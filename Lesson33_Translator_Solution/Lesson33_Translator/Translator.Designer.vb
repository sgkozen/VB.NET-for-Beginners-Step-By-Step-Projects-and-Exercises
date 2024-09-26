<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Translator
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
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.txtFrench = New System.Windows.Forms.TextBox()
        Me.txtGerman = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEnglish
        '
        Me.txtEnglish.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtEnglish.Location = New System.Drawing.Point(269, 40)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(877, 29)
        Me.txtEnglish.TabIndex = 0
        '
        'txtFrench
        '
        Me.txtFrench.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFrench.Location = New System.Drawing.Point(269, 352)
        Me.txtFrench.Name = "txtFrench"
        Me.txtFrench.Size = New System.Drawing.Size(877, 29)
        Me.txtFrench.TabIndex = 1
        '
        'txtGerman
        '
        Me.txtGerman.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtGerman.Location = New System.Drawing.Point(269, 490)
        Me.txtGerman.Name = "txtGerman"
        Me.txtGerman.Size = New System.Drawing.Size(877, 29)
        Me.txtGerman.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "English Sentence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "French Sentence"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 497)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "German Sentence"
        '
        'btnTranslate
        '
        Me.btnTranslate.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTranslate.Location = New System.Drawing.Point(398, 168)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(577, 87)
        Me.btnTranslate.TabIndex = 6
        Me.btnTranslate.Text = "Translate Sentence"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'Translator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 564)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGerman)
        Me.Controls.Add(Me.txtFrench)
        Me.Controls.Add(Me.txtEnglish)
        Me.Name = "Translator"
        Me.Text = "Rudimentary Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents txtFrench As TextBox
    Friend WithEvents txtGerman As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTranslate As Button
End Class
