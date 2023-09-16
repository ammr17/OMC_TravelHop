<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTAViewBookings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTAViewBookings))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblTABooking = New System.Windows.Forms.Label()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.lblTotalResult = New System.Windows.Forms.Label()
        Me.BookingHotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblBreakfastYesNo = New System.Windows.Forms.Label()
        Me.lblRoomTypeResult = New System.Windows.Forms.Label()
        Me.lblCheckOutResult = New System.Windows.Forms.Label()
        Me.lblCheckInResult = New System.Windows.Forms.Label()
        Me.lblHotelResult = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblBreakfast = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNameResult = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.BookingHotelTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusResult = New System.Windows.Forms.Label()
        Me.ToolTipApproval = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(254, 21)
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
        Me.lblTABooking.Location = New System.Drawing.Point(43, 37)
        Me.lblTABooking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTABooking.Name = "lblTABooking"
        Me.lblTABooking.Size = New System.Drawing.Size(168, 23)
        Me.lblTABooking.TabIndex = 0
        Me.lblTABooking.Text = "VIEW BOOKINGS"
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblTABooking)
        Me.pnlBackColor.Location = New System.Drawing.Point(-4, -2)
        Me.pnlBackColor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(367, 103)
        Me.pnlBackColor.TabIndex = 28
        '
        'lblTotalResult
        '
        Me.lblTotalResult.BackColor = System.Drawing.Color.White
        Me.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "TotalPrice", True))
        Me.lblTotalResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalResult.Location = New System.Drawing.Point(149, 327)
        Me.lblTotalResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(163, 20)
        Me.lblTotalResult.TabIndex = 41
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
        'lblBreakfastYesNo
        '
        Me.lblBreakfastYesNo.BackColor = System.Drawing.Color.White
        Me.lblBreakfastYesNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBreakfastYesNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Breakfast", True))
        Me.lblBreakfastYesNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakfastYesNo.Location = New System.Drawing.Point(149, 295)
        Me.lblBreakfastYesNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBreakfastYesNo.Name = "lblBreakfastYesNo"
        Me.lblBreakfastYesNo.Size = New System.Drawing.Size(163, 20)
        Me.lblBreakfastYesNo.TabIndex = 40
        '
        'lblRoomTypeResult
        '
        Me.lblRoomTypeResult.BackColor = System.Drawing.Color.White
        Me.lblRoomTypeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoomTypeResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "RoomType", True))
        Me.lblRoomTypeResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomTypeResult.Location = New System.Drawing.Point(149, 263)
        Me.lblRoomTypeResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoomTypeResult.Name = "lblRoomTypeResult"
        Me.lblRoomTypeResult.Size = New System.Drawing.Size(163, 20)
        Me.lblRoomTypeResult.TabIndex = 39
        '
        'lblCheckOutResult
        '
        Me.lblCheckOutResult.BackColor = System.Drawing.Color.White
        Me.lblCheckOutResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCheckOutResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckOut", True))
        Me.lblCheckOutResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOutResult.Location = New System.Drawing.Point(149, 230)
        Me.lblCheckOutResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckOutResult.Name = "lblCheckOutResult"
        Me.lblCheckOutResult.Size = New System.Drawing.Size(163, 20)
        Me.lblCheckOutResult.TabIndex = 38
        '
        'lblCheckInResult
        '
        Me.lblCheckInResult.BackColor = System.Drawing.Color.White
        Me.lblCheckInResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCheckInResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckIn", True))
        Me.lblCheckInResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckInResult.Location = New System.Drawing.Point(149, 194)
        Me.lblCheckInResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckInResult.Name = "lblCheckInResult"
        Me.lblCheckInResult.Size = New System.Drawing.Size(163, 20)
        Me.lblCheckInResult.TabIndex = 37
        '
        'lblHotelResult
        '
        Me.lblHotelResult.BackColor = System.Drawing.Color.White
        Me.lblHotelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHotelResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "HotelName", True))
        Me.lblHotelResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotelResult.Location = New System.Drawing.Point(149, 158)
        Me.lblHotelResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHotelResult.Name = "lblHotelResult"
        Me.lblHotelResult.Size = New System.Drawing.Size(163, 20)
        Me.lblHotelResult.TabIndex = 36
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(42, 328)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(83, 18)
        Me.lblPrice.TabIndex = 35
        Me.lblPrice.Text = "Total Price:"
        '
        'lblBreakfast
        '
        Me.lblBreakfast.AutoSize = True
        Me.lblBreakfast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakfast.Location = New System.Drawing.Point(42, 295)
        Me.lblBreakfast.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBreakfast.Name = "lblBreakfast"
        Me.lblBreakfast.Size = New System.Drawing.Size(75, 18)
        Me.lblBreakfast.TabIndex = 34
        Me.lblBreakfast.Text = "Breakfast:"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomType.Location = New System.Drawing.Point(42, 264)
        Me.lblRoomType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(90, 18)
        Me.lblRoomType.TabIndex = 33
        Me.lblRoomType.Text = "Room Type:"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOut.Location = New System.Drawing.Point(42, 231)
        Me.lblCheckOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(84, 18)
        Me.lblCheckOut.TabIndex = 32
        Me.lblCheckOut.Text = "Check-Out:"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIn.Location = New System.Drawing.Point(42, 195)
        Me.lblCheckIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(71, 18)
        Me.lblCheckIn.TabIndex = 31
        Me.lblCheckIn.Text = "Check-In:"
        '
        'lblHotel
        '
        Me.lblHotel.AutoSize = True
        Me.lblHotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotel.Location = New System.Drawing.Point(42, 158)
        Me.lblHotel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(47, 18)
        Me.lblHotel.TabIndex = 30
        Me.lblHotel.Text = "Hotel:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(42, 123)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 18)
        Me.lblName.TabIndex = 42
        Me.lblName.Text = "Name:"
        '
        'lblNameResult
        '
        Me.lblNameResult.BackColor = System.Drawing.Color.White
        Me.lblNameResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNameResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "FullName", True))
        Me.lblNameResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameResult.Location = New System.Drawing.Point(149, 122)
        Me.lblNameResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNameResult.Name = "lblNameResult"
        Me.lblNameResult.Size = New System.Drawing.Size(163, 20)
        Me.lblNameResult.TabIndex = 43
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(46, 434)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 24)
        Me.btnBack.TabIndex = 44
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'BookingHotelTableAdapter
        '
        Me.BookingHotelTableAdapter.ClearBeforeFill = True
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.White
        Me.btnApprove.Enabled = False
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Location = New System.Drawing.Point(231, 434)
        Me.btnApprove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(82, 24)
        Me.btnApprove.TabIndex = 45
        Me.btnApprove.Text = "&APPROVE"
        Me.ToolTipApproval.SetToolTip(Me.btnApprove, "Approve Booking")
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(43, 382)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(54, 18)
        Me.lblStatus.TabIndex = 46
        Me.lblStatus.Text = "Status:"
        '
        'lblStatusResult
        '
        Me.lblStatusResult.BackColor = System.Drawing.Color.White
        Me.lblStatusResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatusResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Status", True))
        Me.lblStatusResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusResult.Location = New System.Drawing.Point(149, 381)
        Me.lblStatusResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatusResult.Name = "lblStatusResult"
        Me.lblStatusResult.Size = New System.Drawing.Size(163, 20)
        Me.lblStatusResult.TabIndex = 47
        '
        'frmTAViewBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(360, 471)
        Me.Controls.Add(Me.lblStatusResult)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblNameResult)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTotalResult)
        Me.Controls.Add(Me.lblBreakfastYesNo)
        Me.Controls.Add(Me.lblRoomTypeResult)
        Me.Controls.Add(Me.lblCheckOutResult)
        Me.Controls.Add(Me.lblCheckInResult)
        Me.Controls.Add(Me.lblHotelResult)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblBreakfast)
        Me.Controls.Add(Me.lblRoomType)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.lblHotel)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTAViewBookings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agency - View Bookings"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTABooking As Label
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents lblTotalResult As Label
    Friend WithEvents lblBreakfastYesNo As Label
    Friend WithEvents lblRoomTypeResult As Label
    Friend WithEvents lblCheckOutResult As Label
    Friend WithEvents lblCheckInResult As Label
    Friend WithEvents lblHotelResult As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblBreakfast As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblHotel As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblNameResult As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents BookingHotelBindingSource As BindingSource
    Friend WithEvents BookingHotelTableAdapter As OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStatusResult As Label
    Friend WithEvents ToolTipApproval As ToolTip
End Class
