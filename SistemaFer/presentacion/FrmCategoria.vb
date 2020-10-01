Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmCategoria

    Private dt As New DataTable

    Public cnn As New SqlConnection("Data Source=DESKTOP-43110CL\SQLEXPRESS;Initial Catalog=Ferreterias;Integrated Security=True")



    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub limpiar()
        Textcodigo.Clear()
        Textnombre.Clear()
        BtnGuardar.Visible = True
        BtnEditar.Visible = False

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fcategoria
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                DgvCategoria.DataSource = dt
                TextBuscar.Enabled = True
                DgvCategoria.ColumnHeadersVisible = True
                lbInexistente.Visible = False
            Else
                DgvCategoria.DataSource = Nothing
                TextBuscar.Enabled = False
                DgvCategoria.ColumnHeadersVisible = False
                lbInexistente.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        'BtnNuevo.Enabled = True
        'BtnEditar.Enabled = False


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim dts As New vCategoria
            Dim func As New fcategoria

            dts.Codcat1 = Textcodigo.Text
        dts.NombreCat1 = Textnombre.Text
        '  dts.Descripcion1 = TextDescripcion.Text

        If func.insertar(dts) Then
                MessageBox.Show("Categoria registrado", "guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()

            Else
                MessageBox.Show("Categoria no registrado", "intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim func As New fcategoria
        Dim dts As New vCategoria

        dts.Codcat1 = Textcodigo.Text

        If func.eliminar(dts) Then

            MsgBox("Cliente eliminado correctamente")
            mostrar()
            limpiar()

        Else
            MsgBox("Cliente no fue eliminado")

        End If


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("realmente desea editar los datos de la Categoria?", "modificando registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                Dim dts As New vCategoria
                Dim fun As New fcategoria

                dts.Codcat1 = Textcodigo.Text
                dts.NombreCat1 = Textnombre.Text
                ' dts.Descripcion1 = TextDescripcion.Text

                If fun.editar(dts) Then
                    MessageBox.Show("Categoria modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoria no fue modificado", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Me.Close()


    End Sub


    Private Sub DgvCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellClick

        Textcodigo.Text = DgvCategoria.SelectedCells.Item(0).Value
        Textnombre.Text = DgvCategoria.SelectedCells.Item(1).Value
        ' TextDescripcion.Text = DgvCategoria.SelectedCells.Item(2).Value


    End Sub

    Private Sub DgvCategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellDoubleClick

        If textflag.Text = "1" Then
            frmProducto.textnombrecat.Text = DgvCategoria.SelectedCells.Item(0).Value
            Me.Close()

        End If

    End Sub

    Private Sub TextBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBuscar.TextChanged

        If TextBuscar.Text <> "" Then

            Try
                Dim cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = "BuscarCat"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NombreCat", TextBuscar.Text)
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim ds As New DataSet
                da.Fill(ds, "c")
                DgvCategoria.DataSource = ds.Tables("c")

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else

            mostrar()


        End If


    End Sub
End Class