Public Class frmMainMenu

    Private Sub btnSignOut_Click(sender As System.Object, e As System.EventArgs) Handles btnSignOut.Click

        If MessageBox.Show("Are you sure you want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            frmSignIn.Show()
            Me.Hide()

        End If

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

    Private Sub btnActs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActs.Click

        frmActs.Show()
        Me.Hide()

    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim msg As String

        Dim secondDate As Date

        secondDate = #7/6/2018#

        msg = "Days until Wireless 2018: " & DateDiff(DateInterval.Day, Now, secondDate)

        lblDateTime.Text = msg.ToString

    End Sub

End Class