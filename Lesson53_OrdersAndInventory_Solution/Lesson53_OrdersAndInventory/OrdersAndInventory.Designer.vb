<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersAndInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.btnOutOfStock = New System.Windows.Forms.Button()
        Me.btnBills = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MICROLANDDataSet = New Lesson53_OrdersAndInventory.MICROLANDDataSet()
        Me.CustomersTableAdapter = New Lesson53_OrdersAndInventory.MICROLANDDataSetTableAdapters.CustomersTableAdapter()
        Me.InventoryTableAdapter = New Lesson53_OrdersAndInventory.MICROLANDDataSetTableAdapters.InventoryTableAdapter()
        Me.OrdersTableAdapter = New Lesson53_OrdersAndInventory.MICROLANDDataSetTableAdapters.OrdersTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MICROLANDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOutOfStock
        '
        Me.btnOutOfStock.Location = New System.Drawing.Point(20, 34)
        Me.btnOutOfStock.Name = "btnOutOfStock"
        Me.btnOutOfStock.Size = New System.Drawing.Size(193, 88)
        Me.btnOutOfStock.TabIndex = 0
        Me.btnOutOfStock.Text = "Out of Stock Items"
        Me.btnOutOfStock.UseVisualStyleBackColor = True
        '
        'btnBills
        '
        Me.btnBills.Location = New System.Drawing.Point(557, 34)
        Me.btnBills.Name = "btnBills"
        Me.btnBills.Size = New System.Drawing.Size(193, 88)
        Me.btnBills.TabIndex = 1
        Me.btnBills.Text = "Bills for Today's Orders"
        Me.btnBills.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 18
        Me.lstOutput.Location = New System.Drawing.Point(20, 158)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(727, 562)
        Me.lstOutput.TabIndex = 2
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Orders"
        Me.BindingSource1.DataSource = Me.MICROLANDDataSet
        '
        'MICROLANDDataSet
        '
        Me.MICROLANDDataSet.DataSetName = "MICROLANDDataSet"
        Me.MICROLANDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrdersAndInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 735)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnBills)
        Me.Controls.Add(Me.btnOutOfStock)
        Me.Name = "OrdersAndInventory"
        Me.Text = "Orders and Inventory Manager"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MICROLANDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOutOfStock As Button
    Friend WithEvents btnBills As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MICROLANDDataSet As MICROLANDDataSet
    Friend WithEvents CustomersTableAdapter As MICROLANDDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents InventoryTableAdapter As MICROLANDDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents OrdersTableAdapter As MICROLANDDataSetTableAdapters.OrdersTableAdapter
End Class
