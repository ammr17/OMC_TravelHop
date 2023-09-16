<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCancellation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCancellation))
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.picCancelLogo = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblBookingCancellation = New System.Windows.Forms.Label()
        Me.grbReasons = New System.Windows.Forms.GroupBox()
        Me.txtOtherReason = New System.Windows.Forms.TextBox()
        Me.rbtOther = New System.Windows.Forms.RadioButton()
        Me.rbtPersonalReason = New System.Windows.Forms.RadioButton()
        Me.rbtChangeDate = New System.Windows.Forms.RadioButton()
        Me.rbtHealth = New System.Windows.Forms.RadioButton()
        Me.rbtDifferentAccomodation = New System.Windows.Forms.RadioButton()
        Me.grbCancellationFee = New System.Windows.Forms.GroupBox()
        Me.lblFeeResult = New System.Windows.Forms.Label()
        Me.lblFeePercentage = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblRefundMsg = New System.Windows.Forms.Label()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picCancelLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbReasons.SuspendLayout()
        Me.grbCancellationFee.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picCancelLogo)
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblBookingCancellation)
        Me.pnlBackColor.Location = New System.Drawing.Point(-3, -5)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(809, 78)
        Me.pnlBackColor.TabIndex = 2
        '
        'picCancelLogo
        '
        Me.picCancelLogo.Image = CType(resources.GetObject("picCancelLogo.Image"), System.Drawing.Image)
        Me.picCancelLogo.Location = New System.Drawing.Point(500, 15)
        Me.picCancelLogo.Name = "picCancelLogo"
        Me.picCancelLogo.Size = New System.Drawing.Size(52, 50)
        Me.picCancelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCancelLogo.TabIndex = 8
        Me.picCancelLogo.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(497, 15)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        Me.picLogo.Visible = False
        '
        'lblBookingCancellation
        '
        Me.lblBookingCancellation.AutoSize = True
        Me.lblBookingCancellation.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingCancellation.Location = New System.Drawing.Point(227, 27)
        Me.lblBookingCancellation.Name = "lblBookingCancellation"
        Me.lblBookingCancellation.Size = New System.Drawing.Size(264, 23)
        Me.lblBookingCancellation.TabIndex = 0
        Me.lblBookingCancellation.Text = "BOOKING CANCELLATION"
        '
        'grbReasons
        '
        Me.grbReasons.BackColor = System.Drawing.Color.OldLace
        Me.grbReasons.Controls.Add(Me.txtOtherReason)
        Me.grbReasons.Controls.Add(Me.rbtOther)
        Me.grbReasons.Controls.Add(Me.rbtPersonalReason)
        Me.grbReasons.Controls.Add(Me.rbtChangeDate)
        Me.grbReasons.Controls.Add(Me.rbtHealth)
        Me.grbReasons.Controls.Add(Me.rbtDifferentAccomodation)
        Me.grbReasons.Location = New System.Drawing.Point(230, 95)
        Me.grbReasons.Name = "grbReasons"
        Me.grbReasons.Size = New System.Drawing.Size(300, 195)
        Me.grbReasons.TabIndex = 4
        Me.grbReasons.TabStop = False
        Me.grbReasons.Text = "Reason for Cancellation"
        '
        'txtOtherReason
        '
        Me.txtOtherReason.Enabled = False
        Me.txtOtherReason.Location = New System.Drawing.Point(42, 152)
        Me.txtOtherReason.Name = "txtOtherReason"
        Me.txtOtherReason.Size = New System.Drawing.Size(229, 24)
        Me.txtOtherReason.TabIndex = 5
        '
        'rbtOther
        '
        Me.rbtOther.AutoSize = True
        Me.rbtOther.Location = New System.Drawing.Point(23, 126)
        Me.rbtOther.Name = "rbtOther"
        Me.rbtOther.Size = New System.Drawing.Size(59, 19)
        Me.rbtOther.TabIndex = 4
        Me.rbtOther.TabStop = True
        Me.rbtOther.Text = "Other:"
        Me.rbtOther.UseVisualStyleBackColor = True
        '
        'rbtPersonalReason
        '
        Me.rbtPersonalReason.AutoSize = True
        Me.rbtPersonalReason.Location = New System.Drawing.Point(23, 100)
        Me.rbtPersonalReason.Name = "rbtPersonalReason"
        Me.rbtPersonalReason.Size = New System.Drawing.Size(113, 19)
        Me.rbtPersonalReason.TabIndex = 3
        Me.rbtPersonalReason.TabStop = True
        Me.rbtPersonalReason.Text = "Personal Reason"
        Me.rbtPersonalReason.UseVisualStyleBackColor = True
        '
        'rbtChangeDate
        '
        Me.rbtChangeDate.AutoSize = True
        Me.rbtChangeDate.Location = New System.Drawing.Point(23, 74)
        Me.rbtChangeDate.Name = "rbtChangeDate"
        Me.rbtChangeDate.Size = New System.Drawing.Size(172, 19)
        Me.rbtChangeDate.TabIndex = 2
        Me.rbtChangeDate.TabStop = True
        Me.rbtChangeDate.Text = "Change of date/destination"
        Me.rbtChangeDate.UseVisualStyleBackColor = True
        '
        'rbtHealth
        '
        Me.rbtHealth.AutoSize = True
        Me.rbtHealth.Location = New System.Drawing.Point(23, 48)
        Me.rbtHealth.Name = "rbtHealth"
        Me.rbtHealth.Size = New System.Drawing.Size(242, 19)
        Me.rbtHealth.TabIndex = 1
        Me.rbtHealth.TabStop = True
        Me.rbtHealth.Text = "Unable to travel due to health conditions"
        Me.rbtHealth.UseVisualStyleBackColor = True
        '
        'rbtDifferentAccomodation
        '
        Me.rbtDifferentAccomodation.AutoSize = True
        Me.rbtDifferentAccomodation.Location = New System.Drawing.Point(23, 23)
        Me.rbtDifferentAccomodation.Name = "rbtDifferentAccomodation"
        Me.rbtDifferentAccomodation.Size = New System.Drawing.Size(273, 19)
        Me.rbtDifferentAccomodation.TabIndex = 0
        Me.rbtDifferentAccomodation.TabStop = True
        Me.rbtDifferentAccomodation.Text = "Have a different accomodation/transportation"
        Me.rbtDifferentAccomodation.UseVisualStyleBackColor = True
        '
        'grbCancellationFee
        '
        Me.grbCancellationFee.BackColor = System.Drawing.Color.OldLace
        Me.grbCancellationFee.Controls.Add(Me.lblFeeResult)
        Me.grbCancellationFee.Controls.Add(Me.lblFeePercentage)
        Me.grbCancellationFee.Location = New System.Drawing.Point(295, 331)
        Me.grbCancellationFee.Name = "grbCancellationFee"
        Me.grbCancellationFee.Size = New System.Drawing.Size(165, 67)
        Me.grbCancellationFee.TabIndex = 6
        Me.grbCancellationFee.TabStop = False
        Me.grbCancellationFee.Text = "Cancellation Fee"
        '
        'lblFeeResult
        '
        Me.lblFeeResult.BackColor = System.Drawing.Color.White
        Me.lblFeeResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFeeResult.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeeResult.Location = New System.Drawing.Point(42, 25)
        Me.lblFeeResult.Name = "lblFeeResult"
        Me.lblFeeResult.Size = New System.Drawing.Size(94, 27)
        Me.lblFeeResult.TabIndex = 1
        '
        'lblFeePercentage
        '
        Me.lblFeePercentage.AutoSize = True
        Me.lblFeePercentage.Location = New System.Drawing.Point(12, 31)
        Me.lblFeePercentage.Name = "lblFeePercentage"
        Me.lblFeePercentage.Size = New System.Drawing.Size(28, 15)
        Me.lblFeePercentage.TabIndex = 0
        Me.lblFeePercentage.Text = "25%"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(586, 406)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(165, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.White
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Location = New System.Drawing.Point(586, 362)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(165, 23)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "&CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblRefundMsg
        '
        Me.lblRefundMsg.AutoSize = True
        Me.lblRefundMsg.Location = New System.Drawing.Point(292, 401)
        Me.lblRefundMsg.Name = "lblRefundMsg"
        Me.lblRefundMsg.Size = New System.Drawing.Size(110, 15)
        Me.lblRefundMsg.TabIndex = 7
        Me.lblRefundMsg.Text = "*Refund will be 75%"
        '
        'FrmCancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRefundMsg)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grbCancellationFee)
        Me.Controls.Add(Me.grbReasons)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmCancellation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Cancellation"
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picCancelLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbReasons.ResumeLayout(False)
        Me.grbReasons.PerformLayout()
        Me.grbCancellationFee.ResumeLayout(False)
        Me.grbCancellationFee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblBookingCancellation As Label
    Friend WithEvents grbReasons As GroupBox
    Friend WithEvents txtOtherReason As TextBox
    Friend WithEvents rbtOther As RadioButton
    Friend WithEvents rbtPersonalReason As RadioButton
    Friend WithEvents rbtChangeDate As RadioButton
    Friend WithEvents rbtHealth As RadioButton
    Friend WithEvents rbtDifferentAccomodation As RadioButton
    Friend WithEvents grbCancellationFee As GroupBox
    Friend WithEvents lblFeeResult As Label
    Friend WithEvents lblFeePercentage As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblRefundMsg As Label
    Friend WithEvents picCancelLogo As PictureBox
End Class
