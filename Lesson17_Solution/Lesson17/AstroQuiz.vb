Public Class AstroQuiz

    Const One As String = "TThere are more stars in the Universe than grains of sand on the Earth?"
    Const Two As String = "TOn Venus, a day lasts longer than a year."
    Const Three As String = "TThe Sun accounts for 99.8% of all the mass in the Solar System."
    Const Four As String = "FThe phases of the Moon are caused by the Earth's shadow."
    Const Five As String = "FMercury, the closest planet to the Sun, is also the hottest planet in the Solar System."
    Const Six As String = "FLight from the Sun reaches the Earth in about 2 minutes."
    Const Seven As String = "FSaturn is the only Solar System planet that has rings."
    Dim counter As Integer = 0
    Dim correctAnswers As Integer = 0
    Dim currentQues As String


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        counter += 1
        If counter <= 7 Then
            Questions()
            txtAnswer.Enabled = True
            btnDisplay.Enabled = False
            btnAnswer.Enabled = True
        Else
            DisplayResults()
            counter = 0
            correctAnswers = 0
            btnAnswer.Enabled = False
            txtAnswer.Enabled = False
        End If

    End Sub

    Private Sub DisplayResults()
        Select Case correctAnswers
            Case 7
                MessageBox.Show("Perfect. " & correctAnswers & " correct!")
            Case 5, 6
                MessageBox.Show("Excellent. " & correctAnswers & " correct!")
            Case 3, 4
                MessageBox.Show("Good. " & correctAnswers & " correct!")
            Case 0, 1, 2
                MessageBox.Show("Maybe try looking up once in a while. " & correctAnswers & " correct!")
        End Select
    End Sub

    Private Sub Questions()
        Select Case counter
            Case 1
                currentQues = One
            Case 2
                currentQues = Two
            Case 3
                currentQues = Three
            Case 4
                currentQues = Four
            Case 5
                currentQues = Five
            Case 6
                currentQues = Six
            Case 7
                currentQues = Seven
        End Select

        lblQues.Text = currentQues.Substring(1)

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        If txtAnswer.Text.ToUpper() = "T" Or txtAnswer.Text.ToUpper() = "F" Then
            AddAnswer()
            btnAnswer.Enabled = False
            txtAnswer.Clear()
            txtAnswer.Focus()
            btnDisplay.Enabled = True
            txtAnswer.Enabled = False
            lblQues.Text = ""
        Else
            MessageBox.Show("Please select T or F", "Invalid answer!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAnswer.Focus()
        End If
    End Sub


    Private Sub AddAnswer()
        If txtAnswer.Text.ToUpper() = currentQues.Substring(0, 1) Then
            correctAnswers += 1
        End If

    End Sub











End Class
