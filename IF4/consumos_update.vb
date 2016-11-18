Imports System.Data.SqlClient
Public Class consumos_update
    Shared DirDelLog As String = "\\SER-VIRTUALES\DataRecordCons" + "\ICR.txt"

    Public Shared Sub ErrorLog(ByVal sPathName As String, ByVal sErrMsg As String)
        Try
            Dim sYear As String = DateTime.Now.Year.ToString()
            Dim sMonth As String = DateTime.Now.Month.ToString()
            Dim sDay As String = DateTime.Now.Day.ToString()
            Dim sErrorTime = sYear + sMonth + sDay

            Dim sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> "

            Dim sw As System.IO.StreamWriter = New System.IO.StreamWriter(sPathName.Replace(".", "" + sErrorTime + "."), True)
            sw.WriteLine(sLogFormat + sErrMsg)
            sw.Flush()
            sw.Close()

        Catch ex As Exception
            Dim fi As System.IO.FileInfo = New System.IO.FileInfo(sPathName)
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
            ErrorLog(sPathName, sErrMsg)
        End Try

    End Sub





    Public Shared Sub Log(ByVal sPathName As String, ByVal sMsg As String, Optional ByVal MostrarMsgBox As Boolean = True, Optional ByVal TipoDeMsgBox As MessageBoxIcon = MessageBoxIcon.Information)
        ErrorLog(sPathName, sMsg)
        If (MostrarMsgBox = True) Then
            MessageBox.Show(sMsg, "Cuadro de Mensajes", MessageBoxButtons.OK, TipoDeMsgBox)
        End If
    End Sub

    Private Sub consumos_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetConsumos.Consumos' Puede moverla o quitarla según sea necesario.


        Me.ConsumosTableAdapter1.Fill(Me.DataSetConsumos.Consumos)

    End Sub



    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        If ((Me.KginicialesTextBox.Text = Me.KginicialesLabel2.Text) And (Me.KgFinalesTextBox.Text = Me.KgFinalesLabel2.Text)) Then

        Else


            Dim ThisMoment As DateTime
            

            Dim s As String
            s = ThisMoment.ToShortDateString + " " + ThisMoment.ToLongTimeString


            Dim s23 As String = Format(CDate(Me.Fecha_consumoDateTimePicker.Value), "yyyy-MM-dd  HH:mm:ss")

            Dim fecha_clave As String = s23 + ".000"
            'MessageBox.Show("CADENA: " + fecha_clave)




            metodos.update_cons(Me.KginicialesTextBox.Text, Me.KgFinalesTextBox.Text, Me.EmpalmadorComboBox.Text, fecha_clave)

            Log(DirDelLog, String.Format("//" + Me.Fecha_consumoDateTimePicker.Text + "*" + RTrim(Me.No_ciTextBox.Text) + "*" + Me.No_pedido_otTextBox.Text + "*" + Me.RolloTextBox.Text + ">B:" + Me.KginicialesLabel2.Text + " N:" + Me.KginicialesTextBox.Text + " B2:" + Me.KgFinalesLabel2.Text + " N2:" + Me.KgFinalesTextBox.Text + "//" + My.Settings.StrUser), False)

            MessageBox.Show("Cambio Registrado")
        End If
    End Sub

Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems

End Sub
End Class