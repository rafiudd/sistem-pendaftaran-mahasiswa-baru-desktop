Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditMahasiswa
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim username, password, address As String

        username = update_username.Text
        password = update_password.Text
        address = update_address.Text

        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "INSERT INTO users VALUES(NULL,'" & username & "', '" & password & "', '" & address & "')"
                command = New MySqlCommand(sql, connect)
                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Tambah Data")

                Me.Hide()
                Mahasiswa.Show()
                Mahasiswa.refresh_data(sender, e)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try

        End If
    End Sub
End Class