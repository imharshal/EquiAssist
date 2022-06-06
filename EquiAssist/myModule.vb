'************************************************************************
'This is the Module where all the complex tasks are performed
'************************************************************************
Imports Mysql.data.MysqlClient
Imports System.Net
Imports EquiAssist.registration
Imports EquiAssist.myModule

Module myModule
    Public cn As MySqlConnection
    Public cmd As New MySqlCommand
    Public ConnectionString As String
    Public h_id As String
    Public b_id As String
    Public uID As String
    Public loggedID As String = uID
    Public querydisplay As String
    Public queryfacility As String
    Public dialog As String
    Public IP_Address As String
    Public DOA As DateTime
    Public dept As Char

    Public dclIP As String
    Public dclSelection As String
    Public dclRequirement As String
    Public dclRh_id As String

    Public allSet As Boolean
    '
    '###### Create Connection ######
    Public Sub connection()
        ' ConnectionString = "server=192.168.43.234;Port=443;user id=root;database=equiassist"
        'ConnectionString = "server=db4free.net ; port=3306 ;Uid=bokde984;password=bokde984;database=equiassist"
        ConnectionString = "server=sql108.epizy.com; port=3306 ;Uid=epiz_25268391;password=Harshal9130;database=epiz_25268391_EquiAssist"
        'ConnectionString = "server=databases.000webhost.com\localhost ;Uid=id12663480_bokde984;password=Harshal@9130;database=id12663480_equiassist"
        'ConnectionString = "server=192.168.43.234;port=3306;Uid=bokde;database=equiassist"
        'ConnectionString = "Data Source=HARSHAL-PC\SQLEXPRESS;Initial Catalog=EquiAssist;Integrated Security=True"
        ' ConnectionString = "Data Source=10.0.0.2,1433\SQLEXPRESS;Initial Catalog=EquiAssist;Persist Security Info=True;User ID=admin;Password=913099"
        cn = New MySqlConnection(ConnectionString)
    End Sub
    '
    '###### Function to Open DataBase Connection ######
    Public Sub Connect()
        Try
            Dim cs As New ConnectionState
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            cmd = cn.CreateCommand()
            cmd.CommandType = CommandType.Text
        Catch ex As Exception
            MsgBox("There is problem connecting to database")
        End Try

    End Sub
    '
    '####### Function to load Combobox ######
    Public Sub loadFacilites(ByVal queryfacility As String, ByVal combo As ComboBox)
        Connect()
        cmd = New MySqlCommand(queryfacility, cn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        combo.Items.Clear()
        Do While dr.Read = True
            combo.Items.Add(dr.Item("items"))
        Loop
        cn.Close()
    End Sub
    '
    '###### Display Data to DataGridView ######
    Public Sub disp_data(ByVal querydisplay As String, ByVal o As DataGridView)
        Connect()
        cmd.CommandText = querydisplay
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        o.DataSource = dt
    End Sub
    '
    '###### Display Data to DataGridView ######
    Public Sub Update_datagrid(ByVal querydisplay As String, ByVal o As DataGridView)
        Connect()
        cmd.CommandText = querydisplay
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Update(dt)
    End Sub
    '
    '###### This will check for empty textboxes ######
    Function IsEmpty(ByVal portion As Control) As Boolean
        Dim ctrl As New Control
        'Focus TextBox
        Dim tex As New TextBox
        For Each ctrl In portion.Controls.OfType(Of TextBox)()
            tex = TryCast(ctrl, TextBox)
            If tex.Text = "" Then
                tex.Focus()
                tex.BackColor = Color.Yellow
                allSet = True
            Else
                tex.BackColor = Color.White
                allSet = False
            End If
        Next
        For Each ctrl In portion.Controls.OfType(Of ComboBox)()
            'Focus Combobox
            Dim combo As New ComboBox
            combo = TryCast(ctrl, ComboBox)
            If combo.Text = "-Select-" Or combo.Text = "" Then
                combo.Focus()
                combo.BackColor = Color.Yellow
                allSet = True
                combo.Text = "-Select-"
            Else
                combo.BackColor = Color.White
                allSet = False
            End If

        Next
        Return allSet
    End Function
    '###### This will clear all textboxes ######
    Public Sub clearALL(ByVal portion As Control)
        Dim ctrl As New Control
        'Clear TextBox
        Dim tex As New TextBox
        For Each ctrl In portion.Controls.OfType(Of TextBox)()
            tex = TryCast(ctrl, TextBox)
            tex.Clear()
        Next
        'Clear Combobox
        Dim combo As New ComboBox
        For Each ctrl In portion.Controls.OfType(Of ComboBox)()
            combo = TryCast(ctrl, ComboBox)
            combo.Text = "-Select-"
        Next
        'Clear NumericUpDown
        Dim num As New NumericUpDown
        For Each ctrl In portion.Controls.OfType(Of NumericUpDown)()
            num = TryCast(ctrl, NumericUpDown)
            num.Value = 1
        Next
    End Sub
    '
    '###### Generate Unique ID ######
    Function GenerateID(ByVal cmd) As Integer
        Dim id As Integer
        id = Convert.ToInt32(cmd.ExecuteScalar)
        id += 1
        GenerateID = id
    End Function
    '
    '###### This will check IP address of System ######
    Public Sub GetIPAddress()

        Dim hostName As String
        Dim ipAddr() As IPAddress
        hostName = System.Net.Dns.GetHostName()
        ipAddr = Dns.GetHostAddresses(hostName)
        MsgBox(ipAddr(5).ToString())
        IP_Address = ipAddr(5).ToString()
    End Sub

End Module
