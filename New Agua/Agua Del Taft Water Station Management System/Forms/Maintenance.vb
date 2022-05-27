Imports System.Data.SqlClient
Public Class Maintenance
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\02-023\Documents\AguaDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        If txtCategory.Text = "" Then
            MsgBox("Please Enter A Category")
        Else
            Con.Open()
            Dim query = "INSERT INTO categorytbl VALUES('" & txtCategory.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Successfully Added")
            Con.Close()
            txtCategory.Text = ""
            FillCategory()
        End If

    End Sub

    Private Sub Reset()
        txtItemName.Text = ""
        txtPrice.Text = ""
        cmbCategory.SelectedIndex = 0
        txtQuantity.Text = ""
    End Sub

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
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()

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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If cmbCategory.SelectedIndex = -1 Or txtItemName.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
                MsgBox("Missing Information")
            Else
                Con.Open()
                Dim query = "INSERT INTO itemtbl(ItName,ItCat,ItPrice,ItQty) VALUES('" & txtItemName.Text & "','" & cmbCategory.SelectedValue.ToString() & "'," & txtPrice.Text & "," & txtQuantity.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Successfully Added")
                Con.Close()
                Reset()
                DisplayItem()

            End If


    End Sub

    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        txtItemName.Text = row.Cells(1).Value.ToString
        cmbCategory.SelectedValue = row.Cells(2).Value.ToString
        txtPrice.Text = row.Cells(3).Value.ToString
        txtQuantity.Text = row.Cells(4).Value.ToString
        If txtItemName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Please Select An Item To Be Deleted")
        Else
            Con.Open()
            Dim query = "DELETE FROM itemtbl WHERE ItId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Successfully Deleted")
            Con.Close()
            Reset()
            DisplayItem()

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If cmbCategory.SelectedIndex = -1 Or txtItemName.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "UPDATE itemtbl SET ItName = '" & txtItemName.Text & "', ItCat = '" & cmbCategory.SelectedValue.ToString() & "',ItPrice = " & txtPrice.Text & ",ItQty = " & txtQuantity.Text & " WHERE ItId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Successfully Edited")
            Con.Close()
            Reset()
            DisplayItem()

        End If

    End Sub


End Class