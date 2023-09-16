<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserProfile))
        Me.lblMyProfile = New System.Windows.Forms.Label()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnProfilePicture = New System.Windows.Forms.Button()
        Me.picProfilePicture = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserInfo.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMyProfile
        '
        Me.lblMyProfile.AutoSize = True
        Me.lblMyProfile.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyProfile.Location = New System.Drawing.Point(299, 27)
        Me.lblMyProfile.Name = "lblMyProfile"
        Me.lblMyProfile.Size = New System.Drawing.Size(189, 35)
        Me.lblMyProfile.TabIndex = 0
        Me.lblMyProfile.Text = "MY PROFILE"
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblMyProfile)
        Me.pnlBackColor.Location = New System.Drawing.Point(-3, 26)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(812, 85)
        Me.pnlBackColor.TabIndex = 1
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(432, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(33, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(33, 76)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(94, 20)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(33, 121)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(57, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email:"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(33, 164)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(114, 20)
        Me.lblDateOfBirth.TabIndex = 5
        Me.lblDateOfBirth.Text = "Date of Birth:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(33, 207)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(132, 20)
        Me.lblPhoneNumber.TabIndex = 6
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'pnlUserInfo
        '
        Me.pnlUserInfo.BackColor = System.Drawing.Color.FloralWhite
        Me.pnlUserInfo.Controls.Add(Me.txtPhoneNumber)
        Me.pnlUserInfo.Controls.Add(Me.txtDateOfBirth)
        Me.pnlUserInfo.Controls.Add(Me.txtEmail)
        Me.pnlUserInfo.Controls.Add(Me.txtUsername)
        Me.pnlUserInfo.Controls.Add(Me.txtName)
        Me.pnlUserInfo.Controls.Add(Me.lblName)
        Me.pnlUserInfo.Controls.Add(Me.lblPhoneNumber)
        Me.pnlUserInfo.Controls.Add(Me.lblUsername)
        Me.pnlUserInfo.Controls.Add(Me.lblEmail)
        Me.pnlUserInfo.Controls.Add(Me.lblDateOfBirth)
        Me.pnlUserInfo.Location = New System.Drawing.Point(31, 155)
        Me.pnlUserInfo.Name = "pnlUserInfo"
        Me.pnlUserInfo.Size = New System.Drawing.Size(486, 268)
        Me.pnlUserInfo.TabIndex = 7
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.txtPhoneNumber.Enabled = False
        Me.txtPhoneNumber.Location = New System.Drawing.Point(158, 204)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(262, 31)
        Me.txtPhoneNumber.TabIndex = 11
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
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DateOfBirth", True))
        Me.txtDateOfBirth.Enabled = False
        Me.txtDateOfBirth.Location = New System.Drawing.Point(158, 161)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(262, 31)
        Me.txtDateOfBirth.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(158, 118)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(262, 31)
        Me.txtEmail.TabIndex = 9
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "UserName", True))
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(158, 73)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(262, 31)
        Me.txtUsername.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FullName", True))
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(158, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(262, 31)
        Me.txtName.TabIndex = 7
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(387, 454)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(130, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "&EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(31, 454)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(130, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.White
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Location = New System.Drawing.Point(205, 454)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(130, 23)
        Me.btnChangePassword.TabIndex = 9
        Me.btnChangePassword.Text = "&CHANGE PASSWORD"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnProfilePicture
        '
        Me.btnProfilePicture.BackColor = System.Drawing.Color.White
        Me.btnProfilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfilePicture.Location = New System.Drawing.Point(600, 358)
        Me.btnProfilePicture.Name = "btnProfilePicture"
        Me.btnProfilePicture.Size = New System.Drawing.Size(130, 23)
        Me.btnProfilePicture.TabIndex = 11
        Me.btnProfilePicture.Text = "&PROFILE PICTURE"
        Me.ToolTip1.SetToolTip(Me.btnProfilePicture, "Upload Your Photo")
        Me.btnProfilePicture.UseVisualStyleBackColor = False
        '
        'picProfilePicture
        '
        Me.picProfilePicture.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CustomerBindingSource, "ProfilePhoto", True))
        Me.picProfilePicture.Image = CType(resources.GetObject("picProfilePicture.Image"), System.Drawing.Image)
        Me.picProfilePicture.Location = New System.Drawing.Point(600, 187)
        Me.picProfilePicture.Name = "picProfilePicture"
        Me.picProfilePicture.Size = New System.Drawing.Size(130, 150)
        Me.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfilePicture.TabIndex = 12
        Me.picProfilePicture.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(600, 454)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Password", True))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblNewPassword.Location = New System.Drawing.Point(629, 218)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(0, 20)
        Me.lblNewPassword.TabIndex = 14
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutUsMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColourMenu, Me.FontMenu})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(154, 29)
        Me.MenuToolStripMenuItem.Text = "Customize Page"
        '
        'ColourMenu
        '
        Me.ColourMenu.Name = "ColourMenu"
        Me.ColourMenu.Size = New System.Drawing.Size(167, 34)
        Me.ColourMenu.Text = "Colour"
        '
        'FontMenu
        '
        Me.FontMenu.Name = "FontMenu"
        Me.FontMenu.Size = New System.Drawing.Size(167, 34)
        Me.FontMenu.Text = "Font"
        '
        'AboutUsMenu
        '
        Me.AboutUsMenu.Name = "AboutUsMenu"
        Me.AboutUsMenu.Size = New System.Drawing.Size(108, 29)
        Me.AboutUsMenu.Text = " About Us"
        '
        'FrmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.picProfilePicture)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnProfilePicture)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.pnlUserInfo)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - My Profile"
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserInfo.ResumeLayout(False)
        Me.pnlUserInfo.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMyProfile As Label
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents pnlUserInfo As Panel
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnProfilePicture As Button
    Friend WithEvents picProfilePicture As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColourMenu As ToolStripMenuItem
    Friend WithEvents FontMenu As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents AboutUsMenu As ToolStripMenuItem
End Class
