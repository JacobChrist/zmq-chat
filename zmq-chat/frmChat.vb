Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports ZeroMQ

Public Class frmChat
    Dim server As New Thread(AddressOf ServerThread)

    Delegate Sub TextBoxAppendText(ByVal output As String)

    Public Sub ClientTextBoxAppendText_Callback(ByVal output As String)
        ClientTextBox.AppendText(output + vbCrLf)
    End Sub

    Public Sub ServerTextBoxAppendText_Callback(ByVal output As String)
        ServerTextBox.AppendText(output + vbCrLf)
    End Sub

    Private Sub ServerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerButton.Click
        If server.IsAlive Then
            MsgBox("Server is running")
        Else
            server.Start()
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
            socket.Connect("tcp://localhost:8989")

            socket.SendFrame(New Frame(Encoding.UTF8.GetBytes("Hello")))

            Dim buffer(100) As Byte
            Dim size As Integer = socket.Receive(buffer)

            Dim stream As New MemoryStream(buffer, 0, size)
            Using stream
                If ClientTextBox.InvokeRequired Then
                    Dim d As New TextBoxAppendText(AddressOf ClientTextBoxAppendText_Callback)
                    Me.Invoke(d, New Object() {Encoding.UTF8.GetString(stream.ToArray())})
                Else
                    ClientTextBox.Text = Encoding.UTF8.GetString(stream.ToArray())
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
                socket.Bind("tcp://*:8989")

                While (1)
                    Dim request As Frame = socket.ReceiveFrame(New TimeSpan(10000000))

                    If request.BufferSize > 0 Then
                        If ServerTextBox.InvokeRequired Then
                            Dim d As New TextBoxAppendText(AddressOf ServerTextBoxAppendText_Callback)
                            Me.Invoke(d, New Object() {Encoding.UTF8.GetString(request)})
                        Else
                            ServerTextBox.Text = Encoding.UTF8.GetString(request)
                        End If

                        Console.WriteLine(Encoding.UTF8.GetString(request))
                        socket.SendFrame(New Frame(Encoding.UTF8.GetBytes("World")))
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

End Class
