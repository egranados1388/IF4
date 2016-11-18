Imports System.Data.SqlClient
Public Class vista_evaluacion_real
Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean
Private Sub vista_evaluacion_teorica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("SELECT CI,OT,longitud_m as longitud_estimada_m ,empalmador,parte,rollo  as Lote_Rollo,calidad_flauta as calidad ,Ancho_m as AnchoRollo_m,kginiciales,kgifinales as kgsaldo,fecha_consumo as Fecha_ini, v2 as  ancho_lam , v1 as   cortes,maquina as Linea_Prod,gramaje,factor_flauta, V as ancho_rollos_usado,w as  ancho_utilizable,x as trim, y as porcentaje_papel_usado,kgrequeridosCIempalmador,kgescaneados,kgconsumoDisponiblelote,Rollosxci,kgconsumoasignado,kgdisponiblerollo,kgreqci1rollo,kgconsdisponible,consumosmismorollo, kgreqrolloinicial,kgdispxrollo2,kgfaltantesCI,kgrequeydispxrollo,kgconsumodisponible3,kgfaltantesCI2,kgconsumoci4,proporcionci,CICONSUMOSXROLLO,cisacumulado,kgconsumofinalci,kgconsumoneto,z as consumo_ot      from muestras_r", DataGridView1)


 'cargar_registros("SELECT * from       muestras_r", DataGridView1)



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


    End Sub


End Class