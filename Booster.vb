Public Class Booster
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill out all the fields!")
        Else
            openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO booster (`FirstName`, `MiddleName`, 
            `LastName`, `PermanentAddress`, `PresentAddress`, `ContactNumber`, `VaccineName`, `FirstDoseDate`, `SecondDoseDate`, `BoosterDate`, `TargetNextBoosterDate`)
            VALUES ('" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "', 
            '" & txtpmaddress.Text & "', '" & txtpraddress.Text & "', '" & txtcnumber.Text & "', '" & txtvname.Text & "','" & dtpfdate.Text & "','" & dtpsdate.Text & "', '" & dtpbdate.Text & "', '" & dtptbdate.Text & "');"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Schedule_Complete.Show()
        Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Status.Show()
        Me.Hide()
    End Sub
End Class