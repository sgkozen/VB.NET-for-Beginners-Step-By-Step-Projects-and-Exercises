Public Class SoccerLeague

    Const NumTeams = 6
    Structure Teams
        Dim name As String
        Dim wins As Integer
    End Structure

    Dim teamArr(NumTeams - 1) As Teams
    Dim data(,) As Integer = {
                                {-1, 1, 1, 0, 0, 1},
                                {0, -1, 1, 1, 0, 0},
                                {0, 0, -1, 0, 1, 1},
                                {1, 0, 1, -1, 1, 1},
                                {1, 1, 0, 0, -1, 1},
                                {0, 1, 0, 0, 0, -1}
                                }


    Private Sub AssignNames()
        teamArr(0).name = "Jazz"
        teamArr(1).name = "Jets"
        teamArr(2).name = "Owls"
        teamArr(3).name = "Rams"
        teamArr(4).name = "Cubs"
        teamArr(5).name = "Zips"
    End Sub




    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        AssignNames()
    End Sub
End Class
