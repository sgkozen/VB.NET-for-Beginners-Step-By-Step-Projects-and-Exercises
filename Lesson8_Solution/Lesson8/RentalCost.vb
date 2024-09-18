Public Class RentalCost
    Private Sub btnDisplayRates_Click(sender As Object, e As EventArgs) Handles btnDisplayRates.Click
        lstRentalRates.Items.Add("Price of Equipment" & vbTab & vbTab & "Half Day" & vbTab & "Full Day")
        lstRentalRates.Items.Add("1. Rug Cleaner" & vbTab & vbTab & "$16.00" & vbTab & "$24.00")
        lstRentalRates.Items.Add("2. Lawn Mower" & vbTab & vbTab & "$12.00" & vbTab & "$18.00")
        lstRentalRates.Items.Add("3. Paint Sprayer" & vbTab & vbTab & "$20.00" & vbTab & "$30.00")
    End Sub

    Private Sub btnDisplayBill_Click(sender As Object, e As EventArgs) Handles btnDisplayBill.Click
        lstBill.Items.Clear()
        If (txtItem.Text = "1" Or txtItem.Text = "2" Or txtItem.Text = "3") And (txtDuration.Text.ToUpper() = "H" Or txtDuration.Text.ToUpper() = "F") Then
            Const deposit = 30
            Dim item, duration As String
            Dim itemCost As Double


            item = txtItem.Text
            duration = txtDuration.Text.ToUpper()

            Select Case item
                Case "1"
                    item = "Rug Cleaner"
                    itemCost = 16
                Case "2"
                    item = "Lawn Mower"
                    itemCost = 12
                Case "3"
                    item = "Paint Sprayer"
                    itemCost = 20
            End Select

            If duration = "F" Then
                itemCost *= 1.5
                duration = "Full Day"
            Else
                duration = "Half Day"
            End If

            lstBill.Items.Add("Receipt for your equipment rental.")
            lstBill.Items.Add("")
            lstBill.Items.Add(item & ": " & itemCost.ToString("C2") & "  " & duration)
            lstBill.Items.Add("Deposit: " & deposit.ToString("C2"))
            lstBill.Items.Add("")
            lstBill.Items.Add("Total: " & (deposit + itemCost).ToString("C2"))







        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK)


        End If

    End Sub


End Class
