Public Class Account
    Dim trans(50) As Transaction
    Dim lastNum As Integer

    Private _name As String
    Private _balance As Double

    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property


    Public ReadOnly Property Balance() As Double
        Get
            Return _balance
        End Get
    End Property

    Public Event InsufficientFunds(over As Double)
    Public Event TransactionCommitted()

    Public Sub New(name As String)
        _name = name
    End Sub

    Public Sub Add(transaction As Transaction)
        Dim newBalance As Double
        If transaction.Credit Then
            newBalance = Balance + transaction.Amount
        Else
            newBalance = Balance - transaction.Amount
        End If

        If newBalance < 0 Then
            RaiseEvent InsufficientFunds(newBalance)
        Else
            lastNum += 1
            If trans.Count() - 1 <= lastNum Then
                ReDim Preserve trans(lastNum + 1)
            End If
            trans(lastNum) = transaction
            _balance = newBalance
            RaiseEvent TransactionCommitted()
        End If


    End Sub


    Public Sub Load()
        Dim fileName As String = _name & ".txt"
        Dim sr As IO.StreamReader
        Dim line() As String
        Dim trans As Transaction
        If IO.File.Exists(fileName) Then
            sr = IO.File.OpenText(fileName)
            While Not sr.EndOfStream
                line = sr.ReadLine().Split(","c)
                trans = New Transaction(CDate(line(0)), line(1), CDbl(line(2)), CBool(line(3)))
                Add(trans)
            End While
            sr.Close()
        End If
    End Sub
End Class
