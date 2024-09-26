<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BachelorDegrees
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
        Me.btnFields = New System.Windows.Forms.Button()
        Me.btnPercentage = New System.Windows.Forms.Button()
        Me.btnFields2010 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grdOutput = New System.Windows.Forms.DataGridView()
        CType(Me.grdOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFields
        '
        Me.btnFields.Location = New System.Drawing.Point(320, 36)
        Me.btnFields.Name = "btnFields"
        Me.btnFields.Size = New System.Drawing.Size(374, 82)
        Me.btnFields.TabIndex = 0
        Me.btnFields.Text = "Bachelor Degrees Conferred in Certain Fields"
        Me.btnFields.UseVisualStyleBackColor = True
        '
        'btnPercentage
        '
        Me.btnPercentage.Location = New System.Drawing.Point(320, 124)
        Me.btnPercentage.Name = "btnPercentage"
        Me.btnPercentage.Size = New System.Drawing.Size(374, 82)
        Me.btnPercentage.TabIndex = 1
        Me.btnPercentage.Text = "Percentage Change in Bachelor Degrees Conferred"
        Me.btnPercentage.UseVisualStyleBackColor = True
        '
        'btnFields2010
        '
        Me.btnFields2010.Location = New System.Drawing.Point(320, 212)
        Me.btnFields2010.Name = "btnFields2010"
        Me.btnFields2010.Size = New System.Drawing.Size(374, 82)
        Me.btnFields2010.TabIndex = 2
        Me.btnFields2010.Text = "Bachelor Degrees Conferred in 2010 in Certain Fields"
        Me.btnFields2010.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(320, 357)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(374, 82)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'grdOutput
        '
        Me.grdOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOutput.Location = New System.Drawing.Point(24, 530)
        Me.grdOutput.Name = "grdOutput"
        Me.grdOutput.RowHeadersWidth = 62
        Me.grdOutput.RowTemplate.Height = 27
        Me.grdOutput.Size = New System.Drawing.Size(913, 434)
        Me.grdOutput.TabIndex = 4
        '
        'BachelorDegrees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 976)
        Me.Controls.Add(Me.grdOutput)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnFields2010)
        Me.Controls.Add(Me.btnPercentage)
        Me.Controls.Add(Me.btnFields)
        Me.Name = "BachelorDegrees"
        Me.Text = "Bachelor Degrees"
        CType(Me.grdOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFields As Button
    Friend WithEvents btnPercentage As Button
    Friend WithEvents btnFields2010 As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents grdOutput As DataGridView
End Class
