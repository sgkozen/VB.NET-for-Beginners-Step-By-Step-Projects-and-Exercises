Public Class LoanCalculator

    Private Overloads Function Validate(val1 As String, val2 As String, val3 As String)
        If IsNumeric(val1) And IsNumeric(val2) And IsNumeric(val3) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim amount As String = txtAmount.Text
        Dim intRate As String = txtInterestRate.Text
        Dim duration As String = txtDuration.Text
        Dim payment As String = txtMonthlyPayment.Text

        If radAmountOfLoan.Checked And Validate(duration, intRate, payment) Then
            txtAmount.Text = (PV(CDbl(intRate) / 1200, CDbl(duration), -CDbl(payment))).ToString("C")
        ElseIf radInterestRate.Checked And Validate(amount, duration, payment) Then
            txtInterestRate.Text = ((1200 * Rate(CDbl(duration), CDbl(payment), -CDbl(amount))) * 0.01).ToString("P")
        ElseIf radDurationOfLoan.Checked And Validate(amount, intRate, payment) Then
            txtDuration.Text = (NPer(CDbl(intRate) / 1200, CDbl(payment), -CDbl(amount))).ToString("C2")
        ElseIf radMonthlyPayment.Checked And Validate(amount, intRate, duration) Then
            txtMonthlyPayment.Text = (Pmt(CDbl(intRate) / 1200, CDbl(duration), -CDbl(amount))).ToString("C2")
        Else
            MessageBox.Show("Please correct your input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Clear()
        txtInterestRate.Clear()
        txtDuration.Clear()
        txtMonthlyPayment.Clear()
    End Sub

End Class
