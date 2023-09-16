Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.BookingHotel' table. You can move, or remove it, as needed.
        Me.BookingHotelTableAdapter.Fill(Me.OMC_TravelHopDataSet.BookingHotel)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class