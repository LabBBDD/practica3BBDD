Imports System.Data.OleDb

Public Class GestorConferencia

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
        Dim aux As Conferencia
        agente = Menu.getAgente()
        bbdd = agente.read("SELECT * FROM CONFERENCIAS")
        While bbdd.Read()
            If IsDBNull(bbdd(5)) Then
                aux = New Conferencia(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4), False)
            Else
                aux = New Conferencia(bbdd(0), bbdd(1), bbdd(2), bbdd(3), bbdd(4), bbdd(5))
            End If
            lista.Add(aux)
        End While

    End Sub

    Public Function readConferencia(nombreConf As String) As Conferencia

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        bbdd = agente.read("SELECT * FROM CONFERENCIAS WHERE Titulo='" & nombreConf & "';")
        While bbdd.Read()
            Return bbdd.Item(0)
        End While

    End Function

    Public Sub create(ByVal conferencia As Conferencia)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.create("INSERT INTO CONFERENCIAS(idConferencia,Siglas,Nombre,Lugar,Fecha_inicio,Fecha_fin) VALUES('" & conferencia.id_Conferencia & "','" & conferencia.nombre_siglas & "','" & conferencia.nombre_ & "'," & conferencia.nombre_lugar & "," & conferencia.fechainicio & ",'" & conferencia.fechafin & "');")
        readAll()

    End Sub

    Public Sub update(ByVal conferencia As Conferencia)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.update("UPDATE CONFERENCIAS SET idConferencia='" & conferencia.id_Conferencia & "' , Siglas='" & conferencia.nombre_siglas & "' , Nombre='" & conferencia.nombre_ & "' , Lugar='" & conferencia.nombre_lugar & "' , Fecha_inicio='" & conferencia.fechainicio & "' , Fecha_fin='" & conferencia.fechafin & "';")
        readAll()

    End Sub

    Public Sub delete(ByVal conferencia As Conferencia)

        Dim agente As AgenteBD
        agente = Menu.getAgente()
        num = agente.delete("DELETE FROM CONFERENCIAS WHERE idConferencia='" & conferencia.id_Conferencia & "';")
        num = agente.delete("DELETE FROM ASISTE WHERE Conferencia='" & conferencia.id_Conferencia & "';")
        readAll()

    End Sub
End Class
