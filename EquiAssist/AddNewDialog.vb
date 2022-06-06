'************************************************************************************
'                            ADD NEW FACILITY DIALOG BOX
'*************************************************************************************
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class dialogNewFacility
    'Form Load
    Private Sub dialogNewFacility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        clearALL(pnlHospFacility)
        clearALL(pnlBloodAvailability)
        Connect()
        ' MsgBox(loggedID)
        If dialog = "Hospital" Then
            pnlHospFacility.Visible = True
            pnlBloodAvailability.Visible = False
            'LOADING FACILITIES 
            queryfacility = "SELECT items FROM Facilityitems"
            loadFacilites(queryfacility, cbHospFacility)

        ElseIf dialog = "BloodBank" Then
            pnlHospFacility.Visible = False
            pnlBloodAvailability.Visible = True
        End If
    End Sub

    '###################### Panel Hospital Facility ##############################

    'Facility Add Button
    Private Sub btdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdAdd.Click
        Connect()
        Dim facility As String = cbHospFacility.SelectedItem
        Dim count As String = countHospFacility.Value

        ''************* Inserting New Facility to Database **********
        cmd.CommandText = "INSERT INTO HFacilities VALUES ('" + loggedID + "','" + facility + "','" + count + "') " _
            & "ON DUPLICATE KEY UPDATE Availability='" + count + "' "
        cmd.ExecuteNonQuery()
        'Reset
        clearALL(pnlHospFacility)
        Me.Close()
    End Sub
    'Cancel Buttom
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '####################### Panel Blood Availability ##############################

    'Blood Stock Add Button
    Private Sub btnBAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBAdd.Click
        Connect()
        Dim B_Group As String = cbBloodGroup.SelectedItem
        Dim Available As String = countBloodQuantity.Value

        ''************* Inserting Blood Group Stock to Database **********
        cmd.CommandText = " INSERT INTO BStock VALUES ('" + loggedID + "','" + B_Group + "','" + Available + "')" _
            & " ON DUPLICATE KEY UPDATE Availability ='" + Available + "' "
        cmd.ExecuteNonQuery()
        'Reset
        clearALL(pnlBloodAvailability)
        Me.Close()

    End Sub
    'Cancel Button
    Private Sub btnBCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBCancel.Click
        Me.Close()
    End Sub

End Class
