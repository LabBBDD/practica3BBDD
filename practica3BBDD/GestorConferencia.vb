Imports System.Data.OleDb
Public Class GestorConferencia
    Private _lista As Collection
    Dim conferencia As Conferencia
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
            If IsDBNull(bbdd(6)) Then
                conferencia = New Conferencia(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4), bbdd(5), False)
            Else
                conferencia = New Conferencia(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4), bbdd(5), bbdd(6))
            End If
            Me.lista.Add(conferencia)
        End While
    End Sub

    Public Sub readConferencia(ByRef conferencia As Conferencia)
        agente = AgenteBD.getAgente
        bbdd = agente.read("SELECT * FROM Conferencia WHERE Titulo='" & conferencia.nombre_ & "';")
        While bbdd.Read()
            conferencia.id_Conferencia = bbdd(0)
            conferencia.nombre_siglas = bbdd(1)
            conferencia.nombre_lugar = bbdd(3)
            conferencia.fechainicio = bbdd(4)
            conferencia.fechafin = bbdd(5)
        End While
    End Sub

    Public Sub readConferencia(ByVal investigador As Investigadores, ByVal conferencia As Conferencia) 'leer persona de la tabla ASISTE
        agente = AgenteBD.getAgente
        bbdd = agente.read("SELECT * FROM PARTICIPA WHERE Investigador=" & investigador.num_Id_Invest & " and Conferencia=" & conferencia.id_Conferencia & ";")
        While bbdd.Read()
            conferencia = New Conferencia()
            conferencia.id_Conferencia = bbdd(1)
            Me.lista.Add(conferencia)
        End While
    End Sub

    Public Sub create(ByVal conferencia As Conferencia)
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO Conferencia(Siglas,Nombre,Lugar,Fecha_inicio,Fecha_fin) VALUES('" & conferencia.nombre_siglas & "','" & conferencia.nombre_ & "'," & conferencia.nombre_lugar & "," & conferencia.fechainicio & ",'" & conferencia.fechafin & "');")
    End Sub

    Public Sub create(ByVal conferencia As Conferencia, ByVal articulo As Articulos)
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO PELI_GEN VALUES(" & conferencia.id_Conferencia & "," & articulo.id_articulo & ");")
    End Sub

    Public Sub create(ByVal investigador As Investigadores, ByVal conferencia As Conferencia, ByVal articulo As Articulos)
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO PARTICIPA VALUES(" & investigador.num_Id_Invest & "," & conferencia.id_Conferencia & " ," & articulo.id_articulo & ");")
    End Sub

    Public Sub update(ByVal conferencia As Conferencia)
        agente = AgenteBD.getAgente()
        num = agente.update("UPDATE Conferencias SET Titulo='" & conferencia.nombre_siglas & "' , TituloOriginal='" & conferencia.nombre_ & "' , AñoEstreno=" & conferencia.nombre_lugar & " , Duracion=" & conferencia.fechainicio & " , Sinopsis='" & conferencia.fechafin & "'WHERE IdPelicula=" & conferencia.id_Conferencia & ";")
    End Sub

    Public Sub delete(ByVal conferencia As Conferencia)
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM Conferencia WHERE Nombre='" & conferencia.nombre_ & "'")
        num = agente.delete("DELETE FROM ----- WHERE Conferencia=" & conferencia.id_Conferencia & "")
        num = agente.delete("DELETE FROM ASISTE WHERE Conferencia=" & conferencia.id_Conferencia & "")
    End Sub

    Public Sub delete(ByVal conferencia As Conferencia, ByVal articulo As Articulos)
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM PELI_GEN WHERE Pelicula=" & conferencia.id_Conferencia & "and Genero=" & articulo.id_articulo & "")
    End Sub

    Public Sub delete(ByVal investigador As Investigadores, ByVal conferencia As Conferencia, ByVal articulo As Articulos)
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM ASISTE WHERE Investigador=" & investigador.num_Id_Invest & "and Conferencia=" & conferencia.id_Conferencia & "and Articulo=" & articulo.id_articulo & "")
    End Sub
End Class
