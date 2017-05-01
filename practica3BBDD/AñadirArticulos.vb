Public Class AñadirArticulos

    Dim articuloActual As Articulos

    Private Sub LBArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBArticulos.SelectedIndexChanged

        articuloActual = practica3BBDD.Menu.getGestArt().readArticulo(LBArticulos.SelectedItem)

        txtConferencia.Text = articuloActual.nombre_conferencia
        txtIdArticulo.Text = articuloActual.id_articulo
        txtPagFin.Text = articuloActual.num_pag_fin
        txtPagInicio.Text = articuloActual.num_pag_inicio
        txtTitulo.Text = articuloActual.nombre_titulo

    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        If comprobarTxts() Then
            Dim aux As Articulos
            Try
                aux = New Articulos(txtIdArticulo.Text,
                                    txtTitulo.Text,
                                    txtConferencia.Text,
                                    txtPagInicio.Text,
                                    txtPagFin.Text)

                practica3BBDD.Menu.getGestArt().create(aux)

            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "No se ha podido añadir la conferencia.")
            End Try
        Else
            MessageBox.Show("Rellene todos los campos e intentelo de nuevo")
        End If

    End Sub

    Private Sub loadFormAnArt(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarLB()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If Not (LBArticulos.SelectedIndex = -1) Then
            Try
                practica3BBDD.Menu.getGestArt().delete(articuloActual)
            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "No se ha podido eliminar el registro.")
                Exit Sub
            End Try
        Else
            MessageBox.Show("Seleccione una conferencia para eliminarla")
        End If
        actualizarLB()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        articuloActual.id_articulo = txtIdArticulo.Text
        articuloActual.nombre_conferencia = txtConferencia.Text
        articuloActual.nombre_titulo = txtTitulo.Text
        articuloActual.num_pag_inicio = txtPagInicio.Text
        articuloActual.num_pag_fin = txtPagFin.Text

        Try
            practica3BBDD.Menu.getGestArt().update(articuloActual)
            actualizarLB()
        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show("Fallo en la base de datos." & vbCr & vbCr &
                            "No se ha podido modificar el registro." & vbCr &
                            "Compruebe que el atributo ID no esté repetido")
        End Try

    End Sub

    Private Function comprobarTxts()

        If (txtIdArticulo.Text.Length > 0 AndAlso
            txtConferencia.Text.Length > 0 AndAlso
            txtPagFin.Text.Length > 0 AndAlso
            txtPagInicio.Text.Length > 0 AndAlso
            txtTitulo.Text.Length > 0) Then

            Return True
        Else
            Return False
        End If

    End Function

    Private Sub actualizarLB()

        LBArticulos.Items.Clear()
        For Each aux As Articulos In practica3BBDD.Menu.getGestArt().lista
            LBArticulos.Items.Add(aux.nombre_titulo)
        Next

    End Sub

End Class