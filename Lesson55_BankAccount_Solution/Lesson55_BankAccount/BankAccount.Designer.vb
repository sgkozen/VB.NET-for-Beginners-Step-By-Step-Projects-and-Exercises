<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccount
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
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboTransfer = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.txtTransfer = New System.Windows.Forms.TextBox()
        Me.lblTransferTo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpCheck = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSignCheck = New System.Windows.Forms.Button()
        Me.txtPayTo = New System.Windows.Forms.TextBox()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpCheck.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAccount)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1111, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cboAccount
        '
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cboAccount.Location = New System.Drawing.Point(139, 39)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(121, 26)
        Me.cboAccount.TabIndex = 17
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(956, 37)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(149, 25)
        Me.txtDate.TabIndex = 13
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(522, 40)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(195, 25)
        Me.txtBalance.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(820, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Today's Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Balance:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnDeposit)
        Me.GroupBox2.Controls.Add(Me.txtDeposit)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 97)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deposit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "$"
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(238, 32)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(109, 49)
        Me.btnDeposit.TabIndex = 14
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(80, 44)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(125, 25)
        Me.txtDeposit.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboTransfer)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnTransfer)
        Me.GroupBox3.Controls.Add(Me.txtTransfer)
        Me.GroupBox3.Controls.Add(Me.lblTransferTo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(426, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 230)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transfer"
        '
        'cboTransfer
        '
        Me.cboTransfer.FormattingEnabled = True
        Me.cboTransfer.Items.AddRange(New Object() {"Checking" & Global.Microsoft.VisualBasic.ChrW(9), "Savings"})
        Me.cboTransfer.Location = New System.Drawing.Point(194, 39)
        Me.cboTransfer.Name = "cboTransfer"
        Me.cboTransfer.Size = New System.Drawing.Size(121, 26)
        Me.cboTransfer.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(184, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 18)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "$"
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(187, 166)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(137, 48)
        Me.btnTransfer.TabIndex = 10
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'txtTransfer
        '
        Me.txtTransfer.Location = New System.Drawing.Point(215, 99)
        Me.txtTransfer.Name = "txtTransfer"
        Me.txtTransfer.Size = New System.Drawing.Size(100, 25)
        Me.txtTransfer.TabIndex = 9
        '
        'lblTransferTo
        '
        Me.lblTransferTo.AutoSize = True
        Me.lblTransferTo.Location = New System.Drawing.Point(43, 106)
        Me.lblTransferTo.Name = "lblTransferTo"
        Me.lblTransferTo.Size = New System.Drawing.Size(23, 18)
        Me.lblTransferTo.TabIndex = 4
        Me.lblTransferTo.Text = "to"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Transfer from"
        '
        'grpCheck
        '
        Me.grpCheck.Controls.Add(Me.Label11)
        Me.grpCheck.Controls.Add(Me.btnSignCheck)
        Me.grpCheck.Controls.Add(Me.txtPayTo)
        Me.grpCheck.Controls.Add(Me.txtCheck)
        Me.grpCheck.Controls.Add(Me.Label7)
        Me.grpCheck.Controls.Add(Me.Label6)
        Me.grpCheck.Location = New System.Drawing.Point(806, 158)
        Me.grpCheck.Name = "grpCheck"
        Me.grpCheck.Size = New System.Drawing.Size(345, 230)
        Me.grpCheck.TabIndex = 0
        Me.grpCheck.TabStop = False
        Me.grpCheck.Text = "Check"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(188, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "$"
        '
        'btnSignCheck
        '
        Me.btnSignCheck.Location = New System.Drawing.Point(161, 166)
        Me.btnSignCheck.Name = "btnSignCheck"
        Me.btnSignCheck.Size = New System.Drawing.Size(159, 48)
        Me.btnSignCheck.TabIndex = 11
        Me.btnSignCheck.Text = "Sign Check"
        Me.btnSignCheck.UseVisualStyleBackColor = True
        '
        'txtPayTo
        '
        Me.txtPayTo.Location = New System.Drawing.Point(161, 92)
        Me.txtPayTo.Name = "txtPayTo"
        Me.txtPayTo.Size = New System.Drawing.Size(159, 25)
        Me.txtPayTo.TabIndex = 8
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(220, 37)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(100, 25)
        Me.txtCheck.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "to the order of"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pay this amount"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.btnWithdrawal)
        Me.GroupBox5.Controls.Add(Me.txtWithdrawal)
        Me.GroupBox5.Location = New System.Drawing.Point(40, 291)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(366, 97)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Withdrawal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "$"
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Location = New System.Drawing.Point(238, 33)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(109, 48)
        Me.btnWithdrawal.TabIndex = 15
        Me.btnWithdrawal.Text = "Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Location = New System.Drawing.Point(80, 42)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(125, 25)
        Me.txtWithdrawal.TabIndex = 11
        '
        'dgvTransactions
        '
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Location = New System.Drawing.Point(179, 405)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.RowHeadersWidth = 62
        Me.dgvTransactions.RowTemplate.Height = 27
        Me.dgvTransactions.Size = New System.Drawing.Size(856, 248)
        Me.dgvTransactions.TabIndex = 2
        '
        'BankAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 665)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.grpCheck)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BankAccount"
        Me.Text = "Bank Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpCheck.ResumeLayout(False)
        Me.grpCheck.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTransferTo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpCheck As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents txtTransfer As TextBox
    Friend WithEvents btnSignCheck As Button
    Friend WithEvents txtPayTo As TextBox
    Friend WithEvents txtCheck As TextBox
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents txtWithdrawal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboAccount As ComboBox
    Friend WithEvents cboTransfer As ComboBox
End Class
