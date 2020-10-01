Public Class vProducto
    Dim codprod As String
    Dim CodCat As String
    Dim NombreProd As String
    Dim MarcaProd As String
    Dim PrecioProd As Decimal
    Dim Presentacion As String
    Dim StockProd As Integer


    Public Property codprod1 As String
        Get
            Return codprod
        End Get
        Set(value As String)
            codprod = value
        End Set
    End Property

    Public Property CodCat1 As String
        Get
            Return CodCat
        End Get
        Set(value As String)
            CodCat = value
        End Set
    End Property

    Public Property NombreProd1 As String
        Get
            Return NombreProd
        End Get
        Set(value As String)
            NombreProd = value
        End Set
    End Property

    Public Property MarcaProd1 As String
        Get
            Return MarcaProd
        End Get
        Set(value As String)
            MarcaProd = value
        End Set
    End Property

    Public Property PrecioProd1 As Decimal
        Get
            Return PrecioProd
        End Get
        Set(value As Decimal)
            PrecioProd = value
        End Set
    End Property

    Public Property StockProd1 As Integer
        Get
            Return StockProd
        End Get
        Set(value As Integer)
            StockProd = value
        End Set
    End Property

    Public Property Presentacion1 As String
        Get
            Return Presentacion
        End Get
        Set(value As String)
            Presentacion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal codprod As String, ByVal CodCat As String, ByVal NombreProd As String, ByVal MarcaProd As String,
             ByVal PrecioProd As Double, ByVal Presentacion As String, ByVal StockProd As Integer)
        codprod1 = codprod
        CodCat1 = CodCat
        NombreProd1 = NombreProd
        MarcaProd1 = MarcaProd
        PrecioProd1 = PrecioProd
        Presentacion1 = Presentacion
        StockProd1 = StockProd


    End Sub

End Class
