<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTAViewBookingsCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTAViewBookingsCar))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblTABooking = New System.Windows.Forms.Label()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.lblTotalResult = New System.Windows.Forms.Label()
        Me.RentalCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblSeatsResult = New System.Windows.Forms.Label()
        Me.lblDropOffResult = New System.Windows.Forms.Label()
        Me.lblPickUpResult = New System.Windows.Forms.Label()
        Me.lblCarResult = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.lblDropOff = New System.Windows.Forms.Label()
        Me.lblPickUp = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNameResult = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusResult = New System.Windows.Forms.Label()
        Me.RentalCarTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter()
        Me.ToolTipApproval = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTotalResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "TotalPrice", True))
        Me.lblTotalResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalResult.Location = New System.Drawing.Point(149, 298)
        Me.lblTotalResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(163, 20)
        Me.lblTotalResult.TabIndex = 41
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
        'lblSeatsResult
        '
        Me.lblSeatsResult.BackColor = System.Drawing.Color.White
        Me.lblSeatsResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeatsResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Seats", True))
        Me.lblSeatsResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatsResult.Location = New System.Drawing.Point(149, 263)
        Me.lblSeatsResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeatsResult.Name = "lblSeatsResult"
        Me.lblSeatsResult.Size = New System.Drawing.Size(163, 20)
        Me.lblSeatsResult.TabIndex = 39
        '
        'lblDropOffResult
        '
        Me.lblDropOffResult.BackColor = System.Drawing.Color.White
        Me.lblDropOffResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDropOffResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "DropOff", True))
        Me.lblDropOffResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropOffResult.Location = New System.Drawing.Point(149, 230)
        Me.lblDropOffResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDropOffResult.Name = "lblDropOffResult"
        Me.lblDropOffResult.Size = New System.Drawing.Size(163, 20)
        Me.lblDropOffResult.TabIndex = 38
        '
        'lblPickUpResult
        '
        Me.lblPickUpResult.BackColor = System.Drawing.Color.White
        Me.lblPickUpResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPickUpResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "PickUp", True))
        Me.lblPickUpResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickUpResult.Location = New System.Drawing.Point(149, 194)
        Me.lblPickUpResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPickUpResult.Name = "lblPickUpResult"
        Me.lblPickUpResult.Size = New System.Drawing.Size(163, 20)
        Me.lblPickUpResult.TabIndex = 37
        '
        'lblCarResult
        '
        Me.lblCarResult.BackColor = System.Drawing.Color.White
        Me.lblCarResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "CarType", True))
        Me.lblCarResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarResult.Location = New System.Drawing.Point(149, 158)
        Me.lblCarResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCarResult.Name = "lblCarResult"
        Me.lblCarResult.Size = New System.Drawing.Size(163, 20)
        Me.lblCarResult.TabIndex = 36
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(42, 299)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(83, 18)
        Me.lblPrice.TabIndex = 35
        Me.lblPrice.Text = "Total Price:"
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeats.Location = New System.Drawing.Point(42, 264)
        Me.lblSeats.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(50, 18)
        Me.lblSeats.TabIndex = 33
        Me.lblSeats.Text = "Seats:"
        '
        'lblDropOff
        '
        Me.lblDropOff.AutoSize = True
        Me.lblDropOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropOff.Location = New System.Drawing.Point(42, 231)
        Me.lblDropOff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDropOff.Name = "lblDropOff"
        Me.lblDropOff.Size = New System.Drawing.Size(70, 18)
        Me.lblDropOff.TabIndex = 32
        Me.lblDropOff.Text = "Drop-Off:"
        '
        'lblPickUp
        '
        Me.lblPickUp.AutoSize = True
        Me.lblPickUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickUp.Location = New System.Drawing.Point(42, 195)
        Me.lblPickUp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPickUp.Name = "lblPickUp"
        Me.lblPickUp.Size = New System.Drawing.Size(65, 18)
        Me.lblPickUp.TabIndex = 31
        Me.lblPickUp.Text = "Pick-Up:"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCar.Location = New System.Drawing.Point(42, 158)
        Me.lblCar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(47, 18)
        Me.lblCar.TabIndex = 30
        Me.lblCar.Text = "Hotel:"
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
        Me.lblNameResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "FullName", True))
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
        Me.lblStatusResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Status", True))
        Me.lblStatusResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusResult.Location = New System.Drawing.Point(149, 381)
        Me.lblStatusResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatusResult.Name = "lblStatusResult"
        Me.lblStatusResult.Size = New System.Drawing.Size(163, 20)
        Me.lblStatusResult.TabIndex = 47
        '
        'RentalCarTableAdapter
        '
        Me.RentalCarTableAdapter.ClearBeforeFill = True
        '
        'frmTAViewBookingsCar
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
        Me.Controls.Add(Me.lblSeatsResult)
        Me.Controls.Add(Me.lblDropOffResult)
        Me.Controls.Add(Me.lblPickUpResult)
        Me.Controls.Add(Me.lblCarResult)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.lblDropOff)
        Me.Controls.Add(Me.lblPickUp)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTAViewBookingsCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agency - View Bookings"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTABooking As Label
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents lblTotalResult As Label
    Friend WithEvents lblSeatsResult As Label
    Friend WithEvents lblDropOffResult As Label
    Friend WithEvents lblPickUpResult As Label
    Friend WithEvents lblCarResult As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblDropOff As Label
    Friend WithEvents lblPickUp As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblNameResult As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStatusResult As Label
    Friend WithEvents RentalCarBindingSource As BindingSource
    Friend WithEvents RentalCarTableAdapter As OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter
    Friend WithEvents ToolTipApproval As ToolTip
End Class
