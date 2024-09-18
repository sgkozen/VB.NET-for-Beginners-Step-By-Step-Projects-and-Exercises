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
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPayments = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(536, 142)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(326, 39)
        Me.txtAmount.TabIndex = 0
        '
        'txtInterest
        '
        Me.txtInterest.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtInterest.Location = New System.Drawing.Point(536, 250)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(326, 39)
        Me.txtInterest.TabIndex = 1
        '
        'txtYears
        '
        Me.txtYears.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtYears.Location = New System.Drawing.Point(536, 359)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(326, 39)
        Me.txtYears.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(227, 467)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(592, 142)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Monthly Payments"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPayments
        '
        Me.txtPayments.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPayments.Location = New System.Drawing.Point(536, 735)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.Size = New System.Drawing.Size(326, 39)
        Me.txtPayments.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Amount of Loan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Interest Rate (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number Of Years"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 741)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Monthly Payment"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 938)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPayments)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtAmount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPayments As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
