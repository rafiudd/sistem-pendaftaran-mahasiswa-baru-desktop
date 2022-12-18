Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AddKelas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim class_name, class_code, dosen, jurusan As String
        Dim stream As New MemoryStream

        class_name = add_class.Text
        class_code = add_class_code.Text
        jurusan = add_jurusan.Text
        dosen = add_dosen.Text

        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "INSERT INTO kelas VALUES(NULL,'" & class_name & "', '" & dosen & "', '" & class_code & "', '" & jurusan & "')"
                command = New MySqlCommand(sql, connect)
                command.Parameters.Add("@photo", MySqlDbType.Blob).Value = stream.ToArray()

                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Tambah Data")
                ClearData()

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

    Private Sub ClearData()
        add_class_code.Text = ""
        add_dosen.Text = ""
        add_class.Text = ""
        add_jurusan.Text = ""
    End Sub

    Private Sub AddKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadDataJurusan()
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
                    add_jurusan.Items.Add(reader.Item("name"))
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub
End Class