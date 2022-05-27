Imports System.Data.SqlClient
Public Class Sales
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\02-023\Documents\AguaDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("SELECT * FROM categorytbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        cmbCategory.DataSource = Tbl
        cmbCategory.DisplayMember = "CatName"
        cmbCategory.ValueMember = "CatName"
        Con.Close()
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "SELECT ItId As 'ID',ItName As 'Name',ItCat As 'Category',ItPrice As 'Price',ItQty As 'Quantity' FROM itemtbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "SELECT ItId As 'ID',ItName As 'Name',ItCat As 'Category',ItPrice As 'Price',ItQty As 'Quantity' FROM itemtbl WHERE ItCat = '" & cmbCategory.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()
    End Sub

    Private Sub cmbCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategory.SelectionChangeCommitted
        FilterByCategory()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DisplayItem()
    End Sub

    Dim ProdName As String
    Dim Category As String
    Dim i = 0, GrdTotal = 0, price, qty

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Controls.Clear()
        InitializeComponent()
        Sales_Load(e, e)
    End Sub
    Private Sub UpdateItem()
        Dim newQty = stock - Convert.ToInt32(txtQuantity.Text)
        Con.Open()
        Dim query = "UPDATE itemtbl SET ItQty = " & newQty & " WHERE ItId = " & key & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        'Reset()
        DisplayItem()


    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If key = 0 Then
            MsgBox("Select A Item")
        ElseIf Convert.ToInt32(txtQuantity.Text) > stock Then
            MsgBox("Not enough Stock")
        Else
            Dim todayDate As DateTime = Now
            Dim datenow As String = todayDate.ToString("dd MMMM yyyy")

            Dim rnum As Integer = BillDGV.Rows.Add()
            Dim fee As Integer
            If cmbType.SelectedItem = "Deliver" Then
                fee = 5
            ElseIf cmbType.SelectedItem = "Walk in" Then
                fee = 0
            End If
            Dim total = Convert.ToInt32(txtQuantity.Text) * price
            i += 1
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = Convert.ToString(txtName.Text)
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = Convert.ToString(cmbType.SelectedItem)
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = Convert.ToString(txtContact.Text)
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = Convert.ToString(txtAddress.Text)
            BillDGV.Rows.Item(rnum).Cells("Column6").Value = ProdName
            BillDGV.Rows.Item(rnum).Cells("Column7").Value = price
            BillDGV.Rows.Item(rnum).Cells("Column8").Value = txtQuantity.Text
            BillDGV.Rows.Item(rnum).Cells("Column9").Value = total
            GrdTotal += total
            lblTotalPrice.Text = Convert.ToString(GrdTotal) + fee
            UpdateItem()
            key = 0



            Con.Open()
            Dim query = "INSERT INTO ordertbl(OrdName,OrdType,OrdContact,OrdAddress,OrdCategory,OrdContainer,OrdQuantity,OrdTotalPrice,OrdDate) VALUES
                        ('" & txtName.Text & "', '" & cmbType.SelectedItem.ToString() & "', '" & txtContact.Text & "', '" & txtAddress.Text & "', '" & Category & "', '" & ProdName & "', " & txtQuantity.Text & ", '" & total & "', '" & datenow & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Successfully Added")
            Con.Close()



        End If
    End Sub

    Dim key = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString
        Category = row.Cells(2).Value.ToString
        If ProdName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)

        End If
    End Sub
End Class