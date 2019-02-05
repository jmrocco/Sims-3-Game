Public Class frmChooseSpouse
    Public spouse As Image 'spouse is an image
    Public spousename As String ' spouse name is text
    Private Sub picHusband1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHusband1.Click

        spouse = My.Resources.husband_1 'spouse is husband 1 
        spousename = "Andrew Welling" 'spouses name
        Me.Close() 'closes form
        frmGameInterface.timerAge.Start()                  ' the following code starts the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start()        ' ends here


        frmGameInterface.picSpouse.Visible = True ' spouse image becomes visible in game 
        frmGameInterface.picSpouse.SizeMode = PictureBoxSizeMode.Zoom ' picture zooms
        frmGameInterface.picSpouse.Image = spouse ' picture is set
        frmGameInterface.lblSpouseName.Visible = True ' name is now visible 
        frmGameInterface.picSpouse.BackColor = Color.LightSteelBlue ' backcolour changed 
        frmGameInterface.lblSpouseName.Text = spousename ' sets spouse name 

        frmGameInterface.btnChangeName.Visible = False ' action buttons become not visible 
        frmGameInterface.btnGetMarried.Visible = False ' action buttons become not visible 
        frmGameInterface.btnExitCityHall.Visible = False ' action buttons become not visible 
        frmGameInterface.btnWorkCityHall.Visible = False ' action buttons become not visible 

    End Sub

    Private Sub picHusband2_Click(sender As Object, e As EventArgs) Handles picHusband2.Click

        spouse = My.Resources.husband_2 'spouse is husband 2
        spousename = "Derek Gates" 'spouses name

        Me.Close() 'closes the form
        frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start() ' ends here


        frmGameInterface.picSpouse.Visible = True ' spouse image becomes visible in game 
        frmGameInterface.picSpouse.SizeMode = PictureBoxSizeMode.Zoom ' picture zooms
        frmGameInterface.picSpouse.Image = spouse 'spouse is set
        frmGameInterface.lblSpouseName.Visible = True 'spouse name visible 
        frmGameInterface.picSpouse.BackColor = Color.LightSteelBlue 'backcolour changed
        frmGameInterface.lblSpouseName.Text = spousename ' name set

        frmGameInterface.btnChangeName.Visible = False 'buttons hide
        frmGameInterface.btnGetMarried.Visible = False 'buttons hide
        frmGameInterface.btnExitCityHall.Visible = False ' buttons hide
        frmGameInterface.btnWorkCityHall.Visible = False ' buttons hide

    End Sub

    Private Sub picHusband3_Click(sender As Object, e As EventArgs) Handles picHusband3.Click

        spouse = My.Resources.husband_3 'spouse is husband 3
        spousename = "Jordan Gable" 'spouses name

        Me.Close() 'closes the form
        frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start() ' ends here


        frmGameInterface.picSpouse.Visible = True ' spouse image becomes visible in game 
        frmGameInterface.picSpouse.SizeMode = PictureBoxSizeMode.Zoom ' picture zooms
        frmGameInterface.picSpouse.Image = spouse 'spouse is set
        frmGameInterface.lblSpouseName.Visible = True ' name visible 
        frmGameInterface.picSpouse.BackColor = Color.LightSteelBlue ' backcolour changed
        frmGameInterface.lblSpouseName.Text = spousename ' spouse name set


        frmGameInterface.btnChangeName.Visible = False ' buttons not visible
        frmGameInterface.btnGetMarried.Visible = False ' buttons not visible 
        frmGameInterface.btnExitCityHall.Visible = False ' buttons not visible 
        frmGameInterface.btnWorkCityHall.Visible = False ' buttons not visible 

    End Sub

    Private Sub picWife1_Click(sender As Object, e As EventArgs) Handles picWife1.Click

        spouse = My.Resources.wife_1 'spouse is wife 1 
        spousename = "Jenna Hampton" 'spouses name

        Me.Close() 'closes the form
        frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start() ' ends here


        frmGameInterface.picSpouse.Visible = True ' spouse image becomes visible in game 
        frmGameInterface.picSpouse.SizeMode = PictureBoxSizeMode.Zoom ' picture zooms
        frmGameInterface.picSpouse.Image = spouse ' spouse set
        frmGameInterface.lblSpouseName.Visible = True ' name visible 
        frmGameInterface.picSpouse.BackColor = Color.LightSteelBlue ' backcolour changed 
        frmGameInterface.lblSpouseName.Text = spousename ' name set

        frmGameInterface.btnChangeName.Visible = False ' hides buttons
        frmGameInterface.btnGetMarried.Visible = False ' hides buttons
        frmGameInterface.btnExitCityHall.Visible = False ' hides buttons 
        frmGameInterface.btnWorkCityHall.Visible = False ' hides buttons 

    End Sub

    Private Sub picWife2_Click(sender As Object, e As EventArgs) Handles picWife2.Click

        spouse = My.Resources.wife_2 'spouse is wife 1 
        spousename = "Elena Jones" 'spouses name

        Me.Close() 'closes the form
        frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start() ' ends here


        frmGameInterface.picSpouse.Visible = True ' spouse image becomes visible in game 
        frmGameInterface.picSpouse.SizeMode = PictureBoxSizeMode.Zoom ' zooms picture 
        frmGameInterface.picSpouse.Image = spouse ' sets spouse 
        frmGameInterface.lblSpouseName.Visible = True ' sets name to visible 
        frmGameInterface.picSpouse.BackColor = Color.LightSteelBlue ' backcolour changed 
        frmGameInterface.lblSpouseName.Text = spousename ' spouse name set

        frmGameInterface.btnChangeName.Visible = False ' buttons hide
        frmGameInterface.btnGetMarried.Visible = False ' buttons hide
        frmGameInterface.btnExitCityHall.Visible = False ' buttons hide
        frmGameInterface.btnWorkCityHall.Visible = False ' buttons hide 

    End Sub

    Private Sub picWfie3_Click(sender As Object, e As EventArgs) Handles picWfie3.Click

        spouse = My.Resources.wife_3 'spouse is wife 1 
        spousename = "Sophia Laurent" 'spouses name

        Me.Close() 'closes the form
        frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
        frmGameInterface.timerBladder.Start()
        frmGameInterface.timerEnergy.Start()
        frmGameInterface.timerHunger.Start()
        frmGameInterface.timerHygiene.Start()
        frmGameInterface.timerTime.Start()
        frmGameInterface.timerPlayerMove.Start() ' ends here


        frmGameInterface.picSpouse.Visible = True ' spouse image becomes visible in game 
        frmGameInterface.picSpouse.SizeMode = PictureBoxSizeMode.Zoom 'picture zooms
        frmGameInterface.picSpouse.Image = spouse ' spouse set
        frmGameInterface.lblSpouseName.Visible = True ' name visible 
        frmGameInterface.picSpouse.BackColor = Color.LightSteelBlue ' backcolour set
        frmGameInterface.lblSpouseName.Text = spousename ' name set

        frmGameInterface.btnChangeName.Visible = False ' buttons not visble
        frmGameInterface.btnGetMarried.Visible = False ' buttons not visible 
        frmGameInterface.btnExitCityHall.Visible = False ' buttons not visible
        frmGameInterface.btnWorkCityHall.Visible = False ' buttons not visible 

    End Sub
End Class