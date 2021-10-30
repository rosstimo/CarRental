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
        Dim mileageKm As Double = mileage * 0.62
        Dim mileageCharge As Double
        Dim cost As Double
        Dim totalCost As Double
        Dim discount As Double

        If KilometersradioButton.Checked = True Then
            mileage = mileageKm
        End If


        If mileage <= 200 Then
            mileageCharge = 0
        ElseIf mileage >= 201 And mileage <= 500 Then
            mileageCharge = (mileage - 200) * 0.12
        ElseIf mileage > 500 Then
            mileageCharge = ((mileage - 500) * 0.1) + 36
        End If
        TotalMilesTextBox.Text = CStr(mileage) & " mi"

        cost = dailyCharge + mileageCharge
        If AAAcheckbox.Checked = True And Seniorcheckbox.Checked = True Then
            discount = 0.08
            totalCost = cost - (cost * discount)
        ElseIf AAAcheckbox.Checked = True Then
            discount = 0.05
            totalCost = cost - (cost * discount)
        ElseIf Seniorcheckbox.Checked = True Then
            discount = 0.03
            totalCost = cost - (cost * discount)
        Else
            totalCost = cost
        End If

        TotalChargeTextBox.Text = FormatCurrency(totalCost)

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
