Public Class frmTAViewBookings
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmTABookings.Show()
        Me.Close()
    End Sub

    Private Sub frmTAViewBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.BookingHotel' table. You can move, or remove it, as needed.
        Me.BookingHotelTableAdapter.Fill(Me.OMC_TravelHopDataSet.BookingHotel)

        Dim strFind As String
        strFind = frmTABookings.selectedID

        Dim find_record = From user In OMC_TravelHopDataSet.BookingHotel
                          Where user.ID = strFind
                          Select user

        BookingHotelBindingSource.DataSource = find_record.AsDataView

        If lblStatusResult.Text = "Pending Approval" Then
            btnApprove.Enabled = True
        End If

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        lblStatusResult.Text = "Approved"

        Me.Validate()
        Me.BookingHotelBindingSource.EndEdit()
        Me.BookingHotelTableAdapter.Update(Me.OMC_TravelHopDataSet.BookingHotel)
        Me.BookingHotelTableAdapter.Fill(Me.OMC_TravelHopDataSet.BookingHotel)

        MsgBox("The booking has been apporved!", MsgBoxStyle.Information, "Booking Approval")

        Me.Close()
        frmTABookings.Close()
        frmTABookings.Show()

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