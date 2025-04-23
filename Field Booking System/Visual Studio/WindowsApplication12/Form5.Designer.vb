<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtnewUser = New System.Windows.Forms.TextBox()
        Me.btnRegis = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtnewPass = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(274, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 36)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FORM REGISTRASI"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.txtnewUser)
        Me.Panel1.Controls.Add(Me.btnRegis)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.txtnewPass)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(118, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 298)
        Me.Panel1.TabIndex = 7
        '
        'txtnewUser
        '
        Me.txtnewUser.Location = New System.Drawing.Point(190, 90)
        Me.txtnewUser.Name = "txtnewUser"
        Me.txtnewUser.Size = New System.Drawing.Size(274, 26)
        Me.txtnewUser.TabIndex = 2
        '
        'btnRegis
        '
        Me.btnRegis.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegis.Location = New System.Drawing.Point(362, 206)
        Me.btnRegis.Name = "btnRegis"
        Me.btnRegis.Size = New System.Drawing.Size(102, 34)
        Me.btnRegis.TabIndex = 4
        Me.btnRegis.Text = "Registrasi"
        Me.btnRegis.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblUsername.Location = New System.Drawing.Point(62, 91)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'txtnewPass
        '
        Me.txtnewPass.Location = New System.Drawing.Point(190, 144)
        Me.txtnewPass.Name = "txtnewPass"
        Me.txtnewPass.Size = New System.Drawing.Size(274, 26)
        Me.txtnewPass.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassword.Location = New System.Drawing.Point(66, 145)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 25)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 462)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtnewUser As System.Windows.Forms.TextBox
    Friend WithEvents btnRegis As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtnewPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
End Class
