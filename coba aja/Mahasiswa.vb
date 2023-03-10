
Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports coba_aja.My.Resources
Imports MySql.Data.MySqlClient

Public Class Mahasiswa

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

    Private Sub Maha_Click(sender As Object, e As EventArgs) Handles Maha.Click

    End Sub

    Private Sub Mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data_adapter As DataAdapter
        Dim data_set As DataSet
        Dim query As String

        Me.CenterToScreen()

        DataGridView1.Update()
        DataGridView1.RefreshEdit()


        connect.Close()

        If open_db() Then
            data_set = New DataSet
            query = "SELECT id, name, gender, jurusan, created_at FROM mahasiswa ORDER BY id DESC"
            Try
                data_adapter = New MySqlDataAdapter(query, connect)

                data_adapter.Fill(data_set)
                DataGridView1.DataSource = data_set.Tables(0)
                DataGridView1.Columns(0).HeaderText = "ID"
                DataGridView1.Columns(1).HeaderText = "Nama Lengkap"
                DataGridView1.Columns(2).HeaderText = "Gender"
                DataGridView1.Columns(3).HeaderText = "Program Studi"
                DataGridView1.Columns(4).HeaderText = "Tanggal Mendaftar"

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
        AddMahasiswa.Show()
    End Sub

    Public Sub refresh_data(sender As Object, e As EventArgs)
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Mahasiswa_Load(e, e) 'Load everything in your form, load event again

        Me.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Delete data
        Dim command As MySqlCommand


        If e.ColumnIndex = 6 Then
            If e.RowIndex < 0 Then
                Return
            End If

            Dim r1 As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            MessageBox.Show(r1.Cells("ID").Value)

            If open_db() Then
                Try
                    Dim sql As String = "DELETE FROM mahasiswa WHERE id='" & r1.Cells("ID").Value & "'"
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
            EditMahasiswa.update_id.Text = r1.Cells("ID").Value

            EditMahasiswa.Show()
        End If
    End Sub

    Private Sub kelas_nav_Click(sender As Object, e As EventArgs) Handles kelas_nav.Click
        Hide()

        kelas_form.Visible = True
        kelas_form.refresh_data(e, e)
    End Sub

    Private Sub program_nav_Click(sender As Object, e As EventArgs) Handles program_nav.Click
        Hide()
        ProgramStudi.Visible = True
        ProgramStudi.refresh_data(e, e)
    End Sub

    Private Sub fakultas_nav_Click(sender As Object, e As EventArgs) Handles fakultas_nav.Click
        Hide()
        Fakultas.Show()
        Fakultas.refresh_data(e, e)
    End Sub
End Class
