Public Class AñadirConferencia
    Dim conferencia As Conferencia
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

    End Sub

    Private Sub AñadirConferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not IsNothing(ComboBoxGENERO.SelectedItem) Or Not IsNothing(ListBox1.SelectedItem) Then
            Try
                conferencia.borrar()
            Catch ex As System.Data.OleDb.OleDbException
                MessageBox.Show("FALLO EN LA BASE DE DATOS")
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("FALLO NO REGISTRADO")
            End Try
        Else
            Try
                conferencia.borrar()
            Catch ex As System.Data.OleDb.OleDbException
                MsgBox("FALLO EN LA BASE DE DATOS.")
                Exit Sub
            Catch ex As Exception
                MsgBox("FALLO NO REGISTRADO")
            End Try
        End If
        AñadirConferencia_Load(sender, e)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        conferencia = New Conferencia(ListBox.SelectedItem)
        conferencia.leer()
        txtIdConferencia.Text = conferencia.id_Conferencia
        txtSiglas.Text = conferencia.nombre_siglas
        txtNombre.Text = conferencia.nombre_
        txtLugar.Text = conferencia.nombre_lugar
        txtFechaInicio.Text = conferencia.fechainicio
        txtFechaFin.Text = conferencia.fechafin

        'CARGAR LISTBOX CON LOS GENEROS ATRIBUIDOS
        ListBox1.Items.Clear()
        conferencia = New Conferencia
        conferencia.leerTodo()
        For Each pAux2 As Generos In genero.gestor.lista
            genero = New Generos
            genero.leer(pelicula)
            If Not genero.gestor.lista Is Nothing Then
                For Each pAux3 As Generos In genero.gestor.lista
                    If pAux2.idGenero = pAux3.idGenero Then
                        'generos en los que si estamos
                        ListBox1.Items.Add(pAux2.descGenero)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        conferencia.id_Conferencia = txtIdConferencia.Text
        conferencia.nombre_siglas = txtSiglas.Text
        conferencia.nombre_ = txtNombre.Text
        conferencia.nombre_lugar = txtLugar.Text
        conferencia.fechainicio = txtFechaInicio.Text
        conferencia.fechafin = txtFechaFin.Text
    End Sub
End Class