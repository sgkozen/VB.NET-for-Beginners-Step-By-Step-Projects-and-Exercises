Public Class Nutrition
    Dim string3 As String
    Dim caloriesPerGram As Double = 9
    Dim AHA_RECOMMENDATION As Double = 0.3
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim foodName = txtNameOfFood.Text
        Dim caloriesPerServing = CDbl(txtCaloriesPerServing.Text)
        Dim gramsOfFat = CDbl(TxtGramsOfFat.Text)
        Dim caloriesFromFat As Double = gramsOfFat * caloriesPerGram
        Dim calorieRatio As Double = caloriesFromFat / caloriesPerServing

        Dim string1 As String = foodName & " has " & caloriesPerServing & " calories per serving."
        Dim string2 As String = caloriesFromFat & " calories come from fat, which is " & (calorieRatio * 100).ToString("N1") & "%."


        If calorieRatio > AHA_RECOMMENDATION Then

            string3 = "This food Does NOT meet AHA standards."
        Else
            string3 = "This food meets AHA standards."
        End If

        txtDisplay.Text = foodName & Environment.NewLine & string1 & Environment.NewLine & string2 & Environment.NewLine & string3

    End Sub

End Class
