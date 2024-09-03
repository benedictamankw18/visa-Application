Public Class User_Login
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Close()
    End Sub
    'Function to check whether the username or password is empty
    Public Function Emptyfields() As Boolean
        Dim Username As String = UserName_TextBox.Text.Trim()
        Dim Password As String = Password_TextBox.Text.Trim()
        Dim value As Boolean = False

        If Username.Equals("") And Password.Equals("") Then
            UserNamePanel.BackColor = Color.Red
            Password_Panel.BackColor = Color.Red
            Return False

        ElseIf Username.Equals("") Then
            UserNamePanel.BackColor = Color.Red
            value = False

        ElseIf Password.Equals("") Then
            Password_Panel.BackColor = Color.Red
            value = False

        ElseIf Not Username.Equals("") And Not Password.Equals("") Then
            value = True

        End If
        Return value
    End Function

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Emptyfields()
    End Sub

    Private Sub UserName_TextBox_TextChanged(sender As Object, e As EventArgs) Handles UserName_TextBox.TextChanged

    End Sub
End Class
