Imports System.Data.SqlClient
Public Class Stocks_And_Expenses
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\02-023\Documents\AguaDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim todayDate As DateTime = Now
    Dim datenow As String = todayDate.ToString("dd MMMM yyyy")

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Con.Open()
        Dim query = "INSERT INTO expensestbl VALUES ('" & txtName.Text & "', '" & txtDescription.Text & "', " & txtPrice.Text & ", '" & datenow & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Submited")
        Con.Close()
        DisplayExpenses()
    End Sub

    Private Sub DisplayExpenses()
        Con.Open()
        Dim query = "SELECT expensesName AS 'Name', expensesDes AS 'Description', expensesPrice As 'Price', expensesDate AS 'Date' FROM expensestbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub FilterData(valueToSearch As String)
        Con.Open()
        Dim query = "SELECT expensesName AS 'Name', expensesDes AS 'Description', expensesPrice As 'Price', expensesDate AS 'Date' FROM expensestbl WHERE CONCAT (expensesName,expensesDate) LIKE '%" & valueToSearch & "%'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    Private Sub Stocks_And_Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayExpenses()
        FilterData("")
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        FilterData(txtFilter.Text)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Expenses", New Font("Arial", 22), Brushes.Crimson, 355, 35)
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 90)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class