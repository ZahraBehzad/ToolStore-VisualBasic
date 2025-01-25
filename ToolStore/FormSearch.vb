Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormSearch
    Dim Ds_Load_default As New DataSet
    Dim Str_Load_default As String

    Dim Ds_Load_Data As New DataSet
    Dim Str_Load_Data As String

    Dim Ds_delete_Data As New DataSet
    Dim Str_delete_Data As String

    Dim C_LoadData As Boolean

    Dim id_edit As Long
    Dim c_edit As Boolean
    Dim id_delete As Long


    Public Sub LoadData2()
        Ds_Load_default.Reset()
        con = New OleDbConnection(strcon)
        Str_Load_default = "SELECT Tbl_products.part_number AS [code], Tbl_products.part_name AS [name], Tbl_unit.unit_name AS [unit], Tbl_case.case_name AS [type], Tbl_products.weight AS weight, Tbl_products.size_l AS width, Tbl_products.size_h AS height  , Tbl_products.fire AS [heat sensitive] , Tbl_products.fridge AS [cold sensitive] , Tbl_products.humidity AS [humidity sensitive], Tbl_products.price AS [price], Tbl_products.product_num AS [amount]  , Tbl_products.Time_save AS [Time] , Tbl_products.Date_save AS [Date]
                            FROM ((Tbl_products INNER JOIN Tbl_unit ON Tbl_products.Id_unit = Tbl_unit.Id_unit) INNER JOIN Tbl_case ON Tbl_products.Id_case = Tbl_case.Id_case) 
                            WHERE (Tbl_products.part_name like '%" & ToolStripTextBox1.Text & "%') "

        con.Open()
        da = New OleDbDataAdapter(Str_Load_default, con)
        da.Fill(Ds_Load_default, "Tbl_products")
        con.Close()

        DataGridView1.DataBindings.Clear()
        DataGridView1.DataBindings.Add(New Binding("datasource", Ds_Load_default, "Tbl_products"))
    End Sub


    Private Sub Load_Data()
        Ds_Load_Data.Reset()
        con = New OleDbConnection(strcon)
        Select Case ToolStripComboBox1.SelectedIndex
            Case 0
                Str_Load_Data = "SELECT Tbl_products.part_number AS [code], Tbl_products.part_name AS [name], Tbl_unit.unit_name AS [unit], Tbl_case.case_name AS [type], Tbl_products.weight AS weight, Tbl_products.size_l AS width, Tbl_products.size_h AS height  , Tbl_products.fire AS [heat sensitive] , Tbl_products.fridge AS [cold sensitive] , Tbl_products.humidity AS [humidity sensitive], Tbl_products.price AS [price], Tbl_products.product_num AS [amount]  , Tbl_products.Time_save AS [Time] , Tbl_products.Date_save AS [Date] 
                                 FROM ((Tbl_products INNER JOIN Tbl_unit ON Tbl_products.Id_unit = Tbl_unit.Id_unit) INNER JOIN Tbl_case ON Tbl_products.Id_case = Tbl_case.Id_case) 
                                 WHERE (Tbl_products.part_name like '%" & ToolStripTextBox1.Text & "%') "
            Case 1
                Str_Load_Data = "SELECT Tbl_products.part_number AS [code], Tbl_products.part_name AS [name], Tbl_unit.unit_name AS [unit], Tbl_case.case_name AS [type], Tbl_products.weight AS weight, Tbl_products.size_l AS width, Tbl_products.size_h AS height  , Tbl_products.fire AS [heat sensitive] , Tbl_products.fridge AS [cold sensitive] , Tbl_products.humidity AS [humidity sensitive], Tbl_products.price AS [price], Tbl_products.product_num AS [amount]  , Tbl_products.Time_save AS [Time] , Tbl_products.Date_save AS [Date] 
                                 FROM ((Tbl_products INNER JOIN Tbl_unit ON Tbl_products.Id_unit = Tbl_unit.Id_unit) INNER JOIN Tbl_case ON Tbl_products.Id_case = Tbl_case.Id_case) 
                                 WHERE (Tbl_products.part_number  like '%" & ToolStripTextBox1.Text & "%') "
            Case 2
                Str_Load_Data = "SELECT Tbl_products.part_number AS [code], Tbl_products.part_name AS [name], Tbl_unit.unit_name AS [unit], Tbl_case.case_name AS [type], Tbl_products.weight AS weight, Tbl_products.size_l AS width, Tbl_products.size_h AS height , Tbl_products.fire AS [heat sensitive] , Tbl_products.fridge AS [cold sensitive] , Tbl_products.humidity AS [humidity sensitive], Tbl_products.price AS [price], Tbl_products.product_num AS [amount]  , Tbl_products.Time_save AS [Time] , Tbl_products.Date_save AS [Date] 
                                 FROM ((Tbl_products INNER JOIN Tbl_unit ON Tbl_products.Id_unit = Tbl_unit.Id_unit) INNER JOIN Tbl_case ON Tbl_products.Id_case = Tbl_case.Id_case) 
                                 WHERE (Tbl_products.size_l = " & Val(ToolStripTextBox1.Text) & ") OR (Tbl_products.Size_H = " & Val(ToolStripTextBox1.Text) & " ) "
        End Select


        con.Open()
        da = New OleDbDataAdapter(Str_Load_Data, con)
        da.Fill(Ds_Load_Data, "Tbl_products")
        con.Close()

        DataGridView1.DataBindings.Clear()
        DataGridView1.DataBindings.Add(New Binding("datasource", Ds_Load_Data, "Tbl_products"))
    End Sub


    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click

    End Sub


    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C_LoadData = False
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 20)
        Call LoadData2()
        ToolStripTextBox1.Clear()
        ToolStripComboBox1.SelectedIndex = 1
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call Load_Data()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.CurrentCell.ColumnIndex = 0 Then
            id_edit = Val(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value)
            edit_part_number = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            edit_part_name = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            edit_id_unit = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            edit_id_case = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value
            edit_weight = DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value
            edit_size_l = DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value
            edit_size_h = DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value
            edit_fire = DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value
            edit_fridge = DataGridView1.Item(10, DataGridView1.CurrentCell.RowIndex).Value
            edit_humidity = DataGridView1.Item(11, DataGridView1.CurrentCell.RowIndex).Value
            edit_price = DataGridView1.Item(12, DataGridView1.CurrentCell.RowIndex).Value
            edit_product_num = DataGridView1.Item(13, DataGridView1.CurrentCell.RowIndex).Value
            c_edit = False
            editProduct.ShowDialog()

        ElseIf DataGridView1.CurrentCell.ColumnIndex = 1 Then
            id_delete = (DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value).ToString()
            Ds_delete_Data.Reset()
            con = New OleDbConnection(strcon)
            Str_delete_Data = "DELETE FROM Tbl_products 
                               WHERE part_number = '" & id_delete & "';"
            con.Open()
            da = New OleDbDataAdapter(Str_delete_Data, con)
            da.Fill(Ds_delete_Data, "Tbl_products")
            con.Close()
            Call LoadData2()
        End If
    End Sub
End Class