<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnderdogAndWS
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
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.hsbUnderdog = New System.Windows.Forms.HScrollBar()
        Me.hsbFavorite = New System.Windows.Forms.HScrollBar()
        Me.hsbFourGames = New System.Windows.Forms.HScrollBar()
        Me.hsbFiveGames = New System.Windows.Forms.HScrollBar()
        Me.hsbSixGames = New System.Windows.Forms.HScrollBar()
        Me.hsbSevenGames = New System.Windows.Forms.HScrollBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAvgDuration = New System.Windows.Forms.TextBox()
        Me.txtUnderdogPercent = New System.Windows.Forms.TextBox()
        Me.txtUnderdog = New System.Windows.Forms.TextBox()
        Me.txtSixGamesPercent = New System.Windows.Forms.TextBox()
        Me.txtSixGames = New System.Windows.Forms.TextBox()
        Me.txtSevenGamesPercent = New System.Windows.Forms.TextBox()
        Me.txtSevenGames = New System.Windows.Forms.TextBox()
        Me.txtFavorite = New System.Windows.Forms.TextBox()
        Me.txtFourGamesPercent = New System.Windows.Forms.TextBox()
        Me.txtFourGames = New System.Windows.Forms.TextBox()
        Me.txtFavoritePercent = New System.Windows.Forms.TextBox()
        Me.txtFiveGamesPercent = New System.Windows.Forms.TextBox()
        Me.txtFiveGames = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSimulate
        '
        Me.btnSimulate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSimulate.Location = New System.Drawing.Point(977, 24)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(370, 45)
        Me.btnSimulate.TabIndex = 0
        Me.btnSimulate.Text = "Simulate Outcomes of 10,000 World Series"
        Me.btnSimulate.UseVisualStyleBackColor = False
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(231, 37)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(41, 25)
        Me.txtInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Probability of underdog winning a game:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(650, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Winner"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(533, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 36)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Duration of World Series"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Underdog:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Favorite:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Four games:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Five Games:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 593)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Six games:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 678)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Seven games:"
        '
        'hsbUnderdog
        '
        Me.hsbUnderdog.Location = New System.Drawing.Point(174, 126)
        Me.hsbUnderdog.Maximum = 10000
        Me.hsbUnderdog.Name = "hsbUnderdog"
        Me.hsbUnderdog.Size = New System.Drawing.Size(888, 26)
        Me.hsbUnderdog.TabIndex = 12
        '
        'hsbFavorite
        '
        Me.hsbFavorite.Location = New System.Drawing.Point(174, 223)
        Me.hsbFavorite.Maximum = 10000
        Me.hsbFavorite.Name = "hsbFavorite"
        Me.hsbFavorite.Size = New System.Drawing.Size(888, 26)
        Me.hsbFavorite.TabIndex = 13
        '
        'hsbFourGames
        '
        Me.hsbFourGames.Location = New System.Drawing.Point(174, 419)
        Me.hsbFourGames.Maximum = 10000
        Me.hsbFourGames.Name = "hsbFourGames"
        Me.hsbFourGames.Size = New System.Drawing.Size(888, 26)
        Me.hsbFourGames.TabIndex = 14
        '
        'hsbFiveGames
        '
        Me.hsbFiveGames.Location = New System.Drawing.Point(174, 500)
        Me.hsbFiveGames.Maximum = 10000
        Me.hsbFiveGames.Name = "hsbFiveGames"
        Me.hsbFiveGames.Size = New System.Drawing.Size(888, 26)
        Me.hsbFiveGames.TabIndex = 15
        '
        'hsbSixGames
        '
        Me.hsbSixGames.Location = New System.Drawing.Point(174, 585)
        Me.hsbSixGames.Maximum = 10000
        Me.hsbSixGames.Name = "hsbSixGames"
        Me.hsbSixGames.Size = New System.Drawing.Size(888, 26)
        Me.hsbSixGames.TabIndex = 16
        '
        'hsbSevenGames
        '
        Me.hsbSevenGames.Location = New System.Drawing.Point(174, 667)
        Me.hsbSevenGames.Maximum = 10000
        Me.hsbSevenGames.Name = "hsbSevenGames"
        Me.hsbSevenGames.Size = New System.Drawing.Size(888, 29)
        Me.hsbSevenGames.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(442, 744)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(252, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Average duration of World Series"
        '
        'txtAvgDuration
        '
        Me.txtAvgDuration.Location = New System.Drawing.Point(722, 737)
        Me.txtAvgDuration.Name = "txtAvgDuration"
        Me.txtAvgDuration.Size = New System.Drawing.Size(100, 25)
        Me.txtAvgDuration.TabIndex = 20
        '
        'txtUnderdogPercent
        '
        Me.txtUnderdogPercent.Location = New System.Drawing.Point(1263, 119)
        Me.txtUnderdogPercent.Name = "txtUnderdogPercent"
        Me.txtUnderdogPercent.Size = New System.Drawing.Size(100, 25)
        Me.txtUnderdogPercent.TabIndex = 21
        '
        'txtUnderdog
        '
        Me.txtUnderdog.Location = New System.Drawing.Point(1100, 118)
        Me.txtUnderdog.Name = "txtUnderdog"
        Me.txtUnderdog.Size = New System.Drawing.Size(100, 25)
        Me.txtUnderdog.TabIndex = 22
        '
        'txtSixGamesPercent
        '
        Me.txtSixGamesPercent.Location = New System.Drawing.Point(1263, 585)
        Me.txtSixGamesPercent.Name = "txtSixGamesPercent"
        Me.txtSixGamesPercent.Size = New System.Drawing.Size(100, 25)
        Me.txtSixGamesPercent.TabIndex = 23
        '
        'txtSixGames
        '
        Me.txtSixGames.Location = New System.Drawing.Point(1100, 590)
        Me.txtSixGames.Name = "txtSixGames"
        Me.txtSixGames.Size = New System.Drawing.Size(100, 25)
        Me.txtSixGames.TabIndex = 24
        '
        'txtSevenGamesPercent
        '
        Me.txtSevenGamesPercent.Location = New System.Drawing.Point(1263, 675)
        Me.txtSevenGamesPercent.Name = "txtSevenGamesPercent"
        Me.txtSevenGamesPercent.Size = New System.Drawing.Size(100, 25)
        Me.txtSevenGamesPercent.TabIndex = 25
        '
        'txtSevenGames
        '
        Me.txtSevenGames.Location = New System.Drawing.Point(1100, 675)
        Me.txtSevenGames.Name = "txtSevenGames"
        Me.txtSevenGames.Size = New System.Drawing.Size(100, 25)
        Me.txtSevenGames.TabIndex = 26
        '
        'txtFavorite
        '
        Me.txtFavorite.Location = New System.Drawing.Point(1100, 223)
        Me.txtFavorite.Name = "txtFavorite"
        Me.txtFavorite.Size = New System.Drawing.Size(100, 25)
        Me.txtFavorite.TabIndex = 27
        '
        'txtFourGamesPercent
        '
        Me.txtFourGamesPercent.Location = New System.Drawing.Point(1263, 419)
        Me.txtFourGamesPercent.Name = "txtFourGamesPercent"
        Me.txtFourGamesPercent.Size = New System.Drawing.Size(100, 25)
        Me.txtFourGamesPercent.TabIndex = 28
        '
        'txtFourGames
        '
        Me.txtFourGames.Location = New System.Drawing.Point(1100, 420)
        Me.txtFourGames.Name = "txtFourGames"
        Me.txtFourGames.Size = New System.Drawing.Size(100, 25)
        Me.txtFourGames.TabIndex = 29
        '
        'txtFavoritePercent
        '
        Me.txtFavoritePercent.Location = New System.Drawing.Point(1263, 223)
        Me.txtFavoritePercent.Name = "txtFavoritePercent"
        Me.txtFavoritePercent.Size = New System.Drawing.Size(100, 25)
        Me.txtFavoritePercent.TabIndex = 30
        '
        'txtFiveGamesPercent
        '
        Me.txtFiveGamesPercent.Location = New System.Drawing.Point(1263, 500)
        Me.txtFiveGamesPercent.Name = "txtFiveGamesPercent"
        Me.txtFiveGamesPercent.Size = New System.Drawing.Size(100, 25)
        Me.txtFiveGamesPercent.TabIndex = 32
        '
        'txtFiveGames
        '
        Me.txtFiveGames.Location = New System.Drawing.Point(1100, 501)
        Me.txtFiveGames.Name = "txtFiveGames"
        Me.txtFiveGames.Size = New System.Drawing.Size(100, 25)
        Me.txtFiveGames.TabIndex = 33
        '
        'UnderdogAndWS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1381, 796)
        Me.Controls.Add(Me.txtFiveGames)
        Me.Controls.Add(Me.txtFiveGamesPercent)
        Me.Controls.Add(Me.txtFavoritePercent)
        Me.Controls.Add(Me.txtFourGames)
        Me.Controls.Add(Me.txtFourGamesPercent)
        Me.Controls.Add(Me.txtFavorite)
        Me.Controls.Add(Me.txtSevenGames)
        Me.Controls.Add(Me.txtSevenGamesPercent)
        Me.Controls.Add(Me.txtSixGames)
        Me.Controls.Add(Me.txtSixGamesPercent)
        Me.Controls.Add(Me.txtUnderdog)
        Me.Controls.Add(Me.txtUnderdogPercent)
        Me.Controls.Add(Me.txtAvgDuration)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.hsbSevenGames)
        Me.Controls.Add(Me.hsbSixGames)
        Me.Controls.Add(Me.hsbFiveGames)
        Me.Controls.Add(Me.hsbFourGames)
        Me.Controls.Add(Me.hsbFavorite)
        Me.Controls.Add(Me.hsbUnderdog)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnSimulate)
        Me.Name = "UnderdogAndWS"
        Me.Text = "Underdog and the World Series"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimulate As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents hsbUnderdog As HScrollBar
    Friend WithEvents hsbFavorite As HScrollBar
    Friend WithEvents hsbFourGames As HScrollBar
    Friend WithEvents hsbFiveGames As HScrollBar
    Friend WithEvents hsbSixGames As HScrollBar
    Friend WithEvents hsbSevenGames As HScrollBar
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAvgDuration As TextBox
    Friend WithEvents txtUnderdogPercent As TextBox
    Friend WithEvents txtUnderdog As TextBox
    Friend WithEvents txtSixGamesPercent As TextBox
    Friend WithEvents txtSixGames As TextBox
    Friend WithEvents txtSevenGamesPercent As TextBox
    Friend WithEvents txtSevenGames As TextBox
    Friend WithEvents txtFavorite As TextBox
    Friend WithEvents txtFourGamesPercent As TextBox
    Friend WithEvents txtFourGames As TextBox
    Friend WithEvents txtFavoritePercent As TextBox
    Friend WithEvents txtFiveGamesPercent As TextBox
    Friend WithEvents txtFiveGames As TextBox
End Class
