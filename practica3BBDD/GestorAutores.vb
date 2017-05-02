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
        bbdd = agente.read("SELECT * FROM ")
        While bbdd.Read()

            aux = New Autores(bbdd(0), bbdd(1), bbdd(2))

            lista.Add(aux)
        End While
    End Sub

    Public Sub readAutor(ByRef autor As Autores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        bbdd = agente.read("SELECT * FROM AUTORES WHERE Invest='" & autor.nombre_Invest & "';")
        While bbdd.Read()
            autor.nombre_Articulo = bbdd(0)
            autor.num_orden = bbdd(1)
        End While

    End Sub


    Public Sub create(ByVal autor As Autores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.create("INSERT INTO Autores(Invest, Articulo, Orden) VALUES('" & autor.nombre_Invest & "','" & autor.nombre_Articulo & "','" & autor.num_orden & "');")

    End Sub

    Public Sub update(ByVal autor As Autores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.update("UPDATE Autores SET Invest='" & autor.nombre_Invest & "' , Articulo='" & autor.nombre_Articulo & "' , Orden='" & autor.num_orden & ";")

    End Sub

    Public Sub delete(ByVal autor As Autores)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.delete("DELETE FROM AUTORES WHERE Invest='" & autor.nombre_Invest & "';")
        num = agente.delete("DELETE FROM ASISTE WHERE Autores='" & autor.nombre_Invest & "';")
        num = agente.delete("DELETE FROM INVESTIGADORES WHERE idInvest='" & autor.nombre_Invest & "';")
        num = agente.delete("DELETE FROM ARTICULOS WHERE idArticulo='" & autor.nombre_Articulo & "';")

    End Sub

End Class

