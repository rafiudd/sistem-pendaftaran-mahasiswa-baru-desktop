Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AddMahasiswa
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim name, gender, address, jurusan, birthday, created_at As String
        Dim stream As New MemoryStream

        name = add_fullname.Text
        gender = add_jenis_kelamin.Text
        address = add_address.Text
        jurusan = add_jurusan.Text
        birthday = Format(add_tanggal_lahir.Value, "dd-MM-yyyy")
        created_at = Format(Now, "dd-MM-yyyy hh:ss")

        PictureBox1.Image.Save(stream, PictureBox1.Image.RawFormat)

        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "INSERT INTO mahasiswa VALUES(NULL,'" & name & "', '" & gender & "', '" & address & "', '" & birthday & "', '" & jurusan & "', @photo, '" & created_at & "')"
                command = New MySqlCommand(sql, connect)
                command.Parameters.Add("@photo", MySqlDbType.Blob).Value = stream.ToArray()

                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Tambah Data")
                ClearData()

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

    Private Sub ClearData()
        add_phone.Text = ""
        add_fullname.Text = ""
        add_address.Text = ""
        add_jurusan.Text = ""
        add_jenis_kelamin.Text = ""
        add_jurusan.Text = ""
        add_tanggal_lahir.Value = Now
        PictureBox1.Image = Nothing
    End Sub

    Private Sub AddMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub upload_photo_Click(sender As Object, e As EventArgs) Handles upload_photo.Click
        Dim open_file As New OpenFileDialog

        open_file.Filter = "Choose Image(*.JPG;*.PNG;*GIF)|*.jpg;*.png;*gif"

        If open_file.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open_file.FileName)
        End If
    End Sub
End Class