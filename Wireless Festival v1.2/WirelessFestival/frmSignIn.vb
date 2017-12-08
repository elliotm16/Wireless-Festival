Imports System.IO

Public Class frmSignIn

    Dim ShowPassword As Boolean

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click

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

    Private Sub btnCreateAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateAccount.Click

        frmCreateAccount.Show()
        Me.Hide()

    End Sub

    Private Sub btnShowPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPassword.Click

        If ShowPassword = False Then

            txtPassword.PasswordChar = ""

            ShowPassword = True

        Else

            txtPassword.PasswordChar = "*"

            ShowPassword = False

        End If

    End Sub

    Private Sub frmSignIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ShowPassword = False

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        If MessageBox.Show("Would you like to Exit?", "Wireless Festival Planner", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

End Class