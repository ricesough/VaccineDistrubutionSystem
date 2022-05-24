Public Class Center
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill out all the fields!")
        Else
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO vaccinationcenter (`CenterName`, `CenterAddress`, `CenterContactNumber`)	
            VALUES ('" & txtVCname.Text & "','" & txtVCaddress.Text & "','" & txtVCnumber.Text & "');"
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Schedule_Complete.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        EnterData.Show()
        Me.Hide()
    End Sub
End Class