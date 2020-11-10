Imports System.Data.SqlClient

Public Class fDetalleVenta

    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarDetalleVenta2")
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

    Public Function insertar(ByVal dts As vDetalleVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("INSERTARDVENTA")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodV", dts.CodVentas1)
            cmd.Parameters.AddWithValue("@CodP", dts.CodP1)
            cmd.Parameters.AddWithValue("@Cantidad", dts.Cantidad1)

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

    Public Function eliminardventas(ByVal dts As vDetalleVenta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EliminarDetalleVenta2")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodDV", dts.CodDv1)

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

    Public Function AumentarStock(ByVal dts As vDetalleVenta) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("AumentarStock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Idprod", dts.CodP1)
            cmd.Parameters.AddWithValue("@Cantidadprod", dts.Cantidad1)

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

    Public Function DisminuirStock(ByVal dts As vDetalleVenta) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("DisminuirStock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Idprod", dts.CodP1)
            cmd.Parameters.AddWithValue("@Cantidadprod", dts.Cantidad1)

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
