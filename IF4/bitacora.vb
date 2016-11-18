Public Class bitacora

    Private Sub bitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim LineofText As String = ""
        Dim AllText As String = ""
        Dim strDOB As String


        Dim res As Integer


        strDOB = InputBox("Ingrese  la fecha  de  inicio de programacion", _
        "IF4 Ingreso de  Consumo de  Rollo", _
        "DD/MM/AA")



        If IsDate(strDOB) Then
            ' MsgBox("Fecha " & CDate(strDOB).ToString("D") + " - " + strDOB + "-" + CDate(strDOB))
            ' MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, _
            '  "")
            res = 1
            
        Else
            MsgBox("Se  necesita  una  fecha  validad", _
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, _
                   "Error")
            res = 0

        End If

        ' Loop Until res = 1




        Dim sYear As String = CDate(strDOB).Year
        Dim sMonth As String = CDate(strDOB).Month
        Dim sDay As String = CDate(strDOB).Day

        'MessageBox.Show(sYear + sMonth + sDay)
        Dim sErrorTime = sYear + sMonth + sDay




        Try
            FileOpen(1, "\\SER-VIRTUALES\DataRecordCons\ICR" + sErrorTime + ".txt", OpenMode.Input)

            Do Until EOF(1)
                LineofText = LineInput(1)
                Alltext = Alltext & LineofText & vbCrLf
            Loop

            txtnote.Text = AllText
            txtnote.Enabled = True

        Catch

        Finally

            FileClose(1)

        End Try




    End Sub
End Class