Public Class FrmFeedback
    Private Sub FrmFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.CustFeedback' table. You can move, or remove it, as needed.
        Me.CustFeedbackTableAdapter.Fill(Me.OMC_TravelHopDataSet.CustFeedback)

        Me.CustFeedbackBindingSource.AddNew()
        lblUsernameResult.Text = FrmUserLogin.userAccount

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If FrmUserBookings.selectedServiceCancel = "Car" Then
            lblService.Text = "Car Rental"
        ElseIf FrmUserBookings.selectedServiceCancel = "Hotel" Then
            lblService.Text = "Hotel Booking"
        End If

        If rbtBookingExcellent.Checked = True Then
            lblSmoothnessResult.Text = "Excellent"
        ElseIf rbtBookingGood.Checked = True Then
            lblSmoothnessResult.Text = "Good"
        Else
            lblSmoothnessResult.Text = "Poor"
        End If

        If rbtEaseExcellent.Checked = True Then
            lblNavigationResult.Text = "Excellent"
        ElseIf rbtEaseGood.Checked = True Then
            lblNavigationResult.Text = "Good"
        Else
            lblNavigationResult.Text = "Poor"
        End If

        If rbtInfoExcellent.Checked = True Then
            lblInfoProvidedResult.Text = "Excellent"
        ElseIf rbtInfoGood.Checked = True Then
            lblInfoProvidedResult.Text = "Good"
        Else
            lblInfoProvidedResult.Text = "Poor"
        End If

        If rbtPaymentExcellent.Checked = True Then
            lblPaymentProcessResult.Text = "Excellent"
        ElseIf rbtPaymentGood.Checked = True Then
            lblPaymentProcessResult.Text = "Good"
        Else
            lblPaymentProcessResult.Text = "Poor"
        End If

        Me.Validate()
        Me.CustFeedbackBindingSource.EndEdit()
        Me.CustFeedbackTableAdapter.Update(Me.OMC_TravelHopDataSet.CustFeedback)
        Me.CustFeedbackTableAdapter.Fill(Me.OMC_TravelHopDataSet.CustFeedback)


        MsgBox("Thank You! Your feedback really matters to us as we are always finding ways to improve our services.", MsgBoxStyle.Information, "Feedback")
        Me.Close()
        FrmUserBookings.Show()

    End Sub

    Private Sub rbtBookingPoor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBookingPoor.CheckedChanged
        btnSubmit.Enabled = True
    End Sub

    Private Sub rbtBookingGood_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBookingGood.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtBookingExcellent_CheckedChanged(sender As Object, e As EventArgs) Handles rbtBookingExcellent.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtEasePoor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEasePoor.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtEaseGood_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEaseGood.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtEaseExcellent_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEaseExcellent.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtInfoPoor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtInfoPoor.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtInfoGood_CheckedChanged(sender As Object, e As EventArgs) Handles rbtInfoGood.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtInfoExcellent_CheckedChanged(sender As Object, e As EventArgs) Handles rbtInfoExcellent.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtPaymentPoor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPaymentPoor.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtPaymentGood_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPaymentGood.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub rbtPaymentExcellent_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPaymentExcellent.CheckedChanged
        btnSubmit.Enabled = True

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmUserBookings.Show()
    End Sub

End Class