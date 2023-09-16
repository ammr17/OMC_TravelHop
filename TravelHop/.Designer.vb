<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewOrExistingUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewOrExistingUser))
        Me.grbNewOrExist = New System.Windows.Forms.GroupBox()
        Me.rbtExistingUser = New System.Windows.Forms.RadioButton()
        Me.rbtNewUser = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grbNewOrExist.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbNewOrExist
        '
        Me.grbNewOrExist.Controls.Add(Me.rbtExistingUser)
        Me.grbNewOrExist.Controls.Add(Me.rbtNewUser)
        Me.grbNewOrExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grbNewOrExist.Location = New System.Drawing.Point(256, 185)
        Me.grbNewOrExist.Name = "grbNewOrExist"
        Me.grbNewOrExist.Size = New System.Drawing.Size(277, 164)
        Me.grbNewOrExist.TabIndex = 3
        Me.grbNewOrExist.TabStop = False
        Me.grbNewOrExist.Text = "New / Existing User"
        '
        'rbtExistingUser
        '
        Me.rbtExistingUser.AutoSize = True
        Me.rbtExistingUser.Location = New System.Drawing.Point(85, 104)
        Me.rbtExistingUser.Name = "rbtExistingUser"
        Me.rbtExistingUser.Size = New System.Drawing.Size(138, 24)
        Me.rbtExistingUser.TabIndex = 2
        Me.rbtExistingUser.TabStop = True
        Me.rbtExistingUser.Text = "Existing User"
        Me.rbtExistingUser.UseVisualStyleBackColor = True
        '
        'rbtNewUser
        '
        Me.rbtNewUser.AutoSize = True
        Me.rbtNewUser.Location = New System.Drawing.Point(85, 50)
        Me.rbtNewUser.Name = "rbtNewUser"
        Me.rbtNewUser.Size = New System.Drawing.Size(110, 24)
        Me.rbtNewUser.TabIndex = 1
        Me.rbtNewUser.TabStop = True
        Me.rbtNewUser.Text = "New User"
        Me.rbtNewUser.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(446, 387)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(87, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(303, 15)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(185, 124)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Location = New System.Drawing.Point(-3, -5)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(879, 160)
        Me.pnlBackColor.TabIndex = 4
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(256, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(87, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "&BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FrmNewOrExistingUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grbNewOrExist)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNewOrExistingUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop - User"
        Me.grbNewOrExist.ResumeLayout(False)
        Me.grbNewOrExist.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbNewOrExist As GroupBox
    Friend WithEvents rbtExistingUser As RadioButton
    Friend WithEvents rbtNewUser As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents btnBack As Button
End Class
