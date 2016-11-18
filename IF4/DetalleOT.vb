
Imports System.Data.SqlClient
Public Class DetalleOT


    ''// grid pedido
    Private MiConexion As New SqlConnection("Data Source=172.16.1.15;Initial Catalog=E10Cartomicro;User id=epicon;password=cart0-7364*")
    Private MiAdaptador As New SqlDataAdapter("Select JobNum as IDPedido_OT , MtlSeq  as Secuencia, PartNum as Parte , Description as Descripcion  From JobMtl where JobNum='" + CStr(Ingreso_consumos.ot_txt.Text) + "' and  Mtlseq  in (110,120,130,140,150) ", MiConexion)
    Private MiDataSet As New DataSet()
    Private MiEnlazador As New BindingSource


    ''// grid  lote 
    Private MiConexion2 As New SqlConnection("Data Source=172.16.1.15;Initial Catalog=E10Cartomicro;User id=epicon;password=cart0-7364*")
    Private MiAdaptador2 As New SqlDataAdapter("select PartNum as Parte, LotNum as IDRollo ,  OnHand as En_existencia , FirstRefDate as Primera_Ref  from PartLot where   LotNum = '" + CStr(Ingreso_consumos.rollo_txt.Text) + "'", MiConexion2)
    Private MiDataSet2 As New DataSet()
    Private MiEnlazador2 As New BindingSource



    ''//grid  inventario


    'BindingSource  
    Private WithEvents bs As New BindingSource
    ' Adaptador de datos sql  
    Private SqlDataAdapter As SqlDataAdapter
    ' Cadena de conexión  
    Private Const cs As String = "Data Source=172.16.1.15;Initial Catalog=E10Cartomicro;User id=epicon;password=cart0-7364*"
    ' flag  
    Private bEdit As Boolean




    Private Sub cargar_registros(ByVal sql As String, ByVal dv As DataGridView)

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


    Private Sub Actualizar(ByVal parte As String, Optional ByVal bCargar As Boolean = True)
        ' Actualizar y guardar cambios  

        If Not bs.DataSource Is Nothing Then
            SqlDataAdapter.Update(CType(bs.DataSource, DataTable))
            If bCargar Then
                cargar_registros("select PartNum as Parte, LotNum as IDRollo ,  OnHand as En_existencia , FirstRefDate as Primera_Ref  from PartLot ", DataGridView3)
            End If
        End If
    End Sub

    Private Sub programas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'AddHandler Button1.Click, AddressOf Button1_Click
        Dim commandbuilder As New SqlCommandBuilder(Me.MiAdaptador)

        MiConexion.Open()

        MiAdaptador.Fill(MiDataSet)

        MiEnlazador.DataSource = MiDataSet.Tables(0)

        DataGridView1.DataSource = MiEnlazador



        If Not (Ingreso_consumos.rollo_txt.Text = "") Then

            MiConexion2.Open()

            MiAdaptador2.Fill(MiDataSet2)

            MiEnlazador2.DataSource = MiDataSet2.Tables(0)

            DataGridView2.DataSource = MiEnlazador2

        End If

    End Sub

    

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Dim Variable As String = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString

        'MessageBox.Show("CAMBIO :" + Variable)
       
        With DataGridView3
            ' alternar color de filas  
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            '  .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview  
            .DataSource = bs
        End With




        ' cagar los datos  
        cargar_registros("select PartLot.PartNum as Parte,  PartLot.LotNum as IDRollo ,   PartLot.OnHand as En_existencia , FirstRefDate as Primera_Ref  , PartBin.WarehouseCode from PartLot,partbin WHERE OnHand = 1 and  PartLot.LotNum = PartBin.LotNum  and  PartBin.WarehouseCode = '300' and  PartLot.PartNum like '" + CStr(Variable) + "%'", DataGridView3)



    End Sub
End Class