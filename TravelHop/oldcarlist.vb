Public Class oldcarlist
    Public selectedCarType As String
    Public selectedCarSeat As String
    Public selectedCarPrice As String
    Private Sub btnFortuner_MouseEnter(sender As Object, e As EventArgs) Handles btnFortuner.MouseEnter
        btnFortuner.BackColor = Color.Thistle
    End Sub

    Private Sub btnFortuner_MouseLeave(sender As Object, e As EventArgs) Handles btnFortuner.MouseLeave
        btnFortuner.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnMyvi_MouseEnter(sender As Object, e As EventArgs) Handles btnMyvi.MouseEnter
        btnMyvi.BackColor = Color.Thistle
    End Sub

    Private Sub btnMyvi_MouseLeave(sender As Object, e As EventArgs) Handles btnMyvi.MouseLeave
        btnMyvi.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnSaga_MouseEnter(sender As Object, e As EventArgs) Handles btnSaga.MouseEnter
        btnSaga.BackColor = Color.Thistle
    End Sub

    Private Sub btnSaga_MouseLeave(sender As Object, e As EventArgs) Handles btnSaga.MouseLeave
        btnSaga.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnAxia_MouseEnter(sender As Object, e As EventArgs) Handles btnAxia.MouseEnter
        btnAxia.BackColor = Color.Thistle
    End Sub

    Private Sub btnAxia_MouseLeave(sender As Object, e As EventArgs) Handles btnAxia.MouseLeave
        btnAxia.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmUserHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnFortuner_Click(sender As Object, e As EventArgs) Handles btnFortuner.Click
        selectedCarType = lblFortuner.Text
        selectedCarSeat = lblSeatFortuner.Text
        selectedCarPrice = lblFortunerPrice.Text

        FrmCarBooking.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyvi_Click(sender As Object, e As EventArgs) Handles btnMyvi.Click
        selectedCarType = lblMyvi.Text
        selectedCarSeat = lblSeatMyvi.Text
        selectedCarPrice = lblMyviPrice.Text

        FrmCarBooking.Show()
        Me.Hide()
    End Sub

    Private Sub btnSaga_Click(sender As Object, e As EventArgs) Handles btnSaga.Click
        selectedCarType = lblSaga.Text
        selectedCarSeat = lblSeatSaga.Text
        selectedCarPrice = lblSagaPrice.Text

        FrmCarBooking.Show()
        Me.Hide()
    End Sub

    Private Sub btnAxia_Click(sender As Object, e As EventArgs) Handles btnAxia.Click
        selectedCarType = lblAxia.Text
        selectedCarSeat = lblSeatAxia.Text
        selectedCarPrice = lblAxiaPrice.Text

        FrmCarBooking.Show()
        Me.Hide()
    End Sub
End Class