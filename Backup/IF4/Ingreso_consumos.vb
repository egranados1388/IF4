
Imports System
Imports IF4_1

Imports IF4_1._0._0.fechas_cprograma_frm

Public Class Ingreso_consumos
    Dim Filtrov
    Dim FECHA As String
Dim I
Dim F
Dim posicion As Integer


    Private Sub Ingreso_consumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.maquina_cmb.Text = metodos.destino_carga

        ''Definicion de  periodo  programado a  mostrar
        'Dim strDOB As String
        Dim res As Integer
        'strDOB = InputBox("Ingrese  la fecha  de  inicio de programacion", _
        '"IF4 Ingreso de  Consumo de  Rollo", _
        '"MM/DD/AA")
        'FECHA = strDOB
        'FECHA = inic.fecha_ini





'MessageBox.Show(" tratado ini: " + My.Settings.fini.ToString + " fin: " + My.Settings.ffin)

        Dim sYear As String = CDate(My.Settings.fini).Year
        Dim sMonth As String = CDate(My.Settings.fini).Month
        Dim sDay As String = CDate(My.Settings.fini).Day
         I = sYear + "-" + sMonth + "-" + sDay + " " + "00:00:00.000"


 Dim sYear2 As String = CDate(My.Settings.ffin).Year
        Dim sMonth2 As String = CDate(My.Settings.ffin).Month
        Dim sDay2 As String = CDate(My.Settings.ffin).Day
       F = sYear2 + "-" + sMonth2 + "-" + sDay2 + " " + "00:00:00.000"





'MessageBox.Show("I format : " + I + " F format : " + F)
        ''Tratandose de  un fecha  valida
        If (IsDate(I)) And (IsDate(F)) Then

            res = 1
           ' MessageBox.Show("aplicando filtro")

            Me.BindingSource1.Filter = "id_maquina_prod = '" + CStr(metodos.destino_carga.ToString) + "' AND   fecha_hora_programada  >='" + I + "' AND   fecha_hora_programada <='" + F + "'   "
Me.BindingSource1.Sort = "fecha_hora_programada"
Me.ProgramadoTableAdapter.Fill(Me.DSConjuntoTablasIF4.Programado)

  'Me.ProgramadoTableAdapter.Fill(Me.DSConjuntoTablasIF4.Programado)
          ' Me.BindingSource1.Filter = "id_maquina_prod = '01_CORR2' AND   fecha_hora_programada >= '" + CDate(I) + "'"



        Else
            MsgBox("Se  necesita  una  fecha  validad", _
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, _
                   "Error")
            res = 0

        End If

    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


posicion = Me.BindingSource1.Position

    'MessageBox.Show("dejando binding posicion:" + posicion)
        Filtrov = Filtro
        Filtrov.Show()


'Me.empalmador_cmb.Focus()
        ' Me.BindingSource1.Filter = "no_pedido_ot = '088435'"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

      Me.BindingSource1.RemoveFilter()
        Me.BindingSource1.Filter = "id_maquina_prod = '01_CORR2' AND   fecha_hora_programada  >='" + I + "' AND   fecha_hora_programada <='" + F + "'"
  'MessageBox.Show("recargando binding posicion:" + posicion.ToString)
Me.BindingSource1.Position = posicion

Me.empalmador_cmb.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim strDOB As String
        Dim strDOB2 As String

        strDOB = InputBox("Ingrese  la fecha  de  inicio de programacion", _
        "IF4 Ingreso de  Consumo de  Rollo", _
        "DD/MM/AA")



 strDOB2 = InputBox("Ingrese  la fecha  Final de programacion", _
        "IF4 Ingreso de  Consumo de  Rollo", _
        "DD/MM/AA")


        If IsDate(strDOB) Then
            '  MsgBox("Fecha " & CDate(strDOB).ToString("D") + " - " + strDOB + "-" + CDate(strDOB), _
            ' MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, _
            ' "")


        Dim sYear As String = CDate(strDOB).Year
        Dim sMonth As String = CDate(strDOB).Month
        Dim sDay As String = CDate(strDOB).Day
         I = sYear + "-" + sMonth + "-" + sDay + " " + "00:00:00.000"



        Dim sYear2 As String = CDate(strDOB2).Year
        Dim sMonth2 As String = CDate(strDOB2).Month
        Dim sDay2 As String = CDate(strDOB2).Day
         F = sYear2 + "-" + sMonth2 + "-" + sDay2 + " " + "00:00:00.000"



            Me.ProgramadoTableAdapter.Fill(Me.DSConjuntoTablasIF4.Programado)
            'Me.BindingSource1.Filter = "id_maquina_prod = '01_CORR2' AND   fecha_hora_programada >= '" + I + "'"
            Me.BindingSource1.Filter = "id_maquina_prod = '01_CORR2' AND   fecha_hora_programada >='" + I + "' AND   fecha_hora_programada <='" + F + "'   "
                Me.BindingSource1.Sort = "fecha_hora_programada"
        Else
            MsgBox("Se  necesita  una  fecha  validad", _
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, _
                   "Error")


        End If

Me.empalmador_cmb.Focus()

    End Sub
    Dim detalle
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        detalle = DetalleOT
        detalle.show()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
Dim stoper As Double = 0
Dim mensajes As Double = 0

        'VALIDA  vacios obligatorios

        If (Me.maquina_cmb.Text = "" Or Me.empalmador_cmb.Text = "" Or Me.parterollo_TXT.Text = "" Or Me.rollo_txt.Text = "") Then

            MessageBox.Show("Hay campos  obligatorios  sin capturar")
            ' stoper = 1
            mensajes = 1
            '' Si todos  los campos obligatorios  estan completos entonces
        Else




            Dim maq_warning As Integer
            Dim maq_error As Integer







            ''---------------------------------validar  entradas-------------------------------------------


            ''Maquina - Linea  produccion
            maq_warning = (metodos.bol_maquina(Me.maquina_cmb.Text))
            maq_error = (metodos.bol_maquina_programa(Me.maquina_cmb.Text, Me.maquina_programa_txt.Text))
            ''Si la  maquina es  valida 
            If (maq_warning = 0) Then

                MessageBox.Show("Introduzca  maquina  valida")
                'stoper = 1
            Else

                ''Si la maquina  de  consumo no coincide  con programada
                If (maq_error = 0) Then


                    MessageBox.Show("No hay coincidencia  entre  la  maquina  programada  y de  consumo")
                    'stoper = 0
                    ''// indica  maquina  aprobada  y valida e  inicia  validacion de  empalmador

                Else

                    Dim bol_empalmador = metodos.bol_empalmador(Me.empalmador_cmb.Text)

                    If (bol_empalmador = 0) Then

                        MessageBox.Show("Error  en empalmador  seleccionado")
                        ' stoper = 1.1
                        ''// Si el empalmador  es  correcto entonces  validamos  parte - rollo
                    Else

                        Dim error_parte = metodos.bol_parte(Me.parterollo_TXT.Text)
                        Dim error_papel = metodos.bol_papel(Me.partepapel_lbl.Text, Me.ot_txt.Text)
                        Dim error_ancho = metodos.bol_ancho(CDbl(Me.ancho_lbl.Text), CDbl(Me.ancho_prog_txt.Text))
                        If (error_parte = 0) Then


                            MessageBox.Show("La  parte  seleccionada  no existe  o no tiene  existencia")
                            ''// Si la  parte  existe y tiene  existencia   entonces  validamos  su existenacia  en el pedido  por medio del material
                            ' stoper = 1.2
                        Else


                            If ((error_papel = 0) Or (error_ancho = 0)) Then


                                '//Si el papel y la  parte  estan correctos  validamos  el rollo capturado


Dim r = MsgBox("Hay Incosistencias  entre  papel de  combinacion o ancho diferente, desea continuar?", _
                   MsgBoxStyle.YesNo Or MsgBoxStyle.Information, _
                   "Alerta")


If r = MsgBoxResult.No Then   ' User chose Yes.
   Exit Sub ' Perform some action.
End If
                                'stoper = 0





                            Else

                                Dim error_rollo = metodos.bol_lote(Me.rollo_txt.Text, Me.parterollo_TXT.Text)
                                If (error_rollo = 0) Then

                                    MessageBox.Show("El rollo capturado no es  valido")
                                    'stoper = 1.3
                                     mensajes = 1


                                Else


                                    ''// Validacion consumo previo


                                    'MessageBox.Show("opcional")
                                    Dim error_consumo_val = metodos.consumo_valido(Me.parterollo_TXT.Text, Me.rollo_txt.Text, Me.empalmador_cmb.Text, Me.ci_txt.Text)

                                    If (error_consumo_val > 0) Then
                                    MessageBox.Show("Consumo invalido . Revise sus  consumos 1.4 ")
                                        'stoper = 1.4
                                    Else



                                    ''// Validacion kginiciales



                                    Dim error_kginiciales = metodos.val_kginiciales(Me.parterollo_TXT.Text, Me.rollo_txt.Text)

                                    If (error_kginiciales = 0 And ((Me.kginiciales_txt.Text = String.Empty) Or ((Me.kginiciales_txt.Text = "0")))) Then

                                    If (mensajes = 0) Then
                                    MessageBox.Show("Se  necesita  una  entrada  de  kg iniciales  para este  registro")
                                    End If
                                            'stoper = 1.5


                                    End If

                                    End If ''/ Fin consumo valido


                                End If ''// Fin  rollo



                            End If ''// Fin tipo papel y ancho


                        End If ''// Fin parte  existencia



                    End If ''// Fin emplamador




                End If ''// Fin maquina  vs  programada


            End If ''// FIn maquina


        End If ''// Fin obligatorios


  ''// Validacion consumo previo






                                   ' MessageBox.Show("obligatorio     ")
                                    Dim error_consumo_val2 = metodos.consumo_valido(Me.parterollo_TXT.Text, Me.rollo_txt.Text, Me.empalmador_cmb.Text, Me.ci_txt.Text)

                                    If (error_consumo_val2 > 0) Then
            'stoper = 1.4
                                    If (mensajes = 0) Then
                                    MessageBox.Show("Consumo invalido . Revise sus  consumos 1.4.1")

                                    End If

'stoper = 1.4
            Else
         'MessageBox.Show(" else valido")

                                    End If


                                    ''// Validacion kginiciales


                           ' MessageBox.Show("validando iniciales ")
                            Dim error_kginiciales2 = metodos.val_kginiciales(Me.parterollo_TXT.Text, Me.rollo_txt.Text)

                                    If (error_kginiciales2 = 0 And ((Me.kginiciales_txt.Text = String.Empty) Or ((Me.kginiciales_txt.Text = "0")))) Then
                                     If (mensajes = 0) Then
                                    MessageBox.Show("Se  necesita  una  entrada  de  kg iniciales  para este  registro")
                                    End If
            'stoper = 1.5



                                    End If ''/ Fin consumo valido




If (stoper > 0) Then ''// Insercion de  registro segun stoper o permiso para  insertar

  If (mensajes = 0) Then
MessageBox.Show("No se puede  completar el registro . Codigo de  error:" + CStr(stoper))
End If

Else

  ''// Esto significa  que  los  campos son validos  y podemos  realizar  el grabado


  ''// Convertimos  la cadena  vacia  de kg iniciales  a 0

                                    Dim kginiciales_var
                                    If (Me.kginiciales_txt.Text = String.Empty) Then

                                        kginiciales_var = "0"

                                    Else
                                        kginiciales_var = Me.kginiciales_txt.Text

                                    End If
                                    Dim ThisMoment As DateTime
                                    ' The following statement calls the Get procedure of the Visual Basic Now property.
                                    ThisMoment = Now
                                    'MessageBox.Show("original:" + CStr(ThisMoment))
                                    'MessageBox.Show("this mo to short date:" + ThisMoment.ToShortDateString)
                                    '  MessageBox.Show("this mo to LONG TIME:" + ThisMoment.ToLongTimeString)


                                    Dim s As String
                                    s = ThisMoment.ToShortDateString + " " + ThisMoment.ToLongTimeString
                                    'MessageBox.Show("CADENA: " + s)

                                    'Dim s22 As String = Format(Now, "YYYYMMDD  HH:mm:ss")

                                    'Dim s23 As String = Format(CDate(Me.fecha_prog_txt.Text), "YYYYMMDD  HH:mm:ss")


                                    Dim s22 As String = Format(Now, "MM/dd/yyyy  HH:mm:ss")
                                    '"YYYYMMDD hh:mn:ss"
                                    Dim s23 As String = Format(CDate(Me.fecha_prog_txt.Text), "MM/dd/yyyy  HH:mm:ss")





                                    ' Date.Now.ToString("MM/dd/yyyy HH:mm:ss")
                                    ' MessageBox.Show("fecha  prog: " + s23)

                                    metodos.insert_consumo(s23, s22, Me.ot_txt.Text, Me.ci_txt.Text, Me.maquina_cmb.Text, Me.empalmador_cmb.Text, Me.parterollo_TXT.Text, kginiciales_var, Me.rollo_txt.Text)




End If







Me.empalmador_cmb.Focus()


    End Sub


   


    Private Sub cargapartepapel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parterollo_TXT.Leave

        Try

            Dim parte = Me.parterollo_TXT.Text
            Dim papel, ancho As String 'exteción del fichero
            Dim punto_corte As Integer 'punto
            punto_corte = parte.LastIndexOf("/") 'obtengo el punto
            'MESSAGEBOX.SHOW("2")
            papel = parte.Substring(0, (punto_corte - 0))

            Dim dis As Integer
            Dim tamano As Integer = parte.length()
            '' // DEFINIMOS  PROCEDIMINETO PARA CUANDO HAY MENOS  O MAS GRAMAJE proporcion de  string  tres  o cuatro digitos
            If (tamano = 9) Then
                dis = 4
            Else
                dis = 3
            End If

            Dim ras As Integer
            ras = punto_corte + 1
            ancho = parte.Substring(ras, dis)


            Me.partepapel_lbl.Text = papel
            Me.ancho_lbl.Text = ancho

        Catch



        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.reloj_lbl.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.parterollo_TXT.Text = ""
        Me.rollo_txt.Text = ""
        Me.kginiciales_txt.Text = ""
Me.empalmador_cmb.Text = ""

Me.empalmador_cmb.Focus()
    End Sub

   
    Private Sub parterollo_TXT_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles parterollo_TXT.KeyUp
        Me.Status_stt.Text = "-"
    End Sub

Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

  posicion = Me.BindingSource1.Find("ci_instruccioncorrugadora", Me.ci_txt.Text)


'MessageBox.Show("Posicion dejada:" + posicion.ToString)
Me.BindingSource1.RemoveFilter()
Me.BindingSource1.Filter = "id_maquina_prod = '01_CORR2' AND   fecha_hora_programada  >='" + I + "' AND   fecha_hora_programada <='" + F + "'   "
Me.BindingSource1.Sort = "fecha_hora_programada"

Me.BindingSource1.Position = posicion
'MessageBox.Show("Posicion asignada:" + posicion.ToString)
Me.ProgramadoTableAdapter.Fill(Me.DSConjuntoTablasIF4.Programado)
Me.BindingSource1.Position = posicion
  
Me.empalmador_cmb.Focus()


End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.empalmador_cmb.Focus()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.empalmador_cmb.Focus()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.empalmador_cmb.Focus()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.empalmador_cmb.Focus()
    End Sub

    Private Sub maquina_cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maquina_cmb.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub fecha_prog_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha_prog_txt.TextChanged

    End Sub

    Private Sub ot_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ot_txt.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub partepapel_lbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles partepapel_lbl.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub kginiciales_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kginiciales_txt.TextChanged

    End Sub

    Private Sub empalmador_cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empalmador_cmb.SelectedIndexChanged

    End Sub

    Private Sub rollo_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rollo_txt.TextChanged

    End Sub

    Private Sub parterollo_TXT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parterollo_TXT.TextChanged

    End Sub

    Private Sub ancho_lbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancho_lbl.Click

    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.BindingSource1.MovePrevious()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.BindingSource1.MoveNext()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.BindingSource1.MoveFirst()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.BindingSource1.MoveLast()
    End Sub

    Private Sub BindingNavigatorCountItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCountItem.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class