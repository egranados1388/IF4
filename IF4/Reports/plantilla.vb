Imports System.Data.Odbc ''//Libreria metodos para conexion odbc
Imports System.Data.SqlClient
Public Class plantilla
    Shared cs As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"


    Private Const csd As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"


    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    ' Private Const cs As String = "Data Source=172.16.1.15;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean
Private WithEvents bs As New BindingSource
Private Sub plantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load









With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("SELECT  [OT]      ,[PARTE]      ,[ENSAMBLE]      ,[PARTE_ENS_TRAB]      ,[SEC]      ,[PARTE_SEC_JOB]      ,[cantidad_3]      ,[FECHA]      ,[PARTE_DR]      ,[REFERENCIA]      ,[LOTE]      ,[DE_ALMACEN]      ,[DE_DEPOSITO]      ,[DESCRIPCION]      ,[A_ALMACEN]      ,[A_DEPOSITO]      ,[DESCRIPCION_DR]      ,[EMISIONCOMPLETA]      ,[requerimiento_udm]      ,[cantidad_3]      FROM [IF4].[dbo].[plantilla_r_resumen1] where  OT <> ''", DataGridView1)



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

        Try
            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "select * from muestras_r"
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

Dim sec = "110"
Dim fecha = reader2.Item(5)
Dim referencia = reader2.Item(8)
Dim dealmacen = "300"
Dim deposito = "001"
Dim a_almacen = ""
Dim a_deposito = ""
Dim descripcion_dr = " "
Dim emision_completa = ""
Dim requerimiento_udm = ""
Dim cantidad_d = reader2.Item(52)



 Dim c_ot = comprobar_ot(ot)

If (c_ot = 0) Then
insertar_PLANTILLA(cis, ot, "", "0", "", sec, "", cantidad, fecha, parte13, referencia, rollo13, dealmacen, deposito, "", a_almacen, a_deposito, descripcion_dr, emision_completa, requerimiento_udm, cantidad_d)

End If


            End While ''// Fin registros  base  calculos  fase 1
        Catch e As Exception

 MessageBox.Show("Calculos 2 :" + e.ToString)
        End Try

      '  MessageBox.Show("Ok. Oprima Actualizar 2 ")

        Return 0

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












    Public Shared Function insertar_PLANTILLA(ByVal ci, ByVal ot, ByVal a, ByVal b, ByVal c, ByVal sec, ByVal d, ByVal cantidad, ByVal fecha, ByVal parte13, ByVal referencia, ByVal rollo13, ByVal dealmacen, ByVal deposito, ByVal e, ByVal a_almacen, ByVal a_deposito, ByVal descripcion_dr, ByVal emision_completa, ByVal requerimiento_udm, ByVal cantidad_d)



        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs



            Dim cmd2 As New OdbcCommand
            cmd2.Connection = conn2
           conn2.Open()
            cmd2.CommandText = "INSERT INTO plantilla_r  VALUES   ('" + CStr(ci) + "','" + CStr(ot) + "','" + CStr(a) + "','" + CStr(b) + "','" + CStr(c) + "','" + CStr(sec) + "','" + CStr(d) + "','" + CStr(cantidad) + "','" + CStr(fecha) + "','" + CStr(parte13) + "','" + CStr(referencia) + "','" + CStr(rollo13) + "','" + CStr(dealmacen) + "','" + CStr(deposito) + "','" + CStr(e) + "','" + CStr(a_almacen) + "','" + CStr(a_deposito) + "','" + CStr(descripcion_dr) + "','" + CStr(emision_completa) + "','" + CStr(requerimiento_udm) + "','" + CStr(cantidad_d) + "')"
            cmd2.ExecuteNonQuery()




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
            Dim mystring2 As String = "delete  from plantilla_r"
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