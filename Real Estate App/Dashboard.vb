Public Class Dashboard


    Private Sub btnNavigation_Click(sender As Object, e As EventArgs) Handles btnNavigation.Click
        If pnlPersonalInformation.Visible Then
            pnlPersonalInformation.Visible = False
            pnlNationalInformation.Visible = True
            btnNavigation.Text = "Back"
            lblHeading.Text = "National Information"
        Else
            pnlPersonalInformation.Visible = True
            pnlNationalInformation.Visible = False
            btnNavigation.Text = "Next"
            lblHeading.Text = "Personal Information"
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        pBoxProfilePicture.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Me.Hide()
        frmVisaDateAppoint.Show()
    End Sub
End Class


