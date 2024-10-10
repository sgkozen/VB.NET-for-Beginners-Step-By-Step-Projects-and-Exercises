<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFormal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumPassengers = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWeights
        '
        Me.lblWeights.Location = New System.Drawing.Point(406, 104)
        Me.lblWeights.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(76, 44)
        Me.lblWeights.TabIndex = 26
        Me.lblWeights.Text = "Total must equal 100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 179)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Average age of passengers:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(318, 175)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(52, 20)
        Me.txtAge.TabIndex = 24
        Me.txtAge.Text = "25"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Formal dining expected:"
        '
        'txtFormal
        '
        Me.txtFormal.Location = New System.Drawing.Point(318, 137)
        Me.txtFormal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFormal.Name = "txtFormal"
        Me.txtFormal.Size = New System.Drawing.Size(52, 20)
        Me.txtFormal.TabIndex = 22
        Me.txtFormal.Text = "25"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Geographical region:"
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(318, 100)
        Me.txtRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(52, 20)
        Me.txtRegion.TabIndex = 20
        Me.txtRegion.Text = "25"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ship size (number of passengers):"
        '
        'txtNumPassengers
        '
        Me.txtNumPassengers.Location = New System.Drawing.Point(318, 66)
        Me.txtNumPassengers.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumPassengers.Name = "txtNumPassengers"
        Me.txtNumPassengers.Size = New System.Drawing.Size(52, 20)
        Me.txtNumPassengers.TabIndex = 18
        Me.txtNumPassengers.Text = "25"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(135, 228)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 28)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(261, 228)
        Me.btnBegin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(80, 28)
        Me.btnBegin.TabIndex = 16
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 42)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "This wizard will assist you in selecting a cruise that most closely matches your " &
    "interests. Please assign percentage weights to the following criteria."
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 285)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFormal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumPassengers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuise Selection Wizard"
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWeights As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFormal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumPassengers As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBegin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents errProvider As ErrorProvider
End Class
