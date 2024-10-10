Public Class SpreadOfEpidemic

    Dim dayNumber As Integer
    Dim people() As Integer = {9700, 200, 100, 0}

    Private Sub btnDay0_Click(sender As Object, e As EventArgs) Handles btnDay0.Click
        DrawGraph(pbGraph)
    End Sub



    Private Sub DrawGraph(picOutput As Object)
        Dim g As Graphics = picOutput.CreateGraphics()
        picOutput.Refresh()
        g.DrawLine(Pens.Black, 45, 100, picOutput.Width, 100)
        g.DrawLine(Pens.Black, 45, 100, 45, 0)
        g.DrawLine(Pens.Black, 40, 0, 50, 0)
        g.DrawString("10000", Me.Font, Brushes.Blue, 0, 0)
        g.DrawString("Susceptible     Sick 1 Day     Sick 2 Days     Immune", Me.Font, Brushes.Blue, 42, 102)


        For i As Integer = 0 To people.Count() - 1
            g.FillRectangle(Brushes.Blue, 60 + i * 75, CInt(100 - people(i) / 100), 25, CInt(people(i) / 100))
        Next
        g.DrawString("Day " & dayNumber, Me.Font, Brushes.Blue, 125, 0)
    End Sub

    Private Sub btnAdvance_Click(sender As Object, e As EventArgs) Handles btnAdvance.Click
        Dim totalSick As Integer
        dayNumber += 1
        totalSick = people(1) + people(2)
        people(3) = people(3) + people(2)
        people(2) = people(1)
        people(1) = CInt(0.0001735 * totalSick * people(0))
        people(0) = 10000 - people(1) - people(2) - people(3)
        DrawGraph(pbGraph)

    End Sub
End Class
