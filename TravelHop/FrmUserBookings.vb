Public Class FrmUserBookings
    Public selectedServiceCancel As String
    Public carPrice As String
    Public hotelPrice As String
    Private Sub btnCancelBooking_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelBooking.MouseEnter
        btnCancelBooking.BackColor = Color.Thistle
    End Sub

    Private Sub btnCancelBooking_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelBooking.MouseLeave
        btnCancelBooking.BackColor = Color.White
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmUserHomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelBooking_Click(sender As Object, e As EventArgs) Handles btnCancelBooking.Click

        If selectedServiceCancel = "Car" Then
            carPrice = lblTotalPriceCar.Text.Remove(0, 2)
        Else
            hotelPrice = lblTotalPriceHotel.Text.Remove(0, 2)
        End If

        FrmCancellation.Show()
        Me.Hide()

    End Sub

    Private Sub FrmUserBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.RentalCar' table. You can move, or remove it, as needed.
        Me.RentalCarTableAdapter.Fill(Me.OMC_TravelHopDataSet.RentalCar)
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.BookingHotel' table. You can move, or remove it, as needed.
        Me.BookingHotelTableAdapter.Fill(Me.OMC_TravelHopDataSet.BookingHotel)

        Dim strFind As String
        strFind = FrmUserLogin.userAccount

        Dim find_record_car = From user In OMC_TravelHopDataSet.RentalCar
                              Where user.UserName Like strFind & "*"
                              Select user

        Dim find_record_hotel = From user In OMC_TravelHopDataSet.BookingHotel
                                Where user.UserName Like strFind & "*"
                                Select user

        BookingHotelBindingSource.DataSource = find_record_hotel.AsDataView
        RentalCarBindingSource.DataSource = find_record_car.AsDataView

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        selectedServiceCancel = "Hotel"

        btnCancelBooking.Enabled = True
        btnViewBooking.Enabled = True

        DataGridView2.ClearSelection()

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        selectedServiceCancel = "Car"

        btnCancelBooking.Enabled = True
        btnViewBooking.Enabled = True

        DataGridView1.ClearSelection()

    End Sub

    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewBooking.Click
        If selectedServiceCancel = "Hotel" Then
            panelHotelTicket.Visible = True
        ElseIf selectedServiceCancel = "Car" Then
            panelCarTicket.Visible = True
        End If
    End Sub

    Private Sub btnCloseHotel_Click(sender As Object, e As EventArgs) Handles btnCloseHotel.Click

        panelHotelTicket.Visible = False
        panelHotelTicket.BringToFront()
        panelBackColor.SendToBack()

    End Sub

    Private Sub btnCloseCar_Click(sender As Object, e As EventArgs) Handles btnCloseCar.Click

        panelCarTicket.Visible = False
        panelCarTicket.BringToFront()
        panelBackColor.SendToBack()

    End Sub

    Private Sub btnFeedbackHotel_Click(sender As Object, e As EventArgs) Handles btnFeedbackHotel.Click
        FrmFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub btnFeedbackCar_Click(sender As Object, e As EventArgs) Handles btnFeedbackCar.Click
        FrmFeedback.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewBooking_MouseEnter(sender As Object, e As EventArgs) Handles btnViewBooking.MouseEnter
        btnViewBooking.BackColor = Color.Thistle
    End Sub

    Private Sub btnViewBooking_MouseLeave(sender As Object, e As EventArgs) Handles btnViewBooking.MouseLeave
        btnViewBooking.BackColor = Color.White
    End Sub

End Class