Public Class ProjectileMotion
    Const AccelerationOfGravity As Double = 32

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Me.Close()
    End Sub

    Private Sub btnMaxHeight_Click(sender As Object, e As EventArgs) Handles btnMaxHeight.Click
        Dim v, h As Double
        ValidateInput(v, h)
        Dim maxHeight As Double = HeightOfBall(h, v, v / 32)
        lstOutput.Items.Add("The maximum height is: ")
        lstOutput.Items.Add(maxHeight & " feet")

    End Sub
    Private Sub ValidateInput(ByRef v As Double, ByRef h As Double)
        If IsNumeric(txtInitialHeight.Text) And IsNumeric(txtInitialVelocity.Text) Then
            h = CDbl(txtInitialHeight.Text)
            v = CDbl(txtInitialVelocity.Text)
        Else
            MessageBox.Show("Enter a number", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Function HeightOfBall(h As Double, v As Double, t As Double)
        Return h + v * t - 16 * t * t
    End Function



    Private Sub btnApproxTime_Click(sender As Object, e As EventArgs) Handles btnApproxTime.Click
        lstOutput.Items.Clear()
        Dim h, v As Double
        ValidateInput(v, h)
        Dim t As Double = TimeToHit(h, v)
        lstOutput.Items.Add("The ball will hit the ground after approximately")
        lstOutput.Items.Add(t & " seconds.")

    End Sub

    Private Function TimeToHit(h As Double, v As Double) As Double
        Dim t As Double = 0
        Do While HeightOfBall(h, v, t) > 0
            t += 0.1
        Loop
        Return t
    End Function

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        lstOutput.Items.Clear()
        Dim h, v As Double
        ValidateInput(v, h)
        ShowTable(h, v)


    End Sub


    Private Sub ShowTable(h As Double, v As Double)
        Dim t As Double
        lstOutput.Items.Add("      Time           Height")
        t = 0
        Dim height = HeightOfBall(h, v, t)

        Do
            lstOutput.Items.Add("      " & t.ToString("N") & "            " & height)
            t += 0.25
            height = HeightOfBall(h, v, t)

        Loop Until (t > 5) Or (height < 0)


    End Sub


End Class