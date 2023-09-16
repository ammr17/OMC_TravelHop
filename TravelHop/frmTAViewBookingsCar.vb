Public Class frmTAViewBookingsCar
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmTABookingsCar.Show()
        Me.Close()
    End Sub

    Private Sub frmTAViewBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.BookingHotel' table. You can move, or remove it, as needed.
        Me.RentalCarTableAdapter.Fill(Me.OMC_TravelHopDataSet.RentalCar)

        Dim strFind As String
        strFind = frmTABookingsCar.selectedID

        Dim find_record = From user In OMC_TravelHopDataSet.RentalCar
                          Where user.ID = strFind
                          Select user

        RentalCarBindingSource.DataSource = find_record.AsDataView

        If lblStatusResult.Text = "Pending Approval" Then
            btnApprove.Enabled = True
        End If

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        lblStatusResult.Text = "Approved"

        Me.Validate()
        Me.RentalCarBindingSource.EndEdit()
        Me.RentalCarTableAdapter.Update(Me.OMC_TravelHopDataSet.RentalCar)
        Me.RentalCarTableAdapter.Fill(Me.OMC_TravelHopDataSet.RentalCar)

        MsgBox("The booking has been apporved!", MsgBoxStyle.Information, "Booking Approval")

        Me.Close()
        frmTABookingsCar.Close()
        frmTABookingsCar.Show()

    End Sub
    Private Sub btnApprove_MouseEnter(sender As Object, e As EventArgs) Handles btnApprove.MouseEnter
        btnApprove.BackColor = Color.Thistle
    End Sub

    Private Sub btnApprove_MouseLeave(sender As Object, e As EventArgs) Handles btnApprove.MouseLeave
        btnApprove.BackColor = Color.White
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

End Class