Imports System.Data.SqlClient
Imports System.ComponentModel


Public Class LoginForm2

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.ValidateChildren = True And Textuser.Text <> "" And textPass.Text <> "" Then
                Dim dts As New vTrabajador
                Dim func As New fUsuario
                Dim TP As New vTrabajador
                Dim funct As New fTrabajador


                dts.Usuario1 = Textuser.Text
                dts.Pass1 = textPass.Text
                If func.ValidarUsuario(dts) = True Then
                    MessageBox.Show("Bienvenido ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()

                    frmCliente.Show()

                End If
                FrmInicio.Show()
            Else
                MessageBox.Show("Contraseña o Usuario incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Textuser.Clear()
                textPass.Clear()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TxtTipoUser_TextChanged(sender As Object, e As EventArgs) Handles TxtTipoUser.TextChanged



    End Sub


End Class
