Imports System.IO

Public Class frmSignIn

    Private Sub btnSignIn_Click(sender As System.Object, e As System.EventArgs) Handles btnSignIn.Click

        Dim Details() As String = File.ReadAllLines(Dir$("Details.txt"))

        Dim LoggedIn As Boolean
        LoggedIn = False

        For i = 0 To UBound(Details)

            If Trim(Mid(Details(i), 1, 31)) = txtEmailAddress.Text And Trim(Mid(Details(i), 32, 31)) = txtPassword.Text Then

                LoggedIn = True

                MsgBox("You are now logged in.")

                frmMainMenu.Show()
                Me.Hide()

                txtPassword.Text = ""

            End If

        Next

        If LoggedIn = False Then

            MsgBox("The Email Address and Password you have entered do not match.")

        End If

    End Sub

    Private Sub btnCreateAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateAccount.Click

        frmCreateAccount.Show()
        Me.Hide()

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked = False Then

            txtPassword.PasswordChar = "*"

        Else

            txtPassword.PasswordChar = ""

        End If

    End Sub

End Class