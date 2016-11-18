

Public Class Index
    Dim pro
    Dim ver, ing, cons, eva, eva_r, fechas_cprograma



    'Definir enlace a datos y objetos del form

   


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pro = Carga_programa
        pro.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ver = programas
        ver.Show()
    End Sub

    Private Sub Index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.usuariolbl.Text = My.Settings.StrUser
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       ' ing = Ingreso_consumos
        'ing.show()
        metodos.set_dest_carga("01_CORR2")
fechas_cprograma = fechas_cprograma_frm
fechas_cprograma.show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        metodos.set_dest_carga("01_CORR1")
        fechas_cprograma = fechas_cprograma_frm
        fechas_cprograma.show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        metodos.set_dest_carga("01_SF1")
        fechas_cprograma = fechas_cprograma_frm
        fechas_cprograma.show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        metodos.set_dest_carga("01_SF2")
        fechas_cprograma = fechas_cprograma_frm
        fechas_cprograma.show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        cons = consumos
        cons.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        pro = salida_rollo
        pro.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        pro = Carga_produccion
        pro.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ver = My.Forms.Produccion2
        ver.Show()
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        About.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        eva = Evaluar
        Evaluar.Show()
    End Sub

Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
 My.Forms.settings_menu.Show()
End Sub

Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
  My.Forms.General_frm.Show()

End Sub

Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        'My.Forms.generaldinamico.Show()
End Sub

Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
  My.Forms.index_ayudas_ct.Show()
End Sub

Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

End Sub

Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
My.Forms.index_ayudas_cr.Show()
End Sub

Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

eva_r = Evaluar_r
        Evaluar_r.Show()




End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class