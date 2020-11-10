Public Class frmDetalleVenta

    Public dt As New DataTable
    Private Sub frmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub limpiartodo()
        textcodigoVenta.Clear()
        textcodigoTrab.Clear()
        TextCodigoCliente.Clear()
        TextNumDoc.Clear()
        TextCodigoProd.Clear()
        TextCantidad2.Clear()
        TextStock2.Clear()
        TextPrecio.Clear()
    End Sub

    Public Sub limpiar()
        TextCodigoProd.Clear()
        TextCantidad2.Clear()
        TextStock2.Clear()
        TextPrecio.Clear()
    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fDetalleVenta
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                DgvDetalleVenta.DataSource = dt
                DgvDetalleVenta.ColumnHeadersVisible = True
                SinDatos.Visible = False
            Else
                DgvDetalleVenta.DataSource = Nothing
                DgvDetalleVenta.ColumnHeadersVisible = False
                SinDatos.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click

        Try
            Dim dts As New vDetalleVenta
            Dim func As New fDetalleVenta

            dts.CodVentas1 = textcodigoVenta.Text
            dts.CodP1 = TextCodigoProd.Text
            dts.Cantidad1 = TextCantidad2.Text


            If func.insertar(dts) Then
                If func.DisminuirStock(dts) Then
                End If
                MessageBox.Show("Producto seleccionado", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
            Else
                MessageBox.Show("Producto no seleccionado", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()


    End Sub

    Private Sub BtnCodigoProd_Click(sender As Object, e As EventArgs) Handles BtnCodigoProd.Click
        frmProducto.TextFlag.Text = "1"
        frmProducto.ShowDialog()

    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles BtnVenta.Click
        frmventas.TextFlag.Text = "1"
        frmventas.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim func As New fDetalleVenta
        Dim dts As New vDetalleVenta

        dts.CodDv1 = TextCodDV.Text

        If func.eliminardventas(dts) Then
            dts.CodP1 = TextCodigoProd.Text

            If func.AumentarStock(dts) Then

            End If

            MsgBox("Articulo fue quitado de la lista ")
            mostrar()
            limpiartodo()

        Else
            MsgBox("Articulo no fue eliminado")

        End If

    End Sub

    Private Sub DgvDetalleVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalleVenta.CellClick
        TextCodDV.Text = DgvDetalleVenta.SelectedCells.Item(0).Value
        TextCodigoProd.Text = DgvDetalleVenta.SelectedCells.Item(2).Value

    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click

        Dim can As Integer
        Dim stock As Integer

        can = TextCantidad2.Text
        stock = TextStock2.Text

        If can > stock Then
            MessageBox.Show("La cantidad que desea vender supera al stock", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextCantidad2.BackColor = Color.Red
            TextStock2.BackColor = Color.Red
            Btnguardar.Visible = False

        ElseIf can = 0 Then

            MessageBox.Show("La cantidad que desea vender es nula", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btnguardar.Visible = False
        Else
            MessageBox.Show("Confirmado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextCantidad2.BackColor = Color.Green
            TextStock2.BackColor = Color.Green
            Btnguardar.Visible = True
        End If

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        FrmReporteVenta.Show()

    End Sub
End Class