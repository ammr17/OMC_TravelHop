<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeMeridien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeMeridien))
        Me.grbRoomType = New System.Windows.Forms.GroupBox()
        Me.rbtQueen = New System.Windows.Forms.RadioButton()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.rbtSingle = New System.Windows.Forms.RadioButton()
        Me.rbtKing = New System.Windows.Forms.RadioButton()
        Me.rbtSingleQueen = New System.Windows.Forms.RadioButton()
        Me.grbBreakfast = New System.Windows.Forms.GroupBox()
        Me.lblBreakfast = New System.Windows.Forms.Label()
        Me.rbtNo = New System.Windows.Forms.RadioButton()
        Me.rbtYes = New System.Windows.Forms.RadioButton()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblAmountResult = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPerNight = New System.Windows.Forms.Label()
        Me.lblFacilities = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblWifi = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblPool = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.grbRoomType.SuspendLayout()
        Me.grbBreakfast.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbRoomType
        '
        Me.grbRoomType.BackColor = System.Drawing.Color.OldLace
        Me.grbRoomType.Controls.Add(Me.rbtQueen)
        Me.grbRoomType.Controls.Add(Me.lblRoom)
        Me.grbRoomType.Controls.Add(Me.rbtSingle)
        Me.grbRoomType.Controls.Add(Me.rbtKing)
        Me.grbRoomType.Controls.Add(Me.rbtSingleQueen)
        Me.grbRoomType.Location = New System.Drawing.Point(711, 140)
        Me.grbRoomType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbRoomType.Name = "grbRoomType"
        Me.grbRoomType.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbRoomType.Size = New System.Drawing.Size(271, 187)
        Me.grbRoomType.TabIndex = 46
        Me.grbRoomType.TabStop = False
        '
        'rbtQueen
        '
        Me.rbtQueen.AutoSize = True
        Me.rbtQueen.Location = New System.Drawing.Point(9, 89)
        Me.rbtQueen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtQueen.Name = "rbtQueen"
        Me.rbtQueen.Size = New System.Drawing.Size(92, 19)
        Me.rbtQueen.TabIndex = 9
        Me.rbtQueen.TabStop = True
        Me.rbtQueen.Text = "1 Queen Bed"
        Me.rbtQueen.UseVisualStyleBackColor = True
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(7, 15)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(158, 15)
        Me.lblRoom.TabIndex = 7
        Me.lblRoom.Text = "Please choose type of room:"
        '
        'rbtSingle
        '
        Me.rbtSingle.AutoSize = True
        Me.rbtSingle.Location = New System.Drawing.Point(9, 49)
        Me.rbtSingle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtSingle.Name = "rbtSingle"
        Me.rbtSingle.Size = New System.Drawing.Size(89, 19)
        Me.rbtSingle.TabIndex = 8
        Me.rbtSingle.TabStop = True
        Me.rbtSingle.Text = "2 Single Bed"
        Me.rbtSingle.UseVisualStyleBackColor = True
        '
        'rbtKing
        '
        Me.rbtKing.AutoSize = True
        Me.rbtKing.Location = New System.Drawing.Point(9, 124)
        Me.rbtKing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtKing.Name = "rbtKing"
        Me.rbtKing.Size = New System.Drawing.Size(81, 19)
        Me.rbtKing.TabIndex = 10
        Me.rbtKing.TabStop = True
        Me.rbtKing.Text = "1 King Bed"
        Me.rbtKing.UseVisualStyleBackColor = True
        '
        'rbtSingleQueen
        '
        Me.rbtSingleQueen.AutoSize = True
        Me.rbtSingleQueen.Location = New System.Drawing.Point(11, 162)
        Me.rbtSingleQueen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtSingleQueen.Name = "rbtSingleQueen"
        Me.rbtSingleQueen.Size = New System.Drawing.Size(162, 19)
        Me.rbtSingleQueen.TabIndex = 11
        Me.rbtSingleQueen.TabStop = True
        Me.rbtSingleQueen.Text = "1 Single Bed, 1 Queen Bed"
        Me.rbtSingleQueen.UseVisualStyleBackColor = True
        '
        'grbBreakfast
        '
        Me.grbBreakfast.BackColor = System.Drawing.Color.OldLace
        Me.grbBreakfast.Controls.Add(Me.lblBreakfast)
        Me.grbBreakfast.Controls.Add(Me.rbtNo)
        Me.grbBreakfast.Controls.Add(Me.rbtYes)
        Me.grbBreakfast.Location = New System.Drawing.Point(711, 350)
        Me.grbBreakfast.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbBreakfast.Name = "grbBreakfast"
        Me.grbBreakfast.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbBreakfast.Size = New System.Drawing.Size(271, 98)
        Me.grbBreakfast.TabIndex = 45
        Me.grbBreakfast.TabStop = False
        '
        'lblBreakfast
        '
        Me.lblBreakfast.AutoSize = True
        Me.lblBreakfast.Location = New System.Drawing.Point(5, 17)
        Me.lblBreakfast.Name = "lblBreakfast"
        Me.lblBreakfast.Size = New System.Drawing.Size(187, 15)
        Me.lblBreakfast.TabIndex = 23
        Me.lblBreakfast.Text = "Do you want to include breakfast?"
        '
        'rbtNo
        '
        Me.rbtNo.AutoSize = True
        Me.rbtNo.Location = New System.Drawing.Point(7, 68)
        Me.rbtNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtNo.Name = "rbtNo"
        Me.rbtNo.Size = New System.Drawing.Size(40, 19)
        Me.rbtNo.TabIndex = 25
        Me.rbtNo.TabStop = True
        Me.rbtNo.Text = "No"
        Me.rbtNo.UseVisualStyleBackColor = True
        '
        'rbtYes
        '
        Me.rbtYes.AutoSize = True
        Me.rbtYes.Location = New System.Drawing.Point(7, 43)
        Me.rbtYes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtYes.Name = "rbtYes"
        Me.rbtYes.Size = New System.Drawing.Size(44, 19)
        Me.rbtYes.TabIndex = 24
        Me.rbtYes.TabStop = True
        Me.rbtYes.Text = "Yes"
        Me.rbtYes.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(713, 508)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(210, 15)
        Me.lblMessage.TabIndex = 44
        Me.lblMessage.Text = "*Price has included taxes and charges"
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.White
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(721, 550)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(97, 26)
        Me.btnBook.TabIndex = 43
        Me.btnBook.Text = "&BOOK"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(856, 550)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 26)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(399, 373)
        Me.MonthCalendar2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.ShowTodayCircle = False
        Me.MonthCalendar2.TabIndex = 41
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(395, 350)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(26, 13)
        Me.lblTo.TabIndex = 40
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(395, 110)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(38, 13)
        Me.lblFrom.TabIndex = 39
        Me.lblFrom.Text = "From:"
        '
        'lblAmountResult
        '
        Me.lblAmountResult.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAmountResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountResult.Location = New System.Drawing.Point(796, 490)
        Me.lblAmountResult.Name = "lblAmountResult"
        Me.lblAmountResult.Size = New System.Drawing.Size(89, 18)
        Me.lblAmountResult.TabIndex = 38
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(713, 490)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(53, 13)
        Me.lblAmount.TabIndex = 37
        Me.lblAmount.Text = "Amount:"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Thistle
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Location = New System.Drawing.Point(395, 21)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(580, 38)
        Me.lblAddress.TabIndex = 33
        Me.lblAddress.Text = "Address: 2 Jalan Stesen Sentral, Kuala Lumpur Sentral, KL Sentral Train Station, " &
    "50470 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kuala Lumpur"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(399, 140)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 32
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(207, 175)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(155, 257)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(20, 436)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(340, 142)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 17)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(340, 153)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 175)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 257)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lblPerNight
        '
        Me.lblPerNight.AutoSize = True
        Me.lblPerNight.Location = New System.Drawing.Point(891, 490)
        Me.lblPerNight.Name = "lblPerNight"
        Me.lblPerNight.Size = New System.Drawing.Size(41, 15)
        Me.lblPerNight.TabIndex = 48
        Me.lblPerNight.Text = "/night"
        '
        'lblFacilities
        '
        Me.lblFacilities.AutoSize = True
        Me.lblFacilities.BackColor = System.Drawing.Color.Transparent
        Me.lblFacilities.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacilities.Location = New System.Drawing.Point(730, 84)
        Me.lblFacilities.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFacilities.Name = "lblFacilities"
        Me.lblFacilities.Size = New System.Drawing.Size(155, 15)
        Me.lblFacilities.TabIndex = 107
        Me.lblFacilities.Text = "Facilities for Disabled Guest"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(697, 74)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 110
        Me.PictureBox7.TabStop = False
        '
        'lblWifi
        '
        Me.lblWifi.AutoSize = True
        Me.lblWifi.BackColor = System.Drawing.Color.Transparent
        Me.lblWifi.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWifi.Location = New System.Drawing.Point(594, 84)
        Me.lblWifi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWifi.Name = "lblWifi"
        Me.lblWifi.Size = New System.Drawing.Size(54, 15)
        Me.lblWifi.TabIndex = 106
        Me.lblWifi.Text = "Free WiFi"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(561, 74)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 109
        Me.PictureBox6.TabStop = False
        '
        'lblPool
        '
        Me.lblPool.AutoSize = True
        Me.lblPool.BackColor = System.Drawing.Color.Transparent
        Me.lblPool.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPool.Location = New System.Drawing.Point(425, 84)
        Me.lblPool.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPool.Name = "lblPool"
        Me.lblPool.Size = New System.Drawing.Size(89, 15)
        Me.lblPool.TabIndex = 105
        Me.lblPool.Text = "Swimming Pool" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(394, 74)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 108
        Me.PictureBox5.TabStop = False
        '
        'FrmLeMeridien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1003, 593)
        Me.Controls.Add(Me.lblFacilities)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.lblWifi)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.lblPool)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblPerNight)
        Me.Controls.Add(Me.grbRoomType)
        Me.Controls.Add(Me.grbBreakfast)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblAmountResult)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmLeMeridien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Meridien Kuala Lumpur"
        Me.grbRoomType.ResumeLayout(False)
        Me.grbRoomType.PerformLayout()
        Me.grbBreakfast.ResumeLayout(False)
        Me.grbBreakfast.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbRoomType As GroupBox
    Friend WithEvents rbtQueen As RadioButton
    Friend WithEvents lblRoom As Label
    Friend WithEvents rbtSingle As RadioButton
    Friend WithEvents rbtKing As RadioButton
    Friend WithEvents rbtSingleQueen As RadioButton
    Friend WithEvents grbBreakfast As GroupBox
    Friend WithEvents lblBreakfast As Label
    Friend WithEvents rbtNo As RadioButton
    Friend WithEvents rbtYes As RadioButton
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblAmountResult As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPerNight As Label
    Friend WithEvents lblFacilities As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblWifi As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblPool As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
