Public Class Conferencia

    Private idConferencia As Integer
    Private siglas As String
    Private nombre As String
    Private lugar As String
    Private fecha_inicio As String
    Private fecha_fin As String

    Public Sub New(ByVal IDConferencia As Integer, ByVal Siglas As String, ByVal Nombre As String, ByVal Lugar As String, ByVal Fecha_Inicio As String, ByVal Fecha_Fin As String)

        Me.idConferencia = IDConferencia
        Me.siglas = Siglas
        Me.nombre = Nombre
        Me.lugar = Lugar
        Me.fecha_inicio = Fecha_Inicio
        Me.fecha_fin = Fecha_Fin

    End Sub

    Public Sub New(ByVal Siglas As String, ByVal Nombre As String, ByVal Lugar As String, ByVal Fecha_Inicio As String, ByVal Fecha_Fin As String)

        Me.siglas = Siglas
        Me.nombre = Nombre
        Me.lugar = Lugar
        Me.fecha_inicio = Fecha_Inicio
        Me.fecha_fin = Fecha_Fin

    End Sub

    Public Sub New(ByVal nombre As String)

        Me.nombre = nombre

    End Sub

    Public Sub New()

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

End Class
