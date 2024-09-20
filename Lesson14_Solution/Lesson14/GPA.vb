Public Class GPA

    Dim floatingSum As Double
    Dim numberOfCourses As Integer

    Private Sub BtnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Dim grades As String
        Dim gradeValue, hours As Integer
        Dim courseGrade As Double


        If (cmbGrades.SelectedIndex > -1) And (txtCreditHours.Text = "1" Or txtCreditHours.Text = "2" Or txtCreditHours.Text = "3" Or txtCreditHours.Text = "4") Then
            grades = cmbGrades.Text
            gradeValue = CalculateGrade(grades)
            hours = CInt(txtCreditHours.Text)
            courseGrade = CalculateCourseGrade(gradeValue, hours)

            numberOfCourses += 1
            floatingSum += courseGrade

        Else
            MessageBox.Show("Invalid entry, correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ResetForm()

    End Sub

    Function CalculateCourseGrade(gradeValue As Integer, hours As Integer) As Double
        Dim courseGrade, finalGrade As Double
        Dim maxPossibleGrade As Integer

        maxPossibleGrade = hours * 4
        courseGrade = gradeValue * hours
        finalGrade = (courseGrade / maxPossibleGrade) * 4

        Return finalGrade

    End Function


    Private Sub ResetForm()
        cmbGrades.SelectedIndex = -1
        cmbGrades.Text = "Select Grade"
        txtCreditHours.Clear()
    End Sub






    Function CalculateGrade(grades As String) As Integer
        Dim gradeValue As Integer

        Select Case (grades)
            Case "A"
                gradeValue = 4
            Case "B"
                gradeValue = 3
            Case "C"
                gradeValue = 2
            Case "D"
                gradeValue = 1
            Case "F"
                gradeValue = 0
        End Select

        Return gradeValue
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gpa As Double

        If numberOfCourses > 0 Then
            gpa = floatingSum / numberOfCourses
            txtGPA.Text = gpa.ToString("N2")

            floatingSum = 0
            numberOfCourses = 0
            ResetForm()
        Else
            MessageBox.Show("Please enter grades", "Nothing to calculate", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub
End Class
