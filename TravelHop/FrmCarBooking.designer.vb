<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCarBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarBooking))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblPickup = New System.Windows.Forms.Label()
        Me.cboPickupTime = New System.Windows.Forms.ComboBox()
        Me.lblPU = New System.Windows.Forms.Label()
        Me.lblDO = New System.Windows.Forms.Label()
        Me.cboDropoffTime = New System.Windows.Forms.ComboBox()
        Me.lblPUD = New System.Windows.Forms.Label()
        Me.lblDOD = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblDropOff = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.lblPickUpDropOff = New System.Windows.Forms.Label()
        Me.grbCarSummary = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.grbPickUpDropOff = New System.Windows.Forms.GroupBox()
        Me.cboDropOff = New System.Windows.Forms.ComboBox()
        Me.cboPickUp = New System.Windows.Forms.ComboBox()
        Me.grbCarSummary.SuspendLayout()
        Me.grbPickUpDropOff.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(698, 402)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblPickup
        '
        Me.lblPickup.AutoSize = True
        Me.lblPickup.Location = New System.Drawing.Point(19, 67)
        Me.lblPickup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPickup.Name = "lblPickup"
        Me.lblPickup.Size = New System.Drawing.Size(52, 15)
        Me.lblPickup.TabIndex = 5
        Me.lblPickup.Text = "Pick-Up:"
        '
        'cboPickupTime
        '
        Me.cboPickupTime.FormattingEnabled = True
        Me.cboPickupTime.Items.AddRange(New Object() {"08:00 ", "09:00 ", "10:00  ", "11:00 ", "12:00 ", "13:00 ", "14:00 ", "15:00 ", "16:00 ", "17:00 ", "18:00 ", "19:00 ", "20:00 ", "21:00 ", "22:00 ", "23:00 ", "", ""})
        Me.cboPickupTime.Location = New System.Drawing.Point(397, 245)
        Me.cboPickupTime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboPickupTime.Name = "cboPickupTime"
        Me.cboPickupTime.Size = New System.Drawing.Size(121, 23)
        Me.cboPickupTime.TabIndex = 9
        '
        'lblPU
        '
        Me.lblPU.AutoSize = True
        Me.lblPU.Location = New System.Drawing.Point(300, 248)
        Me.lblPU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPU.Name = "lblPU"
        Me.lblPU.Size = New System.Drawing.Size(84, 15)
        Me.lblPU.TabIndex = 10
        Me.lblPU.Text = "Pick-up Time :"
        '
        'lblDO
        '
        Me.lblDO.AutoSize = True
        Me.lblDO.Location = New System.Drawing.Point(555, 248)
        Me.lblDO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDO.Name = "lblDO"
        Me.lblDO.Size = New System.Drawing.Size(90, 15)
        Me.lblDO.TabIndex = 11
        Me.lblDO.Text = "Drop Off Time :"
        '
        'cboDropoffTime
        '
        Me.cboDropoffTime.FormattingEnabled = True
        Me.cboDropoffTime.Items.AddRange(New Object() {"08:00 ", "09:00 ", "10:00  ", "11:00 ", "12:00 ", "13:00 ", "14:00 ", "15:00 ", "16:00 ", "17:00 ", "18:00 ", "19:00 ", "20:00 ", "21:00 ", "22:00 ", "23:00 "})
        Me.cboDropoffTime.Location = New System.Drawing.Point(652, 245)
        Me.cboDropoffTime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboDropoffTime.Name = "cboDropoffTime"
        Me.cboDropoffTime.Size = New System.Drawing.Size(121, 23)
        Me.cboDropoffTime.TabIndex = 12
        '
        'lblPUD
        '
        Me.lblPUD.AutoSize = True
        Me.lblPUD.Location = New System.Drawing.Point(291, 47)
        Me.lblPUD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPUD.Name = "lblPUD"
        Me.lblPUD.Size = New System.Drawing.Size(81, 15)
        Me.lblPUD.TabIndex = 13
        Me.lblPUD.Text = "Pick-up Date :"
        '
        'lblDOD
        '
        Me.lblDOD.AutoSize = True
        Me.lblDOD.Location = New System.Drawing.Point(546, 47)
        Me.lblDOD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOD.Name = "lblDOD"
        Me.lblDOD.Size = New System.Drawing.Size(87, 15)
        Me.lblDOD.TabIndex = 14
        Me.lblDOD.Text = "Drop Off Date :"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(600, 402)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblDropOff
        '
        Me.lblDropOff.AutoSize = True
        Me.lblDropOff.Location = New System.Drawing.Point(19, 111)
        Me.lblDropOff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDropOff.Name = "lblDropOff"
        Me.lblDropOff.Size = New System.Drawing.Size(57, 15)
        Me.lblDropOff.TabIndex = 16
        Me.lblDropOff.Text = "Drop Off:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(291, 71)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 19
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(546, 71)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 20
        '
        'lblPickUpDropOff
        '
        Me.lblPickUpDropOff.AutoSize = True
        Me.lblPickUpDropOff.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblPickUpDropOff.Location = New System.Drawing.Point(42, 20)
        Me.lblPickUpDropOff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPickUpDropOff.Name = "lblPickUpDropOff"
        Me.lblPickUpDropOff.Size = New System.Drawing.Size(159, 17)
        Me.lblPickUpDropOff.TabIndex = 21
        Me.lblPickUpDropOff.Text = "PICK-UP AND DROP OFF"
        '
        'grbCarSummary
        '
        Me.grbCarSummary.BackColor = System.Drawing.Color.OldLace
        Me.grbCarSummary.Controls.Add(Me.lblPrice)
        Me.grbCarSummary.Controls.Add(Me.lblSeats)
        Me.grbCarSummary.Controls.Add(Me.lblCarType)
        Me.grbCarSummary.Location = New System.Drawing.Point(13, 333)
        Me.grbCarSummary.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbCarSummary.Name = "grbCarSummary"
        Me.grbCarSummary.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grbCarSummary.Size = New System.Drawing.Size(435, 92)
        Me.grbCarSummary.TabIndex = 23
        Me.grbCarSummary.TabStop = False
        Me.grbCarSummary.Text = "Your Booking Summary"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(288, 24)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(134, 51)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price:"
        '
        'lblSeats
        '
        Me.lblSeats.BackColor = System.Drawing.Color.White
        Me.lblSeats.Location = New System.Drawing.Point(148, 24)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(134, 51)
        Me.lblSeats.TabIndex = 3
        Me.lblSeats.Text = "Seats:"
        '
        'lblCarType
        '
        Me.lblCarType.BackColor = System.Drawing.Color.White
        Me.lblCarType.Location = New System.Drawing.Point(8, 24)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(134, 51)
        Me.lblCarType.TabIndex = 0
        Me.lblCarType.Text = "Car Type:"
        '
        'grbPickUpDropOff
        '
        Me.grbPickUpDropOff.BackColor = System.Drawing.Color.OldLace
        Me.grbPickUpDropOff.Controls.Add(Me.cboDropOff)
        Me.grbPickUpDropOff.Controls.Add(Me.cboPickUp)
        Me.grbPickUpDropOff.Controls.Add(Me.lblPickUpDropOff)
        Me.grbPickUpDropOff.Controls.Add(Me.lblPickup)
        Me.grbPickUpDropOff.Controls.Add(Me.lblDropOff)
        Me.grbPickUpDropOff.Location = New System.Drawing.Point(13, 71)
        Me.grbPickUpDropOff.Name = "grbPickUpDropOff"
        Me.grbPickUpDropOff.Size = New System.Drawing.Size(247, 162)
        Me.grbPickUpDropOff.TabIndex = 24
        Me.grbPickUpDropOff.TabStop = False
        '
        'cboDropOff
        '
        Me.cboDropOff.FormattingEnabled = True
        Me.cboDropOff.Items.AddRange(New Object() {"KLIA", "KLIA2", "KL Sentral", "Terminal Bersepadu Selatan"})
        Me.cboDropOff.Location = New System.Drawing.Point(90, 108)
        Me.cboDropOff.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboDropOff.Name = "cboDropOff"
        Me.cboDropOff.Size = New System.Drawing.Size(132, 23)
        Me.cboDropOff.TabIndex = 26
        '
        'cboPickUp
        '
        Me.cboPickUp.FormattingEnabled = True
        Me.cboPickUp.Items.AddRange(New Object() {"KLIA", "KLIA2", "KL Sentral", "Terminal Bersepadu Selatan"})
        Me.cboPickUp.Location = New System.Drawing.Point(90, 64)
        Me.cboPickUp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboPickUp.Name = "cboPickUp"
        Me.cboPickUp.Size = New System.Drawing.Size(132, 23)
        Me.cboPickUp.TabIndex = 25
        '
        'FrmCarBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbPickUpDropOff)
        Me.Controls.Add(Me.grbCarSummary)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblDOD)
        Me.Controls.Add(Me.lblPUD)
        Me.Controls.Add(Me.cboDropoffTime)
        Me.Controls.Add(Me.lblDO)
        Me.Controls.Add(Me.lblPU)
        Me.Controls.Add(Me.cboPickupTime)
        Me.Controls.Add(Me.btnNext)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmCarBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Car Booking"
        Me.grbCarSummary.ResumeLayout(False)
        Me.grbPickUpDropOff.ResumeLayout(False)
        Me.grbPickUpDropOff.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents lblPickup As Label
    Friend WithEvents cboPickupTime As ComboBox
    Friend WithEvents lblPU As Label
    Friend WithEvents lblDO As Label
    Friend WithEvents cboDropoffTime As ComboBox
    Friend WithEvents lblPUD As Label
    Friend WithEvents lblDOD As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblDropOff As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents lblPickUpDropOff As Label
    Friend WithEvents grbCarSummary As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblCarType As Label
    Friend WithEvents grbPickUpDropOff As GroupBox
    Friend WithEvents cboPickUp As ComboBox
    Friend WithEvents cboDropOff As ComboBox
End Class
