<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTARegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTARegistration))
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblUserRegistration = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.AgencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.mtxtPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.AgencyTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkShowPassword
        '
        Me.chkShowPassword.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.chkShowPassword.BackgroundImage = CType(resources.GetObject("chkShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.chkShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPassword.Location = New System.Drawing.Point(318, 298)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(28, 26)
        Me.chkShowPassword.TabIndex = 44
        Me.chkShowPassword.UseVisualStyleBackColor = False
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblUserRegistration)
        Me.pnlBackColor.Location = New System.Drawing.Point(-6, -3)
        Me.pnlBackColor.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(442, 92)
        Me.pnlBackColor.TabIndex = 42
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(314, 23)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(65, 42)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = False
        '
        'lblUserRegistration
        '
        Me.lblUserRegistration.AutoSize = True
        Me.lblUserRegistration.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRegistration.Location = New System.Drawing.Point(61, 34)
        Me.lblUserRegistration.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserRegistration.Name = "lblUserRegistration"
        Me.lblUserRegistration.Size = New System.Drawing.Size(212, 23)
        Me.lblUserRegistration.TabIndex = 0
        Me.lblUserRegistration.Text = "USER REGISTRATION"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(111, 389)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 29)
        Me.btnBack.TabIndex = 39
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Location = New System.Drawing.Point(230, 389)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(85, 29)
        Me.btnRegister.TabIndex = 37
        Me.btnRegister.Text = "&REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Enabled = False
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(111, 342)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(205, 24)
        Me.txtConfirmPassword.TabIndex = 35
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Password", True))
        Me.txtPassword.Enabled = False
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(111, 298)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(205, 24)
        Me.txtPassword.TabIndex = 34
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
        'mtxtPhoneNo
        '
        Me.mtxtPhoneNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Phone", True))
        Me.mtxtPhoneNo.Enabled = False
        Me.mtxtPhoneNo.Location = New System.Drawing.Point(111, 251)
        Me.mtxtPhoneNo.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxtPhoneNo.Mask = "+6###-#######"
        Me.mtxtPhoneNo.Name = "mtxtPhoneNo"
        Me.mtxtPhoneNo.Size = New System.Drawing.Size(205, 20)
        Me.mtxtPhoneNo.SkipLiterals = False
        Me.mtxtPhoneNo.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(111, 205)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(205, 20)
        Me.txtEmail.TabIndex = 30
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "UserName", True))
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(110, 153)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(205, 20)
        Me.txtUsername.TabIndex = 27
        '
        'txtCompanyName
        '
        Me.txtCompanyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "CompanyName", True))
        Me.txtCompanyName.Enabled = False
        Me.txtCompanyName.Location = New System.Drawing.Point(110, 107)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(205, 20)
        Me.txtCompanyName.TabIndex = 25
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(108, 237)
        Me.lblPhoneNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(95, 14)
        Me.lblPhoneNo.TabIndex = 38
        Me.lblPhoneNo.Text = "Contact Number"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(108, 328)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(103, 14)
        Me.lblConfirmPassword.TabIndex = 36
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(108, 283)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(58, 14)
        Me.lblPassword.TabIndex = 33
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(108, 191)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(34, 14)
        Me.lblEmail.TabIndex = 32
        Me.lblEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(107, 139)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(61, 14)
        Me.lblUsername.TabIndex = 29
        Me.lblUsername.Text = "Username"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(107, 93)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(91, 14)
        Me.lblFullName.TabIndex = 26
        Me.lblFullName.Text = "Company Name"
        '
        'AgencyTableAdapter
        '
        Me.AgencyTableAdapter.ClearBeforeFill = True
        '
        'frmTARegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(434, 438)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.mtxtPhoneNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblPhoneNo)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblFullName)
        Me.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTARegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agency - Registration"
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblUserRegistration As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents mtxtPhoneNo As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents AgencyBindingSource As BindingSource
    Friend WithEvents AgencyTableAdapter As OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter
End Class
