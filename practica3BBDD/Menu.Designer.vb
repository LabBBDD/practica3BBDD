<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnInvestigador = New System.Windows.Forms.Button()
        Me.btnConferencia = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnAutor = New System.Windows.Forms.Button()
        Me.ListBoxInvestigadores = New System.Windows.Forms.ListBox()
        Me.ListBoxConferencias = New System.Windows.Forms.ListBox()
        Me.BtnCurriculum = New System.Windows.Forms.Button()
        Me.BtnAsistir = New System.Windows.Forms.Button()
        Me.btnNoAsistir = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInvestigador
        '
        Me.btnInvestigador.Location = New System.Drawing.Point(421, 17)
        Me.btnInvestigador.Name = "btnInvestigador"
        Me.btnInvestigador.Size = New System.Drawing.Size(75, 23)
        Me.btnInvestigador.TabIndex = 0
        Me.btnInvestigador.Text = "Investigador"
        Me.btnInvestigador.UseVisualStyleBackColor = True
        '
        'btnConferencia
        '
        Me.btnConferencia.Location = New System.Drawing.Point(421, 46)
        Me.btnConferencia.Name = "btnConferencia"
        Me.btnConferencia.Size = New System.Drawing.Size(75, 23)
        Me.btnConferencia.TabIndex = 1
        Me.btnConferencia.Text = "Conferencia"
        Me.btnConferencia.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.Location = New System.Drawing.Point(421, 75)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(75, 23)
        Me.btnArticulos.TabIndex = 2
        Me.btnArticulos.Text = "Articulos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnAutor
        '
        Me.btnAutor.Location = New System.Drawing.Point(421, 104)
        Me.btnAutor.Name = "btnAutor"
        Me.btnAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnAutor.TabIndex = 3
        Me.btnAutor.Text = "Autor"
        Me.btnAutor.UseVisualStyleBackColor = True
        '
        'ListBoxInvestigadores
        '
        Me.ListBoxInvestigadores.FormattingEnabled = True
        Me.ListBoxInvestigadores.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxInvestigadores.Name = "ListBoxInvestigadores"
        Me.ListBoxInvestigadores.Size = New System.Drawing.Size(186, 264)
        Me.ListBoxInvestigadores.TabIndex = 10
        '
        'ListBoxConferencias
        '
        Me.ListBoxConferencias.FormattingEnabled = True
        Me.ListBoxConferencias.Location = New System.Drawing.Point(204, 12)
        Me.ListBoxConferencias.Name = "ListBoxConferencias"
        Me.ListBoxConferencias.Size = New System.Drawing.Size(186, 264)
        Me.ListBoxConferencias.TabIndex = 11
        '
        'BtnCurriculum
        '
        Me.BtnCurriculum.Location = New System.Drawing.Point(421, 242)
        Me.BtnCurriculum.Name = "BtnCurriculum"
        Me.BtnCurriculum.Size = New System.Drawing.Size(75, 60)
        Me.BtnCurriculum.TabIndex = 12
        Me.BtnCurriculum.Text = "CV"
        Me.BtnCurriculum.UseVisualStyleBackColor = True
        '
        'BtnAsistir
        '
        Me.BtnAsistir.Location = New System.Drawing.Point(421, 133)
        Me.BtnAsistir.Name = "BtnAsistir"
        Me.BtnAsistir.Size = New System.Drawing.Size(75, 23)
        Me.BtnAsistir.TabIndex = 13
        Me.BtnAsistir.Text = "Asistir"
        Me.BtnAsistir.UseVisualStyleBackColor = True
        '
        'btnNoAsistir
        '
        Me.btnNoAsistir.Location = New System.Drawing.Point(421, 162)
        Me.btnNoAsistir.Name = "btnNoAsistir"
        Me.btnNoAsistir.Size = New System.Drawing.Size(75, 23)
        Me.btnNoAsistir.TabIndex = 14
        Me.btnNoAsistir.Text = "No asistir"
        Me.btnNoAsistir.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(12, 282)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(378, 23)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 314)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnNoAsistir)
        Me.Controls.Add(Me.BtnAsistir)
        Me.Controls.Add(Me.BtnCurriculum)
        Me.Controls.Add(Me.ListBoxConferencias)
        Me.Controls.Add(Me.ListBoxInvestigadores)
        Me.Controls.Add(Me.btnAutor)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.btnConferencia)
        Me.Controls.Add(Me.btnInvestigador)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInvestigador As Button
    Friend WithEvents btnConferencia As Button
    Friend WithEvents btnArticulos As Button
    Friend WithEvents btnAutor As Button
    Friend WithEvents ListBoxInvestigadores As ListBox
    Friend WithEvents ListBoxConferencias As ListBox
    Friend WithEvents BtnCurriculum As Button
    Friend WithEvents BtnAsistir As Button
    Friend WithEvents btnNoAsistir As Button
    Friend WithEvents btnActualizar As Button
End Class
