Public Class Autores
    Private invest As Long
    Private articulo As Long
    Private orden As Long
    Private gestor As GestorAutores

    Public Sub New(ByVal Invest As String, ByVal Articulo As String, ByVal Orden As Integer)

        Me.invest = Invest
        Me.articulo = Articulo
        Me.orden = Orden
        Me.gestor = New GestorAutores()
    End Sub

    Public Sub New()
        Me.gestor = New GestorAutores()
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

    Public Property _gestor As GestorAutores
        Get
            Return gestor
        End Get
        Set(value As GestorAutores)
            gestor = value
        End Set
    End Property

    Public Sub leerTodo()
        gestor.readAll()
    End Sub

    Public Sub leer()
        gestor.readAutor(Me)
    End Sub

    Public Sub leer(ByVal autor As Autores)
        gestor.readAutor(autor)
    End Sub

    Public Sub añadir()
        gestor.create(Me)
    End Sub

    Public Sub actualizar()
        gestor.update(Me)
    End Sub

    Public Sub borrar()
        gestor.delete(Me)
    End Sub
End Class
