Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)

        Dim datTime, datDay As Date
        datTime = TimeOfDay
        datDay = Today

        lblDate.Text = "Opened at " & datTime & " on " & datDay

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim response As String
        response = MsgBox("Do you wish to exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Exit the Administration Program")

        If response = MsgBoxResult.Yes Then
            End
        End If

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnHotel.Click
        Form2.ShowDialog()
    End Sub

    Private Sub btnAvailability_Click(sender As Object, e As EventArgs) Handles btnCarRental.Click
        Form3.ShowDialog()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        Form7.ShowDialog()
    End Sub

    Private Sub btnHotel_MouseEnter(sender As Object, e As EventArgs) Handles btnHotel.MouseEnter
        btnHotel.BackColor = Color.Thistle
    End Sub

    Private Sub btnHotel_MouseLeave(sender As Object, e As EventArgs) Handles btnHotel.MouseLeave
        btnHotel.BackColor = Color.White
    End Sub

    Private Sub btnCarRental_MouseEnter(sender As Object, e As EventArgs) Handles btnCarRental.MouseEnter
        btnCarRental.BackColor = Color.Thistle
    End Sub

    Private Sub btnCarRental_MouseLeave(sender As Object, e As EventArgs) Handles btnCarRental.MouseLeave
        btnCarRental.BackColor = Color.White
    End Sub

    Private Sub btnFeedback_MouseEnter(sender As Object, e As EventArgs) Handles btnFeedback.MouseEnter
        btnFeedback.BackColor = Color.Thistle
    End Sub

    Private Sub btnFeedback_MouseLeave(sender As Object, e As EventArgs) Handles btnFeedback.MouseLeave
        btnFeedback.BackColor = Color.White
    End Sub

End Class
