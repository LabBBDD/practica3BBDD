Public Class Autores

    Private invest As Integer
    Private articulo As Integer
    Private orden As Integer

    Public Sub New(ByVal Invest As Integer, ByVal Articulo As Integer, ByVal Orden As Integer)

        Me.invest = Invest
        Me.articulo = Articulo
        Me.orden = Orden

    End Sub

    Public Sub New()

    End Sub

    Public Property nombre_Invest As Integer

        Get
            Return invest
        End Get
        Set(value As Integer)
            invest = value
        End Set

    End Property

    Public Property nombre_Articulo As Integer

        Get
            Return articulo
        End Get
        Set(value As Integer)
            articulo = value
        End Set

    End Property

    Public Property num_orden As Integer

        Get
            Return orden
        End Get
        Set(value As Integer)
            orden = value
        End Set

    End Property

End Class
