Public Class Form1

    Dim ruta As String

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
End Class
