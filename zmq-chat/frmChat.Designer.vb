<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ServerButton = New System.Windows.Forms.Button()
        Me.ClientButton = New System.Windows.Forms.Button()
        Me.ServerTextBox = New System.Windows.Forms.TextBox()
        Me.ClientTextBox = New System.Windows.Forms.TextBox()
        Me.ServerConnectString = New System.Windows.Forms.TextBox()
        Me.ClientConnectString = New System.Windows.Forms.TextBox()
        Me.ServerStringTextBox = New System.Windows.Forms.TextBox()
        Me.ClientStringTextBox = New System.Windows.Forms.TextBox()
        Me.GetMyIpButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ServerButton
        '
        Me.ServerButton.Location = New System.Drawing.Point(12, 12)
        Me.ServerButton.Name = "ServerButton"
        Me.ServerButton.Size = New System.Drawing.Size(142, 23)
        Me.ServerButton.TabIndex = 1
        Me.ServerButton.Text = "Start Server"
        Me.ServerButton.UseVisualStyleBackColor = True
        '
        'ClientButton
        '
        Me.ClientButton.Location = New System.Drawing.Point(160, 12)
        Me.ClientButton.Name = "ClientButton"
        Me.ClientButton.Size = New System.Drawing.Size(142, 23)
        Me.ClientButton.TabIndex = 2
        Me.ClientButton.Text = "Start Client"
        Me.ClientButton.UseVisualStyleBackColor = True
        '
        'ServerTextBox
        '
        Me.ServerTextBox.Location = New System.Drawing.Point(12, 93)
        Me.ServerTextBox.Multiline = True
        Me.ServerTextBox.Name = "ServerTextBox"
        Me.ServerTextBox.Size = New System.Drawing.Size(142, 168)
        Me.ServerTextBox.TabIndex = 3
        '
        'ClientTextBox
        '
        Me.ClientTextBox.Location = New System.Drawing.Point(160, 93)
        Me.ClientTextBox.Multiline = True
        Me.ClientTextBox.Name = "ClientTextBox"
        Me.ClientTextBox.Size = New System.Drawing.Size(142, 168)
        Me.ClientTextBox.TabIndex = 4
        '
        'ServerConnectString
        '
        Me.ServerConnectString.Location = New System.Drawing.Point(12, 41)
        Me.ServerConnectString.Name = "ServerConnectString"
        Me.ServerConnectString.Size = New System.Drawing.Size(142, 20)
        Me.ServerConnectString.TabIndex = 5
        Me.ServerConnectString.Text = "tcp://*:8989"
        '
        'ClientConnectString
        '
        Me.ClientConnectString.Location = New System.Drawing.Point(160, 41)
        Me.ClientConnectString.Name = "ClientConnectString"
        Me.ClientConnectString.Size = New System.Drawing.Size(142, 20)
        Me.ClientConnectString.TabIndex = 6
        Me.ClientConnectString.Text = "tcp://localhost:8989"
        '
        'ServerStringTextBox
        '
        Me.ServerStringTextBox.Location = New System.Drawing.Point(12, 67)
        Me.ServerStringTextBox.Name = "ServerStringTextBox"
        Me.ServerStringTextBox.Size = New System.Drawing.Size(142, 20)
        Me.ServerStringTextBox.TabIndex = 7
        Me.ServerStringTextBox.Text = "World"
        '
        'ClientStringTextBox
        '
        Me.ClientStringTextBox.Location = New System.Drawing.Point(160, 67)
        Me.ClientStringTextBox.Name = "ClientStringTextBox"
        Me.ClientStringTextBox.Size = New System.Drawing.Size(142, 20)
        Me.ClientStringTextBox.TabIndex = 8
        Me.ClientStringTextBox.Text = "Hello"
        '
        'GetMyIpButton
        '
        Me.GetMyIpButton.Location = New System.Drawing.Point(12, 267)
        Me.GetMyIpButton.Name = "GetMyIpButton"
        Me.GetMyIpButton.Size = New System.Drawing.Size(142, 23)
        Me.GetMyIpButton.TabIndex = 9
        Me.GetMyIpButton.Text = "Get My IP"
        Me.GetMyIpButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(160, 267)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(142, 23)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 297)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GetMyIpButton)
        Me.Controls.Add(Me.ClientStringTextBox)
        Me.Controls.Add(Me.ServerStringTextBox)
        Me.Controls.Add(Me.ClientConnectString)
        Me.Controls.Add(Me.ServerConnectString)
        Me.Controls.Add(Me.ClientTextBox)
        Me.Controls.Add(Me.ServerTextBox)
        Me.Controls.Add(Me.ClientButton)
        Me.Controls.Add(Me.ServerButton)
        Me.Name = "frmChat"
        Me.Text = "frmChat ZeroMQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ServerButton As System.Windows.Forms.Button
    Friend WithEvents ClientButton As System.Windows.Forms.Button
    Friend WithEvents ServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServerConnectString As System.Windows.Forms.TextBox
    Friend WithEvents ClientConnectString As System.Windows.Forms.TextBox
    Friend WithEvents ServerStringTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientStringTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GetMyIpButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button

End Class
