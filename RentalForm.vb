Option Explicit On
Option Strict On
Option Compare Binary
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Car Rental
'https://github.com/AftaAnfi/CarRental_AA.git
Public Class RentalForm

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

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click

        Dim closeForm As Integer = 0
        Dim style As MsgBoxStyle = CType(vbYesNo + vbDefaultButton2, MsgBoxStyle)

        'prompt user if they are sure they want to exit
        closeForm = MsgBox("Are you sure you would like to exit?", style, "Exit Prompt")
        If closeForm = 6 Then
            'if yes exit
            Me.Close()
        Else
            'if not yes -> do nothing
        End If

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim errorMessage As String = ""

        'input validation for number of days
        ValidateDays(errorMessage)

        'validate end odometer reading
        ValidateEndOdometer(errorMessage)

        'validate start odometer reading
        ValidateBeginOdometer(errorMessage)

        'validate zip code
        ValidateZipCode(errorMessage)

        'validate state
        ValidateState(errorMessage)

        'validate city
        ValidateCity(errorMessage)

        'validate address
        ValidateAddress(errorMessage)

        'validate customer name
        ValidateCustomerName(errorMessage)

        'calculate or show errors
        If errorMessage = "" Then
            'calculate
            CalculateResult()

        Else

            'show msg box displaying errormessage
            MsgBox(errorMessage)

        End If



    End Sub

    Sub ValidateDays(ByRef errorMessage As String)
        Dim tempInt As Integer

        If DaysTextBox.Text = "" Then
            errorMessage &= ($"Number of days is empty {vbNewLine}")
            DaysTextBox.Focus()
            DaysTextBox.Text = ""
        Else

            'check to see if it's only numbers
            Try
                tempInt = Convert.ToInt32(DaysTextBox.Text)
            Catch ex As Exception
                errorMessage &= ($"Number of days has letters in it {vbNewLine}")
                DaysTextBox.Focus()
                DaysTextBox.Text = ""
            End Try

            If errorMessage = "" Then
                'if numbers check to make sure it's in between 0 and 45
                Select Case tempInt
                    Case > 45
                        errorMessage &= ($"The number of days is too large{vbNewLine}")
                        DaysTextBox.Focus()
                        DaysTextBox.Text = ""
                    Case < 1
                        errorMessage &= ($"The number of days is too small{vbNewLine}")
                        DaysTextBox.Focus()
                        DaysTextBox.Text = ""
                End Select
            End If


        End If








    End Sub

    Sub ValidateEndOdometer(ByRef errorMessage As String)
        Dim errorString As String = ""
        Dim tempInt As Integer = 0

        'end odometer miles is empty
        If EndOdometerTextBox.Text = "" Then
            errorString = ($"End odometer miles is empty{vbNewLine}")
        Else
            Try
                tempInt = CInt(EndOdometerTextBox.Text)

                Try
                    If tempInt < CInt(BeginOdometerTextBox.Text) Then
                        'end odometer is greater than begin odometer
                        errorString = ($"End Odometer miles is less than begin odometer miles")
                    End If

                Catch ex As Exception

                End Try


            Catch ex As Exception
                'end odometer miles contains symbols or letters
                errorString = ($"End odometer miles is not a number. {vbNewLine}")
            End Try
        End If

        If errorString = "" Then
        Else
            EndOdometerTextBox.Focus()
            EndOdometerTextBox.Text = ""
        End If

        errorMessage &= errorString
    End Sub

    Sub ValidateBeginOdometer(ByRef errorMessage As String)
        Dim errorString As String = ""
        Dim tempInt As Integer

        'message beginodometer field is empty to user
        If BeginOdometerTextBox.Text = "" Then
            errorString = ($"Begin odometer miles is empty {vbNewLine}")
        Else

            Try
                tempInt = CInt(BeginOdometerTextBox.Text)
            Catch ex As Exception
                'beginodometer is not a number (contains symbols or letters)
                errorString = ($"Begin odometer miles is not a number {vbNewLine}")
            End Try
        End If

        If errorString <> "" Then
            BeginOdometerTextBox.Focus()
            BeginOdometerTextBox.Text = ""
        End If

        errorMessage &= errorString
    End Sub

    Sub ValidateZipCode(ByRef errorMessage As String)
        Dim errorString As String = ""
        Dim tempInt As Integer

        'message user that zipcode is empty
        If ZipCodeTextBox.Text = "" Then
            errorString = ($"Zipcode is empty {vbNewLine}")
        Else
            Try
                tempInt = CInt(ZipCodeTextBox.Text)

            Catch ex As Exception
                'message user that zipcode is not a number
                errorString = ($"Zipcode is not a number {vbNewLine}")
            End Try
        End If

        If errorString <> "" Then
            ZipCodeTextBox.Focus()
            ZipCodeTextBox.Text = ""
        End If

        errorMessage &= errorString



    End Sub

    Sub ValidateState(ByRef errorMessage As String)
        Dim errorString As String = ""

        'message user that state is empty
        If StateTextBox.Text = "" Then
            errorString = ($"State field is empty {vbNewLine}")
            StateTextBox.Focus()
            StateTextBox.Text = ""
        End If

        errorMessage &= errorString

    End Sub

    Sub ValidateCity(ByRef errorMessage As String)
        Dim errorString As String = ""

        'message user that city is empty
        If CityTextBox.Text = "" Then
            errorString = ($"City field is empty {vbNewLine}")
            CityTextBox.Focus()
            CityTextBox.Text = ""
        End If

        errorMessage &= errorString

    End Sub

    Sub ValidateAddress(ByRef errorMessage As String)
        Dim errorString As String = ""

        'message user that address is empty
        If AddressTextBox.Text = "" Then
            errorString = ($"Address field is empty {vbNewLine}")
            AddressTextBox.Focus()
            AddressTextBox.Text = ""
        End If

        errorMessage &= errorString

    End Sub

    Sub ValidateCustomerName(ByRef errorMessage As String)
        Dim errorString As String = ""

        'message user name is empty
        If NameTextBox.Text = "" Then
            errorString = ($"Customer Name field is empty {vbNewLine}")
            NameTextBox.Focus()
            NameTextBox.Text = ""
        End If

        errorMessage &= errorString


    End Sub

    Sub CalculateResult()
        Dim dayCharge As Integer = 0
        Dim milesDriven As Double = 0
        Dim mileageCharge As Double = 0

        'miles are in miles
        If MilesradioButton.Checked = True Then

            milesDriven = CInt(EndOdometerTextBox.Text) - CInt(BeginOdometerTextBox.Text)
        End If

        If KilometersradioButton.Checked = True Then
            'miles are in km need to be converted
            milesDriven = ((CInt(EndOdometerTextBox.Text) * 0.62) - (CInt(BeginOdometerTextBox.Text) * 0.62))

        End If

        'calculate miles driven
        TotalMilesTextBox.Text = ($"{milesDriven} miles")


        'calculate charge of miles
        If milesDriven <= 200 Then
            mileageCharge = 0
        Else

            If milesDriven <= 500 Then
                'milecharge is 500 - the 200 free miles times 0.12
                mileageCharge = (milesDriven - 200) * 0.12

            Else
                'add the 300 miles at 0.12 and then whatever miles are over 500 by 0.1
                mileageCharge = (300 * 0.12) + ((milesDriven - 500) * 0.1)

            End If
        End If
        'set the mileagechargebox to the mileagecharge
        MileageChargeTextBox.Text = ($"${CDbl(mileageCharge)}")



        'calculate cost of days 
        dayCharge = 15 * CInt(DaysTextBox.Text)
        DayChargeTextBox.Text = ($" $ {dayCharge}.00")





    End Sub



End Class
