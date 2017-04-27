Imports System.Data.OleDb
Public Class GestorAutores
    Private _lista As Collection
    Dim autor As Autores
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
        bbdd = agente.read("SELECT * FROM Peliculas")
        While bbdd.Read()

            autor = New Autores(bbdd(0), bbdd(1), bbdd(2))

            Me.lista.Add(autor)
        End While
    End Sub

    Public Sub readAutor(ByRef autor As Autores)
        agente = AgenteBD.getAgente
        bbdd = agente.read("SELECT * FROM Autores WHERE Investigador='" & autor.nombre_Invest & "';")
        While bbdd.Read()
            autor.nombre_Articulo = bbdd(1)
            autor.num_orden = bbdd(2)
        End While
    End Sub


    Public Sub create(ByVal autor As Autores)
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO Autores(Invest, Articulo, Orden) VALUES('" & autor.nombre_Invest & "','" & autor.nombre_Articulo & "','" & autor.num_orden & "');")
    End Sub

    Public Sub update(ByVal autor As Autores)
        agente = AgenteBD.getAgente()
        num = agente.update("UPDATE Autores SET Invest='" & autor.nombre_Invest & "' , Articulo='" & autor.nombre_Articulo & "' , Orden='" & autor.num_orden & ";")
    End Sub

    Public Sub delete(ByVal autor As Autores)
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM Autores WHERE Invest=" & autor.nombre_Invest & "")
        num = agente.delete("DELETE FROM ASISTE WHERE Autores=" & autor.nombre_Invest & "")
    End Sub

End Class

