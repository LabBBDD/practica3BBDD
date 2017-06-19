Imports System.Data.OleDb

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
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM ARTICULOS ")
        Dim aux As Articulos
        _lista = New Collection
        While bbdd.Read()
            aux = New Articulos(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4))
            lista.Add(aux)
        End While

    End Sub

    Public Function readArticulo(ByRef titulo As String) As Articulos

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM ARTICULOS WHERE Titulo='" & titulo & "';")
        While bbdd.Read()
            Return New Articulos(bbdd.Item(0),
                                 bbdd.Item(1),
                                 bbdd.Item(2),
                                 bbdd.Item(3),
                                 bbdd.Item(4))
        End While

    End Function

    Public Function readIdArt(idArt As Integer) As Articulos

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM ARTICULOS WHERE idArticulo=" & idArt & ";")
        While bbdd.Read()
            Return New Articulos(bbdd.Item(0),
                                 bbdd.Item(1),
                                 bbdd.Item(2),
                                 bbdd.Item(3),
                                 bbdd.Item(4))
        End While

    End Function

    Public Sub create(ByVal articulo As Articulos)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO ARTICULOS(idArticulo, Titulo, Conferencia, pag_inicio, pag_fin) VALUES(" & articulo.id_articulo & ",'" & articulo.nombre_titulo & "'," & articulo.n_conferencia & "," & articulo.num_pag_inicio & "," & articulo.num_pag_fin & ");")
        readAll()

    End Sub

    Public Sub update(ByVal articulo As Articulos)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.update("UPDATE ARTICULOS SET Titulo='" & articulo.nombre_titulo & "' , Conferencia=" & articulo.n_conferencia & " , pag_inicio='" & articulo.num_pag_inicio & "' , pag_fin='" & articulo.num_pag_fin & "'WHERE IdArticulo=" & articulo.id_articulo & ";")
        readAll()

    End Sub

    Public Sub delete(ByVal articulo As Articulos)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        agente.delete("DELETE FROM ARTICULOS WHERE idArticulo=" & articulo.id_articulo & ";")
        agente.delete("DELETE FROM AUTOR WHERE Articulo=" & articulo.id_articulo & ";")
        readAll()

    End Sub

End Class
