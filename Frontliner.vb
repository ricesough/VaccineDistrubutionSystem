Public Class Frontliner
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Center.Show()
        Me.Hide()
    End Sub

    Private Sub btnStart_Click_1(sender As Object, e As EventArgs) Handles btnStart.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill out all the fields!")
        Else
            openCon()
            Try
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO frontliner(
                                    `FirstName`,
                                    `MiddleName`,
                                    `LastName`,
                                    `PermanentAddress`,
                                    `PresentAddress`,
                                    `ContactNumber`,
                                    `CenterName`
                                )
                                VALUES(
                                    '" & txtfname.Text & "',
                                    '" & txtmname.Text & "',
                                    '" & txtlname.Text & "',
                                    '" & txtpmaddress.Text & "',
                                    '" & txtpraddress.Text & "',
                                    '" & txtcnumber.Text & "',
                                    '" & txtvcenter.Text & "'
                                );"
                cmd.ExecuteNonQuery()
                con.Close()
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtpmaddress.Clear()
                txtpraddress.Clear()
                txtcnumber.Clear()
                txtvcenter.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Schedule_Complete.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        EnterData.ShowDialog()
        Me.Hide()
    End Sub
End Class