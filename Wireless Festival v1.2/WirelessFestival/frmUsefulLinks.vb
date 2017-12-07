Public Class frmUsefulLinks

    Private Sub btnWebsite_Click(sender As System.Object, e As System.EventArgs) Handles btnWebsite.Click

        System.Diagnostics.Process.Start("http://www.wirelessfestival.co.uk")

    End Sub

    Private Sub btnWikipedia_Click(sender As System.Object, e As System.EventArgs) Handles btnWikipedia.Click

        System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Wireless_Festival")

    End Sub

    Private Sub btnFacebook_Click(sender As System.Object, e As System.EventArgs) Handles btnFacebook.Click

        System.Diagnostics.Process.Start("https://www.facebook.com/WirelessFestival")

    End Sub

    Private Sub btnTwitter_Click(sender As System.Object, e As System.EventArgs) Handles btnTwitter.Click

        System.Diagnostics.Process.Start("https://twitter.com/WirelessFest?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor")

    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub frmFurtherInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class