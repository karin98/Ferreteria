Imports System.Data.SqlClient

Public Class fVenta

    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarVenta")
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

    Public Function insertar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CrearVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodVenta", dts.CodVenta1)
            cmd.Parameters.AddWithValue("@codTrab", dts.Codtrab1)
            cmd.Parameters.AddWithValue("@CodCliente", dts.CodCliente1)
            cmd.Parameters.AddWithValue("@Fecha", dts.Fecha1)
            cmd.Parameters.AddWithValue("@TipoDoc", dts.TipoDoc1)
            cmd.Parameters.AddWithValue("@NumDoc", dts.NumDoc1)


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



    Public Function editar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EDITARVENTA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CodVenta", dts.CodVenta1)
            cmd.Parameters.AddWithValue("@codTrab", dts.Codtrab1)
            cmd.Parameters.AddWithValue("@CodCliente", dts.CodCliente1)
            cmd.Parameters.AddWithValue("@Fecha", dts.Fecha1)
            cmd.Parameters.AddWithValue("@TipoDoc", dts.TipoDoc1)
            cmd.Parameters.AddWithValue("@NumDoc", dts.NumDoc1)

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



    Public Function eliminar(ByVal dts As vVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ELIMINARVENTA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodVenta", dts.CodVenta1)

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
