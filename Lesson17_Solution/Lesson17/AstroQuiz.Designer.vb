<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AstroQuiz
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
        Me.lblQues = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQues
        '
        Me.lblQues.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblQues.Location = New System.Drawing.Point(35, 44)
        Me.lblQues.Name = "lblQues"
        Me.lblQues.Size = New System.Drawing.Size(675, 174)
        Me.lblQues.TabIndex = 0
        Me.lblQues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "True (T) or False (F)"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(450, 261)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(70, 37)
        Me.txtAnswer.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(72, 424)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(271, 74)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Question"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(403, 424)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(271, 73)
        Me.btnAnswer.TabIndex = 5
        Me.btnAnswer.Text = "Record Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'AstroQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 582)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQues)
        Me.Name = "AstroQuiz"
        Me.Text = "Astronomy Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQues As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAnswer As Button
End Class
