Public Class LoginForm2

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim dts As New vTrabajador
            Dim func As New fUsuario
            dts.Usuario1 = txtusername.Text
            dts.Pass1 = txtpassword.Text

            If func.ValidarUsuario(dts) Then
                FrmInicio.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese nuevamente :c", MsgBoxStyle.Information, "Acceso denegado")
                txtpassword.Clear()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
