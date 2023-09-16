Public Class FrmPaymentDetails
    Private Sub btnPay_MouseEnter(sender As Object, e As EventArgs) Handles btnPay.MouseEnter
        btnPay.BackColor = Color.Thistle
    End Sub

    Private Sub btnPay_MouseLeave(sender As Object, e As EventArgs) Handles btnPay.MouseLeave
        btnPay.BackColor = Color.White
    End Sub
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.Thistle
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.White
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FrmUserHomePage.Show()
        FrmCarBooking.Close()
        Me.Close()
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        If txtName.Text = "" Or txtEmail.Text = "" Or mskPhoneNum.Text = "" Then
            MsgBox("One or more field(s) is not filled.", MsgBoxStyle.Exclamation, "Payment")
            Exit Sub
        End If

        If FrmUserHomePage.selectedService = "Car" Then
            lblNameCarResult.Text = txtName.Text
            lblEmailCarResult.Text = txtEmail.Text
            lblPhoneCarResult.Text = mskPhoneNum.Text
        Else
            lblHotelNameResult.Text = txtName.Text
            lblEmailHotelResult.Text = txtEmail.Text
            lblPhoneHotelResult.Text = mskPhoneNum.Text
        End If

        FrmPaymentCard.Show()
        Me.Hide()

    End Sub

    Private Sub FrmPaymentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtEmail.Enabled = True
        txtGuestName.Enabled = True
        txtName.Enabled = True
        mskPhoneNum.Enabled = True

        lblCarType.Enabled = True
        lblSeats.Enabled = True
        lblPickUp.Enabled = True
        lblDropOff.Enabled = True
        lblPrice.Enabled = True

        Dim strFind As String
        strFind = FrmUserLogin.userAccount


        Dim find_record = From user In OMC_TravelHopDataSet.Customer
                          Where user.UserName = strFind
                          Select user

        CustomerBindingSource.DataSource = find_record.AsDataView

        If FrmUserHomePage.selectedService = "Car" Then

            Me.RentalCarBindingSource.AddNew()

            lblUsernameCar.Text = FrmUserLogin.userAccount

            Dim timeSpan As TimeSpan = FrmCarList.selectedDropOff.Subtract(FrmCarList.selectedPickUp)

            grbCarSummary.Visible = True
            lblTotalResultCar.Visible = True

            lblCarType.Text = FrmCarList.selectedCarType
            lblSeats.Text = FrmCarList.selectedCarSeat
            lblPrice.Text = FrmCarList.selectedCarPrice
            lblDropOff.Text = FrmCarList.selectedDropOff & ", " & vbNewLine & FrmCarList.selectedDropOffPlace
            lblPickUp.Text = FrmCarList.selectedPickUp & ", " & vbNewLine & FrmCarList.selectedPickUpPlace
            lblTotalResultCar.Text = Format((timeSpan.Days + 1) * Val(FrmCarList.selectedCarPrice), "Currency")

        ElseIf FrmUserHomePage.selectedService = "Hotel" Then

            Me.BookingHotelBindingSource.AddNew()

            lblUsernameHotel.Text = FrmUserLogin.userAccount

            Dim timeSpan As TimeSpan = FrmHotelsList.selectedCheckOut.Subtract(FrmHotelsList.selectedCheckIn)

            grbHotelSummary.Visible = True
            lblTotalResultHotel.Visible = True

            lblHotel.Text = FrmHotelsList.selectedHotel
            lblRoomType.Text = FrmHotelsList.selectedRoomType
            lblBreakfast.Text = FrmHotelsList.selectedBreakfast
            lblCheckIn.Text = FrmHotelsList.selectedCheckIn
            lblCheckOut.Text = FrmHotelsList.selectedCheckOut
            lblTotalResultHotel.Text = Format((timeSpan.Days) * Val(FrmHotelsList.selectedPrice), "Currency")

        End If

    End Sub

    Private Sub rbtIAmGuest_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIAmGuest.CheckedChanged
        'TODO: This line of code loads data into the 'TravelHopDataSet.User' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)
    End Sub

    Private Sub rbtAnotherPerson_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAnotherPerson.CheckedChanged

        txtName.Clear()
        txtEmail.Clear()
        mskPhoneNum.Clear()

        'grbGuestName.Visible = True
        'txtGuestName.Enabled = True

    End Sub

End Class