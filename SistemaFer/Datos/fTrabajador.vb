Imports System.Data.SqlClient
Public Class fTrabajador

    Inherits conexion



    Dim cmd As New SqlCommand 'PARA ENVIAR PETICIONES




    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("TrabajadorMostrar")
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



    Public Function insertar(ByVal dts As vTrabajador) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("TrabajadorCrear")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CodTrabajador", dts.Cod1)
            cmd.Parameters.AddWithValue("@NombreTrabajador", dts.Nombre1)
            cmd.Parameters.AddWithValue("@ApellidoTrabajador", dts.Apellido1)
            cmd.Parameters.AddWithValue("@DireccionTrabajador", dts.Direccion1)
            cmd.Parameters.AddWithValue("@CelTrabajador", dts.Cel1)
            cmd.Parameters.AddWithValue("@DniTrabajador", dts.Dni1)
            cmd.Parameters.AddWithValue("@EmailTrabajador", dts.Email1)
            cmd.Parameters.AddWithValue("@cargo_trabajador", dts.Cargo1)
            cmd.Parameters.AddWithValue("@UsuTrabajador", dts.Usuario1)
            cmd.Parameters.AddWithValue("@PassTrabajador", dts.Pass1)
            cmd.Parameters.AddWithValue("@TipoUsuTrabajador", dts.Tipousu1)


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


    Public Function editar(ByVal dts As vTrabajador) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("EditarTrabajador")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodT", dts.Cod1)
            cmd.Parameters.AddWithValue("@NombreT", dts.Nombre1)
            cmd.Parameters.AddWithValue("@ApellidosT", dts.Apellido1)
            cmd.Parameters.AddWithValue("@DireccionT", dts.Direccion1)
            cmd.Parameters.AddWithValue("@CelT", dts.Cel1)
            cmd.Parameters.AddWithValue("@Email", dts.Email1)
            cmd.Parameters.AddWithValue("@Cargo", dts.Cargo1)
            cmd.Parameters.AddWithValue("@Password", dts.Pass1)
            cmd.Parameters.AddWithValue("@TipoUs", dts.Tipousu1)


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


    Public Function eliminar(ByVal dts As vTrabajador) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("EliminarTrabajador")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodT", dts.Cod1)

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
