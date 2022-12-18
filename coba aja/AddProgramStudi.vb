Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AddProgramStudi
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim class_name, jenjang, fakultas, code As String
        Dim stream As New MemoryStream

        class_name = add_program_studi.Text
        jenjang = add_jenjang.Text
        fakultas = add_fakultas.Text
        code = add_code.Text

        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "INSERT INTO jurusan VALUES(NULL,'" & class_name & "', '" & code & "', '" & jenjang & "', '" & fakultas & "')"
                command = New MySqlCommand(sql, connect)

                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Tambah Data")
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
        add_jenjang.Text = ""
        add_code.Text = ""
        add_program_studi.Text = ""
        add_fakultas.Text = ""
    End Sub

    Private Sub AddKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadDataFakultas()
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
                    add_fakultas.Items.Add(reader.Item("name"))
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub
End Class