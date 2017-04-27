Public Class Form1

    Dim ruta As String
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
    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load

        If MessageBox.Show("¿Quieres abrir una base de datos?", "nueva sesion", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim ventanaAbrirBD As New OpenFileDialog()
            ventanaAbrirBD.Title = "Selecciona una base de datos"
            ventanaAbrirBD.Filter = "Archivos de base de datos|*.accdb"

            If ventanaAbrirBD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ventanaAbrirBD.OpenFile()
                ruta = ventanaAbrirBD.FileName
            End If
        End If


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
