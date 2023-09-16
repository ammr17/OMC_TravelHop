<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserLogin))
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.lblUsernameResult = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblPasswordResult = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblEmailResult = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter()
        Me.ToolTipPassword = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLogin.Location = New System.Drawing.Point(294, 53)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(187, 34)
        Me.lblUserLogin.TabIndex = 0
        Me.lblUserLogin.Text = "USER LOGIN"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(266, 177)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(89, 20)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(269, 258)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(83, 20)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(269, 196)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(251, 31)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(269, 277)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(251, 33)
        Me.txtPassword.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.Enabled = False
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(445, 361)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "&LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(269, 361)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(455, 38)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 7
        Me.picLogo.TabStop = False
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblUserLogin)
        Me.pnlBackColor.Location = New System.Drawing.Point(-12, -4)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(851, 120)
        Me.pnlBackColor.TabIndex = 8
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush
        Me.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgotPassword.Location = New System.Drawing.Point(415, 306)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(112, 29)
        Me.btnForgotPassword.TabIndex = 9
        Me.btnForgotPassword.Text = "Forgot Password?"
        Me.ToolTipPassword.SetToolTip(Me.btnForgotPassword, "Reset Your Password")
        Me.btnForgotPassword.UseVisualStyleBackColor = False
        '
        'lblUsernameResult
        '
        Me.lblUsernameResult.AutoSize = True
        Me.lblUsernameResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "UserName", True))
        Me.lblUsernameResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblUsernameResult.Location = New System.Drawing.Point(22, 130)
        Me.lblUsernameResult.Name = "lblUsernameResult"
        Me.lblUsernameResult.Size = New System.Drawing.Size(0, 20)
        Me.lblUsernameResult.TabIndex = 10
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
        'lblPasswordResult
        '
        Me.lblPasswordResult.AutoSize = True
        Me.lblPasswordResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Password", True))
        Me.lblPasswordResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblPasswordResult.Location = New System.Drawing.Point(22, 159)
        Me.lblPasswordResult.Name = "lblPasswordResult"
        Me.lblPasswordResult.Size = New System.Drawing.Size(0, 20)
        Me.lblPasswordResult.TabIndex = 11
        '
        'chkShowPassword
        '
        Me.chkShowPassword.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.chkShowPassword.BackgroundImage = CType(resources.GetObject("chkShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.chkShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPassword.Location = New System.Drawing.Point(526, 277)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(31, 24)
        Me.chkShowPassword.TabIndex = 12
        Me.ToolTipPassword.SetToolTip(Me.chkShowPassword, "Show Characters")
        Me.chkShowPassword.UseVisualStyleBackColor = False
        '
        'lblEmailResult
        '
        Me.lblEmailResult.AutoSize = True
        Me.lblEmailResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.lblEmailResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblEmailResult.Location = New System.Drawing.Point(25, 223)
        Me.lblEmailResult.Name = "lblEmailResult"
        Me.lblEmailResult.Size = New System.Drawing.Size(0, 20)
        Me.lblEmailResult.TabIndex = 13
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'FrmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEmailResult)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblPasswordResult)
        Me.Controls.Add(Me.lblUsernameResult)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Login"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserLogin As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents lblUsernameResult As Label
    Friend WithEvents lblPasswordResult As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblEmailResult As Label
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ToolTipPassword As ToolTip
End Class
