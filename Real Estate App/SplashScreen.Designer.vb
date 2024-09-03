<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.Lbl_loading = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Lbl_mgs = New System.Windows.Forms.Label()
        Me.percent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbl_loading
        '
        Me.Lbl_loading.AutoSize = True
        Me.Lbl_loading.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_loading.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_loading.Location = New System.Drawing.Point(257, 360)
        Me.Lbl_loading.Name = "Lbl_loading"
        Me.Lbl_loading.Size = New System.Drawing.Size(70, 22)
        Me.Lbl_loading.TabIndex = 0
        Me.Lbl_loading.Text = "Loading...."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(73, 385)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(500, 12)
        Me.ProgressBar1.TabIndex = 1
        '
        'Lbl_mgs
        '
        Me.Lbl_mgs.AutoSize = True
        Me.Lbl_mgs.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_mgs.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mgs.ForeColor = System.Drawing.Color.Red
        Me.Lbl_mgs.Location = New System.Drawing.Point(258, 400)
        Me.Lbl_mgs.Name = "Lbl_mgs"
        Me.Lbl_mgs.Size = New System.Drawing.Size(75, 19)
        Me.Lbl_mgs.TabIndex = 2
        Me.Lbl_mgs.Text = "Processing..."
        '
        'percent
        '
        Me.percent.AutoSize = True
        Me.percent.BackColor = System.Drawing.Color.Transparent
        Me.percent.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percent.Location = New System.Drawing.Point(315, 361)
        Me.percent.Name = "percent"
        Me.percent.Size = New System.Drawing.Size(34, 22)
        Me.percent.TabIndex = 3
        Me.percent.Text = "000"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.percent)
        Me.Controls.Add(Me.Lbl_mgs)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Lbl_loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_loading As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Lbl_mgs As Label
    Friend WithEvents percent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
