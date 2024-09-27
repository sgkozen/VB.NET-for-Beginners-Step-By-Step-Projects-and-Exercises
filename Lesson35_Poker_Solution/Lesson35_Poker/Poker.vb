Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class Poker

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim hand(3, 12), suits(3), denoms(12) As Integer
        InputCard(hand, suits, denoms, txtDenomination1.Text, mtbSuit1.Text)
        InputCard(hand, suits, denoms, txtDenomination2.Text, mtbSuit2.Text)
        InputCard(hand, suits, denoms, txtDenomination3.Text, mtbSuit3.Text)
        InputCard(hand, suits, denoms, txtDenomination4.Text, mtbSuit4.Text)
        InputCard(hand, suits, denoms, txtDenomination5.Text, mtbSuit5.Text)

        txtOutput.Text = "The hand is a " & GetScore(hand, suits, denoms)


    End Sub

    Private Function GetScore(hand(,) As Integer, suits() As Integer, denoms() As Integer) As String
        If IsFlush(suits) And IsAStraight(hand) Then
            Return "Straight Flush"
        End If

        If IsFlush(suits) Then
            Return "Flush"
        End If

        If IsFullHouse(denoms) Then
            Return "Full House"
        End If

        If IsFourOfAKind(denoms) Then
            Return "Four of a Kind"
        End If

        If IsAStraight(hand) Then
            Return "Straight"
        End If

        If IsThreeOfAKind(denoms) Then
            Return "Three of a Kind"
        End If

        If IsTwoPairs(denoms) Then
            Return "Two Pairs"
        End If

        If IsOnePair(denoms) Then
            Return "One Pair"
        End If
        Return "Nothing!!!"
    End Function

    Function IsFlush(suits() As Integer) As Boolean
        For suit As Integer = 0 To 3
            If suits(suit) = 5 Then
                Return True

            End If
        Next
        Return False

    End Function



    Private Function IsFullHouse(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If (denoms(denom) = 1) Or (denoms(denom) > 3) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function IsFourOfAKind(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If (denoms(denom) = 4) Then
                Return True
            End If
        Next
        Return False

    End Function

    Private Function IsThreeOfAKind(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If (denoms(denom) = 3) Then
                Return True
            End If
        Next
        Return False

    End Function

    Private Function IsTwoPairs(denoms() As Integer) As Boolean
        Dim count As Integer = 0
        For denom As Integer = 0 To 12
            If denoms(denom) = 2 Then
                count += 1
            End If
        Next

        If count = 2 Then
            Return True
        End If
        Return False

    End Function

    Private Function IsOnePair(denoms() As Integer) As Boolean

        For denom As Integer = 0 To 12
            If denoms(denom) = 2 Then
                Return True
            End If
        Next

        Return False

    End Function



    Private Function IsAStraight(hand(,) As Integer) As Boolean
        Dim denom As Integer = 13
        Do
            denom = denom - 1

        Loop Until IsAnySuit(hand, denom)


        'If highest denomination is less than a 4 then there is no straight
        If denom < 4 Then
            Return False
        End If

        For i As Integer = 1 To 3
            If Not IsAnySuit(hand, denom - 1) Then
                Return False
            End If
        Next

        'highest card is a king
        If (denom = 12 And IsAnySuit(hand, 0)) Or denom = 12 And IsAnySuit(hand, 8) Then
            Return True

        ElseIf denom = 4 And IsAnySuit(hand, 0) Then
            Return True

        ElseIf IsAnySuit(hand, denom - 4) Then
            Return True
        End If
        Return False

    End Function






    Private Function IsAnySuit(hand(,) As Integer, denom As Integer) As Boolean
        For suit As Integer = 1 To 3
            If hand(suit, denom) Then
                Return True
            End If
        Next
        Return (False)
    End Function




































    Private Sub InputCard(ByRef hand(,) As Integer, ByRef suits() As Integer, ByRef denoms() As Integer, denomstr As String, suitStr As String)

        'Store the card in array.
        Dim denom As Integer = CInt(denomstr) - 1
        Dim suit As Integer

        Select Case suitStr.ToUpper()
            Case "C" 'clubs
                suit = 0
            Case "D" 'diamonds
                suit = 1
            Case "H" 'hearts
                suit = 2
            Case "S" 'spades
                suit = 3

        End Select

        hand(suit, denom) = 1
        suits(suit) += 1 'increment counter for suit
        denoms(denom) += 1





    End Sub


End Class
