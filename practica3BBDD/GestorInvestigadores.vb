﻿Imports System.Data.OleDb

Public Class GestorInvestigadores

    Private _lista As Collection
    Dim bbdd As OleDbDataReader
    Dim num As Integer

    Public Sub New()

        lista = New Collection
        readAll()

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

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        bbdd = agente.read("SELECT * FROM INVESTIGADORES")
        Dim aux As Investigadores
        _lista = New Collection
        While bbdd.Read()
            aux = New Investigadores(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4), bbdd(5), bbdd(6), bbdd(7))
            lista.Add(aux)
        End While

    End Sub

    Public Function readInvestigador(nombre As String) As Investigadores

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        bbdd = agente.read("SELECT * FROM INVESTIGADORES WHERE Nombre='" & nombre & "';")
        While bbdd.Read()
            Return bbdd.Item(0)
        End While

    End Function

    Public Sub create(ByVal investigador As Investigadores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.create("INSERT INTO INVESTIGADORES(idInvest,Nombre,Apellidos,Despacho,Edificio,Departamento,Telefono,Email) VALUES('" & investigador.Nombre_Invest & "','" & investigador.Apellido_Invest & "','" & investigador.nombre_Despacho & "','" & investigador.nombre_Edificio & "','" & investigador.nombre_Departamento & "','" & investigador.num_Telefono & "','" & investigador.direccion_email & "');")
        readAll()

    End Sub

    Public Sub update(ByVal investigador As Investigadores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.update("UPDATE INVESTIGADORES SET Nombre='" & investigador.Nombre_Invest & "' , Apellido='" & investigador.Apellido_Invest & "' , Despacho='" & investigador.nombre_Despacho & "' , Edificio='" & investigador.nombre_Edificio & "' , Departamento='" & investigador.nombre_Departamento & "' , Telefono='" & investigador.num_Telefono & "' , Email='" & investigador.direccion_email & "'WHERE IdPersona=" & investigador.num_Id_Invest & ";")
        readAll()

    End Sub

    Public Sub delete(ByVal investigador As Investigadores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.delete("DELETE FROM ASISTE WHERE Invest='" & investigador.num_Id_Invest & "';")
        num = agente.delete("DELETE FROM INVESTIGADORES WHERE idInvest='" & investigador.num_Id_Invest & "';")
        readAll()

    End Sub

End Class
