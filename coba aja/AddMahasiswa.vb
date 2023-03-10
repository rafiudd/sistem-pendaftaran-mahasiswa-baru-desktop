Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Net.Mail

Public Class AddMahasiswa
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim name, gender, address, jurusan, birthday, email, created_at, kelas As String
        Dim stream As New MemoryStream
        Dim array As String()

        name = add_fullname.Text
        gender = add_jenis_kelamin.Text
        address = add_address.Text
        jurusan = add_jurusan.Text
        email = add_email.Text
        birthday = Format(add_tanggal_lahir.Value, "dd-MM-yyyy")
        created_at = Format(Now, "dd-MM-yyyy hh:ss")

        array = CheckedListBox1.CheckedItems.Cast(Of String).ToArray
        kelas = String.Join(",", array)

        MessageBox.Show(kelas)
        PictureBox1.Image.Save(stream, PictureBox1.Image.RawFormat)

        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "INSERT INTO mahasiswa VALUES(NULL,'" & name & "', '" & gender & "', '" & address & "', '" & birthday & "', '" & email & "', '" & jurusan & "', '" & kelas & "', @photo, '" & created_at & "')"
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

    Private Sub SendEmail()
        Try
            Dim smtp_server As New SmtpClient
            Dim mail As New MailMessage

            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("sarjanalidi@gmail.com", "")
            smtp_server.Port = 587
            smtp_server.EnableSsl = False
            smtp_server.Host = "smtp.gmail.com"

            mail = New MailMessage()

            mail.From = New MailAddress("rayhanrafiudd@gmail.com")
            mail.To.Add("sirin6867@gmail.com")
            mail.Subject = "TEST"
            mail.Body = "TEST"

            smtp_server.Send(mail)
            MessageBox.Show("Sukses Kirim Email")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ClearData()
        add_email.Text = ""
        add_fullname.Text = ""
        add_address.Text = ""
        add_jurusan.Text = ""
        add_jenis_kelamin.Text = ""
        add_jurusan.Text = ""
        add_tanggal_lahir.Value = Now
        PictureBox1.Image = Nothing
    End Sub

    Private Sub AddMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub LoadDataKelas()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT name FROM kelas where jurusan='" & add_jurusan.Text & "'"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)

                reader = command.ExecuteReader

                Do While reader.Read
                    CheckedListBox1.Items.Add(reader(0))
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub ClearDataKelas()
        CheckedListBox1.Items.Clear()
    End Sub

    Private Sub upload_photo_Click(sender As Object, e As EventArgs) Handles upload_photo.Click
        Dim open_file As New OpenFileDialog

        open_file.Filter = "Choose Image(*.JPG;*.PNG;*GIF)|*.jpg;*.png;*gif"

        If open_file.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open_file.FileName)
        End If
    End Sub

    Private Sub add_jurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles add_jurusan.SelectedIndexChanged
        ClearDataKelas()
        LoadDataKelas()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub add_jurusan_SelectedValueChanged(sender As Object, e As EventArgs) Handles add_jurusan.SelectedValueChanged
        ClearDataKelas()
        LoadDataKelas()
    End Sub
End Class