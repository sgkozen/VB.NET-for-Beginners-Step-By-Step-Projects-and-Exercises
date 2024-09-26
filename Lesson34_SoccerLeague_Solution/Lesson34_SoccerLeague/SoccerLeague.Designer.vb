<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoccerLeague
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.grdScores = New System.Windows.Forms.DataGridView()
        CType(Me.grdScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(106, 53)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(755, 141)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Standings"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'grdScores
        '
        Me.grdScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdScores.Location = New System.Drawing.Point(22, 335)
        Me.grdScores.Name = "grdScores"
        Me.grdScores.RowHeadersWidth = 62
        Me.grdScores.RowTemplate.Height = 27
        Me.grdScores.Size = New System.Drawing.Size(941, 559)
        Me.grdScores.TabIndex = 1
        '
        'SoccerLeague
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 906)
        Me.Controls.Add(Me.grdScores)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "SoccerLeague"
        Me.Text = "Soccer League"
        CType(Me.grdScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents grdScores As DataGridView
End Class
