Imports System.Text.RegularExpressions

Public Class Lesson26_Palindrome

    Private Function StripPunctuation(text) As String
        Dim punc As String = "[""\s\][!#$%&'()*+,-./:;<=>?@^_`’'{|}~ ]"
        Dim newText As String = Regex.Replace(text, punc, "")
        Return newText
    End Function


    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim phrase As String = txtword.Text
        Dim palin As Boolean = IsPalindrome(phrase)

        If palin = True Then
            txtOutput.Text = txtword.Text & " is a palindrome."
        Else
            txtOutput.Text = txtword.Text & " is NOT a palindrome."
        End If
    End Sub

    Private Function IsPalindrome(text) As Boolean
        Dim newString As String
        Dim result As Integer
        Dim revString As String
        newString = StripPunctuation(text).ToLower()


        revString = StrReverse(newString).ToLower()
        result = StrComp(newString, revString, CompareMethod.Text)
        If result = 0 Then
            Return True
        End If

        Return False
    End Function

End Class
