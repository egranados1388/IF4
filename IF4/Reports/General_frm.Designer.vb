<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class General_frm
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
Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
Me.general1 = New IF4_1._0._0.general
Me.SuspendLayout()
'
'CrystalReportViewer1
'
Me.CrystalReportViewer1.ActiveViewIndex = 0
Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
Me.CrystalReportViewer1.ReportSource = Me.general1
Me.CrystalReportViewer1.Size = New System.Drawing.Size(703, 610)
Me.CrystalReportViewer1.TabIndex = 0
'
'General_frm
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(703, 610)
Me.Controls.Add(Me.CrystalReportViewer1)
Me.Name = "General_frm"
Me.Text = "General_frm"
Me.ResumeLayout(False)

End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents general1 As IF4_1._0._0.general
End Class
