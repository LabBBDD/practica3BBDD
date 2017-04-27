Public Class Investigadores
    Private idInvest As Integer
    Private nombre As String
    Private apellidos As String
    Private despacho As String
    Private edificio As String
    Private departamento As String
    Private telefono As String
    Private email As String
    Private gestor As GestorInvestigadores

    Public Sub New(ByVal IDInvest As String, ByVal Nombre As String, ByVal Apellidos As Integer, ByVal Despacho As String, ByVal Edificio As String, ByVal Departamento As String, ByVal Telefono As Integer, ByVal Email As String)
        Me.idInvest = IDInvest
        Me.nombre = Nombre
        Me.apellidos = Apellidos
        Me.despacho = Despacho
        Me.edificio = Edificio
        Me.departamento = Departamento
        Me.telefono = Telefono
        Me.email = Email
        Me.gestor = New GestorInvestigadores()
    End Sub

    Public Sub New(ByVal Nombre As String, ByVal Apellidos As Integer, ByVal Despacho As String, ByVal Edificio As String, ByVal Departamento As String, ByVal Telefono As Integer, ByVal Email As String)
        Me.nombre = Nombre
        Me.apellidos = Apellidos
        Me.despacho = Despacho
        Me.edificio = Edificio
        Me.departamento = Departamento
        Me.telefono = Telefono
        Me.email = Email
        Me.gestor = New GestorInvestigadores()
    End Sub

    Public Sub New(ByVal nombre As String)
        Me.nombre = nombre
        Me.gestor = New GestorInvestigadores()
    End Sub

    Public Sub New()
        Me.gestor = New GestorInvestigadores
    End Sub

    Public Property num_Id_Invest As Integer
        Get
            Return idInvest
        End Get
        Set(value As Integer)
            idInvest = value
        End Set
    End Property

    Public Property Nombre_Invest As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido_Invest As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property

    Public Property nombre_Despacho As String
        Get
            Return despacho

        End Get
        Set(value As String)
            despacho = value
        End Set
    End Property

    Public Property nombre_Edificio As String
        Get
            Return edificio
        End Get
        Set(value As String)
            edificio = value
        End Set
    End Property

    Public Property nombre_Departamento As String
        Get
            Return departamento
        End Get
        Set(value As String)
            departamento = value
        End Set
    End Property

    Public Property num_Telefono As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property direccion_email As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property




    Public Property _gestor As GestorInvestigadores
        Get
            Return gestor
        End Get
        Set(value As GestorInvestigadores)
            gestor = value
        End Set
    End Property

    Public Sub leerTodo()
        gestor.readAll()
    End Sub

    Public Sub leer()
        gestor.readInvestigador(Me)
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