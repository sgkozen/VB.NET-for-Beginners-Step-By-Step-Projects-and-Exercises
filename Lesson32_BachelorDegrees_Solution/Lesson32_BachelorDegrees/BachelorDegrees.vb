Public Class BachelorDegrees
    Dim input() As String = IO.File.ReadAllLines("Degrees.txt")

    Private Sub btnFields_Click(sender As Object, e As EventArgs) Handles btnFields.Click
        Dim query = From record In input
                    Let field As String = record.Split(","c)(0)
                    Let year1981 As String = record.Split(","c)(1)
                    Let year2010 As String = record.Split(","c)(2)
                    Order By field
                    Select field, year1981, year2010

        grdOutput.DataSource = query.ToList()
        grdOutput.Columns(0).HeaderText = "Field of Study"
        grdOutput.Columns(1).HeaderText = "Year 1981"
        grdOutput.Columns(2).HeaderText = "Year 2010"
    End Sub

    Private Sub BtnPercentage_Click(sender As Object, e As EventArgs) Handles btnPercentage.Click
        Dim query = From record In input
                    Let field As String = record.Split(","c)(0)
                    Let year1981 As Integer = record.Split(","c)(1)
                    Let year2010 As Integer = record.Split(","c)(2)
                    Let change As Double = (year2010 - year1981) / year1981
                    Let changeOut As String = FormatPercent(change, 2)
                    Order By change Descending
                    Select field, changeOut

        grdOutput.DataSource = query.ToList()
        grdOutput.Columns(0).HeaderText = "Field of Study"
        grdOutput.Columns(1).HeaderText = "% Change (1981-2012)"

    End Sub


    Private Sub btnFields2010_Click(sender As Object, e As EventArgs) Handles btnFields2010.Click
        Dim query = From record In input
                    Let field As String = record.Split(","c)(0)
                    Let year2010 As Integer = record.Split(","c)(2)
                    Let chart As String = GetDots(year2010)
                    Order By year2010 Ascending
                    Select field, chart

        grdOutput.DataSource = query.ToList()
        grdOutput.Columns(0).HeaderText = "Field of Study"
        grdOutput.Columns(1).HeaderText = "Number of Degrees in 2010"

    End Sub


    Private Function GetDots(year2010 As Integer) As String
        Dim output As String
        Dim numOfDots As Integer = 0
        Dim dots As String = ""

        numOfDots = Math.Round(year2010, 0) / 10000

        For i As Integer = 0 To numOfDots
            dots += "*"
        Next
        output = dots & "  " & year2010.ToString("N0")
        Return output
    End Function

















    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub


End Class
