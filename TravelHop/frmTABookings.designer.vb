<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTABookings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTABookings))
        Me.panelBackColor = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblTABooking = New System.Windows.Forms.Label()
        Me.lblIDHotel = New System.Windows.Forms.Label()
        Me.BookingHotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblTotalPriceHotel = New System.Windows.Forms.Label()
        Me.grbHotelBookings = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotelName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Breakfast = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblIDCar = New System.Windows.Forms.Label()
        Me.btnViewBooking = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.BookingHotelTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter()
        Me.lblIDresult = New System.Windows.Forms.Label()
        Me.AgencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgencyTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter()
        Me.panelBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbHotelBookings.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBackColor
        '
        Me.panelBackColor.BackColor = System.Drawing.Color.OldLace
        Me.panelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelBackColor.Controls.Add(Me.picLogo)
        Me.panelBackColor.Controls.Add(Me.lblTABooking)
        Me.panelBackColor.Location = New System.Drawing.Point(-8, -2)
        Me.panelBackColor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelBackColor.Name = "panelBackColor"
        Me.panelBackColor.Size = New System.Drawing.Size(1199, 99)
        Me.panelBackColor.TabIndex = 27
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(518, 21)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(70, 58)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'lblTABooking
        '
        Me.lblTABooking.AutoSize = True
        Me.lblTABooking.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTABooking.Location = New System.Drawing.Point(335, 36)
        Me.lblTABooking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTABooking.Name = "lblTABooking"
        Me.lblTABooking.Size = New System.Drawing.Size(114, 23)
        Me.lblTABooking.TabIndex = 0
        Me.lblTABooking.Text = "BOOKINGS"
        '
        'lblIDHotel
        '
        Me.lblIDHotel.AutoSize = True
        Me.lblIDHotel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "ID", True))
        Me.lblIDHotel.ForeColor = System.Drawing.SystemColors.Control
        Me.lblIDHotel.Location = New System.Drawing.Point(278, 440)
        Me.lblIDHotel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDHotel.Name = "lblIDHotel"
        Me.lblIDHotel.Size = New System.Drawing.Size(0, 15)
        Me.lblIDHotel.TabIndex = 30
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
        'lblTotalPriceHotel
        '
        Me.lblTotalPriceHotel.AutoSize = True
        Me.lblTotalPriceHotel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblTotalPriceHotel.Location = New System.Drawing.Point(328, 103)
        Me.lblTotalPriceHotel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPriceHotel.Name = "lblTotalPriceHotel"
        Me.lblTotalPriceHotel.Size = New System.Drawing.Size(0, 15)
        Me.lblTotalPriceHotel.TabIndex = 29
        '
        'grbHotelBookings
        '
        Me.grbHotelBookings.BackColor = System.Drawing.Color.LavenderBlush
        Me.grbHotelBookings.Controls.Add(Me.DataGridView1)
        Me.grbHotelBookings.Location = New System.Drawing.Point(10, 103)
        Me.grbHotelBookings.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbHotelBookings.Name = "grbHotelBookings"
        Me.grbHotelBookings.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbHotelBookings.Size = New System.Drawing.Size(846, 309)
        Me.grbHotelBookings.TabIndex = 28
        Me.grbHotelBookings.TabStop = False
        Me.grbHotelBookings.Text = "Hotel Bookings"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.HotelName, Me.CheckIn, Me.CheckOut, Me.RoomType, Me.Breakfast, Me.TotalPrice, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.Status})
        Me.DataGridView1.DataSource = Me.BookingHotelBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 27)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(846, 283)
        Me.DataGridView1.TabIndex = 0
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
        'HotelName
        '
        Me.HotelName.DataPropertyName = "HotelName"
        Me.HotelName.HeaderText = "HotelName"
        Me.HotelName.MinimumWidth = 8
        Me.HotelName.Name = "HotelName"
        Me.HotelName.Width = 150
        '
        'CheckIn
        '
        Me.CheckIn.DataPropertyName = "CheckIn"
        Me.CheckIn.HeaderText = "CheckIn"
        Me.CheckIn.MinimumWidth = 8
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Width = 150
        '
        'CheckOut
        '
        Me.CheckOut.DataPropertyName = "CheckOut"
        Me.CheckOut.HeaderText = "CheckOut"
        Me.CheckOut.MinimumWidth = 8
        Me.CheckOut.Name = "CheckOut"
        Me.CheckOut.Width = 150
        '
        'RoomType
        '
        Me.RoomType.DataPropertyName = "RoomType"
        Me.RoomType.HeaderText = "RoomType"
        Me.RoomType.MinimumWidth = 8
        Me.RoomType.Name = "RoomType"
        Me.RoomType.Width = 150
        '
        'Breakfast
        '
        Me.Breakfast.DataPropertyName = "Breakfast"
        Me.Breakfast.HeaderText = "Breakfast"
        Me.Breakfast.MinimumWidth = 8
        Me.Breakfast.Name = "Breakfast"
        Me.Breakfast.Width = 150
        '
        'TotalPrice
        '
        Me.TotalPrice.DataPropertyName = "TotalPrice"
        Me.TotalPrice.HeaderText = "TotalPrice"
        Me.TotalPrice.MinimumWidth = 8
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Width = 150
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
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 8
        Me.Status.Name = "Status"
        Me.Status.Width = 150
        '
        'lblIDCar
        '
        Me.lblIDCar.AutoSize = True
        Me.lblIDCar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblIDCar.Location = New System.Drawing.Point(440, 422)
        Me.lblIDCar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDCar.Name = "lblIDCar"
        Me.lblIDCar.Size = New System.Drawing.Size(0, 15)
        Me.lblIDCar.TabIndex = 32
        '
        'btnViewBooking
        '
        Me.btnViewBooking.BackColor = System.Drawing.Color.White
        Me.btnViewBooking.Enabled = False
        Me.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBooking.Location = New System.Drawing.Point(604, 422)
        Me.btnViewBooking.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnViewBooking.Name = "btnViewBooking"
        Me.btnViewBooking.Size = New System.Drawing.Size(176, 27)
        Me.btnViewBooking.TabIndex = 31
        Me.btnViewBooking.Text = "&VIEW BOOKING"
        Me.btnViewBooking.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(80, 422)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(176, 27)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'BookingHotelTableAdapter
        '
        Me.BookingHotelTableAdapter.ClearBeforeFill = True
        '
        'lblIDresult
        '
        Me.lblIDresult.AutoSize = True
        Me.lblIDresult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "ID", True))
        Me.lblIDresult.ForeColor = System.Drawing.SystemColors.Control
        Me.lblIDresult.Location = New System.Drawing.Point(281, 432)
        Me.lblIDresult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDresult.Name = "lblIDresult"
        Me.lblIDresult.Size = New System.Drawing.Size(0, 15)
        Me.lblIDresult.TabIndex = 36
        '
        'AgencyBindingSource
        '
        Me.AgencyBindingSource.DataMember = "Agency"
        Me.AgencyBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'AgencyTableAdapter
        '
        Me.AgencyTableAdapter.ClearBeforeFill = True
        '
        'frmTABookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 460)
        Me.Controls.Add(Me.lblIDresult)
        Me.Controls.Add(Me.panelBackColor)
        Me.Controls.Add(Me.lblIDHotel)
        Me.Controls.Add(Me.lblTotalPriceHotel)
        Me.Controls.Add(Me.grbHotelBookings)
        Me.Controls.Add(Me.lblIDCar)
        Me.Controls.Add(Me.btnViewBooking)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTABookings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agency - View Bookings"
        Me.panelBackColor.ResumeLayout(False)
        Me.panelBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbHotelBookings.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelBackColor As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTABooking As Label
    Friend WithEvents lblIDHotel As Label
    Friend WithEvents lblTotalPriceHotel As Label
    Friend WithEvents grbHotelBookings As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblIDCar As Label
    Friend WithEvents btnViewBooking As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents BookingHotelBindingSource As BindingSource
    Friend WithEvents BookingHotelTableAdapter As OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter
    Friend WithEvents lblIDresult As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotelName As DataGridViewTextBoxColumn
    Friend WithEvents CheckIn As DataGridViewTextBoxColumn
    Friend WithEvents CheckOut As DataGridViewTextBoxColumn
    Friend WithEvents RoomType As DataGridViewTextBoxColumn
    Friend WithEvents Breakfast As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AgencyBindingSource As BindingSource
    Friend WithEvents AgencyTableAdapter As OMC_TravelHopDataSetTableAdapters.AgencyTableAdapter
End Class
