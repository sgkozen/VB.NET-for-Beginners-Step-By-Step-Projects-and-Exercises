Imports System.Data.Common
Imports System.Runtime.InteropServices

Public Class GameOfLife

    Dim current(,) As Boolean
    Dim generation As Integer = 1
    Private Sub GameOfLife_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewGame()
    End Sub


    Private Sub NewGame()
        Dim input As String
        Dim size As Integer = CInt(InputBox("Enter the size of the grid"))
        ReDim current(size, size)

        For row As Integer = 1 To size
            input = InputBox("Enter the row # " & row & " of " & size & " with 1s or dashes.")
            For column As Integer = 1 To size
                current(row, column) = (input.Substring(column - 1, 1) = "1")
            Next
        Next

        generation = 1
        Display()

    End Sub

    Private Sub Display()
        Dim output As String
        Dim size As Integer = current.GetUpperBound(0)
        lstGeneration.Items.Clear()
        Dim count As Integer = 0
        For row As Integer = 1 To size
            output = ""
            For column As Integer = 1 To size
                If current(row, column) Then
                    output = output & "1"
                    count += 1
                Else
                    output = output & "-"
                End If
            Next
            lstGeneration.Items.Add(output)
        Next
        txtIndividuals.Text = count.ToString()
        btnGeneration.Text = "Generation # " & generation

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NewGame()

    End Sub

    Function Survives(row As Integer, column As Integer) As Boolean
        Dim size As Integer = current.GetUpperBound(0)
        Dim count As Integer = 0
        For r As Integer = row - 1 To row + 1
            For c As Integer = column - 1 To column + 1
                If ((r <> row) Or (c <> column) And (r >= 1) And (r <= size) And (c >= 1) And (c <= size)) Then
                    If current(r, c) Then
                        count += 1
                    End If
                End If
            Next
        Next
        If current(row, column) Then
            Return (count = 2) Or (count = 3)
        Else
            Return (count = 3)
        End If

    End Function

    Private Sub btnGeneration_Click(sender As Object, e As EventArgs) Handles btnGeneration.Click
        Dim size As Integer = current.GetUpperBound(0)
        Dim future(size, size) As Boolean
        For row As Integer = 1 To size
            For column As Integer = 1 To size
                future(row, column) = Survives(row, column)

            Next

        Next
        current = future
        generation += 1


        Display()

    End Sub
End Class



