Imports MySql.Data.MySqlClient

Public Class VaccinationCenter
    Private Sub VaccinationCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()
        loadTable6()
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM vaccinationcenter WHERE CenterID='" & txtID.Text & "'"
            adapter.SelectCommand = cmd
            data.Clear()
            adapter.Fill(data, "Data")

            txtVCname.DataBindings.Add("Text", data, "Data.CenterName")
            txtVCname.DataBindings.Clear()

            txtVCaddress.DataBindings.Add("Text", data, "Data.CenterAddress")
            txtVCaddress.DataBindings.Clear()

            txtVCnumber.DataBindings.Add("Text", data, "Data.CenterContactNumber")
            txtVCnumber.DataBindings.Clear()

            If txtID.Text = "" Then
                txtVCname.Clear()
                txtVCaddress.Clear()
                txtVCnumber.Clear()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub loadTable6()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM vaccinationcenter"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtID.Text = DataGridView1.Item("CenterID", DataGridView1.CurrentRow.Index).Value
        txtVCname.Text = DataGridView1.Item("CenterName", DataGridView1.CurrentRow.Index).Value
        txtVCaddress.Text = DataGridView1.Item("CenterAddress", DataGridView1.CurrentRow.Index).Value
        txtVCnumber.Text = DataGridView1.Item("CenterContactNumber", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE
                                    vaccinationcenter
                                SET
                                    CenterName = '" & txtVCname.Text & "',
                                    CenterAddress = '" & txtVCaddress.Text & "',
                                    CenterContactNumber = '" & txtVCnumber.Text & "'
                                WHERE
                                    CenterID = '" & txtID.Text & "'"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Updated Succesfully!")
            Call loadTable6()
            txtID.Clear()
            txtVCname.Clear()
            txtVCaddress.Clear()
            txtVCnumber.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If (MsgBox(“Are you sure you want to exit?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Me.Close()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox(“Are you sure you want to delete the item?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                cmd.CommandText = "DELETE FROM vaccinationcenter WHERE CenterID = '" & txtID.Text & "'"
                con.Open()
                Dim mysc As New MySqlCommand(cmd.CommandText, con)
                mysc.ExecuteNonQuery()
                MsgBox(“Data Deleted!”, MsgBoxStyle.Information)
                con.Close()
                Call loadTable6()
                txtID.Clear()
                txtVCname.Clear()
                txtVCaddress.Clear()
                txtVCnumber.Clear()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ViewData.Show()
        Me.Close()
    End Sub
End Class