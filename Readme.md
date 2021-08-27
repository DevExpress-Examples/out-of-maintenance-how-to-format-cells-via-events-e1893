<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1893)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxPivotGrid_FormattingCellsViaEvents/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_FormattingCellsViaEvents/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_FormattingCellsViaEvents/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_FormattingCellsViaEvents/Default.aspx.vb))
<!-- default file list end -->
# How to Format Cells via Events
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1893/)**
<!-- run online end -->


<p>The following example shows how to provide custom text for the ASPxPivotGrid's cells by handling the <a href="https://documentation.devexpress.com/aspnet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid.CustomCellDisplayText.event">ASPxPivotGrid.CustomCellDisplayText</a> event.</p>
<p>In this example, if a grand total value is less than 50 000, ASPxPivotGrid displays the 'Low' value instead. If the value exceeds 100 000, 'High' is displayed; otherwise, 'Middle'.</p>

<br/>


