<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHotelBooking
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
        Dim picSelangor As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelBooking))
        Me.lblHotelBooking = New System.Windows.Forms.Label()
        Me.grbState = New System.Windows.Forms.GroupBox()
        Me.rbtSelangor = New System.Windows.Forms.RadioButton()
        Me.rbtKualaLumpur = New System.Windows.Forms.RadioButton()
        Me.picKualaLumpur = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.btnNEXT = New System.Windows.Forms.Button()
        picSelangor = New System.Windows.Forms.PictureBox()
        CType(picSelangor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbState.SuspendLayout()
        CType(Me.picKualaLumpur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSelangor
        '
        picSelangor.Image = CType(resources.GetObject("picSelangor.Image"), System.Drawing.Image)
        picSelangor.Location = New System.Drawing.Point(186, 135)
        picSelangor.Margin = New System.Windows.Forms.Padding(2)
        picSelangor.Name = "picSelangor"
        picSelangor.Size = New System.Drawing.Size(118, 67)
        picSelangor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        picSelangor.TabIndex = 20
        picSelangor.TabStop = False
        '
        'lblHotelBooking
        '
        Me.lblHotelBooking.AutoSize = True
        Me.lblHotelBooking.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotelBooking.Location = New System.Drawing.Point(227, 31)
        Me.lblHotelBooking.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHotelBooking.Name = "lblHotelBooking"
        Me.lblHotelBooking.Size = New System.Drawing.Size(176, 23)
        Me.lblHotelBooking.TabIndex = 0
        Me.lblHotelBooking.Text = "HOTEL BOOKING"
        '
        'grbState
        '
        Me.grbState.BackColor = System.Drawing.Color.Thistle
        Me.grbState.Controls.Add(picSelangor)
        Me.grbState.Controls.Add(Me.rbtSelangor)
        Me.grbState.Controls.Add(Me.rbtKualaLumpur)
        Me.grbState.Controls.Add(Me.picKualaLumpur)
        Me.grbState.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbState.Location = New System.Drawing.Point(132, 94)
        Me.grbState.Margin = New System.Windows.Forms.Padding(2)
        Me.grbState.Name = "grbState"
        Me.grbState.Padding = New System.Windows.Forms.Padding(2)
        Me.grbState.Size = New System.Drawing.Size(384, 237)
        Me.grbState.TabIndex = 14
        Me.grbState.TabStop = False
        Me.grbState.Text = "Please Choose a State"
        '
        'rbtSelangor
        '
        Me.rbtSelangor.AutoSize = True
        Me.rbtSelangor.Font = New System.Drawing.Font("Javanese Text", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSelangor.Location = New System.Drawing.Point(28, 135)
        Me.rbtSelangor.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtSelangor.Name = "rbtSelangor"
        Me.rbtSelangor.Size = New System.Drawing.Size(88, 38)
        Me.rbtSelangor.TabIndex = 1
        Me.rbtSelangor.TabStop = True
        Me.rbtSelangor.Text = "Selangor"
        Me.rbtSelangor.UseVisualStyleBackColor = True
        '
        'rbtKualaLumpur
        '
        Me.rbtKualaLumpur.AutoSize = True
        Me.rbtKualaLumpur.Font = New System.Drawing.Font("Javanese Text", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtKualaLumpur.Location = New System.Drawing.Point(28, 39)
        Me.rbtKualaLumpur.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtKualaLumpur.Name = "rbtKualaLumpur"
        Me.rbtKualaLumpur.Size = New System.Drawing.Size(125, 38)
        Me.rbtKualaLumpur.TabIndex = 0
        Me.rbtKualaLumpur.TabStop = True
        Me.rbtKualaLumpur.Text = "Kuala Lumpur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbtKualaLumpur.UseVisualStyleBackColor = True
        '
        'picKualaLumpur
        '
        Me.picKualaLumpur.Image = CType(resources.GetObject("picKualaLumpur.Image"), System.Drawing.Image)
        Me.picKualaLumpur.Location = New System.Drawing.Point(186, 39)
        Me.picKualaLumpur.Margin = New System.Windows.Forms.Padding(2)
        Me.picKualaLumpur.Name = "picKualaLumpur"
        Me.picKualaLumpur.Size = New System.Drawing.Size(118, 67)
        Me.picKualaLumpur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKualaLumpur.TabIndex = 19
        Me.picKualaLumpur.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(416, 18)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(69, 47)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Controls.Add(Me.lblHotelBooking)
        Me.pnlBackColor.Location = New System.Drawing.Point(-12, -3)
        Me.pnlBackColor.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(647, 80)
        Me.pnlBackColor.TabIndex = 18
        '
        'btnEXIT
        '
        Me.btnEXIT.BackColor = System.Drawing.Color.White
        Me.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEXIT.Location = New System.Drawing.Point(132, 367)
        Me.btnEXIT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(118, 30)
        Me.btnEXIT.TabIndex = 17
        Me.btnEXIT.Text = "&EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = False
        '
        'btnNEXT
        '
        Me.btnNEXT.BackColor = System.Drawing.Color.White
        Me.btnNEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNEXT.Location = New System.Drawing.Point(398, 367)
        Me.btnNEXT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNEXT.Name = "btnNEXT"
        Me.btnNEXT.Size = New System.Drawing.Size(118, 30)
        Me.btnNEXT.TabIndex = 15
        Me.btnNEXT.Text = "&NEXT"
        Me.btnNEXT.UseVisualStyleBackColor = False
        '
        'frmHotelBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(632, 430)
        Me.Controls.Add(Me.grbState)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.btnNEXT)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmHotelBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Booking"
        CType(picSelangor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbState.ResumeLayout(False)
        Me.grbState.PerformLayout()
        CType(Me.picKualaLumpur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.pnlBackColor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHotelBooking As Label
    Friend WithEvents grbState As GroupBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents btnEXIT As Button
    Friend WithEvents btnNEXT As Button
    Friend WithEvents rbtSelangor As RadioButton
    Friend WithEvents rbtKualaLumpur As RadioButton
    Friend WithEvents picKualaLumpur As PictureBox
End Class
