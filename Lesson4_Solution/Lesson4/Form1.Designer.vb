<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt25 = New System.Windows.Forms.Label()
        Me.txt10 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(400, 138)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(365, 25)
        Me.txtAmount.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(400, 317)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(208, 25)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(400, 376)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(208, 25)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(400, 447)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(208, 25)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(400, 529)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(208, 25)
        Me.TextBox5.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(369, 618)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(273, 158)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Change"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter Amount"
        '
        'txt25
        '
        Me.txt25.AutoSize = True
        Me.txt25.Location = New System.Drawing.Point(270, 322)
        Me.txt25.Name = "txt25"
        Me.txt25.Size = New System.Drawing.Size(72, 18)
        Me.txt25.TabIndex = 7
        Me.txt25.Text = "25 cents"
        '
        'txt10
        '
        Me.txt10.AutoSize = True
        Me.txt10.Location = New System.Drawing.Point(270, 383)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(72, 18)
        Me.txt10.TabIndex = 8
        Me.txt10.Text = "10 cents"
        '
        'txt5
        '
        Me.txt5.AutoSize = True
        Me.txt5.Location = New System.Drawing.Point(270, 450)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(63, 18)
        Me.txt5.TabIndex = 9
        Me.txt5.Text = "5 cents"
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(270, 529)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(55, 18)
        Me.txt1.TabIndex = 10
        Me.txt1.Text = "1 cent"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 938)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt10)
        Me.Controls.Add(Me.txt25)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtAmount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmount As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt25 As Label
    Friend WithEvents txt10 As Label
    Friend WithEvents txt5 As Label
    Friend WithEvents txt1 As Label
End Class
