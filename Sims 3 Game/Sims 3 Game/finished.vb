Public Class frmFinished
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Application.Exit() ' closes the form
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        Me.Hide() 'hides the form
        frmGameInterface.timerAge.Start()             ' the following code starts all of the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start()

    End Sub
End Class