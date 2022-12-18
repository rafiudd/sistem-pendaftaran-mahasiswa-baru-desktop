<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddKelas
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.add_dosen = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.add_class = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.add_jurusan = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.add_class_code = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel4.Controls.Add(Me.add_dosen)
        Me.Panel4.Location = New System.Drawing.Point(85, 188)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(455, 60)
        Me.Panel4.TabIndex = 8
        '
        'add_dosen
        '
        Me.add_dosen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add_dosen.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.add_dosen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.add_dosen.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_dosen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_dosen.Location = New System.Drawing.Point(20, 17)
        Me.add_dosen.Margin = New System.Windows.Forms.Padding(30)
        Me.add_dosen.Name = "add_dosen"
        Me.add_dosen.PlaceholderText = "Masukan Nama Dosen"
        Me.add_dosen.Size = New System.Drawing.Size(402, 23)
        Me.add_dosen.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel3.Controls.Add(Me.add_class)
        Me.Panel3.Location = New System.Drawing.Point(85, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(455, 60)
        Me.Panel3.TabIndex = 7
        '
        'add_class
        '
        Me.add_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.add_class.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.add_class.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_class.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_class.Location = New System.Drawing.Point(20, 17)
        Me.add_class.Margin = New System.Windows.Forms.Padding(20)
        Me.add_class.Name = "add_class"
        Me.add_class.PlaceholderText = "Masukan Nama Kelas"
        Me.add_class.Size = New System.Drawing.Size(427, 23)
        Me.add_class.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(76, 31)
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
        Me.Button1.Location = New System.Drawing.Point(85, 475)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(455, 58)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Simpan Data"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Panel6.Location = New System.Drawing.Point(85, 347)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(455, 84)
        Me.Panel6.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel1.Controls.Add(Me.add_class_code)
        Me.Panel1.Location = New System.Drawing.Point(85, 267)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 60)
        Me.Panel1.TabIndex = 9
        '
        'add_class_code
        '
        Me.add_class_code.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add_class_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.add_class_code.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.add_class_code.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_class_code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.add_class_code.Location = New System.Drawing.Point(20, 17)
        Me.add_class_code.Margin = New System.Windows.Forms.Padding(30)
        Me.add_class_code.Name = "add_class_code"
        Me.add_class_code.PlaceholderText = "Masukan Kode Kelas"
        Me.add_class_code.Size = New System.Drawing.Size(405, 23)
        Me.add_class_code.TabIndex = 2
        '
        'AddKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(630, 564)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddKelas"
        Me.Text = "Tambah Kelas"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents add_dosen As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents add_jurusan As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents add_class As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents add_class_code As TextBox
End Class
