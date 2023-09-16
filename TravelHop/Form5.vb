Public Class frmBangiResort
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
        frmSelangorHotelsList.Show()
        Me.Close()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click

        If rbtYes.Checked = True Then
            FrmHotelsList.selectedBreakfast = "Included"
        ElseIf rbtNo.Checked = True Then
            FrmHotelsList.selectedBreakfast = "Not Included"
        Else
            MsgBox("Please Choose Breakfast", MsgBoxStyle.Exclamation, "Hotel Booking")
            Exit Sub
        End If


        If rbtSingle.Checked = True Then
            FrmHotelsList.selectedRoomType = rbtSingle.Text
        ElseIf rbtQueen.Checked = True Then
            FrmHotelsList.selectedRoomType = rbtQueen.Text
        ElseIf rbtQueenSofa.Checked = True Then
            FrmHotelsList.selectedRoomType = rbtQueenSofa.Text
        ElseIf rbt2Queen.Checked = True Then
            FrmHotelsList.selectedRoomType = rbt2Queen.Text
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

        If rbtYes.Checked = True Then
            price = 312 + 60
            lblAmountResult.Text = Format(price, "Currency")
        Else
            price = 312
            lblAmountResult.Text = Format(price, "Currency")
        End If

    End Sub

    Private Sub rbtQueen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtQueen.CheckedChanged

        If rbtYes.Checked = True Then
            price = 312 + 60
            lblAmountResult.Text = Format(price, "Currency")
        Else
            price = 312
            lblAmountResult.Text = Format(price, "Currency")
        End If

    End Sub

    Private Sub rbtQueenSofa_CheckedChanged(sender As Object, e As EventArgs) Handles rbtQueenSofa.CheckedChanged

        If rbtYes.Checked = True Then
            price = 500 + 60
            lblAmountResult.Text = Format(price, "Currency")
        Else
            price = 500
            lblAmountResult.Text = Format(price, "Currency")
        End If

    End Sub

    Private Sub rbt2Queen_CheckedChanged(sender As Object, e As EventArgs) Handles rbt2Queen.CheckedChanged

        If rbtYes.Checked = True Then
            price = 880 + 60
            lblAmountResult.Text = Format(price, "Currency")
        Else
            price = 880
            lblAmountResult.Text = Format(price, "Currency")
        End If

    End Sub

    Private Sub rbtYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtYes.CheckedChanged
        price += 60
        lblAmountResult.Text = Format(price, "Currency")
    End Sub

    Private Sub rbtNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNo.CheckedChanged

        If rbtSingle.Checked = True Then
            price = 312
            lblAmountResult.Text = Format(price, "Currency")
        ElseIf rbtQueen.Checked = True Then
            price = 312
            lblAmountResult.Text = Format(price, "Currency")
        ElseIf rbtQueenSofa.Checked = True Then
            price = 500
            lblAmountResult.Text = Format(price, "Currency")
        Else
            price = 880
            lblAmountResult.Text = Format(price, "Currency")
        End If

    End Sub

    Private Sub frmBangiResort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar2.SelectionStart = Today.AddDays(1)
    End Sub

End Class