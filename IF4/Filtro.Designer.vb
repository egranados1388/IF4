<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtro
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.ciftxt = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label2.Location = New System.Drawing.Point(73, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "C.I:"
        '
        'ciftxt
        '
        Me.ciftxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.ciftxt.Location = New System.Drawing.Point(122, 41)
        Me.ciftxt.Name = "ciftxt"
        Me.ciftxt.Size = New System.Drawing.Size(267, 32)
        Me.ciftxt.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(190, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 70)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Filtro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 230)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ciftxt)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Filtro"
        Me.Text = "Filtro"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ciftxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
