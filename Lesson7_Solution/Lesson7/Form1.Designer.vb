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
        Me.txtPriceOfItem = New System.Windows.Forms.TextBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.txtOunces = New System.Windows.Forms.TextBox()
        Me.txtPricePerOunce = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPriceOfItem
        '
        Me.txtPriceOfItem.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPriceOfItem.Location = New System.Drawing.Point(452, 108)
        Me.txtPriceOfItem.Name = "txtPriceOfItem"
        Me.txtPriceOfItem.Size = New System.Drawing.Size(150, 37)
        Me.txtPriceOfItem.TabIndex = 0
        '
        'txtPounds
        '
        Me.txtPounds.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPounds.Location = New System.Drawing.Point(272, 428)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(150, 37)
        Me.txtPounds.TabIndex = 1
        '
        'txtOunces
        '
        Me.txtOunces.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOunces.Location = New System.Drawing.Point(755, 417)
        Me.txtOunces.Name = "txtOunces"
        Me.txtOunces.Size = New System.Drawing.Size(150, 37)
        Me.txtOunces.TabIndex = 2
        '
        'txtPricePerOunce
        '
        Me.txtPricePerOunce.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPricePerOunce.Location = New System.Drawing.Point(551, 711)
        Me.txtPricePerOunce.Name = "txtPricePerOunce"
        Me.txtPricePerOunce.Size = New System.Drawing.Size(238, 37)
        Me.txtPricePerOunce.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price of Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(415, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 90)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pounds"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(608, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 45)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ounces"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(217, 718)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price Per Ounce"
        '
        'btnDetermine
        '
        Me.btnDetermine.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDetermine.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDetermine.Location = New System.Drawing.Point(272, 511)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(517, 116)
        Me.btnDetermine.TabIndex = 9
        Me.btnDetermine.Text = "Determine Unit Price"
        Me.btnDetermine.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 894)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPricePerOunce)
        Me.Controls.Add(Me.txtOunces)
        Me.Controls.Add(Me.txtPounds)
        Me.Controls.Add(Me.txtPriceOfItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPriceOfItem As TextBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents txtOunces As TextBox
    Friend WithEvents txtPricePerOunce As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDetermine As Button
End Class
