Public Class Menu

    Dim gestorConf As GestorConferencia
    Dim gestorInvest As GestorInvestigadores
    Dim gestorArt As GestorArticulos
    Dim gestorAutor As GestorAutores
    Dim gestorAsiste As GestorAsiste
    Dim investActual As Investigadores
    Dim confActual As Conferencia

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

    Private Sub BtnCurriculum_Click(sender As Object, e As EventArgs) Handles BtnCurriculum.Click
        Curriculum.Show()
    End Sub

    Private Sub BtnAsistir_Click(sender As Object, e As EventArgs) Handles BtnAsistir.Click
        getGestAsiste().create(investActual.num_Id_Invest, ListBoxConferencias.SelectedItem)
        actualizarLB()
    End Sub

    Private Sub btnNoAsistir_Click(sender As Object, e As EventArgs) Handles btnNoAsistir.Click
        getGestAsiste().delete(investActual.num_Id_Invest, ListBoxConferencias.SelectedItem)
        actualizarLB()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarLB()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AgenteBD.getAgente()

        actualizarLB()

        gestorArt = New GestorArticulos()
        gestorArt.readAll()

        gestorAutor = New GestorAutores()
        gestorAutor.readAll()

        gestorAsiste = New GestorAsiste()
        gestorAsiste.readAll()

    End Sub

    Private Sub ListBoxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInvestigadores.SelectedIndexChanged

        If (ListBoxInvestigadores.SelectedIndex > -1) Then
            investActual = getGestInvest().readInvestigador(ListBoxInvestigadores.SelectedItem)
            BtnCurriculum.Enabled = True
        Else
            investActual = Nothing
            BtnCurriculum.Enabled = False
        End If

        If comprobarLb() Then
            If comprobarAsistencia() Then
                btnNoAsistir.Enabled = True
                BtnAsistir.Enabled = False
            Else
                BtnAsistir.Enabled = True
                btnNoAsistir.Enabled = False
            End If
        Else
            btnNoAsistir.Enabled = False
            BtnAsistir.Enabled = False
        End If



    End Sub

    Private Sub ListBoxConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxConferencias.SelectedIndexChanged

        If (ListBoxConferencias.SelectedIndex > -1) Then
            confActual = getGestConf().readConferencia(ListBoxConferencias.SelectedItem)
        End If

        If comprobarLb() Then
            If comprobarAsistencia() Then
                btnNoAsistir.Enabled = True
                BtnAsistir.Enabled = False
            Else
                BtnAsistir.Enabled = True
                btnNoAsistir.Enabled = False
            End If
        Else
            btnNoAsistir.Enabled = False
            BtnAsistir.Enabled = False
        End If

    End Sub

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

    Public Function getGestAsiste() As GestorAsiste
        Return gestorAsiste
    End Function

    Public Function getDatosCV() As Investigadores
        Return investActual
    End Function

    Public Function comprobarLb()

        If (ListBoxConferencias.SelectedIndex > -1 AndAlso
                ListBoxInvestigadores.SelectedIndex > -1) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function comprobarAsistencia()

        If (getGestAsiste.readAsistencia(investActual.num_Id_Invest, ListBoxConferencias.SelectedItem)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub actualizarLB()

        gestorInvest = New GestorInvestigadores()
        gestorInvest.readAll()
        ListBoxInvestigadores.Items.Clear()
        For Each pAux As Investigadores In gestorInvest.lista
            ListBoxInvestigadores.Items.Add(pAux.Nombre_Invest)
        Next

        gestorConf = New GestorConferencia()
        gestorConf.readAll()
        ListBoxConferencias.Items.Clear()
        For Each pAux1 As Conferencia In gestorConf.lista
            ListBoxConferencias.Items.Add(pAux1.id_Conferencia)
        Next

        ListBoxConferencias.SelectedIndex = -1
        ListBoxInvestigadores.SelectedIndex = -1
        btnNoAsistir.Enabled = False
        BtnAsistir.Enabled = False
        BtnCurriculum.Enabled = False

    End Sub

    Public Function abrirBD() As String

        Dim ventanaAbrirBBDD As New OpenFileDialog()
        ventanaAbrirBBDD.Title = "Selecciona una base de datos"
        ventanaAbrirBBDD.Filter = "Archivos de base de datos|*.accdb"

        If ventanaAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Return ventanaAbrirBBDD.FileName
        Else
            Me.Close()
        End If

    End Function

End Class