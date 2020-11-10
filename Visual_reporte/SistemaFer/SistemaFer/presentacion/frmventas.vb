Imports System.Data.SqlClient

Public Class frmventas

    Public cnn As New SqlConnection("Data Source=DESKTOP-43110CL\SQLEXPRESS;Initial Catalog=Ferreterias;Integrated Security=True")
    Private dt As New DataTable

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub limpiar()
        textcodigoVenta.Clear()
        textcodigoTrab.Clear()
        TextCodigoCliente.Clear()
        TextNumDoc.Clear()

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fVenta
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                DgvVenta.DataSource = dt
                ' txtbuscar.Enabled = True
                DgvVenta.ColumnHeadersVisible = True
                SinDatos.Visible = False
            Else
                DgvVenta.DataSource = Nothing
                ' txtbuscar.Enabled = False
                DgvVenta.ColumnHeadersVisible = False
                SinDatos.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btneditar.Enabled = True


    End Sub


    'Private Sub txtnombres_Validating(sender As Object, e As CancelEventArgs) Handles txtnombres.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.ErrorIcono.SetError(sender, "")
    '    Else
    '        Me.ErrorIcono.SetError(sender, "caja vacia")
    '    End If


    'End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click

        Try
            Dim dts As New vVenta
            Dim func As New fVenta

            dts.CodVenta1 = textcodigoVenta.Text
            dts.Codtrab1 = textcodigoTrab.Text
            dts.CodCliente1 = TextCodigoCliente.Text
            dts.Fecha1 = DtpFecha.Text
            dts.TipoDoc1 = cbTipoDoc.Text
            dts.NumDoc1 = TextNumDoc.Text


            If func.insertar(dts) Then
                MessageBox.Show("Venta Registrada", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                ' limpiar()
                Me.Close()

                frmDetalleVenta.Show()

            Else
                MessageBox.Show("Venta no Registrada", "intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult

        result = MessageBox.Show("realmente desea editar los datos de la Venta?", "modificando registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                Dim dts As New vVenta
                Dim fun As New fVenta

                dts.CodVenta1 = textcodigoVenta.Text
                dts.Codtrab1 = textcodigoTrab.Text
                dts.CodCliente1 = TextCodigoCliente.Text
                dts.Fecha1 = DtpFecha.Text
                dts.TipoDoc1 = cbTipoDoc.Text
                dts.NumDoc1 = TextNumDoc.Text

                If fun.editar(dts) Then
                    MessageBox.Show("Venta modificada", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Venta  no fue modificada", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("falta insertar algunos datos ", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If



    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        Dim func As New fVenta
        Dim dts As New vVenta

        dts.CodVenta1 = textcodigoVenta.Text

        If func.eliminar(dts) Then

            MsgBox("Venta fue eliminado correctamente")
            mostrar()
            limpiar()

        Else
            MsgBox("Venta no fue eliminado")

        End If

    End Sub


    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()


    End Sub


    Private Sub DgvVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVenta.CellClick
        textcodigoVenta.Text = DgvVenta.SelectedCells.Item(0).Value
        textcodigoTrab.Text = DgvVenta.SelectedCells.Item(1).Value
        TextCodigoCliente.Text = DgvVenta.SelectedCells.Item(3).Value
        DtpFecha.Text = DgvVenta.SelectedCells.Item(6).Value
        cbTipoDoc.Text = DgvVenta.SelectedCells.Item(7).Value
        TextNumDoc.Text = DgvVenta.SelectedCells.Item(8).Value

        btneditar.Visible = True
        textcodigoVenta.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncliente.Click
        frmCliente.Textflag.Text = "1"
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnbuscarcat_Click(sender As Object, e As EventArgs) Handles btnbuscarcat.Click
        frmTrabajo.TextFlag.Text = "1"
        frmTrabajo.ShowDialog()
    End Sub



    Private Sub DgvVenta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVenta.CellDoubleClick
        If TextFlag.Text = "1" Then
            frmDetalleVenta.textcodigoVenta.Text = DgvVenta.SelectedCells.Item(0).Value
            frmDetalleVenta.textcodigoTrab.Text = DgvVenta.SelectedCells.Item(1).Value
            frmDetalleVenta.TextCodigoCliente.Text = DgvVenta.SelectedCells.Item(3).Value
            frmDetalleVenta.DtpFecha.Text = DgvVenta.SelectedCells.Item(6).Value
            frmDetalleVenta.cbTipoDoc.Text = DgvVenta.SelectedCells.Item(7).Value
            frmDetalleVenta.TextNumDoc.Text = DgvVenta.SelectedCells.Item(8).Value
            Me.Close()

        End If
    End Sub


    Private Sub textbuscar_TextChanged(sender As Object, e As EventArgs) Handles textbuscar.TextChanged

        If textbuscar.Text <> "" Then
            Try
                Dim cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = "BuscarVenta"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cod", textbuscar.Text)
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim ds As New DataSet
                da.Fill(ds, "c")
                DgvVenta.DataSource = ds.Tables("c")

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            mostrar()

        End If

    End Sub
End Class