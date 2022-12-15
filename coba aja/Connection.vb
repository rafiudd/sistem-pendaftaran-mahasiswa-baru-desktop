Imports MySql.Data.MySqlClient

Module Connection
    Public connect As New MySqlConnection
    Dim result As Boolean

    Public Function open_db() As Boolean
        Try
            If connect.State = ConnectionState.Closed Then
                connect.ConnectionString = "server=localhost;userid=root;password='';database=coba;"
                connect.Open()
                result = True
            End If
        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function
End Module
