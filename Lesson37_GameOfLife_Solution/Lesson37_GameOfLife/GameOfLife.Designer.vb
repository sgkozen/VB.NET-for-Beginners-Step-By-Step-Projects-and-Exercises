<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOfLife
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnGeneration = New System.Windows.Forms.Button()
        Me.txtIndividuals = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstGeneration = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNew.Location = New System.Drawing.Point(712, 151)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(215, 72)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New Game"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnGeneration
        '
        Me.btnGeneration.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGeneration.Location = New System.Drawing.Point(681, 267)
        Me.btnGeneration.Name = "btnGeneration"
        Me.btnGeneration.Size = New System.Drawing.Size(273, 93)
        Me.btnGeneration.TabIndex = 1
        Me.btnGeneration.Text = "Generation #1"
        Me.btnGeneration.UseVisualStyleBackColor = True
        '
        'txtIndividuals
        '
        Me.txtIndividuals.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtIndividuals.Location = New System.Drawing.Point(840, 468)
        Me.txtIndividuals.Name = "txtIndividuals"
        Me.txtIndividuals.Size = New System.Drawing.Size(114, 35)
        Me.txtIndividuals.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(689, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Individuals"
        '
        'lstGeneration
        '
        Me.lstGeneration.FormattingEnabled = True
        Me.lstGeneration.ItemHeight = 18
        Me.lstGeneration.Location = New System.Drawing.Point(32, 93)
        Me.lstGeneration.Name = "lstGeneration"
        Me.lstGeneration.Size = New System.Drawing.Size(628, 598)
        Me.lstGeneration.TabIndex = 4
        '
        'GameOfLife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 869)
        Me.Controls.Add(Me.lstGeneration)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIndividuals)
        Me.Controls.Add(Me.btnGeneration)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "GameOfLife"
        Me.Text = "Game Of Life"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents btnGeneration As Button
    Friend WithEvents txtIndividuals As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstGeneration As ListBox
End Class
