Public Class frmLoadingScreen

    Private Sub frmLoadingScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timerLoadingScreen.Start() 'timer starts
        My.Computer.Audio.Play(My.Resources.loading_screen_sound, AudioPlayMode.Background) 'starts music
    End Sub

    Private Sub timerLoadingScreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerLoadingScreen.Tick
        ProgressBar1.Increment(1) 'progress bar adds 1 tick per second

        If ProgressBar1.Value = ProgressBar1.Maximum Then ' if bar reaches maximum
            Me.Hide() 'this form will hide
            frmCas.Show() 'shows create character form
            timerLoadingScreen.Stop() 'stops timer
            My.Computer.Audio.Stop() 'stops music
        End If

    End Sub

End Class