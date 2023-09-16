Public Class frmAgencyLogin
    Public userAccount As String
    Dim counter As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim strFind As String
        strFind = txtUsername.Text

        Dim find_record = From user In OMC_TravelHopDataSet.Agency
                          Where user.UserName = strFind
                          Select user

        AgencyBindingSource.DataSource = find_record.AsDataView

        If txtUsername.Text = lblUsernameResult.Text And txtPassword.Text = lblPasswordResult.Text Then
            MsgBox("Log in Success", MsgBoxStyle.Information, "TravelHop - Login")
            userAccount = txtUsername.Text
            Me.Hide()
            frmMainPage.Show()

        ElseIf txtUsername.Text = lblUsernameResult.Text Then
            MsgBox("Wrong Password", MsgBoxStyle.Exclamation, "TravelHop - Login")
            txtPassword.Clear()
        Else
            MsgBox("Invalid Username", MsgBoxStyle.Exclamation, "TravelHop - Login")
        End If

    End Sub

    Private Sub btnAgencyNewUser_Click(sender As Object, e As EventArgs) Handles btnAgencyNewUser.Click
        frmTARegistration.Show()
        Me.Close()
    End Sub

    Private Sub btnAgencyForgotPassword_Click(sender As Object, e As EventArgs) Handles btnAgencyForgotPassword.Click

        If counter = 0 Then
            MsgBox("Please try to login at least once!", MsgBoxStyle.Critical, "Error")
        Else
            Dim getUsername As String
            getUsername = InputBox("Please enter the account's username: ", "Forgot Password")

            If getUsername = "" Or getUsername = " " Then
                MsgBox("Please enter a valid input!", MsgBoxStyle.Critical, " Change Password")
                Exit Sub
            End If

            Dim find_record = From user In OMC_TravelHopDataSet.Customer
                              Where user.UserName = getUsername
                              Select user

            If getUsername = lblUsernameResult.Text Then
                Dim getEmail As String
                getEmail = InputBox("Please enter the account's email: ", "Forgot Password")

                If getEmail = "" Or getEmail = " " Then
                    MsgBox("Please enter a valid input!", MsgBoxStyle.Critical, " Change Password")
                    Exit Sub
                End If

                If getEmail = lblEmailResult.Text Then
                    Dim newPassword As String
                    Dim passwordCheck As String
                    newPassword = InputBox("Enter a new password: ", "Forgot Password")

                    If newPassword = "" Or newPassword = " " Then
                        MsgBox("Please enter a valid input!", MsgBoxStyle.Critical, " Change Password")
                        Exit Sub
                    End If

                    passwordCheck = InputBox("Enter your new password again: ", "Forgot Password")

                    If passwordCheck = newPassword Then
                        lblPasswordResult.Text = newPassword

                        Me.Validate()
                        Me.AgencyBindingSource.EndEdit()
                        Me.AgencyTableAdapter.Update(Me.OMC_TravelHopDataSet.Agency)
                        Me.AgencyTableAdapter.Fill(Me.OMC_TravelHopDataSet.Agency)

                        MsgBox("Password Change Successful!", MsgBoxStyle.Information, "Forgot Password")

                    Else
                        MsgBox("Password Do Not Match!", MsgBoxStyle.Critical, "Forgot Password")
                        Exit Sub
                    End If
                Else
                    MsgBox("Email Does Not Match With Your Account!", MsgBoxStyle.Critical, "Forgot Password")
                    Exit Sub
                End If
            Else
                MsgBox("The username is not registered!", MsgBoxStyle.Critical, "Forgot Password")
                Exit Sub
            End If
        End If
        counter = counter + 1
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form8.Show()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If

    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        If txtPassword.Text <> "" Then
            btnLogin.Enabled = True
        End If

    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.Thistle
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.White
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub frmAgencyLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.Customer' table. You can move, or remove it, as needed.
        Me.AgencyTableAdapter.Fill(Me.OMC_TravelHopDataSet.Agency)
    End Sub
    Private Sub chkShowPassword_MouseEnter(sender As Object, e As EventArgs) Handles chkShowPassword.MouseEnter
        chkShowPassword.BackColor = Color.Thistle
    End Sub

    Private Sub chkShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles chkShowPassword.MouseLeave
        chkShowPassword.BackColor = Color.Gainsboro
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If

    End Sub

    Private Sub btnAgencyNewUser_MouseEnter(sender As Object, e As EventArgs) Handles btnAgencyNewUser.MouseEnter
        btnAgencyNewUser.Font = New Font("Lucida Sans Unicode", 8.25, FontStyle.Underline)
    End Sub

    Private Sub btnAgencyNewUser_MouseLeave(sender As Object, e As EventArgs) Handles btnAgencyNewUser.MouseLeave
        btnAgencyNewUser.Font = New Font("Lucida Sans Unicode", 8.25, FontStyle.Regular)
    End Sub
End Class
