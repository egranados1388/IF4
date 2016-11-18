<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class plantilla_r
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
Me.DSConjuntoTablasIF4 = New IF4_1._0._0.DSConjuntoTablasIF4
Me.MuestrastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.Muestras_tTableAdapter = New IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.muestras_tTableAdapter
Me.MuestrasrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.Muestras_rTableAdapter = New IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.muestras_rTableAdapter
Me.MuestrasrBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.MuestrasrBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.MuestrastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.MuestrasrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.MuestrasrBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.MuestrasrBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DSConjuntoTablasIF4
'
Me.DSConjuntoTablasIF4.DataSetName = "DSConjuntoTablasIF4"
Me.DSConjuntoTablasIF4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'MuestrastBindingSource
'
Me.MuestrastBindingSource.DataMember = "muestras_t"
Me.MuestrastBindingSource.DataSource = Me.DSConjuntoTablasIF4
'
'Muestras_tTableAdapter
'
Me.Muestras_tTableAdapter.ClearBeforeFill = True
'
'MuestrasrBindingSource
'
Me.MuestrasrBindingSource.DataMember = "muestras_r"
Me.MuestrasrBindingSource.DataSource = Me.DSConjuntoTablasIF4
'
'Muestras_rTableAdapter
'
Me.Muestras_rTableAdapter.ClearBeforeFill = True
'
'MuestrasrBindingSource1
'
Me.MuestrasrBindingSource1.DataMember = "muestras_r"
Me.MuestrasrBindingSource1.DataSource = Me.DSConjuntoTablasIF4
'
'DataGridView1
'
Me.DataGridView1.AllowUserToAddRows = False
Me.DataGridView1.AllowUserToDeleteRows = False
Me.DataGridView1.AllowUserToResizeColumns = False
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
Me.DataGridView1.Size = New System.Drawing.Size(957, 388)
Me.DataGridView1.TabIndex = 1
'
'MuestrasrBindingSource2
'
Me.MuestrasrBindingSource2.DataMember = "muestras_r"
Me.MuestrasrBindingSource2.DataSource = Me.DSConjuntoTablasIF4
'
'plantilla_r
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(981, 461)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "plantilla_r"
Me.Text = "Resumen 1 CR"
CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.MuestrastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.MuestrasrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.MuestrasrBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.MuestrasrBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents DSConjuntoTablasIF4 As IF4_1._0._0.DSConjuntoTablasIF4
    Friend WithEvents MuestrastBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Muestras_tTableAdapter As IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.muestras_tTableAdapter
    Friend WithEvents MuestrasrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Muestras_rTableAdapter As IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.muestras_rTableAdapter
    Friend WithEvents MuestrasrBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MuestrasrBindingSource2 As System.Windows.Forms.BindingSource
End Class
