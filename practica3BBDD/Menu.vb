Public Class Menu

    Dim investigador As Investigadores
    Dim conferencia As Conferencia

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
        investigador = New Investigadores
        investigador.leerTodo()
        For Each pAux As Investigadores In investigador._gestor.lista
            ListBoxInvestigadores.Items.Add(pAux.num_Id_Invest)
        Next
        conferencia = New Conferencia
        conferencia.leerTodo()
        For Each pAux1 As Conferencia In conferencia._gestor.lista
            ListBoxConferencias.Items.Add(pAux1.id_Conferencia)
        Next
    End Sub

    Private Sub btnAbrirBD_Click(sender As Object, e As EventArgs) Handles btnAbrirBD.Click
        Dim ventanaAbrirBBDD As New OpenFileDialog()
        ventanaAbrirBBDD.Title = "Selecciona una base de datos"
        ventanaAbrirBBDD.Filter = "Archivos de base de datos|*.accbd"

        If ventanaAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.Cursor = New Cursor(ventanaAbrirBBDD.OpenFile())
            lblRuta.Text = ventanaAbrirBBDD.FileName
        End If

    End Sub

    Private Sub ListBoxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInvestigadores.SelectedIndexChanged
        investigador = New Investigadores(ListBoxInvestigadores.SelectedItem)
        investigador.leer()
    End Sub

    Private Sub ListBoxConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxConferencias.SelectedIndexChanged
        conferencia = New Conferencia(ListBoxConferencias.SelectedItem)
        conferencia.leer()
    End Sub
End Class