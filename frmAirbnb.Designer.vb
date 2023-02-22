<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirbnb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirbnb))
        Me.picAirbnb = New System.Windows.Forms.PictureBox()
        Me.lblAirbnb = New System.Windows.Forms.Label()
        Me.lblCostPerNight = New System.Windows.Forms.Label()
        Me.lblNightsLocator = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblCostLocator = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirbnb
        '
        Me.picAirbnb.Image = CType(resources.GetObject("picAirbnb.Image"), System.Drawing.Image)
        Me.picAirbnb.Location = New System.Drawing.Point(0, 0)
        Me.picAirbnb.Name = "picAirbnb"
        Me.picAirbnb.Size = New System.Drawing.Size(392, 450)
        Me.picAirbnb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirbnb.TabIndex = 0
        Me.picAirbnb.TabStop = False
        '
        'lblAirbnb
        '
        Me.lblAirbnb.AutoSize = True
        Me.lblAirbnb.Font = New System.Drawing.Font("Cooper Black", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirbnb.Location = New System.Drawing.Point(406, 9)
        Me.lblAirbnb.Name = "lblAirbnb"
        Me.lblAirbnb.Size = New System.Drawing.Size(387, 50)
        Me.lblAirbnb.TabIndex = 1
        Me.lblAirbnb.Text = "Orlando AirBnB"
        '
        'lblCostPerNight
        '
        Me.lblCostPerNight.AutoSize = True
        Me.lblCostPerNight.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerNight.Location = New System.Drawing.Point(469, 59)
        Me.lblCostPerNight.Name = "lblCostPerNight"
        Me.lblCostPerNight.Size = New System.Drawing.Size(274, 27)
        Me.lblCostPerNight.TabIndex = 2
        Me.lblCostPerNight.Text = "Only $79.00 per night"
        '
        'lblNightsLocator
        '
        Me.lblNightsLocator.AutoSize = True
        Me.lblNightsLocator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNightsLocator.Location = New System.Drawing.Point(410, 142)
        Me.lblNightsLocator.Name = "lblNightsLocator"
        Me.lblNightsLocator.Size = New System.Drawing.Size(219, 29)
        Me.lblNightsLocator.TabIndex = 3
        Me.lblNightsLocator.Text = "Number of nights:"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(643, 142)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 26)
        Me.txtNights.TabIndex = 4
        Me.txtNights.Text = "placeholder"
        '
        'lblCostLocator
        '
        Me.lblCostLocator.AutoSize = True
        Me.lblCostLocator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostLocator.Location = New System.Drawing.Point(410, 197)
        Me.lblCostLocator.Name = "lblCostLocator"
        Me.lblCostLocator.Size = New System.Drawing.Size(155, 29)
        Me.lblCostLocator.TabIndex = 5
        Me.lblCostLocator.Text = "Cost of stay:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(639, 204)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(91, 20)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "placeholder"
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(415, 300)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(108, 33)
        Me.btnCost.TabIndex = 7
        Me.btnCost.Text = "Display cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(542, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 33)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(669, 300)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 33)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAirbnb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCostLocator)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.lblNightsLocator)
        Me.Controls.Add(Me.lblCostPerNight)
        Me.Controls.Add(Me.lblAirbnb)
        Me.Controls.Add(Me.picAirbnb)
        Me.Name = "frmAirbnb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirbnb As PictureBox
    Friend WithEvents lblAirbnb As Label
    Friend WithEvents lblCostPerNight As Label
    Friend WithEvents lblNightsLocator As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents lblCostLocator As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
