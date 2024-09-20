<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StickGame
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPileStatus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStart.Location = New System.Drawing.Point(689, 143)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(256, 115)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start New Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(994, 143)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(158, 115)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOne.Location = New System.Drawing.Point(559, 341)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(178, 55)
        Me.btnOne.TabIndex = 2
        Me.btnOne.Text = "One Stick"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(767, 341)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(178, 55)
        Me.btnTwo.TabIndex = 3
        Me.btnTwo.Text = "Two Sticks"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnThree.Location = New System.Drawing.Point(974, 341)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(178, 55)
        Me.btnThree.TabIndex = 4
        Me.btnThree.Text = "Three Sticks"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 70)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "How Many Sticks Would You LIck to Pickup?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPileStatus
        '
        Me.txtPileStatus.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPileStatus.Location = New System.Drawing.Point(615, 469)
        Me.txtPileStatus.Name = "txtPileStatus"
        Me.txtPileStatus.Size = New System.Drawing.Size(385, 37)
        Me.txtPileStatus.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 443)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 73)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Current Status of the pile"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StickGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 637)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPileStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "StickGame"
        Me.Text = "Stick Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPileStatus As TextBox
    Friend WithEvents Label2 As Label
End Class
