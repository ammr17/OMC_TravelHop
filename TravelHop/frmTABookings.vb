Public Class frmTABookings
    Public selectedID As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewBooking.Click
        selectedID = lblIDresult.Text
        frmTAViewBookings.Show()
        Me.Hide()
    End Sub

    Private Sub frmTABookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.BookingHotel' table. You can move, or remove it, as needed.
        'Me.BookingHotelTableAdapter.Fill(Me.OMC_TravelHopDataSet.BookingHotel)

        Dim companyName() As String
        companyName = frmMainPage.agencyName.Split(" ")

        Dim strFind As String
        strFind = companyName(0)

        Dim find_record = From user In OMC_TravelHopDataSet.BookingHotel
                          Where user.HotelName Like strFind & "*"
                          Select user

        BookingHotelBindingSource.DataSource = find_record.AsDataView

        Me.BookingHotelTableAdapter.Fill(Me.OMC_TravelHopDataSet.BookingHotel)

    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnViewBooking_MouseEnter(sender As Object, e As EventArgs) Handles btnViewBooking.MouseEnter
        btnViewBooking.BackColor = Color.Thistle
    End Sub

    Private Sub btnViewBooking_MouseLeave(sender As Object, e As EventArgs) Handles btnViewBooking.MouseLeave
        btnViewBooking.BackColor = Color.White
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnViewBooking.Enabled = True
    End Sub

    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmMainPage.Show()
    End Sub

End Class