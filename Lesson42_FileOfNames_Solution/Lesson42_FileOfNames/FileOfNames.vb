Public Class FileOfNames
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim newName As String = txtName.Text
        Const filename As String = "Names.txt"
        Dim names() = IO.File.ReadAllLines(filename)

        If newName.Length < 1 Then
            MessageBox.Show("Please enter a name.", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf names.Contains(newName) Then
            MessageBox.Show("Please enter another name.", "Name already exists!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        IO.File.AppendAllText(filename, newName)

        Dim query = From name In IO.File.ReadAllLines(filename)
                    Order By name Ascending
                    Select name

        IO.File.WriteAllLines(filename, query)
        MessageBox.Show("Name was inserted.", "Input accepted!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtName.Clear()
        txtName.Focus()

    End Sub

End Class
