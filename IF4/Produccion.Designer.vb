<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produccion
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
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.Label2 = New System.Windows.Forms.Label
Me.Panel2 = New System.Windows.Forms.Panel
Me.Label1 = New System.Windows.Forms.Label
Me.Panel1 = New System.Windows.Forms.Panel
Me.Button3 = New System.Windows.Forms.Button
Me.Label3 = New System.Windows.Forms.Label
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DataGridView1
'
Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.Size = New System.Drawing.Size(861, 416)
Me.DataGridView1.TabIndex = 0
'
'Label2
'
Me.Label2.AutoSize = True
Me.Label2.Location = New System.Drawing.Point(304, 34)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(137, 13)
Me.Label2.TabIndex = 9
Me.Label2.Text = "CI de Piezas  producidas 2°"
'
'Panel2
'
Me.Panel2.BackColor = System.Drawing.Color.Yellow
Me.Panel2.Location = New System.Drawing.Point(270, 23)
Me.Panel2.Name = "Panel2"
Me.Panel2.Size = New System.Drawing.Size(28, 24)
Me.Panel2.TabIndex = 8
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(47, 34)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(137, 13)
Me.Label1.TabIndex = 7
Me.Label1.Text = "CI de Piezas producidas  1°"
'
'Panel1
'
Me.Panel1.BackColor = System.Drawing.Color.Red
Me.Panel1.Location = New System.Drawing.Point(13, 23)
Me.Panel1.Name = "Panel1"
Me.Panel1.Size = New System.Drawing.Size(28, 24)
Me.Panel1.TabIndex = 6
'
'Button3
'
Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Button3.ForeColor = System.Drawing.Color.Red
Me.Button3.Location = New System.Drawing.Point(885, 89)
Me.Button3.Name = "Button3"
Me.Button3.Size = New System.Drawing.Size(74, 66)
Me.Button3.TabIndex = 10
Me.Button3.Text = "X"
Me.Button3.UseVisualStyleBackColor = True
'
'Label3
'
Me.Label3.AutoSize = True
Me.Label3.Location = New System.Drawing.Point(900, 99)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(43, 13)
Me.Label3.TabIndex = 11
Me.Label3.Text = "Eliminar"
'
'produccion
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(971, 511)
Me.Controls.Add(Me.Label3)
Me.Controls.Add(Me.Button3)
Me.Controls.Add(Me.Label2)
Me.Controls.Add(Me.Panel2)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.Panel1)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "produccion"
Me.Text = "Programacion Disponible"
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
