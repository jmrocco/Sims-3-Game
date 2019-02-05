Public Class frmHaveChild
    Public child1 As Image 'image of  child 1 
    Public child2 As Image ' image of  child 2 
    Public child3 As Image ' image of child 3 
    Public onename As String ' name of the first child
    Public twoname As String ' name of the second child
    Public threename As String ' name of the third child
    Private Sub picBoy1_Click(sender As Object, e As EventArgs) Handles picBoy1.Click

        If frmGameInterface.children = 1 Then ' if the child count is 1 then
            child1 = My.Resources.boy_1 ' child 1 is specific pic
            onename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start()    ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild1.Visible = True 'pic for child 1 becomes visible
            frmGameInterface.picChild1.SizeMode = PictureBoxSizeMode.Zoom ' pic zooms
            frmGameInterface.picChild1.Image = child1 ' pic set
            frmGameInterface.lblChild1Name.Visible = True ' name is now visible
            frmGameInterface.picChild1.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild1Name.Text = onename ' name set
        End If

        If frmGameInterface.children = 2 Then ' if the child count is 2  then 
            child2 = My.Resources.boy_1 ' child 2 is specific pic
            twoname = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild2.Visible = True 'pic for child becomes visible
            frmGameInterface.picChild2.SizeMode = PictureBoxSizeMode.Zoom 'pic zooms
            frmGameInterface.picChild2.Image = child2 'pic of kid is set
            frmGameInterface.lblChild2Name.Visible = True ' name is visible
            frmGameInterface.picChild2.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild2Name.Text = twoname ' name set
        End If


        If frmGameInterface.children = 3 Then ' if the child count is 3 then
            child3 = My.Resources.boy_1 ' child 3 is specific pic
            threename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild3.Visible = True ' kids pic is visible
            frmGameInterface.picChild3.SizeMode = PictureBoxSizeMode.Zoom ' pic zooms
            frmGameInterface.picChild3.Image = child3 ' pic set
            frmGameInterface.lblChild3Name.Visible = True ' name visible
            frmGameInterface.picChild3.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild3Name.Text = threename ' name set
        End If

    End Sub

    Private Sub picBoy2_Click(sender As Object, e As EventArgs) Handles picBoy2.Click
        If frmGameInterface.children = 1 Then ' if the child count is 1 then
            child1 = My.Resources.boy_2 ' child 1 is specific pic
            onename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild1.Visible = True ' kids pic becomes visible
            frmGameInterface.picChild1.SizeMode = PictureBoxSizeMode.Zoom ' pic zooms
            frmGameInterface.picChild1.Image = child1 ' pic set
            frmGameInterface.lblChild1Name.Visible = True ' name visible 
            frmGameInterface.picChild1.BackColor = Color.LightSteelBlue ' back colour visible
            frmGameInterface.lblChild1Name.Text = onename ' name set
        End If
        If frmGameInterface.children = 2 Then ' if the child count is 2 then
            child2 = My.Resources.boy_2 ' child 2 is specific pic
            twoname = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild2.Visible = True ' pic visible
            frmGameInterface.picChild2.SizeMode = PictureBoxSizeMode.Zoom 'pic zooms
            frmGameInterface.picChild2.Image = child2 ' pic set
            frmGameInterface.lblChild2Name.Visible = True ' name visible
            frmGameInterface.picChild2.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild2Name.Text = twoname ' name set
        End If

        If frmGameInterface.children = 3 Then ' if the child count is 3 then
            child3 = My.Resources.boy_2 ' child 3 is specific pic
            threename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild3.Visible = True ' pic visible 
            frmGameInterface.picChild3.SizeMode = PictureBoxSizeMode.Zoom 'pic zoom
            frmGameInterface.picChild3.Image = child3 ' pic set
            frmGameInterface.lblChild3Name.Visible = True 'name visible
            frmGameInterface.picChild3.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild3Name.Text = threename ' name set
        End If
    End Sub

    Private Sub picBoy3_Click(sender As Object, e As EventArgs) Handles picBoy3.Click
        If frmGameInterface.children = 1 Then ' if the child count is 1 then
            child1 = My.Resources.boy_3 ' child 1 is specific pic
            onename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild1.Visible = True ' pic visible
            frmGameInterface.picChild1.SizeMode = PictureBoxSizeMode.Zoom 'pic zoomed
            frmGameInterface.picChild1.Image = child1 ' pic set
            frmGameInterface.lblChild1Name.Visible = True ' name visible
            frmGameInterface.picChild1.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild1Name.Text = onename  ' name set
        End If
        If frmGameInterface.children = 2 Then ' if the child count is 2 then
            child2 = My.Resources.boy_3 ' child 2 is specific pic
            twoname = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild2.Visible = True ' child visible
            frmGameInterface.picChild2.SizeMode = PictureBoxSizeMode.Zoom ' pic zoom
            frmGameInterface.picChild2.Image = child2 ' pic set
            frmGameInterface.lblChild2Name.Visible = True ' name visible 
            frmGameInterface.picChild2.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild2Name.Text = twoname ' name set
        End If

        If frmGameInterface.children = 3 Then ' if the child count is 3 then
            child3 = My.Resources.boy_3 ' child 3 is specific pic
            threename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild3.Visible = True ' pic visible
            frmGameInterface.picChild3.SizeMode = PictureBoxSizeMode.Zoom ' pic zoomed
            frmGameInterface.picChild3.Image = child3 ' pic set
            frmGameInterface.lblChild3Name.Visible = True ' name visible
            frmGameInterface.picChild3.BackColor = Color.LightSteelBlue ' colour changed
            frmGameInterface.lblChild3Name.Text = threename ' name set
        End If
    End Sub

    Private Sub picGirl1_Click(sender As Object, e As EventArgs) Handles picGirl1.Click
        If frmGameInterface.children = 1 Then ' if the child count is 1 then
            child1 = My.Resources.girl_1 ' child 1 is specific pic
            onename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild1.Visible = True ' pic visible
            frmGameInterface.picChild1.SizeMode = PictureBoxSizeMode.Zoom 'pic zoomed
            frmGameInterface.picChild1.Image = child1 ' pic set
            frmGameInterface.lblChild1Name.Visible = True ' name visible
            frmGameInterface.picChild1.BackColor = Color.LightSteelBlue ' colour changed
            frmGameInterface.lblChild1Name.Text = onename ' name set
        End If
        If frmGameInterface.children = 2 Then ' if the child count is 2 then
            child2 = My.Resources.girl_1 ' child 2 is specific pic
            twoname = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild2.Visible = True ' pic visible
            frmGameInterface.picChild2.SizeMode = PictureBoxSizeMode.Zoom 'pic zoomed
            frmGameInterface.picChild2.Image = child2 ' child set
            frmGameInterface.lblChild2Name.Visible = True ' name visible
            frmGameInterface.picChild2.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild2Name.Text = twoname ' name set
        End If

        If frmGameInterface.children = 3 Then ' if the child count is 3 then
            child3 = My.Resources.girl_1 ' child 3 is specific pic
            threename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild3.Visible = True ' pic visible
            frmGameInterface.picChild3.SizeMode = PictureBoxSizeMode.Zoom 'pic zoom
            frmGameInterface.picChild3.Image = child3 ' pic set 
            frmGameInterface.lblChild3Name.Visible = True ' name visible
            frmGameInterface.picChild3.BackColor = Color.LightSteelBlue ' colour changed
            frmGameInterface.lblChild3Name.Text = threename ' name set
        End If
    End Sub

    Private Sub picGirl2_Click(sender As Object, e As EventArgs) Handles picGirl2.Click
        If frmGameInterface.children = 1 Then ' if the child count is 1 then
            child1 = My.Resources.girl_2 ' child 1 is specific pic
            onename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild1.Visible = True 'pic visible
            frmGameInterface.picChild1.SizeMode = PictureBoxSizeMode.Zoom ' pic zoomed
            frmGameInterface.picChild1.Image = child1 ' child set
            frmGameInterface.lblChild1Name.Visible = True ' name visible
            frmGameInterface.picChild1.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild1Name.Text = onename ' name set
        End If
        If frmGameInterface.children = 2 Then ' if the child count is 2 then
            child2 = My.Resources.girl_2 ' child 2 is specific pic
            twoname = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild2.Visible = True ' pic child visible
            frmGameInterface.picChild2.SizeMode = PictureBoxSizeMode.Zoom 'pic zoom
            frmGameInterface.picChild2.Image = child2 ' child set
            frmGameInterface.lblChild2Name.Visible = True ' name visible
            frmGameInterface.picChild2.BackColor = Color.LightSteelBlue ' back colour changed
            frmGameInterface.lblChild2Name.Text = twoname ' name set
        End If

        If frmGameInterface.children = 3 Then ' if the child count is 3 then
            child3 = My.Resources.girl_2 ' child 3 is specific pic
            threename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild3.Visible = True ' pic visible 
            frmGameInterface.picChild3.SizeMode = PictureBoxSizeMode.Zoom 'pic zoom
            frmGameInterface.picChild3.Image = child3   ' pic set
            frmGameInterface.lblChild3Name.Visible = True ' name visible    
            frmGameInterface.picChild3.BackColor = Color.LightSteelBlue ' back colour set
            frmGameInterface.lblChild3Name.Text = threename ' name set
        End If
    End Sub

    Private Sub picGirl3_Click(sender As Object, e As EventArgs) Handles picGirl3.Click
        If frmGameInterface.children = 1 Then ' if the child count is 1 then
            child1 = My.Resources.girl_3 ' child 1 is specific pic
            onename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild1.Visible = True ' pic visible
            frmGameInterface.picChild1.SizeMode = PictureBoxSizeMode.Zoom 'pic zoom
            frmGameInterface.picChild1.Image = child1 ' pic set
            frmGameInterface.lblChild1Name.Visible = True ' name visible
            frmGameInterface.picChild1.BackColor = Color.LightSteelBlue ' back colour changed 
            frmGameInterface.lblChild1Name.Text = onename ' name set
        End If
        If frmGameInterface.children = 2 Then ' if the child count is 2 then
            child2 = My.Resources.girl_3 ' child 2 is specific pic
            twoname = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild2.Visible = True ' pic visible
            frmGameInterface.picChild2.SizeMode = PictureBoxSizeMode.Zoom ' pic zoomed
            frmGameInterface.picChild2.Image = child2 'pic set
            frmGameInterface.lblChild2Name.Visible = True ' name visible
            frmGameInterface.picChild2.BackColor = Color.LightSteelBlue ' back colour set
            frmGameInterface.lblChild2Name.Text = twoname ' name set
        End If

        If frmGameInterface.children = 3 Then ' if the child count is 3 then
            child3 = My.Resources.girl_3 ' child 3 is specific pic
            threename = InputBox("Please enter your child's first name.") 'input to enter childs name
            Me.Close() ' closes form
            frmGameInterface.timerAge.Start() ' the following code starts the timers in the game interface
            frmGameInterface.timerBladder.Start()
            frmGameInterface.timerEnergy.Start()
            frmGameInterface.timerHunger.Start()
            frmGameInterface.timerHygiene.Start()
            frmGameInterface.timerTime.Start()
            frmGameInterface.timerPlayerMove.Start()


            frmGameInterface.picChild3.Visible = True ' pic visible
            frmGameInterface.picChild3.SizeMode = PictureBoxSizeMode.Zoom ' pic zoomed
            frmGameInterface.picChild3.Image = child3 ' image set
            frmGameInterface.lblChild3Name.Visible = True ' name visible
            frmGameInterface.picChild3.BackColor = Color.LightSteelBlue ' back colour set
            frmGameInterface.lblChild3Name.Text = threename ' name set
        End If
    End Sub
End Class