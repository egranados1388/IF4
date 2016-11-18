<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings_menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.Button2 = New System.Windows.Forms.Button
Me.Button1 = New System.Windows.Forms.Button
Me.Button3 = New System.Windows.Forms.Button
Me.Button4 = New System.Windows.Forms.Button
Me.Button5 = New System.Windows.Forms.Button
Me.PictureBox1 = New System.Windows.Forms.PictureBox
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'Button2
'
Me.Button2.Enabled = False
Me.Button2.Location = New System.Drawing.Point(223, 12)
Me.Button2.Name = "Button2"
Me.Button2.Size = New System.Drawing.Size(131, 41)
Me.Button2.TabIndex = 2
Me.Button2.Text = "Usuarios"
Me.Button2.UseVisualStyleBackColor = True
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(223, 59)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(131, 53)
Me.Button1.TabIndex = 3
Me.Button1.Text = "Vaciar  Programas"
Me.Button1.UseVisualStyleBackColor = True
'
'Button3
'
Me.Button3.Location = New System.Drawing.Point(223, 118)
Me.Button3.Name = "Button3"
Me.Button3.Size = New System.Drawing.Size(131, 47)
Me.Button3.TabIndex = 4
Me.Button3.Text = "Vacier  OT's  Producidas"
Me.Button3.UseVisualStyleBackColor = True
'
'Button4
'
Me.Button4.Location = New System.Drawing.Point(223, 171)
Me.Button4.Name = "Button4"
Me.Button4.Size = New System.Drawing.Size(131, 49)
Me.Button4.TabIndex = 5
Me.Button4.Text = "Vaciar Consumos"
Me.Button4.UseVisualStyleBackColor = True
'
'Button5
'
Me.Button5.Location = New System.Drawing.Point(223, 226)
Me.Button5.Name = "Button5"
Me.Button5.Size = New System.Drawing.Size(131, 34)
Me.Button5.TabIndex = 6
Me.Button5.Text = "Consumos  Carga"
Me.Button5.UseVisualStyleBackColor = True
'
'PictureBox1
'
Me.PictureBox1.Image = Global.IF4_1._0._0.My.Resources.Resources.sett
Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
Me.PictureBox1.Name = "PictureBox1"
Me.PictureBox1.Size = New System.Drawing.Size(205, 248)
Me.PictureBox1.TabIndex = 0
Me.PictureBox1.TabStop = False
'
'settings_menu
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(360, 308)
Me.Controls.Add(Me.Button5)
Me.Controls.Add(Me.Button4)
Me.Controls.Add(Me.Button3)
Me.Controls.Add(Me.Button1)
Me.Controls.Add(Me.Button2)
Me.Controls.Add(Me.PictureBox1)
Me.Name = "settings_menu"
Me.Text = "Menu configuracion"
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
