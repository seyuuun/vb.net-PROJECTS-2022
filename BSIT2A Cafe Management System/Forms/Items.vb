Imports MySql.Data.MySqlClient
Public Class Items
    Dim Con = New MySqlConnection("server=localhost;user id=root;database=cafe_db")
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        If txtCategory.Text = "" Then
            MsgBox("Enter The Category")
        Else
            Con.Open()
            Dim query = "INSERT INTO categorytbl(CatName) VALUES('" & txtCategory.Text & "')"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Added")
            Con.Close()
            txtCategory.Text = ""
            FillCategory()
        End If


    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub Reset()
        txtItemName.Text = ""
        txtItemPrice.Text = ""
        cmbItemCategory.SelectedIndex = 0
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
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "SELECT * FROM itemtbl"
        Dim cmd = New MySqlCommand(query, Con)
        Dim adapter = New MySqlDataAdapter(cmd)
        Dim builder = New MySqlCommandBuilder(adapter)
        builder = New MySqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbItemCategory.SelectedIndex = -1 Or txtItemName.Text = "" Or txtItemPrice.Text = "" Then
            MsgBox("Please Enter all the information in all fields")
        Else
            Con.Open()
            Dim query = "INSERT INTO itemtbl(ItName,ItCat,ItPrice) VALUES('" & txtItemName.Text & "', '" & cmbItemCategory.SelectedValue.ToString() & "', " & txtItemPrice.Text & ")"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Added")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub
    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        txtItemName.Text = row.Cells(1).Value.ToString
        cmbItemCategory.SelectedValue = row.Cells(2).Value.ToString
        txtItemPrice.Text = row.Cells(3).Value.ToString
        If txtItemName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Please Select Item To Be Deleted")
        Else
            Con.Open()
            Dim query = "DELETE FROM itemtbl WHERE ItId = " & key & ""
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Deleted Successfully")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cmbItemCategory.SelectedIndex = -1 Or txtItemName.Text = "" Or txtItemPrice.Text = "" Then
            MsgBox("Please Enter all the information in all fields")
        Else
            Con.Open()
            Dim query = "UPDATE itemtbl SET ItName = '" & txtItemName.Text & "', ItCat = '" & cmbItemCategory.SelectedValue & "', ItPrice = " & txtItemPrice.Text & " WHERE ItId = " & key & ""
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Edited Successfully")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub
End Class