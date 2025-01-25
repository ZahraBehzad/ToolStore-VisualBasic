Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class NewProduct
    Dim ds_unit As New DataSet
    Dim str_unit As String
    Dim ds_case As New DataSet
    Dim str_case As String
    Dim Ds_Save_Parts As New DataSet
    Dim Str_Save_Parts As String


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


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()

        Call load_data1()
        Call load_data2()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                If ComboBox1.SelectedIndex >= 0 Then
                    If ComboBox2.SelectedIndex >= 0 Then
                        If MaskedTextBox5.Text <> "" Then
                            Call Save_Parts()
                        Else
                            MessageBox.Show("please enter price of product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            MaskedTextBox5.Focus()
                        End If
                    Else
                        MessageBox.Show("please choose type of product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ComboBox2.Focus()
                    End If
                Else
                    MessageBox.Show("please choose unit of product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ComboBox1.Focus()
                End If
            Else
                MessageBox.Show("please enter name of product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
            End If
        Else
            MessageBox.Show("please enter code of product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Reset_Item()
        TextBox1.Text = ""
        TextBox2.Clear()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        MaskedTextBox3.Clear()
        MaskedTextBox4.Clear()
        MaskedTextBox5.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Reset_Item()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub Save_Parts()
        Ds_Save_Parts.Reset()
        con = New OleDbConnection(strcon)
        Str_Save_Parts = "SELECT * 
                          FROM Tbl_products 
                          WHERE (part_number = '" & TextBox1.Text & "')"

        con.Open()
        da = New OleDbDataAdapter(Str_Save_Parts, con)
        da.Fill(Ds_Save_Parts, "Tbl_products")
        con.Close()
        If Ds_Save_Parts.Tables("Tbl_products").Rows.Count > 0 Then MessageBox.Show("This product exists!please check the product code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Str_Save_Parts = "INSERT INTO Tbl_products (part_number, part_name, Id_unit, Id_case, weight, size_l, size_h, fire, fridge, humidity, Id_user, Time_save, Date_save, price, product_num) 
                          VALUES (@part_number,@part_name,@Id_unit,@Id_case,@weight,@size_l,@size_h,@fire,@fridge,@humidity,@Id_user,@Time_save,@Date_save,@price,@product_num) "
        Me.BindingContext(Ds_Save_Parts, "Tbl_products").AddNew()
        con.Open()
        cmd = New OleDbCommand(Str_Save_Parts, con)
        cmd.Parameters.Add("@part_number", OleDbType.VarChar, 16).Value = Trim(TextBox1.Text)
        cmd.Parameters.Add("@part_name", OleDbType.VarChar, 60).Value = Trim(TextBox2.Text)
        cmd.Parameters.Add("@Id_unit", OleDbType.Integer).Value = (ds_unit.Tables("Tbl_unit").Rows(ComboBox1.SelectedIndex).Item("Id_unit"))
        cmd.Parameters.Add("@Id_case", OleDbType.Integer).Value = Val(ds_case.Tables("Tbl_case").Rows(ComboBox2.SelectedIndex).Item("Id_case"))
        cmd.Parameters.Add("@weight", OleDbType.Double).Value = Val(Trim(MaskedTextBox1.Text))
        cmd.Parameters.Add("@size_l", OleDbType.Double).Value = Val(Trim(MaskedTextBox3.Text))
        cmd.Parameters.Add("@size_h", OleDbType.Double).Value = Val(Trim(MaskedTextBox2.Text))
        cmd.Parameters.Add("@fire", OleDbType.Integer).Value = IIf(CheckBox1.Checked = True, 1, 0)
        cmd.Parameters.Add("@fridge", OleDbType.Integer).Value = IIf(CheckBox3.Checked = True, 1, 0)
        cmd.Parameters.Add("@humidity", OleDbType.Integer).Value = IIf(CheckBox2.Checked = True, 1, 0)
        cmd.Parameters.Add("@Id_user", OleDbType.Integer).Value = 123
        cmd.Parameters.Add("@Time_save", OleDbType.VarChar, 5).Value = Label8.Text
        cmd.Parameters.Add("@Date_save", OleDbType.VarChar, 10).Value = Label2.Text
        cmd.Parameters.Add("@price", OleDbType.Double).Value = Val(Trim(MaskedTextBox5.Text))
        cmd.Parameters.Add("@product_num", OleDbType.Double).Value = Val(Trim(MaskedTextBox4.Text))
        cmd.ExecuteNonQuery()
        con.Close()
        Call Reset_Item()
        MessageBox.Show("product submitted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub


    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim my_datetime As DateTime = DateTime.Now
        Label2.Text = $"{my_datetime:yyyy}/{my_datetime:MM}/{my_datetime:dd}"
        Label8.Text = my_datetime.ToString("HH:mm:ss")
    End Sub
End Class