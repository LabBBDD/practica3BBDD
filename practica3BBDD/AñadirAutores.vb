Public Class AñadirAutores

    Dim listIdInvest As Collection
    Dim listIdArt As Collection

    Private Sub btnAñadir_Click_1(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Dim aux As Autores

        If comprobarTxts() Then
            Try
                aux = New Autores(listIdInvest.Item(LBInvest.SelectedIndex),
                                  listIdArt.Item(LBArt.SelectedIndex),
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
        actualizarLB()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            practica3BBDD.Menu.getGestAut().update(New Autores(listIdInvest.Item(LBInvest.SelectedIndex + 1), listIdArt.Item(LBArt.SelectedIndex + 1), txtOrden.Text))
            actualizarLB()
        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show("Fallo en la base de datos." & vbCr & "No se ha podido modificar el registro")
        End Try
        actualizarLB()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If Not comprobarLBs() Then
            Try
                practica3BBDD.Menu.getGestAut().delete(New Autores(listIdInvest.Item(LBInvest.SelectedIndex + 1), listIdArt.Item(LBArt.SelectedIndex + 1), txtOrden.Text))
            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show("Fallo en la base de datos." & vbCr & "No se ha podido eliminar el registro")
            End Try
        End If
        actualizarLB()

    End Sub

    Private Sub LBInvest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBInvest.SelectedIndexChanged
        rellenarOrden()
    End Sub

    Private Sub LBArt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBArt.SelectedIndexChanged
        rellenarOrden()
    End Sub

    Private Sub AñadirAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarLB()

    End Sub

    Private Sub rellenarOrden()

        If comprobarLBs() Then

            txtOrden.Text = practica3BBDD.Menu.getGestAut().readAutor(listIdInvest.Item(LBInvest.SelectedIndex + 1), listIdArt.Item(LBArt.SelectedIndex + 1)).num_orden
            If txtOrden.Text.Length > 0 Then
                btnAñadir.Enabled = False
                btnEliminar.Enabled = True
                btnModificar.Enabled = True
            Else
                btnAñadir.Enabled = True
                btnEliminar.Enabled = False
                btnModificar.Enabled = False
            End If

        Else
            txtOrden.Clear()
            btnAñadir.Enabled = False
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        End If

    End Sub

    Private Function comprobarTxts()

        If (LBInvest.SelectedIndex > -1 AndAlso
                LBArt.SelectedIndex > -1 AndAlso
                txtOrden.Text.Length > 0) Then

            Return True
        Else
            Return False
        End If

    End Function

    Private Function comprobarLBs()

        If (LBInvest.SelectedIndex > -1 AndAlso
            LBArt.SelectedIndex > -1) Then

            Return True
        Else
            Return False
        End If

    End Function

    Private Sub actualizarLB()

        LBInvest.Items.Clear()
        listIdInvest = New Collection
        For Each aux As Investigadores In practica3BBDD.Menu.getGestInvest().lista
            LBInvest.Items.Add(aux.Nombre_Invest)
            listIdInvest.Add(aux.num_Id_Invest)
        Next
        LBArt.Items.Clear()
        listIdArt = New Collection
        For Each aux As Articulos In practica3BBDD.Menu.getGestArt().lista
            LBArt.Items.Add(aux.nombre_titulo)
            listIdArt.Add(aux.id_articulo)
        Next

    End Sub

End Class