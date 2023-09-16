<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaymentCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaymentCard))
        Me.grbCardType = New System.Windows.Forms.GroupBox()
        Me.picMastercard = New System.Windows.Forms.PictureBox()
        Me.picVisa = New System.Windows.Forms.PictureBox()
        Me.rbtMasterCard = New System.Windows.Forms.RadioButton()
        Me.rbtVISA = New System.Windows.Forms.RadioButton()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.mskCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.grbCardNum = New System.Windows.Forms.GroupBox()
        Me.grbExpiryDate = New System.Windows.Forms.GroupBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.grbCVV = New System.Windows.Forms.GroupBox()
        Me.mskCVV = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.picVisaSecure = New System.Windows.Forms.PictureBox()
        Me.picMastercardID = New System.Windows.Forms.PictureBox()
        Me.picMasterpass = New System.Windows.Forms.PictureBox()
        Me.pnlLogos = New System.Windows.Forms.Panel()
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.lblStatusCar = New System.Windows.Forms.Label()
        Me.RentalCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblStatusHotel = New System.Windows.Forms.Label()
        Me.BookingHotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalCarTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter()
        Me.BookingHotelTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter()
        Me.ToolTipCVV = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbCardType.SuspendLayout()
        CType(Me.picMastercard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCardNum.SuspendLayout()
        Me.grbExpiryDate.SuspendLayout()
        Me.grbCVV.SuspendLayout()
        CType(Me.picVisaSecure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMastercardID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMasterpass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogos.SuspendLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCardType
        '
        Me.grbCardType.Controls.Add(Me.picMastercard)
        Me.grbCardType.Controls.Add(Me.picVisa)
        Me.grbCardType.Controls.Add(Me.rbtMasterCard)
        Me.grbCardType.Controls.Add(Me.rbtVISA)
        Me.grbCardType.Location = New System.Drawing.Point(124, 118)
        Me.grbCardType.Name = "grbCardType"
        Me.grbCardType.Size = New System.Drawing.Size(231, 81)
        Me.grbCardType.TabIndex = 0
        Me.grbCardType.TabStop = False
        Me.grbCardType.Text = "Card Type"
        '
        'picMastercard
        '
        Me.picMastercard.Image = CType(resources.GetObject("picMastercard.Image"), System.Drawing.Image)
        Me.picMastercard.Location = New System.Drawing.Point(145, 32)
        Me.picMastercard.Name = "picMastercard"
        Me.picMastercard.Size = New System.Drawing.Size(52, 30)
        Me.picMastercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMastercard.TabIndex = 3
        Me.picMastercard.TabStop = False
        '
        'picVisa
        '
        Me.picVisa.Image = CType(resources.GetObject("picVisa.Image"), System.Drawing.Image)
        Me.picVisa.Location = New System.Drawing.Point(38, 32)
        Me.picVisa.Name = "picVisa"
        Me.picVisa.Size = New System.Drawing.Size(52, 30)
        Me.picVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVisa.TabIndex = 2
        Me.picVisa.TabStop = False
        '
        'rbtMasterCard
        '
        Me.rbtMasterCard.AutoSize = True
        Me.rbtMasterCard.Location = New System.Drawing.Point(125, 40)
        Me.rbtMasterCard.Name = "rbtMasterCard"
        Me.rbtMasterCard.Size = New System.Drawing.Size(21, 20)
        Me.rbtMasterCard.TabIndex = 1
        Me.rbtMasterCard.TabStop = True
        Me.rbtMasterCard.UseVisualStyleBackColor = True
        '
        'rbtVISA
        '
        Me.rbtVISA.AutoSize = True
        Me.rbtVISA.Location = New System.Drawing.Point(18, 40)
        Me.rbtVISA.Name = "rbtVISA"
        Me.rbtVISA.Size = New System.Drawing.Size(21, 20)
        Me.rbtVISA.TabIndex = 0
        Me.rbtVISA.TabStop = True
        Me.rbtVISA.UseVisualStyleBackColor = True
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblPayment)
        Me.pnlBackColor.Location = New System.Drawing.Point(-3, -5)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(811, 83)
        Me.pnlBackColor.TabIndex = 3
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
        'mskCardNumber
        '
        Me.mskCardNumber.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCardNumber.Location = New System.Drawing.Point(18, 31)
        Me.mskCardNumber.Mask = "#### #### #### ####"
        Me.mskCardNumber.Name = "mskCardNumber"
        Me.mskCardNumber.Size = New System.Drawing.Size(191, 44)
        Me.mskCardNumber.TabIndex = 5
        '
        'grbCardNum
        '
        Me.grbCardNum.Controls.Add(Me.mskCardNumber)
        Me.grbCardNum.Location = New System.Drawing.Point(124, 224)
        Me.grbCardNum.Name = "grbCardNum"
        Me.grbCardNum.Size = New System.Drawing.Size(231, 81)
        Me.grbCardNum.TabIndex = 6
        Me.grbCardNum.TabStop = False
        Me.grbCardNum.Text = "Card Number"
        '
        'grbExpiryDate
        '
        Me.grbExpiryDate.Controls.Add(Me.cboYear)
        Me.grbExpiryDate.Controls.Add(Me.cboMonth)
        Me.grbExpiryDate.Controls.Add(Me.lblYear)
        Me.grbExpiryDate.Controls.Add(Me.lblMonth)
        Me.grbExpiryDate.Location = New System.Drawing.Point(426, 118)
        Me.grbExpiryDate.Name = "grbExpiryDate"
        Me.grbExpiryDate.Size = New System.Drawing.Size(231, 81)
        Me.grbExpiryDate.TabIndex = 7
        Me.grbExpiryDate.TabStop = False
        Me.grbExpiryDate.Text = "Expiry Date"
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.cboYear.Location = New System.Drawing.Point(145, 38)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(80, 29)
        Me.cboYear.TabIndex = 3
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(6, 38)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 29)
        Me.cboMonth.TabIndex = 2
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(160, 20)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(48, 21)
        Me.lblYear.TabIndex = 1
        Me.lblYear.Text = "Year"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(15, 20)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(62, 21)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Month"
        '
        'grbCVV
        '
        Me.grbCVV.Controls.Add(Me.mskCVV)
        Me.grbCVV.Location = New System.Drawing.Point(426, 224)
        Me.grbCVV.Name = "grbCVV"
        Me.grbCVV.Size = New System.Drawing.Size(231, 81)
        Me.grbCVV.TabIndex = 8
        Me.grbCVV.TabStop = False
        Me.grbCVV.Text = "CVV"
        '
        'mskCVV
        '
        Me.mskCVV.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCVV.Location = New System.Drawing.Point(80, 31)
        Me.mskCVV.Mask = "###"
        Me.mskCVV.Name = "mskCVV"
        Me.mskCVV.Size = New System.Drawing.Size(66, 44)
        Me.mskCVV.TabIndex = 6
        Me.ToolTipCVV.SetToolTip(Me.mskCVV, "3 Numbers in the Back of Your Card")
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(266, 328)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(426, 328)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'picVisaSecure
        '
        Me.picVisaSecure.Image = CType(resources.GetObject("picVisaSecure.Image"), System.Drawing.Image)
        Me.picVisaSecure.Location = New System.Drawing.Point(223, 12)
        Me.picVisaSecure.Name = "picVisaSecure"
        Me.picVisaSecure.Size = New System.Drawing.Size(100, 50)
        Me.picVisaSecure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVisaSecure.TabIndex = 11
        Me.picVisaSecure.TabStop = False
        '
        'picMastercardID
        '
        Me.picMastercardID.Image = CType(resources.GetObject("picMastercardID.Image"), System.Drawing.Image)
        Me.picMastercardID.Location = New System.Drawing.Point(343, 12)
        Me.picMastercardID.Name = "picMastercardID"
        Me.picMastercardID.Size = New System.Drawing.Size(100, 50)
        Me.picMastercardID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMastercardID.TabIndex = 12
        Me.picMastercardID.TabStop = False
        '
        'picMasterpass
        '
        Me.picMasterpass.Image = CType(resources.GetObject("picMasterpass.Image"), System.Drawing.Image)
        Me.picMasterpass.Location = New System.Drawing.Point(464, 12)
        Me.picMasterpass.Name = "picMasterpass"
        Me.picMasterpass.Size = New System.Drawing.Size(100, 50)
        Me.picMasterpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMasterpass.TabIndex = 13
        Me.picMasterpass.TabStop = False
        '
        'pnlLogos
        '
        Me.pnlLogos.BackColor = System.Drawing.Color.White
        Me.pnlLogos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLogos.Controls.Add(Me.picMasterpass)
        Me.pnlLogos.Controls.Add(Me.picVisaSecure)
        Me.pnlLogos.Controls.Add(Me.picMastercardID)
        Me.pnlLogos.Controls.Add(Me.lblStatusCar)
        Me.pnlLogos.Controls.Add(Me.lblStatusHotel)
        Me.pnlLogos.Location = New System.Drawing.Point(-3, 374)
        Me.pnlLogos.Name = "pnlLogos"
        Me.pnlLogos.Size = New System.Drawing.Size(811, 90)
        Me.pnlLogos.TabIndex = 14
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.White
        Me.pnlBorder.Location = New System.Drawing.Point(383, 118)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(10, 187)
        Me.pnlBorder.TabIndex = 15
        '
        'lblStatusCar
        '
        Me.lblStatusCar.AutoSize = True
        Me.lblStatusCar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "Status", True))
        Me.lblStatusCar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblStatusCar.Location = New System.Drawing.Point(534, 27)
        Me.lblStatusCar.Name = "lblStatusCar"
        Me.lblStatusCar.Size = New System.Drawing.Size(0, 21)
        Me.lblStatusCar.TabIndex = 16
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
        'lblStatusHotel
        '
        Me.lblStatusHotel.AutoSize = True
        Me.lblStatusHotel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingHotelBindingSource, "Status", True))
        Me.lblStatusHotel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblStatusHotel.Location = New System.Drawing.Point(458, 12)
        Me.lblStatusHotel.Name = "lblStatusHotel"
        Me.lblStatusHotel.Size = New System.Drawing.Size(0, 21)
        Me.lblStatusHotel.TabIndex = 17
        '
        'BookingHotelBindingSource
        '
        Me.BookingHotelBindingSource.DataMember = "BookingHotel"
        Me.BookingHotelBindingSource.DataSource = Me.OMC_TravelHopDataSet
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
        'FrmPaymentCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlBorder)
        Me.Controls.Add(Me.pnlLogos)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grbCVV)
        Me.Controls.Add(Me.grbExpiryDate)
        Me.Controls.Add(Me.grbCardNum)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.grbCardType)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmPaymentCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Payment"
        Me.grbCardType.ResumeLayout(False)
        Me.grbCardType.PerformLayout()
        CType(Me.picMastercard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCardNum.ResumeLayout(False)
        Me.grbCardNum.PerformLayout()
        Me.grbExpiryDate.ResumeLayout(False)
        Me.grbExpiryDate.PerformLayout()
        Me.grbCVV.ResumeLayout(False)
        Me.grbCVV.PerformLayout()
        CType(Me.picVisaSecure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMastercardID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMasterpass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogos.ResumeLayout(False)
        Me.pnlLogos.PerformLayout()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingHotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbCardType As GroupBox
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents picMastercard As PictureBox
    Friend WithEvents picVisa As PictureBox
    Friend WithEvents rbtMasterCard As RadioButton
    Friend WithEvents rbtVISA As RadioButton
    Friend WithEvents mskCardNumber As MaskedTextBox
    Friend WithEvents grbCardNum As GroupBox
    Friend WithEvents grbExpiryDate As GroupBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents grbCVV As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents picVisaSecure As PictureBox
    Friend WithEvents picMastercardID As PictureBox
    Friend WithEvents picMasterpass As PictureBox
    Friend WithEvents pnlLogos As Panel
    Friend WithEvents pnlBorder As Panel
    Friend WithEvents lblStatusCar As Label
    Friend WithEvents lblStatusHotel As Label
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents RentalCarBindingSource As BindingSource
    Friend WithEvents RentalCarTableAdapter As OMC_TravelHopDataSetTableAdapters.RentalCarTableAdapter
    Friend WithEvents BookingHotelBindingSource As BindingSource
    Friend WithEvents BookingHotelTableAdapter As OMC_TravelHopDataSetTableAdapters.BookingHotelTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As OMC_TravelHopDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents mskCVV As MaskedTextBox
    Friend WithEvents ToolTipCVV As ToolTip
End Class
