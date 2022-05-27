Imports System.Data.SqlClient
Public Class Sales_Report
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\02-023\Documents\AguaDb.mdf;Integrated Security=True;Connect Timeout=30")


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Sales Report", New Font("Arial", 22), Brushes.Crimson, 355, 35)
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 90)

    End Sub

    Private Sub DisplaySales()

        Con.Open()
        Dim query = "SELECT OrdId AS 'ID', OrdName AS 'Name', OrdAddress AS 'Address', OrdType AS 'Type', OrdContact AS 'Contact#', OrdCategory AS 'Category', OrdContainer AS 'Container', OrdQuantity AS 'Quantity', OrdTotalPrice AS 'Total Price', OrdDate AS 'Date'  FROM ordertbl"
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
        Dim query = "SELECT OrdId AS 'ID', OrdName AS 'Name', OrdAddress AS 'Address', OrdType AS 'Type', OrdContact AS 'Contact#', OrdCategory AS 'Category', OrdContainer AS 'Container', OrdQuantity AS 'Quantity', OrdTotalPrice AS 'Total Price', OrdDate AS 'Date' FROM ordertbl WHERE CONCAT (OrdName,OrdType,OrdAddress,OrdCategory,OrdContainer,OrdDate) LIKE '%" & valueToSearch & "%'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Sales_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySales()
        FilterData("")
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        FilterData(txtFilter.Text)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Show()
    End Sub


End Class