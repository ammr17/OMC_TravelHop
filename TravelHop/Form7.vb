Public Class Form7
    Private borderColor As Color = Color.Black 'Border Color
    Private borderWidth As Integer = 1
    Private formRegion As Rectangle

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.CustFeedback' table. You can move, or remove it, as needed.
        Me.CustFeedbackTableAdapter.Fill(Me.OMC_TravelHopDataSet.CustFeedback)

        formRegion = New Rectangle(0, 0, 606, 363)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub Form7_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        ControlPaint.DrawBorder(e.Graphics, formRegion, borderColor,
        borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
        ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
        borderColor, borderWidth, ButtonBorderStyle.Solid)

    End Sub

End Class