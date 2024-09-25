<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRA
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEarlTotalDeposits = New System.Windows.Forms.TextBox()
        Me.txtLarryTotalDeposits = New System.Windows.Forms.TextBox()
        Me.txtEarlTotalIra = New System.Windows.Forms.TextBox()
        Me.txtLarryTotalIRA = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(452, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amounts Deposited"
        '
        'txtEarlTotalDeposits
        '
        Me.txtEarlTotalDeposits.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtEarlTotalDeposits.Location = New System.Drawing.Point(193, 189)
        Me.txtEarlTotalDeposits.Name = "txtEarlTotalDeposits"
        Me.txtEarlTotalDeposits.Size = New System.Drawing.Size(338, 35)
        Me.txtEarlTotalDeposits.TabIndex = 1
        '
        'txtLarryTotalDeposits
        '
        Me.txtLarryTotalDeposits.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLarryTotalDeposits.Location = New System.Drawing.Point(700, 182)
        Me.txtLarryTotalDeposits.Name = "txtLarryTotalDeposits"
        Me.txtLarryTotalDeposits.Size = New System.Drawing.Size(338, 35)
        Me.txtLarryTotalDeposits.TabIndex = 2
        '
        'txtEarlTotalIra
        '
        Me.txtEarlTotalIra.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtEarlTotalIra.Location = New System.Drawing.Point(193, 537)
        Me.txtEarlTotalIra.Name = "txtEarlTotalIra"
        Me.txtEarlTotalIra.Size = New System.Drawing.Size(338, 35)
        Me.txtEarlTotalIra.TabIndex = 3
        '
        'txtLarryTotalIRA
        '
        Me.txtLarryTotalIRA.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLarryTotalIRA.Location = New System.Drawing.Point(700, 530)
        Me.txtLarryTotalIRA.Name = "txtLarryTotalIRA"
        Me.txtLarryTotalIRA.Size = New System.Drawing.Size(338, 35)
        Me.txtLarryTotalIRA.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(923, 1584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(828, 338)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Earl"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(611, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Larry"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 527)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Earl"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(588, 527)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Larry"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(413, 637)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(342, 120)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Amounts"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(454, 33)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Amounts in IRA upon retirement."
        '
        'IRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 578)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtLarryTotalIRA)
        Me.Controls.Add(Me.txtEarlTotalIra)
        Me.Controls.Add(Me.txtLarryTotalDeposits)
        Me.Controls.Add(Me.txtEarlTotalDeposits)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IRA"
        Me.Text = "IRA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEarlTotalDeposits As TextBox
    Friend WithEvents txtLarryTotalDeposits As TextBox
    Friend WithEvents txtEarlTotalIra As TextBox
    Friend WithEvents txtLarryTotalIRA As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label6 As Label
End Class
