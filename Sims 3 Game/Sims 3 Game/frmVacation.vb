Public Class frmVacation

    Private Sub btnFrance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrance.Click
        frmFrance.Show() ' brings up france vid
        Me.Hide() ' hides this form
    End Sub

    Private Sub btnChina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChina.Click
        frmChina.Show() 'brings up china vid
        Me.Hide() ' hides this form
    End Sub

    Private Sub btnEgypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEgypt.Click
        frmEgypt.Show() ' brings up egypt vid
        Me.Hide() ' hides this form
    End Sub
End Class