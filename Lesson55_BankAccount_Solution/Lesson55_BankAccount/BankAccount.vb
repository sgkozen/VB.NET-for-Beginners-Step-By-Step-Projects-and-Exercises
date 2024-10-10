Public Class BankAccount
    Dim WithEvents checking As New Account("Checking")
    Dim WithEvents savings As New Account("Savings")
    Dim check As Boolean
    Dim committed As Boolean
    Dim curDate As Date

    Structure Trans
        Dim dt As Date
        Dim trsType As String
        Dim newBal As Double
        Dim amt As Double
        Dim cred As Boolean
    End Structure

    Dim trs() As Trans

    Private Sub BankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checking.Load()
        savings.Load()
        cboTransfer.SelectedIndex = 0
        cboAccount.SelectedIndex = 0
        txtDate.Text = Today.ToString()
        UpdateGrid()
    End Sub

    Private Sub UpdateGrid()
        Dim temp() As String
        If cboAccount.SelectedIndex = 0 Then
            temp = IO.File.ReadAllLines("Checking.txt")
        Else
            temp = IO.File.ReadAllLines("Savings.txt")
        End If

        Dim n = temp.Count() - 1
        Dim line() As String
        ReDim trs(n)

        For i As Integer = 0 To n
            Dim previousBalance As Double = 0
            line = temp(i).Split(","c)
            trs(i).dt = CDate(line(0))
            trs(i).trsType = line(1)
            trs(i).amt = CDbl(line(2))
            If i = 0 Then
                previousBalance = 0
            Else
                previousBalance = trs(i - 1).newBal
            End If
            If CBool(line(3)) Then
                trs(i).newBal = previousBalance + trs(i).amt
            Else
                trs(i).newBal = previousBalance - trs(i).amt
            End If
        Next


        Dim query = From s In trs
                    Let amt = s.amt.ToString("C")
                    Let newBal = s.newBal.ToString("C")
                    Select s.dt, s.trsType, s.amt, s.newBal

        dgvTransactions.DataSource = query.ToList
        dgvTransactions.Columns("dt").HeaderText = "Date"
        dgvTransactions.Columns("trsType").HeaderText = "Type of Transaction"
        dgvTransactions.Columns("amt").HeaderText = "Amount"
        dgvTransactions.Columns("newBal").HeaderText = "New Balance"
    End Sub

    Sub Insufficient(over As Double) Handles checking.InsufficientFunds, savings.InsufficientFunds
        committed = False
        MessageBox.Show("Insufficient Funds: " & over.ToString("C"), "Insufficient Funds")
    End Sub


    Public Sub CommittedTrans() Handles checking.TransactionCommitted, savings.TransactionCommitted
        committed = True
    End Sub

    Private Sub cboAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccount.SelectedIndexChanged
        check = (cboAccount.SelectedIndex = 0)
        grpCheck.Visible = check
        Display()
        UpdateGrid()
    End Sub

    Private Sub Display()
        If check Then
            txtBalance.Text = checking.Balance.ToString("C")
        Else
            txtBalance.Text = savings.Balance.ToString("C")
        End If
        UpdateGrid()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim trans As Transaction
        curDate = CDate(txtDate.Text)
        trans = New Transaction(curDate, "Deposit", CDbl(txtDeposit.Text), True)
        If check Then
            checking.Add(trans)
            Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
            sw.WriteLine(trans.Format())
            sw.Close()
        Else
            savings.Add(trans)
            Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
            sw.WriteLine(trans.Format())
            sw.Close()
        End If
        Display()
        txtDeposit.Clear()
    End Sub

    Private Sub btnWithdrawal_Click(sender As Object, e As EventArgs) Handles btnWithdrawal.Click
        Dim trans As Transaction
        curDate = CDate(txtDate.Text)
        trans = New Transaction(curDate, "Withdrawal", CDbl(txtWithdrawal.Text), False)
        If check Then
            checking.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
        Else
            savings.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
        End If
        Display()
        txtWithdrawal.Clear()
    End Sub

    Private Sub btnSignCheck_Click(sender As Object, e As EventArgs) Handles btnSignCheck.Click
        Dim trans As Transaction
        curDate = CDate(txtDate.Text)
        trans = New Transaction(curDate, "Check cashed by " & txtPayTo.Text, CDbl(txtCheck.Text), False)
        checking.Add(trans)
        If committed Then
            Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
            sw.WriteLine(trans.Format)
            sw.Close()
        End If
        Display()
        txtPayTo.Clear()
        txtCheck.Clear()
    End Sub

    Private Sub cboTransfer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransfer.SelectedIndexChanged
        If cboTransfer.SelectedIndex = 0 Then
            lblTransferTo.Text = "to Savings"
        Else
            lblTransferTo.Text = "to Checking"
        End If
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim trans As Transaction
        Dim amount As Double = CDbl(txtTransfer.Text)
        curDate = CDate(txtDate.Text)
        If cboTransfer.SelectedIndex = 0 Then
            trans = New Transaction(curDate, "Transfer to Savings", amount, False)
            checking.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
        Else
            trans = New Transaction(curDate, "Transfer to Checking", amount, False)
            savings.Add(trans)
            If committed Then
                Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
        End If




        If committed Then
            If cboTransfer.SelectedIndex = 0 Then
                trans = New Transaction(curDate, "Transfer from Checking", amount, True)
                savings.Add(trans)
                Dim sw As IO.StreamWriter = IO.File.AppendText("Savings.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            Else
                trans = New Transaction(curDate, "Transfer from Savings", amount, True)
                checking.Add(trans)
                Dim sw As IO.StreamWriter = IO.File.AppendText("Checking.txt")
                sw.WriteLine(trans.Format)
                sw.Close()
            End If
            Display()
            txtTransfer.Clear()
        End If
    End Sub
End Class
