Public Class UpdateDashboard
    Public Sub childform(ByVal Panel As Form)
        Panel1.Controls.Clear()
        Panel.TopLevel = False
        Panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(Panel)
        Panel.Show()
    End Sub

    Private Sub btnOverview_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        childform(New Overview)
    End Sub

    Private Sub btnAppynow_Click(sender As Object, e As EventArgs) Handles btnAppynow.Click
        childform(New ApplyNow)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        childform(New Profile)
    End Sub

    Private Sub UpdateDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        childform(New Overview)
    End Sub

    Private Sub btnContactUs_Click(sender As Object, e As EventArgs) Handles btnContactUs.Click
        childform(ContactUs)
    End Sub
End Class