Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditFakultas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim name As String
        Dim stream As New MemoryStream

        name = update_fakultas.Text

        UpdateJurusan()

        connect.Close()

        If open_db() Then
            Try

                Dim sql As String = "UPDATE fakultas SET name='" & name & "' WHERE id='" & ID.Text & "'"
                command = New MySqlCommand(sql, connect)
                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Update Data")
                ClearData()

                Me.Hide()
                Fakultas.Show()
                Fakultas.refresh_data(sender, e)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try

        End If
    End Sub

    Public P_Studi As String

    Private Sub LoadDataById()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM fakultas WHERE id='" & ID.Text & "'"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)
                reader = command.ExecuteReader

                Do While reader.Read
                    update_fakultas.Text = reader.Item("name")
                    P_Studi = reader.Item("name")
                Loop
                reader.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub
    Private Sub UpdateJurusan()
        connect.Close()
        Dim command2 As MySqlCommand

        If open_db() Then
            Try
                Dim sql_kelas As String = "UPDATE jurusan SET fakultas='" & update_fakultas.Text & "' WHERE fakultas='" & P_Studi & "'"
                command2 = New MySqlCommand(sql_kelas, connect)
                command2.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub ClearData()
        update_fakultas.Text = ""
    End Sub

    Private Sub AddFakultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        LoadDataById()
    End Sub
End Class