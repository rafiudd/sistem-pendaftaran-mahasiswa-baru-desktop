Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditKelas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim class_name, class_code, dosen, jurusan As String
        Dim stream As New MemoryStream

        class_name = update_class.Text
        class_code = update_class_code.Text
        jurusan = update_jurusan.Text
        dosen = update_dosen.Text

        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "UPDATE kelas SET name='" & class_name & "', teacher='" & dosen & "', code='" & class_code & "', jurusan='" & jurusan & "' WHERE id='" & ID.Text & "'"
                command = New MySqlCommand(sql, connect)

                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Update Data")
                Me.Hide()
                kelas_form.Show()
                kelas_form.refresh_data(sender, e)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try

        End If
    End Sub

    Private Sub EditKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadDataJurusan()
        LoadDataById()
    End Sub

    Private Sub LoadDataById()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM kelas WHERE id='" & ID.Text & "'"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)
                reader = command.ExecuteReader

                Do While reader.Read
                    update_class.Text = reader.Item("name")
                    update_class_code.Text = reader.Item("code")
                    update_dosen.Text = reader.Item("teacher")
                    update_jurusan.Text = reader.Item("jurusan")
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub LoadDataJurusan()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT name FROM jurusan"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)

                reader = command.ExecuteReader

                Do While reader.Read
                    update_jurusan.Items.Add(reader.Item("name"))
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub
End Class