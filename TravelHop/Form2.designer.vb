<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grdUsers = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotelNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreakfastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingHotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.pnlRoomInfo = New System.Windows.Forms.Panel()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblActivities = New System.Windows.Forms.Label()
        Me.lblAccommodation = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblChckIn = New System.Windows.Forms.Label()
        Me.lblHotelName = New System.Windows.Forms.Label()
        Me.lblRoomInfo = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lbPhoneNum = New System.Windows.Forms.Label()
        Me.BookingHotelTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserInfo.SuspendLayout()
        Me.pnlRoomInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Pink
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(587, 9)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'grdUsers
        '
        Me.grdUsers.AutoGenerateColumns = False
        Me.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.HotelNameDataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.BreakfastDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.CheckInDataGridViewTextBoxColumn, Me.CheckOutDataGridViewTextBoxColumn})
        Me.grdUsers.DataSource = Me.BookingHotelBindingSource
        Me.grdUsers.Location = New System.Drawing.Point(27, 44)
        Me.grdUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.grdUsers.Name = "grdUsers"
        Me.grdUsers.RowHeadersWidth = 40
        Me.grdUsers.RowTemplate.Height = 28
        Me.grdUsers.Size = New System.Drawing.Size(250, 287)
        Me.grdUsers.TabIndex = 19
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'HotelNameDataGridViewTextBoxColumn
        '
        Me.HotelNameDataGridViewTextBoxColumn.DataPropertyName = "HotelName"
        Me.HotelNameDataGridViewTextBoxColumn.HeaderText = "HotelName"
        Me.HotelNameDataGridViewTextBoxColumn.Name = "HotelNameDataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        '
        'BreakfastDataGridViewTextBoxColumn
        '
        Me.BreakfastDataGridViewTextBoxColumn.DataPropertyName = "Breakfast"
        Me.BreakfastDataGridViewTextBoxColumn.HeaderText = "Breakfast"
        Me.BreakfastDataGridViewTextBoxColumn.Name = "BreakfastDataGridViewTextBoxColumn"
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
        'CheckInDataGridViewTextBoxColumn
        '
        Me.CheckInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn"
        Me.CheckInDataGridViewTextBoxColumn.HeaderText = "CheckIn"
        Me.CheckInDataGridViewTextBoxColumn.Name = "CheckInDataGridViewTextBoxColumn"
        '
        'CheckOutDataGridViewTextBoxColumn
        '
        Me.CheckOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut"
        Me.CheckOutDataGridViewTextBoxColumn.HeaderText = "CheckOut"
        Me.CheckOutDataGridViewTextBoxColumn.Name = "CheckOutDataGridViewTextBoxColumn"
        '
        'BookingHotelBindingSource
        '
        Me.BookingHotelBindingSource.DataMember = "BookingHotel"
        Me.BookingHotelBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'OMC_TravelHopDataSet
        '
        Me.OMC_TravelHopDataSet.DataSetName = "OMC_TravelHopDataSet"
        Me.OMC_TravelHopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'pnlUserInfo
        '
        Me.pnlUserInfo.BackColor = System.Drawing.Color.Linen
        Me.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUserInfo.Controls.Add(Me.pnlRoomInfo)
        Me.pnlUserInfo.Controls.Add(Me.lblPhoneNumber)
        Me.pnlUserInfo.Controls.Add(Me.lblUsername)
        Me.pnlUserInfo.Controls.Add(Me.lblInfo)
        Me.pnlUserInfo.Controls.Add(Me.lbPhoneNum)
        Me.pnlUserInfo.Controls.Add(Me.lblName)
        Me.pnlUserInfo.Location = New System.Drawing.Point(304, 44)
        Me.pnlUserInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlUserInfo.Name = "pnlUserInfo"
        Me.pnlUserInfo.Size = New System.Drawing.Size(269, 288)
        Me.pnlUserInfo.TabIndex = 21
        '
        'pnlRoomInfo
        '
        Me.pnlRoomInfo.BackColor = System.Drawing.Color.Linen
        Me.pnlRoomInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRoomInfo.Controls.Add(Me.lblPayment)
        Me.pnlRoomInfo.Controls.Add(Me.lblActivities)
        Me.pnlRoomInfo.Controls.Add(Me.lblAccommodation)
        Me.pnlRoomInfo.Controls.Add(Me.lblDestination)
        Me.pnlRoomInfo.Controls.Add(Me.lblCheckOut)
        Me.pnlRoomInfo.Controls.Add(Me.lblRoomType)
        Me.pnlRoomInfo.Controls.Add(Me.lblChckIn)
        Me.pnlRoomInfo.Controls.Add(Me.lblHotelName)
        Me.pnlRoomInfo.Controls.Add(Me.lblRoomInfo)
        Me.pnlRoomInfo.Location = New System.Drawing.Point(-1, 102)
        Me.pnlRoomInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlRoomInfo.Name = "pnlRoomInfo"
        Me.pnlRoomInfo.Size = New System.Drawing.Size(269, 185)
        Me.pnlRoomInfo.TabIndex = 25
        '
        'lblPayment
        '
        Me.lblPayment.BackColor = System.Drawing.Color.Linen
        Me.lblPayment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckOut", True))
        Me.lblPayment.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(120, 141)
        Me.lblPayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(119, 21)
        Me.lblPayment.TabIndex = 32
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActivities
        '
        Me.lblActivities.BackColor = System.Drawing.Color.Linen
        Me.lblActivities.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckIn", True))
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
        Me.lblAccommodation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "RoomType", True))
        Me.lblAccommodation.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccommodation.Location = New System.Drawing.Point(120, 62)
        Me.lblAccommodation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccommodation.Name = "lblAccommodation"
        Me.lblAccommodation.Size = New System.Drawing.Size(119, 42)
        Me.lblAccommodation.TabIndex = 30
        Me.lblAccommodation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDestination
        '
        Me.lblDestination.BackColor = System.Drawing.Color.Linen
        Me.lblDestination.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "HotelName", True))
        Me.lblDestination.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(120, 42)
        Me.lblDestination.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(119, 21)
        Me.lblDestination.TabIndex = 26
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Location = New System.Drawing.Point(9, 143)
        Me.lblCheckOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(69, 15)
        Me.lblCheckOut.TabIndex = 29
        Me.lblCheckOut.Text = "Check Out :"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.BackColor = System.Drawing.Color.Linen
        Me.lblRoomType.Location = New System.Drawing.Point(9, 74)
        Me.lblRoomType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(74, 15)
        Me.lblRoomType.TabIndex = 28
        Me.lblRoomType.Text = "Room Type :"
        '
        'lblChckIn
        '
        Me.lblChckIn.AutoSize = True
        Me.lblChckIn.Location = New System.Drawing.Point(9, 107)
        Me.lblChckIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChckIn.Name = "lblChckIn"
        Me.lblChckIn.Size = New System.Drawing.Size(59, 15)
        Me.lblChckIn.TabIndex = 27
        Me.lblChckIn.Text = "Check In :"
        '
        'lblHotelName
        '
        Me.lblHotelName.AutoSize = True
        Me.lblHotelName.Location = New System.Drawing.Point(9, 42)
        Me.lblHotelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHotelName.Name = "lblHotelName"
        Me.lblHotelName.Size = New System.Drawing.Size(41, 15)
        Me.lblHotelName.TabIndex = 26
        Me.lblHotelName.Text = "Hotel :"
        '
        'lblRoomInfo
        '
        Me.lblRoomInfo.AutoSize = True
        Me.lblRoomInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomInfo.Location = New System.Drawing.Point(9, 7)
        Me.lblRoomInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoomInfo.Name = "lblRoomInfo"
        Me.lblRoomInfo.Size = New System.Drawing.Size(147, 15)
        Me.lblRoomInfo.TabIndex = 26
        Me.lblRoomInfo.Text = "ROOM INFORMATION"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Linen
        Me.lblPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Phone", True))
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
        Me.lblUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "FullName", True))
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
        Me.lbPhoneNum.BackColor = System.Drawing.Color.Linen
        Me.lbPhoneNum.Location = New System.Drawing.Point(9, 61)
        Me.lbPhoneNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPhoneNum.Name = "lbPhoneNum"
        Me.lbPhoneNum.Size = New System.Drawing.Size(93, 15)
        Me.lbPhoneNum.TabIndex = 21
        Me.lbPhoneNum.Text = "Phone Number :"
        '
        'BookingHotelTableAdapter
        '
        Me.BookingHotelTableAdapter.ClearBeforeFill = True
        '
        'Form2
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
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserInfo.ResumeLayout(False)
        Me.pnlUserInfo.PerformLayout()
        Me.pnlRoomInfo.ResumeLayout(False)
        Me.pnlRoomInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents grdUsers As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents pnlUserInfo As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents lbPhoneNum As Label
    Friend WithEvents pnlRoomInfo As Panel
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblActivities As Label
    Friend WithEvents lblAccommodation As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblChckIn As Label
    Friend WithEvents lblHotelName As Label
    Friend WithEvents lblRoomInfo As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotelNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BreakfastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents BookingHotelBindingSource As BindingSource
    Friend WithEvents BookingHotelTableAdapter As OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter
End Class
