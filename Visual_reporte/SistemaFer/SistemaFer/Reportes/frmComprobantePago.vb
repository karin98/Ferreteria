Public Class frmComprobantePago
    Private Sub frmComprobantePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriasDataSet2.generar_comprobante' Puede moverla o quitarla según sea necesario.
        Me.generar_comprobanteTableAdapter.Fill(Me.FerreteriasDataSet2.generar_comprobante, idventa:=textIdventa.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class