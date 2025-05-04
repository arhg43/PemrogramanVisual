<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtJamMulai = New System.Windows.Forms.TextBox()
        Me.TxtNomorTelepon = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.cmbLapangan = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbLamaSewa = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(166, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(557, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lapangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(583, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(100, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(137, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jam Mulai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(151, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(543, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Lama Sewa"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(114, 344)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(878, 248)
        Me.DataGridView1.TabIndex = 17
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(656, 303)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(225, 26)
        Me.txtCari.TabIndex = 18
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCari.Location = New System.Drawing.Point(913, 296)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(103, 38)
        Me.btnCari.TabIndex = 19
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.BackColor = System.Drawing.Color.White
        Me.lblCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblCari.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCari.Location = New System.Drawing.Point(589, 272)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(292, 17)
        Me.lblCari.TabIndex = 20
        Me.lblCari.Text = "Masukan Nama Penyewa Yang Ingin Di Cari :"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Location = New System.Drawing.Point(114, 291)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(114, 38)
        Me.btnSimpan.TabIndex = 21
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(244, 189)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(275, 26)
        Me.dtpTanggal.TabIndex = 43
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(244, 112)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(275, 26)
        Me.txtNama.TabIndex = 36
        '
        'txtJamMulai
        '
        Me.txtJamMulai.Location = New System.Drawing.Point(244, 221)
        Me.txtJamMulai.Name = "txtJamMulai"
        Me.txtJamMulai.Size = New System.Drawing.Size(275, 26)
        Me.txtJamMulai.TabIndex = 41
        '
        'TxtNomorTelepon
        '
        Me.TxtNomorTelepon.Location = New System.Drawing.Point(244, 150)
        Me.TxtNomorTelepon.Name = "TxtNomorTelepon"
        Me.TxtNomorTelepon.Size = New System.Drawing.Size(275, 26)
        Me.TxtNomorTelepon.TabIndex = 37
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUbah.Location = New System.Drawing.Point(244, 291)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(114, 38)
        Me.btnUbah.TabIndex = 44
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHapus.Location = New System.Drawing.Point(373, 290)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(120, 39)
        Me.btnHapus.TabIndex = 45
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'cmbLapangan
        '
        Me.cmbLapangan.FormattingEnabled = True
        Me.cmbLapangan.Location = New System.Drawing.Point(665, 152)
        Me.cmbLapangan.Name = "cmbLapangan"
        Me.cmbLapangan.Size = New System.Drawing.Size(275, 28)
        Me.cmbLapangan.TabIndex = 46
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(665, 191)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(275, 28)
        Me.cmbStatus.TabIndex = 47
        '
        'cmbLamaSewa
        '
        Me.cmbLamaSewa.FormattingEnabled = True
        Me.cmbLamaSewa.Location = New System.Drawing.Point(665, 115)
        Me.cmbLamaSewa.Name = "cmbLamaSewa"
        Me.cmbLamaSewa.Size = New System.Drawing.Size(275, 28)
        Me.cmbLamaSewa.TabIndex = 48
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 719)
        Me.Controls.Add(Me.cmbLamaSewa)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbLapangan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtJamMulai)
        Me.Controls.Add(Me.TxtNomorTelepon)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtJamMulai As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomorTelepon As System.Windows.Forms.TextBox
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents cmbLapangan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLamaSewa As System.Windows.Forms.ComboBox
End Class
