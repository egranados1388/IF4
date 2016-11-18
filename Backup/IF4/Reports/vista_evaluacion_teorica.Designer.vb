<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vista_evaluacion_teorica
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
Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
Me.DataGridView1 = New System.Windows.Forms.DataGridView
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DataGridView1
'
Me.DataGridView1.AllowUserToAddRows = False
Me.DataGridView1.AllowUserToDeleteRows = False
Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.EnableHeadersVisualStyles = False
Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.Size = New System.Drawing.Size(1024, 388)
Me.DataGridView1.TabIndex = 2
'
'vista_evaluacion_teorica
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(1048, 420)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "vista_evaluacion_teorica"
Me.Text = "Calculos Teoricos"
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
