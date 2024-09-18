Public Class Form1

    Dim OUNCES_PER_POUND As Double = 16
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim itemPrice, pounds, ounces, pricePerOunce As Double

        itemPrice = CDbl(txtPriceOfItem.Text)
        pounds = CDbl(txtPounds.Text)
        ounces = CDbl(txtOunces.Text)

        pricePerOunce = itemPrice / ((pounds * OUNCES_PER_POUND) + ounces)

        txtPricePerOunce.Text = pricePerOunce.ToString("C2")
    End Sub
End Class
