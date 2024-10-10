Public Class UnderdogAndWS

    Dim randomNumber As New Random

    Private Sub UnderdogAndWS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        Dim games As Integer
        Dim winner As String
        ResetControls()
        For i As Integer = 1 To 10000
            PlaySeries(winner, games)
            If winner = "Underdog Wins!" Then
                hsbUnderdog.Value = hsbUnderdog.Value + 1
            Else
                hsbFavorite.Value = hsbFavorite.Value + 1
            End If

            Select Case games
                Case 4
                    hsbFourGames.Value = hsbFourGames.Value + 1
                Case 5
                    hsbFiveGames.Value = hsbFiveGames.Value + 1
                Case 6
                    hsbSixGames.Value = hsbSixGames.Value + 1
                Case 7
                    hsbSevenGames.Value = hsbSevenGames.Value + 1
            End Select

            If i Mod 10 = 0 Then
                Updates(i)
                txtUnderdog.Refresh()
                txtFavorite.Refresh()
                txtFourGames.Refresh()
                txtFiveGames.Refresh()
                txtSixGames.Refresh()
                txtSevenGames.Refresh()
                txtUnderdogPercent.Refresh()
                txtFavoritePercent.Refresh()
                txtFourGamesPercent.Refresh()
                txtFiveGamesPercent.Refresh()
                txtSixGamesPercent.Refresh()
                txtSevenGamesPercent.Refresh()
            End If
        Next
        txtAvgDuration.Text = ((4 * CDbl(hsbFourGames.Value) +
            5 * CDbl(hsbFiveGames.Value) +
            6 * CDbl(hsbSixGames.Value) +
            7 * CDbl(hsbSevenGames.Value)) / 10000).ToString("N") & " games"

    End Sub

    Private Sub Updates(numGames As Integer)
        txtUnderdog.Text = hsbUnderdog.Value.ToString()
        txtFavorite.Text = hsbFavorite.Value.ToString()
        txtFourGames.Text = hsbFourGames.Value.ToString()
        txtFiveGames.Text = hsbFiveGames.Value.ToString()
        txtSixGames.Text = hsbSixGames.Value.ToString()
        txtSevenGames.Text = hsbSevenGames.Value.ToString()
        txtUnderdogPercent.Text = (hsbUnderdog.Value / numGames).ToString("P")
        txtFavoritePercent.Text = (hsbFavorite.Value / numGames).ToString("P")
        txtFourGamesPercent.Text = (hsbFourGames.Value / numGames).ToString("P")
        txtFiveGamesPercent.Text = (hsbFiveGames.Value / numGames).ToString("P")
        txtSixGamesPercent.Text = (hsbSixGames.Value / numGames).ToString("P")
        txtSevenGamesPercent.Text = (hsbSevenGames.Value / numGames).ToString("P")
    End Sub

    Private Sub PlaySeries(ByRef winner As String, ByRef games As Integer)
        Dim underdogWins As Integer = 0
        Dim favoriteWins As Integer = 0
        Dim numGames As Integer = 0
        Dim probability As Integer = CInt(txtInput.Text)
        Dim seriesOver As Boolean = False

        Do While seriesOver = False
            If randomNumber.Next(0, 101) < probability Then
                underdogWins += 1
            Else
                favoriteWins += 1
            End If


            If underdogWins = 4 Then
                winner = "Underdog Wins!"
                seriesOver = True
            ElseIf favoriteWins = 4 Then
                winner = "Favorite Wins!"
                seriesOver = True
            End If
            numGames += 1
        Loop
        games = numGames
    End Sub



    Private Sub ResetControls()
        hsbUnderdog.Value = 0
        hsbFavorite.Value = 0
        hsbFourGames.Value = 0
        hsbFiveGames.Value = 0
        hsbSixGames.Value = 0
        hsbSevenGames.Value = 0
        Updates(1)
        txtAvgDuration.Clear()
    End Sub












End Class
