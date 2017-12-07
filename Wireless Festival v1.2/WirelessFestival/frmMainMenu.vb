Public Class frmMainMenu

    Private Sub btnSignOut_Click(sender As System.Object, e As System.EventArgs) Handles btnSignOut.Click

        frmWelcome.Show()
        Me.Hide()

    End Sub

    Private Sub btnFurtherInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnUsefulLinks.Click

        frmUsefulLinks.Show()
        Me.Hide()

    End Sub

    Private Sub btnItems_Click(sender As System.Object, e As System.EventArgs) Handles btnItems.Click

        frmItems.Show()
        Me.Hide()

    End Sub

    Private Sub btnWeather_Click(sender As System.Object, e As System.EventArgs) Handles btnWeather.Click

        System.Diagnostics.Process.Start("http://www.metoffice.gov.uk/public/weather/forecast/gcpvj0v07")

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblDateTime.Text = Now

    End Sub

    Private Sub btnActs_Click(sender As System.Object, e As System.EventArgs) Handles btnActs.Click

        frmActs.Show()
        Me.Hide()

    End Sub

End Class