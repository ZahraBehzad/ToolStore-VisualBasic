Imports System.Data.SqlClient
Imports System.Data.OleDb
Module DB
    Public strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Zahra\source\repos\ToolStore\ToolStore.accdb"
    Public con As OleDbConnection
    Public da As OleDbDataAdapter
    Public cmd As OleDbCommand

    Public edit_part_number As String
    Public edit_part_name As String
    Public edit_id_unit As String
    Public edit_id_case As String
    Public edit_weight As String
    Public edit_size_l As String
    Public edit_size_h As String
    Public edit_fire As String
    Public edit_fridge As String
    Public edit_humidity As String
    Public edit_price As String
    Public edit_product_num As String
End Module
