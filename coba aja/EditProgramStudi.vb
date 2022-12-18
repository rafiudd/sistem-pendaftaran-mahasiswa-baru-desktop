Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditProgramStudi
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim class_name, jenjang, fakultas, code As String
        Dim stream As New MemoryStream

        class_name = update_program_studi.Text
        jenjang = update_jenjang.Text
        fakultas = update_fakultas.Text
        code = update_code.Text

        UpdateKelas()
        UpdateMahasiswa()

        connect.Close()

        If open_db() Then
            Try

                Dim sql As String = "UPDATE jurusan SET name='" & class_name & "', nick_name='" & code & "', grade='" & jenjang & "', fakultas='" & fakultas & "' WHERE id='" & ID.Text & "'"
                command = New MySqlCommand(sql, connect)
                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Update Data")
                ClearData()

                Me.Hide()
                ProgramStudi.Show()
                ProgramStudi.refresh_data(sender, e)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try

        End If
    End Sub

    Private Sub ClearData()
        update_jenjang.Text = ""
        update_code.Text = ""
        update_program_studi.Text = ""
        update_fakultas.Text = ""
    End Sub

    Private Sub AddKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadDataFakultas()
        LoadDataById()
    End Sub

    Public P_Studi As String

    Private Sub LoadDataById()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM jurusan WHERE id='" & ID.Text & "'"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)
                reader = command.ExecuteReader

                Do While reader.Read
                    update_jenjang.Text = reader.Item("grade")
                    update_code.Text = reader.Item("nick_name")
                    update_program_studi.Text = reader.Item("name")
                    update_fakultas.Text = reader.Item("fakultas")
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

    Private Sub UpdateKelas()
        connect.Close()
        Dim command2 As MySqlCommand

        If open_db() Then
            Try
                Dim sql_kelas As String = "UPDATE kelas SET jurusan='" & update_program_studi.Text & "' WHERE jurusan='" & P_Studi & "'"
                command2 = New MySqlCommand(sql_kelas, connect)
                command2.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub UpdateMahasiswa()
        connect.Close()
        Dim command2 As MySqlCommand

        If open_db() Then
            Try
                Dim sql_kelas As String = "UPDATE mahasiswa SET jurusan='" & update_program_studi.Text & "' WHERE jurusan='" & P_Studi & "'"
                command2 = New MySqlCommand(sql_kelas, connect)
                command2.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub LoadDataFakultas()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT name FROM fakultas"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)

                reader = command.ExecuteReader

                Do While reader.Read
                    update_fakultas.Items.Add(reader.Item("name"))
                Loop
                reader.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub
End Class