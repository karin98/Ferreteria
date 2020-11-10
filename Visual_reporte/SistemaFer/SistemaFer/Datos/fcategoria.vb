Imports System.Data.SqlClient

Public Class fcategoria

    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarCat")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function

    Public Function insertar(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CrearCat")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodigoCat", dts.Codcat1)
            cmd.Parameters.AddWithValue("@NombreCat", dts.NombreCat1)
            cmd.Parameters.AddWithValue("@Descripcion", dts.Descripcion1)
            If cmd.ExecuteNonQuery Then
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



    Public Function editar(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EditarCat")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CodCat", dts.Codcat1)
            cmd.Parameters.AddWithValue("@NombreCat", dts.NombreCat1)
            cmd.Parameters.AddWithValue("@Descripcion", dts.Descripcion1)

            If cmd.ExecuteNonQuery Then
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

    Public Function eliminar(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EliminarCat")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodCat", dts.Codcat1)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function




End Class
