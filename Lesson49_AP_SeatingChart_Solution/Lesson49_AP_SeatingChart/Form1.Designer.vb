<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeals
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
        Me.rdbUnoccupied = New System.Windows.Forms.RadioButton()
        Me.rdbRegular = New System.Windows.Forms.RadioButton()
        Me.rdbLowCalorie = New System.Windows.Forms.RadioButton()
        Me.rdbVegetarian = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rdbUnoccupied
        '
        Me.rdbUnoccupied.AutoSize = True
        Me.rdbUnoccupied.Location = New System.Drawing.Point(63, 42)
        Me.rdbUnoccupied.Name = "rdbUnoccupied"
        Me.rdbUnoccupied.Size = New System.Drawing.Size(121, 22)
        Me.rdbUnoccupied.TabIndex = 0
        Me.rdbUnoccupied.TabStop = True
        Me.rdbUnoccupied.Text = "Unoccupied"
        Me.rdbUnoccupied.UseVisualStyleBackColor = True
        '
        'rdbRegular
        '
        Me.rdbRegular.AutoSize = True
        Me.rdbRegular.Location = New System.Drawing.Point(242, 42)
        Me.rdbRegular.Name = "rdbRegular"
        Me.rdbRegular.Size = New System.Drawing.Size(89, 22)
        Me.rdbRegular.TabIndex = 1
        Me.rdbRegular.TabStop = True
        Me.rdbRegular.Text = "Regular"
        Me.rdbRegular.UseVisualStyleBackColor = True
        '
        'rdbLowCalorie
        '
        Me.rdbLowCalorie.AutoSize = True
        Me.rdbLowCalorie.Location = New System.Drawing.Point(63, 121)
        Me.rdbLowCalorie.Name = "rdbLowCalorie"
        Me.rdbLowCalorie.Size = New System.Drawing.Size(122, 22)
        Me.rdbLowCalorie.TabIndex = 2
        Me.rdbLowCalorie.TabStop = True
        Me.rdbLowCalorie.Text = "Low Calorie"
        Me.rdbLowCalorie.UseVisualStyleBackColor = True
        '
        'rdbVegetarian
        '
        Me.rdbVegetarian.AutoSize = True
        Me.rdbVegetarian.Location = New System.Drawing.Point(242, 121)
        Me.rdbVegetarian.Name = "rdbVegetarian"
        Me.rdbVegetarian.Size = New System.Drawing.Size(113, 22)
        Me.rdbVegetarian.TabIndex = 3
        Me.rdbVegetarian.TabStop = True
        Me.rdbVegetarian.Text = "Vegetarian"
        Me.rdbVegetarian.UseVisualStyleBackColor = True
        '
        'frmMeals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 226)
        Me.Controls.Add(Me.rdbVegetarian)
        Me.Controls.Add(Me.rdbLowCalorie)
        Me.Controls.Add(Me.rdbRegular)
        Me.Controls.Add(Me.rdbUnoccupied)
        Me.Name = "frmMeals"
        Me.Text = "frmMeals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbUnoccupied As RadioButton
    Friend WithEvents rdbRegular As RadioButton
    Friend WithEvents rdbLowCalorie As RadioButton
    Friend WithEvents rdbVegetarian As RadioButton
End Class
