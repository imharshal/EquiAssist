<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReqAssistanceDialog
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
        Me.grpRequirement = New System.Windows.Forms.GroupBox()
        Me.checkBGroup = New System.Windows.Forms.RadioButton()
        Me.checkFacility = New System.Windows.Forms.RadioButton()
        Me.cbBgroup = New System.Windows.Forms.ComboBox()
        Me.cbFacilityReq = New System.Windows.Forms.ComboBox()
        Me.grpPatient = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.cbPatientID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridviewList = New System.Windows.Forms.DataGridView()
        Me.grpHospitalList = New System.Windows.Forms.GroupBox()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.checkPermit = New System.Windows.Forms.CheckBox()
        Me.grpRequirement.SuspendLayout()
        Me.grpPatient.SuspendLayout()
        CType(Me.gridviewList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHospitalList.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRequirement
        '
        Me.grpRequirement.Controls.Add(Me.checkBGroup)
        Me.grpRequirement.Controls.Add(Me.checkFacility)
        Me.grpRequirement.Controls.Add(Me.cbBgroup)
        Me.grpRequirement.Controls.Add(Me.cbFacilityReq)
        Me.grpRequirement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRequirement.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpRequirement.Location = New System.Drawing.Point(33, 25)
        Me.grpRequirement.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRequirement.Name = "grpRequirement"
        Me.grpRequirement.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRequirement.Size = New System.Drawing.Size(494, 114)
        Me.grpRequirement.TabIndex = 9
        Me.grpRequirement.TabStop = False
        Me.grpRequirement.Text = "Requirement"
        '
        'checkBGroup
        '
        Me.checkBGroup.AutoSize = True
        Me.checkBGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBGroup.ForeColor = System.Drawing.Color.Black
        Me.checkBGroup.Location = New System.Drawing.Point(35, 76)
        Me.checkBGroup.Name = "checkBGroup"
        Me.checkBGroup.Size = New System.Drawing.Size(106, 21)
        Me.checkBGroup.TabIndex = 34
        Me.checkBGroup.TabStop = True
        Me.checkBGroup.Text = "Blood Group"
        Me.checkBGroup.UseVisualStyleBackColor = True
        '
        'checkFacility
        '
        Me.checkFacility.AutoSize = True
        Me.checkFacility.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFacility.ForeColor = System.Drawing.Color.Black
        Me.checkFacility.Location = New System.Drawing.Point(35, 33)
        Me.checkFacility.Name = "checkFacility"
        Me.checkFacility.Size = New System.Drawing.Size(69, 21)
        Me.checkFacility.TabIndex = 33
        Me.checkFacility.TabStop = True
        Me.checkFacility.Text = "Facility"
        Me.checkFacility.UseVisualStyleBackColor = True
        '
        'cbBgroup
        '
        Me.cbBgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBgroup.FormattingEnabled = True
        Me.cbBgroup.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.cbBgroup.Location = New System.Drawing.Point(206, 76)
        Me.cbBgroup.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBgroup.Name = "cbBgroup"
        Me.cbBgroup.Size = New System.Drawing.Size(120, 23)
        Me.cbBgroup.TabIndex = 31
        Me.cbBgroup.Text = "-Select-"
        '
        'cbFacilityReq
        '
        Me.cbFacilityReq.FormattingEnabled = True
        Me.cbFacilityReq.Location = New System.Drawing.Point(206, 32)
        Me.cbFacilityReq.Margin = New System.Windows.Forms.Padding(4)
        Me.cbFacilityReq.Name = "cbFacilityReq"
        Me.cbFacilityReq.Size = New System.Drawing.Size(179, 23)
        Me.cbFacilityReq.TabIndex = 1
        Me.cbFacilityReq.Text = "-Select-"
        '
        'grpPatient
        '
        Me.grpPatient.Controls.Add(Me.Label7)
        Me.grpPatient.Controls.Add(Me.txtPatientName)
        Me.grpPatient.Controls.Add(Me.cbPatientID)
        Me.grpPatient.Controls.Add(Me.Label1)
        Me.grpPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPatient.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpPatient.Location = New System.Drawing.Point(33, 470)
        Me.grpPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPatient.Name = "grpPatient"
        Me.grpPatient.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPatient.Size = New System.Drawing.Size(494, 104)
        Me.grpPatient.TabIndex = 10
        Me.grpPatient.TabStop = False
        Me.grpPatient.Text = "Select Patient "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Patient Name"
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(160, 72)
        Me.txtPatientName.MaxLength = 10
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.ReadOnly = True
        Me.txtPatientName.Size = New System.Drawing.Size(307, 22)
        Me.txtPatientName.TabIndex = 17
        '
        'cbPatientID
        '
        Me.cbPatientID.FormattingEnabled = True
        Me.cbPatientID.Location = New System.Drawing.Point(160, 34)
        Me.cbPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPatientID.Name = "cbPatientID"
        Me.cbPatientID.Size = New System.Drawing.Size(179, 23)
        Me.cbPatientID.TabIndex = 1
        Me.cbPatientID.Text = "-Select-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient ID"
        '
        'gridviewList
        '
        Me.gridviewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewList.Location = New System.Drawing.Point(7, 45)
        Me.gridviewList.Name = "gridviewList"
        Me.gridviewList.Size = New System.Drawing.Size(480, 228)
        Me.gridviewList.TabIndex = 16
        '
        'grpHospitalList
        '
        Me.grpHospitalList.Controls.Add(Me.gridviewList)
        Me.grpHospitalList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHospitalList.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpHospitalList.Location = New System.Drawing.Point(33, 161)
        Me.grpHospitalList.Margin = New System.Windows.Forms.Padding(4)
        Me.grpHospitalList.Name = "grpHospitalList"
        Me.grpHospitalList.Padding = New System.Windows.Forms.Padding(4)
        Me.grpHospitalList.Size = New System.Drawing.Size(494, 280)
        Me.grpHospitalList.TabIndex = 17
        Me.grpHospitalList.TabStop = False
        Me.grpHospitalList.Text = "Hospitals Having Facility"
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRequest.FlatAppearance.BorderSize = 0
        Me.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRequest.Location = New System.Drawing.Point(153, 648)
        Me.btnRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(229, 38)
        Me.btnRequest.TabIndex = 18
        Me.btnRequest.Text = "Request An Assistance"
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'checkPermit
        '
        Me.checkPermit.AutoSize = True
        Me.checkPermit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkPermit.ForeColor = System.Drawing.Color.Black
        Me.checkPermit.Location = New System.Drawing.Point(51, 582)
        Me.checkPermit.Margin = New System.Windows.Forms.Padding(4)
        Me.checkPermit.Name = "checkPermit"
        Me.checkPermit.Size = New System.Drawing.Size(361, 28)
        Me.checkPermit.TabIndex = 19
        Me.checkPermit.Text = "I/we agree that all the sensetive patient information could be shared for assista" & _
            "nce " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with the ""Selected Hospital"""
        Me.checkPermit.UseVisualStyleBackColor = True
        '
        'ReqAssistanceDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(563, 711)
        Me.Controls.Add(Me.checkPermit)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.grpHospitalList)
        Me.Controls.Add(Me.grpPatient)
        Me.Controls.Add(Me.grpRequirement)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReqAssistanceDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request For Assistance"
        Me.grpRequirement.ResumeLayout(False)
        Me.grpRequirement.PerformLayout()
        Me.grpPatient.ResumeLayout(False)
        Me.grpPatient.PerformLayout()
        CType(Me.gridviewList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHospitalList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpRequirement As System.Windows.Forms.GroupBox
    Friend WithEvents cbFacilityReq As System.Windows.Forms.ComboBox
    Friend WithEvents grpPatient As System.Windows.Forms.GroupBox
    Friend WithEvents cbPatientID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents gridviewList As System.Windows.Forms.DataGridView
    Friend WithEvents grpHospitalList As System.Windows.Forms.GroupBox
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents checkPermit As System.Windows.Forms.CheckBox
    Friend WithEvents cbBgroup As System.Windows.Forms.ComboBox
    Friend WithEvents checkBGroup As System.Windows.Forms.RadioButton
    Friend WithEvents checkFacility As System.Windows.Forms.RadioButton

End Class
