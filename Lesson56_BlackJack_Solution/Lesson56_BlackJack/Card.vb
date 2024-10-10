Public Class Card
    Private _denomination As Integer
    Private _suit As String

    Public Property Denomination() As Integer
        Get
            Return _denomination
        End Get
        Set(value As Integer)
            If (value >= 1) And (value <= 13) Then
                _denomination = value
            End If
        End Set
    End Property

    Public Property Suit() As String
        Get
            Return _suit
        End Get
        Set(value As String)
            If (value = "Hearts") Or (value = "Clubs") Or (value = "Diamonds") Or (value = "Spades") Then
                _suit = value
            End If
        End Set
    End Property

    Public ReadOnly Property Score() As Integer
        Get
            If _denomination > 10 Then
                Return 10
            Else
                Return _denomination
            End If
        End Get
    End Property


    Function IdentifyCard() As String
        Dim denom As String
        Select Case _denomination
            Case 1
                denom = "Ace"
            Case 11
                denom = "Jack"
            Case 12
                denom = "Queen"
            Case 13
                denom = "King"
            Case Else
                denom = _denomination.ToString()
        End Select
        Return denom & " of " & Suit
    End Function






End Class
