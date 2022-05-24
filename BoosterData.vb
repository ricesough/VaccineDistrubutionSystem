Imports MySql.Data.MySqlClient

Public Class BoosterData
    Private Sub BoosterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()
        loadTable5()
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM booster WHERE B_StatusID='" & txtID.Text & "'"
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

            txtID.DataBindings.Add("Text", data, "Data.B_StatusID")
            txtID.DataBindings.Clear()

            txtvname2.DataBindings.Add("Text", data, "Data.VaccineName")
            txtvname2.DataBindings.Clear()

            dtpfdate2.DataBindings.Add("Text", data, "Data.FirstDoseDate")
            dtpfdate2.DataBindings.Clear()

            dtptsdate2.DataBindings.Add("Text", data, "Data.SecondDoseDate")
            dtptsdate2.DataBindings.Clear()

            dtptbd.DataBindings.Add("Text", data, "Data.BoosterDate")
            dtptbd.DataBindings.Clear()

            dtpnbd.DataBindings.Add("Text", data, "Data.TargetNextBoosterDate")
            dtpnbd.DataBindings.Clear()
            If txtID.Text = "" Then
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtpmaddress.Clear()
                txtpraddress.Clear()
                txtcnumber.Clear()
                txtvname2.Clear()
                dtpfdate2.Text = ""
                dtptsdate2.Text = ""
                dtptbd.Text = ""
                dtpnbd.Text = ""
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Sub loadTable5()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM booster"
            adapter.SelectCommand = cmd
            table5.Clear()
            adapter.Fill(table5)
            DataGridView1.DataSource = table5
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtID.Text = DataGridView1.Item("B_StatusID", DataGridView1.CurrentRow.Index).Value
        txtfname.Text = DataGridView1.Item("FirstName", DataGridView1.CurrentRow.Index).Value
        txtmname.Text = DataGridView1.Item("MiddleName", DataGridView1.CurrentRow.Index).Value
        txtlname.Text = DataGridView1.Item("LastName", DataGridView1.CurrentRow.Index).Value
        txtpmaddress.Text = DataGridView1.Item("PermanentAddress", DataGridView1.CurrentRow.Index).Value
        txtpraddress.Text = DataGridView1.Item("PresentAddress", DataGridView1.CurrentRow.Index).Value
        txtcnumber.Text = DataGridView1.Item("ContactNumber", DataGridView1.CurrentRow.Index).Value
        txtvname2.Text = DataGridView1.Item("VaccineName", DataGridView1.CurrentRow.Index).Value
        dtpfdate2.Text = DataGridView1.Item("FirstDoseDate", DataGridView1.CurrentRow.Index).Value
        dtptsdate2.Text = DataGridView1.Item("SecondDoseDate", DataGridView1.CurrentRow.Index).Value
        dtptbd.Text = DataGridView1.Item("BoosterDate", DataGridView1.CurrentRow.Index).Value
        dtpnbd.Text = DataGridView1.Item("TargetNextBoosterDate", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE
                                    booster
                                SET
                                    B_StatusID =     '" & txtID.Text & "',
                                    FirstName = '" & txtfname.Text & "',
                                    MiddleName = '" & txtmname.Text & "',
                                    LastName = '" & txtlname.Text & "',
                                    PermanentAddress = '" & txtpmaddress.Text & "',
                                    PresentAddress = '" & txtpraddress.Text & "',
                                    ContactNumber = '" & txtcnumber.Text & "',
                                    VaccineName = '" & txtvname2.Text & "',
                                    FirstDoseDate = '" & dtpfdate2.Text & "',
                                    SecondDoseDate = '" & dtptsdate2.Text & "',
                                    BoosterDate = '" & dtptbd.Text & "',
                                    TargetNextBoosterDate = '" & dtpnbd.Text & "'
                                WHERE
                                    B_StatusID = '" & txtID.Text & "'"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Updated Succesfully!")
            Call loadTable5()
            txtID.Clear()
            txtfname.Clear()
            txtmname.Clear()
            txtlname.Clear()
            txtpmaddress.Clear()
            txtpraddress.Clear()
            txtcnumber.Clear()
            txtvname2.Clear()
            dtpfdate2.Text = ""
            dtptsdate2.Text = ""
            dtptbd.Text = ""
            dtpnbd.Text = ""
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
                cmd.CommandText = "DELETE FROM booster WHERE B_StatusID = '" & txtID.Text & "'"
                con.Open()
                Dim mysc As New MySqlCommand(cmd.CommandText, con)
                mysc.ExecuteNonQuery()
                MsgBox(“Data Deleted!”, MsgBoxStyle.Information)
                con.Close()
                Call loadTable5()
                txtID.Clear()
                txtfname.Clear()
                txtmname.Clear()
                txtlname.Clear()
                txtpmaddress.Clear()
                txtpraddress.Clear()
                txtcnumber.Clear()
                txtvname2.Clear()
                dtpfdate2.Text = ""
                dtptsdate2.Text = ""
                dtptbd.Text = ""
                dtpnbd.Text = ""
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