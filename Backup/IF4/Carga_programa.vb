Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Carga_programa

    Dim pro

    Dim Cmd As New OleDbCommand("Select * From [A3:H]")
    Dim Ds As New DataSet
    Dim Da As New OleDbDataAdapter
    Dim Dt As New DataTable






    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



      Dim stRuta As String = ""
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                stRuta = .FileName
            End If
        End With
        Try
            Dim stConexion As String

            stConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (stRuta & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))


            Dim cnConex As New OleDbConnection(stConexion)
            cnConex.Open()
            Cmd.Connection = cnConex
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            Dt = Ds.Tables(0)

            Me.DataGridView1.DataSource = Dt

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ---")
            Exit Sub
        End Try









               
              Dim headerText = DataGridView1.Columns(5).HeaderText


               
'MessageBox.Show("Archivo con :" + CStr(headerText))



If (headerText.Equals("ID Pedido CI Inferior")) Then

Me.Button3.Enabled = True

End If


If (headerText.Equals("ID Pedido CI Superior")) Then

Me.Button2.Enabled = True

End If











    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

       






    End Sub

    

    Private Function ExecuteAction(ByVal cmd As SqlCommand) As Integer

        If (cmd Is Nothing) Then _
            Throw New ArgumentNullException()

        Try
            Using cnn As New SqlConnection("Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*")

                cmd.Connection = cnn

                cnn.Open()

                Return cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw

        End Try

    End Function


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim contador As Integer
        Dim KEY, CI_K, F_K, M_K
        Try
            ' Recorremos las filas existentes en el control DataGridView
            '
            For Each row As DataGridViewRow In Me.DataGridView1.Rows

                ' Si se trata de la fila de nuevos registros, pasamos
                ' a la siguiente fila.
                '

                If (row.IsNewRow) Then Continue For

                ' Creamos el comando
                Dim cmd As New SqlCommand()

                ' Creamos la consulta T-SQL de datos añadidos
                cmd.CommandText = _
                    "INSERT INTO Programado  VALUES " & _
                    "(@ValorCampo1,@ValorCampo2,@ValorCampo3,@ValorCampo4,@ValorCampo5,@ValorCampo6,@ValorCampo7,@ValorCampo8,null,null,null,@ValorCampo10,@ValorCampo9)"

                ' Valor de la columna Campo1. Se comprende que es
                ' la clave principal de la tabla, por lo que no puede
                ' contener valores NULL.
                '
                Dim value As Object = row.Cells("Nro# CI").Value

                CI_K = row.Cells("Nro# CI").Value

'CI_K = Replace(CI_K, " ", "")

Dim ci_format = Trim(CI_K)

                If ((value Is DBNull.Value) Or (value = "N/A")) Then
                    'MessageBox.Show("El valor de la clave principal no puede ser NULL.  o  na ")

                Else



                'If (value Is DBNull.Value) Then
                'MessageBox.Show("El valor de la clave principal no puede ser NULL.")
                'Return
                'End If

                ' Añadimos el parámetro a la colección Parameters del objeto Command.
                '
                cmd.Parameters.AddWithValue("@ValorCampo1", ci_format)

                ' Valor de la columna Campo2
                '
                value = row.Cells("Calidad CI").Value
                cmd.Parameters.AddWithValue("@ValorCampo2", Trim(value))

                ' Valor de la columna Campo3
                '
                value = row.Cells("~Flute").Value
                cmd.Parameters.AddWithValue("@ValorCampo3", Trim(value))


                ' Valor de la columna Campo4
                '
                value = row.Cells("Longitud CI").Value
                cmd.Parameters.AddWithValue("@ValorCampo4", value)


                ' Valor de la columna Campo5
                '
                value = row.Cells("Ancho Papel CI").Value
                cmd.Parameters.AddWithValue("@ValorCampo5", value)



                ' Valor de la columna Campo6
                '
                value = row.Cells("ID Pedido CI Inferior").Value
                cmd.Parameters.AddWithValue("@ValorCampo6", Trim(value))



                ' Valor de la columna Campo7
                '
                value = row.Cells("Id Máquina").Value
                cmd.Parameters.AddWithValue("@ValorCampo7", value)
                M_K = row.Cells("Id Máquina").Value
M_K = Replace(M_K, "_", "")
                ' Valor de la columna Campo8
                '
                value = CDate(row.Cells("StartLoadDate").Value)
                cmd.Parameters.AddWithValue("@ValorCampo8", value)

F_K = CStr(row.Cells("StartLoadDate").Value)



F_K = Replace(F_K, "-", "")
F_K = Replace(F_K, ".", "")
F_K = Replace(F_K, ":", "")
F_K = Replace(F_K, "/", "")
F_K = Replace(F_K, " ", "")



KEY = CStr(M_K) + CStr(CI_K) + CStr(F_K)
value = KEY
cmd.Parameters.AddWithValue("@ValorCampo9", value)
cmd.Parameters.AddWithValue("@ValorCampo10", ci_format)



 ExecuteAction(cmd)
                contador = contador + 1

End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        MessageBox.Show(CStr(contador) + " Registros nuevos")
        Me.Close()


    End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
Dim contador As Integer
Dim KEY, CI_K, F_K, M_K
        Try
          
            For Each row As DataGridViewRow In Me.DataGridView1.Rows

               

                If (row.IsNewRow) Then Continue For


                Dim cmd As New SqlCommand()
'MessageBox.Show("4")
                ' Creamos la consulta T-SQL de datos añadidos
                cmd.CommandText = _
                    "INSERT INTO Programado  VALUES " & _
                    "(@ValorCampo1,@ValorCampo2,@ValorCampo3,@ValorCampo4,@ValorCampo5,@ValorCampo6,@ValorCampo7,@ValorCampo8,null,null,null,@ValorCampo10,@ValorCampo9)"

                ' Valor de la columna Campo1. Se comprende que es
                ' la clave principal de la tabla, por lo que no puede
                ' contener valores NULL.
                '

'MessageBox.Show("5")
                Dim value As Object = row.Cells("Nro# CI").Value

 CI_K = row.Cells("Nro# CI").Value
'CI_K = Replace(CI_K, " ", "")
Dim ci_format = Trim(CI_K)

                If ((value Is DBNull.Value) Or (value = "N/A")) Then
                    'MessageBox.Show("El valor de la clave principal no puede ser NULL.  o  na ")

                Else


                'If (value Is DBNull.Value) Then
                'MessageBox.Show("El valor de la clave principal no puede ser NULL.")
                'Return
                'End If

                ' Añadimos el parámetro a la colección Parameters del objeto Command.
                '

'MessageBox.Show("6")
                cmd.Parameters.AddWithValue("@ValorCampo1", ci_format)

                ' Valor de la columna Campo2
                '
                value = row.Cells("Calidad CI").Value
                cmd.Parameters.AddWithValue("@ValorCampo2", Trim(value))

                ' Valor de la columna Campo3
                '


                value = row.Cells("~Flute").Value
                cmd.Parameters.AddWithValue("@ValorCampo3", Trim(value))


                ' Valor de la columna Campo4
                '
                value = row.Cells("Longitud CI").Value
                cmd.Parameters.AddWithValue("@ValorCampo4", value)


                ' Valor de la columna Campo5
                '
                value = row.Cells("Ancho Papel CI").Value
                cmd.Parameters.AddWithValue("@ValorCampo5", value)



                ' Valor de la columna Campo6
                '
                value = row.Cells("ID Pedido CI Superior").Value
                cmd.Parameters.AddWithValue("@ValorCampo6", Trim(value))



                ' Valor de la columna Campo7
                '
                value = row.Cells("Id Máquina").Value
                cmd.Parameters.AddWithValue("@ValorCampo7", value)
  M_K = row.Cells("Id Máquina").Value
M_K = Replace(M_K, "_", "")

                ' Valor de la columna Campo8
                '
                value = CDate(row.Cells("StartLoadDate").Value)
                cmd.Parameters.AddWithValue("@ValorCampo8", value)





F_K = CStr(row.Cells("StartLoadDate").Value)
F_K = Replace(F_K, "-", "")
F_K = Replace(F_K, ".", "")
F_K = Replace(F_K, ":", "")
F_K = Replace(F_K, "/", "")
F_K = Replace(F_K, " ", "")

KEY = CStr(M_K) + CStr(CI_K) + CStr(F_K)
value = KEY
cmd.Parameters.AddWithValue("@ValorCampo9", value)
cmd.Parameters.AddWithValue("@ValorCampo10", ci_format)

                ' Ejecutamos el comando
                '
                ExecuteAction(cmd)
                contador = contador + 1

End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message + "  IF4 " + ex.ToString)

        End Try

        MessageBox.Show(CStr(contador) + " Registros nuevos")
        Me.Close()

End Sub
End Class
