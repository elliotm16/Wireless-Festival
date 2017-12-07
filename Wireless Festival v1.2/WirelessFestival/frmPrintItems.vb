Imports System.IO

Public Class frmPrintItems

    Dim FileLocation As String

    Private Sub PrintItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim EmailAddress As String

        EmailAddress = frmSignIn.txtEmailAddress.Text
        FileLocation = EmailAddress + "-Items.txt"

        Dim Items() As String = File.ReadAllLines(Dir$(FileLocation, True))

        For i = 0 To UBound(Items)

            lstItems.Items.Add(Trim(Mid(Items(i), 1, 26)))

        Next

    End Sub

End Class