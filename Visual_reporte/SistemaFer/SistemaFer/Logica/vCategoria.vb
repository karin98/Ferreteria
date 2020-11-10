Public Class vCategoria
    Dim Codcat As String
    Dim NombreCat As String
    Dim Descripcion As String


    Public Property Codcat1 As String
        Get
            Return Codcat
        End Get
        Set(value As String)
            Codcat = value
        End Set
    End Property

    Public Property NombreCat1 As String
        Get
            Return NombreCat
        End Get
        Set(value As String)
            NombreCat = value
        End Set
    End Property


    Public Property Descripcion1 As String
        Get
            Return Descripcion

        End Get
        Set(value As String)
            Descripcion = value

        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal Codcat As String, ByVal NombreCat As String, ByVal Descripcion As String)
        Codcat1 = Codcat
        NombreCat1 = NombreCat
        Descripcion1 = Descripcion
    End Sub

End Class
