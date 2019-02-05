Public Class frmChina

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "\Resources\China.mp4" ' plays the china vacation video in the media player
        btnPlay.Visible = False ' button play hides
        btnGoHome.Visible = True ' button go home becomes visible 
    End Sub

    Private Sub btnGoHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoHome.Click
  
        Me.Hide() ' hides the form
        frmGameInterface.timerAge.Start() ' the following code starts all the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start()
    End Sub
End Class