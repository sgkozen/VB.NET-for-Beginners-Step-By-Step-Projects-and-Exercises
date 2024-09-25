<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lesson26_Palindrome
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
        Me.txtword = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtword
        '
        Me.txtword.Location = New System.Drawing.Point(114, 115)
        Me.txtword.Name = "txtword"
        Me.txtword.Size = New System.Drawing.Size(739, 25)
        Me.txtword.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(114, 568)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(761, 31)
        Me.txtOutput.TabIndex = 2
        '
        'btnDetermine
        '
        Me.btnDetermine.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDetermine.Location = New System.Drawing.Point(242, 261)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(496, 119)
        Me.btnDetermine.TabIndex = 3
        Me.btnDetermine.Text = "Determine if Palindrome"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the word or phrase."
        '
        'Lesson26_Palindrome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 763)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtword)
        Me.Name = "Lesson26_Palindrome"
        Me.text = "Palindrome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtword As TextBox
    Private WithEvents txtOutput As TextBox
    Friend WithEvents btnDetermine As Button
    Friend WithEvents Label1 As Label
End Class
