
Imports System.Data.SqlClient
Public Class salida_rollo

    Private MiConexion As New SqlConnection("Data Source=172.16.1.11;Initial Catalog=IF4;User id=epicon;password=cart0-7364*")

    Private MiEnlazador As New BindingSource
    Dim MiAdaptador2
    


Public Function CARGAR()
Try
Dim query As String = "Select KgFinales,kginiciales,Fecha_consumo,Rollo,parte_rollo,no_ci,no_pedido_ot,id_maquina_consumo,empalmador,CRowID_fecha_programa,vid From Consumos Order by Fecha_consumo DESC"
'Dim query As String = "Select * From Consumos Order by Fecha_consumo DESC"

Dim MiAdaptador As New SqlDataAdapter(query, MiConexion)
Dim commandbuilder As New SqlCommandBuilder(MiAdaptador)
Dim MiDataSet As New DataTable()




           


 MiAdaptador.Fill(MiDataSet)

If (Me.parte_txt.Text.Equals(String.Empty) And Me.rollo_txt.Text.Equals(String.Empty)) Then
Else
MiEnlazador.Filter = "parte_rollo = '" + Me.parte_txt.Text + "' AND   Rollo ='" + Me.rollo_txt.Text + "'"

End If
 MiEnlazador.DataSource = MiDataSet
        'DataGridView1.DataSource = MiEnlazador
With DataGridView1
                .Refresh()
                ' coloca el registro arriba de todo  
                .FirstDisplayedScrollingRowIndex = MiEnlazador.Position
            End With
        MiAdaptador2 = MiAdaptador
            ' DataGridView1.foc()

Catch E As Exception
MessageBox.Show("ERROR")

End Try
Return 0
End Function





   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
 With DataGridView1
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = MiEnlazador
        End With

CARGAR()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

 Me.MiAdaptador2.Update(CType(Me.MiEnlazador.DataSource, DataTable))
Me.parte_txt.Text = ""
Me.rollo_txt.Text = ""
Me.parte_txt.Focus()
    End Sub

Private Sub salida_rollo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


Me.parte_txt.Focus()



End Sub

Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
  Me.parte_txt.Text = ""
Me.rollo_txt.Text = ""
Me.parte_txt.Focus()
End Sub
End Class