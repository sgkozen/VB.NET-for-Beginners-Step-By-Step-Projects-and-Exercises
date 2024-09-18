<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nutrition
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
        Me.txtNameOfFood = New System.Windows.Forms.TextBox()
        Me.txtCaloriesPerServing = New System.Windows.Forms.TextBox()
        Me.TxtGramsOfFat = New System.Windows.Forms.TextBox()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNameOfFood
        '
        Me.txtNameOfFood.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtNameOfFood.Location = New System.Drawing.Point(476, 58)
        Me.txtNameOfFood.Name = "txtNameOfFood"
        Me.txtNameOfFood.Size = New System.Drawing.Size(909, 65)
        Me.txtNameOfFood.TabIndex = 0
        '
        'txtCaloriesPerServing
        '
        Me.txtCaloriesPerServing.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCaloriesPerServing.Location = New System.Drawing.Point(551, 180)
        Me.txtCaloriesPerServing.Name = "txtCaloriesPerServing"
        Me.txtCaloriesPerServing.Size = New System.Drawing.Size(741, 65)
        Me.txtCaloriesPerServing.TabIndex = 1
        '
        'TxtGramsOfFat
        '
        Me.TxtGramsOfFat.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtGramsOfFat.Location = New System.Drawing.Point(552, 312)
        Me.TxtGramsOfFat.Name = "TxtGramsOfFat"
        Me.TxtGramsOfFat.Size = New System.Drawing.Size(738, 65)
        Me.TxtGramsOfFat.TabIndex = 2
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(21, 639)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(944, 277)
        Me.txtDisplay.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name Of Food"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Calories Per Serving"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(401, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grams of Fat Per Serving"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(225, 448)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(542, 159)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate % Calories From Fat"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Nutrition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 946)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.TxtGramsOfFat)
        Me.Controls.Add(Me.txtCaloriesPerServing)
        Me.Controls.Add(Me.txtNameOfFood)
        Me.Name = "Nutrition"
        Me.Text = "Nutrition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNameOfFood As TextBox
    Friend WithEvents txtCaloriesPerServing As TextBox
    Friend WithEvents TxtGramsOfFat As TextBox
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
End Class
