
Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports coba_aja.My.Resources
Imports MySql.Data.MySqlClient

Public Class ProgramStudi

    Private headerColor As Color = Color.Transparent

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX

        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)
        draggable = False
    End Sub

    Private Sub KelasLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data_adapter As DataAdapter
        Dim data_set As DataSet
        Dim query As String
        Me.CenterToScreen()


        DataGridView1.Update()
        DataGridView1.RefreshEdit()

        connect.Close()

        If open_db() Then
            data_set = New DataSet
            query = "SELECT * FROM jurusan ORDER BY id DESC"
            Try
                data_adapter = New MySqlDataAdapter(query, connect)

                data_adapter.Fill(data_set)
                DataGridView1.DataSource = data_set.Tables(0)
                DataGridView1.Columns(0).HeaderText = "ID"
                DataGridView1.Columns(1).HeaderText = "Program Studi"
                DataGridView1.Columns(2).HeaderText = "Kode"
                DataGridView1.Columns(3).HeaderText = "Jenjang"
                DataGridView1.Columns(4).HeaderText = "Fakultas"

                Dim btn_edit As New DataGridViewButtonColumn()
                btn_edit.Name = "btn_edit"
                btn_edit.HeaderText = "Edit Data"
                btn_edit.Text = "EDIT"
                btn_edit.UseColumnTextForButtonValue = True
                DataGridView1.Columns.Insert(5, btn_edit)

                Dim btn_delete As New DataGridViewButtonColumn()
                btn_delete.Name = "btn_delete"
                btn_delete.HeaderText = "Delete Data"
                btn_delete.Text = "DELETE"
                btn_delete.UseColumnTextForButtonValue = True
                DataGridView1.Columns.Insert(6, btn_delete)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AddProgramStudi.Show()
    End Sub

    Public Sub refresh_data(sender As Object, e As EventArgs)
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        KelasLoad(e, e) 'Load everything in your form, load event again

        Me.Refresh()
    End Sub

    Public P_Studi As String
    Public ID As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Delete data
        Dim command As MySqlCommand


        If e.ColumnIndex = 6 Then
            If e.RowIndex < 0 Then
                Return
            End If

            Dim r1 As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ID = r1.Cells("ID").Value

            LoadDataById()
            UpdateKelas()
            UpdateMahasiswa()

            If open_db() Then
                Try
                    Dim sql As String = "DELETE FROM jurusan WHERE id='" & r1.Cells("ID").Value & "'"
                    command = New MySqlCommand(sql, connect)
                    command.ExecuteNonQuery()

                    MessageBox.Show("Sukses Delete Data")
                    refresh_data(sender, e)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    connect.Close()
                End Try
            End If
        ElseIf e.ColumnIndex = 5 Then
            If e.RowIndex < 0 Then
                Return
            End If

            Dim r1 As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            EditProgramStudi.ID.Text = r1.Cells("ID").Value

            EditProgramStudi.Show()
        End If
    End Sub

    Private Sub LoadDataById()
        connect.Close()
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query As String = "SELECT * FROM jurusan WHERE id='" & ID & "'"

        If open_db() Then
            Try
                command = New MySqlCommand(query, connect)
                reader = command.ExecuteReader

                Do While reader.Read
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
                Dim sql_kelas As String = "UPDATE kelas SET jurusan='' WHERE jurusan='" & P_Studi & "'"
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
                Dim sql_kelas As String = "UPDATE mahasiswa SET jurusan='' WHERE jurusan='" & P_Studi & "'"
                command2 = New MySqlCommand(sql_kelas, connect)
                command2.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub mahasiswa_nav_Click(sender As Object, e As EventArgs) Handles mahasiswa_nav.Click
        Me.Hide()
        Mahasiswa.Show()
        Mahasiswa.refresh_data(e, e)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Hide()
        kelas_form.Show()
        kelas_form.refresh_data(e, e)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Hide()
        Fakultas.Show()
    End Sub
End Class
