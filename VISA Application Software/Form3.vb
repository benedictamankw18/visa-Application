Public Class Form3
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
    ' Method to validate the form
    Public Function ValidateForm() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Validate Passport Type
        If cmbPassportType.SelectedIndex = -1 Then
            isValid = False
            errorMessage &= "Passport type is required." & vbCrLf
        End If

        ' Validate Passport Issuance Date
        If dtpPassportIssuanceDate.Value >= dtpPassportExpirationDate.Value Then
            isValid = False
            errorMessage &= "Passport issuance date must be before expiration date." & vbCrLf
        End If

        ' Validate Father's Name
        If String.IsNullOrWhiteSpace(txtFatherName.Text) Or txtFatherName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Father's name is required." & vbCrLf
        End If

        ' Validate Mother's Name
        If String.IsNullOrWhiteSpace(txtMotherName.Text) Or txtMotherName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Mother's name is required." & vbCrLf
        End If

        ' Validate Educational Background
        If String.IsNullOrWhiteSpace(txtEducationalBackground.Text) Or txtEducationalBackground.Text.Trim.Length < 10 Then
            isValid = False
            errorMessage &= "Educational background is required." & vbCrLf
        End If



        ' Validate Employer's Name
        If String.IsNullOrWhiteSpace(txtEmployerName.Text) Or txtEmployerName.Text.Trim.Length < 3 Then
            isValid = False
            errorMessage &= "Employer's name is required." & vbCrLf
        End If

        ' Validate Employer's Address
        If String.IsNullOrWhiteSpace(txtEmployerAddress.Text) Or txtEmployerAddress.Text.Trim.Length < 2 Then
            isValid = False
            errorMessage &= "Employer's address is required." & vbCrLf
        End If

        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If txtPassportNumber.Text.Trim.Length < 8 And txtPassportNumber.Text.Trim.Length > 10 Then
            MessageBox.Show("Passport Number must be 8 to 12 character long.")
            Return False
        End If

        If String.IsNullOrEmpty(txtPassportNumber.Text) Then
            MessageBox.Show("Passport Number is required.")
            Return False
        End If
        Return isValid
    End Function

    Private Sub txtFatherName_TextChanged(sender As Object, e As EventArgs) Handles txtFatherName.TextChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassportNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPassportNumber.TextChanged

    End Sub

    Private Sub dtpPassportExpirationDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpPassportExpirationDate.ValueChanged

    End Sub

    Private Sub GunaGradient2Panel19_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel19.Paint

    End Sub

    Private Sub GunaLabel9_Click(sender As Object, e As EventArgs) Handles GunaLabel9.Click

    End Sub
End Class