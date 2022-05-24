Imports MySql.Data.MySqlClient

Public Class UnvaccinatedData
    Private Sub UnvaccinatedData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()
        loadTable2()
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM unvaccinated WHERE U_StatusID = '" & txtID.Text & "'"
            adapter.SelectCommand = cmd
            data.Clear()
            adapter.Fill(data, "Data")

            txtfname.DataBindings.Add("Text", data, "Data.FirstName")
            txtfname.DataBindings.Clear()

            txtmname.DataBindings.Add("Text", data, "Data.MiddleName")
            txtmname.DataBindings.Clear()

            txtlname.DataBindings.Add("Text", data, "Data.LastName")
            txtlname.DataBindings.Clear()

            txtpmaddress.DataBindings.Add("Text", data, "Data.PermanentAddress")
            txtpmaddress.DataBindings.Clear()

            txtpraddress.DataBindings.Add("Text", data, "Data.PresentAddress")
            txtpraddress.DataBindings.Clear()

            txtcnumber.DataBindings.Add("Text", data, "Data.ContactNumber")
            txtcnumber.DataBindings.Clear()

            txtvaccinename.DataBindings.Add("Text", data, "Data.TargetVaccineName")
            txtvaccinename.DataBindings.Clear()

            dtpfdate.DataBindings.Add("Text", data, "Data.TargetFirstDoseDate")
            dtpfdate.DataBindings.Clear()

            If txtID.Text = "" Then
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtpmaddress.Clear()
                txtpraddress.Clear()
                txtcnumber.Clear()
                txtvaccinename.Clear()
                dtpfdate.Text = ""
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub loadTable2()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM unvaccinated"
            adapter.SelectCommand = cmd
            table2.Clear()
            adapter.Fill(table2)
            DataGridView2.DataSource = table2
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        txtID.Text = DataGridView2.Item("U_StatusID", DataGridView2.CurrentRow.Index).Value
        txtfname.Text = DataGridView2.Item("FirstName", DataGridView2.CurrentRow.Index).Value
        txtmname.Text = DataGridView2.Item("MiddleName", DataGridView2.CurrentRow.Index).Value
        txtlname.Text = DataGridView2.Item("LastName", DataGridView2.CurrentRow.Index).Value
        txtpmaddress.Text = DataGridView2.Item("PermanentAddress", DataGridView2.CurrentRow.Index).Value
        txtpraddress.Text = DataGridView2.Item("PresentAddress", DataGridView2.CurrentRow.Index).Value
        txtcnumber.Text = DataGridView2.Item("ContactNumber", DataGridView2.CurrentRow.Index).Value
        txtvaccinename.Text = DataGridView2.Item("TargetVaccineName", DataGridView2.CurrentRow.Index).Value
        dtpfdate.Text = DataGridView2.Item("TargetFirstDoseDate", DataGridView2.CurrentRow.Index).Value
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE
                                    unvaccinated
                                SET
                                    U_StatusID = '" & txtID.Text & "',
                                    FirstName = '" & txtfname.Text & "',
                                    MiddleName = '" & txtmname.Text & "',
                                    LastName = '" & txtlname.Text & "',
                                    PermanentAddress = '" & txtpmaddress.Text & "',
                                    PresentAddress = '" & txtpraddress.Text & "',
                                    ContactNumber = '" & txtcnumber.Text & "',
                                    TargetVaccineName = '" & txtvaccinename.Text & "',
                                    TargetFirstDoseDate = '" & dtpfdate.Text & "'
                                WHERE
                                    U_StatusID = '" & txtID.Text & "'"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Updated Succesfully!")
            Call loadTable2()
            txtfname.Clear()
            txtmname.Clear()
            txtlname.Clear()
            txtpmaddress.Clear()
            txtpraddress.Clear()
            txtcnumber.Clear()
            txtID.Clear()
            txtvaccinename.Clear()
            dtpfdate.Text = ""
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
                cmd.CommandText = "DELETE FROM unvaccinated WHERE U_StatusID = '" & txtID.Text & "'"
                con.Open()
                Dim mysc As New MySqlCommand(cmd.CommandText, con)
                mysc.ExecuteNonQuery()
                MsgBox(“Data Deleted!”, MsgBoxStyle.Information)
                con.Close()
                Call loadTable2()
                txtID.Clear()
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtpmaddress.Clear()
                txtpraddress.Clear()
                txtcnumber.Clear()
                txtvaccinename.Clear()
                dtpfdate.Text = ""
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