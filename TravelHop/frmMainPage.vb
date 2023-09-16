Public Class frmMainPage
    Public agencyName As String
    Dim splitAgencyName() As String
    Private Sub btnAgencyBookings_Click(sender As Object, e As EventArgs) Handles btnAgencyBookings.Click

        If splitAgencyName(0) = "Dorsett" Or splitAgencyName(0) = "Ceylonz" Or splitAgencyName(0) = "Concorde" Or splitAgencyName(0) = "Four" Or splitAgencyName(0) = "Le" Or splitAgencyName(0) = "Orange" Or splitAgencyName(0) = "Bangi" Then
            frmTABookings.Show()
            Me.Hide()
        Else
            frmTABookingsCar.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnAgencyExit_Click(sender As Object, e As EventArgs) Handles btnAgencyExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAgencyBookings_MouseEnter(sender As Object, e As EventArgs) Handles btnAgencyBookings.MouseEnter
        btnAgencyBookings.BackColor = Color.Thistle
    End Sub

    Private Sub btnAgencyBookings_MouseLeave(sender As Object, e As EventArgs) Handles btnAgencyBookings.MouseLeave
        btnAgencyBookings.BackColor = Color.OldLace
    End Sub

    Private Sub btnAgencyExit_MouseEnter(sender As Object, e As EventArgs) Handles btnAgencyExit.MouseEnter
        btnAgencyExit.BackColor = Color.Thistle
    End Sub

    Private Sub btnAgencyExit_MouseLeave(sender As Object, e As EventArgs) Handles btnAgencyExit.MouseLeave
        btnAgencyExit.BackColor = Color.OldLace
    End Sub

    Private Sub frmMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.Agency' table. You can move, or remove it, as needed.
        Me.AgencyTableAdapter.Fill(Me.OMC_TravelHopDataSet.Agency)

        Dim strFind As String
        strFind = frmAgencyLogin.userAccount

        Dim find_record = From user In OMC_TravelHopDataSet.Agency
                          Where user.UserName = strFind
                          Select user

        AgencyBindingSource.DataSource = find_record.AsDataView

        agencyName = txtCompanyName.Text

        splitAgencyName = agencyName.Split(" ")

    End Sub

End Class