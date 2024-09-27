<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Poker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Poker))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtDenomination1 = New System.Windows.Forms.TextBox()
        Me.txtDenomination2 = New System.Windows.Forms.TextBox()
        Me.txtDenomination3 = New System.Windows.Forms.TextBox()
        Me.txtDenomination4 = New System.Windows.Forms.TextBox()
        Me.txtDenomination5 = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.mtbSuit1 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit4 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit3 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSuit5 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RichTextBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, -3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(665, 134)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'txtDenomination1
        '
        Me.txtDenomination1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDenomination1.Location = New System.Drawing.Point(192, 185)
        Me.txtDenomination1.Name = "txtDenomination1"
        Me.txtDenomination1.Size = New System.Drawing.Size(150, 29)
        Me.txtDenomination1.TabIndex = 2
        Me.txtDenomination1.Text = "1"
        '
        'txtDenomination2
        '
        Me.txtDenomination2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDenomination2.Location = New System.Drawing.Point(192, 269)
        Me.txtDenomination2.Name = "txtDenomination2"
        Me.txtDenomination2.Size = New System.Drawing.Size(150, 29)
        Me.txtDenomination2.TabIndex = 3
        '
        'txtDenomination3
        '
        Me.txtDenomination3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDenomination3.Location = New System.Drawing.Point(192, 358)
        Me.txtDenomination3.Name = "txtDenomination3"
        Me.txtDenomination3.Size = New System.Drawing.Size(150, 29)
        Me.txtDenomination3.TabIndex = 4
        '
        'txtDenomination4
        '
        Me.txtDenomination4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDenomination4.Location = New System.Drawing.Point(192, 455)
        Me.txtDenomination4.Name = "txtDenomination4"
        Me.txtDenomination4.Size = New System.Drawing.Size(150, 29)
        Me.txtDenomination4.TabIndex = 5
        '
        'txtDenomination5
        '
        Me.txtDenomination5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDenomination5.Location = New System.Drawing.Point(192, 555)
        Me.txtDenomination5.Name = "txtDenomination5"
        Me.txtDenomination5.Size = New System.Drawing.Size(150, 29)
        Me.txtDenomination5.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(153, 637)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(395, 52)
        Me.btnDisplay.TabIndex = 12
        Me.btnDisplay.Text = "Display Type of Hand"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Card#1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Card#2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Card#3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Card#4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 555)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Card#5"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(153, 738)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(395, 25)
        Me.txtOutput.TabIndex = 18
        '
        'mtbSuit1
        '
        Me.mtbSuit1.Location = New System.Drawing.Point(448, 189)
        Me.mtbSuit1.Name = "mtbSuit1"
        Me.mtbSuit1.Size = New System.Drawing.Size(100, 25)
        Me.mtbSuit1.TabIndex = 19
        '
        'mtbSuit2
        '
        Me.mtbSuit2.Location = New System.Drawing.Point(448, 277)
        Me.mtbSuit2.Name = "mtbSuit2"
        Me.mtbSuit2.Size = New System.Drawing.Size(100, 25)
        Me.mtbSuit2.TabIndex = 20
        '
        'mtbSuit4
        '
        Me.mtbSuit4.Location = New System.Drawing.Point(448, 455)
        Me.mtbSuit4.Name = "mtbSuit4"
        Me.mtbSuit4.Size = New System.Drawing.Size(100, 25)
        Me.mtbSuit4.TabIndex = 21
        '
        'mtbSuit3
        '
        Me.mtbSuit3.Location = New System.Drawing.Point(448, 358)
        Me.mtbSuit3.Name = "mtbSuit3"
        Me.mtbSuit3.Size = New System.Drawing.Size(100, 25)
        Me.mtbSuit3.TabIndex = 22
        '
        'mtbSuit5
        '
        Me.mtbSuit5.Location = New System.Drawing.Point(448, 559)
        Me.mtbSuit5.Name = "mtbSuit5"
        Me.mtbSuit5.Size = New System.Drawing.Size(100, 25)
        Me.mtbSuit5.TabIndex = 23
        '
        'Poker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 816)
        Me.Controls.Add(Me.mtbSuit5)
        Me.Controls.Add(Me.mtbSuit3)
        Me.Controls.Add(Me.mtbSuit4)
        Me.Controls.Add(Me.mtbSuit2)
        Me.Controls.Add(Me.mtbSuit1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtDenomination5)
        Me.Controls.Add(Me.txtDenomination4)
        Me.Controls.Add(Me.txtDenomination3)
        Me.Controls.Add(Me.txtDenomination2)
        Me.Controls.Add(Me.txtDenomination1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Poker"
        Me.Text = "Poker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtDenomination1 As TextBox
    Friend WithEvents txtDenomination2 As TextBox
    Friend WithEvents txtDenomination3 As TextBox
    Friend WithEvents txtDenomination4 As TextBox
    Friend WithEvents txtDenomination5 As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents mtbSuit1 As MaskedTextBox
    Friend WithEvents mtbSuit2 As MaskedTextBox
    Friend WithEvents mtbSuit4 As MaskedTextBox
    Friend WithEvents mtbSuit3 As MaskedTextBox
    Friend WithEvents mtbSuit5 As MaskedTextBox
End Class
