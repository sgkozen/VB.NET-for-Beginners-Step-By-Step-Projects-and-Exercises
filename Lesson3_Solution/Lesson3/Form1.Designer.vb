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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtName.Location = New System.Drawing.Point(428, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(770, 56)
        Me.txtName.TabIndex = 0
        '
        'txtLabor
        '
        Me.txtLabor.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLabor.Location = New System.Drawing.Point(428, 222)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(394, 37)
        Me.txtLabor.TabIndex = 1
        '
        'txtParts
        '
        Me.txtParts.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtParts.Location = New System.Drawing.Point(428, 375)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(394, 37)
        Me.txtParts.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDisplay.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(891, 222)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(315, 178)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 36)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hours of Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cost of Parts"
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 36
        Me.lstDisplay.Location = New System.Drawing.Point(443, 484)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(763, 292)
        Me.lstDisplay.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 905)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstDisplay As ListBox
End Class
