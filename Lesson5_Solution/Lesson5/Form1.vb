Public Class Form1

    Dim totalInches As Double
    Dim totalMeters As Double
    Dim meters As Double
    Dim centimeters As Double
    Dim remainder As Double
    Dim kilometers As Double
    Dim inchesInMile As Double = 63360
    Dim inchesInYard As Double = 36
    Dim inchesInFoot As Double = 12
    Dim inchesInMeter As Double = 39.37
    Dim metersInKm As Double = 1000

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        totalInches = (inchesInMile * txtMiles.Text) + (inchesInYard * txtYards.Text) + (inchesInFoot * txtFeet.Text) + txtInches.Text
        totalMeters = totalInches / inchesInMeter
        kilometers = Int(totalMeters / metersInKm)
        remainder = totalMeters - (kilometers * 1000)

        meters = Int(remainder)
        remainder = (remainder - meters) * 100
        centimeters = remainder
        lstMetric.Items.Add(kilometers & " kilometers")
        lstMetric.Items.Add(meters & " meters")
        lstMetric.Items.Add(centimeters.ToString("N1") & " centimeters")



    End Sub
End Class
