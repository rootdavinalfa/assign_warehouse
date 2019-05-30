Imports MySql.Data.MySqlClient
Module connector
    Public cmd As MySqlCommand
    Public Con As MySqlConnection
    Public adapter As MySqlDataAdapter
    Public reader As MySqlDataReader
    Public sql As String
    Public dataset As DataSet
    Dim str As String

    Sub connect2db()
        Try
            str = "Server=localhost;user id=root;password=Davinalfa123;database=hw_warehouse"
            Con = New MySqlConnection(str)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
                If Con.State = ConnectionState.Open Then
                    'MessageBox.Show("CONNECTED!")
                End If
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function checkConnect() As Boolean
        Try
            str = "Server=localhost;user id=root;password=Davinalfa123;database=hw_warehouse"
            Con = New MySqlConnection(str)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
                Return True
            End If
            Return False

        Catch ex As Exception
            Return False
        End Try
    End Function

End Module
