Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class addOperator
    Dim Ds_Save_operator As New DataSet
    Dim Str_Save_operator As String


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Function Encrypt(plainText As String) As String
        Dim key As Byte() = Encoding.UTF8.GetBytes("your-16-char-key")
        Dim iv As Byte() = Encoding.UTF8.GetBytes("your-16-char-iv ")

        Using aes As Aes = Aes.Create()
            aes.Key = key
            aes.IV = iv

            Dim encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)

            Using ms As New IO.MemoryStream()
                Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                    Using sw As New IO.StreamWriter(cs)
                        sw.Write(plainText)
                    End Using
                    Return Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
        End Using
    End Function


    Private Sub Save_operator()
        Ds_Save_operator.Reset()
        con = New OleDbConnection(strcon)
        Str_Save_operator = "SELECT * 
                             FROM Tbl_operator 
                             WHERE (op_UserId = '" & TextBox1.Text & "')"
        con.Open()
        da = New OleDbDataAdapter(Str_Save_operator, con)
        da.Fill(Ds_Save_operator, "Tbl_operator")
        con.Close()
        If Ds_Save_operator.Tables("Tbl_operator").Rows.Count > 0 Then MessageBox.Show("username exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Str_Save_operator = "INSERT INTO Tbl_operator (op_UserId, op_Pass) 
                             VALUES (@op_UserId,@op_Pass)"

        Me.BindingContext(Ds_Save_operator, "Tbl_operator").AddNew()
        Dim EncryptedPassword As String = Encrypt(TextBox2.Text)
        con.Open()
        cmd = New OleDbCommand(Str_Save_operator, con)
        cmd.Parameters.Add("@op_UserId", OleDbType.VarChar, 30).Value = Trim(TextBox1.Text)
        cmd.Parameters.Add("@op_Pass", OleDbType.VarChar, 30).Value = EncryptedPassword
        cmd.ExecuteNonQuery()
        con.Close()
        Call Reset_Item()
        MessageBox.Show("operator submitted succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub Reset_Item()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                If TextBox2.Text.Length < 8 Then
                    MessageBox.Show("Password must be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox2.Focus()
                    Return
                End If
                Call Save_operator()
            Else
                MessageBox.Show("Please fill the password field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
            End If
        Else
            MessageBox.Show("Please fill the username field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub addOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class