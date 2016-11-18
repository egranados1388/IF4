
Imports System.Data.SqlClient
Public Class Produccion2

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
        cargar_registros("Select * From  Produccion order  by fecha_inicio_prod  desc", DataGridView1)




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
           ' Dim actual As String = row.Cells(0).Value.ToString
           ' Dim actual_fecha As Date = row.Cells(7).Value
            'MessageBox.Show("Actual:" + actual)

''// CI
 Dim actual As String = row.Cells(0).Value.ToString
 ''//numero
Dim actual_fecha As Integer = CInt(row.Cells(12).Value)


Dim ot As String = row.Cells(3).Value.ToString

 Dim fechaini As String = Format(CDate(row.Cells(10).Value.ToString), "yyyy-MM-dd  HH:mm:ss.fff")
'MessageBox.Show("ot. " + ot.ToString + " fechaini :" + fechaini.ToString)




            Dim duplicado_ci As Integer = metodos.valida_produccion(ot, fechaini)

            Dim fechamax_obsoleta As Integer = metodos.valida_produccion_duplicate_2(actual)


           ' MessageBox.Show("DUPLICAOD:" + duplicado_ci.ToString)
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
                cargar_registros("Select * From Produccion", DataGridView1)
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
End Class