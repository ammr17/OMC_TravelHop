Public Class FrmPaymentCard
    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        btnSubmit.BackColor = Color.Thistle
    End Sub
    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        btnSubmit.BackColor = Color.White
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
        FrmPaymentDetails.Close()
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If mskCardNumber.Text = "" Or cboMonth.SelectedItem = "" Or cboYear.SelectedItem = "" Or mskCVV.Text = "" Then
            MsgBox("One or more field(s) is not filled.", MsgBoxStyle.Exclamation, "Payment")
            Exit Sub
        End If

        If FrmUserHomePage.selectedService = "Car" Then
            FrmPaymentDetails.lblStatusCar.Text = "Pending Approval"
        Else
            FrmPaymentDetails.lblStatusHotel.Text = "Pending Approval"
        End If

        FrmPaymentDetails.Validate()

        FrmPaymentDetails.BookingHotelBindingSource.EndEdit()
        FrmPaymentDetails.BookingHotelTableAdapter.Update(FrmPaymentDetails.OMC_TravelHopDataSet.BookingHotel)
        FrmPaymentDetails.BookingHotelTableAdapter.Fill(FrmPaymentDetails.OMC_TravelHopDataSet.BookingHotel)

        FrmPaymentDetails.RentalCarBindingSource.EndEdit()
        FrmPaymentDetails.RentalCarTableAdapter.Update(FrmPaymentDetails.OMC_TravelHopDataSet.RentalCar)
        FrmPaymentDetails.RentalCarTableAdapter.Fill(FrmPaymentDetails.OMC_TravelHopDataSet.RentalCar)

        MsgBox("Payment Successful. Your booking will be accepted by the travel agency. Thank you!", MsgBoxStyle.Information, "Payment")

        Me.Close()

        FrmPaymentDetails.Close()
        FrmUserHomePage.Show()

    End Sub

    Private Sub FrmPaymentCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.BookingHotel' table. You can move, or remove it, as needed.
        Me.BookingHotelTableAdapter.Fill(Me.OMC_TravelHopDataSet.BookingHotel)
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.RentalCar' table. You can move, or remove it, as needed.
        Me.RentalCarTableAdapter.Fill(Me.OMC_TravelHopDataSet.RentalCar)

        Dim strFind As String
        strFind = FrmUserLogin.userAccount


        Dim find_record = From user In OMC_TravelHopDataSet.Customer
                          Where user.UserName = strFind
                          Select user

        CustomerBindingSource.DataSource = find_record.AsDataView

    End Sub

End Class