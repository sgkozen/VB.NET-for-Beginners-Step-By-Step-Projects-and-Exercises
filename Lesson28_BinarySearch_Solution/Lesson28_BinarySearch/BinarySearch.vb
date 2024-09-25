﻿Public Class BinarySearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim letters As String = txtInput.Text.ToUpper()
        Dim flag As Boolean = False
        Dim state As String = ""
        Dim first, middle, last As Integer

        first = 0
        last = lstStates.Items.Count - 1

        Do While (Not flag) And (first <= last)
            middle = CInt((first + last) / 2)
            Select Case CStr(lstStates.Items(middle)).Substring(0, 2).ToUpper()
                Case letters
                    state = CStr(lstStates.Items(middle))
                    flag = True
                Case Is > letters
                    last = middle - 1
                Case < letters
                    first = middle + 1
            End Select



        Loop

        If flag Then
            txtOutput.Text = state
        Else
            txtOutput.Text = "The state does not exist!!!"
        End If



    End Sub













End Class


