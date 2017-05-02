Public Class Articulos

    Private idArticulo As Integer
    Private titulo As String
    Private conferencia As String
    Private pag_inicio As Integer
    Private pag_fin As Integer

    Public Sub New(ByVal IDArticulo As Integer, ByVal Titulo As String, ByVal Conferencia As String, ByVal Pag_Inicio As Integer, ByVal Pag_Fin As Integer)

        Me.idArticulo = IDArticulo
        Me.titulo = Titulo
        Me.conferencia = Conferencia
        Me.pag_inicio = Pag_Inicio
        Me.pag_fin = Pag_Fin

    End Sub

    Public Sub New()

    End Sub

    Public Property id_articulo As Integer

        Get
            Return idArticulo
        End Get
        Set(value As Integer)
            idArticulo = value
        End Set

    End Property

    Public Property nombre_titulo As String

        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set

    End Property

    Public Property nombre_conferencia As String

        Get
            Return conferencia
        End Get
        Set(value As String)
            conferencia = value
        End Set

    End Property

    Public Property num_pag_inicio As Integer
        Get
            Return pag_inicio
        End Get
        Set(value As Integer)
            pag_inicio = value
        End Set
    End Property

    Public Property num_pag_fin As Integer

        Get
            Return pag_fin
        End Get
        Set(value As Integer)
            pag_fin = value
        End Set

    End Property

End Class
