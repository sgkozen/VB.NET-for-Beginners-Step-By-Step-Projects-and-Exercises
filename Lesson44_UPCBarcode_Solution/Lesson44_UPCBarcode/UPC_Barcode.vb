Imports System.CodeDom.Compiler

Public Class UPC_Barcode
    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        lstOutput.Items.Clear()
        mtbUpcCode.Clear()
        mtbUpcCode.Focus()
        IO.File.Delete("TempFile.txt")
        MessageBox.Show("The cash register is ready for the next customer", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Function checkUPC(upc As String) As Boolean
        Dim upcOK As Boolean = False
        Dim d(11) As Integer
        Dim code As Integer = 0

        For i As Integer = 0 To 11
            d(i) = CInt(upc.Substring(i, 1))
        Next

        code = (3 * d(0)) + d(1) + (3 * d(2)) + d(3) + (3 * d(4)) + d(5) + (3 * d(6)) + d(7) + (3 * d(8)) + d(9) + (3 * d(10)) + d(11)

        If code Mod 10 = 0 Then
            upcOK = True
        End If

        Return upcOK

    End Function

    Private Sub btnAddReceipt_Click(sender As Object, e As EventArgs) Handles btnAddReceipt.Click
        Dim tempfile As IO.StreamWriter = IO.File.AppendText("TempFile.txt")
        Dim upc As String

        If mtbUpcCode.Text.Length <> 12 Then
            MessageBox.Show("Please fill in the 12-digit UPC code", "Invalid UPC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtbUpcCode.Focus()
        End If



        upc = mtbUpcCode.Text
        If checkUPC(upc) Then
            lstOutput.Items.Add(upc + "---OK")
            mtbUpcCode.Focus()
            tempfile.WriteLine(upc)

        Else
            MessageBox.Show("Invalid UPC Code!", "Invalid UPC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        tempfile.Close()

    End Sub

    Private Sub btnDisplayReceipt_Click(sender As Object, e As EventArgs) Handles btnDisplayReceipt.Click
        lstOutput.Items.Clear()
        Dim purchaseUPC() = IO.File.ReadAllLines("TempFile.txt")
        Dim sum As Double = 0


        For i As Integer = 0 To purchaseUPC.Count() - 1
            Dim query = From product In IO.File.ReadAllLines("UPC.txt")
                        Let UPC As String = product.Split(","c)(0)
                        Let productDesc As String = product.Split(","c)(1)
                        Let price As Double = CDbl(product.Split(","c)(2))
                        Where UPC = purchaseUPC(i)
                        Select UPC, productDesc, price

            lstOutput.Items.Add(query(0).productDesc + "  " + FormatCurrency(query(0).price, 2))
            sum += query(0).price
        Next



        lstOutput.Items.Add("")
        lstOutput.Items.Add("Total " + FormatCurrency(sum))



    End Sub
End Class
