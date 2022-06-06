<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabHospital = New System.Windows.Forms.TabPage()
        Me.btnHospSubmit = New System.Windows.Forms.Button()
        Me.btnHospCancel = New System.Windows.Forms.Button()
        Me.checkHosp = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gridviewHosp = New System.Windows.Forms.DataGridView()
        Me.grpHospDetail = New System.Windows.Forms.GroupBox()
        Me.cbHospCity = New System.Windows.Forms.ComboBox()
        Me.cbHospState = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHospContact2 = New System.Windows.Forms.TextBox()
        Me.txtHospContact1 = New System.Windows.Forms.TextBox()
        Me.txtHospAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHospName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpHospAvailability = New System.Windows.Forms.GroupBox()
        Me.cbHospFacility = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btdHospAdd = New System.Windows.Forms.Button()
        Me.countHospFacility = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabBlood = New System.Windows.Forms.TabPage()
        Me.btnBloodSubmit = New System.Windows.Forms.Button()
        Me.btnBloodCancel = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.gridviewBlood = New System.Windows.Forms.DataGridView()
        Me.checkBlood = New System.Windows.Forms.CheckBox()
        Me.grpBloodAvailability = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBloodAdd = New System.Windows.Forms.Button()
        Me.countBloodQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbBloodGroup = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grpBloodDetails = New System.Windows.Forms.GroupBox()
        Me.cbBloodCity = New System.Windows.Forms.ComboBox()
        Me.cbBloodState = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBloodContact2 = New System.Windows.Forms.TextBox()
        Me.txtBloodContact1 = New System.Windows.Forms.TextBox()
        Me.txtBloodAddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBloodname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabHospital.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.gridviewHosp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHospDetail.SuspendLayout()
        Me.grpHospAvailability.SuspendLayout()
        CType(Me.countHospFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBlood.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.gridviewBlood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBloodAvailability.SuspendLayout()
        CType(Me.countBloodQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBloodDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(719, 759)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registration"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabHospital)
        Me.TabControl1.Controls.Add(Me.tabBlood)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(9, 73)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(719, 714)
        Me.TabControl1.TabIndex = 78
        '
        'tabHospital
        '
        Me.tabHospital.Controls.Add(Me.btnHospSubmit)
        Me.tabHospital.Controls.Add(Me.btnHospCancel)
        Me.tabHospital.Controls.Add(Me.checkHosp)
        Me.tabHospital.Controls.Add(Me.GroupBox5)
        Me.tabHospital.Controls.Add(Me.grpHospDetail)
        Me.tabHospital.Controls.Add(Me.grpHospAvailability)
        Me.tabHospital.Location = New System.Drawing.Point(4, 29)
        Me.tabHospital.Margin = New System.Windows.Forms.Padding(4)
        Me.tabHospital.Name = "tabHospital"
        Me.tabHospital.Padding = New System.Windows.Forms.Padding(4)
        Me.tabHospital.Size = New System.Drawing.Size(711, 681)
        Me.tabHospital.TabIndex = 0
        Me.tabHospital.Text = "Hospital"
        Me.tabHospital.UseVisualStyleBackColor = True
        '
        'btnHospSubmit
        '
        Me.btnHospSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnHospSubmit.FlatAppearance.BorderSize = 0
        Me.btnHospSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHospSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHospSubmit.Location = New System.Drawing.Point(392, 615)
        Me.btnHospSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHospSubmit.Name = "btnHospSubmit"
        Me.btnHospSubmit.Size = New System.Drawing.Size(116, 38)
        Me.btnHospSubmit.TabIndex = 10
        Me.btnHospSubmit.Text = "Submit"
        Me.btnHospSubmit.UseVisualStyleBackColor = False
        '
        'btnHospCancel
        '
        Me.btnHospCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnHospCancel.FlatAppearance.BorderSize = 0
        Me.btnHospCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHospCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHospCancel.Location = New System.Drawing.Point(211, 615)
        Me.btnHospCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHospCancel.Name = "btnHospCancel"
        Me.btnHospCancel.Size = New System.Drawing.Size(113, 38)
        Me.btnHospCancel.TabIndex = 12
        Me.btnHospCancel.Text = "Cancel"
        Me.btnHospCancel.UseVisualStyleBackColor = False
        '
        'checkHosp
        '
        Me.checkHosp.AutoSize = True
        Me.checkHosp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkHosp.ForeColor = System.Drawing.Color.Black
        Me.checkHosp.Location = New System.Drawing.Point(19, 587)
        Me.checkHosp.Margin = New System.Windows.Forms.Padding(4)
        Me.checkHosp.Name = "checkHosp"
        Me.checkHosp.Size = New System.Drawing.Size(630, 19)
        Me.checkHosp.TabIndex = 9
        Me.checkHosp.Text = "I/we agree that all the details mentioned above are accurate and I/we will be res" & _
            "ponsible if found to be incorrect"
        Me.checkHosp.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.gridviewHosp)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox5.Location = New System.Drawing.Point(19, 388)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(681, 199)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Review"
        '
        'gridviewHosp
        '
        Me.gridviewHosp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewHosp.Location = New System.Drawing.Point(44, 25)
        Me.gridviewHosp.Margin = New System.Windows.Forms.Padding(4)
        Me.gridviewHosp.Name = "gridviewHosp"
        Me.gridviewHosp.Size = New System.Drawing.Size(603, 167)
        Me.gridviewHosp.TabIndex = 0
        '
        'grpHospDetail
        '
        Me.grpHospDetail.Controls.Add(Me.cbHospCity)
        Me.grpHospDetail.Controls.Add(Me.cbHospState)
        Me.grpHospDetail.Controls.Add(Me.Label8)
        Me.grpHospDetail.Controls.Add(Me.Label7)
        Me.grpHospDetail.Controls.Add(Me.Label3)
        Me.grpHospDetail.Controls.Add(Me.txtHospContact2)
        Me.grpHospDetail.Controls.Add(Me.txtHospContact1)
        Me.grpHospDetail.Controls.Add(Me.txtHospAddress)
        Me.grpHospDetail.Controls.Add(Me.Label2)
        Me.grpHospDetail.Controls.Add(Me.txtHospName)
        Me.grpHospDetail.Controls.Add(Me.Label1)
        Me.grpHospDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHospDetail.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpHospDetail.Location = New System.Drawing.Point(20, 16)
        Me.grpHospDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.grpHospDetail.Name = "grpHospDetail"
        Me.grpHospDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.grpHospDetail.Size = New System.Drawing.Size(680, 209)
        Me.grpHospDetail.TabIndex = 9
        Me.grpHospDetail.TabStop = False
        Me.grpHospDetail.Text = "Hospital Details"
        '
        'cbHospCity
        '
        Me.cbHospCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbHospCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbHospCity.FormattingEnabled = True
        Me.cbHospCity.Location = New System.Drawing.Point(441, 122)
        Me.cbHospCity.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHospCity.Name = "cbHospCity"
        Me.cbHospCity.Size = New System.Drawing.Size(180, 26)
        Me.cbHospCity.TabIndex = 3
        Me.cbHospCity.Text = "-Select-"
        '
        'cbHospState
        '
        Me.cbHospState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbHospState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbHospState.FormattingEnabled = True
        Me.cbHospState.Location = New System.Drawing.Point(168, 121)
        Me.cbHospState.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHospState.Name = "cbHospState"
        Me.cbHospState.Size = New System.Drawing.Size(188, 26)
        Me.cbHospState.TabIndex = 2
        Me.cbHospState.Text = "-Select-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(393, 126)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 174)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Contact No.*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(39, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "State*"
        '
        'txtHospContact2
        '
        Me.txtHospContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospContact2.Location = New System.Drawing.Point(376, 170)
        Me.txtHospContact2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHospContact2.MaxLength = 10
        Me.txtHospContact2.Name = "txtHospContact2"
        Me.txtHospContact2.Size = New System.Drawing.Size(169, 26)
        Me.txtHospContact2.TabIndex = 5
        '
        'txtHospContact1
        '
        Me.txtHospContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospContact1.Location = New System.Drawing.Point(168, 170)
        Me.txtHospContact1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHospContact1.MaxLength = 10
        Me.txtHospContact1.Name = "txtHospContact1"
        Me.txtHospContact1.Size = New System.Drawing.Size(169, 26)
        Me.txtHospContact1.TabIndex = 4
        '
        'txtHospAddress
        '
        Me.txtHospAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospAddress.Location = New System.Drawing.Point(168, 64)
        Me.txtHospAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHospAddress.Multiline = True
        Me.txtHospAddress.Name = "txtHospAddress"
        Me.txtHospAddress.Size = New System.Drawing.Size(476, 43)
        Me.txtHospAddress.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Address*"
        '
        'txtHospName
        '
        Me.txtHospName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospName.Location = New System.Drawing.Point(168, 30)
        Me.txtHospName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHospName.Name = "txtHospName"
        Me.txtHospName.Size = New System.Drawing.Size(476, 26)
        Me.txtHospName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hospital Name*"
        '
        'grpHospAvailability
        '
        Me.grpHospAvailability.Controls.Add(Me.cbHospFacility)
        Me.grpHospAvailability.Controls.Add(Me.Label31)
        Me.grpHospAvailability.Controls.Add(Me.btdHospAdd)
        Me.grpHospAvailability.Controls.Add(Me.countHospFacility)
        Me.grpHospAvailability.Controls.Add(Me.Label5)
        Me.grpHospAvailability.Controls.Add(Me.Label4)
        Me.grpHospAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHospAvailability.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpHospAvailability.Location = New System.Drawing.Point(19, 251)
        Me.grpHospAvailability.Margin = New System.Windows.Forms.Padding(4)
        Me.grpHospAvailability.Name = "grpHospAvailability"
        Me.grpHospAvailability.Padding = New System.Windows.Forms.Padding(4)
        Me.grpHospAvailability.Size = New System.Drawing.Size(681, 117)
        Me.grpHospAvailability.TabIndex = 8
        Me.grpHospAvailability.TabStop = False
        Me.grpHospAvailability.Text = "Availability"
        '
        'cbHospFacility
        '
        Me.cbHospFacility.FormattingEnabled = True
        Me.cbHospFacility.Location = New System.Drawing.Point(168, 32)
        Me.cbHospFacility.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHospFacility.Name = "cbHospFacility"
        Me.cbHospFacility.Size = New System.Drawing.Size(160, 26)
        Me.cbHospFacility.TabIndex = 6
        Me.cbHospFacility.Text = "-Select-"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(368, 94)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(303, 15)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "*To Add Multiple Facility Entries, Add One After Another"
        '
        'btdHospAdd
        '
        Me.btdHospAdd.BackColor = System.Drawing.Color.DarkGray
        Me.btdHospAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btdHospAdd.ForeColor = System.Drawing.Color.Black
        Me.btdHospAdd.Location = New System.Drawing.Point(417, 52)
        Me.btdHospAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btdHospAdd.Name = "btdHospAdd"
        Me.btdHospAdd.Size = New System.Drawing.Size(116, 38)
        Me.btdHospAdd.TabIndex = 8
        Me.btdHospAdd.Text = "Add"
        Me.btdHospAdd.UseVisualStyleBackColor = False
        '
        'countHospFacility
        '
        Me.countHospFacility.Location = New System.Drawing.Point(169, 80)
        Me.countHospFacility.Margin = New System.Windows.Forms.Padding(4)
        Me.countHospFacility.Name = "countHospFacility"
        Me.countHospFacility.Size = New System.Drawing.Size(160, 24)
        Me.countHospFacility.TabIndex = 7
        Me.countHospFacility.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(40, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Availability*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 40)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Facilities" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Available*"
        '
        'tabBlood
        '
        Me.tabBlood.Controls.Add(Me.btnBloodSubmit)
        Me.tabBlood.Controls.Add(Me.btnBloodCancel)
        Me.tabBlood.Controls.Add(Me.GroupBox7)
        Me.tabBlood.Controls.Add(Me.checkBlood)
        Me.tabBlood.Controls.Add(Me.grpBloodAvailability)
        Me.tabBlood.Controls.Add(Me.grpBloodDetails)
        Me.tabBlood.Location = New System.Drawing.Point(4, 29)
        Me.tabBlood.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBlood.Name = "tabBlood"
        Me.tabBlood.Padding = New System.Windows.Forms.Padding(4)
        Me.tabBlood.Size = New System.Drawing.Size(711, 681)
        Me.tabBlood.TabIndex = 1
        Me.tabBlood.Text = "Blood Bank"
        Me.tabBlood.UseVisualStyleBackColor = True
        '
        'btnBloodSubmit
        '
        Me.btnBloodSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnBloodSubmit.FlatAppearance.BorderSize = 0
        Me.btnBloodSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBloodSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBloodSubmit.Location = New System.Drawing.Point(399, 619)
        Me.btnBloodSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBloodSubmit.Name = "btnBloodSubmit"
        Me.btnBloodSubmit.Size = New System.Drawing.Size(116, 38)
        Me.btnBloodSubmit.TabIndex = 25
        Me.btnBloodSubmit.Text = "Submit"
        Me.btnBloodSubmit.UseVisualStyleBackColor = False
        '
        'btnBloodCancel
        '
        Me.btnBloodCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnBloodCancel.FlatAppearance.BorderSize = 0
        Me.btnBloodCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBloodCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBloodCancel.Location = New System.Drawing.Point(217, 619)
        Me.btnBloodCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBloodCancel.Name = "btnBloodCancel"
        Me.btnBloodCancel.Size = New System.Drawing.Size(113, 38)
        Me.btnBloodCancel.TabIndex = 11
        Me.btnBloodCancel.Text = "Cancel"
        Me.btnBloodCancel.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.gridviewBlood)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox7.Location = New System.Drawing.Point(23, 402)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(681, 178)
        Me.GroupBox7.TabIndex = 58
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Review"
        '
        'gridviewBlood
        '
        Me.gridviewBlood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewBlood.Location = New System.Drawing.Point(44, 25)
        Me.gridviewBlood.Margin = New System.Windows.Forms.Padding(4)
        Me.gridviewBlood.Name = "gridviewBlood"
        Me.gridviewBlood.Size = New System.Drawing.Size(603, 150)
        Me.gridviewBlood.TabIndex = 59
        '
        'checkBlood
        '
        Me.checkBlood.AutoSize = True
        Me.checkBlood.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBlood.ForeColor = System.Drawing.Color.Black
        Me.checkBlood.Location = New System.Drawing.Point(23, 585)
        Me.checkBlood.Margin = New System.Windows.Forms.Padding(4)
        Me.checkBlood.Name = "checkBlood"
        Me.checkBlood.Size = New System.Drawing.Size(630, 19)
        Me.checkBlood.TabIndex = 24
        Me.checkBlood.Text = "I/we agree that all the details mentioned above are accurate and I/we will be res" & _
            "ponsible if found to be incorrect"
        Me.checkBlood.UseVisualStyleBackColor = True
        '
        'grpBloodAvailability
        '
        Me.grpBloodAvailability.Controls.Add(Me.Label6)
        Me.grpBloodAvailability.Controls.Add(Me.btnBloodAdd)
        Me.grpBloodAvailability.Controls.Add(Me.countBloodQuantity)
        Me.grpBloodAvailability.Controls.Add(Me.Label15)
        Me.grpBloodAvailability.Controls.Add(Me.cbBloodGroup)
        Me.grpBloodAvailability.Controls.Add(Me.Label16)
        Me.grpBloodAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBloodAvailability.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpBloodAvailability.Location = New System.Drawing.Point(23, 261)
        Me.grpBloodAvailability.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBloodAvailability.Name = "grpBloodAvailability"
        Me.grpBloodAvailability.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBloodAvailability.Size = New System.Drawing.Size(681, 117)
        Me.grpBloodAvailability.TabIndex = 57
        Me.grpBloodAvailability.TabStop = False
        Me.grpBloodAvailability.Text = "Availability"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(360, 95)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(300, 15)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "*To Add Multiple Group Entries, Add One After Another"
        '
        'btnBloodAdd
        '
        Me.btnBloodAdd.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnBloodAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBloodAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBloodAdd.Location = New System.Drawing.Point(416, 53)
        Me.btnBloodAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBloodAdd.Name = "btnBloodAdd"
        Me.btnBloodAdd.Size = New System.Drawing.Size(116, 38)
        Me.btnBloodAdd.TabIndex = 23
        Me.btnBloodAdd.Text = "Add"
        Me.btnBloodAdd.UseVisualStyleBackColor = False
        '
        'countBloodQuantity
        '
        Me.countBloodQuantity.Location = New System.Drawing.Point(169, 71)
        Me.countBloodQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.countBloodQuantity.Name = "countBloodQuantity"
        Me.countBloodQuantity.Size = New System.Drawing.Size(160, 24)
        Me.countBloodQuantity.TabIndex = 22
        Me.countBloodQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(44, 71)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 20)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Availability"
        '
        'cbBloodGroup
        '
        Me.cbBloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBloodGroup.FormattingEnabled = True
        Me.cbBloodGroup.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.cbBloodGroup.Location = New System.Drawing.Point(168, 28)
        Me.cbBloodGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBloodGroup.Name = "cbBloodGroup"
        Me.cbBloodGroup.Size = New System.Drawing.Size(160, 26)
        Me.cbBloodGroup.TabIndex = 21
        Me.cbBloodGroup.Text = "-Select-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(40, 32)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 20)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Blood Group"
        '
        'grpBloodDetails
        '
        Me.grpBloodDetails.Controls.Add(Me.cbBloodCity)
        Me.grpBloodDetails.Controls.Add(Me.cbBloodState)
        Me.grpBloodDetails.Controls.Add(Me.Label9)
        Me.grpBloodDetails.Controls.Add(Me.Label10)
        Me.grpBloodDetails.Controls.Add(Me.Label11)
        Me.grpBloodDetails.Controls.Add(Me.txtBloodContact2)
        Me.grpBloodDetails.Controls.Add(Me.txtBloodContact1)
        Me.grpBloodDetails.Controls.Add(Me.txtBloodAddress)
        Me.grpBloodDetails.Controls.Add(Me.Label12)
        Me.grpBloodDetails.Controls.Add(Me.txtBloodname)
        Me.grpBloodDetails.Controls.Add(Me.Label13)
        Me.grpBloodDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBloodDetails.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpBloodDetails.Location = New System.Drawing.Point(23, 16)
        Me.grpBloodDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBloodDetails.Name = "grpBloodDetails"
        Me.grpBloodDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBloodDetails.Size = New System.Drawing.Size(680, 220)
        Me.grpBloodDetails.TabIndex = 56
        Me.grpBloodDetails.TabStop = False
        Me.grpBloodDetails.Text = "Blood Bank Details"
        '
        'cbBloodCity
        '
        Me.cbBloodCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBloodCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBloodCity.FormattingEnabled = True
        Me.cbBloodCity.Location = New System.Drawing.Point(420, 134)
        Me.cbBloodCity.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBloodCity.Name = "cbBloodCity"
        Me.cbBloodCity.Size = New System.Drawing.Size(188, 26)
        Me.cbBloodCity.TabIndex = 18
        Me.cbBloodCity.Text = "-Select-"
        '
        'cbBloodState
        '
        Me.cbBloodState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBloodState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBloodState.FormattingEnabled = True
        Me.cbBloodState.Location = New System.Drawing.Point(168, 134)
        Me.cbBloodState.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBloodState.Name = "cbBloodState"
        Me.cbBloodState.Size = New System.Drawing.Size(191, 26)
        Me.cbBloodState.TabIndex = 17
        Me.cbBloodState.Text = "-Select-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(372, 138)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "City"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(39, 187)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Contact No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(39, 138)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "State"
        '
        'txtBloodContact2
        '
        Me.txtBloodContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloodContact2.Location = New System.Drawing.Point(376, 183)
        Me.txtBloodContact2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBloodContact2.MaxLength = 10
        Me.txtBloodContact2.Name = "txtBloodContact2"
        Me.txtBloodContact2.Size = New System.Drawing.Size(169, 26)
        Me.txtBloodContact2.TabIndex = 20
        '
        'txtBloodContact1
        '
        Me.txtBloodContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloodContact1.Location = New System.Drawing.Point(168, 183)
        Me.txtBloodContact1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBloodContact1.MaxLength = 10
        Me.txtBloodContact1.Name = "txtBloodContact1"
        Me.txtBloodContact1.Size = New System.Drawing.Size(169, 26)
        Me.txtBloodContact1.TabIndex = 19
        '
        'txtBloodAddress
        '
        Me.txtBloodAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloodAddress.Location = New System.Drawing.Point(168, 78)
        Me.txtBloodAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBloodAddress.Multiline = True
        Me.txtBloodAddress.Name = "txtBloodAddress"
        Me.txtBloodAddress.Size = New System.Drawing.Size(476, 43)
        Me.txtBloodAddress.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(39, 85)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Address"
        '
        'txtBloodname
        '
        Me.txtBloodname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloodname.Location = New System.Drawing.Point(168, 38)
        Me.txtBloodname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBloodname.Name = "txtBloodname"
        Me.txtBloodname.Size = New System.Drawing.Size(476, 26)
        Me.txtBloodname.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(39, 33)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 40)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Organisation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name"
        '
        'registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(737, 769)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EquiAssist Registration"
        Me.TabControl1.ResumeLayout(False)
        Me.tabHospital.ResumeLayout(False)
        Me.tabHospital.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.gridviewHosp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHospDetail.ResumeLayout(False)
        Me.grpHospDetail.PerformLayout()
        Me.grpHospAvailability.ResumeLayout(False)
        Me.grpHospAvailability.PerformLayout()
        CType(Me.countHospFacility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBlood.ResumeLayout(False)
        Me.tabBlood.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.gridviewBlood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBloodAvailability.ResumeLayout(False)
        Me.grpBloodAvailability.PerformLayout()
        CType(Me.countBloodQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBloodDetails.ResumeLayout(False)
        Me.grpBloodDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabHospital As System.Windows.Forms.TabPage
    Friend WithEvents tabBlood As System.Windows.Forms.TabPage
    Friend WithEvents grpHospDetail As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHospName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpHospAvailability As System.Windows.Forms.GroupBox
    Friend WithEvents countHospFacility As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents gridviewHosp As System.Windows.Forms.DataGridView
    Friend WithEvents btnHospSubmit As System.Windows.Forms.Button
    Friend WithEvents btnHospCancel As System.Windows.Forms.Button
    Friend WithEvents checkHosp As System.Windows.Forms.CheckBox
    Friend WithEvents cbHospCity As System.Windows.Forms.ComboBox
    Friend WithEvents cbHospState As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHospContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHospContact1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHospAddress As System.Windows.Forms.TextBox
    Friend WithEvents grpBloodDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cbBloodCity As System.Windows.Forms.ComboBox
    Friend WithEvents cbBloodState As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBloodContact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBloodContact1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBloodAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBloodname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grpBloodAvailability As System.Windows.Forms.GroupBox
    Friend WithEvents countBloodQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbBloodGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents checkBlood As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents gridviewBlood As System.Windows.Forms.DataGridView
    Friend WithEvents btnBloodSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBloodCancel As System.Windows.Forms.Button
    Friend WithEvents btdHospAdd As System.Windows.Forms.Button
    Friend WithEvents btnBloodAdd As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbHospFacility As System.Windows.Forms.ComboBox

End Class
