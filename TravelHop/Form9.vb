Public Class Form9
    Public Sub mnuColour_Click(sender As Object, e As EventArgs) Handles mnuColour.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub
End Class