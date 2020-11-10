Imports System.Data.SqlClient

Public Class frmProducto

    Private dt As New DataTable

    Public cnn As New SqlConnection("Data Source=DESKTOP-43110CL\SQLEXPRESS;Initial Catalog=Ferreterias;Integrated Security=True")


    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub limpiar()
        textcodigoprod.Clear()
        textnombrecat.Clear()
        textnombrep.Clear()
        textmarcap.Clear()
        textpreciop.Clear()
        txtStock.Clear()
        '  textpresentacion.Clear()
        'Btnguardar.Visible = True
        'btneditar.Visible = False

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fproducto
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                Dgvproducto.DataSource = dt
                textbuscar.Enabled = True
                Dgvproducto.ColumnHeadersVisible = True
                SinDatos.Visible = False
            Else
                Dgvproducto.DataSource = Nothing
                textbuscar.Enabled = False
                Dgvproducto.ColumnHeadersVisible = False
                SinDatos.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        btneditar.Enabled = False


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        If Me.ValidateChildren = True And textnombrep.Text <> "" Then
            Dim dts As New vProducto
            Dim func As New fproducto

            dts.codprod1 = textcodigoprod.Text
            dts.CodCat1 = textnombrecat.Text
            dts.NombreProd1 = textnombrep.Text
            dts.PrecioProd1 = textpreciop.Text
            dts.MarcaProd1 = textmarcap.Text
            '   dts.Presentacion1 = textpresentacion.Text
            dts.StockProd1 = txtStock.Text


            If func.insertar(dts) Then
                MessageBox.Show("Producto registrado", "guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()

            Else
                MessageBox.Show("Producto no registrado", "intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)



            End If

        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult

        result = MessageBox.Show("realmente desea editar los datos Trabajador?", "modificando registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            'If Me.ValidateChildren = True And txtnombres.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" Then


            Try
                Dim dts As New vProducto
                Dim fun As New fproducto

                dts.NombreProd1 = textnombrep.Text
                dts.MarcaProd1 = textmarcap.Text
                dts.PrecioProd1 = textpreciop.Text
                '  dts.Presentacion1 = textpresentacion.Text
                dts.StockProd1 = txtStock.Text
                dts.StockMin1 = TxtstockMin.Text




                If fun.editar(dts) Then
                    MessageBox.Show("Producto modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Producto no fue modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("falta insertar algunos datos ", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

        'End If
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        Dim func As New fproducto
        Dim dts As New vProducto

        dts.codprod1 = textcodigoprod.Text

        If func.eliminar(dts) Then

            MsgBox("Producto eliminado correctamente")
            mostrar()
            limpiar()

        Else
            MsgBox("Producto no fue eliminado")

        End If
    End Sub


    Private Sub Dgvproducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvproducto.CellClick


        textcodigoprod.Text = Dgvproducto.SelectedCells.Item(0).Value
        textnombrecat.Text = Dgvproducto.SelectedCells.Item(1).Value
        textnombrep.Text = Dgvproducto.SelectedCells.Item(2).Value
        textpreciop.Text = Dgvproducto.SelectedCells.Item(3).Value
        textmarcap.Text = Dgvproducto.SelectedCells.Item(4).Value
        ' textpresentacion.Text = Dgvproducto.SelectedCells.Item(5).Value
        txtStock.Text = Dgvproducto.SelectedCells.Item(5).Value
        TxtstockMin.Text = Dgvproducto.SelectedCells.Item(6).Value





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscarcat.Click

        FrmCategoria.textflag.Text = "1"
        FrmCategoria.ShowDialog()


    End Sub


    Private Sub Dgvproducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvproducto.CellDoubleClick
        If TextFlag.Text = "1" Then
            frmDetalleVenta.TextCodigoProd.Text = Dgvproducto.SelectedCells.Item(0).Value
            frmDetalleVenta.TextPrecio.Text = Dgvproducto.SelectedCells.Item(3).Value
            frmDetalleVenta.TextPresentacion.Text = Dgvproducto.SelectedCells.Item(5).Value
            frmDetalleVenta.TextStock2.Text = Dgvproducto.SelectedCells.Item(6).Value

            Me.Close()

        End If
    End Sub



    Private Sub textbuscar_TextChanged(sender As Object, e As EventArgs) Handles textbuscar.TextChanged

        If textbuscar.Text <> "" Then

            Try
                Dim cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = "BuscarProducto"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Nombre", textbuscar.Text)
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim ds As New DataSet
                da.Fill(ds, "c")
                Dgvproducto.DataSource = ds.Tables("c")

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else

            mostrar()


        End If


    End Sub
End Class