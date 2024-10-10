<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotMachine
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picSlot2 = New System.Windows.Forms.PictureBox()
        Me.picSlot1 = New System.Windows.Forms.PictureBox()
        Me.picSlot0 = New System.Windows.Forms.PictureBox()
        Me.picChoice1 = New System.Windows.Forms.PictureBox()
        Me.picChoice0 = New System.Windows.Forms.PictureBox()
        Me.picChoice2 = New System.Windows.Forms.PictureBox()
        Me.picChoice3 = New System.Windows.Forms.PictureBox()
        Me.txtBankRoll = New System.Windows.Forms.TextBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.timerSpin = New System.Windows.Forms.Timer(Me.components)
        Me.timerDone = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bankroll"
        '
        'picSlot2
        '
        Me.picSlot2.Location = New System.Drawing.Point(533, 194)
        Me.picSlot2.MaximumSize = New System.Drawing.Size(117, 134)
        Me.picSlot2.MinimumSize = New System.Drawing.Size(117, 134)
        Me.picSlot2.Name = "picSlot2"
        Me.picSlot2.Size = New System.Drawing.Size(117, 134)
        Me.picSlot2.TabIndex = 1
        Me.picSlot2.TabStop = False
        '
        'picSlot1
        '
        Me.picSlot1.Location = New System.Drawing.Point(309, 194)
        Me.picSlot1.MaximumSize = New System.Drawing.Size(117, 134)
        Me.picSlot1.MinimumSize = New System.Drawing.Size(117, 134)
        Me.picSlot1.Name = "picSlot1"
        Me.picSlot1.Size = New System.Drawing.Size(117, 134)
        Me.picSlot1.TabIndex = 2
        Me.picSlot1.TabStop = False
        '
        'picSlot0
        '
        Me.picSlot0.Location = New System.Drawing.Point(86, 194)
        Me.picSlot0.MaximumSize = New System.Drawing.Size(117, 134)
        Me.picSlot0.MinimumSize = New System.Drawing.Size(117, 134)
        Me.picSlot0.Name = "picSlot0"
        Me.picSlot0.Size = New System.Drawing.Size(117, 134)
        Me.picSlot0.TabIndex = 3
        Me.picSlot0.TabStop = False
        '
        'picChoice1
        '
        Me.picChoice1.Image = Global.SlotMachine.My.Resources.Resources.ball
        Me.picChoice1.Location = New System.Drawing.Point(77, 442)
        Me.picChoice1.MaximumSize = New System.Drawing.Size(27, 28)
        Me.picChoice1.MinimumSize = New System.Drawing.Size(27, 28)
        Me.picChoice1.Name = "picChoice1"
        Me.picChoice1.Size = New System.Drawing.Size(27, 28)
        Me.picChoice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice1.TabIndex = 4
        Me.picChoice1.TabStop = False
        Me.picChoice1.Visible = False
        '
        'picChoice0
        '
        Me.picChoice0.Image = Global.SlotMachine.My.Resources.Resources.arrow
        Me.picChoice0.Location = New System.Drawing.Point(25, 442)
        Me.picChoice0.MaximumSize = New System.Drawing.Size(27, 28)
        Me.picChoice0.MinimumSize = New System.Drawing.Size(27, 28)
        Me.picChoice0.Name = "picChoice0"
        Me.picChoice0.Size = New System.Drawing.Size(27, 28)
        Me.picChoice0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice0.TabIndex = 5
        Me.picChoice0.TabStop = False
        Me.picChoice0.Visible = False
        '
        'picChoice2
        '
        Me.picChoice2.Image = Global.SlotMachine.My.Resources.Resources.bullseye
        Me.picChoice2.Location = New System.Drawing.Point(123, 442)
        Me.picChoice2.MaximumSize = New System.Drawing.Size(27, 28)
        Me.picChoice2.MinimumSize = New System.Drawing.Size(27, 28)
        Me.picChoice2.Name = "picChoice2"
        Me.picChoice2.Size = New System.Drawing.Size(27, 28)
        Me.picChoice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice2.TabIndex = 6
        Me.picChoice2.TabStop = False
        Me.picChoice2.Visible = False
        '
        'picChoice3
        '
        Me.picChoice3.Image = Global.SlotMachine.My.Resources.Resources.jackpot
        Me.picChoice3.Location = New System.Drawing.Point(176, 442)
        Me.picChoice3.MaximumSize = New System.Drawing.Size(27, 28)
        Me.picChoice3.MinimumSize = New System.Drawing.Size(27, 28)
        Me.picChoice3.Name = "picChoice3"
        Me.picChoice3.Size = New System.Drawing.Size(27, 28)
        Me.picChoice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice3.TabIndex = 7
        Me.picChoice3.TabStop = False
        Me.picChoice3.Visible = False
        '
        'txtBankRoll
        '
        Me.txtBankRoll.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtBankRoll.Location = New System.Drawing.Point(309, 80)
        Me.txtBankRoll.Name = "txtBankRoll"
        Me.txtBankRoll.Size = New System.Drawing.Size(150, 43)
        Me.txtBankRoll.TabIndex = 8
        Me.txtBankRoll.Text = "100"
        Me.txtBankRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSpin
        '
        Me.btnSpin.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSpin.Location = New System.Drawing.Point(252, 361)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(264, 53)
        Me.btnSpin.TabIndex = 9
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnExit.Location = New System.Drawing.Point(309, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 62)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Location = New System.Drawing.Point(509, 36)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(58, 18)
        Me.lblBank.TabIndex = 11
        Me.lblBank.Text = "Label2"
        '
        'timerSpin
        '
        '
        'timerDone
        '
        Me.timerDone.Interval = 2000
        '
        'SlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 549)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.txtBankRoll)
        Me.Controls.Add(Me.picChoice3)
        Me.Controls.Add(Me.picChoice2)
        Me.Controls.Add(Me.picChoice0)
        Me.Controls.Add(Me.picChoice1)
        Me.Controls.Add(Me.picSlot0)
        Me.Controls.Add(Me.picSlot1)
        Me.Controls.Add(Me.picSlot2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SlotMachine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picSlot2 As PictureBox
    Friend WithEvents picSlot1 As PictureBox
    Friend WithEvents picSlot0 As PictureBox
    Friend WithEvents picChoice1 As PictureBox
    Friend WithEvents picChoice0 As PictureBox
    Friend WithEvents picChoice2 As PictureBox
    Friend WithEvents picChoice3 As PictureBox
    Friend WithEvents txtBankRoll As TextBox
    Friend WithEvents btnSpin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblBank As Label
    Friend WithEvents timerSpin As Timer
    Friend WithEvents timerDone As Timer
End Class
