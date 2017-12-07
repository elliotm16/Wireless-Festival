Imports System.IO

Public Class frmActs

    Private Sub cboDays_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDays.SelectedIndexChanged

        Dim FileLocation As String

        FileLocation = cboDays.SelectedItem + ".txt"

        Dim Items() As String = File.ReadAllLines(Dir$(FileLocation, True))

        cboActs.Items.Clear()

        For i = 0 To UBound(Items)

            cboActs.Items.Add(Items(i))

        Next

    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub

End Class