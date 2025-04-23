<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblCari = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.BackColor = System.Drawing.Color.Transparent
        Me.lblCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lblCari.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCari.Location = New System.Drawing.Point(35, 94)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(292, 17)
        Me.lblCari.TabIndex = 24
        Me.lblCari.Text = "Masukan Nama Penyewa Yang Ingin Di Cari :"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCari.Location = New System.Drawing.Point(359, 118)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(103, 38)
        Me.btnCari.TabIndex = 23
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(102, 125)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(225, 26)
        Me.txtCari.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(102, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(846, 500)
        Me.DataGridView1.TabIndex = 21
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHapus.Location = New System.Drawing.Point(468, 118)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(103, 38)
        Me.btnHapus.TabIndex = 26
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnkembali.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnkembali.Location = New System.Drawing.Point(845, 673)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(103, 38)
        Me.btnkembali.TabIndex = 28
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(303, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(426, 36)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "FORM LIHAT LIST PENYEWA"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication12.My.Resources.Resources.Background_Virtual_Nobar_Sepak_Bola_Digital_Biru
        Me.ClientSize = New System.Drawing.Size(1068, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.lblCari)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
