Public Class frmWelcome

    
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Me.Hide() ' hides form
        frmLoadingScreen.Show() ' shows the loading screen


    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show() ' shows the about form
    End Sub

    Private Sub RulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RulesToolStripMenuItem.Click
        frmRules.Show() ' shows the rules form
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Me.Hide() ' hides the form
        frmLoadingScreen.Show() ' brings the loading screen up

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() ' exits the form
    End Sub


End Class
