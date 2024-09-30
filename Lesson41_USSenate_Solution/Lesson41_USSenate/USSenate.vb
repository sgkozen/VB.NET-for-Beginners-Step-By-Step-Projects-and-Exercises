Public Class USSenate
    Private Sub USSenate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim origSenate = From senator In IO.File.ReadAllLines("Senate112.txt")
                         Select senator

        Dim retiredSenators = From senator In IO.File.ReadAllLines("RetiredSen.txt")
                              Select senator

        Dim newSenate = From senator In IO.File.ReadAllLines("NewSen.txt")
                        Select senator

        Dim removeRetired = From senator In origSenate.Except(retiredSenators)
                            Select senator

        Dim finalSenate = From senator In removeRetired.Concat(newSenate)
                          Select senator

        IO.File.WriteAllLines("Senate113.txt", finalSenate)

        Dim query = From senator In finalSenate
                    Let party As String = senator.Split(","c)(2)
                    Select party

        Dim demCount As Integer = 0
        Dim repCount As Integer = 0
        Dim indCount As Integer = 0

        For i As Integer = 0 To query.Count() - 1
            If query(i) = "D" Then
                demCount += 1
            ElseIf query(i) = "R" Then
                repCount += 1
            Else
                indCount += 1
            End If
        Next

        Dim query2 = From senator In finalSenate
                     Let state As String = senator.Split(","c)(1)
                     Let party As String = senator.Split(","c)(2)
                     Order By state Ascending
                     Select party


        Dim numStatesWithSameParty As Integer = 0

        For i As Integer = 0 To query2.Count() - 2 Step 2
            If query2(i) = query2(i + 1) Then
                numStatesWithSameParty += 1
            End If
        Next

        MessageBox.Show("Democrats: " & demCount.ToString & vbNewLine &
                        "Republicans: " & repCount.ToString & vbNewLine &
                        "Indepentent: " & indCount.ToString & vbNewLine &
                        "Number of states whose senators have the same party affiliation: " & numStatesWithSameParty)


        Dim query3 = From state In finalSenate
                     Let states As String = state.Split(",")(1)
                     Order By states Ascending
                     Select states
                     Distinct



        lstStates.DataSource = query3.ToList





    End Sub

    Private Sub lstStates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStates.SelectedIndexChanged
        Dim selectedState = lstStates.Text

        Dim query = From data In IO.File.ReadAllLines("Senate113.txt")
                    Let senator As String = data.Split(","c)(0)
                    Let state As String = data.Split(","c)(1)
                    Where state = selectedState
                    Select senator


        lstSenators.DataSource = query.ToList
    End Sub
End Class
