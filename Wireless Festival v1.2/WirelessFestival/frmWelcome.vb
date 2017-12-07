Imports System.IO

Public Class frmWelcome

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Dir$("Details.txt") = "" Then

            Dim sw As New StreamWriter("Details.txt", True)

            sw.WriteLine("")

            sw.Close()

        End If

    End Sub

    Private Sub btnSignIn_Click(sender As System.Object, e As System.EventArgs) Handles btnSignIn.Click

        frmSignIn.Show()
        Me.Hide()

    End Sub

    Private Sub btnCreateAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateAccount.Click

        frmCreateAccount.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblDateTime.Text = Now

    End Sub

End Class
