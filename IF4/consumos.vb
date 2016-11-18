
Imports System.Data.SqlClient
Public Class consumos

    Private MiConexion As New SqlConnection("Data Source=172.16.1.15;Initial Catalog=IF4;User id=epicon;password=cart0-7364*")
    Private MiDataSet As New DataSet()
    Private MiEnlazador As New BindingSource
    Dim MiAdaptador2
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal HWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long



    'BindingSource  
    Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean

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




           





    End Sub



    Private Sub Actualizar(Optional ByVal bCargar As Boolean = True)
        ' Actualizar y guardar cambios  

        If Not bs.DataSource Is Nothing Then
            SqlDataAdapter.Update(CType(bs.DataSource, DataTable))
            If bCargar Then
                cargar_registros("Select rtrim(no_ci) as CI,no_pedido_ot,Fecha_consumo,id_maquina_consumo,empalmador,parte_rollo,Rollo,kginiciales,KgFinales,CRowID_fecha_programa,vid From Consumos Order by CRowID_fecha_programa", DataGridView1)
            End If
        End If
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With



        Dim inicio_q = " Select rtrim(no_ci) as  CI,no_pedido_ot,Fecha_consumo,id_maquina_consumo,empalmador,parte_rollo,Rollo,kginiciales,KgFinales,CRowID_fecha_programa,vid From Consumos"
        Dim fin_q = " Order by Fecha_consumo desc"
        Dim fechas_q = ""
        Dim maquina_q = ""
        Dim ci_q = " "
        Dim ot_q = " "
        Dim sql_string = ""



        Dim inicio = Format(CDate(Me.inicio_consumo_txt.Text), "yyyy-MM-dd  HH:mm:ss")
        Dim fin = Format(CDate(Me.fin_consumo_txt.Text), "yyyy-MM-dd  HH:mm:ss")


        ' MsgBox("" + CDate(Me.inicio_consumo_txt.Text).ToString("yyyy-MM-dd") + " " + Me.fin_consumo_txt.Text)
        fechas_q = "  Fecha_consumo Between '" + inicio + "' and '" + fin + "'"



        Dim maquina1 = "A"
        Dim maquina2 = "A"
        Dim maquina3 = "A"
        Dim maquina4 = "A"


        If (Me.corr1_cbx.Checked = True) Then
            maquina1 = "01_CORR1"

        End If


        If (Me.corr2_cbx.Checked = True) Then
            maquina2 = "01_CORR2"

        End If



        If (Me.sf1_cbx.Checked = True) Then
            maquina3 = "01_SF1"

        End If


        If (Me.sf2_cbx.Checked = True) Then
            maquina4 = "01_SF2"

        End If

        maquina_q = " and  (id_maquina_consumo = '" + maquina1 + "' or id_maquina_consumo ='" + maquina2 + "' or id_maquina_consumo ='" + maquina3 + "' or id_maquina_consumo ='" + maquina4 + "')"





        If Me.ci_txt.Text.Length > 0 Then

            ci_q = " and  no_ci='" + Me.ci_txt.Text + "'"

        End If






        If Me.ot_txt.Text.Length > 0 Then


            ot_q = "  and  no_pedido_ot='" + Me.ot_txt.Text + "'"


        End If

        sql_string = inicio_q + " Where " + fechas_q + maquina_q + ci_q + ot_q + fin_q



        Me.TextBox1.Text = sql_string.ToString
        ' cagar los datos  
        cargar_registros(sql_string, DataGridView1)


    End Sub


    Public Shared Sub ErrorLog(ByVal sPathName As String, ByVal sErrMsg As String)
        Try
            Dim sYear As String = DateTime.Now.Year.ToString()
            Dim sMonth As String = DateTime.Now.Month.ToString()
            Dim sDay As String = DateTime.Now.Day.ToString()
            Dim sErrorTime = sYear + sMonth + sDay

            Dim sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> "

            Dim sw As System.IO.StreamWriter = New System.IO.StreamWriter(sPathName.Replace(".", "." + sErrorTime + "."), True)
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
    Shared DirDelLog As String = IO.Path.GetDirectoryName(Application.ExecutablePath) + "\LogIF\Log.txt"








    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If (My.Settings.intJer = 1 Or My.Settings.intJer = 3 Or My.Settings.intJer = 4) Then

            consumos_update.Show()

        Else

            MsgBox("No tiene suficientes  privilegios  para acceder  a  esta  opcion")


        End If



    End Sub

    Private Sub RegistroDeModifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeModifToolStripMenuItem.Click

        If (My.Settings.intJer = 1 Or My.Settings.intJer = 2 Or My.Settings.intJer = 3) Then


            bitacora.Show()

        Else

            MsgBox("No tiene suficientes  privilegios  para acceder  a  esta  opcion")

        End If
           

    End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

 
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




      
End Sub

Private Sub consumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("Select rtrim(no_ci) as  CI,no_pedido_ot,Fecha_consumo,id_maquina_consumo,empalmador,parte_rollo,Rollo,kginiciales,KgFinales,CRowID_fecha_programa,vid From Consumos Order by Fecha_consumo desc", DataGridView1)
End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ' SqlDataAdapter.Update(CType(bs.DataSource, DataTable))

        Me.Validate()
        Me.bs.EndEdit()
        Me.SqlDataAdapter.Update(Me.bs.DataSource)

    End Sub
End Class