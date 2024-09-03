Public Class Form1
    Public firsName As String
    Public LastName As String
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Public Function ValidateForm() As Boolean
        If String.IsNullOrEmpty(txtFirstName.Text) Or txtFirstName.Text.Trim.Length < 3 Then
            MessageBox.Show("First Name is required.")
            Return False
        Else
            firsName = txtFirstName.Text
        End If

        If String.IsNullOrEmpty(txtLastName.Text) Or txtLastName.Text.Trim.Length < 3 Then
            MessageBox.Show("Last Name is required.")
            Return False
        Else
            lastName = txtLastName.Text
        End If

        Dim today As DateTime = DateTime.Now
        Dim minDateOfBirth As DateTime = today.AddYears(-18)
        If dtpDOB.Value > minDateOfBirth Then
            MessageBox.Show("You must be at least 18 years old.")
            Return False
        End If

        If cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select a gender.")
            Return False
        End If

        If cmbNationality.SelectedIndex = -1 Then
            MessageBox.Show("Please select a nationality.")
            Return False
        End If
        Return True
    End Function

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpPassportExpiry_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFirstName_TextChanged_1(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub cmbNationality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNationality.SelectedIndexChanged

    End Sub
End Class
