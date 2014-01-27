namespace SharePointReportsTool
{
    partial class SharePointReportsTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharePointReportsTool));
            this.tabOverallControl = new System.Windows.Forms.TabControl();
            this.tabSourceDestination = new System.Windows.Forms.TabPage();
            this.spContainerSourceDestination = new System.Windows.Forms.SplitContainer();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnGetSPList = new System.Windows.Forms.Button();
            this.lblSelectedList = new System.Windows.Forms.Label();
            this.treeLists = new System.Windows.Forms.TreeView();
            this.txtSPURL = new System.Windows.Forms.TextBox();
            this.lblSharePointURL = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnQueryAll = new System.Windows.Forms.Button();
            this.lblCheckReportDisplay = new System.Windows.Forms.Label();
            this.checkBoxListQueryReport = new System.Windows.Forms.CheckedListBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.btnCreateQuery = new System.Windows.Forms.Button();
            this.generatedQueryHeader = new System.Windows.Forms.Label();
            this.metadataHeader = new System.Windows.Forms.Label();
            this.txtReportQuery = new System.Windows.Forms.TextBox();
            this.lblUnderValue = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblCompare = new System.Windows.Forms.Label();
            this.lblFields = new System.Windows.Forms.Label();
            this.ddFields = new System.Windows.Forms.ComboBox();
            this.ddCompareReport = new System.Windows.Forms.ComboBox();
            this.txtReportValue = new System.Windows.Forms.TextBox();
            this.grdReport = new System.Windows.Forms.DataGridView();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.spContainerLogs = new System.Windows.Forms.SplitContainer();
            this.lblQueryLogsHeader = new System.Windows.Forms.Label();
            this.grdQueryLogs = new System.Windows.Forms.DataGridView();
            this.colGrdQueryLogsQV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrdQueryLogsTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGrdLogsHeader = new System.Windows.Forms.Label();
            this.grdApplicationLogs = new System.Windows.Forms.DataGridView();
            this.colGrdAppLogsMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrdAppLogsTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.saveContentType = new System.Windows.Forms.SaveFileDialog();
            this.tabOverallControl.SuspendLayout();
            this.tabSourceDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerSourceDestination)).BeginInit();
            this.spContainerSourceDestination.Panel1.SuspendLayout();
            this.spContainerSourceDestination.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerLogs)).BeginInit();
            this.spContainerLogs.Panel1.SuspendLayout();
            this.spContainerLogs.Panel2.SuspendLayout();
            this.spContainerLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdApplicationLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOverallControl
            // 
            this.tabOverallControl.Controls.Add(this.tabSourceDestination);
            this.tabOverallControl.Controls.Add(this.tabReports);
            this.tabOverallControl.Controls.Add(this.tabLogs);
            this.tabOverallControl.ImageList = this.imgLstIcons;
            this.tabOverallControl.Location = new System.Drawing.Point(16, 15);
            this.tabOverallControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabOverallControl.Name = "tabOverallControl";
            this.tabOverallControl.SelectedIndex = 0;
            this.tabOverallControl.Size = new System.Drawing.Size(1315, 690);
            this.tabOverallControl.TabIndex = 0;
            // 
            // tabSourceDestination
            // 
            this.tabSourceDestination.Controls.Add(this.spContainerSourceDestination);
            this.tabSourceDestination.ImageIndex = 0;
            this.tabSourceDestination.Location = new System.Drawing.Point(4, 39);
            this.tabSourceDestination.Margin = new System.Windows.Forms.Padding(4);
            this.tabSourceDestination.Name = "tabSourceDestination";
            this.tabSourceDestination.Padding = new System.Windows.Forms.Padding(4);
            this.tabSourceDestination.Size = new System.Drawing.Size(1307, 647);
            this.tabSourceDestination.TabIndex = 0;
            this.tabSourceDestination.Text = "Source and Destination";
            this.tabSourceDestination.UseVisualStyleBackColor = true;
            // 
            // spContainerSourceDestination
            // 
            this.spContainerSourceDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerSourceDestination.Location = new System.Drawing.Point(4, 4);
            this.spContainerSourceDestination.Margin = new System.Windows.Forms.Padding(4);
            this.spContainerSourceDestination.Name = "spContainerSourceDestination";
            // 
            // spContainerSourceDestination.Panel1
            // 
            this.spContainerSourceDestination.Panel1.Controls.Add(this.lblListTitle);
            this.spContainerSourceDestination.Panel1.Controls.Add(this.btnGetSPList);
            this.spContainerSourceDestination.Panel1.Controls.Add(this.lblSelectedList);
            this.spContainerSourceDestination.Panel1.Controls.Add(this.treeLists);
            this.spContainerSourceDestination.Panel1.Controls.Add(this.txtSPURL);
            this.spContainerSourceDestination.Panel1.Controls.Add(this.lblSharePointURL);
            // 
            // spContainerSourceDestination.Panel2
            // 
            this.spContainerSourceDestination.Panel2.BackgroundImage = global::SharePointReportsTool.Properties.Resources.search_queries;
            this.spContainerSourceDestination.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.spContainerSourceDestination.Size = new System.Drawing.Size(1299, 639);
            this.spContainerSourceDestination.SplitterDistance = 495;
            this.spContainerSourceDestination.SplitterWidth = 5;
            this.spContainerSourceDestination.TabIndex = 0;
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitle.Location = new System.Drawing.Point(15, 59);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(132, 17);
            this.lblListTitle.TabIndex = 11;
            this.lblListTitle.Text = "List (Unselected)";
            // 
            // btnGetSPList
            // 
            this.btnGetSPList.Image = ((System.Drawing.Image)(resources.GetObject("btnGetSPList.Image")));
            this.btnGetSPList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetSPList.Location = new System.Drawing.Point(251, 31);
            this.btnGetSPList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetSPList.Name = "btnGetSPList";
            this.btnGetSPList.Size = new System.Drawing.Size(179, 44);
            this.btnGetSPList.TabIndex = 10;
            this.btnGetSPList.Text = "List / Library";
            this.btnGetSPList.UseVisualStyleBackColor = true;
            this.btnGetSPList.Click += new System.EventHandler(this.btnGetSPList_Click);
            // 
            // lblSelectedList
            // 
            this.lblSelectedList.AutoSize = true;
            this.lblSelectedList.Location = new System.Drawing.Point(3, 31);
            this.lblSelectedList.Name = "lblSelectedList";
            this.lblSelectedList.Size = new System.Drawing.Size(93, 17);
            this.lblSelectedList.TabIndex = 8;
            this.lblSelectedList.Text = "Selected List:";
            // 
            // treeLists
            // 
            this.treeLists.Location = new System.Drawing.Point(3, 80);
            this.treeLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeLists.Name = "treeLists";
            this.treeLists.Size = new System.Drawing.Size(425, 547);
            this.treeLists.TabIndex = 5;
            this.treeLists.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeLists_AfterSelect);
            // 
            // txtSPURL
            // 
            this.txtSPURL.Location = new System.Drawing.Point(124, 4);
            this.txtSPURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSPURL.Name = "txtSPURL";
            this.txtSPURL.Size = new System.Drawing.Size(304, 22);
            this.txtSPURL.TabIndex = 7;
            // 
            // lblSharePointURL
            // 
            this.lblSharePointURL.AutoSize = true;
            this.lblSharePointURL.Location = new System.Drawing.Point(3, 7);
            this.lblSharePointURL.Name = "lblSharePointURL";
            this.lblSharePointURL.Size = new System.Drawing.Size(114, 17);
            this.lblSharePointURL.TabIndex = 6;
            this.lblSharePointURL.Text = "SharePoint URL:";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnQueryAll);
            this.tabReports.Controls.Add(this.lblCheckReportDisplay);
            this.tabReports.Controls.Add(this.checkBoxListQueryReport);
            this.tabReports.Controls.Add(this.btnExportToExcel);
            this.tabReports.Controls.Add(this.btnRunReport);
            this.tabReports.Controls.Add(this.btnCreateQuery);
            this.tabReports.Controls.Add(this.generatedQueryHeader);
            this.tabReports.Controls.Add(this.metadataHeader);
            this.tabReports.Controls.Add(this.txtReportQuery);
            this.tabReports.Controls.Add(this.lblUnderValue);
            this.tabReports.Controls.Add(this.lblValue);
            this.tabReports.Controls.Add(this.lblCompare);
            this.tabReports.Controls.Add(this.lblFields);
            this.tabReports.Controls.Add(this.ddFields);
            this.tabReports.Controls.Add(this.ddCompareReport);
            this.tabReports.Controls.Add(this.txtReportValue);
            this.tabReports.Controls.Add(this.grdReport);
            this.tabReports.ImageIndex = 5;
            this.tabReports.Location = new System.Drawing.Point(4, 39);
            this.tabReports.Margin = new System.Windows.Forms.Padding(4);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(4);
            this.tabReports.Size = new System.Drawing.Size(1307, 647);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnQueryAll
            // 
            this.btnQueryAll.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryAll.Image")));
            this.btnQueryAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueryAll.Location = new System.Drawing.Point(1055, 142);
            this.btnQueryAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQueryAll.Name = "btnQueryAll";
            this.btnQueryAll.Size = new System.Drawing.Size(240, 54);
            this.btnQueryAll.TabIndex = 26;
            this.btnQueryAll.Text = "Query All Files";
            this.btnQueryAll.UseVisualStyleBackColor = true;
            this.btnQueryAll.Click += new System.EventHandler(this.btnQueryAll_Click);
            // 
            // lblCheckReportDisplay
            // 
            this.lblCheckReportDisplay.AutoSize = true;
            this.lblCheckReportDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckReportDisplay.Location = new System.Drawing.Point(900, 202);
            this.lblCheckReportDisplay.Name = "lblCheckReportDisplay";
            this.lblCheckReportDisplay.Size = new System.Drawing.Size(175, 20);
            this.lblCheckReportDisplay.TabIndex = 25;
            this.lblCheckReportDisplay.Text = "Query Report Display:";
            // 
            // checkBoxListQueryReport
            // 
            this.checkBoxListQueryReport.CheckOnClick = true;
            this.checkBoxListQueryReport.FormattingEnabled = true;
            this.checkBoxListQueryReport.Items.AddRange(new object[] {
            "FileName"});
            this.checkBoxListQueryReport.Location = new System.Drawing.Point(901, 239);
            this.checkBoxListQueryReport.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxListQueryReport.Name = "checkBoxListQueryReport";
            this.checkBoxListQueryReport.Size = new System.Drawing.Size(377, 378);
            this.checkBoxListQueryReport.TabIndex = 24;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExportToExcel.Location = new System.Drawing.Point(19, 166);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(185, 28);
            this.btnExportToExcel.TabIndex = 21;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnCreateExcelFile_Click);
            // 
            // btnRunReport
            // 
            this.btnRunReport.Image = ((System.Drawing.Image)(resources.GetObject("btnRunReport.Image")));
            this.btnRunReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunReport.Location = new System.Drawing.Point(1055, 82);
            this.btnRunReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(240, 54);
            this.btnRunReport.TabIndex = 20;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // btnCreateQuery
            // 
            this.btnCreateQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateQuery.Image")));
            this.btnCreateQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQuery.Location = new System.Drawing.Point(1055, 23);
            this.btnCreateQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateQuery.Name = "btnCreateQuery";
            this.btnCreateQuery.Size = new System.Drawing.Size(240, 54);
            this.btnCreateQuery.TabIndex = 19;
            this.btnCreateQuery.Text = "Create Query";
            this.btnCreateQuery.UseVisualStyleBackColor = true;
            this.btnCreateQuery.Click += new System.EventHandler(this.btnCreateQuery_Click);
            // 
            // generatedQueryHeader
            // 
            this.generatedQueryHeader.AutoSize = true;
            this.generatedQueryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedQueryHeader.Location = new System.Drawing.Point(576, 17);
            this.generatedQueryHeader.Name = "generatedQueryHeader";
            this.generatedQueryHeader.Size = new System.Drawing.Size(142, 20);
            this.generatedQueryHeader.TabIndex = 18;
            this.generatedQueryHeader.Text = "Generated Query:";
            // 
            // metadataHeader
            // 
            this.metadataHeader.AutoSize = true;
            this.metadataHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metadataHeader.Location = new System.Drawing.Point(15, 17);
            this.metadataHeader.Name = "metadataHeader";
            this.metadataHeader.Size = new System.Drawing.Size(197, 20);
            this.metadataHeader.TabIndex = 17;
            this.metadataHeader.Text = "Metadata Search Values:";
            // 
            // txtReportQuery
            // 
            this.txtReportQuery.Location = new System.Drawing.Point(580, 39);
            this.txtReportQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReportQuery.Multiline = true;
            this.txtReportQuery.Name = "txtReportQuery";
            this.txtReportQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReportQuery.Size = new System.Drawing.Size(468, 154);
            this.txtReportQuery.TabIndex = 7;
            // 
            // lblUnderValue
            // 
            this.lblUnderValue.AutoSize = true;
            this.lblUnderValue.Location = new System.Drawing.Point(15, 130);
            this.lblUnderValue.Name = "lblUnderValue";
            this.lblUnderValue.Size = new System.Drawing.Size(233, 17);
            this.lblUnderValue.TabIndex = 16;
            this.lblUnderValue.Text = "(Format for Time is YYYY-MM-DDT)";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(15, 108);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(48, 17);
            this.lblValue.TabIndex = 15;
            this.lblValue.Text = "Value:";
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(15, 80);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(69, 17);
            this.lblCompare.TabIndex = 14;
            this.lblCompare.Text = "Compare:";
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(15, 49);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(42, 17);
            this.lblFields.TabIndex = 13;
            this.lblFields.Text = "Field:";
            // 
            // ddFields
            // 
            this.ddFields.FormattingEnabled = true;
            this.ddFields.Location = new System.Drawing.Point(89, 39);
            this.ddFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddFields.Name = "ddFields";
            this.ddFields.Size = new System.Drawing.Size(465, 24);
            this.ddFields.TabIndex = 12;
            // 
            // ddCompareReport
            // 
            this.ddCompareReport.FormattingEnabled = true;
            this.ddCompareReport.Items.AddRange(new object[] {
            "Eq",
            "Gt",
            "Lt",
            "Geq",
            "Leq",
            "Neq",
            "Contains",
            "IsNull",
            "IsNotNull",
            "BeginsWith"});
            this.ddCompareReport.Location = new System.Drawing.Point(89, 70);
            this.ddCompareReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddCompareReport.Name = "ddCompareReport";
            this.ddCompareReport.Size = new System.Drawing.Size(465, 24);
            this.ddCompareReport.TabIndex = 11;
            // 
            // txtReportValue
            // 
            this.txtReportValue.Location = new System.Drawing.Point(89, 100);
            this.txtReportValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReportValue.Name = "txtReportValue";
            this.txtReportValue.Size = new System.Drawing.Size(465, 22);
            this.txtReportValue.TabIndex = 10;
            // 
            // grdReport
            // 
            this.grdReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReport.Location = new System.Drawing.Point(7, 202);
            this.grdReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdReport.Name = "grdReport";
            this.grdReport.ReadOnly = true;
            this.grdReport.RowTemplate.Height = 24;
            this.grdReport.Size = new System.Drawing.Size(888, 430);
            this.grdReport.TabIndex = 9;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.spContainerLogs);
            this.tabLogs.ImageIndex = 6;
            this.tabLogs.Location = new System.Drawing.Point(4, 39);
            this.tabLogs.Margin = new System.Windows.Forms.Padding(4);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(4);
            this.tabLogs.Size = new System.Drawing.Size(1307, 647);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // spContainerLogs
            // 
            this.spContainerLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerLogs.Location = new System.Drawing.Point(4, 4);
            this.spContainerLogs.Margin = new System.Windows.Forms.Padding(4);
            this.spContainerLogs.Name = "spContainerLogs";
            // 
            // spContainerLogs.Panel1
            // 
            this.spContainerLogs.Panel1.Controls.Add(this.lblQueryLogsHeader);
            this.spContainerLogs.Panel1.Controls.Add(this.grdQueryLogs);
            // 
            // spContainerLogs.Panel2
            // 
            this.spContainerLogs.Panel2.Controls.Add(this.lblGrdLogsHeader);
            this.spContainerLogs.Panel2.Controls.Add(this.grdApplicationLogs);
            this.spContainerLogs.Size = new System.Drawing.Size(1299, 639);
            this.spContainerLogs.SplitterDistance = 433;
            this.spContainerLogs.SplitterWidth = 5;
            this.spContainerLogs.TabIndex = 0;
            // 
            // lblQueryLogsHeader
            // 
            this.lblQueryLogsHeader.AutoSize = true;
            this.lblQueryLogsHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblQueryLogsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQueryLogsHeader.Location = new System.Drawing.Point(4, 4);
            this.lblQueryLogsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueryLogsHeader.Name = "lblQueryLogsHeader";
            this.lblQueryLogsHeader.Size = new System.Drawing.Size(194, 20);
            this.lblQueryLogsHeader.TabIndex = 6;
            this.lblQueryLogsHeader.Text = "Previous Queried Values";
            // 
            // grdQueryLogs
            // 
            this.grdQueryLogs.AllowUserToAddRows = false;
            this.grdQueryLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueryLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrdQueryLogsQV,
            this.colGrdQueryLogsTime});
            this.grdQueryLogs.Location = new System.Drawing.Point(4, 27);
            this.grdQueryLogs.Margin = new System.Windows.Forms.Padding(4);
            this.grdQueryLogs.Name = "grdQueryLogs";
            this.grdQueryLogs.ReadOnly = true;
            this.grdQueryLogs.Size = new System.Drawing.Size(424, 599);
            this.grdQueryLogs.TabIndex = 0;
            // 
            // colGrdQueryLogsQV
            // 
            this.colGrdQueryLogsQV.HeaderText = "Queried Value";
            this.colGrdQueryLogsQV.Name = "colGrdQueryLogsQV";
            this.colGrdQueryLogsQV.ReadOnly = true;
            this.colGrdQueryLogsQV.Width = 175;
            // 
            // colGrdQueryLogsTime
            // 
            this.colGrdQueryLogsTime.HeaderText = "Time";
            this.colGrdQueryLogsTime.Name = "colGrdQueryLogsTime";
            this.colGrdQueryLogsTime.ReadOnly = true;
            // 
            // lblGrdLogsHeader
            // 
            this.lblGrdLogsHeader.AutoSize = true;
            this.lblGrdLogsHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblGrdLogsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGrdLogsHeader.Location = new System.Drawing.Point(4, 4);
            this.lblGrdLogsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrdLogsHeader.Name = "lblGrdLogsHeader";
            this.lblGrdLogsHeader.Size = new System.Drawing.Size(200, 20);
            this.lblGrdLogsHeader.TabIndex = 5;
            this.lblGrdLogsHeader.Text = "Application Process Logs";
            // 
            // grdApplicationLogs
            // 
            this.grdApplicationLogs.BackgroundColor = System.Drawing.Color.White;
            this.grdApplicationLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdApplicationLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrdAppLogsMessage,
            this.colGrdAppLogsTime});
            this.grdApplicationLogs.Location = new System.Drawing.Point(0, 27);
            this.grdApplicationLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdApplicationLogs.Name = "grdApplicationLogs";
            this.grdApplicationLogs.ReadOnly = true;
            this.grdApplicationLogs.RowTemplate.Height = 24;
            this.grdApplicationLogs.Size = new System.Drawing.Size(856, 603);
            this.grdApplicationLogs.TabIndex = 3;
            // 
            // colGrdAppLogsMessage
            // 
            this.colGrdAppLogsMessage.HeaderText = "Message";
            this.colGrdAppLogsMessage.Name = "colGrdAppLogsMessage";
            this.colGrdAppLogsMessage.ReadOnly = true;
            this.colGrdAppLogsMessage.Width = 497;
            // 
            // colGrdAppLogsTime
            // 
            this.colGrdAppLogsTime.HeaderText = "Time";
            this.colGrdAppLogsTime.Name = "colGrdAppLogsTime";
            this.colGrdAppLogsTime.ReadOnly = true;
            this.colGrdAppLogsTime.Width = 101;
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "html.png");
            this.imgLstIcons.Images.SetKeyName(1, "folder_cyan.png");
            this.imgLstIcons.Images.SetKeyName(2, "folder_html.png");
            this.imgLstIcons.Images.SetKeyName(3, "folder_txt.png");
            this.imgLstIcons.Images.SetKeyName(4, "mo_unmount.png");
            this.imgLstIcons.Images.SetKeyName(5, "kivio_flw.png");
            this.imgLstIcons.Images.SetKeyName(6, "kaddressbook.png");
            // 
            // saveContentType
            // 
            this.saveContentType.FileName = "SharePointSiteExport";
            this.saveContentType.Filter = ".xls files (*.xls)|*.xlsx|All files (*.*)|*.*\";";
            // 
            // SharePointReportsTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 720);
            this.Controls.Add(this.tabOverallControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SharePointReportsTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharePoint Reporting Tool v1.1";
            this.tabOverallControl.ResumeLayout(false);
            this.tabSourceDestination.ResumeLayout(false);
            this.spContainerSourceDestination.Panel1.ResumeLayout(false);
            this.spContainerSourceDestination.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerSourceDestination)).EndInit();
            this.spContainerSourceDestination.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.spContainerLogs.Panel1.ResumeLayout(false);
            this.spContainerLogs.Panel1.PerformLayout();
            this.spContainerLogs.Panel2.ResumeLayout(false);
            this.spContainerLogs.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerLogs)).EndInit();
            this.spContainerLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdApplicationLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOverallControl;
        private System.Windows.Forms.TabPage tabSourceDestination;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.SplitContainer spContainerSourceDestination;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnGetSPList;
        private System.Windows.Forms.Label lblSelectedList;
        private System.Windows.Forms.TreeView treeLists;
        private System.Windows.Forms.TextBox txtSPURL;
        private System.Windows.Forms.Label lblSharePointURL;
        private System.Windows.Forms.Label lblUnderValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.ComboBox ddFields;
        private System.Windows.Forms.ComboBox ddCompareReport;
        private System.Windows.Forms.TextBox txtReportValue;
        private System.Windows.Forms.DataGridView grdReport;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.Button btnCreateQuery;
        private System.Windows.Forms.Label generatedQueryHeader;
        private System.Windows.Forms.Label metadataHeader;
        private System.Windows.Forms.TextBox txtReportQuery;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.SplitContainer spContainerLogs;
        private System.Windows.Forms.Label lblQueryLogsHeader;
        private System.Windows.Forms.DataGridView grdQueryLogs;
        private System.Windows.Forms.Label lblGrdLogsHeader;
        private System.Windows.Forms.DataGridView grdApplicationLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrdAppLogsMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrdAppLogsTime;
        private System.Windows.Forms.Label lblCheckReportDisplay;
        private System.Windows.Forms.CheckedListBox checkBoxListQueryReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrdQueryLogsQV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrdQueryLogsTime;
        private System.Windows.Forms.Button btnQueryAll;
        private System.Windows.Forms.SaveFileDialog saveContentType;
    }
}

