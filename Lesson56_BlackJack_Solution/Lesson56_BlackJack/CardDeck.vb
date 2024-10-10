Imports System.Drawing.Text

Public Class CardDeck
    Private _deck(52) As Card
    Private _dealt As Integer
    Public Event shuffling(n As Integer, nMax As Integer)

    Public Sub New()
        Dim suits() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
        For i As Integer = 0 To 3
            For j As Integer = 1 To 13
                _deck(i * 13 + j) = New Card()
                _deck(i * 13 + j).Suit = suits(i)
                _deck(i * 13 + j).Denomination = j
            Next
        Next
    End Sub

    Public Function Deal() As Card
        If _dealt < 52 Then
            _dealt += 1
        Else
            _dealt = 1
        End If

        Return _deck(_dealt)
    End Function


    Private Sub Swap(i As Integer, j As Integer)
        Dim tempCard As Card
        tempCard = _deck(i)
        _deck(i) = _deck(j)
        _deck(j) = tempCard

    End Sub


    Public Sub ShuffleDeck()
        Dim index As Integer
        Dim randomIndex As New Random()

        For i As Integer = 1 To 2000
            For j As Integer = 1 To 52
                index = randomIndex.Next(1, 53)
                Swap(j, index)
            Next
            RaiseEvent shuffling(i, 2000)
        Next

    End Sub


































End Class
