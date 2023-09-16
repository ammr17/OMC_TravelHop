Imports System.Text
Public Class frmSelangorHotelsList
    Private Sub btnDorsettGrand_MouseEnter(sender As Object, e As EventArgs) Handles btnDorsettGrand.MouseEnter
        btnDorsettGrand.BackColor = Color.Thistle
    End Sub

    Private Sub btnDorsettGrand_MouseLeave(sender As Object, e As EventArgs) Handles btnDorsettGrand.MouseLeave
        btnDorsettGrand.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub btnFourPoints_MouseEnter(sender As Object, e As EventArgs) Handles btnFourPoints.MouseEnter
        btnFourPoints.BackColor = Color.Thistle
    End Sub

    Private Sub btnFourPoints_MouseLeave(sender As Object, e As EventArgs) Handles btnFourPoints.MouseLeave
        btnFourPoints.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub btnOrange_MouseEnter(sender As Object, e As EventArgs) Handles btnOrange.MouseEnter
        btnOrange.BackColor = Color.Thistle
    End Sub

    Private Sub btnOrange_MouseLeave(sender As Object, e As EventArgs) Handles btnOrange.MouseLeave
        btnOrange.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub btnBangi_MouseEnter(sender As Object, e As EventArgs) Handles btnBangi.MouseEnter
        btnBangi.BackColor = Color.Thistle
    End Sub

    Private Sub btnBangi_MouseLeave(sender As Object, e As EventArgs) Handles btnBangi.MouseLeave
        btnBangi.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBACK.MouseEnter
        btnBACK.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBACK.MouseLeave
        btnBACK.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBACK.Click
        FrmUserHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnDorsettGrand_Click(sender As Object, e As EventArgs) Handles btnDorsettGrand.Click
        FrmHotelsList.selectedHotel = lblDorsettGrand.Text
        frmDorsettGrand.Show()
        Me.Hide()
    End Sub

    Private Sub btnFourPoints_Click(sender As Object, e As EventArgs) Handles btnFourPoints.Click
        FrmHotelsList.selectedHotel = lblFourPoints.Text
        frmFourPoints.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        FrmHotelsList.selectedHotel = lblOrange.Text
        frmOrange.Show()
        Me.Hide()
    End Sub

    Private Sub btnBangi_Click(sender As Object, e As EventArgs) Handles btnBangi.Click
        FrmHotelsList.selectedHotel = lblBangiResort.Text
        frmBangiResort.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMapDorsett.Click

        lblHotel.Text = "Dorsett Grand Subang"
        lblCity.Text = "Subang Jaya"
        lblState.Text = "Selangor"

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

        browser.Navigate(GetAddress.ToString)

    End Sub

    Private Sub btnMapFourPoints_Click(sender As Object, e As EventArgs) Handles btnMapFourPoints.Click

        lblHotel.Text = "Four Points by Sheraton"
        lblCity.Text = "Puchong"
        lblState.Text = "Selangor"

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

        browser.Navigate(GetAddress.ToString)

    End Sub

    Private Sub btnMapOrange_Click(sender As Object, e As EventArgs) Handles btnMapOrange.Click

        lblHotel.Text = "Orange Business Hotel"
        lblCity.Text = "Petaling Jaya"
        lblState.Text = "Selangor"

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

        browser.Navigate(GetAddress.ToString)

    End Sub

    Private Sub btnMapBangiResort_Click(sender As Object, e As EventArgs) Handles btnMapBangiResort.Click

        lblHotel.Text = "Bangi Resort Hotel"
        lblCity.Text = "Bangi"
        lblState.Text = "Selangor"

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

        browser.Navigate(GetAddress.ToString)

    End Sub

End Class