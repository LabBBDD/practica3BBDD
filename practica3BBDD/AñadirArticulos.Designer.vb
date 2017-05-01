<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirArticulos
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
        Me.LBArticulos = New System.Windows.Forms.ListBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtConferencia = New System.Windows.Forms.TextBox()
        Me.txtPagInicio = New System.Windows.Forms.TextBox()
        Me.txtPagFin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBArticulos
        '
        Me.LBArticulos.FormattingEnabled = True
        Me.LBArticulos.Location = New System.Drawing.Point(12, 27)
        Me.LBArticulos.Name = "LBArticulos"
        Me.LBArticulos.Size = New System.Drawing.Size(135, 212)
        Me.LBArticulos.TabIndex = 0
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(249, 39)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdArticulo.TabIndex = 1
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(249, 80)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 2
        '
        'txtConferencia
        '
        Me.txtConferencia.Location = New System.Drawing.Point(249, 122)
        Me.txtConferencia.Name = "txtConferencia"
        Me.txtConferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtConferencia.TabIndex = 3
        '
        'txtPagInicio
        '
        Me.txtPagInicio.Location = New System.Drawing.Point(249, 165)
        Me.txtPagInicio.Name = "txtPagInicio"
        Me.txtPagInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtPagInicio.TabIndex = 4
        '
        'txtPagFin
        '
        Me.txtPagFin.Location = New System.Drawing.Point(249, 203)
        Me.txtPagFin.Name = "txtPagFin"
        Me.txtPagFin.Size = New System.Drawing.Size(100, 20)
        Me.txtPagFin.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Titulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Conferencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pag Inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pag Fin"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(379, 60)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 11
        Me.btnAñadir.Text = "Añadir "
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(379, 120)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(379, 184)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'AñadirArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 262)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPagFin)
        Me.Controls.Add(Me.txtPagInicio)
        Me.Controls.Add(Me.txtConferencia)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.LBArticulos)
        Me.Name = "AñadirArticulos"
        Me.Text = "AñadirArticulos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBArticulos As ListBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtConferencia As TextBox
    Friend WithEvents txtPagInicio As TextBox
    Friend WithEvents txtPagFin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
End Class
