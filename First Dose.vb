Public Class First_Dose

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill out all the fields!")
        Else
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO partiallyvaccinated (`FirstName`, `MiddleName`, 
            `LastName`, `PermanentAddress`, `PresentAddress`, `ContactNumber`, `VaccineName`, `FirstDoseDate`, `TargetSecondDoseDate`)
            VALUES ('" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "', 
            '" & txtpmaddress.Text & "', '" & txtpraddress.Text & "', '" & txtcnumber.Text & "', '" & txtvname1.Text & "','" & dtpfdate1.Text & "','" & dtptsdate1.Text & "');"
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