Public Class Autores

    Private invest As Long
    Private articulo As Long
    Private orden As Long

    Public Sub New(ByVal Invest As String, ByVal Articulo As String, ByVal Orden As Integer)

        Me.invest = Invest
        Me.articulo = Articulo
        Me.orden = Orden
    End Sub

    Public Sub New()

    End Sub

    Public Property nombre_Invest As Long

        Get
            Return invest
        End Get
        Set(value As Long)
            invest = value
        End Set

    End Property

    Public Property nombre_Articulo As Long

        Get
            Return articulo
        End Get
        Set(value As Long)
            articulo = value
        End Set

    End Property

    Public Property num_orden As Long

        Get
            Return orden
        End Get
        Set(value As Long)
            orden = value
        End Set

    End Property

End Class
