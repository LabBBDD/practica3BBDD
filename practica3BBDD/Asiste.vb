Public Class Asiste
    Private conferencia As Long
    Private Invest As Long
    Private gestor As GestorAsiste


    Public Sub New(ByVal Conferencia As Long, ByVal Invest As Long)
        Me.conferencia = Conferencia
        Me.Invest = Invest
        Me.gestor = New GestorAsiste()
    End Sub
    Public Sub New()
        Me.gestor = New GestorAsiste
    End Sub

    Public Property nombre_conferencia As Long
        Get
            Return conferencia
        End Get
        Set(value As Long)
            conferencia = value
        End Set
    End Property
    Public Property nombre_Invest As Long
        Get
            Return Invest
        End Get
        Set(value As Long)
            Invest = value
        End Set
    End Property
    Public Property _gestor As GestorAsiste
        Get
            Return gestor
        End Get
        Set(value As GestorAsiste)
            gestor = value
        End Set
    End Property
End Class
