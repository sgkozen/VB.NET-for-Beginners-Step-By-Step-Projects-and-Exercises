Public Class TravelExpenses
    Const OneInch As Integer = 75
    Const LineHeight As Integer = 15

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim str As String
        Dim x1 As Integer = OneInch
        Dim x2 As Integer = 5 * OneInch
        Dim y As Integer = 2 * OneInch
        Dim font As New Font("Times New Roman", 12, FontStyle.Bold)

        str = "Business Travel Expenses"
        g.DrawString(str, font, Brushes.Black, x1, y)
        font = New Font("Times New Roman", 12, FontStyle.Regular)
        y += 2 * LineHeight
        str = "Trip to attend meeting of"
        g.DrawString(str, font, Brushes.Black, x1, y)
        y += LineHeight
        g.DrawString(txtOrgVisited.Text, font, Brushes.Black, x1, y)
        y += LineHeight
        str = txtDates.Text + " in " + txtLocation.Text + "."
        g.DrawString(str, font, Brushes.Black, x1, y)
        y += 2 * LineHeight
        g.DrawString(Label4.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtMealsEnt.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += LineHeight
        g.DrawString(Label5.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtAirFare.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += LineHeight
        g.DrawString(Label6.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtLodging.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += LineHeight
        g.DrawString(Label7.Text, font, Brushes.Black, x1, y)
        g.DrawString((CDbl(txtTaxiFare.Text)).ToString("C"), font, Brushes.Black, x2, y)
        y += 2 * LineHeight
        Dim other As Double = CDbl(txtAirFare.Text) + CDbl(txtLodging.Text) + CDbl(txtTaxiFare.Text)
        str = "Total other than meals and entertainment: " + other.ToString("C")
        g.DrawString(str, font, Brushes.Black, x1, y)
        y += LineHeight
        str = "50% of meals and entertainment: " + (CDbl(txtMealsEnt.Text) / 2).ToString("C")
        g.DrawString(str, font, Brushes.Black, x1, y)
        y += 2 * LineHeight
        str = "TOTAL DEDUCTABLE EXPENSES: " + ((CDbl(txtMealsEnt.Text) / 2) + other).ToString("C")
        g.DrawString(str, font, Brushes.Black, x1, y)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
