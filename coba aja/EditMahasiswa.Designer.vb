<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.update_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.upload_photo = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.update_jurusan = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.update_jenis_kelamin = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.birth = New System.Windows.Forms.Label()
        Me.update_tanggal_lahir = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.update_email = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.update_fullname = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.update_address = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'update_id
        '
        Me.update_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.update_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_id.Enabled = False
        Me.update_id.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_id.Location = New System.Drawing.Point(125, 130)
        Me.update_id.Margin = New System.Windows.Forms.Padding(20)
        Me.update_id.Name = "update_id"
        Me.update_id.PlaceholderText = "ID"
        Me.update_id.ReadOnly = True
        Me.update_id.Size = New System.Drawing.Size(427, 23)
        Me.update_id.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(96, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Edit Data"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Inter SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(381, 664)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(455, 58)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(105, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 60)
        Me.Panel2.TabIndex = 9
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel7.Controls.Add(Me.upload_photo)
        Me.Panel7.Location = New System.Drawing.Point(604, 543)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(205, 38)
        Me.Panel7.TabIndex = 20
        '
        'upload_photo
        '
        Me.upload_photo.AutoSize = True
        Me.upload_photo.Font = New System.Drawing.Font("Inter Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.upload_photo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.upload_photo.Location = New System.Drawing.Point(14, 10)
        Me.upload_photo.Name = "upload_photo"
        Me.upload_photo.Size = New System.Drawing.Size(91, 17)
        Me.upload_photo.TabIndex = 16
        Me.upload_photo.Text = "Upload Foto "
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.update_jurusan)
        Me.Panel6.Location = New System.Drawing.Point(604, 197)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(455, 84)
        Me.Panel6.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pilih Jurusan"
        '
        'update_jurusan
        '
        Me.update_jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.update_jurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_jurusan.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_jurusan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.update_jurusan.FormattingEnabled = True
        Me.update_jurusan.Location = New System.Drawing.Point(22, 40)
        Me.update_jurusan.Name = "update_jurusan"
        Me.update_jurusan.Size = New System.Drawing.Size(413, 27)
        Me.update_jurusan.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.update_jenis_kelamin)
        Me.Panel1.Location = New System.Drawing.Point(105, 277)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 84)
        Me.Panel1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Kelamin"
        '
        'update_jenis_kelamin
        '
        Me.update_jenis_kelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.update_jenis_kelamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_jenis_kelamin.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_jenis_kelamin.FormattingEnabled = True
        Me.update_jenis_kelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.update_jenis_kelamin.Location = New System.Drawing.Point(22, 40)
        Me.update_jenis_kelamin.Name = "update_jenis_kelamin"
        Me.update_jenis_kelamin.Size = New System.Drawing.Size(413, 27)
        Me.update_jenis_kelamin.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel5.Controls.Add(Me.birth)
        Me.Panel5.Controls.Add(Me.update_tanggal_lahir)
        Me.Panel5.Location = New System.Drawing.Point(105, 543)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(455, 84)
        Me.Panel5.TabIndex = 22
        '
        'birth
        '
        Me.birth.AutoSize = True
        Me.birth.Font = New System.Drawing.Font("Inter Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.birth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.birth.Location = New System.Drawing.Point(18, 15)
        Me.birth.Name = "birth"
        Me.birth.Size = New System.Drawing.Size(97, 17)
        Me.birth.TabIndex = 0
        Me.birth.Text = "Tanggal Lahir"
        '
        'update_tanggal_lahir
        '
        Me.update_tanggal_lahir.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.update_tanggal_lahir.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.update_tanggal_lahir.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.update_tanggal_lahir.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_tanggal_lahir.Location = New System.Drawing.Point(20, 39)
        Me.update_tanggal_lahir.Name = "update_tanggal_lahir"
        Me.update_tanggal_lahir.Size = New System.Drawing.Size(414, 27)
        Me.update_tanggal_lahir.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel4.Controls.Add(Me.update_email)
        Me.Panel4.Location = New System.Drawing.Point(604, 112)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(455, 60)
        Me.Panel4.TabIndex = 19
        '
        'update_email
        '
        Me.update_email.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.update_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.update_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_email.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.update_email.Location = New System.Drawing.Point(20, 17)
        Me.update_email.Margin = New System.Windows.Forms.Padding(30)
        Me.update_email.Name = "update_email"
        Me.update_email.PlaceholderText = "Masukan Email"
        Me.update_email.Size = New System.Drawing.Size(417, 23)
        Me.update_email.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel3.Controls.Add(Me.update_fullname)
        Me.Panel3.Location = New System.Drawing.Point(105, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(455, 60)
        Me.Panel3.TabIndex = 18
        '
        'update_fullname
        '
        Me.update_fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.update_fullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_fullname.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_fullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.update_fullname.Location = New System.Drawing.Point(20, 17)
        Me.update_fullname.Margin = New System.Windows.Forms.Padding(20)
        Me.update_fullname.Name = "update_fullname"
        Me.update_fullname.PlaceholderText = "Masukan Nama Lengkap"
        Me.update_fullname.Size = New System.Drawing.Size(427, 23)
        Me.update_fullname.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel8.Controls.Add(Me.update_address)
        Me.Panel8.Location = New System.Drawing.Point(105, 381)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(455, 145)
        Me.Panel8.TabIndex = 21
        '
        'update_address
        '
        Me.update_address.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.update_address.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.update_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_address.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.update_address.Location = New System.Drawing.Point(20, 20)
        Me.update_address.Margin = New System.Windows.Forms.Padding(30)
        Me.update_address.Multiline = True
        Me.update_address.Name = "update_address"
        Me.update_address.PlaceholderText = "Masukan Alamat"
        Me.update_address.Size = New System.Drawing.Size(415, 112)
        Me.update_address.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Location = New System.Drawing.Point(604, 309)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(205, 217)
        Me.Panel9.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'EditMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1141, 745)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.update_id)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EditMahasiswa"
        Me.Text = "Edit Mahasiswa"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents update_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents upload_photo As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents update_jurusan As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents update_jenis_kelamin As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents birth As Label
    Friend WithEvents update_tanggal_lahir As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents update_email As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents update_fullname As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents update_address As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
