Imports MySql.Data.MySqlClient
Imports System.IO

Public Class MainForm
    Private currentFormIndex As Integer = 0
    Private childForms As List(Of Form)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True

        ' Initialize the list of child forms
        childForms = New List(Of Form)()
        childForms.Add(New Form1())
        childForms.Add(New Form2())
        childForms.Add(New Form3())
        childForms.Add(New Form4())
        ' Add other forms here...

        ' Set up each form
        For Each form As Form In childForms
            form.MdiParent = Me
            form.FormBorderStyle = FormBorderStyle.None
            form.TopLevel = False
            form.Anchor = AnchorStyles.None
            form.Size = New Size(595, 548)
        Next

        ' Show the first form
        ShowChildForm(currentFormIndex)
        UpdateButtons()

        btnNext.BackColor = Color.Transparent
        btnPrevious.BackColor = Color.Transparent
        btnSubmit.BackColor = Color.Transparent
        '  btnNext.Anchor = AnchorStyles.None
        ' btnPrevious.Anchor = AnchorStyles.None
        'btnSubmit.Anchor = AnchorStyles.None
    End Sub

    Private Sub ShowChildForm(index As Integer)
        For Each form As Form In childForms
            form.Hide()
        Next

        Dim formToShow As Form = childForms(index)
        Me.LayoutMdi(MdiLayout.Cascade)
        PositionChildForm(formToShow)
        formToShow.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If ValidateCurrentForm() Then
            currentFormIndex += 1
            ShowChildForm(currentFormIndex)
            UpdateButtons()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentFormIndex > 0 Then
            currentFormIndex -= 1
            ShowChildForm(currentFormIndex)
            UpdateButtons()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            If ValidateCurrentForm() Then

                Dim firstName, LastName, gender, nationality, phoneNumber, email, Address, DestinationCountry, PurposeOfTravel, TravelPlan As String
                Dim PassportType, PassportNumber, FatherName, MotherName, ChildrenName, SpouseName, EducationBackground, CurrentOccupation As String
                Dim EmployerName, EmployerAddress As String
                Dim DOB, enrty, exitDate, PassportDate, ExpiryDate As Date
                '   Dim bankAccountDetail, incomeTaxReturn, ProofOfFinance, MedicalCert, PoliceCert, CharacterReference, CopyOfPreviousVisa, CopyOfPreviousPassport, ProfilePic As Byte()
                MsgBox(Form2.txtEmailAddress.Text)
                firstName = Form1.txtFirstName.Text
                LastName = Form1.txtLastName.Text
                gender = Form1.cmbGender.Text
                nationality = Form1.cmbNationality.Text
                phoneNumber = Form2.txtPhoneNumber.Text
                email = Form2.txtEmailAddress.Text
                Address = Form2.txtAddress.Text
                DestinationCountry = Form2.cmbDestinationCountry.Text
                PurposeOfTravel = Form2.txtPurposeOfTravel.Text
                TravelPlan = Form2.txtFlightItinerary.Text
                PassportType = Form3.cmbPassportType.Text
                PassportNumber = Form3.txtPassportNumber.Text
                FatherName = Form3.txtFatherName.Text
                MotherName = Form3.txtMotherName.Text
                ChildrenName = Form3.txtChildrenName.Text
                SpouseName = Form3.txtSpouseName.Text
                EducationBackground = Form3.txtEducationalBackground.Text
                CurrentOccupation = Form3.cmbCurrentOccupation.Text
                EmployerName = Form3.txtEmployerName.Text
                EmployerAddress = Form3.txtEmployerAddress.Text
                DOB = Form1.dtpDOB.Value
                enrty = Form2.dtpEntryDate.Value
                exitDate = Form2.dtpExitDate.Value
                ExpiryDate = Form3.dtpPassportExpirationDate.Value
                PassportDate = Form3.dtpPassportIssuanceDate.Value

                'ProfilePic = File.ReadAllBytes(Form4.diaPic.FileName)
                'bankAccountDetail = File.ReadAllBytes(Form4.txtBankAccountDetails.Text)
                'incomeTaxReturn = File.ReadAllBytes(Form4.txtIncomeTaxReturns.Text)
                'ProofOfFinance = File.ReadAllBytes(Form4.txtProofOfFinancialResources.Text)
                'MedicalCert = File.ReadAllBytes(Form4.txtMedicalCertificate.Text)
                'PoliceCert = File.ReadAllBytes(Form4.txtPoliceCertificate.Text)
                'CharacterReference = File.ReadAllBytes(Form4.txtCharacterReferences.Text)
                'CopyOfPreviousVisa = File.ReadAllBytes(Form4.txtPreviousVisas.Text)
                'CopyOfPreviousPassport = File.ReadAllBytes(Form4.txtPreviousPassports.Text)



                Using con As New MySqlConnection(My.Settings.conStr)
                    con.Open()
                    Dim query = "SELECT * FROM `signup` where id = @id and `FName`= @FName and `LName`= @LName;"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", Login1.id)
                        cmd.Parameters.AddWithValue("@FName", firstName)
                        cmd.Parameters.AddWithValue("@LName", LastName)
                        Dim dr = cmd.ExecuteReader()
                        While dr.HasRows
                            MessageBox.Show("Has Row")
                        End While
                    End Using
                End Using
                'MessageBox.Show("Form Submitted!")
                ' Add your submit logic here
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ValidateCurrentForm() As Boolean
        Dim currentForm As Form = childForms(currentFormIndex)
        If TypeOf currentForm Is Form1 Then
            Return DirectCast(currentForm, Form1).ValidateForm()
        ElseIf TypeOf currentForm Is Form2 Then
            Return DirectCast(currentForm, Form2).ValidateForm()
        ElseIf TypeOf currentForm Is Form3 Then
            Return DirectCast(currentForm, Form3).ValidateForm()
        ElseIf TypeOf currentForm Is Form4 Then
            Return DirectCast(currentForm, Form4).ValidateForm()
        End If

        ' Add similar checks for other forms
        Return True
    End Function


    Private Sub PositionChildForm(form As Form)
        form.StartPosition = FormStartPosition.CenterParent
        form.Anchor = AnchorStyles.None
        form.Location = New Point(136, 26)
    End Sub

    Private Sub UpdateButtons()
        btnPrevious.Enabled = currentFormIndex > 0
        btnNext.Visible = currentFormIndex < childForms.Count - 1
        btnSubmit.Visible = currentFormIndex = childForms.Count - 1
        btnNext.BackColor = Color.Transparent
        btnPrevious.BackColor = Color.Transparent
        btnSubmit.BackColor = Color.Transparent
        'btnNext.Anchor = AnchorStyles.None
        ' btnPrevious.Anchor = AnchorStyles.None
        '  btnSubmit.Anchor = AnchorStyles.None
    End Sub

End Class


