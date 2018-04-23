# How to export a worksheet with embedded charts to PDF


<p>To export a worksheet to PDF, use the <a href="http://help.devexpress.com/#DocumentServer/DevExpressSpreadsheetWorkbook_ExportToPdftopic">Workbook.ExportToPdf</a> method.</p>
<p>However, to export embedded <a href="http://help.devexpress.com/#WindowsForms/CustomDocument16453">charts</a>, it is necessary to register the following services:</p>
<strong>DevExpress.XtraSpreadsheet.Services.Implementation.ChartControllerFactoryService</strong> <br><strong>DevExpress.XtraSpreadsheet.Services.Implementation.ChartImageService<br><br><br></strong>The<strong> Universal Subscription</strong> or an additional <strong>Document Server Subscription</strong> is required to use this example in production code. Please refer to the <a href="http://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information.

<br/>


