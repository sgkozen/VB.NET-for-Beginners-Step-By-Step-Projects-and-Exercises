<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FurnitureOrder
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
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtChairs = New System.Windows.Forms.TextBox()
        Me.txtSofas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtName.Location = New System.Drawing.Point(546, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(386, 35)
        Me.txtName.TabIndex = 0
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(546, 185)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(386, 35)
        Me.txtAddress.TabIndex = 1
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCity.Location = New System.Drawing.Point(546, 284)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(386, 35)
        Me.txtCity.TabIndex = 2
        '
        'txtChairs
        '
        Me.txtChairs.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtChairs.Location = New System.Drawing.Point(546, 401)
        Me.txtChairs.Name = "txtChairs"
        Me.txtChairs.Size = New System.Drawing.Size(149, 35)
        Me.txtChairs.TabIndex = 3
        '
        'txtSofas
        '
        Me.txtSofas.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtSofas.Location = New System.Drawing.Point(546, 519)
        Me.txtSofas.Name = "txtSofas"
        Me.txtSofas.Size = New System.Drawing.Size(149, 35)
        Me.txtSofas.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer Name (Last, First)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "City, State, ZIP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number of Chairs Ordered"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 526)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of Sofas Ordered"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 18
        Me.lstDisplay.Location = New System.Drawing.Point(1058, 82)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(646, 472)
        Me.lstDisplay.TabIndex = 10
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnProcessOrder.Location = New System.Drawing.Point(135, 714)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(393, 66)
        Me.btnProcessOrder.TabIndex = 11
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClear.Location = New System.Drawing.Point(712, 714)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(393, 66)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear Order Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(1311, 714)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(393, 66)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'FurnitureOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1764, 908)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSofas)
        Me.Controls.Add(Me.txtChairs)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Name = "FurnitureOrder"
        Me.Text = "Furniture Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtChairs As TextBox
    Friend WithEvents txtSofas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnProcessOrder As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
End Class
