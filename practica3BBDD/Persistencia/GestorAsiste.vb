Imports System.Data.OleDb

Public Class GestorAsiste

    Dim bbdd As OleDbDataReader
    Dim num As Integer
    Dim listaNom_Invest As Collection
    Dim listaId_Invest As Collection
    Dim listaNom_Conf As Collection
    Dim listaId_Conf As Collection

    Public Property listaNomInvest As Collection

        Get
            Return listaNom_Invest
        End Get
        Set(value As Collection)
            listaNom_Invest = value
        End Set

    End Property

    Public Property listaIdInvest As Collection

        Get
            Return listaId_Invest
        End Get
        Set(value As Collection)
            listaId_Invest = value
        End Set

    End Property

    Public Property listaNomConf As Collection

        Get
            Return listaNom_Conf
        End Get
        Set(value As Collection)
            listaNom_Conf = value
        End Set

    End Property

    Public Property listaIdConf As Collection

        Get
            Return listaId_Conf
        End Get
        Set(value As Collection)
            listaId_Conf = value
        End Set

    End Property

    Public Sub New()

        readAll()

    End Sub

    Public Sub readAll()

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM ASISTE")
        listaNomInvest = New Collection
        listaIdInvest = New Collection
        listaNomConf = New Collection
        listaIdConf = New Collection
        While bbdd.Read()

            listaIdConf.Add(bbdd.Item(0))
            listaIdInvest.Add(bbdd.Item(1))
            listaNomConf.Add(Menu.getGestConf().readConferencia(bbdd.Item(0)))
            listaNomInvest.Add(Menu.getGestInvest().readInvestigador(bbdd.Item(1)))

        End While

    End Sub

    Public Function readConferencias(ByVal investigador As Investigadores) As Collection

        Dim agente As AgenteBD
        Dim lista As Collection
        lista = New Collection
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM ASISTE WHERE Invest=" & investigador.num_Id_Invest & ";")
        While bbdd.Read()
            lista.Add(bbdd.Item(0))
        End While
        Return lista

    End Function

    Public Function readArticulos(ByVal investigador As Investigadores) As Collection

        Dim agente As AgenteBD
        Dim lista As Collection
        lista = New Collection
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM AUTOR WHERE Invest=" & investigador.num_Id_Invest & ";")
        While bbdd.Read()
            lista.Add(bbdd.Item(1))
        End While
        Return lista

    End Function

    Public Function readAsistencia(idInvest As Integer, idConf As Integer)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        bbdd = agente.read("SELECT * FROM ASISTE WHERE Conferencia=" & idConf & " AND Invest=" & idInvest & ";")
        While bbdd.Read()
            Return True
        End While
        Return False

    End Function

    Public Sub create(idInvest As Integer, idConf As Integer)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.create("INSERT INTO ASISTE(Conferencia, Invest) VALUES(" & idConf & "," & idInvest & ");")
        readAll()

    End Sub

    Public Sub delete(idInvest As Integer, idConf As Integer)

        Dim agente As AgenteBD
        agente = AgenteBD.getAgente()
        num = agente.delete("DELETE FROM ASISTE WHERE Conferencia=" & idConf & " AND Invest=" & idInvest & ";")
        readAll()

    End Sub

End Class
