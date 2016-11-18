<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salida_rollo
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
Me.Button1 = New System.Windows.Forms.Button
Me.Button2 = New System.Windows.Forms.Button
Me.Label5 = New System.Windows.Forms.Label
Me.rollo_txt = New System.Windows.Forms.TextBox
Me.Label1 = New System.Windows.Forms.Label
Me.parte_txt = New System.Windows.Forms.TextBox
Me.Button3 = New System.Windows.Forms.Button
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DataGridView1
'
Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.EnableHeadersVisualStyles = False
Me.DataGridView1.Location = New System.Drawing.Point(24, 117)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.Size = New System.Drawing.Size(1119, 388)
Me.DataGridView1.TabIndex = 4
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(993, 15)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(150, 100)
Me.Button1.TabIndex = 3
Me.Button1.Text = "Cargar"
Me.Button1.UseVisualStyleBackColor = True
'
'Button2
'
Me.Button2.Location = New System.Drawing.Point(24, 511)
Me.Button2.Name = "Button2"
Me.Button2.Size = New System.Drawing.Size(131, 62)
Me.Button2.TabIndex = 5
Me.Button2.Text = "Guardar cambios"
Me.Button2.UseVisualStyleBackColor = True
'
'Label5
'
Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
Me.Label5.AutoSize = True
Me.Label5.Location = New System.Drawing.Point(21, 57)
Me.Label5.Name = "Label5"
Me.Label5.Size = New System.Drawing.Size(64, 13)
Me.Label5.TabIndex = 20
Me.Label5.Text = "Rollo (Lote):"
'
'rollo_txt
'
Me.rollo_txt.Location = New System.Drawing.Point(92, 50)
Me.rollo_txt.Name = "rollo_txt"
Me.rollo_txt.Size = New System.Drawing.Size(118, 20)
Me.rollo_txt.TabIndex = 2
'
'Label1
'
Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(21, 27)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(35, 13)
Me.Label1.TabIndex = 20
Me.Label1.Text = "Parte:"
'
'parte_txt
'
Me.parte_txt.Location = New System.Drawing.Point(92, 24)
Me.parte_txt.Name = "parte_txt"
Me.parte_txt.Size = New System.Drawing.Size(118, 20)
Me.parte_txt.TabIndex = 1
'
'Button3
'
Me.Button3.Location = New System.Drawing.Point(161, 511)
Me.Button3.Name = "Button3"
Me.Button3.Size = New System.Drawing.Size(125, 62)
Me.Button3.TabIndex = 6
Me.Button3.Text = "Limpiar"
Me.Button3.UseVisualStyleBackColor = True
'
'salida_rollo
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(1155, 585)
Me.Controls.Add(Me.Button3)
Me.Controls.Add(Me.parte_txt)
Me.Controls.Add(Me.Label1)
Me.Controls.Add(Me.rollo_txt)
Me.Controls.Add(Me.Label5)
Me.Controls.Add(Me.Button2)
Me.Controls.Add(Me.Button1)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "salida_rollo"
Me.Text = "Regtistro  Salida  de Maquina (Rollo)"
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rollo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents parte_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
