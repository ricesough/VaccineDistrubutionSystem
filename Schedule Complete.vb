Public Class Schedule_Complete
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblSubtitle_Click(sender As Object, e As EventArgs) Handles lblSubtitle.Click

    End Sub

    Private Sub Schedule_Complete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (MsgBox(“Are you sure you want to exit?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewData.Show()
        Me.Close()
    End Sub
End Class