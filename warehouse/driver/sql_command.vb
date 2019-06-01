Imports MySql.Data.MySqlClient
Public Class sql_command
    Public Shared Function sqlcommand_with_dataset(sql_command As String) As DataSet
        Call connect2db()
        Dim ds As New DataSet
        sql = sql_command
        adapter = New MySqlDataAdapter(sql, Con)
        adapter.Fill(ds)
        Return ds
    End Function

    Public Shared Function sqlcommand_with_datatable(sql_command As String) As DataTable
        Call connect2db()
        Dim ds As New DataTable
        sql = sql_command
        adapter = New MySqlDataAdapter(sql, Con)
        adapter.Fill(ds)
        Return ds
    End Function
End Class
