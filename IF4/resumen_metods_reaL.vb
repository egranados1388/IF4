
Imports System.Data.Odbc ''//Libreria metodos para conexion odbc

Public Class resumen_metods_real
    Shared cs As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"




''// Borra  existencia de  muestras(registros  muestras_t)
Public Shared Function clean_resumen() As Integer

        Try


            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "delete  from resumen_r"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()

            End While


        Catch i As Exception
            MessageBox.Show("Clean resumen " + i.ToString())
        End Try


    End Function


  Public Shared Function integra_resumen(ByVal indice, ByVal ci, ByVal empalmador, ByVal rollo, ByVal fecha_consumo, ByVal consecutivo, ByVal correccion)


       Dim sal As Double
        Dim fecha_consu As String = Format(fecha_consumo, "MM/dd/yyyy HH:mm:ss")


        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs



            Dim cmd2 As New OdbcCommand
            cmd2.Connection = conn2
           conn2.Open()
            cmd2.CommandText = "INSERT INTO resumen_r  VALUES " & _
          "(" + CStr(indice) + ",'" + ci + "','" + empalmador + "','" + rollo + "','" + fecha_consu + "','si','si'," + CStr(consecutivo) + "," + CStr(correccion) + ",0.00,0.00,0.00,0.00,0.00,0.00,'no','-',0.00,0.00,'part',0.00,0.00,0.00,0.00,0.00,0.00,'-',0.00,'-',0.00,'-')"
            cmd2.ExecuteNonQuery()







            Return sal


            conn2.Close()





        Catch a As Exception
            MessageBox.Show(" Insertar resumen " + a.ToString())
        End Try
        Return sal

    End Function












Public Shared Function get_papel(ByVal parte)


        Dim papel As String 'exteción del fichero
        Dim punto_corte As Integer 'punto
        punto_corte = parte.LastIndexOf("/") 'obtengo el punto
        'MESSAGEBOX.SHOW("2")
        papel = parte.Substring(0, (punto_corte - 0))
Return papel


End Function


Public Shared Function get_ancho(ByVal parte)


        Dim ancho As String 'exteción del fichero
        Dim punto_corte As Integer 'punto
        punto_corte = parte.LastIndexOf("/") 'obtengo el punto
        'MESSAGEBOX.SHOW("2")


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



        Return ancho








End Function








Public Shared Function actualiza_resumen()

''// Analizar registro de  muestra

        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = " Select  * from muestras_r "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

''// Declaracion de  variables

Dim indice, parte_r, ot_r, ancho_r, rollo_r, CI_r, kginicialescorregido_r, kgfinalescorregido_r
Dim ancho_c, papel_c, empalmador_r
Dim conta As Integer = 0



Dim kginiciales_r
Dim kgfinales_r
Dim fecha_consumo_r


            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas de  muestras_t  calculos
indice = reader2.GetValue(0) ''/ Indice
parte_r = reader2.GetString(10)
ot_r = reader2.GetString(6)
ancho_r = reader2.GetString(16) ''// Ancho programa
rollo_r = reader2.GetString(11)
CI_r = reader2.GetString(7)
kginicialescorregido_r = reader2.GetString(47)
kgfinalescorregido_r = reader2.GetString(46)

conta = conta + 1
kginiciales_r = reader2.GetValue(12)
fecha_consumo_r = reader2.GetDateTime(5)
kgfinales_r = reader2.GetValue(13)
empalmador_r = reader2.GetValue(9)









''// BH papel coincide
papel_c = get_papel(parte_r)

''si no es papel correcto 0
Dim papel_coincide As Integer = metodos.bol_papel(papel_c, ot_r)
update_bh(indice, papel_coincide)
'MessageBox.Show("BH:" + CStr(papel_coincide))



'MessageBox.Show("1:")
''//BI ancho coincide
ancho_c = get_ancho(parte_r) ''// Ancho de consumo
Dim ancho_coincide As Integer = metodos.bol_ancho(ancho_c, ancho_r) ''si no es ancho  correcto 0
update_bi(indice, ancho_coincide)
'MessageBox.Show("BI:" + CStr(ancho_coincide))

'MessageBox.Show("2:")
''// BJ Consecutivo aparicion parte-Lote
''// ya  validado a  tabla resumen_t desde integra


''// BK Correccion kg  negativos  por  cambio
''// ya  validado a  tabla resumen_t desde integra


''//BL
'MessageBox.Show("3:")
Dim capturas_duplicadas_BL = get_BL(parte_r, rollo_r, CI_r)
'MessageBox.Show("4:")
update_bl(indice, capturas_duplicadas_BL)
'MessageBox.Show("Bl:" + CStr(capturas_duplicadas_BL))
'MessageBox.Show("5:")




''//BM
Dim bm_cicapturaduplicado
If (capturas_duplicadas_BL = 1) Then
bm_cicapturaduplicado = "NO"
Else
bm_cicapturaduplicado = CI_r + CStr("-SI")
End If
update_bm(indice, bm_cicapturaduplicado)


''MessageBox.Show("Fin primer  revision x registros  muestras_t HASTA  COL BM")
''// 1er revision------------------------




''bn//

Dim bn_inicalesacum = get_bn_cuenta_inicalesacum(indice, parte_r, rollo_r, kginicialescorregido_r)
update_bn(indice, bn_inicalesacum)

''bo //

Dim bo_fincalesacum = get_bn_cuenta_finalesacum(indice, parte_r, rollo_r, kgfinalescorregido_r)
'update_bo(indice, bo_fincalesacum)


''//BP
Dim bp_entradassalidas = bn_inicalesacum - bo_fincalesacum
update_bp(indice, bp_entradassalidas)


''//BQ
Dim tiene_kgsalida
If (kgfinalescorregido_r > 0) Then
tiene_kgsalida = "-con salida"
Else
tiene_kgsalida = "_"
End If
update_bq(indice, tiene_kgsalida)


''//BR
Dim entradas_salidasKgsalidas
entradas_salidasKgsalidas = CStr(bp_entradassalidas) + "" + CStr(tiene_kgsalida)
update_br(indice, entradas_salidasKgsalidas)




'MessageBox.Show("fin de  segunda  revision  de bn hasta  br")






''// BS
''// Pendiente
Dim bs_respuesta = "OK"
update_bs(indice, bs_respuesta)


''BT //
Dim cisinerror = Trim(CStr(CI_r)) + "-" + CStr(bs_respuesta)
update_bt(indice, Trim(cisinerror))




''BU
Dim kgdisponiblerollo_r = reader2.GetValue(26)
Dim kgrequeridosCIempalmador_r = reader2.GetValue(19)
Dim kgfaltantesCI2_r = reader2.GetValue(35)
Dim faltaderollo

If (kgdisponiblerollo_r = 0) And (kgrequeridosCIempalmador_r = kgfaltantesCI2_r) Then
faltaderollo = 1
Else
faltaderollo = 0
End If
'update_bu(indice, faltaderollo)



'' BV
Dim cifaltaderollo = Trim(CStr(CI_r)) + "-" + CStr(faltaderollo)
update_bv(indice, Trim(cifaltaderollo))


'' Bw
Dim rolloescaneadoynousado
If (kginiciales_r = kgfinales_r) Then
 rolloescaneadoynousado = 0
Else
rolloescaneadoynousado = 1
End If
update_bw(indice, rolloescaneadoynousado)


''BX
Dim parte_lote = parte_r + "-" + rollo_r
update_bx(indice, parte_lote)



'' //

'MessageBox.Show("Fin de  tercer repaso de BS a  BX")



''by
''pendiente
Dim ultimo_kgsalida = 0
update_by(indice, ultimo_kgsalida)




''// CC

Dim kginiciales_cuenta = get_kginiciales_cuenta(indice, parte_r, rollo_r)
update_cc(indice, kginiciales_cuenta)



''// CD

Dim kgfinales_cuenta = get_kgfinales_cuenta(indice, parte_r, rollo_r)
update_cd(indice, kgfinales_cuenta)




''// CA
''CA
''pendiente
Dim MaximoKgEntrada = 1000
'update_ca(indice, MaximoKgEntrada)



''// CB



Dim kgconsumodisponiblexrollo_r = reader2.GetValue(23)
Dim DiferenciaUltimoKgSalidanoafecta = kgconsumodisponiblexrollo_r
'update_cb(indice, kgconsumodisponiblexrollo_r)





''// CE
Dim diferenciautlimokg_siafecta
If ((kginiciales_cuenta - kgfinales_cuenta) = 0) Then

diferenciautlimokg_siafecta = 0

Else

       If (MaximoKgEntrada = kgconsumodisponiblexrollo_r) Then
diferenciautlimokg_siafecta = 0
Else
diferenciautlimokg_siafecta = 1

       End If

End If
update_ce(indice, diferenciautlimokg_siafecta)
'diferenciaenultimokgsalidaafecta





''////bz
Dim diferenciaenentrada


If (kginiciales_r = ultimo_kgsalida) Then

diferenciaenentrada = 0

Else
diferenciaenentrada = 1

End If

diferenciaenentrada = diferenciaenentrada * diferenciautlimokg_siafecta
update_bz(indice, diferenciaenentrada)
''diferenci_ent_sal


'MessageBox.Show("fin de  cuarta  revision desde by a  bz y ce")







''// CF

Dim CIDifKgEntradayKgSalida = Trim(CStr(CI_r)) + "-" + CStr(diferenciaenentrada)
update_cf(indice, CIDifKgEntradayKgSalida)
'ci_dif_ent_sal()



''// CG

Dim ultimo = "E1"
update_cg(indice, ultimo)

''// CH

Dim cambioempalmador_sinval
If (empalmador_r = ultimo) Then
cambioempalmador_sinval = 0

Else

        If (kginicialescorregido_r > 0) Then

            cambioempalmador_sinval = 0
        Else
            cambioempalmador_sinval = 1
        End If

End If
update_ch(indice, cambioempalmador_sinval)




''//CI 

Dim ci_error = Trim(CStr(CI_r)) + CStr(cambioempalmador_sinval)
update_ci(indice, ci_error)


''// CJ

Dim kginicialesduplicados = get_kginicialesduplica(indice, parte_r, rollo_r, kginiciales_r)
update_cj(indice, kginicialesduplicados)


''// CK
Dim ci_error2 = Trim(CStr(CI_r)) + CStr(kginicialesduplicados)
update_ck(indice, ci_error2)


'MessageBox.Show("fin de  revision 5  de cf a ck")


            End While

            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("actualuiza  res " + i.ToString())
        End Try
        Return sal

    End Function





    Public Shared Function update_cj(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET kginicialesduplic =  " + CStr(val) + "    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function





    Public Shared Function update_ck(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET ci_error2 =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function








    Public Shared Function update_cf(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET ci_dif_ent_sal =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function







    Public Shared Function update_cg(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET ultimo_emp_re =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function



Public Shared Function update_ch(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET cambio_empal_sinval =  " + CStr(val) + "    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function



Public Shared Function update_ci(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET ci_error_ =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function












    Public Shared Function update_ca(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET tipo_papel_coincide =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function







    Public Shared Function update_ce(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET diferenciaenultimokgsalidaafecta =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function





    Public Shared Function update_bz(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET diferenci_ent_sal =  " + CStr(val) + "    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function













    Public Shared Function update_bh(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET tipo_papel_coincide =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function






    Public Shared Function update_by(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET ultimokgsalida =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function





    Public Shared Function update_cc(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET kginicialescuenta =  " + CStr(val) + "    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function






    Public Shared Function update_cd(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET kgfinalescuenta =  " + CStr(val) + "    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function





    Public Shared Function update_bs(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET respuesta =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function






    Public Shared Function update_bt(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET cisinerror =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function



    Public Shared Function update_bu(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET faltaderollo =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function




    Public Shared Function update_bv(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET faltaderollo ='" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function






    Public Shared Function update_bw(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET rolloescaneadoynousado =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function





    Public Shared Function update_bx(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET parte_lote =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function






































    Public Shared Function update_bn(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET kginicialescuentacum =" + CStr(val) + "  WHERE  indice = " + CStr(indice) + " "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("bm ---   " + i.ToString())
        End Try
        Return 0

    End Function






    Public Shared Function update_bo(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET =" + CStr(val) + "  WHERE  indice = " + CStr(indice) + " "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("bm ---   " + i.ToString())
        End Try
        Return 0

    End Function








    Public Shared Function update_bp(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET entradas_salidas =" + CStr(val) + "  WHERE  indice = " + CStr(indice) + " "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("bm ---   " + i.ToString())
        End Try
        Return 0

    End Function








    Public Shared Function update_bq(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET tienekgsalida = '" + CStr(val) + "'  WHERE  indice = " + CStr(indice) + " "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("bq ---   " + i.ToString())
        End Try
        Return 0

    End Function







    Public Shared Function update_br(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET ent_sal_kgsalida ='" + CStr(val) + "'  WHERE  indice = " + CStr(indice) + " "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("bm ---   " + i.ToString())
        End Try
        Return 0

    End Function



















    Public Shared Function update_bm(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET cicapturaduplicada ='" + CStr(val) + "'  WHERE  indice = " + CStr(indice) + " "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("bm ---   " + i.ToString())
        End Try
        Return 0

    End Function








Public Shared Function get_kginiciales_cuenta(ByVal indice, ByVal parte, ByVal rollo)
Dim parte_vs, rollo_vs, kginicorr_vs
 Dim suma = 0, entry = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()

            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item("parte")
rollo_vs = reader2.Item("rollo")
kginicorr_vs = reader2.Item("V5")

'MessageBox.Show("1.5.2")
If (parte = parte_vs And rollo = rollo_vs And kginicorr_vs > 0) Then

suma = suma + 1

End If


            End While

            entry = suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr - " + i.ToString())
        End Try



Return entry


End Function
















Public Shared Function get_kginicialesduplica(ByVal indice, ByVal parte, ByVal rollo, ByVal kginiciales)
Dim parte_vs, rollo_vs, kgini_vs
 Dim suma = 0, entry = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()

            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item("parte")
rollo_vs = reader2.Item("rollo")
kgini_vs = reader2.Item(12)

'MessageBox.Show("1.5.2")
If (parte = parte_vs And rollo = rollo_vs And kgini_vs > 0 And kgini_vs = kginiciales) Then

suma = suma + 1

End If


            End While

            entry = suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr - " + i.ToString())
        End Try



Return entry


End Function























Public Shared Function get_kgfinales_cuenta(ByVal indice, ByVal parte, ByVal rollo)
Dim parte_vs, rollo_vs, kginicorr_vs
 Dim suma = 0, entry = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()

            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item("parte")
rollo_vs = reader2.Item("rollo")
kginicorr_vs = reader2.Item("V4")

'MessageBox.Show("1.5.2")
If (parte = parte_vs And rollo = rollo_vs And kginicorr_vs > 0) Then

suma = suma + 1

End If


            End While

            entry = suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr - " + i.ToString())
        End Try



Return entry


End Function




































    Public Shared Function update_bl(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET capturasduplicadas =  " + CStr(val) + "    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function











    Public Shared Function update_bi(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  resumen_r SET ancho_papel_coincide =  '" + CStr(val) + "'    WHERE  indice = " + CStr(indice) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons dis  rollo " + i.ToString())
        End Try
        Return 0

    End Function






















Public Shared Function actualiza_resumen2()

''// Analizar registro de  muestra

        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = " Select  * from resumen_r "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
'Dim parte_r
'Dim ot_r

'Dim ancho_r
'Dim rollo_r
'Dim CI_r
Dim kginiciales_r As Double = 0.0
Dim kgfinales_r As Double = 0.0
'Dim fecha_consumo_r


'Dim parte_lote
            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas
conta = conta + 1
'parte_r = reader2.GetString(10)
'ot_r = reader2.GetString(6)
'ancho_r = 0 ''// Ancho programa
'rollo_r = 0
'CI_r = reader2.GetString("CI")
'kginiciales_r = reader2.GetString("kginiciales")
'fecha_consumo_r = reader2.GetString("fecha_consumo")
'kgfinales_r = reader2.GetString("kgfinales")
'parte_lote = reader2.GetString("partelote")
''/segundo calculo

''//Para  segundo calculo---------------------------------------------------




''CB

'Dim DiferenciaenUltimoKgSalidanoafecta = get_diferenciaenultimo(parte_lote)









            End While

            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("actualuiza  res2  " + i.ToString())
        End Try
        Return sal

    End Function






























    Public Shared Function get_kginicorr(ByVal rollo, ByVal kginici, ByVal parte, ByVal fecha_consumo) As Double
'MessageBox.Show(" cons : " + CStr(fecha_consumo) + " inic: " + CStr(inicio_m) + " fin: " + CStr(fin_m))

'MessageBox.Show("ingresando a  double")
Dim entry As Double = 0

'MessageBox.Show("saliendo")
        Dim suma As Double = 0
        Dim parte_vs As String = ""
        Dim rollo_vs As String = ""
        Dim kgini_vs As Double = 0
'MessageBox.Show("1.3")
If (kginici > 0) Then
'MessageBox.Show("1.4")
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r  where     Fecha_consumo < '" + CStr(fecha_consumo) + "'    order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
'MessageBox.Show("1.5")
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
'MessageBox.Show("1.5.1")
parte_vs = reader2.Item("parte")
rollo_vs = reader2.Item("rollo")
kgini_vs = reader2.Item("kginiciales")

'MessageBox.Show("1.5.2")
If (parte = parte_vs And rollo = rollo_vs And kginici = kgini_vs) Then

suma = suma + CDbl(reader2.Item(7))

End If


            End While

            entry = kginici - suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr - " + i.ToString())
        End Try


Else
entry = kginici
End If

Return entry

End Function


Public Shared Function get_diferenciaenultimo(ByVal partelote)
Dim parte_vs, kginicorr_vs, lote_vs
 Dim suma = 0, entry = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r  "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()

            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item("parte")
lote_vs = reader2.Item("rollo")
kginicorr_vs = reader2.Item("V5")

'MessageBox.Show("1.5.2")
If ((parte_vs + "-" + lote_vs) = partelote) Then

suma = suma + kginicorr_vs

End If


            End While

            entry = suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr - " + i.ToString())
        End Try



Return entry


End Function







Public Shared Function get_bn_cuenta_inicalesacum(ByVal indice, ByVal parte, ByVal rollo, ByVal inicialescorr)
Dim parte_vs, rollo_vs, inicialescorr_vs
 Dim suma = 0, entry = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r where MrowID <= " + CStr(indice) + " order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()

            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item("parte")
rollo_vs = reader2.Item("rollo")
inicialescorr_vs = reader2.Item("V5")

'MessageBox.Show("1.5.2")
If ((parte = parte_vs) And (rollo = rollo_vs) And (inicialescorr_vs > 0)) Then

suma = suma + 1

End If


            End While

            entry = suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr - " + i.ToString())
        End Try



Return entry


End Function












Public Shared Function get_bn_cuenta_finalesacum(ByVal indice, ByVal parte, ByVal rollo, ByVal finalescorr)
Dim parte_vs, rollo_vs, kginicorr_vs
 Dim suma = 0, entry = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r where MrowID <= " + CStr(indice) + " order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()

            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item("parte")
rollo_vs = reader2.Item("rollo")
kginicorr_vs = reader2.Item("V4")

'MessageBox.Show("1.5.2")
If (parte = parte_vs And rollo = rollo_vs And kginicorr_vs > 0) Then

suma = suma + 1

End If


            End While

            entry = suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr - " + i.ToString())
        End Try



Return entry


End Function













    Public Shared Function get_kgfinalescorr(ByVal rollo, ByVal kgfinal, ByVal parte, ByVal fecha_consumo) As Integer
        Dim entry As Double
        Dim suma As Double = 0
        Dim parte_vs As String = ""
        Dim rollo_vs As String = ""
        Dim kgfinal_vs As Double = 0

If (kgfinal > 0) Then

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM muestras_r  where     Fecha_consumo < '" + CStr(fecha_consumo) + "'    order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item("parte")
rollo_vs = reader2.Item("rollo")
kgfinal_vs = reader2.Item(13)


If (parte = parte_vs And rollo = rollo_vs And kgfinal = kgfinal_vs) Then

suma = suma + CDbl(reader2.Item(7))

End If


            End While

            entry = kgfinal - suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg fin corr" + i.ToString())
        End Try


Else
entry = kgfinal
End If

Return entry
    End Function














    Public Shared Function get_BL(ByVal parte, ByVal lote, ByVal CI) As Integer
        Dim entry As Double

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select  count(parte) as entradas  from muestras_r where  parte= '" + CStr(parte) + "' and rollo='" + CStr(lote) + "' and  CI='" + CStr(CI) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                entry = CInt(reader2.Item("entradas"))
            End While

            Return entry

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("get BL :" + i.ToString())
        End Try


    End Function








End Class
