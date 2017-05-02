Public Class Menu

    Dim gestorConf As GestorConferencia
    Dim gestorInvest As GestorInvestigadores
    Dim gestorArt As GestorArticulos
    Dim gestorAutor As GestorAutores
    Dim agente As AgenteBD

    Private Sub btnInvestigador_Click(sender As Object, e As EventArgs) Handles btnInvestigador.Click
        AñadirInvestigadores.Show()
    End Sub

    Private Sub btnConferencia_Click(sender As Object, e As EventArgs) Handles btnConferencia.Click
        AñadirConferencia.Show()
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        AñadirArticulos.Show()
    End Sub

    Private Sub btnAutor_Click(sender As Object, e As EventArgs) Handles btnAutor.Click
        AñadirAutores.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ventanaAbrirBBDD As New OpenFileDialog()
        ventanaAbrirBBDD.Title = "Selecciona una base de datos"
        ventanaAbrirBBDD.Filter = "Archivos de base de datos|*.accdb"

        If ventanaAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'Me.Cursor = New Cursor(ventanaAbrirBBDD.OpenFile())
            agente = New AgenteBD(ventanaAbrirBBDD.FileName)
        End If

        gestorInvest = New GestorInvestigadores()
        gestorInvest.readAll()
        For Each pAux As Investigadores In gestorInvest.lista
            ListBoxInvestigadores.Items.Add(pAux.num_Id_Invest)
        Next

        gestorConf = New GestorConferencia()
        gestorConf.readAll()
        For Each pAux1 As Conferencia In gestorConf.lista
            ListBoxConferencias.Items.Add(pAux1.id_Conferencia)
        Next

        gestorArt = New GestorArticulos()
        gestorArt.readAll()

    End Sub

    Private Sub ListBoxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInvestigadores.SelectedIndexChanged

    End Sub

    Private Sub ListBoxConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxConferencias.SelectedIndexChanged

    End Sub

    Public Function getAgente() As AgenteBD
        Return agente
    End Function

    Public Function getGestInvest() As GestorInvestigadores
        Return gestorInvest
    End Function

    Public Function getGestConf() As GestorConferencia
        Return gestorConf
    End Function

    Public Function getGestArt() As GestorArticulos
        Return gestorArt
    End Function

    Public Function getGestAut() As GestorAutores
        Return gestorAutor
    End Function

End Class