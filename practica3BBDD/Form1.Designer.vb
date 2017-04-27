<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBoxConferencias = New System.Windows.Forms.ListBox()
        Me.ListBoxInvestigadores = New System.Windows.Forms.ListBox()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.btnAbrirBD = New System.Windows.Forms.Button()
        Me.btnAutor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAsiste = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnConferencia = New System.Windows.Forms.Button()
        Me.btnInvestigador = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxConferencias
        '
        Me.ListBoxConferencias.FormattingEnabled = True
        Me.ListBoxConferencias.Location = New System.Drawing.Point(186, 12)
        Me.ListBoxConferencias.Name = "ListBoxConferencias"
        Me.ListBoxConferencias.Size = New System.Drawing.Size(144, 186)
        Me.ListBoxConferencias.TabIndex = 16
        '
        'ListBoxInvestigadores
        '
        Me.ListBoxInvestigadores.FormattingEnabled = True
        Me.ListBoxInvestigadores.Location = New System.Drawing.Point(23, 12)
        Me.ListBoxInvestigadores.Name = "ListBoxInvestigadores"
        Me.ListBoxInvestigadores.Size = New System.Drawing.Size(144, 186)
        Me.ListBoxInvestigadores.TabIndex = 15
        '
        'lblRuta
        '
        Me.lblRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRuta.Location = New System.Drawing.Point(102, 215)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(280, 69)
        Me.lblRuta.TabIndex = 14
        '
        'btnAbrirBD
        '
        Me.btnAbrirBD.Location = New System.Drawing.Point(-84, 196)
        Me.btnAbrirBD.Name = "btnAbrirBD"
        Me.btnAbrirBD.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirBD.TabIndex = 13
        Me.btnAbrirBD.Text = "Abrir BD"
        Me.btnAbrirBD.UseVisualStyleBackColor = True
        '
        'btnAutor
        '
        Me.btnAutor.Location = New System.Drawing.Point(372, 128)
        Me.btnAutor.Name = "btnAutor"
        Me.btnAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnAutor.TabIndex = 12
        Me.btnAutor.Text = "Autor"
        Me.btnAutor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Abrir BD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAsiste
        '
        Me.btnAsiste.Location = New System.Drawing.Point(372, 99)
        Me.btnAsiste.Name = "btnAsiste"
        Me.btnAsiste.Size = New System.Drawing.Size(75, 23)
        Me.btnAsiste.TabIndex = 21
        Me.btnAsiste.Text = "Asiste"
        Me.btnAsiste.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.Location = New System.Drawing.Point(372, 70)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(75, 23)
        Me.btnArticulos.TabIndex = 20
        Me.btnArticulos.Text = "Articulos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnConferencia
        '
        Me.btnConferencia.Location = New System.Drawing.Point(372, 41)
        Me.btnConferencia.Name = "btnConferencia"
        Me.btnConferencia.Size = New System.Drawing.Size(75, 23)
        Me.btnConferencia.TabIndex = 19
        Me.btnConferencia.Text = "Conferencia"
        Me.btnConferencia.UseVisualStyleBackColor = True
        '
        'btnInvestigador
        '
        Me.btnInvestigador.Location = New System.Drawing.Point(372, 12)
        Me.btnInvestigador.Name = "btnInvestigador"
        Me.btnInvestigador.Size = New System.Drawing.Size(75, 23)
        Me.btnInvestigador.TabIndex = 18
        Me.btnInvestigador.Text = "Investigador"
        Me.btnInvestigador.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 307)
        Me.Controls.Add(Me.btnAsiste)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.btnConferencia)
        Me.Controls.Add(Me.btnInvestigador)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBoxConferencias)
        Me.Controls.Add(Me.ListBoxInvestigadores)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.btnAbrirBD)
        Me.Controls.Add(Me.btnAutor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxConferencias As ListBox
    Friend WithEvents ListBoxInvestigadores As ListBox
    Friend WithEvents lblRuta As Label
    Friend WithEvents btnAbrirBD As Button
    Friend WithEvents btnAutor As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAsiste As Button
    Friend WithEvents btnArticulos As Button
    Friend WithEvents btnConferencia As Button
    Friend WithEvents btnInvestigador As Button
End Class
