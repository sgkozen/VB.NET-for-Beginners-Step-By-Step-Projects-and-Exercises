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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("MS UI Gothic", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(106, 407)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(150, 77)
        Me.txtFirst.TabIndex = 1
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("MS UI Gothic", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(992, 407)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(150, 77)
        Me.txtSecond.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 174)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Number"
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPlus.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(508, 39)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(207, 147)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnMinus.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(508, 235)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(215, 159)
        Me.btnMinus.TabIndex = 6
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnMultiply.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(508, 448)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(221, 170)
        Me.btnMultiply.TabIndex = 7
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'txtResults
        '
        Me.txtResults.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtResults.Location = New System.Drawing.Point(175, 870)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(898, 67)
        Me.txtResults.TabIndex = 8
        Me.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(971, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 174)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Second Number"
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDivide.Font = New System.Drawing.Font("MS UI Gothic", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(508, 678)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(215, 157)
        Me.btnDivide.TabIndex = 10
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(846, 806)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents txtResults As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDivide As Button
End Class
