Public Class frmReportesHoras
    Public idPlanilla As Integer
    Public cedula As Integer
    Public reporte As Integer
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        If reporte = 0 Then
            cargarReporteEmpleados()
        ElseIf reporte = 1 Then
            cargarReportePlanillas()
        End If
    End Sub
    Sub cargarReportePlanillas()
        Dim objReportePlanilla As New reportePlanilla
        objReportePlanilla.SetParameterValue("idPlanillaSalario", idPlanilla)
        CrystalReportViewer1.ReportSource = objReportePlanilla
    End Sub
    Sub cargarReporteEmpleados()
        Dim objReporteEmpleados As New reporteEmpleado
        objReporteEmpleados.SetParameterValue("cedulaEmpleado", cedula)
        CrystalReportViewer1.ReportSource = objReporteEmpleados
    End Sub
End Class