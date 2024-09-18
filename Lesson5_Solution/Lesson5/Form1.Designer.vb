<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtYards = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.lstMetric = New System.Windows.Forms.ListBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFeet
        '
        Me.txtFeet.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFeet.Location = New System.Drawing.Point(201, 323)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(431, 37)
        Me.txtFeet.TabIndex = 0
        '
        'txtYards
        '
        Me.txtYards.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtYards.Location = New System.Drawing.Point(201, 202)
        Me.txtYards.Name = "txtYards"
        Me.txtYards.Size = New System.Drawing.Size(431, 37)
        Me.txtYards.TabIndex = 1
        '
        'txtMiles
        '
        Me.txtMiles.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMiles.Location = New System.Drawing.Point(201, 92)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(431, 37)
        Me.txtMiles.TabIndex = 2
        '
        'txtInches
        '
        Me.txtInches.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtInches.Location = New System.Drawing.Point(201, 462)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(431, 37)
        Me.txtInches.TabIndex = 3
        '
        'lstMetric
        '
        Me.lstMetric.FormattingEnabled = True
        Me.lstMetric.ItemHeight = 18
        Me.lstMetric.Location = New System.Drawing.Point(692, 341)
        Me.lstMetric.Name = "lstMetric"
        Me.lstMetric.Size = New System.Drawing.Size(544, 310)
        Me.lstMetric.TabIndex = 4
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(692, 92)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(544, 143)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert To Metric"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Miles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Yards"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Feet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Inches"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 799)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lstMetric)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtYards)
        Me.Controls.Add(Me.txtFeet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtYards As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtInches As TextBox
    Friend WithEvents lstMetric As ListBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
