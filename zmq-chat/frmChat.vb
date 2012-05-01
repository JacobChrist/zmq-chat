Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports ZeroMQ

Public Class frmChat
    Dim server As Thread

    Delegate Sub TextBoxAppendText(ByVal output As String)

    Public Sub ClientTextBoxAppendText_Callback(ByVal output As String)
        ClientTextBox.AppendText(output + vbCrLf)
    End Sub

    Public Sub ServerTextBoxAppendText_Callback(ByVal output As String)
        ServerTextBox.AppendText(output + vbCrLf)
    End Sub

    Private Sub ServerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerButton.Click
        If server Is Nothing Then
            server = New Thread(AddressOf ServerThread)
        End If
        If server.IsAlive Then
            server.Abort()
            ServerButton.Text = "Start Server"
        Else
            server = New Thread(AddressOf ServerThread)
            server.Start()
            ServerButton.Text = "Stop Server"
        End If
    End Sub

    Private Sub ClientButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientButton.Click
        Dim client As New Thread(AddressOf ClientThread)
        client.Start()
        'ClientThread() // for some reason this caused the server to hang
    End Sub

    Private Sub ClientThread()
        Dim context As ZmqContext = ZmqContext.Create()
        Dim socket As ZmqSocket = context.CreateSocket(SocketType.REQ)
        Using socket
            socket.Connect(ClientConnectString.Text)

            socket.SendFrame(New Frame(Encoding.UTF8.GetBytes(ClientStringTextBox.Text)))

            Dim buffer(100) As Byte
            Dim size As Integer = socket.Receive(buffer)

            Dim stream As New MemoryStream(buffer, 0, size)
            Dim DisplayString As String = ClientStringTextBox.Text + "->" + Encoding.UTF8.GetString(stream.ToArray())
            Using stream
                If ClientTextBox.InvokeRequired Then
                    Dim d As New TextBoxAppendText(AddressOf ClientTextBoxAppendText_Callback)
                    Me.Invoke(d, New Object() {DisplayString})
                Else
                    ClientTextBox.Text = DisplayString
                End If

                Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()))
            End Using
        End Using
    End Sub

    Private Sub ServerThread()
        Try
            Dim context As ZmqContext = ZmqContext.Create()
            Dim socket As ZmqSocket = context.CreateSocket(SocketType.REP)

            Using socket
                socket.Bind(ServerConnectString.Text)

                While (1)
                    Dim request As Frame = socket.ReceiveFrame(New TimeSpan(10000000))

                    Dim DisplayString As String = Encoding.UTF8.GetString(request) + "<-" + ServerStringTextBox.Text

                    If request.BufferSize > 0 Then
                        If ServerTextBox.InvokeRequired Then
                            Dim d As New TextBoxAppendText(AddressOf ServerTextBoxAppendText_Callback)
                            Me.Invoke(d, New Object() {DisplayString})
                        Else
                            ServerTextBox.Text = DisplayString
                        End If

                        Console.WriteLine(Encoding.UTF8.GetString(request))
                        socket.SendFrame(New Frame(Encoding.UTF8.GetBytes(ServerStringTextBox.Text)))
                    End If
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If server.IsAlive Then
            server.Abort()
        End If
    End Sub

    Private Sub GetIPAddress()
        Dim HostName As String
        Dim IPAddresses As String = ""

        HostName = System.Net.Dns.GetHostName()

        For Each IP In System.Net.Dns.GetHostEntry(HostName).AddressList
            IPAddresses += IP.ToString() + vbCrLf
        Next
        MessageBox.Show("Host Name: " + HostName + "; IP Addresses: " + vbCrLf + IPAddresses)
    End Sub

    Private Sub GetMyIpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetMyIpButton.Click
        GetIPAddress()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ServerTextBox.Clear()
        ClientTextBox.Clear()
    End Sub
End Class
