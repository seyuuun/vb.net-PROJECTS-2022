Imports MySql.Data.MySqlClient
Public Class Orders
    Dim Con = New MySqlConnection("server=localhost;user id=root;database=cafe_db")
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New MySqlCommand("SELECT * FROM categorytbl", Con)
        Dim adapter = New MySqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        cmbItemCategory.DataSource = Tbl
        cmbItemCategory.DisplayMember = "CatName"
        cmbItemCategory.ValueMember = "CatName"
        Con.Close()
    End Sub

    Private Sub DisplayItem()
        Con.Open()
        Dim query = "SELECT ItId AS 'ID',ItName As Name,ItCat As Category,ItPrice As Price FROM itemtbl"
        '"SELECT * FROM itemtbl"
        Dim cmd = New MySqlCommand(query, Con)
        Dim adapter = New MySqlDataAdapter(cmd)
        Dim builder = New MySqlCommandBuilder(adapter)
        builder = New MySqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "SELECT * FROM itemtbl WHERE ItCat = '" & cmbItemCategory.SelectedValue.ToString & "'"
        Dim cmd = New MySqlCommand(query, Con)
        Dim adapter = New MySqlDataAdapter(cmd)
        Dim builder = New MySqlCommandBuilder(adapter)
        builder = New MySqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()
    End Sub

    Private Sub cmbItemCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbItemCategory.SelectionChangeCommitted
        FilterByCategory()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DisplayItem()
    End Sub
    Dim ProdName As String
    Dim i = 0, GrdTotal = 0, price, qty
    Private Sub AddBill()
        Con.Open()
        Dim query = "INSERT INTO ordertbl(OrdDate,OrdAmt) VALUES('" & DateTime.Today.Date & "', '" & GrdTotal & "')"
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Bill Added")
        Con.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        AddBill()
        PrintPreviewDialog1.Show()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Cafe Shop", New Font("Arial", 22), Brushes.BlueViolet, 355, 35)
        e.Graphics.DrawString("===Your Bill===", New Font("Arial", 14), Brushes.BlueViolet, 350, 60)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Total Amount" + GrdTotal.ToString(), New Font("Arial", 15), Brushes.Crimson, 325, 580)
        e.Graphics.DrawString("===============Thanks For Visiting===============", New Font("Arial", 15), Brushes.Crimson, 130, 600)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        Dim Obj = New ViewOrders
        Obj.Show()
        Me.Hide()
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If key = 0 Then
            MsgBox("Select an Item")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            Dim total = Convert.ToInt32(txtQuantity.Text) * price
            i += 1
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProdName
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = price
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = txtQuantity.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal += total
            lblTotal.Text = "₱" + Convert.ToString(GrdTotal)
            txtQuantity.Text = ""
            key = 0
        End If
    End Sub

    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString
        If ProdName = "" Then
            key = 0

        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub
End Class