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
        Dim totalCost As String
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        TotalMilesTextBox.Text = ""
        MileageChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        TotalDiscountTextBox.Text = ""
        TotalChargeTextBox.Text = ""
        MilesradioButton.Checked = True
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False
    End Sub
End Class
