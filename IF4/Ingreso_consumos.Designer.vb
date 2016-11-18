<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_consumos
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
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ci_txt = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.fecha_prog_txt = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.reloj_lbl = New System.Windows.Forms.Label
        Me.maquina_programa_txt = New System.Windows.Forms.TextBox
        Me.ancho_prog_txt = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.ot_txt = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.parterollo_TXT = New System.Windows.Forms.TextBox
        Me.kginiciales_txt = New System.Windows.Forms.TextBox
        Me.rollo_txt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label15 = New System.Windows.Forms.Label
        Me.partepapel_lbl = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.ancho_lbl = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Status_stt = New System.Windows.Forms.ToolStripStatusLabel
        Me.maquina_cmb = New System.Windows.Forms.ComboBox
        Me.empalmador_cmb = New System.Windows.Forms.ComboBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConjuntoTablasIF4 = New IF4_1._0._0.DSConjuntoTablasIF4
        Me.ProgramadoTableAdapter = New IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.ProgramadoTableAdapter
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 684)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1354, 36)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(70, 33)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 36)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 36)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'ci_txt
        '
        Me.ci_txt.BackColor = System.Drawing.SystemColors.Control
        Me.ci_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ci_instruccioncorrugadora", True))
        Me.ci_txt.Enabled = False
        Me.ci_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ci_txt.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ci_txt.Location = New System.Drawing.Point(49, 29)
        Me.ci_txt.Name = "ci_txt"
        Me.ci_txt.Size = New System.Drawing.Size(195, 31)
        Me.ci_txt.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "calidad", True))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(379, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 31)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "C.I:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(587, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha y Hora  Programada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Flauta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(682, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Longitud  Pedido (m)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(745, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Ancho papel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "No Pedido (ot)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(295, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Maquina Programada"
        '
        'fecha_prog_txt
        '
        Me.fecha_prog_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "fecha_hora_programada", True))
        Me.fecha_prog_txt.Enabled = False
        Me.fecha_prog_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_prog_txt.Location = New System.Drawing.Point(835, 29)
        Me.fecha_prog_txt.Name = "fecha_prog_txt"
        Me.fecha_prog_txt.Size = New System.Drawing.Size(241, 31)
        Me.fecha_prog_txt.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Peru
        Me.GroupBox1.Controls.Add(Me.reloj_lbl)
        Me.GroupBox1.Controls.Add(Me.maquina_programa_txt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ancho_prog_txt)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.ot_txt)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.fecha_prog_txt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ci_txt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1082, 184)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos  de  Programa:"
        '
        'reloj_lbl
        '
        Me.reloj_lbl.AutoSize = True
        Me.reloj_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.reloj_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.reloj_lbl.Location = New System.Drawing.Point(7, 155)
        Me.reloj_lbl.Name = "reloj_lbl"
        Me.reloj_lbl.Size = New System.Drawing.Size(16, 24)
        Me.reloj_lbl.TabIndex = 33
        Me.reloj_lbl.Text = "-"
        '
        'maquina_programa_txt
        '
        Me.maquina_programa_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "id_maquina_prod", True))
        Me.maquina_programa_txt.Enabled = False
        Me.maquina_programa_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maquina_programa_txt.Location = New System.Drawing.Point(492, 113)
        Me.maquina_programa_txt.Name = "maquina_programa_txt"
        Me.maquina_programa_txt.Size = New System.Drawing.Size(202, 31)
        Me.maquina_programa_txt.TabIndex = 13
        '
        'ancho_prog_txt
        '
        Me.ancho_prog_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ancho_pedido_mm", True))
        Me.ancho_prog_txt.Enabled = False
        Me.ancho_prog_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancho_prog_txt.Location = New System.Drawing.Point(935, 117)
        Me.ancho_prog_txt.Name = "ancho_prog_txt"
        Me.ancho_prog_txt.Size = New System.Drawing.Size(141, 31)
        Me.ancho_prog_txt.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "longitud_pedido_mm", True))
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(935, 67)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(141, 31)
        Me.TextBox7.TabIndex = 14
        '
        'ot_txt
        '
        Me.ot_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "no_pedido_ot", True))
        Me.ot_txt.Enabled = False
        Me.ot_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ot_txt.Location = New System.Drawing.Point(6, 113)
        Me.ot_txt.Name = "ot_txt"
        Me.ot_txt.Size = New System.Drawing.Size(238, 31)
        Me.ot_txt.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "flauta", True))
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(379, 72)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(149, 31)
        Me.TextBox4.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 31)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "* Maquina"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(568, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 31)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "* Empalmador"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(591, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 31)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Kg Iniciales:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 31)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "* Parte :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(390, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(405, 39)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "DATOS DE  CONSUMO"
        '
        'parterollo_TXT
        '
        Me.parterollo_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parterollo_TXT.Location = New System.Drawing.Point(181, 346)
        Me.parterollo_TXT.Name = "parterollo_TXT"
        Me.parterollo_TXT.Size = New System.Drawing.Size(284, 38)
        Me.parterollo_TXT.TabIndex = 30
        '
        'kginiciales_txt
        '
        Me.kginiciales_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!)
        Me.kginiciales_txt.Location = New System.Drawing.Point(754, 337)
        Me.kginiciales_txt.Multiline = True
        Me.kginiciales_txt.Name = "kginiciales_txt"
        Me.kginiciales_txt.Size = New System.Drawing.Size(346, 86)
        Me.kginiciales_txt.TabIndex = 50
        '
        'rollo_txt
        '
        Me.rollo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollo_txt.Location = New System.Drawing.Point(181, 446)
        Me.rollo_txt.Name = "rollo_txt"
        Me.rollo_txt.Size = New System.Drawing.Size(284, 38)
        Me.rollo_txt.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 453)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 31)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "* ID Rollo"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.Location = New System.Drawing.Point(1167, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 116)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "Buscar en Programa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button2.Location = New System.Drawing.Point(1167, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 116)
        Me.Button2.TabIndex = 120
        Me.Button2.Text = "Reestablecer Original"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button3.Location = New System.Drawing.Point(1167, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 116)
        Me.Button3.TabIndex = 130
        Me.Button3.Text = "Definir  Periodo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button4.Location = New System.Drawing.Point(976, 510)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(185, 116)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "GUARDAR COSUMO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LinkLabel1.Location = New System.Drawing.Point(941, 218)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(159, 24)
        Me.LinkLabel1.TabIndex = 180
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Detalle  Pedido CI"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(175, 395)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 31)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Papel:"
        '
        'partepapel_lbl
        '
        Me.partepapel_lbl.AutoSize = True
        Me.partepapel_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partepapel_lbl.Location = New System.Drawing.Point(282, 395)
        Me.partepapel_lbl.Name = "partepapel_lbl"
        Me.partepapel_lbl.Size = New System.Drawing.Size(23, 31)
        Me.partepapel_lbl.TabIndex = 30
        Me.partepapel_lbl.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(311, 395)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 31)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Ancho :"
        '
        'ancho_lbl
        '
        Me.ancho_lbl.AutoSize = True
        Me.ancho_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancho_lbl.Location = New System.Drawing.Point(423, 395)
        Me.ancho_lbl.Name = "ancho_lbl"
        Me.ancho_lbl.Size = New System.Drawing.Size(23, 31)
        Me.ancho_lbl.TabIndex = 32
        Me.ancho_lbl.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowDrop = True
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Status_stt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 658)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1354, 26)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "."
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(168, 21)
        Me.ToolStripStatusLabel1.Text = "*Campos  Obligatorios"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Status_stt
        '
        Me.Status_stt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_stt.ForeColor = System.Drawing.Color.Red
        Me.Status_stt.Name = "Status_stt"
        Me.Status_stt.Size = New System.Drawing.Size(16, 21)
        Me.Status_stt.Text = "-"
        '
        'maquina_cmb
        '
        Me.maquina_cmb.Enabled = False
        Me.maquina_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maquina_cmb.FormattingEnabled = True
        Me.maquina_cmb.Items.AddRange(New Object() {"01_CORR2", "01_CORR1", "01_SF1", "01_SF2"})
        Me.maquina_cmb.Location = New System.Drawing.Point(181, 292)
        Me.maquina_cmb.Name = "maquina_cmb"
        Me.maquina_cmb.Size = New System.Drawing.Size(284, 39)
        Me.maquina_cmb.TabIndex = 10
        '
        'empalmador_cmb
        '
        Me.empalmador_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empalmador_cmb.FormattingEnabled = True
        Me.empalmador_cmb.Items.AddRange(New Object() {"E1D", "E2D", "E3D", "E4D", "E5D", "E1I", "E2I", "E3I", "E4I", "E5I", "", ""})
        Me.empalmador_cmb.Location = New System.Drawing.Point(754, 292)
        Me.empalmador_cmb.Name = "empalmador_cmb"
        Me.empalmador_cmb.Size = New System.Drawing.Size(346, 39)
        Me.empalmador_cmb.TabIndex = 20
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button5.Location = New System.Drawing.Point(1167, 510)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(187, 116)
        Me.Button5.TabIndex = 181
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button6.Location = New System.Drawing.Point(1167, 388)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(187, 116)
        Me.Button6.TabIndex = 182
        Me.Button6.Text = "Actualizar  programacion"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Button7.Location = New System.Drawing.Point(380, 555)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(115, 71)
        Me.Button7.TabIndex = 183
        Me.Button7.Text = "|<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Button8.Location = New System.Drawing.Point(501, 555)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(115, 71)
        Me.Button8.TabIndex = 184
        Me.Button8.Text = "<<"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Button9.Location = New System.Drawing.Point(622, 555)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(115, 71)
        Me.Button9.TabIndex = 185
        Me.Button9.Text = ">>"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Button10.Location = New System.Drawing.Point(743, 555)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(115, 71)
        Me.Button10.TabIndex = 186
        Me.Button10.Text = ">|"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Programado"
        Me.BindingSource1.DataSource = Me.DSConjuntoTablasIF4
        '
        'DSConjuntoTablasIF4
        '
        Me.DSConjuntoTablasIF4.DataSetName = "DSConjuntoTablasIF4"
        Me.DSConjuntoTablasIF4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProgramadoTableAdapter
        '
        Me.ProgramadoTableAdapter.ClearBeforeFill = True
        '
        'Ingreso_consumos
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1354, 720)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.empalmador_cmb)
        Me.Controls.Add(Me.maquina_cmb)
        Me.Controls.Add(Me.ancho_lbl)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.partepapel_lbl)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.rollo_txt)
        Me.Controls.Add(Me.kginiciales_txt)
        Me.Controls.Add(Me.parterollo_TXT)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "Ingreso_consumos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Consumos de Rollo "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConjuntoTablasIF4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ci_txt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    'Friend WithEvents DSProgramado As IF4_1._0._0.DSProgramado
    'Friend WithEvents ProgramadoTableAdapter As IF4_1._0._0.DSProgramadoTableAdapters.ProgramadoTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fecha_prog_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ot_txt As System.Windows.Forms.TextBox
    Friend WithEvents maquina_programa_txt As System.Windows.Forms.TextBox
    Friend WithEvents ancho_prog_txt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents parterollo_TXT As System.Windows.Forms.TextBox
    Friend WithEvents kginiciales_txt As System.Windows.Forms.TextBox
    Friend WithEvents rollo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents partepapel_lbl As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ancho_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents reloj_lbl As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents maquina_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents empalmador_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Status_stt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DSConjuntoTablasIF4 As IF4_1._0._0.DSConjuntoTablasIF4
    Friend WithEvents ProgramadoTableAdapter As IF4_1._0._0.DSConjuntoTablasIF4TableAdapters.ProgramadoTableAdapter
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
