'Copyright 2019
'    Davin Alfarizky Putra Basudewa <davinbambang@hotmail.com / dbasudewa@gmail.com>
'    All rights reserved
'This is my hardwork,please to insert credit to the github link if you copycat to your works
'DONTSTEALMYHARDWORK
Imports MySql.Data.MySqlClient
Public Class sql_command
    Public Shared Function select_sqlcommand_with_dataset(sql_command As String) As DataSet
        Call connect2db()
        Dim ds As New DataSet
        sql = sql_command
        adapter = New MySqlDataAdapter(sql, Con)
        adapter.Fill(ds)
        Return ds
    End Function

    Public Shared Function select_sqlcommand_with_datatable(sql_command As String) As DataTable
        Call connect2db()
        Dim ds As New DataTable
        sql = sql_command
        adapter = New MySqlDataAdapter(sql, Con)
        adapter.Fill(ds)
        Return ds
    End Function
    Public Shared Function noreturnsql(sql_command As String, param As Dictionary(Of String, Integer)) As Boolean
        Call connect2db()
        Try
            Dim cmd As New MySqlCommand(sql_command, Con)
            For Each params As KeyValuePair(Of String, Integer) In param
                cmd.Parameters.AddWithValue(params.Key, params.Value)
            Next
            cmd.BeginExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("There's error while executing\nerror:" & ex.Message)
            Return False
        End Try
    End Function
End Class
