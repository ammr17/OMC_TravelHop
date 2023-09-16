<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnCarRental = New System.Windows.Forms.Button()
        Me.btnHotel = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.lblPswd = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picAdminLogo = New System.Windows.Forms.PictureBox()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.grdUsers = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfilePhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CustomerTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter()
        Me.ToolTipHotel = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipCar = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlDetails.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdmin.SuspendLayout()
        CType(Me.picAdminLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Linen
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Gill Sans MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(15, 377)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(184, 60)
        Me.lblDate.TabIndex = 15
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCarRental
        '
        Me.btnCarRental.BackColor = System.Drawing.Color.White
        Me.btnCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarRental.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarRental.Location = New System.Drawing.Point(356, 377)
        Me.btnCarRental.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCarRental.Name = "btnCarRental"
        Me.btnCarRental.Size = New System.Drawing.Size(119, 28)
        Me.btnCarRental.TabIndex = 14
        Me.btnCarRental.Text = "&Car Rental"
        Me.ToolTipCar.SetToolTip(Me.btnCarRental, "View Car Rental Records")
        Me.btnCarRental.UseVisualStyleBackColor = False
        '
        'btnHotel
        '
        Me.btnHotel.BackColor = System.Drawing.Color.White
        Me.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHotel.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHotel.Location = New System.Drawing.Point(225, 377)
        Me.btnHotel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHotel.Name = "btnHotel"
        Me.btnHotel.Size = New System.Drawing.Size(118, 28)
        Me.btnHotel.TabIndex = 13
        Me.btnHotel.Text = "&Hotel Records"
        Me.ToolTipHotel.SetToolTip(Me.btnHotel, "View Hotel Records")
        Me.btnHotel.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.White
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedback.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.Location = New System.Drawing.Point(225, 410)
        Me.btnFeedback.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(250, 28)
        Me.btnFeedback.TabIndex = 12
        Me.btnFeedback.Text = "View Customer &Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.Linen
        Me.pnlDetails.Controls.Add(Me.lbEmail)
        Me.pnlDetails.Controls.Add(Me.lblPhoneNum)
        Me.pnlDetails.Controls.Add(Me.lblPswd)
        Me.pnlDetails.Controls.Add(Me.lblUser)
        Me.pnlDetails.Controls.Add(Me.lblID)
        Me.pnlDetails.Controls.Add(Me.lblPhoneNumber)
        Me.pnlDetails.Controls.Add(Me.lblPassword)
        Me.pnlDetails.Controls.Add(Me.lblUsername)
        Me.pnlDetails.Location = New System.Drawing.Point(15, 99)
        Me.pnlDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(184, 273)
        Me.pnlDetails.TabIndex = 11
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(52, 196)
        Me.lbEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(36, 15)
        Me.lbEmail.TabIndex = 10
        Me.lbEmail.Text = "Email"
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.Location = New System.Drawing.Point(52, 141)
        Me.lblPhoneNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(87, 15)
        Me.lblPhoneNum.TabIndex = 9
        Me.lblPhoneNum.Text = "Phone Number"
        '
        'lblPswd
        '
        Me.lblPswd.AutoSize = True
        Me.lblPswd.Location = New System.Drawing.Point(61, 88)
        Me.lblPswd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPswd.Name = "lblPswd"
        Me.lblPswd.Size = New System.Drawing.Size(58, 15)
        Me.lblPswd.TabIndex = 8
        Me.lblPswd.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(61, 33)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(62, 15)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "Username"
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.lblID.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(34, 219)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(119, 21)
        Me.lblID.TabIndex = 6
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.White
        Me.lblPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(34, 167)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(119, 21)
        Me.lblPhoneNumber.TabIndex = 5
        Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Password", True))
        Me.lblPassword.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(34, 112)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(119, 21)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "UserName", True))
        Me.lblUsername.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(34, 58)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 21)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.LavenderBlush
        Me.pnlAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdmin.Controls.Add(Me.btnExit)
        Me.pnlAdmin.Controls.Add(Me.picAdminLogo)
        Me.pnlAdmin.Controls.Add(Me.lblAdmin)
        Me.pnlAdmin.Location = New System.Drawing.Point(-4, -5)
        Me.pnlAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(494, 78)
        Me.pnlAdmin.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Thistle
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(451, 14)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picAdminLogo
        '
        Me.picAdminLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picAdminLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAdminLogo.Image = CType(resources.GetObject("picAdminLogo.Image"), System.Drawing.Image)
        Me.picAdminLogo.Location = New System.Drawing.Point(18, 14)
        Me.picAdminLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.picAdminLogo.Name = "picAdminLogo"
        Me.picAdminLogo.Size = New System.Drawing.Size(43, 48)
        Me.picAdminLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAdminLogo.TabIndex = 1
        Me.picAdminLogo.TabStop = False
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(197, 29)
        Me.lblAdmin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(61, 20)
        Me.lblAdmin.TabIndex = 0
        Me.lblAdmin.Text = "ADMIN"
        '
        'grdUsers
        '
        Me.grdUsers.AutoGenerateColumns = False
        Me.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.ProfilePhotoDataGridViewImageColumn})
        Me.grdUsers.DataSource = Me.CustomerBindingSource
        Me.grdUsers.Location = New System.Drawing.Point(225, 106)
        Me.grdUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.grdUsers.Name = "grdUsers"
        Me.grdUsers.RowHeadersWidth = 40
        Me.grdUsers.RowTemplate.Height = 28
        Me.grdUsers.Size = New System.Drawing.Size(250, 267)
        Me.grdUsers.TabIndex = 16
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'ProfilePhotoDataGridViewImageColumn
        '
        Me.ProfilePhotoDataGridViewImageColumn.DataPropertyName = "ProfilePhoto"
        Me.ProfilePhotoDataGridViewImageColumn.HeaderText = "ProfilePhoto"
        Me.ProfilePhotoDataGridViewImageColumn.Name = "ProfilePhotoDataGridViewImageColumn"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(490, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdUsers)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnCarRental)
        Me.Controls.Add(Me.btnHotel)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlAdmin)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlAdmin.PerformLayout()
        CType(Me.picAdminLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDate As Label
    Friend WithEvents btnCarRental As Button
    Friend WithEvents btnHotel As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lbEmail As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblPswd As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents picAdminLogo As PictureBox
    Friend WithEvents lblAdmin As Label
    Friend WithEvents grdUsers As DataGridView
    Friend WithEvents UserBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfilePhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ToolTipCar As ToolTip
    Friend WithEvents ToolTipHotel As ToolTip
End Class
