Imports System.Runtime.InteropServices.WindowsRuntime

Public Class FurnitureOrder
    Const PricePerChair As Double = 350
    Const PricePerSofa As Double = 925
    Const SalesTax As Double = 0.05


    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click
        Dim custName As String = txtName.Text, street As String = txtAddress.Text, cityStateZip As String = txtCity.Text, invoiceId As String, reversedName As String
        Dim chairs, sofas As Integer
        Dim totalDue, totalTax, orderPrice As Double


        If ValidateInput(custName, street, cityStateZip) Then
            chairs = CInt(txtChairs.Text)
            sofas = CInt(txtSofas.Text)
        End If


        totalDue = Calculate(chairs, sofas, totalTax, orderPrice)
        invoiceId = InvoiceNumber(custName, cityStateZip)
        reversedName = ReverseName(custName)

        PrintInvoice(chairs, sofas, orderPrice, totalTax, totalDue, invoiceId, reversedName, street, cityStateZip)

    End Sub


    Private Function ValidateInput(custName As String, street As String, cityStateZip As String) As Boolean
        If Not custName.Contains(", ") Or custName.Length < 4 Then
            MessageBox.Show("Invalid Name.  Make sure names are separated by a comma", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf street = "" Or cityStateZip = "" Then
            MessageBox.Show("Invalid street,state or ZIP.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not IsNumeric(txtChairs.Text) Or Not IsNumeric(txtSofas.Text) Then
            MessageBox.Show("Invalid chair or sofa quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Private Function InvoiceNumber(custName As String, cityStateZip As String) As String
        Dim zipDigits As String
        If cityStateZip = "" Then
            MessageBox.Show("Invalid street,state or ZIP.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            zipDigits = cityStateZip.Substring(cityStateZip.Length - 4)
            Return custName.Substring(0, 2).ToUpper & zipDigits
        End If

        Return "00000000"
    End Function

    Private Function Calculate(chairs As Integer, sofas As Integer, ByRef totalTax As Double, ByRef orderPrice As Double)
        orderPrice = chairs * PricePerChair + sofas * PricePerSofa
        totalTax = orderPrice * SalesTax
        Return orderPrice + totalTax
    End Function

    Private Function ReverseName(custName As String) As String
        Dim firstName, lastName As String
        Dim commaPosition As Integer
        commaPosition = custName.IndexOf(",")
        firstName = custName.Substring(commaPosition + 2)
        lastName = custName.Substring(0, commaPosition)

        Return firstName & " " & lastName
    End Function



    Private Sub PrintInvoice(chairs As Integer, sofas As Integer, orderPrice As Double, totalTax As Double, totalDue As Double, invoiceId As String, reversedName As String, street As String, cityStateZip As String)

        lstDisplay.Items.Add("Invoice Number: " + invoiceId)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Name: " + reversedName)
        lstDisplay.Items.Add("Street: " + street)
        lstDisplay.Items.Add("City, State, Zip: " + cityStateZip)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Number of Chairs: " + chairs.ToString)
        lstDisplay.Items.Add("Number of Sofas:  " + sofas.ToString)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Order Price:      " + FormatCurrency(orderPrice))
        lstDisplay.Items.Add("Sales Tax:        " + FormatCurrency(totalTax))
        lstDisplay.Items.Add("                      ------------------")
        lstDisplay.Items.Add("Total Price       " + FormatCurrency(totalDue))

    End Sub


    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each ctrl In Controls.OfType(Of TextBox)
            ctrl.Clear()
        Next

        lstDisplay.Items.Clear()
        txtName.Focus()

    End Sub

End Class
