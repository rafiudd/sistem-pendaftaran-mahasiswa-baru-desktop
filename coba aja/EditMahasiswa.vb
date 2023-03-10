Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditMahasiswa
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim name, gender, address, jurusan, birthday, email, kelas As String
        Dim photo() As Byte

        name = update_fullname.Text
        gender = update_jenis_kelamin.Text
        address = update_address.Text
        jurusan = update_jurusan.Text
        email = update_email.Text
        kelas = update_kelas.Text
        birthday = Format(update_tanggal_lahir.Value, "dd-MM-yyyy")


        Using ms As New MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            photo = ms.ToArray()
        End Using


        'PictureBox1.Image.Save(stream, PictureBox1.Image.RawFormat)
        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "UPDATE mahasiswa SET name='" & name & "', gender='" & gender & "', address='" & address & "',  email='" & email & "',  birthday='" & birthday & "', jurusan='" & jurusan & "', photo=@photo, kelas='" & kelas & "' WHERE id='" & update_id.Text & "'"
                command = New MySqlCommand(sql, connect)
                command.Parameters.Add("@photo", MySqlDbType.Blob).Value = photo
                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Edit Data")
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

    Private Sub EditMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadDataJurusan()
        LoadDataById()

        If update_jurusan.Text IsNot "" Then
            LoadDataKelas()
        End If
    End Sub

    Private Sub LoadDataById()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM mahasiswa  WHERE id='" & update_id.Text & "'"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)
                reader = command.ExecuteReader

                Do While reader.Read
                    update_fullname.Text = reader.Item("name")
                    update_jenis_kelamin.Text = reader.Item("gender")
                    update_address.Text = reader.Item("address")
                    update_jurusan.Text = reader.Item("jurusan")
                    update_tanggal_lahir.Value = reader.Item("birthday")
                    update_email.Text = reader.Item("email")
                    update_kelas.Text = reader.Item("kelas")

                    Dim bytes As Byte() = CType(reader.Item("photo"), Byte())
                    PictureBox1.Image = Image.FromStream(New MemoryStream(bytes))
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

    Private Sub upload_photo_Click(sender As Object, e As EventArgs) Handles upload_photo.Click
        Dim open_file As New OpenFileDialog

        open_file.Filter = "Choose Image(*.JPG;*.PNG;*GIF)|*.jpg;*.png;*gif"

        If open_file.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open_file.FileName)
        End If
    End Sub

    Private Sub LoadDataKelas()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT name FROM kelas where jurusan='" & update_jurusan.Text & "'"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)

                reader = command.ExecuteReader

                Do While reader.Read
                    ListBox.Items.Add(reader.Item("name"))
                Loop
            Catch ex As Exception
                MessageBox.Show("EHEHe")
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub ClearDataKelas()
        ListBox.Items.Clear()
    End Sub

    Private Sub update_jurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles update_jurusan.SelectionChangeCommitted
        ClearDataKelas()
        LoadDataKelas()
    End Sub

    Private Sub ClearData()
        update_email.Text = ""
        update_fullname.Text = ""
        update_address.Text = ""
        update_jurusan.Text = ""
        update_jenis_kelamin.Text = ""
        update_jurusan.Text = ""
        update_tanggal_lahir.Value = Now
        update_kelas.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        Dim array As String()
        Dim kelas As String
        array = ListBox.CheckedItems.Cast(Of String).ToArray
        kelas = String.Join(",", array)

        update_kelas.Text = kelas
    End Sub
End Class