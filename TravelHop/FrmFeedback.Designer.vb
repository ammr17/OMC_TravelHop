<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFeedback))
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblFeedbackReview = New System.Windows.Forms.Label()
        Me.grbRateOurService = New System.Windows.Forms.GroupBox()
        Me.grbPaymentProcess = New System.Windows.Forms.GroupBox()
        Me.rbtPaymentExcellent = New System.Windows.Forms.RadioButton()
        Me.rbtPaymentPoor = New System.Windows.Forms.RadioButton()
        Me.rbtPaymentGood = New System.Windows.Forms.RadioButton()
        Me.grbInfoProvided = New System.Windows.Forms.GroupBox()
        Me.rbtInfoExcellent = New System.Windows.Forms.RadioButton()
        Me.rbtInfoPoor = New System.Windows.Forms.RadioButton()
        Me.rbtInfoGood = New System.Windows.Forms.RadioButton()
        Me.grbNavigating = New System.Windows.Forms.GroupBox()
        Me.rbtEaseExcellent = New System.Windows.Forms.RadioButton()
        Me.rbtEasePoor = New System.Windows.Forms.RadioButton()
        Me.rbtEaseGood = New System.Windows.Forms.RadioButton()
        Me.grbSmoothness = New System.Windows.Forms.GroupBox()
        Me.rbtBookingExcellent = New System.Windows.Forms.RadioButton()
        Me.rbtBookingPoor = New System.Windows.Forms.RadioButton()
        Me.rbtBookingGood = New System.Windows.Forms.RadioButton()
        Me.txtOtherFeedback = New System.Windows.Forms.TextBox()
        Me.CustFeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.lblOtherFeedback = New System.Windows.Forms.Label()
        Me.lblPaymentProcess = New System.Windows.Forms.Label()
        Me.lblInformationProvided = New System.Windows.Forms.Label()
        Me.lblEaseNavigating = New System.Windows.Forms.Label()
        Me.lblBookingSmoothness = New System.Windows.Forms.Label()
        Me.lblExcellent = New System.Windows.Forms.Label()
        Me.lblGood = New System.Windows.Forms.Label()
        Me.lblPoor = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblUsernameResult = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblSmoothnessResult = New System.Windows.Forms.Label()
        Me.lblNavigationResult = New System.Windows.Forms.Label()
        Me.lblInfoProvidedResult = New System.Windows.Forms.Label()
        Me.lblPaymentProcessResult = New System.Windows.Forms.Label()
        Me.CustFeedbackTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustFeedbackTableAdapter()
        Me.pnlBackColor.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRateOurService.SuspendLayout()
        Me.grbPaymentProcess.SuspendLayout()
        Me.grbInfoProvided.SuspendLayout()
        Me.grbNavigating.SuspendLayout()
        Me.grbSmoothness.SuspendLayout()
        CType(Me.CustFeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblFeedbackReview)
        Me.pnlBackColor.Location = New System.Drawing.Point(-3, -5)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(809, 78)
        Me.pnlBackColor.TabIndex = 3
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
        '
        'lblFeedbackReview
        '
        Me.lblFeedbackReview.AutoSize = True
        Me.lblFeedbackReview.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedbackReview.Location = New System.Drawing.Point(251, 28)
        Me.lblFeedbackReview.Name = "lblFeedbackReview"
        Me.lblFeedbackReview.Size = New System.Drawing.Size(227, 23)
        Me.lblFeedbackReview.TabIndex = 0
        Me.lblFeedbackReview.Text = "CUSTOMER FEEDBACK"
        '
        'grbRateOurService
        '
        Me.grbRateOurService.Controls.Add(Me.grbPaymentProcess)
        Me.grbRateOurService.Controls.Add(Me.grbInfoProvided)
        Me.grbRateOurService.Controls.Add(Me.grbNavigating)
        Me.grbRateOurService.Controls.Add(Me.grbSmoothness)
        Me.grbRateOurService.Controls.Add(Me.txtOtherFeedback)
        Me.grbRateOurService.Controls.Add(Me.lblOtherFeedback)
        Me.grbRateOurService.Controls.Add(Me.lblPaymentProcess)
        Me.grbRateOurService.Controls.Add(Me.lblInformationProvided)
        Me.grbRateOurService.Controls.Add(Me.lblEaseNavigating)
        Me.grbRateOurService.Controls.Add(Me.lblBookingSmoothness)
        Me.grbRateOurService.Location = New System.Drawing.Point(144, 113)
        Me.grbRateOurService.Name = "grbRateOurService"
        Me.grbRateOurService.Size = New System.Drawing.Size(513, 222)
        Me.grbRateOurService.TabIndex = 4
        Me.grbRateOurService.TabStop = False
        Me.grbRateOurService.Text = "Rate Our Service"
        '
        'grbPaymentProcess
        '
        Me.grbPaymentProcess.Controls.Add(Me.rbtPaymentExcellent)
        Me.grbPaymentProcess.Controls.Add(Me.rbtPaymentPoor)
        Me.grbPaymentProcess.Controls.Add(Me.rbtPaymentGood)
        Me.grbPaymentProcess.Location = New System.Drawing.Point(233, 128)
        Me.grbPaymentProcess.Name = "grbPaymentProcess"
        Me.grbPaymentProcess.Size = New System.Drawing.Size(258, 39)
        Me.grbPaymentProcess.TabIndex = 11
        Me.grbPaymentProcess.TabStop = False
        '
        'rbtPaymentExcellent
        '
        Me.rbtPaymentExcellent.AutoSize = True
        Me.rbtPaymentExcellent.Location = New System.Drawing.Point(215, 16)
        Me.rbtPaymentExcellent.Name = "rbtPaymentExcellent"
        Me.rbtPaymentExcellent.Size = New System.Drawing.Size(14, 13)
        Me.rbtPaymentExcellent.TabIndex = 8
        Me.rbtPaymentExcellent.TabStop = True
        Me.rbtPaymentExcellent.UseVisualStyleBackColor = True
        '
        'rbtPaymentPoor
        '
        Me.rbtPaymentPoor.AutoSize = True
        Me.rbtPaymentPoor.Location = New System.Drawing.Point(15, 16)
        Me.rbtPaymentPoor.Name = "rbtPaymentPoor"
        Me.rbtPaymentPoor.Size = New System.Drawing.Size(14, 13)
        Me.rbtPaymentPoor.TabIndex = 6
        Me.rbtPaymentPoor.TabStop = True
        Me.rbtPaymentPoor.UseVisualStyleBackColor = True
        '
        'rbtPaymentGood
        '
        Me.rbtPaymentGood.AutoSize = True
        Me.rbtPaymentGood.Location = New System.Drawing.Point(114, 16)
        Me.rbtPaymentGood.Name = "rbtPaymentGood"
        Me.rbtPaymentGood.Size = New System.Drawing.Size(14, 13)
        Me.rbtPaymentGood.TabIndex = 7
        Me.rbtPaymentGood.TabStop = True
        Me.rbtPaymentGood.UseVisualStyleBackColor = True
        '
        'grbInfoProvided
        '
        Me.grbInfoProvided.Controls.Add(Me.rbtInfoExcellent)
        Me.grbInfoProvided.Controls.Add(Me.rbtInfoPoor)
        Me.grbInfoProvided.Controls.Add(Me.rbtInfoGood)
        Me.grbInfoProvided.Location = New System.Drawing.Point(233, 93)
        Me.grbInfoProvided.Name = "grbInfoProvided"
        Me.grbInfoProvided.Size = New System.Drawing.Size(258, 39)
        Me.grbInfoProvided.TabIndex = 10
        Me.grbInfoProvided.TabStop = False
        '
        'rbtInfoExcellent
        '
        Me.rbtInfoExcellent.AutoSize = True
        Me.rbtInfoExcellent.Location = New System.Drawing.Point(215, 16)
        Me.rbtInfoExcellent.Name = "rbtInfoExcellent"
        Me.rbtInfoExcellent.Size = New System.Drawing.Size(14, 13)
        Me.rbtInfoExcellent.TabIndex = 8
        Me.rbtInfoExcellent.TabStop = True
        Me.rbtInfoExcellent.UseVisualStyleBackColor = True
        '
        'rbtInfoPoor
        '
        Me.rbtInfoPoor.AutoSize = True
        Me.rbtInfoPoor.Location = New System.Drawing.Point(15, 16)
        Me.rbtInfoPoor.Name = "rbtInfoPoor"
        Me.rbtInfoPoor.Size = New System.Drawing.Size(14, 13)
        Me.rbtInfoPoor.TabIndex = 6
        Me.rbtInfoPoor.TabStop = True
        Me.rbtInfoPoor.UseVisualStyleBackColor = True
        '
        'rbtInfoGood
        '
        Me.rbtInfoGood.AutoSize = True
        Me.rbtInfoGood.Location = New System.Drawing.Point(114, 16)
        Me.rbtInfoGood.Name = "rbtInfoGood"
        Me.rbtInfoGood.Size = New System.Drawing.Size(14, 13)
        Me.rbtInfoGood.TabIndex = 7
        Me.rbtInfoGood.TabStop = True
        Me.rbtInfoGood.UseVisualStyleBackColor = True
        '
        'grbNavigating
        '
        Me.grbNavigating.Controls.Add(Me.rbtEaseExcellent)
        Me.grbNavigating.Controls.Add(Me.rbtEasePoor)
        Me.grbNavigating.Controls.Add(Me.rbtEaseGood)
        Me.grbNavigating.Location = New System.Drawing.Point(233, 58)
        Me.grbNavigating.Name = "grbNavigating"
        Me.grbNavigating.Size = New System.Drawing.Size(258, 39)
        Me.grbNavigating.TabIndex = 9
        Me.grbNavigating.TabStop = False
        '
        'rbtEaseExcellent
        '
        Me.rbtEaseExcellent.AutoSize = True
        Me.rbtEaseExcellent.Location = New System.Drawing.Point(215, 16)
        Me.rbtEaseExcellent.Name = "rbtEaseExcellent"
        Me.rbtEaseExcellent.Size = New System.Drawing.Size(14, 13)
        Me.rbtEaseExcellent.TabIndex = 8
        Me.rbtEaseExcellent.TabStop = True
        Me.rbtEaseExcellent.UseVisualStyleBackColor = True
        '
        'rbtEasePoor
        '
        Me.rbtEasePoor.AutoSize = True
        Me.rbtEasePoor.Location = New System.Drawing.Point(15, 16)
        Me.rbtEasePoor.Name = "rbtEasePoor"
        Me.rbtEasePoor.Size = New System.Drawing.Size(14, 13)
        Me.rbtEasePoor.TabIndex = 6
        Me.rbtEasePoor.TabStop = True
        Me.rbtEasePoor.UseVisualStyleBackColor = True
        '
        'rbtEaseGood
        '
        Me.rbtEaseGood.AutoSize = True
        Me.rbtEaseGood.Location = New System.Drawing.Point(114, 16)
        Me.rbtEaseGood.Name = "rbtEaseGood"
        Me.rbtEaseGood.Size = New System.Drawing.Size(14, 13)
        Me.rbtEaseGood.TabIndex = 7
        Me.rbtEaseGood.TabStop = True
        Me.rbtEaseGood.UseVisualStyleBackColor = True
        '
        'grbSmoothness
        '
        Me.grbSmoothness.Controls.Add(Me.rbtBookingExcellent)
        Me.grbSmoothness.Controls.Add(Me.rbtBookingPoor)
        Me.grbSmoothness.Controls.Add(Me.rbtBookingGood)
        Me.grbSmoothness.Location = New System.Drawing.Point(233, 23)
        Me.grbSmoothness.Name = "grbSmoothness"
        Me.grbSmoothness.Size = New System.Drawing.Size(258, 39)
        Me.grbSmoothness.TabIndex = 8
        Me.grbSmoothness.TabStop = False
        '
        'rbtBookingExcellent
        '
        Me.rbtBookingExcellent.AutoSize = True
        Me.rbtBookingExcellent.Location = New System.Drawing.Point(215, 16)
        Me.rbtBookingExcellent.Name = "rbtBookingExcellent"
        Me.rbtBookingExcellent.Size = New System.Drawing.Size(14, 13)
        Me.rbtBookingExcellent.TabIndex = 8
        Me.rbtBookingExcellent.TabStop = True
        Me.rbtBookingExcellent.UseVisualStyleBackColor = True
        '
        'rbtBookingPoor
        '
        Me.rbtBookingPoor.AutoSize = True
        Me.rbtBookingPoor.Location = New System.Drawing.Point(15, 16)
        Me.rbtBookingPoor.Name = "rbtBookingPoor"
        Me.rbtBookingPoor.Size = New System.Drawing.Size(14, 13)
        Me.rbtBookingPoor.TabIndex = 6
        Me.rbtBookingPoor.TabStop = True
        Me.rbtBookingPoor.UseVisualStyleBackColor = True
        '
        'rbtBookingGood
        '
        Me.rbtBookingGood.AutoSize = True
        Me.rbtBookingGood.Location = New System.Drawing.Point(114, 16)
        Me.rbtBookingGood.Name = "rbtBookingGood"
        Me.rbtBookingGood.Size = New System.Drawing.Size(14, 13)
        Me.rbtBookingGood.TabIndex = 7
        Me.rbtBookingGood.TabStop = True
        Me.rbtBookingGood.UseVisualStyleBackColor = True
        '
        'txtOtherFeedback
        '
        Me.txtOtherFeedback.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "Others", True))
        Me.txtOtherFeedback.Location = New System.Drawing.Point(233, 180)
        Me.txtOtherFeedback.Name = "txtOtherFeedback"
        Me.txtOtherFeedback.Size = New System.Drawing.Size(258, 24)
        Me.txtOtherFeedback.TabIndex = 5
        '
        'CustFeedbackBindingSource
        '
        Me.CustFeedbackBindingSource.DataMember = "CustFeedback"
        Me.CustFeedbackBindingSource.DataSource = Me.OMC_TravelHopDataSet
        '
        'OMC_TravelHopDataSet
        '
        Me.OMC_TravelHopDataSet.DataSetName = "OMC_TravelHopDataSet"
        Me.OMC_TravelHopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblOtherFeedback
        '
        Me.lblOtherFeedback.AutoSize = True
        Me.lblOtherFeedback.Location = New System.Drawing.Point(28, 183)
        Me.lblOtherFeedback.Name = "lblOtherFeedback"
        Me.lblOtherFeedback.Size = New System.Drawing.Size(151, 15)
        Me.lblOtherFeedback.TabIndex = 4
        Me.lblOtherFeedback.Text = "Other Feedback [Optional]:"
        '
        'lblPaymentProcess
        '
        Me.lblPaymentProcess.AutoSize = True
        Me.lblPaymentProcess.Location = New System.Drawing.Point(28, 149)
        Me.lblPaymentProcess.Name = "lblPaymentProcess"
        Me.lblPaymentProcess.Size = New System.Drawing.Size(98, 15)
        Me.lblPaymentProcess.TabIndex = 3
        Me.lblPaymentProcess.Text = "Payment Process"
        '
        'lblInformationProvided
        '
        Me.lblInformationProvided.AutoSize = True
        Me.lblInformationProvided.Location = New System.Drawing.Point(28, 114)
        Me.lblInformationProvided.Name = "lblInformationProvided"
        Me.lblInformationProvided.Size = New System.Drawing.Size(121, 15)
        Me.lblInformationProvided.TabIndex = 2
        Me.lblInformationProvided.Text = "Information Provided"
        '
        'lblEaseNavigating
        '
        Me.lblEaseNavigating.AutoSize = True
        Me.lblEaseNavigating.Location = New System.Drawing.Point(28, 80)
        Me.lblEaseNavigating.Name = "lblEaseNavigating"
        Me.lblEaseNavigating.Size = New System.Drawing.Size(105, 15)
        Me.lblEaseNavigating.TabIndex = 1
        Me.lblEaseNavigating.Text = "Ease of Navigating"
        '
        'lblBookingSmoothness
        '
        Me.lblBookingSmoothness.AutoSize = True
        Me.lblBookingSmoothness.Location = New System.Drawing.Point(28, 47)
        Me.lblBookingSmoothness.Name = "lblBookingSmoothness"
        Me.lblBookingSmoothness.Size = New System.Drawing.Size(120, 15)
        Me.lblBookingSmoothness.TabIndex = 0
        Me.lblBookingSmoothness.Text = "Booking Smoothness"
        '
        'lblExcellent
        '
        Me.lblExcellent.AutoSize = True
        Me.lblExcellent.Location = New System.Drawing.Point(575, 101)
        Me.lblExcellent.Name = "lblExcellent"
        Me.lblExcellent.Size = New System.Drawing.Size(55, 15)
        Me.lblExcellent.TabIndex = 5
        Me.lblExcellent.Text = "Excellent"
        '
        'lblGood
        '
        Me.lblGood.AutoSize = True
        Me.lblGood.Location = New System.Drawing.Point(478, 101)
        Me.lblGood.Name = "lblGood"
        Me.lblGood.Size = New System.Drawing.Size(36, 15)
        Me.lblGood.TabIndex = 6
        Me.lblGood.Text = "Good"
        '
        'lblPoor
        '
        Me.lblPoor.AutoSize = True
        Me.lblPoor.Location = New System.Drawing.Point(384, 101)
        Me.lblPoor.Name = "lblPoor"
        Me.lblPoor.Size = New System.Drawing.Size(32, 15)
        Me.lblPoor.TabIndex = 7
        Me.lblPoor.Text = "Poor"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(431, 382)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(151, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(219, 382)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(151, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblUsernameResult
        '
        Me.lblUsernameResult.AutoSize = True
        Me.lblUsernameResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "UserName", True))
        Me.lblUsernameResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblUsernameResult.Location = New System.Drawing.Point(13, 101)
        Me.lblUsernameResult.Name = "lblUsernameResult"
        Me.lblUsernameResult.Size = New System.Drawing.Size(0, 15)
        Me.lblUsernameResult.TabIndex = 10
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "Service", True))
        Me.lblService.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblService.Location = New System.Drawing.Point(13, 136)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(0, 15)
        Me.lblService.TabIndex = 11
        '
        'lblSmoothnessResult
        '
        Me.lblSmoothnessResult.AutoSize = True
        Me.lblSmoothnessResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "Smoothness", True))
        Me.lblSmoothnessResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblSmoothnessResult.Location = New System.Drawing.Point(16, 160)
        Me.lblSmoothnessResult.Name = "lblSmoothnessResult"
        Me.lblSmoothnessResult.Size = New System.Drawing.Size(0, 15)
        Me.lblSmoothnessResult.TabIndex = 12
        '
        'lblNavigationResult
        '
        Me.lblNavigationResult.AutoSize = True
        Me.lblNavigationResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "Navigation", True))
        Me.lblNavigationResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblNavigationResult.Location = New System.Drawing.Point(19, 194)
        Me.lblNavigationResult.Name = "lblNavigationResult"
        Me.lblNavigationResult.Size = New System.Drawing.Size(0, 15)
        Me.lblNavigationResult.TabIndex = 13
        '
        'lblInfoProvidedResult
        '
        Me.lblInfoProvidedResult.AutoSize = True
        Me.lblInfoProvidedResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "InfoProvided", True))
        Me.lblInfoProvidedResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblInfoProvidedResult.Location = New System.Drawing.Point(16, 231)
        Me.lblInfoProvidedResult.Name = "lblInfoProvidedResult"
        Me.lblInfoProvidedResult.Size = New System.Drawing.Size(0, 15)
        Me.lblInfoProvidedResult.TabIndex = 14
        '
        'lblPaymentProcessResult
        '
        Me.lblPaymentProcessResult.AutoSize = True
        Me.lblPaymentProcessResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "PaymentProcess", True))
        Me.lblPaymentProcessResult.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblPaymentProcessResult.Location = New System.Drawing.Point(16, 266)
        Me.lblPaymentProcessResult.Name = "lblPaymentProcessResult"
        Me.lblPaymentProcessResult.Size = New System.Drawing.Size(0, 15)
        Me.lblPaymentProcessResult.TabIndex = 15
        '
        'CustFeedbackTableAdapter
        '
        Me.CustFeedbackTableAdapter.ClearBeforeFill = True
        '
        'FrmFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPaymentProcessResult)
        Me.Controls.Add(Me.lblInfoProvidedResult)
        Me.Controls.Add(Me.lblNavigationResult)
        Me.Controls.Add(Me.lblSmoothnessResult)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblUsernameResult)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblPoor)
        Me.Controls.Add(Me.lblGood)
        Me.Controls.Add(Me.lblExcellent)
        Me.Controls.Add(Me.grbRateOurService)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - Feedback & Review"
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRateOurService.ResumeLayout(False)
        Me.grbRateOurService.PerformLayout()
        Me.grbPaymentProcess.ResumeLayout(False)
        Me.grbPaymentProcess.PerformLayout()
        Me.grbInfoProvided.ResumeLayout(False)
        Me.grbInfoProvided.PerformLayout()
        Me.grbNavigating.ResumeLayout(False)
        Me.grbNavigating.PerformLayout()
        Me.grbSmoothness.ResumeLayout(False)
        Me.grbSmoothness.PerformLayout()
        CType(Me.CustFeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblFeedbackReview As Label
    Friend WithEvents grbRateOurService As GroupBox
    Friend WithEvents grbPaymentProcess As GroupBox
    Friend WithEvents rbtPaymentExcellent As RadioButton
    Friend WithEvents rbtPaymentPoor As RadioButton
    Friend WithEvents rbtPaymentGood As RadioButton
    Friend WithEvents grbInfoProvided As GroupBox
    Friend WithEvents rbtInfoExcellent As RadioButton
    Friend WithEvents rbtInfoPoor As RadioButton
    Friend WithEvents rbtInfoGood As RadioButton
    Friend WithEvents grbNavigating As GroupBox
    Friend WithEvents rbtEaseExcellent As RadioButton
    Friend WithEvents rbtEasePoor As RadioButton
    Friend WithEvents rbtEaseGood As RadioButton
    Friend WithEvents grbSmoothness As GroupBox
    Friend WithEvents rbtBookingExcellent As RadioButton
    Friend WithEvents rbtBookingPoor As RadioButton
    Friend WithEvents rbtBookingGood As RadioButton
    Friend WithEvents txtOtherFeedback As TextBox
    Friend WithEvents lblOtherFeedback As Label
    Friend WithEvents lblPaymentProcess As Label
    Friend WithEvents lblInformationProvided As Label
    Friend WithEvents lblEaseNavigating As Label
    Friend WithEvents lblBookingSmoothness As Label
    Friend WithEvents lblExcellent As Label
    Friend WithEvents lblGood As Label
    Friend WithEvents lblPoor As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblUsernameResult As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblSmoothnessResult As Label
    Friend WithEvents lblNavigationResult As Label
    Friend WithEvents lblInfoProvidedResult As Label
    Friend WithEvents lblPaymentProcessResult As Label
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents CustFeedbackBindingSource As BindingSource
    Friend WithEvents CustFeedbackTableAdapter As OMC_TravelHopDataSetTableAdapters.CustFeedbackTableAdapter
End Class
