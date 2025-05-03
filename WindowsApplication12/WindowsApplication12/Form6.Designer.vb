<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbLapangan = New System.Windows.Forms.ComboBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.txtJamMulai = New System.Windows.Forms.TextBox()
        Me.txtJamSelesai = New System.Windows.Forms.TextBox()
        Me.TxtNomorTelepon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Location = New System.Drawing.Point(117, 247)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(114, 38)
        Me.btnSimpan.TabIndex = 59
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.BackColor = System.Drawing.Color.White
        Me.lblCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblCari.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCari.Location = New System.Drawing.Point(592, 228)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(292, 17)
        Me.lblCari.TabIndex = 58
        Me.lblCari.Text = "Masukan Nama Penyewa Yang Ingin Di Cari :"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCari.Location = New System.Drawing.Point(916, 252)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(103, 38)
        Me.btnCari.TabIndex = 57
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(659, 259)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(225, 26)
        Me.txtCari.TabIndex = 56
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(117, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(878, 248)
        Me.DataGridView1.TabIndex = 55
        '
        'cmbLapangan
        '
        Me.cmbLapangan.FormattingEnabled = True
        Me.cmbLapangan.Location = New System.Drawing.Point(660, 129)
        Me.cmbLapangan.Name = "cmbLapangan"
        Me.cmbLapangan.Size = New System.Drawing.Size(275, 28)
        Me.cmbLapangan.TabIndex = 74
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(239, 177)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(275, 26)
        Me.dtpTanggal.TabIndex = 73
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(239, 62)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(275, 26)
        Me.txtNama.TabIndex = 68
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(239, 140)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(275, 26)
        Me.txtTotalHarga.TabIndex = 72
        '
        'txtJamMulai
        '
        Me.txtJamMulai.Location = New System.Drawing.Point(660, 62)
        Me.txtJamMulai.Name = "txtJamMulai"
        Me.txtJamMulai.Size = New System.Drawing.Size(275, 26)
        Me.txtJamMulai.TabIndex = 71
        '
        'txtJamSelesai
        '
        Me.txtJamSelesai.Location = New System.Drawing.Point(660, 97)
        Me.txtJamSelesai.Name = "txtJamSelesai"
        Me.txtJamSelesai.Size = New System.Drawing.Size(275, 26)
        Me.txtJamSelesai.TabIndex = 70
        '
        'TxtNomorTelepon
        '
        Me.TxtNomorTelepon.Location = New System.Drawing.Point(239, 100)
        Me.TxtNomorTelepon.Name = "TxtNomorTelepon"
        Me.TxtNomorTelepon.Size = New System.Drawing.Size(275, 26)
        Me.TxtNomorTelepon.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(161, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(120, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Total Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(552, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Lapangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(538, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Jam Selesai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(146, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(553, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Jam Mulai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(95, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Nomor Telepon"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication12.My.Resources.Resources.Background_Virtual_Nobar_Sepak_Bola_Digital_Biru
        Me.ClientSize = New System.Drawing.Size(1115, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbLapangan)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.txtJamMulai)
        Me.Controls.Add(Me.txtJamSelesai)
        Me.Controls.Add(Me.TxtNomorTelepon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblCari)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbLapangan As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtJamMulai As System.Windows.Forms.TextBox
    Friend WithEvents txtJamSelesai As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomorTelepon As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
