<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitConversion
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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtOriginal = New System.Windows.Forms.TextBox()
        Me.txtDesired = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lstUnits = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLength.Location = New System.Drawing.Point(1002, 69)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(150, 37)
        Me.txtLength.TabIndex = 0
        '
        'txtOriginal
        '
        Me.txtOriginal.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOriginal.Location = New System.Drawing.Point(1002, 222)
        Me.txtOriginal.Name = "txtOriginal"
        Me.txtOriginal.Size = New System.Drawing.Size(150, 37)
        Me.txtOriginal.TabIndex = 1
        '
        'txtDesired
        '
        Me.txtDesired.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDesired.Location = New System.Drawing.Point(1002, 376)
        Me.txtDesired.Name = "txtDesired"
        Me.txtDesired.Size = New System.Drawing.Size(150, 37)
        Me.txtDesired.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(993, 765)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(150, 37)
        Me.txtOutput.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(441, 510)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(702, 105)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lstUnits
        '
        Me.lstUnits.FormattingEnabled = True
        Me.lstUnits.ItemHeight = 18
        Me.lstUnits.Items.AddRange(New Object() {"1. inch", "2. fathom", "3. foot", "4. furlong", "5. kilometer", "6. meter", "7. mile", "8. rod", "9. yard", " "})
        Me.lstUnits.Location = New System.Drawing.Point(68, 54)
        Me.lstUnits.Name = "lstUnits"
        Me.lstUnits.Size = New System.Drawing.Size(305, 616)
        Me.lstUnits.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(642, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Length to Convert"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(634, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Original Units (1-9)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(632, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Desired Units (1-9)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(683, 772)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Desired Length"
        '
        'UnitConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 887)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstUnits)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtDesired)
        Me.Controls.Add(Me.txtOriginal)
        Me.Controls.Add(Me.txtLength)
        Me.Name = "UnitConversion"
        Me.Text = "Unit Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtOriginal As TextBox
    Friend WithEvents txtDesired As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents lstUnits As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
