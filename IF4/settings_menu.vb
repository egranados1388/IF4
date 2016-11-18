

Imports System.Data.Odbc ''//Libreria metodos para conexion odbc

Public Class settings_menu
    Shared cs As String = "Driver={SQL Server Native Client 10.0};" + "Server=172.16.1.11;" + "DataBase=IF4;" + "Trusted_Connection=no;" + "Uid=epicon;" + "Pwd=cart0-7364*;"




''// Borra  existencia de  muestras(registros  muestras_t)
Public Shared Function clean_programado() As Integer

        Try


            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "delete  from programado"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()

            End While
MessageBox.Show("Todos  los  programas  han sido eliminados")

        Catch i As Exception
            MessageBox.Show("Clean programado " + i.ToString())
        End Try


    End Function





''// Borra  existencia de  muestras(registros  muestras_t)
Public Shared Function clean_producido() As Integer

        Try


            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "delete  from produccion"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()

            End While
MessageBox.Show("Todos  los  programas  producidos han sido eliminados")

        Catch i As Exception
            MessageBox.Show("Clean programado " + i.ToString())
        End Try


    End Function



''// Borra  existencia de  muestras(registros  muestras_t)
Public Shared Function clean_consumos() As Integer

        Try


            Dim conn2 As OdbcConnection = New OdbcConnection()
            conn2.ConnectionString = cs
            Dim mystring2 As String = "delete  from consumos"
            Dim cmd2 As OdbcCommand = New OdbcCommand(mystring2, conn2)
            conn2.Open()
            Dim reader2 As OdbcDataReader = cmd2.ExecuteReader()

            While reader2.Read()

            End While

MessageBox.Show("Todos  los  consumos  han sido eliminados")
        Catch i As Exception
            MessageBox.Show("Clean programado " + i.ToString())
        End Try


    End Function



Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
My.Forms.Usuarios_ver.Show()
End Sub

Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



Dim r = MsgBox("Va  a eliminar  todos los  registros  de  Programas del SISTEMA, desea continuar?", _
                   MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, _
                   "Alerta")


If r = MsgBoxResult.Yes Then   ' User chose Yes.
 clean_programado()
Else
 Exit Sub ' Perform some action.

End If




End Sub

Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


Dim r = MsgBox("Va  a eliminar  todos los  registros  de  OT's Producidas del SISTEMA, desea continuar?", _
                   MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, _
                   "Alerta")


If r = MsgBoxResult.Yes Then   ' User chose Yes.
  clean_producido()
Else

 Exit Sub ' Perform some action.
End If





End Sub

Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


Dim r = MsgBox("Va  a eliminar  todos los  registros  de  consumos del SISTEMA, desea continuar?", _
                   MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, _
                   "Alerta")


If r = MsgBoxResult.Yes Then   ' User chose Yes.
   clean_consumos()
Else
Exit Sub ' Perform some action.

End If


End Sub

Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
  My.Forms.Carga_consumos.Show()
End Sub
End Class