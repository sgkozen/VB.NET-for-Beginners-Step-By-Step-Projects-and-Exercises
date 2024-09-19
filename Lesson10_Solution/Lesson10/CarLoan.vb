Imports System.ComponentModel

Public Class CarLoan


    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Dim monthlyPayments, totalInterest, loanAmount, rate As Double
        Dim duration As Integer


        If Double.TryParse(txtAmountOfLoan.Text, loanAmount) And Double.TryParse(txtInterestRate.Text, rate) And Integer.TryParse(txtDuration.Text, duration) Then
        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        rate = rate / 100

            monthlyPayments = (loanAmount * rate / 12) / (1 - (1 + rate / 12) ^ (-duration))

        totalInterest = (duration * monthlyPayments) - loanAmount

        txtMonthlyPayments.Text = monthlyPayments.ToString("C2")

        txtInterestPaid.Text = totalInterest.ToString("C2")



    End Sub











End Class
