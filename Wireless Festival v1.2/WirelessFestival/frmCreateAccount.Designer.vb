<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateAccount))
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumCharacters = New System.Windows.Forms.Label()
        Me.txtLettersNumbers = New System.Windows.Forms.Label()
        Me.txtBothCases = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.Location = New System.Drawing.Point(230, 293)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(120, 30)
        Me.btnCreateAccount.TabIndex = 5
        Me.btnCreateAccount.Text = "Create Account"
        Me.ToolTip1.SetToolTip(Me.btnCreateAccount, "Create your account")
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'txtPassword1
        '
        Me.txtPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword1.Location = New System.Drawing.Point(199, 117)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword1.Size = New System.Drawing.Size(150, 22)
        Me.txtPassword1.TabIndex = 2
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Location = New System.Drawing.Point(199, 68)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(150, 22)
        Me.txtEmailAddress.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Email Address"
        '
        'txtPassword2
        '
        Me.txtPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.Location = New System.Drawing.Point(199, 256)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(150, 22)
        Me.txtPassword2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Re-enter Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Your password must:"
        '
        'txtNumCharacters
        '
        Me.txtNumCharacters.AutoSize = True
        Me.txtNumCharacters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCharacters.Location = New System.Drawing.Point(59, 186)
        Me.txtNumCharacters.Name = "txtNumCharacters"
        Me.txtNumCharacters.Size = New System.Drawing.Size(157, 16)
        Me.txtNumCharacters.TabIndex = 14
        Me.txtNumCharacters.Text = " - Be at least 8 characters"
        '
        'txtLettersNumbers
        '
        Me.txtLettersNumbers.AutoSize = True
        Me.txtLettersNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLettersNumbers.Location = New System.Drawing.Point(59, 202)
        Me.txtLettersNumbers.Name = "txtLettersNumbers"
        Me.txtLettersNumbers.Size = New System.Drawing.Size(212, 16)
        Me.txtLettersNumbers.TabIndex = 15
        Me.txtLettersNumbers.Text = " - Contain both letters and numbers"
        '
        'txtBothCases
        '
        Me.txtBothCases.AutoSize = True
        Me.txtBothCases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBothCases.Location = New System.Drawing.Point(59, 218)
        Me.txtBothCases.Name = "txtBothCases"
        Me.txtBothCases.Size = New System.Drawing.Size(290, 16)
        Me.txtBothCases.TabIndex = 16
        Me.txtBothCases.Text = " - Contain both lowercase and uppercase letters"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Already have an account?"
        '
        'btnSignIn
        '
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.Location = New System.Drawing.Point(12, 369)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(120, 30)
        Me.btnSignIn.TabIndex = 6
        Me.btnSignIn.Text = "Sign In"
        Me.ToolTip1.SetToolTip(Me.btnSignIn, "Sign in to your account if you already have one")
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'btnShowPassword
        '
        Me.btnShowPassword.BackgroundImage = CType(resources.GetObject("btnShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassword.Location = New System.Drawing.Point(355, 108)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(40, 40)
        Me.btnShowPassword.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnShowPassword, "Sign in to your account")
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(434, 411)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtBothCases)
        Me.Controls.Add(Me.txtLettersNumbers)
        Me.Controls.Add(Me.txtNumCharacters)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.txtPassword1)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCreateAccount"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumCharacters As System.Windows.Forms.Label
    Friend WithEvents txtLettersNumbers As System.Windows.Forms.Label
    Friend WithEvents txtBothCases As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnShowPassword As System.Windows.Forms.Button
End Class
