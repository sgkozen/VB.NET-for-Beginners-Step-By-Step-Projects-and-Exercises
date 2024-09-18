Public Class Form1
    Dim labor, parts, total As Double
    Dim custName As String
    Dim laborCost As Double = 35
    Dim salesTax As Double = 0.05
    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstDisplay.Items.Clear()
        If IsNumeric(txtLabor.Text) And IsNumeric(txtParts.Text) And txtName.Text <> "" Then
            labor = CDbl(txtLabor.Text)
            parts = CDbl(txtParts.Text)
            custName = txtName.Text
            Dim laborTotal As Double = labor * laborCost
            Dim partsCost As Double = (parts * salesTax) + (parts)
            total = laborTotal + partsCost

            lstDisplay.Items.Add("Customer: " & custName)
            lstDisplay.Items.Add("Labor Cost: " & FormatCurrency(laborTotal))
            lstDisplay.Items.Add("Parts: " & "$" & partsCost)
            lstDisplay.Items.Add("Grand Total: " & "$" & total)
        Else
            MessageBox.Show("Please enter a valid number.")
        End If





    End Sub
End Class
