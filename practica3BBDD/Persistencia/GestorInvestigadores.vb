Imports System.Data.OleDb

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
        agente = AgenteBD.getAgente()
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
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM INVESTIGADORES WHERE Nombre='" & nombre & "';")
        While bbdd.Read()
            Return New Investigadores(bbdd.Item(0), bbdd.Item(1),
                                      bbdd.Item(2), bbdd.Item(3),
                                      bbdd.Item(4), bbdd.Item(5),
                                      bbdd.Item(6), bbdd.Item(7))
        End While

    End Function

    Public Sub create(ByVal investigador As Investigadores)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO INVESTIGADORES(idInvest,Nombre,Apellidos,Despacho,Edificio,Departamento,Teléfono,Email) VALUES('" & investigador.num_Id_Invest & "','" & investigador.Nombre_Invest & "','" & investigador.Apellido_Invest & "','" & investigador.nombre_Despacho & "','" & investigador.nombre_Edificio & "','" & investigador.nombre_Departamento & "','" & investigador.num_Telefono & "','" & investigador.direccion_email & "');")
        readAll()

    End Sub

    Public Sub update(ByVal investigadorOriginal As Investigadores, ByVal investigador As Investigadores)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.update("UPDATE INVESTIGADORES SET Nombre='" & investigador.Nombre_Invest & "' , Apellidos='" & investigador.Apellido_Invest & "' , Despacho='" & investigador.nombre_Despacho & "' , Edificio='" & investigador.nombre_Edificio & "' , Departamento='" & investigador.nombre_Departamento & "' , Teléfono='" & investigador.num_Telefono & "' , Email='" & investigador.direccion_email & "' WHERE idInvest=" & investigadorOriginal.num_Id_Invest & ";")
        readAll()

    End Sub

    Public Sub delete(ByVal investigador As Investigadores)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM INVESTIGADORES WHERE idInvest=" & investigador.num_Id_Invest & ";")
        readAll()

    End Sub

End Class
