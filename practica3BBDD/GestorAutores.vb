Imports System.Data.OleDb

Public Class GestorAutores

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
        Dim aux As Autores
        bbdd = agente.read("SELECT * FROM AUTOR")
        While bbdd.Read()

            aux = New Autores(bbdd(0), bbdd(1), bbdd(2))

            lista.Add(aux)
        End While
    End Sub

    Public Function readAutor(ByRef idInvest As Integer, idArt As Integer) As Autores

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        bbdd = agente.read("SELECT * FROM AUTOR WHERE Invest=" & idInvest & " AND Articulo=" & idArt & ";")
        While bbdd.Read()
            Return New Autores(bbdd.Item(0), bbdd.Item(1), bbdd.Item(2))
        End While

    End Function


    Public Sub create(ByVal autor As Autores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.create("INSERT INTO AUTOR(Invest, Articulo, Orden) VALUES('" & autor.nombre_Invest & "','" & autor.nombre_Articulo & "','" & autor.num_orden & "');")
        readAll()

    End Sub

    Public Sub update(ByVal autor As Autores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.update("UPDATE AUTOR SET Orden=" & autor.num_orden & " WHERE Invest=" & autor.nombre_Invest & " AND Articulo=" & autor.nombre_Articulo & ";")
        readAll()

    End Sub

    Public Sub delete(ByVal autor As Autores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.delete("DELETE FROM AUTOR WHERE Invest=" & autor.nombre_Invest & " AND Articulo=" & autor.nombre_Articulo & ";")
        readAll()

    End Sub

End Class

