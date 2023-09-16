Public Class FrmNewOrExistingUser

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If rbtExistingUser.Checked = True Then
            FrmUserLogin.Show()
            Me.Hide()
        ElseIf rbtNewUser.Checked = True Then
            FrmUserRegistration.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub rbtNewUser_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNewUser.CheckedChanged
        btnNext.Enabled = True
    End Sub

    Private Sub rbtExistingUser_CheckedChanged(sender As Object, e As EventArgs) Handles rbtExistingUser.CheckedChanged
        btnNext.Enabled = True
    End Sub

    Private Sub btnNext_MouseEnter(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        btnNext.BackColor = Color.Thistle
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.Thistle
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        btnNext.BackColor = Color.White
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form8.Show()
        Me.Hide()
    End Sub



    Private Sub FrmNewOrExistingUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
