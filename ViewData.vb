Public Class ViewData

    Private Sub pcUnvaccinated_Click(sender As Object, e As EventArgs) Handles pcUnvaccinated.Click
        UnvaccinatedData.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Opening.Show()
        Me.Hide()
    End Sub

    Private Sub pcPartial_Click(sender As Object, e As EventArgs) Handles pcPartial.Click
        PartiallyData.Show()
        Me.Hide()
    End Sub

    Private Sub pcFully_Click(sender As Object, e As EventArgs) Handles pcFully.Click
        FullyVaccinatedData.Show()
        Me.Hide()
    End Sub

    Private Sub pcBooster_Click(sender As Object, e As EventArgs) Handles pcBooster.Click
        BoosterData.Show()
        Me.Hide()
    End Sub

    Private Sub PcFrontliner_Click(sender As Object, e As EventArgs) Handles PcFrontliner.Click
        FrontlinerData.Show()
        Me.Hide()
    End Sub

    Private Sub pcCenter_Click(sender As Object, e As EventArgs) Handles pcCenter.Click
        VaccinationCenter.Show()
        Me.Hide()
    End Sub
End Class