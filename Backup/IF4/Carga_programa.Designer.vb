<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carga_programa
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
Me.Button1 = New System.Windows.Forms.Button
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.Button3 = New System.Windows.Forms.Button
Me.Label1 = New System.Windows.Forms.Label
Me.Button2 = New System.Windows.Forms.Button
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(12, 31)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(131, 78)
Me.Button1.TabIndex = 0
Me.Button1.Text = "Seleccionar  Archivo"
Me.Button1.UseVisualStyleBackColor = True
Me.Button1.Visible = False
'
'DataGridView1
'
Me.DataGridView1.AllowUserToOrderColumns = True
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.Location = New System.Drawing.Point(149, 31)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.Size = New System.Drawing.Size(1103, 456)
Me.DataGridView1.TabIndex = 2
'
'Button3
'
Me.Button3.Enabled = False
Me.Button3.Location = New System.Drawing.Point(12, 396)
Me.Button3.Name = "Button3"
Me.Button3.Size = New System.Drawing.Size(131, 91)
Me.Button3.TabIndex = 3
Me.Button3.Text = "Guardar Programa AI"
Me.Button3.UseVisualStyleBackColor = True
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(510, 11)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(162, 13)
Me.Label1.TabIndex = 4
Me.Label1.Text = "Registros de Programa a  cargar:"
'
'Button2
'
Me.Button2.Enabled = False
Me.Button2.Location = New System.Drawing.Point(12, 290)
Me.Button2.Name = "Button2"
Me.Button2.Size = New System.Drawing.Size(131, 91)
Me.Button2.TabIndex = 5
Me.Button2.Text = "Guardar Programa AS"
Me.Button2.UseVisualStyleBackColor = True
'
'Carga_programa
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(1264, 537)
Me.Controls.Add(Me.Button2)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.Button3)
Me.Controls.Add(Me.DataGridView1)
Me.Controls.Add(Me.Button1)
Me.Name = "Carga_programa"
Me.Text = "Carga  de Programas OMP"
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
