Imports System.Data.Odbc
Imports System.Data
Imports System.Data.SqlClient
Public Class metodos

    Shared coneccionstring = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.15;" + "DataBase=E10Cartomicro;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"
    Shared coneccionstring3 = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"

    Shared coneccionstring2 = "Initial Catalog=IF4;DATA SOURCE=172.16.1.11;Integrated Security=True"
    Public Shared destino_carga = "01_CORR2"
    '' // Validacion de  la maquina leida

    '' Valida maquina  disponible
    Public Shared Function bol_maquina(ByVal maquina) As Integer
        Dim valor As Integer
        If (maquina = "01_CORR2" Or maquina = "01_CORR1" Or maquina = "01_SF1" Or maquina = "01_SF2") Then
            valor = 1
        Else
            valor = 0
        End If
        Return valor
    End Function



    Public Shared Sub set_dest_carga(ByVal value)

        destino_carga = value




    End Sub






    ''valida  maquina  correcta  del programa

    Public Shared Function bol_maquina_programa(ByVal maquina_c, ByVal maquina_prog) As Integer
        Dim valor As Integer
        If (maquina_c = maquina_prog) Then
            valor = 1
        Else
            valor = 0
        End If
        Return valor
    End Function






    ''/// validacion empalmador valido

    Public Shared Function bol_empalmador(ByVal empalmador) As Integer
        Dim valor As Integer
        If (empalmador = "E1D" Or empalmador = "E2D" Or empalmador = "E3D" Or empalmador = "E4D" Or empalmador = "E5D" Or empalmador = "E1I" Or empalmador = "E2I" Or empalmador = "E3I" Or empalmador = "E4I" Or empalmador = "E5I") Then
            valor = 1
        Else
            valor = 0
        End If
        Return valor
    End Function



    ''// validacion de  lote




    Public Shared Function bol_lote(ByVal lotenum, ByVal parte_lote) As Integer
        Dim valor As Integer
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.15;" + "DataBase=E10Cartomicro;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"
            'Dim mystring2 As String = "select * from PartLot where LotNum ='" + CStr(lotenum) + "' and PartNum ='" + CStr(parte_lote) + "' and  OnHand=1"
            Dim mystring2 As String = "select * from PartLot,partbin where PartLot.LotNum ='" + CStr(lotenum) + "' and PartLot.PartNum = '" + CStr(parte_lote) + "' and  PartLot.OnHand=1 and  PartLot.LotNum = PartBin.LotNum and PartBin.WarehouseCode = '300'"

            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
                conta = conta + 1
            End While
            If (conta > 0) Then
                valor = 1
            Else

                valor = 0

            End If
            Return conta

            reader2.Close()
            conn2.Close()

        Catch i As Exception
            MessageBox.Show("ups 2 " + i.ToString())
        End Try


    End Function






    Public Shared Function get_maximo() As Integer
        Dim valor As Integer
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"
            Dim mystring2 As String = " select MAX(n1) from  produccion"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0


            While reader2.Read()
                If (reader2.GetValue(0) Is DBNull.Value) Then

                    conta = 0
                Else

                    conta = reader2.GetValue(0)
                End If




            End While
            If (conta > 0) Then
                valor = 1
            Else

                valor = 0

            End If
            Return conta

            reader2.Close()
            conn2.Close()

        Catch i As Exception
            MessageBox.Show("ups 2 " + i.ToString())
        End Try


    End Function




    ''// Validacion de  la parte   o papel leido

    ''valida  que  la  parte  sea valida  en el sistema

    Public Shared Function bol_parte(ByVal partepapel) As Integer
        Dim valor As Integer
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring
            Dim mystring2 As String = "select * from Part where PartNum ='" + CStr(partepapel) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
                conta = conta + 1

            End While

            If (conta > 0) Then
                valor = 1
            Else

                valor = 0

            End If

            Return valor

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Parte no encontrada  en el sistema ")
        End Try






    End Function




    ''valida  el papel dentro del pedido
    Public Shared Function bol_papel(ByVal partepapel, ByVal job) As Integer
        Dim valor As Integer
'MessageBox.Show("Papel:" + CStr(partepapel) + "   job:" + CStr(job))
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring
            Dim mystring2 As String = "select * from JobMtl where   JobNum = '" + CStr(job) + "'    and  MtlSeq in (110,120,130,140,150) and PartNum = '" + CStr(partepapel) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
                conta = conta + 1
            End While
            If (conta > 0) Then
                valor = 1
            Else

                valor = 0

            End If
            Return valor

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar  papel ")
        End Try






    End Function






    ''valida  existencia  de consumo de tal CI
    Public Shared Function consumo_existe(ByVal CI) As Integer
        Dim valor As Integer
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring3
            Dim mystring2 As String = "  select *  from Consumos where no_ci = '" + CStr(CI) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
                conta = conta + 1
            End While
            If (conta > 0) Then
                valor = 1
            Else

                valor = 0

            End If
            Return valor

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar  consumos  de CI " + i.ToString)
        End Try


















    End Function




 ''valida  existencia  de consumo 
    Public Shared Function consumo_valido(ByVal parte, ByVal lote, ByVal empalmador, ByVal ci) As Integer
        Dim valor As Integer
'MessageBox.Show(" enviados  validar  consumo parte: " + CStr(parte) + " lote:" + CStr(lote) + " empalmador:" + CStr(empalmador) + " ci:" + CStr(ci))

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring3
            Dim mystring2 As String = "  select *  from Consumos where no_ci = '" + CStr(ci) + "' and  parte_rollo='" + CStr(parte) + "' and Rollo='" + CStr(lote) + "' and empalmador='" + CStr(empalmador) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
                conta = conta + 1
               ' MessageBox.Show("Encontrado")
            End While

'MessageBox.Show("encontrados :" + CStr(conta))

            If (conta > 0) Then
                valor = 1
'MessageBox.Show("no debe ser valido")
            Else

                valor = 0
'MessageBox.Show(" debe ser valido")

            End If
            Return valor

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar  consumos  de CI,parte empalmador  lote " + i.ToString)
        End Try


End Function









 ''valida  existencia  kgfinales
    Public Shared Function val_kginiciales(ByVal parte, ByVal rollo) As Integer
        Dim valor As Integer
'MessageBox.Show("pARTE" + CStr(parte) + "  rollo : " + CStr(rollo))
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring3
            Dim mystring2 As String = " SELECT  TOP (1) *  FROM CONSUMOS where  parte_rollo='" + CStr(parte) + "' and  Rollo='" + CStr(rollo) + "'  ORDER BY Fecha_consumo DESC "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                conta = reader2.GetDouble(8)
'MessageBox.Show("kgfinales  mas  recientes :" + CStr(reader2.GetDouble(8)))
            End While
            If (conta <= 0) Then ''kgfinales  <= 0
                valor = 0
'MessageBox.Show("no tiene kg  finales:, debe pedir")
            Else

                valor = 1
'MessageBox.Show(" tiene kgfinales : , puede  permitir 0")
            End If
            Return valor

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar KG inciales " + i.ToString)
        End Try


End Function








    ''valida  maquina  correcta  del programa

    Public Shared Function bol_ancho(ByVal ancho_c, ByVal ancho_prog) As Integer
        Dim valor As Integer
        If (ancho_c = ancho_prog) Then
            valor = 1
        Else
            valor = 0
        End If
        Return valor
    End Function



    ''// Insertar  consumo
    Public Shared Function insert_consumo(ByVal fecha_programa, ByVal fecha_consumo, ByVal pedido_ot, ByVal CI, ByVal maquina_consumo, ByVal empalmador, ByVal parte_rollo, ByVal kginiciales, ByVal rollo) As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
Dim idrow = CStr(fecha_consumo) + "/" + CStr(empalmador)
            con.ConnectionString = coneccionstring2
            con.Open()
            cmd.Connection = con
            'cmd.CommandText = " insert into consumos  values  (" + CDate(fecha_programa) + "," + CDate(fecha_consumo) + ",'" + CStr(pedido_ot) + "','" + CStr(CI) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte_rollo) + "'," + CStr(kginiciales) + ",null,'" + CStr(rollo) + "',null,null,null,null,null)"
            'MessageBox.Show("fecha_programa :" + CStr(fecha_programa) + " fecha CONSUMO : " + fecha_consumo)
            cmd.CommandText = " insert into consumos  values  ('" + fecha_programa + "','" + fecha_consumo + "'" + ",'" + Trim(CStr(pedido_ot)) + "','" + Trim(CStr(CI)) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte_rollo) + "'," + CStr(kginiciales) + ",0.00,'" + CStr(rollo) + "',null,null,null,null,null,'" + CStr(idrow) + "')"

            cmd.ExecuteNonQuery()
            Ingreso_consumos.parterollo_TXT.Text = ""
            Ingreso_consumos.rollo_txt.Text = ""
            Ingreso_consumos.kginiciales_txt.Text = ""
            Ingreso_consumos.Status_stt.Text = "Nuevo consumo agregado..."
            My.Forms.Ingreso_consumos.empalmador_cmb.Focus()
        Catch i As Exception

            MessageBox.Show("Error  al insertar  consumo de  rollo " + i.ToString())

        Finally
            con.Close()

        End Try


    End Function

    ''valida  duplicado CI
    Public Shared Function valida_programado_duplicate_(ByVal CI_programada) As Integer
        Dim valor As Integer
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring
            Dim mystring2 As String = "select * from IF4.dbo.Programado where  ci_instruccioncorrugadora = '" + CStr(CI_programada) + "'"


            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
                conta = conta + 1
            End While
            If (conta > 1) Then
                valor = 1
            Else

                valor = 0

            End If
            Return valor

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar   ")
        End Try






    End Function

''valida  duplicado CI
    Public Shared Function valida_produccion(ByVal ot, ByVal fechaini) As Integer
        Dim valor As Integer
        Try
'MessageBox.Show("OT REC:" + ot.ToString + "FECHA_INI :" + fechaini.ToString)
            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring3
            Dim mystring2 As String = "select * from Produccion where  OT = '" + CStr(ot) + "' and  fecha_inicio_prod = '" + CStr(fechaini) + "'"


            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

                conta = conta + 1

'MessageBox.Show("CONT:" + conta.ToString)

            End While
            If (conta > 1) Then
                valor = 1
            Else

                valor = 0

            End If
            Return valor

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar   " + i.ToString)
        End Try


End Function


 ''valida  duplicado CI
    Public Shared Function valida_produccion_duplicate_(ByVal CI_programada) As Integer

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring
            Dim mystring2 As String = "select max(n1) from IF4.dbo.Produccion where  ci= '" + CStr(CI_programada) + "'"


            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
               conta = reader2.GetInt32(0)
            End While

            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar   ")
        End Try






    End Function




 ''valida  duplicado CI
    Public Shared Function valida_produccion_duplicate_2(ByVal CI_programada) As Integer

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring
            Dim mystring2 As String = "select min(n1) from IF4.dbo.Produccion where  ci= '" + CStr(CI_programada) + "'"


            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()
               conta = reader2.GetInt32(0)
            End While

            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar   ")
        End Try






    End Function




    ''obtiene  fecha  minima
    Public Shared Function get_min_fecha(ByVal CI_programada) As Date

        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = coneccionstring
            Dim mystring2 As String = "select top 1 fecha_hora_programada from IF4.dbo.Programado where  ci_instruccioncorrugadora = '" + CStr(CI_programada) + "' order by fecha_hora_programada asc"


            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Date
            While reader2.Read()
                conta = reader2.GetDateTime(0)

            End While




            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Error  al validar   ")
        End Try






    End Function





    Public Shared Function update_cons(ByVal KgIniciales, ByVal KgFinales, ByVal empalmador, ByVal fecha)


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim res As Integer
        Try

            con.ConnectionString = coneccionstring2
            con.Open()
            cmd.Connection = con
            'cmd.CommandText = " insert into consumos  values  (" + CDate(fecha_programa) + "," + CDate(fecha_consumo) + ",'" + CStr(pedido_ot) + "','" + CStr(CI) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte_rollo) + "'," + CStr(kginiciales) + ",null,'" + CStr(rollo) + "',null,null,null,null,null)"
            ' MessageBox.Show("Recibido:" + fecha + " -inic:   " + KgIniciales + " - fin: " + KgFinales)
            cmd.CommandText = " Update consumos set  Kginiciales = " + KgIniciales + " ,KgFinales = " + KgFinales + ",empalmador = '" + CStr(empalmador) + "' where  Fecha_consumo = '" + fecha + "'"

            cmd.ExecuteNonQuery()


        Catch i As Exception
            MessageBox.Show("Error  al actualizar  consumo de  rollo " + i.ToString())

        Finally
            con.Close()

        End Try

        Return res




    End Function





End Class
