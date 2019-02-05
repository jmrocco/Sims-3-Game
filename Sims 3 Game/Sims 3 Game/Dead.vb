Public Class frmDead

    Private Sub frmDead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' everything happens at load
        lblName.Text = frmGameInterface.playername 'takes players name from game interface and displays it
        lbltext.Text = "died before their time at " & frmGameInterface.lblAgeByName.Text & "." 'displays text and age from game interface
        lblSpouseName.Text = frmGameInterface.lblSpouseName.Text 'takes spouses name from game interface and displays it 
        lblNumChildren.Text = frmGameInterface.children & "  children named; " 'displays text and number of children from game interface
        lblChildren.Text = frmGameInterface.lblChild1Name.Text & ", " & frmGameInterface.lblChild2Name.Text & ", " & frmGameInterface.lblChild3Name.Text & "." 'displays childrens names from gameinterface
        lblName2.Text = frmGameInterface.playername & " lived for " 'displays text and name of sim from game interface
        lblTime.Text = frmGameInterface.timePlayed & " minutes," 'displays text and number of minutes lived from game interface
        lblMoney.Text = FormatCurrency(frmGameInterface.money, 2) & "." 'displays the amount of money earned
        lblName3.Text = frmGameInterface.playername & " worked as a " & frmGameInterface.job & "." 'displays name from game interface as well as the job they held
        lblLastLine.Text = frmGameInterface.playername & " will be greatly missed." ' displays name from game interface followed by some text 

    End Sub

    Private Sub btnFinished_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinished.Click
        Application.Exit() 'closes the application
    End Sub
End Class