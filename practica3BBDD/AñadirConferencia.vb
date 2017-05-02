Public Class AñadirConferencia

    Dim conferenciaActual As Conferencia

    Private Sub loadFormAnConf(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarLB()

    End Sub

    Private Sub LBConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBConferencias.SelectedIndexChanged

        conferenciaActual = practica3BBDD.Menu.getGestConf().readConferencia(LBConferencias.SelectedItem)

        txtIdConferencia.Text = conferenciaActual.id_Conferencia
        txtSiglas.Text = conferenciaActual.nombre_siglas
        txtNombre.Text = conferenciaActual.nombre_
        txtLugar.Text = conferenciaActual.nombre_lugar
        txtFechaInicio.Text = conferenciaActual.fechainicio
        txtFechaFin.Text = conferenciaActual.fechafin

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        If comprobarTxts() Then
            Dim aux As Conferencia
            Try
                aux = New Conferencia(txtIdConferencia.Text,
                                      txtSiglas.Text,
                                      txtNombre.Text,
                                      txtLugar.Text,
                                      txtFechaInicio.Text,
                                      txtFechaFin.Text)
                practica3BBDD.Menu.getGestConf().create(aux)
            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "No se ha podido añadir la conferencia.")
                Exit Sub
            End Try
        Else
            MessageBox.Show("Rellene todos los campos e intentelo de nuevo")
        End If
        actualizarLB()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If Not (LBConferencias.SelectedIndex = -1) Then
            Try
                practica3BBDD.Menu.getGestConf().delete(conferenciaActual)
                actualizarLB()
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

        Dim confMod As Conferencia
        confMod = New Conferencia(txtIdConferencia.Text,
                                  txtSiglas.Text,
                                  txtNombre.Text,
                                  txtLugar.Text,
                                  txtFechaInicio.Text,
                                  txtFechaFin.Text)

        Try
            practica3BBDD.Menu.getGestConf().update(confMod, conferenciaActual)
            actualizarLB()
        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show("Fallo en la base de datos." & vbCr & vbCr &
                            "No se ha podido modificar el registro." & vbCr &
                            "Compruebe que el atributo ID no esté repetido")
        End Try

    End Sub

    Private Function comprobarTxts()

        If (txtFechaFin.Text.Length > 0 AndAlso
            txtFechaInicio.Text.Length > 0 AndAlso
            txtIdConferencia.Text.Length > 0 AndAlso
            txtLugar.Text.Length > 0 AndAlso
            txtNombre.Text.Length > 0 AndAlso
            txtSiglas.Text.Length > 0) Then

            Return True
        Else
            Return False
        End If

    End Function

    Private Sub actualizarLB()

        LBConferencias.Items.Clear()
        For Each aux As Conferencia In practica3BBDD.Menu.getGestConf().lista
            LBConferencias.Items.Add(aux.nombre_)
        Next

    End Sub

End Class