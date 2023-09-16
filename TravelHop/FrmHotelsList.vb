Imports System.Text
Public Class FrmHotelsList
    Public selectedHotel As String
    Public selectedRoomType As String
    Public selectedBreakfast As String
    Public selectedCheckIn As Date
    Public selectedCheckOut As Date
    Public selectedPrice As String
    Private Sub btnDorsett_MouseEnter(sender As Object, e As EventArgs) Handles btnDorsett.MouseEnter
        btnDorsett.BackColor = Color.Thistle
    End Sub

    Private Sub btnDorsett_MouseLeave(sender As Object, e As EventArgs) Handles btnDorsett.MouseLeave
        btnDorsett.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnConcorde_MouseEnter(sender As Object, e As EventArgs) Handles btnConcorde.MouseEnter
        btnConcorde.BackColor = Color.Thistle
    End Sub

    Private Sub btnConcorde_MouseLeave(sender As Object, e As EventArgs) Handles btnConcorde.MouseLeave
        btnConcorde.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnCeylonz_MouseEnter(sender As Object, e As EventArgs) Handles btnCeylonz.MouseEnter
        btnCeylonz.BackColor = Color.Thistle
    End Sub

    Private Sub btnCeylonz_MouseLeave(sender As Object, e As EventArgs) Handles btnCeylonz.MouseLeave
        btnCeylonz.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnLeMeridien_MouseEnter(sender As Object, e As EventArgs) Handles btnLeMeridien.MouseEnter
        btnLeMeridien.BackColor = Color.Thistle
    End Sub

    Private Sub btnLeMeridien_MouseLeave(sender As Object, e As EventArgs) Handles btnLeMeridien.MouseLeave
        btnLeMeridien.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmUserHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnDorsett_Click(sender As Object, e As EventArgs) Handles btnDorsett.Click
        selectedHotel = lblDorsett.Text
        FrmDorsett.Show()
        Me.Hide()
    End Sub

    Private Sub btnConcorde_Click(sender As Object, e As EventArgs) Handles btnConcorde.Click
        selectedHotel = lblConcorde.Text
        FrmConcorde.Show()
        Me.Hide()
    End Sub

    Private Sub btnCeylonz_Click(sender As Object, e As EventArgs) Handles btnCeylonz.Click
        selectedHotel = lblCeylonz.Text
        FrmCeylonz.Show()
        Me.Hide()
    End Sub

    Private Sub btnLeMeridien_Click(sender As Object, e As EventArgs) Handles btnLeMeridien.Click
        selectedHotel = lblLeMeridien.Text
        FrmLeMeridien.Show()
        Me.Hide()
    End Sub

    Private Sub btnMapDorsettKL_Click(sender As Object, e As EventArgs) Handles btnMapDorsettKL.Click

        lblHotel.Text = "Dorsett Kuala Lumpur"
        lblCity.Text = "Bukit Bintang"
        lblState.Text = "Kuala Lumpur"

        Dim state As String
        Dim city As String
        Dim street As String

        state = lblHotel.Text
        city = lblState.Text
        street = lblCity.Text

        Dim GetAddress As New StringBuilder
        GetAddress.Append("https://maps.google.com/maps?q=")

        If lblHotel.Text <> " " Then
            GetAddress.Append(state + "," & "+")
        End If

        If lblState.Text <> " " Then
            GetAddress.Append(city + "," & "+")
        End If

        If lblCity.Text <> " " Then
            GetAddress.Append(street + "," & "+")
        End If

        browser1.Navigate(GetAddress.ToString)

    End Sub

    Private Sub btnMapConcorde_Click(sender As Object, e As EventArgs) Handles btnMapConcorde.Click

        lblHotel.Text = "Concorde Hotel Kuala Lumpur"
        lblCity.Text = "Kuala Lumpur City-Centre"
        lblState.Text = "Kuala Lumpur"

        Dim state As String
        Dim city As String
        Dim street As String

        state = lblHotel.Text
        city = lblState.Text
        street = lblCity.Text

        Dim GetAddress As New StringBuilder
        GetAddress.Append("https://maps.google.com/maps?q=")

        If lblHotel.Text <> " " Then
            GetAddress.Append(state + "," & "+")
        End If

        If lblState.Text <> " " Then
            GetAddress.Append(city + "," & "+")
        End If

        If lblCity.Text <> " " Then
            GetAddress.Append(street + "," & "+")
        End If

        browser1.Navigate(GetAddress.ToString)

    End Sub

    Private Sub btnMapCeylonz_Click(sender As Object, e As EventArgs) Handles btnMapCeylonz.Click

        lblHotel.Text = "Ceylonz Starlight Suites"
        lblCity.Text = "Bukit Bintang"
        lblState.Text = "Kuala Lumpur"

        Dim state As String
        Dim city As String
        Dim street As String

        state = lblHotel.Text
        city = lblState.Text
        street = lblCity.Text

        Dim GetAddress As New StringBuilder
        GetAddress.Append("https://maps.google.com/maps?q=")

        If lblHotel.Text <> " " Then
            GetAddress.Append(state + "," & "+")
        End If

        If lblState.Text <> " " Then
            GetAddress.Append(city + "," & "+")
        End If

        If lblCity.Text <> " " Then
            GetAddress.Append(street + "," & "+")
        End If

        browser1.Navigate(GetAddress.ToString)

    End Sub

    Private Sub btnMapLe_Click(sender As Object, e As EventArgs) Handles btnMapLe.Click

        lblHotel.Text = "Le Meridien"
        lblCity.Text = "Kuala Lumpur"
        lblState.Text = "Kuala Lumpur"

        Dim state As String
        Dim city As String
        Dim street As String

        state = lblHotel.Text
        city = lblState.Text
        street = lblCity.Text

        Dim GetAddress As New StringBuilder
        GetAddress.Append("https://maps.google.com/maps?q=")

        If lblHotel.Text <> " " Then
            GetAddress.Append(state + "," & "+")
        End If

        If lblState.Text <> " " Then
            GetAddress.Append(city + "," & "+")
        End If

        If lblCity.Text <> " " Then
            GetAddress.Append(street + "," & "+")
        End If

        browser1.Navigate(GetAddress.ToString)

    End Sub

End Class
