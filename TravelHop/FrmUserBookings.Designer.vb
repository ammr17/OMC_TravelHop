<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserBookings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserBookings))
        Me.panelCarTicket = New System.Windows.Forms.Panel()
        Me.btnFeedbackCar = New System.Windows.Forms.Button()
        Me.btnCloseCar = New System.Windows.Forms.Button()
        Me.lblNameCarResult = New System.Windows.Forms.Label()
        Me.RentalCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblPriceCarResult = New System.Windows.Forms.Label()
        Me.lblSeatsResult = New System.Windows.Forms.Label()
        Me.lblDropOffResult = New System.Windows.Forms.Label()
        Me.lblPickUpResult = New System.Windows.Forms.Label()
        Me.lblCarResult = New System.Windows.Forms.Label()
        Me.lblPriceCar = New System.Windows.Forms.Label()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.lblDropOff = New System.Windows.Forms.Label()
        Me.lblPickUp = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.picLogo3 = New System.Windows.Forms.PictureBox()
        Me.panelHotelTicket = New System.Windows.Forms.Panel()
        Me.btnFeedbackHotel = New System.Windows.Forms.Button()
        Me.btnCloseHotel = New System.Windows.Forms.Button()
        Me.lblNameHotelResult = New System.Windows.Forms.Label()
        Me.BookingHotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPriceHotelResult = New System.Windows.Forms.Label()
        Me.lblBreakfastResult = New System.Windows.Forms.Label()
        Me.lblRoomTypeResult = New System.Windows.Forms.Label()
        Me.lblCheckOutResult = New System.Windows.Forms.Label()
        Me.lblCheckInResult = New System.Windows.Forms.Label()
        Me.lblHotelResult = New System.Windows.Forms.Label()
        Me.lblPriceHotel = New System.Windows.Forms.Label()
        Me.lblBreakfast = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.picLogo2 = New System.Windows.Forms.PictureBox()
        Me.grbHotelBookings = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotelName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Breakfast = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbCarRentals = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PickUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DropOff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seats = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCancelBooking = New System.Windows.Forms.Button()
        Me.lblTotalPriceHotel = New System.Windows.Forms.Label()
        Me.lblTotalPriceCar = New System.Windows.Forms.Label()
        Me.btnViewBooking = New System.Windows.Forms.Button()
        Me.lblIDCar = New System.Windows.Forms.Label()
        Me.lblMyBookings = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.panelBackColor = New System.Windows.Forms.Panel()
        Me.BookingHotelTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter()
        Me.RentalCarTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter()
        Me.panelCarTicket.SuspendLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelHotelTicket.SuspendLayout()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbHotelBookings.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCarRentals.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBackColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCarTicket
        '
        Me.panelCarTicket.BackColor = System.Drawing.Color.LavenderBlush
        Me.panelCarTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelCarTicket.Controls.Add(Me.btnFeedbackCar)
        Me.panelCarTicket.Controls.Add(Me.btnCloseCar)
        Me.panelCarTicket.Controls.Add(Me.lblNameCarResult)
        Me.panelCarTicket.Controls.Add(Me.lblPriceCarResult)
        Me.panelCarTicket.Controls.Add(Me.lblSeatsResult)
        Me.panelCarTicket.Controls.Add(Me.lblDropOffResult)
        Me.panelCarTicket.Controls.Add(Me.lblPickUpResult)
        Me.panelCarTicket.Controls.Add(Me.lblCarResult)
        Me.panelCarTicket.Controls.Add(Me.lblPriceCar)
        Me.panelCarTicket.Controls.Add(Me.lblSeats)
        Me.panelCarTicket.Controls.Add(Me.lblDropOff)
        Me.panelCarTicket.Controls.Add(Me.lblPickUp)
        Me.panelCarTicket.Controls.Add(Me.lblCar)
        Me.panelCarTicket.Controls.Add(Me.picLogo3)
        Me.panelCarTicket.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelCarTicket.Location = New System.Drawing.Point(255, 79)
        Me.panelCarTicket.Name = "panelCarTicket"
        Me.panelCarTicket.Size = New System.Drawing.Size(304, 378)
        Me.panelCarTicket.TabIndex = 9
        Me.panelCarTicket.Visible = False
        '
        'btnFeedbackCar
        '
        Me.btnFeedbackCar.BackColor = System.Drawing.Color.Thistle
        Me.btnFeedbackCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedbackCar.Location = New System.Drawing.Point(184, 321)
        Me.btnFeedbackCar.Name = "btnFeedbackCar"
        Me.btnFeedbackCar.Size = New System.Drawing.Size(100, 23)
        Me.btnFeedbackCar.TabIndex = 18
        Me.btnFeedbackCar.Text = "FEEDBACK"
        Me.btnFeedbackCar.UseVisualStyleBackColor = False
        '
        'btnCloseCar
        '
        Me.btnCloseCar.BackColor = System.Drawing.Color.Thistle
        Me.btnCloseCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseCar.Location = New System.Drawing.Point(274, 9)
        Me.btnCloseCar.Name = "btnCloseCar"
        Me.btnCloseCar.Size = New System.Drawing.Size(21, 23)
        Me.btnCloseCar.TabIndex = 17
        Me.btnCloseCar.Text = "X"
        Me.btnCloseCar.UseVisualStyleBackColor = False
        '
        'lblNameCarResult
        '
        Me.lblNameCarResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "FullName", True))
        Me.lblNameCarResult.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameCarResult.Location = New System.Drawing.Point(70, 111)
        Me.lblNameCarResult.Name = "lblNameCarResult"
        Me.lblNameCarResult.Size = New System.Drawing.Size(172, 32)
        Me.lblNameCarResult.TabIndex = 16
        Me.lblNameCarResult.Text = "Label1"
        Me.lblNameCarResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'lblPriceCarResult
        '
        Me.lblPriceCarResult.BackColor = System.Drawing.Color.White
        Me.lblPriceCarResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceCarResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "TotalPrice", True))
        Me.lblPriceCarResult.Location = New System.Drawing.Point(134, 296)
        Me.lblPriceCarResult.Name = "lblPriceCarResult"
        Me.lblPriceCarResult.Size = New System.Drawing.Size(150, 20)
        Me.lblPriceCarResult.TabIndex = 14
        Me.lblPriceCarResult.Text = "Label1"
        '
        'lblSeatsResult
        '
        Me.lblSeatsResult.BackColor = System.Drawing.Color.White
        Me.lblSeatsResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeatsResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Seats", True))
        Me.lblSeatsResult.Location = New System.Drawing.Point(134, 264)
        Me.lblSeatsResult.Name = "lblSeatsResult"
        Me.lblSeatsResult.Size = New System.Drawing.Size(150, 20)
        Me.lblSeatsResult.TabIndex = 13
        Me.lblSeatsResult.Text = "Label1"
        '
        'lblDropOffResult
        '
        Me.lblDropOffResult.BackColor = System.Drawing.Color.White
        Me.lblDropOffResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDropOffResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "DropOff", True))
        Me.lblDropOffResult.Location = New System.Drawing.Point(134, 232)
        Me.lblDropOffResult.Name = "lblDropOffResult"
        Me.lblDropOffResult.Size = New System.Drawing.Size(150, 20)
        Me.lblDropOffResult.TabIndex = 12
        Me.lblDropOffResult.Text = "Label1"
        '
        'lblPickUpResult
        '
        Me.lblPickUpResult.BackColor = System.Drawing.Color.White
        Me.lblPickUpResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPickUpResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "PickUp", True))
        Me.lblPickUpResult.Location = New System.Drawing.Point(134, 201)
        Me.lblPickUpResult.Name = "lblPickUpResult"
        Me.lblPickUpResult.Size = New System.Drawing.Size(150, 20)
        Me.lblPickUpResult.TabIndex = 11
        Me.lblPickUpResult.Text = "Label1"
        '
        'lblCarResult
        '
        Me.lblCarResult.BackColor = System.Drawing.Color.White
        Me.lblCarResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "CarType", True))
        Me.lblCarResult.Location = New System.Drawing.Point(134, 167)
        Me.lblCarResult.Name = "lblCarResult"
        Me.lblCarResult.Size = New System.Drawing.Size(150, 20)
        Me.lblCarResult.TabIndex = 10
        Me.lblCarResult.Text = "Label1"
        '
        'lblPriceCar
        '
        Me.lblPriceCar.AutoSize = True
        Me.lblPriceCar.Location = New System.Drawing.Point(40, 296)
        Me.lblPriceCar.Name = "lblPriceCar"
        Me.lblPriceCar.Size = New System.Drawing.Size(117, 23)
        Me.lblPriceCar.TabIndex = 8
        Me.lblPriceCar.Text = "Total Price:"
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Location = New System.Drawing.Point(40, 264)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(66, 23)
        Me.lblSeats.TabIndex = 7
        Me.lblSeats.Text = "Seats:"
        '
        'lblDropOff
        '
        Me.lblDropOff.AutoSize = True
        Me.lblDropOff.Location = New System.Drawing.Point(40, 233)
        Me.lblDropOff.Name = "lblDropOff"
        Me.lblDropOff.Size = New System.Drawing.Size(106, 23)
        Me.lblDropOff.TabIndex = 6
        Me.lblDropOff.Text = "Drop-Off:"
        '
        'lblPickUp
        '
        Me.lblPickUp.AutoSize = True
        Me.lblPickUp.Location = New System.Drawing.Point(40, 202)
        Me.lblPickUp.Name = "lblPickUp"
        Me.lblPickUp.Size = New System.Drawing.Size(94, 23)
        Me.lblPickUp.TabIndex = 5
        Me.lblPickUp.Text = "Pick-Up:"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Location = New System.Drawing.Point(40, 168)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(49, 23)
        Me.lblCar.TabIndex = 4
        Me.lblCar.Text = "Car:"
        '
        'picLogo3
        '
        Me.picLogo3.Image = CType(resources.GetObject("picLogo3.Image"), System.Drawing.Image)
        Me.picLogo3.Location = New System.Drawing.Point(120, 33)
        Me.picLogo3.Name = "picLogo3"
        Me.picLogo3.Size = New System.Drawing.Size(72, 63)
        Me.picLogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo3.TabIndex = 3
        Me.picLogo3.TabStop = False
        '
        'panelHotelTicket
        '
        Me.panelHotelTicket.BackColor = System.Drawing.Color.LavenderBlush
        Me.panelHotelTicket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelHotelTicket.Controls.Add(Me.btnFeedbackHotel)
        Me.panelHotelTicket.Controls.Add(Me.btnCloseHotel)
        Me.panelHotelTicket.Controls.Add(Me.lblNameHotelResult)
        Me.panelHotelTicket.Controls.Add(Me.lblPriceHotelResult)
        Me.panelHotelTicket.Controls.Add(Me.lblBreakfastResult)
        Me.panelHotelTicket.Controls.Add(Me.lblRoomTypeResult)
        Me.panelHotelTicket.Controls.Add(Me.lblCheckOutResult)
        Me.panelHotelTicket.Controls.Add(Me.lblCheckInResult)
        Me.panelHotelTicket.Controls.Add(Me.lblHotelResult)
        Me.panelHotelTicket.Controls.Add(Me.lblTotalPriceCar)
        Me.panelHotelTicket.Controls.Add(Me.lblPriceHotel)
        Me.panelHotelTicket.Controls.Add(Me.lblBreakfast)
        Me.panelHotelTicket.Controls.Add(Me.lblRoomType)
        Me.panelHotelTicket.Controls.Add(Me.lblCheckOut)
        Me.panelHotelTicket.Controls.Add(Me.lblCheckIn)
        Me.panelHotelTicket.Controls.Add(Me.lblHotel)
        Me.panelHotelTicket.Controls.Add(Me.picLogo2)
        Me.panelHotelTicket.Controls.Add(Me.lblTotalPriceHotel)
        Me.panelHotelTicket.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelHotelTicket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.panelHotelTicket.Location = New System.Drawing.Point(255, 74)
        Me.panelHotelTicket.Name = "panelHotelTicket"
        Me.panelHotelTicket.Size = New System.Drawing.Size(304, 378)
        Me.panelHotelTicket.TabIndex = 1
        Me.panelHotelTicket.Visible = False
        '
        'btnFeedbackHotel
        '
        Me.btnFeedbackHotel.BackColor = System.Drawing.Color.Thistle
        Me.btnFeedbackHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedbackHotel.Location = New System.Drawing.Point(184, 348)
        Me.btnFeedbackHotel.Name = "btnFeedbackHotel"
        Me.btnFeedbackHotel.Size = New System.Drawing.Size(100, 23)
        Me.btnFeedbackHotel.TabIndex = 17
        Me.btnFeedbackHotel.Text = "FEEDBACK"
        Me.btnFeedbackHotel.UseVisualStyleBackColor = False
        '
        'btnCloseHotel
        '
        Me.btnCloseHotel.BackColor = System.Drawing.Color.Thistle
        Me.btnCloseHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseHotel.Location = New System.Drawing.Point(270, 7)
        Me.btnCloseHotel.Name = "btnCloseHotel"
        Me.btnCloseHotel.Size = New System.Drawing.Size(21, 23)
        Me.btnCloseHotel.TabIndex = 16
        Me.btnCloseHotel.Text = "X"
        Me.btnCloseHotel.UseVisualStyleBackColor = False
        '
        'lblNameHotelResult
        '
        Me.lblNameHotelResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "FullName", True))
        Me.lblNameHotelResult.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameHotelResult.Location = New System.Drawing.Point(63, 113)
        Me.lblNameHotelResult.Name = "lblNameHotelResult"
        Me.lblNameHotelResult.Size = New System.Drawing.Size(172, 36)
        Me.lblNameHotelResult.TabIndex = 15
        Me.lblNameHotelResult.Text = "Label1"
        Me.lblNameHotelResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BookingHotelBindingSource
        '
        Me.BookingHotelBindingSource.DataMember = "BookingHotel"
        Me.BookingHotelBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'lblPriceHotelResult
        '
        Me.lblPriceHotelResult.BackColor = System.Drawing.Color.White
        Me.lblPriceHotelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceHotelResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "TotalPrice", True))
        Me.lblPriceHotelResult.Location = New System.Drawing.Point(133, 324)
        Me.lblPriceHotelResult.Name = "lblPriceHotelResult"
        Me.lblPriceHotelResult.Size = New System.Drawing.Size(150, 20)
        Me.lblPriceHotelResult.TabIndex = 14
        Me.lblPriceHotelResult.Text = "Label1"
        '
        'lblBreakfastResult
        '
        Me.lblBreakfastResult.BackColor = System.Drawing.Color.White
        Me.lblBreakfastResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBreakfastResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Breakfast", True))
        Me.lblBreakfastResult.Location = New System.Drawing.Point(133, 294)
        Me.lblBreakfastResult.Name = "lblBreakfastResult"
        Me.lblBreakfastResult.Size = New System.Drawing.Size(150, 20)
        Me.lblBreakfastResult.TabIndex = 13
        Me.lblBreakfastResult.Text = "Label1"
        '
        'lblRoomTypeResult
        '
        Me.lblRoomTypeResult.BackColor = System.Drawing.Color.White
        Me.lblRoomTypeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoomTypeResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "RoomType", True))
        Me.lblRoomTypeResult.Location = New System.Drawing.Point(133, 262)
        Me.lblRoomTypeResult.Name = "lblRoomTypeResult"
        Me.lblRoomTypeResult.Size = New System.Drawing.Size(150, 20)
        Me.lblRoomTypeResult.TabIndex = 12
        Me.lblRoomTypeResult.Text = "Label1"
        '
        'lblCheckOutResult
        '
        Me.lblCheckOutResult.BackColor = System.Drawing.Color.White
        Me.lblCheckOutResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCheckOutResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckOut", True))
        Me.lblCheckOutResult.Location = New System.Drawing.Point(133, 230)
        Me.lblCheckOutResult.Name = "lblCheckOutResult"
        Me.lblCheckOutResult.Size = New System.Drawing.Size(150, 20)
        Me.lblCheckOutResult.TabIndex = 11
        Me.lblCheckOutResult.Text = "Label1"
        '
        'lblCheckInResult
        '
        Me.lblCheckInResult.BackColor = System.Drawing.Color.White
        Me.lblCheckInResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCheckInResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckIn", True))
        Me.lblCheckInResult.Location = New System.Drawing.Point(133, 199)
        Me.lblCheckInResult.Name = "lblCheckInResult"
        Me.lblCheckInResult.Size = New System.Drawing.Size(150, 20)
        Me.lblCheckInResult.TabIndex = 10
        Me.lblCheckInResult.Text = "Label1"
        '
        'lblHotelResult
        '
        Me.lblHotelResult.BackColor = System.Drawing.Color.White
        Me.lblHotelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHotelResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "HotelName", True))
        Me.lblHotelResult.Location = New System.Drawing.Point(133, 165)
        Me.lblHotelResult.Name = "lblHotelResult"
        Me.lblHotelResult.Size = New System.Drawing.Size(150, 20)
        Me.lblHotelResult.TabIndex = 9
        Me.lblHotelResult.Text = "Label1"
        '
        'lblPriceHotel
        '
        Me.lblPriceHotel.AutoSize = True
        Me.lblPriceHotel.Location = New System.Drawing.Point(30, 324)
        Me.lblPriceHotel.Name = "lblPriceHotel"
        Me.lblPriceHotel.Size = New System.Drawing.Size(117, 23)
        Me.lblPriceHotel.TabIndex = 8
        Me.lblPriceHotel.Text = "Total Price:"
        '
        'lblBreakfast
        '
        Me.lblBreakfast.AutoSize = True
        Me.lblBreakfast.Location = New System.Drawing.Point(30, 294)
        Me.lblBreakfast.Name = "lblBreakfast"
        Me.lblBreakfast.Size = New System.Drawing.Size(105, 23)
        Me.lblBreakfast.TabIndex = 7
        Me.lblBreakfast.Text = "Breakfast:"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Location = New System.Drawing.Point(30, 262)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(125, 23)
        Me.lblRoomType.TabIndex = 6
        Me.lblRoomType.Text = "Room Type:"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Location = New System.Drawing.Point(30, 231)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(122, 23)
        Me.lblCheckOut.TabIndex = 5
        Me.lblCheckOut.Text = "Check-Out:"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Location = New System.Drawing.Point(30, 200)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(105, 23)
        Me.lblCheckIn.TabIndex = 4
        Me.lblCheckIn.Text = "Check-In:"
        '
        'lblHotel
        '
        Me.lblHotel.AutoSize = True
        Me.lblHotel.Location = New System.Drawing.Point(30, 166)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(67, 23)
        Me.lblHotel.TabIndex = 3
        Me.lblHotel.Text = "Hotel:"
        '
        'picLogo2
        '
        Me.picLogo2.Image = CType(resources.GetObject("picLogo2.Image"), System.Drawing.Image)
        Me.picLogo2.Location = New System.Drawing.Point(110, 31)
        Me.picLogo2.Name = "picLogo2"
        Me.picLogo2.Size = New System.Drawing.Size(72, 63)
        Me.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo2.TabIndex = 2
        Me.picLogo2.TabStop = False
        '
        'grbHotelBookings
        '
        Me.grbHotelBookings.BackColor = System.Drawing.Color.LavenderBlush
        Me.grbHotelBookings.Controls.Add(Me.DataGridView1)
        Me.grbHotelBookings.Location = New System.Drawing.Point(44, 104)
        Me.grbHotelBookings.Name = "grbHotelBookings"
        Me.grbHotelBookings.Size = New System.Drawing.Size(327, 268)
        Me.grbHotelBookings.TabIndex = 2
        Me.grbHotelBookings.TabStop = False
        Me.grbHotelBookings.Text = "Hotel Bookings"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.HotelName, Me.CheckIn, Me.CheckOut, Me.RoomType, Me.Breakfast, Me.TotalPrice, Me.Status})
        Me.DataGridView1.DataSource = Me.BookingHotelBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(327, 245)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.Visible = False
        Me.IDDataGridViewTextBoxColumn1.Width = 150
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
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 8
        Me.Status.Name = "Status"
        Me.Status.Width = 150
        '
        'grbCarRentals
        '
        Me.grbCarRentals.BackColor = System.Drawing.Color.LavenderBlush
        Me.grbCarRentals.Controls.Add(Me.DataGridView2)
        Me.grbCarRentals.Location = New System.Drawing.Point(437, 104)
        Me.grbCarRentals.Name = "grbCarRentals"
        Me.grbCarRentals.Size = New System.Drawing.Size(327, 268)
        Me.grbCarRentals.TabIndex = 0
        Me.grbCarRentals.TabStop = False
        Me.grbCarRentals.Text = "Car Rentals"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CarType, Me.PickUp, Me.DropOff, Me.Seats, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.DataSource = Me.RentalCarBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(0, 23)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.Size = New System.Drawing.Size(327, 245)
        Me.DataGridView2.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'CarType
        '
        Me.CarType.DataPropertyName = "CarType"
        Me.CarType.HeaderText = "CarType"
        Me.CarType.MinimumWidth = 8
        Me.CarType.Name = "CarType"
        Me.CarType.Width = 150
        '
        'PickUp
        '
        Me.PickUp.DataPropertyName = "PickUp"
        Me.PickUp.HeaderText = "PickUp"
        Me.PickUp.MinimumWidth = 8
        Me.PickUp.Name = "PickUp"
        Me.PickUp.Width = 150
        '
        'DropOff
        '
        Me.DropOff.DataPropertyName = "DropOff"
        Me.DropOff.HeaderText = "DropOff"
        Me.DropOff.MinimumWidth = 8
        Me.DropOff.Name = "DropOff"
        Me.DropOff.Width = 150
        '
        'Seats
        '
        Me.Seats.DataPropertyName = "Seats"
        Me.Seats.HeaderText = "Seats"
        Me.Seats.MinimumWidth = 8
        Me.Seats.Name = "Seats"
        Me.Seats.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TotalPrice"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(113, 414)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(151, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCancelBooking
        '
        Me.btnCancelBooking.BackColor = System.Drawing.Color.White
        Me.btnCancelBooking.Enabled = False
        Me.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelBooking.Location = New System.Drawing.Point(532, 424)
        Me.btnCancelBooking.Name = "btnCancelBooking"
        Me.btnCancelBooking.Size = New System.Drawing.Size(151, 23)
        Me.btnCancelBooking.TabIndex = 3
        Me.btnCancelBooking.Text = "&CANCEL BOOKING"
        Me.btnCancelBooking.UseVisualStyleBackColor = False
        '
        'lblTotalPriceHotel
        '
        Me.lblTotalPriceHotel.AutoSize = True
        Me.lblTotalPriceHotel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "TotalPrice", True))
        Me.lblTotalPriceHotel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblTotalPriceHotel.Location = New System.Drawing.Point(30, 81)
        Me.lblTotalPriceHotel.Name = "lblTotalPriceHotel"
        Me.lblTotalPriceHotel.Size = New System.Drawing.Size(0, 23)
        Me.lblTotalPriceHotel.TabIndex = 4
        '
        'lblTotalPriceCar
        '
        Me.lblTotalPriceCar.AutoSize = True
        Me.lblTotalPriceCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "TotalPrice", True))
        Me.lblTotalPriceCar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblTotalPriceCar.Location = New System.Drawing.Point(283, 129)
        Me.lblTotalPriceCar.Name = "lblTotalPriceCar"
        Me.lblTotalPriceCar.Size = New System.Drawing.Size(0, 23)
        Me.lblTotalPriceCar.TabIndex = 5
        '
        'btnViewBooking
        '
        Me.btnViewBooking.BackColor = System.Drawing.Color.White
        Me.btnViewBooking.Enabled = False
        Me.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBooking.Location = New System.Drawing.Point(531, 393)
        Me.btnViewBooking.Name = "btnViewBooking"
        Me.btnViewBooking.Size = New System.Drawing.Size(151, 23)
        Me.btnViewBooking.TabIndex = 6
        Me.btnViewBooking.Text = "&VIEW BOOKING"
        Me.btnViewBooking.UseVisualStyleBackColor = False
        '
        'lblIDCar
        '
        Me.lblIDCar.AutoSize = True
        Me.lblIDCar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblIDCar.Location = New System.Drawing.Point(682, 393)
        Me.lblIDCar.Name = "lblIDCar"
        Me.lblIDCar.Size = New System.Drawing.Size(0, 20)
        Me.lblIDCar.TabIndex = 8
        '
        'lblMyBookings
        '
        Me.lblMyBookings.AutoSize = True
        Me.lblMyBookings.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyBookings.Location = New System.Drawing.Point(293, 28)
        Me.lblMyBookings.Name = "lblMyBookings"
        Me.lblMyBookings.Size = New System.Drawing.Size(226, 35)
        Me.lblMyBookings.TabIndex = 0
        Me.lblMyBookings.Text = "MY BOOKINGS"
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(450, 15)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'panelBackColor
        '
        Me.panelBackColor.BackColor = System.Drawing.Color.OldLace
        Me.panelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelBackColor.Controls.Add(Me.picLogo)
        Me.panelBackColor.Controls.Add(Me.lblMyBookings)
        Me.panelBackColor.Location = New System.Drawing.Point(-3, -5)
        Me.panelBackColor.Name = "panelBackColor"
        Me.panelBackColor.Size = New System.Drawing.Size(809, 78)
        Me.panelBackColor.TabIndex = 1
        '
        'BookingHotelTableAdapter
        '
        Me.BookingHotelTableAdapter.ClearBeforeFill = True
        '
        'RentalCarTableAdapter
        '
        Me.RentalCarTableAdapter.ClearBeforeFill = True
        '
        'FrmUserBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.panelHotelTicket)
        Me.Controls.Add(Me.panelCarTicket)
        Me.Controls.Add(Me.lblIDCar)
        Me.Controls.Add(Me.btnViewBooking)
        Me.Controls.Add(Me.btnCancelBooking)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grbCarRentals)
        Me.Controls.Add(Me.grbHotelBookings)
        Me.Controls.Add(Me.panelBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserBookings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - My Bookings"
        Me.panelCarTicket.ResumeLayout(False)
        Me.panelCarTicket.PerformLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelHotelTicket.ResumeLayout(False)
        Me.panelHotelTicket.PerformLayout()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbHotelBookings.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCarRentals.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBackColor.ResumeLayout(False)
        Me.panelBackColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbHotelBookings As GroupBox
    Friend WithEvents grbCarRentals As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCancelBooking As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents lblTotalPriceHotel As Label
    Friend WithEvents lblTotalPriceCar As Label
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HotelName As DataGridViewTextBoxColumn
    Friend WithEvents CheckIn As DataGridViewTextBoxColumn
    Friend WithEvents CheckOut As DataGridViewTextBoxColumn
    Friend WithEvents RoomType As DataGridViewTextBoxColumn
    Friend WithEvents Breakfast As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarType As DataGridViewTextBoxColumn
    Friend WithEvents PickUp As DataGridViewTextBoxColumn
    Friend WithEvents DropOff As DataGridViewTextBoxColumn
    Friend WithEvents Seats As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnViewBooking As Button
    Friend WithEvents lblIDCar As Label
    Friend WithEvents panelCarTicket As Panel
    Friend WithEvents lblPriceCarResult As Label
    Friend WithEvents lblSeatsResult As Label
    Friend WithEvents lblDropOffResult As Label
    Friend WithEvents lblPickUpResult As Label
    Friend WithEvents lblCarResult As Label
    Friend WithEvents lblPriceCar As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblDropOff As Label
    Friend WithEvents lblPickUp As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents picLogo3 As PictureBox
    Friend WithEvents btnCloseCar As Button
    Friend WithEvents lblNameCarResult As Label
    Friend WithEvents lblMyBookings As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents panelHotelTicket As Panel
    Friend WithEvents btnCloseHotel As Button
    Friend WithEvents lblNameHotelResult As Label
    Friend WithEvents lblPriceHotelResult As Label
    Friend WithEvents lblBreakfastResult As Label
    Friend WithEvents lblRoomTypeResult As Label
    Friend WithEvents lblCheckOutResult As Label
    Friend WithEvents lblCheckInResult As Label
    Friend WithEvents lblHotelResult As Label
    Friend WithEvents lblPriceHotel As Label
    Friend WithEvents lblBreakfast As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblHotel As Label
    Friend WithEvents picLogo2 As PictureBox
    Friend WithEvents panelBackColor As Panel
    Friend WithEvents btnFeedbackHotel As Button
    Friend WithEvents btnFeedbackCar As Button
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents BookingHotelBindingSource As BindingSource
    Friend WithEvents BookingHotelTableAdapter As OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter
    Friend WithEvents RentalCarBindingSource As BindingSource
    Friend WithEvents RentalCarTableAdapter As OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter
End Class
