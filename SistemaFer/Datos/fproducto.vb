Imports System.Data.SqlClient

Public Class fproducto

    Inherits conexion

    Dim cmd As New SqlCommand 'PARA ENVIAR PETICIONES
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarProducto")
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

    Public Function insertar(ByVal dts As vProducto) As Boolean
        ' Try
        conectado()
        cmd = New SqlCommand("Crearproducto")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@CodProd", dts.codprod1)
        cmd.Parameters.AddWithValue("@CodCat", dts.CodCat1)
        cmd.Parameters.AddWithValue("@NomProd", dts.NombreProd1)
        cmd.Parameters.AddWithValue("@PrecioProd", dts.PrecioProd1)
        cmd.Parameters.AddWithValue("@MarcaProd", dts.MarcaProd1)
        cmd.Parameters.AddWithValue("@Presentacion", dts.Presentacion1)
        cmd.Parameters.AddWithValue("@StockProd", dts.StockProd1)


        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False

        End If
        ' Catch ex As Exception
        '  MsgBox(ex.Message)
        Return False
        '  Finally
        desconectado()


        'End Try
    End Function


    Public Function editar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EditarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@NomProd", dts.NombreProd1)
            cmd.Parameters.AddWithValue("@PrecioProd", dts.PrecioProd1)
            cmd.Parameters.AddWithValue("@MarcaProd", dts.MarcaProd1)
            cmd.Parameters.AddWithValue("@Presentacion", dts.Presentacion1)
            cmd.Parameters.AddWithValue("@StockProd", dts.StockProd1)

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


    Public Function eliminar(ByVal dts As vProducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EliminarPoducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodProd", dts.codprod1)

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
