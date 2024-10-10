Public Class BlackJack
    Dim player, dealer
    Dim WithEvents deck As CardDeck


    Private Sub BlackJack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player = New Hand()
        dealer = New Hand()
        deck = New CardDeck()

        NewHand()
        txtOutput.Clear()
    End Sub


    Private Sub NewHand()
        player.Clear()
        dealer.Clear()
        lstPlayer.Items.Clear()
        lstDealer.Items.Clear()
        txtPlayer.Clear()
        txtDealer.Clear()
        txtOutput.Clear()
        deck.ShuffleDeck()
        DealDealer()
        DealPlayer()
        DealPlayer()

    End Sub


    Private Sub DealPlayer()
        Dim card As Card
        card = deck.Deal()
        player.Deal(card)
        lstPlayer.Items.Add(card.IdentifyCard())
        txtPlayer.Text = player.Score().ToString()
    End Sub

    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        If (player.LastStored < 5) And (player.Score < 21) And (dealer.LastStored = 1) Then
            DealPlayer()
        End If


        If (player.LastStored = 5) Or (player.Score > 21) Then
            Hold()
        End If
    End Sub

    Private Sub Hold()
        Do
            DealDealer()
        Loop Until (player.Score > 21) Or (dealer.Score > 16) Or (dealer.LastStored = 5)
        txtOutput.Text = Result()
    End Sub

    Private Function Result() As String
        If player.Score > 21 Then
            Return "You busted - Dealer wins!"
        End If

        If dealer.score > 21 Then
            Return "Dealer busted - You win!"
        End If

        If player.LastStored = 5 Then
            If dealer.LastStored = 5 Then
                Return "Both hands reached 5 - Push"
            End If
            Return "Hand reached 5 - You win!"
        End If

        If dealer.LastStored = 5 Then
            Return "Dealer's hand reached 5 - Dealer wins!"
        End If

        Select Case player.Score
            Case Is > dealer.Score
                Return "You win!"
            Case dealer.Score
                Return "Push"
            Case Else
                Return "Dealer wins!"
        End Select


    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dealer.LastStored <> 1 Then
            NewHand()
        End If
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        If player.Score <= 21 And dealer.LastStored = 1 Then
            Hold()
        End If
    End Sub

    Private Sub DealDealer()
        Dim card As Card
        card = deck.Deal()
        dealer.Deal(card)
        lstDealer.Items.Add(card.IdentifyCard())
        txtDealer.Text = dealer.Score().ToString()
    End Sub

    Private Sub CardShuffling(n As Integer, nMax As Integer) Handles deck.shuffling
        txtOutput.Text = "Shuffling Pass: " & n & " out of " & nMax
        For i As Integer = 1 To 1000000

        Next
        txtOutput.Update()
    End Sub










End Class
