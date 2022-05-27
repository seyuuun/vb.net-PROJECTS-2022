Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter Username and Password")
        ElseIf txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
            txtPassword.Text = ""
            txtUsername.Text = ""
        End If

    End Sub

    Private Sub lblSeller_Click(sender As Object, e As EventArgs) Handles lblSeller.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
