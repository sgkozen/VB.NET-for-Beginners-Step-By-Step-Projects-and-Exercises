<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectileMotion
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
        Me.txtInitialHeight = New System.Windows.Forms.TextBox()
        Me.txtInitialVelocity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMaxHeight = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnApproxTime = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtInitialHeight
        '
        Me.txtInitialHeight.Location = New System.Drawing.Point(176, 64)
        Me.txtInitialHeight.Name = "txtInitialHeight"
        Me.txtInitialHeight.Size = New System.Drawing.Size(100, 25)
        Me.txtInitialHeight.TabIndex = 0
        '
        'txtInitialVelocity
        '
        Me.txtInitialVelocity.Location = New System.Drawing.Point(629, 64)
        Me.txtInitialVelocity.Name = "txtInitialVelocity"
        Me.txtInitialVelocity.Size = New System.Drawing.Size(100, 25)
        Me.txtInitialVelocity.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(75, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Initial Height:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(474, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 69)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Initial Velocity: (feet / )"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMaxHeight
        '
        Me.btnMaxHeight.Location = New System.Drawing.Point(68, 135)
        Me.btnMaxHeight.Name = "btnMaxHeight"
        Me.btnMaxHeight.Size = New System.Drawing.Size(363, 113)
        Me.btnMaxHeight.TabIndex = 4
        Me.btnMaxHeight.Text = "Determine Maximum Height"
        Me.btnMaxHeight.UseVisualStyleBackColor = True
        '
        'btnTable
        '
        Me.btnTable.Location = New System.Drawing.Point(503, 136)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(216, 113)
        Me.btnTable.TabIndex = 5
        Me.btnTable.Text = "Display Table"
        Me.btnTable.UseVisualStyleBackColor = True
        '
        'btnApproxTime
        '
        Me.btnApproxTime.Location = New System.Drawing.Point(68, 294)
        Me.btnApproxTime.Name = "btnApproxTime"
        Me.btnApproxTime.Size = New System.Drawing.Size(363, 127)
        Me.btnApproxTime.TabIndex = 6
        Me.btnApproxTime.Text = "Determine Approximate Time Until Ball Hits the Ground"
        Me.btnApproxTime.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.AutoEllipsis = True
        Me.Quit.Location = New System.Drawing.Point(503, 294)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(213, 126)
        Me.Quit.TabIndex = 7
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 18
        Me.lstOutput.Location = New System.Drawing.Point(25, 464)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(758, 490)
        Me.lstOutput.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 1018)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.btnApproxTime)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.btnMaxHeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInitialVelocity)
        Me.Controls.Add(Me.txtInitialHeight)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInitialHeight As TextBox
    Friend WithEvents txtInitialVelocity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMaxHeight As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnApproxTime As Button
    Friend WithEvents Quit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstOutput As ListBox
End Class
