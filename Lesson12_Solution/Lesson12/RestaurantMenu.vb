Public Class RestaurantMenu
    Private Sub chkBurgers_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurgers.CheckedChanged
        If chkBurgers.Checked Then
            grpBurgers.Visible = True
            regBurger.Checked = True
        Else
            grpBurgers.Visible = False
        End If
    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked Then
            grpFries.Visible = True
            medFries.Checked = True
        Else
            grpFries.Visible = False
        End If
    End Sub

    Private Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrinks.CheckedChanged
        If chkDrinks.Checked Then
            grpDrinks.Visible = True
            soda.Checked = True
        Else
            grpDrinks.Visible = False
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sum As Double = 0
        If chkBurgers.Checked Then
            If regBurger.Checked Then
                sum += 4.19
            ElseIf wCheese.Checked Then
                sum += 4.79
            ElseIf wBacon.Checked Then
                sum += 4.79
            ElseIf wBaconAndCheese.Checked Then
                sum += 5.39
            Else
                sum += 0
            End If
        End If

        If chkFries.Checked Then
            If smlFries.Checked Then
                sum += 2.39
            ElseIf medFries.Checked Then
                sum += 3.09
            ElseIf lrgFries.Checked Then
                sum += 4.99
            Else
                sum += 0
            End If
        End If

        If chkDrinks.Checked Then
            If soda.Checked Then
                sum += 1.69
            ElseIf btlWater.Checked Then
                sum += 1.49
            Else
                sum += 0
            End If
        End If

        txtCost.Text = sum.ToString("C2")
    End Sub

End Class
