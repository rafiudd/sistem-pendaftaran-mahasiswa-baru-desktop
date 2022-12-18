Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AddFakultas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As MySqlCommand
        Dim class_name As String
        Dim stream As New MemoryStream

        class_name = add_fakultas.Text

        connect.Close()

        If open_db() Then
            Try
                Dim sql As String = "INSERT INTO fakultas VALUES(NULL,'" & class_name & "')"
                command = New MySqlCommand(sql, connect)
                command.ExecuteNonQuery()

                MessageBox.Show("Sukses Tambah Data")
                ClearData()

                Me.Hide()
                Fakultas.Show()
                Fakultas.refresh_data(sender, e)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connect.Close()
            End Try

        End If
    End Sub

    Private Sub ClearData()
        add_fakultas.Text = ""
    End Sub

    Private Sub AddFakultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
End Class