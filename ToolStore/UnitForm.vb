Imports System.Data.OleDb
Public Class UnitForm
    Dim ds_unit As New DataSet
    Dim str_unit As String
    Dim ds_save As New DataSet
    Dim str_save As String
    Dim id As Long
    Dim c_unit As Boolean


    Private Sub load_data()
        ds_unit.Reset()
        con = New OleDbConnection(strcon)
        str_unit = "SELECT unit_name,id_unit  
                    FROM Tbl_unit  
                    ORDER BY unit_name"

        con.Open()
        da = New OleDbDataAdapter(str_unit, con)
        da.Fill(ds_unit, "Tbl_unit")
        con.Close()
        DataGridView1.DataBindings.Clear()
        DataGridView1.DataBindings.Add(New Binding("datasource", ds_unit, "Tbl_unit"))
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(0).Width = 45
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c_unit = True
        Call load_data()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub Save_unit()
        ds_save.Reset()
        con = New OleDbConnection(strcon)
        str_save = "SELECT *  
                FROM Tbl_unit  
                WHERE unit_name = @unit_name"

        con.Open()
        da = New OleDbDataAdapter(str_save, con)
        da.SelectCommand.Parameters.Add("@unit_name", OleDbType.VarChar).Value = TextBox1.Text
        da.Fill(ds_save, "Tbl_unit")
        con.Close()

        If ds_save.Tables("Tbl_unit").Rows.Count > 0 Then
            MsgBox("Unit exists!Please do not enter duplicate value.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim recordCount As Integer
        str_save = "SELECT COUNT(*) FROM Tbl_unit"
        con.Open()
        cmd = New OleDbCommand(str_save, con)
        recordCount = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()
        str_save = "INSERT INTO Tbl_unit (Id_unit, unit_name) 
                VALUES (@Id_unit, @unit_name)"

        con.Open()
        cmd = New OleDbCommand(str_save, con)
        cmd.Parameters.Add("@Id_unit", OleDbType.Integer).Value = recordCount + 1
        cmd.Parameters.Add("@unit_name", OleDbType.VarChar).Value = TextBox1.Text
        cmd.ExecuteNonQuery()
        con.Close()

        Call load_data()
        TextBox1.Clear()
    End Sub


    Private Sub edit_unit()
        ds_save.Reset()
        con = New OleDbConnection(strcon)
        str_save = "SELECT *  
                    FROM Tbl_unit  
                    where unit_name='" & TextBox1.Text & "'"

        con.Open()
        da = New OleDbDataAdapter(str_save, con)
        da.Fill(ds_save, "Tbl_unit")
        con.Close()
        str_save = "UPDATE Tbl_unit 
                    SET unit_name=@unit_name    
                    WHERE Tbl_unit.id_unit= " & id
        con.Open()
        cmd = New OleDbCommand(str_save, con)
        cmd.Parameters.Add("@unit_name", OleDbType.VarChar).Value = TextBox1.Text
        cmd.ExecuteNonQuery()
        con.Close()
        Call load_data()
        TextBox1.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If c_unit = True Then
            If TextBox1.Text <> "" Then
                Call Save_unit()
            Else
                MsgBox("Please enter the unit.", MsgBoxStyle.Information, "Error")
            End If
        Else
            If TextBox1.Text <> "" Then
                Call edit_unit()
            Else
                MsgBox("Please enter the unit.", MsgBoxStyle.Information, "Error")
            End If
        End If
        c_unit = True
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.CurrentCell.ColumnIndex = 0 Then
            id = Val(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value)
            TextBox1.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            c_unit = False
        End If
    End Sub
End Class