#region #namespaces
using DevExpress.Spreadsheet;
using DevExpress.XtraPrinting;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;
#endregion #namespaces

namespace WorksheetChartsExportPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #ExportToPDF
            Workbook workbook = new Workbook();

            //Register required services. 
            workbook.AddService(typeof(IChartControllerFactoryService), new ChartControllerFactoryService());
            workbook.AddService(typeof(IChartImageService), new ChartImageService());

            workbook.LoadDocument("testDocument.xlsx");
            workbook.ExportToPdf("resultingDocument.pdf");
            #endregion #ExportToPDF
            System.Diagnostics.Process.Start("resultingDocument.pdf");
        }
    }
}
