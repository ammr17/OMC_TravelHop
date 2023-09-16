Public Class FrmUserHomePage
    Public FormColour As Color

    Public selectedService As String
    Private Sub btnHotelBooking_MouseEnter(sender As Object, e As EventArgs) Handles btnHotelBooking.MouseEnter
        btnHotelBooking.BackColor = Color.Thistle
    End Sub

    Private Sub btnCarRental_MouseEnter(sender As Object, e As EventArgs) Handles btnCarRental.MouseEnter
        btnCarRental.BackColor = Color.Thistle
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackColor = Color.Thistle
    End Sub

    Private Sub btnMyBookings_MouseEnter(sender As Object, e As EventArgs) Handles btnMyBookings.MouseEnter
        btnMyBookings.BackColor = Color.Thistle
        picBookingsLogo.BackColor = Color.Thistle
    End Sub

    Private Sub btnMyProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnMyProfile.MouseEnter
        btnMyProfile.BackColor = Color.Thistle
        picProfileLogo.BackColor = Color.Thistle
    End Sub

    Private Sub btnMyProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnMyProfile.MouseLeave
        btnMyProfile.BackColor = Color.OldLace
        picProfileLogo.BackColor = Color.OldLace
    End Sub

    Private Sub btnMyBookings_MouseLeave(sender As Object, e As EventArgs) Handles btnMyBookings.MouseLeave
        btnMyBookings.BackColor = Color.OldLace
        picBookingsLogo.BackColor = Color.OldLace
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.OldLace
    End Sub

    Private Sub btnCarRental_MouseLeave(sender As Object, e As EventArgs) Handles btnCarRental.MouseLeave
        btnCarRental.BackColor = Color.White
    End Sub

    Private Sub btnHotelBooking_MouseLeave(sender As Object, e As EventArgs) Handles btnHotelBooking.MouseLeave
        btnHotelBooking.BackColor = Color.White
    End Sub

    Private Sub btnHotelBooking_Click(sender As Object, e As EventArgs) Handles btnHotelBooking.Click
        selectedService = "Hotel"
        frmHotelBooking.Show()
        Me.Hide()
    End Sub

    Private Sub btnCarRental_Click(sender As Object, e As EventArgs) Handles btnCarRental.Click
        selectedService = "Car"
        FrmCarList.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        FrmUserProfile.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyBookings_Click(sender As Object, e As EventArgs) Handles btnMyBookings.Click
        FrmUserBookings.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font
    End Sub

    Private Sub grbService_Enter(sender As Object, e As EventArgs) Handles grbService.Enter

    End Sub

    Private Sub FrmUserHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class