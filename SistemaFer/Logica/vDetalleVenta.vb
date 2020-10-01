Public Class vDetalleVenta
    Dim CodDv As Integer
    Dim CodVentas As String
    Dim CodP As String
    Dim Cantidad As Integer


    Public Property CodDv1 As Integer
        Get
            Return CodDv
        End Get
        Set(value As Integer)
            CodDv = value
        End Set
    End Property

    Public Property CodVentas1 As String
        Get
            Return CodVentas
        End Get
        Set(value As String)
            CodVentas = value
        End Set
    End Property

    Public Property CodP1 As String
        Get
            Return CodP
        End Get
        Set(value As String)
            CodP = value
        End Set
    End Property

    Public Property Cantidad1 As Integer
        Get
            Return Cantidad
        End Get
        Set(value As Integer)
            Cantidad = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal CodDv As Integer, ByVal CodVentas As String, ByVal CodProd As String, ByVal Cantidad As Integer)

        CodDv1 = CodDv
        CodVentas1 = CodVentas
        CodP1 = CodP
        Cantidad1 = Cantidad



    End Sub


End Class
