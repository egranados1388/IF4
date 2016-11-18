<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evaluar
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
Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
Me.DataSetConsumos = New IF4_1._0._0.DataSetConsumos
Me.ConsumosTableAdapter = New IF4_1._0._0.DataSetConsumosTableAdapters.ConsumosTableAdapter
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.MuestrastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.DSConjuntoTablasIF4 = New IF4_1._0._0.DSConjuntoTablasIF4
Me.Muestras_tTableAdapter = New IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.muestras_tTableAdapter
CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DataSetConsumos, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.MuestrastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'BindingSource2
'
Me.BindingSource2.DataMember = "Consumos"
Me.BindingSource2.DataSource = Me.DataSetConsumos
'
'DataSetConsumos
'
Me.DataSetConsumos.DataSetName = "DataSetConsumos"
Me.DataSetConsumos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'ConsumosTableAdapter
'
Me.ConsumosTableAdapter.ClearBeforeFill = True
'
'DataGridView1
'
Me.DataGridView1.AllowUserToAddRows = False
Me.DataGridView1.AllowUserToDeleteRows = False
Me.DataGridView1.AllowUserToResizeColumns = False
Me.DataGridView1.AllowUserToResizeRows = False
DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.EnableHeadersVisualStyles = False
Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.ReadOnly = True
DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
Me.DataGridView1.Size = New System.Drawing.Size(49, 27)
Me.DataGridView1.TabIndex = 0
'
'MuestrastBindingSource
'
Me.MuestrastBindingSource.DataMember = "muestras_t"
Me.MuestrastBindingSource.DataSource = Me.DSConjuntoTablasIF4
'
'DSConjuntoTablasIF4
'
Me.DSConjuntoTablasIF4.DataSetName = "DSConjuntoTablasIF4"
Me.DSConjuntoTablasIF4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'Muestras_tTableAdapter
'
Me.Muestras_tTableAdapter.ClearBeforeFill = True
'
'Evaluar
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(208, 132)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "Evaluar"
Me.Text = "Evaluacion de  Consumo teorico"
CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DataSetConsumos, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.MuestrastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    'Friend WithEvents DSProgramado As IF4_1._0._0.DSProgramado
    'Friend WithEvents ProgramadoTableAdapter As IF4_1._0._0.DSProgramadoTableAdapters.ProgramadoTableAdapter
    Friend WithEvents DataSetConsumos As IF4_1._0._0.DataSetConsumos
    Friend WithEvents ConsumosTableAdapter As IF4_1._0._0.DataSetConsumosTableAdapters.ConsumosTableAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DSConjuntoTablasIF4 As IF4_1._0._0.DSConjuntoTablasIF4
    Friend WithEvents MuestrastBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Muestras_tTableAdapter As IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.muestras_tTableAdapter
End Class
