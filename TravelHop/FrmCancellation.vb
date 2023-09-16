Public Class FrmCancellation

    Dim cancellationFee As Double
    Dim refund As Double
    Private Sub btnConfirm_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        btnConfirm.BackColor = Color.Thistle
    End Sub

    Private Sub btnConfirm_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        btnConfirm.BackColor = Color.White
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmUserBookings.Show()
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If FrmUserBookings.selectedServiceCancel = "Hotel" Then
            refund = CDbl(FrmUserBookings.hotelPrice) * 0.75

            FrmUserBookings.BookingHotelBindingSource.RemoveCurrent()

            FrmUserBookings.Validate()
            FrmUserBookings.BookingHotelBindingSource.EndEdit()
            FrmUserBookings.BookingHotelTableAdapter.Update(FrmUserBookings.OMC_TravelHopDataSet.BookingHotel)
            FrmUserBookings.BookingHotelTableAdapter.Fill(FrmUserBookings.OMC_TravelHopDataSet.BookingHotel)
        Else
            refund = CDbl(FrmUserBookings.carPrice) * 0.75

            FrmUserBookings.RentalCarBindingSource.RemoveCurrent()

            FrmUserBookings.Validate()
            FrmUserBookings.RentalCarBindingSource.EndEdit()
            FrmUserBookings.RentalCarTableAdapter.Update(FrmUserBookings.OMC_TravelHopDataSet.RentalCar)
            FrmUserBookings.RentalCarTableAdapter.Fill(FrmUserBookings.OMC_TravelHopDataSet.RentalCar)

        End If

        MsgBox("Your booking has been cancelled. Your refund of " & Format(refund, "Currency") & " has been transferred.", MsgBoxStyle.Information, "Booking Cancellation")

        FrmUserBookings.Close()
        FrmUserBookings.Show()
        Me.Close()

    End Sub

    Private Sub rbtDifferentAccomodation_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDifferentAccomodation.CheckedChanged
        btnConfirm.Enabled = True
        txtOtherReason.Enabled = False
    End Sub

    Private Sub rbtHealth_CheckedChanged(sender As Object, e As EventArgs) Handles rbtHealth.CheckedChanged
        btnConfirm.Enabled = True
        txtOtherReason.Enabled = False
    End Sub

    Private Sub rbtChangeDate_CheckedChanged(sender As Object, e As EventArgs) Handles rbtChangeDate.CheckedChanged
        btnConfirm.Enabled = True
        txtOtherReason.Enabled = False
    End Sub

    Private Sub rbtPersonalReason_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPersonalReason.CheckedChanged
        btnConfirm.Enabled = True
        txtOtherReason.Enabled = False
    End Sub

    Private Sub rbtOther_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOther.CheckedChanged
        btnConfirm.Enabled = True
        txtOtherReason.Enabled = True
    End Sub

    Private Sub FrmCancellation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FrmUserBookings.selectedServiceCancel = "Car" Then

            cancellationFee = CDbl(FrmUserBookings.carPrice) * 0.25

            lblFeeResult.Text = Format(cancellationFee, "Currency")
        Else

            cancellationFee = CDbl(FrmUserBookings.hotelPrice) * 0.25

            lblFeeResult.Text = Format(cancellationFee, "Currency")
        End If

    End Sub

End Class