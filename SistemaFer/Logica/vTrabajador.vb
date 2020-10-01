Public Class vTrabajador
    Dim cod As String
    Dim nombre As String
    Dim apellido As String
    Dim direccion As String
    Dim cel As String
    Dim dni As String
    Dim email As String
    Dim cargo As String
    Dim usuario As String
    Dim pass As String
    Dim tipousu As String

    Public Property Cod1 As String
        Get
            Return cod
        End Get
        Set(value As String)
            cod = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property Cel1 As String
        Get
            Return cel
        End Get
        Set(value As String)
            cel = value
        End Set
    End Property

    Public Property Dni1 As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Cargo1 As String
        Get
            Return cargo
        End Get
        Set(value As String)
            cargo = value
        End Set
    End Property

    Public Property Usuario1 As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property

    Public Property Pass1 As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property

    Public Property Tipousu1 As String
        Get
            Return tipousu
        End Get
        Set(value As String)
            tipousu = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal cod As String, ByVal nombre As String, ByVal apellido As String, ByRef direccion As String,
       ByVal email As String, ByVal cargo As String, ByVal usuario As String, ByVal pass As String, ByVal tipousu As String)

        Cod1 = cod
        Nombre1 = nombre
        Apellido1 = apellido
        Direccion1 = direccion
        Cel1 = cel
        Dni1 = dni
        Email1 = email
        Cargo1 = cargo
        Usuario1 = usuario
        Pass1 = pass
        Tipousu1 = tipousu




    End Sub
End Class
