Imports System.Data.SqlClient

Public Class resumen_ct
Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexi�n  
    Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean
Private Sub resumen_ct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("SELECT  [indice],rtrim([ci]) as  CI,[empalmador],[rollo],[feche_consumo],[tipo_papel_coincide],[ancho_papel_coincide],[Consecutivo_aparicion] ,[Correccion_kg_negativos]   ,[capturasduplicadas],[cicapturaduplicada] ,[kginicialescuentacum] ,[entradas_salidas] ,[tienekgsalida],[ent_sal_kgsalida] ,[respuesta] ,[cisinerror] ,[faltaderollo] ,[rolloescaneadoynousado],[parte_lote],[ultimokgsalida],[diferenci_ent_sal] ,[kginicialescuenta] ,[kgfinalescuenta] ,[diferenciaenultimokgsalidaafecta] ,[ci_dif_ent_sal],[ultimo_emp_re] ,[cambio_empal_sinval] ,[ci_error_]  ,[kginicialesduplic] ,[ci_error2] FROM [IF4].[dbo].[resumen_t]", Me.DataGridView1)



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