<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserRegistration))
        Me.lblUserRegistration = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mtxtPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.lblDateOfBirthResult = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.CustomerTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter()
        Me.ToolTipPassword = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserRegistration
        '
        Me.lblUserRegistration.AutoSize = True
        Me.lblUserRegistration.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRegistration.Location = New System.Drawing.Point(252, 32)
        Me.lblUserRegistration.Name = "lblUserRegistration"
        Me.lblUserRegistration.Size = New System.Drawing.Size(212, 23)
        Me.lblUserRegistration.TabIndex = 0
        Me.lblUserRegistration.Text = "USER REGISTRATION"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(55, 104)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(60, 15)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Full Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(55, 169)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(62, 15)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(467, 104)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 15)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(467, 236)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 15)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(467, 300)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(106, 15)
        Me.lblConfirmPassword.TabIndex = 6
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(467, 169)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(87, 15)
        Me.lblPhoneNo.TabIndex = 7
        Me.lblPhoneNo.Text = "Phone Number"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(55, 236)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(73, 15)
        Me.lblDateOfBirth.TabIndex = 8
        Me.lblDateOfBirth.Text = "Date of Birth"
        '
        'txtFullName
        '
        Me.txtFullName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FullName", True))
        Me.txtFullName.Enabled = False
        Me.txtFullName.Location = New System.Drawing.Point(58, 124)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(262, 23)
        Me.txtFullName.TabIndex = 0
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'OMC_TravelHopDataSet
        '
        Me.OMC_TravelHopDataSet.DataSetName = "OMC_TravelHopDataSet"
        Me.OMC_TravelHopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "UserName", True))
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(58, 189)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(262, 23)
        Me.txtUsername.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(470, 124)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(262, 23)
        Me.txtEmail.TabIndex = 3
        '
        'mtxtPhoneNo
        '
        Me.mtxtPhoneNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.mtxtPhoneNo.Enabled = False
        Me.mtxtPhoneNo.Location = New System.Drawing.Point(470, 189)
        Me.mtxtPhoneNo.Mask = "+6###-#######"
        Me.mtxtPhoneNo.Name = "mtxtPhoneNo"
        Me.mtxtPhoneNo.Size = New System.Drawing.Size(262, 23)
        Me.mtxtPhoneNo.SkipLiterals = False
        Me.mtxtPhoneNo.TabIndex = 4
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Enabled = False
        Me.MonthCalendar1.Location = New System.Drawing.Point(58, 260)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Password", True))
        Me.txtPassword.Enabled = False
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(470, 257)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(262, 24)
        Me.txtPassword.TabIndex = 5
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Enabled = False
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(470, 320)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(262, 24)
        Me.txtConfirmPassword.TabIndex = 6
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Location = New System.Drawing.Point(623, 387)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(109, 23)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "&REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(470, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(109, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(498, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = False
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.OldLace
        Me.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBorder.Location = New System.Drawing.Point(385, 104)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(10, 320)
        Me.pnlBorder.TabIndex = 21
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblUserRegistration)
        Me.pnlBackColor.Location = New System.Drawing.Point(-6, -7)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(829, 80)
        Me.pnlBackColor.TabIndex = 22
        '
        'lblDateOfBirthResult
        '
        Me.lblDateOfBirthResult.AutoSize = True
        Me.lblDateOfBirthResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DateOfBirth", True))
        Me.lblDateOfBirthResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblDateOfBirthResult.Location = New System.Drawing.Point(168, 236)
        Me.lblDateOfBirthResult.Name = "lblDateOfBirthResult"
        Me.lblDateOfBirthResult.Size = New System.Drawing.Size(0, 15)
        Me.lblDateOfBirthResult.TabIndex = 23
        '
        'chkShowPassword
        '
        Me.chkShowPassword.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.chkShowPassword.BackgroundImage = CType(resources.GetObject("chkShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.chkShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPassword.Location = New System.Drawing.Point(738, 257)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(31, 24)
        Me.chkShowPassword.TabIndex = 24
        Me.ToolTipPassword.SetToolTip(Me.chkShowPassword, "Show Characters")
        Me.chkShowPassword.UseVisualStyleBackColor = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'FrmUserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblDateOfBirthResult)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.pnlBorder)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.mtxtPhoneNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblPhoneNo)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFullName)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Registration"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserRegistration As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtxtPhoneNo As MaskedTextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlBorder As Panel
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents lblDateOfBirthResult As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ToolTipPassword As ToolTip
End Class
