<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpreadOfEpidemic
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
        Me.btnDay0 = New System.Windows.Forms.Button()
        Me.btnAdvance = New System.Windows.Forms.Button()
        Me.pbGraph = New System.Windows.Forms.PictureBox()
        CType(Me.pbGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDay0
        '
        Me.btnDay0.Location = New System.Drawing.Point(81, 504)
        Me.btnDay0.Name = "btnDay0"
        Me.btnDay0.Size = New System.Drawing.Size(239, 56)
        Me.btnDay0.TabIndex = 0
        Me.btnDay0.Text = "Show Day 0"
        Me.btnDay0.UseVisualStyleBackColor = True
        '
        'btnAdvance
        '
        Me.btnAdvance.Location = New System.Drawing.Point(495, 504)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(239, 56)
        Me.btnAdvance.TabIndex = 1
        Me.btnAdvance.Text = "Advance One Day"
        Me.btnAdvance.UseVisualStyleBackColor = True
        '
        'pbGraph
        '
        Me.pbGraph.Location = New System.Drawing.Point(12, 144)
        Me.pbGraph.Name = "pbGraph"
        Me.pbGraph.Size = New System.Drawing.Size(776, 354)
        Me.pbGraph.TabIndex = 2
        Me.pbGraph.TabStop = False
        '
        'SpreadOfEpidemic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 597)
        Me.Controls.Add(Me.pbGraph)
        Me.Controls.Add(Me.btnAdvance)
        Me.Controls.Add(Me.btnDay0)
        Me.Name = "SpreadOfEpidemic"
        Me.Text = "frmEpidemic"
        CType(Me.pbGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDay0 As Button
    Friend WithEvents btnAdvance As Button
    Friend WithEvents pbGraph As PictureBox
End Class
