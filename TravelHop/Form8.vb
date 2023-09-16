Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButton(btnCustomer)
        RoundButton(btnAdmin)
        RoundButton(btnAgency)

    End Sub
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.White
        btn.ForeColor = Color.Black
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Lucida Sans Unicode", 8)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()

        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)

        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)

        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)

        'appends a line segment to the current figure
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        'Close the current figure and start a new one.
        Raduis.CloseFigure()

        'set the window associated with the control
        btn.Region = New Region(Raduis)

    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        FrmNewOrExistingUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click

        Dim adminPassword As String = "travelhopthebest"
        Dim response As String

        response = InputBox("Please enter admin password:", "TravelHop - Admin")

        If response = adminPassword Then
            MsgBox("Login Succesful.", MsgBoxStyle.Information, "TravelHop - Admin")
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Password.", MsgBoxStyle.Exclamation, "Admin Login")
            Exit Sub
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAgency_Click(sender As Object, e As EventArgs) Handles btnAgency.Click
        frmAgencyLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomer_MouseEnter(sender As Object, e As EventArgs) Handles btnCustomer.MouseEnter
        btnCustomer.BackColor = Color.Thistle
    End Sub

    Private Sub btnCustomer_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomer.MouseLeave
        btnCustomer.BackColor = Color.White
    End Sub
    Private Sub btnAgency_MouseEnter(sender As Object, e As EventArgs) Handles btnAgency.MouseEnter
        btnAgency.BackColor = Color.Thistle
    End Sub

    Private Sub btnAgency_MouseLeave(sender As Object, e As EventArgs) Handles btnAgency.MouseLeave
        btnAgency.BackColor = Color.White
    End Sub
    Private Sub btnAdmin_MouseEnter(sender As Object, e As EventArgs) Handles btnAdmin.MouseEnter
        btnAdmin.BackColor = Color.Thistle
    End Sub

    Private Sub btnAdmin_MouseLeave(sender As Object, e As EventArgs) Handles btnAdmin.MouseLeave
        btnAdmin.BackColor = Color.White
    End Sub

End Class