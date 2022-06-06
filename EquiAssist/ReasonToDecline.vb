'************************************************************************************
'                               REASON TO DECLINE DIALOG BOX
'*************************************************************************************
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class ReasonToDecline
    '###### Button Decline ######
    Private Sub btnDecline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecline.Click
        Try
            If tickReason1.Checked = True Or tickReason2.Checked = True Or tickReasonOther.Checked = True Then
                connection()
                Connect()
                cmd.CommandText = ("UPDATE RequestHistory SET Status ='Declined' WHERE Req_id='" + dclSelection + "' AND SPh_id='" + loggedID + "'")
                cmd.ExecuteNonQuery()
                querydisplay = "SELECT Date,Req_id,Requirement,Status,Rh_id FROM RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Pending'"
                'SENDING Accept Notification
                Dim message As String = "Request Declined For " + dclSelection + " { " + dclRequirement + " }"
                sendMessage(dclIP, message)
                Me.Close()
            Else
                MsgBox("Please Select Any Reason To Decline")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '
    '###### Button Cancel ######
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    '
    '###### Form Closing ###### 
    Private Sub ReasonToDecline_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        querydisplay = "SELECT Date,Req_id,Requirement,Status,Rh_id FROM RequestHistory WHERE SPh_id='" + loggedID + "' AND Status='Pending' ORDER BY Date"
        disp_data(querydisplay, AssistDialogue.gridviewRequests)
        If AssistDialogue.gridviewRequests.RowCount > 2 Then
            AssistDialogue.lblNoRecordFound.Visible = False
        Else
            AssistDialogue.lblNoRecordFound.Visible = True
        End If
    End Sub

End Class
