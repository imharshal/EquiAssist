'************************************************************************************
'                                HOSPITAL DASHBOARD FORM
'*************************************************************************************
Imports MySql.Data.MySqlClient
Imports EquiAssist.myModule
Imports EquiAssist.Login
Imports System.Net

Public Class HospitalDashboard
    Dim logout As Boolean
    Private Sub Home()
        pnlHome.Visible = True
        pnlDoctor.Visible = False
        pnlGridview.Visible = False
        pnlPatient.Visible = False
        pnlUpdate.Visible = False
    End Sub
    '
    '###### Form Closing ######
    Private Sub HospitalDashboard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        stopServer() 'Closing The Server
        Login.Show()
        If Not logout Then
            MsgBox("You Are Logged Out Unexpectedly!")
        End If
        txtNotification.Clear()
        'Connect()
        'cmd = New MySqlCommand("UPDATE Login SET IP=NULL WHERE id='" + uID + "'", cn)
        'cmd.ExecuteNonQuery()
    End Sub
    '
    '###### Form Load ######
    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home()
        connection()
        Connect()
        loggedID = uID
        startServer(Timer1) 'Starting The Server
        cmd = New MySqlCommand("SELECT * FROM Hospital WHERE h_id='" + loggedID + "'", cn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        Try
            If dr.HasRows Then
                If dr.Read Then
                    lblCode.Text = dr.Item(0)
                    lblName.Text = dr.Item(1)
                    lblContact1.Text = dr.Item(5)
                    lblContact2.Text = dr.Item(6)
                    dr.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    '
    '###### Receiving Notification From Client ######
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
        pnlUpdate.Visible = True
        pnlDoctor.Visible = False
        pnlGridview.Visible = False
        pnlPatient.Visible = False
        pnlHome.Visible = False
        'filing data to table
        querydisplay = "SELECT Facility,Availability FROM HFacilities WHERE h_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewUpdate)
        'Loading Facilities to Combobox
        Connect()
        queryfacility = "SELECT items FROM Facilityitems"
        loadFacilites(queryfacility, cbHospFacility)
    End Sub
    '
    Private Sub gridviewUpdate_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridviewUpdate.RowHeaderMouseClick
        Dim index = gridviewUpdate.CurrentRow.Index
        Dim SelFacility = gridviewUpdate.Item(0, index).Value
        cbHospFacility.SelectedItem = SelFacility
    End Sub
    '
    '###### Button Update Facility ######
    Private Sub btnFacilityUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacilityUpdate.Click
        Connect()
        Dim count As String = countHospFacility.Value.ToString
        cmd.CommandText = "UPDATE HFacilities SET Availability = '" + count + "' WHERE Facility='" + cbHospFacility.SelectedItem + "'"
        cmd.ExecuteNonQuery()
        disp_data(querydisplay, gridviewUpdate)

        MsgBox("Records Updated")
    End Sub
    '
    '####### Button Delete Facility #######
    Private Sub btnFacilityDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacilityDelete.Click
        Connect()
        cmd.CommandText = "DELETE FROM HFacilities WHERE Facility='" + cbHospFacility.SelectedItem + "'"
        cmd.ExecuteNonQuery()
        disp_data(querydisplay, gridviewUpdate)

        MsgBox("Records Deleted")
    End Sub
    '
    '####### Updating the Data in gridview after adding new facility ######
    Private Sub linkNewFacility_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles linkNewFacility.Invalidated
        Connect()
        querydisplay = "SELECT Facility,Availability FROM HFacilities WHERE h_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewUpdate)
    End Sub
    '###### Link New Facility ######
    Private Sub linkNewFacility_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNewFacility.LinkClicked
        Connect()
        dialog = "Hospital"
        dialogNewFacility.ShowDialog()
        disp_data(querydisplay, gridviewUpdate)
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '##########################
    '       Panel Doctor
    '##########################
    'Showing Doctor panel
    Private Sub btnDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoctor.Click
        pnlDoctor.Visible = True
        pnlGridview.Visible = False
        pnlPatient.Visible = False
        pnlHome.Visible = False
        pnlUpdate.Visible = False
        'Updating data to Doctors table
    End Sub
    'validating numbers
    Private Sub txtDoctorExperience_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDoctorExperience.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    'Validating numbers
    Private Sub txtDoctorAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDoctorAge.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    'validating numbers
    Private Sub txtDoctorContact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDoctorContact1.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    'Checking if 10 digit no. is entered
    Private Sub txtDoctorContact1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDoctorContact1.Leave
        If pnlDoctor.Enabled And txtDoctorContact1.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    'Validating numbers
    Private Sub txtDoctorContact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDoctorContact2.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    'Checking if 10 digit no. is entered
    Private Sub txtDoctorContact2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDoctorContact2.Leave
        If pnlDoctor.Enabled And txtDoctorContact2.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    '###### Save Button ######
    Private Sub btnDoctorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoctorSave.Click
        If Not IsEmpty(grpboxDoctor) Then
            cmd = New MySqlCommand("SELECT COUNT(d_id) FROM BDonor WHERE d_id='" + loggedID + "'", cn)
            Dim d_id As String
            d_id = loggedID + "dx" + GenerateID(cmd).ToString
            Dim name As String = txtDoctorFname.Text + " " + txtDoctorMname.Text + " " + txtDoctorLname.Text
            Dim address As String = txtDoctorAddress.Text
            Dim contact1 As String = txtDoctorContact1.Text
            Dim contact2 As String = txtDoctorContact2.Text
            Dim sex As String = cbDoctorSex.SelectedItem
            Dim age As String = txtDoctorAge.Text
            Dim qualification As String = cbDoctorQualification.SelectedItem
            Dim speciality As String = txtDoctorSpeciality.Text
            Dim experience As String = txtDoctorExperience.Text
            cmd.CommandText = "INSERT INTO HDoctors VALUES('" + loggedID + "','" + d_id + "'," _
                & " '" + name + "','" + address + "','" + contact1 + "','" + contact2 + "', " _
                & " '" + sex + "','" + age + "','" + qualification + "','" + speciality + "','" + experience + "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully!")
            clearALL(grpboxDoctor)
        Else : MsgBox("Please Fill All the Required Fields")
        End If
    End Sub
    '###### Cancel Button ######
    Private Sub btnDoctorCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoctorCancel.Click
        Home()
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '#############################
    '        Panel Patient 
    '#############################
    'Showing patient panel
    Private Sub btnPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatient.Click
        pnlDoctor.Visible = False
        pnlGridview.Visible = False
        pnlPatient.Visible = True
        pnlHome.Visible = False
        pnlUpdate.Visible = False
    End Sub
    'validating numbers
    Private Sub txtPatientAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientAge.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    ' validating numbers
    Private Sub txtPatientContact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientContact1.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    'Checking if 10 digit no. is entered
    Private Sub txtPatientContact1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientContact1.Leave
        If pnlPatient.Enabled And txtPatientContact1.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    'Checking if 10 digit no. is entered
    Private Sub txtPatientContact2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatientContact2.Leave
        If pnlPatient.Enabled And txtPatientContact2.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    'validating numbers
    Private Sub txtPatientContact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientContact2.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    '
    '###### Save Patient Details #######
    Private Sub btnPatientSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatientSave.Click

        If Not IsEmpty(grpPatient) Then
            cmd = New MySqlCommand("SELECT COUNT(p_id) FROM HPatients WHERE h_id='" + loggedID + "'", cn)
            Dim p_id As String
            p_id = loggedID + "p" + GenerateID(cmd).ToString
            Dim name As String = txtPatientFname.Text + " " + txtPatientMname.Text + " " + txtPatientLname.Text
            Dim address As String = txtPatientAddress.Text
            Dim contact1 As String = txtPatientContact1.Text
            Dim contact2 As String = txtPatientContact2.Text
            Dim sex As String = cbPatientSex.SelectedItem
            Dim age As String = txtPatientAge.Text
            Dim Bgroup As String = cbPatientBgroup.SelectedItem
            Dim disease As String = txtPatientDisease.Text
            Dim remarks As String = txtPatientRemark.Text

            Dim dt As String = DateTimePicker1.Text
            DOA = Convert.ToDateTime(dt.ToString)
            '**************** Inserting Data to database
            cmd.CommandText = "INSERT INTO HPatients VALUES('" + loggedID + "','" + p_id + "','" + name + "'," _
                & "'" + address + "','" + contact1 + "','" + contact2 + "','" + sex + "','" + age + "'," _
                & "'" + Bgroup + "','" + disease + "','" + remarks + "','" + DOA + "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully!")
            clearALL(grpPatient)
        Else : MsgBox("Please Fill All the Required Fields")
        End If
    End Sub
    'Button Cancel
    Private Sub btnPatientCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatientCancel.Click
        Home()
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '#############################
    '       Panel GridView 
    '#############################
    'Showing patient panel
    Private Sub btnGridview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridview.Click
        pnlDoctor.Visible = False
        pnlGridview.Visible = True
        pnlPatient.Visible = False
        pnlHome.Visible = False
        pnlUpdate.Visible = False
        querydisplay = "SELECT * FROM HPatients WHERE h_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewPatient)
        querydisplay = "SELECT * FROM HDoctors WHERE h_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewDoctor)
    End Sub
    '##### Cancel Button ######
    Private Sub btnGridPatientCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridPatientCancel.Click
        Home()
    End Sub
    '###### Update Button For Patient Data
    Private Sub btnGridPatientUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridPatientUpdate.Click
        Dim ind = gridviewPatient.CurrentRow.Index
        Dim Selection = gridviewPatient.Item(1, ind).Value
        'Reading Edited Data
        Dim Name As String = gridviewPatient.Item(2, ind).Value
        Dim Address = gridviewPatient.Item(3, ind).Value
        Dim Age = gridviewPatient.Item(7, ind).Value
        Dim Contact1 = gridviewPatient.Item(4, ind).Value
        Dim Contact2 = gridviewPatient.Item(5, ind).Value
        cmd = New MySqlCommand("Update HPatients SET Name='" + Name + "', Address='" + Address + "', " _
                             & " Contact1='" + Contact1 + "',Contact2='" + Contact2 + "', Age='" + Age + "' " _
                             & "WHERE h_id='" + loggedID + "' AND p_id='" + Selection + "'", cn)
        cmd.ExecuteNonQuery()
        querydisplay = "SELECT * FROM HPatients WHERE h_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewPatient)
    End Sub
    '###### Cancel Button ######
    Private Sub btnGridDoctorCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridDoctorCancel.Click
        Home()
    End Sub
    '###### Delete Button For Doctor Data ######
    Private Sub btnGridDoctorDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridDoctorDelete.Click
        Dim ind = gridviewDoctor.CurrentRow.Index
        Dim Selection = gridviewDoctor.Item(1, ind).Value
        cmd = New MySqlCommand("DELETE FROM HDoctors WHERE d_id='" + Selection + "' AND h_id ='" + loggedID + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Selected Record Deleted")
        disp_data(querydisplay, gridviewDoctor)
    End Sub
    '###### Update Button For Doctor Data ######
    Private Sub btnGridDoctorUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridDoctorUpdate.Click
        Dim ind = gridviewDoctor.CurrentRow.Index
        Dim Selection = gridviewDoctor.Item(1, ind).Value
        'Reading Edited Data
        Dim Name As String = gridviewDoctor.Item(2, ind).Value
        Dim Address = gridviewDoctor.Item(3, ind).Value
        Dim Contact1 = gridviewDoctor.Item(4, ind).Value
        Dim Contact2 = gridviewDoctor.Item(5, ind).Value
        Dim Age = gridviewDoctor.Item(7, ind).Value
        Dim Qualification = gridviewDoctor.Item(8, ind).Value
        Dim Speciality = gridviewDoctor.Item(9, ind).Value
        Dim Experience = gridviewDoctor.Item(10, ind).Value
        cmd = New MySqlCommand("Update HDoctors SET Name='" + Name + "', Address='" + Address + "', " _
                & "Contact1='" + Contact1 + "', Contact2='" + Contact2 + "',Age='" + Age + "', " _
                & "Qualification='" + Qualification + "',Speciality='" + Speciality + "'," _
                & "Experience='" + Experience + "' WHERE h_id='" + loggedID + "' AND d_id='" + Selection + "'", cn)
        cmd.ExecuteNonQuery()
        querydisplay = "SELECT * FROM HDoctors WHERE h_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewDoctor)
    End Sub
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    '#############################
    '            LOGOUT
    '#############################
    Public Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        'Server.IsListening = False
        logout = True
        loggedID = Nothing
        Me.Close()
        Login.Show()
        MsgBox("You are logged out successfully")
        stopServer()
    End Sub
    '###### Request Button ######
    Private Sub btnRequestAssistance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequestAssistance.Click
        ReqAssistanceDialog.ShowDialog()
    End Sub
    '####### Assist Button ######
    Private Sub btnAssist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssist.Click
        AssistDialogue.ShowDialog()
    End Sub
End Class