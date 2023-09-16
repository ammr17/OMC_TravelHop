<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBangiResort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBangiResort))
        Me.grbRoomType = New System.Windows.Forms.GroupBox()
        Me.rbtQueen = New System.Windows.Forms.RadioButton()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.rbtSingle = New System.Windows.Forms.RadioButton()
        Me.rbtQueenSofa = New System.Windows.Forms.RadioButton()
        Me.rbt2Queen = New System.Windows.Forms.RadioButton()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.lblBreakfast = New System.Windows.Forms.Label()
        Me.rbtNo = New System.Windows.Forms.RadioButton()
        Me.rbtYes = New System.Windows.Forms.RadioButton()
        Me.grbBreakfast = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblAmountResult = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblBar = New System.Windows.Forms.Label()
        Me.lblWiFi = New System.Windows.Forms.Label()
        Me.lblPool = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblPerNight = New System.Windows.Forms.Label()
        Me.grbRoomType.SuspendLayout()
        Me.grbBreakfast.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbRoomType
        '
        Me.grbRoomType.BackColor = System.Drawing.Color.OldLace
        Me.grbRoomType.Controls.Add(Me.rbtQueen)
        Me.grbRoomType.Controls.Add(Me.lblRoom)
        Me.grbRoomType.Controls.Add(Me.rbtSingle)
        Me.grbRoomType.Controls.Add(Me.rbtQueenSofa)
        Me.grbRoomType.Controls.Add(Me.rbt2Queen)
        Me.grbRoomType.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbRoomType.Location = New System.Drawing.Point(614, 125)
        Me.grbRoomType.Margin = New System.Windows.Forms.Padding(2)
        Me.grbRoomType.Name = "grbRoomType"
        Me.grbRoomType.Padding = New System.Windows.Forms.Padding(2)
        Me.grbRoomType.Size = New System.Drawing.Size(237, 182)
        Me.grbRoomType.TabIndex = 100
        Me.grbRoomType.TabStop = False
        '
        'rbtQueen
        '
        Me.rbtQueen.AutoSize = True
        Me.rbtQueen.Location = New System.Drawing.Point(8, 83)
        Me.rbtQueen.Margin = New System.Windows.Forms.Padding(2)
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
        Me.lblRoom.Location = New System.Drawing.Point(6, 14)
        Me.lblRoom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(158, 15)
        Me.lblRoom.TabIndex = 7
        Me.lblRoom.Text = "Please choose type of room:"
        '
        'rbtSingle
        '
        Me.rbtSingle.AutoSize = True
        Me.rbtSingle.Location = New System.Drawing.Point(8, 46)
        Me.rbtSingle.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtSingle.Name = "rbtSingle"
        Me.rbtSingle.Size = New System.Drawing.Size(89, 19)
        Me.rbtSingle.TabIndex = 8
        Me.rbtSingle.TabStop = True
        Me.rbtSingle.Text = "2 Single Bed"
        Me.rbtSingle.UseVisualStyleBackColor = True
        '
        'rbtQueenSofa
        '
        Me.rbtQueenSofa.AutoSize = True
        Me.rbtQueenSofa.Location = New System.Drawing.Point(8, 117)
        Me.rbtQueenSofa.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtQueenSofa.Name = "rbtQueenSofa"
        Me.rbtQueenSofa.Size = New System.Drawing.Size(153, 19)
        Me.rbtQueenSofa.TabIndex = 10
        Me.rbtQueenSofa.TabStop = True
        Me.rbtQueenSofa.Text = "1 Queen Bed, 1 Sofa Bed"
        Me.rbtQueenSofa.UseVisualStyleBackColor = True
        '
        'rbt2Queen
        '
        Me.rbt2Queen.AutoSize = True
        Me.rbt2Queen.Location = New System.Drawing.Point(9, 152)
        Me.rbt2Queen.Margin = New System.Windows.Forms.Padding(2)
        Me.rbt2Queen.Name = "rbt2Queen"
        Me.rbt2Queen.Size = New System.Drawing.Size(92, 19)
        Me.rbt2Queen.TabIndex = 11
        Me.rbt2Queen.TabStop = True
        Me.rbt2Queen.Text = "2 Queen Bed"
        Me.rbt2Queen.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(615, 470)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(210, 15)
        Me.lblMessage.TabIndex = 98
        Me.lblMessage.Text = "*Price has included taxes and charges"
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.White
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Location = New System.Drawing.Point(623, 509)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(85, 24)
        Me.btnBook.TabIndex = 97
        Me.btnBook.Text = "&BOOK"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'lblBreakfast
        '
        Me.lblBreakfast.AutoSize = True
        Me.lblBreakfast.Location = New System.Drawing.Point(5, 16)
        Me.lblBreakfast.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBreakfast.Name = "lblBreakfast"
        Me.lblBreakfast.Size = New System.Drawing.Size(187, 15)
        Me.lblBreakfast.TabIndex = 23
        Me.lblBreakfast.Text = "Do you want to include breakfast?"
        '
        'rbtNo
        '
        Me.rbtNo.AutoSize = True
        Me.rbtNo.Location = New System.Drawing.Point(6, 63)
        Me.rbtNo.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rbtYes.Location = New System.Drawing.Point(6, 40)
        Me.rbtYes.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtYes.Name = "rbtYes"
        Me.rbtYes.Size = New System.Drawing.Size(44, 19)
        Me.rbtYes.TabIndex = 24
        Me.rbtYes.TabStop = True
        Me.rbtYes.Text = "Yes"
        Me.rbtYes.UseVisualStyleBackColor = True
        '
        'grbBreakfast
        '
        Me.grbBreakfast.BackColor = System.Drawing.Color.OldLace
        Me.grbBreakfast.Controls.Add(Me.lblBreakfast)
        Me.grbBreakfast.Controls.Add(Me.rbtNo)
        Me.grbBreakfast.Controls.Add(Me.rbtYes)
        Me.grbBreakfast.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBreakfast.Location = New System.Drawing.Point(614, 321)
        Me.grbBreakfast.Margin = New System.Windows.Forms.Padding(2)
        Me.grbBreakfast.Name = "grbBreakfast"
        Me.grbBreakfast.Padding = New System.Windows.Forms.Padding(2)
        Me.grbBreakfast.Size = New System.Drawing.Size(237, 92)
        Me.grbBreakfast.TabIndex = 99
        Me.grbBreakfast.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(741, 509)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 24)
        Me.btnCancel.TabIndex = 96
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Location = New System.Drawing.Point(340, 343)
        Me.MonthCalendar2.Margin = New System.Windows.Forms.Padding(7)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.ShowTodayCircle = False
        Me.MonthCalendar2.TabIndex = 95
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(337, 321)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(24, 15)
        Me.lblTo.TabIndex = 94
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(337, 96)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(39, 15)
        Me.lblFrom.TabIndex = 93
        Me.lblFrom.Text = "From:"
        '
        'lblAmountResult
        '
        Me.lblAmountResult.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAmountResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountResult.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountResult.Location = New System.Drawing.Point(687, 452)
        Me.lblAmountResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmountResult.Name = "lblAmountResult"
        Me.lblAmountResult.Size = New System.Drawing.Size(78, 17)
        Me.lblAmountResult.TabIndex = 92
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(615, 452)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(54, 15)
        Me.lblAmount.TabIndex = 91
        Me.lblAmount.Text = "Amount:"
        '
        'lblBar
        '
        Me.lblBar.AutoSize = True
        Me.lblBar.BackColor = System.Drawing.Color.Transparent
        Me.lblBar.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBar.Location = New System.Drawing.Point(673, 67)
        Me.lblBar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBar.Name = "lblBar"
        Me.lblBar.Size = New System.Drawing.Size(24, 15)
        Me.lblBar.TabIndex = 90
        Me.lblBar.Text = "Bar"
        '
        'lblWiFi
        '
        Me.lblWiFi.AutoSize = True
        Me.lblWiFi.BackColor = System.Drawing.Color.Transparent
        Me.lblWiFi.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWiFi.Location = New System.Drawing.Point(537, 67)
        Me.lblWiFi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWiFi.Name = "lblWiFi"
        Me.lblWiFi.Size = New System.Drawing.Size(54, 15)
        Me.lblWiFi.TabIndex = 89
        Me.lblWiFi.Text = "Free WiFi"
        '
        'lblPool
        '
        Me.lblPool.AutoSize = True
        Me.lblPool.BackColor = System.Drawing.Color.Transparent
        Me.lblPool.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPool.Location = New System.Drawing.Point(368, 67)
        Me.lblPool.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPool.Name = "lblPool"
        Me.lblPool.Size = New System.Drawing.Size(89, 15)
        Me.lblPool.TabIndex = 88
        Me.lblPool.Text = "Swimming Pool" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Thistle
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(337, 13)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(341, 17)
        Me.lblAddress.TabIndex = 87
        Me.lblAddress.Text = "Address: Off Persiaran Bandar, 43650 Bangi, Selangor"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(340, 125)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(7)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 86
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 402)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(298, 133)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(298, 143)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 84
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 157)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 241)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(158, 157)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(149, 241)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 101
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(337, 57)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 102
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(504, 57)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 103
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(640, 57)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 104
        Me.PictureBox7.TabStop = False
        '
        'lblPerNight
        '
        Me.lblPerNight.AutoSize = True
        Me.lblPerNight.Location = New System.Drawing.Point(770, 452)
        Me.lblPerNight.Name = "lblPerNight"
        Me.lblPerNight.Size = New System.Drawing.Size(41, 15)
        Me.lblPerNight.TabIndex = 105
        Me.lblPerNight.Text = "/night"
        '
        'frmBangiResort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(869, 539)
        Me.Controls.Add(Me.lblPerNight)
        Me.Controls.Add(Me.lblBar)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.lblWiFi)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.lblPool)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.grbRoomType)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.grbBreakfast)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblAmountResult)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBangiResort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bangi Resort Hotel"
        Me.grbRoomType.ResumeLayout(False)
        Me.grbRoomType.PerformLayout()
        Me.grbBreakfast.ResumeLayout(False)
        Me.grbBreakfast.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbRoomType As GroupBox
    Friend WithEvents rbtQueen As RadioButton
    Friend WithEvents lblRoom As Label
    Friend WithEvents rbtSingle As RadioButton
    Friend WithEvents rbtQueenSofa As RadioButton
    Friend WithEvents rbt2Queen As RadioButton
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents lblBreakfast As Label
    Friend WithEvents rbtNo As RadioButton
    Friend WithEvents rbtYes As RadioButton
    Friend WithEvents grbBreakfast As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblAmountResult As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblBar As Label
    Friend WithEvents lblWiFi As Label
    Friend WithEvents lblPool As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblPerNight As Label
End Class
