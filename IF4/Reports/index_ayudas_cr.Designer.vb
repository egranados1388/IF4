<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index_ayudas_cr
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index_ayudas_cr))
Me.Button1 = New System.Windows.Forms.Button
Me.Button3 = New System.Windows.Forms.Button
Me.Label1 = New System.Windows.Forms.Label
Me.PictureBox1 = New System.Windows.Forms.PictureBox
Me.Button4 = New System.Windows.Forms.Button
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(348, 12)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(104, 42)
Me.Button1.TabIndex = 0
Me.Button1.Text = "Calculos"
Me.Button1.UseVisualStyleBackColor = True
'
'Button3
'
Me.Button3.Location = New System.Drawing.Point(348, 152)
Me.Button3.Name = "Button3"
Me.Button3.Size = New System.Drawing.Size(104, 38)
Me.Button3.TabIndex = 2
Me.Button3.Text = "Exportacion Epicor"
Me.Button3.UseVisualStyleBackColor = True
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label1.Location = New System.Drawing.Point(12, 202)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(337, 20)
Me.Label1.TabIndex = 5
Me.Label1.Text = "Resultados   OT Producidas - Escaneo"
'
'PictureBox1
'
Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
Me.PictureBox1.Name = "PictureBox1"
Me.PictureBox1.Size = New System.Drawing.Size(64, 52)
Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
Me.PictureBox1.TabIndex = 3
Me.PictureBox1.TabStop = False
'
'Button4
'
Me.Button4.Location = New System.Drawing.Point(348, 85)
Me.Button4.Name = "Button4"
Me.Button4.Size = New System.Drawing.Size(104, 38)
Me.Button4.TabIndex = 6
Me.Button4.Text = "Resumen 1"
Me.Button4.UseVisualStyleBackColor = True
'
'index_ayudas_cr
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(461, 231)
Me.Controls.Add(Me.Button4)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.PictureBox1)
Me.Controls.Add(Me.Button3)
Me.Controls.Add(Me.Button1)
Me.Name = "index_ayudas_cr"
Me.Text = "IF4 - Calculos  Reales"
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
