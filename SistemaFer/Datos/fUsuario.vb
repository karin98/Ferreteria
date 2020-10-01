Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class fUsuario
    Inherits conexion

    Dim cmd As New SqlCommand
    Public Function ValidarUsuario(ByVal dts As vTrabajador)
        Try
            conectado()
            cmd = New SqlCommand("sp_ValidarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Usuario", dts.Usuario1)
            cmd.Parameters.AddWithValue("@ClaveAcceso", dts.Pass1)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader


            If dr.HasRows Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function






End Class
