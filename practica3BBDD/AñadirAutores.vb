Public Class AñadirAutores

    Private Sub btnAñadir_Click_1(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Dim aux As Autores

        If comprobarTxts() Then
            Try
                aux = New Autores(txtInvest.Text,
                                  txtArticulo.Text,
                                  txtOrden.Text)
                practica3BBDD.Menu.getGestAut().create(aux)

            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "El atributo ID está repetido, por favor cambie dicho atributo para el nuevo registro.")
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("FALLO AL AÑADIR EL REGISTRO.")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub AñadirAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarLB()

    End Sub

    Private Function comprobarTxts()

        If (txtArticulo.Text.Length > 0 AndAlso
                txtInvest.Text.Length > 0 AndAlso
                txtOrden.Text.Length > 0) Then

            Return True
        Else
            Return False
        End If

    End Function

    Private Sub actualizarLB()

        LBAutores.Items.Clear()
        For Each aux As Conferencia In practica3BBDD.Menu.getGestAut().lista
            LBAutores.Items.Add(aux.nombre_)
        Next

    End Sub

End Class