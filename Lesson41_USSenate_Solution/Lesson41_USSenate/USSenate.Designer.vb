<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USSenate
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstStates = New System.Windows.Forms.ListBox()
        Me.lstSenators = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "State"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(503, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senators"
        '
        'lstStates
        '
        Me.lstStates.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstStates.FormattingEnabled = True
        Me.lstStates.ItemHeight = 24
        Me.lstStates.Location = New System.Drawing.Point(50, 130)
        Me.lstStates.Name = "lstStates"
        Me.lstStates.Size = New System.Drawing.Size(383, 676)
        Me.lstStates.TabIndex = 3
        '
        'lstSenators
        '
        Me.lstSenators.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstSenators.FormattingEnabled = True
        Me.lstSenators.ItemHeight = 24
        Me.lstSenators.Location = New System.Drawing.Point(508, 119)
        Me.lstSenators.Name = "lstSenators"
        Me.lstSenators.Size = New System.Drawing.Size(343, 364)
        Me.lstSenators.TabIndex = 4
        '
        'USSenate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 893)
        Me.Controls.Add(Me.lstSenators)
        Me.Controls.Add(Me.lstStates)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "USSenate"
        Me.Text = "US Senate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstStates As ListBox
    Friend WithEvents lstSenators As ListBox
End Class
