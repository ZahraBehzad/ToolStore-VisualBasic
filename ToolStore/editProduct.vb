Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class editProduct
    Dim ds_unit As New DataSet
    Dim str_unit As String
    Dim ds_case As New DataSet
    Dim str_case As String
    Dim Ds_edit_Parts As New DataSet
    Dim Str_edit_Parts As String


    Private Sub load_data1()
        ds_unit.Reset()
        con = New OleDbConnection(strcon)
        str_unit = "SELECT unit_name,Id_unit  
                    FROM Tbl_unit  
                    ORDER BY unit_name"
        con.Open()
        da = New OleDbDataAdapter(str_unit, con)
        da.Fill(ds_unit, "Tbl_unit")
        con.Close()
        Dim i
        For i = 0 To ds_unit.Tables("Tbl_unit").Rows.Count - 1
            ComboBox1.Items.Add(ds_unit.Tables("Tbl_unit").Rows(i).Item("unit_name"))
        Next
        ComboBox1.SelectedIndex = 0
    End Sub


    Private Sub load_data2()
        ds_case.Reset()
        con = New OleDbConnection(strcon)
        str_case = "SELECT case_name,Id_case  
                    FROM Tbl_case  
                    ORDER BY case_name"
        con.Open()
        da = New OleDbDataAdapter(str_case, con)
        da.Fill(ds_case, "Tbl_case")
        con.Close()
        Dim i
        For i = 0 To ds_case.Tables("Tbl_case").Rows.Count - 1
            ComboBox2.Items.Add(ds_case.Tables("Tbl_case").Rows(i).Item("case_name"))
        Next
        ComboBox2.SelectedIndex = 0
    End Sub


    Private Sub editProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_data1()
        Call load_data2()
        TextBox1.Text = edit_part_number
        TextBox1.ReadOnly = True
        TextBox2.Text = edit_part_name
        ComboBox1.Text = edit_id_unit
        ComboBox2.Text = edit_id_case
        TextBox3.Text = edit_weight
        TextBox4.Text = edit_size_l
        TextBox5.Text = edit_size_h
        CheckBox1.Checked = edit_fire
        CheckBox2.Checked = edit_humidity
        CheckBox3.Checked = edit_fridge
        TextBox7.Text = edit_price
        TextBox6.Text = edit_product_num
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                If ComboBox1.SelectedIndex >= 0 Then
                    If ComboBox2.SelectedIndex >= 0 Then
                        Call Edit_Parts()
                        Me.Close()
                    Else
                        MessageBox.Show("Please select the type of product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ComboBox2.Focus()
                    End If
                Else
                    MessageBox.Show("Please select the unit of measurement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ComboBox1.Focus()
                End If
            Else
                MessageBox.Show("Please enter the product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
            End If
        Else
            MessageBox.Show("Please enter the product code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Edit_Parts()
        Ds_edit_Parts.Reset()
        con = New OleDbConnection(strcon)
        Str_edit_Parts = "Update Tbl_products 
                            SET 
                                part_name = @part_name,
                                Id_unit = @Id_unit,
                                Id_case = @Id_case,
                                weight = @weight,
                                size_l = @size_l,
                                size_h = @size_h,
                                fire = @fire,
                                fridge = @fridge,
                                humidity = @humidity,
                                price = @price,
                                product_num = @product_num
                            WHERE
                                part_number = @part_number"

        con.Open()
        cmd = New OleDbCommand(Str_edit_Parts, con)
        cmd.Parameters.Add("@part_name", OleDbType.VarChar, 60).Value = Trim(TextBox2.Text)
        cmd.Parameters.Add("@Id_unit", OleDbType.Integer).Value = (ds_unit.Tables("Tbl_unit").Rows(ComboBox1.SelectedIndex).Item("Id_unit"))
        cmd.Parameters.Add("@Id_case", OleDbType.Integer).Value = Val(ds_case.Tables("Tbl_case").Rows(ComboBox2.SelectedIndex).Item("Id_case"))
        cmd.Parameters.Add("@weight", OleDbType.Double).Value = Val(Trim(TextBox3.Text))
        cmd.Parameters.Add("@size_l", OleDbType.Double).Value = Val(Trim(TextBox4.Text))
        cmd.Parameters.Add("@size_h", OleDbType.Double).Value = Val(Trim(TextBox5.Text))
        cmd.Parameters.Add("@fire", OleDbType.Integer).Value = IIf(CheckBox1.Checked = True, 1, 0)
        cmd.Parameters.Add("@fridge", OleDbType.Integer).Value = IIf(CheckBox3.Checked = True, 1, 0)
        cmd.Parameters.Add("@humidity", OleDbType.Integer).Value = IIf(CheckBox2.Checked = True, 1, 0)
        cmd.Parameters.Add("@price", OleDbType.VarChar, 16).Value = Trim(TextBox7.Text)
        cmd.Parameters.Add("@product_num", OleDbType.VarChar, 16).Value = Trim(TextBox6.Text)
        cmd.Parameters.Add("@part_number", OleDbType.VarChar, 16).Value = Trim(TextBox1.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("product edited successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        FormSearch.LoadData2()
    End Sub
End Class