Public Class frmChooseJob


    Public job As String 'job is a word
    Public salary As Integer = 0 ' salary is intially 0
    Private Sub picPolice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPolice.Click

        job = "Law Enforcement" 'what the job is 
        salary = 300 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub

    Private Sub picChef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picChef.Click

        job = "Chef" 'what the job is 
        salary = 200 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub

    Private Sub picPolitic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPolitic.Click

        job = "Politician" 'what the job is 
        salary = 400 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub

    Private Sub picGrocery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGrocery.Click

        job = "Grocery Clerk" 'what the job is 
        salary = 100 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub

    Private Sub picMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMovie.Click

        job = "Movie Star" 'what the job is 
        salary = 400 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub

    Private Sub picWriter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picWriter.Click

        job = "Writer" 'what the job is 
        salary = 200 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub

    Private Sub picSchool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSchool.Click

        job = "School Teacher" 'what the job is 
        salary = 250 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub

    Private Sub picLifeguard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLifeguard.Click

        job = "Lifeguard" 'what the job is 
        salary = 100 'salary 
        Me.Hide() 'hides form
        frmGameInterface.Show() 'brings game up
        frmDiamond.Show() 'instuctions show 

    End Sub
End Class