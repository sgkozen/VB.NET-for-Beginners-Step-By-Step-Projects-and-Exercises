<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarLoan
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
        Me.txtAmountOfLoan = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayments = New System.Windows.Forms.TextBox()
        Me.txtInterestPaid = New System.Windows.Forms.TextBox()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAmountOfLoan
        '
        Me.txtAmountOfLoan.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAmountOfLoan.Location = New System.Drawing.Point(528, 75)
        Me.txtAmountOfLoan.Name = "txtAmountOfLoan"
        Me.txtAmountOfLoan.Size = New System.Drawing.Size(356, 65)
        Me.txtAmountOfLoan.TabIndex = 0
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(528, 185)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(356, 65)
        Me.txtInterestRate.TabIndex = 1
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(528, 308)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(356, 65)
        Me.txtDuration.TabIndex = 2
        '
        'txtMonthlyPayments
        '
        Me.txtMonthlyPayments.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMonthlyPayments.Location = New System.Drawing.Point(545, 647)
        Me.txtMonthlyPayments.Name = "txtMonthlyPayments"
        Me.txtMonthlyPayments.Size = New System.Drawing.Size(339, 43)
        Me.txtMonthlyPayments.TabIndex = 3
        '
        'txtInterestPaid
        '
        Me.txtInterestPaid.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtInterestPaid.Location = New System.Drawing.Point(528, 781)
        Me.txtInterestPaid.Name = "txtInterestPaid"
        Me.txtInterestPaid.Size = New System.Drawing.Size(356, 43)
        Me.txtInterestPaid.TabIndex = 4
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnalyze.Location = New System.Drawing.Point(443, 436)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(550, 131)
        Me.btnAnalyze.TabIndex = 5
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Amount of Loan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 36)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Interest Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 36)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Duration in months"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 654)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 36)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monthly Payments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 788)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total interest paid"
        '
        'CarLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 950)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.txtInterestPaid)
        Me.Controls.Add(Me.txtMonthlyPayments)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtAmountOfLoan)
        Me.Name = "CarLoan"
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmountOfLoan As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtMonthlyPayments As TextBox
    Friend WithEvents txtInterestPaid As TextBox
    Friend WithEvents btnAnalyze As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
