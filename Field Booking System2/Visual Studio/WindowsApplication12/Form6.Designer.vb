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
        Me.cmbLapangan = New System.Windows.Forms.ComboBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtJamMulai = New System.Windows.Forms.TextBox()
        Me.TxtNomorTelepon = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLamaSewa = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbLapangan
        '
        Me.cmbLapangan.FormattingEnabled = True
        Me.cmbLapangan.Location = New System.Drawing.Point(668, 135)
        Me.cmbLapangan.Name = "cmbLapangan"
        Me.cmbLapangan.Size = New System.Drawing.Size(275, 28)
        Me.cmbLapangan.TabIndex = 69
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(247, 142)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(275, 26)
        Me.dtpTanggal.TabIndex = 66
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(247, 68)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(275, 26)
        Me.txtNama.TabIndex = 60
        '
        'txtJamMulai
        '
        Me.txtJamMulai.Location = New System.Drawing.Point(668, 68)
        Me.txtJamMulai.Name = "txtJamMulai"
        Me.txtJamMulai.Size = New System.Drawing.Size(275, 26)
        Me.txtJamMulai.TabIndex = 64
        '
        'TxtNomorTelepon
        '
        Me.TxtNomorTelepon.Location = New System.Drawing.Point(247, 106)
        Me.TxtNomorTelepon.Name = "TxtNomorTelepon"
        Me.TxtNomorTelepon.Size = New System.Drawing.Size(275, 26)
        Me.TxtNomorTelepon.TabIndex = 61
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(169, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nama"
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(117, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(878, 248)
        Me.DataGridView1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(560, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Lapangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(546, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Lama Sewa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(154, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(561, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Jam Mulai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(103, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Nomor Telepon"
        '
        'cmbLamaSewa
        '
        Me.cmbLamaSewa.FormattingEnabled = True
        Me.cmbLamaSewa.Location = New System.Drawing.Point(668, 100)
        Me.cmbLamaSewa.Name = "cmbLamaSewa"
        Me.cmbLamaSewa.Size = New System.Drawing.Size(275, 28)
        Me.cmbLamaSewa.TabIndex = 70
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbLamaSewa)
        Me.Controls.Add(Me.cmbLapangan)
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmbLapangan As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtJamMulai As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomorTelepon As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbLamaSewa As System.Windows.Forms.ComboBox
End Class
