Option Explicit On
Option Strict On
Option Compare Binary
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Car Rental
'https://github.com/AftaAnfi/CarRental_AA.git
Public Class RentalForm

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear all input text boxes
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""

        'Clear all output text boxes
        TotalMilesTextBox.Text = ""
        MileageChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        TotalDiscountTextBox.Text = ""
        TotalChargeTextBox.Text = ""


        'Clear discount check boxes
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False


        'Select Case the miles radio button
        MilesradioButton.Checked = True

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
