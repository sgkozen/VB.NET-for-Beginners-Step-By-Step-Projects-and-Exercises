<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuelEconomy
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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("MS UI Gothic", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(105, 48)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(532, 80)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "Compute MPG"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'dgvOutput
        '
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(105, 154)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersWidth = 62
        Me.dgvOutput.RowTemplate.Height = 27
        Me.dgvOutput.Size = New System.Drawing.Size(532, 460)
        Me.dgvOutput.TabIndex = 1
        '
        'FuelEconomy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 452)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnCompute)
        Me.Name = "FuelEconomy"
        Me.Text = "Fuel Economy"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCompute As Button
    Friend WithEvents dgvOutput As DataGridView
End Class
