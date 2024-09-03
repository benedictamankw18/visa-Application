Imports System.Text.RegularExpressions
Imports Guna.UI.WinForms

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    ' Method to validate the form
    Public Function ValidateForm() As Boolean
        Dim isValid As Boolean = True
        Dim errorMessage As String = ""

        ' Validate Address
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            isValid = False
            errorMessage &= "Address is required." & vbCrLf
        End If

        ' Validate Phone Number
        If Not IsValidPhoneNumber(txtPhoneNumber.Text) Then
            isValid = False
            errorMessage &= "Invalid phone number." & vbCrLf
        End If

        ' Validate Email Address
        If Not IsValidEmail(txtEmailAddress.Text) Then
            isValid = False
            errorMessage &= "Invalid email address." & vbCrLf
        End If

        ' Validate Purpose of Travel
        If String.IsNullOrWhiteSpace(txtPurposeOfTravel.Text) And txtPurposeOfTravel.Text.Trim.Length > 15 Then
            isValid = False
            errorMessage &= "Purpose of travel is required." & vbNewLine & "Must be 15 or more character long" & vbCrLf
        End If

        ' Validate Destination Country
        If cmbDestinationCountry.SelectedIndex = -1 Then
            isValid = False
            errorMessage &= "Destination country is required." & vbCrLf
        End If

        ' Validate Entry and Exit Dates
        If dtpEntryDate.Value >= dtpExitDate.Value Then
            isValid = False
            errorMessage &= "Entry date must be before exit date." & vbCrLf
        End If

        ' Validate Flight Itinerary
        If String.IsNullOrWhiteSpace(txtFlightItinerary.Text) Then
            isValid = False
            errorMessage &= "Flight itinerary is required." & vbCrLf
        End If

        If txtFlightItinerary.Text.Trim.Length < 4 Then
            isValid = False
            errorMessage &= "Flight itinerary should be more than 3 letters." & vbCrLf
        End If
        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    ' Helper method to validate phone number
    Private Function IsValidPhoneNumber(phone As String) As Boolean
        ' Simple regex for phone number validation (international format included)
        Dim phonePattern As String = "^\+?\d{1,14}$"
        Return Regex.IsMatch(phone, phonePattern)
    End Function

    ' Helper method to validate email address
    Private Function IsValidEmail(email As String) As Boolean
        ' Simple regex for email validation
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    Private Sub txtPurposeOfTravel_TextChanged(sender As Object, e As EventArgs) Handles txtPurposeOfTravel.TextChanged

    End Sub

    Private Sub txtPurposeOfTravel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurposeOfTravel.KeyPress
        Dim txtPurposeOfTravel As GunaTextBox = CType(sender, GunaTextBox)

        If Char.IsControl(e.KeyChar) Or e.KeyChar = " "c Then
            Return
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            'If txtPurposeOfTravel.Text.Length < 9 Then
            e.Handled = True
            ' End If
        End If
        If txtPurposeOfTravel.Text.Length >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You must enter at most 50 characters.")
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFlightItinerary_TextChanged(sender As Object, e As EventArgs) Handles txtFlightItinerary.TextChanged

    End Sub
    Private Sub txtFlightItinerary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFlightItinerary.KeyPress
        Dim txtFlightItinerary As GunaTextBox = CType(sender, GunaTextBox)

        If Char.IsControl(e.KeyChar) Or e.KeyChar = " "c Then
            Return
        End If

        If Not Char.IsLetter(e.KeyChar) Then
            'If txtPurposeOfTravel.Text.Length < 9 Then
            e.Handled = True
            ' End If
        End If
        If txtFlightItinerary.Text.Length >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You must enter at most 50 characters.")
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub

    Private Sub dtpEntryDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEntryDate.ValueChanged

    End Sub
End Class