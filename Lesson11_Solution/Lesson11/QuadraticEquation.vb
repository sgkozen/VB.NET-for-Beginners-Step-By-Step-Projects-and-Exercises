Public Class QuadraticEquation
    Private Sub BtnFindSolution_Click(sender As Object, e As EventArgs) Handles btnFindSolution.Click
        Dim a As Integer = CInt(txtA.Text)
        Dim b As Integer = CInt(txtB.Text)
        Dim c As Integer = CInt(txtC.Text)

        If txtA.Text <> "0" Then
            a = CInt(txtA.Text)
            b = CInt(txtB.Text)
            c = CInt(txtC.Text)
        Else
            MessageBox.Show("Please correct your input for 'a'.", "Must be non-zero", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Dim checkSolutions As Integer = (b ^ 2) - (4 * a * c)

        If checkSolutions = 0 Then
            Dim solutionA As Double = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            txtSolutions.Text = $"There is one solution: {solutionA}"
        ElseIf checkSolutions < 0 Then
            txtSolutions.Text = "There are no solutions."
        ElseIf checkSolutions > 0 Then
            Dim solutionA As Double = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            Dim solutionB As Double = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            txtSolutions.Text = $"There are 2 solutions: {solutionA.ToString("N2")} and  {solutionB.ToString("N2")}"
        End If
    End Sub
End Class
