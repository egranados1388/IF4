Public Class fechas_cprograma_frm
Dim ing

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
My.Settings.fini = Me.DateTimePicker1.Value.ToString
My.Settings.ffin = Me.DateTimePicker2.Value.ToString
'MessageBox.Show("Recogido inicio:" + My.Settings.fini.ToString + " fin:" + My.Settings.ffin.ToString)
ing = Ingreso_consumos
ing.show()
Me.Close()
End Sub

Private Sub fechas_cprograma_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Carga de  CI programadas  " + metodos.destino_carga
End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class