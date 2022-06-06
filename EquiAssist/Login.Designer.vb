<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlLogin = New JGradient_Panel.JGradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlShowPass = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New FlatButton.JFlatButton()
        Me.grpSearchBloodGroup = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JGradientPanel1 = New JGradient_Panel.JGradientPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlLogin.SuspendLayout()
        Me.grpSearchBloodGroup.SuspendLayout()
        Me.JGradientPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.EquiAssist.My.Resources.Resources.title
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(159, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1483, 123)
        Me.Panel1.TabIndex = 0
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogin.ColorBottom = System.Drawing.Color.LavenderBlush
        Me.pnlLogin.ColorTop = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Controls.Add(Me.Label7)
        Me.pnlLogin.Controls.Add(Me.pnlShowPass)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.Controls.Add(Me.Label3)
        Me.pnlLogin.Controls.Add(Me.lblRegister)
        Me.pnlLogin.Controls.Add(Me.Label4)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Location = New System.Drawing.Point(235, 208)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(376, 390)
        Me.pnlLogin.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(56, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(56, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Username"
        '
        'pnlShowPass
        '
        Me.pnlShowPass.BackColor = System.Drawing.Color.Transparent
        Me.pnlShowPass.BackgroundImage = Global.EquiAssist.My.Resources.Resources.eye
        Me.pnlShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlShowPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlShowPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlShowPass.Location = New System.Drawing.Point(284, 197)
        Me.pnlShowPass.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlShowPass.Name = "pnlShowPass"
        Me.pnlShowPass.Size = New System.Drawing.Size(39, 32)
        Me.pnlShowPass.TabIndex = 20
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(60, 197)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(221, 30)
        Me.txtPassword.TabIndex = 22
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtUsername.Location = New System.Drawing.Point(60, 134)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(263, 30)
        Me.txtUsername.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(56, 315)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Not Registered Yet"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRegister.DisabledLinkColor = System.Drawing.Color.Blue
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.Blue
        Me.lblRegister.LinkColor = System.Drawing.Color.Black
        Me.lblRegister.Location = New System.Drawing.Point(205, 314)
        Me.lblRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(110, 20)
        Me.lblRegister.TabIndex = 17
        Me.lblRegister.TabStop = True
        Me.lblRegister.Text = "Register Now"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 52)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Login"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.CausesValidation = False
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.ErrorImageLeft = CType(resources.GetObject("btnLogin.ErrorImageLeft"), System.Drawing.Image)
        Me.btnLogin.ErrorImageRight = CType(resources.GetObject("btnLogin.ErrorImageRight"), System.Drawing.Image)
        Me.btnLogin.FocusBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.FocusFontColor = System.Drawing.Color.Empty
        Me.btnLogin.ForeColors = System.Drawing.Color.White
        Me.btnLogin.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.HoverFontColor = System.Drawing.Color.Empty
        Me.btnLogin.ImageLeft = CType(resources.GetObject("btnLogin.ImageLeft"), System.Drawing.Image)
        Me.btnLogin.ImageRight = Nothing
        Me.btnLogin.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnLogin.Location = New System.Drawing.Point(60, 249)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnLogin.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnLogin.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnLogin.Size = New System.Drawing.Size(264, 53)
        Me.btnLogin.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnLogin.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnLogin.TabIndex = 0
        '
        'grpSearchBloodGroup
        '
        Me.grpSearchBloodGroup.BackColor = System.Drawing.Color.Transparent
        Me.grpSearchBloodGroup.Controls.Add(Me.Label8)
        Me.grpSearchBloodGroup.Controls.Add(Me.Label6)
        Me.grpSearchBloodGroup.Controls.Add(Me.LinkLabel1)
        Me.grpSearchBloodGroup.Controls.Add(Me.Panel2)
        Me.grpSearchBloodGroup.Controls.Add(Me.Label2)
        Me.grpSearchBloodGroup.Controls.Add(Me.Label1)
        Me.grpSearchBloodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSearchBloodGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchBloodGroup.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpSearchBloodGroup.Location = New System.Drawing.Point(21, 16)
        Me.grpSearchBloodGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSearchBloodGroup.Name = "grpSearchBloodGroup"
        Me.grpSearchBloodGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSearchBloodGroup.Size = New System.Drawing.Size(625, 165)
        Me.grpSearchBloodGroup.TabIndex = 35
        Me.grpSearchBloodGroup.TabStop = False
        Me.grpSearchBloodGroup.Text = "About"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(52, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(280, 34)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "The New Platform to form a Hospital Union " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Equipment Assistance "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "A STEP TOWARDS ASSISTACE"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(29, 130)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 20)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Contact us"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.EquiAssist.My.Resources.Resources.horizontal_logo
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(357, 16)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 87)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(403, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Harshal Bokde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Concept and Design"
        '
        'JGradientPanel1
        '
        Me.JGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.JGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.JGradientPanel1.ColorBottom = System.Drawing.Color.Lavender
        Me.JGradientPanel1.ColorTop = System.Drawing.Color.White
        Me.JGradientPanel1.Controls.Add(Me.grpSearchBloodGroup)
        Me.JGradientPanel1.Location = New System.Drawing.Point(1043, 2)
        Me.JGradientPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.JGradientPanel1.Name = "JGradientPanel1"
        Me.JGradientPanel1.Size = New System.Drawing.Size(665, 198)
        Me.JGradientPanel1.TabIndex = 36
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.JGradientPanel1)
        Me.Panel3.Location = New System.Drawing.Point(-2, 604)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1894, 259)
        Me.Panel3.TabIndex = 37
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipTitle = "Request For"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.EquiAssist.My.Resources.Resources.hospital_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1785, 844)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.grpSearchBloodGroup.ResumeLayout(False)
        Me.grpSearchBloodGroup.PerformLayout()
        Me.JGradientPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlLogin As JGradient_Panel.JGradientPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRegister As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As FlatButton.JFlatButton
    Friend WithEvents pnlShowPass As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpSearchBloodGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents JGradientPanel1 As JGradient_Panel.JGradientPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
End Class
