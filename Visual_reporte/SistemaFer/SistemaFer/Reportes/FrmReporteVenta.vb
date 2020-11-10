Imports Microsoft.Reporting.WinForms

Public Class FrmReporteVenta
    Private Sub FrmReporteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriasDataSet.BuscarDetalleVenta4' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Me.BuscarDetalleVenta4TableAdapter.Fill(Me.FerreteriasDataSet.BuscarDetalleVenta4, TextBuscar.Text)
        Dim parameters(0) As ReportParameter
        parameters(0) = New ReportParameter("CodV", Me.TextBuscar.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class