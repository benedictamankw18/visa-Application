Public Class frmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Emptyfields()

    End Sub
    Public Function Emptyfields() As Boolean
        Dim Username As String = UserName_TextBox.Text.Trim()
        Dim Password As String = Password_TextBox.Text.Trim()
        Dim value As Boolean = False

        If Username.Equals("") And Password.Equals("") Then
            User_NamePanel1.BackColor = Color.Red
            Password_Panel1.BackColor = Color.Red
            Return False

        ElseIf Username.Equals("") Then
            User_NamePanel1.BackColor = Color.Red
            value = False

        ElseIf Password.Equals("") Then
            Password_Panel1.BackColor = Color.Red
            value = False

        ElseIf Not Username.Equals("") And Not Password.Equals("") Then
            value = True
            Dashboard.Show()
            Me.Hide()
        End If
        Return value

    End Function
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If CheckBox.Checked = True Then
            Password_TextBox.UseSystemPasswordChar = False
        Else
            Password_TextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_CloseButton_Click(sender As Object, e As EventArgs) Handles login_CloseButton.Click
        Me.Close()
    End Sub
End Class
