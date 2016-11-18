<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bitacora
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
        Me.txtnote = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(2, 12)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtnote.Size = New System.Drawing.Size(701, 250)
        Me.txtnote.TabIndex = 0
        '
        'bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 274)
        Me.Controls.Add(Me.txtnote)
        Me.Name = "bitacora"
        Me.Text = "bitacora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
End Class
