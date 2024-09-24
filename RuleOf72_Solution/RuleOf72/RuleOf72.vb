Public Class RuleOf72
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim years As Integer
        Dim rate As Integer = 1
        Const RuleNumber As Integer = 72

        For i = 1 To 20
            years = RuleNumber / rate
            lstOutput.Items.Add($"For rate {rate}%, it will take {years} to double." + vbCr)
            rate += 1
        Next

    End Sub
End Class
