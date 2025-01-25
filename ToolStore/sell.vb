Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class sell
    Dim ds_customer As New DataSet
    Dim str_customer As String

    Dim ds_product As New DataSet
    Dim str_product As String

    Dim ds_price As New DataSet
    Dim str_price As String
    Dim price As Decimal
    Private selectedProductNumber As Integer
    Private selectedPartNumber As Integer

    Dim ds_sell As New DataSet
    Dim str_sell As String

    Dim Ds_edit_Parts As New DataSet
    Dim Str_edit_Parts As String


    Private Sub sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()

        Call load_data1()
        Call load_data2()
    End Sub


    Private Sub load_data1()
        ds_customer.Reset()
        con = New OleDbConnection(strcon)
        str_customer = "SELECT customer_name,customer_id  
                        FROM Tbl_customer  
                        ORDER BY customer_name"
        con.Open()
        da = New OleDbDataAdapter(str_customer, con)
        da.Fill(ds_customer, "Tbl_customer")
        con.Close()
        Dim i
        For i = 0 To ds_customer.Tables("Tbl_customer").Rows.Count - 1
            ComboBox1.Items.Add(ds_customer.Tables("Tbl_customer").Rows(i).Item("customer_name"))
        Next
        ComboBox1.SelectedIndex = 0
    End Sub


    Private Sub load_data2()
        ds_product.Reset()
        con = New OleDbConnection(strcon)
        str_product = "SELECT part_name, part_number, price, product_num 
                       FROM Tbl_products 
                       ORDER BY part_name"
        con.Open()
        da = New OleDbDataAdapter(str_product, con)
        da.Fill(ds_product, "Tbl_products")
        con.Close()
        Dim i
        For i = 0 To ds_product.Tables("Tbl_products").Rows.Count - 1
            ComboBox2.Items.Add(ds_product.Tables("Tbl_products").Rows(i).Item("part_name"))
        Next
        ComboBox2.SelectedIndex = 0
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim selectedPartName As String = ComboBox2.SelectedItem.ToString()
        For Each row As DataRow In ds_product.Tables("Tbl_products").Rows
            If row("part_name").ToString() = selectedPartName Then
                price = Convert.ToDecimal(row("price"))
                selectedProductNumber = Convert.ToInt32(row("product_num"))
                selectedPartNumber = Convert.ToInt32(row("part_number"))
                Label10.Text = price.ToString()
                Exit For
            End If
        Next
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim my_datetime As DateTime = DateTime.Now
        Label3.Text = $"{my_datetime:yyyy}/{my_datetime:MM}/{my_datetime:dd}"
        Label8.Text = my_datetime.ToString("HH:mm:ss")
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim inputValue As String = TextBox1.Text
        Dim number As Integer
        If Integer.TryParse(inputValue, number) Then
            Dim userInput As Integer
            If Integer.TryParse(TextBox1.Text, userInput) Then
                If userInput > selectedProductNumber Then
                    MessageBox.Show("This amount is not available in store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please enter the amount as a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Dim result As Integer = price * Val(TextBox1.Text())
            Label10.Text = result.ToString()
        Else
            MessageBox.Show("Please enter the amount as a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ds_sell.Reset()
        con = New OleDbConnection(strcon)
        str_sell = "INSERT INTO Tbl_sell (sell_customer, sell_product, sell_product_number, sell_price, sell_operator, sell_date, sell_time) 
                    VALUES (@sell_customer,@sell_product,@sell_product_number,@sell_price,@sell_operator,@sell_date,@sell_time) "

        con.Open()
        cmd = New OleDbCommand(str_sell, con)
        cmd.Parameters.Add("@sell_customer", OleDbType.VarChar, 16).Value = (ds_customer.Tables("Tbl_customer").Rows(ComboBox1.SelectedIndex).Item("customer_id"))
        cmd.Parameters.Add("@sell_product", OleDbType.VarChar, 16).Value = Val(ds_product.Tables("Tbl_products").Rows(ComboBox2.SelectedIndex).Item("part_number"))
        cmd.Parameters.Add("@sell_product_number", OleDbType.VarChar, 16).Value = Trim(TextBox1.Text)
        cmd.Parameters.Add("@sell_price", OleDbType.VarChar, 16).Value = Trim(Label10.Text)
        cmd.Parameters.Add("@sell_operator", OleDbType.VarChar, 16).Value = operatorName
        cmd.Parameters.Add("@sell_date", OleDbType.VarChar, 10).Value = Label3.Text
        cmd.Parameters.Add("@sell_time", OleDbType.VarChar, 10).Value = Label8.Text
        cmd.ExecuteNonQuery()
        con.Close()
        'update the amount in the products table
        Call update_product_number()
        Call Reset_Item()
        MessageBox.Show("The purchase was made successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Reset_Item()
    End Sub


    Private Sub update_product_number()
        Ds_edit_Parts.Reset()
        con = New OleDbConnection(strcon)
        Str_edit_Parts = "Update Tbl_products 
                            SET 
                                product_num=@product_num
                            WHERE
                                part_number = @part_number"
        con.Open()
        cmd = New OleDbCommand(Str_edit_Parts, con)
        cmd.Parameters.Add("@product_num", OleDbType.VarChar, 60).Value = (selectedProductNumber - Val(TextBox1.Text())).ToString()
        cmd.Parameters.Add("@part_number", OleDbType.VarChar, 60).Value = selectedPartNumber.ToString()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub Reset_Item()
        TextBox1.Text = 0
        Label10.Text = 0
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class