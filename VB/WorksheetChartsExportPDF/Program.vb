#Region "#namespaces"
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation
#End Region ' #namespaces

Namespace WorksheetChartsExportPDF
    Friend Class Program
        Shared Sub Main(ByVal args() As String)
'            #Region "#ExportToPDF"
            Dim workbook As New Workbook()

            'Register required services. 
            workbook.AddService(GetType(IChartControllerFactoryService), New ChartControllerFactoryService())
            workbook.AddService(GetType(IChartImageService), New ChartImageService())

            workbook.LoadDocument("testDocument.xlsx")
            workbook.ExportToPdf("resultingDocument.pdf")
'            #End Region ' #ExportToPDF
            System.Diagnostics.Process.Start("resultingDocument.pdf")
        End Sub
    End Class
End Namespace
