<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613063/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T269520)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Spreadsheet Document API - Export a Worksheet with Embedded Charts to PDF

To export a worksheet to PDF, use the [Workbook.ExportToPdf](https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.ExportToPdf.overloads) method.

However, to export embedded charts, it is necessary to register the following services:

- **DevExpress.XtraSpreadsheet.Services.Implementation.ChartControllerFactoryService**
- **DevExpress.XtraSpreadsheet.Services.Implementation.ChartImageService**

The **Universal Subscription** or an additional **Office File API Subscription** is required to use this example in production code. Please refer to the [DevExpress Subscription](https://www.devexpress.com/Buy/NET/) page for pricing information.

Starting with **v18.1**, you don't need to register chart rendering services manually when you print and export documents containing charts to PDF. The WinForms version of these services is registered automatically when you create a workbook instance. 

## Files to Review

* [Program.cs](./CS/WorksheetChartsExportPDF/Program.cs) (VB: [Program.vb](./VB/WorksheetChartsExportPDF/Program.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=spreadsheet-document-api-export-worksheet-with-embedded-charts-to-pdf&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=spreadsheet-document-api-export-worksheet-with-embedded-charts-to-pdf&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
