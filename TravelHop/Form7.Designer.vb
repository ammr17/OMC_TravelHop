<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmoothnessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavigationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoProvidedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentProcessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustFeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMC_TravelHopDataSet = New TravelHop.OMC_TravelHopDataSet()
        Me.pnlFeedbackInfo = New System.Windows.Forms.Panel()
        Me.lblPayResult = New System.Windows.Forms.Label()
        Me.lblInfoProvidedResult = New System.Windows.Forms.Label()
        Me.lblNavResult = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblInfoProv = New System.Windows.Forms.Label()
        Me.lblNavigate = New System.Windows.Forms.Label()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lbSmoothnesss = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.CustFeedbackTableAdapter = New TravelHop.OMC_TravelHopDataSetTableAdapters.CustFeedbackTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustFeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFeedbackInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.ServiceDataGridViewTextBoxColumn, Me.SmoothnessDataGridViewTextBoxColumn, Me.NavigationDataGridViewTextBoxColumn, Me.InfoProvidedDataGridViewTextBoxColumn, Me.PaymentProcessDataGridViewTextBoxColumn, Me.OthersDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustFeedbackBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 39)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(250, 287)
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
        'ServiceDataGridViewTextBoxColumn
        '
        Me.ServiceDataGridViewTextBoxColumn.DataPropertyName = "Service"
        Me.ServiceDataGridViewTextBoxColumn.HeaderText = "Service"
        Me.ServiceDataGridViewTextBoxColumn.Name = "ServiceDataGridViewTextBoxColumn"
        '
        'SmoothnessDataGridViewTextBoxColumn
        '
        Me.SmoothnessDataGridViewTextBoxColumn.DataPropertyName = "Smoothness"
        Me.SmoothnessDataGridViewTextBoxColumn.HeaderText = "Smoothness"
        Me.SmoothnessDataGridViewTextBoxColumn.Name = "SmoothnessDataGridViewTextBoxColumn"
        '
        'NavigationDataGridViewTextBoxColumn
        '
        Me.NavigationDataGridViewTextBoxColumn.DataPropertyName = "Navigation"
        Me.NavigationDataGridViewTextBoxColumn.HeaderText = "Navigation"
        Me.NavigationDataGridViewTextBoxColumn.Name = "NavigationDataGridViewTextBoxColumn"
        '
        'InfoProvidedDataGridViewTextBoxColumn
        '
        Me.InfoProvidedDataGridViewTextBoxColumn.DataPropertyName = "InfoProvided"
        Me.InfoProvidedDataGridViewTextBoxColumn.HeaderText = "InfoProvided"
        Me.InfoProvidedDataGridViewTextBoxColumn.Name = "InfoProvidedDataGridViewTextBoxColumn"
        '
        'PaymentProcessDataGridViewTextBoxColumn
        '
        Me.PaymentProcessDataGridViewTextBoxColumn.DataPropertyName = "PaymentProcess"
        Me.PaymentProcessDataGridViewTextBoxColumn.HeaderText = "PaymentProcess"
        Me.PaymentProcessDataGridViewTextBoxColumn.Name = "PaymentProcessDataGridViewTextBoxColumn"
        '
        'OthersDataGridViewTextBoxColumn
        '
        Me.OthersDataGridViewTextBoxColumn.DataPropertyName = "Others"
        Me.OthersDataGridViewTextBoxColumn.HeaderText = "Others"
        Me.OthersDataGridViewTextBoxColumn.Name = "OthersDataGridViewTextBoxColumn"
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
        'pnlFeedbackInfo
        '
        Me.pnlFeedbackInfo.BackColor = System.Drawing.Color.Linen
        Me.pnlFeedbackInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFeedbackInfo.Controls.Add(Me.lblPayResult)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblInfoProvidedResult)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblNavResult)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblDestination)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblPayment)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblInfoProv)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblNavigate)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblFeedback)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblPhoneNumber)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblInfo)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblUsername)
        Me.pnlFeedbackInfo.Controls.Add(Me.lblName)
        Me.pnlFeedbackInfo.Controls.Add(Me.lbSmoothnesss)
        Me.pnlFeedbackInfo.Location = New System.Drawing.Point(309, 42)
        Me.pnlFeedbackInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlFeedbackInfo.Name = "pnlFeedbackInfo"
        Me.pnlFeedbackInfo.Size = New System.Drawing.Size(270, 288)
        Me.pnlFeedbackInfo.TabIndex = 1
        '
        'lblPayResult
        '
        Me.lblPayResult.BackColor = System.Drawing.Color.Linen
        Me.lblPayResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "PaymentProcess", True))
        Me.lblPayResult.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayResult.Location = New System.Drawing.Point(130, 255)
        Me.lblPayResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPayResult.Name = "lblPayResult"
        Me.lblPayResult.Size = New System.Drawing.Size(119, 21)
        Me.lblPayResult.TabIndex = 37
        Me.lblPayResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoProvidedResult
        '
        Me.lblInfoProvidedResult.BackColor = System.Drawing.Color.Linen
        Me.lblInfoProvidedResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "InfoProvided", True))
        Me.lblInfoProvidedResult.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoProvidedResult.Location = New System.Drawing.Point(130, 211)
        Me.lblInfoProvidedResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoProvidedResult.Name = "lblInfoProvidedResult"
        Me.lblInfoProvidedResult.Size = New System.Drawing.Size(119, 21)
        Me.lblInfoProvidedResult.TabIndex = 36
        Me.lblInfoProvidedResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNavResult
        '
        Me.lblNavResult.BackColor = System.Drawing.Color.Linen
        Me.lblNavResult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "Navigation", True))
        Me.lblNavResult.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNavResult.Location = New System.Drawing.Point(130, 164)
        Me.lblNavResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNavResult.Name = "lblNavResult"
        Me.lblNavResult.Size = New System.Drawing.Size(119, 21)
        Me.lblNavResult.TabIndex = 35
        Me.lblNavResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDestination
        '
        Me.lblDestination.BackColor = System.Drawing.Color.Linen
        Me.lblDestination.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "Smoothness", True))
        Me.lblDestination.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(130, 117)
        Me.lblDestination.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(119, 21)
        Me.lblDestination.TabIndex = 34
        Me.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(19, 246)
        Me.lblPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(56, 30)
        Me.lblPayment.TabIndex = 33
        Me.lblPayment.Text = "Payment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Process :"
        '
        'lblInfoProv
        '
        Me.lblInfoProv.AutoSize = True
        Me.lblInfoProv.Location = New System.Drawing.Point(19, 202)
        Me.lblInfoProv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfoProv.Name = "lblInfoProv"
        Me.lblInfoProv.Size = New System.Drawing.Size(74, 30)
        Me.lblInfoProv.TabIndex = 32
        Me.lblInfoProv.Text = "Information " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Provided:"
        '
        'lblNavigate
        '
        Me.lblNavigate.AutoSize = True
        Me.lblNavigate.Location = New System.Drawing.Point(19, 155)
        Me.lblNavigate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNavigate.Name = "lblNavigate"
        Me.lblNavigate.Size = New System.Drawing.Size(70, 30)
        Me.lblNavigate.TabIndex = 31
        Me.lblNavigate.Text = "Ease of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Navigation :"
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.BackColor = System.Drawing.Color.Linen
        Me.lblFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(19, 72)
        Me.lblFeedback.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(82, 15)
        Me.lblFeedback.TabIndex = 30
        Me.lblFeedback.Text = "FEEDBACK "
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Linen
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(130, 72)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(119, 21)
        Me.lblPhoneNumber.TabIndex = 29
        Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(19, 13)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(143, 15)
        Me.lblInfo.TabIndex = 27
        Me.lblInfo.Text = "USER INFORMATION"
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Linen
        Me.lblUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustFeedbackBindingSource, "UserName", True))
        Me.lblUsername.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(130, 39)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 21)
        Me.lblUsername.TabIndex = 28
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(19, 42)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 15)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "Username :"
        '
        'lbSmoothnesss
        '
        Me.lbSmoothnesss.AutoSize = True
        Me.lbSmoothnesss.Location = New System.Drawing.Point(19, 107)
        Me.lbSmoothnesss.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSmoothnesss.Name = "lbSmoothnesss"
        Me.lbSmoothnesss.Size = New System.Drawing.Size(80, 30)
        Me.lbSmoothnesss.TabIndex = 26
        Me.lbSmoothnesss.Text = "Booking " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Smoothness :"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Thistle
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(553, 13)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'CustFeedbackTableAdapter
        '
        Me.CustFeedbackTableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(606, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlFeedbackInfo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustFeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMC_TravelHopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFeedbackInfo.ResumeLayout(False)
        Me.pnlFeedbackInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnlFeedbackInfo As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SmoothnessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NavigationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InfoProvidedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentProcessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lbSmoothnesss As Label
    Friend WithEvents lblFeedback As Label
    Friend WithEvents lblNavigate As Label
    Friend WithEvents lblInfoProv As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblPayResult As Label
    Friend WithEvents lblInfoProvidedResult As Label
    Friend WithEvents lblNavResult As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents OMC_TravelHopDataSet As OMC_TravelHopDataSet
    Friend WithEvents CustFeedbackBindingSource As BindingSource
    Friend WithEvents CustFeedbackTableAdapter As OMC_TravelHopDataSetTableAdapters.CustFeedbackTableAdapter
End Class
