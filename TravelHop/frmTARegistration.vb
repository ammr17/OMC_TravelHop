Public Class frmTARegistration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtCompanyName.Text = "" OrElse txtUsername.Text = "" OrElse txtEmail.Text = "" OrElse mtxtPhoneNo.Text = "" OrElse txtPassword.Text = "" OrElse txtConfirmPassword.Text = "" Then
            MsgBox("One or more field(s) is not filled.", MsgBoxStyle.Exclamation, "Registration")
            Exit Sub
        End If

        If txtConfirmPassword.Text <> txtPassword.Text Then
            MsgBox("Password Do Not Match. Please Reenter.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Me.Validate()
        Me.AgencyBindingSource.EndEdit()
        Me.AgencyTableAdapter.Update(Me.OMC_TravelHopDataSet.Agency)
        'Me.AgencyTableAdapter.Fill(Me.OMC_TravelHopDataSet.Agency)

        MsgBox("Your account have been registered! Proceed to Login Page.", MsgBoxStyle.Information, "Agency Registration")

        frmAgencyLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAgencyLogin.Show()
        Me.Hide()
    End Sub

    Private Sub frmTARegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCompanyName.Enabled = True
        txtUsername.Enabled = True
        txtEmail.Enabled = True
        mtxtPhoneNo.Enabled = True
        txtPassword.Enabled = True
        txtConfirmPassword.Enabled = True

        Me.AgencyBindingSource.AddNew()

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

    Private Sub btnRegister_MouseEnter(sender As Object, e As EventArgs) Handles btnRegister.MouseEnter
        btnRegister.BackColor = Color.Thistle
    End Sub

    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.White
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

End Class