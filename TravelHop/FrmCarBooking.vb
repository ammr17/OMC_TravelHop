Public Class FrmCarBooking

    Private Sub btnNext_MouseEnter(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        btnNext.BackColor = Color.Thistle
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        btnNext.BackColor = Color.White
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmCarList.Show()
        Me.Close()
    End Sub

    Private Sub FrmCarBooking_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblCarType.Text &= vbNewLine & FrmCarList.selectedCarType
        lblSeats.Text &= vbNewLine & FrmCarList.selectedCarSeat
        lblPrice.Text &= vbNewLine & FrmCarList.selectedCarPrice
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If cboDropOff.SelectedItem = "" Or cboPickUp.SelectedItem = "" Or cboPickupTime.SelectedItem = "" Or cboDropoffTime.SelectedItem = "" Then
            MsgBox("One or more field(s) is not filled.", MsgBoxStyle.Exclamation, "Car Booking")
            Exit Sub
        End If

        FrmCarList.selectedPickUp = MonthCalendar1.SelectionRange.Start
        FrmCarList.selectedDropOff = MonthCalendar2.SelectionRange.Start
        FrmCarList.selectedPickUpPlace = cboPickUp.SelectedItem
        FrmCarList.selectedDropOffPlace = cboDropOff.SelectedItem
        FrmPaymentDetails.Show()
        Me.Hide()

    End Sub

End Class
