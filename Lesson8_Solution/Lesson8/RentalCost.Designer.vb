<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalCost
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
        Me.lstRentalRates = New System.Windows.Forms.ListBox()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.btnDisplayRates = New System.Windows.Forms.Button()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstRentalRates
        '
        Me.lstRentalRates.FormattingEnabled = True
        Me.lstRentalRates.ItemHeight = 18
        Me.lstRentalRates.Location = New System.Drawing.Point(783, 72)
        Me.lstRentalRates.Name = "lstRentalRates"
        Me.lstRentalRates.Size = New System.Drawing.Size(584, 310)
        Me.lstRentalRates.TabIndex = 0
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.ItemHeight = 18
        Me.lstBill.Location = New System.Drawing.Point(783, 520)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(584, 310)
        Me.lstBill.TabIndex = 1
        '
        'btnDisplayRates
        '
        Me.btnDisplayRates.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDisplayRates.Location = New System.Drawing.Point(105, 72)
        Me.btnDisplayRates.Name = "btnDisplayRates"
        Me.btnDisplayRates.Size = New System.Drawing.Size(536, 178)
        Me.btnDisplayRates.TabIndex = 2
        Me.btnDisplayRates.Text = "Display Rental Rates"
        Me.btnDisplayRates.UseVisualStyleBackColor = True
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDisplayBill.Location = New System.Drawing.Point(105, 633)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(536, 183)
        Me.btnDisplayBill.TabIndex = 3
        Me.btnDisplayBill.Text = "Display Customer Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtItem.Location = New System.Drawing.Point(524, 317)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(150, 43)
        Me.txtItem.TabIndex = 4
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(524, 520)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(150, 43)
        Me.txtDuration.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Item (1, 2, or 3)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 549)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 36)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select Duration (H or F)"
        '
        'RentalCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1430, 917)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.btnDisplayRates)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.lstRentalRates)
        Me.Name = "RentalCost"
        Me.Text = "Rental Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRentalRates As ListBox
    Friend WithEvents lstBill As ListBox
    Friend WithEvents btnDisplayRates As Button
    Friend WithEvents btnDisplayBill As Button
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
