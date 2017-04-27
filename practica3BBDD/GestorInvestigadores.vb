Imports System.Data.OleDb

Public Class GestorInvestigadores
    Private _lista As Collection
    Dim investigador As Investigadores
    Dim agente As AgenteBD
    Dim bbdd As OleDbDataReader
    Dim num As Integer

    Public Sub New()
        Me.lista = New Collection
    End Sub

    Public Property lista As Collection
        Get
            Return _lista
        End Get
        Set(value As Collection)
            _lista = value
        End Set
    End Property

    Public Sub readAll()
        agente = AgenteBD.getAgente
        bbdd = agente.read("SELECT * FROM Conferencias")
        While bbdd.Read()
            investigador = New Investigadores(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4), bbdd(5), bbdd(6), bbdd(7))
            Me.lista.Add(investigador)
        End While
    End Sub

    Public Sub readInvestigador(ByRef investigador As Investigadores)
        agente = AgenteBD.getAgente
        bbdd = agente.read("SELECT * FROM Peliculas WHERE Titulo='" & investigador.Nombre_Invest & "';")
        While bbdd.Read()
            investigador.num_Id_Invest = bbdd(0)
            investigador.Apellido_Invest = bbdd(2)
            investigador.nombre_Despacho = bbdd(3)
            investigador.nombre_Edificio = bbdd(4)
            investigador.nombre_Departamento = bbdd(5)
            investigador.num_Telefono = bbdd(6)
            investigador.direccion_email = bbdd(7)
        End While
    End Sub

    Public Sub readConferencia(ByVal investigador As Investigadores, ByVal conferencia As Conferencia) 'leer investigador de la tabla ASISTE
        agente = AgenteBD.getAgente
        bbdd = agente.read("SELECT * FROM ASISTE WHERE Investigador=" & investigador.num_Id_Invest & " and Conferencia=" & conferencia.id_Conferencia & ";")
        While bbdd.Read()
            conferencia = New Conferencia()
            conferencia.id_Conferencia = bbdd(1)
            Me.lista.Add(conferencia)
        End While
    End Sub


    Public Sub create(ByVal investigador As Investigadores)
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO Investigadores(Nombre,Apellido,Despacho,Edificio,Departamento,Telefono,Email) VALUES('" & investigador.Nombre_Invest & "','" & investigador.Apellido_Invest & "','" & investigador.nombre_Despacho & "','" & investigador.nombre_Edificio & "','" & investigador.nombre_Departamento & "','" & investigador.num_Telefono & "','" & investigador.direccion_email & "');")
    End Sub

    Public Sub update(ByVal investigador As Investigadores)
        agente = AgenteBD.getAgente()
        num = agente.update("UPDATE Investigadores SET Nombre='" & investigador.Nombre_Invest & "' , Apellido='" & investigador.Apellido_Invest & "' , Despacho='" & investigador.nombre_Despacho & "' , Edificio='" & investigador.nombre_Edificio & "' , Departamento='" & investigador.nombre_Departamento & "' , Telefono='" & investigador.num_Telefono & "' , Email='" & investigador.direccion_email & "'WHERE IdPersona=" & investigador.num_Id_Invest & ";")
    End Sub

    Public Sub delete(ByVal investigador As Investigadores)
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM Personas WHERE idInvest=" & investigador.num_Id_Invest & "")
        num = agente.delete("DELETE FROM PARTICIPA WHERE Investigador=" & investigador.num_Id_Invest & "")
    End Sub

End Class
