Public Class frmDetails
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        If txtAuthor.Text = "" Or txtTitle.Text = "" Or txtStock.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Please complete all fields.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If InventoryControl.flagNewBook Then
                ReDim Preserve InventoryControl.books(InventoryControl.numOfBooks)
                InventoryControl.books(InventoryControl.numOfBooks).title = txtTitle.Text
                InventoryControl.books(InventoryControl.numOfBooks).author = txtAuthor.Text
                InventoryControl.books(InventoryControl.numOfBooks).price = CDbl(txtPrice.Text)
                InventoryControl.books(InventoryControl.numOfBooks).stock = CInt(txtStock.Text)
                If rdbFiction.Checked Then
                    InventoryControl.books(InventoryControl.numOfBooks).category = "F"
                Else
                    InventoryControl.books(InventoryControl.numOfBooks).category = "N"
                End If
                InventoryControl.numOfBooks += 1
            Else
                InventoryControl.books(InventoryControl.n).title = txtTitle.Text
                InventoryControl.books(InventoryControl.n).author = txtAuthor.Text
                InventoryControl.books(InventoryControl.n).price = CDbl(txtPrice.Text)
                InventoryControl.books(InventoryControl.n).stock = CInt(txtStock.Text)
                If rdbFiction.Checked Then
                    InventoryControl.books(InventoryControl.n).category = "F"
                Else
                    InventoryControl.books(InventoryControl.n).category = "N"
                End If
            End If
        End If
        Close()
    End Sub
End Class