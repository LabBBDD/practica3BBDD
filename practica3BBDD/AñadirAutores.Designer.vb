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
        Me.LBInvest = New System.Windows.Forms.ListBox()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.LBArt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LBInvest
        '
        Me.LBInvest.FormattingEnabled = True
        Me.LBInvest.Location = New System.Drawing.Point(12, 12)
        Me.LBInvest.Name = "LBInvest"
        Me.LBInvest.Size = New System.Drawing.Size(139, 238)
        Me.LBInvest.TabIndex = 125
        '
        'txtOrden
        '
        Me.txtOrden.ForeColor = System.Drawing.Color.Black
        Me.txtOrden.Location = New System.Drawing.Point(312, 38)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(157, 20)
        Me.txtOrden.TabIndex = 1
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(345, 139)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(89, 24)
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
        Me.btnAñadir.Location = New System.Drawing.Point(345, 109)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(89, 24)
        Me.btnAñadir.TabIndex = 120
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.ForeColor = System.Drawing.Color.Black
        Me.LabelNombre.Location = New System.Drawing.Point(370, 22)
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
        Me.btnEliminar.Location = New System.Drawing.Point(345, 169)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(89, 24)
        Me.btnEliminar.TabIndex = 122
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'LBArt
        '
        Me.LBArt.FormattingEnabled = True
        Me.LBArt.Location = New System.Drawing.Point(157, 12)
        Me.LBArt.Name = "LBArt"
        Me.LBArt.Size = New System.Drawing.Size(139, 238)
        Me.LBArt.TabIndex = 130
        '
        'AñadirAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 262)
        Me.Controls.Add(Me.LBArt)
        Me.Controls.Add(Me.LBInvest)
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

    Friend WithEvents LBInvest As ListBox
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents LabelNombre As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents LBArt As ListBox
End Class
