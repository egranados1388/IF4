Imports System.Data.Odbc ''//Libreria metodos para conexion odbc
Imports System.Data.SqlClient
Public Class plantilla_r
Shared cs As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"
Shared cs2 As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=Epicor905;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"


 Private Const csd As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"


Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
   ' Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean
Private WithEvents bs As New BindingSource
Private Sub plantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

clean_dbplantilla()
carga_PLANTILLA()
carga_PLANTILLA2()





With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("SELECT * FROM [IF4].[dbo].[plantilla_r_resumen1]", DataGridView1)



End Sub




 Public Sub cargar_registros(ByVal sql As String, ByVal dv As DataGridView)

        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string  
            SqlDataAdapter = New SqlDataAdapter(sql, csd)

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable  
            Dim dt As New DataTable()
            SqlDataAdapter.Fill(dt)

            ' Enlazar el BindingSource con el datatable anterior  
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
            bs.DataSource = dt

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                .FirstDisplayedScrollingRowIndex = bs.Position
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try



        ''Ciclo forzoso 1


    End Sub




    Public Shared Function carga_PLANTILLA()

        ''// Actualizar segunda  fase de ciclo  de calculos teoricos en base  a  registros primer calculo
Dim ind As Integer = 0
        Try
            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_r order by MrowID asc"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0


            '' // Comienzan registros base  para calculos 
            While reader2.Read()

                Dim ot = reader2.Item(6)
                Dim rollo13 = reader2.Item(11)
                Dim parte13 = reader2.Item(10)
                Dim cis = reader2.Item(7)
                Dim indice = reader2.Item(0)
                Dim cantidad = reader2.Item(52)

Dim EMPALMADOR = reader2.Item(9)

Dim sec = ""

If (EMPALMADOR.Equals("E1")) Then

sec = "110"

End If



If (EMPALMADOR.Equals("E2")) Then

sec = "120"


End If




If (EMPALMADOR.Equals("E3")) Then

sec = "130"


End If


If (EMPALMADOR.Equals("E4")) Then

sec = "140"


End If



If (EMPALMADOR.Equals("E5")) Then

sec = "150"


End If







Dim MAQUINA = reader2.Item(8)
Dim COMB = reader2.Item(14)


Dim fecha = reader2.Item(5)
Dim referencia = MAQUINA.ToString + "-" + cis.ToString + "-" + COMB.ToString
Dim dealmacen = "300"
Dim deposito = "001"
Dim a_almacen = ""
Dim a_deposito = ""
Dim descripcion_dr = " "
Dim emision_completa = ""
Dim requerimiento_udm = ""
Dim cantidad_d = reader2.Item(52)



Dim cant_alm300 = "", cant_alm300acum = "", cant_tranif4 = "", cantidad2 = "", cantidad3 = "", combinacion = "", lineaprod = ""




cant_alm300 = GET_CANT_ALM300(rollo13, parte13)




 Dim c_ot = comprobar_ot(ot)

'If (c_ot = 0) Then
ind = ind + 1

'MessageBox.Show(" ind leido: " + CStr(indice))

insertar_PLANTILLA(cis, ot, "", "0", "", sec, "", cantidad, fecha, parte13, referencia, rollo13, dealmacen, deposito, "", a_almacen, a_deposito, descripcion_dr, emision_completa, requerimiento_udm, cantidad_d, cant_alm300, cant_tranif4, cant_alm300acum, cantidad2, cantidad3, MAQUINA, COMB, indice)
'MessageBox.Show(" ind insertado: " + CStr(indice))
'End If


            End While ''// Fin registros  base  calculos  fase 1
        Catch e As Exception

 MessageBox.Show("Calculos 2 :" + e.ToString)
        End Try

      '  MessageBox.Show("Ok. Oprima Actualizar 2 ")

        Return 0

    End Function





    Public Shared Function update_cant_transif4acum(ByVal indice, ByVal valor)
        'MessageBox.Show("vaslor : " + CStr(valor) + "  indice: " + CStr(indice))

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim res As Integer
        Try

            con.ConnectionString = csd
            con.Open()
            cmd.Connection = con
            'cmd.CommandText = " insert into consumos  values  (" + CDate(fecha_programa) + "," + CDate(fecha_consumo) + ",'" + CStr(pedido_ot) + "','" + CStr(CI) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte_rollo) + "'," + CStr(kginiciales) + ",null,'" + CStr(rollo) + "',null,null,null,null,null)"
            ' MessageBox.Show("Recibido:" + fecha + " -inic:   " + KgIniciales + " - fin: " + KgFinales)
            cmd.CommandText = " Update plantilla_r_resumen1 set  cantidad_tranIF4_acum = '" + CStr(valor) + "' where  ind = '" + CStr(indice) + "'"

            cmd.ExecuteNonQuery()


        Catch i As Exception
            MessageBox.Show("Error  al actualizar  consumo de  rollo " + i.ToString())

        Finally
            con.Close()

        End Try

        Return res




    End Function








    Public Shared Function update_cant_alm300_acum(ByVal indice, ByVal valor)


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim res As Integer
        Try

            con.ConnectionString = csd
            con.Open()
            cmd.Connection = con
            'cmd.CommandText = " insert into consumos  values  (" + CDate(fecha_programa) + "," + CDate(fecha_consumo) + ",'" + CStr(pedido_ot) + "','" + CStr(CI) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte_rollo) + "'," + CStr(kginiciales) + ",null,'" + CStr(rollo) + "',null,null,null,null,null)"
            ' MessageBox.Show("Recibido:" + fecha + " -inic:   " + KgIniciales + " - fin: " + KgFinales)
            cmd.CommandText = " Update plantilla_r_resumen1 set  cantidad_alm300_acum = '" + CStr(valor) + "' where  ind = '" + CStr(indice) + "'"

            cmd.ExecuteNonQuery()


        Catch i As Exception
            MessageBox.Show("Error  al actualizar  consumo de  rollo " + i.ToString())

        Finally
            con.Close()

        End Try

        Return res




    End Function





    Public Shared Function update_cantidad2(ByVal indice, ByVal valor)


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim res As Integer
        Try

            con.ConnectionString = csd
            con.Open()
            cmd.Connection = con
            'cmd.CommandText = " insert into consumos  values  (" + CDate(fecha_programa) + "," + CDate(fecha_consumo) + ",'" + CStr(pedido_ot) + "','" + CStr(CI) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte_rollo) + "'," + CStr(kginiciales) + ",null,'" + CStr(rollo) + "',null,null,null,null,null)"
            ' MessageBox.Show("Recibido:" + fecha + " -inic:   " + KgIniciales + " - fin: " + KgFinales)
            cmd.CommandText = " Update plantilla_r_resumen1 set  cantidad_2= '" + CStr(valor) + "' where  ind = '" + CStr(indice) + "'"

            cmd.ExecuteNonQuery()


        Catch i As Exception
            MessageBox.Show("Error  al actualizar  consumo de  rollo " + i.ToString())

        Finally
            con.Close()

        End Try

        Return res




    End Function




    Public Shared Function update_cantidad3(ByVal indice, ByVal valor)


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim res As Integer
        Try

            con.ConnectionString = csd
            con.Open()
            cmd.Connection = con
            'cmd.CommandText = " insert into consumos  values  (" + CDate(fecha_programa) + "," + CDate(fecha_consumo) + ",'" + CStr(pedido_ot) + "','" + CStr(CI) + "','" + CStr(maquina_consumo) + "','" + CStr(empalmador) + "','" + CStr(parte_rollo) + "'," + CStr(kginiciales) + ",null,'" + CStr(rollo) + "',null,null,null,null,null)"
            ' MessageBox.Show("Recibido:" + fecha + " -inic:   " + KgIniciales + " - fin: " + KgFinales)
            cmd.CommandText = " Update plantilla_r_resumen1 set  cantidad_3= '" + CStr(valor) + "' where  ind = '" + CStr(indice) + "'"

            cmd.ExecuteNonQuery()


        Catch i As Exception
            MessageBox.Show("Error  al actualizar  consumo de  rollo " + i.ToString())

        Finally
            con.Close()

        End Try

        Return res




    End Function








    Public Shared Function carga_PLANTILLA2()

        ''// Actualizar segunda  fase de ciclo  de calculos teoricos en base  a  registros primer calculo

        Try
            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from plantilla_r_resumen1"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0


            '' // Comienzan registros base  para calculos 
            While reader2.Read()

                Dim ot = reader2.Item(0)
                Dim rollo13 = reader2.Item(10)
                Dim parte13 = reader2.Item(8)
                Dim cis = reader2.Item(27)
                'Dim indice = reader2.Item(0)


''// H
                Dim cantidad = reader2.Item(6)



Dim indice = reader2.Item(28)
'Dim EMPALMADOR = reader2.Item(9)



''AI-----------------
Dim cant_alm300 = reader2.Item(20)




''AJ-------------------------------
'MessageBox.Show("IFTRAN ACUM :" + " PARTE :" + parte13.ToString + " rollo13: " + rollo13.ToString + "  indice: " + indice.ToString)
Dim cant_transif4acum = get_cant_transif4acum(parte13, rollo13, indice)
'MessageBox.Show(" acum : " + cant_transif4acum.ToString)

update_cant_transif4acum(indice, cant_transif4acum)



''AK-------------------------

Dim cant_alm300_acum = cant_alm300 - cant_transif4acum
update_cant_alm300_acum(indice, cant_alm300_acum)



''AL----------------------------

'=SI(AJ7>AI7,SI((H7+AK7)<0,0, H7+AK7),H7)

Dim cantidad2
If (cant_transif4acum > cant_alm300) Then


                If ((cantidad + cant_alm300_acum) < 0) Then
                cantidad2 = 0

                Else
                cantidad2 = cantidad + cant_alm300_acum

                End If


Else

cantidad2 = cantidad

End If


update_cantidad2(indice, cantidad2)

Dim cantidad3 = Decimal.Round(cantidad2, 6)
update_cantidad3(indice, cantidad3)

'insertar_PLANTILLA(cis, ot, "", "0", "", sec, "", cantidad, fecha, parte13, referencia, rollo13, dealmacen, deposito, "", a_almacen, a_deposito, descripcion_dr, emision_completa, requerimiento_udm, cantidad_d, cant_alm300, cant_tranif4, cant_alm300acum, cantidad2, cantidad3, lineaprod, combinacion)




            End While ''// Fin registros  base  calculos  fase 1
        Catch e As Exception

 MessageBox.Show("Calculos 2 :" + e.ToString)
        End Try

      '  MessageBox.Show("Ok. Oprima Actualizar 2 ")

        Return 0

    End Function






Public Shared Function GET_CANT_ALM300(ByVal LOTE, ByVal PARTE) As Integer
        Dim valor As Integer = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs2
            Dim mystring2 As String = "select PartNum , WarehouseCode , BinNum , OnhandQty , LotNum  from PartBin  where  WarehouseCode = 300  and  LotNum = '" + LOTE.ToString + "' and  PartNum =  '" + PARTE.ToString + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
            While reader2.Read()

               conta = conta + reader2.Item(3)

            End While

            
            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Parte no encontrada  en el sistema --- 300 " + i.ToString)
        End Try






    End Function







Public Shared Function GET_CANT_transif4acum(ByVal parte, ByVal lote, ByVal indice) As Double
        Dim valor As Integer = 0
        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select *  from plantilla_r_resumen1  where    lote = '" + lote.ToString + "' and  parte_dr =  '" + parte.ToString + "' and  ind <=  '" + indice.ToString + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Double = 0.0
Dim c As Integer
Dim b As Integer
            While reader2.Read()


               If reader2.Item(0).ToString.Length > 0 Then
               conta = conta + reader2.Item(6)
b = b + 1

                End If

            c = c + 1

            End While

'MessageBox.Show("coincidencias :" + c.ToString)
'MessageBox.Show("contables:" + b.ToString)
            Return conta

            reader2.Close()
            conn2.Close()


        Catch i As Exception
            MessageBox.Show(" Parte no encontrada  en el sistema 001  " + i.ToString)
        End Try






    End Function



    Public Shared Function comprobar_ot(ByVal ot)

        ''// Actualizar segunda  fase de ciclo  de calculos teoricos en base  a  registros primer calculo
  Dim conta As Integer = 0
        Try
            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from plantilla_r"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()



            '' // Comienzan registros base  para calculos 
            While reader2.Read()



            If (reader2.Item(1).Equals(ot)) Then


            conta = conta + 1



            End If


            End While ''// Fin registros  base  calculos  fase 1
        Catch e As Exception

 MessageBox.Show("Calculos 2 :" + e.ToString)
        End Try

      '  MessageBox.Show("Ok. Oprima Actualizar 2 ")

        Return conta

    End Function












    Public Shared Function insertar_PLANTILLA(ByVal ci, ByVal ot, ByVal a, ByVal b, ByVal c, ByVal sec, ByVal d, ByVal cantidad, ByVal fecha, ByVal parte13, ByVal referencia, ByVal rollo13, ByVal dealmacen, ByVal deposito, ByVal e, ByVal a_almacen, ByVal a_deposito, ByVal descripcion_dr, ByVal emision_completa, ByVal requerimiento_udm, ByVal cantidad_d, ByVal cant_alm300, ByVal cantidad_tranIF4, ByVal cantidad_alm300acum, ByVal cantidad_2, ByVal cantidad_3, ByVal linea_prod, ByVal combinacion, ByVal ind)



        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs



            Dim cmd2 As New OdbcCommand
            cmd2.Connection = conn2
           conn2.Open()
            cmd2.CommandText = "INSERT INTO plantilla_r_resumen1  VALUES   ('" + CStr(ot) + "','" + CStr(a) + "','" + CStr(b) + "','" + CStr(c) + "','" + CStr(sec) + "','" + CStr(d) + "','" + CStr(cantidad) + "','" + CStr(fecha) + "','" + CStr(parte13) + "','" + CStr(referencia) + "','" + CStr(rollo13) + "','" + CStr(dealmacen) + "','" + CStr(deposito) + "','" + CStr(e) + "','" + CStr(a_almacen) + "','" + CStr(a_deposito) + "','" + CStr(descripcion_dr) + "','" + CStr(emision_completa) + "','" + CStr(requerimiento_udm) + "','" + CStr(cantidad_d) + "','" + CStr(cant_alm300) + "','" + CStr(cantidad_tranIF4) + "','" + CStr(cantidad_alm300acum) + "','" + CStr(cantidad_2) + "','" + CStr(cantidad_3) + "','" + CStr(linea_prod) + "','" + CStr(ci) + "','" + CStr(combinacion) + "'," + CStr(ind) + " )"
            cmd2.ExecuteNonQuery()



'insertar_PLANTILLA(cis, ot, "", "0", "", sec, "", cantidad, fecha, parte13, referencia, rollo13, dealmacen, deposito, "", a_almacen, a_deposito, descripcion_dr, emision_completa, requerimiento_udm, cantidad_d)


            conn2.Close()





        Catch ax As Exception
            MessageBox.Show(" Insertar_ayuda " + a.ToString())
        End Try

Return 0
    End Function







''// Borra  existencia de  muestras(registros  muestras_t)
Public Shared Function clean_dbplantilla() As Integer

        Try


            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "delete  from plantilla_r_resumen1"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()

            End While


        Catch i As Exception
            MessageBox.Show("Clean dbayuda " + i.ToString())
        End Try


    End Function









End Class