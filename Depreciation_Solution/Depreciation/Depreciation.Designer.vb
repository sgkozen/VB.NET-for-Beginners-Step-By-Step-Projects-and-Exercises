<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Depreciation
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
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtNumYears = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnStraight = New System.Windows.Forms.Button()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(156, 46)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(150, 31)
        Me.txtDesc.TabIndex = 0
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCost.Location = New System.Drawing.Point(714, 49)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(150, 31)
        Me.txtCost.TabIndex = 1
        '
        'txtNumYears
        '
        Me.txtNumYears.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNumYears.Location = New System.Drawing.Point(714, 165)
        Me.txtNumYears.Name = "txtNumYears"
        Me.txtNumYears.Size = New System.Drawing.Size(150, 31)
        Me.txtNumYears.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtYear.Location = New System.Drawing.Point(156, 165)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(150, 31)
        Me.txtYear.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(594, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cost:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 71)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Year of Purchase:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(591, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 112)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estimated life of item (years):"
        '
        'btnStraight
        '
        Me.btnStraight.Location = New System.Drawing.Point(242, 259)
        Me.btnStraight.Name = "btnStraight"
        Me.btnStraight.Size = New System.Drawing.Size(472, 64)
        Me.btnStraight.TabIndex = 8
        Me.btnStraight.Text = "Straight-Line Method"
        Me.btnStraight.UseVisualStyleBackColor = True
        '
        'btnDouble
        '
        Me.btnDouble.Location = New System.Drawing.Point(242, 367)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(472, 58)
        Me.btnDouble.TabIndex = 9
        Me.btnDouble.Text = "Double-Declining -Balance Method"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 18
        Me.lstOutput.Location = New System.Drawing.Point(36, 452)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(924, 454)
        Me.lstOutput.TabIndex = 10
        '
        'Depreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 943)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.btnStraight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtNumYears)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtDesc)
        Me.Name = "Depreciation"
        Me.Text = "Depreciation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtNumYears As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnStraight As Button
    Friend WithEvents btnDouble As Button
    Friend WithEvents lstOutput As ListBox
End Class
