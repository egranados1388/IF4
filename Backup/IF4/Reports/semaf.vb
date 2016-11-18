
Imports System.Data.SqlClient
Public Class semaf

    'BindingSource  
    Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean


    Private Sub programas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       ' Me.ToolTip1.SetToolTip(Me.Button3, "Eliminar  el registro actual")
        With DataGridView2
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("Select * From semaforos", DataGridView2)




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


           If (CDbl(row.Cells(7).Value) > 10) Then

                    row.DefaultCellStyle.BackColor = Color.Yellow

Else

If (CDbl(row.Cells(7).Value) < -10) Then

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
End Class