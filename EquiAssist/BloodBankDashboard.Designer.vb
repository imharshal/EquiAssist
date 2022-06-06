<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BloodBankDashboard
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
        Dim JGradientPanel1 As JGradient_Panel.JGradientPanel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BloodBankDashboard))
        Me.btnNewDonor = New FlatButton.JFlatButton()
        Me.btnLogout = New FlatButton.JFlatButton()
        Me.btnDonorData = New FlatButton.JFlatButton()
        Me.btnUpdate = New FlatButton.JFlatButton()
        Me.btnHome = New FlatButton.JFlatButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlNewDonor = New System.Windows.Forms.Panel()
        Me.grpDonorDetails = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnNewDonorSave = New System.Windows.Forms.Button()
        Me.btnNewDonorCancel = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDonorRemark = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDonorDisease = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbDonorBgroup = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbDonorSex = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDonorAge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDonorLname = New System.Windows.Forms.TextBox()
        Me.txtDonorMname = New System.Windows.Forms.TextBox()
        Me.txtDonorFname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDonorContact2 = New System.Windows.Forms.TextBox()
        Me.txtDonorContact1 = New System.Windows.Forms.TextBox()
        Me.txtDonorAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnlDonorData = New System.Windows.Forms.Panel()
        Me.grpDonorData = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDonorDetails = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnGridDonorUpdate = New System.Windows.Forms.Button()
        Me.btnGridDonorCancel = New System.Windows.Forms.Button()
        Me.gridviewDonorDetails = New System.Windows.Forms.DataGridView()
        Me.tabSearchDonor = New System.Windows.Forms.TabPage()
        Me.grpSearchBloodGroup = New System.Windows.Forms.GroupBox()
        Me.btnDonorSearchCancel = New System.Windows.Forms.Button()
        Me.btnDonorSearch = New System.Windows.Forms.Button()
        Me.cbSearchDonorBgroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridviewSearchDonor = New System.Windows.Forms.DataGridView()
        Me.pnlUpdate = New System.Windows.Forms.Panel()
        Me.grpUpdateStock = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbBloodGroup = New System.Windows.Forms.ComboBox()
        Me.btnBloodDelete = New System.Windows.Forms.Button()
        Me.btnBloodUpdate = New System.Windows.Forms.Button()
        Me.JFlatButton2 = New FlatButton.JFlatButton()
        Me.countBloodStock = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.linkNewFacility = New System.Windows.Forms.LinkLabel()
        Me.gridviewUpdate = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.JGradientPanel3 = New JGradient_Panel.JGradientPanel()
        Me.btnAssist = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.JGradientPanel2 = New JGradient_Panel.JGradientPanel()
        Me.grpNotification = New System.Windows.Forms.GroupBox()
        Me.txtNotification = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContact2 = New System.Windows.Forms.Label()
        Me.lblContact1 = New System.Windows.Forms.Label()
        Me.Labelx = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIconRequirement = New System.Windows.Forms.NotifyIcon(Me.components)
        JGradientPanel1 = New JGradient_Panel.JGradientPanel()
        JGradientPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNewDonor.SuspendLayout()
        Me.grpDonorDetails.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.pnlDonorData.SuspendLayout()
        Me.grpDonorData.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabDonorDetails.SuspendLayout()
        CType(Me.gridviewDonorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearchDonor.SuspendLayout()
        Me.grpSearchBloodGroup.SuspendLayout()
        CType(Me.gridviewSearchDonor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUpdate.SuspendLayout()
        Me.grpUpdateStock.SuspendLayout()
        CType(Me.countBloodStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JGradientPanel3.SuspendLayout()
        Me.JGradientPanel2.SuspendLayout()
        Me.grpNotification.SuspendLayout()
        Me.SuspendLayout()
        '
        'JGradientPanel1
        '
        JGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        JGradientPanel1.ColorBottom = System.Drawing.Color.LavenderBlush
        JGradientPanel1.ColorTop = System.Drawing.Color.White
        JGradientPanel1.Controls.Add(Me.btnNewDonor)
        JGradientPanel1.Controls.Add(Me.btnLogout)
        JGradientPanel1.Controls.Add(Me.btnDonorData)
        JGradientPanel1.Controls.Add(Me.btnUpdate)
        JGradientPanel1.Controls.Add(Me.btnHome)
        JGradientPanel1.Location = New System.Drawing.Point(20, 273)
        JGradientPanel1.Name = "JGradientPanel1"
        JGradientPanel1.Size = New System.Drawing.Size(291, 395)
        JGradientPanel1.TabIndex = 26
        '
        'btnNewDonor
        '
        Me.btnNewDonor.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnNewDonor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnNewDonor.ButtonText = " Add New Donor"
        Me.btnNewDonor.CausesValidation = False
        Me.btnNewDonor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewDonor.ErrorImageLeft = CType(resources.GetObject("btnNewDonor.ErrorImageLeft"), System.Drawing.Image)
        Me.btnNewDonor.ErrorImageRight = CType(resources.GetObject("btnNewDonor.ErrorImageRight"), System.Drawing.Image)
        Me.btnNewDonor.FocusBackground = System.Drawing.Color.Lavender
        Me.btnNewDonor.FocusFontColor = System.Drawing.Color.Empty
        Me.btnNewDonor.ForeColors = System.Drawing.Color.White
        Me.btnNewDonor.HoverBackground = System.Drawing.Color.Lavender
        Me.btnNewDonor.HoverFontColor = System.Drawing.Color.Empty
        Me.btnNewDonor.ImageLeft = CType(resources.GetObject("btnNewDonor.ImageLeft"), System.Drawing.Image)
        Me.btnNewDonor.ImageRight = Nothing
        Me.btnNewDonor.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnNewDonor.Location = New System.Drawing.Point(44, 160)
        Me.btnNewDonor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewDonor.Name = "btnNewDonor"
        Me.btnNewDonor.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnNewDonor.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnNewDonor.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnNewDonor.Size = New System.Drawing.Size(198, 43)
        Me.btnNewDonor.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnNewDonor.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnNewDonor.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnLogout.ButtonText = "Logout"
        Me.btnLogout.CausesValidation = False
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.ErrorImageLeft = CType(resources.GetObject("btnLogout.ErrorImageLeft"), System.Drawing.Image)
        Me.btnLogout.ErrorImageRight = CType(resources.GetObject("btnLogout.ErrorImageRight"), System.Drawing.Image)
        Me.btnLogout.FocusBackground = System.Drawing.Color.Lavender
        Me.btnLogout.FocusFontColor = System.Drawing.Color.Empty
        Me.btnLogout.ForeColors = System.Drawing.Color.White
        Me.btnLogout.HoverBackground = System.Drawing.Color.Lavender
        Me.btnLogout.HoverFontColor = System.Drawing.Color.Empty
        Me.btnLogout.ImageLeft = CType(resources.GetObject("btnLogout.ImageLeft"), System.Drawing.Image)
        Me.btnLogout.ImageRight = Nothing
        Me.btnLogout.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnLogout.Location = New System.Drawing.Point(44, 297)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnLogout.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnLogout.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnLogout.Size = New System.Drawing.Size(198, 43)
        Me.btnLogout.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnLogout.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnLogout.TabIndex = 5
        '
        'btnDonorData
        '
        Me.btnDonorData.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDonorData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDonorData.ButtonText = " Donor Records"
        Me.btnDonorData.CausesValidation = False
        Me.btnDonorData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDonorData.ErrorImageLeft = CType(resources.GetObject("btnDonorData.ErrorImageLeft"), System.Drawing.Image)
        Me.btnDonorData.ErrorImageRight = CType(resources.GetObject("btnDonorData.ErrorImageRight"), System.Drawing.Image)
        Me.btnDonorData.FocusBackground = System.Drawing.Color.Lavender
        Me.btnDonorData.FocusFontColor = System.Drawing.Color.Empty
        Me.btnDonorData.ForeColors = System.Drawing.Color.White
        Me.btnDonorData.HoverBackground = System.Drawing.Color.Lavender
        Me.btnDonorData.HoverFontColor = System.Drawing.Color.Empty
        Me.btnDonorData.ImageLeft = CType(resources.GetObject("btnDonorData.ImageLeft"), System.Drawing.Image)
        Me.btnDonorData.ImageRight = Nothing
        Me.btnDonorData.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnDonorData.Location = New System.Drawing.Point(44, 228)
        Me.btnDonorData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDonorData.Name = "btnDonorData"
        Me.btnDonorData.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnDonorData.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnDonorData.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnDonorData.Size = New System.Drawing.Size(198, 43)
        Me.btnDonorData.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDonorData.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnDonorData.TabIndex = 4
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnUpdate.ButtonText = "Update"
        Me.btnUpdate.CausesValidation = False
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.ErrorImageLeft = CType(resources.GetObject("btnUpdate.ErrorImageLeft"), System.Drawing.Image)
        Me.btnUpdate.ErrorImageRight = CType(resources.GetObject("btnUpdate.ErrorImageRight"), System.Drawing.Image)
        Me.btnUpdate.FocusBackground = System.Drawing.Color.Lavender
        Me.btnUpdate.FocusFontColor = System.Drawing.Color.Empty
        Me.btnUpdate.ForeColors = System.Drawing.Color.White
        Me.btnUpdate.HoverBackground = System.Drawing.Color.Lavender
        Me.btnUpdate.HoverFontColor = System.Drawing.Color.Empty
        Me.btnUpdate.ImageLeft = CType(resources.GetObject("btnUpdate.ImageLeft"), System.Drawing.Image)
        Me.btnUpdate.ImageRight = Nothing
        Me.btnUpdate.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Location = New System.Drawing.Point(44, 92)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnUpdate.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnUpdate.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Size = New System.Drawing.Size(198, 43)
        Me.btnUpdate.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnUpdate.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnUpdate.TabIndex = 1
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnHome.ButtonText = "Home"
        Me.btnHome.CausesValidation = False
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.ErrorImageLeft = CType(resources.GetObject("btnHome.ErrorImageLeft"), System.Drawing.Image)
        Me.btnHome.ErrorImageRight = CType(resources.GetObject("btnHome.ErrorImageRight"), System.Drawing.Image)
        Me.btnHome.FocusBackground = System.Drawing.Color.Lavender
        Me.btnHome.FocusFontColor = System.Drawing.Color.Empty
        Me.btnHome.ForeColors = System.Drawing.Color.White
        Me.btnHome.HoverBackground = System.Drawing.Color.Lavender
        Me.btnHome.HoverFontColor = System.Drawing.Color.Empty
        Me.btnHome.ImageLeft = CType(resources.GetObject("btnHome.ImageLeft"), System.Drawing.Image)
        Me.btnHome.ImageRight = Nothing
        Me.btnHome.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnHome.Location = New System.Drawing.Point(44, 24)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnHome.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnHome.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnHome.Size = New System.Drawing.Size(198, 43)
        Me.btnHome.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnHome.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnHome.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackgroundImage = Global.EquiAssist.My.Resources.Resources.hospital_background
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.88888!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.11112!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.73913!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.26087!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1022, 603)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pnlNewDonor)
        Me.Panel1.Controls.Add(Me.pnlHome)
        Me.Panel1.Controls.Add(Me.pnlDonorData)
        Me.Panel1.Controls.Add(Me.pnlUpdate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.JGradientPanel3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(JGradientPanel1)
        Me.Panel1.Controls.Add(Me.JGradientPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(-111, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1250, 578)
        Me.Panel1.TabIndex = 0
        '
        'pnlNewDonor
        '
        Me.pnlNewDonor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlNewDonor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNewDonor.Controls.Add(Me.grpDonorDetails)
        Me.pnlNewDonor.Location = New System.Drawing.Point(338, 273)
        Me.pnlNewDonor.Name = "pnlNewDonor"
        Me.pnlNewDonor.Size = New System.Drawing.Size(575, 395)
        Me.pnlNewDonor.TabIndex = 28
        '
        'grpDonorDetails
        '
        Me.grpDonorDetails.Controls.Add(Me.Label3)
        Me.grpDonorDetails.Controls.Add(Me.DateTimePicker1)
        Me.grpDonorDetails.Controls.Add(Me.btnNewDonorSave)
        Me.grpDonorDetails.Controls.Add(Me.btnNewDonorCancel)
        Me.grpDonorDetails.Controls.Add(Me.Label16)
        Me.grpDonorDetails.Controls.Add(Me.Label15)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorRemark)
        Me.grpDonorDetails.Controls.Add(Me.Label14)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorDisease)
        Me.grpDonorDetails.Controls.Add(Me.Label13)
        Me.grpDonorDetails.Controls.Add(Me.cbDonorBgroup)
        Me.grpDonorDetails.Controls.Add(Me.Label12)
        Me.grpDonorDetails.Controls.Add(Me.cbDonorSex)
        Me.grpDonorDetails.Controls.Add(Me.Label11)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorAge)
        Me.grpDonorDetails.Controls.Add(Me.Label10)
        Me.grpDonorDetails.Controls.Add(Me.Label9)
        Me.grpDonorDetails.Controls.Add(Me.Label8)
        Me.grpDonorDetails.Controls.Add(Me.Label6)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorLname)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorMname)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorFname)
        Me.grpDonorDetails.Controls.Add(Me.Label7)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorContact2)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorContact1)
        Me.grpDonorDetails.Controls.Add(Me.txtDonorAddress)
        Me.grpDonorDetails.Controls.Add(Me.Label4)
        Me.grpDonorDetails.Controls.Add(Me.Label5)
        Me.grpDonorDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDonorDetails.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpDonorDetails.Location = New System.Drawing.Point(24, 12)
        Me.grpDonorDetails.Name = "grpDonorDetails"
        Me.grpDonorDetails.Size = New System.Drawing.Size(532, 361)
        Me.grpDonorDetails.TabIndex = 0
        Me.grpDonorDetails.TabStop = False
        Me.grpDonorDetails.Text = "Donor Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 32)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Date Of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admission"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 233)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePicker1.TabIndex = 45
        '
        'btnNewDonorSave
        '
        Me.btnNewDonorSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnNewDonorSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewDonorSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewDonorSave.ForeColor = System.Drawing.Color.White
        Me.btnNewDonorSave.Location = New System.Drawing.Point(293, 309)
        Me.btnNewDonorSave.Name = "btnNewDonorSave"
        Me.btnNewDonorSave.Size = New System.Drawing.Size(80, 31)
        Me.btnNewDonorSave.TabIndex = 44
        Me.btnNewDonorSave.Text = "Save"
        Me.btnNewDonorSave.UseVisualStyleBackColor = False
        '
        'btnNewDonorCancel
        '
        Me.btnNewDonorCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnNewDonorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewDonorCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewDonorCancel.ForeColor = System.Drawing.Color.White
        Me.btnNewDonorCancel.Location = New System.Drawing.Point(162, 309)
        Me.btnNewDonorCancel.Name = "btnNewDonorCancel"
        Me.btnNewDonorCancel.Size = New System.Drawing.Size(80, 31)
        Me.btnNewDonorCancel.TabIndex = 43
        Me.btnNewDonorCancel.Text = "Cancel"
        Me.btnNewDonorCancel.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label16.Location = New System.Drawing.Point(322, 147)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 12)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Contact 2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label15.Location = New System.Drawing.Point(160, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 12)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Contact 1"
        '
        'txtDonorRemark
        '
        Me.txtDonorRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorRemark.Location = New System.Drawing.Point(124, 266)
        Me.txtDonorRemark.Name = "txtDonorRemark"
        Me.txtDonorRemark.Size = New System.Drawing.Size(396, 22)
        Me.txtDonorRemark.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(27, 270)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Remarks"
        '
        'txtDonorDisease
        '
        Me.txtDonorDisease.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorDisease.Location = New System.Drawing.Point(352, 198)
        Me.txtDonorDisease.Name = "txtDonorDisease"
        Me.txtDonorDisease.Size = New System.Drawing.Size(168, 22)
        Me.txtDonorDisease.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(277, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Disease"
        '
        'cbDonorBgroup
        '
        Me.cbDonorBgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbDonorBgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDonorBgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDonorBgroup.FormattingEnabled = True
        Me.cbDonorBgroup.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.cbDonorBgroup.Location = New System.Drawing.Point(124, 197)
        Me.cbDonorBgroup.Name = "cbDonorBgroup"
        Me.cbDonorBgroup.Size = New System.Drawing.Size(91, 23)
        Me.cbDonorBgroup.TabIndex = 31
        Me.cbDonorBgroup.Text = "-Select-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(27, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Blood Group"
        '
        'cbDonorSex
        '
        Me.cbDonorSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbDonorSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDonorSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDonorSex.FormattingEnabled = True
        Me.cbDonorSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cbDonorSex.Location = New System.Drawing.Point(124, 165)
        Me.cbDonorSex.Name = "cbDonorSex"
        Me.cbDonorSex.Size = New System.Drawing.Size(91, 23)
        Me.cbDonorSex.TabIndex = 29
        Me.cbDonorSex.Text = "-Select-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(27, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Sex"
        '
        'txtDonorAge
        '
        Me.txtDonorAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorAge.Location = New System.Drawing.Point(352, 166)
        Me.txtDonorAge.Name = "txtDonorAge"
        Me.txtDonorAge.Size = New System.Drawing.Size(56, 22)
        Me.txtDonorAge.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(277, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Age"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Location = New System.Drawing.Point(427, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 12)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Last Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(291, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 12)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Middle Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(160, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 12)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "First Name"
        '
        'txtDonorLname
        '
        Me.txtDonorLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorLname.Location = New System.Drawing.Point(392, 35)
        Me.txtDonorLname.Name = "txtDonorLname"
        Me.txtDonorLname.Size = New System.Drawing.Size(128, 22)
        Me.txtDonorLname.TabIndex = 22
        '
        'txtDonorMname
        '
        Me.txtDonorMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorMname.Location = New System.Drawing.Point(258, 35)
        Me.txtDonorMname.Name = "txtDonorMname"
        Me.txtDonorMname.Size = New System.Drawing.Size(128, 22)
        Me.txtDonorMname.TabIndex = 21
        '
        'txtDonorFname
        '
        Me.txtDonorFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorFname.Location = New System.Drawing.Point(124, 35)
        Me.txtDonorFname.Name = "txtDonorFname"
        Me.txtDonorFname.Size = New System.Drawing.Size(128, 22)
        Me.txtDonorFname.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(27, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Contact No."
        '
        'txtDonorContact2
        '
        Me.txtDonorContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorContact2.Location = New System.Drawing.Point(280, 122)
        Me.txtDonorContact2.MaxLength = 10
        Me.txtDonorContact2.Name = "txtDonorContact2"
        Me.txtDonorContact2.Size = New System.Drawing.Size(128, 22)
        Me.txtDonorContact2.TabIndex = 18
        '
        'txtDonorContact1
        '
        Me.txtDonorContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorContact1.Location = New System.Drawing.Point(124, 122)
        Me.txtDonorContact1.MaxLength = 10
        Me.txtDonorContact1.Name = "txtDonorContact1"
        Me.txtDonorContact1.Size = New System.Drawing.Size(128, 22)
        Me.txtDonorContact1.TabIndex = 17
        '
        'txtDonorAddress
        '
        Me.txtDonorAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonorAddress.Location = New System.Drawing.Point(124, 79)
        Me.txtDonorAddress.Multiline = True
        Me.txtDonorAddress.Name = "txtDonorAddress"
        Me.txtDonorAddress.Size = New System.Drawing.Size(396, 36)
        Me.txtDonorAddress.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Donor Name"
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlHome.BackgroundImage = Global.EquiAssist.My.Resources.Resources.wcimage
        Me.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHome.Controls.Add(Me.Panel4)
        Me.pnlHome.Controls.Add(Me.Label17)
        Me.pnlHome.Location = New System.Drawing.Point(338, 273)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(575, 395)
        Me.pnlHome.TabIndex = 29
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.EquiAssist.My.Resources.Resources.horizontal_logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(338, 298)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(228, 85)
        Me.Panel4.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoEllipsis = True
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Ivory
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(135, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(314, 118)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Welcome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to EquiAssist"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.UseCompatibleTextRendering = True
        '
        'pnlDonorData
        '
        Me.pnlDonorData.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlDonorData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDonorData.Controls.Add(Me.grpDonorData)
        Me.pnlDonorData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDonorData.Location = New System.Drawing.Point(338, 273)
        Me.pnlDonorData.Name = "pnlDonorData"
        Me.pnlDonorData.Size = New System.Drawing.Size(575, 395)
        Me.pnlDonorData.TabIndex = 33
        '
        'grpDonorData
        '
        Me.grpDonorData.Controls.Add(Me.TabControl1)
        Me.grpDonorData.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpDonorData.Location = New System.Drawing.Point(24, 12)
        Me.grpDonorData.Name = "grpDonorData"
        Me.grpDonorData.Size = New System.Drawing.Size(526, 361)
        Me.grpDonorData.TabIndex = 0
        Me.grpDonorData.TabStop = False
        Me.grpDonorData.Text = "Donor Details"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDonorDetails)
        Me.TabControl1.Controls.Add(Me.tabSearchDonor)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(526, 340)
        Me.TabControl1.TabIndex = 0
        '
        'tabDonorDetails
        '
        Me.tabDonorDetails.Controls.Add(Me.Label21)
        Me.tabDonorDetails.Controls.Add(Me.btnGridDonorUpdate)
        Me.tabDonorDetails.Controls.Add(Me.btnGridDonorCancel)
        Me.tabDonorDetails.Controls.Add(Me.gridviewDonorDetails)
        Me.tabDonorDetails.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tabDonorDetails.Location = New System.Drawing.Point(4, 24)
        Me.tabDonorDetails.Name = "tabDonorDetails"
        Me.tabDonorDetails.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabDonorDetails.Size = New System.Drawing.Size(518, 312)
        Me.tabDonorDetails.TabIndex = 0
        Me.tabDonorDetails.Text = "Donor Details"
        Me.tabDonorDetails.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label21.Location = New System.Drawing.Point(8, 243)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(405, 13)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Note : Select and Edit a Record to Update || Only Basic Information Could be Upda" & _
            "ted"
        '
        'btnGridDonorUpdate
        '
        Me.btnGridDonorUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridDonorUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridDonorUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridDonorUpdate.ForeColor = System.Drawing.Color.White
        Me.btnGridDonorUpdate.Location = New System.Drawing.Point(293, 265)
        Me.btnGridDonorUpdate.Name = "btnGridDonorUpdate"
        Me.btnGridDonorUpdate.Size = New System.Drawing.Size(80, 31)
        Me.btnGridDonorUpdate.TabIndex = 44
        Me.btnGridDonorUpdate.Text = "Update"
        Me.btnGridDonorUpdate.UseVisualStyleBackColor = False
        '
        'btnGridDonorCancel
        '
        Me.btnGridDonorCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridDonorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridDonorCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridDonorCancel.ForeColor = System.Drawing.Color.White
        Me.btnGridDonorCancel.Location = New System.Drawing.Point(162, 265)
        Me.btnGridDonorCancel.Name = "btnGridDonorCancel"
        Me.btnGridDonorCancel.Size = New System.Drawing.Size(80, 31)
        Me.btnGridDonorCancel.TabIndex = 43
        Me.btnGridDonorCancel.Text = "Cancel"
        Me.btnGridDonorCancel.UseVisualStyleBackColor = False
        '
        'gridviewDonorDetails
        '
        Me.gridviewDonorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewDonorDetails.Location = New System.Drawing.Point(3, 4)
        Me.gridviewDonorDetails.Name = "gridviewDonorDetails"
        Me.gridviewDonorDetails.Size = New System.Drawing.Size(512, 237)
        Me.gridviewDonorDetails.TabIndex = 3
        '
        'tabSearchDonor
        '
        Me.tabSearchDonor.Controls.Add(Me.grpSearchBloodGroup)
        Me.tabSearchDonor.Controls.Add(Me.gridviewSearchDonor)
        Me.tabSearchDonor.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tabSearchDonor.Location = New System.Drawing.Point(4, 24)
        Me.tabSearchDonor.Name = "tabSearchDonor"
        Me.tabSearchDonor.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabSearchDonor.Size = New System.Drawing.Size(518, 312)
        Me.tabSearchDonor.TabIndex = 1
        Me.tabSearchDonor.Text = "Search Donor"
        Me.tabSearchDonor.UseVisualStyleBackColor = True
        '
        'grpSearchBloodGroup
        '
        Me.grpSearchBloodGroup.Controls.Add(Me.btnDonorSearchCancel)
        Me.grpSearchBloodGroup.Controls.Add(Me.btnDonorSearch)
        Me.grpSearchBloodGroup.Controls.Add(Me.cbSearchDonorBgroup)
        Me.grpSearchBloodGroup.Controls.Add(Me.Label2)
        Me.grpSearchBloodGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchBloodGroup.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpSearchBloodGroup.Location = New System.Drawing.Point(7, 11)
        Me.grpSearchBloodGroup.Name = "grpSearchBloodGroup"
        Me.grpSearchBloodGroup.Size = New System.Drawing.Size(503, 70)
        Me.grpSearchBloodGroup.TabIndex = 34
        Me.grpSearchBloodGroup.TabStop = False
        Me.grpSearchBloodGroup.Text = "Search Blood Group"
        '
        'btnDonorSearchCancel
        '
        Me.btnDonorSearchCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDonorSearchCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDonorSearchCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonorSearchCancel.ForeColor = System.Drawing.Color.White
        Me.btnDonorSearchCancel.Location = New System.Drawing.Point(386, 26)
        Me.btnDonorSearchCancel.Name = "btnDonorSearchCancel"
        Me.btnDonorSearchCancel.Size = New System.Drawing.Size(80, 31)
        Me.btnDonorSearchCancel.TabIndex = 46
        Me.btnDonorSearchCancel.Text = "Cancel"
        Me.btnDonorSearchCancel.UseVisualStyleBackColor = False
        '
        'btnDonorSearch
        '
        Me.btnDonorSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDonorSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDonorSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonorSearch.ForeColor = System.Drawing.Color.White
        Me.btnDonorSearch.Location = New System.Drawing.Point(280, 26)
        Me.btnDonorSearch.Name = "btnDonorSearch"
        Me.btnDonorSearch.Size = New System.Drawing.Size(80, 31)
        Me.btnDonorSearch.TabIndex = 45
        Me.btnDonorSearch.Text = "Search"
        Me.btnDonorSearch.UseVisualStyleBackColor = False
        '
        'cbSearchDonorBgroup
        '
        Me.cbSearchDonorBgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbSearchDonorBgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbSearchDonorBgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchDonorBgroup.FormattingEnabled = True
        Me.cbSearchDonorBgroup.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.cbSearchDonorBgroup.Location = New System.Drawing.Point(135, 31)
        Me.cbSearchDonorBgroup.Name = "cbSearchDonorBgroup"
        Me.cbSearchDonorBgroup.Size = New System.Drawing.Size(91, 23)
        Me.cbSearchDonorBgroup.TabIndex = 33
        Me.cbSearchDonorBgroup.Text = "-Select-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Blood Group"
        '
        'gridviewSearchDonor
        '
        Me.gridviewSearchDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewSearchDonor.Location = New System.Drawing.Point(7, 87)
        Me.gridviewSearchDonor.Name = "gridviewSearchDonor"
        Me.gridviewSearchDonor.Size = New System.Drawing.Size(503, 223)
        Me.gridviewSearchDonor.TabIndex = 4
        '
        'pnlUpdate
        '
        Me.pnlUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlUpdate.Controls.Add(Me.grpUpdateStock)
        Me.pnlUpdate.Location = New System.Drawing.Point(338, 273)
        Me.pnlUpdate.Name = "pnlUpdate"
        Me.pnlUpdate.Size = New System.Drawing.Size(575, 395)
        Me.pnlUpdate.TabIndex = 27
        '
        'grpUpdateStock
        '
        Me.grpUpdateStock.Controls.Add(Me.Label20)
        Me.grpUpdateStock.Controls.Add(Me.cbBloodGroup)
        Me.grpUpdateStock.Controls.Add(Me.btnBloodDelete)
        Me.grpUpdateStock.Controls.Add(Me.btnBloodUpdate)
        Me.grpUpdateStock.Controls.Add(Me.JFlatButton2)
        Me.grpUpdateStock.Controls.Add(Me.countBloodStock)
        Me.grpUpdateStock.Controls.Add(Me.Label19)
        Me.grpUpdateStock.Controls.Add(Me.Label18)
        Me.grpUpdateStock.Controls.Add(Me.linkNewFacility)
        Me.grpUpdateStock.Controls.Add(Me.gridviewUpdate)
        Me.grpUpdateStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUpdateStock.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpUpdateStock.Location = New System.Drawing.Point(24, 13)
        Me.grpUpdateStock.Name = "grpUpdateStock"
        Me.grpUpdateStock.Size = New System.Drawing.Size(532, 360)
        Me.grpUpdateStock.TabIndex = 0
        Me.grpUpdateStock.TabStop = False
        Me.grpUpdateStock.Text = "Update Availability"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label20.Location = New System.Drawing.Point(14, 208)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(203, 13)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Note : Select a record to Update or Delete"
        '
        'cbBloodGroup
        '
        Me.cbBloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBloodGroup.FormattingEnabled = True
        Me.cbBloodGroup.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.cbBloodGroup.Location = New System.Drawing.Point(153, 243)
        Me.cbBloodGroup.Name = "cbBloodGroup"
        Me.cbBloodGroup.Size = New System.Drawing.Size(121, 23)
        Me.cbBloodGroup.TabIndex = 47
        Me.cbBloodGroup.Text = "-Select-"
        '
        'btnBloodDelete
        '
        Me.btnBloodDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnBloodDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBloodDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBloodDelete.ForeColor = System.Drawing.Color.White
        Me.btnBloodDelete.Location = New System.Drawing.Point(293, 309)
        Me.btnBloodDelete.Name = "btnBloodDelete"
        Me.btnBloodDelete.Size = New System.Drawing.Size(80, 31)
        Me.btnBloodDelete.TabIndex = 46
        Me.btnBloodDelete.Text = "Delete"
        Me.btnBloodDelete.UseVisualStyleBackColor = False
        '
        'btnBloodUpdate
        '
        Me.btnBloodUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnBloodUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBloodUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBloodUpdate.ForeColor = System.Drawing.Color.White
        Me.btnBloodUpdate.Location = New System.Drawing.Point(162, 309)
        Me.btnBloodUpdate.Name = "btnBloodUpdate"
        Me.btnBloodUpdate.Size = New System.Drawing.Size(80, 31)
        Me.btnBloodUpdate.TabIndex = 45
        Me.btnBloodUpdate.Text = "Update"
        Me.btnBloodUpdate.UseVisualStyleBackColor = False
        '
        'JFlatButton2
        '
        Me.JFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.JFlatButton2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.JFlatButton2.ButtonText = "Cancel"
        Me.JFlatButton2.CausesValidation = False
        Me.JFlatButton2.ErrorImageLeft = CType(resources.GetObject("JFlatButton2.ErrorImageLeft"), System.Drawing.Image)
        Me.JFlatButton2.ErrorImageRight = CType(resources.GetObject("JFlatButton2.ErrorImageRight"), System.Drawing.Image)
        Me.JFlatButton2.FocusBackground = System.Drawing.Color.Empty
        Me.JFlatButton2.FocusFontColor = System.Drawing.Color.Empty
        Me.JFlatButton2.ForeColors = System.Drawing.Color.White
        Me.JFlatButton2.HoverBackground = System.Drawing.Color.Empty
        Me.JFlatButton2.HoverFontColor = System.Drawing.Color.Empty
        Me.JFlatButton2.ImageLeft = Nothing
        Me.JFlatButton2.ImageRight = Nothing
        Me.JFlatButton2.LeftPictureColor = System.Drawing.Color.Transparent
        Me.JFlatButton2.Location = New System.Drawing.Point(260, 305)
        Me.JFlatButton2.Margin = New System.Windows.Forms.Padding(9, 3, 9, 3)
        Me.JFlatButton2.Name = "JFlatButton2"
        Me.JFlatButton2.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.JFlatButton2.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.JFlatButton2.RightPictureColor = System.Drawing.Color.Transparent
        Me.JFlatButton2.Size = New System.Drawing.Size(0, 0)
        Me.JFlatButton2.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.JFlatButton2.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.JFlatButton2.TabIndex = 42
        '
        'countBloodStock
        '
        Me.countBloodStock.Location = New System.Drawing.Point(380, 244)
        Me.countBloodStock.Name = "countBloodStock"
        Me.countBloodStock.Size = New System.Drawing.Size(69, 21)
        Me.countBloodStock.TabIndex = 3
        Me.countBloodStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(63, 245)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Blood Group"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(294, 245)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Availability*"
        '
        'linkNewFacility
        '
        Me.linkNewFacility.AutoSize = True
        Me.linkNewFacility.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkNewFacility.Location = New System.Drawing.Point(402, 24)
        Me.linkNewFacility.Name = "linkNewFacility"
        Me.linkNewFacility.Size = New System.Drawing.Size(106, 15)
        Me.linkNewFacility.TabIndex = 5
        Me.linkNewFacility.TabStop = True
        Me.linkNewFacility.Text = "Add New Group"
        '
        'gridviewUpdate
        '
        Me.gridviewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewUpdate.Location = New System.Drawing.Point(13, 45)
        Me.gridviewUpdate.Name = "gridviewUpdate"
        Me.gridviewUpdate.Size = New System.Drawing.Size(508, 163)
        Me.gridviewUpdate.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.EquiAssist.My.Resources.Resources.reciptionist
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(941, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 395)
        Me.Panel2.TabIndex = 32
        '
        'JGradientPanel3
        '
        Me.JGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.JGradientPanel3.ColorBottom = System.Drawing.Color.LavenderBlush
        Me.JGradientPanel3.ColorTop = System.Drawing.Color.White
        Me.JGradientPanel3.Controls.Add(Me.btnAssist)
        Me.JGradientPanel3.Location = New System.Drawing.Point(967, 93)
        Me.JGradientPanel3.Name = "JGradientPanel3"
        Me.JGradientPanel3.Size = New System.Drawing.Size(264, 168)
        Me.JGradientPanel3.TabIndex = 31
        '
        'btnAssist
        '
        Me.btnAssist.BackColor = System.Drawing.Color.Lavender
        Me.btnAssist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAssist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssist.Location = New System.Drawing.Point(42, 55)
        Me.btnAssist.Name = "btnAssist"
        Me.btnAssist.Size = New System.Drawing.Size(185, 56)
        Me.btnAssist.TabIndex = 2
        Me.btnAssist.Text = "ASSIST"
        Me.btnAssist.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.EquiAssist.My.Resources.Resources.title
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(35, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1177, 79)
        Me.Panel3.TabIndex = 30
        '
        'JGradientPanel2
        '
        Me.JGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JGradientPanel2.ColorBottom = System.Drawing.Color.LavenderBlush
        Me.JGradientPanel2.ColorTop = System.Drawing.Color.White
        Me.JGradientPanel2.Controls.Add(Me.grpNotification)
        Me.JGradientPanel2.Controls.Add(Me.Label1)
        Me.JGradientPanel2.Controls.Add(Me.lblContact2)
        Me.JGradientPanel2.Controls.Add(Me.lblContact1)
        Me.JGradientPanel2.Controls.Add(Me.Labelx)
        Me.JGradientPanel2.Controls.Add(Me.lblCode)
        Me.JGradientPanel2.Controls.Add(Me.lblName)
        Me.JGradientPanel2.Location = New System.Drawing.Point(20, 93)
        Me.JGradientPanel2.Name = "JGradientPanel2"
        Me.JGradientPanel2.Size = New System.Drawing.Size(920, 168)
        Me.JGradientPanel2.TabIndex = 25
        '
        'grpNotification
        '
        Me.grpNotification.Controls.Add(Me.txtNotification)
        Me.grpNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNotification.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpNotification.Location = New System.Drawing.Point(603, 41)
        Me.grpNotification.Name = "grpNotification"
        Me.grpNotification.Size = New System.Drawing.Size(308, 119)
        Me.grpNotification.TabIndex = 13
        Me.grpNotification.TabStop = False
        Me.grpNotification.Text = "Notifications"
        '
        'txtNotification
        '
        Me.txtNotification.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.txtNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotification.Location = New System.Drawing.Point(11, 21)
        Me.txtNotification.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNotification.MaxLength = 999999999
        Me.txtNotification.Multiline = True
        Me.txtNotification.Name = "txtNotification"
        Me.txtNotification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotification.Size = New System.Drawing.Size(288, 92)
        Me.txtNotification.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Blood Bank Code :"
        '
        'lblContact2
        '
        Me.lblContact2.AutoSize = True
        Me.lblContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact2.Location = New System.Drawing.Point(313, 122)
        Me.lblContact2.Name = "lblContact2"
        Me.lblContact2.Size = New System.Drawing.Size(104, 20)
        Me.lblContact2.TabIndex = 4
        Me.lblContact2.Text = "Contact No."
        '
        'lblContact1
        '
        Me.lblContact1.AutoSize = True
        Me.lblContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact1.Location = New System.Drawing.Point(187, 122)
        Me.lblContact1.Name = "lblContact1"
        Me.lblContact1.Size = New System.Drawing.Size(104, 20)
        Me.lblContact1.TabIndex = 3
        Me.lblContact1.Text = "Contact No."
        '
        'Labelx
        '
        Me.Labelx.AutoSize = True
        Me.Labelx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelx.Location = New System.Drawing.Point(23, 122)
        Me.Labelx.Name = "Labelx"
        Me.Labelx.Size = New System.Drawing.Size(114, 20)
        Me.Labelx.TabIndex = 2
        Me.Labelx.Text = "Contact No. :"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(187, 74)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(122, 20)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "Hospital Code"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(21, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(255, 33)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "BloodBank Name"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'NotifyIconRequirement
        '
        Me.NotifyIconRequirement.Text = "NotifyIcon1"
        Me.NotifyIconRequirement.Visible = True
        '
        'BloodBankDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 603)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BloodBankDashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        JGradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlNewDonor.ResumeLayout(False)
        Me.grpDonorDetails.ResumeLayout(False)
        Me.grpDonorDetails.PerformLayout()
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.pnlDonorData.ResumeLayout(False)
        Me.grpDonorData.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabDonorDetails.ResumeLayout(False)
        Me.tabDonorDetails.PerformLayout()
        CType(Me.gridviewDonorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearchDonor.ResumeLayout(False)
        Me.grpSearchBloodGroup.ResumeLayout(False)
        Me.grpSearchBloodGroup.PerformLayout()
        CType(Me.gridviewSearchDonor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUpdate.ResumeLayout(False)
        Me.grpUpdateStock.ResumeLayout(False)
        Me.grpUpdateStock.PerformLayout()
        CType(Me.countBloodStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JGradientPanel3.ResumeLayout(False)
        Me.JGradientPanel2.ResumeLayout(False)
        Me.JGradientPanel2.PerformLayout()
        Me.grpNotification.ResumeLayout(False)
        Me.grpNotification.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlDonorData As System.Windows.Forms.Panel
    Friend WithEvents grpDonorData As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDonorDetails As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnGridDonorUpdate As System.Windows.Forms.Button
    Friend WithEvents btnGridDonorCancel As System.Windows.Forms.Button
    Friend WithEvents gridviewDonorDetails As System.Windows.Forms.DataGridView
    Friend WithEvents tabSearchDonor As System.Windows.Forms.TabPage
    Friend WithEvents grpSearchBloodGroup As System.Windows.Forms.GroupBox
    Friend WithEvents btnDonorSearchCancel As System.Windows.Forms.Button
    Friend WithEvents btnDonorSearch As System.Windows.Forms.Button
    Friend WithEvents cbSearchDonorBgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridviewSearchDonor As System.Windows.Forms.DataGridView
    Friend WithEvents pnlUpdate As System.Windows.Forms.Panel
    Friend WithEvents grpUpdateStock As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbBloodGroup As System.Windows.Forms.ComboBox
    Friend WithEvents btnBloodDelete As System.Windows.Forms.Button
    Friend WithEvents btnBloodUpdate As System.Windows.Forms.Button
    Friend WithEvents JFlatButton2 As FlatButton.JFlatButton
    Friend WithEvents countBloodStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents linkNewFacility As System.Windows.Forms.LinkLabel
    Friend WithEvents gridviewUpdate As System.Windows.Forms.DataGridView
    Friend WithEvents pnlNewDonor As System.Windows.Forms.Panel
    Friend WithEvents grpDonorDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNewDonorSave As System.Windows.Forms.Button
    Friend WithEvents btnNewDonorCancel As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDonorRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDonorDisease As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbDonorBgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbDonorSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDonorAge As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDonorLname As System.Windows.Forms.TextBox
    Friend WithEvents txtDonorMname As System.Windows.Forms.TextBox
    Friend WithEvents txtDonorFname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDonorContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDonorContact1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDonorAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents JGradientPanel3 As JGradient_Panel.JGradientPanel
    Friend WithEvents btnAssist As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlHome As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnNewDonor As FlatButton.JFlatButton
    Friend WithEvents btnLogout As FlatButton.JFlatButton
    Friend WithEvents btnDonorData As FlatButton.JFlatButton
    Friend WithEvents btnUpdate As FlatButton.JFlatButton
    Friend WithEvents btnHome As FlatButton.JFlatButton
    Friend WithEvents JGradientPanel2 As JGradient_Panel.JGradientPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblContact2 As System.Windows.Forms.Label
    Friend WithEvents lblContact1 As System.Windows.Forms.Label
    Friend WithEvents Labelx As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIconRequirement As System.Windows.Forms.NotifyIcon
    Friend WithEvents grpNotification As System.Windows.Forms.GroupBox
    Friend WithEvents txtNotification As System.Windows.Forms.TextBox
End Class
