
Imports System.Data.SqlClient
Imports System.Data.Odbc
Public Class semaf2

    'BindingSource  
    Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.15;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean
    Shared csd As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.15;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"

    Shared epicor As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.15;" + "DataBase=E10Cartomicro;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"


''// Borra  existencia de  muestras(registros  muestras_t)
Public Shared Function clean_dbsemaforo() As Integer

        Try


            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "delete  from semaforo_t"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()

            End While


        Catch i As Exception
            MessageBox.Show("Clean sema " + i.ToString())
        End Try


    End Function

    Private Sub programas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
clean_dbsemaforo()

integra_semaforos()



 ' Me.ToolTip1.SetToolTip(Me.Button3, "Eliminar  el registro actual")
        With DataGridView2
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("Select * From semaforo_t", DataGridView2)




    End Sub

    Public Sub cargar_registros(ByVal sql As String, ByVal dv As DataGridView)

        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string  
            SqlDataAdapter = New SqlDataAdapter(sql, cs)

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

        For Each row As DataGridViewRow In Me.DataGridView2.Rows
            '' Valor  fila  actual recorrido
            Dim actual = row.Cells(7).Value.ToString

           ' MessageBox.Show("Actual:" + actual)


           If (CDbl(row.Cells(7).Value) > 50) Then

                    row.DefaultCellStyle.BackColor = Color.Yellow

Else

If (CDbl(row.Cells(7).Value) < -50) Then

  row.DefaultCellStyle.BackColor = Color.Red
End If

End If






        Next

    End Sub


    Private Sub Actualizar(Optional ByVal bCargar As Boolean = True)
        ' Actualizar y guardar cambios  

        If Not bs.DataSource Is Nothing Then
            SqlDataAdapter.Update(CType(bs.DataSource, DataTable))
            If bCargar Then
                cargar_registros("Select * From Programado Order by fecha_hora_programada", DataGridView2)
            End If
        End If
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim estaci As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
'MessageBox.Show("ok")

       ' MessageBox.Show("CI a eliminar:" + estaci)
        Dim consumo_previo_this_CI As Integer = metodos.consumo_existe(estaci)

        If (consumo_previo_this_CI = 1) Then



            Dim response = MsgBox("Esta CI ya contiene  consumos registrados Desea Continuar?", MsgBoxStyle.OkCancel, "Aviso")
            If response = MsgBoxResult.Ok Then
                If Not bs.Current Is Nothing Then
                    ' eliminar()
                    bs.RemoveCurrent()

                    'Guardar los cambios y recargar  
                    Actualizar()
                     MsgBox("El registro ha sido eliminado")
                Else
                  '  MsgBox("No hay un registro actual para eliminar", _
                         '  MsgBoxStyle.Exclamation, _
                         '  "Eliminar")
                End If


            End If

        Else


            If Not bs.Current Is Nothing Then
                ' eliminar  
                bs.RemoveCurrent()

                'Guardar los cambios y recargar  
               Actualizar()
                 MsgBox("El registro ha sido eliminado")
            Else
               ' MsgBox("No hay un registro actual para eliminar", _
               '        MsgBoxStyle.Exclamation, _
                '       "Eliminar")
            End If


        End If

    End Sub


Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


 Dim estaci As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
'MessageBox.Show("ok")

        'MessageBox.Show("CI a eliminar:" + estaci)
        Dim consumo_previo_this_CI As Integer = metodos.consumo_existe(estaci)

        If (consumo_previo_this_CI = 1) Then



           Dim response = MsgBox("Esta CI ya contiene  consumos registrados Desea Continuar?", MsgBoxStyle.OkCancel, "Aviso")
            If response = MsgBoxResult.Ok Then
               If Not bs.Current Is Nothing Then
                    ' eliminar  
                    bs.RemoveCurrent()

                    'Guardar los cambios y recargar  
                    Actualizar()
                     MsgBox("El registro ha sido eliminado")
                Else
                    'MsgBox("No hay un registro actual para eliminar", _
                         '  MsgBoxStyle.Exclamation, _
                         '  "Eliminar")
                End If


            End If

        Else


            If Not bs.Current Is Nothing Then
                ' eliminar  
                bs.RemoveCurrent()

                'Guardar los cambios y recargar  
                Actualizar()
                 MsgBox("El registro ha sido eliminado")
            Else
               ' MsgBox("No hay un registro actual para eliminar", _
               '        MsgBoxStyle.Exclamation, _
                '       "Eliminar")
            End If


        End If
End Sub




  Public Shared Function inserta_semaforo(ByVal ci, ByVal calidad, ByVal flauta, ByVal longitud, ByVal ancho_papel, ByVal idpedido, ByVal te1, ByVal te2, ByVal te3, ByVal te4, ByVal te5, ByVal rce1, ByVal rce2, ByVal rce3, ByVal rce4, ByVal rce5, ByVal de1, ByVal de2, ByVal de3, ByVal de4, ByVal de5, ByVal err_tipo, ByVal err_ancho, ByVal falta_esca, ByVal falta_kg, ByVal dif_kgen_sal, ByVal cambio_empal)


       Dim sal As Double



        Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd



            Dim cmd2 As New OdbcCommand
            cmd2.Connection = conn2
           conn2.Open()
            'cmd2.CommandText = "INSERT INTO semaforo_t  VALUES " & _
         ' "('" + CStr(ci) + "','" + CStr(calidad) + "','" + CStr(flauta) + "'," + CStr(longitud) + "," + CStr(ancho_papel) + ",'" + CStr(idpedido) + "'," + CStr(te1) + "," + CStr(te2) + "," + CStr(te3) + "," + CStr(te4) + "," + CStr(te5) + "," + CStr(rce1) + "," + CStr(rce2) + "," + CStr(rce3) + "," + CStr(rce4) + "," + CStr(rce5) + "," + CStr(de1) + "," + CStr(de2) + "," + CStr(de3) + "," + CStr(de4) + "," + CStr(de5) + ",'" + CStr(err_tipo) + "','" + CStr(err_ancho) + "','" + CStr(falta_esca) + "','" + CStr(falta_kg) + "','" + CStr(dif_kgen_sal) + "','" + CStr(cambio_empal) + "')"


   cmd2.CommandText = "INSERT INTO semaforo_t  VALUES " & _
          "('" + CStr(ci) + "','" + CStr(calidad) + "','" + CStr(flauta) + "'," + CStr(longitud) + "," + CStr(ancho_papel) + ",'" + CStr(idpedido) + "'," + CStr(te1) + "," + CStr(te2) + "," + CStr(te3) + "," + CStr(te4) + "," + CStr(te5) + "," + CStr(rce1) + "," + CStr(rce2) + "," + CStr(rce3) + "," + CStr(rce4) + "," + CStr(rce5) + ",'" + CStr(de1) + "','" + CStr(de2) + "','" + CStr(de3) + "','" + CStr(de4) + "','" + CStr(de5) + "','" + CStr(err_tipo) + "','" + CStr(err_ancho) + "','" + CStr(falta_esca) + "','" + CStr(falta_kg) + "','" + CStr(dif_kgen_sal) + "','" + CStr(cambio_empal) + "')"




 cmd2.ExecuteNonQuery()







            Return sal


            conn2.Close()





        Catch a As Exception
            MessageBox.Show(" Insertar resumen " + a.ToString())
        End Try
        Return sal

    End Function




  Public Shared Function integra_semaforos()

Dim val = 0

Dim data_gen(), data_papeles()


 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select distinct ci from muestras_t "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
Dim CI
            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas
conta = conta + 1
 CI = Trim(Replace(reader2.GetString(0), " ", ""))

'MessageBox.Show("ci estudiada:" + CStr(CI) + " --")

data_gen = get_genericos_semaforo(RTrim(CStr(CI)))

'MessageBox.Show(" - " + CStr(data_gen(0)) + " - combinac " + Trim(CStr(data_gen(1))) + " - " + CStr(data_gen(2)) + " - " + CStr(data_gen(3)) + " - " + CStr(data_gen(4)) + " - " + CStr(data_gen(5)))


'MessageBox.Show("combinacion enviada:" + Trim(CStr(data_gen(1))))


data_papeles = get_papeles_empalmador(Trim(CStr(data_gen(1))))


'MessageBox.Show("e1:" + CStr(data_papeles(1)) + "e2:" + CStr(data_papeles(2)) + "  e3: " + CStr(data_papeles(3)) + " e4: " + CStr(data_papeles(4)) + " e5: " + CStr(data_papeles(5)))





''//Sacando kgestimados  x  empalmador 1
'MessageBox.Show("Papel 1 para gramaje: " + CStr(CStr(data_papeles(1))))
Dim grama1
Dim factor1
Dim kgestimados_empalmador1
If (data_papeles(1).Equals(DBNull.Value) Or data_papeles(1).Equals("")) Then
grama1 = 0
 factor1 = 0
 kgestimados_empalmador1 = 0

Else
grama1 = Calculos_teorico.get_gramaje(CStr(data_papeles(1) + "/0000"))
 factor1 = Calculos_teorico.set_factor("E1", data_gen(2))
 kgestimados_empalmador1 = CDbl(data_gen(4)) * 0.001 * CDbl(data_gen(3)) * grama1 * factor1
End If



Dim grama2
Dim factor2
Dim kgestimados_empalmador2

If (data_papeles(2).Equals(DBNull.Value) Or data_papeles(2).Equals("")) Then
''//Sacando kgestimados  x  empalmador 2
grama2 = 0
 factor2 = 0
kgestimados_empalmador2 = 0

Else
 grama2 = Calculos_teorico.get_gramaje(CStr(data_papeles(2) + "/0000"))
 factor2 = Calculos_teorico.set_factor("E2", data_gen(2))
kgestimados_empalmador2 = CDbl(data_gen(4)) * 0.001 * CDbl(data_gen(3)) * grama2 * factor2

End If


Dim grama3
Dim factor3
Dim kgestimados_empalmador3

If (data_papeles(3).Equals(DBNull.Value) Or data_papeles(3).Equals("")) Then

grama3 = 0
factor3 = 0
kgestimados_empalmador3 = 0
Else

 grama3 = Calculos_teorico.get_gramaje(CStr(data_papeles(3) + "/0000"))
 factor3 = Calculos_teorico.set_factor("E3", data_gen(2))
 kgestimados_empalmador3 = CDbl(data_gen(4)) * 0.001 * CDbl(data_gen(3)) * grama3 * factor3
End If




Dim grama4
Dim factor4
Dim kgestimados_empalmador4
If (data_papeles(4).Equals(DBNull.Value) Or data_papeles(4).Equals("")) Then
''//Sacando kgestimados  x  empalmador 4

grama4 = 0
factor4 = 0
kgestimados_empalmador4 = 0

Else

 grama4 = Calculos_teorico.get_gramaje(CStr(data_papeles(4) + "/0000"))
 factor4 = Calculos_teorico.set_factor("E4", data_gen(2))
 kgestimados_empalmador4 = CDbl(data_gen(4)) * 0.001 * CDbl(data_gen(3)) * grama4 * factor4
End If


Dim grama5
Dim factor5
Dim kgestimados_empalmador5

''//Sacando kgestimados  x  empalmador 5

If (data_papeles(5).Equals(DBNull.Value) Or data_papeles(5).Equals("")) Then
grama5 = 0
 factor5 = 0
kgestimados_empalmador5 = 0
Else
grama5 = Calculos_teorico.get_gramaje(CStr(data_papeles(5) + "/0000"))
 factor5 = Calculos_teorico.set_factor("E5", data_gen(2))
kgestimados_empalmador5 = CDbl(data_gen(4)) * 0.001 * CDbl(data_gen(3)) * grama5 * factor5

End If




''--------------------sacando datos reales teoricos  (escaneos)



''//E1
Dim kgreales_empalmador1 = get_dr(CI, "E1")

''//E2
Dim kgreales_empalmador2 = get_dr(CI, "E2")

''//E3
Dim kgreales_empalmador3 = get_dr(CI, "E3")

''//E4
Dim kgreales_empalmador4 = get_dr(CI, "E4")

''//E5
Dim kgreales_empalmador5 = get_dr(CI, "E5")




''// Sacando diferencias


''//E1
Dim dif_porc1
If (grama1 > 0) Then

Try

dif_porc1 = CStr((kgreales_empalmador1 - kgestimados_empalmador1) / kgestimados_empalmador1)

Catch ex As Exception

dif_porc1 = "-1"

End Try

Else

dif_porc1 = "-"
End If




''//E2
Dim dif_porc2
If (grama2 > 0) Then

Try

dif_porc2 = CStr((kgreales_empalmador2 - kgestimados_empalmador2) / kgestimados_empalmador2)

Catch ex As Exception

dif_porc2 = "-1"

End Try

Else

dif_porc2 = "-"
End If




''//E3
Dim dif_porc3
If (grama3 > 0) Then

Try

dif_porc3 = CStr((kgreales_empalmador3 - kgestimados_empalmador3) / kgestimados_empalmador3)

Catch ex As Exception

dif_porc3 = "-1"

End Try

Else

dif_porc3 = "-"
End If






''//E4
Dim dif_porc4
If (grama4 > 0) Then

Try

dif_porc4 = CStr((kgreales_empalmador4 - kgestimados_empalmador4) / kgestimados_empalmador4)

Catch ex As Exception

dif_porc4 = "-1"

End Try

Else

dif_porc4 = "-"
End If






''//E5
Dim dif_porc5
If (grama5 > 0) Then

Try

dif_porc5 = (kgreales_empalmador5 - kgestimados_empalmador5) / kgestimados_empalmador5

Catch ex As Exception

dif_porc5 = "-1"

End Try

Else

dif_porc5 = "-"
End If









''// Indicadores  tablero errores


''// Error  tipo papel 
Dim error_tipo = get_errortipo(CI)

''// Error  ancho papel 
Dim error_ancho = get_errorancho(CI)






''// Escaneos por  empalmador

''//E1
Dim esc_e1
If kgestimados_empalmador1 > 0 Then
esc_e1 = get_aparemp(CI, "E1")
Else
esc_e1 = ""
End If

''//E2
Dim esc_e2
If kgestimados_empalmador2 > 0 Then
esc_e2 = get_aparemp(CI, "E2")
Else
esc_e2 = ""
End If


''//E3
Dim esc_e3
If kgestimados_empalmador3 > 0 Then
esc_e3 = get_aparemp(CI, "E3")
Else
esc_e3 = ""
End If



''//E4
Dim esc_e4
If kgestimados_empalmador4 > 0 Then
esc_e4 = get_aparemp(CI, "E4")
Else
esc_e4 = ""
End If




''//E5
Dim esc_e5
If kgestimados_empalmador5 > 0 Then
esc_e5 = get_aparemp(CI, "E5")
Else
esc_e5 = ""
End If






''// falta escaneos 
Dim falta_escaneos
Dim conta_e1 = 0, conta_e2 = 0, conta_e3 = 0, conta_e4 = 0, conta_e5 = 0
If Not (esc_e1.Equals("")) Then
If (esc_e1 = 0) Then
conta_e1 = 1

Else

conta_e1 = 0

End If
End If



If Not (esc_e2.Equals("")) Then

If (esc_e2 = 0) Then
conta_e2 = 1

Else

conta_e2 = 0

End If
End If




If Not (esc_e3.Equals("")) Then
If (esc_e3 = 0) Then


conta_e3 = 1

Else

conta_e3 = 0
End If
End If




If Not (esc_e4.Equals("")) Then

If (esc_e4 = 0) Then
conta_e4 = 1

Else
conta_e4 = 0
End If
End If

If Not (esc_e5.Equals("")) Then
If (esc_e5 = 0) Then
conta_e5 = 1
Else

conta_e5 = 0
End If
End If

''// Empalmadores  falta de  escaneo
Dim empalmadores_con_falta_esc1 = "", empalmadores_con_falta_esc2 = "", empalmadores_con_falta_esc3 = "", empalmadores_con_falta_esc4 = "", empalmadores_con_falta_esc5 = ""

If Not (esc_e1.Equals("")) Then
empalmadores_con_falta_esc1 = "E1"

End If

If Not (esc_e2.Equals("")) Then
empalmadores_con_falta_esc2 = "E2"

End If

If Not (esc_e3.Equals("")) Then
empalmadores_con_falta_esc3 = "E3"

End If

If Not (esc_e4.Equals("")) Then
empalmadores_con_falta_esc4 = "E4"

End If

If Not (esc_e5.Equals("")) Then
empalmadores_con_falta_esc5 = "E5"

End If

Dim empal_falta_escaneos = empalmadores_con_falta_esc1 + "-" + empalmadores_con_falta_esc2 + "-" + empalmadores_con_falta_esc3 + "-" + empalmadores_con_falta_esc4 + "-" + empalmadores_con_falta_esc5







 falta_escaneos = conta_e1 + conta_e2 + conta_e3 + conta_e4 + conta_e5



''// Falta  de  kg

Dim falta_kg = get_faltakg(CI)


''//Diferencia_kgent_salida

Dim diferencia_kgent_salida = get_diferencia_es(CI)
Dim empalmadores_con_dif = get_empa_con_diferencia_es(CI)

''// Cambio empalmador

Dim cambio_empalmador = get_cambioempa(CI)



            inserta_semaforo(CStr(CI), CStr(data_gen(1)), CStr(data_gen(2)), CStr(data_gen(3)), CStr(data_gen(4)), CStr(data_gen(5)), kgestimados_empalmador1, kgestimados_empalmador2, kgestimados_empalmador3, kgestimados_empalmador4, kgestimados_empalmador5, kgreales_empalmador1, kgreales_empalmador2, kgreales_empalmador3, kgreales_empalmador4, kgreales_empalmador5, dif_porc5, dif_porc5, dif_porc5, dif_porc5, dif_porc5, CStr(error_tipo), CStr(error_ancho), CStr(falta_escaneos) + "/" + CStr(empal_falta_escaneos), CStr(falta_kg), CStr(diferencia_kgent_salida) + CStr(empalmadores_con_dif), CStr(cambio_empalmador))

End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return val
    End Function








  Public Shared Function get_errortipo(ByVal ci)


Dim neto_ci_empa = 0

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select * from  resumen_t where ci='" + CStr(ci) + "' and  tipo_papel_coincide = 0 "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


neto_ci_empa = neto_ci_empa + 1


End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function







  Public Shared Function get_errorancho(ByVal ci)


Dim neto_ci_empa = 0

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select * from  resumen_t where ci='" + CStr(ci) + "' and  ancho_papel_coincide = 0 "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


neto_ci_empa = neto_ci_empa + 1


End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function






  Public Shared Function get_aparemp(ByVal ci, ByVal empal)


Dim neto_ci_empa = 0

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select * from  resumen_t where ci='" + CStr(ci) + "' and  empalmador ='" + CStr(empal) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


neto_ci_empa = neto_ci_empa + 1


End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function









  Public Shared Function get_faltakg(ByVal ci)


Dim neto_ci_empa = 0

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select faltaderollo from  resumen_t where ci='" + CStr(ci) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


neto_ci_empa = neto_ci_empa + 1


End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function





  Public Shared Function get_diferencia_es(ByVal ci)


Dim neto_ci_empa = 0

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select sum(diferenci_ent_sal) from  resumen_t where ci='" + CStr(ci) + "'  and  diferenci_ent_sal > 0"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


neto_ci_empa = neto_ci_empa + 1


End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function




  Public Shared Function get_empa_con_diferencia_es(ByVal ci)


Dim neto_ci_empa = 0
Dim empalamdores_0 As String = ""
 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select * from  resumen_t where ci='" + CStr(ci) + "'  and  diferenci_ent_sal > 0"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


Dim empal = reader2.GetString(2)
empalamdores_0 = empalamdores_0 + CStr(empal)

End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function



  Public Shared Function get_cambioempa(ByVal ci)


Dim neto_ci_empa = 0

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select sum(cambio_empal_sinval) from  resumen_t where ci='" + CStr(ci) + "' "
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


neto_ci_empa = neto_ci_empa + 1


End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function








  Public Shared Function get_dr(ByVal ci, ByVal empalmador)


Dim neto_ci_empa = 0

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select SUM(kgconsumoneto) from  muestras_t where ci='" + CStr(ci) + "' and  empalmador like '" + CStr(empalmador) + "%'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas


If (reader2.GetValue(0).Equals(DBNull.Value)) Then

neto_ci_empa = 0
Else
neto_ci_empa = reader2.GetValue(0)


End If


End While


        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return neto_ci_empa
    End Function












  Public Shared Function get_papeles_empalmador(ByVal combinacion)

Dim val = 0
Dim e1p, e2p, e3p, e4p, e5p

Dim papeles_emp(6)
'MessageBox.Show("Combinacion dada:" + CStr(combinacion))
 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = epicor
            Dim mystring2 As String = "  select  * from  UD02 where Key1='" + CStr(combinacion) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0



            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas
conta = conta + 1
e1p = reader2.GetString(6)
e2p = reader2.GetString(7)
e3p = reader2.GetString(8)
e4p = reader2.GetString(9)
e5p = reader2.GetString(10)



papeles_emp(0) = CStr(combinacion)
papeles_emp(1) = e1p
papeles_emp(2) = e2p
papeles_emp(3) = e3p
papeles_emp(4) = e4p
papeles_emp(5) = e5p




End While
'MessageBox.Show("Coincidencias:" + CStr(conta))

        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return papeles_emp
    End Function








  Public Shared Function get_genericos_semaforo(ByVal CI)

Dim val = 0
 'MessageBox.Show("Iniciando get genericosd ci reciubida:" + CStr(CI) + " ok")

Dim generic_data(5)

 Try

            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = csd
            Dim mystring2 As String = "  select  * from  programado  where v4='" + CStr(CI) + "'"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()
            Dim conta As Integer = 0
Dim CIa, calidad, flauta, longitud, ancho, pedido


            ''Para cada registro de muestras
             While reader2.Read()

''// Almacena  variables leidas
conta = conta + 1
CIa = reader2.GetString(0)
calidad = reader2.GetString(1)
flauta = reader2.GetString(2)
longitud = reader2.GetValue(3)
ancho = reader2.GetValue(4)
pedido = reader2.GetValue(5)




generic_data(0) = CIa
generic_data(1) = calidad
generic_data(2) = flauta
generic_data(3) = longitud
generic_data(4) = ancho
generic_data(5) = pedido




End While
'MessageBox.Show(" coincidencias genericos :" + CStr(conta))

        Catch a As Exception
            MessageBox.Show(" Integra res" + a.ToString())
        End Try

Return generic_data
    End Function













Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

End Sub
End Class


