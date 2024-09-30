Public Class FuelEconomy

    Structure Cars
        Dim carName As String
        Dim numOfCarsTested As Integer
        Dim totalGallons As Double
    End Structure

    Const NUM_OF_MODELS As Integer = 5
    Const MILES_DRIVEN As Integer = 100
    Dim input() As String = IO.File.ReadAllLines("Mileage.txt")
    Dim allCars(input.Length - 1) As Cars
    Dim distinctCars(NUM_OF_MODELS - 1) As Cars

    'Move data to structured array
    Private Sub getData()
        For i As Integer = 0 To distinctCars.Length - 1
            For c As Integer = 0 To allCars.Length - 1
                If distinctCars(i).carName = allCars(c).carName Then
                    distinctCars(i).numOfCarsTested += 1
                    distinctCars(i).totalGallons += allCars(c).totalGallons
                End If
            Next
        Next
    End Sub


    Private Sub MoveFile()
        Dim line As String
        For i As Integer = 0 To allCars.Length - 1
            line = input(i)
            allCars(i).carName = line.Split(","c)(0)
            allCars(i).totalGallons = CDbl(line.Split(","c)(1))
        Next
    End Sub


    Private Sub getModels()
        Dim query = From car In allCars
                    Select car.carName
                    Distinct
        For i As Integer = 0 To query.Count() - 1
            distinctCars(i).carName = query(i)
        Next

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim query = From car In distinctCars
                    Let mpg As Double = (MILES_DRIVEN * car.numOfCarsTested) / car.totalGallons
                    Let output As String = FormatNumber(mpg, 2)
                    Order By mpg Descending
                    Select car.carName, output

        dgvOutput.DataSource = query.ToList
        dgvOutput.Columns(0).HeaderText = "Model"
        dgvOutput.Columns(1).HeaderText = "MPG"

    End Sub

    Private Sub dgvOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveFile()
        getModels()
        getData()

    End Sub
End Class
