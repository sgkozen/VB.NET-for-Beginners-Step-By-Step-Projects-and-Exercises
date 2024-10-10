Public Class Hand
    Private _cards(5) As Card
    Private _lastStored As Integer

    Public ReadOnly Property LastStored() As Integer
        Get
            Return _lastStored
        End Get
    End Property

    Public ReadOnly Property Card(i) As Card
        Get
            Return _cards(i)
        End Get
    End Property

    Public ReadOnly Property Score() As Integer
        Get
            Dim total As Integer
            Dim ace As Boolean = False

            For i As Integer = 1 To LastStored
                total += _cards(i).Score
                If _cards(i).Denomination = 1 Then
                    ace = True
                End If
            Next

            If total <= 11 And ace Then
                total += 10
            End If
            Return total
        End Get
    End Property


    Public Sub Deal(card As Card)
        If LastStored < 5 Then
            _lastStored += 1
            _cards(LastStored) = card
        End If
    End Sub

    Public Sub Clear()
        _lastStored = 0
    End Sub







End Class
