﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanCalculator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMonthlyPayment = New System.Windows.Forms.RadioButton()
        Me.radDurationOfLoan = New System.Windows.Forms.RadioButton()
        Me.radInterestRate = New System.Windows.Forms.RadioButton()
        Me.radAmountOfLoan = New System.Windows.Forms.RadioButton()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMonthlyPayment)
        Me.GroupBox1.Controls.Add(Me.radDurationOfLoan)
        Me.GroupBox1.Controls.Add(Me.radInterestRate)
        Me.GroupBox1.Controls.Add(Me.radAmountOfLoan)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(98, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 465)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check Value To Calculate"
        '
        'radMonthlyPayment
        '
        Me.radMonthlyPayment.AutoSize = True
        Me.radMonthlyPayment.Location = New System.Drawing.Point(28, 366)
        Me.radMonthlyPayment.Name = "radMonthlyPayment"
        Me.radMonthlyPayment.Size = New System.Drawing.Size(240, 32)
        Me.radMonthlyPayment.TabIndex = 3
        Me.radMonthlyPayment.TabStop = True
        Me.radMonthlyPayment.Text = "Monthly Payment"
        Me.radMonthlyPayment.UseVisualStyleBackColor = True
        '
        'radDurationOfLoan
        '
        Me.radDurationOfLoan.AutoSize = True
        Me.radDurationOfLoan.Location = New System.Drawing.Point(28, 263)
        Me.radDurationOfLoan.Name = "radDurationOfLoan"
        Me.radDurationOfLoan.Size = New System.Drawing.Size(233, 32)
        Me.radDurationOfLoan.TabIndex = 2
        Me.radDurationOfLoan.TabStop = True
        Me.radDurationOfLoan.Text = "Duration of Loan"
        Me.radDurationOfLoan.UseVisualStyleBackColor = True
        '
        'radInterestRate
        '
        Me.radInterestRate.AutoSize = True
        Me.radInterestRate.Location = New System.Drawing.Point(28, 165)
        Me.radInterestRate.Name = "radInterestRate"
        Me.radInterestRate.Size = New System.Drawing.Size(193, 32)
        Me.radInterestRate.TabIndex = 1
        Me.radInterestRate.TabStop = True
        Me.radInterestRate.Text = "Interest Rate"
        Me.radInterestRate.UseVisualStyleBackColor = True
        '
        'radAmountOfLoan
        '
        Me.radAmountOfLoan.AutoSize = True
        Me.radAmountOfLoan.Location = New System.Drawing.Point(28, 68)
        Me.radAmountOfLoan.Name = "radAmountOfLoan"
        Me.radAmountOfLoan.Size = New System.Drawing.Size(225, 32)
        Me.radAmountOfLoan.TabIndex = 0
        Me.radAmountOfLoan.TabStop = True
        Me.radAmountOfLoan.Text = "Amount of Loan"
        Me.radAmountOfLoan.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(535, 178)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(331, 35)
        Me.txtAmount.TabIndex = 1
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(535, 275)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(331, 35)
        Me.txtInterestRate.TabIndex = 2
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(535, 373)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(331, 35)
        Me.txtDuration.TabIndex = 3
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(535, 476)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(331, 35)
        Me.txtMonthlyPayment.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(342, 636)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(287, 70)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Value"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClear.Location = New System.Drawing.Point(342, 749)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(287, 70)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear All Values"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'LoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 911)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoanCalculator"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMonthlyPayment As RadioButton
    Friend WithEvents radDurationOfLoan As RadioButton
    Friend WithEvents radInterestRate As RadioButton
    Friend WithEvents radAmountOfLoan As RadioButton
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtMonthlyPayment As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
