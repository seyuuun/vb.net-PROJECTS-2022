Imports MySql.Data.MySqlClient
Public Class ViewOrders
    Dim Con = New MySqlConnection("server=localhost;user id=root;database=cafe_db")
    Private Sub DisplayBill()
        Con.Open()
        Dim query = "SELECT * FROM ordertbl"
        Dim cmd = New MySqlCommand(query, Con)
        Dim adapter = New MySqlDataAdapter(cmd)
        Dim builder = New MySqlCommandBuilder(adapter)
        builder = New MySqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        OrdersDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub
End Class