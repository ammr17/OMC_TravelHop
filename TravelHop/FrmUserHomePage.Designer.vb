<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserHomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserHomePage))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.grbService = New System.Windows.Forms.GroupBox()
        Me.picCar = New System.Windows.Forms.PictureBox()
        Me.picHotel = New System.Windows.Forms.PictureBox()
        Me.btnCarRental = New System.Windows.Forms.Button()
        Me.btnHotelBooking = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMyBookings = New System.Windows.Forms.Button()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.picBookingsLogo = New System.Windows.Forms.PictureBox()
        Me.picProfileLogo = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.grbService.SuspendLayout()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHotel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.picBookingsLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfileLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(237, 30)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(330, 28)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "WELCOME TO TRAVELHOP!"
        '
        'grbService
        '
        Me.grbService.Controls.Add(Me.picCar)
        Me.grbService.Controls.Add(Me.picHotel)
        Me.grbService.Controls.Add(Me.btnCarRental)
        Me.grbService.Controls.Add(Me.btnHotelBooking)
        Me.grbService.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbService.Location = New System.Drawing.Point(244, 114)
        Me.grbService.Name = "grbService"
        Me.grbService.Size = New System.Drawing.Size(498, 301)
        Me.grbService.TabIndex = 1
        Me.grbService.TabStop = False
        Me.grbService.Text = "Choose a Service"
        '
        'picCar
        '
        Me.picCar.Image = CType(resources.GetObject("picCar.Image"), System.Drawing.Image)
        Me.picCar.Location = New System.Drawing.Point(297, 63)
        Me.picCar.Name = "picCar"
        Me.picCar.Size = New System.Drawing.Size(151, 145)
        Me.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCar.TabIndex = 3
        Me.picCar.TabStop = False
        '
        'picHotel
        '
        Me.picHotel.Image = CType(resources.GetObject("picHotel.Image"), System.Drawing.Image)
        Me.picHotel.Location = New System.Drawing.Point(42, 63)
        Me.picHotel.Name = "picHotel"
        Me.picHotel.Size = New System.Drawing.Size(151, 145)
        Me.picHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHotel.TabIndex = 2
        Me.picHotel.TabStop = False
        '
        'btnCarRental
        '
        Me.btnCarRental.BackColor = System.Drawing.Color.White
        Me.btnCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarRental.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!)
        Me.btnCarRental.Location = New System.Drawing.Point(297, 248)
        Me.btnCarRental.Name = "btnCarRental"
        Me.btnCarRental.Size = New System.Drawing.Size(151, 23)
        Me.btnCarRental.TabIndex = 1
        Me.btnCarRental.Text = "&CAR RENTAL"
        Me.btnCarRental.UseVisualStyleBackColor = False
        '
        'btnHotelBooking
        '
        Me.btnHotelBooking.BackColor = System.Drawing.Color.White
        Me.btnHotelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHotelBooking.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!)
        Me.btnHotelBooking.Location = New System.Drawing.Point(42, 248)
        Me.btnHotelBooking.Name = "btnHotelBooking"
        Me.btnHotelBooking.Size = New System.Drawing.Size(151, 23)
        Me.btnHotelBooking.TabIndex = 0
        Me.btnHotelBooking.Text = "&HOTEL BOOKING"
        Me.btnHotelBooking.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(527, 15)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'btnMyProfile
        '
        Me.btnMyProfile.BackColor = System.Drawing.Color.OldLace
        Me.btnMyProfile.FlatAppearance.BorderColor = System.Drawing.Color.OldLace
        Me.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyProfile.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyProfile.Location = New System.Drawing.Point(0, 0)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(202, 70)
        Me.btnMyProfile.TabIndex = 4
        Me.btnMyProfile.Text = "MY PROFILE"
        Me.btnMyProfile.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OldLace
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.OldLace
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(0, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(202, 70)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMyBookings
        '
        Me.btnMyBookings.BackColor = System.Drawing.Color.OldLace
        Me.btnMyBookings.FlatAppearance.BorderColor = System.Drawing.Color.OldLace
        Me.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyBookings.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyBookings.Location = New System.Drawing.Point(0, 72)
        Me.btnMyBookings.Name = "btnMyBookings"
        Me.btnMyBookings.Size = New System.Drawing.Size(202, 70)
        Me.btnMyBookings.TabIndex = 7
        Me.btnMyBookings.Text = "MY BOOKINGS"
        Me.btnMyBookings.UseVisualStyleBackColor = False
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblWelcome)
        Me.pnlBackColor.Location = New System.Drawing.Point(-16, -4)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(868, 91)
        Me.pnlBackColor.TabIndex = 8
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.OldLace
        Me.pnlButtons.Controls.Add(Me.picBookingsLogo)
        Me.pnlButtons.Controls.Add(Me.picProfileLogo)
        Me.pnlButtons.Controls.Add(Me.btnMyBookings)
        Me.pnlButtons.Controls.Add(Me.btnMyProfile)
        Me.pnlButtons.Controls.Add(Me.btnExit)
        Me.pnlButtons.Location = New System.Drawing.Point(0, 81)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(204, 374)
        Me.pnlButtons.TabIndex = 10
        '
        'picBookingsLogo
        '
        Me.picBookingsLogo.Image = CType(resources.GetObject("picBookingsLogo.Image"), System.Drawing.Image)
        Me.picBookingsLogo.Location = New System.Drawing.Point(22, 95)
        Me.picBookingsLogo.Name = "picBookingsLogo"
        Me.picBookingsLogo.Size = New System.Drawing.Size(26, 23)
        Me.picBookingsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookingsLogo.TabIndex = 12
        Me.picBookingsLogo.TabStop = False
        '
        'picProfileLogo
        '
        Me.picProfileLogo.Image = CType(resources.GetObject("picProfileLogo.Image"), System.Drawing.Image)
        Me.picProfileLogo.Location = New System.Drawing.Point(22, 20)
        Me.picProfileLogo.Name = "picProfileLogo"
        Me.picProfileLogo.Size = New System.Drawing.Size(26, 23)
        Me.picProfileLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfileLogo.TabIndex = 11
        Me.picProfileLogo.TabStop = False
        '
        'FontDialog1
        '
        '
        'FrmUserHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(852, 452)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.grbService)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop"
        Me.grbService.ResumeLayout(False)
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHotel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.picBookingsLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfileLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents grbService As GroupBox
    Friend WithEvents btnHotelBooking As Button
    Friend WithEvents btnCarRental As Button
    Friend WithEvents picCar As PictureBox
    Friend WithEvents picHotel As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnMyProfile As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMyBookings As Button
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents picProfileLogo As PictureBox
    Friend WithEvents picBookingsLogo As PictureBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
End Class
