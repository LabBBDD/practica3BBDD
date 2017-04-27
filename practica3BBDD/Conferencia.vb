Public Class Conferencia
    Private idConferencia As Integer
    Private siglas As String
    Private nombre As String
    Private lugar As String
    Private fecha_inicio As String
    Private fecha_fin As String
    Private gestor As GestorConferencia

    Public Sub New(ByVal IDConferencia As String, ByVal Siglas As String, ByVal Nombre As String, ByVal Lugar As String, ByVal Edificio As String, ByVal Fecha_Inicio As String, ByVal Fecha_Fin As String)
        Me.idConferencia = IDConferencia
        Me.siglas = Siglas
        Me.nombre = Nombre
        Me.lugar = Lugar
        Me.fecha_inicio = Fecha_Inicio
        Me.fecha_fin = Fecha_Fin
        Me.gestor = New GestorConferencia()
    End Sub

    Public Sub New(ByVal nombre As String)
        Me.nombre = nombre
        Me.gestor = New GestorConferencia()
    End Sub

    Public Sub New()
        Me.gestor = New GestorConferencia
    End Sub


    Public Property id_Conferencia As Integer
        Get
            Return idConferencia
        End Get
        Set(value As Integer)
            idConferencia = value
        End Set
    End Property

    Public Property nombre_siglas As String
        Get
            Return siglas
        End Get
        Set(value As String)
            siglas = value
        End Set
    End Property

    Public Property nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property nombre_lugar As String
        Get
            Return lugar
        End Get
        Set(value As String)
            lugar = value
        End Set
    End Property

    Public Property fechainicio As String
        Get
            Return fecha_inicio
        End Get
        Set(value As String)
            fecha_inicio = value
        End Set
    End Property

    Public Property fechafin As String
        Get
            Return fecha_fin
        End Get
        Set(value As String)
            fecha_fin = value
        End Set
    End Property

    Public Property _gestor As GestorConferencia
        Get
            Return gestor
        End Get
        Set(value As GestorConferencia)
            gestor = value
        End Set
    End Property

    Public Sub leerTodo()
        gestor.readAll()
    End Sub

    Public Sub leer()
        gestor.readConferencia(Me)
    End Sub

    Public Sub leer(ByVal investigador As Investigadores, ByVal conferencia As Conferencia)
        gestor.readConferencia(investigador, conferencia)
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
