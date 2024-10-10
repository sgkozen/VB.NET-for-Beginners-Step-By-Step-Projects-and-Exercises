Public Class frmMeals

    Public seat As String
    Private Sub frmMeals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case seat
            Case "R"
                rdbRegular.Checked = True
            Case "L"
                rdbLowCalorie.Checked = True
            Case "V"
                rdbVegetarian.Checked = True
            Case Else
                rdbUnoccupied.Checked = True
        End Select

    End Sub

    Private Sub rdbUnoccupied_CheckedChanged(sender As Object, e As EventArgs) Handles rdbUnoccupied.CheckedChanged
        seat = "."
        Close()
    End Sub

    Private Sub rdbRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRegular.CheckedChanged
        seat = "R"
        Close()
    End Sub

    Private Sub rdbLowCalorie_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLowCalorie.CheckedChanged
        seat = "L"
        Close()
    End Sub

    Private Sub rdbVegetarian_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVegetarian.CheckedChanged
        seat = "V"
        Close()
    End Sub
End Class