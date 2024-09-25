Public Class AlphabeticalOrder


    Private Function IsTrippleConsecutive(word As String) As Boolean
        Dim isConsecutive As Boolean = False
        Dim L1, L2, L3 As Integer

        For i As Integer = 0 To word.Length - 3
            L1 = Asc(word.ToUpper().Substring(i, 1))
            L2 = Asc(word.ToUpper().Substring(i + 1, 1))
            L3 = Asc(word.ToUpper().Substring(i + 2, 1))

            If L1 + 1 = L2 And L2 + 1 = L3 Then
                isConsecutive = True
                Return isConsecutive
            Else
                isConsecutive = False
            End If

        Next
        Return isConsecutive

    End Function

    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim word As String = txtWord.Text

        If IsTrippleConsecutive(word) Then
            txtOutput.Text = "YES"
        Else
            txtOutput.Text = "NO"
        End If
    End Sub

End Class
