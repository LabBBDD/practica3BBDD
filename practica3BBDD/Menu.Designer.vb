﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'btnInvestigador
        '
        Me.btnInvestigador.Location = New System.Drawing.Point(373, 44)
        Me.btnInvestigador.Name = "btnInvestigador"
        Me.btnInvestigador.Size = New System.Drawing.Size(75, 23)
        Me.btnInvestigador.TabIndex = 0
        Me.btnInvestigador.Text = "Investigador"
        Me.btnInvestigador.UseVisualStyleBackColor = True
        '
        'btnConferencia
        '
        Me.btnConferencia.Location = New System.Drawing.Point(373, 73)
        Me.btnConferencia.Name = "btnConferencia"
        Me.btnConferencia.Size = New System.Drawing.Size(75, 23)
        Me.btnConferencia.TabIndex = 1
        Me.btnConferencia.Text = "Conferencia"
        Me.btnConferencia.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.Location = New System.Drawing.Point(373, 102)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(75, 23)
        Me.btnArticulos.TabIndex = 2
        Me.btnArticulos.Text = "Articulos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnAutor
        '
        Me.btnAutor.Location = New System.Drawing.Point(373, 131)
        Me.btnAutor.Name = "btnAutor"
        Me.btnAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnAutor.TabIndex = 3
        Me.btnAutor.Text = "Autor"
        Me.btnAutor.UseVisualStyleBackColor = True
        '
        'ListBoxInvestigadores
        '
        Me.ListBoxInvestigadores.FormattingEnabled = True
        Me.ListBoxInvestigadores.Location = New System.Drawing.Point(26, 12)
        Me.ListBoxInvestigadores.Name = "ListBoxInvestigadores"
        Me.ListBoxInvestigadores.Size = New System.Drawing.Size(144, 186)
        Me.ListBoxInvestigadores.TabIndex = 10
        '
        'ListBoxConferencias
        '
        Me.ListBoxConferencias.FormattingEnabled = True
        Me.ListBoxConferencias.Location = New System.Drawing.Point(187, 12)
        Me.ListBoxConferencias.Name = "ListBoxConferencias"
        Me.ListBoxConferencias.Size = New System.Drawing.Size(144, 186)
        Me.ListBoxConferencias.TabIndex = 11
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 217)
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
End Class
