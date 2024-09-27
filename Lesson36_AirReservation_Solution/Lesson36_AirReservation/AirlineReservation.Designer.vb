<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AirlineReservation
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
        Me.lstWaitingList = New System.Windows.Forms.ListBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.mtbSeatCol = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSeatRow = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtName.Location = New System.Drawing.Point(186, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(434, 31)
        Me.txtName.TabIndex = 0
        '
        'lstWaitingList
        '
        Me.lstWaitingList.FormattingEnabled = True
        Me.lstWaitingList.ItemHeight = 18
        Me.lstWaitingList.Location = New System.Drawing.Point(186, 591)
        Me.lstWaitingList.Name = "lstWaitingList"
        Me.lstWaitingList.Size = New System.Drawing.Size(435, 202)
        Me.lstWaitingList.TabIndex = 1
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 60
        Me.lstOutput.Location = New System.Drawing.Point(715, 218)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(456, 664)
        Me.lstOutput.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(186, 189)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(435, 60)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Passenger"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(186, 296)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(435, 62)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Passenger"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(186, 411)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(435, 62)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'mtbSeatCol
        '
        Me.mtbSeatCol.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.mtbSeatCol.Location = New System.Drawing.Point(1048, 93)
        Me.mtbSeatCol.Mask = "L"
        Me.mtbSeatCol.Name = "mtbSeatCol"
        Me.mtbSeatCol.Size = New System.Drawing.Size(123, 31)
        Me.mtbSeatCol.TabIndex = 6
        '
        'mtbSeatRow
        '
        Me.mtbSeatRow.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.mtbSeatRow.Location = New System.Drawing.Point(871, 90)
        Me.mtbSeatRow.Mask = "##"
        Me.mtbSeatRow.Name = "mtbSeatRow"
        Me.mtbSeatRow.Size = New System.Drawing.Size(123, 31)
        Me.mtbSeatRow.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(727, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Seat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Waiting List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(801, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "(1A, 1B, 1C, 2A, 2B,...10D)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Name:"
        '
        'AirlineReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 972)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtbSeatRow)
        Me.Controls.Add(Me.mtbSeatCol)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lstWaitingList)
        Me.Controls.Add(Me.txtName)
        Me.Name = "AirlineReservation"
        Me.Text = "Airline Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lstWaitingList As ListBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents mtbSeatCol As MaskedTextBox
    Friend WithEvents mtbSeatRow As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
