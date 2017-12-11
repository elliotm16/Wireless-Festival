Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmCreateAccount

    Dim ShowPassword As Boolean

    Private Sub btnCreateAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateAccount.Click

        Dim CustomersData() As String = File.ReadAllLines(Dir$("Details.txt"))

        Dim Validated As Boolean
        Validated = False

        If Validation(CustomersData) = True Then

            Dim sw As New System.IO.StreamWriter("Details.txt", True)

            sw.WriteLine(LSet(txtEmailAddress.Text, 32) & LSet(txtPassword1.Text, 32))

            sw.Close()

            MsgBox("Your account has been created.")

            txtEmailAddress.Text = ""
            txtPassword1.Text = ""
            txtPassword2.Text = ""

            frmSignIn.Show()
            Me.Hide()

        End If

    End Sub

    Public Function Validation(ByVal CustomersData)

        Dim PasswordReq As Boolean
        PasswordReq = True

        txtNumCharacters.ForeColor = Color.Black
        txtLettersNumbers.ForeColor = Color.Black
        txtBothCases.ForeColor = Color.Black

        ' Invalid email address

        Dim Pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        Dim ValidEmail As Match = Regex.Match(txtEmailAddress.Text, Pattern)

        If ValidEmail.Success = False Then

            MsgBox("You must enter a valid Email Address.")

            Return False

        End If

        ' Email address has already been used

        For i = 0 To UBound(CustomersData)

            If Trim(Mid(CustomersData(i), 1, 31)) = txtEmailAddress.Text Then

                MsgBox("An account has already been created using the Email Address you have entered.")

                Return False

            End If

        Next

        ' Passwords don't match

        If txtPassword1.Text <> txtPassword2.Text Then

            MsgBox("Password must match.")

            Return False

        End If

        ' Password is less than 8 characters

        If (txtPassword1.Text).Length < 8 Then

            txtNumCharacters.ForeColor = Color.DarkRed

            Return False

        End If

        ' Password doesn't contain at least one number

        Dim NumberFound As Boolean
        NumberFound = False

        For i = 0 To 9

            If (txtPassword1.Text).Contains(i) Then

                NumberFound = True

            End If

        Next

        If NumberFound = False Then

            txtLettersNumbers.ForeColor = Color.DarkRed

            Return False

        End If

        ' Password is all lowercase or uppercase

        If (txtPassword1.Text = (txtPassword1.Text).ToUpper) Or (txtPassword1.Text = (txtPassword1.Text).ToLower) Then

            txtBothCases.ForeColor = Color.DarkRed

            Return False

        End If

        ' Password contains the word password

        If ((txtPassword1.Text).ToLower).Contains("password") Then

            MsgBox("Common words like 'password' should not be in your password.")

            Return False

        End If

        Return True

    End Function

    Private Sub btnShowPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPassword.Click

        If ShowPassword = False Then

            txtPassword1.PasswordChar = ""
            txtPassword2.PasswordChar = ""

            ShowPassword = True

        Else

            txtPassword1.PasswordChar = "*"
            txtPassword2.PasswordChar = "*"

            ShowPassword = False

        End If

    End Sub

    Private Sub frmCreateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ShowPassword = False

    End Sub

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click

        Me.Hide()
        frmSignIn.Show()

    End Sub

End Class