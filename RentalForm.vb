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
        Dim dailyCharge As Double
        Dim mileage As Double
        Dim mileageCharge As Double
        Dim cost As Double
        Dim totalCost As Double
        Dim discount As Double
        Dim displayPermission As Boolean = True
        Dim beginOdometer As Double
        Dim endOdometer As Double
        Dim days As Double


        If NameTextBox.Text = "" Then
            NameTextBox.Focus()
            displayPermission = False
            MsgBox("Fill out all input boxes")
        ElseIf AddressTextBox.Text = "" Then
            AddressTextBox.Focus()
            displayPermission = False
            MsgBox("Fill out all input boxes")
        ElseIf CityTextBox.Text = "" Then
            CityTextBox.Focus()
            displayPermission = False
            MsgBox("Fill out all input boxes")
        ElseIf StateTextBox.Text = "" Then
            StateTextBox.Focus()
            displayPermission = False
            MsgBox("Fill out all input boxes")
        ElseIf ZipCodeTextBox.Text = "" Then
            ZipCodeTextBox.Focus()
            displayPermission = False
            MsgBox("Fill out all input boxes")

        Else
            Try
                beginOdometer = CDbl(BeginOdometerTextBox.Text)
                endOdometer = CDbl(EndOdometerTextBox.Text)
                mileage = endOdometer - beginOdometer
                If mileage <= 0 Then
                    MsgBox("Miles driven must equal a positive number")
                    BeginOdometerTextBox.Text = ""
                    EndOdometerTextBox.Text = ""
                    BeginOdometerTextBox.Focus()
                    displayPermission = False
                End If

            Catch ex As Exception
                MsgBox("Odometer value must be a number")
                BeginOdometerTextBox.Text = ""
                EndOdometerTextBox.Text = ""
                BeginOdometerTextBox.Focus()
                displayPermission = False
            End Try

            If displayPermission = False Then
                Try
                    dailyCharge = 15 * Math.Ceiling(CDbl(DaysTextBox.Text))
                    DaysTextBox.Text = CStr(Math.Ceiling(CDbl(DaysTextBox.Text)))
                    If dailyCharge <= 0 Then
                        DaysTextBox.Text = ""
                    End If
                Catch ex As Exception
                    DaysTextBox.Text = ""
                End Try
            ElseIf displayPermission = True Then
                Try
                    dailyCharge = 15 * Math.Ceiling(CDbl(DaysTextBox.Text))
                    DaysTextBox.Text = CStr(Math.Ceiling(CDbl(DaysTextBox.Text)))
                    If dailyCharge <= 0 Then
                        DaysTextBox.Text = ""
                        MsgBox("Day must be greater than zero")
                    End If
                Catch ex As Exception
                    DaysTextBox.Text = ""
                    MsgBox("Please enter the number of days driven")
                    DaysTextBox.Focus()
                End Try
            End If

        End If


        If displayPermission = True Then

            If KilometersradioButton.Checked = True Then
                mileage = mileage * 0.62
            End If

            If mileage <= 200 Then
                mileageCharge = 0
            ElseIf mileage >= 201 And mileage <= 500 Then
                mileageCharge = (mileage - 200) * 0.12
            ElseIf mileage > 500 Then
                mileageCharge = ((mileage - 500) * 0.1) + 36
            End If
            TotalMilesTextBox.Text = CStr(mileage) & " mi"
            MileageChargeTextBox.Text = FormatCurrency(mileageCharge)
            DayChargeTextBox.Text = FormatCurrency(dailyCharge)

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

            TotalDiscountTextBox.Text = FormatCurrency(cost * discount)
            TotalChargeTextBox.Text = FormatCurrency(totalCost)
        End If
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
