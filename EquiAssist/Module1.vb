'************************************************************************************
'   THIS IS THE MODULE WHERE ALL NETWORK RELATED CODING IS WRITTEN
'*************************************************************************************
Imports System.IO
Imports System.Net.Sockets
Imports System.Net
Module Module1
    Public ServerIP As IPAddress = IPAddress.Parse(IP_Address)
    Public listener As New TcpListener(ServerIP, 44444)
    Public client As TcpClient
    Public message As String = ""
    '
    '###### This is to stop Server ######
    Public Sub stopServer()
        If listener.Pending Then listener.Stop()
    End Sub
    '
    'This is to start the server
    Public Sub startServer(ByVal tmr As Timer)
        Try
            listener.Start()
            tmr.Enabled = True
            tmr.Start()
        Catch ex As Exception
            MsgBox("There is an error. This might because you are using the same IP address for two systems")
        End Try
        
    End Sub
    '
    '###### This is to read request from other hospital ######
    Public Sub readMessage(ByVal txt As TextBox, ByVal notify As NotifyIcon)
        Try
            If listener.Pending = True Then
                message = ""
                client = listener.AcceptTcpClient()
                Dim reader As New StreamReader(client.GetStream)
                While reader.Peek > -1
                    message = message + Convert.ToChar(reader.Read).ToString
                End While
                If message.Contains("Requirement For") Then

                End If
                txt.AppendText(message)
                notify.BalloonTipText = message
                notify.ShowBalloonTip(5000)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '
    '###### This is to send request to other hospital ######
    Public Sub sendMessage(ByVal ip As String, ByVal message As String)
        Try
            client = New TcpClient(ip, 44444)
            Dim writer As New StreamWriter(client.GetStream)
            writer.Write(message + vbCrLf)
            writer.Flush()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
