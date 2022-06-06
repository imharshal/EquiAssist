'************************************************************************************
'                                BLOOD BANK DASHBOARD FORM
'*************************************************************************************
Imports MySql.Data.MySqlClient
Imports System.Net
Imports EquiAssist.Module1
Public Class BloodBankDashboard
    Dim d_id As String
    Dim logout As Boolean
    '###### Function to Display Home Panel ######
    Private Sub Home()
        pnlHome.Visible = True
        pnlNewDonor.Visible = False
        pnlDonorData.Visible = False
        pnlUpdate.Visible = False
    End Sub
    '###### Form Closing ######
    Private Sub BloodBankDashboard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        stopServer()
        Login.Show()
        If Not logout = True Then MsgBox("You Are Unexpectedly Logged Out!")
        txtNotification.Clear()
    End Sub
    '###### Form Load ######
    Private Sub BlodBankDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home()
        connection()
        Connect()
        loggedID = uID
        startServer(Timer1) 'Starting server
        cmd = New MySqlCommand("SELECT b_id, Name, Contact1, Contact2 FROM BloodBank WHERE b_id='" + loggedID + "'", cn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        Try
            If dr.HasRows Then
                If dr.Read Then
                    lblCode.Text = dr.Item("b_id")
                    lblName.Text = dr.Item("Name")
                    lblContact1.Text = dr.Item("Contact1")
                    lblContact2.Text = dr.Item("Contact2")
                    dr.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Reading Message from Client
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        readMessage(txtNotification, NotifyIconRequirement)
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '############################
    '        Panel Home
    '############################
    'Showing Home panel
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home()
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '############################
    '        Panel Update
    '############################
    'Showing Update panel
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        pnlHome.Visible = False
        pnlNewDonor.Visible = False
        pnlDonorData.Visible = False
        pnlUpdate.Visible = True
        querydisplay = "SELECT B_Group,Availability FROM BStock WHERE b_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewUpdate)
    End Sub
    '###### Update Stock Button ######
    Private Sub btnBloodUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloodUpdate.Click
        Dim count As String = countBloodStock.Value.ToString
        cmd.CommandText = "UPDATE BStock SET Availability = '" + count + "' WHERE B_Group='" + cbBloodGroup.SelectedItem + "'"
        cmd.ExecuteNonQuery()
        disp_data(querydisplay, gridviewUpdate)
        MsgBox("Records Updated")
        clearALL(grpUpdateStock)
    End Sub
    '###### Delete Stock Button ######
    Private Sub btnBloodDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloodDelete.Click
        cmd.CommandText = "DELETE FROM BStock WHERE B_Group='" + cbBloodGroup.SelectedItem + "'"
        cmd.ExecuteNonQuery()
        disp_data(querydisplay, gridviewUpdate)
        MsgBox("Records Deleted")
        clearALL(grpUpdateStock)
    End Sub
    '###### Updating the Data in gridview after adding new Blood Stock ######
    Private Sub linkNewFacility_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles linkNewFacility.Invalidated
        querydisplay = "SELECT B_Group,Availability FROM BStock WHERE b_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewUpdate)
    End Sub
    '###### Link New BloodGroup ######
    Private Sub linkNewFacility_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNewFacility.LinkClicked
        dialog = "BloodBank"
        dialogNewFacility.Show()
        disp_data(querydisplay, gridviewUpdate)
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '############################
    '        Panel New Donor
    '############################
    'Showing New Donor panel
    Private Sub btnNewDonor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDonor.Click
        pnlHome.Visible = False
        pnlNewDonor.Visible = True
        pnlDonorData.Visible = False
        pnlUpdate.Visible = False
    End Sub
    'Validating contact1 textbox
    Private Sub txtDonorContact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDonorContact1.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    Private Sub txtDonorContact1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDonorContact1.Leave
        If pnlNewDonor.Enabled And txtDonorContact1.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    'Validating contact2 textbox
    Private Sub txtDonorContact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDonorContact2.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    Private Sub txtDonorContact2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDonorContact2.Leave
        If pnlNewDonor.Enabled And txtDonorContact2.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    Private Sub txtDonorAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDonorAge.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    '###### Button Save ######
    Private Sub btnNewDonorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDonorSave.Click
        If allSet = True Then
            cmd = New MySqlCommand("SELECT COUNT(d_id) FROM BDonor WHERE b_id='" + loggedID + "'", cn)
            d_id = loggedID + "d" + GenerateID(cmd).ToString
            Dim name As String = txtDonorFname.Text + " " + txtDonorMname.Text + " " + txtDonorLname.Text
            Dim address As String = txtDonorAddress.Text
            Dim contact1 As String = txtDonorContact1.Text
            Dim contact2 As String = txtDonorContact2.Text
            Dim sex As String = cbDonorSex.SelectedItem
            Dim age As String = txtDonorAge.Text
            Dim Bgroup As String = cbDonorBgroup.SelectedItem
            Dim disease As String = txtDonorDisease.Text
            Dim remarks As String = txtDonorRemark.Text
            Dim dt As String = DateTimePicker1.Text
            Dim DateOfDonation = Convert.ToDateTime(dt.ToString)
            '**************** Inserting Data to Database **************
            cmd.CommandText = "INSERT INTO BDonor VALUES('" + loggedID + "','" + d_id + "','" + name + "','" + address + "','" + contact1 + "','" + contact2 + "','" + sex + "','" + age + "','" + Bgroup + "','" + disease + "','" + remarks + "','" + DateOfDonation + "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully!")
            clearALL(grpDonorDetails)
        Else : MsgBox("Please Fill All the Required Fields")
        End If
    End Sub
    '###### Button Cancel ######
    Private Sub btnNewDonorCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDonorCancel.Click
        Home()
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '############################
    '        Panel Donor Data
    '############################
    'Showing Donor Data panel
    Private Sub btnDonorData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDonorData.Click
        pnlHome.Visible = False
        pnlNewDonor.Visible = False
        pnlDonorData.Visible = True
        pnlUpdate.Visible = False
        'filing data to table
        querydisplay = "SELECT * FROM BDonor WHERE b_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewDonorDetails)
    End Sub
    '###### Reading Data From Selected Row ######
    Private Sub gridviewUpdate_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridviewUpdate.RowHeaderMouseClick
        Dim index = gridviewUpdate.CurrentRow.Index
        Dim SelFacility = gridviewUpdate.Item(0, index).Value
        cbBloodGroup.SelectedItem = SelFacility
    End Sub
    '###### Donor Data Update Button ######
    Private Sub btnGridDonorUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridDonorUpdate.Click
        Dim ind = gridviewDonorDetails.CurrentRow.Index
        Dim Selection = gridviewDonorDetails.Item(1, ind).Value
        'Reading Edited Data
        Dim Name As String = gridviewDonorDetails.Item(1, ind).Value
        Dim Address As String = gridviewDonorDetails.Item(5, ind).Value
        Dim Age = gridviewDonorDetails.Item(2, ind).Value
        Dim Contact1 = gridviewDonorDetails.Item(6, ind).Value
        Dim Contact2 = gridviewDonorDetails.Item(7, ind).Value
        cmd = New MySqlCommand("Update BDonor SET Name='" + Name + "', Address='" + Address + "',Contact1='" + Contact1 + "'," _
                             & "Contact2='" + Contact2 + "', Age='" + Age + "' WHERE b_id='" + loggedID + "' AND d_id='" + Selection + "'", cn)
        cmd.ExecuteNonQuery()
        querydisplay = "SELECT * FROM BDonor WHERE b_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewDonorDetails)
    End Sub
    '###### Button Search Donor ######
    Private Sub btnDonorSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDonorSearch.Click
        Dim search As String = cbSearchDonorBgroup.SelectedItem
        querydisplay = "SELECT d_id, Name, BloodGroup, Contact1, Contact2, Address FROM BDonor WHERE BloodGroup='" + search + "' AND b_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewSearchDonor)
    End Sub
    '###### Button Data Cancel ######
    Private Sub btnGridDonorCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridDonorCancel.Click
        Home()
    End Sub
    '###### Button Search Cancel ######
    Private Sub btnDonorSearchCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDonorSearchCancel.Click
        Home()
    End Sub
    '####### LOGOUT Button ######
    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Close()
        Login.Show()
        MsgBox("You are logged out successfully")
        logout = True
    End Sub
    '###### Assist Button ######
    Private Sub btnAssist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssist.Click
        AssistDialogue.ShowDialog()
    End Sub
End Class