<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPaymentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaymentDetails))
        Me.grbHotelSummary = New System.Windows.Forms.GroupBox()
        Me.lblBreakfastLabel = New System.Windows.Forms.Label()
        Me.lblRoomTypeLabel = New System.Windows.Forms.Label()
        Me.lblCheckOutLabel = New System.Windows.Forms.Label()
        Me.lblCheckInLabel = New System.Windows.Forms.Label()
        Me.lblHotelLabel = New System.Windows.Forms.Label()
        Me.lblBreakfast = New System.Windows.Forms.Label()
        Me.BookingHotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.grbCarSummary = New System.Windows.Forms.GroupBox()
        Me.lblPriceLabel = New System.Windows.Forms.Label()
        Me.lblSeatsLabel = New System.Windows.Forms.Label()
        Me.lblDropOffLabel = New System.Windows.Forms.Label()
        Me.lblPickUpLabel = New System.Windows.Forms.Label()
        Me.lblCarTypeLabel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.RentalCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDropOff = New System.Windows.Forms.Label()
        Me.lblPickUp = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grbCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.rbtAnotherPerson = New System.Windows.Forms.RadioButton()
        Me.rbtIAmGuest = New System.Windows.Forms.RadioButton()
        Me.mskPhoneNum = New System.Windows.Forms.MaskedTextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalResultCar = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUsernameCar = New System.Windows.Forms.Label()
        Me.lblUsernameHotel = New System.Windows.Forms.Label()
        Me.lblStatusCar = New System.Windows.Forms.Label()
        Me.lblStatusHotel = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.grbGuestName = New System.Windows.Forms.GroupBox()
        Me.lblTotalResultHotel = New System.Windows.Forms.Label()
        Me.lblNameCarResult = New System.Windows.Forms.Label()
        Me.lblHotelNameResult = New System.Windows.Forms.Label()
        Me.lblEmailCarResult = New System.Windows.Forms.Label()
        Me.lblEmailHotelResult = New System.Windows.Forms.Label()
        Me.lblPhoneHotelResult = New System.Windows.Forms.Label()
        Me.lblPhoneCarResult = New System.Windows.Forms.Label()
        Me.RentalCarTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter()
        Me.BookingHotelTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter()
        Me.CustomerTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter()
        Me.ToolTipGuest = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbHotelSummary.SuspendLayout()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCarSummary.SuspendLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCustomerDetails.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbGuestName.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbHotelSummary
        '
        Me.grbHotelSummary.BackColor = System.Drawing.Color.OldLace
        Me.grbHotelSummary.Controls.Add(Me.lblBreakfastLabel)
        Me.grbHotelSummary.Controls.Add(Me.lblRoomTypeLabel)
        Me.grbHotelSummary.Controls.Add(Me.lblCheckOutLabel)
        Me.grbHotelSummary.Controls.Add(Me.lblCheckInLabel)
        Me.grbHotelSummary.Controls.Add(Me.lblHotelLabel)
        Me.grbHotelSummary.Controls.Add(Me.lblBreakfast)
        Me.grbHotelSummary.Controls.Add(Me.lblRoomType)
        Me.grbHotelSummary.Controls.Add(Me.lblCheckOut)
        Me.grbHotelSummary.Controls.Add(Me.lblCheckIn)
        Me.grbHotelSummary.Controls.Add(Me.lblHotel)
        Me.grbHotelSummary.Location = New System.Drawing.Point(31, 95)
        Me.grbHotelSummary.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbHotelSummary.Name = "grbHotelSummary"
        Me.grbHotelSummary.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbHotelSummary.Size = New System.Drawing.Size(152, 334)
        Me.grbHotelSummary.TabIndex = 0
        Me.grbHotelSummary.TabStop = False
        Me.grbHotelSummary.Text = "Your Booking Summary"
        Me.grbHotelSummary.Visible = False
        '
        'lblBreakfastLabel
        '
        Me.lblBreakfastLabel.BackColor = System.Drawing.Color.White
        Me.lblBreakfastLabel.Location = New System.Drawing.Point(9, 273)
        Me.lblBreakfastLabel.Name = "lblBreakfastLabel"
        Me.lblBreakfastLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblBreakfastLabel.TabIndex = 12
        Me.lblBreakfastLabel.Text = "Breakfast:"
        '
        'lblRoomTypeLabel
        '
        Me.lblRoomTypeLabel.BackColor = System.Drawing.Color.White
        Me.lblRoomTypeLabel.Location = New System.Drawing.Point(8, 208)
        Me.lblRoomTypeLabel.Name = "lblRoomTypeLabel"
        Me.lblRoomTypeLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblRoomTypeLabel.TabIndex = 12
        Me.lblRoomTypeLabel.Text = "Room Type:"
        '
        'lblCheckOutLabel
        '
        Me.lblCheckOutLabel.BackColor = System.Drawing.Color.White
        Me.lblCheckOutLabel.Location = New System.Drawing.Point(9, 146)
        Me.lblCheckOutLabel.Name = "lblCheckOutLabel"
        Me.lblCheckOutLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblCheckOutLabel.TabIndex = 12
        Me.lblCheckOutLabel.Text = "Check-Out:"
        '
        'lblCheckInLabel
        '
        Me.lblCheckInLabel.BackColor = System.Drawing.Color.White
        Me.lblCheckInLabel.Location = New System.Drawing.Point(9, 85)
        Me.lblCheckInLabel.Name = "lblCheckInLabel"
        Me.lblCheckInLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblCheckInLabel.TabIndex = 12
        Me.lblCheckInLabel.Text = "Check-In:"
        '
        'lblHotelLabel
        '
        Me.lblHotelLabel.BackColor = System.Drawing.Color.White
        Me.lblHotelLabel.Location = New System.Drawing.Point(8, 24)
        Me.lblHotelLabel.Name = "lblHotelLabel"
        Me.lblHotelLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblHotelLabel.TabIndex = 12
        Me.lblHotelLabel.Text = "Hotel:"
        '
        'lblBreakfast
        '
        Me.lblBreakfast.BackColor = System.Drawing.Color.White
        Me.lblBreakfast.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Breakfast", True))
        Me.lblBreakfast.Location = New System.Drawing.Point(7, 288)
        Me.lblBreakfast.Name = "lblBreakfast"
        Me.lblBreakfast.Size = New System.Drawing.Size(134, 34)
        Me.lblBreakfast.TabIndex = 4
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
        'lblRoomType
        '
        Me.lblRoomType.BackColor = System.Drawing.Color.White
        Me.lblRoomType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "RoomType", True))
        Me.lblRoomType.Location = New System.Drawing.Point(7, 225)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(134, 34)
        Me.lblRoomType.TabIndex = 3
        '
        'lblCheckOut
        '
        Me.lblCheckOut.BackColor = System.Drawing.Color.White
        Me.lblCheckOut.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckOut", True))
        Me.lblCheckOut.Location = New System.Drawing.Point(7, 163)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(134, 34)
        Me.lblCheckOut.TabIndex = 2
        '
        'lblCheckIn
        '
        Me.lblCheckIn.BackColor = System.Drawing.Color.White
        Me.lblCheckIn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "CheckIn", True))
        Me.lblCheckIn.Location = New System.Drawing.Point(8, 102)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(134, 34)
        Me.lblCheckIn.TabIndex = 1
        '
        'lblHotel
        '
        Me.lblHotel.BackColor = System.Drawing.Color.White
        Me.lblHotel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "HotelName", True))
        Me.lblHotel.Location = New System.Drawing.Point(8, 41)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(134, 34)
        Me.lblHotel.TabIndex = 0
        '
        'grbCarSummary
        '
        Me.grbCarSummary.BackColor = System.Drawing.Color.OldLace
        Me.grbCarSummary.Controls.Add(Me.lblPriceLabel)
        Me.grbCarSummary.Controls.Add(Me.lblSeatsLabel)
        Me.grbCarSummary.Controls.Add(Me.lblDropOffLabel)
        Me.grbCarSummary.Controls.Add(Me.lblPickUpLabel)
        Me.grbCarSummary.Controls.Add(Me.lblCarTypeLabel)
        Me.grbCarSummary.Controls.Add(Me.lblPrice)
        Me.grbCarSummary.Controls.Add(Me.lblSeats)
        Me.grbCarSummary.Controls.Add(Me.lblDropOff)
        Me.grbCarSummary.Controls.Add(Me.lblPickUp)
        Me.grbCarSummary.Controls.Add(Me.lblCarType)
        Me.grbCarSummary.Location = New System.Drawing.Point(31, 99)
        Me.grbCarSummary.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbCarSummary.Name = "grbCarSummary"
        Me.grbCarSummary.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbCarSummary.Size = New System.Drawing.Size(152, 334)
        Me.grbCarSummary.TabIndex = 10
        Me.grbCarSummary.TabStop = False
        Me.grbCarSummary.Text = "Your Booking Summary"
        Me.grbCarSummary.Visible = False
        '
        'lblPriceLabel
        '
        Me.lblPriceLabel.BackColor = System.Drawing.Color.White
        Me.lblPriceLabel.Location = New System.Drawing.Point(7, 271)
        Me.lblPriceLabel.Name = "lblPriceLabel"
        Me.lblPriceLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblPriceLabel.TabIndex = 12
        Me.lblPriceLabel.Text = "Price:"
        '
        'lblSeatsLabel
        '
        Me.lblSeatsLabel.BackColor = System.Drawing.Color.White
        Me.lblSeatsLabel.Location = New System.Drawing.Point(8, 208)
        Me.lblSeatsLabel.Name = "lblSeatsLabel"
        Me.lblSeatsLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblSeatsLabel.TabIndex = 12
        Me.lblSeatsLabel.Text = "Seats:"
        '
        'lblDropOffLabel
        '
        Me.lblDropOffLabel.BackColor = System.Drawing.Color.White
        Me.lblDropOffLabel.Location = New System.Drawing.Point(8, 146)
        Me.lblDropOffLabel.Name = "lblDropOffLabel"
        Me.lblDropOffLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblDropOffLabel.TabIndex = 12
        Me.lblDropOffLabel.Text = "Drop-Off:"
        '
        'lblPickUpLabel
        '
        Me.lblPickUpLabel.BackColor = System.Drawing.Color.White
        Me.lblPickUpLabel.Location = New System.Drawing.Point(8, 85)
        Me.lblPickUpLabel.Name = "lblPickUpLabel"
        Me.lblPickUpLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblPickUpLabel.TabIndex = 12
        Me.lblPickUpLabel.Text = "Pick-Up:"
        '
        'lblCarTypeLabel
        '
        Me.lblCarTypeLabel.BackColor = System.Drawing.Color.White
        Me.lblCarTypeLabel.Location = New System.Drawing.Point(8, 24)
        Me.lblCarTypeLabel.Name = "lblCarTypeLabel"
        Me.lblCarTypeLabel.Size = New System.Drawing.Size(133, 17)
        Me.lblCarTypeLabel.TabIndex = 11
        Me.lblCarTypeLabel.Text = "Car Type:"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Enabled = False
        Me.lblPrice.Location = New System.Drawing.Point(7, 288)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(134, 34)
        Me.lblPrice.TabIndex = 4
        '
        'lblSeats
        '
        Me.lblSeats.BackColor = System.Drawing.Color.White
        Me.lblSeats.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Seats", True))
        Me.lblSeats.Enabled = False
        Me.lblSeats.Location = New System.Drawing.Point(7, 225)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(134, 34)
        Me.lblSeats.TabIndex = 3
        '
        'RentalCarBindingSource
        '
        Me.RentalCarBindingSource.DataMember = "RentalCar"
        Me.RentalCarBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'lblDropOff
        '
        Me.lblDropOff.BackColor = System.Drawing.Color.White
        Me.lblDropOff.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "DropOff", True))
        Me.lblDropOff.Enabled = False
        Me.lblDropOff.Location = New System.Drawing.Point(7, 163)
        Me.lblDropOff.Name = "lblDropOff"
        Me.lblDropOff.Size = New System.Drawing.Size(134, 34)
        Me.lblDropOff.TabIndex = 2
        '
        'lblPickUp
        '
        Me.lblPickUp.BackColor = System.Drawing.Color.White
        Me.lblPickUp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "PickUp", True))
        Me.lblPickUp.Enabled = False
        Me.lblPickUp.Location = New System.Drawing.Point(8, 102)
        Me.lblPickUp.Name = "lblPickUp"
        Me.lblPickUp.Size = New System.Drawing.Size(134, 34)
        Me.lblPickUp.TabIndex = 1
        '
        'lblCarType
        '
        Me.lblCarType.BackColor = System.Drawing.Color.White
        Me.lblCarType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "CarType", True))
        Me.lblCarType.Enabled = False
        Me.lblCarType.Location = New System.Drawing.Point(8, 41)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(134, 34)
        Me.lblCarType.TabIndex = 0
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(325, 33)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(156, 35)
        Me.lblPayment.TabIndex = 1
        Me.lblPayment.Text = "PAYMENT"
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblPayment)
        Me.pnlBackColor.Location = New System.Drawing.Point(-8, -9)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(811, 83)
        Me.pnlBackColor.TabIndex = 2
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(436, 19)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'grbCustomerDetails
        '
        Me.grbCustomerDetails.BackColor = System.Drawing.Color.OldLace
        Me.grbCustomerDetails.Controls.Add(Me.rbtAnotherPerson)
        Me.grbCustomerDetails.Controls.Add(Me.rbtIAmGuest)
        Me.grbCustomerDetails.Controls.Add(Me.mskPhoneNum)
        Me.grbCustomerDetails.Controls.Add(Me.txtEmail)
        Me.grbCustomerDetails.Controls.Add(Me.lblEmail)
        Me.grbCustomerDetails.Controls.Add(Me.lblPhoneNumber)
        Me.grbCustomerDetails.Controls.Add(Me.txtName)
        Me.grbCustomerDetails.Controls.Add(Me.lblName)
        Me.grbCustomerDetails.Controls.Add(Me.lblStatusHotel)
        Me.grbCustomerDetails.Controls.Add(Me.lblStatusCar)
        Me.grbCustomerDetails.Location = New System.Drawing.Point(227, 95)
        Me.grbCustomerDetails.Name = "grbCustomerDetails"
        Me.grbCustomerDetails.Size = New System.Drawing.Size(374, 242)
        Me.grbCustomerDetails.TabIndex = 3
        Me.grbCustomerDetails.TabStop = False
        Me.grbCustomerDetails.Text = "Your Details"
        '
        'rbtAnotherPerson
        '
        Me.rbtAnotherPerson.AutoSize = True
        Me.rbtAnotherPerson.Location = New System.Drawing.Point(152, 34)
        Me.rbtAnotherPerson.Name = "rbtAnotherPerson"
        Me.rbtAnotherPerson.Size = New System.Drawing.Size(305, 25)
        Me.rbtAnotherPerson.TabIndex = 5
        Me.rbtAnotherPerson.TabStop = True
        Me.rbtAnotherPerson.Text = "I am booking for another person"
        Me.ToolTipGuest.SetToolTip(Me.rbtAnotherPerson, "Enter Guest's Details")
        Me.rbtAnotherPerson.UseVisualStyleBackColor = True
        '
        'rbtIAmGuest
        '
        Me.rbtIAmGuest.AutoSize = True
        Me.rbtIAmGuest.Location = New System.Drawing.Point(36, 34)
        Me.rbtIAmGuest.Name = "rbtIAmGuest"
        Me.rbtIAmGuest.Size = New System.Drawing.Size(152, 25)
        Me.rbtIAmGuest.TabIndex = 4
        Me.rbtIAmGuest.TabStop = True
        Me.rbtIAmGuest.Text = "I am the guest"
        Me.rbtIAmGuest.UseVisualStyleBackColor = True
        '
        'mskPhoneNum
        '
        Me.mskPhoneNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.mskPhoneNum.Enabled = False
        Me.mskPhoneNum.Location = New System.Drawing.Point(10, 146)
        Me.mskPhoneNum.Mask = "+6###-#######"
        Me.mskPhoneNum.Name = "mskPhoneNum"
        Me.mskPhoneNum.Size = New System.Drawing.Size(358, 33)
        Me.mskPhoneNum.TabIndex = 2
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(10, 207)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(358, 33)
        Me.txtEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(7, 188)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(55, 21)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(7, 127)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(132, 21)
        Me.lblPhoneNumber.TabIndex = 2
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FullName", True))
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(10, 85)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(358, 33)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 66)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(316, 413)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 21)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "TOTAL :"
        '
        'lblTotalResultCar
        '
        Me.lblTotalResultCar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblTotalResultCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalResultCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "TotalPrice", True))
        Me.lblTotalResultCar.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalResultCar.Location = New System.Drawing.Point(379, 407)
        Me.lblTotalResultCar.Name = "lblTotalResultCar"
        Me.lblTotalResultCar.Size = New System.Drawing.Size(117, 26)
        Me.lblTotalResultCar.TabIndex = 7
        Me.lblTotalResultCar.Visible = False
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.White
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Location = New System.Drawing.Point(626, 362)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(151, 23)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "&PAY"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(626, 410)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblUsernameCar
        '
        Me.lblUsernameCar.AutoSize = True
        Me.lblUsernameCar.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblUsernameCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "UserName", True))
        Me.lblUsernameCar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblUsernameCar.Location = New System.Drawing.Point(653, 129)
        Me.lblUsernameCar.Name = "lblUsernameCar"
        Me.lblUsernameCar.Size = New System.Drawing.Size(0, 21)
        Me.lblUsernameCar.TabIndex = 11
        '
        'lblUsernameHotel
        '
        Me.lblUsernameHotel.AutoSize = True
        Me.lblUsernameHotel.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblUsernameHotel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "UserName", True))
        Me.lblUsernameHotel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblUsernameHotel.Location = New System.Drawing.Point(653, 161)
        Me.lblUsernameHotel.Name = "lblUsernameHotel"
        Me.lblUsernameHotel.Size = New System.Drawing.Size(0, 21)
        Me.lblUsernameHotel.TabIndex = 12
        '
        'lblStatusCar
        '
        Me.lblStatusCar.AutoSize = True
        Me.lblStatusCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Status", True))
        Me.lblStatusCar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblStatusCar.Location = New System.Drawing.Point(350, 122)
        Me.lblStatusCar.Name = "lblStatusCar"
        Me.lblStatusCar.Size = New System.Drawing.Size(0, 21)
        Me.lblStatusCar.TabIndex = 13
        '
        'lblStatusHotel
        '
        Me.lblStatusHotel.AutoSize = True
        Me.lblStatusHotel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Status", True))
        Me.lblStatusHotel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblStatusHotel.Location = New System.Drawing.Point(350, 62)
        Me.lblStatusHotel.Name = "lblStatusHotel"
        Me.lblStatusHotel.Size = New System.Drawing.Size(0, 21)
        Me.lblStatusHotel.TabIndex = 14
        '
        'txtGuestName
        '
        Me.txtGuestName.Enabled = False
        Me.txtGuestName.Location = New System.Drawing.Point(10, 17)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(358, 33)
        Me.txtGuestName.TabIndex = 6
        '
        'grbGuestName
        '
        Me.grbGuestName.BackColor = System.Drawing.Color.OldLace
        Me.grbGuestName.Controls.Add(Me.txtGuestName)
        Me.grbGuestName.Location = New System.Drawing.Point(227, 343)
        Me.grbGuestName.Name = "grbGuestName"
        Me.grbGuestName.Size = New System.Drawing.Size(374, 51)
        Me.grbGuestName.TabIndex = 4
        Me.grbGuestName.TabStop = False
        Me.grbGuestName.Text = "Guest's Name"
        Me.grbGuestName.Visible = False
        '
        'lblTotalResultHotel
        '
        Me.lblTotalResultHotel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblTotalResultHotel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalResultHotel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "TotalPrice", True))
        Me.lblTotalResultHotel.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalResultHotel.Location = New System.Drawing.Point(379, 408)
        Me.lblTotalResultHotel.Name = "lblTotalResultHotel"
        Me.lblTotalResultHotel.Size = New System.Drawing.Size(117, 26)
        Me.lblTotalResultHotel.TabIndex = 15
        Me.lblTotalResultHotel.Visible = False
        '
        'lblNameCarResult
        '
        Me.lblNameCarResult.AutoSize = True
        Me.lblNameCarResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "FullName", True))
        Me.lblNameCarResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblNameCarResult.Location = New System.Drawing.Point(656, 251)
        Me.lblNameCarResult.Name = "lblNameCarResult"
        Me.lblNameCarResult.Size = New System.Drawing.Size(66, 21)
        Me.lblNameCarResult.TabIndex = 16
        Me.lblNameCarResult.Text = "Label1"
        '
        'lblHotelNameResult
        '
        Me.lblHotelNameResult.AutoSize = True
        Me.lblHotelNameResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "FullName", True))
        Me.lblHotelNameResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblHotelNameResult.Location = New System.Drawing.Point(659, 283)
        Me.lblHotelNameResult.Name = "lblHotelNameResult"
        Me.lblHotelNameResult.Size = New System.Drawing.Size(66, 21)
        Me.lblHotelNameResult.TabIndex = 17
        Me.lblHotelNameResult.Text = "Label1"
        '
        'lblEmailCarResult
        '
        Me.lblEmailCarResult.AutoSize = True
        Me.lblEmailCarResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Email", True))
        Me.lblEmailCarResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblEmailCarResult.Location = New System.Drawing.Point(722, 283)
        Me.lblEmailCarResult.Name = "lblEmailCarResult"
        Me.lblEmailCarResult.Size = New System.Drawing.Size(0, 21)
        Me.lblEmailCarResult.TabIndex = 19
        '
        'lblEmailHotelResult
        '
        Me.lblEmailHotelResult.AutoSize = True
        Me.lblEmailHotelResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Email", True))
        Me.lblEmailHotelResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblEmailHotelResult.Location = New System.Drawing.Point(719, 251)
        Me.lblEmailHotelResult.Name = "lblEmailHotelResult"
        Me.lblEmailHotelResult.Size = New System.Drawing.Size(0, 21)
        Me.lblEmailHotelResult.TabIndex = 18
        '
        'lblPhoneHotelResult
        '
        Me.lblPhoneHotelResult.AutoSize = True
        Me.lblPhoneHotelResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Phone", True))
        Me.lblPhoneHotelResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblPhoneHotelResult.Location = New System.Drawing.Point(735, 283)
        Me.lblPhoneHotelResult.Name = "lblPhoneHotelResult"
        Me.lblPhoneHotelResult.Size = New System.Drawing.Size(0, 21)
        Me.lblPhoneHotelResult.TabIndex = 21
        '
        'lblPhoneCarResult
        '
        Me.lblPhoneCarResult.AutoSize = True
        Me.lblPhoneCarResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Phone", True))
        Me.lblPhoneCarResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblPhoneCarResult.Location = New System.Drawing.Point(732, 251)
        Me.lblPhoneCarResult.Name = "lblPhoneCarResult"
        Me.lblPhoneCarResult.Size = New System.Drawing.Size(0, 21)
        Me.lblPhoneCarResult.TabIndex = 20
        '
        'RentalCarTableAdapter
        '
        Me.RentalCarTableAdapter.ClearBeforeFill = True
        '
        'BookingHotelTableAdapter
        '
        Me.BookingHotelTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'FrmPaymentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPhoneHotelResult)
        Me.Controls.Add(Me.lblPhoneCarResult)
        Me.Controls.Add(Me.lblEmailCarResult)
        Me.Controls.Add(Me.lblEmailHotelResult)
        Me.Controls.Add(Me.lblHotelNameResult)
        Me.Controls.Add(Me.lblNameCarResult)
        Me.Controls.Add(Me.lblTotalResultHotel)
        Me.Controls.Add(Me.grbCarSummary)
        Me.Controls.Add(Me.lblUsernameHotel)
        Me.Controls.Add(Me.lblUsernameCar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblTotalResultCar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grbGuestName)
        Me.Controls.Add(Me.grbCustomerDetails)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.grbHotelSummary)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmPaymentDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Payment"
        Me.grbHotelSummary.ResumeLayout(False)
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCarSummary.ResumeLayout(False)
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCustomerDetails.ResumeLayout(False)
        Me.grbCustomerDetails.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbGuestName.ResumeLayout(False)
        Me.grbGuestName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbHotelSummary As GroupBox
    Friend WithEvents lblBreakfast As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblHotel As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents grbCustomerDetails As GroupBox
    Friend WithEvents rbtAnotherPerson As RadioButton
    Friend WithEvents rbtIAmGuest As RadioButton
    Friend WithEvents mskPhoneNum As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalResultCar As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCarType As Label
    Friend WithEvents lblPickUp As Label
    Friend WithEvents lblDropOff As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents grbCarSummary As GroupBox
    Friend WithEvents lblPriceLabel As Label
    Friend WithEvents lblSeatsLabel As Label
    Friend WithEvents lblDropOffLabel As Label
    Friend WithEvents lblPickUpLabel As Label
    Friend WithEvents lblCarTypeLabel As Label
    Friend WithEvents lblBreakfastLabel As Label
    Friend WithEvents lblRoomTypeLabel As Label
    Friend WithEvents lblCheckOutLabel As Label
    Friend WithEvents lblCheckInLabel As Label
    Friend WithEvents lblHotelLabel As Label
    Friend WithEvents lblUsernameCar As Label
    Friend WithEvents lblUsernameHotel As Label
    Friend WithEvents lblStatusCar As Label
    Friend WithEvents lblStatusHotel As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents grbGuestName As GroupBox
    Friend WithEvents lblTotalResultHotel As Label
    Friend WithEvents lblNameCarResult As Label
    Friend WithEvents lblHotelNameResult As Label
    Friend WithEvents lblEmailCarResult As Label
    Friend WithEvents lblEmailHotelResult As Label
    Friend WithEvents lblPhoneHotelResult As Label
    Friend WithEvents lblPhoneCarResult As Label
    Friend WithEvents CarRentalBindingSource2 As BindingSource
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents RentalCarBindingSource As BindingSource
    Friend WithEvents RentalCarTableAdapter As OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter
    Friend WithEvents BookingHotelBindingSource As BindingSource
    Friend WithEvents BookingHotelTableAdapter As OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ToolTipGuest As ToolTip
End Class
