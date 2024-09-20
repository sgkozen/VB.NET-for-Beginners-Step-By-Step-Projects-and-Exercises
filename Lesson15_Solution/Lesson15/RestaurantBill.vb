Public Class RestaurantBill

    Dim pizzas As Integer = 0
    Dim fries As Integer = 0
    Dim drinks As Integer = 0
    Dim pizzaCost As Double = 1.75
    Dim friesCost As Double = 2.0
    Dim drinkCost As Double = 1.25

    Private Sub GetOrderQuantity()
        If Integer.TryParse(txtPizza.Text, pizzas) And Integer.TryParse(txtFries.Text, fries) And Integer.TryParse(txtDrinks.Text, drinks) Then
        Else
            MessageBox.Show("Input is not a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function CalculateCost(pizzas As Integer, fries As Integer, drinks As Integer) As Double
        Dim totalCost As Double
        totalCost = pizzas * pizzaCost + fries * friesCost + drinks * drinkCost

        Return (totalCost.ToString("C2"))

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        GetOrderQuantity()

        lstDisplay.Items.Add("ITEM" + vbTab + "    QUANTITY" + vbTab + "PRICE")

        If pizzas > 0 Then
            lstDisplay.Items.Add("Pizza" + vbTab + vbTab + pizzas.ToString() + vbTab + FormatCurrency(pizzas * pizzaCost))
        End If


        If fries > 0 Then
            lstDisplay.Items.Add("Fries" + vbTab + vbTab + fries.ToString() + vbTab + FormatCurrency(fries * friesCost))
        End If

        If drinks > 0 Then
            lstDisplay.Items.Add("Drinks" + vbTab + vbTab + drinks.ToString() + vbTab + FormatCurrency(drinks * drinkCost))
        End If


        lstDisplay.Items.Add("TOTAL COST")
        lstDisplay.Items.Add("$" & CalculateCost(pizzas, fries, drinks))


    End Sub
End Class
