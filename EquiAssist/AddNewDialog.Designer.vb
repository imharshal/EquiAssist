<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogNewFacility
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
        Me.grpHospAvailability = New System.Windows.Forms.GroupBox()
        Me.countHospFacility = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbHospFacility = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btdAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlHospFacility = New System.Windows.Forms.Panel()
        Me.pnlBloodAvailability = New System.Windows.Forms.Panel()
        Me.btnBCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Groups = New System.Windows.Forms.GroupBox()
        Me.cbBloodGroup = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.countBloodQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBAdd = New System.Windows.Forms.Button()
        Me.grpHospAvailability.SuspendLayout()
        CType(Me.countHospFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHospFacility.SuspendLayout()
        Me.pnlBloodAvailability.SuspendLayout()
        Me.Groups.SuspendLayout()
        CType(Me.countBloodQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpHospAvailability
        '
        Me.grpHospAvailability.BackColor = System.Drawing.Color.Transparent
        Me.grpHospAvailability.Controls.Add(Me.countHospFacility)
        Me.grpHospAvailability.Controls.Add(Me.Label5)
        Me.grpHospAvailability.Controls.Add(Me.cbHospFacility)
        Me.grpHospAvailability.Controls.Add(Me.Label4)
        Me.grpHospAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHospAvailability.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpHospAvailability.Location = New System.Drawing.Point(5, 15)
        Me.grpHospAvailability.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpHospAvailability.Name = "grpHospAvailability"
        Me.grpHospAvailability.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpHospAvailability.Size = New System.Drawing.Size(389, 117)
        Me.grpHospAvailability.TabIndex = 9
        Me.grpHospAvailability.TabStop = False
        Me.grpHospAvailability.Text = "Facilities"
        '
        'countHospFacility
        '
        Me.countHospFacility.Location = New System.Drawing.Point(169, 80)
        Me.countHospFacility.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.countHospFacility.Name = "countHospFacility"
        Me.countHospFacility.Size = New System.Drawing.Size(160, 24)
        Me.countHospFacility.TabIndex = 3
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
        'cbHospFacility
        '
        Me.cbHospFacility.FormattingEnabled = True
        Me.cbHospFacility.Items.AddRange(New Object() {"MRI", "BED", "BLOOD"})
        Me.cbHospFacility.Location = New System.Drawing.Point(169, 32)
        Me.cbHospFacility.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbHospFacility.Name = "cbHospFacility"
        Me.cbHospFacility.Size = New System.Drawing.Size(160, 26)
        Me.cbHospFacility.TabIndex = 1
        Me.cbHospFacility.Text = "-Select-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Facility*"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(3, 135)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(303, 15)
        Me.Label31.TabIndex = 41
        Me.Label31.Text = "*To Add Multiple Facility Entries, Add One After Another"
        '
        'btdAdd
        '
        Me.btdAdd.BackColor = System.Drawing.Color.DarkGray
        Me.btdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdAdd.ForeColor = System.Drawing.Color.Black
        Me.btdAdd.Location = New System.Drawing.Point(200, 164)
        Me.btdAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btdAdd.Name = "btdAdd"
        Me.btdAdd.Size = New System.Drawing.Size(116, 38)
        Me.btdAdd.TabIndex = 14
        Me.btdAdd.Text = "Add"
        Me.btdAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(76, 164)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 38)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pnlHospFacility
        '
        Me.pnlHospFacility.Controls.Add(Me.btnCancel)
        Me.pnlHospFacility.Controls.Add(Me.Label31)
        Me.pnlHospFacility.Controls.Add(Me.grpHospAvailability)
        Me.pnlHospFacility.Controls.Add(Me.btdAdd)
        Me.pnlHospFacility.Location = New System.Drawing.Point(0, 1)
        Me.pnlHospFacility.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHospFacility.Name = "pnlHospFacility"
        Me.pnlHospFacility.Size = New System.Drawing.Size(403, 208)
        Me.pnlHospFacility.TabIndex = 43
        '
        'pnlBloodAvailability
        '
        Me.pnlBloodAvailability.Controls.Add(Me.btnBCancel)
        Me.pnlBloodAvailability.Controls.Add(Me.Label1)
        Me.pnlBloodAvailability.Controls.Add(Me.Groups)
        Me.pnlBloodAvailability.Controls.Add(Me.btnBAdd)
        Me.pnlBloodAvailability.Location = New System.Drawing.Point(0, 1)
        Me.pnlBloodAvailability.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlBloodAvailability.Name = "pnlBloodAvailability"
        Me.pnlBloodAvailability.Size = New System.Drawing.Size(403, 208)
        Me.pnlBloodAvailability.TabIndex = 44
        '
        'btnBCancel
        '
        Me.btnBCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnBCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBCancel.ForeColor = System.Drawing.Color.Black
        Me.btnBCancel.Location = New System.Drawing.Point(76, 164)
        Me.btnBCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBCancel.Name = "btnBCancel"
        Me.btnBCancel.Size = New System.Drawing.Size(116, 38)
        Me.btnBCancel.TabIndex = 42
        Me.btnBCancel.Text = "Cancel"
        Me.btnBCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(3, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 15)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "*To Add Multiple Facility Entries, Add One After Another"
        '
        'Groups
        '
        Me.Groups.BackColor = System.Drawing.Color.Transparent
        Me.Groups.Controls.Add(Me.cbBloodGroup)
        Me.Groups.Controls.Add(Me.Label19)
        Me.Groups.Controls.Add(Me.countBloodQuantity)
        Me.Groups.Controls.Add(Me.Label2)
        Me.Groups.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Groups.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Groups.Location = New System.Drawing.Point(5, 15)
        Me.Groups.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Groups.Name = "Groups"
        Me.Groups.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Groups.Size = New System.Drawing.Size(389, 117)
        Me.Groups.TabIndex = 9
        Me.Groups.TabStop = False
        Me.Groups.Text = "Availlability"
        '
        'cbBloodGroup
        '
        Me.cbBloodGroup.FormattingEnabled = True
        Me.cbBloodGroup.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"})
        Me.cbBloodGroup.Location = New System.Drawing.Point(168, 33)
        Me.cbBloodGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbBloodGroup.Name = "cbBloodGroup"
        Me.cbBloodGroup.Size = New System.Drawing.Size(160, 26)
        Me.cbBloodGroup.TabIndex = 49
        Me.cbBloodGroup.Text = "-Select-"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(40, 37)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 20)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Blood Group"
        '
        'countBloodQuantity
        '
        Me.countBloodQuantity.Location = New System.Drawing.Point(169, 80)
        Me.countBloodQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.countBloodQuantity.Name = "countBloodQuantity"
        Me.countBloodQuantity.Size = New System.Drawing.Size(160, 24)
        Me.countBloodQuantity.TabIndex = 3
        Me.countBloodQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Availability*"
        '
        'btnBAdd
        '
        Me.btnBAdd.BackColor = System.Drawing.Color.DarkGray
        Me.btnBAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBAdd.ForeColor = System.Drawing.Color.Black
        Me.btnBAdd.Location = New System.Drawing.Point(200, 164)
        Me.btnBAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBAdd.Name = "btnBAdd"
        Me.btnBAdd.Size = New System.Drawing.Size(116, 38)
        Me.btnBAdd.TabIndex = 14
        Me.btnBAdd.Text = "Add"
        Me.btnBAdd.UseVisualStyleBackColor = False
        '
        'dialogNewFacility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(399, 207)
        Me.Controls.Add(Me.pnlHospFacility)
        Me.Controls.Add(Me.pnlBloodAvailability)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialogNewFacility"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Facility"
        Me.grpHospAvailability.ResumeLayout(False)
        Me.grpHospAvailability.PerformLayout()
        CType(Me.countHospFacility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHospFacility.ResumeLayout(False)
        Me.pnlHospFacility.PerformLayout()
        Me.pnlBloodAvailability.ResumeLayout(False)
        Me.pnlBloodAvailability.PerformLayout()
        Me.Groups.ResumeLayout(False)
        Me.Groups.PerformLayout()
        CType(Me.countBloodQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpHospAvailability As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btdAdd As System.Windows.Forms.Button
    Friend WithEvents countHospFacility As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbHospFacility As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlHospFacility As System.Windows.Forms.Panel
    Friend WithEvents pnlBloodAvailability As System.Windows.Forms.Panel
    Friend WithEvents btnBCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Groups As System.Windows.Forms.GroupBox
    Friend WithEvents countBloodQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBAdd As System.Windows.Forms.Button
    Friend WithEvents cbBloodGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label

End Class
