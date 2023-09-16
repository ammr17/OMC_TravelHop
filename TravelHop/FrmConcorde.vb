Public Class FrmConcorde
    Dim price As Double
    Private Sub btnBook_MouseEnter(sender As Object, e As EventArgs) Handles btnBook.MouseEnter
        btnBook.BackColor = Color.Thistle
    End Sub

    Private Sub btnBook_MouseLeave(sender As Object, e As EventArgs) Handles btnBook.MouseLeave
        btnBook.BackColor = Color.White
    End Sub
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.Thistle
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.White
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FrmHotelsList.Show()
        Me.Close()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click

        FrmHotelsList.selectedBreakfast = "Included"

        If rbtSingle.Checked = True Then
            FrmHotelsList.selectedRoomType = rbtSingle.Text
        ElseIf rbtQueen.Checked = True Then
            FrmHotelsList.selectedRoomType = rbtQueen.Text
        ElseIf rbtKing.Checked = True Then
            FrmHotelsList.selectedRoomType = rbtKing.Text
        ElseIf rbtSingleQueen.Checked = True Then
            FrmHotelsList.selectedRoomType = rbtSingleQueen.Text
        Else
            MsgBox("Please Choose Room Type", MsgBoxStyle.Exclamation, "Hotel Booking")
            Exit Sub
        End If

        FrmHotelsList.selectedCheckIn = MonthCalendar1.SelectionRange.Start
        FrmHotelsList.selectedCheckOut = MonthCalendar2.SelectionRange.Start
        FrmHotelsList.selectedPrice = price

        FrmPaymentDetails.Show()
        Me.Hide()

    End Sub
    Private Sub rbtSingle_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSingle.CheckedChanged
        price = 281
        lblAmountResult.Text = Format(price, "Currency")
    End Sub

    Private Sub rbtQueen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtQueen.CheckedChanged
        price = 319
        lblAmountResult.Text = Format(price, "Currency")
    End Sub

    Private Sub rbtKing_CheckedChanged(sender As Object, e As EventArgs) Handles rbtKing.CheckedChanged
        price = 361
        lblAmountResult.Text = Format(price, "Currency")
    End Sub

    Private Sub rbtSingleQueen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSingleQueen.CheckedChanged
        price = 771
        lblAmountResult.Text = Format(price, "Currency")
    End Sub

    Private Sub FrmConcorde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar2.SelectionStart = Today.AddDays(1)
    End Sub

End Class