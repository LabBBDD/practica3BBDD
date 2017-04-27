<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirInvestigadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtIdInvest = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDespacho = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtEdificio = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(21, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(135, 212)
        Me.ListBox1.TabIndex = 1
        '
        'txtIdInvest
        '
        Me.txtIdInvest.Location = New System.Drawing.Point(251, 25)
        Me.txtIdInvest.Name = "txtIdInvest"
        Me.txtIdInvest.Size = New System.Drawing.Size(100, 20)
        Me.txtIdInvest.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(251, 51)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtDespacho
        '
        Me.txtDespacho.Location = New System.Drawing.Point(251, 103)
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.Size = New System.Drawing.Size(100, 20)
        Me.txtDespacho.TabIndex = 4
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(251, 77)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidos.TabIndex = 5
        '
        'txtEdificio
        '
        Me.txtEdificio.Location = New System.Drawing.Point(251, 129)
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.Size = New System.Drawing.Size(100, 20)
        Me.txtEdificio.TabIndex = 6
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(251, 155)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartamento.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(251, 181)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "IDInvest"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Despacho"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Edificio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(249, 206)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 17
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(388, 54)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 18
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(388, 122)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(388, 184)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'AñadirInvestigadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 262)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtEdificio)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtDespacho)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdInvest)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "AñadirInvestigadores"
        Me.Text = "AñadirInvestigadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtIdInvest As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDespacho As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtEdificio As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
End Class
