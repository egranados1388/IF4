<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consumos_update
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
Dim Fecha_consumoLabel As System.Windows.Forms.Label
Dim No_pedido_otLabel As System.Windows.Forms.Label
Dim RolloLabel As System.Windows.Forms.Label
Dim No_ciLabel As System.Windows.Forms.Label
Dim Id_maquina_consumoLabel As System.Windows.Forms.Label
Dim Parte_rolloLabel As System.Windows.Forms.Label
Dim KginicialesLabel As System.Windows.Forms.Label
Dim KgFinalesLabel As System.Windows.Forms.Label
Dim KginicialesLabel1 As System.Windows.Forms.Label
Dim KgFinalesLabel1 As System.Windows.Forms.Label
Dim Fecha_consumoLabel1 As System.Windows.Forms.Label
Dim EmpalmadorLabel1 As System.Windows.Forms.Label
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consumos_update))
Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
Me.ConsumosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
Me.DataSetConsumos = New IF4_1._0._0.DataSetConsumos
Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton
Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
Me.ConsumosTableAdapter1 = New IF4_1._0._0.DataSetConsumosTableAdapters.ConsumosTableAdapter
Me.Fecha_consumoDateTimePicker = New System.Windows.Forms.DateTimePicker
Me.No_pedido_otTextBox = New System.Windows.Forms.TextBox
Me.RolloTextBox = New System.Windows.Forms.TextBox
Me.No_ciTextBox = New System.Windows.Forms.TextBox
Me.Id_maquina_consumoTextBox = New System.Windows.Forms.TextBox
Me.Parte_rolloTextBox = New System.Windows.Forms.TextBox
Me.KginicialesTextBox = New System.Windows.Forms.TextBox
Me.KgFinalesTextBox = New System.Windows.Forms.TextBox
Me.KginicialesLabel2 = New System.Windows.Forms.Label
Me.KgFinalesLabel2 = New System.Windows.Forms.Label
Me.Fecha_consumoTextBox = New System.Windows.Forms.TextBox
Me.Panel1 = New System.Windows.Forms.Panel
Me.EmpalmadorComboBox = New System.Windows.Forms.ComboBox
Fecha_consumoLabel = New System.Windows.Forms.Label
No_pedido_otLabel = New System.Windows.Forms.Label
RolloLabel = New System.Windows.Forms.Label
No_ciLabel = New System.Windows.Forms.Label
Id_maquina_consumoLabel = New System.Windows.Forms.Label
Parte_rolloLabel = New System.Windows.Forms.Label
KginicialesLabel = New System.Windows.Forms.Label
KgFinalesLabel = New System.Windows.Forms.Label
KginicialesLabel1 = New System.Windows.Forms.Label
KgFinalesLabel1 = New System.Windows.Forms.Label
Fecha_consumoLabel1 = New System.Windows.Forms.Label
EmpalmadorLabel1 = New System.Windows.Forms.Label
CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.BindingNavigator1.SuspendLayout()
CType(Me.ConsumosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
CType(Me.DataSetConsumos, System.ComponentModel.ISupportInitialize).BeginInit()
Me.Panel1.SuspendLayout()
Me.SuspendLayout()
'
'Fecha_consumoLabel
'
Fecha_consumoLabel.AutoSize = True
Fecha_consumoLabel.Location = New System.Drawing.Point(295, 7)
Fecha_consumoLabel.Name = "Fecha_consumoLabel"
Fecha_consumoLabel.Size = New System.Drawing.Size(86, 13)
Fecha_consumoLabel.TabIndex = 4
Fecha_consumoLabel.Text = "Fecha consumo:"
'
'No_pedido_otLabel
'
No_pedido_otLabel.AutoSize = True
No_pedido_otLabel.Location = New System.Drawing.Point(150, 39)
No_pedido_otLabel.Name = "No_pedido_otLabel"
No_pedido_otLabel.Size = New System.Drawing.Size(75, 13)
No_pedido_otLabel.TabIndex = 5
No_pedido_otLabel.Text = "ID Pedido OT:"
'
'RolloLabel
'
RolloLabel.AutoSize = True
RolloLabel.Location = New System.Drawing.Point(191, 65)
RolloLabel.Name = "RolloLabel"
RolloLabel.Size = New System.Drawing.Size(34, 13)
RolloLabel.TabIndex = 6
RolloLabel.Text = "Rollo:"
'
'No_ciLabel
'
No_ciLabel.AutoSize = True
No_ciLabel.Location = New System.Drawing.Point(10, 39)
No_ciLabel.Name = "No_ciLabel"
No_ciLabel.Size = New System.Drawing.Size(20, 13)
No_ciLabel.TabIndex = 7
No_ciLabel.Text = "CI:"
'
'Id_maquina_consumoLabel
'
Id_maquina_consumoLabel.AutoSize = True
Id_maquina_consumoLabel.Location = New System.Drawing.Point(430, 36)
Id_maquina_consumoLabel.Name = "Id_maquina_consumoLabel"
Id_maquina_consumoLabel.Size = New System.Drawing.Size(51, 13)
Id_maquina_consumoLabel.TabIndex = 9
Id_maquina_consumoLabel.Text = "Maquina:"
'
'Parte_rolloLabel
'
Parte_rolloLabel.AutoSize = True
Parte_rolloLabel.Location = New System.Drawing.Point(425, 68)
Parte_rolloLabel.Name = "Parte_rolloLabel"
Parte_rolloLabel.Size = New System.Drawing.Size(57, 13)
Parte_rolloLabel.TabIndex = 13
Parte_rolloLabel.Text = "Parte rollo:"
'
'KginicialesLabel
'
KginicialesLabel.AutoSize = True
KginicialesLabel.Location = New System.Drawing.Point(7, 112)
KginicialesLabel.Name = "KginicialesLabel"
KginicialesLabel.Size = New System.Drawing.Size(63, 13)
KginicialesLabel.TabIndex = 15
KginicialesLabel.Text = "kg Iniciales:"
'
'KgFinalesLabel
'
KgFinalesLabel.AutoSize = True
KgFinalesLabel.Location = New System.Drawing.Point(7, 148)
KgFinalesLabel.Name = "KgFinalesLabel"
KgFinalesLabel.Size = New System.Drawing.Size(59, 13)
KgFinalesLabel.TabIndex = 17
KgFinalesLabel.Text = "Kg Finales:"
'
'KginicialesLabel1
'
KginicialesLabel1.AutoSize = True
KginicialesLabel1.Location = New System.Drawing.Point(32, 352)
KginicialesLabel1.Name = "KginicialesLabel1"
KginicialesLabel1.Size = New System.Drawing.Size(59, 13)
KginicialesLabel1.TabIndex = 19
KginicialesLabel1.Text = "kginiciales:"
KginicialesLabel1.Visible = False
'
'KgFinalesLabel1
'
KgFinalesLabel1.AutoSize = True
KgFinalesLabel1.Location = New System.Drawing.Point(227, 352)
KgFinalesLabel1.Name = "KgFinalesLabel1"
KgFinalesLabel1.Size = New System.Drawing.Size(59, 13)
KgFinalesLabel1.TabIndex = 21
KgFinalesLabel1.Text = "Kg Finales:"
KgFinalesLabel1.Visible = False
'
'Fecha_consumoLabel1
'
Fecha_consumoLabel1.AutoSize = True
Fecha_consumoLabel1.Location = New System.Drawing.Point(44, 381)
Fecha_consumoLabel1.Name = "Fecha_consumoLabel1"
Fecha_consumoLabel1.Size = New System.Drawing.Size(86, 13)
Fecha_consumoLabel1.TabIndex = 23
Fecha_consumoLabel1.Text = "Fecha consumo:"
Fecha_consumoLabel1.Visible = False
'
'EmpalmadorLabel1
'
EmpalmadorLabel1.AutoSize = True
EmpalmadorLabel1.Location = New System.Drawing.Point(7, 188)
EmpalmadorLabel1.Name = "EmpalmadorLabel1"
EmpalmadorLabel1.Size = New System.Drawing.Size(67, 13)
EmpalmadorLabel1.TabIndex = 18
EmpalmadorLabel1.Text = "empalmador:"
'
'BindingNavigator1
'
Me.BindingNavigator1.AddNewItem = Nothing
Me.BindingNavigator1.BindingSource = Me.ConsumosBindingSource1
Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.GuardarToolStripButton, Me.toolStripSeparator, Me.toolStripSeparator1})
Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
Me.BindingNavigator1.Name = "BindingNavigator1"
Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
Me.BindingNavigator1.Size = New System.Drawing.Size(619, 25)
Me.BindingNavigator1.TabIndex = 4
Me.BindingNavigator1.Text = "BindingNavigator1"
'
'ConsumosBindingSource1
'
Me.ConsumosBindingSource1.DataMember = "Consumos"
Me.ConsumosBindingSource1.DataSource = Me.DataSetConsumos
'
'DataSetConsumos
'
Me.DataSetConsumos.DataSetName = "DataSetConsumos"
Me.DataSetConsumos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'BindingNavigatorCountItem
'
Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
Me.BindingNavigatorCountItem.Text = "de {0}"
Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
'
'BindingNavigatorDeleteItem
'
Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorDeleteItem.Enabled = False
Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorDeleteItem.Text = "Eliminar"
'
'BindingNavigatorMoveFirstItem
'
Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
'
'BindingNavigatorMovePreviousItem
'
Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
'
'BindingNavigatorSeparator
'
Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
'
'BindingNavigatorPositionItem
'
Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
Me.BindingNavigatorPositionItem.AutoSize = False
Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
Me.BindingNavigatorPositionItem.Text = "0"
Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
'
'BindingNavigatorSeparator1
'
Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
'
'BindingNavigatorMoveNextItem
'
Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
'
'BindingNavigatorMoveLastItem
'
Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
Me.BindingNavigatorMoveLastItem.Text = "Mover último"
'
'BindingNavigatorSeparator2
'
Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
'
'GuardarToolStripButton
'
Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
Me.GuardarToolStripButton.Text = "&Guardar"
'
'toolStripSeparator
'
Me.toolStripSeparator.Name = "toolStripSeparator"
Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
'
'toolStripSeparator1
'
Me.toolStripSeparator1.Name = "toolStripSeparator1"
Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
'
'ConsumosTableAdapter1
'
Me.ConsumosTableAdapter1.ClearBeforeFill = True
'
'Fecha_consumoDateTimePicker
'
Me.Fecha_consumoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConsumosBindingSource1, "Fecha_consumo", True))
Me.Fecha_consumoDateTimePicker.Enabled = False
Me.Fecha_consumoDateTimePicker.Location = New System.Drawing.Point(387, 3)
Me.Fecha_consumoDateTimePicker.Name = "Fecha_consumoDateTimePicker"
Me.Fecha_consumoDateTimePicker.Size = New System.Drawing.Size(200, 20)
Me.Fecha_consumoDateTimePicker.TabIndex = 5
'
'No_pedido_otTextBox
'
Me.No_pedido_otTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "no_pedido_ot", True))
Me.No_pedido_otTextBox.Enabled = False
Me.No_pedido_otTextBox.Location = New System.Drawing.Point(232, 36)
Me.No_pedido_otTextBox.Name = "No_pedido_otTextBox"
Me.No_pedido_otTextBox.Size = New System.Drawing.Size(100, 20)
Me.No_pedido_otTextBox.TabIndex = 6
'
'RolloTextBox
'
Me.RolloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "Rollo", True))
Me.RolloTextBox.Enabled = False
Me.RolloTextBox.Location = New System.Drawing.Point(232, 62)
Me.RolloTextBox.Name = "RolloTextBox"
Me.RolloTextBox.Size = New System.Drawing.Size(100, 20)
Me.RolloTextBox.TabIndex = 7
'
'No_ciTextBox
'
Me.No_ciTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "no_ci", True))
Me.No_ciTextBox.Enabled = False
Me.No_ciTextBox.Location = New System.Drawing.Point(35, 36)
Me.No_ciTextBox.Name = "No_ciTextBox"
Me.No_ciTextBox.Size = New System.Drawing.Size(100, 20)
Me.No_ciTextBox.TabIndex = 8
'
'Id_maquina_consumoTextBox
'
Me.Id_maquina_consumoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "id_maquina_consumo", True))
Me.Id_maquina_consumoTextBox.Enabled = False
Me.Id_maquina_consumoTextBox.Location = New System.Drawing.Point(487, 33)
Me.Id_maquina_consumoTextBox.Name = "Id_maquina_consumoTextBox"
Me.Id_maquina_consumoTextBox.Size = New System.Drawing.Size(100, 20)
Me.Id_maquina_consumoTextBox.TabIndex = 10
'
'Parte_rolloTextBox
'
Me.Parte_rolloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "parte_rollo", True))
Me.Parte_rolloTextBox.Enabled = False
Me.Parte_rolloTextBox.Location = New System.Drawing.Point(487, 65)
Me.Parte_rolloTextBox.Name = "Parte_rolloTextBox"
Me.Parte_rolloTextBox.Size = New System.Drawing.Size(100, 20)
Me.Parte_rolloTextBox.TabIndex = 14
'
'KginicialesTextBox
'
Me.KginicialesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "kginiciales", True))
Me.KginicialesTextBox.Location = New System.Drawing.Point(72, 109)
Me.KginicialesTextBox.Name = "KginicialesTextBox"
Me.KginicialesTextBox.Size = New System.Drawing.Size(100, 20)
Me.KginicialesTextBox.TabIndex = 16
'
'KgFinalesTextBox
'
Me.KgFinalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "KgFinales", True))
Me.KgFinalesTextBox.Location = New System.Drawing.Point(72, 145)
Me.KgFinalesTextBox.Name = "KgFinalesTextBox"
Me.KgFinalesTextBox.Size = New System.Drawing.Size(100, 20)
Me.KgFinalesTextBox.TabIndex = 18
'
'KginicialesLabel2
'
Me.KginicialesLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "kginiciales", True))
Me.KginicialesLabel2.Location = New System.Drawing.Point(97, 352)
Me.KginicialesLabel2.Name = "KginicialesLabel2"
Me.KginicialesLabel2.Size = New System.Drawing.Size(100, 23)
Me.KginicialesLabel2.TabIndex = 20
Me.KginicialesLabel2.Visible = False
'
'KgFinalesLabel2
'
Me.KgFinalesLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "KgFinales", True))
Me.KgFinalesLabel2.Location = New System.Drawing.Point(289, 342)
Me.KgFinalesLabel2.Name = "KgFinalesLabel2"
Me.KgFinalesLabel2.Size = New System.Drawing.Size(100, 23)
Me.KgFinalesLabel2.TabIndex = 22
Me.KgFinalesLabel2.Visible = False
'
'Fecha_consumoTextBox
'
Me.Fecha_consumoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "Fecha_consumo", True))
Me.Fecha_consumoTextBox.Location = New System.Drawing.Point(136, 378)
Me.Fecha_consumoTextBox.Name = "Fecha_consumoTextBox"
Me.Fecha_consumoTextBox.Size = New System.Drawing.Size(227, 20)
Me.Fecha_consumoTextBox.TabIndex = 24
Me.Fecha_consumoTextBox.Visible = False
'
'Panel1
'
Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
Me.Panel1.Controls.Add(EmpalmadorLabel1)
Me.Panel1.Controls.Add(Me.EmpalmadorComboBox)
Me.Panel1.Controls.Add(Me.Fecha_consumoDateTimePicker)
Me.Panel1.Controls.Add(Fecha_consumoLabel)
Me.Panel1.Controls.Add(Me.No_pedido_otTextBox)
Me.Panel1.Controls.Add(No_pedido_otLabel)
Me.Panel1.Controls.Add(Me.No_ciTextBox)
Me.Panel1.Controls.Add(No_ciLabel)
Me.Panel1.Controls.Add(Me.RolloTextBox)
Me.Panel1.Controls.Add(Parte_rolloLabel)
Me.Panel1.Controls.Add(KgFinalesLabel)
Me.Panel1.Controls.Add(Me.Parte_rolloTextBox)
Me.Panel1.Controls.Add(RolloLabel)
Me.Panel1.Controls.Add(Me.KgFinalesTextBox)
Me.Panel1.Controls.Add(Id_maquina_consumoLabel)
Me.Panel1.Controls.Add(KginicialesLabel)
Me.Panel1.Controls.Add(Me.Id_maquina_consumoTextBox)
Me.Panel1.Controls.Add(Me.KginicialesTextBox)
Me.Panel1.Location = New System.Drawing.Point(12, 38)
Me.Panel1.Name = "Panel1"
Me.Panel1.Size = New System.Drawing.Size(607, 356)
Me.Panel1.TabIndex = 25
'
'EmpalmadorComboBox
'
Me.EmpalmadorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsumosBindingSource1, "empalmador", True))
Me.EmpalmadorComboBox.FormattingEnabled = True
Me.EmpalmadorComboBox.Items.AddRange(New Object() {"E1D", "E2D", "E3D", "E4D", "E5D", "E1I", "E2I", "E3I", "E4I", "E5I"})
Me.EmpalmadorComboBox.Location = New System.Drawing.Point(72, 185)
Me.EmpalmadorComboBox.Name = "EmpalmadorComboBox"
Me.EmpalmadorComboBox.Size = New System.Drawing.Size(121, 21)
Me.EmpalmadorComboBox.TabIndex = 19
'
'consumos_update
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(619, 410)
Me.Controls.Add(Me.Panel1)
Me.Controls.Add(Fecha_consumoLabel1)
Me.Controls.Add(Me.Fecha_consumoTextBox)
Me.Controls.Add(KgFinalesLabel1)
Me.Controls.Add(Me.KgFinalesLabel2)
Me.Controls.Add(KginicialesLabel1)
Me.Controls.Add(Me.KginicialesLabel2)
Me.Controls.Add(Me.BindingNavigator1)
Me.Name = "consumos_update"
Me.Text = "consumos_update"
CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
Me.BindingNavigator1.ResumeLayout(False)
Me.BindingNavigator1.PerformLayout()
CType(Me.ConsumosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.DataSetConsumos, System.ComponentModel.ISupportInitialize).EndInit()
Me.Panel1.ResumeLayout(False)
Me.Panel1.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents DataSetConsumos As IF4_1._0._0.DataSetConsumos
    Friend WithEvents ConsumosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumosTableAdapter1 As IF4_1._0._0.DataSetConsumosTableAdapters.ConsumosTableAdapter
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Fecha_consumoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents No_pedido_otTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RolloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_ciTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_maquina_consumoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Parte_rolloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KginicialesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KgFinalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KginicialesLabel2 As System.Windows.Forms.Label
    Friend WithEvents KgFinalesLabel2 As System.Windows.Forms.Label
    Friend WithEvents Fecha_consumoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EmpalmadorComboBox As System.Windows.Forms.ComboBox
End Class
