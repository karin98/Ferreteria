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

                dts.Tipousu1 = TxtTipoUser.Text

                dts.Usuario1 = Textuser.Text
                dts.Pass1 = textPass.Text
                If func.ValidarUsuario(dts) = True Then
                    Dim res As String
                    res = funct.consultarTipoUser(dts)
                    If Not res = "" Then
                        TxtTipoUser.Text = res


                        If res = "ADMINISTRADOR" Then
                            MessageBox.Show("Bienvenido ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Hide()
                            FrmInicio.Show()

                        Else
                            MessageBox.Show("Bienvenido ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Hide()
                            FrmInicio.Show()
                            FrmInicio.Button3.Enabled = False
                            FrmInicio.Button2.Enabled = False
                            FrmInicio.Button6.Enabled = False

                        End If
                    End If

                Else
                    MessageBox.Show("Contraseña o Usuario incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Textuser.Clear()
                    textPass.Clear()

                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub






End Class
