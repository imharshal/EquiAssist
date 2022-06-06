'************************************************************************************
'                                LOGIN FORM
'*************************************************************************************
Imports MySql.Data.MySqlClient
Imports System.Net

Public Class Login
    'Getting focus on Username textbox
    Private Sub Login_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        txtUsername.Focus()
    End Sub
    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then txtPassword.Focus()
    End Sub
    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then loginButton()
    End Sub
    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub
    '###### Show Password Panel ######
    Private Sub pnlShowPass_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlShowPass.MouseClick
        If txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
        ElseIf txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
    '###### Opening Registration window ######
    Private Sub lblRegistration(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblRegister.LinkClicked
        registration.ShowDialog()
    End Sub
    '###### Login Button ######
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        loginButton()
    End Sub
    '###### Coding for login Button ######
    Public Sub loginButton()
        connection()
        Connect()
        txtPassword.UseSystemPasswordChar = True
        'Getting the department of the Login ID
        cmd = New MySqlCommand("SELECT * FROM Login WHERE Username ='" + txtUsername.Text + "' AND " _
                     & "Password ='" + txtPassword.Text + "' ", cn)
        'COLLATE SQL_Latin1_General_Cp1_CS_AS

        uID = cmd.ExecuteScalar
        If IsNothing(uID) = False Then
            dept = uID.Chars(0)
            clearALL(pnlLogin)
            If dept = "h" Then
                GetIPAddress()
                cmd = New MySqlCommand("UPDATE Login SET IP='" + IP_Address + "' WHERE id='" + uID + "'", cn)
                cmd.ExecuteNonQuery()
                Me.Hide()
                HospitalDashboard.ShowDialog()
            ElseIf dept = "b" Then
                GetIPAddress()
                cmd = New MySqlCommand("UPDATE Login SET IP='" + IP_Address + "' WHERE id='" + uID + "'", cn)
                cmd.ExecuteNonQuery()
                Me.Hide()
                BloodBankDashboard.ShowDialog()
            End If
        Else
            MessageBox.Show("No records Found")
            clearALL(pnlLogin)
        End If
    End Sub
    '###### Login Page Load Event ######
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearALL(pnlLogin)
    End Sub

End Class