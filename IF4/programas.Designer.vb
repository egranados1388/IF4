<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class programas
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(programas))
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.Button1 = New System.Windows.Forms.Button
Me.Panel1 = New System.Windows.Forms.Panel
Me.Label1 = New System.Windows.Forms.Label
Me.Panel2 = New System.Windows.Forms.Panel
Me.Label2 = New System.Windows.Forms.Label
Me.Button2 = New System.Windows.Forms.Button
Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
Me.Button3 = New System.Windows.Forms.Button
Me.Label3 = New System.Windows.Forms.Label
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DataGridView1
'
Me.DataGridView1.AllowUserToAddRows = False
Me.DataGridView1.AllowUserToDeleteRows = False
Me.DataGridView1.AllowUserToOrderColumns = True
Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.Location = New System.Drawing.Point(24, 66)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.Size = New System.Drawing.Size(923, 509)
Me.DataGridView1.TabIndex = 0
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
Me.Label1.Size = New System.Drawing.Size(204, 13)
Me.Label1.TabIndex = 4
Me.Label1.Text = "CI de Programa   Duplicada  mas  Antigua"
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
Me.Label2.Size = New System.Drawing.Size(211, 13)
Me.Label2.TabIndex = 5
Me.Label2.Text = "CI de Programa   Duplicada  mas  Reciente"
'
'Button2
'
Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
Me.Button2.Location = New System.Drawing.Point(937, 66)
Me.Button2.Name = "Button2"
Me.Button2.Size = New System.Drawing.Size(10, 13)
Me.Button2.TabIndex = 6
Me.Button2.UseVisualStyleBackColor = True
'
'Button3
'
Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Button3.ForeColor = System.Drawing.Color.Red
Me.Button3.Location = New System.Drawing.Point(953, 66)
Me.Button3.Name = "Button3"
Me.Button3.Size = New System.Drawing.Size(74, 66)
Me.Button3.TabIndex = 7
Me.Button3.Text = "X"
Me.Button3.UseVisualStyleBackColor = True
'
'Label3
'
Me.Label3.AutoSize = True
Me.Label3.Location = New System.Drawing.Point(972, 77)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(43, 13)
Me.Label3.TabIndex = 8
Me.Label3.Text = "Eliminar"
'
'programas
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(1028, 623)
Me.Controls.Add(Me.Label3)
Me.Controls.Add(Me.Button3)
Me.Controls.Add(Me.Button2)
Me.Controls.Add(Me.Label2)
Me.Controls.Add(Me.Panel2)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.Panel1)
Me.Controls.Add(Me.Button1)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "programas"
Me.Text = "Programacion Disponible"
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
