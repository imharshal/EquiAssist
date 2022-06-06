'************************************************************************************
'                                CREATE LOGIN CREDENTIALS DIALOG
'*************************************************************************************
Imports System.Windows.Forms
Imports EquiAssist.myModule
Imports MySql.Data.MySqlClient

Public Class CreateLogin
    '###### Form Load ######
    Private Sub CreateLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Create Login Credintial to manage your dashboard on the go")
        connection()
    End Sub
    '
    '###### Show Password Panel #######
    Private Sub pnlShowPass_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlShowPass.MouseClick
        If txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
        ElseIf txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub
    '
    '###### Submit Button ######
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Connect()
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Please Enter Username or Password")
        Else
            txtPassword.UseSystemPasswordChar = True
            cmd.CommandText = "INSERT INTO Login VALUES ('" + uID + "','" + txtUsername.Text + "','" + txtPassword.Text + "',null)"
            cmd.ExecuteNonQuery()
            uID = Nothing
            registration.Close()
            MsgBox("Congratulation! You are Registered Successfully." + vbLf + "Now Login to go to Dashboard")
            Me.Close()
        End If
    End Sub

End Class
