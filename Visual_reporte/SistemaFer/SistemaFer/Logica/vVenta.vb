Public Class vVenta

    Dim CodVenta As String
    Dim Codtrab As String
    Dim CodCliente As String
    Dim fecha As Date
    Dim TipoDoc As String
    Dim NumDoc As String

    Public Property CodVenta1 As String
        Get
            Return CodVenta
        End Get
        Set(value As String)
            CodVenta = value
        End Set
    End Property

    Public Property Codtrab1 As String
        Get
            Return Codtrab
        End Get
        Set(value As String)
            Codtrab = value
        End Set
    End Property

    Public Property CodCliente1 As String
        Get
            Return CodCliente
        End Get
        Set(value As String)
            CodCliente = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Property TipoDoc1 As String
        Get
            Return TipoDoc
        End Get
        Set(value As String)
            TipoDoc = value
        End Set
    End Property

    Public Property NumDoc1 As String
        Get
            Return NumDoc
        End Get
        Set(value As String)
            NumDoc = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal CodVenta As String, ByVal Codtrab As String, ByVal CodCliente As String, ByVal fecha As Date, ByVal TipoDoc As String, ByVal NumDoc As String)
        CodVenta1 = CodVenta
        Codtrab1 = Codtrab1
        CodCliente1 = CodCliente
        Fecha1 = fecha
        TipoDoc1 = TipoDoc
        NumDoc1 = NumDoc


    End Sub


End Class
