Public Class Filtro

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       ' Dim m_Pos = Ingreso_consumos.BindingSource1.Find("no_pedido_ot", Me.TextBox2.Text)

         'Ingreso_consumos.BindingSource1.Position = m_Pos
         'Ingreso_consumos.BindingSource1.Filter = "ci_instruccioncorrugadora = '" + Me.ciftxt.Text + "'"
 Dim pos = Ingreso_consumos.BindingSource1.Find("ci_instruccioncorrugadora", Me.ciftxt.Text)
Ingreso_consumos.BindingSource1.Position = pos


Me.Close()
'Ingreso_consumos.Focus()
Ingreso_consumos.empalmador_cmb.Focus()
    End Sub

Private Sub Filtro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  Me.ciftxt.Focus()
End Sub
End Class