'************************************************************************************
'                                ASSISTANCE DASHBOARD FORM
'*************************************************************************************
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class AssistDialogue
    Dim IP As String

    Private Sub AssistDialogue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        Connect()
    End Sub
    '
    '#############################    Tab NEW Request    ################################

    Private Sub tabNewRequests_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabNewRequests.Enter
        querydisplay = "SELECT Date,Req_id,Requirement,Status,Rh_id FROM RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Pending' ORDER BY Date"
        disp_data(querydisplay, gridviewRequests)
        If gridviewRequests.RowCount > 2 Then
            lblNoRecordFound.Visible = False
        Else
            lblNoRecordFound.Visible = True
        End If
    End Sub
    Dim selection As String
    Dim requirement As String
    Dim Rh_id As String

    Private Sub checkPermit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkPermit.CheckedChanged
        Dim index = gridviewRequests.CurrentRow.Index
        selection = gridviewRequests.Item(1, index).Value
        requirement = gridviewRequests.Item(2, index).Value
        Rh_id = gridviewRequests.Item(4, index).Value
        cmd = New MySqlCommand("Select IP FROM Login WHERE id='" + Rh_id + "'", cn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.Read Then IP = dr.Item(0)
        dr.Close()
    End Sub
    '###### Accept Button ######
    Public Sub btnAcceptRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptRequest.Click
        If checkPermit.Checked Then
            Try
                cmd.CommandText = ("UPDATE RequestHistory SET Status ='Accepted' WHERE Req_id='" + selection + "' AND SPh_id='" + loggedID + "'")
                cmd.ExecuteNonQuery()
                querydisplay = "SELECT Date,Req_id,Requirement,Status,Rh_id FROM RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Pending' ORDER BY Date"
                disp_data(querydisplay, gridviewRequests)
                'SENDING Accept Notification
                Dim message As String = "Request Accepted For " + selection + " { " + requirement + " }"
                sendMessage(IP, message)
            Catch ex As Exception
                MsgBox("Currently there are no Pending Requests to Accept")
            End Try
        Else
            MsgBox("You must be Agree the Terms and Conditions")
        End If
    End Sub
    '
    '###### Decline Button ######
    Private Sub btnDecline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecline.Click
        dclIP = IP
        dclSelection = selection
        dclRh_id = Rh_id
        dclRequirement = requirement
        ReasonToDecline.ShowDialog()
    End Sub

    '###################################    Tab History    ##########################################

    Private Sub cbDuration_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDuration.SelectedIndexChanged
        tickDuration.Checked = True
        tickJumpDate.Checked = False
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calJumpDate.ValueChanged
        tickJumpDate.Checked = True
        tickDuration.Checked = False
    End Sub
    '
    '###### Search Button ######
    Private Sub btnDurationSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDurationSubmit.Click
        ' Select duration
        If tickDuration.Checked Then
            'Today's record
            If cbDuration.SelectedItem = "Today" Then
                querydisplay = "SELECT * From RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Accepted' AND Date ='" + Today + "'"
                disp_data(querydisplay, gridviewHistory)
            End If
            'Month-wise Record
            If cbDuration.SelectedIndex = 1 Then
                Dim temp = Today.Month
                Dim month As String = ""
                If temp < 10 Then
                    month = "0" + temp.ToString
                End If
                querydisplay = "SELECT * From RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Accepted' AND Date LIKE '___" + month + "%'"
                disp_data(querydisplay, gridviewHistory)
            End If
            'Year-wise Record
            If cbDuration.SelectedIndex = 2 Then
                Dim year As String = Today.Year
                querydisplay = "SELECT * From RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Accepted' AND Date LIKE '______" + year + "%'"
                disp_data(querydisplay, gridviewHistory)
            End If
            If cbDuration.SelectedIndex = 3 Then
                Dim temp = Today.Year
                temp = temp - 1
                Dim year As String = temp.ToString
                querydisplay = "SELECT * From RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Accepted' AND Date LIKE '______" + year + "%'"
                disp_data(querydisplay, gridviewHistory)
            End If
            '###### Jump to Date ######
        ElseIf tickJumpDate.Checked Then
            Dim SelectedDate As DateTime

            Dim dt As String = calJumpDate.Text
            SelectedDate = Convert.ToDateTime(dt.ToString)
            'MsgBox(SelectedDate)
            querydisplay = "SELECT Date,Req_id,Requirement,Status,Rh_id as Requestee, p_id as Patient_ID,DOA,Name as Patient_Name,Age,BloodGroup,Sex,Disease,Contact1,Contact2,Address From RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Accepted' AND Date = '" + SelectedDate + "'"
            disp_data(querydisplay, gridviewHistory)
        End If

        If gridviewHistory.RowCount > 2 Then
            lblNoRecord.Visible = False
        Else
            lblNoRecord.Visible = True
        End If
    End Sub
    '
    '#############################    Tab Your Requests    ###################################

    Private Sub tabYourRequest_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabYourRequest.Enter
        Connect()
        'This query is to select hospital name address and contacts from hospital table
        querydisplay = "Select Date,Req_id,Requirement,Status, H.Name as Service_Provider,H.City,H.Address,H.Contact1,H.Contact2 From Hospital H INNER JOIN RequestHistory RH ON H.h_id=SPh_id and Rh_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewYourRequests)
        If gridviewYourRequests.RowCount > 2 Then
            lblNoRequests.Visible = False
        Else
            lblNoRequests.Visible = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Connect()
        'This query is to select hospital name address and contacts from hospital table
        querydisplay = "Select Date,Req_id,Requirement,Status, H.Name,H.City,H.Address,H.Contact1,H.Contact2 From Hospital H INNER JOIN RequestHistory RH ON H.h_id=SPh_id and Rh_id='" + loggedID + "'"
        disp_data(querydisplay, gridviewYourRequests)
        If gridviewYourRequests.RowCount > 2 Then
            lblNoRequests.Visible = False
        Else
            lblNoRequests.Visible = True
        End If
    End Sub

End Class
