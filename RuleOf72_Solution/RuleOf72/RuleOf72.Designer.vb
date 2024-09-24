<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RuleOf72
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 18
        Me.lstOutput.Location = New System.Drawing.Point(68, 206)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(799, 526)
        Me.lstOutput.TabIndex = 0
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEvaluate.Location = New System.Drawing.Point(186, 59)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(556, 102)
        Me.btnEvaluate.TabIndex = 1
        Me.btnEvaluate.Text = "Evaluate Rule"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'RuleOf72
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 778)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "RuleOf72"
        Me.Text = "Rule of 72"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnEvaluate As Button
End Class
