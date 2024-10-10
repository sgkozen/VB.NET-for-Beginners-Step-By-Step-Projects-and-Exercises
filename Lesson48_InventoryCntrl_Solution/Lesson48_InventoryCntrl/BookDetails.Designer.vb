<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbNonfiction = New System.Windows.Forms.RadioButton()
        Me.rdbFiction = New System.Windows.Forms.RadioButton()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Author:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "In Stock:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(140, 97)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(300, 31)
        Me.txtAuthor.TabIndex = 5
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtStock.Location = New System.Drawing.Point(155, 196)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(94, 31)
        Me.txtStock.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(356, 200)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(150, 31)
        Me.txtPrice.TabIndex = 8
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(50, 461)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(442, 68)
        Me.btnRecord.TabIndex = 10
        Me.btnRecord.Text = "Record Details"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbNonfiction)
        Me.GroupBox1.Controls.Add(Me.rdbFiction)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 123)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category"
        '
        'rdbNonfiction
        '
        Me.rdbNonfiction.AutoSize = True
        Me.rdbNonfiction.Location = New System.Drawing.Point(257, 54)
        Me.rdbNonfiction.Name = "rdbNonfiction"
        Me.rdbNonfiction.Size = New System.Drawing.Size(109, 22)
        Me.rdbNonfiction.TabIndex = 1
        Me.rdbNonfiction.TabStop = True
        Me.rdbNonfiction.Text = "Nonfiction"
        Me.rdbNonfiction.UseVisualStyleBackColor = True
        '
        'rdbFiction
        '
        Me.rdbFiction.AutoSize = True
        Me.rdbFiction.Location = New System.Drawing.Point(47, 54)
        Me.rdbFiction.Name = "rdbFiction"
        Me.rdbFiction.Size = New System.Drawing.Size(84, 22)
        Me.rdbFiction.TabIndex = 0
        Me.rdbFiction.TabStop = True
        Me.rdbFiction.Text = "Fiction"
        Me.rdbFiction.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(140, 39)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(300, 31)
        Me.txtTitle.TabIndex = 9
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 556)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDetails"
        Me.Text = "Book Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnRecord As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents rdbNonfiction As RadioButton
    Friend WithEvents rdbFiction As RadioButton
End Class
