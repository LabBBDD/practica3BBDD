﻿Imports System.Data.OleDb

Public Class GestorArticulos

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
        bbdd = agente.read("SELECT * FROM ARTICULOS ")
        Dim aux As Articulos
        _lista = New Collection
        While bbdd.Read()
            aux = New Articulos(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4))
            lista.Add(aux)
        End While

    End Sub

    Public Function readArticulo(ByRef titulo As String)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        bbdd = agente.read("SELECT * FROM ARTICULOS WHERE Titulo='" & titulo & "';")
        While bbdd.Read()
            Return bbdd.Item(0)
        End While

    End Function

    Public Sub create(ByVal articulo As Articulos)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.create("INSERT INTO ARTICULOS(idArticulo, Titulo, Conferencia, pag_inicio, pag_fin) VALUES('" & articulo.id_articulo & "','" & articulo.nombre_titulo & "','" & articulo.nombre_conferencia & "','" & articulo.num_pag_inicio & "','" & articulo.num_pag_fin & "');")
        readAll()

    End Sub

    Public Sub update(ByVal articulo As Articulos)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.update("UPDATE ARTICULOS SET Titulo='" & articulo.nombre_titulo & "' , Conferencia='" & articulo.nombre_conferencia & "' , Pag Inicio='" & articulo.num_pag_inicio & "' , Pag Fin='" & articulo.num_pag_fin & "'WHERE IdArticulo=" & articulo.id_articulo & ";")
        readAll()

    End Sub

    Public Sub delete(ByVal articulo As Articulos)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.delete("DELETE FROM AUTOR WHERE Articulo='" & articulo.id_articulo & "';")
        num = agente.delete("DELETE FROM ARTICULOS WHERE idArticulo='" & articulo.id_articulo & "';")
        readAll()

    End Sub

End Class
