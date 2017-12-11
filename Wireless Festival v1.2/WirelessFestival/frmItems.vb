Imports System.IO

Public Class frmItems

    Dim FileLocation As String

    Private Sub frmItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim EmailAddress As String

        EmailAddress = frmSignIn.txtEmailAddress.Text
        FileLocation = EmailAddress + "-Items.txt"

        If Dir$(FileLocation) = "" Then

            Dim sw As New StreamWriter(FileLocation, True)
            sw.Close()

        End If

        lstItems.MultiColumn = True
        lstItems.SelectionMode = SelectionMode.MultiExtended

        UpdateItems()

    End Sub

    Private Sub btnAddItem_Click(sender As System.Object, e As System.EventArgs) Handles btnAddItem.Click

        Dim sw As New StreamWriter(FileLocation, True)

        If lstItems.Items.Contains(txtItem.Text) Then

            MsgBox("hi")

            Dim PreviousQuantity As Integer

            PreviousQuantity = lstItems.Items.Item(txtItem.Text).Substring(0, 1)

            lstItems.Items.Add(lstItems.SelectedItem.Replace(PreviousQuantity, PreviousQuantity + 1))

            lstItems.Items.Remove(lstItems.SelectedItem)

        End If

        If txtItem.Text = "" Then

            MsgBox("The Item textbox must not be left blank.")

        ElseIf updAddQuantity.Value = 0 Then

            MsgBox("The Item Quantity must not be zero.")

        Else

            sw.WriteLine(updAddQuantity.Value & "x " & txtItem.Text)

            sw.Close()

            UpdateItems()

        End If

        sw.Close()

        txtItem.Text = ""
        updAddQuantity.Value = 1

    End Sub

    Private Sub btnRemoveItem_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveItem.Click

        lstItems.Items.Remove(lstItems.SelectedItem)

        My.Computer.FileSystem.DeleteFile(FileLocation)

        Dim sw As New StreamWriter(FileLocation, True)

        For i = 0 To (lstItems.Items.Count - 1)

            sw.WriteLine(lstItems.Items.Item(i))

        Next

        sw.Close()

    End Sub

    Private Sub btnEditQuantity_Click(sender As System.Object, e As System.EventArgs) Handles btnEditQuantity.Click

        Dim Items() As String = File.ReadAllLines(Dir$(FileLocation))

        Dim PreviousQuantity As Integer

        PreviousQuantity = (lstItems.SelectedItem).Substring(0, 1)

        lstItems.Items.Add(lstItems.SelectedItem.Replace(PreviousQuantity, updEditQuantity.Value))

        lstItems.Items.Remove(lstItems.SelectedItem)

    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click

        txtItem.Text = ""

        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Public Sub UpdateItems()

        Dim Items() As String = File.ReadAllLines(Dir$(FileLocation, True))

        lstItems.Items.Clear()

        For i = 0 To UBound(Items)

            lstItems.Items.Add(Trim(Mid(Items(i), 1, 26)))

        Next

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDocument1.Print()

        End If

    End Sub

End Class