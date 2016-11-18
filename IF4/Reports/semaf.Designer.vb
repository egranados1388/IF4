<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class semaf
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
Me.components = New System.ComponentModel.Container
Me.DataGridView2 = New System.Windows.Forms.DataGridView
Me.Button1 = New System.Windows.Forms.Button
Me.Panel1 = New System.Windows.Forms.Panel
Me.Label1 = New System.Windows.Forms.Label
Me.Panel2 = New System.Windows.Forms.Panel
Me.Label2 = New System.Windows.Forms.Label
Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DataGridView2
'
Me.DataGridView2.AllowUserToAddRows = False
Me.DataGridView2.AllowUserToDeleteRows = False
Me.DataGridView2.AllowUserToOrderColumns = True
Me.DataGridView2.AllowUserToResizeColumns = False
Me.DataGridView2.AllowUserToResizeRows = False
Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView2.Location = New System.Drawing.Point(24, 62)
Me.DataGridView2.Name = "DataGridView2"
Me.DataGridView2.Size = New System.Drawing.Size(754, 509)
Me.DataGridView2.TabIndex = 0
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(-4, 433)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(10, 30)
Me.Button1.TabIndex = 1
Me.Button1.Text = "Eliminar"
Me.Button1.UseVisualStyleBackColor = True
'
'Panel1
'
Me.Panel1.BackColor = System.Drawing.Color.Red
Me.Panel1.Location = New System.Drawing.Point(24, 12)
Me.Panel1.Name = "Panel1"
Me.Panel1.Size = New System.Drawing.Size(28, 24)
Me.Panel1.TabIndex = 3
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(58, 23)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(96, 13)
Me.Label1.TabIndex = 4
Me.Label1.Text = "% Diferencia < - 10"
'
'Panel2
'
Me.Panel2.BackColor = System.Drawing.Color.Yellow
Me.Panel2.Location = New System.Drawing.Point(281, 12)
Me.Panel2.Name = "Panel2"
Me.Panel2.Size = New System.Drawing.Size(28, 24)
Me.Panel2.TabIndex = 4
'
'Label2
'
Me.Label2.AutoSize = True
Me.Label2.Location = New System.Drawing.Point(315, 23)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(90, 13)
Me.Label2.TabIndex = 5
Me.Label2.Text = "% Diferencia > 10"
'
'semaf
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(789, 577)
Me.Controls.Add(Me.Label2)
Me.Controls.Add(Me.Panel2)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.Panel1)
Me.Controls.Add(Me.Button1)
Me.Controls.Add(Me.DataGridView2)
Me.Name = "semaf"
Me.Text = "Semaforo Consumo Teorico"
CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
