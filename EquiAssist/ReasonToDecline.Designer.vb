<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReasonToDecline
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
        Me.grpReasons = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tickReasonOther = New System.Windows.Forms.RadioButton()
        Me.tickReason2 = New System.Windows.Forms.RadioButton()
        Me.tickReason1 = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.grpReasons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReasons
        '
        Me.grpReasons.Controls.Add(Me.Label1)
        Me.grpReasons.Controls.Add(Me.TextBox1)
        Me.grpReasons.Controls.Add(Me.tickReasonOther)
        Me.grpReasons.Controls.Add(Me.tickReason2)
        Me.grpReasons.Controls.Add(Me.tickReason1)
        Me.grpReasons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReasons.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpReasons.Location = New System.Drawing.Point(21, 22)
        Me.grpReasons.Margin = New System.Windows.Forms.Padding(4)
        Me.grpReasons.Name = "grpReasons"
        Me.grpReasons.Padding = New System.Windows.Forms.Padding(4)
        Me.grpReasons.Size = New System.Drawing.Size(543, 215)
        Me.grpReasons.TabIndex = 11
        Me.grpReasons.TabStop = False
        Me.grpReasons.Text = "Reason To Decline Request"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Specify your reason here"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 166)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(453, 24)
        Me.TextBox1.TabIndex = 22
        '
        'tickReasonOther
        '
        Me.tickReasonOther.AutoSize = True
        Me.tickReasonOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tickReasonOther.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tickReasonOther.Location = New System.Drawing.Point(35, 103)
        Me.tickReasonOther.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tickReasonOther.Name = "tickReasonOther"
        Me.tickReasonOther.Size = New System.Drawing.Size(72, 24)
        Me.tickReasonOther.TabIndex = 21
        Me.tickReasonOther.Text = "Other"
        Me.tickReasonOther.UseVisualStyleBackColor = True
        '
        'tickReason2
        '
        Me.tickReason2.AutoSize = True
        Me.tickReason2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tickReason2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tickReason2.Location = New System.Drawing.Point(35, 71)
        Me.tickReason2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tickReason2.Name = "tickReason2"
        Me.tickReason2.Size = New System.Drawing.Size(408, 24)
        Me.tickReason2.TabIndex = 19
        Me.tickReason2.Text = "There is having technical issue with the Equipment"
        Me.tickReason2.UseVisualStyleBackColor = True
        '
        'tickReason1
        '
        Me.tickReason1.AutoSize = True
        Me.tickReason1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tickReason1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tickReason1.Location = New System.Drawing.Point(35, 37)
        Me.tickReason1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tickReason1.Name = "tickReason1"
        Me.tickReason1.Size = New System.Drawing.Size(282, 24)
        Me.tickReason1.TabIndex = 18
        Me.tickReason1.Text = "Facility is temporarily unavailable "
        Me.tickReason1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SeaShell
        Me.btnCancel.Location = New System.Drawing.Point(155, 245)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 38)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDecline
        '
        Me.btnDecline.BackColor = System.Drawing.Color.Tomato
        Me.btnDecline.FlatAppearance.BorderSize = 0
        Me.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecline.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecline.ForeColor = System.Drawing.Color.SeaShell
        Me.btnDecline.Location = New System.Drawing.Point(316, 245)
        Me.btnDecline.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(104, 38)
        Me.btnDecline.TabIndex = 30
        Me.btnDecline.Text = "Decline" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDecline.UseVisualStyleBackColor = False
        '
        'ReasonToDecline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(587, 310)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.grpReasons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReasonToDecline"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EquiAssist"
        Me.grpReasons.ResumeLayout(False)
        Me.grpReasons.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpReasons As System.Windows.Forms.GroupBox
    Friend WithEvents tickReason2 As System.Windows.Forms.RadioButton
    Friend WithEvents tickReason1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tickReasonOther As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDecline As System.Windows.Forms.Button

End Class
