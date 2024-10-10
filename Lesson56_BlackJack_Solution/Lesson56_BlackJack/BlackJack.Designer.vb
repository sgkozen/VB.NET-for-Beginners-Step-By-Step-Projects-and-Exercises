<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackJack
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
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.lstPlayer = New System.Windows.Forms.ListBox()
        Me.lstDealer = New System.Windows.Forms.ListBox()
        Me.txtDealer = New System.Windows.Forms.TextBox()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPlayer
        '
        Me.txtPlayer.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPlayer.Location = New System.Drawing.Point(217, 495)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(225, 43)
        Me.txtPlayer.TabIndex = 0
        '
        'lstPlayer
        '
        Me.lstPlayer.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstPlayer.FormattingEnabled = True
        Me.lstPlayer.ItemHeight = 36
        Me.lstPlayer.Location = New System.Drawing.Point(38, 26)
        Me.lstPlayer.Name = "lstPlayer"
        Me.lstPlayer.Size = New System.Drawing.Size(568, 400)
        Me.lstPlayer.TabIndex = 1
        '
        'lstDealer
        '
        Me.lstDealer.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstDealer.FormattingEnabled = True
        Me.lstDealer.ItemHeight = 36
        Me.lstDealer.Location = New System.Drawing.Point(659, 26)
        Me.lstDealer.Name = "lstDealer"
        Me.lstDealer.Size = New System.Drawing.Size(568, 400)
        Me.lstDealer.TabIndex = 2
        '
        'txtDealer
        '
        Me.txtDealer.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDealer.Location = New System.Drawing.Point(1002, 495)
        Me.txtDealer.Name = "txtDealer"
        Me.txtDealer.Size = New System.Drawing.Size(225, 43)
        Me.txtDealer.TabIndex = 3
        '
        'btnHit
        '
        Me.btnHit.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnHit.Location = New System.Drawing.Point(38, 583)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(317, 84)
        Me.btnHit.TabIndex = 4
        Me.btnHit.Text = "Hit Me"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(439, 583)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(398, 84)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "New Hand"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnHold
        '
        Me.btnHold.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnHold.Location = New System.Drawing.Point(910, 583)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(317, 84)
        Me.btnHold.TabIndex = 6
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Player Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(824, 505)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dealer Total:"
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(91, 719)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(1081, 29)
        Me.txtOutput.TabIndex = 9
        '
        'BlackJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 774)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.txtDealer)
        Me.Controls.Add(Me.lstDealer)
        Me.Controls.Add(Me.lstPlayer)
        Me.Controls.Add(Me.txtPlayer)
        Me.Name = "BlackJack"
        Me.Text = "Black Jack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlayer As TextBox
    Friend WithEvents lstPlayer As ListBox
    Friend WithEvents lstDealer As ListBox
    Friend WithEvents txtDealer As TextBox
    Friend WithEvents btnHit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnHold As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOutput As TextBox
End Class
