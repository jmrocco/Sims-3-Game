Public Class frmLoadingScreen2

    Private Sub Loading_Screen_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timerLoadingScreen2.Start() ' timer starts when it loads
        My.Computer.Audio.Play(My.Resources.loading_screen_sound, AudioPlayMode.Background) 'starts music
    End Sub
    Private Sub timerLoadingScreen2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerLoadingScreen2.Tick
        ProgressBar1.Increment(1) 'progress bar adds 1 tick per second

        If ProgressBar1.Value = ProgressBar1.Maximum Then ' if bar is maximum
            Me.Hide() 'this form will hide
            frmChooseJob.Show() ' show job form
            timerLoadingScreen2.Stop() ' stop timer
            My.Computer.Audio.Stop() 'stops music
        End If
    End Sub

End Class