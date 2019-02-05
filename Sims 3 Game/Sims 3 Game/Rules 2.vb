Public Class frmRules2

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click

        Me.Hide() 'hides form
        frmGameInterface.timerAge.Start()           ' the following code starts the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start()

    End Sub


End Class