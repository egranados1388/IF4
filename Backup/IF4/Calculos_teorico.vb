''Clase modelo  para calculos de consumo teorico IF4


Imports System.Data.Odbc ''//Libreria metodos para conexion odbc
''Inicio de clase
Public Class Calculos_teorico
''// Cadeba conexion ser-sql.IF4 database
Shared cs As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"





''// Borra  existencia de  muestras(registros  muestras_t)
Public Shared Function clean_dbayuda() As Integer

        Try


            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "delete  from muestras_t"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()

            End While


        Catch i As Exception
            MessageBox.Show("Clean dbayuda " + i.ToString())
        End Try


    End Function





    Public Shared Function set_factor(ByVal empalmador, ByVal flauta) As Double


        ''/// Asignacion de  factores de faluta
        Dim factor As Double
       ' MessageBox.Show("flauta:" + CStr(flauta))
       ' MessageBox.Show("Emplamador:" + CStr(empalmador))
Dim f As String = Trim(flauta)


        If (empalmador = "E1" Or empalmador = "E1") Then

            Select Case f
                Case "C"
                    factor = 1
                  '  MessageBox.Show("C: fac : " + CStr(factor))

                Case "B"
                    factor = 0
                   ' MessageBox.Show("B: fac : " + CStr(factor))

                Case "E"
                    factor = 0
                   ' MessageBox.Show("e: fac : " + CStr(factor))

                Case "CB", "BC"
                    factor = 1
                    ' MessageBox.Show("Cb: fac : " + CStr(factor))

                Case "CE", "EC"

                    factor = 1
                   ' MessageBox.Show("ce: fac : " + CStr(factor))



            End Select

        End If



        If (empalmador = "E2" Or empalmador = "E2") Then
'MessageBox.Show("2")
            Select Case f
                Case "C"
                    factor = 1.45

                Case "B"
                    factor = 0

                Case "E"
                    factor = 0

                Case "CB"
                    factor = 1.45
                Case "BC"
                    factor = 1.45
                Case "CE"
                    factor = 1.45
 Case "EC"
                    factor = 1.45



            End Select

        End If



        If (empalmador = "E3" Or empalmador = "E3") Then
'MessageBox.Show("3")
            Select Case f
                Case "C"
                    factor = 0

                Case "B"
                    factor = 1

                Case "E"
                    factor = 1

                Case "CB"
                    factor = 1
                Case "BC"
                    factor = 1
                Case "CE"
                    factor = 1
                Case "EC"
                    factor = 1



            End Select

        End If

        If (empalmador = "E4" Or empalmador = "E4") Then
'MessageBox.Show("4")
            Select Case f
                Case "C"
                    factor = 0

                Case "B"
                    factor = 1.4

                Case "E"
                    factor = 1.33

                Case "CB"
                    factor = 1.4
                Case "BC"
                    factor = 1.4
                Case "CE"
                    factor = 1.33
                Case "EC"
                    factor = 1.33



            End Select

        End If

        If (empalmador = "E5" Or empalmador = "E5") Then
'MessageBox.Show("5")
            Select Case f
                Case "C"
                    factor = 1

                Case "B"
                    factor = 1

                Case "E"
                    factor = 1

                Case "CB"
                    factor = 1
                Case "BC"
                    factor = 1
                Case "CE"
                    factor = 1

                Case "EC"
                    factor = 1




            End Select

        End If


        Return factor




    End Function


    Public Shared Function get_gramaje(ByVal parte) As String




        ''---------------OBTENIENDO GRAMAJE  A PARTIR  DE  PARTE ---''''
        Dim ext, ext2 As String 'exteción del fichero
        Dim p As Integer 'punto
        p = parte.LastIndexOf("/") 'obtengo el punto
        'MESSAGEBOX.SHOW("2")
        ext = parte.Substring(1, (p - 1))
        Dim dis As Integer
        Dim tamano As Integer = parte.length()
        '' // DEFINIMOS  PROCEDIMINETO PARA CUANDO HAY MENOS  O MAS GRAMAJE proporcion de  string  tres  o cuatro digitos
        If (tamano = 9) Then
            dis = 4
        Else
            dis = 3
        End If

        Dim ras As Integer
        ras = p + 1
        ext2 = parte.Substring(ras, dis)
        Return ext
       ' MessageBox.Show("ext1 " + CStr(ext))
    End Function



    Public Shared Function get_entrada(ByVal rollo) As Double
        Dim entry As Double
'MessageBox.Show("Rollo:" + CStr(rollo))
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select  sum(kginiciales) as entradas  from consumos where  rollo = '" + CStr(rollo) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                If (reader2.Item("entradas").Equals(DBNull.Value)) Then

 entry = CInt(0)
Else

                entry = CInt(reader2.Item("entradas"))

End If

            End While

            Return entry

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("get entrada :" + i.ToString())
        End Try


    End Function





    Public Shared Function get_salida(ByVal rollo) As Double
        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select  sum(kgfinales) as salida  from consumos where rollo = '" + CStr(rollo) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                   If reader2.Item("salida").Equals(DBNull.Value) Then

sal = 0
Else
sal = CInt(reader2.Item("salida"))
                   End If


            End While

            Return sal

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("get salida " + i.ToString())
        End Try


    End Function












    Public Shared Function get_mismorollokgini(ByVal rollo, ByVal kginici) As Integer
        Dim entry As Double
If (kginici.Equals(DBNull.Value)) Then
kginici = 0

End If
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select count( rollo ) from Consumos  where rollo = '" + CStr(rollo) + "' and  kginiciales =" + CStr(kginici) + "  and  kginiciales > 0"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                entry = CInt(reader2.Item(0))
            End While

            Return entry

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("get kginici mismo rollo:" + i.ToString())
        End Try


    End Function











    Public Shared Function get_kginicorr(ByVal rollo, ByVal kginici, ByVal parte, ByVal fecha_consumo, ByVal inicio_m, ByVal fin_m) As Double
'MessageBox.Show(" cons : " + CStr(fecha_consumo) + " inic: " + CStr(inicio_m) + " fin: " + CStr(fin_m))

'MessageBox.Show("ingresando a  double")
Dim entry As Double = 0

'MessageBox.Show("saliendo")
        Dim suma As Double = 0
        Dim parte_vs As String = ""
        Dim rollo_vs As String = ""
        Dim kgini_vs As Double = 0
'MessageBox.Show("1.3")

If (kginici.Equals(DBNull.Value)) Then

kginici = 0

End If



If (kginici > 0) Then
'MessageBox.Show("1.4")
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM Consumos  where   Fecha_consumo between  '" + CStr(inicio_m) + "'    and  '" + CStr(fin_m) + "'  and  Fecha_consumo < '" + CStr(fecha_consumo) + "'    order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
'MessageBox.Show("1.5")
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
'MessageBox.Show("1.5.1")
parte_vs = reader2.Item(6)
rollo_vs = reader2.Item(9)


If (reader2.Item(7).Equals(DBNull.Value)) Then
kgini_vs = 0


Else
kgini_vs = reader2.Item(7)
End If


'MessageBox.Show("1.5.2")
If (parte = parte_vs And rollo = rollo_vs And kginici = kgini_vs) Then

If (reader2.Item(7).Equals(DBNull.Value)) Then

suma = suma + 0

Else

suma = suma + CDbl(reader2.Item(7))
End If
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






    Public Shared Function get_kgfinalcorr(ByVal rollo, ByVal kgfinal, ByVal parte, ByVal fecha_consumo, ByVal inicio_m, ByVal fin_m) As Integer
        Dim entry As Double
        Dim suma As Double = 0
        Dim parte_vs As String = ""
        Dim rollo_vs As String = ""
        Dim kgfinal_vs As Double = 0
If (kgfinal.Equals(DBNull.Value)) Then

kgfinal = 0
End If



If (kgfinal > 0) Then

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM Consumos  where   Fecha_consumo between  '" + CStr(inicio_m) + "'    and  '" + CStr(fin_m) + "'  and  Fecha_consumo < '" + CStr(fecha_consumo) + "'    order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item(6)
rollo_vs = reader2.Item(9)

If (reader2.Item(7).Equals(DBNull.Value)) Then
kgfinal_vs = 0
Else
kgfinal_vs = reader2.Item(7)
End If






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






    Public Shared Function get_consec_aparicion(ByVal parte, ByVal rollo, ByVal inicio_m, ByVal fin_m) As Double
        Dim entry As Double
        Dim suma As Double = 0
        Dim parte_vs As String = ""
        Dim rollo_vs As String = ""




        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * FROM Consumos  where   Fecha_consumo between  '" + CStr(inicio_m) + "'    and  '" + CStr(fin_m) + "'  order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

parte_vs = reader2.Item(6)
rollo_vs = reader2.Item(9)



If (parte = parte_vs And rollo = rollo_vs) Then

 If (reader2.Item(7).Equals(DBNull.Value)) Then

suma = suma + 0

Else

suma = suma + CDbl(reader2.Item(7))


End If


End If


            End While

            entry = suma



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg ini corr" + i.ToString())
        End Try



Return entry

    End Function

















 Public Shared Function get_mismorollokgfinal(ByVal rollo, ByVal kgfinales) As Integer
        Dim entry As Double

 If (kgfinales.Equals(System.DBNull.Value)) Then
kgfinales = 0
 End If


'MessageBox.Show("rollo:" + CStr(rollo) + " kgfinales :" + CStr(kgfinales))
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select count( rollo ) from Consumos  where rollo = '" + CStr(rollo) + "' and  kgFinales =" + CStr(kgfinales) + "  and  kgFinales > 0"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()


                If (reader2.Item(0).Equals(System.DBNull.Value)) Then
                entry = 0
                End If

                entry = CInt(reader2.Item(0))

            End While

            Return entry

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("get kgfinales mismo rollo:" + i.ToString())
        End Try


    End Function

















    Public Shared Function insertar_ayuda(ByVal indice, ByVal inicio, ByVal fin, ByVal fecha_programa, ByVal fecha_consumo, ByVal ot, ByVal ci, ByVal maquina_consumo, ByVal empalmador, ByVal parte, ByVal rollo, ByVal kginiciales, ByVal kgfinales, ByVal calidad_flauta, ByVal longitud_m, ByVal ancho_m, ByVal gramaje, ByVal factor, ByVal kgreque, ByVal kgescaneados, ByVal kgqaporta, ByVal kgdespues, ByVal kgfaltantes, ByVal kginicialescorr, ByVal kgfinalescorregido)
'MessageBox.Show("kginiciales :" + CStr(kginiciales) + " kgfinales" + CStr(kgfinales))

        Dim sal As Double
        Dim fecha_val As String = Format(Now, "MM/dd/yyyy  HH:mm:ss")
        Dim fecha_prog As String = Format(fecha_programa, "MM/dd/yyyy HH:mm:ss")
        Dim fecha_consu As String = Format(fecha_consumo, "MM/dd/yyyy HH:mm:ss")




If (kginiciales.Equals(DBNull.Value)) Then

kginiciales = 0

End If



If (kgfinales.Equals(DBNull.Value)) Then

kgfinales = 0

End If


        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs



            Dim cmd2 As New OdbcCommand
            cmd2.Connection = conn2
           conn2.Open()
            cmd2.CommandText = "INSERT INTO muestras_t  VALUES " & _
          "(" + CStr(indice) + ",'" + inicio + "','" + fin + "','" + fecha_val + "','" + fecha_prog + "','" + fecha_consu + "','" + Trim(ot) + "','" + Trim(ci) + "','" + maquina_consumo + "','" + empalmador + "','" + parte + "','" + rollo + "'," + CStr(kginiciales) + "," + CStr(kgfinales) + ",'" + Trim(CStr(calidad_flauta)) + "'," + CStr(longitud_m) + "," + CStr(ancho_m) + "," + CStr(gramaje) + "," + CStr(factor) + "," + CStr(kgreque) + "," + CStr(kgescaneados) + "" & _
           "," + CStr(kgqaporta) + "," + CStr(kgdespues) + "," + CStr(kgfaltantes) + ",null,null,null,null,null,null,null,null,null,null,null,null,null,null,null" & _
           ",null,null,null,null,null,null,null,'" + CStr(kgfinalescorregido) + "','" + CStr(kginicialescorr) + "')"
            cmd2.ExecuteNonQuery()



  'cmd2.CommandText = "INSERT INTO muestras_t  VALUES " & _
         ' "(" + CStr(indice) + ",'" + inicio + "','" + fin + "','" + fecha_programa + "','" + fecha_consumo + "','" + CStr(ot) + "','" + CStr(ci) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte) + "','" + CStr(rollo) + "'," + CDbl(kginiciales) + "," + CDbl(kgfinales) + ",'" + CStr(calidad_flauta) + "'," + CDbl(longitud_m) + "," + CDbl(ancho_m) + "," + CDbl(gramaje) + "," + CDbl(factor) + "," + CDbl(kgreque) + "," + CDbl(kgescaneados) + "," + CDbl(kgqaporta) + "" & _
          ' "," + CDbl(kgdespues) + "," + CDbl(kgfaltantes) + ",null,null,null,null,null,null,null,null,null ,null,null,null,null,null,null,null" & _
          ' ",null,null,null,null,null,null,null,null,null)"
          '  cmd2.ExecuteNonQuery()





            Return sal


            conn2.Close()





        Catch a As Exception
            MessageBox.Show(" Insertar_ayuda " + a.ToString())
        End Try
        Return sal

    End Function

''----------------------------------------PRIMER  CICLO--------------------------------------------------''

    ''// Despliegue  de informacion de consumos + programa respecto a  fechas  definidas
    Public Shared Function carga_resultados(ByVal inicio, ByVal fin) As Boolean

        Dim registros_validar As Integer = 0
        Dim indice As Integer = 0 ''//Indice para cada  registro de  muestra
       ' MessageBox.Show("Mostrando del " + CStr(inicio) + "    al " + CStr(fin))
        '' // Se inicial ciclo de   recorrido para  cada  ingreso de  consumo registrado en orden desc 
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs

             inicio = Format(CDate(inicio), "yyyy-MM-dd  HH:mm:ss")
             fin = Format(CDate(fin), "yyyy-MM-dd  HH:mm:ss")
              '  MessageBox.Show("Nuevo: " + CStr(inicio) + "    al " + CStr(fin))

            Dim mystring2 As String = "	select * FROM Consumos LEFT OUTER JOIN programado ON ( Consumos.CRowID_fecha_programa like Programado.fecha_hora_programada  and Consumos.no_ci = Programado.ci_instruccioncorrugadora    ) where   Fecha_consumo between  '" + CStr(inicio) + "'    and  '" + CStr(fin) + "'     order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()


            ''// Inicio de   lectura  de registros  
            While reader2.Read()


                Dim CRowID_fecha_programa = (reader2.Item(0))
                Dim Fecha_consumo = (reader2.Item(1))
                Dim no_pedido_ot = (reader2.Item(2))
                Dim no_ci = (reader2.Item(3))
'MessageBox.Show("cI" + CStr(no_ci))
                Dim id_maquina_consumo = (reader2.Item(4))


                Dim empalmador = reader2.Item(5)
'MessageBox.Show("Empalamador completo:" + CStr(empalmador))
                empalmador = CStr(empalmador).Substring(0, 2)
'MessageBox.Show("Empalamador uni:" + CStr(empalmador))
                Dim parte_rollo = (reader2.Item(6))
                Dim kginiciales = (reader2.Item(7))
                Dim KgFinales = (reader2.Item(8))
                Dim Rollo = (reader2.Item(9))
'MessageBox.Show("rollo :" + CStr(Rollo) + " ci " + CStr(no_ci) + "  Empalamador uni:" + CStr(empalmador))

                Dim cv3 = (reader2.Item(10))
                Dim cv4 = (reader2.Item(11))
                Dim cv5 = (reader2.Item(12))
                Dim cv1 = (reader2.Item(13))
                Dim cv2 = (reader2.Item(14))
                Dim ci_instruccioncorrugadora = (reader2.Item(16))
                Dim calidad = (reader2.Item(17))
                Dim flauta = (reader2.Item(18))
                Dim longitud_pedido_mm = (reader2.Item(19))
                Dim ancho_pedido_mm = (reader2.Item(20))
                Dim no_pedido_ot_p = (reader2.Item(21))
                Dim id_maquina_prod = (reader2.Item(22))
                Dim fecha_hora_programada = (reader2.Item(23))
                Dim pv1 = (reader2.Item(24))
                Dim pv2 = (reader2.Item(25))
                Dim pv3 = (reader2.Item(26))
                Dim pv4 = (reader2.Item(27))
                Dim pv5 = (reader2.Item(28))


If (flauta.Equals(DBNull.Value)) Then
'MessageBox.Show("ok:" + CStr(CRowID_fecha_programa))
flauta = calidad.Substring(calidad.Length - 2, 2)
End If


'MessageBox.Show("Flauta:" + CStr(flauta))

                Dim factor = set_factor(empalmador, flauta)



                Dim gramaje = get_gramaje(parte_rollo)

                ''// convertimos a  milimetros y miligramos estandar gramaje y ancho para calculos
                Dim ancho As Double = CInt(ancho_pedido_mm) * 0.001
                Dim grama As Double = CInt(gramaje) * 0.001



'MessageBox.Show("1")




                ''-----------------------------------calculo de  kg Kg Teoricos por CI y Empalmador
  'MessageBox.Show(" ancho m :" + CStr(ancho) + " Largo m " + CStr(longitud_pedido_mm) + " gramaje: " + CStr(grama) + " factor: " + CStr(factor))

Dim kgreque As Double = ancho * CInt(longitud_pedido_mm) * factor * grama


           ' MessageBox.Show("reque: " + CStr(kgreque))



'MessageBox.Show("2")

                ''----------------------------------- calculando entradas  y salidas   para  Kg escaneados o  kg de  consumo bruto


                ''// Mismo rollo mismos  kginiciales y finales
                    Dim v_mismorollo_kginiciales = get_mismorollokgini(Rollo, kginiciales)
                    Dim v_mismorollo_kgfinales = get_mismorollokgfinal(Rollo, KgFinales)
'MessageBox.Show("3")

''//kginiciales corregido y finales corr

'MessageBox.Show("1")

Dim kginicialescorregido As Double = get_kginicorr(Rollo, kginiciales, parte_rollo, Format(CDate(Fecha_consumo), "yyyy-MM-dd  HH:mm:ss"), inicio, fin)


'MessageBox.Show("ok")

Dim kgfinalescorregido = get_kgfinalcorr(Rollo, KgFinales, parte_rollo, Format(CDate(Fecha_consumo), "yyyy-MM-dd  HH:mm:ss"), inicio, fin)

'MessageBox.Show("2")
''// BJ Consecutivo aparicion parte-Lote

Dim conse_aparicion = get_consec_aparicion(parte_rollo, Rollo, inicio, fin)

''// BK Correccion kg  negativos  por  cambio

Dim cor_kgnegativos = 0

If (conse_aparicion = 0 And kgfinalescorregido > 0) Then

cor_kgnegativos = 0

Else

cor_kgnegativos = 1


End If





''// kg escaneados  o consumo bruto AE

                ''//Calculo obsoleto
                Dim entrada As Double = get_entrada(CStr(Rollo))
                Dim salidas As Double = get_salida(CStr(Rollo))
               ' Dim kgscan As Double = entrada - salidas

''// Nuevo calculo
Dim kgscan As Double
If (kginicialescorregido < 0) Then

kgscan = 0

Else

kgscan = (kginicialescorregido - kgfinalescorregido) * cor_kgnegativos

End If







''/// Trashhhhh***********************************************************
                ''------------------------------------calculo kg aporta
                Dim kgaporta As Double
                If (kgreque <= kgscan) Then
                    kgaporta = kgreque
                Else
                    kgaporta = kgscan
                End If

                ''------------------------------------ calculo kg despues  de  escaneo 
                Dim kgdespues As Double = kgscan - kgaporta

                ''------------------------------------ calculo kg  faltantes ci
                Dim kgfalta As Double = kgreque - kgaporta
''/// Trashhhh_________________________________________________________________________



                registros_validar = registros_validar + 1
                'Grabando resultados  primera  corrida 

                'MessageBox.Show("***CI: " + CStr(reader2.Item("Key1")) + "**Rollo: " + CStr(rolli) + "***Ancho m : " + CStr(ancho) + "Largo m: " + CStr(reader2.Item("Key4")) + "***Empalmador m: " + CStr(reader2.Item("Character05")) + "***Flauta: " + CStr(reader2.Item("Key3")) + "***FACTOR: " + CStr(factor) + "*****parte: " + CStr(parte) + "***gramaje kg/m: " + CStr(grama) + "***Kg requeridos: " + CStr(kgreque) + "***entrada: " + CStr(entrada) + "***salida: " + CStr(salidas) + "***kg escaneados: " + CStr(kgscan) + "***kg aporta: " + CStr(kgaporta) + "***kg  despues : " + CStr(kgdespues) + "***kgfalta: " + CStr(kgfalta))
                ''// Registro Unico 
                indice = indice + 1




                ''// insercion de  registro en muestra_t con primeros  datos

                insertar_ayuda(indice, inicio, fin, CRowID_fecha_programa, Fecha_consumo, no_pedido_ot, no_ci, id_maquina_consumo, empalmador, parte_rollo, Rollo, kginiciales, KgFinales, calidad, longitud_pedido_mm, ancho, grama, factor, kgreque, kgscan, kgaporta, kgdespues, kgfalta, kginicialescorregido, kgfinalescorregido)

      'MessageBox.Show("Insertado indice" + CStr(indice) + " en  muestras t")          ''// Insercion de  registro en resumen_t , extencion de  muestras  t datos de  resumen
                 resumen_metods.integra_resumen(indice, no_ci, empalmador, Rollo, Fecha_consumo, conse_aparicion, cor_kgnegativos)

'MessageBox.Show("Insertado indice" + CStr(indice) + " en  resumen t")




            End While ''// Fin de   ciclo de registros de consumo y actualizacion primeras  variables 
'MessageBox.Show("Fin de  cliclo 1  calculos  e integracion de  resumen (resumen 1)")

            reader2.Close()
            conn2.Close()
        Catch i As Exception
            MessageBox.Show("carga resultados :  " + i.ToString())
        End Try ''// Fin de repaso de  ingresos de  consumo 


    End Function















 Public Shared Function carga_programa_semaforo(ByVal inicio, ByVal fin) As Boolean

        Dim registros_validar As Integer = 0
        Dim indice As Integer = 0 ''//Indice para cada  registro de  muestra
       ' MessageBox.Show("Mostrando del " + CStr(inicio) + "    al " + CStr(fin))
        '' // Se inicial ciclo de   recorrido para  cada  ingreso de  consumo registrado en orden desc 
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs

             inicio = Format(CDate(inicio), "yyyy-MM-dd  HH:mm:ss")
             fin = Format(CDate(fin), "yyyy-MM-dd  HH:mm:ss")
              '  MessageBox.Show("Nuevo: " + CStr(inicio) + "    al " + CStr(fin))

            Dim mystring2 As String = "	select * FROM Consumos LEFT OUTER JOIN programado ON ( Consumos.CRowID_fecha_programa like Programado.fecha_hora_programada) where   Fecha_consumo between  '" + CStr(inicio) + "'    and  '" + CStr(fin) + "'     order by Fecha_consumo asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()


            ''// Inicio de   lectura  de registros  
            While reader2.Read()


                Dim CRowID_fecha_programa = (reader2.Item(0))
                Dim Fecha_consumo = (reader2.Item(1))
                Dim no_pedido_ot = (reader2.Item(2))
                Dim no_ci = (reader2.Item(3))
                Dim id_maquina_consumo = (reader2.Item(4))
                Dim empalmador = (reader2.Item(5))
                Dim parte_rollo = (reader2.Item(6))
                Dim kginiciales = (reader2.Item(7))
                Dim KgFinales = (reader2.Item(8))
                Dim Rollo = (reader2.Item(9))
                Dim cv3 = (reader2.Item(10))
                Dim cv4 = (reader2.Item(11))
                Dim cv5 = (reader2.Item(12))
                Dim cv1 = (reader2.Item(13))
                Dim cv2 = (reader2.Item(14))
                Dim ci_instruccioncorrugadora = (reader2.Item(15))
                Dim calidad = (reader2.Item(16))
                Dim flauta = (reader2.Item(17))
                Dim longitud_pedido_mm = (reader2.Item(18))
                Dim ancho_pedido_mm = (reader2.Item(19))
                Dim no_pedido_ot_p = (reader2.Item(20))
                Dim id_maquina_prod = (reader2.Item(21))
                Dim fecha_hora_programada = (reader2.Item(22))
                Dim pv1 = (reader2.Item(23))
                Dim pv2 = (reader2.Item(24))
                Dim pv3 = (reader2.Item(25))
                Dim pv4 = (reader2.Item(26))
                Dim pv5 = (reader2.Item(27))


                Dim factor = set_factor(empalmador, flauta)



                Dim gramaje = get_gramaje(parte_rollo)

                ''// convertimos a  milimetros y miligramos estandar gramaje y ancho para calculos
                Dim ancho As Double = CInt(ancho_pedido_mm) * 0.001
                Dim grama As Double = CInt(gramaje) * 0.001








                ''-----------------------------------calculo de  kg Kg Teoricos por CI y Empalmador
                Dim kgreque As Double = ancho * CInt(longitud_pedido_mm) * factor * grama
               ' MessageBox.Show(" ancho m :" + CStr(ancho) + " Largo m " + CStr(longitud_pedido_mm) + " gramaje: " + CStr(grama) + " factor: " + CStr(factor))


           ' MessageBox.Show("reque: " + CStr(kgreque))





                ''----------------------------------- calculando entradas  y salidas   para  Kg escaneados o  kg de  consumo bruto


                ''// Mismo rollo mismos  kginiciales y finales
                    Dim v_mismorollo_kginiciales = get_mismorollokgini(Rollo, kginiciales)
                    Dim v_mismorollo_kgfinales = get_mismorollokgfinal(Rollo, KgFinales)


''//kginiciales corregido y finales corr

'MessageBox.Show("1")

Dim kginicialescorregido As Double = get_kginicorr(Rollo, kginiciales, parte_rollo, Format(CDate(Fecha_consumo), "yyyy-MM-dd  HH:mm:ss"), inicio, fin)


'MessageBox.Show("ok")

Dim kgfinalescorregido = get_kgfinalcorr(Rollo, KgFinales, parte_rollo, Format(CDate(Fecha_consumo), "yyyy-MM-dd  HH:mm:ss"), inicio, fin)

'MessageBox.Show("2")
''// BJ Consecutivo aparicion parte-Lote

Dim conse_aparicion = get_consec_aparicion(parte_rollo, Rollo, inicio, fin)

''// BK Correccion kg  negativos  por  cambio

Dim cor_kgnegativos = 0

If (conse_aparicion = 0 And kgfinalescorregido > 0) Then

cor_kgnegativos = 0

Else

cor_kgnegativos = 1


End If





''// kg escaneados  o consumo bruto AE

                ''//Calculo obsoleto
                Dim entrada As Double = get_entrada(CStr(Rollo))
                Dim salidas As Double = get_salida(CStr(Rollo))
               ' Dim kgscan As Double = entrada - salidas

''// Nuevo calculo
Dim kgscan As Double
If (kginicialescorregido < 0) Then

kgscan = 0

Else

kgscan = (kginicialescorregido - kgfinalescorregido) * cor_kgnegativos

End If







''/// Trashhhhh***********************************************************
                ''------------------------------------calculo kg aporta
                Dim kgaporta As Double
                If (kgreque <= kgscan) Then
                    kgaporta = kgreque
                Else
                    kgaporta = kgscan
                End If

                ''------------------------------------ calculo kg despues  de  escaneo 
                Dim kgdespues As Double = kgscan - kgaporta

                ''------------------------------------ calculo kg  faltantes ci
                Dim kgfalta As Double = kgreque - kgaporta
''/// Trashhhh_________________________________________________________________________



                registros_validar = registros_validar + 1
                'Grabando resultados  primera  corrida 

                'MessageBox.Show("***CI: " + CStr(reader2.Item("Key1")) + "**Rollo: " + CStr(rolli) + "***Ancho m : " + CStr(ancho) + "Largo m: " + CStr(reader2.Item("Key4")) + "***Empalmador m: " + CStr(reader2.Item("Character05")) + "***Flauta: " + CStr(reader2.Item("Key3")) + "***FACTOR: " + CStr(factor) + "*****parte: " + CStr(parte) + "***gramaje kg/m: " + CStr(grama) + "***Kg requeridos: " + CStr(kgreque) + "***entrada: " + CStr(entrada) + "***salida: " + CStr(salidas) + "***kg escaneados: " + CStr(kgscan) + "***kg aporta: " + CStr(kgaporta) + "***kg  despues : " + CStr(kgdespues) + "***kgfalta: " + CStr(kgfalta))
                ''// Registro Unico 
                indice = indice + 1




                ''// insercion de  registro en muestra_t con primeros  datos
MessageBox.Show("Insertado indice" + CStr(indice) + " en  muestras t")
                insertar_ayuda(indice, inicio, fin, CRowID_fecha_programa, Fecha_consumo, no_pedido_ot, no_ci, id_maquina_consumo, empalmador, parte_rollo, Rollo, kginiciales, KgFinales, calidad, longitud_pedido_mm, ancho, grama, factor, kgreque, kgscan, kgaporta, kgdespues, kgfalta, kginicialescorregido, kgfinalescorregido)
MessageBox.Show("Insertado indice" + CStr(indice) + " en  resumen t")
                ''// Insercion de  registro en resumen_t , extencion de  muestras  t datos de  resumen
                 resumen_metods.integra_resumen(indice, no_ci, empalmador, Rollo, Fecha_consumo, conse_aparicion, cor_kgnegativos)






            End While ''// Fin de   ciclo de registros de consumo y actualizacion primeras  variables 
MessageBox.Show("Fin de  cliclo 1  calculos  e integracion de  resumen (resumen 1)")

            reader2.Close()
            conn2.Close()
        Catch i As Exception
            MessageBox.Show("carga resultados :  " + i.ToString())
        End Try ''// Fin de repaso de  ingresos de  consumo 


    End Function

















    Public Shared Function get_kgdisponiblerollo(ByVal parte, ByVal rollo) As Double
'MessageBox.Show("1")
 Dim sal As Double
'MessageBox.Show("2")
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
'MessageBox.Show("3")
            Dim mystring2 As String = "select  sum(kgescaneados) as salida  from muestras_t where   rollo = '" + CStr(rollo) + "'" + " and " + "parte = '" + CStr(parte) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
'MessageBox.Show("4")
            Dim conta As Integer = 0



'''''

          

'''''''

While reader2.Read()



'MessageBox.Show("5")
 If reader2.Item("salida").Equals(DBNull.Value) Then
'MessageBox.Show("si")
            sal = 0.0
Else
sal = CInt(reader2.Item("salida"))
'MessageBox.Show("no")
                   End If






            End While

            Return sal

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg disponiblerollo : " + i.ToString())
        End Try


    End Function


    '''''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function update_kgdisponiblerollo(ByVal parte As String, ByVal rollo As String, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE muestras_t  SET Kgconsumodisponiblelote =  " + CStr(val) + "    WHERE  rollo = '" + CStr(rollo) + "' AND parte = '" + CStr(parte) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" update kgdisponiblerollo " + i.ToString())
        End Try
        Return 0

    End Function




    Public Shared Function get_rollosxci(ByVal ci, ByVal empa) As Integer
        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = " Select count(rollo) as salida , CI  from muestras_t where CI ='" + CStr(ci) + "' and empalmador ='" + CStr(empa) + "'  group by CI"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                sal = CInt(reader2.Item("salida"))
            End While

            Return sal

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("get rollos x ci " + i.ToString())
        End Try


    End Function



    '''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function set_rollosxci(ByVal ci, ByVal empa, ByVal val)
        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET RollosxCI =  " + CStr(val) + "    WHERE  CI = '" + CStr(ci) + "' and  empalmador = '" + CStr(empa) + "'"

            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("set rollos x ci " + i.ToString())
        End Try
        Return sal

    End Function




    Public Shared Function get_consumosmismorollo(ByVal rollo) As Integer
        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "  Select count(rollo) as salida , rollo  from muestras_t  where rollo = '" + CStr(rollo) + "' group by rollo"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


                sal = CInt(reader2.Item("salida"))

            End While

            Return sal

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("consumos  mismo rollo " + i.ToString())
        End Try


    End Function




    '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function update_nconsumosrollo(ByVal parte, ByVal rollo, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET consumosmismorollo =  " + CStr(val) + "    WHERE  rollo = '" + CStr(rollo) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("update n consumos  rollo " + i.ToString())
        End Try
        Return 0

    End Function





    Public Shared Function get_cisep(ByVal parte, ByVal rollo, ByVal sei) As Integer
        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = " Select  * from muestras_t where  CI= '" + CStr(sei) + "' and rollo='" + CStr(rollo) + "' and parte='" + CStr(parte) + "' "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                conta = conta + 1

            End While

            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("get _ cisep " + i.ToString())
        End Try
        Return sal

    End Function

    Public Shared Function update_proporcionci(ByVal parte As String, ByVal rollo As String, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET proporcionci =  " + CStr(val) + "    WHERE  rollo = '" + CStr(rollo) + "' AND parte = '" + CStr(parte) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("proporcion ci " + i.ToString())
        End Try

        Return 0
    End Function



    Public Shared Function carga_resultados_second()

        ''// Actualizar segunda  fase de ciclo  de calculos teoricos en base  a  registros primer calculo

        Try
            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_t"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0


            '' // Comienzan registros base  para calculos 
            While reader2.Read()

                Dim cbruto = reader2.Item(20)
                Dim rollo13 = reader2.Item(11)
                Dim parte13 = reader2.Item(10)
                Dim cis = reader2.Item(7)
 Dim empalma = reader2.Item(9)


                'messagebox.show("rollo :" + cstr(rollo13) + " parte= "+ cstr(parte13))
                ''------------------------------------------------------------------------calculo columna  AF 
                Dim kgdisponiblerollo As Double = get_kgdisponiblerollo(parte13, rollo13)
                'messagebox.show("Kg disponible  rollo :" + cstr(rollo13) + " = "+ cstr(kgdisponiblerollo))
                update_kgdisponiblerollo(parte13, rollo13, kgdisponiblerollo)

                ''--------------------------------------------------------------------------------------------------


                ''calculo rollos  x ci  ag
                Dim rollosxci As Integer = get_rollosxci(cis, empalma)
                'messagebox.show(" rollos de c1 :" + cstr(rollosxci) + "ci:" + cis)
                set_rollosxci(cis, empalma, rollosxci)

                ''--------------------------------------------------------------------------------------------
                'messagebox.show("rollo en juego :" + rollo13)

                Dim consumosmismorollo As Integer = get_consumosmismorollo(rollo13)

                'messagebox.show(" consumos  mismo rollo  : " + cstr(consumosmismorollo) + "  rollo :" +rollo13)
                update_nconsumosrollo(parte13, rollo13, consumosmismorollo)


                ''------------------------------------------------------------------------------------------------


                '' calculo proporcion CI AU
                Dim cisep2 As Integer = get_cisep(parte13, rollo13, cis)
                'MessageBox.Show("AU proporcion  ci    : " + CStr(cis) + "parte :" + CStr(parte13) + "rollo :" + CStr(rollo13))
              ' MessageBox.Show(" ci separando   : " + CStr(cisep2))


                Dim proporcion As Integer = 1 / cisep2
               ' MessageBox.Show(" proporcion ci consumos    : " + CStr(proporcion))
                update_proporcionci(parte13, rollo13, proporcion)



            End While ''// Fin registros  base  calculos  fase 1
        Catch e As Exception

 MessageBox.Show("Calculos 2 :" + e.ToString)
        End Try

      '  MessageBox.Show("Ok. Oprima Actualizar 2 ")

        Return 0

    End Function




    Public Shared Function get_cisconsumopararollo(ByVal parte, ByVal rollo) As Double
        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select  sum(proporcionci) as salida  from muestras_t where  rollo = '" + CStr(rollo) + "'" + " and " + "parte = '" + CStr(parte) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                sal = CDbl(reader2.Item("salida"))
            End While

            Return sal

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("cis consumos  para rollo" + i.ToString())
        End Try


    End Function



    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function update_nconsumospararollo(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET CICONSUMOSXROLLO =  " + CStr(val) + "    WHERE MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("CONSUMOS  PARA ROLLO " + i.ToString())
        End Try
        Return 0

    End Function



    '''''''''''''''''''''''''''''''''''''''''''''''''''''



    Public Shared Function get_ciconsumoacumuladorollo(ByVal indice, ByVal parte, ByVal rollo) As Integer
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_t where MrowID <= " + CStr(indice)
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            Dim suma_ss1 As Double = 0
            Dim total1 As Double = 0
            Dim total2 As Double = 0

            ''// Se hace la comparativa  contra  el registro actual
            While reader2.Read()


                Dim rl_parte As String = CStr(reader2.Item(10))
                Dim rl_rollo As String = CStr(reader2.Item(11))
                Dim rl_indice As Integer = CInt(reader2.Item(0))

                Dim rl_propci As Double = CDbl(reader2.Item(37))


                If (rl_parte = parte) Then

                    If (rl_rollo = rollo) Then


                        total1 = total1 + rl_propci



                    End If
                End If


            End While

            Return total1



        Catch ex As Exception
            MsgBox("ci consumo acumulado para rollo" & vbCrLf & ex.Message)

        End Try



    End Function




    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function update_nconsumosacupararollo(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET cisacumulado=  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("upd n consumos  p rollo acum " + i.ToString())
        End Try

        Return 0
    End Function



    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    Public Shared Function get_kgconsumoyaasignado(ByVal indice, ByVal parte, ByVal rollo, ByVal ci) As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_t where MrowID < " + CStr(indice)
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            Dim suma_ss1 As Double = 0
            Dim total1 As Double = 0
            Dim total2 As Double = 0
'MessageBox.Show("1")
            ''// Se hace la comparativa  contra  el registro actual
            While reader2.Read()


                Dim rl_parte As String = CStr(reader2.Item(10))
                Dim rl_rollo As String = CStr(reader2.Item(11))
                Dim rl_ci As String = CStr(reader2.Item(7))
                Dim rl_indice As Integer = CInt(reader2.Item(0))
'MessageBox.Show("1.1")
                Dim kgrepci = reader2.Item(36)
                Dim rl_kgreqci As Double

'MessageBox.Show("1.2")

'MessageBox.Show("datos  recogidos :   parte " + CStr(rl_parte) + " rollo :" + CStr(rollo) + " CI:" + CStr(rl_ci) + " INdice:" + CStr(rl_indice))

                If (kgrepci.Equals(" ")) Then

                    rl_kgreqci = 0

                Else
                    If (kgrepci.Equals(DBNull.Value)) Then

                    rl_kgreqci = 0
                    Else
                    rl_kgreqci = CDbl(kgrepci)
                    End If

                End If
'MessageBox.Show("Val AS :" + CStr(rl_kgreqci))
                'messagebox.show("Datos  leidos :" +  cstr(rl_parte)+ " "+ cstr(rl_rollo)+ " " + cstr(rl_ci)+" "+ cstr(rl_indice) )

                If (rl_parte = parte) Then
                    'messagebox.show("misma parte t1")
                    If (rl_rollo = rollo) Then
                        'messagebox.show("misma rollo t1")


                        'messagebox.show("total 2 antes:" + cstr(total2))
                        'messagebox.show("kgreqci (as) de registro leido:" + cstr(rl_kgreqci))
                        total1 = total1 + rl_kgreqci

                        'messagebox.show("total 2 ahora:" + cstr(total2))

                    End If
                End If
'MessageBox.Show("1.4")
                'messagebox.show("7")
                ''//////////////////////////////
                If (rl_parte = parte) Then
                    'messagebox.show("misma parte t2")

                    If (rl_rollo = rollo) Then
                        'messagebox.show("misma rollo t2")

                        If (rl_ci = ci) Then

                            'messagebox.show("misma ci t1")

                            'messagebox.show("total 2 antes:" + cstr(total2))
                            'messagebox.show("kgreqci (as) de registro leido:" + cstr(rl_kgreqci))
                            total2 = total2 + rl_kgreqci
                            'messagebox.show("total 2 ahora:" + cstr(total2))
                        End If

                    End If
                End If

'MessageBox.Show("1.5")

                conta = conta + 1

            End While

           ' MessageBox.Show("Registros leidos  antes de  este indice:" + CStr(conta))
'MessageBox.Show("C1:" + CStr(total1) + "  c2 :" + CStr(total2))
            Dim neto As Double = total1 - total2
           ' MessageBox.Show("AH kgyaasign salida:" + CStr(neto))

            Return neto



        Catch ex As Exception
            MsgBox("consumo ya  asignado" & vbCrLf & ex.Message)

        End Try







    End Function




    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function update_consumoya(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgconsumoasignado =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" upd consumo ya " + i.ToString())
        End Try

        Return 0
    End Function


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Shared Function update_kgdisponibleporrolloacum(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgdisponiblerollo =  " + CStr(val) + "    WHERE  MrowID = " + CStr(indice)
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons disponible  x  rollo acum " + i.ToString())
        End Try
        Return 0

    End Function



    Public Shared Function update_kgreqci1rollo(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgreqci1rollo =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("upd kgreqci1rollo " + i.ToString())
        End Try
        Return 0

    End Function




    Public Shared Function update_kgconsumodsip2(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE muestras_t SET kgconsdisponible =  " + CStr(val) + "    WHERE   MrowID = " + CStr(indice)
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kg cons disponible 2 " + i.ToString())
        End Try
        Return 0

    End Function




    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function update_kgreqrolloini(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgreqrolloinicial =  " + CStr(val) + "    WHERE  MrowID = " + CStr(indice)
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kgreq  rollo inic " + i.ToString())
        End Try

        Return 0
    End Function




    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




    ''''''''''''''''''''''''''''''''''''''''''''''''''''





    Public Shared Function get_ss1_factor(ByVal indice_reg, ByVal ci_reg, ByVal emp_reg) As Double

        '' obteniendo matriz  de registros  anteriores
'MessageBox.Show(" comenzando ss1 ")
        Dim i As Integer = indice_reg

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_t where MrowID < " + CStr(i) + ""
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            Dim suma_ss1 As Double = 0

            While reader2.Read()

                Dim emp_mat As String = CStr(reader2.Item(9))
                Dim ci_mat As String = CStr(reader2.Item(7))
                Dim kgreq1ci_mat = reader2.Item(36)


                If (emp_mat = emp_reg) Then
                    'messagebox.show(" empalmador  igual " )
                    If (ci_mat = ci_reg) Then
                        'messagebox.show(" ci igual" )

                        'messagebox.show(" acumulado SS1:" + cstr(suma_ss1) + " mas  kgreq1ci: "+ cstr(kgreq1ci_mat))
                        suma_ss1 = suma_ss1 + CDbl(kgreq1ci_mat)
                        'messagebox.show(" despues :" + cstr(suma_ss1))
                    Else

                        'messagebox.show(" ci no   igual " )

                    End If

                Else

                    'messagebox.show(" empalmador  no igual " )

                End If


                conta = conta + 1

            End While
           ' MessageBox.Show(" registros  antes ss1: " + CStr(conta))
           ' MessageBox.Show(" suma_ss1: " + CStr(suma_ss1))
            Return suma_ss1



        Catch ex As Exception
            MsgBox("get ss1 factor" & vbCrLf & ex.Message)

        End Try




    End Function



    Public Shared Function update_kgconsdisrollo(ByVal indice, ByVal val)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgdispxrollo2 =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
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





    Public Shared Function get_ss2_factor(ByVal indice_reg, ByVal ci_reg, ByVal emp_reg, ByVal parte_reg, ByVal rollo_reg) As Double




        '' obteniendo matriz  de registros  anteriores

        Dim i As Integer = indice_reg - 1

        Try
            'messagebox.show(" 1:"  )
            Dim conn2 As OdbcConnection = New OdbcConnection()
            'messagebox.show(" 2:"  )
            conn2.ConnectionString = cs
            'messagebox.show(" 3:"  )
            Dim mystring2 As String = "select * from muestras_t where MrowID < " + CStr(i) + ""
            'messagebox.show(" 4:"  )
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            'messagebox.show(" 5:"  )
            'messagebox.show(" 6:"  )
            conn2.Open()
            'messagebox.show(" 7:"  )
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            'messagebox.show(" 8:"  )
            Dim conta As Integer = 0
            'messagebox.show(" 9:"  )
            Dim suma_ss1 As Double = 0

            While reader2.Read()

                Dim emp_mat As String = CStr(reader2.Item(8))
                Dim ci_mat As String = CStr(reader2.Item(6))
                Dim kgreq1ci_mat = reader2.Item(36)
                Dim parte_mat As String = CStr(reader2.Item(9))
                Dim rollo_mat As String = CStr(reader2.Item(10))

                If (emp_mat.Equals(emp_reg)) Then

                    If (ci_mat.Equals(ci_reg)) Then

                        suma_ss1 = suma_ss1 + kgreq1ci_mat

                    End If


                End If




            End While
            Return suma_ss1
            'messagebox.show(" 4:"  )


        Catch ex As Exception
            MsgBox(" get ss2 factor" & vbCrLf & ex.Message)

        End Try




    End Function



    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Shared Function update_kgfaltantesci(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgfaltantesci =  " + CStr(val) + "    WHERE MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("kgfaltantesci " + i.ToString())
        End Try

        Return 0
    End Function





    ''kg re disp x rollo----999999999999999999999999999999999999999999999999999999999999999'''''''''''''''''''''''''''''''
    Public Shared Function update_kgreqdispxrollo(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgrequeydispxrollo =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("updt kreqdispxrollo " + i.ToString())
        End Try

        Return 0
    End Function



    ''kg consumo disponible 4 --99999999999999999999999999999999999999999999999999999999999999999999999''''''''''''''
    Public Shared Function update_kgconsumodisponible4(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgconsumodisponible3 =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("k " + i.ToString())
        End Try
        Return 0

    End Function


    Public Shared Function update_kgconsumofaltaci4(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgfaltantesCI2 =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("upd kgconsumofalta ci4" + i.ToString())
        End Try
        Return 0

    End Function




    ''kgconsumo x ci 4--99999999999999999999999999999999999999999999999999999999999999999999999''''''''''''''''''''''''
    Public Shared Function update_kgconsumoxci4(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgconsumoci4 =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("updt  kgconsumoxci4" + i.ToString())
        End Try
        Return 0

    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''


    Public Shared Function carga_resultados_third()

        ''// Calculos  fase  3  

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_t"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0

            While reader2.Read()

                Dim cbruto = reader2.Item(20)
                Dim rollo13 = reader2.Item(11)
                Dim parte13 = reader2.Item(10)

                Dim a_kgconsumodisponiblexrollo = reader2.Item(23)
                Dim a_req = reader2.Item(19)
                Dim a_rxci = reader2.Item(24)
                Dim a_fac = reader2.Item(0)

                Dim a_ci = reader2.Item(7)
                Dim mismo2 = reader2.Item(29)
                Dim a_emp = reader2.Item(9)
                Dim ax_req = reader2.Item(19)


   'kgreqci1rollo + kgrequerolloinicial + kgreqydispxrollo

'MessageBox.Show("1.4")


                ''---------------------------------------------// calculando CI consumo para rollo AV
                Dim ciconsumopararollo As Double = get_cisconsumopararollo(parte13, rollo13)
'MessageBox.Show("1.5")
                update_nconsumospararollo(a_fac, ciconsumopararollo)
                'MessageBox.Show("ci consumo para rollo :" + CStr(ciconsumopararollo))




                ''//------------------------------------------ci consumo acumulado para rollo AW
                'MessageBox.Show(" entradas AW para  indice:" + CStr(a_fac) + " parte:" + CStr(parte13) + " rollo:" + CStr(rollo13))
                Dim ciconsumoacumuladopararollo As Double = get_ciconsumoacumuladorollo(a_fac, parte13, rollo13)

               ' MessageBox.Show("consumo acumulado para  rollo :" + CStr(ciconsumoacumuladopararollo))

                update_nconsumosacupararollo(a_fac, ciconsumoacumuladopararollo)



'MessageBox.Show("AH celda    entradas :" + " indice " + CStr(a_fac) + "  parte:" + CStr(parte13) + " rollo :" + CStr(rollo13) + "  CI: " + CStr(a_ci))

                ''// kg  ya asignados de ci x rollo ah

                'MessageBox.Show("Datos enviados :  " + CStr(a_fac) + " " + CStr(parte13) + " " + CStr(rollo13) + " " + CStr(a_ci))
                Dim kgdeconsumoasignadoantesCI As Double = get_kgconsumoyaasignado(a_fac, parte13, rollo13, a_ci)
                update_consumoya(a_fac, kgdeconsumoasignadoantesCI)
               ' MessageBox.Show("kg de consumo asignado antes de CI :" + CStr(kgdeconsumoasignadoantesCI))

'MessageBox.Show("1.7")


                ''//kg de consumo disponible  por rollo acumulado ai
                Dim kgconsumodisponiblexrolloacumulado As Double = a_kgconsumodisponiblexrollo - kgdeconsumoasignadoantesCI
               ' MessageBox.Show("disponible rollo : " + CStr(a_kgconsumodisponiblexrollo) + " consumo asignado:" + CStr(kgdeconsumoasignadoantesCI))
               ' MessageBox.Show("kg de consumo disponible  x rollo acumulado :" + CStr(kgconsumodisponiblexrolloacumulado))
'MessageBox.Show("1.8")
   update_kgdisponibleporrolloacum(a_fac, kgconsumodisponiblexrolloacumulado)

'MessageBox.Show("1.8.1")
                ''// kg  requeridos ci 1 rollo  -------------------------------------------AJ
                Dim kgreqci1rollo As Double
'MessageBox.Show("a_rxci" + CStr(a_rxci))
'MessageBox.Show("1.8.2")



                If (a_rxci = 1) Then
            'MessageBox.Show("if 1")
                    If (kgconsumodisponiblexrolloacumulado <= a_req) Then
                       ' MessageBox.Show("if2")
                        kgreqci1rollo = kgconsumodisponiblexrolloacumulado
                    Else
                        kgreqci1rollo = a_req
'MessageBox.Show("else 1")
                    End If
                Else
'MessageBox.Show("else 2")
                    kgreqci1rollo = 0
                End If
'MessageBox.Show("1.8.3")
                'messagebox.show("kg requeridos ci un rollo :" + cstr(kgreqci1rollo ))
                update_kgreqci1rollo(a_fac, kgreqci1rollo)


'MessageBox.Show("1.9")

                ''//----Kg de consumo disponible 2 AK
                Dim kgconsumodisponible2 As Double = a_kgconsumodisponiblexrollo - kgdeconsumoasignadoantesCI - kgreqci1rollo
                'messagebox.show("kg disponibles 2 :" + cstr(kgconsumodisponible2 ))
                update_kgconsumodsip2(a_fac, kgconsumodisponible2)

                'messagebox.show("kg disponibles 2 :" + cstr(kgconsumodisponible2 ))
                ''// kg  requeridos  rollo inicial-------------------------------------------------------am
                Dim kgrequerolloinicial As Double

'MessageBox.Show("2")

                'messagebox.show( "rollos x ci :" + Cstr(reader2.Item("Number10")) + " consumos mismo rollo: "+ cstr(reader2.Item("Number13")))


                If ((CInt(reader2.Item(24)) > 1) And (CInt(reader2.Item(29)) = 1)) Then
                    'messagebox.show("f1 ok")
                    'messagebox.show( "cons disp 2:  :" + Cstr(kgconsumodisponible2) + " kg teoricos : "+ cstr(reader2.Item("Number01")))
                    If (CInt(kgconsumodisponible2) <= CInt(reader2.Item(19))) Then
                        'messagebox.show("f2 ok")	
                        kgrequerolloinicial = CInt(kgconsumodisponible2)
                    Else
                        'messagebox.show("e2 ok")
                        kgrequerolloinicial = CInt(reader2.Item(19))
                    End If
                Else
                    'messagebox.show("e1 ok")
                    kgrequerolloinicial = 0

                End If
                'messagebox.show("kg requeridos  rollo inicial :" + cstr(kgrequerolloinicial))
                update_kgreqrolloini(a_fac, kgrequerolloinicial)

'MessageBox.Show("2.1")
                ''// Kg  consumo disponible  por  rollo 3 -----------------------------------------an
                Dim kgconsumodispxrollo As Double = kgconsumodisponible2 - kgrequerolloinicial
                'messagebox.show("kg consumo dispon x rollo  :" + cstr(kgconsumodispxrollo))
                update_kgconsdisrollo(a_fac, kgconsumodispxrollo)








                ''// kG  FALTANTES CI CALCULO COMPLEJO --------A0
              '  MessageBox.Show(" ci: " + CStr(a_ci) + " emp: " + CStr(a_emp) + " parte13 :" + CStr(parte13) + " rollo" + CStr(rollo13))
                Dim ss1 As Double = get_ss1_factor(a_fac, a_ci, a_emp)


                Dim ss2 As Double = get_ss2_factor(a_fac, a_ci, a_emp, parte13, rollo13)
            'MessageBox.Show("kg teoricos:" + CStr(ax_req) + " kg requeridos Ci con 1 rollo : " + CStr(kgreqci1rollo) + "  kgrequeridos  rollo inicial:" + CStr(kgrequerolloinicial) + " ss1: " + CStr(ss1) + " ss2:" + CStr(ss2))
                Dim kgfaltantesci As Double = ax_req - kgreqci1rollo - kgrequerolloinicial - ss1 - ss2

                'messagebox.show("ss1:" + cstr(ss1) + " ss2: "+ cstr(ss2))

              '  MessageBox.Show(" kg faltantes ci:" + CStr(kgfaltantesci))
                update_kgfaltantesci(a_fac, kgfaltantesci)


                Dim kgreqydispxrollo As Double
                If (kgfaltantesci > 0) Then
                    If (kgfaltantesci <= kgconsumodispxrollo) Then
                        kgreqydispxrollo = kgfaltantesci
                    Else
                        kgreqydispxrollo = kgconsumodispxrollo
                    End If
                Else
                    kgreqydispxrollo = 0

                End If
                'messagebox.show("kg  req  disponibles x rollo 3:" + cstr(kgreqydispxrollo))
                update_kgreqdispxrollo(a_fac, kgreqydispxrollo)


                '' KG DE  CONSUMO DISPONIBLE  4 -------------AQ
                Dim kgconsdisp4 As Double = kgconsumodispxrollo - kgreqydispxrollo
                update_kgconsumodisponible4(a_fac, kgconsdisp4)
                'messagebox.show("kg  consumo disp 4 :" + cstr(kgconsdisp4))




                '' KG DE CONSUMO FALTANTE  CI 4---------------AR
                Dim kgfaltaci4 As Double = kgfaltantesci - kgreqydispxrollo
                update_kgconsumofaltaci4(a_fac, kgfaltaci4)
                'messagebox.show("kg  faltantes  a ci 4 :" + cstr(kgfaltaci4))



                '' KG  DE CONSUMO X CI 4 ---------------------------------------------------AS
                Dim kgconsumoxci4 As Double = kgreqci1rollo + kgrequerolloinicial + kgreqydispxrollo
'MessageBox.Show("KGREQCI1ROLLO:" + CStr(kgreqci1rollo) + " kgreqrolloinici: " + CStr(kgrequerolloinicial) + " kgreqydispxrollo:" + CStr(kgreqydispxrollo))
 'MessageBox.Show("kg  consumo x ci 4 :" + CStr(kgconsumoxci4), " id  row:" + CStr(a_fac))

update_kgconsumoxci4(a_fac, kgconsumoxci4)





            End While ''// fin registros  tercer  ciclo
        Catch i As Exception
            MessageBox.Show("carga resultados  3° " + i.ToString())



        End Try ''// fin tercer ciclo
        'MessageBox.Show("Ok. Oprima Actualizar 3 ")
        Return 0

    End Function





    ''kg consumo despues todas  CI--------9999999999999999999999999999999999999999999999999999999999999999''''''''''''''''''
    Public Shared Function update_kgconsumodespuestodasci(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgconsumofinalci =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("update_kgconsumodespuestodasci " + i.ToString())
        End Try

        Return 0
    End Function




    ''kgconsumo ci 5--99999999999999999999999999999999999999999999999999999999999999999999999'''''''''''''''''
    Public Shared Function update_kgconsumoci5(ByVal indice As Integer, ByVal val As Double)

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "UPDATE  muestras_t SET kgconsumoneto =  " + CStr(val) + "    WHERE  MrowID = '" + CStr(indice) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()


            End While



            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("update_kgconsumoci5" + i.ToString())
        End Try

        Return 0
    End Function







    Public Shared Function clean_dbsema()
        Dim sal As Double
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=Epicor905;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"
            Dim mystring2 As String = "Delete from UD15"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()


            End While

            Return sal

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show("clean_dbsema " + i.ToString())
        End Try
        Return 0

    End Function






    Public Shared Function insertar_dtlsemaforo(ByVal ci, ByVal empa, ByVal cali, ByVal teoricos, ByVal consumo, ByVal dif, ByVal lin)
        'messagebox.show("Ok dtl semaforo")
        Try





        Catch a As Exception
            MessageBox.Show("error insertar dtl semaforo" + a.ToString())
        End Try
        Return 0

    End Function









    Public Shared Function set_semaforo()
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "IF OBJECT_ID ('semaforos', 'V') IS NOT NULL DROP VIEW semaforos GO ; CREATE VIEW semaforos AS select  CI ,Empalmador,AVG(kgrequeridosCIempalmador) as teoricos,SUM(kgconsumoneto) as consumo ,MAX(calidad_flauta) as combinacion , MAX(maquina) as linea   from muestras_t group by ci,empalmador GO ;"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            Dim suma_ss1 As Double = 0
            Dim total1 As Double = 0
            Dim total2 As Double = 0
            clean_dbsema()
            ''// Se hace la comparativa  contra  el registro actual
            While reader2.Read()

               ' Dim rl_ci As String = CStr(reader2.Item("CI"))
               ' Dim rl_empalmador As String = CStr(reader2.Item("empalmador"))
                'dim rl_indice as integer = cint(reader2.Item ("Number15"))
                'DIM rl_ot  as string = Cstr(reader2.Item("Character04"))
                'DIM rl_longitud  as string = Cstr(reader2.Item("Key4"))

                'DIM rl_parte as string = Cstr(reader2.Item("Character06"))
               ' Dim rl_linea As String = CStr(reader2.Item("linea"))
                'Dim rl_calidad As String = CStr(reader2.Item("combinacion"))
                'DIM rl_ancho  as string = Cstr(reader2.Item("Key5"))
                'DIM rl_flauta  as string = Cstr(reader2.Item("Key3"))
                Dim rl_kgteoricos As String = CStr(reader2.Item("teoricos"))
                Dim rl_kgconsumoxci5 As String = CStr(reader2.Item("consumo"))

               ' conta = conta + 1

                'messagebox.show("( rl_kgconsumoxci5 : " +cstr(rl_kgconsumoxci5) + " - rl_kgteoricos : " + cstr(rl_kgteoricos)+ " ) /  ( rl_kgteoricos : " + cstr(rl_kgteoricos) + " * 100 ) "  )
                Dim rl_dif As Double = ((CDbl(rl_kgconsumoxci5) - CDbl(rl_kgteoricos)) / CDbl(rl_kgteoricos)) * 100
                'messagebox.show("ci: "+ cstr(rl_ci)+" empalmador: " + cstr(rl_empalmador)+" calidad:" + cstr(rl_calidad)+ " Teoricos:" + cstr(rl_kgteoricos) + " Consumos: "+ cstr(rl_kgconsumoxci5))
                'messagebox.show("rl_dif  % dif :" + cstr(rl_dif))
               ' insertar_dtlsemaforo(CStr(rl_ci), CStr(rl_empalmador), CStr(rl_calidad), CDbl(rl_kgteoricos), CDbl(rl_kgconsumoxci5), CDbl(rl_dif), CStr(rl_linea))
            End While


            'messagebox.show("Registros:" + cstr(conta) )

        Catch ex As Exception
            MsgBox("error  set-semaforo " & vbCrLf & ex.Message)

        End Try


        Return 0

    End Function









    Public Shared Function carga_resultados_fourth()


        ''// INICIOI DE  4  Y ULTIMO CICLO  CALCULOS  COMPLEJOS
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_t"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0


            ''// INICIO DE  REGISTROS 4  CICLO 
            While reader2.Read()


                'MessageBox.Show(" 1")
                Dim ax_ci = reader2.Item(7)
                Dim cbruto = reader2.Item(20)
                Dim rollo13 = reader2.Item(11)
                Dim parte13 = reader2.Item(10)
                Dim ax_kgconsumodisponiblexrollo = reader2.Item(24)
                Dim ax_req = reader2.Item(19)
                Dim ax_rxci = reader2.Item(25)
                Dim ax_reqc1rollo = reader2.Item(27)
                Dim ax_reqrolloini = reader2.Item(30)
  'MessageBox.Show(" 2")
                Dim ax_emp = reader2.Item(9)
                Dim ax_indice = reader2.Item(0)
                Dim ax_kgdispxrollo = reader2.Item(29)
                Dim ax_nconspr = reader2.Item(38)
                Dim ax_nconsacupr = reader2.Item(39)
                Dim kgconsdisp4 = reader2.Item(34)
                Dim kgreqydispxrollo = reader2.Item(33)

'MessageBox.Show(" 3")


'MessageBox.Show("kgconsumodespuestodasci " + CStr(ax_nconsacupr))
                '' KG  DE CONSUMO DISPONIBLE  POR ROLLO DESPUES  TODAS  CI--------------AX
                Dim kgconsumodespuestodasci As Double

If ax_nconsacupr.Equals(DBNull.Value) Then

ax_nconsacupr = 0

End If



'MessageBox.Show("AV:" + CStr(ax_nconspr) + "  AW:" + CStr(ax_nconsacupr) + " AQ:" + CStr(kgconsdisp4))

                If ((ax_nconspr - ax_nconsacupr) = 0) Then
                    kgconsumodespuestodasci = kgconsdisp4
'MessageBox.Show(" si")
                Else
                    kgconsumodespuestodasci = 0
'MessageBox.Show(" no")
                End If
                update_kgconsumodespuestodasci(ax_indice, kgconsumodespuestodasci)
               ' MessageBox.Show(" Ax kg  consumo depues todas  ci :" + CStr(kgconsumodespuestodasci))

'MessageBox.Show(" 4")
                '' KG CONSUMO X CI 5 ---------------------------------------------------------------AY



               ' MessageBox.Show("factores  AY:     AJ: " + CStr(ax_reqc1rollo) + " am:" + CStr(ax_reqrolloini) + "  ap:" + CStr(kgreqydispxrollo) + " ax:" + CStr(kgconsumodespuestodasci))
                Dim kgconsumoci5 As Double = ax_reqc1rollo + ax_reqrolloini + kgreqydispxrollo + kgconsumodespuestodasci

 'MessageBox.Show("AY kg  consumo ci 5:" + CStr(kgconsumoci5))

update_kgconsumoci5(ax_indice, kgconsumoci5)



            End While ''// FIN CUARTO Y ULTIMO CICLO 



            ''// Exportacion y agrupacion a  semaforos






        Catch ex As Exception
            MsgBox("4 CALCULO" & vbCrLf & ex.Message)

        End Try ''// FIN CUARTO CICLO






        MessageBox.Show("Calculos  completos  ")
        Return 0
    End Function








End Class
