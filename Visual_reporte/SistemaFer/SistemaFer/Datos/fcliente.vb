Imports System.Data.SqlClient

Public Class fcliente
    Inherits conexion

    Dim cmd As New SqlCommand 'PARA ENVIAR PETICIONES
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarCliente")
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

    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CrearCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodC", dts.gCodC)
            cmd.Parameters.AddWithValue("@NombreC", dts.gNombreC)
            cmd.Parameters.AddWithValue("@ApellidosC", dts.gApellidosC)
            cmd.Parameters.AddWithValue("@DireccionC", dts.gDireccionC)
            cmd.Parameters.AddWithValue("@CelC", dts.gCelC)
            cmd.Parameters.AddWithValue("@Dni", dts.gDniC)
            cmd.Parameters.AddWithValue("@Email", dts.gEmailC)


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




    Public Function editar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EditarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CodC", dts.gCodC)
            cmd.Parameters.AddWithValue("@NombreC", dts.gNombreC)
            cmd.Parameters.AddWithValue("@ApellidosC", dts.gApellidosC)
            cmd.Parameters.AddWithValue("@DireccionC", dts.gDireccionC)
            cmd.Parameters.AddWithValue("@CelC", dts.gCelC)
            cmd.Parameters.AddWithValue("@Email", dts.gEmailC)


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



    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EliminarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@pCodCliente", dts.gCodC)

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
