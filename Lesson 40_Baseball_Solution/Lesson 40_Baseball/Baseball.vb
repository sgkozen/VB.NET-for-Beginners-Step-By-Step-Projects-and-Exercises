Public Class Baseball
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim newFile As IO.StreamWriter = IO.File.CreateText("ALE2.txt")

        Dim query = From data In IO.File.ReadAllLines("ALE.txt")
                    Let team As String = data.ToString().Split(",")(0)
                    Let wins As Integer = CInt(data.ToString().Split(",")(1))
                    Let losses As Integer = CInt(data.ToString().Split(",")(2))
                    Let percentage As Double = CDbl(wins / (wins + losses))
                    Order By percentage Descending
                    Select team & "," & wins & "," & losses & "," & FormatNumber(percentage.ToString(), 3)


        For i As Integer = 0 To query.Count - 1
            newFile.WriteLine(query(i))
        Next

        newFile.Close()

    End Sub
End Class
