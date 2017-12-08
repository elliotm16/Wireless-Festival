Imports System.IO

Public Class frmActs

    Private Sub frmActs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim FileLocation As String
        Dim EmailAddress As String

        EmailAddress = frmSignIn.txtEmailAddress.Text
        FileLocation = EmailAddress + "-Acts.txt"

        If Dir$(FileLocation) = "" Then

            Dim sw As New StreamWriter(FileLocation, True)
            sw.Close()

        End If

    End Sub

    Private Sub cboDays_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDays.SelectedIndexChanged

        Dim FileLocation As String

        FileLocation = cboDays.SelectedItem + ".txt"

        Dim Acts() As String = File.ReadAllLines(Dir$(FileLocation, True))

        cboActs.Items.Clear()

        For i = 0 To UBound(Acts)

            cboActs.Items.Add(Acts(i))

        Next

    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click

        cboDays.Text = ""
        cboActs.Text = ""

        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim FileLocation As String
        Dim EmailAddress As String

        EmailAddress = frmSignIn.txtEmailAddress.Text
        FileLocation = EmailAddress + "-Acts.txt"

        Dim sw As New StreamWriter(FileLocation, True)

        If cboDays.Text = "" Or cboActs.Text = "" Then

            MsgBox("The dropdown boxes must not be left blank.")

        Else

            sw.WriteLine(cboActs.Text)

        End If

        sw.Close()

        cboActs.Text = ""

    End Sub

End Class