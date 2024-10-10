<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryControl
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
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNonfiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValuesAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValuesFiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValuesNonFiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.ItemHeight = 18
        Me.lstBooks.Location = New System.Drawing.Point(34, 63)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(384, 418)
        Me.lstBooks.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BookToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.mnuValues})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(482, 54)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSaveFile, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 50)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddBook, Me.mnuDeleteBook, Me.mnuUpdateBook})
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(69, 50)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'mnuAddBook
        '
        Me.mnuAddBook.Name = "mnuAddBook"
        Me.mnuAddBook.Size = New System.Drawing.Size(270, 34)
        Me.mnuAddBook.Text = "Add"
        '
        'mnuDeleteBook
        '
        Me.mnuDeleteBook.Name = "mnuDeleteBook"
        Me.mnuDeleteBook.Size = New System.Drawing.Size(270, 34)
        Me.mnuDeleteBook.Text = "Delete"
        '
        'mnuUpdateBook
        '
        Me.mnuUpdateBook.Name = "mnuUpdateBook"
        Me.mnuUpdateBook.Size = New System.Drawing.Size(270, 34)
        Me.mnuUpdateBook.Text = "Update"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAll, Me.mnuFiction, Me.mnuNonfiction})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(86, 50)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'mnuAll
        '
        Me.mnuAll.Name = "mnuAll"
        Me.mnuAll.Size = New System.Drawing.Size(270, 34)
        Me.mnuAll.Text = "All"
        '
        'mnuFiction
        '
        Me.mnuFiction.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.mnuFiction.Name = "mnuFiction"
        Me.mnuFiction.Size = New System.Drawing.Size(270, 34)
        Me.mnuFiction.Text = "Fiction"
        '
        'mnuNonfiction
        '
        Me.mnuNonfiction.Name = "mnuNonfiction"
        Me.mnuNonfiction.Size = New System.Drawing.Size(270, 34)
        Me.mnuNonfiction.Text = "Nonfiction"
        '
        'mnuValues
        '
        Me.mnuValues.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuValuesAll, Me.mnuValuesFiction, Me.mnuValuesNonFiction})
        Me.mnuValues.Name = "mnuValues"
        Me.mnuValues.Size = New System.Drawing.Size(78, 50)
        Me.mnuValues.Text = "Values"
        '
        'mnuSaveFile
        '
        Me.mnuSaveFile.Name = "mnuSaveFile"
        Me.mnuSaveFile.Size = New System.Drawing.Size(270, 34)
        Me.mnuSaveFile.Text = "Save"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(270, 34)
        Me.mnuExit.Text = "Exit"
        '
        'mnuValuesAll
        '
        Me.mnuValuesAll.Name = "mnuValuesAll"
        Me.mnuValuesAll.Size = New System.Drawing.Size(270, 34)
        Me.mnuValuesAll.Text = "All"
        '
        'mnuValuesFiction
        '
        Me.mnuValuesFiction.Name = "mnuValuesFiction"
        Me.mnuValuesFiction.Size = New System.Drawing.Size(270, 34)
        Me.mnuValuesFiction.Text = "Fiction"
        '
        'mnuValuesNonFiction
        '
        Me.mnuValuesNonFiction.Name = "mnuValuesNonFiction"
        Me.mnuValuesNonFiction.Size = New System.Drawing.Size(270, 34)
        Me.mnuValuesNonFiction.Text = "NonFiction"
        '
        'InventoryControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 341)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InventoryControl"
        Me.Text = "Inventory Control (main form)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBooks As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuValues As ToolStripMenuItem
    Friend WithEvents mnuAll As ToolStripMenuItem
    Friend WithEvents mnuFiction As ToolStripMenuItem
    Friend WithEvents mnuNonfiction As ToolStripMenuItem
    Friend WithEvents mnuAddBook As ToolStripMenuItem
    Friend WithEvents mnuDeleteBook As ToolStripMenuItem
    Friend WithEvents mnuUpdateBook As ToolStripMenuItem
    Friend WithEvents mnuSaveFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuValuesAll As ToolStripMenuItem
    Friend WithEvents mnuValuesFiction As ToolStripMenuItem
    Friend WithEvents mnuValuesNonFiction As ToolStripMenuItem
End Class
