Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.RentalCar' table. You can move, or remove it, as needed.
        Me.RentalCarTableAdapter.Fill(Me.OMC_TravelHopDataSet.RentalCar)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class