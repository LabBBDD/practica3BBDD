Public Class AñadirInvestigadores

    Dim investigadorActual As Investigadores

    Private Sub loadFormAnInvest(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarLB()

    End Sub

    Public Sub LBInvestigadoresSelectedIndexChanged(sender As Object, e As EventArgs) Handles LBInvestigadores.SelectedIndexChanged

        investigadorActual = practica3BBDD.Menu.getGestInvest().readInvestigador(LBInvestigadores.SelectedItem)

        txtIdInvest.Text = investigadorActual.num_Id_Invest
        txtNombre.Text = investigadorActual.Nombre_Invest
        txtApellidos.Text = investigadorActual.Apellido_Invest
        txtDespacho.Text = investigadorActual.nombre_Despacho
        txtEdificio.Text = investigadorActual.nombre_Edificio
        txtDepartamento.Text = investigadorActual.nombre_Departamento
        txtTelefono.Text = investigadorActual.num_Telefono
        txtEmail.Text = investigadorActual.direccion_email

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        If comprobarTxts() Then
            Dim aux As Investigadores
            Try
                aux = New Investigadores(txtIdInvest.Text,
                                         txtNombre.Text,
                                         txtApellidos.Text,
                                         txtDespacho.Text,
                                         txtEdificio.Text,
                                         txtDepartamento.Text,
                                         txtTelefono.Text,
                                         txtEmail.Text)
                practica3BBDD.Menu.getGestInvest().create(aux)
                actualizarLB()
            Catch ex As System.Data.OleDb.OleDbException
                MsgBox("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "No se ha podido añadir el investigador.")
                Exit Sub
            End Try
        Else
            MessageBox.Show("Rellene todos los campos e intentelo de nuevo")
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If Not (LBInvestigadores.SelectedIndex = -1) Then
            Try
                practica3BBDD.Menu.getGestInvest().delete(investigadorActual)
            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "No se ha podido eliminar el registro.")
                Exit Sub
            End Try
        Else
            MessageBox.Show("Seleccione un investigador para eliminarlo")
        End If
        actualizarLB()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        investigadorActual.num_Id_Invest = txtIdInvest.Text
        investigadorActual.Nombre_Invest = txtNombre.Text
        investigadorActual.Apellido_Invest = txtApellidos.Text
        investigadorActual.nombre_Despacho = txtDespacho.Text
        investigadorActual.nombre_Edificio = txtEdificio.Text
        investigadorActual.nombre_Departamento = txtDepartamento.Text
        investigadorActual.num_Telefono = txtTelefono.Text
        investigadorActual.direccion_email = txtEdificio.Text

        Try
            practica3BBDD.Menu.getGestInvest().update(investigadorActual)
            actualizarLB()
        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show("FALLO EN LA BASE DE DATOS." & vbCr & vbCr &
                            "No se ha podido modificar el registro." & vbCr &
                            "Compruebe que el atributo ID no esté repetido")
            Exit Sub
        End Try

    End Sub

    Private Function comprobarTxts()

        If (txtNombre.Text.Length > 0 AndAlso
            txtApellidos.Text.Length > 0 AndAlso
            txtDepartamento.Text.Length > 0 AndAlso
            txtDespacho.Text.Length > 0 AndAlso
            txtEdificio.Text.Length > 0 AndAlso
            txtEmail.Text.Length > 0 AndAlso
            txtIdInvest.Text.Length > 0 AndAlso
            txtTelefono.Text.Length > 0) Then

            Return True
        Else
            Return False
        End If

    End Function

    Private Sub actualizarLB()

        LBInvestigadores.Items.Clear()
        For Each aux As Investigadores In practica3BBDD.Menu.getGestInvest().lista
            LBInvestigadores.Items.Add(aux.Nombre_Invest)
        Next

    End Sub

End Class