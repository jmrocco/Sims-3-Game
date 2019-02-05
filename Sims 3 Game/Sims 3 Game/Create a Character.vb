Public Class frmCas

    Dim gclicks As Integer = 0 'how many times the guy character buttons has been clicked
    Dim fclicks As Integer = 0 'how many times the girl character buttons have been clicked
    Public character As Image 'your character is an image
    Dim characterchoosen As Boolean = False 'characterchosen is set to false intially
    Public firstname As String 'first name is a word
    Public lastname As String 'last name is a word 
    Private Sub btnMale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMale.Click

        gclicks += 1 'sets guy clicks to 1            < this code is used to flip the character picture panels according to if male or female has been clicked 
        fclicks = 0 'girl clicks to 0                 < the player can change gender halfway through creating a character and the panels will still change smoothly 
        If gclicks > 1 Then ' the value of guy clicks can only be 1 
            gclicks = 1 'changes the value back to 1 
        End If


        lblChoose.Visible = True 'statement becomes visible 
        Me.picPerson1.Image = My.Resources.guy_1_real 'panel 1 shows a character
        picPerson1.SizeMode = PictureBoxSizeMode.Zoom ' panel 1 zooms the image out
        Me.picPerson2.Image = My.Resources.guy_2_real 'panel 2 shows a character
        picPerson2.SizeMode = PictureBoxSizeMode.Zoom ' panel 2 zooms the image out
        Me.picPerson3.Image = My.Resources.guy_3_real 'panel 3 shows a character
        picPerson3.SizeMode = PictureBoxSizeMode.Zoom ' panel 3 zooms the image out

    End Sub

    Private Sub btnFemale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFemale.Click

        fclicks += 1 'sets girl clicks to 1            < this code is used to flip the character picture panels according to if male or female has been clicked 
        gclicks = 0 'guy clicks to 0                 < the player can change gender halfway through creating a character and the panels will still change smoothly 
        If fclicks > 1 Then ' the value of girl clicks can only be 1
            fclicks = 1 'changes the value back to 1 
        End If
        lblChoose.Visible = True 'statement becomes visible 
        Me.picPerson1.Image = My.Resources.girl_1_real 'panel 1 shows a character
        picPerson1.SizeMode = PictureBoxSizeMode.Zoom ' panel 1 zooms the image out
        Me.picPerson2.Image = My.Resources.girl_2_real 'panel 2 shows a character
        picPerson2.SizeMode = PictureBoxSizeMode.Zoom ' panel 2 zooms the image out
        Me.picPerson3.Image = My.Resources.girl_3_real 'panel 3 shows a character
        picPerson3.SizeMode = PictureBoxSizeMode.Zoom ' panel 3 zooms the image out

    End Sub

    Private Sub picPerson1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPerson1.Click

        If gclicks = 1 Then ' if the male button has been clicked once then
            Me.picChoosenPerson.Image = My.Resources.guy_1_real ' the character chosen is now displayed in a big picturebox 
            picChoosenPerson.SizeMode = PictureBoxSizeMode.Zoom 'image zoomed out
            character = My.Resources.guy_1_real 'character is set
            characterchoosen = True 'character chosen is now true 
        ElseIf fclicks = 1 Then ' if the girl button has been clicked once then
            Me.picChoosenPerson.Image = My.Resources.girl_1_real 'the character chosen is now displayed in the big picturebox
            picChoosenPerson.SizeMode = PictureBoxSizeMode.Zoom 'image zoomed out
            character = My.Resources.girl_1_real 'character is set
            characterchoosen = True ' character chosen is true 
        End If



    End Sub

    Private Sub picPerson2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPerson2.Click

        If gclicks = 1 Then ' if the male button has been clicked once then
            Me.picChoosenPerson.Image = My.Resources.guy_2_real ' the character chosen is now displayed in a big picturebox 
            picChoosenPerson.SizeMode = PictureBoxSizeMode.Zoom 'image zoomed out
            character = My.Resources.guy_2_real 'character is set
            characterchoosen = True 'character chosen is true
        ElseIf fclicks = 1 Then ' if the girl button has been clicked once then
            Me.picChoosenPerson.Image = My.Resources.girl_2_real ' the character chosen is now displayed in a big picturebox 
            picChoosenPerson.SizeMode = PictureBoxSizeMode.Zoom 'image zoomed out
            character = My.Resources.girl_2_real 'character is set
            characterchoosen = True ' character chosen is true 
        End If

    End Sub

    Private Sub picPerson3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPerson3.Click

        If gclicks = 1 Then ' if the male button has been clicked once then
            Me.picChoosenPerson.Image = My.Resources.guy_3_real ' the character chosen is now displayed in a big picturebox 
            picChoosenPerson.SizeMode = PictureBoxSizeMode.Zoom 'image zoomed out
            character = My.Resources.guy_3_real 'character is set
            characterchoosen = True 'character chosen is true 
        ElseIf fclicks = 1 Then ' if the girl button has been clicked once then
            Me.picChoosenPerson.Image = My.Resources.girl_3_real ' the character chosen is now displayed in a big picturebox 
            picChoosenPerson.SizeMode = PictureBoxSizeMode.Zoom 'image zoomed out
            character = My.Resources.girl_3_real 'character is set
            characterchoosen = True ' character chosen is true 
        End If

    End Sub

    Private Sub btnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReady.Click

        firstname = txtFirstName.Text 'firstname is what is entered in textbox
        lastname = txtLastName.Text 'lastname is what is entered in textbox

        If firstname = "" Or lastname = "" Then 'if either name box is empty
            MessageBox.Show("Please fill in the sections that are highlighted red.") 'messagebox to tell you to enter your name
            If firstname = "" Then 'changes firstname to red to show you what you need to fill in
                lblFirstState.ForeColor = System.Drawing.Color.Red
            End If
            If lastname = "" Then 'changes lastname to red to show you what you need to fill in
                lblLastState.ForeColor = System.Drawing.Color.Red
            End If
        ElseIf firstname <> "" Or lastname <> "" Then 'if first and last name are not empty
            If gclicks = 0 And fclicks = 0 Then 'if a gender hasnt been chosen
                MessageBox.Show("Please choose a gender") 'message to choose gender
            End If
        End If

        If gclicks <> 0 Or fclicks <> 0 Then ' if gender has been chosen 

            If characterchoosen = False Then ' but there has been no chosencharacter then
                MessageBox.Show("Choose a character from the characters shown below") 'messagebox to choose a character

            Else
                Me.Hide() 'hides form
                frmLoadingScreen2.Show() 'brings loading screen
            End If
        End If

    End Sub

End Class