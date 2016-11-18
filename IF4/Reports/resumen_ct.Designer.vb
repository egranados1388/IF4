<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resumen_ct
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
Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.ResumentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.Resume_t_DS = New IF4_1._0._0.resume_t_DS
Me.Resumen_tTableAdapter = New IF4_1._0._0.resume_t_DSTableAdapters.resumen_tTableAdapter
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.ResumentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.Resume_t_DS, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DataGridView1
'
Me.DataGridView1.AllowUserToAddRows = False
Me.DataGridView1.AllowUserToDeleteRows = False
Me.DataGridView1.AllowUserToResizeRows = False
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
Me.DataGridView1.Size = New System.Drawing.Size(1021, 388)
Me.DataGridView1.TabIndex = 3
'
'ResumentBindingSource
'
Me.ResumentBindingSource.DataMember = "resumen_t"
Me.ResumentBindingSource.DataSource = Me.Resume_t_DS
'
'Resume_t_DS
'
Me.Resume_t_DS.DataSetName = "resume_t_DS"
Me.Resume_t_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'Resumen_tTableAdapter
'
Me.Resumen_tTableAdapter.ClearBeforeFill = True
'
'resumen_ct
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(1045, 432)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "resumen_ct"
Me.Text = "Resumen Calculos  Teoricos"
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.ResumentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.Resume_t_DS, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents Resume_t_DS As IF4_1._0._0.resume_t_DS
    Friend WithEvents ResumentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Resumen_tTableAdapter As IF4_1._0._0.resume_t_DSTableAdapters.resumen_tTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
