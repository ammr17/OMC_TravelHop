<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPage))
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.lblMainPage = New System.Windows.Forms.Label()
        Me.lblTAMainPage = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.AgencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.pnlAgencyInfo = New System.Windows.Forms.Panel()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.panelBackColor = New System.Windows.Forms.Panel()
        Me.btnAgencyBookings = New System.Windows.Forms.Button()
        Me.btnAgencyExit = New System.Windows.Forms.Button()
        Me.AgencyTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAgencyInfo.SuspendLayout()
        Me.panelBackColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBackColor.Controls.Add(Me.lblMainPage)
        Me.pnlBackColor.Controls.Add(Me.lblTAMainPage)
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Location = New System.Drawing.Point(-9, -6)
        Me.pnlBackColor.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(1198, 98)
        Me.pnlBackColor.TabIndex = 20
        '
        'lblMainPage
        '
        Me.lblMainPage.AutoSize = True
        Me.lblMainPage.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainPage.Location = New System.Drawing.Point(270, 37)
        Me.lblMainPage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMainPage.Name = "lblMainPage"
        Me.lblMainPage.Size = New System.Drawing.Size(121, 23)
        Me.lblMainPage.TabIndex = 10
        Me.lblMainPage.Text = "MAIN PAGE"
        '
        'lblTAMainPage
        '
        Me.lblTAMainPage.AutoSize = True
        Me.lblTAMainPage.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTAMainPage.Location = New System.Drawing.Point(23, 168)
        Me.lblTAMainPage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTAMainPage.Name = "lblTAMainPage"
        Me.lblTAMainPage.Size = New System.Drawing.Size(121, 23)
        Me.lblTAMainPage.TabIndex = 0
        Me.lblTAMainPage.Text = "MAIN PAGE"
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(425, 22)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(78, 58)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 9
        Me.picLogo.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(184, 245)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 20)
        Me.txtEmail.TabIndex = 11
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
        'pnlAgencyInfo
        '
        Me.pnlAgencyInfo.BackColor = System.Drawing.Color.LavenderBlush
        Me.pnlAgencyInfo.Controls.Add(Me.txtEmail)
        Me.pnlAgencyInfo.Controls.Add(Me.txtPhone)
        Me.pnlAgencyInfo.Controls.Add(Me.txtPassword)
        Me.pnlAgencyInfo.Controls.Add(Me.txtUsername)
        Me.pnlAgencyInfo.Controls.Add(Me.txtCompanyName)
        Me.pnlAgencyInfo.Controls.Add(Me.lblCompanyName)
        Me.pnlAgencyInfo.Controls.Add(Me.lblEmail)
        Me.pnlAgencyInfo.Controls.Add(Me.lblUsername)
        Me.pnlAgencyInfo.Controls.Add(Me.lblPassword)
        Me.pnlAgencyInfo.Controls.Add(Me.lblContactNo)
        Me.pnlAgencyInfo.Location = New System.Drawing.Point(220, 89)
        Me.pnlAgencyInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlAgencyInfo.Name = "pnlAgencyInfo"
        Me.pnlAgencyInfo.Size = New System.Drawing.Size(544, 321)
        Me.pnlAgencyInfo.TabIndex = 19
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Phone", True))
        Me.txtPhone.Enabled = False
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(184, 195)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(307, 20)
        Me.txtPhone.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "Password", True))
        Me.txtPassword.Enabled = False
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(184, 145)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(307, 20)
        Me.txtPassword.TabIndex = 9
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "UserName", True))
        Me.txtUsername.Enabled = False
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(184, 92)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(307, 20)
        Me.txtUsername.TabIndex = 8
        '
        'txtCompanyName
        '
        Me.txtCompanyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AgencyBindingSource, "CompanyName", True))
        Me.txtCompanyName.Enabled = False
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(184, 43)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(307, 20)
        Me.txtCompanyName.TabIndex = 7
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(55, 46)
        Me.lblCompanyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(85, 13)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "Company Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(55, 247)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(55, 97)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(55, 148)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(55, 197)
        Me.lblContactNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(87, 13)
        Me.lblContactNo.TabIndex = 5
        Me.lblContactNo.Text = "Contact Number:"
        '
        'panelBackColor
        '
        Me.panelBackColor.BackColor = System.Drawing.Color.OldLace
        Me.panelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBackColor.Controls.Add(Me.btnAgencyBookings)
        Me.panelBackColor.Controls.Add(Me.btnAgencyExit)
        Me.panelBackColor.Location = New System.Drawing.Point(0, -6)
        Me.panelBackColor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelBackColor.Name = "panelBackColor"
        Me.panelBackColor.Size = New System.Drawing.Size(224, 600)
        Me.panelBackColor.TabIndex = 18
        '
        'btnAgencyBookings
        '
        Me.btnAgencyBookings.BackColor = System.Drawing.Color.OldLace
        Me.btnAgencyBookings.FlatAppearance.BorderColor = System.Drawing.Color.OldLace
        Me.btnAgencyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgencyBookings.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgencyBookings.Location = New System.Drawing.Point(-4, 93)
        Me.btnAgencyBookings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgencyBookings.Name = "btnAgencyBookings"
        Me.btnAgencyBookings.Size = New System.Drawing.Size(226, 102)
        Me.btnAgencyBookings.TabIndex = 4
        Me.btnAgencyBookings.Text = "YOUR BOOKINGS"
        Me.btnAgencyBookings.UseVisualStyleBackColor = False
        '
        'btnAgencyExit
        '
        Me.btnAgencyExit.BackColor = System.Drawing.Color.OldLace
        Me.btnAgencyExit.FlatAppearance.BorderColor = System.Drawing.Color.OldLace
        Me.btnAgencyExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgencyExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgencyExit.Location = New System.Drawing.Point(-4, 291)
        Me.btnAgencyExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgencyExit.Name = "btnAgencyExit"
        Me.btnAgencyExit.Size = New System.Drawing.Size(226, 92)
        Me.btnAgencyExit.TabIndex = 6
        Me.btnAgencyExit.Text = "EXIT"
        Me.btnAgencyExit.UseVisualStyleBackColor = False
        '
        'AgencyTableAdapter
        '
        Me.AgencyTableAdapter.ClearBeforeFill = True
        '
        'frmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 378)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.pnlAgencyInfo)
        Me.Controls.Add(Me.panelBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Agency "
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAgencyInfo.ResumeLayout(False)
        Me.pnlAgencyInfo.PerformLayout()
        Me.panelBackColor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents lblTAMainPage As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pnlAgencyInfo As Panel
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents panelBackColor As Panel
    Friend WithEvents btnAgencyBookings As Button
    Friend WithEvents btnAgencyExit As Button
    Friend WithEvents lblMainPage As Label
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents AgencyBindingSource As BindingSource
    Friend WithEvents AgencyTableAdapter As OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter
End Class
