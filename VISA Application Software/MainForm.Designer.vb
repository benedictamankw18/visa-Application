<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnSubmit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnNext = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnPrevious = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.AnimationHoverSpeed = 0.07!
        Me.btnSubmit.AnimationSpeed = 0.03!
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.BorderColor = System.Drawing.Color.Black
        Me.btnSubmit.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnSubmit.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSubmit.CheckedForeColor = System.Drawing.Color.White
        Me.btnSubmit.CheckedImage = Nothing
        Me.btnSubmit.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSubmit.FocusedColor = System.Drawing.Color.Empty
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Image = Nothing
        Me.btnSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSubmit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSubmit.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSubmit.Location = New System.Drawing.Point(5, 465)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSubmit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSubmit.OnHoverImage = Nothing
        Me.btnSubmit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSubmit.OnPressedColor = System.Drawing.Color.Black
        Me.btnSubmit.Radius = 10
        Me.btnSubmit.Size = New System.Drawing.Size(104, 29)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSubmit.UseTransfarantBackground = True
        '
        'btnNext
        '
        Me.btnNext.AnimationHoverSpeed = 0.07!
        Me.btnNext.AnimationSpeed = 0.03!
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.BorderColor = System.Drawing.Color.Black
        Me.btnNext.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnNext.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnNext.CheckedForeColor = System.Drawing.Color.Transparent
        Me.btnNext.CheckedImage = CType(resources.GetObject("btnNext.CheckedImage"), System.Drawing.Image)
        Me.btnNext.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNext.FocusedColor = System.Drawing.Color.Empty
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = Nothing
        Me.btnNext.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNext.LineColor = System.Drawing.Color.Magenta
        Me.btnNext.Location = New System.Drawing.Point(5, 395)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNext.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNext.OnHoverImage = Nothing
        Me.btnNext.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNext.OnPressedColor = System.Drawing.Color.Black
        Me.btnNext.Radius = 10
        Me.btnNext.Size = New System.Drawing.Size(104, 29)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnNext.UseTransfarantBackground = True
        '
        'btnPrevious
        '
        Me.btnPrevious.AnimationHoverSpeed = 0.07!
        Me.btnPrevious.AnimationSpeed = 0.03!
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.BorderColor = System.Drawing.Color.Black
        Me.btnPrevious.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnPrevious.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPrevious.CheckedForeColor = System.Drawing.Color.White
        Me.btnPrevious.CheckedImage = CType(resources.GetObject("btnPrevious.CheckedImage"), System.Drawing.Image)
        Me.btnPrevious.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrevious.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Image = Nothing
        Me.btnPrevious.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrevious.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrevious.Location = New System.Drawing.Point(5, 430)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrevious.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrevious.OnHoverImage = Nothing
        Me.btnPrevious.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPrevious.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrevious.Radius = 10
        Me.btnPrevious.Size = New System.Drawing.Size(104, 29)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPrevious.UseTransfarantBackground = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 579)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrevious As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnNext As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSubmit As Guna.UI.WinForms.GunaAdvenceButton
End Class
