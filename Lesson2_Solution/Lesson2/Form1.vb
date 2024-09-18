Public Class Form1

    Dim firstNumber, secondNumber, result As Double

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNumber = txtFirst.Text
            secondNumber = txtSecond.Text
            result = firstNumber + secondNumber
            txtResults.Text = $"The sum of {firstNumber} + {secondNumber} = {result}"
        Else
            MessageBox.Show("Please enter a number in both boxes!")
        End If
        btnPlus.BackColor = Color.Green
        btnMinus.BackColor = Color.Red
        btnMultiply.BackColor = Color.Red
        btnDivide.BackColor = Color.Red

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNumber = txtFirst.Text
            secondNumber = txtSecond.Text
            result = firstNumber - secondNumber
            txtResults.Text = $"The difference of {firstNumber} - {secondNumber} = {result}"
        Else
            MessageBox.Show("Please enter a number in both boxes!")
        End If
        btnPlus.BackColor = Color.Red
        btnMinus.BackColor = Color.Green
        btnMultiply.BackColor = Color.Red
        btnDivide.BackColor = Color.Red
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNumber = txtFirst.Text
            secondNumber = txtSecond.Text
            result = firstNumber * secondNumber
            txtResults.Text = $"The product of {firstNumber} X {secondNumber} = {result}"
        Else
            MessageBox.Show("Please enter a number in both boxes!")
        End If
        btnPlus.BackColor = Color.Red
        btnMinus.BackColor = Color.Red
        btnMultiply.BackColor = Color.Green
        btnDivide.BackColor = Color.Red
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNumber = txtFirst.Text
            secondNumber = txtSecond.Text
            result = firstNumber / secondNumber
            txtResults.Text = $"The quotient of {firstNumber} / {secondNumber} = {result}"
        Else
            MessageBox.Show("Please enter a number in both boxes!")
        End If
        btnPlus.BackColor = Color.Red
        btnMinus.BackColor = Color.Red
        btnMultiply.BackColor = Color.Red
        btnDivide.BackColor = Color.Green
    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged
        txtResults.Clear()
    End Sub

    Private Sub txtSecond_TextChanged(sender As Object, e As EventArgs) Handles txtSecond.TextChanged
        txtResults.Clear()
    End Sub

End Class
