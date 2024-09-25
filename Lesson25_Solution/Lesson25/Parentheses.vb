Public Class Parentheses


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim sentence As String = txtSentence.Text
        Dim perenBegin As Integer
        Dim perenEnd As Integer
        Dim endFound As Boolean = False
        Dim finalSentence As String

        If sentence.Contains("(") And sentence.Contains(")") Then
            For i As Integer = 0 To sentence.Length - 1
                If sentence.Substring(i, 1) = "(" Then
                    perenBegin = i
                ElseIf sentence.Substring(i, 1) = ")" Then
                    perenEnd = i
                End If
            Next
            txtOutput.Text = sentence.Substring(0, perenBegin) & sentence.Substring(perenEnd + 1)
        Else
            MessageBox.Show("The sentence does not contain the characters ()", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub


End Class
