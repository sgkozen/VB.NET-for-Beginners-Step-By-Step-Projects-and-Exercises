<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurantMenu
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
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBurgers = New System.Windows.Forms.GroupBox()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.regBurger = New System.Windows.Forms.RadioButton()
        Me.wCheese = New System.Windows.Forms.RadioButton()
        Me.wBacon = New System.Windows.Forms.RadioButton()
        Me.wBaconAndCheese = New System.Windows.Forms.RadioButton()
        Me.smlFries = New System.Windows.Forms.RadioButton()
        Me.medFries = New System.Windows.Forms.RadioButton()
        Me.lrgFries = New System.Windows.Forms.RadioButton()
        Me.soda = New System.Windows.Forms.RadioButton()
        Me.btlWater = New System.Windows.Forms.RadioButton()
        Me.grpBurgers.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBurgers
        '
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkBurgers.Location = New System.Drawing.Point(81, 72)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(130, 32)
        Me.chkBurgers.TabIndex = 0
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkFries.Location = New System.Drawing.Point(81, 377)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(96, 32)
        Me.chkFries.TabIndex = 1
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkDrinks.Location = New System.Drawing.Point(81, 629)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(112, 32)
        Me.chkDrinks.TabIndex = 2
        Me.chkDrinks.Text = "Drinks"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(890, 619)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(405, 100)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Cost of Meal"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCost.Location = New System.Drawing.Point(1041, 825)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(254, 31)
        Me.txtCost.TabIndex = 4
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(769, 832)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cost of the Meal Is:"
        '
        'grpBurgers
        '
        Me.grpBurgers.Controls.Add(Me.wBaconAndCheese)
        Me.grpBurgers.Controls.Add(Me.wBacon)
        Me.grpBurgers.Controls.Add(Me.wCheese)
        Me.grpBurgers.Controls.Add(Me.regBurger)
        Me.grpBurgers.Location = New System.Drawing.Point(287, 72)
        Me.grpBurgers.Name = "grpBurgers"
        Me.grpBurgers.Size = New System.Drawing.Size(430, 236)
        Me.grpBurgers.TabIndex = 6
        Me.grpBurgers.TabStop = False
        Me.grpBurgers.Text = "Choices for Burgers"
        Me.grpBurgers.Visible = False
        '
        'grpFries
        '
        Me.grpFries.Controls.Add(Me.lrgFries)
        Me.grpFries.Controls.Add(Me.medFries)
        Me.grpFries.Controls.Add(Me.smlFries)
        Me.grpFries.Location = New System.Drawing.Point(287, 377)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Size = New System.Drawing.Size(430, 195)
        Me.grpFries.TabIndex = 7
        Me.grpFries.TabStop = False
        Me.grpFries.Text = "Choices for Fries"
        Me.grpFries.Visible = False
        '
        'grpDrinks
        '
        Me.grpDrinks.Controls.Add(Me.btlWater)
        Me.grpDrinks.Controls.Add(Me.soda)
        Me.grpDrinks.Location = New System.Drawing.Point(287, 639)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(430, 159)
        Me.grpDrinks.TabIndex = 0
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Choices for Drinks"
        Me.grpDrinks.Visible = False
        '
        'regBurger
        '
        Me.regBurger.AutoSize = True
        Me.regBurger.Location = New System.Drawing.Point(43, 37)
        Me.regBurger.Name = "regBurger"
        Me.regBurger.Size = New System.Drawing.Size(144, 22)
        Me.regBurger.TabIndex = 0
        Me.regBurger.TabStop = True
        Me.regBurger.Text = "Regular ($4.19)"
        Me.regBurger.UseVisualStyleBackColor = True
        '
        'wCheese
        '
        Me.wCheese.AutoSize = True
        Me.wCheese.Location = New System.Drawing.Point(43, 80)
        Me.wCheese.Name = "wCheese"
        Me.wCheese.Size = New System.Drawing.Size(162, 22)
        Me.wCheese.TabIndex = 1
        Me.wCheese.TabStop = True
        Me.wCheese.Text = "w/cheese ($4.79)"
        Me.wCheese.UseVisualStyleBackColor = True
        '
        'wBacon
        '
        Me.wBacon.AutoSize = True
        Me.wBacon.Location = New System.Drawing.Point(43, 129)
        Me.wBacon.Name = "wBacon"
        Me.wBacon.Size = New System.Drawing.Size(154, 22)
        Me.wBacon.TabIndex = 2
        Me.wBacon.TabStop = True
        Me.wBacon.Text = "w/bacon ($4.79)"
        Me.wBacon.UseVisualStyleBackColor = True
        '
        'wBaconAndCheese
        '
        Me.wBaconAndCheese.AutoSize = True
        Me.wBaconAndCheese.Location = New System.Drawing.Point(43, 175)
        Me.wBaconAndCheese.Name = "wBaconAndCheese"
        Me.wBaconAndCheese.Size = New System.Drawing.Size(249, 22)
        Me.wBaconAndCheese.TabIndex = 3
        Me.wBaconAndCheese.TabStop = True
        Me.wBaconAndCheese.Text = "w/ bacon and cheese ($5.39)"
        Me.wBaconAndCheese.UseVisualStyleBackColor = True
        '
        'smlFries
        '
        Me.smlFries.AutoSize = True
        Me.smlFries.Location = New System.Drawing.Point(47, 33)
        Me.smlFries.Name = "smlFries"
        Me.smlFries.Size = New System.Drawing.Size(129, 22)
        Me.smlFries.TabIndex = 0
        Me.smlFries.TabStop = True
        Me.smlFries.Text = "Small ($2.39)"
        Me.smlFries.UseVisualStyleBackColor = True
        '
        'medFries
        '
        Me.medFries.AutoSize = True
        Me.medFries.Location = New System.Drawing.Point(47, 91)
        Me.medFries.Name = "medFries"
        Me.medFries.Size = New System.Drawing.Size(145, 22)
        Me.medFries.TabIndex = 1
        Me.medFries.TabStop = True
        Me.medFries.Text = "Medium ($3.09)"
        Me.medFries.UseVisualStyleBackColor = True
        '
        'lrgFries
        '
        Me.lrgFries.AutoSize = True
        Me.lrgFries.Location = New System.Drawing.Point(47, 151)
        Me.lrgFries.Name = "lrgFries"
        Me.lrgFries.Size = New System.Drawing.Size(130, 22)
        Me.lrgFries.TabIndex = 2
        Me.lrgFries.TabStop = True
        Me.lrgFries.Text = "Large ($4.99)"
        Me.lrgFries.UseVisualStyleBackColor = True
        '
        'soda
        '
        Me.soda.AutoSize = True
        Me.soda.Location = New System.Drawing.Point(47, 46)
        Me.soda.Name = "soda"
        Me.soda.Size = New System.Drawing.Size(126, 22)
        Me.soda.TabIndex = 0
        Me.soda.TabStop = True
        Me.soda.Text = "Soda ($1.69)"
        Me.soda.UseVisualStyleBackColor = True
        '
        'btlWater
        '
        Me.btlWater.AutoSize = True
        Me.btlWater.Location = New System.Drawing.Point(47, 102)
        Me.btlWater.Name = "btlWater"
        Me.btlWater.Size = New System.Drawing.Size(190, 22)
        Me.btlWater.TabIndex = 1
        Me.btlWater.TabStop = True
        Me.btlWater.Text = "Bottled Water ($1.49)"
        Me.btlWater.UseVisualStyleBackColor = True
        '
        'RestaurantMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 952)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.grpFries)
        Me.Controls.Add(Me.grpBurgers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkDrinks)
        Me.Controls.Add(Me.chkFries)
        Me.Controls.Add(Me.chkBurgers)
        Me.Name = "RestaurantMenu"
        Me.Text = "Restaurant Menu"
        Me.grpBurgers.ResumeLayout(False)
        Me.grpBurgers.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBurgers As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkDrinks As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpBurgers As GroupBox
    Friend WithEvents wBaconAndCheese As RadioButton
    Friend WithEvents wBacon As RadioButton
    Friend WithEvents wCheese As RadioButton
    Friend WithEvents regBurger As RadioButton
    Friend WithEvents grpFries As GroupBox
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents lrgFries As RadioButton
    Friend WithEvents medFries As RadioButton
    Friend WithEvents smlFries As RadioButton
    Friend WithEvents btlWater As RadioButton
    Friend WithEvents soda As RadioButton
End Class
