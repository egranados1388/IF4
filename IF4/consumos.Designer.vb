<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consumos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consumos))
        Me.Button1 = New System.Windows.Forms.Button
        Me.inicio_consumo_txt = New System.Windows.Forms.DateTimePicker
        Me.Del = New System.Windows.Forms.Label
        Me.fin_consumo_txt = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.corr1_cbx = New System.Windows.Forms.CheckBox
        Me.corr2_cbx = New System.Windows.Forms.CheckBox
        Me.sf1_cbx = New System.Windows.Forms.CheckBox
        Me.sf2_cbx = New System.Windows.Forms.CheckBox
        Me.ci_txt = New System.Windows.Forms.TextBox
        Me.CI = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ot_txt = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistroDeModifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1102, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 87)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inicio_consumo_txt
        '
        Me.inicio_consumo_txt.Location = New System.Drawing.Point(78, 32)
        Me.inicio_consumo_txt.Name = "inicio_consumo_txt"
        Me.inicio_consumo_txt.Size = New System.Drawing.Size(233, 20)
        Me.inicio_consumo_txt.TabIndex = 2
        '
        'Del
        '
        Me.Del.AutoSize = True
        Me.Del.Location = New System.Drawing.Point(21, 38)
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(26, 13)
        Me.Del.TabIndex = 3
        Me.Del.Text = "Del:"
        '
        'fin_consumo_txt
        '
        Me.fin_consumo_txt.Location = New System.Drawing.Point(355, 32)
        Me.fin_consumo_txt.Name = "fin_consumo_txt"
        Me.fin_consumo_txt.Size = New System.Drawing.Size(200, 20)
        Me.fin_consumo_txt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Al:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Maquina:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "(Fecha de consumo)"
        '
        'corr1_cbx
        '
        Me.corr1_cbx.AutoSize = True
        Me.corr1_cbx.Checked = True
        Me.corr1_cbx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.corr1_cbx.Location = New System.Drawing.Point(82, 58)
        Me.corr1_cbx.Name = "corr1_cbx"
        Me.corr1_cbx.Size = New System.Drawing.Size(51, 17)
        Me.corr1_cbx.TabIndex = 9
        Me.corr1_cbx.Text = "Corr1"
        Me.corr1_cbx.UseVisualStyleBackColor = True
        '
        'corr2_cbx
        '
        Me.corr2_cbx.AutoSize = True
        Me.corr2_cbx.Location = New System.Drawing.Point(131, 58)
        Me.corr2_cbx.Name = "corr2_cbx"
        Me.corr2_cbx.Size = New System.Drawing.Size(51, 17)
        Me.corr2_cbx.TabIndex = 10
        Me.corr2_cbx.Text = "Corr2"
        Me.corr2_cbx.UseVisualStyleBackColor = True
        '
        'sf1_cbx
        '
        Me.sf1_cbx.AutoSize = True
        Me.sf1_cbx.Location = New System.Drawing.Point(188, 58)
        Me.sf1_cbx.Name = "sf1_cbx"
        Me.sf1_cbx.Size = New System.Drawing.Size(45, 17)
        Me.sf1_cbx.TabIndex = 11
        Me.sf1_cbx.Text = "SF1"
        Me.sf1_cbx.UseVisualStyleBackColor = True
        '
        'sf2_cbx
        '
        Me.sf2_cbx.AutoSize = True
        Me.sf2_cbx.Location = New System.Drawing.Point(239, 58)
        Me.sf2_cbx.Name = "sf2_cbx"
        Me.sf2_cbx.Size = New System.Drawing.Size(45, 17)
        Me.sf2_cbx.TabIndex = 12
        Me.sf2_cbx.Text = "SF2"
        Me.sf2_cbx.UseVisualStyleBackColor = True
        '
        'ci_txt
        '
        Me.ci_txt.Location = New System.Drawing.Point(82, 91)
        Me.ci_txt.Name = "ci_txt"
        Me.ci_txt.Size = New System.Drawing.Size(120, 20)
        Me.ci_txt.TabIndex = 13
        '
        'CI
        '
        Me.CI.AutoSize = True
        Me.CI.Location = New System.Drawing.Point(21, 94)
        Me.CI.Name = "CI"
        Me.CI.Size = New System.Drawing.Size(26, 13)
        Me.CI.TabIndex = 14
        Me.CI.Text = "C.I :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID Pedido (OT):"
        '
        'ot_txt
        '
        Me.ot_txt.Location = New System.Drawing.Point(355, 91)
        Me.ot_txt.Name = "ot_txt"
        Me.ot_txt.Size = New System.Drawing.Size(100, 20)
        Me.ot_txt.TabIndex = 16
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem, Me.RegistroDeModifToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'RegistroDeModifToolStripMenuItem
        '
        Me.RegistroDeModifToolStripMenuItem.Name = "RegistroDeModifToolStripMenuItem"
        Me.RegistroDeModifToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RegistroDeModifToolStripMenuItem.Text = "Registro de Modif."
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(956, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 87)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1004, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Eliminar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(811, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 87)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(24, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1228, 426)
        Me.DataGridView1.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(583, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 79)
        Me.TextBox1.TabIndex = 24
        '
        'consumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 563)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ot_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CI)
        Me.Controls.Add(Me.ci_txt)
        Me.Controls.Add(Me.sf2_cbx)
        Me.Controls.Add(Me.sf1_cbx)
        Me.Controls.Add(Me.corr2_cbx)
        Me.Controls.Add(Me.corr1_cbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fin_consumo_txt)
        Me.Controls.Add(Me.Del)
        Me.Controls.Add(Me.inicio_consumo_txt)
        Me.Controls.Add(Me.Button1)
        Me.Name = "consumos"
        Me.Text = "Consumos  Registrados"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents inicio_consumo_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Del As System.Windows.Forms.Label
    Friend WithEvents fin_consumo_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents corr1_cbx As System.Windows.Forms.CheckBox
    Friend WithEvents corr2_cbx As System.Windows.Forms.CheckBox
    Friend WithEvents sf1_cbx As System.Windows.Forms.CheckBox
    Friend WithEvents sf2_cbx As System.Windows.Forms.CheckBox
    Friend WithEvents ci_txt As System.Windows.Forms.TextBox
    Friend WithEvents CI As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ot_txt As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeModifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
