Public Class frmEgypt

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "\Resources\Egypt.mp4" 'plays the egypt vacation video
        btnPlay.Visible = False ' hides the play button
        btnGoHome.Visible = True ' makes the go home button visible 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoHome.Click
      

        Me.Hide() ' hides the form  
        frmGameInterface.timerAge.Start() '    the following code starts all the timers in the gameinterface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start()
    End Sub
End Class