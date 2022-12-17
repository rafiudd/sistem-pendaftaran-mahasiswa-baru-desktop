<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.add_phone = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.add_address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.birth = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.add_tanggal_lahir = New System.Windows.Forms.DateTimePicker()
        Me.add_jenis_kelamin = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.add_jurusan = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.upload_photo = New System.Windows.Forms.Label()
        Me.add_fullname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel4.Controls.Add(Me.add_phone)
        Me.Panel4.Location = New System.Drawing.Point(85, 556)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(455, 60)
        Me.Panel4.TabIndex = 8
        '
        'add_phone
        '
        Me.add_phone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add_phone.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.add_phone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.add_phone.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_phone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_phone.Location = New System.Drawing.Point(20, 17)
        Me.add_phone.Margin = New System.Windows.Forms.Padding(30)
        Me.add_phone.Name = "add_phone"
        Me.add_phone.PlaceholderText = "Masukan No HP"
        Me.add_phone.Size = New System.Drawing.Size(402, 23)
        Me.add_phone.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel3.Controls.Add(Me.add_fullname)
        Me.Panel3.Location = New System.Drawing.Point(85, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(455, 60)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel1.Controls.Add(Me.add_address)
        Me.Panel1.Location = New System.Drawing.Point(85, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 145)
        Me.Panel1.TabIndex = 9
        '
        'add_address
        '
        Me.add_address.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add_address.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.add_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.add_address.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_address.Location = New System.Drawing.Point(20, 20)
        Me.add_address.Margin = New System.Windows.Forms.Padding(30)
        Me.add_address.Multiline = True
        Me.add_address.Name = "add_address"
        Me.add_address.PlaceholderText = "Masukan Alamat"
        Me.add_address.Size = New System.Drawing.Size(414, 108)
        Me.add_address.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(82, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tambah Data"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Inter SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(380, 673)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(455, 58)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Simpan Data"
        Me.Button1.UseVisualStyleBackColor = False
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel5.Controls.Add(Me.birth)
        Me.Panel5.Controls.Add(Me.add_tanggal_lahir)
        Me.Panel5.Location = New System.Drawing.Point(85, 453)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(455, 84)
        Me.Panel5.TabIndex = 12
        '
        'add_tanggal_lahir
        '
        Me.add_tanggal_lahir.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.add_tanggal_lahir.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_tanggal_lahir.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_tanggal_lahir.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_tanggal_lahir.Location = New System.Drawing.Point(20, 39)
        Me.add_tanggal_lahir.Name = "add_tanggal_lahir"
        Me.add_tanggal_lahir.Size = New System.Drawing.Size(414, 27)
        Me.add_tanggal_lahir.TabIndex = 12
        '
        'add_jenis_kelamin
        '
        Me.add_jenis_kelamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_jenis_kelamin.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_jenis_kelamin.FormattingEnabled = True
        Me.add_jenis_kelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.add_jenis_kelamin.Location = New System.Drawing.Point(22, 40)
        Me.add_jenis_kelamin.Name = "add_jenis_kelamin"
        Me.add_jenis_kelamin.Size = New System.Drawing.Size(413, 27)
        Me.add_jenis_kelamin.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.add_jenis_kelamin)
        Me.Panel2.Location = New System.Drawing.Point(85, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 84)
        Me.Panel2.TabIndex = 13
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
        'add_jurusan
        '
        Me.add_jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.add_jurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_jurusan.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_jurusan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_jurusan.FormattingEnabled = True
        Me.add_jurusan.Location = New System.Drawing.Point(22, 40)
        Me.add_jurusan.Name = "add_jurusan"
        Me.add_jurusan.Size = New System.Drawing.Size(413, 27)
        Me.add_jurusan.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.add_jurusan)
        Me.Panel6.Location = New System.Drawing.Point(580, 106)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(455, 84)
        Me.Panel6.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel7.Controls.Add(Me.upload_photo)
        Me.Panel7.Location = New System.Drawing.Point(580, 453)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(205, 38)
        Me.Panel7.TabIndex = 9
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
        'add_fullname
        '
        Me.add_fullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.add_fullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.add_fullname.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_fullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_fullname.Location = New System.Drawing.Point(20, 17)
        Me.add_fullname.Margin = New System.Windows.Forms.Padding(20)
        Me.add_fullname.Name = "add_fullname"
        Me.add_fullname.PlaceholderText = "Masukan Nama Lengkap"
        Me.add_fullname.Size = New System.Drawing.Size(427, 23)
        Me.add_fullname.TabIndex = 1
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
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Location = New System.Drawing.Point(580, 218)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(205, 217)
        Me.Panel8.TabIndex = 17
        '
        'AddMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1105, 757)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddMahasiswa"
        Me.Text = "Form2"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents add_phone As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents add_address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents birth As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents add_tanggal_lahir As DateTimePicker
    Friend WithEvents add_jenis_kelamin As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents add_jurusan As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents upload_photo As Label
    Friend WithEvents add_fullname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel8 As Panel
End Class
