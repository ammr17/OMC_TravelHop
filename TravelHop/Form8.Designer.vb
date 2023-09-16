<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBackColor = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnAgency = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(168, 14)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(139, 105)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'pnlBackColor
        '
        Me.pnlBackColor.BackColor = System.Drawing.Color.OldLace
        Me.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBackColor.Controls.Add(Me.btnExit)
        Me.pnlBackColor.Controls.Add(Me.picLogo)
        Me.pnlBackColor.Location = New System.Drawing.Point(-2, -3)
        Me.pnlBackColor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlBackColor.Name = "pnlBackColor"
        Me.pnlBackColor.Size = New System.Drawing.Size(470, 131)
        Me.pnlBackColor.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Thistle
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(435, 13)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(22, 20)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.White
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Location = New System.Drawing.Point(117, 186)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(99, 83)
        Me.btnCustomer.TabIndex = 6
        Me.btnCustomer.Text = "&CUSTOMER"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.White
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Location = New System.Drawing.Point(252, 186)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(99, 83)
        Me.btnAdmin.TabIndex = 7
        Me.btnAdmin.Text = "A&DMIN"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnAgency
        '
        Me.btnAgency.BackColor = System.Drawing.Color.White
        Me.btnAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgency.Location = New System.Drawing.Point(186, 287)
        Me.btnAgency.Name = "btnAgency"
        Me.btnAgency.Size = New System.Drawing.Size(99, 83)
        Me.btnAgency.TabIndex = 8
        Me.btnAgency.Text = "A&GENCY"
        Me.btnAgency.UseVisualStyleBackColor = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(467, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAgency)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.pnlBackColor)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TravelHop"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackColor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlBackColor As Panel
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnAgency As Button
    Friend WithEvents btnExit As Button
End Class
