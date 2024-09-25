Public Class Depreciation
    Dim item As String
    Dim purchaseYear, numYears As Integer
    Dim cost As Double

    Private Function ValidateInput()
        item = txtDesc.Text
        If item <> "" And Integer.TryParse(txtYear.Text, purchaseYear) And Integer.TryParse(txtNumYears.Text, numYears) And Double.TryParse(txtCost.Text, cost) Then
            Return True
        Else
            MessageBox.Show("Correct your input.", "Input is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function


    Private Sub btnStraight_Click(sender As Object, e As EventArgs) Handles btnStraight.Click

        If ValidateInput() Then
            ShowTable(1)
        End If








    End Sub

    Private Sub btnDouble_Click(sender As Object, e As EventArgs) Handles btnDouble.Click
        If ValidateInput() Then
            ShowTable(2)
        End If
    End Sub


    Private Sub ShowTable(method As Integer)
        Dim depreciation As Double
        Dim totalDepreciation As Double = 0
        Dim value = cost
        Dim straightLine As Double
        lstOutput.Items.Clear()
        ShowHeadings(method)

        If method = 1 Then
            straightLine = (1 / numYears) * cost
        End If

        For yr As Integer = 1 To numYears
            If yr <> numYears Then
                If method = 1 Then
                    depreciation = straightLine
                Else
                    depreciation = (2 / numYears) * value
                End If


            Else
                depreciation = value
            End If
            totalDepreciation += depreciation

            lstOutput.Items.Add("Value at the beginning of " & purchaseYear + yr - 1 & ": " & value.ToString("C"))
            lstOutput.Items.Add("Amount of depreciation during " & purchaseYear + yr - 1 & ": " & depreciation.ToString("C"))
            lstOutput.Items.Add("Total depreciation at the end of  " & purchaseYear + yr - 1 & ": " & totalDepreciation.ToString("C"))
            lstOutput.Items.Add("")

            value = value - depreciation

        Next



    End Sub













    Private Sub ShowHeadings(method As Integer)
        lstOutput.Items.Add("Description: " & item)
        lstOutput.Items.Add("Year of Purchase: " & purchaseYear)
        lstOutput.Items.Add("Cost: " & cost.ToString("C"))
        lstOutput.Items.Add("Estimated life: " & numYears)

        If method = 1 Then
            lstOutput.Items.Add("Method: Straigth Line")
        ElseIf method = 2 Then
            lstOutput.Items.Add("Method: Double-Declining Balance")
        End If

        lstOutput.Items.Add("")
    End Sub





End Class
