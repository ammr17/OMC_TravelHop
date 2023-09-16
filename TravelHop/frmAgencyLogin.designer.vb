<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgencyLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgencyLogin))
        Me.btnAgencyForgotPassword = New System.Windows.Forms.Button()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblAgencyLogin = New System.Windows.Forms.Label()
        Me.btnAgencyNewUser = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.AgencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.AgencyTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter()
        Me.lblUsernameResult = New System.Windows.Forms.Label()
        Me.lblPasswordResult = New System.Windows.Forms.Label()
        Me.lblEmailResult = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.ToolTipPassword = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipRegister = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgencyForgotPassword
        '
        Me.btnAgencyForgotPassword.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnAgencyForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush
        Me.btnAgencyForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgencyForgotPassword.Location = New System.Drawing.Point(415, 273)
        Me.btnAgencyForgotPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgencyForgotPassword.Name = "btnAgencyForgotPassword"
        Me.btnAgencyForgotPassword.Size = New System.Drawing.Size(121, 33)
        Me.btnAgencyForgotPassword.TabIndex = 26
        Me.btnAgencyForgotPassword.Text = "Forgot Password?"
        Me.ToolTipPassword.SetToolTip(Me.btnAgencyForgotPassword, "Reset your password")
        Me.btnAgencyForgotPassword.UseVisualStyleBackColor = False
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblAgencyLogin)
        Me.pnlBackColor.Location = New System.Drawing.Point(-100, -1)
        Me.pnlBackColor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(993, 99)
        Me.pnlBackColor.TabIndex = 25
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(576, 18)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(70, 58)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 7
        Me.picLogo.TabStop = False
        '
        'lblAgencyLogin
        '
        Me.lblAgencyLogin.AutoSize = True
        Me.lblAgencyLogin.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgencyLogin.Location = New System.Drawing.Point(376, 35)
        Me.lblAgencyLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgencyLogin.Name = "lblAgencyLogin"
        Me.lblAgencyLogin.Size = New System.Drawing.Size(169, 23)
        Me.lblAgencyLogin.TabIndex = 0
        Me.lblAgencyLogin.Text = "AGENCY LOG IN"
        '
        'btnAgencyNewUser
        '
        Me.btnAgencyNewUser.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnAgencyNewUser.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush
        Me.btnAgencyNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgencyNewUser.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgencyNewUser.ForeColor = System.Drawing.Color.Black
        Me.btnAgencyNewUser.Location = New System.Drawing.Point(459, 178)
        Me.btnAgencyNewUser.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgencyNewUser.Name = "btnAgencyNewUser"
        Me.btnAgencyNewUser.Size = New System.Drawing.Size(68, 29)
        Me.btnAgencyNewUser.TabIndex = 27
        Me.btnAgencyNewUser.Text = "Register?"
        Me.btnAgencyNewUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTipRegister.SetToolTip(Me.btnAgencyNewUser, "Join as TravelHop agencies")
        Me.btnAgencyNewUser.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(245, 343)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 27)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.Enabled = False
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(450, 343)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 27)
        Me.btnLogin.TabIndex = 23
        Me.btnLogin.Text = "&LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(245, 246)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(292, 24)
        Me.txtPassword.TabIndex = 22
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(245, 152)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(292, 24)
        Me.txtUsername.TabIndex = 21
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(245, 224)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 15)
        Me.lblPassword.TabIndex = 20
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(241, 132)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(62, 15)
        Me.lblUsername.TabIndex = 19
        Me.lblUsername.Text = "Username"
        '
        'AgencyBindingSource
        '
        Me.AgencyBindingSource.DataMember = "Agency"
        Me.AgencyBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'OMC_TravelHopDataSet
        '
        Me.OMC_TravelHopDataSet.DataSetName = "OMC_TravelHopDataSet"
        Me.OMC_TravelHopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgencyTableAdapter
        '
        Me.AgencyTableAdapter.ClearBeforeFill = True
        '
        'lblUsernameResult
        '
        Me.lblUsernameResult.AutoSize = True
        Me.lblUsernameResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "UserName", True))
        Me.lblUsernameResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblUsernameResult.Location = New System.Drawing.Point(13, 152)
        Me.lblUsernameResult.Name = "lblUsernameResult"
        Me.lblUsernameResult.Size = New System.Drawing.Size(0, 15)
        Me.lblUsernameResult.TabIndex = 28
        '
        'lblPasswordResult
        '
        Me.lblPasswordResult.AutoSize = True
        Me.lblPasswordResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Password", True))
        Me.lblPasswordResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblPasswordResult.Location = New System.Drawing.Point(13, 183)
        Me.lblPasswordResult.Name = "lblPasswordResult"
        Me.lblPasswordResult.Size = New System.Drawing.Size(0, 15)
        Me.lblPasswordResult.TabIndex = 29
        '
        'lblEmailResult
        '
        Me.lblEmailResult.AutoSize = True
        Me.lblEmailResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Email", True))
        Me.lblEmailResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblEmailResult.Location = New System.Drawing.Point(20, 193)
        Me.lblEmailResult.Name = "lblEmailResult"
        Me.lblEmailResult.Size = New System.Drawing.Size(0, 15)
        Me.lblEmailResult.TabIndex = 30
        '
        'chkShowPassword
        '
        Me.chkShowPassword.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.chkShowPassword.BackgroundImage = CType(resources.GetObject("chkShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.chkShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPassword.Location = New System.Drawing.Point(544, 246)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(31, 24)
        Me.chkShowPassword.TabIndex = 31
        Me.ToolTipPassword.SetToolTip(Me.chkShowPassword, "Show Password Characters")
        Me.chkShowPassword.UseVisualStyleBackColor = False
        '
        'frmAgencyLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(761, 407)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblEmailResult)
        Me.Controls.Add(Me.lblPasswordResult)
        Me.Controls.Add(Me.lblUsernameResult)
        Me.Controls.Add(Me.btnAgencyForgotPassword)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.btnAgencyNewUser)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAgencyLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Agency Log In"
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgencyForgotPassword As Button
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblAgencyLogin As Label
    Friend WithEvents btnAgencyNewUser As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents AgencyBindingSource As BindingSource
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents AgencyTableAdapter As OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter
    Friend WithEvents lblUsernameResult As Label
    Friend WithEvents lblPasswordResult As Label
    Friend WithEvents lblEmailResult As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents ToolTipPassword As ToolTip
    Friend WithEvents ToolTipRegister As ToolTip
End Class
