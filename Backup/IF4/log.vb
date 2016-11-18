
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class log

    Dim da As SqlDataAdapter
    Dim cn As New SqlConnection("Data Source=172.16.1.11;Initial Catalog=IF4;Integrated Security=True")
    Dim cmd As SqlCommand

    Dim dt As DataTable
    Dim dr As DataRow



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try

            'cmd.CommandType = CommandType.Text
            'cmd.CommandText = "Select * From usuarios where idsuario_usuariomail='@Usuario' and passwd='@Contraseña'"
            'cmd.Connection = cn
            'cmd.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar)).Value = UsernameTextBox.Text
            'cmd.Parameters.Add(New SqlParameter("@Contraseña", SqlDbType.NVarChar)).Value = PasswordTextBox.Text





            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"
            Dim mystring2 As String = "Select * From usuarios where idusuario_usuariomail='" + CStr(Me.UsernameTextBox.Text) + "' and passwd='" + CStr(Me.PasswordTextBox.Text) + "'"

            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            Dim conta As Integer = 0
            Dim ger As Integer
            While reader2.Read()
                conta = conta + 1
                ger = reader2.GetInt32(2)
            End While

           

            If conta = 1 Then


                My.Settings.StrUser = UsernameTextBox.Text
                My.Settings.StrPass = PasswordTextBox.Text
                My.Settings.intJer = ger
                My.Settings.Save()
                My.Settings.Reload()

                ' MessageBox.Show("BienVenido " + My.Settings.StrUser + "/" + CStr(My.Settings.intJer), "Aviso")
                Index.Show()
                Me.Hide()
            Else
                MessageBox.Show("Contraseña O Usuario InCorrecto")
            End If
        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)
        Finally
            'Cmd.Parameters.Clear()
        End Try





    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UsernameTextBox.Text = My.Settings.StrUser

        PasswordTextBox.Text = My.Settings.StrPass


       

    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub
End Class
