<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssistDialogue
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabNewRequests = New System.Windows.Forms.TabPage()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.btnAcceptRequest = New System.Windows.Forms.Button()
        Me.grpNewRequests = New System.Windows.Forms.GroupBox()
        Me.lblNoRecordFound = New System.Windows.Forms.Label()
        Me.checkPermit = New System.Windows.Forms.CheckBox()
        Me.gridviewRequests = New System.Windows.Forms.DataGridView()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.grpHistory = New System.Windows.Forms.GroupBox()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.gridviewHistory = New System.Windows.Forms.DataGridView()
        Me.grpDuration = New System.Windows.Forms.GroupBox()
        Me.tickJumpDate = New System.Windows.Forms.RadioButton()
        Me.tickDuration = New System.Windows.Forms.RadioButton()
        Me.calJumpDate = New System.Windows.Forms.DateTimePicker()
        Me.cbDuration = New System.Windows.Forms.ComboBox()
        Me.btnDurationSubmit = New System.Windows.Forms.Button()
        Me.tabYourRequest = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblNoRequests = New System.Windows.Forms.Label()
        Me.gridviewYourRequests = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.tabNewRequests.SuspendLayout()
        Me.grpNewRequests.SuspendLayout()
        CType(Me.gridviewRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        Me.grpHistory.SuspendLayout()
        CType(Me.gridviewHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuration.SuspendLayout()
        Me.tabYourRequest.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridviewYourRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabNewRequests)
        Me.TabControl1.Controls.Add(Me.tabHistory)
        Me.TabControl1.Controls.Add(Me.tabYourRequest)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(14, 24)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(471, 413)
        Me.TabControl1.TabIndex = 1
        '
        'tabNewRequests
        '
        Me.tabNewRequests.Controls.Add(Me.btnDecline)
        Me.tabNewRequests.Controls.Add(Me.btnAcceptRequest)
        Me.tabNewRequests.Controls.Add(Me.grpNewRequests)
        Me.tabNewRequests.Location = New System.Drawing.Point(4, 25)
        Me.tabNewRequests.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabNewRequests.Name = "tabNewRequests"
        Me.tabNewRequests.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabNewRequests.Size = New System.Drawing.Size(463, 384)
        Me.tabNewRequests.TabIndex = 0
        Me.tabNewRequests.Text = "New Requests"
        Me.tabNewRequests.UseVisualStyleBackColor = True
        '
        'btnDecline
        '
        Me.btnDecline.BackColor = System.Drawing.Color.Tomato
        Me.btnDecline.FlatAppearance.BorderSize = 0
        Me.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecline.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecline.ForeColor = System.Drawing.Color.SeaShell
        Me.btnDecline.Location = New System.Drawing.Point(35, 335)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(78, 31)
        Me.btnDecline.TabIndex = 27
        Me.btnDecline.Text = "Decline" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDecline.UseVisualStyleBackColor = False
        '
        'btnAcceptRequest
        '
        Me.btnAcceptRequest.BackColor = System.Drawing.Color.Chartreuse
        Me.btnAcceptRequest.FlatAppearance.BorderSize = 0
        Me.btnAcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceptRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptRequest.ForeColor = System.Drawing.Color.SeaShell
        Me.btnAcceptRequest.Location = New System.Drawing.Point(169, 335)
        Me.btnAcceptRequest.Name = "btnAcceptRequest"
        Me.btnAcceptRequest.Size = New System.Drawing.Size(142, 31)
        Me.btnAcceptRequest.TabIndex = 26
        Me.btnAcceptRequest.Text = "Accept Request" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAcceptRequest.UseVisualStyleBackColor = False
        '
        'grpNewRequests
        '
        Me.grpNewRequests.Controls.Add(Me.lblNoRecordFound)
        Me.grpNewRequests.Controls.Add(Me.checkPermit)
        Me.grpNewRequests.Controls.Add(Me.gridviewRequests)
        Me.grpNewRequests.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNewRequests.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpNewRequests.Location = New System.Drawing.Point(5, 16)
        Me.grpNewRequests.Name = "grpNewRequests"
        Me.grpNewRequests.Size = New System.Drawing.Size(454, 305)
        Me.grpNewRequests.TabIndex = 19
        Me.grpNewRequests.TabStop = False
        Me.grpNewRequests.Text = "Select Request"
        '
        'lblNoRecordFound
        '
        Me.lblNoRecordFound.AutoSize = True
        Me.lblNoRecordFound.BackColor = System.Drawing.Color.White
        Me.lblNoRecordFound.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblNoRecordFound.Location = New System.Drawing.Point(138, 139)
        Me.lblNoRecordFound.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoRecordFound.Name = "lblNoRecordFound"
        Me.lblNoRecordFound.Size = New System.Drawing.Size(190, 15)
        Me.lblNoRecordFound.TabIndex = 27
        Me.lblNoRecordFound.Text = "No Pending Requests Found"
        '
        'checkPermit
        '
        Me.checkPermit.AutoSize = True
        Me.checkPermit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkPermit.ForeColor = System.Drawing.Color.Black
        Me.checkPermit.Location = New System.Drawing.Point(6, 265)
        Me.checkPermit.Name = "checkPermit"
        Me.checkPermit.Size = New System.Drawing.Size(344, 23)
        Me.checkPermit.TabIndex = 26
        Me.checkPermit.Text = "  I/we agree that the Requested Equipment is belong to me/us for that I/we ready " & _
            "to Provide an Assistance," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   All the sensetive patient information could be use" & _
            "d for Assistance perpose only"
        Me.checkPermit.UseVisualStyleBackColor = True
        '
        'gridviewRequests
        '
        Me.gridviewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewRequests.Location = New System.Drawing.Point(14, 33)
        Me.gridviewRequests.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gridviewRequests.MultiSelect = False
        Me.gridviewRequests.Name = "gridviewRequests"
        Me.gridviewRequests.RowTemplate.Height = 24
        Me.gridviewRequests.ShowEditingIcon = False
        Me.gridviewRequests.Size = New System.Drawing.Size(426, 228)
        Me.gridviewRequests.TabIndex = 24
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.grpHistory)
        Me.tabHistory.Controls.Add(Me.grpDuration)
        Me.tabHistory.Location = New System.Drawing.Point(4, 25)
        Me.tabHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabHistory.Size = New System.Drawing.Size(463, 384)
        Me.tabHistory.TabIndex = 1
        Me.tabHistory.Text = "History"
        Me.tabHistory.UseVisualStyleBackColor = True
        '
        'grpHistory
        '
        Me.grpHistory.Controls.Add(Me.lblNoRecord)
        Me.grpHistory.Controls.Add(Me.gridviewHistory)
        Me.grpHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistory.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpHistory.Location = New System.Drawing.Point(16, 135)
        Me.grpHistory.Name = "grpHistory"
        Me.grpHistory.Size = New System.Drawing.Size(434, 240)
        Me.grpHistory.TabIndex = 18
        Me.grpHistory.TabStop = False
        Me.grpHistory.Text = "Accepted Requests"
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.BackColor = System.Drawing.Color.White
        Me.lblNoRecord.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblNoRecord.Location = New System.Drawing.Point(120, 124)
        Me.lblNoRecord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(195, 15)
        Me.lblNoRecord.TabIndex = 28
        Me.lblNoRecord.Text = "No Accepted Requests Found"
        Me.lblNoRecord.Visible = False
        '
        'gridviewHistory
        '
        Me.gridviewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewHistory.Location = New System.Drawing.Point(5, 25)
        Me.gridviewHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gridviewHistory.MultiSelect = False
        Me.gridviewHistory.Name = "gridviewHistory"
        Me.gridviewHistory.Size = New System.Drawing.Size(423, 210)
        Me.gridviewHistory.TabIndex = 16
        '
        'grpDuration
        '
        Me.grpDuration.Controls.Add(Me.tickJumpDate)
        Me.grpDuration.Controls.Add(Me.tickDuration)
        Me.grpDuration.Controls.Add(Me.calJumpDate)
        Me.grpDuration.Controls.Add(Me.cbDuration)
        Me.grpDuration.Controls.Add(Me.btnDurationSubmit)
        Me.grpDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDuration.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpDuration.Location = New System.Drawing.Point(16, 16)
        Me.grpDuration.Name = "grpDuration"
        Me.grpDuration.Size = New System.Drawing.Size(434, 105)
        Me.grpDuration.TabIndex = 10
        Me.grpDuration.TabStop = False
        Me.grpDuration.Text = "Duration"
        '
        'tickJumpDate
        '
        Me.tickJumpDate.AutoSize = True
        Me.tickJumpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tickJumpDate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tickJumpDate.Location = New System.Drawing.Point(26, 72)
        Me.tickJumpDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tickJumpDate.Name = "tickJumpDate"
        Me.tickJumpDate.Size = New System.Drawing.Size(82, 17)
        Me.tickJumpDate.TabIndex = 19
        Me.tickJumpDate.Text = "Jump to Date"
        Me.tickJumpDate.UseVisualStyleBackColor = True
        '
        'tickDuration
        '
        Me.tickDuration.AutoSize = True
        Me.tickDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tickDuration.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tickDuration.Location = New System.Drawing.Point(26, 30)
        Me.tickDuration.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tickDuration.Name = "tickDuration"
        Me.tickDuration.Size = New System.Drawing.Size(60, 17)
        Me.tickDuration.TabIndex = 18
        Me.tickDuration.Text = "Duration"
        Me.tickDuration.UseVisualStyleBackColor = True
        '
        'calJumpDate
        '
        Me.calJumpDate.CustomFormat = "dd-MMM-yyyy"
        Me.calJumpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calJumpDate.Location = New System.Drawing.Point(136, 72)
        Me.calJumpDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.calJumpDate.Name = "calJumpDate"
        Me.calJumpDate.Size = New System.Drawing.Size(109, 21)
        Me.calJumpDate.TabIndex = 17
        '
        'cbDuration
        '
        Me.cbDuration.FormattingEnabled = True
        Me.cbDuration.Items.AddRange(New Object() {"Today", "This Month", "This Year", "Last Year"})
        Me.cbDuration.Location = New System.Drawing.Point(136, 30)
        Me.cbDuration.Name = "cbDuration"
        Me.cbDuration.Size = New System.Drawing.Size(151, 23)
        Me.cbDuration.TabIndex = 1
        Me.cbDuration.Text = "-Select-"
        '
        'btnDurationSubmit
        '
        Me.btnDurationSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDurationSubmit.FlatAppearance.BorderSize = 0
        Me.btnDurationSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDurationSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDurationSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDurationSubmit.Location = New System.Drawing.Point(337, 44)
        Me.btnDurationSubmit.Name = "btnDurationSubmit"
        Me.btnDurationSubmit.Size = New System.Drawing.Size(68, 31)
        Me.btnDurationSubmit.TabIndex = 15
        Me.btnDurationSubmit.Text = "Search"
        Me.btnDurationSubmit.UseVisualStyleBackColor = False
        '
        'tabYourRequest
        '
        Me.tabYourRequest.Controls.Add(Me.GroupBox2)
        Me.tabYourRequest.Location = New System.Drawing.Point(4, 25)
        Me.tabYourRequest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabYourRequest.Name = "tabYourRequest"
        Me.tabYourRequest.Size = New System.Drawing.Size(463, 384)
        Me.tabYourRequest.TabIndex = 2
        Me.tabYourRequest.Text = "Your Requests"
        Me.tabYourRequest.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.lblNoRequests)
        Me.GroupBox2.Controls.Add(Me.gridviewYourRequests)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(5, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 366)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Your Requests"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(363, 17)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 15)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh"
        '
        'lblNoRequests
        '
        Me.lblNoRequests.AutoSize = True
        Me.lblNoRequests.BackColor = System.Drawing.Color.White
        Me.lblNoRequests.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblNoRequests.Location = New System.Drawing.Point(132, 168)
        Me.lblNoRequests.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoRequests.Name = "lblNoRequests"
        Me.lblNoRequests.Size = New System.Drawing.Size(190, 15)
        Me.lblNoRequests.TabIndex = 27
        Me.lblNoRequests.Text = "No Pending Requests Found"
        Me.lblNoRequests.Visible = False
        '
        'gridviewYourRequests
        '
        Me.gridviewYourRequests.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridviewYourRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridviewYourRequests.Location = New System.Drawing.Point(14, 37)
        Me.gridviewYourRequests.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gridviewYourRequests.MultiSelect = False
        Me.gridviewYourRequests.Name = "gridviewYourRequests"
        Me.gridviewYourRequests.RowTemplate.Height = 24
        Me.gridviewYourRequests.ShowEditingIcon = False
        Me.gridviewYourRequests.Size = New System.Drawing.Size(426, 314)
        Me.gridviewYourRequests.TabIndex = 24
        '
        'AssistDialogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(504, 459)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssistDialogue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistance Dashboard"
        Me.TabControl1.ResumeLayout(False)
        Me.tabNewRequests.ResumeLayout(False)
        Me.grpNewRequests.ResumeLayout(False)
        Me.grpNewRequests.PerformLayout()
        CType(Me.gridviewRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        Me.grpHistory.ResumeLayout(False)
        Me.grpHistory.PerformLayout()
        CType(Me.gridviewHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDuration.ResumeLayout(False)
        Me.grpDuration.PerformLayout()
        Me.tabYourRequest.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridviewYourRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabNewRequests As System.Windows.Forms.TabPage
    Friend WithEvents tabHistory As System.Windows.Forms.TabPage
    Friend WithEvents grpHistory As System.Windows.Forms.GroupBox
    Friend WithEvents gridviewHistory As System.Windows.Forms.DataGridView
    Friend WithEvents grpDuration As System.Windows.Forms.GroupBox
    Friend WithEvents tickJumpDate As System.Windows.Forms.RadioButton
    Friend WithEvents tickDuration As System.Windows.Forms.RadioButton
    Friend WithEvents calJumpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbDuration As System.Windows.Forms.ComboBox
    Friend WithEvents btnDurationSubmit As System.Windows.Forms.Button
    Friend WithEvents grpNewRequests As System.Windows.Forms.GroupBox
    Friend WithEvents checkPermit As System.Windows.Forms.CheckBox
    Friend WithEvents gridviewRequests As System.Windows.Forms.DataGridView
    Friend WithEvents btnAcceptRequest As System.Windows.Forms.Button
    Friend WithEvents lblNoRecordFound As System.Windows.Forms.Label
    Friend WithEvents tabYourRequest As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNoRequests As System.Windows.Forms.Label
    Friend WithEvents gridviewYourRequests As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnDecline As System.Windows.Forms.Button
    Friend WithEvents lblNoRecord As System.Windows.Forms.Label

End Class
