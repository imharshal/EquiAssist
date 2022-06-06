'************************************************************************************
'                                REQUEST FOR ASSISTANCE FORM
'*************************************************************************************
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ReqAssistanceDialog
    Public IP As String
    Dim SelHosp As String
    Dim Req_id As String

    Private Sub ReqAssistanceDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearALL(grpRequirement)
        clearALL(grpPatient)
    End Sub
    '
    '###### Form Load ######
    Private Sub AssistanceDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        Connect()
        clearALL(grpRequirement)
        clearALL(grpPatient)
    End Sub
    '
    '###### Select Requirement ComboBox ######
    Private Sub cbFacilityReq_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbFacilityReq.MouseClick
        checkFacility.Checked = True
        checkBGroup.Checked = False
        queryfacility = "SELECT items FROM Facilityitems"
        loadFacilites(queryfacility, cbFacilityReq)
    End Sub
    '
    '###### Showing Available Hospitals ######
    Private Sub cbFacilityReq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFacilityReq.SelectedIndexChanged
        Connect()
        querydisplay = "SELECT Hospital.h_id, Name as Hospital_Name, City, Address, Contact1, Contact2 FROM Hospital LEFT JOIN HFacilities ON HFacilities.h_id= Hospital.h_id  WHERE HFacilities.Facility='" + cbFacilityReq.SelectedItem + "'"
        disp_data(querydisplay, gridviewList)
    End Sub
    '
    '####### Showing Available Blood Bank ######
    Private Sub cbBgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBgroup.SelectedIndexChanged
        checkBGroup.Checked = True
        checkFacility.Checked = False
        querydisplay = "SELECT BloodBank.b_id, Name AS BloodBank_Name, City, Address, Contact1, Contact2 FROM BloodBank LEFT JOIN BStock ON BStock.b_id= BloodBank.b_id  WHERE B_Group='" + cbBgroup.SelectedItem + "'"
        '  querydisplay = "SELECT Hospital.h_id, Name as Hospital_Name, City, Address, Contact1, Contact2 FROM Hospital LEFT JOIN HFacilities ON HFacilities.h_id= Hospital.h_id  WHERE HFacilities.Facility='" + cbFacilityReq.SelectedItem + "'"
        disp_data(querydisplay, gridviewList)
    End Sub
    '
    '###### Select Patient ComboBox ######
    Private Sub cbPatientID_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbPatientID.MouseClick
        Connect()
        Dim dr As MySqlDataReader
        cmd = New MySqlCommand("SELECT p_id FROM HPatients Where h_id='" + loggedID + "'", cn)
        dr = cmd.ExecuteReader()
        cbPatientID.Items.Clear()
        Do While dr.Read = True
            cbPatientID.Items.Add(dr.Item("p_id"))
        Loop
        dr.Close()
    End Sub
    '
    '###### Confirming the name of Patient ######
    Private Sub cbPatientID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPatientID.SelectedIndexChanged
        Connect()
        Dim dr As String
        cmd.CommandType = CommandType.Text
        cmd = New MySqlCommand("SELECT Name FROM HPatients Where p_id='" + cbPatientID.SelectedItem + "'", cn)
        dr = cmd.ExecuteScalar
        txtPatientName.Clear()
        txtPatientName.Text = dr

    End Sub
    '
    '###### REQUEST BUTTON ######
    Private Sub btnRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequest.Click
        'Checking if Hospital is Selected
        If Not gridviewList.SelectedRows.Count = Nothing Then
            'Checking if Patient is selected
            If Not txtPatientName.Text = Nothing Then
                'Checking if Checkbox is checked
                If checkPermit.Checked = True Then
                    Connect()
                    Dim i = gridviewList.CurrentRow.Index
                    SelHosp = gridviewList.Item(0, i).Value
                    Dim name As String = gridviewList.Item(1, i).Value
                    'Tracking the Details of Recipient Hospital
                    cmd = New MySqlCommand("SELECT IP FROM Login WHERE id='" + SelHosp + "'", cn)
                    Dim dr As MySqlDataReader
                    dr = cmd.ExecuteReader()

                    If dr.Read Then
                        If IsDBNull(dr.Item("IP")) = True Then
                            MsgBox("Hospital is currently Unable to Process the request")
                            Return
                        Else
                            IP = dr.Item("IP")
                        End If
                        dr.Close()
                    End If

                    '###### Generating Request ######
                    Connect()
                    cmd = New MySqlCommand("SELECT COUNT(Req_id) FROM RequestHistory", cn)
                    Req_id = "EAx" + GenerateID(cmd).ToString
                    Dim PatientID As String = cbPatientID.SelectedItem
                    If checkFacility.Checked Then

                        cmd.CommandText = "INSERT INTO RequestHistory(Req_id,SPh_id,Rh_id,Requirement,Date,Status) Values" _
                       & "('" + Req_id + "','" + SelHosp + "','" + loggedID + "','" + cbFacilityReq.SelectedItem + "','" + Today + "','Pending')"

                    ElseIf checkBGroup.Checked Then

                        cmd.CommandText = "INSERT INTO RequestHistory(Req_id,SPh_id,Rh_id,Requirement,Date,Status) Values" _
                       & "('" + Req_id + "','" + SelHosp + "','" + loggedID + "','" + cbBgroup.SelectedItem + "','" + Today + "','Pending')"

                    End If
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "UPDATE requesthistory inner join hpatients on Rh_id=h_id SET requesthistory.p_id=hpatients.p_id,RequestHistory.Name=hpatients.Name,RequestHistory.Address = HPatients.Address, RequestHistory.Contact1 = HPatients.Contact1," _
                    & "RequestHistory.Contact2 = HPatients.Contact2, RequestHistory.Sex = hpatients.Sex, RequestHistory.Age =HPatients.Age, RequestHistory.BloodGroup = HPatients.BloodGroup, RequestHistory.Disease = hpatients.Disease, RequestHistory.Remarks = hpatients.Remarks, RequestHistory.DOA =hpatients.DOA where Req_id='" + Req_id + "' "
                    cmd.ExecuteNonQuery()

                    '******************************
                    'SENDING NotiFication
                    If checkFacility.Checked Then
                        Dim message As String = "Requirement for " + cbFacilityReq.SelectedItem
                        sendMessage(IP, message)
                    ElseIf checkBGroup.Checked Then
                        Dim message As String = "Requirement for Blood Group " + cbBgroup.SelectedItem
                        sendMessage(IP, message)
                    End If
                    'Giving Successful Message
                    MsgBox("Please Wait While Your Request Will Be Accepted By '" + name + "'")
                    '******************************
                Else 'Else of Checkbox Condition
                    MsgBox("You must be agree to share information of the patient with Selected Hospital")
                End If
            Else 'Else of Patient Selection Condition
                MsgBox("Please Select A Patient")
            End If
        Else 'Else of Hospital Selection Condition
            MsgBox("Please Select Any of the Hospital to Continue")
        End If
    End Sub

End Class
