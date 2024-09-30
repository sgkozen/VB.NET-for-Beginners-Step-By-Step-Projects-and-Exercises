<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelephoneDirectory
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
        Me.btnNewDirectory = New System.Windows.Forms.Button()
        Me.txtCurrentDirectory = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.btnAddListing = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstDirectories = New System.Windows.Forms.ListBox()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click on one of the existing phone directories below to make it the current phone" &
    " directory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(711, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Phone Directory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(900, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(809, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'btnNewDirectory
        '
        Me.btnNewDirectory.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNewDirectory.Font = New System.Drawing.Font("MS UI Gothic", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNewDirectory.Location = New System.Drawing.Point(718, 17)
        Me.btnNewDirectory.Name = "btnNewDirectory"
        Me.btnNewDirectory.Size = New System.Drawing.Size(548, 69)
        Me.btnNewDirectory.TabIndex = 4
        Me.btnNewDirectory.Text = "Create a New Phone Directory"
        Me.btnNewDirectory.UseVisualStyleBackColor = False
        '
        'txtCurrentDirectory
        '
        Me.txtCurrentDirectory.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCurrentDirectory.Location = New System.Drawing.Point(993, 137)
        Me.txtCurrentDirectory.Name = "txtCurrentDirectory"
        Me.txtCurrentDirectory.Size = New System.Drawing.Size(285, 31)
        Me.txtCurrentDirectory.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtName.Location = New System.Drawing.Point(993, 253)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(285, 31)
        Me.txtName.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(993, 373)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(285, 31)
        Me.txtPhone.TabIndex = 7
        '
        'dgvOutput
        '
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(291, 625)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersWidth = 62
        Me.dgvOutput.RowTemplate.Height = 27
        Me.dgvOutput.Size = New System.Drawing.Size(739, 296)
        Me.dgvOutput.TabIndex = 8
        '
        'btnAddListing
        '
        Me.btnAddListing.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAddListing.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAddListing.Location = New System.Drawing.Point(158, 456)
        Me.btnAddListing.Name = "btnAddListing"
        Me.btnAddListing.Size = New System.Drawing.Size(274, 116)
        Me.btnAddListing.TabIndex = 9
        Me.btnAddListing.Text = "Add a Listing to the Current Directory"
        Me.btnAddListing.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRemove.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(894, 456)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(274, 116)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove a Listing from the Current Directory"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(154, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Phone Directories"
        '
        'lstDirectories
        '
        Me.lstDirectories.FormattingEnabled = True
        Me.lstDirectories.ItemHeight = 18
        Me.lstDirectories.Location = New System.Drawing.Point(30, 158)
        Me.lstDirectories.Name = "lstDirectories"
        Me.lstDirectories.Size = New System.Drawing.Size(464, 256)
        Me.lstDirectories.TabIndex = 13
        '
        'TelephoneDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 956)
        Me.Controls.Add(Me.lstDirectories)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddListing)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCurrentDirectory)
        Me.Controls.Add(Me.btnNewDirectory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TelephoneDirectory"
        Me.Text = "Telephone Directory"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNewDirectory As Button
    Friend WithEvents txtCurrentDirectory As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents btnAddListing As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lstDirectories As ListBox
End Class
