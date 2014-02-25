using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client;
using Excel = Microsoft.Office.Interop.Excel;

namespace SharePointReportsTool
{
    public partial class SharePointReportsTool : System.Windows.Forms.Form
    {
        //use
        private String originalQuery;

        public SharePointReportsTool()
        {
            InitializeComponent();
        }

        //////////////////////////////
        //BUTTON METHODS START HERE//
        ////////////////////////////

        /// <summary>
        /// "List / Library" button
        /// </summary>
        /// <dependencies>
        /// Microsoft.SharePoint.Client.Runtime.dll
        /// </dependencies>
        [STAThread]
        private void btnGetSPList_Click(object sender, EventArgs e)
        {

            //in case if user enters an invalid text for the SP URL
            try
            {
                //clears the list when loading a new SharePoint URL
                treeLists.Nodes.Clear();

                //loading bar
                //LoadingList.ShowSplashScreen();
                LoadingSplashScreen.startSplashScreen("Loading SharePoint lists...");

                //retrieves link from text box
                using (ClientContext ctx = new ClientContext(txtSPURL.Text))
                {
                    //establishes text as web link
                    Web oWeb = ctx.Web;

                    // fill with actual credentials
                    ctx.Credentials = new NetworkCredential();
                    ListCollection oLists = oWeb.Lists;

                    //load website
                    ctx.Load(oWeb);
                    ctx.Load(oLists);

                    //obtain data from website
                    ctx.ExecuteQuery();

                    //for each list on the SharePoint site, put it in
                    //in the treeList below the link
                    foreach (List olist in oLists)
                    {
                        if (!olist.Hidden)
                        {
                            object item = new object();
                            item = olist.Title;
                            TreeNode olistNode = new TreeNode(olist.Title);

                            treeLists.Nodes.Add(olistNode);
                        }
                    }

                    //end loading bar
                    //something.stopLoadingBar();
                    LoadingSplashScreen.stopSplashScreen();

                    //attaches '/' to the end of the text if not there
                    if (!txtSPURL.Text.EndsWith("/"))
                    {
                        txtSPURL.Text = txtSPURL.Text + "/";
                    }

                }//end "using" clause

            }//end try

            catch (Exception ex)
            {
                //end loading bar
                //something.stopLoadingBar();
                LoadingSplashScreen.stopSplashScreen();
                MessageBox.Show("SharePoint URL is not valid.");
                LogError(ex);
            }

        }//end btnGetSPList_Click

        /// <summary>
        /// "Create Query" button
        /// </summary>
        private void btnCreateQuery_Click(object sender, EventArgs e)
        {
            //make sure there are values in the "Fields" and "Compare" ddBox
            if (ddFields.SelectedItem != null && ddCompareReport.SelectedItem != null)
            {
                ComboboxItem newItem = (ComboboxItem)ddFields.SelectedItem;


                String Text = newItem.Text;
                String Value = newItem.Value.ToString();
                String CompareSyntect = ddCompareReport.SelectedItem.ToString();

                if (CompareSyntect.Equals("IsNull") || CompareSyntect.Equals("IsNotNull"))
                {
                    txtReportQuery.Text = @"<View Scope='Recursive'>
                                            <Query>
                                                <Where>
                                                   <" + CompareSyntect + "> " + @" 
                                                        <FieldRef Name='" + Text + "' />" + @"
                                                    </" + CompareSyntect + ">" + @"
                                                </Where>
                                            </Query>
                                            </View>";
                }
                else
                {
                    txtReportQuery.Text = @"<View Scope='Recursive'>
                                            <Query>
                                                <Where>
                                                   <" + CompareSyntect + "> " + @" 
                                                        <FieldRef Name='" + Text + "' />" + @"
                                                        <Value Type='" + Value + "'>" + txtReportValue.Text + @"</Value>
                                                    </" + CompareSyntect + ">" + @"
                                                </Where>
                                            </Query>
                                            </View>";
                }

                originalQuery = txtReportQuery.Text;


            }
        }//end btnCreateQuery_Click

        /// <summary>
        /// "Run Report" button
        /// </summary>
        private void btnRunReport_Click(object sender, EventArgs e)
        {
            String itemField;

            //check if query box was manually modified
            Boolean isModified = false;
            if (!originalQuery.Equals(txtReportQuery.Text))
                isModified = true;


            try
            {
                //start loading screen
                LoadingSplashScreen.startSplashScreen("Gathering items based on query...");

                ComboboxItem newItem = (ComboboxItem)ddFields.SelectedItem;
                String Text = newItem.Text;
                DataTable tblResult = new DataTable();
                    
                /*
                //create table columns with file name, queried value, and location
                if (!Text.Equals("ID"))
                    tblResult.Columns.Add(new DataColumn("ID"));

                tblResult.Columns.Add(new DataColumn("Name"));
                tblResult.Columns.Add(new DataColumn(Text));
                tblResult.Columns.Add(new DataColumn("URL"));
                */

                //create table columns with whatever was checked in the checkbox display
                foreach (var itemCheckBox in checkBoxListQueryReport.CheckedItems)
                {
                    itemField = itemCheckBox.ToString();
                    tblResult.Columns.Add(new DataColumn(itemField));
                }

                if (ddCompareReport.SelectedItem.ToString().Equals("IsNull") ||  
                    ddCompareReport.SelectedItem.ToString().Equals("IsNotNull") ||
                    txtReportValue.Text.Length > 0)
                {
                    using (ClientContext clientContext = new ClientContext(txtSPURL.Text))
                    {

                        clientContext.Credentials = new NetworkCredential();

                        List oList = clientContext.Web.Lists.GetByTitle(lblListTitle.Text);
                        String Title = String.Empty;
                        String Query = String.Empty;

                        //create query
                        Query = txtReportQuery.Text;
                        CamlQuery camlQuery = new CamlQuery();
                        camlQuery.ViewXml = Query;
                        ListItemCollection listItems = oList.GetItems(camlQuery);
                        clientContext.Load(oList);
                        clientContext.Load(listItems);
                        clientContext.ExecuteQuery();

                        foreach (var item in listItems)
                        {
                            DataRow newRow = tblResult.NewRow();

                            foreach (var itemCheckBox in checkBoxListQueryReport.CheckedItems)
                            {
                                itemField = itemCheckBox.ToString();

                                /*
                                  Situations where metadata field will return
                                  Microsoft.SharePoint.Client.FieldUserValue
                                */
                                switch (itemField)
                                {
                                    case "FileName":
                                        newRow[itemCheckBox.ToString()] = item.FieldValues["FileLeafRef"];
                                        break;
                                    case "_dlc_DocIdUrl":
                                        FieldUrlValue newUrl = (FieldUrlValue)item.FieldValues["_dlc_DocIdUrl"];
                                        newRow[itemCheckBox.ToString()] = newUrl.Url;
                                        break;
                                    case "Author":
                                        FieldUserValue newAuthor = (FieldUserValue) item.FieldValues["Author"];
                                        newRow[itemCheckBox.ToString()] = newAuthor.LookupValue.ToString();
                                        break;
                                    case "Editor":
                                        FieldUserValue newEditor = (FieldUserValue) item.FieldValues["Editor"];
                                        newRow[itemCheckBox.ToString()] = newEditor.LookupValue.ToString();
                                        break;
                                    default:
                                        newRow[itemCheckBox.ToString()] = item.FieldValues[itemCheckBox.ToString()];
                                        break;

                                }

                            }


                            /*
                            if (!Text.Equals("ID"))
                                newRow["ID"] = item.FieldValues["ID"];


                            newRow["Name"] = item.FieldValues["Title"];
                            newRow["URL"] = item.FieldValues["FileRef"];
                            newRow[Text] = item.FieldValues[Text];
                             */

                            tblResult.Rows.Add(newRow);
                        }

                    }
                    grdReport.DataSource = tblResult;

                    //stop loading screen
                    LoadingSplashScreen.stopBlockLoadingBar();

                    if (isModified)
                    {
                        reportQueryLog("Modified Query Field");
                    }
                    else
                    {
                        reportQueryLog(Text);
                    }
                    MessageBox.Show("Information Gathering Completed");

                }
                else
                {
                    LoadingSplashScreen.stopBlockLoadingBar();
                    MessageBox.Show("Please fill in the query");
                }

            }
            catch (Exception expContentType)
            {
                LoadingSplashScreen.stopSplashScreen();
                LogMigrationError(expContentType, "Fill In Information by ID");
            }

        }//end btnRunReport_click

        private void btnQueryAll_Click(object sender, EventArgs e)
        {
            String itemField;
            try
            {
                //start loading screen
                LoadingSplashScreen.startSplashScreen("Gathering items based on query...");
                DataTable tblResult = new DataTable();

                //create table columns with whatever was checked in the checkbox display
                foreach (var itemCheckBox in checkBoxListQueryReport.CheckedItems)
                {
                    itemField = itemCheckBox.ToString();
                    tblResult.Columns.Add(new DataColumn(itemField));
                }

                    using (ClientContext clientContext = new ClientContext(txtSPURL.Text))
                    {
                        // fill with actual credentials
                        clientContext.Credentials = new NetworkCredential();

                        List oList = clientContext.Web.Lists.GetByTitle(lblListTitle.Text);
                        String Title = String.Empty;
                        String Query = String.Empty;

                        //create query
                        Query = @"<View Scope='Recursive'>
                                            <Query>
                                                <Where>
 
                                                </Where>
                                            </Query>
                                            </View>";

                        CamlQuery camlQuery = new CamlQuery();
                        camlQuery.ViewXml = Query;
                        ListItemCollection listItems = oList.GetItems(camlQuery);
                        clientContext.Load(oList);
                        clientContext.Load(listItems);
                        clientContext.ExecuteQuery();

                        foreach (var item in listItems)
                        {
                            DataRow newRow = tblResult.NewRow();

                            foreach (var itemCheckBox in checkBoxListQueryReport.CheckedItems)
                            {
                                itemField = itemCheckBox.ToString();

                                /*
                                  Situations where metadata field will return
                                  Microsoft.SharePoint.Client.FieldUserValue
                                */
                                switch (itemField)
                                {
                                    case "FileName":
                                        newRow[itemCheckBox.ToString()] = item.FieldValues["FileLeafRef"];
                                        break;
                                    case "_dlc_DocIdUrl":
                                        FieldUrlValue newUrl = (FieldUrlValue)item.FieldValues["_dlc_DocIdUrl"];
                                        newRow[itemCheckBox.ToString()] = newUrl.Url;
                                        break;
                                    case "Author":
                                        FieldUserValue newAuthor = (FieldUserValue)item.FieldValues["Author"];
                                        newRow[itemCheckBox.ToString()] = newAuthor.LookupValue.ToString();
                                        break;
                                    case "Editor":
                                        FieldUserValue newEditor = (FieldUserValue)item.FieldValues["Editor"];
                                        newRow[itemCheckBox.ToString()] = newEditor.LookupValue.ToString();
                                        break;
                                    default:
                                        newRow[itemCheckBox.ToString()] = item.FieldValues[itemCheckBox.ToString()];
                                        break;

                                }

                            }

                            tblResult.Rows.Add(newRow);
                        }

                    }
                    grdReport.DataSource = tblResult;

                    //stop loading screen
                    LoadingSplashScreen.stopBlockLoadingBar();
                    MessageBox.Show("Information Gathering Completed");

            }
            catch (Exception expContentType)
            {
                LoadingSplashScreen.stopSplashScreen();
                LogMigrationError(expContentType, "Fill In Information by ID");
            }
        }


        /// <summary>
        /// "Export to Excel" button, uses textbox to left to determine fileName
        /// </summary>
        private void btnCreateExcelFile_Click(object sender, EventArgs e)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

                //Content Type
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 30;
                Microsoft.Office.Interop.Excel.Workbook wb = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet wsContentType = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;
                // storing header part in Excel
                for (int i = 1; i < grdReport.Columns.Count + 1; i++)
                {
                    wsContentType.Cells[1, i] = grdReport.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet
                for (int i = 0; i < grdReport.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grdReport.Columns.Count; j++)
                    {
                        wsContentType.Cells[i + 2, j + 1] = grdReport.Rows[i].Cells[j].Value.ToString();
                    }
                }

                if (saveContentType.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveContentType.FileName);
                    ExcelApp.ActiveWorkbook.Saved = true;
                }
                ExcelApp.Quit();

            }
            catch (Exception exp)
            {
                LogError(exp);
                MessageBox.Show("Failed to create Excel file");
            }

        }

        //////////////////////////////
        //BUTTON METHODS END HERE////
        ////////////////////////////

        ////////////////////////////
        //SUPPORTING METHODS START//
        ////////////////////////////

        /// <summary>
        /// Occurs when you click a file in the treeList window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeLists_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String fieldName = String.Empty;

            lblListTitle.Text = treeLists.SelectedNode.Text;
            try
            {
                MessageBox.Show("We will load all the metadata for you, It shouldn't be long");

                //loading screen
                LoadingSplashScreen.startSplashScreen("Loading metadata...");

                DataTable tblResult = new DataTable();
                tblResult.Columns.Add(new DataColumn("Field"));
                tblResult.Columns.Add(new DataColumn("Value"));

                using (ClientContext ctx = new ClientContext(txtSPURL.Text))
                {
                    Web oWeb = ctx.Web;

                    // fill with actual credentials 
                    ctx.Credentials = new NetworkCredential();
                    String ColName = String.Empty;

                    List theList = ctx.Web.Lists.GetByTitle(treeLists.SelectedNode.Text);
                    FieldCollection oCllection = theList.Fields;
                    ctx.Load(theList);
                    ctx.Load(oCllection);
                    ctx.ExecuteQuery();
                    try
                    {
                        ddFields.Items.Clear();

                        foreach (Field oField in oCllection)
                        {
                            if (!oField.InternalName.Equals("ContentType"))
                            {
                                DataRow newRow = tblResult.NewRow();
                                newRow["Field"] = oField.InternalName;
                                
                                ComboboxItem item = new ComboboxItem();
                                item.Text = oField.InternalName;
                                item.Value = oField.TypeAsString;
                                

                                ddFields.Items.Add(item);
                                tblResult.Rows.Add(newRow);
                                checkBoxListQueryReport.Items.Add(item);

                            }

                        }


                    }
                    catch (Exception expContentType)
                    {
                        LogMigrationError(expContentType, "Tree View After Select");
                    }

                }
                //grdMetadata.DataSource = tblResult;

                //end loading screen
                LoadingSplashScreen.stopSplashScreen();

                MessageBox.Show("Metadata has been loaded, you can use Reports Tab.");
            }
            catch (Exception exp)
            {
                LogMigrationError(exp, "Load List Information");
            }
        }//end treeLists_AfterSelect


        //////////////////////////////
        //Simple supporting methods//
        ////////////////////////////

        /// <summary>
        /// Free object
        /// </summary>
        /// <param name="sender"></param>
        private void releaseObject(object sender)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(sender);
                sender = null;
            }
            catch (Exception ex)
            {
                sender = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void reportQueryLog(String query)
        {
            grdQueryLogs.Rows.Add(query, DateTime.Now.ToShortTimeString());
        }

        /// <summary>
        /// Outputs the error log
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="FileName"></param>
        private void LogMigrationError(Exception ex, String FileName)
        {
            grdApplicationLogs.Rows.Add(FileName + " " + ex.Message, DateTime.Now.ToShortTimeString());
        }

        /// <summary>
        /// Outputs the user history of actions and any errors that have
        /// occured while the user has been using this application to the
        /// log table display.
        /// </summary>
        /// <param name="e">Is the exception caught that caused the error
        /// or log report.</param>
        private void LogError(Exception ex)
        {
            grdApplicationLogs.Rows.Add(ex.Message, DateTime.Now.ToShortTimeString());
        }//end LogError

        /// <summary>
        /// Checks the treeList if the node exists or not
        /// </summary>
        /// <returns>Boolean true if treeList exists, else false</returns>
        private bool CheckForSelectedList()
        {
            bool result = false;
            if (treeLists.Nodes.Count > 0)
            {
                if (treeLists.SelectedNode != null)
                {
                    return true;
                }
            }

            return result;
        }

        ////////////////////////////
        //SUPPORTING METHODS END////
        ////////////////////////////
    }


}
