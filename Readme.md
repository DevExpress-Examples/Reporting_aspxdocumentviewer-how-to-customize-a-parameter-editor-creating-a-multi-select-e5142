<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597817/13.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5142)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/E5142/Default.aspx) (VB: [Default.aspx](./VB/E5142/Default.aspx))
* **[Default.aspx.cs](./CS/E5142/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/E5142/Default.aspx.vb))**
* [ProductsReport.cs](./CS/E5142/ProductsReport.cs) (VB: [ProductsReport.vb](./VB/E5142/ProductsReport.vb))
<!-- default file list end -->
# ASPxDocumentViewer - How to customize a parameter editor (Creating a multi-select parameter)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5142/)**
<!-- run online end -->


<p><strong>NOTE</strong> Starting with version <strong>15.1</strong> the multi-select parameters for our reporting suite are available out of the box. See the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument9997/Using">Parameters Overview > Using Parameters > Multi-Value Parameters</a> help topic for more details.</p>
<p><br />This example demonstrates how to use a custom editor for the report's parameter to implement a multi-select parameter. The <a href="http://documentation.devexpress.com/#AspNet/CustomDocument16296"><u>ASPxTokenBox</u></a> control is used as a multi-select parameter editor.</p>
<br />
<p>The main idea of this approach is to use a report's parameter to pass a string that contains CategoryIDs separated by the '|' character to the report. Then on the report's <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic"><u>DataSourceDemanded</u></a> event handler the report's DataSource is populated based on the parameter value. <br /> The <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebASPxDocumentViewer_CustomizeParameterEditorstopic"><u>ASPxDocumentViewer.CustomizeParameterEditors</u></a> event handler is used to customize the report's parameter editor: assign a required editor (ASPxEditBase class descendant) to the <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebCustomizeParameterEditorsEventArgs_Editortopic"><u>e.Editor</u></a> property, and specify its Init event. Then use this Init event handler to initialize your custom parameter editor and bind it to the data.</p>
<p><strong>See also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T191944">MVC DocumentViewer extension - Creating a multi-select parameter</a><br /><a href="https://www.devexpress.com/Support/Center/p/T262163">MVC DocumentViewer - How to create a custom CheckedComboBox parameter editor with the "Select All" functionality for a report</a></p>

<br/>


