<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuadraticEquation
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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtSolutions = New System.Windows.Forms.TextBox()
        Me.btnFindSolution = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtA.Location = New System.Drawing.Point(157, 94)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(150, 39)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtB.Location = New System.Drawing.Point(517, 94)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(150, 39)
        Me.txtB.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtC.Location = New System.Drawing.Point(905, 91)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(150, 39)
        Me.txtC.TabIndex = 2
        '
        'txtSolutions
        '
        Me.txtSolutions.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtSolutions.Location = New System.Drawing.Point(398, 570)
        Me.txtSolutions.Name = "txtSolutions"
        Me.txtSolutions.Size = New System.Drawing.Size(708, 39)
        Me.txtSolutions.TabIndex = 3
        '
        'btnFindSolution
        '
        Me.btnFindSolution.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFindSolution.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnFindSolution.Location = New System.Drawing.Point(234, 251)
        Me.btnFindSolution.Name = "btnFindSolution"
        Me.btnFindSolution.Size = New System.Drawing.Size(692, 161)
        Me.btnFindSolution.TabIndex = 4
        Me.btnFindSolution.Text = "Find Solution"
        Me.btnFindSolution.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(454, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "b"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(839, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "c"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 576)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Solutions"
        '
        'QuadraticEquation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1149, 753)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFindSolution)
        Me.Controls.Add(Me.txtSolutions)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Name = "QuadraticEquation"
        Me.Text = "Quadratic Equation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtSolutions As TextBox
    Friend WithEvents btnFindSolution As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
