Imports System.Data.SqlClient

Public Class frmTrabajo

    Public cnn As New SqlConnection("Data Source=DESKTOP-43110CL\SQLEXPRESS;Initial Catalog=Ferreterias;Integrated Security=True")


    Private dt As New DataTable
    Private Sub frmTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub limpiar()
        TextCodigo.Clear()
        Textnombre.Clear()
        Textapellido.Clear()
        Textdireccion.Clear()
        Textcelular.Clear()
        Textdni.Clear()
        Textemail.Clear()
        Textcargo.Clear()
        Textusuario.Clear()
        Textpass.Clear()

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fTrabajador
            dt = func.mostrar
            ' dgvTrabajador.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                dgvTrabajador.DataSource = dt
                textbuscar.Enabled = True
                dgvTrabajador.ColumnHeadersVisible = True
                lbldatos.Visible = False
            Else
                dgvTrabajador.DataSource = Nothing
                textbuscar.Enabled = False
                dgvTrabajador.ColumnHeadersVisible = False
                lbldatos.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        '' btneditar.Enabled = False


    End Sub

    Private Sub dgvTrabajador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrabajador.CellClick

        TextCodigo.Enabled = False
        Textdni.Enabled = False
        Textusuario.Enabled = False
        TextCodigo.Text = dgvTrabajador.SelectedCells.Item(0).Value
        Textnombre.Text = dgvTrabajador.SelectedCells.Item(1).Value
        Textapellido.Text = dgvTrabajador.SelectedCells.Item(2).Value
        Textdireccion.Text = dgvTrabajador.SelectedCells.Item(3).Value
        Textcelular.Text = dgvTrabajador.SelectedCells.Item(4).Value
        Textdni.Text = dgvTrabajador.SelectedCells.Item(5).Value
        Textemail.Text = dgvTrabajador.SelectedCells.Item(6).Value
        Textcargo.Text = dgvTrabajador.SelectedCells.Item(7).Value
        Textusuario.Text = dgvTrabajador.SelectedCells.Item(8).Value
        Textpass.Text = dgvTrabajador.SelectedCells.Item(9).Value
        Cbtipousuario.Text = dgvTrabajador.SelectedCells.Item(10).Value
        btnEditar.Visible = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim result As DialogResult

        result = MessageBox.Show("realmente desea editar los datos Trabajador?", "modificando registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                Dim dts As New vTrabajador
                Dim fun As New fTrabajador

                dts.Cod1 = TextCodigo.Text
                dts.Nombre1 = Textnombre.Text
                dts.Apellido1 = Textapellido.Text
                dts.Direccion1 = Textdireccion.Text
                dts.Cel1 = Textcelular.Text
                dts.Email1 = Textemail.Text
                dts.Cargo1 = Textcargo.Text
                dts.Pass1 = Textpass.Text
                dts.Tipousu1 = Cbtipousuario.Text

                If fun.editar(dts) Then
                    MessageBox.Show("Trabajador modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Trabajador no fue modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim func As New fTrabajador
        Dim dts As New vTrabajador

        dts.Cod1 = TextCodigo.Text

        If func.eliminar(dts) Then

            MsgBox("Trabajador eliminado correctamente")
            mostrar()
            limpiar()

        Else
            MsgBox("Trabajador no fue eliminado")

        End If

    End Sub

    Private Sub Btnguardar_Click_1(sender As Object, e As EventArgs) Handles Btnguardar.Click

        Dim dts As New vTrabajador
        Dim func As New fTrabajador

        dts.Cod1 = TextCodigo.Text
        dts.Nombre1 = Textnombre.Text
        dts.Apellido1 = Textapellido.Text
        dts.Direccion1 = Textdireccion.Text
        dts.Cel1 = Textcelular.Text
        dts.Dni1 = Textdni.Text
        dts.Email1 = Textemail.Text
        dts.Cargo1 = Textcargo.Text
        dts.Usuario1 = Textusuario.Text
        dts.Pass1 = Textpass.Text
        dts.Tipousu1 = Cbtipousuario.Text

        If func.insertar(dts) Then
            MessageBox.Show("Trabajador Registrado", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrar()
            limpiar()

        Else
            MessageBox.Show("Trabajador no Registrado", "intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()


    End Sub


    Private Sub dgvTrabajador_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrabajador.CellDoubleClick
        If TextFlag.Text = "1" Then
            frmventas.textcodigoTrab.Text = dgvTrabajador.SelectedCells.Item(0).Value
            Me.Close()

        End If

    End Sub

    Private Sub dgvTrabajador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrabajador.CellContentClick

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        TextCodigo.Enabled = True

    End Sub

    Private Sub textbuscar_TextChanged(sender As Object, e As EventArgs) Handles textbuscar.TextChanged

        If textbuscar.Text <> "" Then

            Try
                Dim cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = "BuscarTrabajador"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@dni", textbuscar.Text)
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim ds As New DataSet
                da.Fill(ds, "c")
                dgvTrabajador.DataSource = ds.Tables("c")

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else

            mostrar()


        End If

    End Sub

End Class