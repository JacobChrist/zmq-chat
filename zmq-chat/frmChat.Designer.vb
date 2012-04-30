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
        Me.SuspendLayout()
        '
        'ServerButton
        '
        Me.ServerButton.Location = New System.Drawing.Point(12, 12)
        Me.ServerButton.Name = "ServerButton"
        Me.ServerButton.Size = New System.Drawing.Size(86, 23)
        Me.ServerButton.TabIndex = 1
        Me.ServerButton.Text = "Start Server"
        Me.ServerButton.UseVisualStyleBackColor = True
        '
        'ClientButton
        '
        Me.ClientButton.Location = New System.Drawing.Point(160, 12)
        Me.ClientButton.Name = "ClientButton"
        Me.ClientButton.Size = New System.Drawing.Size(86, 23)
        Me.ClientButton.TabIndex = 2
        Me.ClientButton.Text = "Start Client"
        Me.ClientButton.UseVisualStyleBackColor = True
        '
        'ServerTextBox
        '
        Me.ServerTextBox.Location = New System.Drawing.Point(12, 41)
        Me.ServerTextBox.Multiline = True
        Me.ServerTextBox.Name = "ServerTextBox"
        Me.ServerTextBox.Size = New System.Drawing.Size(142, 220)
        Me.ServerTextBox.TabIndex = 3
        '
        'ClientTextBox
        '
        Me.ClientTextBox.Location = New System.Drawing.Point(160, 41)
        Me.ClientTextBox.Multiline = True
        Me.ClientTextBox.Name = "ClientTextBox"
        Me.ClientTextBox.Size = New System.Drawing.Size(142, 220)
        Me.ClientTextBox.TabIndex = 4
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 273)
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

End Class
