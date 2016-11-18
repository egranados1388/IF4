<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios_ver
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
Me.DataGridView1 = New System.Windows.Forms.DataGridView
Me.IdusuariousuariomailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.PasswdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.JerarquiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.DSConjuntoTablasIF4 = New IF4_1._0._0.DSConjuntoTablasIF4
Me.DataSEpicor905 = New IF4_1._0._0.DataSEpicor905
Me.DataSEpicor905BindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.JobOperBindingSource = New System.Windows.Forms.BindingSource(Me.components)
Me.JobOperTableAdapter = New IF4_1._0._0.DataSEpicor905TableAdapters.JobOperTableAdapter
Me.UsuariosTableAdapter = New IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.usuariosTableAdapter
Me.Button1 = New System.Windows.Forms.Button
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DataSEpicor905, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DataSEpicor905BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.JobOperBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'DataGridView1
'
Me.DataGridView1.AutoGenerateColumns = False
Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdusuariousuariomailDataGridViewTextBoxColumn, Me.PasswdDataGridViewTextBoxColumn, Me.JerarquiaDataGridViewTextBoxColumn})
Me.DataGridView1.DataSource = Me.UsuariosBindingSource
Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
Me.DataGridView1.Name = "DataGridView1"
Me.DataGridView1.Size = New System.Drawing.Size(653, 294)
Me.DataGridView1.TabIndex = 0
'
'IdusuariousuariomailDataGridViewTextBoxColumn
'
Me.IdusuariousuariomailDataGridViewTextBoxColumn.DataPropertyName = "idusuario_usuariomail"
Me.IdusuariousuariomailDataGridViewTextBoxColumn.HeaderText = "Usuario"
Me.IdusuariousuariomailDataGridViewTextBoxColumn.Name = "IdusuariousuariomailDataGridViewTextBoxColumn"
'
'PasswdDataGridViewTextBoxColumn
'
Me.PasswdDataGridViewTextBoxColumn.DataPropertyName = "passwd"
Me.PasswdDataGridViewTextBoxColumn.HeaderText = "Contraseña"
Me.PasswdDataGridViewTextBoxColumn.Name = "PasswdDataGridViewTextBoxColumn"
'
'JerarquiaDataGridViewTextBoxColumn
'
Me.JerarquiaDataGridViewTextBoxColumn.DataPropertyName = "jerarquia"
Me.JerarquiaDataGridViewTextBoxColumn.HeaderText = "Jerarquia"
Me.JerarquiaDataGridViewTextBoxColumn.Name = "JerarquiaDataGridViewTextBoxColumn"
'
'UsuariosBindingSource
'
Me.UsuariosBindingSource.DataMember = "usuarios"
Me.UsuariosBindingSource.DataSource = Me.DSConjuntoTablasIF4
'
'DSConjuntoTablasIF4
'
Me.DSConjuntoTablasIF4.DataSetName = "DSConjuntoTablasIF4"
Me.DSConjuntoTablasIF4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'DataSEpicor905
'
Me.DataSEpicor905.DataSetName = "DataSEpicor905"
Me.DataSEpicor905.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'DataSEpicor905BindingSource
'
Me.DataSEpicor905BindingSource.DataSource = Me.DataSEpicor905
Me.DataSEpicor905BindingSource.Position = 0
'
'JobOperBindingSource
'
Me.JobOperBindingSource.DataMember = "JobOper"
Me.JobOperBindingSource.DataSource = Me.DataSEpicor905BindingSource
'
'JobOperTableAdapter
'
Me.JobOperTableAdapter.ClearBeforeFill = True
'
'UsuariosTableAdapter
'
Me.UsuariosTableAdapter.ClearBeforeFill = True
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(590, 312)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(75, 32)
Me.Button1.TabIndex = 1
Me.Button1.Text = "Guardar"
Me.Button1.UseVisualStyleBackColor = True
'
'Usuarios_ver
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(677, 354)
Me.Controls.Add(Me.Button1)
Me.Controls.Add(Me.DataGridView1)
Me.Name = "Usuarios_ver"
Me.Text = "Usuarios  Registrados"
CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DataSEpicor905, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DataSEpicor905BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.JobOperBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSEpicor905BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSEpicor905 As IF4_1._0._0.DataSEpicor905
    Friend WithEvents JobOperBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobOperTableAdapter As IF4_1._0._0.DataSEpicor905TableAdapters.JobOperTableAdapter
    Friend WithEvents DSConjuntoTablasIF4 As IF4_1._0._0.DSConjuntoTablasIF4
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.usuariosTableAdapter
    Friend WithEvents IdusuariousuariomailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JerarquiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
