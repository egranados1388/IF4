
Imports System.Data.SqlClient
Public Class produccion

   ' Private MiConexion As New SqlConnection("Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*")
    'Private MiAdaptador As New SqlDataAdapter("Select * From Produccion Order by fecha_final_prod", MiConexion)
    'Private MiDataSet As New DataSet()
    'Private MiEnlazador As New BindingSource



 'BindingSource  
    Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean




    Private Sub programas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load






 'Me.ToolTip1.SetToolTip(Me.Button3, "Eliminar  el registro actual")
        With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("Select * From Produccion ", DataGridView1)







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
Dim conta_filas = 0
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
        conta_filas = conta_filas + 1
        '' Valor  fila  actual recorrido
        Dim CI_avalidar As String = row.Cells(0).Value.ToString
        
        Dim no_actual As String = row.Cells(12).Value.ToString
        'MessageBox.Show("validando fila :" + conta_filas.ToString + " con ci:" + CI_avalidar)


Dim ot As String = row.Cells(3).Value.ToString
Dim fechaini As String = row.Cells(10).Value.ToString


        Dim duplicado_ci = metodos.valida_produccion(ot, fechaini)
       ' MessageBox.Show("duplicado:" + CStr(duplicado_ci))

            If (duplicado_ci = 1) Then


                    Dim NO_duplicado_ci_2 As Integer = metodos.valida_produccion_duplicate_(CI_avalidar)
                    Dim NO_duplicado_ci_1 As Integer = metodos.valida_produccion_duplicate_2(CI_avalidar)


                  '  MessageBox.Show("miembros  duplicados:  " + NO_duplicado_ci_1.ToString + " y " + NO_duplicado_ci_2.ToString)

                        If (NO_duplicado_ci_1 = no_actual) Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        End If

                        If (NO_duplicado_ci_2 = no_actual) Then
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
DataGridView1.Refresh()
                cargar_registros("Select * From Produccion ", DataGridView1)
            End If
        End If
    End Sub


Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

 
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




End Sub
End Class