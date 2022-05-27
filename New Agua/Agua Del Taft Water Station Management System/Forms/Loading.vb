Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPercent.Text = pbLoading.Value & "%"
        pbLoading.Value += 1
        If pbLoading.Value > 10 Then
            lblState.Text = "Loading Components..."
        End If

        If pbLoading.Value > 35 Then
            lblState.Text = "We making things ready..."
        End If

        If pbLoading.Value = 100 Then
            lblState.Text = "Almost there..."
            Homepage.Show()
            Me.Hide()
            Timer1.Dispose()
        End If

    End Sub
End Class