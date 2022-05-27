Imports System.Data.SqlClient
Public Class Dashboard
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\02-023\Documents\AguaDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim todayDate As DateTime = Now
    Dim datenow As String = todayDate.ToString("dd MMMM yyyy")
    Public cmd As New SqlCommand
    Public adapter As New SqlDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public ds3 As New DataSet
    Public ds4 As New DataSet
    Public ds5 As New DataSet
    Public ds6 As New DataSet
    Public ds7 As New DataSet
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTotalSalesToday()
        loadTotalGallonRefilled()
        loadTotalGallonRound()
        loadTotalGallonSlim()
        loadExpensesToday()
        loadTotalGallonStock()
        loadTotalRoundStock()
        loadTotalSlimStock()
    End Sub

    Private Sub loadTotalSalesToday()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT SUM(OrdTotalPrice) AS 'Total' FROM ordertbl WHERE OrdDate = '" & datenow & "'"
        adapter.SelectCommand = cmd
        ds.Clear()
        adapter.Fill(ds, "TotalSales")

        lblTotalSales.DataBindings.Add("Text", ds, "TotalSales.Total")
        lblTotalSales.DataBindings.Clear()
        Con.close()


    End Sub

    Private Sub loadTotalGallonRefilled()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT SUM(OrdQuantity) AS 'TotalQuantity' FROM ordertbl WHERE OrdContainer = 'Slim' AND OrdDate = '" & datenow & "' OR OrdContainer = 'Round' AND OrdDate = '" & datenow & "'"
        adapter.SelectCommand = cmd
        ds1.Clear()
        adapter.Fill(ds1, "TotalRefill")

        lblTotalGallonReffiled.DataBindings.Add("Text", ds1, "TotalRefill.TotalQuantity")
        lblTotalGallonReffiled.DataBindings.Clear()
        Con.close()

    End Sub

    Private Sub loadTotalGallonRound()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT SUM(OrdQuantity) AS 'TotalRoundQuantity' FROM ordertbl WHERE OrdContainer = 'Round' AND OrdDate = '" & datenow & "'"
        adapter.SelectCommand = cmd
        ds2.Clear()
        adapter.Fill(ds2, "TotalRoundRefill")

        lblTotalGallonRound.DataBindings.Add("Text", ds2, "TotalRoundRefill.TotalRoundQuantity")
        lblTotalGallonRound.DataBindings.Clear()
        Con.close()
    End Sub

    Private Sub loadTotalGallonSlim()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT SUM(OrdQuantity) AS 'TotalSlimQuantity' FROM ordertbl WHERE OrdContainer = 'Slim' AND OrdDate = '" & datenow & "'"
        adapter.SelectCommand = cmd
        ds3.Clear()
        adapter.Fill(ds3, "TotalSlimRefill")

        lblTotalGallonSlim.DataBindings.Add("Text", ds3, "TotalSlimRefill.TotalSlimQuantity")
        lblTotalGallonSlim.DataBindings.Clear()
        Con.close()
    End Sub

    Private Sub loadExpensesToday()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT SUM(expensesPrice) AS 'TodayExpenses' FROM expensestbl WHERE expensesDate = '" & datenow & "'"
        adapter.SelectCommand = cmd
        ds4.Clear()
        adapter.Fill(ds4, "TotalExpenses")

        lblTodayExpenses.DataBindings.Add("Text", ds4, "TotalExpenses.TodayExpenses")
        lblTodayExpenses.DataBindings.Clear()
        Con.close()
    End Sub

    Private Sub loadTotalGallonStock()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT SUM(ItQty) AS 'TotalStockQuantity' FROM itemtbl WHERE ItName = 'Round Container' OR ItName = 'Slim w/ Faucet'"
        ds5.Clear()
        adapter.Fill(ds5, "TotalStock")

        lblGallonStock.DataBindings.Add("Text", ds5, "TotalStock.TotalStockQuantity")
        lblGallonStock.DataBindings.Clear()
        Con.close()
    End Sub

    Private Sub loadTotalRoundStock()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT ItQty AS 'TotalRoundQuantity' FROM itemtbl WHERE ItName = 'Round Container'"
        ds6.Clear()
        adapter.Fill(ds6, "TotalRoundStock")

        lblGallonStockRound.DataBindings.Add("Text", ds6, "TotalRoundStock.TotalRoundQuantity")
        lblGallonStockRound.DataBindings.Clear()
        Con.close()
    End Sub

    Private Sub loadTotalSlimStock()
        Con.Open()

        cmd.Connection = Con
        cmd.CommandText = "SELECT ItQty AS 'TotalSlimQuantity' FROM itemtbl WHERE ItName = 'Slim w/ Faucet'"
        ds7.Clear()
        adapter.Fill(ds7, "TotalSlimStock")

        lblGallonStockSlim.DataBindings.Add("Text", ds7, "TotalSlimStock.TotalSlimQuantity")
        lblGallonStockSlim.DataBindings.Clear()
        Con.close()
    End Sub
End Class