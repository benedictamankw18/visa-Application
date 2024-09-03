<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl = New Guna.UI.WinForms.GunaLabel()
        Me.Firstnamelbl = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaGradient2Panel4 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.lastnamelbl = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel5 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.dtpDOB = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaGradient2Panel6 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.dateofbirthlbl = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel7 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.cmbGender = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaGradient2Panel8 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel9 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.cmbNationality = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaGradient2Panel10 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.GunaGradient2Panel3.SuspendLayout()
        Me.GunaGradient2Panel4.SuspendLayout()
        Me.GunaGradient2Panel5.SuspendLayout()
        Me.GunaGradient2Panel6.SuspendLayout()
        Me.GunaGradient2Panel7.SuspendLayout()
        Me.GunaGradient2Panel8.SuspendLayout()
        Me.GunaGradient2Panel9.SuspendLayout()
        Me.GunaGradient2Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(149, 77)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(288, 37)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Personal information"
        '
        'Firstnamelbl
        '
        Me.Firstnamelbl.AutoSize = True
        Me.Firstnamelbl.BackColor = System.Drawing.Color.Transparent
        Me.Firstnamelbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstnamelbl.ForeColor = System.Drawing.Color.Black
        Me.Firstnamelbl.Location = New System.Drawing.Point(14, 0)
        Me.Firstnamelbl.Name = "Firstnamelbl"
        Me.Firstnamelbl.Size = New System.Drawing.Size(79, 21)
        Me.Firstnamelbl.TabIndex = 2
        Me.Firstnamelbl.Text = "Firstname"
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.Firstnamelbl)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(15, 12)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Radius = 10
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(105, 25)
        Me.GunaGradient2Panel1.TabIndex = 3
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.txtFirstName)
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaGradient2Panel1)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(45, 128)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Radius = 25
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(493, 46)
        Me.GunaGradient2Panel2.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColor = System.Drawing.Color.DimGray
        Me.txtFirstName.BorderRadius = 10
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.Parent = Me.txtFirstName
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FillColor = System.Drawing.Color.DarkGray
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.FocusedState.Parent = Me.txtFirstName
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.HoverState.Parent = Me.txtFirstName
        Me.txtFirstName.Location = New System.Drawing.Point(141, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.ShadowDecoration.Parent = Me.txtFirstName
        Me.txtFirstName.Size = New System.Drawing.Size(340, 32)
        Me.txtFirstName.TabIndex = 4
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.Controls.Add(Me.txtLastName)
        Me.GunaGradient2Panel3.Controls.Add(Me.GunaGradient2Panel4)
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(45, 192)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Radius = 25
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(493, 46)
        Me.GunaGradient2Panel3.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.BorderColor = System.Drawing.Color.DimGray
        Me.txtLastName.BorderRadius = 10
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.Parent = Me.txtLastName
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FillColor = System.Drawing.Color.DarkGray
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.FocusedState.Parent = Me.txtLastName
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.HoverState.Parent = Me.txtLastName
        Me.txtLastName.Location = New System.Drawing.Point(141, 8)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.ShadowDecoration.Parent = Me.txtLastName
        Me.txtLastName.Size = New System.Drawing.Size(340, 32)
        Me.txtLastName.TabIndex = 5
        '
        'GunaGradient2Panel4
        '
        Me.GunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel4.Controls.Add(Me.lastnamelbl)
        Me.GunaGradient2Panel4.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel4.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel4.Location = New System.Drawing.Point(15, 12)
        Me.GunaGradient2Panel4.Name = "GunaGradient2Panel4"
        Me.GunaGradient2Panel4.Radius = 10
        Me.GunaGradient2Panel4.Size = New System.Drawing.Size(105, 25)
        Me.GunaGradient2Panel4.TabIndex = 3
        '
        'lastnamelbl
        '
        Me.lastnamelbl.AutoSize = True
        Me.lastnamelbl.BackColor = System.Drawing.Color.Transparent
        Me.lastnamelbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnamelbl.ForeColor = System.Drawing.Color.Black
        Me.lastnamelbl.Location = New System.Drawing.Point(14, 2)
        Me.lastnamelbl.Name = "lastnamelbl"
        Me.lastnamelbl.Size = New System.Drawing.Size(77, 21)
        Me.lastnamelbl.TabIndex = 2
        Me.lastnamelbl.Text = "Lastname"
        '
        'GunaGradient2Panel5
        '
        Me.GunaGradient2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel5.Controls.Add(Me.dtpDOB)
        Me.GunaGradient2Panel5.Controls.Add(Me.GunaGradient2Panel6)
        Me.GunaGradient2Panel5.GradientColor1 = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel5.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel5.Location = New System.Drawing.Point(48, 258)
        Me.GunaGradient2Panel5.Name = "GunaGradient2Panel5"
        Me.GunaGradient2Panel5.Radius = 25
        Me.GunaGradient2Panel5.Size = New System.Drawing.Size(493, 46)
        Me.GunaGradient2Panel5.TabIndex = 7
        '
        'dtpDOB
        '
        Me.dtpDOB.BackColor = System.Drawing.Color.Transparent
        Me.dtpDOB.BaseColor = System.Drawing.Color.White
        Me.dtpDOB.BorderColor = System.Drawing.Color.Magenta
        Me.dtpDOB.CustomFormat = Nothing
        Me.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDOB.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDOB.ForeColor = System.Drawing.Color.Black
        Me.dtpDOB.Location = New System.Drawing.Point(138, 10)
        Me.dtpDOB.MaxDate = New Date(2029, 12, 25, 23, 59, 59, 0)
        Me.dtpDOB.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpDOB.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDOB.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDOB.OnPressedColor = System.Drawing.Color.Black
        Me.dtpDOB.Radius = 10
        Me.dtpDOB.Size = New System.Drawing.Size(343, 27)
        Me.dtpDOB.TabIndex = 8
        Me.dtpDOB.Text = "Sunday, 21 July 2024"
        Me.dtpDOB.Value = New Date(2024, 7, 21, 22, 30, 19, 965)
        '
        'GunaGradient2Panel6
        '
        Me.GunaGradient2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel6.Controls.Add(Me.dateofbirthlbl)
        Me.GunaGradient2Panel6.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel6.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel6.Location = New System.Drawing.Point(15, 12)
        Me.GunaGradient2Panel6.Name = "GunaGradient2Panel6"
        Me.GunaGradient2Panel6.Radius = 10
        Me.GunaGradient2Panel6.Size = New System.Drawing.Size(105, 25)
        Me.GunaGradient2Panel6.TabIndex = 3
        '
        'dateofbirthlbl
        '
        Me.dateofbirthlbl.AutoSize = True
        Me.dateofbirthlbl.BackColor = System.Drawing.Color.Transparent
        Me.dateofbirthlbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateofbirthlbl.Location = New System.Drawing.Point(4, 2)
        Me.dateofbirthlbl.Name = "dateofbirthlbl"
        Me.dateofbirthlbl.Size = New System.Drawing.Size(97, 21)
        Me.dateofbirthlbl.TabIndex = 2
        Me.dateofbirthlbl.Text = "Date of birth"
        '
        'GunaGradient2Panel7
        '
        Me.GunaGradient2Panel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel7.Controls.Add(Me.cmbGender)
        Me.GunaGradient2Panel7.Controls.Add(Me.GunaGradient2Panel8)
        Me.GunaGradient2Panel7.GradientColor1 = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel7.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel7.Location = New System.Drawing.Point(48, 324)
        Me.GunaGradient2Panel7.Name = "GunaGradient2Panel7"
        Me.GunaGradient2Panel7.Radius = 25
        Me.GunaGradient2Panel7.Size = New System.Drawing.Size(493, 46)
        Me.GunaGradient2Panel7.TabIndex = 8
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.BaseColor = System.Drawing.Color.White
        Me.cmbGender.BorderColor = System.Drawing.Color.Magenta
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGender.ForeColor = System.Drawing.Color.Black
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male ", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(138, 12)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbGender.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbGender.Radius = 10
        Me.cmbGender.Size = New System.Drawing.Size(343, 26)
        Me.cmbGender.TabIndex = 9
        '
        'GunaGradient2Panel8
        '
        Me.GunaGradient2Panel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel8.Controls.Add(Me.GunaLabel1)
        Me.GunaGradient2Panel8.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel8.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel8.Location = New System.Drawing.Point(15, 12)
        Me.GunaGradient2Panel8.Name = "GunaGradient2Panel8"
        Me.GunaGradient2Panel8.Radius = 10
        Me.GunaGradient2Panel8.Size = New System.Drawing.Size(105, 25)
        Me.GunaGradient2Panel8.TabIndex = 3
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(22, 2)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(61, 21)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Gender"
        '
        'GunaGradient2Panel9
        '
        Me.GunaGradient2Panel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel9.Controls.Add(Me.cmbNationality)
        Me.GunaGradient2Panel9.Controls.Add(Me.GunaGradient2Panel10)
        Me.GunaGradient2Panel9.GradientColor1 = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel9.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel9.Location = New System.Drawing.Point(45, 390)
        Me.GunaGradient2Panel9.Name = "GunaGradient2Panel9"
        Me.GunaGradient2Panel9.Radius = 25
        Me.GunaGradient2Panel9.Size = New System.Drawing.Size(493, 46)
        Me.GunaGradient2Panel9.TabIndex = 9
        '
        'cmbNationality
        '
        Me.cmbNationality.BackColor = System.Drawing.Color.Transparent
        Me.cmbNationality.BaseColor = System.Drawing.Color.White
        Me.cmbNationality.BorderColor = System.Drawing.Color.Magenta
        Me.cmbNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNationality.FocusedColor = System.Drawing.Color.Empty
        Me.cmbNationality.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbNationality.ForeColor = System.Drawing.Color.Black
        Me.cmbNationality.FormattingEnabled = True
        Me.cmbNationality.Items.AddRange(New Object() {"Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguan", "Argentine", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Botswana", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Cambodian", "Cameroonian", "Canadian", "Central African", "Chadian", "Chilean", "ChineseColombian", "Comoran", "Congolese", "Costa Rican", "Côte d'Ivoire", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djiboutian", "Dominican", "Dutch", "Ecuadorian", "Egyptian", "Emirati", "English", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinean", "Guyanese", "Haitian", "Honduran", "Hungarian", "Icelandic", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Jamaican", "Japanese", "Jordanian", "Kazakhstan", "Kenyan", "Kiribati", "North Korean", "South Korean", "Kosovan", "Kuwaiti", "KyrgyzstaniLao", "Latvian", "Lebanese", "Liberian", "Libyan", "Lithuanian", "Luxembourgish", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivian", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monégasque", "Mongolian", "Montenegrin", "Moroccan", "Mozambican", "Namibian", "Nauruan", "Nepali", "New Zealander", "Nicaraguan", "Nigerian", "Nigerien", "North Macedonian", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Rwandan", "Saint Kitts and Nevis", "Saint Lucian", "Saint Vincent and the Grenadines", "Salvadoran", "Samoan", "San Marino", "Sao Tome and Principe", "Saudi Arabian", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Sint Maarten", "Slovak", "Slovenian", "Solomon Islands", "Somali", "South African", "South Sudanese", "Spanish", "Sri Lankan", "Sudanese", "Surinamese", "Swazi", "Swedish", "Swiss", "Syrian", "Tajikistani", "Tanzanian", "Thai", "Timorese", "Togolese", "Tongan", "Trinidadian and Tobagonian", "Tunisian", "Turkish", "Turkmenistan", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Vanuatuan", "Vatican City", "Venezuelan", "Vietnamese", "Yemeni", "Zambian", "Zimbabwean"})
        Me.cmbNationality.Location = New System.Drawing.Point(138, 12)
        Me.cmbNationality.Name = "cmbNationality"
        Me.cmbNationality.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNationality.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbNationality.Radius = 10
        Me.cmbNationality.Size = New System.Drawing.Size(343, 26)
        Me.cmbNationality.TabIndex = 9
        '
        'GunaGradient2Panel10
        '
        Me.GunaGradient2Panel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel10.Controls.Add(Me.GunaLabel2)
        Me.GunaGradient2Panel10.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel10.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel10.Location = New System.Drawing.Point(15, 12)
        Me.GunaGradient2Panel10.Name = "GunaGradient2Panel10"
        Me.GunaGradient2Panel10.Radius = 10
        Me.GunaGradient2Panel10.Size = New System.Drawing.Size(105, 25)
        Me.GunaGradient2Panel10.TabIndex = 3
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 2)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(86, 21)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Nationality"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(579, 509)
        Me.Controls.Add(Me.GunaGradient2Panel9)
        Me.Controls.Add(Me.GunaGradient2Panel7)
        Me.Controls.Add(Me.GunaGradient2Panel5)
        Me.Controls.Add(Me.GunaGradient2Panel3)
        Me.Controls.Add(Me.GunaGradient2Panel2)
        Me.Controls.Add(Me.lbl)
        Me.Name = "Form1"
        Me.Text = " "
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaGradient2Panel4.ResumeLayout(False)
        Me.GunaGradient2Panel4.PerformLayout()
        Me.GunaGradient2Panel5.ResumeLayout(False)
        Me.GunaGradient2Panel6.ResumeLayout(False)
        Me.GunaGradient2Panel6.PerformLayout()
        Me.GunaGradient2Panel7.ResumeLayout(False)
        Me.GunaGradient2Panel8.ResumeLayout(False)
        Me.GunaGradient2Panel8.PerformLayout()
        Me.GunaGradient2Panel9.ResumeLayout(False)
        Me.GunaGradient2Panel10.ResumeLayout(False)
        Me.GunaGradient2Panel10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Firstnamelbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel4 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents lastnamelbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel5 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel6 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents dateofbirthlbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel7 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel8 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel9 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel10 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Public WithEvents dtpDOB As Guna.UI.WinForms.GunaDateTimePicker
    Public WithEvents cmbGender As Guna.UI.WinForms.GunaComboBox
    Public WithEvents cmbNationality As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
End Class
