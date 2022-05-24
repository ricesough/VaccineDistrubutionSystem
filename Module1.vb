Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public table2 As New DataTable
    Public table3 As New DataTable
    Public table4 As New DataTable
    Public table5 As New DataTable
    Public table6 As New DataTable
    Public table7 As New DataTable
    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=;database=covid19vaccinedistributionsystem"
        con.Open()
    End Sub
End Module