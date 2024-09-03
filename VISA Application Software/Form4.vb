Public Class Form4
    Private ReadOnly ofdPreviousPassports As OpenFileDialog
    ' Method to validate the form
    Public Function ValidateForm() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Validate Bank Account Details
        If String.IsNullOrWhiteSpace(txtBankAccountDetails.Text) Then
            isValid = False
            errorMessage &= "Bank account details are required." & vbCrLf
        End If

        ' Validate Income Tax Returns (optional)
        ' No validation required if empty

        ' Validate Proof of Financial Resources
        If String.IsNullOrWhiteSpace(txtProofOfFinancialResources.Text) Then
            isValid = False
            errorMessage &= "Proof of financial resources is required." & vbCrLf
        End If

        ' Validate Medical Certificate (optional)
        ' No validation required if empty

        ' Validate Police Certificate (optional)
        ' No validation required if empty

        ' Validate Copies of Previous Visas (optional)
        ' No validation required if empty

        ' Validate Copies of Previous Passports (optional)
        ' No validation required if empty

        ' Validate Other Documents (optional)
        ' No validation required if empty

        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    ' Handlers for uploading files
    Private Sub btnUploadBankAccountDetails_Click(sender As Object, e As EventArgs) Handles btnUploadBankAccountDetails.Click
        UploadFile(ofdBankAccountDetails, txtBankAccountDetails)
    End Sub

    Private Sub btnUploadIncomeTaxReturns_Click(sender As Object, e As EventArgs) Handles btnUploadIncomeTaxReturns.Click
        UploadFile(ofdIncomeTaxReturns, txtIncomeTaxReturns)
    End Sub

    Private Sub btnUploadProofOfFinancialResources_Click(sender As Object, e As EventArgs) Handles btnUploadProofOfFinancialResources.Click
        UploadFile(ofdProofOfFinancialResources, txtProofOfFinancialResources)
    End Sub

    Private Sub btnUploadMedicalCertificate_Click(sender As Object, e As EventArgs) Handles btnUploadMedicalCertificate.Click
        UploadFile(ofdMedicalCertificate, txtMedicalCertificate)
    End Sub

    Private Sub btnUploadPoliceCertificate_Click(sender As Object, e As EventArgs) Handles btnUploadPoliceCertificate.Click
        UploadFile(ofdPoliceCertificate, txtPoliceCertificate)
    End Sub

    Private Sub btnUploadCharacterReferences_Click(sender As Object, e As EventArgs) Handles btnUploadCharacterReferences.Click
        UploadFile(ofdCharacterReferences, txtCharacterReferences)
    End Sub

    Private Sub btnUploadPreviousVisas_Click(sender As Object, e As EventArgs) Handles btnUploadPreviousVisas.Click
        UploadFile(ofdPreviousVisas, txtPreviousVisas)
    End Sub

    Private Sub btnUploadPreviousPassports_Click(sender As Object, e As EventArgs) Handles btnUploadPreviousPassports.Click
        UploadFile(ofdPreviousPassports, txtPreviousPassports)
    End Sub


    ' Common method to upload files
    Private Sub UploadFile(ofd As OpenFileDialog, textBox As TextBox)
        ofd.Filter = "PDF files (*.pdf)|*.pdf"
        If ofd.ShowDialog() = DialogResult.OK Then
            textBox.Text = ofd.FileName
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIncomeTaxReturns.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public diaPic As New OpenFileDialog
    Private Sub btnUploadPassportPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPassportPhoto.Click
        diaPic.Filter = "jpg, jpeg, png files (*.png,*.jpg,*.jpeg)|*.png;*.jpg;*.jpeg"
        If diaPic.ShowDialog() = DialogResult.OK Then
            picPassportPhoto.Image = Image.FromFile(diaPic.FileName)
        End If
    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub
End Class