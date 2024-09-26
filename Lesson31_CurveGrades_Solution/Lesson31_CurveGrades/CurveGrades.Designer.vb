<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurveGrades
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
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtNumOfExams = New System.Windows.Forms.TextBox()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.txtStandDev = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdScores = New System.Windows.Forms.DataGridView()
        CType(Me.grdScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnalyze.Location = New System.Drawing.Point(46, 69)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(441, 151)
        Me.btnAnalyze.TabIndex = 0
        Me.btnAnalyze.Text = "Analyze Grades"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'txtNumOfExams
        '
        Me.txtNumOfExams.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNumOfExams.Location = New System.Drawing.Point(313, 277)
        Me.txtNumOfExams.Name = "txtNumOfExams"
        Me.txtNumOfExams.Size = New System.Drawing.Size(150, 35)
        Me.txtNumOfExams.TabIndex = 1
        '
        'txtMean
        '
        Me.txtMean.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMean.Location = New System.Drawing.Point(313, 400)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.Size = New System.Drawing.Size(150, 35)
        Me.txtMean.TabIndex = 2
        '
        'txtStandDev
        '
        Me.txtStandDev.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtStandDev.Location = New System.Drawing.Point(313, 516)
        Me.txtStandDev.Name = "txtStandDev"
        Me.txtStandDev.Size = New System.Drawing.Size(150, 35)
        Me.txtStandDev.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of Exams:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mean:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 523)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Standard Deviation"
        '
        'grdScores
        '
        Me.grdScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdScores.Location = New System.Drawing.Point(512, 69)
        Me.grdScores.Name = "grdScores"
        Me.grdScores.RowHeadersWidth = 62
        Me.grdScores.RowTemplate.Height = 27
        Me.grdScores.Size = New System.Drawing.Size(511, 866)
        Me.grdScores.TabIndex = 7
        '
        'CurveGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 976)
        Me.Controls.Add(Me.grdScores)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStandDev)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.txtNumOfExams)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Name = "CurveGrades"
        Me.Text = "Curve Grades"
        CType(Me.grdScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnalyze As Button
    Friend WithEvents txtNumOfExams As TextBox
    Friend WithEvents txtMean As TextBox
    Friend WithEvents txtStandDev As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grdScores As DataGridView
End Class
