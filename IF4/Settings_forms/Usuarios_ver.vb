Imports System.Data.SqlClient
Public Class Usuarios_ver



    Private MiConexion As New SqlConnection("Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*")
Private MiEnlazador As New BindingSource
 Dim MiAdaptador2





Public Function CARGAR()
Try
Dim query As String = "Select * From usuarios"
Dim MiAdaptador As New SqlDataAdapter(query, MiConexion)
Dim commandbuilder As New SqlCommandBuilder(MiAdaptador)
Dim MiDataSet As New DataTable()

 MiAdaptador.Fill(MiDataSet)


 MiEnlazador.DataSource = MiDataSet
        'DataGridView1.DataSource = MiEnlazador
With DataGridView1
                .Refresh()
                ' coloca el registro arriba de todo  
                .FirstDisplayedScrollingRowIndex = MiEnlazador.Position
            End With
        MiAdaptador2 = MiAdaptador


Catch E As Exception
MessageBox.Show("ERROR")

End Try
Return 0
End Function


Private Sub Usuarios_ver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = MiEnlazador
        End With

CARGAR()


End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
  ' Me.UsuariosTableAdapter.Update(CType(Me.MiEnlazador.DataSource, DataTable))


Me.MiAdaptador2.Update(CType(Me.MiEnlazador.DataSource, DataTable))
End Sub
End Class