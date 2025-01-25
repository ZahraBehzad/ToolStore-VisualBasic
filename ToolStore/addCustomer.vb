Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class addCustomer
    Dim Ds_Save_Customers As New DataSet
    Dim Str_Save_Customers As String


    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim my_datetime As DateTime = DateTime.Now
        Label3.Text = $"{my_datetime:yyyy}/{my_datetime:MM}/{my_datetime:dd}"
        Label8.Text = my_datetime.ToString("HH:mm:ss")
    End Sub


    Private Sub Save_Customers()
        Ds_Save_Customers.Reset()
        con = New OleDbConnection(strcon)
        Str_Save_Customers = "SELECT * 
                              FROM Tbl_customer 
                              WHERE (customer_phone = '" & TextBox3.Text & "')"
        con.Open()
        da = New OleDbDataAdapter(Str_Save_Customers, con)
        da.Fill(Ds_Save_Customers, "Tbl_customer")
        con.Close()
        If Ds_Save_Customers.Tables("Tbl_customer").Rows.Count > 0 Then MessageBox.Show("customer exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Str_Save_Customers = "INSERT INTO Tbl_customer (customer_id, customer_name, customer_gender, customer_phone, customer_address, customer_date, customer_time) 
                              VALUES (@customer_id,@customer_name,@customer_gender,@customer_phone,@customer_address,@customer_date,@customer_time) "
        Me.BindingContext(Ds_Save_Customers, "Tbl_customer").AddNew()
        con.Open()
        cmd = New OleDbCommand(Str_Save_Customers, con)
        cmd.Parameters.Add("@customer_id", OleDbType.VarChar, 16).Value = Trim(TextBox1.Text)
        cmd.Parameters.Add("@customer_name", OleDbType.VarChar, 60).Value = Trim(TextBox2.Text)
        cmd.Parameters.Add("@customer_gender", OleDbType.VarChar, 60).Value = Trim(ComboBox1.SelectedItem.ToString())
        cmd.Parameters.Add("@customer_phone", OleDbType.VarChar, 60).Value = Trim(TextBox3.Text)
        cmd.Parameters.Add("@customer_address", OleDbType.VarChar, 60).Value = Trim(RichTextBox1.Text)
        cmd.Parameters.Add("@customer_date", OleDbType.VarChar, 10).Value = Label3.Text
        cmd.Parameters.Add("@customer_time", OleDbType.VarChar, 10).Value = Label8.Text
        cmd.ExecuteNonQuery()
        con.Close()
        Call Reset_Item()
        MessageBox.Show("customer submitted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub Reset_Item()
        TextBox1.Text = ""
        TextBox2.Clear()
        ComboBox1.SelectedIndex = 0
        TextBox3.Clear()
        RichTextBox1.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                If TextBox3.Text <> "" Then
                    Call Save_Customers()
                Else
                    MessageBox.Show("Please enter the customer's phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox3.Focus()
                End If
            Else
                MessageBox.Show("Please enter the customer's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
            End If
        Else
            MessageBox.Show("Please enter the customer's code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Reset_Item()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class