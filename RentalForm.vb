'Elliot Heiner
'RCET 0265
'Fall 2021
'Car Rental
'https://github.com/heinelli/CarRental.git

Option Explicit On
Option Strict On
Option Compare Binary

Public Class RentalForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim dailyCharge As Double = 15 * CDbl(DaysTextBox.Text)
        Dim mileage As Double = CDbl(EndOdometerTextBox.Text) - CDbl(BeginOdometerTextBox.Text)

        TotalChargeTextBox.Text = CStr("$" & dailyCharge)
        TotalMilesTextBox.Text = CStr(mileage)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = ""
            End If
        Next
        MilesradioButton.Checked = True
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False

        'NameTextBox.Text = ""
        'AddressTextBox.Text = ""
        'CityTextBox.Text = ""
        'StateTextBox.Text = ""
        'ZipCodeTextBox.Text = ""
        'BeginOdometerTextBox.Text = ""
        'EndOdometerTextBox.Text = ""
        'DaysTextBox.Text = ""
        'TotalMilesTextBox.Text = ""
        'MileageChargeTextBox.Text = ""
        'DayChargeTextBox.Text = ""
        'TotalDiscountTextBox.Text = ""
        'TotalChargeTextBox.Text = ""

    End Sub
End Class
