<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurantBill
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
        Me.txtPizza = New System.Windows.Forms.TextBox()
        Me.txtFries = New System.Windows.Forms.TextBox()
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtPizza
        '
        Me.txtPizza.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPizza.Location = New System.Drawing.Point(516, 129)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(150, 43)
        Me.txtPizza.TabIndex = 0
        '
        'txtFries
        '
        Me.txtFries.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFries.Location = New System.Drawing.Point(516, 226)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(150, 43)
        Me.txtFries.TabIndex = 1
        '
        'txtDrinks
        '
        Me.txtDrinks.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDrinks.Location = New System.Drawing.Point(516, 334)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(150, 43)
        Me.txtDrinks.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "How many pizza slices?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "How many orders of fries?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "How many drinks?"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.IndianRed
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(756, 130)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(258, 246)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Total Cost"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 18
        Me.lstDisplay.Location = New System.Drawing.Point(63, 433)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(950, 472)
        Me.lstDisplay.TabIndex = 7
        '
        'RestaurantBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 954)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDrinks)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.txtPizza)
        Me.Name = "RestaurantBill"
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPizza As TextBox
    Friend WithEvents txtFries As TextBox
    Friend WithEvents txtDrinks As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lstDisplay As ListBox
End Class
