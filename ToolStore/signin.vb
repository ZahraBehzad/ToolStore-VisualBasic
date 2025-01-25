Imports System.Data.OleDb
Imports System.Drawing
Imports System.Security.Cryptography
Imports System.Text
Public Class signin
    Dim Ds_Load_operator As New DataSet
    Dim Str_Load_operator As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

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


    Private Sub Reset_Item()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ds_Load_operator.Reset()
        con = New OleDbConnection(strcon)
        Str_Load_operator = "SELECT op_Pass 
                             FROM Tbl_operator 
                             WHERE op_UserId = @username1"
        Dim cmd As New OleDbCommand(Str_Load_operator, con)
        cmd.Parameters.AddWithValue("@username1", TextBox1.Text)
        Try
            con.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim storedPassword As String = reader("op_Pass").ToString()
                Dim enteredPassword As String = Encrypt(TextBox2.Text)
                If enteredPassword = storedPassword Then
                    operatorManage.operatorName = TextBox1.Text
                    Dim mainForm As New index()
                    mainForm.Show()
                    Me.Hide()
                    MessageBox.Show("SignIn successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Reset_Item()
                Else
                    MessageBox.Show("The username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call Reset_Item()
                End If
            Else
                MessageBox.Show("The username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call Reset_Item()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
