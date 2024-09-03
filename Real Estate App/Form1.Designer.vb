<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Login
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
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.User_Login_Label = New System.Windows.Forms.Label()
        Me.PasswordPanel = New System.Windows.Forms.Panel()
        Me.ErrorMessageLabel = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Password_Panel = New System.Windows.Forms.Panel()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserNamePanel = New System.Windows.Forms.Panel()
        Me.UserName_TextBox = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.Label()
        Me.PasswordPanel.SuspendLayout()
        Me.Password_Panel.SuspendLayout()
        Me.UserNamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Close_Button
        '
        Me.Close_Button.BackColor = System.Drawing.Color.Red
        Me.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Button.Font = New System.Drawing.Font("Poppins Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Button.ForeColor = System.Drawing.Color.Transparent
        Me.Close_Button.Location = New System.Drawing.Point(467, 0)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(33, 27)
        Me.Close_Button.TabIndex = 0
        Me.Close_Button.Text = "X"
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'User_Login_Label
        '
        Me.User_Login_Label.BackColor = System.Drawing.Color.Blue
        Me.User_Login_Label.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Login_Label.Location = New System.Drawing.Point(1, 36)
        Me.User_Login_Label.Name = "User_Login_Label"
        Me.User_Login_Label.Size = New System.Drawing.Size(499, 53)
        Me.User_Login_Label.TabIndex = 1
        Me.User_Login_Label.Text = "User Login"
        Me.User_Login_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordPanel
        '
        Me.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PasswordPanel.Controls.Add(Me.ErrorMessageLabel)
        Me.PasswordPanel.Controls.Add(Me.LoginButton)
        Me.PasswordPanel.Controls.Add(Me.Password_Panel)
        Me.PasswordPanel.Controls.Add(Me.UserNamePanel)
        Me.PasswordPanel.Location = New System.Drawing.Point(10, 106)
        Me.PasswordPanel.Name = "PasswordPanel"
        Me.PasswordPanel.Size = New System.Drawing.Size(478, 291)
        Me.PasswordPanel.TabIndex = 2
        '
        'ErrorMessageLabel
        '
        Me.ErrorMessageLabel.AutoSize = True
        Me.ErrorMessageLabel.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorMessageLabel.Location = New System.Drawing.Point(155, 158)
        Me.ErrorMessageLabel.Name = "ErrorMessageLabel"
        Me.ErrorMessageLabel.Size = New System.Drawing.Size(172, 28)
        Me.ErrorMessageLabel.TabIndex = 5
        Me.ErrorMessageLabel.Text = "Error Message Here"
        Me.ErrorMessageLabel.Visible = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Green
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(12, 227)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(446, 42)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Password_Panel
        '
        Me.Password_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Password_Panel.Controls.Add(Me.Password_TextBox)
        Me.Password_Panel.Controls.Add(Me.Label1)
        Me.Password_Panel.Location = New System.Drawing.Point(12, 106)
        Me.Password_Panel.Name = "Password_Panel"
        Me.Password_Panel.Size = New System.Drawing.Size(452, 49)
        Me.Password_Panel.TabIndex = 3
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_TextBox.Location = New System.Drawing.Point(133, 10)
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.Size = New System.Drawing.Size(313, 31)
        Me.Password_TextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Password:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserNamePanel
        '
        Me.UserNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserNamePanel.Controls.Add(Me.UserName_TextBox)
        Me.UserNamePanel.Controls.Add(Me.UserName)
        Me.UserNamePanel.Location = New System.Drawing.Point(12, 24)
        Me.UserNamePanel.Name = "UserNamePanel"
        Me.UserNamePanel.Size = New System.Drawing.Size(452, 49)
        Me.UserNamePanel.TabIndex = 0
        '
        'UserName_TextBox
        '
        Me.UserName_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_TextBox.Location = New System.Drawing.Point(133, 10)
        Me.UserName_TextBox.Name = "UserName_TextBox"
        Me.UserName_TextBox.Size = New System.Drawing.Size(313, 31)
        Me.UserName_TextBox.TabIndex = 1
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.Location = New System.Drawing.Point(4, 5)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(135, 37)
        Me.UserName.TabIndex = 1
        Me.UserName.Text = "Username:"
        Me.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'User_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 396)
        Me.Controls.Add(Me.PasswordPanel)
        Me.Controls.Add(Me.User_Login_Label)
        Me.Controls.Add(Me.Close_Button)
        Me.Name = "User_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        Me.PasswordPanel.ResumeLayout(False)
        Me.PasswordPanel.PerformLayout()
        Me.Password_Panel.ResumeLayout(False)
        Me.Password_Panel.PerformLayout()
        Me.UserNamePanel.ResumeLayout(False)
        Me.UserNamePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Close_Button As Button
    Friend WithEvents User_Login_Label As Label
    Friend WithEvents PasswordPanel As Panel
    Friend WithEvents ErrorMessageLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents Password_Panel As Panel
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UserNamePanel As Panel
    Friend WithEvents UserName_TextBox As TextBox
    Friend WithEvents UserName As Label

    Private Sub LoginButton_Click(e As EventArgs, sender As Object)
        Me.Hide()
        SplashScreen.Show()
    End Sub
End Class
