﻿Public Class ISBN_Validator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim ISBN(9) As Integer
        Dim input As String = mtbISBN.Text
        Dim sum As Integer


        If input.EndsWith("X".ToUpper()) Then
            ISBN(9) = 10
            sum += 10
        ElseIf IsNumeric(input.Substring(12, 1)) Then
            ISBN(9) = CInt(input.Substring(12, 1))
            sum += ISBN(9)
        Else
            MessageBox.Show("You entered an invalid character!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim multiplier As Integer = 10
        Dim index As Integer = 0

        For i As Integer = 0 To input.Length - 2
            If IsNumeric(input.Substring(i, 1)) Then
                ISBN(index) = CInt(input.Substring(i, 1))
                sum += multiplier * ISBN(index)
                multiplier -= 1
                index += 1
            End If
        Next

        If sum Mod 11 = 0 Then
            txtOutput.Text = "Yes"
        Else
            txtOutput.Text = "No"
        End If









    End Sub
End Class
