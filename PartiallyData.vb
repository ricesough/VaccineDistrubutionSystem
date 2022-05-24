Imports MySql.Data.MySqlClient

Public Class PartiallyData
    Private Sub PartiallyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()
        loadTable3()
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM partiallyvaccinated WHERE P_StatusID='" & txtID.Text & "'"
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

            txtID.DataBindings.Add("Text", data, "Data.P_StatusID")
            txtID.DataBindings.Clear()

            txtvname1.DataBindings.Add("Text", data, "Data.VaccineName")
            txtvname1.DataBindings.Clear()

            dtpfdate1.DataBindings.Add("Text", data, "Data.FirstDoseDate")
            dtpfdate1.DataBindings.Clear()

            dtptsdate1.DataBindings.Add("Text", data, "Data.TargetSecondDoseDate")
            dtptsdate1.DataBindings.Clear()

            If txtID.Text = "" Then
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtpmaddress.Clear()
                txtpraddress.Clear()
                txtcnumber.Clear()
                txtvname1.Clear()
                dtpfdate1.Text = ""
                dtptsdate1.Text = ""
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub loadTable3()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM partiallyvaccinated"
            adapter.SelectCommand = cmd
            table3.Clear()
            adapter.Fill(table3)
            DataGridView1.DataSource = table3
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtID.Text = DataGridView1.Item("P_StatusID", DataGridView1.CurrentRow.Index).Value
        txtfname.Text = DataGridView1.Item("FirstName", DataGridView1.CurrentRow.Index).Value
        txtmname.Text = DataGridView1.Item("MiddleName", DataGridView1.CurrentRow.Index).Value
        txtlname.Text = DataGridView1.Item("LastName", DataGridView1.CurrentRow.Index).Value
        txtpmaddress.Text = DataGridView1.Item("PermanentAddress", DataGridView1.CurrentRow.Index).Value
        txtpraddress.Text = DataGridView1.Item("PresentAddress", DataGridView1.CurrentRow.Index).Value
        txtcnumber.Text = DataGridView1.Item("ContactNumber", DataGridView1.CurrentRow.Index).Value
        txtvname1.Text = DataGridView1.Item("VaccineName", DataGridView1.CurrentRow.Index).Value
        dtpfdate1.Text = DataGridView1.Item("FirstDoseDate", DataGridView1.CurrentRow.Index).Value
        dtptsdate1.Text = DataGridView1.Item("TargetSecondDoseDate", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE
                                    partiallyvaccinated
                                SET
                                    P_StatusID = '" & txtID.Text & "',
                                    FirstName = '" & txtfname.Text & "',
                                    MiddleName = '" & txtmname.Text & "',
                                    LastName = '" & txtlname.Text & "',
                                    PermanentAddress = '" & txtpmaddress.Text & "',
                                    PresentAddress = '" & txtpraddress.Text & "',
                                    ContactNumber = '" & txtcnumber.Text & "',
                                    VaccineName = '" & txtvname1.Text & "',
                                    FirstDoseDate = '" & dtpfdate1.Text & "',
                                    TargetSecondDoseDate = '" & dtptsdate1.Text & "'
                                WHERE
                                    P_StatusID = '" & txtID.Text & "'"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Updated Succesfully!")
            Call loadTable3()
            txtID.Clear()
            txtfname.Clear()
            txtmname.Clear()
            txtlname.Clear()
            txtpmaddress.Clear()
            txtpraddress.Clear()
            txtcnumber.Clear()
            txtvname1.Clear()
            dtpfdate1.Text = ""
            dtptsdate1.Text = ""
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
                cmd.CommandText = "DELETE FROM partiallyvaccinated WHERE P_StatusID = '" & txtID.Text & "'"
                con.Open()
                Dim mysc As New MySqlCommand(cmd.CommandText, con)
                mysc.ExecuteNonQuery()
                MsgBox(“Data Deleted!”, MsgBoxStyle.Information)
                con.Close()
                Call loadTable3()
                txtID.Clear()
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtpmaddress.Clear()
                txtpraddress.Clear()
                txtcnumber.Clear()
                txtvname1.Clear()
                dtpfdate1.Text = ""
                dtptsdate1.Text = ""
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