<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GPA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCreditHours = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbGrades = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRecord.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRecord.Location = New System.Drawing.Point(134, 428)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(518, 116)
        Me.btnRecord.TabIndex = 0
        Me.btnRecord.Text = "Record This Course"
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(134, 611)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(518, 107)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate GPA"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtCreditHours
        '
        Me.txtCreditHours.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCreditHours.Location = New System.Drawing.Point(365, 321)
        Me.txtCreditHours.Name = "txtCreditHours"
        Me.txtCreditHours.Size = New System.Drawing.Size(287, 37)
        Me.txtCreditHours.TabIndex = 3
        '
        'txtGPA
        '
        Me.txtGPA.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtGPA.Location = New System.Drawing.Point(365, 791)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(287, 37)
        Me.txtGPA.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Credit Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 798)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "GPA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Grade"
        '
        'cmbGrades
        '
        Me.cmbGrades.AccessibleName = ""
        Me.cmbGrades.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbGrades.FormattingEnabled = True
        Me.cmbGrades.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.cmbGrades.Location = New System.Drawing.Point(365, 157)
        Me.cmbGrades.Name = "cmbGrades"
        Me.cmbGrades.Size = New System.Drawing.Size(287, 38)
        Me.cmbGrades.TabIndex = 8
        Me.cmbGrades.Text = "Select Grade"
        '
        'GPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 893)
        Me.Controls.Add(Me.cmbGrades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtCreditHours)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnRecord)
        Me.Name = "GPA"
        Me.Text = "GPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecord As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCreditHours As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbGrades As ComboBox
End Class
