﻿Public Class CurveGrades
    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Dim fileText() As String = IO.File.ReadAllLines("Scores.txt")
        Dim mean As Double
        Dim stdDev As Double
        Dim scores(fileText.Count() - 1) As Integer

        For i As Integer = 0 To scores.Count() - 1
            scores(i) = CInt(fileText(i))
        Next

        Array.Sort(scores)

        mean = GetMean(scores)

        stdDev = getDeviation(scores, mean)

        Dim query = From score In scores
                    Let grade = getGrade(score, mean, stdDev)
                    Select score, grade

        txtNumOfExams.Text = scores.Count().ToString()
        txtMean.Text = mean.ToString("N")
        txtStandDev.Text = stdDev.ToString("N")

        grdScores.DataSource = query.ToList
        grdScores.Columns(0).HeaderText = "Score"
        grdScores.Columns(1).HeaderText = "Grade"




    End Sub

    Public Function GetMean(scores() As Integer) As Double
        Dim m As Double
        m = scores.Sum() / scores.Count()

        Return m
    End Function

    Public Function getDeviation(scores() As Integer, mean As Double) As Double
        Dim s As Double
        Dim numerator As Double

        For i As Integer = 0 To scores.Count() - 1
            numerator += Math.Pow(scores(i) - mean, 2)
        Next

        s = Math.Sqrt(numerator / scores.Count())
        Return s

    End Function

    Public Function getGrade(score As Integer, mean As Double, stdDev As Double) As String
        Dim grade As String

        If score >= mean + 1.5 * stdDev Then
            grade = "A"
        ElseIf score >= mean + (0.5 * stdDev) And score < mean + 1.5 * stdDev Then
            grade = "B"
        ElseIf score >= mean - (0.5 * stdDev) And score < mean + 0.5 * stdDev Then
            grade = "C"
        ElseIf score >= mean - (1.5 * stdDev) And score < mean - 0.5 * stdDev Then
            grade = "D"
        Else
            grade = "F"
        End If

        Return grade

    End Function

End Class
