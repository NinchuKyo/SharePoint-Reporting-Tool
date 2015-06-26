SharePoint-Reporting-Tool
=========================

An application developed in C# that allows for the generation of queries of lists/libraries of SharePoint sites.

How to Run:
---
- Download the repository onto your computer.
- Double-click the .exe file (SharePointReportsTool.exe).

### When the Program Starts ###
- In the boxed labelled SharePoint URL **without the part including the .aspx**, enter the link of the SharePoint site that you wish to query.
(Note: this will only work for SharePoint sites that you have been granted permissions to).
- For example, http://sharepoint-site-example/default.aspx -> http://sharepoint-site-example/
- Then click on the "List/Library" button to populate for the list/libraries contained on the site.
- Click on a specified list in the box and then proceed to the "Reports" tab

### Running Reports ###
- In the "Reports" tab, you can choose to query the chosen list for items depending on what you need, or to query
for all items in the list, just click "Query All Files".
- If you want to generate your own query, then first select a field you wish to query by, then any comparison
operators against the value of your chosen field.
- Click on the "Create Query" button to generate the query that will be run against the list that you have chosen
previously
- It is possible to modify the query by hand to better suit what you are looking for in the "Generated Query" box
- In the "Query Report Display" box, you can check which fields are to be included/excluded in the generated report
- Once you are finished, you can click "Run Report"

### Report Results ###
- The results will display all the items that are present from the chosen list from before in the "Source and Destination"
tab
- The results can be exported to an Excel file for use by other programs/systems.

Requirements:
---
- .NET 4.5 Framework
- SharePoint 2010 SDK (https://www.microsoft.com/en-us/download/details.aspx?id=12323)

Source Code:
---
In the SharePointReportsTool.cs is where the queries and connections to the SharePoint site
using the client-object-model is done.