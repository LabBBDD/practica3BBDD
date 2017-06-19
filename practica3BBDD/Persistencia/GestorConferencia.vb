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
        lista = New Collection
        agente = AgenteBD.getAgente()
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
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM CONFERENCIAS WHERE Nombre='" & nombreConf & "';")
        While bbdd.Read()
            Return New Conferencia(bbdd.Item(0),
                                   bbdd.Item(1),
                                   bbdd.Item(2),
                                   bbdd.Item(3),
                                   bbdd.Item(4),
                                   bbdd.Item(5))
        End While

    End Function

    Public Function readIdConf(idConf As Integer) As Conferencia

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM CONFERENCIAS WHERE idConferencia=" & idConf & ";")
        While bbdd.Read()
            Return New Conferencia(bbdd.Item(0),
                                   bbdd.Item(1),
                                   bbdd.Item(2),
                                   bbdd.Item(3),
                                   bbdd.Item(4),
                                   bbdd.Item(5))
        End While

    End Function

    Public Sub create(ByVal conferencia As Conferencia)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO CONFERENCIAS(idConferencia,Siglas,Nombre,Lugar,Fecha_inicio,Fecha_fin) VALUES(" & conferencia.id_Conferencia & ",'" & conferencia.nombre_siglas & "','" & conferencia.nombre_ & "','" & conferencia.nombre_lugar & "','" & conferencia.fechainicio & "','" & conferencia.fechafin & "');")
        readAll()

    End Sub

    Public Sub update(ByVal conferencia As Conferencia, confOriginal As Conferencia)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.update("UPDATE CONFERENCIAS SET Siglas='" & conferencia.nombre_siglas & "' , Nombre='" & conferencia.nombre_ & "' , Lugar='" & conferencia.nombre_lugar & "' , Fecha_inicio='" & conferencia.fechainicio & "' , Fecha_fin='" & conferencia.fechafin & "' WHERE idConferencia=" & confOriginal.id_Conferencia & ";")
        readAll()

    End Sub

    Public Sub delete(ByVal conferencia As Conferencia)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        agente.delete("DELETE FROM CONFERENCIAS WHERE idConferencia=" & conferencia.id_Conferencia & ";")
        agente.delete("DELETE FROM ASISTE WHERE Conferencia=" & conferencia.id_Conferencia & ";")
        readAll()

    End Sub
End Class
