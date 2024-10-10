Public Class VotingMachine

    Dim totals() As Integer
    Private Sub VotingMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnNominate_Click(sender As Object, e As EventArgs) Handles btnNominate.Click
        Dim candidate As String
        candidate = InputBox("Please nominate a candidate for office.", "Candidate")
        lstCandidates.Items.Add(candidate)

    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        lblInstructions.Text = "Vote for a candidate by" &
                              " double-clicking on his/her name. " &
                              "End the voting by clicking on 'Tally Votes'."
    End Sub

    Private Sub lstCandidates_DoubleClick(sender As Object, e As EventArgs) Handles lstCandidates.DoubleClick
        ReDim Preserve totals(lstCandidates.Items.Count - 1)

        totals(lstCandidates.SelectedIndex) += 1
        MessageBox.Show("Thank you for voting for " + lstCandidates.SelectedItem.ToString() + ".")
    End Sub

    Private Sub btnVotes_Click(sender As Object, e As EventArgs) Handles btnVotes.Click
        lstVotes.Visible = True
        For Each vote In totals
            lstVotes.Items.Add(vote)
        Next


        Dim winners(totals.Count - 1) As Integer
        Dim highest As Integer = totals.Max()

        For i As Integer = 0 To totals.Count - 1
            If totals(i) = highest Then
                winners(i) = 1
            Else
                winners(i) = 0
            End If
        Next


        Dim allWinners As String
        For i As Integer = 0 To winners.Count() - 1
            If winners(i) = 1 Then
                allWinners += lstCandidates.Items.Item(i).ToString() + ", "
            End If
        Next


        MessageBox.Show("The winner(s) is/are " & allWinners & "who won with " & totals.Max & " votes.")

    End Sub
End Class
