Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        percent.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
        If ProgressBar1.Value = 15 Then
            Lbl_mgs.Text = "Loading. . ."
        End If
        If ProgressBar1.Value = 20 Then
            Lbl_mgs.Text = "Preparing Files. . ."
        End If
        If ProgressBar1.Value = 60 Then
            Lbl_mgs.Text = "Few Seconds to go. . ."
        End If
        If ProgressBar1.Value = 85 Then
            Lbl_mgs.Text = "Nice! We're Ready. . ."
        End If
        If ProgressBar1.Value = 100 Then
            Lbl_mgs.Text = "Done. . ."
            Me.Hide()
            User_Login.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()

    End Sub
End Class