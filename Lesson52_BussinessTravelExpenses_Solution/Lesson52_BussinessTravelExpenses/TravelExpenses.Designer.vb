<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TravelExpenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TravelExpenses))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOrgVisited = New System.Windows.Forms.TextBox()
        Me.txtDates = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtMealsEnt = New System.Windows.Forms.TextBox()
        Me.txtAirFare = New System.Windows.Forms.TextBox()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.txtTaxiFare = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Organization visited:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dates:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(300, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meals and Entertainment:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(265, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Airplane fare:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lodging:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(292, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Taxi fares:"
        '
        'txtOrgVisited
        '
        Me.txtOrgVisited.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOrgVisited.Location = New System.Drawing.Point(473, 26)
        Me.txtOrgVisited.Name = "txtOrgVisited"
        Me.txtOrgVisited.Size = New System.Drawing.Size(184, 29)
        Me.txtOrgVisited.TabIndex = 7
        '
        'txtDates
        '
        Me.txtDates.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDates.Location = New System.Drawing.Point(473, 78)
        Me.txtDates.Name = "txtDates"
        Me.txtDates.Size = New System.Drawing.Size(184, 29)
        Me.txtDates.TabIndex = 8
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(473, 130)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(184, 29)
        Me.txtLocation.TabIndex = 9
        '
        'txtMealsEnt
        '
        Me.txtMealsEnt.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMealsEnt.Location = New System.Drawing.Point(473, 189)
        Me.txtMealsEnt.Name = "txtMealsEnt"
        Me.txtMealsEnt.Size = New System.Drawing.Size(184, 29)
        Me.txtMealsEnt.TabIndex = 10
        '
        'txtAirFare
        '
        Me.txtAirFare.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAirFare.Location = New System.Drawing.Point(473, 249)
        Me.txtAirFare.Name = "txtAirFare"
        Me.txtAirFare.Size = New System.Drawing.Size(184, 29)
        Me.txtAirFare.TabIndex = 11
        '
        'txtLodging
        '
        Me.txtLodging.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLodging.Location = New System.Drawing.Point(473, 302)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(184, 29)
        Me.txtLodging.TabIndex = 12
        '
        'txtTaxiFare
        '
        Me.txtTaxiFare.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtTaxiFare.Location = New System.Drawing.Point(473, 363)
        Me.txtTaxiFare.Name = "txtTaxiFare"
        Me.txtTaxiFare.Size = New System.Drawing.Size(184, 29)
        Me.txtTaxiFare.TabIndex = 13
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(157, 426)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(503, 69)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print Business Travel Expenses Attachment"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(157, 522)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(503, 74)
        Me.btnPreview.TabIndex = 15
        Me.btnPreview.Text = "Preview Business Travel Expenses Attachment"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TravelExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 612)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtTaxiFare)
        Me.Controls.Add(Me.txtLodging)
        Me.Controls.Add(Me.txtAirFare)
        Me.Controls.Add(Me.txtMealsEnt)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtDates)
        Me.Controls.Add(Me.txtOrgVisited)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TravelExpenses"
        Me.Text = "Business Travel Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOrgVisited As TextBox
    Friend WithEvents txtDates As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtMealsEnt As TextBox
    Friend WithEvents txtAirFare As TextBox
    Friend WithEvents txtLodging As TextBox
    Friend WithEvents txtTaxiFare As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
