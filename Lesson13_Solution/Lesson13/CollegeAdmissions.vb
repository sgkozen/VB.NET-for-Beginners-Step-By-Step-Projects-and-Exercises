Public Class CollegeAdmissions
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gpa, sum1, sum2 As Double

        If Double.TryParse(txtGPAScore.Text, gpa) Then
            If gpa >= 2 And gpa <= 4 Then
                For Each radio In grpSAT.Controls.OfType(Of RadioButton)
                    If radio.Checked Then
                        sum1 += CInt(radio.Tag)
                    End If
                Next

                For Each radio In grpHSQuality.Controls.OfType(Of RadioButton)
                    If radio.Checked Then
                        sum1 += CInt(radio.Tag)
                    End If
                Next

                For Each radio In grpCurriculum.Controls.OfType(Of RadioButton)
                    If radio.Checked Then
                        sum1 += CInt(radio.Tag)
                    End If
                Next

                For Each radio In grpEssay.Controls.OfType(Of RadioButton)
                    If radio.Checked Then
                        sum2 += CInt(radio.Tag)
                    End If
                Next

                For Each radio In grpMisc.Controls.OfType(Of RadioButton)
                    If radio.Checked Then
                        sum2 += CInt(radio.Tag)
                    End If
                Next

                For Each chk In grpGeo.Controls.OfType(Of CheckBox)
                    If chk.Checked Then
                        sum2 += CInt(chk.Tag)
                    End If
                Next

                For Each chk In grpAlum.Controls.OfType(Of CheckBox)
                    If chk.Checked Then
                        sum2 += CInt(chk.Tag)
                    End If
                Next

                For Each chk In grpLS.Controls.OfType(Of CheckBox)
                    If chk.Checked Then
                        sum2 += CInt(chk.Tag)
                    End If
                Next

                If sum2 > 40 Then
                    sum2 = 40
                End If

                Dim totalScore = sum1 + sum2 + gpa * 20
                Dim admitted As String

                If totalScore < 100 Then
                    admitted = "Not admitted!"
                Else
                    admitted = "Admitted!!!"
                End If

                txtOutput.Text = "Total Score: " & totalScore & vbNewLine & "Student is " & admitted

            Else
                    MessageBox.Show("Invalid GPA", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("GPA must be in numeric format", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
