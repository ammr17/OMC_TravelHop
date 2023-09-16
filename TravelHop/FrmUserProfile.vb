Public Class FrmUserProfile
    Public FormColour As Color
    Public FormFont As Font
    Private Sub btnProfilePicture_MouseEnter(sender As Object, e As EventArgs) Handles btnProfilePicture.MouseEnter
        btnProfilePicture.BackColor = Color.Thistle
    End Sub

    Private Sub btnProfilePicture_MouseLeave(sender As Object, e As EventArgs) Handles btnProfilePicture.MouseLeave
        btnProfilePicture.BackColor = Color.White
    End Sub
    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter
        btnSave.BackColor = Color.Thistle
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackColor = Color.White
    End Sub
    Private Sub btnEdit_MouseEnter(sender As Object, e As EventArgs) Handles btnEdit.MouseEnter
        btnEdit.BackColor = Color.Thistle
    End Sub

    Private Sub btnEdit_MouseLeave(sender As Object, e As EventArgs) Handles btnEdit.MouseLeave
        btnEdit.BackColor = Color.White
    End Sub
    Private Sub btnChangePassword_MouseEnter(sender As Object, e As EventArgs) Handles btnChangePassword.MouseEnter
        btnChangePassword.BackColor = Color.Thistle
    End Sub

    Private Sub btnChangePassword_MouseLeave(sender As Object, e As EventArgs) Handles btnChangePassword.MouseLeave
        btnChangePassword.BackColor = Color.White
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmUserHomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnProfilePicture_Click(sender As Object, e As EventArgs) Handles btnProfilePicture.Click

        Dim openPhoto As New OpenFileDialog

        openPhoto.Filter = ("Picture File|*.jpeg; *.jpg; *.png; *.bmp; *,gif")

        openPhoto.ShowDialog()

        picProfilePicture.ImageLocation = openPhoto.FileName

        btnSave.Enabled = True


    End Sub

    Private Sub FrmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)

        Dim strFind As String
        strFind = FrmUserLogin.userAccount

        Dim find_record = From user In OMC_TravelHopDataSet.Customer
                          Where user.UserName = strFind
                          Select user

        CustomerBindingSource.DataSource = find_record.AsDataView

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.CustomerTableAdapter.Update(Me.OMC_TravelHopDataSet.Customer)
        Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)

        txtEmail.Enabled = False
        txtName.Enabled = False
        txtPhoneNumber.Enabled = False
        txtUsername.Enabled = False

        MsgBox("Data Updated", MsgBoxStyle.Information, "TravelHop - My Profile")

        Dim strFind As String
        strFind = FrmUserLogin.userAccount

        Dim find_record = From user In OMC_TravelHopDataSet.Customer
                          Where user.UserName = strFind
                          Select user

        CustomerBindingSource.DataSource = find_record.AsDataView
        Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)

        btnSave.Enabled = False

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        txtEmail.Enabled = True
        txtName.Enabled = True
        txtPhoneNumber.Enabled = True
        txtUsername.Enabled = True

        btnSave.Enabled = True

    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        Dim getEmail As String
        getEmail = InputBox("Please enter your email:", "Change Password")

        Dim find_record = From user In OMC_TravelHopDataSet.Customer
                          Where user.Email = getEmail
                          Select user

        Dim newPassword As String
        Dim passwordCheck As String

        If getEmail = txtEmail.Text Then
            newPassword = InputBox("Enter a new password: ", "Change Password")
            If newPassword = "" Or newPassword = " " Then
                MsgBox("Please enter a valid input!", MsgBoxStyle.Critical, " Change Password")
                Exit Sub
            End If
            passwordCheck = InputBox("Enter your new password again: ", "Change Password")

            If passwordCheck = newPassword Then
                lblNewPassword.Text = newPassword

                Me.Validate()
                Me.CustomerBindingSource.EndEdit()
                Me.CustomerTableAdapter.Update(Me.OMC_TravelHopDataSet.Customer)
                Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)

                MsgBox("Password Change Successful!", MsgBoxStyle.Information, "Change Password")

            Else
                MsgBox("Password Do Not Match!", MsgBoxStyle.Critical, "Change Password")
                Exit Sub
            End If
        Else
            MsgBox("Email Does Not Match With Your Account!", MsgBoxStyle.Critical, "Change Password")
            Exit Sub
        End If

        CustomerBindingSource.DataSource = find_record.AsDataView

    End Sub

    Private Sub ColourMenu_Click(sender As Object, e As EventArgs) Handles ColourMenu.Click
        ColorDialog1.ShowDialog()
        FormColour = ColorDialog1.Color

        Me.BackColor = ColorDialog1.Color
        frmAgencyLogin.BackColor = FormColour
        frmBangiResort.BackColor = FormColour
        frmDorsettGrand.BackColor = FormColour
        frmFourPoints.BackColor = FormColour
        frmHotelBooking.BackColor = FormColour
        frmMainPage.BackColor = FormColour
        frmOrange.BackColor = FormColour
        frmSelangorHotelsList.BackColor = FormColour
        frmTABookings.BackColor = FormColour
        frmTABookingsCar.BackColor = FormColour
        frmTARegistration.BackColor = FormColour
        frmTAViewBookings.BackColor = FormColour
        frmTAViewBookingsCar.BackColor = FormColour
        FrmCancellation.BackColor = FormColour
        FrmCarBooking.BackColor = FormColour
        FrmCarList.BackColor = FormColour
        FrmCeylonz.BackColor = FormColour
        FrmConcorde.BackColor = FormColour
        FrmDorsett.BackColor = FormColour
        FrmFeedback.BackColor = FormColour
        FrmHotelsList.BackColor = FormColour
        FrmLeMeridien.BackColor = FormColour
        FrmNewOrExistingUser.BackColor = FormColour
        FrmPaymentCard.BackColor = FormColour
        FrmPaymentDetails.BackColor = FormColour
        FrmUserBookings.BackColor = FormColour
        FrmUserLogin.BackColor = FormColour
        FrmUserHomePage.BackColor = FormColour
        FrmUserRegistration.BackColor = FormColour
    End Sub

    Private Sub FontMenu_Click(sender As Object, e As EventArgs) Handles FontMenu.Click
        FontDialog1.ShowDialog()
        FormFont = FontDialog1.Font
        Me.Font = FormFont

        frmAgencyLogin.Font = FormFont
        frmBangiResort.Font = FormFont
        frmDorsettGrand.Font = FormFont
        frmFourPoints.Font = FormFont
        frmHotelBooking.Font = FormFont
        frmMainPage.Font = FormFont
        frmOrange.Font = FormFont
        frmSelangorHotelsList.Font = FormFont
        frmTABookings.Font = FormFont
        frmTABookingsCar.Font = FormFont
        frmTARegistration.Font = FormFont
        frmTAViewBookings.Font = FormFont
        frmTAViewBookingsCar.Font = FormFont
        FrmCancellation.Font = FormFont
        FrmCarBooking.Font = FormFont
        FrmCarList.Font = FormFont
        FrmCeylonz.Font = FormFont
        FrmConcorde.Font = FormFont
        FrmDorsett.Font = FormFont
        FrmFeedback.Font = FormFont
        FrmHotelsList.Font = FormFont
        FrmLeMeridien.Font = FormFont
        FrmNewOrExistingUser.Font = FormFont
        FrmPaymentCard.Font = FormFont
        FrmPaymentDetails.Font = FormFont
        FrmUserBookings.Font = FormFont
        FrmUserLogin.Font = FormFont
        FrmUserHomePage.Font = FormFont
        FrmUserRegistration.Font = FormFont
    End Sub

    Private Sub AboutUsMenu_Click(sender As Object, e As EventArgs) Handles AboutUsMenu.Click
        abtTravelHop.Show()
        Me.Hide()
    End Sub
End Class