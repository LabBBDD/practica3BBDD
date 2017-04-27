Public Class AñadirInvestigadores

    Private investigador As Investigadores

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtDepartamento.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        investigador = New Investigadores()
        investigador.leer()
        txtIdInvest.Text = investigador.num_Id_Invest
        txtNombre.Text = investigador.Nombre_Invest
        txtApellidos.Text = investigador.Apellido_Invest
        txtDespacho.Text = investigador.nombre_Despacho
        txtEdificio.Text = investigador.nombre_Edificio
        txtDepartamento.Text = investigador.nombre_Departamento
        txtTelefono.Text = investigador.num_Telefono
        txtEmail.Text = investigador.direccion_email
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If Not String.IsNullOrEmpty(txtNombre.Text) Then
            Try
                investigador = New Investigadores(txtIdInvest.Text, txtNombre.Text, txtApellidos.Text, txtDespacho.Text, txtEdificio.Text, txtDepartamento.Text, txtTelefono.Text, txtEmail.Text)
                investigador.añadir()
                AñadirInvestigadores_Load(sender, e)
            Catch ex As System.Data.OleDb.OleDbException
                MsgBox("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "Recuerde que el campo NOMBRE es obligatorio.")
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("FALLO AL AÑADIR EL REGISTRO.")
            End Try
        Else
            MessageBox.Show("Recuerde que el campo NOMBRE es obligatorio.")
        End If
    End Sub

    Private Sub AñadirInvestigadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        'Menu.ListBoxInvestigadores.Items.Clear()
        investigador = New Investigadores
        investigador.leerTodo()
        Dim pAux As Investigadores
        For Each pAux In investigador._gestor.lista
            ListBox1.Items.Add(pAux.Nombre_Invest)
            'Menu.ListBoxInvestigadores.Items.Add(pAux.Nombre_Invest)
        Next
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            investigador.borrar()
            AñadirInvestigadores_Load(sender, e)
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "El atributo ID está repetido, por favor cambie dicho atributo para el nuevo registro.")
            Exit Sub
        Catch ex As Exception
            MsgBox("FALLO AL ELIMINAR EL REGISTRO")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        investigador.num_Id_Invest = txtIdInvest.Text
        investigador.Nombre_Invest = txtNombre.Text
        investigador.Apellido_Invest = txtApellidos.Text
        investigador.nombre_Despacho = txtDespacho.Text
        investigador.nombre_Edificio = txtEdificio.Text
        investigador.nombre_Departamento = txtDepartamento.Text
        investigador.num_Telefono = txtTelefono.Text
        investigador.direccion_email = txtEdificio.Text
        Try
            investigador.actualizar()
            AñadirInvestigadores_Load(sender, e)
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("FALLO EN LA BASE DE DATOS." & vbCr & vbCr & "El atributo ID está repetido, por favor cambie dicho atributo para el nuevo registro.")
            Exit Sub
        Catch ex As Exception
            MsgBox("FALLO AL MODIFICAR EL NUEVO REGISTRO")
        End Try
    End Sub
End Class