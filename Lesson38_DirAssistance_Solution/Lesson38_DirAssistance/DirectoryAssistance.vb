Imports System.Runtime.Remoting.Messaging

Public Class DirectoryAssistance

    Dim employees() As String = IO.File.ReadAllLines("Employees.txt")

    Private Sub DisplayNames()
        Dim query = From line In employees
                    Let lastName As String = line.Split(","c)(0)
                    Let firstName As String = line.Split(","c)(1)
                    Let extension As String = line.Split(","c)(2)
                    Let code As String = GetCode(lastName, firstName)
                    Where code = txtPshBtnCode.Text
                    Select firstName, lastName, extension


        If query.Count() = 0 Then
            lstOutput.Items.Add("The name was not found")
        Else
            For Each employee In query
                lstOutput.Items.Add(employee.firstName + ", " + employee.lastName + " ext." + employee.extension)
            Next
        End If

    End Sub


    Private Function Translate(letter As String) As Integer
        Select Case letter
            Case "A", "B", "C"
                Return 1
            Case "D", "E", "F"
                Return 2
            Case "G", "H", "I"
                Return 3
            Case "J", "K", "L"
                Return 4
            Case "M", "N", "O"
                Return 5
            Case "P", "Q", "R", "S"
                Return 6
            Case "T", "U", "V"
                Return 7
            Case "W", "X", "Y", "Z"
                Return 8
        End Select
    End Function


    Private Function GetCode(last As String, first As String) As String
        Dim word, code As String
        word = (last.Substring(0, 3) & first.Substring(0, 1)).ToUpper()

        For i As Integer = 0 To 3
            code += Translate(word.Substring(i, 1)).ToString()
        Next
        Return code

    End Function

    Private Sub btnABC_Click(sender As Object, e As EventArgs) Handles btnABC.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "1"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnDEF_Click(sender As Object, e As EventArgs) Handles btnDEF.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "2"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnGHI_Click(sender As Object, e As EventArgs) Handles btnGHI.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "3"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnJKL_Click(sender As Object, e As EventArgs) Handles btnJKL.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "4"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnMNO_Click(sender As Object, e As EventArgs) Handles btnMNO.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "5"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnPQRS_Click(sender As Object, e As EventArgs) Handles btnPQRS.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "6"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnTUV_Click(sender As Object, e As EventArgs) Handles btnTUV.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "7"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnWXYZ_Click(sender As Object, e As EventArgs) Handles btnWXYZ.Click
        If txtPshBtnCode.Text.Length < 4 Then
            txtPshBtnCode.Text += "8"
            If txtPshBtnCode.Text.Length = 4 Then
                DisplayNames()
            End If
        End If
    End Sub

    Private Sub btnLookUp_Click(sender As Object, e As EventArgs) Handles btnLookUp.Click
        lstOutput.Items.Clear()
        txtPshBtnCode.Text = ""
    End Sub
End Class
