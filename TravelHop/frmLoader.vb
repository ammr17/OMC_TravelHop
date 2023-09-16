Public Class frmLoader

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblReportProgress.Text = PBLoading1.Value & "%"
        PBLoading1.Value += 1

        If PBLoading1.Value > 10 Then
            lblStatusText.Text = "Loading...."
        End If
        If PBLoading1.Value > 35 Then
            lblStatusText.Text = "Please Wait.."
        End If

        If PBLoading1.Value > 65 Then
            lblStatusText.Text = "Just A Moment..."
        End If

        If PBLoading1.Value > 95 Then
            lblStatusText.Text = "Thanks!"
        End If

        If PBLoading1.Value = 100 Then
            lblStatusText.Text = "Launching Application"
            Form8.Show()
            Me.Hide()
            Timer1.Dispose()
        End If

    End Sub

    Private Sub frmLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With

        With Me
            .ShowInTaskbar = False

            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual
            .BackColor = Color.LavenderBlush
            .Opacity = 1.0

            Dim r As Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
            r = New Rectangle(3, 3, Me.Width - 4, Me.Height - 4)
            .Region.Exclude(RoundedRectangle(r, 48))
            .Show()

        End With


    End Sub
    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath

        Dim path As New Drawing2D.GraphicsPath

        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)

        path.CloseFigure()

        Return path

    End Function

    Private Sub frmLoader_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        Dim r As New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
        Dim path As Drawing2D.GraphicsPath = RoundedRectangle(r, 48)

        Using pn As New Pen(Color.LavenderBlush, 2)
            e.Graphics.DrawPath(pn, path)
        End Using

    End Sub

End Class