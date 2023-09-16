<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.pnlCarInfo = New System.Windows.Forms.Panel()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.RentalCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblActivities = New System.Windows.Forms.Label()
        Me.lblAccommodation = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblDropOff = New System.Windows.Forms.Label()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.lblPickUp = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblCarInfo = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lbPhoneNum = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grdUsers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PickUpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DropOffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.RentalCarTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter()
        Me.pnlUserInfo.SuspendLayout()
        Me.pnlCarInfo.SuspendLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlUserInfo
        '
        Me.pnlUserInfo.BackColor = System.Drawing.Color.Linen
        Me.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUserInfo.Controls.Add(Me.pnlCarInfo)
        Me.pnlUserInfo.Controls.Add(Me.lblPhoneNumber)
        Me.pnlUserInfo.Controls.Add(Me.lblUsername)
        Me.pnlUserInfo.Controls.Add(Me.lblInfo)
        Me.pnlUserInfo.Controls.Add(Me.lbPhoneNum)
        Me.pnlUserInfo.Controls.Add(Me.lblName)
        Me.pnlUserInfo.Location = New System.Drawing.Point(309, 42)
        Me.pnlUserInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlUserInfo.Name = "pnlUserInfo"
        Me.pnlUserInfo.Size = New System.Drawing.Size(269, 288)
        Me.pnlUserInfo.TabIndex = 24
        '
        'pnlCarInfo
        '
        Me.pnlCarInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCarInfo.Controls.Add(Me.lblPrice)
        Me.pnlCarInfo.Controls.Add(Me.lblActivities)
        Me.pnlCarInfo.Controls.Add(Me.lblAccommodation)
        Me.pnlCarInfo.Controls.Add(Me.lblDestination)
        Me.pnlCarInfo.Controls.Add(Me.lblDropOff)
        Me.pnlCarInfo.Controls.Add(Me.lblSeats)
        Me.pnlCarInfo.Controls.Add(Me.lblPickUp)
        Me.pnlCarInfo.Controls.Add(Me.lblCar)
        Me.pnlCarInfo.Controls.Add(Me.lblCarInfo)
        Me.pnlCarInfo.Location = New System.Drawing.Point(-1, 102)
        Me.pnlCarInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCarInfo.Name = "pnlCarInfo"
        Me.pnlCarInfo.Size = New System.Drawing.Size(269, 185)
        Me.pnlCarInfo.TabIndex = 25
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Linen
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "DropOff", True))
        Me.lblPrice.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(120, 141)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(119, 21)
        Me.lblPrice.TabIndex = 32
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RentalCarBindingSource
        '
        Me.RentalCarBindingSource.DataMember = "RentalCar"
        Me.RentalCarBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'OMC_TravelHopDataSet
        '
        Me.OMC_TravelHopDataSet.DataSetName = "OMC_TravelHopDataSet"
        Me.OMC_TravelHopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblActivities
        '
        Me.lblActivities.BackColor = System.Drawing.Color.Linen
        Me.lblActivities.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "PickUp", True))
        Me.lblActivities.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivities.Location = New System.Drawing.Point(120, 104)
        Me.lblActivities.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActivities.Name = "lblActivities"
        Me.lblActivities.Size = New System.Drawing.Size(119, 21)
        Me.lblActivities.TabIndex = 31
        Me.lblActivities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAccommodation
        '
        Me.lblAccommodation.BackColor = System.Drawing.Color.Linen
        Me.lblAccommodation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Seats", True))
        Me.lblAccommodation.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccommodation.Location = New System.Drawing.Point(120, 72)
        Me.lblAccommodation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccommodation.Name = "lblAccommodation"
        Me.lblAccommodation.Size = New System.Drawing.Size(119, 21)
        Me.lblAccommodation.TabIndex = 30
        Me.lblAccommodation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDestination
        '
        Me.lblDestination.BackColor = System.Drawing.Color.Linen
        Me.lblDestination.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "CarType", True))
        Me.lblDestination.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(120, 42)
        Me.lblDestination.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(119, 21)
        Me.lblDestination.TabIndex = 26
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDropOff
        '
        Me.lblDropOff.AutoSize = True
        Me.lblDropOff.Location = New System.Drawing.Point(9, 143)
        Me.lblDropOff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDropOff.Name = "lblDropOff"
        Me.lblDropOff.Size = New System.Drawing.Size(60, 15)
        Me.lblDropOff.TabIndex = 29
        Me.lblDropOff.Text = "Drop Off :"
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Location = New System.Drawing.Point(9, 74)
        Me.lblSeats.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(41, 15)
        Me.lblSeats.TabIndex = 28
        Me.lblSeats.Text = "Seats :"
        '
        'lblPickUp
        '
        Me.lblPickUp.AutoSize = True
        Me.lblPickUp.Location = New System.Drawing.Point(9, 107)
        Me.lblPickUp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPickUp.Name = "lblPickUp"
        Me.lblPickUp.Size = New System.Drawing.Size(52, 15)
        Me.lblPickUp.TabIndex = 27
        Me.lblPickUp.Text = "Pick Up :"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Location = New System.Drawing.Point(9, 42)
        Me.lblCar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(32, 15)
        Me.lblCar.TabIndex = 26
        Me.lblCar.Text = "Car :"
        '
        'lblCarInfo
        '
        Me.lblCarInfo.AutoSize = True
        Me.lblCarInfo.BackColor = System.Drawing.Color.Linen
        Me.lblCarInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarInfo.Location = New System.Drawing.Point(9, 7)
        Me.lblCarInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCarInfo.Name = "lblCarInfo"
        Me.lblCarInfo.Size = New System.Drawing.Size(132, 15)
        Me.lblCarInfo.TabIndex = 26
        Me.lblCarInfo.Text = "CAR INFORMATION"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Linen
        Me.lblPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Phone", True))
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(120, 59)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(119, 21)
        Me.lblPhoneNumber.TabIndex = 24
        Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Linen
        Me.lblUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "FullName", True))
        Me.lblUsername.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(120, 27)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 21)
        Me.lblUsername.TabIndex = 23
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(9, 0)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(143, 15)
        Me.lblInfo.TabIndex = 22
        Me.lblInfo.Text = "USER INFORMATION"
        '
        'lbPhoneNum
        '
        Me.lbPhoneNum.AutoSize = True
        Me.lbPhoneNum.Location = New System.Drawing.Point(9, 61)
        Me.lbPhoneNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPhoneNum.Name = "lbPhoneNum"
        Me.lbPhoneNum.Size = New System.Drawing.Size(93, 15)
        Me.lbPhoneNum.TabIndex = 21
        Me.lbPhoneNum.Text = "Phone Number :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 29)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 15)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Name :"
        '
        'grdUsers
        '
        Me.grdUsers.AutoGenerateColumns = False
        Me.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.FullNameDataGridViewTextBoxColumn, Me.CarTypeDataGridViewTextBoxColumn, Me.PickUpDataGridViewTextBoxColumn, Me.DropOffDataGridViewTextBoxColumn, Me.SeatsDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.grdUsers.DataSource = Me.RentalCarBindingSource
        Me.grdUsers.Location = New System.Drawing.Point(31, 42)
        Me.grdUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.grdUsers.Name = "grdUsers"
        Me.grdUsers.RowHeadersWidth = 40
        Me.grdUsers.RowTemplate.Height = 28
        Me.grdUsers.Size = New System.Drawing.Size(250, 287)
        Me.grdUsers.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'CarTypeDataGridViewTextBoxColumn
        '
        Me.CarTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.HeaderText = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.Name = "CarTypeDataGridViewTextBoxColumn"
        '
        'PickUpDataGridViewTextBoxColumn
        '
        Me.PickUpDataGridViewTextBoxColumn.DataPropertyName = "PickUp"
        Me.PickUpDataGridViewTextBoxColumn.HeaderText = "PickUp"
        Me.PickUpDataGridViewTextBoxColumn.Name = "PickUpDataGridViewTextBoxColumn"
        '
        'DropOffDataGridViewTextBoxColumn
        '
        Me.DropOffDataGridViewTextBoxColumn.DataPropertyName = "DropOff"
        Me.DropOffDataGridViewTextBoxColumn.HeaderText = "DropOff"
        Me.DropOffDataGridViewTextBoxColumn.Name = "DropOffDataGridViewTextBoxColumn"
        '
        'SeatsDataGridViewTextBoxColumn
        '
        Me.SeatsDataGridViewTextBoxColumn.DataPropertyName = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.HeaderText = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.Name = "SeatsDataGridViewTextBoxColumn"
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
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Thistle
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(592, 7)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'RentalCarTableAdapter
        '
        Me.RentalCarTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(622, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlUserInfo)
        Me.Controls.Add(Me.grdUsers)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlUserInfo.ResumeLayout(False)
        Me.pnlUserInfo.PerformLayout()
        Me.pnlCarInfo.ResumeLayout(False)
        Me.pnlCarInfo.PerformLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlUserInfo As Panel
    Friend WithEvents pnlCarInfo As Panel
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblActivities As Label
    Friend WithEvents lblAccommodation As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblDropOff As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblPickUp As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblCarInfo As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lbPhoneNum As Label
    Friend WithEvents lblName As Label
    Friend WithEvents grdUsers As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestinationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccomodationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivitiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeedbackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfilePicDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PickUpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DropOffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents RentalCarBindingSource As BindingSource
    Friend WithEvents RentalCarTableAdapter As OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter
End Class
