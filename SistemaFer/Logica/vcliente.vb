Imports System.Data.SqlClient

Public Class vcliente



    Dim CodC, NombreC, ApellidosC, DireccionC, CelC, DniC, EmailC As String

    ''METODO SETTER / GET

    Public Property gCodC
        Get
            Return CodC
        End Get
        Set(ByVal value)
            CodC = value

        End Set
    End Property

    Public Property gNombreC
        Get
            Return NombreC
        End Get
        Set(ByVal value)
            NombreC = value
        End Set

    End Property

    Public Property gApellidosC
        Get
            Return ApellidosC
        End Get
        Set(ByVal value)
            ApellidosC = value
        End Set

    End Property


    Public Property gDireccionC
        Get
            Return DireccionC
        End Get
        Set(ByVal value)
            DireccionC = value
        End Set

    End Property

    Public Property gCelC
        Get
            Return CelC
        End Get
        Set(ByVal value)
            CelC = value
        End Set
    End Property

    Public Property gDniC
        Get
            Return DniC
        End Get
        Set(ByVal value)
            DniC = value
        End Set
    End Property

    Public Property gEmailC
        Get
            Return EmailC
        End Get
        Set(value)
            EmailC = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal CodC As String, ByVal NombreC As String, ByVal ApellidosC As String,
      ByVal DireccionC As String, ByVal CelC As String, ByVal DniC As String, ByVal EmailC As String)

        gCodC = CodC
        gNombreC = NombreC
        gApellidosC = ApellidosC
        gDireccionC = DireccionC
        gCelC = CelC
        gDniC = DniC
        gEmailC = EmailC


    End Sub






End Class
