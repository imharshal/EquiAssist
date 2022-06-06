<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HospitalDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HospitalDashboard))
        Me.btnDoctor = New FlatButton.JFlatButton()
        Me.btnLogout = New FlatButton.JFlatButton()
        Me.btnGridview = New FlatButton.JFlatButton()
        Me.btnPatient = New FlatButton.JFlatButton()
        Me.btnUpdate = New FlatButton.JFlatButton()
        Me.btnHome = New FlatButton.JFlatButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlPatient = New System.Windows.Forms.Panel()
        Me.grpPatient = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnPatientSave = New System.Windows.Forms.Button()
        Me.btnPatientCancel = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPatientRemark = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPatientDisease = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbPatientBgroup = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbPatientSex = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPatientAge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPatientLname = New System.Windows.Forms.TextBox()
        Me.txtPatientMname = New System.Windows.Forms.TextBox()
        Me.txtPatientFname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPatientContact2 = New System.Windows.Forms.TextBox()
        Me.txtPatientContact1 = New System.Windows.Forms.TextBox()
        Me.txtPatientAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlDoctor = New System.Windows.Forms.Panel()
        Me.grpboxDoctor = New System.Windows.Forms.GroupBox()
        Me.btnDoctorSave = New System.Windows.Forms.Button()
        Me.btnDoctorCancel = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtDoctorExperience = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtDoctorSpeciality = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cbDoctorQualification = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cbDoctorSex = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtDoctorAge = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtDoctorLname = New System.Windows.Forms.TextBox()
        Me.txtDoctorMname = New System.Windows.Forms.TextBox()
        Me.txtDoctorFname = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtDoctorContact2 = New System.Windows.Forms.TextBox()
        Me.txtDoctorContact1 = New System.Windows.Forms.TextBox()
        Me.txtDoctorAddress = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnlGridview = New System.Windows.Forms.Panel()
        Me.grpboxGrid = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPatient = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGridPatientUpdate = New System.Windows.Forms.Button()
        Me.btnGridPatientCancel = New System.Windows.Forms.Button()
        Me.gridviewPatient = New System.Windows.Forms.DataGridView()
        Me.tabDoctor = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnGridDoctorDelete = New System.Windows.Forms.Button()
        Me.btnGridDoctorUpdate = New System.Windows.Forms.Button()
        Me.btnGridDoctorCancel = New System.Windows.Forms.Button()
        Me.gridviewDoctor = New System.Windows.Forms.DataGridView()
        Me.pnlUpdate = New System.Windows.Forms.Panel()
        Me.grpboxUpdateAvail = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnFacilityDelete = New System.Windows.Forms.Button()
        Me.btnFacilityUpdate = New System.Windows.Forms.Button()
        Me.JFlatButton2 = New FlatButton.JFlatButton()
        Me.countHospFacility = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbHospFacility = New System.Windows.Forms.ComboBox()
        Me.linkNewFacility = New System.Windows.Forms.LinkLabel()
        Me.gridviewUpdate = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.JGradientPanel3 = New JGradient_Panel.JGradientPanel()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.btnRequestAssistance = New System.Windows.Forms.Button()
        Me.btnAssist = New System.Windows.Forms.Button()
        Me.JGradientPanel2 = New JGradient_Panel.JGradientPanel()
        Me.grpNotification = New System.Windows.Forms.GroupBox()
        Me.txtNotification = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContact2 = New System.Windows.Forms.Label()
        Me.lblContact1 = New System.Windows.Forms.Label()
        Me.Labelx = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NotifyIconRequirement = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        JGradientPanel1 = New JGradient_Panel.JGradientPanel()
        JGradientPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlPatient.SuspendLayout()
        Me.grpPatient.SuspendLayout()
        Me.pnlDoctor.SuspendLayout()
        Me.grpboxDoctor.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.pnlGridview.SuspendLayout()
        Me.grpboxGrid.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPatient.SuspendLayout()
        CType(Me.gridviewPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDoctor.SuspendLayout()
        CType(Me.gridviewDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUpdate.SuspendLayout()
        Me.grpboxUpdateAvail.SuspendLayout()
        CType(Me.countHospFacility, System.ComponentModel.ISupportInitialize).BeginInit()
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
        JGradientPanel1.Controls.Add(Me.btnDoctor)
        JGradientPanel1.Controls.Add(Me.btnLogout)
        JGradientPanel1.Controls.Add(Me.btnGridview)
        JGradientPanel1.Controls.Add(Me.btnPatient)
        JGradientPanel1.Controls.Add(Me.btnUpdate)
        JGradientPanel1.Controls.Add(Me.btnHome)
        JGradientPanel1.Location = New System.Drawing.Point(21, 269)
        JGradientPanel1.Name = "JGradientPanel1"
        JGradientPanel1.Size = New System.Drawing.Size(291, 395)
        JGradientPanel1.TabIndex = 20
        '
        'btnDoctor
        '
        Me.btnDoctor.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDoctor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDoctor.ButtonText = "Add New Doctor"
        Me.btnDoctor.CausesValidation = False
        Me.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoctor.ErrorImageLeft = CType(resources.GetObject("btnDoctor.ErrorImageLeft"), System.Drawing.Image)
        Me.btnDoctor.ErrorImageRight = CType(resources.GetObject("btnDoctor.ErrorImageRight"), System.Drawing.Image)
        Me.btnDoctor.FocusBackground = System.Drawing.Color.Lavender
        Me.btnDoctor.FocusFontColor = System.Drawing.Color.Empty
        Me.btnDoctor.ForeColors = System.Drawing.Color.White
        Me.btnDoctor.HoverBackground = System.Drawing.Color.Lavender
        Me.btnDoctor.HoverFontColor = System.Drawing.Color.Empty
        Me.btnDoctor.ImageLeft = CType(resources.GetObject("btnDoctor.ImageLeft"), System.Drawing.Image)
        Me.btnDoctor.ImageRight = Nothing
        Me.btnDoctor.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnDoctor.Location = New System.Drawing.Point(44, 203)
        Me.btnDoctor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoctor.Name = "btnDoctor"
        Me.btnDoctor.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnDoctor.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnDoctor.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnDoctor.Size = New System.Drawing.Size(198, 43)
        Me.btnDoctor.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDoctor.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnDoctor.TabIndex = 2
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
        Me.btnLogout.Location = New System.Drawing.Point(43, 331)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnLogout.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnLogout.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnLogout.Size = New System.Drawing.Size(198, 43)
        Me.btnLogout.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnLogout.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnLogout.TabIndex = 5
        '
        'btnGridview
        '
        Me.btnGridview.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridview.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridview.ButtonText = "Records"
        Me.btnGridview.CausesValidation = False
        Me.btnGridview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGridview.ErrorImageLeft = CType(resources.GetObject("btnGridview.ErrorImageLeft"), System.Drawing.Image)
        Me.btnGridview.ErrorImageRight = CType(resources.GetObject("btnGridview.ErrorImageRight"), System.Drawing.Image)
        Me.btnGridview.FocusBackground = System.Drawing.Color.Lavender
        Me.btnGridview.FocusFontColor = System.Drawing.Color.Empty
        Me.btnGridview.ForeColors = System.Drawing.Color.White
        Me.btnGridview.HoverBackground = System.Drawing.Color.Lavender
        Me.btnGridview.HoverFontColor = System.Drawing.Color.Empty
        Me.btnGridview.ImageLeft = CType(resources.GetObject("btnGridview.ImageLeft"), System.Drawing.Image)
        Me.btnGridview.ImageRight = Nothing
        Me.btnGridview.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnGridview.Location = New System.Drawing.Point(44, 264)
        Me.btnGridview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGridview.Name = "btnGridview"
        Me.btnGridview.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnGridview.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnGridview.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnGridview.Size = New System.Drawing.Size(198, 43)
        Me.btnGridview.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnGridview.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnGridview.TabIndex = 4
        '
        'btnPatient
        '
        Me.btnPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnPatient.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnPatient.ButtonText = "Add New Patient"
        Me.btnPatient.CausesValidation = False
        Me.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatient.ErrorImageLeft = CType(resources.GetObject("btnPatient.ErrorImageLeft"), System.Drawing.Image)
        Me.btnPatient.ErrorImageRight = CType(resources.GetObject("btnPatient.ErrorImageRight"), System.Drawing.Image)
        Me.btnPatient.FocusBackground = System.Drawing.Color.Lavender
        Me.btnPatient.FocusFontColor = System.Drawing.Color.Empty
        Me.btnPatient.ForeColors = System.Drawing.Color.White
        Me.btnPatient.HoverBackground = System.Drawing.Color.Lavender
        Me.btnPatient.HoverFontColor = System.Drawing.Color.Empty
        Me.btnPatient.ImageLeft = CType(resources.GetObject("btnPatient.ImageLeft"), System.Drawing.Image)
        Me.btnPatient.ImageRight = Nothing
        Me.btnPatient.LeftPictureColor = System.Drawing.Color.Transparent
        Me.btnPatient.Location = New System.Drawing.Point(44, 145)
        Me.btnPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.PaddingLeftPicture = New System.Windows.Forms.Padding(0)
        Me.btnPatient.PaddingRightPicture = New System.Windows.Forms.Padding(0)
        Me.btnPatient.RightPictureColor = System.Drawing.Color.Transparent
        Me.btnPatient.Size = New System.Drawing.Size(198, 43)
        Me.btnPatient.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnPatient.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.btnPatient.TabIndex = 3
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
        Me.btnUpdate.Location = New System.Drawing.Point(44, 86)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.430933!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.56907!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1028, 609)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pnlPatient)
        Me.Panel1.Controls.Add(Me.pnlDoctor)
        Me.Panel1.Controls.Add(Me.pnlHome)
        Me.Panel1.Controls.Add(Me.pnlGridview)
        Me.Panel1.Controls.Add(Me.pnlUpdate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.JGradientPanel3)
        Me.Panel1.Controls.Add(JGradientPanel1)
        Me.Panel1.Controls.Add(Me.JGradientPanel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(-108, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1250, 557)
        Me.Panel1.TabIndex = 0
        '
        'pnlPatient
        '
        Me.pnlPatient.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPatient.Controls.Add(Me.grpPatient)
        Me.pnlPatient.Location = New System.Drawing.Point(339, 269)
        Me.pnlPatient.Name = "pnlPatient"
        Me.pnlPatient.Size = New System.Drawing.Size(575, 395)
        Me.pnlPatient.TabIndex = 21
        '
        'grpPatient
        '
        Me.grpPatient.Controls.Add(Me.Label2)
        Me.grpPatient.Controls.Add(Me.DateTimePicker1)
        Me.grpPatient.Controls.Add(Me.btnPatientSave)
        Me.grpPatient.Controls.Add(Me.btnPatientCancel)
        Me.grpPatient.Controls.Add(Me.Label16)
        Me.grpPatient.Controls.Add(Me.Label15)
        Me.grpPatient.Controls.Add(Me.txtPatientRemark)
        Me.grpPatient.Controls.Add(Me.Label14)
        Me.grpPatient.Controls.Add(Me.txtPatientDisease)
        Me.grpPatient.Controls.Add(Me.Label13)
        Me.grpPatient.Controls.Add(Me.cbPatientBgroup)
        Me.grpPatient.Controls.Add(Me.Label12)
        Me.grpPatient.Controls.Add(Me.cbPatientSex)
        Me.grpPatient.Controls.Add(Me.Label11)
        Me.grpPatient.Controls.Add(Me.txtPatientAge)
        Me.grpPatient.Controls.Add(Me.Label10)
        Me.grpPatient.Controls.Add(Me.Label9)
        Me.grpPatient.Controls.Add(Me.Label8)
        Me.grpPatient.Controls.Add(Me.Label6)
        Me.grpPatient.Controls.Add(Me.txtPatientLname)
        Me.grpPatient.Controls.Add(Me.txtPatientMname)
        Me.grpPatient.Controls.Add(Me.txtPatientFname)
        Me.grpPatient.Controls.Add(Me.Label7)
        Me.grpPatient.Controls.Add(Me.txtPatientContact2)
        Me.grpPatient.Controls.Add(Me.txtPatientContact1)
        Me.grpPatient.Controls.Add(Me.txtPatientAddress)
        Me.grpPatient.Controls.Add(Me.Label4)
        Me.grpPatient.Controls.Add(Me.Label5)
        Me.grpPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPatient.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpPatient.Location = New System.Drawing.Point(24, 12)
        Me.grpPatient.Name = "grpPatient"
        Me.grpPatient.Size = New System.Drawing.Size(532, 361)
        Me.grpPatient.TabIndex = 0
        Me.grpPatient.TabStop = False
        Me.grpPatient.Text = "Patient Addmission"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 32)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Date Of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admission"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 237)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePicker1.TabIndex = 11
        '
        'btnPatientSave
        '
        Me.btnPatientSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnPatientSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientSave.ForeColor = System.Drawing.Color.White
        Me.btnPatientSave.Location = New System.Drawing.Point(293, 309)
        Me.btnPatientSave.Name = "btnPatientSave"
        Me.btnPatientSave.Size = New System.Drawing.Size(80, 31)
        Me.btnPatientSave.TabIndex = 12
        Me.btnPatientSave.Text = "Save"
        Me.btnPatientSave.UseVisualStyleBackColor = False
        '
        'btnPatientCancel
        '
        Me.btnPatientCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnPatientCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientCancel.ForeColor = System.Drawing.Color.White
        Me.btnPatientCancel.Location = New System.Drawing.Point(162, 309)
        Me.btnPatientCancel.Name = "btnPatientCancel"
        Me.btnPatientCancel.Size = New System.Drawing.Size(80, 31)
        Me.btnPatientCancel.TabIndex = 13
        Me.btnPatientCancel.Text = "Cancel"
        Me.btnPatientCancel.UseVisualStyleBackColor = False
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
        'txtPatientRemark
        '
        Me.txtPatientRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientRemark.Location = New System.Drawing.Point(124, 267)
        Me.txtPatientRemark.Name = "txtPatientRemark"
        Me.txtPatientRemark.Size = New System.Drawing.Size(396, 22)
        Me.txtPatientRemark.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(27, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Remarks"
        '
        'txtPatientDisease
        '
        Me.txtPatientDisease.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientDisease.Location = New System.Drawing.Point(352, 198)
        Me.txtPatientDisease.Name = "txtPatientDisease"
        Me.txtPatientDisease.Size = New System.Drawing.Size(168, 22)
        Me.txtPatientDisease.TabIndex = 10
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
        'cbPatientBgroup
        '
        Me.cbPatientBgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPatientBgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPatientBgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPatientBgroup.FormattingEnabled = True
        Me.cbPatientBgroup.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.cbPatientBgroup.Location = New System.Drawing.Point(124, 197)
        Me.cbPatientBgroup.Name = "cbPatientBgroup"
        Me.cbPatientBgroup.Size = New System.Drawing.Size(91, 23)
        Me.cbPatientBgroup.TabIndex = 9
        Me.cbPatientBgroup.Text = "-Select-"
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
        'cbPatientSex
        '
        Me.cbPatientSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPatientSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPatientSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPatientSex.FormattingEnabled = True
        Me.cbPatientSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cbPatientSex.Location = New System.Drawing.Point(124, 165)
        Me.cbPatientSex.Name = "cbPatientSex"
        Me.cbPatientSex.Size = New System.Drawing.Size(91, 23)
        Me.cbPatientSex.TabIndex = 7
        Me.cbPatientSex.Text = "-Select-"
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
        'txtPatientAge
        '
        Me.txtPatientAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientAge.Location = New System.Drawing.Point(352, 166)
        Me.txtPatientAge.Name = "txtPatientAge"
        Me.txtPatientAge.Size = New System.Drawing.Size(56, 22)
        Me.txtPatientAge.TabIndex = 8
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
        'txtPatientLname
        '
        Me.txtPatientLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientLname.Location = New System.Drawing.Point(392, 35)
        Me.txtPatientLname.Name = "txtPatientLname"
        Me.txtPatientLname.Size = New System.Drawing.Size(128, 22)
        Me.txtPatientLname.TabIndex = 3
        '
        'txtPatientMname
        '
        Me.txtPatientMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientMname.Location = New System.Drawing.Point(258, 35)
        Me.txtPatientMname.Name = "txtPatientMname"
        Me.txtPatientMname.Size = New System.Drawing.Size(128, 22)
        Me.txtPatientMname.TabIndex = 2
        '
        'txtPatientFname
        '
        Me.txtPatientFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientFname.Location = New System.Drawing.Point(124, 35)
        Me.txtPatientFname.Name = "txtPatientFname"
        Me.txtPatientFname.Size = New System.Drawing.Size(128, 22)
        Me.txtPatientFname.TabIndex = 1
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
        'txtPatientContact2
        '
        Me.txtPatientContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientContact2.Location = New System.Drawing.Point(280, 122)
        Me.txtPatientContact2.MaxLength = 10
        Me.txtPatientContact2.Name = "txtPatientContact2"
        Me.txtPatientContact2.Size = New System.Drawing.Size(128, 22)
        Me.txtPatientContact2.TabIndex = 6
        '
        'txtPatientContact1
        '
        Me.txtPatientContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientContact1.Location = New System.Drawing.Point(124, 122)
        Me.txtPatientContact1.MaxLength = 10
        Me.txtPatientContact1.Name = "txtPatientContact1"
        Me.txtPatientContact1.Size = New System.Drawing.Size(128, 22)
        Me.txtPatientContact1.TabIndex = 5
        '
        'txtPatientAddress
        '
        Me.txtPatientAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientAddress.Location = New System.Drawing.Point(124, 79)
        Me.txtPatientAddress.Multiline = True
        Me.txtPatientAddress.Name = "txtPatientAddress"
        Me.txtPatientAddress.Size = New System.Drawing.Size(396, 36)
        Me.txtPatientAddress.TabIndex = 4
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
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Patient Name"
        '
        'pnlDoctor
        '
        Me.pnlDoctor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDoctor.Controls.Add(Me.grpboxDoctor)
        Me.pnlDoctor.Location = New System.Drawing.Point(339, 269)
        Me.pnlDoctor.Name = "pnlDoctor"
        Me.pnlDoctor.Size = New System.Drawing.Size(575, 395)
        Me.pnlDoctor.TabIndex = 24
        '
        'grpboxDoctor
        '
        Me.grpboxDoctor.Controls.Add(Me.btnDoctorSave)
        Me.grpboxDoctor.Controls.Add(Me.btnDoctorCancel)
        Me.grpboxDoctor.Controls.Add(Me.Label31)
        Me.grpboxDoctor.Controls.Add(Me.Label32)
        Me.grpboxDoctor.Controls.Add(Me.Label33)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorExperience)
        Me.grpboxDoctor.Controls.Add(Me.Label34)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorSpeciality)
        Me.grpboxDoctor.Controls.Add(Me.Label35)
        Me.grpboxDoctor.Controls.Add(Me.cbDoctorQualification)
        Me.grpboxDoctor.Controls.Add(Me.Label36)
        Me.grpboxDoctor.Controls.Add(Me.cbDoctorSex)
        Me.grpboxDoctor.Controls.Add(Me.Label37)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorAge)
        Me.grpboxDoctor.Controls.Add(Me.Label38)
        Me.grpboxDoctor.Controls.Add(Me.Label39)
        Me.grpboxDoctor.Controls.Add(Me.Label40)
        Me.grpboxDoctor.Controls.Add(Me.Label41)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorLname)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorMname)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorFname)
        Me.grpboxDoctor.Controls.Add(Me.Label42)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorContact2)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorContact1)
        Me.grpboxDoctor.Controls.Add(Me.txtDoctorAddress)
        Me.grpboxDoctor.Controls.Add(Me.Label43)
        Me.grpboxDoctor.Controls.Add(Me.Label44)
        Me.grpboxDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxDoctor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpboxDoctor.Location = New System.Drawing.Point(24, 12)
        Me.grpboxDoctor.Name = "grpboxDoctor"
        Me.grpboxDoctor.Size = New System.Drawing.Size(532, 361)
        Me.grpboxDoctor.TabIndex = 0
        Me.grpboxDoctor.TabStop = False
        Me.grpboxDoctor.Text = "Doctor's Details"
        '
        'btnDoctorSave
        '
        Me.btnDoctorSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDoctorSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoctorSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctorSave.ForeColor = System.Drawing.Color.White
        Me.btnDoctorSave.Location = New System.Drawing.Point(293, 309)
        Me.btnDoctorSave.Name = "btnDoctorSave"
        Me.btnDoctorSave.Size = New System.Drawing.Size(80, 31)
        Me.btnDoctorSave.TabIndex = 12
        Me.btnDoctorSave.Text = "Save"
        Me.btnDoctorSave.UseVisualStyleBackColor = False
        '
        'btnDoctorCancel
        '
        Me.btnDoctorCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDoctorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoctorCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctorCancel.ForeColor = System.Drawing.Color.White
        Me.btnDoctorCancel.Location = New System.Drawing.Point(162, 309)
        Me.btnDoctorCancel.Name = "btnDoctorCancel"
        Me.btnDoctorCancel.Size = New System.Drawing.Size(80, 31)
        Me.btnDoctorCancel.TabIndex = 13
        Me.btnDoctorCancel.Text = "Cancel"
        Me.btnDoctorCancel.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label31.Location = New System.Drawing.Point(148, 263)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 12)
        Me.Label31.TabIndex = 40
        Me.Label31.Text = "(In years)"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label32.Location = New System.Drawing.Point(322, 147)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 12)
        Me.Label32.TabIndex = 37
        Me.Label32.Text = "Contact 2"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label33.Location = New System.Drawing.Point(160, 147)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 12)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "Contact 1"
        '
        'txtDoctorExperience
        '
        Me.txtDoctorExperience.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorExperience.Location = New System.Drawing.Point(124, 238)
        Me.txtDoctorExperience.Name = "txtDoctorExperience"
        Me.txtDoctorExperience.Size = New System.Drawing.Size(91, 22)
        Me.txtDoctorExperience.TabIndex = 11
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(27, 241)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 16)
        Me.Label34.TabIndex = 34
        Me.Label34.Text = "Experience"
        '
        'txtDoctorSpeciality
        '
        Me.txtDoctorSpeciality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorSpeciality.Location = New System.Drawing.Point(385, 198)
        Me.txtDoctorSpeciality.Name = "txtDoctorSpeciality"
        Me.txtDoctorSpeciality.Size = New System.Drawing.Size(137, 22)
        Me.txtDoctorSpeciality.TabIndex = 10
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(310, 204)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(67, 16)
        Me.Label35.TabIndex = 32
        Me.Label35.Text = "Speciality"
        '
        'cbDoctorQualification
        '
        Me.cbDoctorQualification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbDoctorQualification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDoctorQualification.DropDownHeight = 80
        Me.cbDoctorQualification.FormattingEnabled = True
        Me.cbDoctorQualification.IntegralHeight = False
        Me.cbDoctorQualification.ItemHeight = 15
        Me.cbDoctorQualification.Items.AddRange(New Object() {"M. B. B. S. (Bachelor of Medicine and Bachelor of Surgery)", "B. D. S. (Bachelor of Dental Surgery)", "B. H. M. S. (Bachelor of Homeopathic Medicine & Surgery)", "B. A. M. S. (Bachelor of Ayurvedic Medicine and Surgery) ", "M.D. (Doctor of Medicine)", "M.S. (Master of Surgery)", "D.M (Doctorate in Medicine)", "B.Pharm (Bachelor of Pharmacy)", "B.P.T (Physiotherapy)", "B.O.T (Occupational Therapy) ", "B.U.M.S (Unani Medicine)", "D.Pharm (Ayurvedic, Siddha Medicine)", "BMLT (Bachelor of Medical Lab Technicians)", "DMLT (Diploma of Medical Lab Technicians)"})
        Me.cbDoctorQualification.Location = New System.Drawing.Point(124, 197)
        Me.cbDoctorQualification.MaxDropDownItems = 6
        Me.cbDoctorQualification.Name = "cbDoctorQualification"
        Me.cbDoctorQualification.Size = New System.Drawing.Size(180, 23)
        Me.cbDoctorQualification.TabIndex = 9
        Me.cbDoctorQualification.Text = "-Select-"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(27, 200)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(81, 16)
        Me.Label36.TabIndex = 30
        Me.Label36.Text = "Qualification"
        '
        'cbDoctorSex
        '
        Me.cbDoctorSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbDoctorSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDoctorSex.FormattingEnabled = True
        Me.cbDoctorSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cbDoctorSex.Location = New System.Drawing.Point(124, 165)
        Me.cbDoctorSex.Name = "cbDoctorSex"
        Me.cbDoctorSex.Size = New System.Drawing.Size(91, 23)
        Me.cbDoctorSex.TabIndex = 7
        Me.cbDoctorSex.Text = "-Select-"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(27, 168)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(31, 16)
        Me.Label37.TabIndex = 28
        Me.Label37.Text = "Sex"
        '
        'txtDoctorAge
        '
        Me.txtDoctorAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorAge.Location = New System.Drawing.Point(385, 165)
        Me.txtDoctorAge.Name = "txtDoctorAge"
        Me.txtDoctorAge.Size = New System.Drawing.Size(56, 22)
        Me.txtDoctorAge.TabIndex = 8
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(310, 168)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(33, 16)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "Age"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label39.Location = New System.Drawing.Point(427, 60)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(50, 12)
        Me.Label39.TabIndex = 25
        Me.Label39.Text = "Last Name"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label40.Location = New System.Drawing.Point(291, 60)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(60, 12)
        Me.Label40.TabIndex = 24
        Me.Label40.Text = "Middle Name"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label41.Location = New System.Drawing.Point(160, 60)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(51, 12)
        Me.Label41.TabIndex = 23
        Me.Label41.Text = "First Name"
        '
        'txtDoctorLname
        '
        Me.txtDoctorLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorLname.Location = New System.Drawing.Point(392, 35)
        Me.txtDoctorLname.Name = "txtDoctorLname"
        Me.txtDoctorLname.Size = New System.Drawing.Size(128, 22)
        Me.txtDoctorLname.TabIndex = 3
        '
        'txtDoctorMname
        '
        Me.txtDoctorMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorMname.Location = New System.Drawing.Point(258, 35)
        Me.txtDoctorMname.Name = "txtDoctorMname"
        Me.txtDoctorMname.Size = New System.Drawing.Size(128, 22)
        Me.txtDoctorMname.TabIndex = 2
        '
        'txtDoctorFname
        '
        Me.txtDoctorFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorFname.Location = New System.Drawing.Point(124, 35)
        Me.txtDoctorFname.Name = "txtDoctorFname"
        Me.txtDoctorFname.Size = New System.Drawing.Size(128, 22)
        Me.txtDoctorFname.TabIndex = 1
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(27, 125)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(77, 16)
        Me.Label42.TabIndex = 19
        Me.Label42.Text = "Contact No."
        '
        'txtDoctorContact2
        '
        Me.txtDoctorContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorContact2.Location = New System.Drawing.Point(280, 122)
        Me.txtDoctorContact2.MaxLength = 10
        Me.txtDoctorContact2.Name = "txtDoctorContact2"
        Me.txtDoctorContact2.Size = New System.Drawing.Size(128, 22)
        Me.txtDoctorContact2.TabIndex = 6
        '
        'txtDoctorContact1
        '
        Me.txtDoctorContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorContact1.Location = New System.Drawing.Point(124, 122)
        Me.txtDoctorContact1.MaxLength = 10
        Me.txtDoctorContact1.Name = "txtDoctorContact1"
        Me.txtDoctorContact1.Size = New System.Drawing.Size(128, 22)
        Me.txtDoctorContact1.TabIndex = 5
        '
        'txtDoctorAddress
        '
        Me.txtDoctorAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorAddress.Location = New System.Drawing.Point(124, 79)
        Me.txtDoctorAddress.Multiline = True
        Me.txtDoctorAddress.Name = "txtDoctorAddress"
        Me.txtDoctorAddress.Size = New System.Drawing.Size(396, 36)
        Me.txtDoctorAddress.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(27, 85)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(59, 16)
        Me.Label43.TabIndex = 13
        Me.Label43.Text = "Address"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(27, 38)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(88, 16)
        Me.Label44.TabIndex = 11
        Me.Label44.Text = "Doctor Name"
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlHome.BackgroundImage = Global.EquiAssist.My.Resources.Resources.wcimage
        Me.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHome.Controls.Add(Me.Panel4)
        Me.pnlHome.Controls.Add(Me.Label17)
        Me.pnlHome.Location = New System.Drawing.Point(339, 269)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(575, 395)
        Me.pnlHome.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.EquiAssist.My.Resources.Resources.horizontal_logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(338, 297)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(228, 85)
        Me.Panel4.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoEllipsis = True
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Ivory
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(137, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(314, 118)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Welcome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to EquiAssist"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.UseCompatibleTextRendering = True
        '
        'pnlGridview
        '
        Me.pnlGridview.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlGridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGridview.Controls.Add(Me.grpboxGrid)
        Me.pnlGridview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGridview.Location = New System.Drawing.Point(339, 269)
        Me.pnlGridview.Name = "pnlGridview"
        Me.pnlGridview.Size = New System.Drawing.Size(575, 395)
        Me.pnlGridview.TabIndex = 23
        '
        'grpboxGrid
        '
        Me.grpboxGrid.Controls.Add(Me.TabControl1)
        Me.grpboxGrid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpboxGrid.Location = New System.Drawing.Point(24, 12)
        Me.grpboxGrid.Name = "grpboxGrid"
        Me.grpboxGrid.Size = New System.Drawing.Size(526, 361)
        Me.grpboxGrid.TabIndex = 0
        Me.grpboxGrid.TabStop = False
        Me.grpboxGrid.Text = "GridView Data"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPatient)
        Me.TabControl1.Controls.Add(Me.tabDoctor)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(526, 340)
        Me.TabControl1.TabIndex = 0
        '
        'tabPatient
        '
        Me.tabPatient.Controls.Add(Me.Label3)
        Me.tabPatient.Controls.Add(Me.btnGridPatientUpdate)
        Me.tabPatient.Controls.Add(Me.btnGridPatientCancel)
        Me.tabPatient.Controls.Add(Me.gridviewPatient)
        Me.tabPatient.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tabPatient.Location = New System.Drawing.Point(4, 24)
        Me.tabPatient.Name = "tabPatient"
        Me.tabPatient.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPatient.Size = New System.Drawing.Size(518, 312)
        Me.tabPatient.TabIndex = 0
        Me.tabPatient.Text = "Patient Details"
        Me.tabPatient.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(7, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Note : Select and Edit a Record to Update || Only Basic Information Could be Upda" & _
            "ted"
        '
        'btnGridPatientUpdate
        '
        Me.btnGridPatientUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridPatientUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridPatientUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridPatientUpdate.ForeColor = System.Drawing.Color.White
        Me.btnGridPatientUpdate.Location = New System.Drawing.Point(293, 265)
        Me.btnGridPatientUpdate.Name = "btnGridPatientUpdate"
        Me.btnGridPatientUpdate.Size = New System.Drawing.Size(80, 31)
        Me.btnGridPatientUpdate.TabIndex = 44
        Me.btnGridPatientUpdate.Text = "Update"
        Me.btnGridPatientUpdate.UseVisualStyleBackColor = False
        '
        'btnGridPatientCancel
        '
        Me.btnGridPatientCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridPatientCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridPatientCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridPatientCancel.ForeColor = System.Drawing.Color.White
        Me.btnGridPatientCancel.Location = New System.Drawing.Point(162, 265)
        Me.btnGridPatientCancel.Name = "btnGridPatientCancel"
        Me.btnGridPatientCancel.Size = New System.Drawing.Size(80, 31)
        Me.btnGridPatientCancel.TabIndex = 43
        Me.btnGridPatientCancel.Text = "Cancel"
        Me.btnGridPatientCancel.UseVisualStyleBackColor = False
        '
        'gridviewPatient
        '
        Me.gridviewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewPatient.Location = New System.Drawing.Point(3, 4)
        Me.gridviewPatient.Name = "gridviewPatient"
        Me.gridviewPatient.Size = New System.Drawing.Size(512, 237)
        Me.gridviewPatient.TabIndex = 3
        '
        'tabDoctor
        '
        Me.tabDoctor.Controls.Add(Me.Label21)
        Me.tabDoctor.Controls.Add(Me.btnGridDoctorDelete)
        Me.tabDoctor.Controls.Add(Me.btnGridDoctorUpdate)
        Me.tabDoctor.Controls.Add(Me.btnGridDoctorCancel)
        Me.tabDoctor.Controls.Add(Me.gridviewDoctor)
        Me.tabDoctor.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tabDoctor.Location = New System.Drawing.Point(4, 24)
        Me.tabDoctor.Name = "tabDoctor"
        Me.tabDoctor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDoctor.Size = New System.Drawing.Size(518, 312)
        Me.tabDoctor.TabIndex = 1
        Me.tabDoctor.Text = "Doctors Details"
        Me.tabDoctor.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label21.Location = New System.Drawing.Point(7, 241)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(405, 13)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Note : Select and Edit a Record to Update || Only Basic Information Could be Upda" & _
            "ted"
        '
        'btnGridDoctorDelete
        '
        Me.btnGridDoctorDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridDoctorDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridDoctorDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridDoctorDelete.ForeColor = System.Drawing.Color.White
        Me.btnGridDoctorDelete.Location = New System.Drawing.Point(213, 265)
        Me.btnGridDoctorDelete.Name = "btnGridDoctorDelete"
        Me.btnGridDoctorDelete.Size = New System.Drawing.Size(80, 31)
        Me.btnGridDoctorDelete.TabIndex = 47
        Me.btnGridDoctorDelete.Text = "Delete"
        Me.btnGridDoctorDelete.UseVisualStyleBackColor = False
        '
        'btnGridDoctorUpdate
        '
        Me.btnGridDoctorUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridDoctorUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridDoctorUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridDoctorUpdate.ForeColor = System.Drawing.Color.White
        Me.btnGridDoctorUpdate.Location = New System.Drawing.Point(310, 265)
        Me.btnGridDoctorUpdate.Name = "btnGridDoctorUpdate"
        Me.btnGridDoctorUpdate.Size = New System.Drawing.Size(80, 31)
        Me.btnGridDoctorUpdate.TabIndex = 46
        Me.btnGridDoctorUpdate.Text = "Update"
        Me.btnGridDoctorUpdate.UseVisualStyleBackColor = False
        '
        'btnGridDoctorCancel
        '
        Me.btnGridDoctorCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnGridDoctorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridDoctorCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridDoctorCancel.ForeColor = System.Drawing.Color.White
        Me.btnGridDoctorCancel.Location = New System.Drawing.Point(115, 265)
        Me.btnGridDoctorCancel.Name = "btnGridDoctorCancel"
        Me.btnGridDoctorCancel.Size = New System.Drawing.Size(80, 31)
        Me.btnGridDoctorCancel.TabIndex = 45
        Me.btnGridDoctorCancel.Text = "Cancel"
        Me.btnGridDoctorCancel.UseVisualStyleBackColor = False
        '
        'gridviewDoctor
        '
        Me.gridviewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewDoctor.Location = New System.Drawing.Point(3, 4)
        Me.gridviewDoctor.Name = "gridviewDoctor"
        Me.gridviewDoctor.Size = New System.Drawing.Size(512, 237)
        Me.gridviewDoctor.TabIndex = 4
        '
        'pnlUpdate
        '
        Me.pnlUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlUpdate.Controls.Add(Me.grpboxUpdateAvail)
        Me.pnlUpdate.Location = New System.Drawing.Point(339, 269)
        Me.pnlUpdate.Name = "pnlUpdate"
        Me.pnlUpdate.Size = New System.Drawing.Size(575, 395)
        Me.pnlUpdate.TabIndex = 26
        '
        'grpboxUpdateAvail
        '
        Me.grpboxUpdateAvail.Controls.Add(Me.Label20)
        Me.grpboxUpdateAvail.Controls.Add(Me.btnFacilityDelete)
        Me.grpboxUpdateAvail.Controls.Add(Me.btnFacilityUpdate)
        Me.grpboxUpdateAvail.Controls.Add(Me.JFlatButton2)
        Me.grpboxUpdateAvail.Controls.Add(Me.countHospFacility)
        Me.grpboxUpdateAvail.Controls.Add(Me.Label19)
        Me.grpboxUpdateAvail.Controls.Add(Me.Label18)
        Me.grpboxUpdateAvail.Controls.Add(Me.cbHospFacility)
        Me.grpboxUpdateAvail.Controls.Add(Me.linkNewFacility)
        Me.grpboxUpdateAvail.Controls.Add(Me.gridviewUpdate)
        Me.grpboxUpdateAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxUpdateAvail.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpboxUpdateAvail.Location = New System.Drawing.Point(24, 13)
        Me.grpboxUpdateAvail.Name = "grpboxUpdateAvail"
        Me.grpboxUpdateAvail.Size = New System.Drawing.Size(532, 360)
        Me.grpboxUpdateAvail.TabIndex = 0
        Me.grpboxUpdateAvail.TabStop = False
        Me.grpboxUpdateAvail.Text = "Update Availability"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label20.Location = New System.Drawing.Point(15, 210)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(203, 13)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Note : Select a record to Update or Delete"
        '
        'btnFacilityDelete
        '
        Me.btnFacilityDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnFacilityDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacilityDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacilityDelete.ForeColor = System.Drawing.Color.White
        Me.btnFacilityDelete.Location = New System.Drawing.Point(293, 309)
        Me.btnFacilityDelete.Name = "btnFacilityDelete"
        Me.btnFacilityDelete.Size = New System.Drawing.Size(80, 31)
        Me.btnFacilityDelete.TabIndex = 46
        Me.btnFacilityDelete.Text = "Delete"
        Me.btnFacilityDelete.UseVisualStyleBackColor = False
        '
        'btnFacilityUpdate
        '
        Me.btnFacilityUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnFacilityUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacilityUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacilityUpdate.ForeColor = System.Drawing.Color.White
        Me.btnFacilityUpdate.Location = New System.Drawing.Point(162, 309)
        Me.btnFacilityUpdate.Name = "btnFacilityUpdate"
        Me.btnFacilityUpdate.Size = New System.Drawing.Size(80, 31)
        Me.btnFacilityUpdate.TabIndex = 45
        Me.btnFacilityUpdate.Text = "Update"
        Me.btnFacilityUpdate.UseVisualStyleBackColor = False
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
        'countHospFacility
        '
        Me.countHospFacility.Location = New System.Drawing.Point(380, 246)
        Me.countHospFacility.Name = "countHospFacility"
        Me.countHospFacility.Size = New System.Drawing.Size(69, 21)
        Me.countHospFacility.TabIndex = 3
        Me.countHospFacility.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(63, 248)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Facilities"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(294, 248)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Availability*"
        '
        'cbHospFacility
        '
        Me.cbHospFacility.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbHospFacility.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbHospFacility.FormattingEnabled = True
        Me.cbHospFacility.Items.AddRange(New Object() {"MRI", "BED", "BLOOD"})
        Me.cbHospFacility.Location = New System.Drawing.Point(130, 244)
        Me.cbHospFacility.Name = "cbHospFacility"
        Me.cbHospFacility.Size = New System.Drawing.Size(121, 23)
        Me.cbHospFacility.TabIndex = 1
        Me.cbHospFacility.Text = "-Select-"
        '
        'linkNewFacility
        '
        Me.linkNewFacility.AutoSize = True
        Me.linkNewFacility.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkNewFacility.Location = New System.Drawing.Point(402, 25)
        Me.linkNewFacility.Name = "linkNewFacility"
        Me.linkNewFacility.Size = New System.Drawing.Size(112, 15)
        Me.linkNewFacility.TabIndex = 5
        Me.linkNewFacility.TabStop = True
        Me.linkNewFacility.Text = "Add New Facility"
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
        Me.Panel2.Location = New System.Drawing.Point(942, 269)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 395)
        Me.Panel2.TabIndex = 27
        '
        'JGradientPanel3
        '
        Me.JGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.JGradientPanel3.ColorBottom = System.Drawing.Color.LavenderBlush
        Me.JGradientPanel3.ColorTop = System.Drawing.Color.White
        Me.JGradientPanel3.Controls.Add(Me.lblNew)
        Me.JGradientPanel3.Controls.Add(Me.btnRequestAssistance)
        Me.JGradientPanel3.Controls.Add(Me.btnAssist)
        Me.JGradientPanel3.Location = New System.Drawing.Point(968, 89)
        Me.JGradientPanel3.Name = "JGradientPanel3"
        Me.JGradientPanel3.Size = New System.Drawing.Size(264, 168)
        Me.JGradientPanel3.TabIndex = 22
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.BackColor = System.Drawing.Color.Yellow
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNew.Location = New System.Drawing.Point(185, 24)
        Me.lblNew.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(35, 15)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "New"
        Me.lblNew.Visible = False
        '
        'btnRequestAssistance
        '
        Me.btnRequestAssistance.BackColor = System.Drawing.Color.Orange
        Me.btnRequestAssistance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRequestAssistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequestAssistance.Location = New System.Drawing.Point(38, 87)
        Me.btnRequestAssistance.Name = "btnRequestAssistance"
        Me.btnRequestAssistance.Size = New System.Drawing.Size(185, 64)
        Me.btnRequestAssistance.TabIndex = 3
        Me.btnRequestAssistance.Text = "REQUEST FOR ASSISTANCE"
        Me.btnRequestAssistance.UseVisualStyleBackColor = False
        '
        'btnAssist
        '
        Me.btnAssist.BackColor = System.Drawing.Color.Lavender
        Me.btnAssist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAssist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssist.Location = New System.Drawing.Point(38, 15)
        Me.btnAssist.Name = "btnAssist"
        Me.btnAssist.Size = New System.Drawing.Size(185, 56)
        Me.btnAssist.TabIndex = 2
        Me.btnAssist.Text = "ASSIST"
        Me.btnAssist.UseVisualStyleBackColor = False
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
        Me.JGradientPanel2.Location = New System.Drawing.Point(21, 89)
        Me.JGradientPanel2.Name = "JGradientPanel2"
        Me.JGradientPanel2.Size = New System.Drawing.Size(920, 168)
        Me.JGradientPanel2.TabIndex = 19
        '
        'grpNotification
        '
        Me.grpNotification.Controls.Add(Me.txtNotification)
        Me.grpNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNotification.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpNotification.Location = New System.Drawing.Point(593, 43)
        Me.grpNotification.Name = "grpNotification"
        Me.grpNotification.Size = New System.Drawing.Size(308, 119)
        Me.grpNotification.TabIndex = 12
        Me.grpNotification.TabStop = False
        Me.grpNotification.Text = "Notifications"
        '
        'txtNotification
        '
        Me.txtNotification.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.txtNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotification.Location = New System.Drawing.Point(11, 21)
        Me.txtNotification.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNotification.MaxLength = 999999999
        Me.txtNotification.Multiline = True
        Me.txtNotification.Name = "txtNotification"
        Me.txtNotification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotification.Size = New System.Drawing.Size(288, 92)
        Me.txtNotification.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hospital Code :"
        '
        'lblContact2
        '
        Me.lblContact2.AutoSize = True
        Me.lblContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact2.Location = New System.Drawing.Point(297, 122)
        Me.lblContact2.Name = "lblContact2"
        Me.lblContact2.Size = New System.Drawing.Size(104, 20)
        Me.lblContact2.TabIndex = 4
        Me.lblContact2.Text = "Contact No."
        '
        'lblContact1
        '
        Me.lblContact1.AutoSize = True
        Me.lblContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact1.Location = New System.Drawing.Point(169, 122)
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
        Me.lblCode.Location = New System.Drawing.Point(169, 74)
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
        Me.lblName.Size = New System.Drawing.Size(220, 33)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Hospital Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.EquiAssist.My.Resources.Resources.title
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(36, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1177, 79)
        Me.Panel3.TabIndex = 18
        '
        'NotifyIconRequirement
        '
        Me.NotifyIconRequirement.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIconRequirement.BalloonTipTitle = "Requirement For"
        Me.NotifyIconRequirement.Icon = CType(resources.GetObject("NotifyIconRequirement.Icon"), System.Drawing.Icon)
        Me.NotifyIconRequirement.Text = "NotifyIRequest"
        Me.NotifyIconRequirement.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'HospitalDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HospitalDashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        JGradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlPatient.ResumeLayout(False)
        Me.grpPatient.ResumeLayout(False)
        Me.grpPatient.PerformLayout()
        Me.pnlDoctor.ResumeLayout(False)
        Me.grpboxDoctor.ResumeLayout(False)
        Me.grpboxDoctor.PerformLayout()
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.pnlGridview.ResumeLayout(False)
        Me.grpboxGrid.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabPatient.ResumeLayout(False)
        Me.tabPatient.PerformLayout()
        CType(Me.gridviewPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDoctor.ResumeLayout(False)
        Me.tabDoctor.PerformLayout()
        CType(Me.gridviewDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUpdate.ResumeLayout(False)
        Me.grpboxUpdateAvail.ResumeLayout(False)
        Me.grpboxUpdateAvail.PerformLayout()
        CType(Me.countHospFacility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JGradientPanel3.ResumeLayout(False)
        Me.JGradientPanel3.PerformLayout()
        Me.JGradientPanel2.ResumeLayout(False)
        Me.JGradientPanel2.PerformLayout()
        Me.grpNotification.ResumeLayout(False)
        Me.grpNotification.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlGridview As System.Windows.Forms.Panel
    Friend WithEvents grpboxGrid As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPatient As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGridPatientUpdate As System.Windows.Forms.Button
    Friend WithEvents btnGridPatientCancel As System.Windows.Forms.Button
    Friend WithEvents gridviewPatient As System.Windows.Forms.DataGridView
    Friend WithEvents tabDoctor As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnGridDoctorDelete As System.Windows.Forms.Button
    Friend WithEvents btnGridDoctorUpdate As System.Windows.Forms.Button
    Friend WithEvents btnGridDoctorCancel As System.Windows.Forms.Button
    Friend WithEvents gridviewDoctor As System.Windows.Forms.DataGridView
    Friend WithEvents pnlUpdate As System.Windows.Forms.Panel
    Friend WithEvents grpboxUpdateAvail As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnFacilityDelete As System.Windows.Forms.Button
    Friend WithEvents btnFacilityUpdate As System.Windows.Forms.Button
    Friend WithEvents JFlatButton2 As FlatButton.JFlatButton
    Friend WithEvents countHospFacility As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbHospFacility As System.Windows.Forms.ComboBox
    Friend WithEvents linkNewFacility As System.Windows.Forms.LinkLabel
    Friend WithEvents gridviewUpdate As System.Windows.Forms.DataGridView
    Friend WithEvents pnlPatient As System.Windows.Forms.Panel
    Friend WithEvents grpPatient As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPatientSave As System.Windows.Forms.Button
    Friend WithEvents btnPatientCancel As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPatientRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPatientDisease As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbPatientBgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbPatientSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPatientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPatientLname As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientMname As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientFname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPatientContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientContact1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlDoctor As System.Windows.Forms.Panel
    Friend WithEvents grpboxDoctor As System.Windows.Forms.GroupBox
    Friend WithEvents btnDoctorSave As System.Windows.Forms.Button
    Friend WithEvents btnDoctorCancel As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtDoctorExperience As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtDoctorSpeciality As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbDoctorQualification As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cbDoctorSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtDoctorAge As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtDoctorLname As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorMname As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorFname As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtDoctorContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorContact1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents pnlHome As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents JGradientPanel3 As JGradient_Panel.JGradientPanel
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents btnRequestAssistance As System.Windows.Forms.Button
    Friend WithEvents btnAssist As System.Windows.Forms.Button
    Friend WithEvents btnDoctor As FlatButton.JFlatButton
    Friend WithEvents btnLogout As FlatButton.JFlatButton
    Friend WithEvents btnGridview As FlatButton.JFlatButton
    Friend WithEvents btnPatient As FlatButton.JFlatButton
    Friend WithEvents btnUpdate As FlatButton.JFlatButton
    Friend WithEvents btnHome As FlatButton.JFlatButton
    Friend WithEvents JGradientPanel2 As JGradient_Panel.JGradientPanel
    Friend WithEvents txtNotification As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblContact2 As System.Windows.Forms.Label
    Friend WithEvents lblContact1 As System.Windows.Forms.Label
    Friend WithEvents Labelx As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents NotifyIconRequirement As System.Windows.Forms.NotifyIcon
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpNotification As System.Windows.Forms.GroupBox
End Class
