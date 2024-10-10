<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPC_Barcode
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
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnAddReceipt = New System.Windows.Forms.Button()
        Me.btnDisplayReceipt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbUpcCode = New System.Windows.Forms.MaskedTextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNewCustomer.Location = New System.Drawing.Point(98, 61)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(310, 79)
        Me.btnNewCustomer.TabIndex = 0
        Me.btnNewCustomer.Text = "New Customer"
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnAddReceipt
        '
        Me.btnAddReceipt.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAddReceipt.Location = New System.Drawing.Point(611, 61)
        Me.btnAddReceipt.Name = "btnAddReceipt"
        Me.btnAddReceipt.Size = New System.Drawing.Size(310, 79)
        Me.btnAddReceipt.TabIndex = 1
        Me.btnAddReceipt.Text = "Add to Receipt"
        Me.btnAddReceipt.UseVisualStyleBackColor = True
        '
        'btnDisplayReceipt
        '
        Me.btnDisplayReceipt.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDisplayReceipt.Location = New System.Drawing.Point(611, 231)
        Me.btnDisplayReceipt.Name = "btnDisplayReceipt"
        Me.btnDisplayReceipt.Size = New System.Drawing.Size(310, 79)
        Me.btnDisplayReceipt.TabIndex = 2
        Me.btnDisplayReceipt.Text = "Display Receipt"
        Me.btnDisplayReceipt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UPC"
        '
        'mtbUpcCode
        '
        Me.mtbUpcCode.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.mtbUpcCode.Location = New System.Drawing.Point(158, 253)
        Me.mtbUpcCode.Mask = "000000000000"
        Me.mtbUpcCode.Name = "mtbUpcCode"
        Me.mtbUpcCode.Size = New System.Drawing.Size(279, 35)
        Me.mtbUpcCode.TabIndex = 4
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 18
        Me.lstOutput.Location = New System.Drawing.Point(78, 374)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(843, 436)
        Me.lstOutput.TabIndex = 5
        '
        'UPC_Barcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 869)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.mtbUpcCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplayReceipt)
        Me.Controls.Add(Me.btnAddReceipt)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Name = "UPC_Barcode"
        Me.Text = "UPC Barcode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewCustomer As Button
    Friend WithEvents btnAddReceipt As Button
    Friend WithEvents btnDisplayReceipt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbUpcCode As MaskedTextBox
    Friend WithEvents lstOutput As ListBox
End Class
