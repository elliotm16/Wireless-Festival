<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnUsefulLinks = New System.Windows.Forms.Button()
        Me.btnWeather = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.btnActs = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSignOut
        '
        Me.btnSignOut.BackgroundImage = CType(resources.GetObject("btnSignOut.BackgroundImage"), System.Drawing.Image)
        Me.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(12, 289)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(60, 60)
        Me.btnSignOut.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnSignOut, "Sign out of your account")
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'btnUsefulLinks
        '
        Me.btnUsefulLinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsefulLinks.Location = New System.Drawing.Point(220, 110)
        Me.btnUsefulLinks.Name = "btnUsefulLinks"
        Me.btnUsefulLinks.Size = New System.Drawing.Size(120, 30)
        Me.btnUsefulLinks.TabIndex = 11
        Me.btnUsefulLinks.Text = "Useful Links"
        Me.ToolTip1.SetToolTip(Me.btnUsefulLinks, "Useful links for Wireless Festival")
        Me.btnUsefulLinks.UseVisualStyleBackColor = True
        '
        'btnWeather
        '
        Me.btnWeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeather.Location = New System.Drawing.Point(220, 160)
        Me.btnWeather.Name = "btnWeather"
        Me.btnWeather.Size = New System.Drawing.Size(120, 30)
        Me.btnWeather.TabIndex = 14
        Me.btnWeather.Text = "London Weather"
        Me.ToolTip1.SetToolTip(Me.btnWeather, "Check out the Weather in London")
        Me.btnWeather.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnItems
        '
        Me.btnItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.Location = New System.Drawing.Point(220, 60)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(120, 30)
        Me.btnItems.TabIndex = 12
        Me.btnItems.Text = "Items Taking"
        Me.ToolTip1.SetToolTip(Me.btnItems, "Track what items you are taking with you")
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(217, 9)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(155, 20)
        Me.lblDateTime.TabIndex = 16
        Me.lblDateTime.Text = "00/00/0000 00:00:00"
        Me.ToolTip1.SetToolTip(Me.lblDateTime, "Current Date and Time")
        '
        'btnActs
        '
        Me.btnActs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActs.Location = New System.Drawing.Point(220, 210)
        Me.btnActs.Name = "btnActs"
        Me.btnActs.Size = New System.Drawing.Size(120, 30)
        Me.btnActs.TabIndex = 17
        Me.btnActs.Text = "Acts"
        Me.ToolTip1.SetToolTip(Me.btnActs, "Create your act schedule")
        Me.btnActs.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.btnActs)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnWeather)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnUsefulLinks)
        Me.Controls.Add(Me.btnSignOut)
        Me.Name = "frmMainMenu"
        Me.Text = "Logged In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents btnUsefulLinks As System.Windows.Forms.Button
    Friend WithEvents btnWeather As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnItems As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents btnActs As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
