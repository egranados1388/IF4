''// Formulario de  evaluacion de  consumo teorico

Imports System
Imports IF4_1
Imports System.Data.SqlClient
''// Comienzo de  clase  de formualrio
Public Class Evaluar
'BindingSource  
    Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean




''//Al cargar formulario evaluar
    Private Sub Evaluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'TODO: esta línea de código carga datos en la tabla 'DSConjuntoTablasIF4.muestras_t' Puede moverla o quitarla según sea necesario.
'Me.Muestras_tTableAdapter.Fill(Me.DSConjuntoTablasIF4.muestras_t)
'MessageBox.Show("Comenzando evaluacion de  consumo teorico")

        ''////Definicion de  periodo  de consumo  a  evaluar

        Dim strDOB As String ''// Fecha  inicial
        Dim res As Integer
        strDOB = InputBox("Fecha Inicial evaluacion", _
        "IF4 ", _
        "DD/MM/AA")


        Dim strDOB2 As String ''// Fecha  final


        ''Tratandose de  un fecha  valida de inicio
        If IsDate(strDOB) Then


            ''// Definiciendo fecha final
            strDOB2 = InputBox("Fecha Final evaluacion", _
            "IF4 ", _
            "DD/MM/AA")

            ''// Fecha final  valida??
            If IsDate(strDOB2) Then
'MessageBox.Show("Rango de  validacion del " + CStr(strDOB) + " al " + CStr(strDOB2))
                ''//Periodo correctamente  definido . Inicio de  calculos   

                Calculos_teorico.clean_dbayuda() ''-----// Se borra  el historico de muestras_t  para  mejorar  rendimiento y evitar  confusiones
                resumen_metods.clean_resumen()

               ' MessageBox.Show("Calculos  y resumen limpiados")

                Calculos_teorico.carga_resultados(strDOB, strDOB2) ''-----Ciclo 1  conjuncion datos consumo-programa.carga  de datos  solo del periodo a  evaluar y primeros  calculos
               ' MessageBox.Show("calculos  teoricos  fase 1 (conjuncion datos  programa-consumo) y resumen datos genericos")



 Calculos_teorico.carga_resultados_second() ''-----Ciclo 2 de calculos
 ' MessageBox.Show("calculos  teoricos  fase 2 datos basados en muestras t  calculo 1 ")



Calculos_teorico.carga_resultados_third() ''-----Ciclo 3 de calculos
'MessageBox.Show("calculos  teoricos  fase 3 datos basados en muestras t  calculo 1 y 2 ")




Calculos_teorico.carga_resultados_fourth() ''-----Ciclo 4 y final  de calculos
'MessageBox.Show("calculos  teoricos  fase 4 final datos basados en muestras t  calculo 1 , 2  y 3")


''// comenzando a  actualizar  resumen teniendo calculos completos
''// despues de integra  resumen implicito en  carga_resultados

resumen_metods.actualiza_resumen()
'MessageBox.Show("Actualizado resumen")

resumen_metods.actualiza_resumen2()

'MessageBox.Show("Actualizado resumen 2")






            ''// Fecha  final invalida
            Else
                MsgBox("Se  necesita  una  fecha  final  valida", _
                       MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, _
                       "Error")

            End If ''// Fin if  fecha  final

        ''// Si no hay fecha inicial valida
        Else
            MsgBox("Se  necesita  una  fecha de  inicio  valida", _
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, _
                   "Error")
            res = 0

        End If ''// Fin if  fecha  inicial




With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        'cargar_registros("SELECT CI,OT,longitud_m as longitud_estimada_m ,empalmador,parte,rollo  as Lote_Rollo,calidad_flauta as calidad ,Ancho_m as AnchoRollo_m,kginiciales,kgifinales as kgsaldo,fecha_consumo,maquina as Linea_Prod,gramaje,factor_flauta, kgrequeridosCIempalmador,kgescaneados,kgconsumoDisponiblelote,Rollosxci,kgconsumoasignado,kgdisponiblerollo,kgreqci1rollo,kgconsdisponible,consumosmismorollo, kgreqrolloinicial,kgdispxrollo2,kgfaltantesCI,kgrequeydispxrollo,kgconsumodisponible3,kgfaltantesCI2,kgconsumoci4,proporcionci,CICONSUMOSXROLLO,cisacumulado,kgconsumofinalci,kgconsumoneto,KGREQDISPONROLLOFINAL      from muestras_t", DataGridView1)

Me.Close()

    End Sub ''// Fin carga  de  formulario





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

        
    End Sub



End Class