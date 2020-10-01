Public Class FrmInicio
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmTrabajo.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmDetalleVenta.Show()

    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        frmCliente.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmProducto.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmCategoria.Show()

    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class