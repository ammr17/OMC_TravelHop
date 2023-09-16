Public Class FrmUserRegistration
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmNewOrExistingUser.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtFullName.Text = "" OrElse txtUsername.Text = "" OrElse txtEmail.Text = "" OrElse mtxtPhoneNo.Text = "" OrElse txtPassword.Text = "" OrElse txtConfirmPassword.Text = "" Then
            MsgBox("One or more field(s) is not filled.", MsgBoxStyle.Exclamation, "Registration")
            Exit Sub
        End If

        If txtConfirmPassword.Text <> txtPassword.Text Then
            MsgBox("Password Do Not Match. Please Reenter.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        lblDateOfBirthResult.Text = MonthCalendar1.SelectionRange.Start

        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.CustomerTableAdapter.Update(Me.OMC_TravelHopDataSet.Customer)
        'Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)

        MsgBox("Your account have been registered! Proceed to Login Page.", MsgBoxStyle.Information, "User Registration")

        Me.Hide()
        FrmUserLogin.Show()

    End Sub

    Private Sub btnRegister_MouseEnter(sender As Object, e As EventArgs) Handles btnRegister.MouseEnter
        btnRegister.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.White
    End Sub

    Private Sub FrmUserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'OMC_TravelHopDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.OMC_TravelHopDataSet.Customer)

        txtFullName.Enabled = True
        txtUsername.Enabled = True
        MonthCalendar1.Enabled = True
        txtEmail.Enabled = True
        mtxtPhoneNo.Enabled = True
        txtPassword.Enabled = True
        txtConfirmPassword.Enabled = True

        Me.CustomerBindingSource.AddNew()

    End Sub

    Private Sub chkShowPassword_MouseEnter(sender As Object, e As EventArgs) Handles chkShowPassword.MouseEnter
        chkShowPassword.BackColor = Color.Thistle
    End Sub

    Private Sub chkShowPassword_MouseLeave(sender As Object, e As EventArgs) Handles chkShowPassword.MouseLeave
        chkShowPassword.BackColor = Color.Gainsboro
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
            txtConfirmPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
            txtConfirmPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub txtConfirmPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConfirmPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnRegister_Click(sender, e)
        End If

    End Sub

End Class