<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISBN_Validator
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
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.mtbISBN = New System.Windows.Forms.MaskedTextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 524)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valid ISBN?"
        '
        'btnValidate
        '
        Me.btnValidate.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnValidate.Location = New System.Drawing.Point(134, 230)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(481, 157)
        Me.btnValidate.TabIndex = 2
        Me.btnValidate.Text = "Check Validity"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'mtbISBN
        '
        Me.mtbISBN.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.mtbISBN.Location = New System.Drawing.Point(327, 79)
        Me.mtbISBN.Mask = "0-00-000000-&"
        Me.mtbISBN.Name = "mtbISBN"
        Me.mtbISBN.Size = New System.Drawing.Size(401, 37)
        Me.mtbISBN.TabIndex = 3
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(346, 517)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(344, 37)
        Me.txtOutput.TabIndex = 4
        '
        'ISBN_Validator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 647)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.mtbISBN)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ISBN_Validator"
        Me.Text = "ISBN Validator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnValidate As Button
    Friend WithEvents mtbISBN As MaskedTextBox
    Friend WithEvents txtOutput As TextBox
End Class
