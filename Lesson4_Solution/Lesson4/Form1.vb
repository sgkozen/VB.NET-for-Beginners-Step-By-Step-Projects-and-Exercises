Public Class Form1
    Dim enteredAmount, quarters, dimes, nickles, pennies As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If IsNumeric(txtAmount.Text) And txtAmount.Text <> "" Then
            enteredAmount = CDbl(txtAmount.Text)
            quarters = Int(enteredAmount / 25)
            enteredAmount -= quarters * 25
            dimes = Int(enteredAmount / 10)
            enteredAmount -= dimes * 10
            nickles = Int(enteredAmount / 5)
            enteredAmount -= nickles * 5
            pennies = Int(enteredAmount / 1)

            txt25.Text = quarters
            txt10.Text = dimes
            txt5.Text = nickles
            txt1.Text = pennies
        Else
            txtAmount.Text = "Please enter a numerical value."

        End If
    End Sub


End Class
