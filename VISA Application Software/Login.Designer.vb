<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.login_CloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.Password_Panel1 = New System.Windows.Forms.Panel()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User_NamePanel1 = New System.Windows.Forms.Panel()
        Me.UserName_TextBox = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Password_Panel1.SuspendLayout()
        Me.User_NamePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.login_CloseButton)
        Me.Panel1.Controls.Add(Me.CheckBox)
        Me.Panel1.Controls.Add(Me.Password_Panel1)
        Me.Panel1.Controls.Add(Me.User_NamePanel1)
        Me.Panel1.Controls.Add(Me.BtnLogin)
        Me.Panel1.Controls.Add(Me.btnSignUp)
        Me.Panel1.Controls.Add(Me.lblUserLogin)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(23, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 487)
        Me.Panel1.TabIndex = 0
        '
        'login_CloseButton
        '
        Me.login_CloseButton.BorderColor = System.Drawing.Color.Transparent
        Me.login_CloseButton.CheckedState.Parent = Me.login_CloseButton
        Me.login_CloseButton.CustomImages.Parent = Me.login_CloseButton
        Me.login_CloseButton.FillColor = System.Drawing.Color.Red
        Me.login_CloseButton.Font = New System.Drawing.Font("Poppins Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_CloseButton.ForeColor = System.Drawing.Color.White
        Me.login_CloseButton.HoverState.Parent = Me.login_CloseButton
        Me.login_CloseButton.Location = New System.Drawing.Point(477, 6)
        Me.login_CloseButton.Name = "login_CloseButton"
        Me.login_CloseButton.ShadowDecoration.Parent = Me.login_CloseButton
        Me.login_CloseButton.Size = New System.Drawing.Size(27, 25)
        Me.login_CloseButton.TabIndex = 15
        Me.login_CloseButton.Text = "X"
        Me.login_CloseButton.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(456, 264)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox.TabIndex = 14
        Me.CheckBox.Text = "Show"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'Password_Panel1
        '
        Me.Password_Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Password_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Password_Panel1.Controls.Add(Me.Password_TextBox)
        Me.Password_Panel1.Controls.Add(Me.Label1)
        Me.Password_Panel1.Location = New System.Drawing.Point(46, 254)
        Me.Password_Panel1.Name = "Password_Panel1"
        Me.Password_Panel1.Size = New System.Drawing.Size(407, 34)
        Me.Password_Panel1.TabIndex = 13
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_TextBox.HideSelection = False
        Me.Password_TextBox.Location = New System.Drawing.Point(98, 2)
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.Size = New System.Drawing.Size(307, 29)
        Me.Password_TextBox.TabIndex = 7
        Me.Password_TextBox.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Password"
        '
        'User_NamePanel1
        '
        Me.User_NamePanel1.BackColor = System.Drawing.Color.Transparent
        Me.User_NamePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.User_NamePanel1.Controls.Add(Me.UserName_TextBox)
        Me.User_NamePanel1.Controls.Add(Me.lblEmailAddress)
        Me.User_NamePanel1.Location = New System.Drawing.Point(46, 180)
        Me.User_NamePanel1.Name = "User_NamePanel1"
        Me.User_NamePanel1.Size = New System.Drawing.Size(407, 34)
        Me.User_NamePanel1.TabIndex = 12
        '
        'UserName_TextBox
        '
        Me.UserName_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_TextBox.Location = New System.Drawing.Point(98, 2)
        Me.UserName_TextBox.Name = "UserName_TextBox"
        Me.UserName_TextBox.Size = New System.Drawing.Size(307, 29)
        Me.UserName_TextBox.TabIndex = 7
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(6, 5)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(94, 26)
        Me.lblEmailAddress.TabIndex = 6
        Me.lblEmailAddress.Text = "Username "
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnLogin.Location = New System.Drawing.Point(46, 318)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(304, 39)
        Me.BtnLogin.TabIndex = 11
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(358, 318)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(112, 39)
        Me.btnSignUp.TabIndex = 10
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblUserLogin
        '
        Me.lblUserLogin.BackColor = System.Drawing.Color.Silver
        Me.lblUserLogin.Font = New System.Drawing.Font("Poppins Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLogin.ForeColor = System.Drawing.Color.Black
        Me.lblUserLogin.Location = New System.Drawing.Point(3, 105)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(506, 48)
        Me.lblUserLogin.TabIndex = 5
        Me.lblUserLogin.Text = "USER LOGIN"
        Me.lblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 511)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Password_Panel1.ResumeLayout(False)
        Me.Password_Panel1.PerformLayout()
        Me.User_NamePanel1.ResumeLayout(False)
        Me.User_NamePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserName_TextBox As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Password_Panel1 As Panel
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents User_NamePanel1 As Panel
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents login_CloseButton As Guna.UI2.WinForms.Guna2Button
End Class
