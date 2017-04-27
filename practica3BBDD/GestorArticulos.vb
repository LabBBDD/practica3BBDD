Imports System.Data.OleDb
Public Class GestorArticulos
    Private _lista As Collection
    Dim articulo As Articulos
    Dim agente As AgenteBD
    Dim bbdd As OleDbDataReader
    Dim num As Integer
    Dim investigador As Investigadores

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
            investigador = New Investigadores(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4), bbdd(5), bbdd(6), bbdd(7))
            Me.lista.Add(investigador)
        End While
    End Sub

    Public Sub readArticulo(ByRef articulo As Articulos)
        agente = AgenteBD.getAgente
        bbdd = agente.read("SELECT * FROM Articulos WHERE Invest='" & articulo.id_articulo & "';")
        While bbdd.Read()
            articulo.nombre_titulo = bbdd(0)
            articulo.nombre_conferencia = bbdd(2)
            articulo.num_pag_inicio = bbdd(3)
            articulo.num_pag_fin = bbdd(4)
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

    Public Sub create(ByVal articulo As Articulos)
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO Articulo(Id Articulo, Titulo, Conferencia, Pag Inicio, Pag Fin) VALUES('" & articulo.nombre_titulo & "','" & articulo.nombre_conferencia & "','" & articulo.num_pag_inicio & "','" & articulo.num_pag_fin & "');")
    End Sub

    Public Sub update(ByVal articulo As Articulos)
        agente = AgenteBD.getAgente()
        num = agente.update("UPDATE Articulo SET Titulo='" & articulo.nombre_titulo & "' , Conferencia='" & articulo.nombre_conferencia & "' , Pag Inicio='" & articulo.num_pag_inicio & "' , Pag Fin='" & articulo.num_pag_fin & "'WHERE IdArticulo=" & articulo.id_articulo & ";")
    End Sub

    Public Sub delete(ByVal articulo As Articulos)
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM Personas WHERE idInvest=" & articulo.id_articulo & "")
        num = agente.delete("DELETE FROM PARTICIPA WHERE Investigador=" & articulo.id_articulo & "")
    End Sub

End Class
