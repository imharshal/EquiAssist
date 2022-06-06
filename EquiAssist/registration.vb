'************************************************************************************
'                                REGISTRATION FORM
'*************************************************************************************
Imports MySql.Data.MySqlClient
Public Class registration
    Dim submit As Boolean = False

    Private Sub registration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearALL(grpHospAvailability)
        clearALL(grpHospDetail)
        clearALL(grpBloodDetails)
        clearALL(grpBloodAvailability)
    End Sub
    '
    '###### Form Load ######
    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
    End Sub
    '######################    Tab Hospital    ############################
    '
    'Hospital tab Enter event
    Private Sub tabHospital_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabHospital.Enter
        tabHospital.Enabled = True
        tabBlood.Enabled = False
        txtHospName.Focus()
        ''''''''''''''''''''''''''''''''
        '###### ComboBox State ######
        'Loading states in combobox
        Connect()
        cmd = New MySqlCommand("Select DISTINCT city_state from cities order by city_state", cn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            cbHospState.Items.Add(dr.GetString(0))
        Loop
        cn.Close()
        ''''''''''''''''''''''''''''''''
    End Sub
    '
    '###### ComboBox Cities ######
    'Change Cities according to states
    Private Sub cbHospState_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbHospState.SelectedValueChanged
        Dim index As String
        index = cbHospState.SelectedItem
        Connect()
        cmd = New MySqlCommand("SELECT city_name FROM cities WHERE city_state='" + index + "' ORDER BY city_name", cn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        cbHospCity.Items.Clear()
        Do While dr.Read = True
            cbHospCity.Items.Add(dr.GetString(0))
        Loop
    End Sub
    'Number validation
    Private Sub txtHospContact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHospContact1.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    ''Checking if 10 digit no. is entered
    Private Sub txtHospContact1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHospContact1.Leave
        If tabHospital.Enabled And txtHospContact1.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    'Numbver Validation
    Private Sub txtHospContact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHospContact2.KeyPress
         e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    ''Checking if 10 digit no. is entered
    Private Sub txtHospContact2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHospContact2.Leave
        If tabHospital.Enabled And txtHospContact2.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    '
    '###### Cancel Button ######
    'After Registration Form's Cancel button pressed Login Form will be Enabled
    Private Sub btnHospCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHospCancel.Click
        Me.Close()
    End Sub
    '
    '###### Submit Button ######
    Public Sub btnHospSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHospSubmit.Click
        If checkHosp.Checked Then
            If Not IsEmpty(grpHospDetail) Then
                If submit = True Then
                    'Connecting to Database
                    Connect()
                    'Group Hospital Details
                    Dim hname As String = txtHospName.Text
                    Dim address As String = txtHospAddress.Text
                    Dim state As String = cbHospState.SelectedItem
                    Dim city As String = cbHospCity.SelectedItem
                    Dim contact1 As String = txtHospContact1.Text
                    Dim contact2 As String = txtHospContact2.Text
                    uID = h_id
                    '************* Inserting Hospital Details to Database **********
                    cmd.CommandText = "INSERT INTO Hospital VALUES ('" + h_id + "','" + hname + "','" + address + "','" + state + "','" + city + "','" + contact1 + "','" + contact2 + "')"
                    cmd.ExecuteNonQuery()

                    'Calling to create login details
                    CreateLogin.ShowDialog()
                Else
                    MsgBox("You Must Add Atleast One Group Entry")
                End If
            Else : MsgBox("Please Fill All the Required Fields")
            End If
        Else
            MsgBox("You Must Be Agree The Terms And Conditions To CONTINUE")
        End If

    End Sub
    '
    '###### Facility Add Button ######
    Public Sub btdhospadd_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdHospAdd.Click
        Connect()
        Dim facility As String = cbHospFacility.SelectedItem
        Dim count As String = countHospFacility.Value
        'Getting unique ID for Hospital
        cmd = New MySqlCommand("SELECT COUNT(h_id) FROM Hospital", cn)
        h_id = "hx" + GenerateID(cmd).ToString

        ''************* Inserting Hospital Facilities to Database **********
        'cmd.CommandText = "IF EXISTS (SELECT Facility,Availability FROM HFacilities WHERE h_id='" + h_id + "' AND Facility='" + facility + "')" _
        '& "BEGIN UPDATE HFacilities SET Availability='" + count + "' WHERE Facility = '" + facility + "'END" _
        '& " ELSE BEGIN INSERT INTO HFacilities VALUES ('" + h_id + "','" + facility + "','" + count + "') END"
        'cmd.ExecuteNonQuery()


        cmd.CommandText = "INSERT INTO HFacilities VALUES ('" + h_id + "','" + facility + "','" + count + "')" _
            & "ON DUPLICATE KEY UPDATE Availability='" + count + "' "
        cmd.ExecuteNonQuery()
        '###### Hospital Facilities DataGridView #####
        querydisplay = "SELECT Facility,Availability FROM HFacilities WHERE h_id='" + h_id + "'"
        disp_data(querydisplay, gridviewHosp)
        'Reset facilities
        clearALL(grpHospAvailability)
        submit = True
    End Sub
    '
    '#######################    Tab Blood Bank    ###############################
    '
    '###### Blood Bank Tab ######
    'Hospital tab Enter event
    Private Sub tabBlood_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabBlood.Enter
        tabBlood.Enabled = True
        tabHospital.Enabled = False
        '''''''''''''''''''''''''''''''''''''
        '##### ComboBox State ######
        'Loading states in combobox
        Connect()
        cmd = New MySqlCommand("SELECT DISTINCT city_state FROM cities ORDER BY city_state", cn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        Do While dr.Read = True
            cbBloodState.Items.Add(dr.GetString(0))
        Loop
        cn.Close()
        ''''''''''''''''''''''''''''''''''''
    End Sub
    '
    '###### ComboBox Cities ######
    'Change Cities according to states
    Private Sub cbBloodState_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBloodState.SelectedValueChanged
        Dim index As String
        index = cbBloodState.SelectedItem
        Connect()
        cmd = New MySqlCommand("SELECT city_name FROM cities WHERE city_state='" + index + "' ORDER BY city_name", cn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        cbBloodCity.Items.Clear()
        Do While dr.Read = True
            cbBloodCity.Items.Add(dr.GetString(0))
        Loop
    End Sub
    'Number Validation
    Private Sub txtBloodContact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBloodContact1.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    'Checking if 10 digit no. is entered
    Private Sub txtBloodContact1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBloodContact1.Leave
        If tabBlood.Enabled And txtBloodContact1.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    'Number Validation
    Private Sub txtBloodContact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBloodContact2.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub
    'Checking if 10 digit no. is entered
    Private Sub txtBloodContact2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBloodContact2.Leave
        If tabBlood.Enabled And txtBloodContact2.TextLength < 10 Then
            MsgBox("Contact No. must be 10 digit long")
        End If
    End Sub
    '
    '###### Cancel Button ######
    Private Sub btnBloodCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloodCancel.Click
        Me.Close()
    End Sub
    '
    '###### Submit Button ######
    'Getting the unique ID for blood bank
    Private Sub btnBloodSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloodSubmit.Click
        If checkBlood.Checked Then
            If Not IsEmpty(grpBloodDetails) Then
                If submit = True Then
                    'Group Blood Bank Details
                    Dim name As String = txtBloodname.Text
                    Dim address As String = txtBloodAddress.Text
                    Dim state As String = cbBloodState.SelectedItem
                    Dim city As String = cbBloodCity.SelectedItem
                    Dim contact1 As String = txtBloodContact1.Text
                    Dim contact2 As String = txtBloodContact2.Text

                    'Getting the unique ID for blood bank
                    cmd = New MySqlCommand("SELECT COUNT(b_id) FROM BloodBank", cn)
                    b_id = "bx" + GenerateID(cmd).ToString
                    uID = b_id

                    '************* Inserting Blood Bank Details to Database **********
                    cmd.CommandText = "INSERT INTO BloodBank VALUES ('" + b_id + "','" + name + "','" + address + "','" + state + "','" + city + "','" + contact1 + "','" + contact2 + "')"
                    cmd.ExecuteNonQuery()
                    clearALL(grpBloodAvailability)
                    clearALL(grpBloodDetails)
                    'Calling to create login details
                    CreateLogin.ShowDialog()
                Else
                    MsgBox("You Must Add Atleast One Group Entry")
                End If
            Else
                MsgBox("Please Fill All the Required Fields")
            End If
        Else
            MsgBox("You Must Be Agree The Terms And Conditions To CONTINUE")
        End If
    End Sub
    '
    '####### Blood Stock Availability #######
    'Adding Blood Availability
    Private Sub btnBloodAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloodAdd.Click
        Connect()
        Dim B_Group As String = cbBloodGroup.SelectedItem
        Dim Available As String = countBloodQuantity.Value
        'Getting unique ID for BloodBank
        cmd = New MySqlCommand("SELECT COUNT(b_id) FROM BloodBank", cn)
        b_id = "bx" + GenerateID(cmd).ToString
        MessageBox.Show(b_id)

        ''************* Inserting Blood Group Stock to Database **********
        cmd.CommandText = "IF EXISTS (SELECT B_Group,Availability FROM BStock Where b_id='" + b_id + "' AND B_Group ='" + B_Group + "') " _
            & "BEGIN UPDATE BStock SET Availability ='" + Available + "' WHERE B_Group='" + B_Group + "'END" _
            & " ELSE BEGIN INSERT INTO BStock VALUES ('" + b_id + "','" + B_Group + "','" + Available + "') END"
        cmd.ExecuteNonQuery()

        '###### Blood Stock DataGridView ######
        querydisplay = "SELECT B_Group,Availability FROM BStock Where b_id='" + b_id + "'"
        disp_data(querydisplay, gridviewBlood)
        'Reset
        clearALL(grpBloodAvailability)
        submit = True
    End Sub
    Private Sub cbHospFacility_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbHospFacility.GotFocus
        queryfacility = "SELECT items FROM Facilityitems"
        loadFacilites(queryfacility, cbHospFacility)
    End Sub
End Class