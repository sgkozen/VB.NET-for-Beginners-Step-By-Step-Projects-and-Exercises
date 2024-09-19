<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollegeAdmissions
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
        Me.txtGPAScore = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpSAT = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.grpHSQuality = New System.Windows.Forms.GroupBox()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.grpCurriculum = New System.Windows.Forms.GroupBox()
        Me.RadioButton21 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpGeo = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.grpAlum = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.grpEssay = New System.Windows.Forms.GroupBox()
        Me.grpLS = New System.Windows.Forms.GroupBox()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.RadioButton22 = New System.Windows.Forms.RadioButton()
        Me.RadioButton23 = New System.Windows.Forms.RadioButton()
        Me.RadioButton24 = New System.Windows.Forms.RadioButton()
        Me.RadioButton25 = New System.Windows.Forms.RadioButton()
        Me.RadioButton26 = New System.Windows.Forms.RadioButton()
        Me.RadioButton27 = New System.Windows.Forms.RadioButton()
        Me.RadioButton28 = New System.Windows.Forms.RadioButton()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.btmGroup = New System.Windows.Forms.GroupBox()
        Me.topGroup = New System.Windows.Forms.GroupBox()
        Me.grpSAT.SuspendLayout()
        Me.grpHSQuality.SuspendLayout()
        Me.grpCurriculum.SuspendLayout()
        Me.grpGeo.SuspendLayout()
        Me.grpAlum.SuspendLayout()
        Me.grpEssay.SuspendLayout()
        Me.grpLS.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.btmGroup.SuspendLayout()
        Me.topGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGPAScore
        '
        Me.txtGPAScore.Location = New System.Drawing.Point(491, 47)
        Me.txtGPAScore.Name = "txtGPAScore"
        Me.txtGPAScore.Size = New System.Drawing.Size(100, 25)
        Me.txtGPAScore.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(675, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 25)
        Me.TextBox2.TabIndex = 1
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(932, 185)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(241, 141)
        Me.txtOutput.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCalculate.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(932, 47)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(241, 91)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Score"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter GPA"
        '
        'grpSAT
        '
        Me.grpSAT.Controls.Add(Me.RadioButton5)
        Me.grpSAT.Controls.Add(Me.RadioButton4)
        Me.grpSAT.Controls.Add(Me.RadioButton3)
        Me.grpSAT.Controls.Add(Me.RadioButton2)
        Me.grpSAT.Controls.Add(Me.RadioButton1)
        Me.grpSAT.Location = New System.Drawing.Point(23, 36)
        Me.grpSAT.Name = "grpSAT"
        Me.grpSAT.Size = New System.Drawing.Size(215, 273)
        Me.grpSAT.TabIndex = 5
        Me.grpSAT.TabStop = False
        Me.grpSAT.Text = "SAT"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(21, 240)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(149, 22)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Tag = "12"
        Me.RadioButton5.Text = "1360-1600 [12]"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(21, 192)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(149, 22)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Tag = "11"
        Me.RadioButton4.Text = "1200-1350 [11]"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(21, 139)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(149, 22)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Tag = "10"
        Me.RadioButton3.Text = "1010-1190 [10]"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 88)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(131, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "6"
        Me.RadioButton2.Text = "930-1000 [6]"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(21, 35)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(122, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = "0"
        Me.RadioButton1.Text = "400-920 [0]"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'grpHSQuality
        '
        Me.grpHSQuality.Controls.Add(Me.RadioButton20)
        Me.grpHSQuality.Controls.Add(Me.RadioButton11)
        Me.grpHSQuality.Controls.Add(Me.RadioButton10)
        Me.grpHSQuality.Controls.Add(Me.RadioButton9)
        Me.grpHSQuality.Controls.Add(Me.RadioButton8)
        Me.grpHSQuality.Controls.Add(Me.RadioButton7)
        Me.grpHSQuality.Controls.Add(Me.RadioButton6)
        Me.grpHSQuality.Location = New System.Drawing.Point(310, 36)
        Me.grpHSQuality.Name = "grpHSQuality"
        Me.grpHSQuality.Size = New System.Drawing.Size(217, 263)
        Me.grpHSQuality.TabIndex = 0
        Me.grpHSQuality.TabStop = False
        Me.grpHSQuality.Text = "High School Quality"
        '
        'RadioButton20
        '
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.Location = New System.Drawing.Point(335, 92)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton20.TabIndex = 14
        Me.RadioButton20.TabStop = True
        Me.RadioButton20.Tag = "4"
        Me.RadioButton20.Text = "2 [4]"
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(101, 212)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(77, 22)
        Me.RadioButton11.TabIndex = 5
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Tag = "10"
        Me.RadioButton11.Text = "5 [10]"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(101, 129)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton10.TabIndex = 4
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Tag = "8"
        Me.RadioButton10.Text = "4 [8]"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(101, 56)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton9.TabIndex = 3
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Tag = "6"
        Me.RadioButton9.Text = "3 [6]"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(17, 212)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton8.TabIndex = 2
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Tag = "4"
        Me.RadioButton8.Text = "2 [4]"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(17, 129)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton7.TabIndex = 1
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Tag = "2"
        Me.RadioButton7.Text = "1 [2]"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(17, 56)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Tag = "0"
        Me.RadioButton6.Text = "0 [0]"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(137, 34)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton13.TabIndex = 10
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Tag = "4"
        Me.RadioButton13.Text = "2 [4]"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(158, 268)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(77, 22)
        Me.RadioButton12.TabIndex = 11
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Tag = "10"
        Me.RadioButton12.Text = "5 [10]"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Location = New System.Drawing.Point(137, 156)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton18.TabIndex = 12
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.Tag = "8"
        Me.RadioButton18.Text = "4 [8]"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.Location = New System.Drawing.Point(137, 92)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton19.TabIndex = 13
        Me.RadioButton19.TabStop = True
        Me.RadioButton19.Tag = "6"
        Me.RadioButton19.Text = "3 [6]"
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'grpCurriculum
        '
        Me.grpCurriculum.Controls.Add(Me.RadioButton21)
        Me.grpCurriculum.Controls.Add(Me.RadioButton17)
        Me.grpCurriculum.Controls.Add(Me.RadioButton15)
        Me.grpCurriculum.Controls.Add(Me.RadioButton14)
        Me.grpCurriculum.Controls.Add(Me.RadioButton19)
        Me.grpCurriculum.Controls.Add(Me.RadioButton18)
        Me.grpCurriculum.Controls.Add(Me.RadioButton12)
        Me.grpCurriculum.Controls.Add(Me.RadioButton13)
        Me.grpCurriculum.Location = New System.Drawing.Point(601, 36)
        Me.grpCurriculum.Name = "grpCurriculum"
        Me.grpCurriculum.Size = New System.Drawing.Size(245, 263)
        Me.grpCurriculum.TabIndex = 0
        Me.grpCurriculum.TabStop = False
        Me.grpCurriculum.Text = "Difficulty of Curriculum"
        '
        'RadioButton21
        '
        Me.RadioButton21.AutoSize = True
        Me.RadioButton21.Location = New System.Drawing.Point(23, 212)
        Me.RadioButton21.Name = "RadioButton21"
        Me.RadioButton21.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton21.TabIndex = 17
        Me.RadioButton21.TabStop = True
        Me.RadioButton21.Tag = "2"
        Me.RadioButton21.Text = "1 [2]"
        Me.RadioButton21.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(23, 156)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(68, 22)
        Me.RadioButton17.TabIndex = 16
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.Tag = "0"
        Me.RadioButton17.Text = "0 [0]"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(23, 92)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(86, 22)
        Me.RadioButton15.TabIndex = 15
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Tag = "-2"
        Me.RadioButton15.Text = "-1 [-2]"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(23, 34)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(86, 22)
        Me.RadioButton14.TabIndex = 14
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Tag = "-4"
        Me.RadioButton14.Text = "-2 [-4]"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(645, 186)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(86, 22)
        Me.RadioButton16.TabIndex = 7
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Tag = "-2"
        Me.RadioButton16.Text = "-1 [-2]"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Maximum of 40 Points"
        '
        'grpGeo
        '
        Me.grpGeo.Controls.Add(Me.CheckBox3)
        Me.grpGeo.Controls.Add(Me.CheckBox2)
        Me.grpGeo.Controls.Add(Me.CheckBox1)
        Me.grpGeo.Location = New System.Drawing.Point(31, 60)
        Me.grpGeo.Name = "grpGeo"
        Me.grpGeo.Size = New System.Drawing.Size(376, 183)
        Me.grpGeo.TabIndex = 9
        Me.grpGeo.TabStop = False
        Me.grpGeo.Text = "Geography"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(30, 130)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(360, 33)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Tag = "2"
        Me.CheckBox3.Text = "Underrepresented State [2]"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(30, 83)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(449, 33)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Tag = "6"
        Me.CheckBox2.Text = "Underrepresented State County [6]"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(30, 35)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(270, 33)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Tag = "10"
        Me.CheckBox1.Text = "State Resident [10]"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grpAlum
        '
        Me.grpAlum.Controls.Add(Me.CheckBox5)
        Me.grpAlum.Controls.Add(Me.CheckBox4)
        Me.grpAlum.Location = New System.Drawing.Point(31, 299)
        Me.grpAlum.Name = "grpAlum"
        Me.grpAlum.Size = New System.Drawing.Size(383, 172)
        Me.grpAlum.TabIndex = 10
        Me.grpAlum.TabStop = False
        Me.grpAlum.Text = "Alumnus"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(23, 47)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(291, 22)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Tag = "4"
        Me.CheckBox4.Text = "Legacy (parents, step-parents) [4]"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(23, 114)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(417, 33)
        Me.CheckBox5.TabIndex = 1
        Me.CheckBox5.Tag = "1"
        Me.CheckBox5.Text = "Other (grandparents, siblings) [1]"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'grpEssay
        '
        Me.grpEssay.Controls.Add(Me.RadioButton24)
        Me.grpEssay.Controls.Add(Me.RadioButton23)
        Me.grpEssay.Controls.Add(Me.RadioButton22)
        Me.grpEssay.Location = New System.Drawing.Point(501, 66)
        Me.grpEssay.Name = "grpEssay"
        Me.grpEssay.Size = New System.Drawing.Size(237, 177)
        Me.grpEssay.TabIndex = 11
        Me.grpEssay.TabStop = False
        Me.grpEssay.Text = "Essay"
        '
        'grpLS
        '
        Me.grpLS.Controls.Add(Me.CheckBox8)
        Me.grpLS.Controls.Add(Me.CheckBox7)
        Me.grpLS.Controls.Add(Me.CheckBox6)
        Me.grpLS.Location = New System.Drawing.Point(501, 299)
        Me.grpLS.Name = "grpLS"
        Me.grpLS.Size = New System.Drawing.Size(237, 201)
        Me.grpLS.TabIndex = 12
        Me.grpLS.TabStop = False
        Me.grpLS.Text = "Leadership and Service"
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.RadioButton28)
        Me.grpMisc.Controls.Add(Me.RadioButton27)
        Me.grpMisc.Controls.Add(Me.RadioButton26)
        Me.grpMisc.Controls.Add(Me.RadioButton25)
        Me.grpMisc.Location = New System.Drawing.Point(855, 75)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(390, 425)
        Me.grpMisc.TabIndex = 13
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Miscellaneous"
        '
        'RadioButton22
        '
        Me.RadioButton22.AutoSize = True
        Me.RadioButton22.Location = New System.Drawing.Point(26, 39)
        Me.RadioButton22.Name = "RadioButton22"
        Me.RadioButton22.Size = New System.Drawing.Size(207, 33)
        Me.RadioButton22.TabIndex = 0
        Me.RadioButton22.TabStop = True
        Me.RadioButton22.Tag = "1"
        Me.RadioButton22.Text = "Very Good [1]"
        Me.RadioButton22.UseVisualStyleBackColor = True
        '
        'RadioButton23
        '
        Me.RadioButton23.AutoSize = True
        Me.RadioButton23.Location = New System.Drawing.Point(26, 88)
        Me.RadioButton23.Name = "RadioButton23"
        Me.RadioButton23.Size = New System.Drawing.Size(191, 33)
        Me.RadioButton23.TabIndex = 1
        Me.RadioButton23.TabStop = True
        Me.RadioButton23.Tag = "2"
        Me.RadioButton23.Text = "Excellent [2]"
        Me.RadioButton23.UseVisualStyleBackColor = True
        '
        'RadioButton24
        '
        Me.RadioButton24.AutoSize = True
        Me.RadioButton24.Location = New System.Drawing.Point(26, 135)
        Me.RadioButton24.Name = "RadioButton24"
        Me.RadioButton24.Size = New System.Drawing.Size(224, 33)
        Me.RadioButton24.TabIndex = 2
        Me.RadioButton24.TabStop = True
        Me.RadioButton24.Tag = "3"
        Me.RadioButton24.Text = "Outstanding [3]"
        Me.RadioButton24.UseVisualStyleBackColor = True
        '
        'RadioButton25
        '
        Me.RadioButton25.AutoSize = True
        Me.RadioButton25.Location = New System.Drawing.Point(53, 59)
        Me.RadioButton25.Name = "RadioButton25"
        Me.RadioButton25.Size = New System.Drawing.Size(287, 22)
        Me.RadioButton25.TabIndex = 0
        Me.RadioButton25.TabStop = True
        Me.RadioButton25.Tag = "20"
        Me.RadioButton25.Text = "Socioeconomic Disadvantage [20]"
        Me.RadioButton25.UseVisualStyleBackColor = True
        '
        'RadioButton26
        '
        Me.RadioButton26.AutoSize = True
        Me.RadioButton26.Location = New System.Drawing.Point(53, 146)
        Me.RadioButton26.Name = "RadioButton26"
        Me.RadioButton26.Size = New System.Drawing.Size(169, 22)
        Me.RadioButton26.TabIndex = 1
        Me.RadioButton26.TabStop = True
        Me.RadioButton26.Tag = "5"
        Me.RadioButton26.Text = "Men in Nursing [5]"
        Me.RadioButton26.UseVisualStyleBackColor = True
        '
        'RadioButton27
        '
        Me.RadioButton27.AutoSize = True
        Me.RadioButton27.Location = New System.Drawing.Point(53, 241)
        Me.RadioButton27.Name = "RadioButton27"
        Me.RadioButton27.Size = New System.Drawing.Size(214, 22)
        Me.RadioButton27.TabIndex = 2
        Me.RadioButton27.TabStop = True
        Me.RadioButton27.Tag = "20"
        Me.RadioButton27.Text = "Scholarship Athlete [20]"
        Me.RadioButton27.UseVisualStyleBackColor = True
        '
        'RadioButton28
        '
        Me.RadioButton28.AutoSize = True
        Me.RadioButton28.Location = New System.Drawing.Point(59, 338)
        Me.RadioButton28.Name = "RadioButton28"
        Me.RadioButton28.Size = New System.Drawing.Size(208, 22)
        Me.RadioButton28.TabIndex = 3
        Me.RadioButton28.TabStop = True
        Me.RadioButton28.Tag = "20"
        Me.RadioButton28.Text = "Provot's discretion [20]"
        Me.RadioButton28.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(25, 42)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(152, 33)
        Me.CheckBox6.TabIndex = 0
        Me.CheckBox6.Tag = "1"
        Me.CheckBox6.Text = "State [1]"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(26, 99)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(185, 33)
        Me.CheckBox7.TabIndex = 1
        Me.CheckBox7.Tag = "2"
        Me.CheckBox7.Text = "Regional [2]"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(26, 160)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(183, 33)
        Me.CheckBox8.TabIndex = 2
        Me.CheckBox8.Tag = "5"
        Me.CheckBox8.Text = "National [5]"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'btmGroup
        '
        Me.btmGroup.Controls.Add(Me.grpMisc)
        Me.btmGroup.Controls.Add(Me.grpLS)
        Me.btmGroup.Controls.Add(Me.grpEssay)
        Me.btmGroup.Controls.Add(Me.grpAlum)
        Me.btmGroup.Controls.Add(Me.grpGeo)
        Me.btmGroup.Controls.Add(Me.Label2)
        Me.btmGroup.Location = New System.Drawing.Point(37, 460)
        Me.btmGroup.Name = "btmGroup"
        Me.btmGroup.Size = New System.Drawing.Size(1274, 542)
        Me.btmGroup.TabIndex = 14
        Me.btmGroup.TabStop = False
        '
        'topGroup
        '
        Me.topGroup.Controls.Add(Me.grpCurriculum)
        Me.topGroup.Controls.Add(Me.RadioButton16)
        Me.topGroup.Controls.Add(Me.grpHSQuality)
        Me.topGroup.Controls.Add(Me.grpSAT)
        Me.topGroup.Location = New System.Drawing.Point(39, 101)
        Me.topGroup.Name = "topGroup"
        Me.topGroup.Size = New System.Drawing.Size(873, 337)
        Me.topGroup.TabIndex = 15
        Me.topGroup.TabStop = False
        '
        'CollegeAdmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 1014)
        Me.Controls.Add(Me.topGroup)
        Me.Controls.Add(Me.btmGroup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtGPAScore)
        Me.Name = "CollegeAdmissions"
        Me.Text = "College Admissions"
        Me.grpSAT.ResumeLayout(False)
        Me.grpSAT.PerformLayout()
        Me.grpHSQuality.ResumeLayout(False)
        Me.grpHSQuality.PerformLayout()
        Me.grpCurriculum.ResumeLayout(False)
        Me.grpCurriculum.PerformLayout()
        Me.grpGeo.ResumeLayout(False)
        Me.grpGeo.PerformLayout()
        Me.grpAlum.ResumeLayout(False)
        Me.grpAlum.PerformLayout()
        Me.grpEssay.ResumeLayout(False)
        Me.grpEssay.PerformLayout()
        Me.grpLS.ResumeLayout(False)
        Me.grpLS.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.btmGroup.ResumeLayout(False)
        Me.btmGroup.PerformLayout()
        Me.topGroup.ResumeLayout(False)
        Me.topGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGPAScore As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grpSAT As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents grpHSQuality As GroupBox
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton20 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents grpCurriculum As GroupBox
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton21 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents grpGeo As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents grpAlum As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents grpEssay As GroupBox
    Friend WithEvents RadioButton24 As RadioButton
    Friend WithEvents RadioButton23 As RadioButton
    Friend WithEvents RadioButton22 As RadioButton
    Friend WithEvents grpLS As GroupBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents grpMisc As GroupBox
    Friend WithEvents RadioButton28 As RadioButton
    Friend WithEvents RadioButton27 As RadioButton
    Friend WithEvents RadioButton26 As RadioButton
    Friend WithEvents RadioButton25 As RadioButton
    Friend WithEvents btmGroup As GroupBox
    Friend WithEvents topGroup As GroupBox
End Class
