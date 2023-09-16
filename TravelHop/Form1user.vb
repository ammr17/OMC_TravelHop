Public Class frmHotelBooking


    Private Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNEXT.Click

        If rbtKualaLumpur.Checked = True Then
            FrmHotelsList.Show()
            Me.Hide()
        Else
            frmSelangorHotelsList.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        FrmUserHomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnNEXT_MouseEnter(sender As Object, e As EventArgs) Handles btnNEXT.MouseEnter
        btnNEXT.BackColor = Color.Thistle
    End Sub

    Private Sub btnNEXT_MouseLeave(sender As Object, e As EventArgs) Handles btnNEXT.MouseLeave
        btnNEXT.BackColor = Color.White
    End Sub
    Private Sub btnEXIT_MouseEnter(sender As Object, e As EventArgs) Handles btnEXIT.MouseEnter
        btnEXIT.BackColor = Color.Thistle
    End Sub

    Private Sub btnEXIT_MouseLeave(sender As Object, e As EventArgs) Handles btnEXIT.MouseLeave
        btnEXIT.BackColor = Color.White
    End Sub

End Class
