Imports System.IO

Public Class frmCreateAccount

    Private Sub btnSignIn_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateAccount.Click

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

    Public Function Validation(CustomersData)

        Dim PasswordReq As Boolean
        PasswordReq = True

        txtNumCharacters.ForeColor = Color.Black
        txtLettersNumbers.ForeColor = Color.Black
        txtBothCases.ForeColor = Color.Black

        ' Email address doesn't contain '@' and '.'

        If (txtEmailAddress.Text).Contains("@") = False Or (txtEmailAddress.Text).Contains(".") = False Then

            MsgBox("Your Email Address must contain the '@' and '.' symbols.")

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

            PasswordRequirements()

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

            PasswordRequirements()

            Return False

        End If

        ' Password is all lowercase or uppercase

        If (txtPassword1.Text = (txtPassword1.Text).ToUpper) Or (txtPassword1.Text = (txtPassword1.Text).ToLower) Then

            txtBothCases.ForeColor = Color.DarkRed

            PasswordRequirements()

            Return False

        End If

        ' Password contains the word password

        If ((txtPassword1.Text).ToLower).Contains("password") Then

            MsgBox("Common words like 'password' should not be in your password.")

            Return False

        End If

        Return True

    End Function

    Public Sub PasswordRequirements()

        txtPassword1.ForeColor = Color.DarkRed
        txtPassword2.ForeColor = Color.DarkRed

    End Sub

End Class