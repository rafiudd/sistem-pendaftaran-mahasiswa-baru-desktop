
Imports MySql.Data.MySqlClient

Public Class Login

    Private headerColor As Color = Color.Transparent

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim username, password As String

        username = UsernameI.Text
        password = PasswordI.Text

        If open_db() Then
            Try
                Dim sql As String = "SELECT * FROM users where username='" & username & "' AND password='" & password & "' "
                command = New MySqlCommand(sql, connect)
                reader = command.ExecuteReader

                If reader.HasRows Then
                    MessageBox.Show("Sukses Login")
                    Me.Hide()
                    Mahasiswa.Show()
                Else
                    MessageBox.Show("Username dan password salah")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX

        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class
