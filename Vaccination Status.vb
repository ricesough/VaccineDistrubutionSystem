Public Class Status
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUnvaccinated.Click
        Unvaccinated.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBooster.Click
        Booster.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPartiallyVaccinated.Click
        First_Dose.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnFullyVaccinated.Click
        Fully_Vaccinated.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        EnterData.Show()
        Me.Hide()
    End Sub
End Class