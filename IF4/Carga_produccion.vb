Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Carga_produccion

    Dim pro

    Dim Cmd As New OleDbCommand("Select * From [B3:M]")
    Dim Ds As New DataSet
    Dim Da As New OleDbDataAdapter
    Dim Dt As New DataTable






    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  Try
'MessageBox.Show("1")
Dim stRuta As String = ""
        Dim openFD As New OpenFileDialog()
'MessageBox.Show("2")
 With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls)|*.xls"
            .Multiselect = False
'MessageBox.Show("3")
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                stRuta = .FileName
            End If
'MessageBox.Show("4")
        End With

'MessageBox.Show("--:" + CStr(openFD.FileName))

'MessageBox.Show("5")
        Dim stConexion As String
'MessageBox.Show("6")




            stConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (stRuta & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))

           ' stConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myExcel2007file.xlsx;Extended Properties="Excel 12.0 Xml;HDR=YES";



'MessageBox.Show("7")
            Dim cnConex As New OleDbConnection(stConexion)
            cnConex.Open()
'MessageBox.Show("8")
            Cmd.Connection = cnConex
'MessageBox.Show("9")
            Da.SelectCommand = Cmd
'MessageBox.Show("10")
            Da.Fill(Ds)
'MessageBox.Show("11")
            Dt = Ds.Tables(0)
'MessageBox.Show("12")

            Me.DataGridView1.DataSource = Dt
'MessageBox.Show("13")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error , revise  el archivo")
        End Try






              Dim headerText = DataGridView1.Columns(3).HeaderText



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
                    "INSERT INTO Produccion  VALUES " & _
                    "(@ValorCampo1, @ValorCampo2, @ValorCampo3,@ValorCampo4, @ValorCampo5, @ValorCampo6,@ValorCampo7, @ValorCampo8,@ValorCampo9,@ValorCampo10,@ValorCampo11,@ValorCampo12,@ValorCampo14,null,null,null,@ValorCampo13)"

                ' Valor de la columna Campo1. Se comprende que es
                ' la clave principal de la tabla, por lo que no puede
                ' contener valores NULL.
                '
                Dim value As Object = row.Cells("Nro# CI").Value

                If ((value Is DBNull.Value) Or (value = "N/A")) Then
                    'MessageBox.Show("El valor de la clave principal no puede ser NULL.  o  na ")

                Else

                    ' Añadimos el parámetro a la colección Parameters del objeto Command.
                    '


  Dim CLAVE = row.Cells("Nro# CI").Value

                   ' MessageBox.Show("CI:" + CLAVE.ToString)




                    Dim consecutivo As Integer = metodos.get_maximo() + 1

                    CLAVE = CStr(CLAVE) + CStr(consecutivo)

                    'MessageBox.Show("clave:" + CLAVE)
                    cmd.Parameters.AddWithValue("@ValorCampo1", value)

                    ' Valor de la columna Campo2
                    '
                    value = row.Cells("Calidad CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo2", value)

                    ' Valor de la columna Campo3
                    '
                    value = row.Cells("~Flute").Value
                    cmd.Parameters.AddWithValue("@ValorCampo3", value)


                    ' Valor de la columna Campo4
                    '

                   ' Valor de la columna Campo4
                    '
If (row.Cells("ID Pedido CI Inferior").Value Is DBNull.Value) Then
value = " "
Else
                    value = row.Cells("ID Pedido CI Inferior").Value
End If


                    cmd.Parameters.AddWithValue("@ValorCampo4", value)


                    ' Valor de la columna Campo5
                    '
                    value = row.Cells("Ancho Papel CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo5", value)



                    ' Valor de la columna Campo6
                    '
                    value = row.Cells("Longitud CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo6", value)



                    ' Valor de la columna Campo7
                    '
                    value = row.Cells("~Multiplicity lower").Value
                    cmd.Parameters.AddWithValue("@ValorCampo7", value)


                    ' Valor de la columna Campo8
                    '
                    Dim valor = row.Cells("~Width lower").Value

                    'MessageBox.Show("width:" + CStr(valor))


If valor Is DBNull.Value Then

valor = "0"

End If



                    If (CStr(valor).Equals("")) Then

                    value = "0"


                    Else
value = row.Cells("~Width lower").Value

End If
                    cmd.Parameters.AddWithValue("@ValorCampo8", value)


                    ' Valor de la columna Campo9
                    '
                    value = row.Cells("~Trim").Value
                    cmd.Parameters.AddWithValue("@ValorCampo9", value)


                    ' Valor de la columna Campo10
                    '
                    value = row.Cells("Estado CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo10", value)


                    ' Valor de la columna Campo11
                    '
                    value = CDate(row.Cells("StartLoadDate").Value)
                    cmd.Parameters.AddWithValue("@ValorCampo11", value)


                    ' Valor de la columna Campo12
                    '
                    value = CDate(row.Cells("EndLoadDate").Value)
                    cmd.Parameters.AddWithValue("@ValorCampo12", value)

cmd.Parameters.AddWithValue("@ValorCampo14", consecutivo)
cmd.Parameters.AddWithValue("@ValorCampo13", CLAVE)



                    ' Ejecutamos el comando
                    '
                    ExecuteAction(cmd)
                    contador = contador + 1
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

        MessageBox.Show(CStr(contador) + " Registros nuevos")
        Me.Close()


    End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
 Dim contador As Integer
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
                    "INSERT INTO Produccion  VALUES " & _
                    "(@ValorCampo1, @ValorCampo2, @ValorCampo3,@ValorCampo4, @ValorCampo5, @ValorCampo6,@ValorCampo7, @ValorCampo8,@ValorCampo9,@ValorCampo10,@ValorCampo11,@ValorCampo12,@ValorCampo14,null,null,null,@ValorCampo13)"

                ' Valor de la columna Campo1. Se comprende que es
                ' la clave principal de la tabla, por lo que no puede
                ' contener valores NULL.
                '
                Dim value As Object = row.Cells("Nro# CI").Value

                If ((value Is DBNull.Value) Or (value = "N/A") Or (value.ToString.Length < 2) Or (value.ToString.StartsWith("se terminaron"))) Then
                    'MessageBox.Show("El valor de la clave principal no puede ser NULL.  o  na ")

                Else

                    ' Añadimos el parámetro a la colección Parameters del objeto Command.
                    '

                    Dim CLAVE = row.Cells("Nro# CI").Value

                   ' MessageBox.Show("CI:" + CLAVE.ToString)




                    Dim consecutivo As Integer = metodos.get_maximo() + 1

                    CLAVE = CStr(CLAVE) + CStr(consecutivo)

                    'MessageBox.Show("clave:" + CLAVE)

                    cmd.Parameters.AddWithValue("@ValorCampo1", value)

                    ' Valor de la columna Campo2
                    '
                    value = row.Cells("Calidad CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo2", value)

                    ' Valor de la columna Campo3
                    '
                    value = row.Cells("~Flute").Value
                    cmd.Parameters.AddWithValue("@ValorCampo3", value)


                    ' Valor de la columna Campo4
                    '
If (row.Cells("ID Pedido CI Superior").Value Is DBNull.Value) Then
value = " "
Else
              value = row.Cells("ID Pedido CI Superior").Value

End If

                    cmd.Parameters.AddWithValue("@ValorCampo4", value)




                    ' Valor de la columna Campo5
                    '
                    value = row.Cells("Ancho Papel CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo5", value)



                    ' Valor de la columna Campo6
                    '
                    value = row.Cells("Longitud CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo6", value)



                    ' Valor de la columna Campo7
                    '
                    value = row.Cells("~Multiplicity upper").Value
                    cmd.Parameters.AddWithValue("@ValorCampo7", value)


                    ' Valor de la columna Campo8
                    '
                 ' Dim valor = row.Cells("~Width upper").Value



                    If (row.Cells("~Width upper").Value Is DBNull.Value) Then
                    ' MessageBox.Show("si nulo:")
                    value = 0
                   Else
                    'MessageBox.Show("no  nulo:")
                  'MessageBox.Show("distancia:" + CStr(row.Cells("~Width upper").Value))





                        If (CStr(row.Cells("~Width upper").Value).Equals("")) Then
                        value = 0
                        Else
                        value = row.Cells("~Width upper").Value
                        End If
                        'MessageBox.Show("value:" + CStr(value))
                    End If


                    cmd.Parameters.AddWithValue("@ValorCampo8", value)


                    ' Valor de la columna Campo9
                    '
                    value = row.Cells("~Trim").Value
                    cmd.Parameters.AddWithValue("@ValorCampo9", value)


                    ' Valor de la columna Campo10
                    '
                    value = row.Cells("Estado CI").Value
                    cmd.Parameters.AddWithValue("@ValorCampo10", value)


                    ' Valor de la columna Campo11
                    '
                    value = CDate(row.Cells("StartLoadDate").Value)
                    cmd.Parameters.AddWithValue("@ValorCampo11", value)
'MessageBox.Show("3")

                    ' Valor de la columna Campo12
                    '
                    value = CDate(row.Cells("EndLoadDate").Value)
'MessageBox.Show("4")
                    cmd.Parameters.AddWithValue("@ValorCampo12", value)

'MessageBox.Show("5")
                    cmd.Parameters.AddWithValue("@ValorCampo14", consecutivo)
                    cmd.Parameters.AddWithValue("@ValorCampo13", CLAVE)

                    ' Ejecutamos el comando
                    '
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
End Class
