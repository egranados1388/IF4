
Imports System.Data.SqlClient
Public Class programas

    'BindingSource  
    Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean


    Private Sub programas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.Button3, "Eliminar  el registro actual")
        With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        'cargar_registros("Select rtrim(*) From Programado Order by fecha_hora_programada asc", DataGridView1)

        cargar_registros("SELECT  rtrim([ci_instruccioncorrugadora]) as CI       ,rtrim([calidad]) as calidad      ,rtrim ([flauta]) as flauta      ,[longitud_pedido_mm]      ,[ancho_pedido_mm]      ,rtrim([no_pedido_ot]) as ot      ,[id_maquina_prod]      ,[fecha_hora_programada]      ,[v1]      ,[v2]      ,[v3]      ,[v4]      ,[v5]  FROM [IF4].[dbo].[Programado] order  by fecha_hora_programada desc", DataGridView1)



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

        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            '' Valor  fila  actual recorrido
            Dim actual As String = row.Cells(0).Value.ToString
            Dim actual_fecha As Date = row.Cells(7).Value
            'MessageBox.Show("Actual:" + actual)


            Dim duplicado_ci As Integer = metodos.valida_programado_duplicate_(actual)
            Dim fechamax_obsoleta As Date = metodos.get_min_fecha(actual)


            'MessageBox.Show("Actual:" + actual)
            If (duplicado_ci = 1) Then

                If (fechamax_obsoleta = actual_fecha) Then

                    row.DefaultCellStyle.BackColor = Color.Red
                Else

                    row.DefaultCellStyle.BackColor = Color.Yellow
                End If
            End If



        Next

    End Sub


    Private Sub Actualizar(Optional ByVal bCargar As Boolean = True)
        ' Actualizar y guardar cambios  

        If Not bs.DataSource Is Nothing Then
            SqlDataAdapter.Update(CType(bs.DataSource, DataTable))
            If bCargar Then
               cargar_registros("SELECT  rtrim([ci_instruccioncorrugadora]) as CI       ,rtrim([calidad]) as calidad      ,rtrim ([flauta]) as flauta      ,[longitud_pedido_mm]      ,[ancho_pedido_mm]      ,rtrim([no_pedido_ot]) as ot      ,[id_maquina_prod]      ,[fecha_hora_programada]      ,[v1]      ,[v2]      ,[v3]      ,[v4]      ,[v5]  FROM [IF4].[dbo].[Programado]", DataGridView1)

            End If
        End If
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim estaci As String = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString
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


Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


 Dim estaci As String = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString
'MessageBox.Show("ok")

        'MessageBox.Show("CI a eliminar:" + estaci)
        Dim consumo_previo_this_CI As Integer = metodos.consumo_existe(estaci)

        If (consumo_previo_this_CI = 1) Then



           Dim response = MsgBox("Esta CI ya contiene  consumos registrados Desea Continuar?", MsgBoxStyle.OkCancel, "Aviso")
            If response = MsgBoxResult.Ok Then
               If Not bs.Current Is Nothing Then
                    ' eliminar

'Dim conf = MsgBox("El registro sera  eliminado permanentemente , desea  continuar?", MsgBoxStyle.OkCancel, "Aviso")
'If conf = MsgBoxResult.Ok Then
                    bs.RemoveCurrent()

                    'Guardar los cambios y recargar  
                    Actualizar()
                     'MsgBox("El registro ha sido eliminado")
'Else
'Exit Sub

'End If



                Else
                    MsgBox("No hay un registro actual para eliminar", _
                           MsgBoxStyle.Exclamation, _
                           "Eliminar")
                End If


            End If

        Else


            If Not bs.Current Is Nothing Then
                ' eliminar  
                bs.RemoveCurrent()

                'Guardar los cambios y recargar 

'Dim conf = MsgBox("El registro sera  eliminado permanentemente , desea  continuar?", MsgBoxStyle.OkCancel, "Aviso")
'If conf = MsgBoxResult.Ok Then

                Actualizar()
                 'MsgBox("El registro ha sido eliminado")

'Else

'Exit Sub
'End If

            Else
              MsgBox("No hay un registro actual para eliminar", _
                   MsgBoxStyle.Exclamation, _
                     "Eliminar")
            End If


        End If
End Sub
End Class