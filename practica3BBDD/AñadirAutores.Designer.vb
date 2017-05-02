<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirAutores
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
        Me.LBAutores = New System.Windows.Forms.ListBox()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtInvest = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtArticulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBAutores
        '
        Me.LBAutores.FormattingEnabled = True
        Me.LBAutores.Location = New System.Drawing.Point(20, 19)
        Me.LBAutores.Name = "LBAutores"
        Me.LBAutores.Size = New System.Drawing.Size(256, 225)
        Me.LBAutores.TabIndex = 125
        '
        'txtOrden
        '
        Me.txtOrden.ForeColor = System.Drawing.Color.Black
        Me.txtOrden.Location = New System.Drawing.Point(400, 75)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(138, 20)
        Me.txtOrden.TabIndex = 124
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(400, 220)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(87, 24)
        Me.btnModificar.TabIndex = 121
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadir.ForeColor = System.Drawing.Color.Black
        Me.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAñadir.Location = New System.Drawing.Point(312, 220)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(82, 24)
        Me.btnAñadir.TabIndex = 120
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.ForeColor = System.Drawing.Color.Black
        Me.LabelNombre.Location = New System.Drawing.Point(309, 75)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(36, 13)
        Me.LabelNombre.TabIndex = 123
        Me.LabelNombre.Text = "Orden"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(493, 220)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(89, 24)
        Me.btnEliminar.TabIndex = 122
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtInvest
        '
        Me.txtInvest.AutoSize = True
        Me.txtInvest.Location = New System.Drawing.Point(310, 22)
        Me.txtInvest.Name = "txtInvest"
        Me.txtInvest.Size = New System.Drawing.Size(36, 13)
        Me.txtInvest.TabIndex = 126
        Me.txtInvest.Text = "Invest"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(400, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 127
        '
        'TextBox2
        '
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(400, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 129
        '
        'txtArticulo
        '
        Me.txtArticulo.AutoSize = True
        Me.txtArticulo.Location = New System.Drawing.Point(310, 48)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(42, 13)
        Me.txtArticulo.TabIndex = 128
        Me.txtArticulo.Text = "Articulo"
        '
        'AñadirAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 262)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtInvest)
        Me.Controls.Add(Me.LBAutores)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.btnEliminar)
        Me.Name = "AñadirAutores"
        Me.Text = "AñadirAutores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBAutores As ListBox
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents LabelNombre As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtInvest As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtArticulo As Label
End Class
