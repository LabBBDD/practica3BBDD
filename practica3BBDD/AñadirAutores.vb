Public Class AñadirAutores
    Dim autor As Autores
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub LabelNombre_Click(sender As Object, e As EventArgs) Handles LabelNombre.Click

    End Sub

    Private Sub btnAñadir_Click_1(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If Not String.IsNullOrEmpty(txtOrden.Text) Then
            Try
                autor = New Autores(txtInvest.Text, txtArticulo.Text, txtOrden.Text)
                autor.añadir()
                AñadirAutores_Load(sender, e)
            Catch ex As System.Data.OleDb.OleDbException
                MsgBox("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "El atributo ID está repetido, por favor cambie dicho atributo para el nuevo registro.")
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("FALLO AL AÑADIR EL REGISTRO.")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub AñadirAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox.Items.Clear()
        autor = New Autores(txtInvest.Text, txtArticulo.Text, txtOrden.Text)
        autor.leerTodo()


    End Sub
End Class