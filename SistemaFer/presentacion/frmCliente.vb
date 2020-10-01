Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCliente
    Private dt As New DataTable

    Public cnn As New SqlConnection("Data Source=DESKTOP-43110CL\SQLEXPRESS;Initial Catalog=Ferreterias;Integrated Security=True")


    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    Private Sub limpiar()
        txtcodigo.Clear()
        txtnombres.Clear()
        txtapellido.Clear()
        txtdireccion.Clear()
        textcel.Clear()
        textDni.Clear()

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True

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


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            Dim dts As New vcliente
            Dim func As New fcliente

            dts.gCodC = txtcodigo.Text
            dts.gNombreC = txtnombres.Text
            dts.gApellidosC = txtapellido.Text
            dts.gDireccionC = txtdireccion.Text
            dts.gCelC = textcel.Text
            dts.gDniC = textDni.Text


            If func.insertar(dts) Then
                MessageBox.Show("cliente registrado", "guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
            Else
                MessageBox.Show("cliente no registrado", "intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult

        result = MessageBox.Show("realmente desea editar los datos cliente?", "modificando registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                Dim dts As New vcliente
                Dim fun As New fcliente

                dts.gCodC = txtcodigo.Text
                dts.gNombreC = txtnombres.Text
                dts.gApellidosC = txtapellido.Text
                dts.gDireccionC = txtdireccion.Text
                dts.gCelC = textcel.Text

                If fun.editar(dts) Then
                    MessageBox.Show("cliente modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("cliente no fue modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim func As New fcliente
        Dim dts As New vcliente

        dts.gCodC = txtcodigo.Text

        If func.eliminar(dts) Then

            MsgBox("Cliente eliminado correctamente")
            mostrar()
            limpiar()

        Else
            MsgBox("Cliente no fue eliminado")

        End If

    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtcodigo.Text = datalistado.SelectedCells.Item(0).Value
        txtnombres.Text = datalistado.SelectedCells.Item(1).Value
        txtapellido.Text = datalistado.SelectedCells.Item(2).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(3).Value
        textcel.Text = datalistado.SelectedCells.Item(4).Value
        textDni.Text = datalistado.SelectedCells.Item(5).Value

        btneditar.Visible = True
        txtcodigo.Enabled = False
        textDni.Enabled = False


    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()


    End Sub


    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If Textflag.Text = "1" Then
            frmventas.TextCodigoCliente.Text = datalistado.SelectedCells.Item(0).Value
            Me.Close()

        End If

    End Sub

    Private Sub Textflag_TextChanged(sender As Object, e As EventArgs) Handles Textflag.TextChanged

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If txtbuscar.Text <> "" Then

            Try
                Dim cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = "BuscarCliente"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@dni", txtbuscar.Text)
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim ds As New DataSet
                da.Fill(ds, "c")
                datalistado.DataSource = ds.Tables("c")

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else

            mostrar()


        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class







