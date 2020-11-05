
'Luis Torres
'RCET0265
'Fall 2020
'CAR Rental
'https://github.com/LuisTorres0419/CarRental.git

Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Dim customers As Integer
    Dim totalMles, totalCharges, totalDiscount, milesCharged As Decimal

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem1.Click
        Dim Msg, Title As String
        Dim style As MsgBoxStyle
        Dim Response As Integer

        Msg = "do you want this?"
        style = CType(vbYesNo + vbCritical + vbDefaultButton2, MsgBoxStyle)
        Title = "close?"
        Response = MsgBox(Msg, style, Title)
        If Response = vbYes Then
            Msg = "Really?"
            Title = "for real"
            style = CType(vbYesNo + vbCritical + vbDefaultButton2, MsgBoxStyle)
            Response = MsgBox(Msg, style, Title)

            If Response = vbYes Then
                Me.Close()
            Else

            End If
        Else

        End If

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click, ClearToolStripMenuItem1.Click

        Dim Summary As String
        Summary = "total number of people:   " & customers.ToString & vbNewLine
        Summary &= "total miles driven:   " & totalMles.ToString("n") & "mi" & vbNewLine
        Summary &= "total charges:   " & totalCharges.ToString("c") & vbNewLine
        MessageBox.Show(Summary, "summary")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem1.Click

        Reset()

        MileageChargeTextBox.Clear()
        TotalMilesTextBox.Clear()
        DayChargeTextBox.Clear()
        TotalDiscountTextBox.Clear()
        TotalChargeTextBox.Clear()
    End Sub

    Sub Reset()
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        MilesradioButton.Checked = True
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False
        TotalMilesTextBox.Text = ""
        MileageChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        TotalDiscountTextBox.Text = ""
        TotalChargeTextBox.Text = ""
    End Sub



    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click
        Dim data As Boolean = False
        Dim positveOdometer As Boolean = False
        Dim negitivOdometer As Boolean = False
        Dim goodDays As Boolean = False
        Dim origanalOdometer, afterOdometer As Decimal
        Dim days As Integer
        Dim message As String = ""
        Try

            If DaysTextBox.Text = "" Then
                message = "pls enter your days" & vbNewLine
            End If

            If EndOdometerTextBox.Text = "" Then
                message = "pls enter more numberz" & vbNewLine
            End If

            If BeginOdometerTextBox.Text = "" Then
                message = "pls enter your numberz" & vbNewLine
            End If

            If ZipCodeTextBox.Text = "" Then
                message = "pls enter number of the state" & vbNewLine
            End If

            If StateTextBox.Text = "" Then
                message = "pls enter your state title" & vbNewLine
            End If

            If CityTextBox.Text = "" Then
                message = "pls enter your city title" & vbNewLine
            End If

            If AddressTextBox.Text = "" Then
                message = "pls enter your living addres" & vbNewLine
            End If

            If NameTextBox.Text = "" Then
                message = "pls enter your birth title" & vbNewLine
            End If

        Catch ex As Exception

        End Try
        If BeginOdometerTextBox.Text <> "" Or EndOdometerTextBox.Text <> "" Or
        DaysTextBox.Text <> "" Then
            Try
                origanalOdometer = CDec(BeginOdometerTextBox.Text)
                positveOdometer = True
            Catch ex As Exception

                message &= "the begin odometer must good numberz" & vbNewLine

            End Try

            Try
                afterOdometer = CDec(EndOdometerTextBox.Text)
                negitivOdometer = True
            Catch ex As Exception

                message &= "the end odometer must good numberz" & vbNewLine

            End Try

            If origanalOdometer < afterOdometer Then

            Else
                message &= "the end odometer greatere then start odometer. FIXE IT" & vbNewLine & vbNewLine
            End If

            Try
                days = CInt(DaysTextBox.Text)
                If days > 0 And days <= 45 Then
                    goodDays = True
                Else
                    message &= "you have from the day of to the 45th day" & vbNewLine
                End If
            Catch ex As Exception
                message &= "please put in the right amount of days" & vbNewLine
            End Try
        End If

        If message <> "" Then
            MsgBox(message)
            If positveOdometer = False Then
                BeginOdometerTextBox.Text = ""
            End If
            If negitivOdometer = False Then
                EndOdometerTextBox.Text = ""
            End If
            If goodDays = False Then
                DaysTextBox.Text = ""
            End If

            If goodDays = False Then
                DaysTextBox.Select()
            End If
            If negitivOdometer = False Then
                EndOdometerTextBox.Select()
            End If
            If positveOdometer = False Then
                BeginOdometerTextBox.Select()
            End If

            If ZipCodeTextBox.Text = "" Then
                ZipCodeTextBox.Select()
            End If
            If StateTextBox.Text = "" Then
                StateTextBox.Select()
            End If
            If CityTextBox.Text = "" Then
                CityTextBox.Select()
            End If
            If AddressTextBox.Text = "" Then
                AddressTextBox.Select()
            End If
            If NameTextBox.Text = "" Then
                NameTextBox.Select()
            End If


        Else
            data = True
        End If
        If data = True Then
            Dim milesDriven, milesDrivenRound, totalOwed, subTotal As Decimal
            Dim daysCharged As Integer

            If MilesradioButton.Checked = True Then
                milesDriven = afterOdometer - origanalOdometer
            Else
                milesDriven = (afterOdometer - origanalOdometer) * 0.12D
            End If
            milesDrivenRound = Math.Round(milesDriven, 2)
            MileCharged(milesDrivenRound)
            daysCharged = days * 15
            DayChargeTextBox.Text = daysCharged.ToString("c")
            subTotal = milesCharged + daysCharged
            TotalMilesTextBox.Text = CStr(milesDrivenRound)
            TotalDiscountTextBox.Text = CStr(milesCharged)
            Discount(subTotal)
            TotalDiscountTextBox.Text = totalDiscount.ToString("c")
            totalOwed = milesCharged + daysCharged - totalDiscount
            TotalChargeTextBox.Text = totalOwed.ToString("c")
            customers += 1
            totalMles += milesDriven
            totalCharges += totalOwed
            SummaryButton.Enabled = True
        End If

    End Sub

    Function MileCharged(ByRef mile As Decimal) As Decimal


        Const RegularRate = 0.12D
        Const LowRate = 0.1D
        Const FreeRate = 0D

        Select Case mile
            Case <= 200
                milesCharged = mile * FreeRate
            Case <= 200
                milesCharged = (300) * RegularRate
                milesCharged += (mile - 500) * LowRate
            Case Else
                milesCharged = (mile - 200) * RegularRate
        End Select
        Return milesCharged
    End Function

    Function Discount(totalcharges As Decimal) As Decimal
        Const TripleARate = 0.05D
        Const SeniorRate = 0.03D
        If AAAcheckbox.Checked = True Then
            totalDiscount += totalcharges * TripleARate
        End If

        If Seniorcheckbox.Checked = True Then
            totalDiscount += totalcharges * SeniorRate
        End If

        Return totalDiscount
    End Function


End Class