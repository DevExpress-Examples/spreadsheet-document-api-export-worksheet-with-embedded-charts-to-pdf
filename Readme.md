<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613063/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T269520)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/WorksheetChartsExportPDF/Program.cs) (VB: [Program.vb](./VB/WorksheetChartsExportPDF/Program.vb))
<!-- default file list end -->
# Spreadsheet Document API - Export a Worksheet with Embedded Charts to PDF


To export a worksheet to PDF, use the [Workbook.ExportToPdf](https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.ExportToPdf.overloads) method.

However, to export embedded charts, it is necessary to register the following services:

- **DevExpress.XtraSpreadsheet.Services.Implementation.ChartControllerFactoryService**
- **DevExpress.XtraSpreadsheet.Services.Implementation.ChartImageService**

The **Universal Subscription** or an additional **Office File API Subscription** is required to use this example in production code. Please refer to the [DevExpress Subscription](https://www.devexpress.com/Buy/NET/) page for pricing information.

Starting with **v18.1**, you don't need to register chart rendering services manually when you print and export to PDF documents containing charts. The WinForms version of these services is registered automatically when you create a workbook instance. If you use the Spreadsheet Document API within a WPF application, you can replace these default services with WPF equivalents to ensure application consistency. For details, refer to the [How to use the WPF chart rendering mechanism when printing or exporting a workbook to PDF](https://github.com/DevExpress-Examples/how-to-use-the-wpf-chart-rendering-mechanism-when-printing-or-exporting-a-workbook-to-pdf-t603465) example.
