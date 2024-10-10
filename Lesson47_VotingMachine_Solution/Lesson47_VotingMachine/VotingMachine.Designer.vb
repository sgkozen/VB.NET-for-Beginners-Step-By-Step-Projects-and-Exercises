<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotingMachine
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lstCandidates = New System.Windows.Forms.ListBox()
        Me.lstVotes = New System.Windows.Forms.ListBox()
        Me.btnNominate = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnVotes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(178, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(635, 72)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Click ""Nominate Candidate"" to enter a candidate, or ""Start Voting"" to end nominat" &
    "ions and begin voting."
        '
        'lstCandidates
        '
        Me.lstCandidates.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstCandidates.FormattingEnabled = True
        Me.lstCandidates.ItemHeight = 30
        Me.lstCandidates.Location = New System.Drawing.Point(182, 133)
        Me.lstCandidates.Name = "lstCandidates"
        Me.lstCandidates.Size = New System.Drawing.Size(363, 484)
        Me.lstCandidates.TabIndex = 1
        '
        'lstVotes
        '
        Me.lstVotes.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstVotes.FormattingEnabled = True
        Me.lstVotes.ItemHeight = 30
        Me.lstVotes.Location = New System.Drawing.Point(604, 133)
        Me.lstVotes.Name = "lstVotes"
        Me.lstVotes.Size = New System.Drawing.Size(253, 484)
        Me.lstVotes.TabIndex = 2
        Me.lstVotes.Visible = False
        '
        'btnNominate
        '
        Me.btnNominate.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNominate.Location = New System.Drawing.Point(60, 654)
        Me.btnNominate.Name = "btnNominate"
        Me.btnNominate.Size = New System.Drawing.Size(253, 228)
        Me.btnNominate.TabIndex = 3
        Me.btnNominate.Text = "Nominate Candidate"
        Me.btnNominate.UseVisualStyleBackColor = True
        '
        'btnVote
        '
        Me.btnVote.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnVote.Location = New System.Drawing.Point(365, 654)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(258, 228)
        Me.btnVote.TabIndex = 4
        Me.btnVote.Text = "Start Voting"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnVotes
        '
        Me.btnVotes.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnVotes.Location = New System.Drawing.Point(693, 654)
        Me.btnVotes.Name = "btnVotes"
        Me.btnVotes.Size = New System.Drawing.Size(243, 228)
        Me.btnVotes.TabIndex = 5
        Me.btnVotes.Text = "Tally Votes"
        Me.btnVotes.UseVisualStyleBackColor = True
        '
        'VotingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 983)
        Me.Controls.Add(Me.btnVotes)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnNominate)
        Me.Controls.Add(Me.lstVotes)
        Me.Controls.Add(Me.lstCandidates)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "VotingMachine"
        Me.Text = "Voting Machine"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents lstCandidates As ListBox
    Friend WithEvents lstVotes As ListBox
    Friend WithEvents btnNominate As Button
    Friend WithEvents btnVote As Button
    Friend WithEvents btnVotes As Button
End Class
