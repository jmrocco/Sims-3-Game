Public Class frmGameInterface

    Dim age As String = "Young Adult" ' age starts out as young adult
    Public timePlayed As String ' time played is set as a string
    Dim keyarray(1000) ' moving is set as a second movement
    Public money As Integer = 1000 ' money starts as 1000$
    Public job As String = frmChooseJob.job ' job will be whatever job was chosen in the job form
    Dim namechange As String 'name change is a string
    Public children As Integer ' children is an integer
    Dim housediamond As Integer = 0 ' house diamond count starts at 0
    Dim counter As Integer = 0 ' counter for time starts at 0
    Dim marriage As Integer = 0 ' marriage button clicks starts at 0
    Dim groceries As Integer = 0 ' grocery count
    Dim timeleft As Integer ' time left to go back to work
    Public playername As String ' player name is a string
    Dim lotterytimeleft As Integer ' time left for lottery
    Private Sub lblTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus() ' focuses on the form
        lblAgeByName.Text = "Age:" & " " & age ' displays age on form
        piccharacter.SizeMode = PictureBoxSizeMode.Zoom ' zooms your characters picture
        piccharacter.Image = frmCas.character ' displays your characters picture taken from another form
        playername = frmCas.firstname & " " & frmCas.lastname ' makes your name as a single string by joining first and last name 
        lblName.Text = lblName.Text & " " & playername ' displays your sims name on the form
        picPlayer.SizeMode = PictureBoxSizeMode.Zoom 'zooms your picture for the character that will move
        picPlayer.Image = frmCas.character ' sets your picture for your character that will move
        lblJob.Text = "Job: " & job ' displays  your job title on the form
        KeyPreview = True ' allows the keyboard arrows to be used in the game
        lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' money displayed on the form
        


    End Sub
    Private Sub timerAge_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAge.Tick
        prgBarAge.Increment(1) 'progress bar adds 1 tick per second

        If prgBarAge.Value = prgBarAge.Maximum And age = "Young Adult" Then ' if the age bar reaches max and you are a young adult 
            timerAge.Stop() ' all timers stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()

            MessageBox.Show("You've aged up to an adult!") ' message saying you've aged up
            timerAge.Start() ' timers start when messagebox gone
            timerBladder.Start()
            timerEnergy.Start()
            timerHunger.Start()
            timerHygiene.Start()
            timerTime.Start()

            age = "Adult" ' age updated to adult
            lblAgeByName.Text = "Age:" & " " & age ' age updated on the form
            prgBarAge.Value = 0 ' age resets to 0

        End If

        If prgBarAge.Value = prgBarAge.Maximum And age = "Adult" Then ' if you were an adult and age reaches max
            timerAge.Stop() ' timers stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()


            MessageBox.Show("You've aged up to an Elder!") ' message saying you've aged up
            timerAge.Start() ' timers start
            timerBladder.Start()
            timerEnergy.Start()
            timerHunger.Start()
            timerHygiene.Start()
            timerTime.Start()


            age = "Elder" ' age updated to elder
            lblAgeByName.Text = "Age:" & " " & age ' age updated on form
            prgBarAge.Value = 0 ' age bar resets to 0

        End If

        If prgBarAge.Value = prgBarAge.Maximum And age = "Elder" Then ' if you have reached age elder
            timerAge.Stop() ' all timers will stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background) ' death music will play
            MessageBox.Show("Congratulations on living a full and happy life. You died of old age but achieved all you could have ever wanted.") ' message saying you died of old age
            Me.Hide() ' form hides
            frmDead.Show() ' death form shows 
        End If

    End Sub


    Private Sub timerBladder_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBladder.Tick
        prgBarBladder.Increment(1) 'progress bar adds 1 tick per second

        lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' money on form resets
        If prgBarBladder.Value = prgBarBladder.Maximum Then ' if bladder reaches maximum
            timerBladder.Stop() ' timer bladder stops
            MessageBox.Show("Your sim is suffering from embarrassement from peeing on the floor in public. You lost $200.") ' message box shows
            money -= 200 ' money subtracts 200
            timerBladder.Stop() ' bladder timer stops
            prgBarBladder.Value = 0 ' bladder resets to 0
            timerBladder.Start() ' bladder timer starts

        End If


    End Sub

    Private Sub timerHunger_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHunger.Tick
        prgBarHunger.Increment(1) ' 'hunger increases by 1 

        If prgBarHunger.Value = prgBarHunger.Maximum Then 'if hunger reaches max
            timerAge.Stop() ' all timers stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background) ' death sound plays
            MessageBox.Show("You died from not eating.") ' message shows how you died
            Me.Hide()
            frmDead.Show()


        End If
    End Sub

    Private Sub timerHygiene_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHygiene.Tick
        prgHygiene.Increment(1) 'progress bar adds 1 tick per second


        If prgHygiene.Value = prgHygiene.Maximum Then 'if hygiene reaches max
            timerHygiene.Stop() ' timer stops
            MessageBox.Show("Your sim is suffering from embarrassement from not keeping clean. You lost $200.") ' message telling you that you've lost money 
            money -= 200 ' takes money away
            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates money
            timerHygiene.Stop() ' hygiene timer stops
            prgHygiene.Value = 0 ' resets hygiene
            timerHygiene.Start() ' timer starts

        End If
    End Sub

    Private Sub timerEnergy_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerEnergy.Tick
        prgBarEnergy.Increment(1) ' increasement is 1

        If prgBarEnergy.Value = prgBarEnergy.Maximum Then ' bar reaches full
            timerAge.Stop() ' all timers stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background) ' death music plays
            MessageBox.Show("You died from overexertion.") ' message saying youve died
            Me.Hide() ' form hides
            frmDead.Show() ' death form shows



        End If
    End Sub

    Private Sub timerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerTime.Tick
        Static hour As Integer = 0 ' hour is a integer starting at 0
        Static counter As Integer = 0 ' seconds is an integer starting at 0

        counter += 1 ' adds 1 to the counter every tick of the timer
        If counter >= 60 Then ' if it = 60 seconds then 
            counter = 0 ' seconds changes to 0
            hour += 1 ' a number is added to the hour/ minutes  mark
        End If


        lblTime.Text = hour & ":" & counter ' displays the time played

        timePlayed = lblTime.Text ' total time played 
    End Sub


    Private Sub frmGameInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus() ' focuses on the gameinterface
    End Sub
    Private Sub frmGameInterface_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        keyarray(e.KeyCode) = True ' the down key is used in the game
    End Sub
    Private Sub frmGameInterface_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        keyarray(e.KeyCode) = False '  the up key is used in the game 
    End Sub
    Function testcollisonBookStore(ByVal player As PictureBox, ByVal picBookStore As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picBookStore.Bounds) Then ' if player collides with book store return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonMovie(ByVal player As PictureBox, ByVal picMovie As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picMovie.Bounds) Then ' if player collides with movie theather return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonGrocery(ByVal player As PictureBox, ByVal picGrocery As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picGrocery.Bounds) Then 'if player collides with grocery store return true
            Return True
        End If
        Return False
    End Function
    Function testcollisonPark(ByVal player As PictureBox, ByVal picPark As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picPark.Bounds) Then ' if player collides with park return true
            Return True
        End If
        Return False
    End Function
    Function testcollisonSwimming(ByVal player As PictureBox, ByVal picPool As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picPool.Bounds) Then ' player collides with pool return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonSchool(ByVal player As PictureBox, ByVal picSchool As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picSchool.Bounds) Then ' player collides with school, return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonHospital(ByVal player As PictureBox, ByVal picGym As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picGym.Bounds) Then ' player collides with hospital return true
            Return True
        End If
        Return False
    End Function

    Function testcollisonCityHall(ByVal player As PictureBox, ByVal piccityhall As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(piccityhall.Bounds) Then ' player collides with city hall return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonhouse3(ByVal player As PictureBox, ByVal pichouse3 As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(pichouse3.Bounds) Then ' player collides with house 3 returns true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonPolice(ByVal player As PictureBox, ByVal picpolice As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picpolice.Bounds) Then ' player collides with police station return true
            Return True
        End If
        Return False
    End Function
    Function testcollisonhouse1(ByVal player As PictureBox, ByVal pichouse1 As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(pichouse1.Bounds) Then ' player collides with house 1 return true
            Return True
        End If
        Return False
    End Function
    Function testcollisonhouse4(ByVal player As PictureBox, ByVal picHouse4New As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picHouse4New.Bounds) Then ' player collides with house 4 return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonhouse5(ByVal player As PictureBox, ByVal pichouse5 As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(pichouse5.Bounds) Then ' player collides with house 5 return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonhouse2(ByVal player As PictureBox, ByVal pichouse2 As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(pichouse2.Bounds) Then ' player collides with house 2 return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonrestur(ByVal player As PictureBox, ByVal picrestur As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picrestur.Bounds) Then ' player collides with resturant returns true 
            Return True
        End If
        Return False
    End Function
    Function testcollisontaskbar(ByVal player As PictureBox, ByVal pictaskbar As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(pictaskbar.Bounds) Then ' player collides with taskbar returns true 
            Return True
        End If
        Return False
    End Function
    Function testcollisontop(ByVal player As PictureBox, ByVal pictopBoundary As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(pictopBoundary.Bounds) Then ' player collides with top of form return true 
            Return True
        End If
        Return False
    End Function
    Function testcollisonleft(ByVal player As PictureBox, ByVal picBoundaryLeft As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picBoundaryLeft.Bounds) Then ' player collides with left of form return true
            Return True
        End If
        Return False
    End Function
    Function testcollisonright(ByVal player As PictureBox, ByVal picBoundaryRight As PictureBox) As Boolean
        If player.Bounds.IntersectsWith(picBoundaryRight.Bounds) Then ' player collides with right of form return true 
            Return True
        End If
        Return False
    End Function
    Private Sub timerPlayerMove_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerPlayerMove.Tick
        Dim hspeed As New Integer       'Sets up the horizontal speed                                                 'the following code deals with moving the player around
        Dim vspeed As New Integer       'Sets up the vertical speed
        If keyarray(Keys.Left) = True Then  'Checks if the key down is left
            hspeed -= 3           'If left then set the horizontal speed to -3(will make it move left)
        End If
        If keyarray(Keys.Right) = True Then     'Checks if the keydown is right
            hspeed += 3             'If right then sets the horizontal speed to +3(will make it move left)
        End If
        If keyarray(Keys.Up) Then   'Checks if the keydown is up
            vspeed -= 3        'If up then sets the vspeed to -3(will make it move up)
        End If
        If keyarray(Keys.Down) Then     'Checks if the keydown is down
            vspeed += 3     'If down then sets the vspeed +3(will make it move down)
        End If

        picPlayer.Location = New Point(picPlayer.Location.X + hspeed, picPlayer.Location.Y + vspeed)    'Every tick of the timer the player location will update and add the current vspeed and hspeed values to its X and Y values





        If picPlayer.Bounds.IntersectsWith(picBookStore.Bounds) Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnExitBookStore.Visible = True ' book store becomes visible if collison true 

            If job = "Writer" Then 'if the player has the writer job and collison is true 
                btnWorkWriter.Visible = True ' btn work shows
            Else
                btnWorkWriter.Visible = False ' else it wont
            End If
        End If

        If testcollisonBookStore(picPlayer, picMovie) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnWatchMovie.Visible = True ' watch movie btn shows
            btnExitMovie.Visible = True ' exit movie btn shows

            If job = "Movie Star" Then ' if the player has the movie star job and collison is true
                btnWorkMovie.Visible = True ' btn go to work shows
            Else
                btnWorkMovie.Visible = False ' else it wont
            End If
        End If

        If testcollisonGrocery(picPlayer, picGroceryStore) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnBuyGrocery.Visible = True ' buy groceries shows
            btnExitGrocer.Visible = True ' exit grocery shows

            If job = "Grocery Clerk" Then ' if player works as a grocery clerk and collison is true 
                btnWorkGrocery.Visible = True ' work btn shows
            Else
                btnWorkGrocery.Visible = False ' else it doesnt 
            End If
        End If

        If testcollisonPark(picPlayer, picCentralPark) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnPark.Visible = True ' go to park shows
            btnExitPark.Visible = True ' exit park shows
        End If

        If testcollisonSwimming(picPlayer, picSwimmingPool) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnSwim.Visible = True ' btn swim shows
            btnExitPool.Visible = True ' exit pool shows

            If job = "Lifeguard" Then ' if the player is working as a lifeguard and collison true 
                btnWorkLifeguard.Visible = True ' work btn shows
            Else
                btnWorkLifeguard.Visible = False ' else it wont 
            End If
        End If

        If testcollisonSchool(picPlayer, picSchool) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnExitSchool.Visible = True ' exit school shows

            If job = "School Teacher" Then ' if job is school teacher and collison is true 
                btnWorkSchool.Visible = True ' btn work shows
            Else
                btnWorkSchool.Visible = False ' otherwise it wont 
            End If
        End If

        If testcollisonHospital(picPlayer, picGym) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnHaveChildren.Visible = True ' have kids shows
            btnExitHospital.Visible = True ' exit shows
        End If

        If testcollisonCityHall(picPlayer, picCityHall) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnChangeName.Visible = True ' change name shows
            btnGetMarried.Visible = True ' get married shows
            btnExitCityHall.Visible = True ' exit shows

            If job = "Politician" Then ' if player is politician then
                btnWorkCityHall.Visible = True ' btn work shows
            Else
                btnWorkCityHall.Visible = False ' else it doesnt 
            End If
        End If

        If testcollisonhouse3(picPlayer, picHouse3) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            If HouseDiamond3.Visible = True Then '  if house 3 was chosen
                btnBathroom3.Visible = True  ' all these buttons become visible if collison is true 
                btnEat3.Visible = True
                btnShower3.Visible = True
                btnBed3.Visible = True
                btnEat3.Visible = True
                btnExit3.Visible = True
            End If
        End If

        If testcollisonPolice(picPlayer, picPolice) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnpoliceexit.Visible = True ' exit button shows

            If job = "Law Enforcement" Then ' if player has this job and collison is true 
                btnWorkPolice.Visible = True ' btn work shows
            Else
                btnWorkPolice.Visible = False ' else it will not
            End If

        End If

        If testcollisonhouse1(picPlayer, picHouse1) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed)' moves the player back away from walls
            If HouseDiamond1.Visible = True Then 'if house diamond 1 is visible
                btnBathroom1.Visible = True   ' all these buttons will become visible if collison is true 
                btnEat1.Visible = True
                btnShower1.Visible = True
                btnBed1.Visible = True
                btnEat1.Visible = True
                btnExit1.Visible = True

            End If
        End If
        If testcollisonhouse4(picPlayer, picHouse4New) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls

            If HouseDiamond4.Visible = True Then ' if the house diamond 4 is visible all house buttons become visible 
                btnBathroom4.Visible = True
                btnEat4.Visible = True
                btnShower4.Visible = True
                btnBed4.Visible = True
                btnEat4.Visible = True
                btnExit4.Visible = True
            End If
        End If

        If testcollisonhouse5(picPlayer, picHouse5) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            If HouseDiamond5.Visible = True Then ' if house diamond 5 is visible all house buttons become visible
                btnBathroom5.Visible = True
                btnEat5.Visible = True
                btnShower5.Visible = True
                btnBed5.Visible = True
                btnEat5.Visible = True
                btnExit5.Visible = True
            End If
        End If

        If testcollisonhouse2(picPlayer, picHouse2) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            If HouseDiamond2.Visible = True Then ' if house diamond 2 is visible then all house buttons become visible
                btnBathroom2.Visible = True
                btnEat2.Visible = True
                btnShower2.Visible = True
                btnBed2.Visible = True
                btnEat2.Visible = True
                btnExit2.Visible = True
            End If
        End If

        If testcollisonrestur(picPlayer, picRestaur) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
            btnEatRestur.Visible = True ' resturant button becomes visible at collison
            btnExitRest.Visible = True ' exit button becomes visible

            If job = "Chef" Then ' if player is ac chef
                btnWorkRestur.Visible = True ' btn work will shows
            Else
                btnWorkRestur.Visible = False ' else it will not
            End If

        End If

        If testcollisontaskbar(picPlayer, picTaskBar) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
        End If

        If testcollisontop(picPlayer, pictopboundary) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
        End If

        If testcollisonleft(picPlayer, picBoundaryLeft) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
        End If

        If testcollisonleft(picPlayer, picRightBoundary) = True Then ' if it returns true the player will not be able to go through the walls 
            picPlayer.Location = New Point(picPlayer.Location.X - hspeed, picPlayer.Location.Y - vspeed) ' moves the player back away from walls
        End If



    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        timerAge.Stop() ' stops all timers
        timerBladder.Stop()
        timerEnergy.Stop()
        timerHunger.Stop()
        timerHygiene.Stop()
        timerTime.Stop()
        timerPlayerMove.Stop()


        MessageBox.Show("Paused") ' message saying game is paused
        timerAge.Start() ' starts all timers
        timerBladder.Start()
        timerEnergy.Start()
        timerHunger.Start()
        timerHygiene.Start()
        timerTime.Start()
        timerPlayerMove.Start()


    End Sub


    Private Sub btnEat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEatRestur.Click
        If money >= 25 Then
            money -= 25 ' subtract 25$
            prgBarHunger.Value = 0 ' eat resets
            If prgBarEnergy.Value >= 90 Then ' if energy is 90 or more
                prgBarEnergy.Value += +1 ' add 1 to energy
            Else
                prgBarEnergy.Value += 5 ' else add 5 to energy
            End If


            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates money
            btnEatRestur.Visible = False ' all buttons hide
            btnExitRest.Visible = False
            btnWorkRestur.Visible = False
        Else
            MessageBox.Show("Not enough funds.")
        End If
    End Sub


    Private Sub btnExitRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitRest.Click
        btnEatRestur.Visible = False ' all buttons hide
        btnExitRest.Visible = False
        btnWorkRestur.Visible = False
    End Sub

    Private Sub btnpoliceexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpoliceexit.Click
        btnpoliceexit.Visible = False ' all buttons hide
        btnWorkPolice.Visible = False
    End Sub

    Private Sub btnChangeName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeName.Click
        If money >= 300 Then


            timerAge.Stop() ' stops all timers
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()

            money -= 300 ' subtracts 300$

            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates money
            namechange = InputBox("Please enter your NEW FULL NAME:", "Enter full name") ' prompt for new name
            lblName.Text = "Name : " & namechange ' updates the name
            playername = namechange
            btnChangeName.Visible = False ' all buttons hide
            btnGetMarried.Visible = False
            btnExitCityHall.Visible = False
            btnWorkCityHall.Visible = False
            timerAge.Start() ' all timers start
            timerBladder.Start()
            timerEnergy.Start()
            timerHunger.Start()
            timerHygiene.Start()
            timerTime.Start()
            timerPlayerMove.Start()
        Else
            MessageBox.Show("Not enough funds.")
        End If



    End Sub

    Private Sub btnGetMarried_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetMarried.Click
        marriage += 1 ' adds 1 to marriage count

        If marriage = 1 Then 'if marriage is 1 
            frmChooseSpouse.Show() ' form marriage shows
            My.Computer.Audio.Play(My.Resources.marriage, AudioPlayMode.Background) ' music plays
            timerAge.Stop() ' timers stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()

        End If

        If marriage > 1 Then ' if marriage is greater than 1 
            MessageBox.Show("You're already married and divorce is not an option.") ' message saying you are already married
        End If
        btnChangeName.Visible = False ' all buttons hide
        btnGetMarried.Visible = False
        btnExitCityHall.Visible = False
        btnWorkCityHall.Visible = False




    End Sub

    Private Sub btnExitCityHall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitCityHall.Click
        btnChangeName.Visible = False ' hides all buttons 
        btnGetMarried.Visible = False
        btnExitCityHall.Visible = False
        btnWorkCityHall.Visible = False
    End Sub

    Private Sub btnPark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPark.Click
        If prgBarEnergy.Value >= 90 Then ' if energy is 90 or more
            prgBarEnergy.Value += 1 ' adds 1 to energy
        Else
            prgBarEnergy.Value += 5 ' else adds 5 to energy
        End If
        If prgBarBladder.Value >= 90 Then ' if bladder is 90 or more
            prgBarBladder.Value += 1 ' add 1 to bladder
        Else
            prgBarBladder.Value += +5 ' else add 5 
        End If
        If prgBarHunger.Value >= 90 Then ' if hunger is 90 or more
            prgBarHunger.Value += 1 ' add 1 
        Else
            prgBarHunger.Value += 5 ' else add 5
        End If
        If prgHygiene.Value >= 90 Then ' if hygiene is 90 or more
            prgHygiene.Value += 1 ' add 1 
        Else
            prgHygiene.Value += 5 ' else add 5
        End If
        btnPark.Visible = False ' hides all buttons
        btnExitPark.Visible = False
    End Sub

    Private Sub btnHaveChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHaveChildren.Click
        children += 1 ' adds 1 to kid count
        If children <= 3 Then ' if children is less then or = 3
            If prgBarEnergy.Value >= 90 Then ' if energy is 90 or more
                prgBarEnergy.Value += 1 ' adds 1 to energy
            Else
                prgBarEnergy.Value += 10 ' else adds 10 to energy
            End If
            timerAge.Stop() ' stops all timers
            timerAge.Stop()
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            My.Computer.Audio.Play(My.Resources.birth, AudioPlayMode.Background) ' plays birth music
            frmHaveChild.Show() ' brings up the kid form
        ElseIf children > 3 Then ' if kids is greater than 3 
            MessageBox.Show("You cannot have anymore children") ' message saying you cant have more kids
            children = 3 ' kid count resets back to 3 
        End If
        btnHaveChildren.Visible = False ' buttons hide
        btnExitHospital.Visible = False
    End Sub

    Private Sub btnExitGym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitHospital.Click
        btnHaveChildren.Visible = False ' all buttons hide
        btnExitHospital.Visible = False
    End Sub

    Private Sub btnExitSchool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitSchool.Click
        btnExitSchool.Visible = False ' all buttons hide
        btnWorkSchool.Visible = False
    End Sub

    Private Sub btnSwim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSwim.Click
        If prgBarEnergy.Value >= 90 Then ' if energy is 90 or more
            prgBarEnergy.Value += 1 ' adds 1 to energy
        Else
            prgBarEnergy.Value += 5 ' else adds 5 to energy
        End If
        If prgBarBladder.Value >= 90 Then ' if bladder is 90 or more
            prgBarBladder.Value += 1 ' adds 1 to bladder
        Else
            prgBarBladder.Value += 5 ' else adds 5 to bladder
        End If
        If prgBarHunger.Value >= 90 Then ' if hunger is 90 then
            prgBarHunger.Value += 1 ' adds 1 to hunger
        Else
            prgBarHunger.Value += 5 ' else adds 5 to hunger
        End If

        btnSwim.Visible = False ' all buttons hide
        btnExitPool.Visible = False
        btnWorkLifeguard.Visible = False
    End Sub

    Private Sub btnExitPool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitPool.Click
        btnSwim.Visible = False ' all buttons hide
        btnExitPool.Visible = False
        btnWorkLifeguard.Visible = False
    End Sub

    Private Sub btnBuyGrocery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuyGrocery.Click
        If money >= 100 Then
            money -= 100 ' takes 100 away

            groceries += 5 ' adds groceries 
            lblGroceries.Text = "Groceries: " & groceries ' updates groceries
            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates money
            If prgBarHunger.Value >= 90 Then ' if hunger is 90 or more
                prgBarHunger.Value += 1 ' adds 1 
            Else
                prgBarHunger.Value += 5 ' else adds 5
            End If

            btnBuyGrocery.Visible = False ' all buttons hide
            btnExitGrocer.Visible = False
            btnWorkGrocery.Visible = False
        Else
            MessageBox.Show("Not enough funds.")
        End If
    End Sub

    Private Sub btnExitGrocer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitGrocer.Click
        btnBuyGrocery.Visible = False ' all buttons hide
        btnExitGrocer.Visible = False
        btnWorkGrocery.Visible = False
    End Sub

    Private Sub btnWatchMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWatchMovie.Click
        If money >= 5 Then
            money -= 5 ' take away 5 $

            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates money
            If prgBarEnergy.Value >= 90 Then ' if energy is 90 or more
                prgBarEnergy.Value += 1 ' adds 1 to energy
            Else
                prgBarEnergy.Value += 5 ' else adds 5
            End If
            If prgBarBladder.Value >= 90 Then ' if bladder is 90 or more
                prgBarBladder.Value += 1 ' adds 1 to bladder
            Else
                prgBarBladder.Value = 5 ' else adds 5 
            End If
            If prgBarHunger.Value >= 90 Then ' if hunger is 90 or more
                prgBarHunger.Value += 1 ' adds 1 to hunger
            Else
                prgBarHunger.Value = 5 ' else adds 5
            End If
            If prgHygiene.Value >= 90 Then ' if hygiene is 90 or more
                prgHygiene.Value += 1 ' adds 1 to hygiene
            Else
                prgHygiene.Value += 5 ' adds 5 to hygiene 
            End If
            btnWatchMovie.Visible = False ' all buttons hide
            btnExitMovie.Visible = False
            btnWorkMovie.Visible = False
        Else
            MessageBox.Show("Not enough funds.")
        End If
    End Sub

    Private Sub btnExitMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitMovie.Click
        btnWatchMovie.Visible = False ' all buttons hide
        btnExitMovie.Visible = False
        btnWorkMovie.Visible = False
    End Sub


    Private Sub btnExitBookStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitBookStore.Click
        btnExitBookStore.Visible = False ' all buttons hide
        btnWorkWriter.Visible = False
    End Sub

    Private Sub btnExitPark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitPark.Click
        btnPark.Visible = False ' all  buttons hide
        btnExitPark.Visible = False
    End Sub

    Private Sub HouseDiamond1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseDiamond1.Click
        housediamond += 1 ' adds 1 to the house diamond counter
        HouseDiamond2.Visible = False ' hides all other diamonds
        HouseDiamond3.Visible = False
        HouseDiamond4.Visible = False
        HouseDiamond5.Visible = False

        If housediamond > 1 Then ' if housediamond count is more than 1 
            btnBathroom1.Visible = True ' all house option buttons show
            btnEat1.Visible = True
            btnShower1.Visible = True
            btnBed1.Visible = True
            btnEat1.Visible = True
            btnExit1.Visible = True
        End If

    End Sub

    Private Sub HouseDiamond2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseDiamond2.Click
        housediamond += 1 ' adds 1 to the house diamond counter
        HouseDiamond1.Visible = False ' hides all other diamonds
        HouseDiamond3.Visible = False
        HouseDiamond4.Visible = False
        HouseDiamond5.Visible = False

        If housediamond > 1 Then ' if housediamond count is more than 1 
            btnBathroom2.Visible = True ' all house option buttons show
            btnEat2.Visible = True
            btnShower2.Visible = True
            btnBed2.Visible = True
            btnEat2.Visible = True
            btnExit2.Visible = True
        End If

    End Sub

    Private Sub HouseDiamond3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseDiamond3.Click
        housediamond += 1 ' adds 1 to the house diamond counter
        HouseDiamond1.Visible = False ' hides all other diamonds
        HouseDiamond2.Visible = False
        HouseDiamond4.Visible = False
        HouseDiamond5.Visible = False

        If housediamond > 1 Then ' if housediamond count is more than 1 
            btnBathroom3.Visible = True ' all house option buttons show
            btnEat3.Visible = True
            btnShower3.Visible = True
            btnBed3.Visible = True
            btnEat3.Visible = True
            btnExit3.Visible = True
        End If
    End Sub

    Private Sub HouseDiamond4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseDiamond4.Click
        housediamond += 1 ' adds 1 to the house diamond counter
        HouseDiamond1.Visible = False ' hides all other diamonds
        HouseDiamond2.Visible = False
        HouseDiamond3.Visible = False
        HouseDiamond5.Visible = False

        If housediamond > 1 Then ' if housediamond count is more than 1 
            btnBathroom4.Visible = True ' all house option buttons show
            btnEat4.Visible = True
            btnShower4.Visible = True
            btnBed4.Visible = True
            btnEat4.Visible = True
            btnExit4.Visible = True
        End If

    End Sub

    Private Sub HouseDiamond5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseDiamond5.Click
        housediamond += 1 ' adds 1 to the house diamond counter
        HouseDiamond1.Visible = False ' hides all other diamonds
        HouseDiamond2.Visible = False
        HouseDiamond3.Visible = False
        HouseDiamond4.Visible = False

        If housediamond > 1 Then ' if housediamond count is more than 1 
            btnBathroom5.Visible = True ' all house option buttons show
            btnEat5.Visible = True
            btnShower5.Visible = True
            btnBed5.Visible = True
            btnEat5.Visible = True
            btnExit5.Visible = True
        End If

    End Sub


    Private Sub timerJob_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerJob.Tick

        counter += 1 ' adds 1 every tick
        timeleft = 100 - counter ' time left

        If counter = 100 Then ' if it reaches 100 seconds
            timerJob.Stop() ' timer stops
            counter = 0 ' counter resets
        End If

    End Sub


    Private Sub btnWorkSchool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkSchool.Click, btnWorkCityHall.Click, btnWorkGrocery.Click, btnWorkLifeguard.Click, btnWorkMovie.Click, btnWorkPolice.Click, btnWorkRestur.Click, btnWorkWriter.Click
        If timerJob.Enabled = False Then ' if timer work is not enabled then 
            timerJob.Start() ' start the timer
            MessageBox.Show("You went to work and earned " & FormatCurrency(frmChooseJob.salary) & ".") ' tells you that you went to work and how much you made

            money += frmChooseJob.salary ' adds the money
            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates the money
            If prgBarBladder.Value >= 90 Then ' if bladder is 90 or more
                prgBarBladder.Value += +1 ' add 1 
            Else
                prgBarBladder.Value += +5 ' else add 5
            End If
            If prgBarEnergy.Value >= 90 Then ' if energy is 90 or more
                prgBarEnergy.Value += +1 ' add 1 
            Else
                prgBarEnergy.Value += +15 ' else add 15
            End If
            If prgBarHunger.Value >= 90 Then ' if hunger is 90 or more
                prgBarHunger.Value += +1 ' add 1 
            Else
                prgBarHunger.Value += +10 ' else add 10
            End If
            If prgHygiene.Value >= 90 Then ' if hygiene is 90 or more
                prgHygiene.Value += +1 ' add 1 
            Else
                prgHygiene.Value += +5 ' else add 5
            End If

        ElseIf timerJob.Enabled = True Then ' if timer is running
            timerAge.Stop() ' all timers stop, even job timer
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            timerJob.Stop()
            MessageBox.Show("You cannot go back to work so soon. You must wait " & timeleft & " seconds.") ' message telling you that you can't go back to work and tells you how long till you can
            timerAge.Start() ' timers start
            timerBladder.Start()
            timerEnergy.Start()
            timerHunger.Start()
            timerHygiene.Start()
            timerTime.Start()
            timerPlayerMove.Start()
            timerJob.Start()
        End If
        
    End Sub

    Private Sub btnBathroom1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBathroom1.Click, btnBathroom2.Click, btnBathroom3.Click, btnBathroom4.Click, btnBathroom5.Click ' handles all bathroom buttons
        prgBarBladder.Value = 0 ' resets bladder
        If prgHygiene.Value >= 90 Then ' if hygiene is 90 or more
            prgHygiene.Value += 1 ' increacement is 1 
        Else
            prgBarEnergy.Value += 5 ' increases by 5 else
        End If
    End Sub

    Private Sub btnEat1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEat1.Click, btnEat2.Click, btnEat3.Click, btnEat4.Click, btnEat5.Click ' handles all btn eats
        If groceries = 0 Then ' if you have no groceries
            MessageBox.Show("You do not have any food in the fridge. Either go out for dinner or buy groceries.") ' message telling you to buy groceries 
        Else
            groceries -= 1 ' subtract groceries when you use them
            prgBarHunger.Value = 0 ' hunger resets
            If prgBarEnergy.Value >= 90 Then ' if energy is 90 or higher
                prgBarEnergy.Value += 1 ' only add 1 increacment
            Else
                prgBarEnergy.Value += 5 ' else add 5
            End If
            If prgBarBladder.Value >= 90 Then ' if bladder is 90 or higher
                prgBarBladder.Value += 1 ' adds 1 
            Else
                prgBarBladder.Value += 4 ' else adds 4
            End If
            lblGroceries.Text = "Groceries: " & groceries ' displays number of groceries
        End If
    End Sub

    Private Sub btnShower1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShower1.Click, btnShower2.Click, btnShower3.Click, btnShower4.Click, btnShower5.Click ' handles all shower buttons
        prgHygiene.Value = 0 ' resets  shower
        If prgBarEnergy.Value >= 90 Then ' if energy is at 90 or more
            prgBarEnergy.Value += 1 ' only adds 1 increacment
        Else
            prgBarEnergy.Value += 5 ' otherwise adds 5
        End If
    End Sub

    Private Sub btnBed1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBed1.Click, btnBed2.Click, btnBed3.Click, btnBed4.Click, btnBed5.Click ' handles all bed buttons
        prgBarEnergy.Value = 0 ' energy resets
        If prgBarHunger.Value >= 90 Then ' if hunger is at 90 progress
            prgBarHunger.Value += 1 ' only add 1 
        Else
            prgBarHunger.Value += 20 ' else add 20
        End If
    End Sub

    Private Sub btnExit1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit1.Click
        btnBathroom1.Visible = False ' all butons hide
        btnEat1.Visible = False
        btnShower1.Visible = False
        btnBed1.Visible = False
        btnEat1.Visible = False
        btnExit1.Visible = False
    End Sub

    Private Sub btnExit2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit2.Click
        btnBathroom2.Visible = False ' all buttons hide
        btnEat2.Visible = False
        btnShower2.Visible = False
        btnBed2.Visible = False
        btnEat2.Visible = False
        btnExit2.Visible = False
    End Sub

    Private Sub btnExit3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit3.Click
        btnBathroom3.Visible = False ' all buttons hide
        btnEat3.Visible = False
        btnShower3.Visible = False
        btnBed3.Visible = False
        btnEat3.Visible = False
        btnExit3.Visible = False
    End Sub

    Private Sub btnExit4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit4.Click
        btnBathroom4.Visible = False ' all buttons hide
        btnEat4.Visible = False
        btnShower4.Visible = False
        btnBed4.Visible = False
        btnEat4.Visible = False
        btnExit4.Visible = False
    End Sub

    Private Sub btnExit5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit5.Click
        btnBathroom5.Visible = False ' all buttons hide
        btnEat5.Visible = False
        btnShower5.Visible = False
        btnBed5.Visible = False
        btnEat5.Visible = False
        btnExit5.Visible = False
    End Sub

    Private Sub picPlayer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles picPlayer.Click
        btnRobBank.Show() ' buttons show
        btnClubbing.Show()
        btnVacation.Show()
        btnLottery.Show()
        btnExitSelf.Show()
    End Sub

    Private Sub btnRobBank_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRobBank.Click
        Dim chance As Integer ' chance of success
        Randomize()

        chance = Int(3 * Rnd() + 1) ' 1 in 3 chance

        If chance = 3 Then ' if chance is 3
            timerAge.Stop() ' stops all timers
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            MessageBox.Show("You successfully stole $3000 without getting caught. Next time you may not be so lucky") ' you stole something 
            money += 3000 ' adds 300$
            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates label
            timerAge.Start() ' starts all timers
            timerBladder.Start()
            timerEnergy.Start()
            timerHunger.Start()
            timerHygiene.Start()
            timerTime.Start()
            timerPlayerMove.Start()

        Else
            MessageBox.Show("You were caught trying to steal money. You have been sentenced to life in prison") ' message sayin you've died
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background) ' death music
            Me.Hide() ' hides form
            frmDead.Show() ' form died shows
        End If


    End Sub

    Private Sub btnClubbing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClubbing.Click
        If money >= 30 Then
            money -= 30 ' subtracts money
            lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' money is updated
            btnRobBank.Visible = False ' all buttons become not visible
            btnVacation.Visible = False
            btnLottery.Visible = False
            btnExitSelf.Visible = False
            btnClubbing.Visible = False
            If prgBarEnergy.Value >= 90 Then ' if you are reaching the end of your health
                prgBarEnergy.Value += 1 ' will only increase by 1
            Else
                prgBarHunger.Value += 5 ' else by 1 
            End If
        Else
            MessageBox.Show("Not enough funds.")
        End If


    End Sub

    Private Sub btnVacation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVacation.Click
        If money >= 800 Then
            money -= 800 ' subtracts 800$ 
            lblMoney.Text = "Money:" & FormatCurrency(money, 2) ' money updates
            timerAge.Stop() ' all timers stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            frmVacation.Show() ' vacation form comes up
            btnRobBank.Visible = False ' all buttons become not visible
            btnVacation.Visible = False
            btnLottery.Visible = False
            btnExitSelf.Visible = False
            btnClubbing.Visible = False
        Else
            MessageBox.Show("Not enough funds.")
        End If
    End Sub

    Private Sub btnLottery_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLottery.Click


        Dim chance As Integer ' chance of winning 

        Randomize()
        chance = Int(5 * Rnd() + 1) ' chance of winning is 1 in 5
        If money >= 5 Then
            If chance = 5 Then ' if u get 5
                MessageBox.Show("YOU WON THE LOTTERY!!! You won the grand prize of $10,000.") ' message saying youve won money
                money += 10000 ' adds money
                lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates money
            Else
                money -= 5 ' subtracts 5 from money
                MessageBox.Show("You did not win. Better luck next time") ' message saying you died
                lblMoney.Text = "Money: " & FormatCurrency(money, 2) ' updates money
            End If

            btnRobBank.Visible = False ' all buttons become not visible
            btnBed5.Visible = False
            btnVacation.Visible = False
            btnLottery.Visible = False
            btnShower5.Visible = False
            btnExitSelf.Visible = False
            btnClubbing.Visible = False
        Else
            MessageBox.Show("Not enough funds.")
        End If
        
    End Sub
    Private Sub btnExitSelf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExitSelf.Click
        btnRobBank.Visible = False ' all buttons become not visible 
        btnBed5.Visible = False
        btnVacation.Visible = False
        btnLottery.Visible = False
        btnShower5.Visible = False
        btnExitSelf.Visible = False
        btnClubbing.Visible = False
    End Sub

    Private Sub btnFinishedPlaying_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFinishedPlaying.Click
        timerAge.Stop() ' all timers stop
        timerBladder.Stop()
        timerEnergy.Stop()
        timerHunger.Stop()
        timerHygiene.Stop()
        timerTime.Stop()
        timerPlayerMove.Stop()
        timerJob.Stop()
        frmFinished.Show() ' finished form appears
    End Sub


    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        timerAge.Stop()  ' all timers stop
        timerBladder.Stop()
        timerEnergy.Stop()
        timerHunger.Stop()
        timerHygiene.Stop()
        timerTime.Stop()
        timerPlayerMove.Stop()
        frmRules2.Show() ' rules comes up

    End Sub

    Private Sub lblHelpMoving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHelpMoving.Click
        MessageBox.Show("If your player is uncontrollably moving, click the key of the direction your character is going in. Example: Character stuck moving right, click the right arrow key.") ' tip displays
    End Sub

    Private Sub tmrCheckMoney_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckMoney.Tick
        If money <= 0 Then ' if you have no money
            tmrCheckMoney.Stop()
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background) ' death song plays
            MessageBox.Show("You've run out of money and don't have enough funds to live. You have died.") ' messagebox telling you that you died
            frmDead.Show() ' form death shows
            Me.Hide() ' this form hides
            timerAge.Stop()  ' all timers stop
            timerBladder.Stop()
            timerEnergy.Stop()
            timerHunger.Stop()
            timerHygiene.Stop()
            timerTime.Stop()
            timerPlayerMove.Stop()
            timerJob.Stop()
        End If
    End Sub

End Class