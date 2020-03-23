<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentalForm
    Inherits System.Windows.Forms.Form

    'Form Overrides Dispose To Clean Up The Component List.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal Disposing As Boolean)
        Try
            If Disposing AndAlso Components IsNot Nothing Then
                Components.Dispose()
            End If
        Finally
            MyBase.Dispose(Disposing)
        End Try
    End Sub

    'Note: The Following Procedure Is Required By The Windows Form Designer
    'It Can Be Modified Using The Windows Form Designer.  
    'Do Not Modify It Using The Code Editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.State4 = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.BeginOdometerLabel = New System.Windows.Forms.Label()
        Me.EndOdometerLabel = New System.Windows.Forms.Label()
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BeginOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.DaysTextBox = New System.Windows.Forms.TextBox()
        Me.OdometerGroupbox = New System.Windows.Forms.GroupBox()
        Me.KilometersradioButton = New System.Windows.Forms.RadioButton()
        Me.MilesradioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountGroupbox = New System.Windows.Forms.GroupBox()
        Me.Seniorcheckbox = New System.Windows.Forms.CheckBox()
        Me.AAAcheckbox = New System.Windows.Forms.CheckBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenOutputLabel = New System.Windows.Forms.Label()
        Me.MileChargeLabel = New System.Windows.Forms.Label()
        Me.MileChargeOutputLabel = New System.Windows.Forms.Label()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.YouOweLabel = New System.Windows.Forms.Label()
        Me.DayChargeOutputLabel = New System.Windows.Forms.Label()
        Me.DiscountOutputLabel = New System.Windows.Forms.Label()
        Me.YouOweOutputLabel = New System.Windows.Forms.Label()
        Me.HDivLabel = New System.Windows.Forms.Label()
        Me.VDivLabel = New System.Windows.Forms.Label()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.RentalFormToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OdometerGroupbox.SuspendLayout()
        Me.DiscountGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(8, 20)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(82, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(8, 48)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 2
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(8, 76)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 4
        Me.CityLabel.Text = "City"
        '
        'State4
        '
        Me.State4.AutoSize = True
        Me.State4.Location = New System.Drawing.Point(8, 104)
        Me.State4.Name = "State4"
        Me.State4.Size = New System.Drawing.Size(32, 13)
        Me.State4.TabIndex = 6
        Me.State4.Text = "State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(8, 132)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(50, 13)
        Me.ZipCodeLabel.TabIndex = 8
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'BeginOdometerLabel
        '
        Me.BeginOdometerLabel.AutoSize = True
        Me.BeginOdometerLabel.Location = New System.Drawing.Point(8, 160)
        Me.BeginOdometerLabel.Name = "BeginOdometerLabel"
        Me.BeginOdometerLabel.Size = New System.Drawing.Size(146, 13)
        Me.BeginOdometerLabel.TabIndex = 10
        Me.BeginOdometerLabel.Text = "Beginning Odometer Reading"
        '
        'EndOdometerLabel
        '
        Me.EndOdometerLabel.AutoSize = True
        Me.EndOdometerLabel.Location = New System.Drawing.Point(8, 188)
        Me.EndOdometerLabel.Name = "EndOdometerLabel"
        Me.EndOdometerLabel.Size = New System.Drawing.Size(132, 13)
        Me.EndOdometerLabel.TabIndex = 12
        Me.EndOdometerLabel.Text = "Ending Odometer Reading"
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(8, 216)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(85, 13)
        Me.DaysLabel.TabIndex = 14
        Me.DaysLabel.Text = "Number Of Days"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(160, 16)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(160, 44)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(160, 72)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 5
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(160, 100)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 7
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(160, 128)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipCodeTextBox.TabIndex = 9
        '
        'BeginOdometerTextBox
        '
        Me.BeginOdometerTextBox.Location = New System.Drawing.Point(160, 156)
        Me.BeginOdometerTextBox.Name = "BeginOdometerTextBox"
        Me.BeginOdometerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BeginOdometerTextBox.TabIndex = 11
        '
        'EndOdometerTextBox
        '
        Me.EndOdometerTextBox.Location = New System.Drawing.Point(160, 184)
        Me.EndOdometerTextBox.Name = "EndOdometerTextBox"
        Me.EndOdometerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndOdometerTextBox.TabIndex = 13
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Location = New System.Drawing.Point(160, 212)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DaysTextBox.TabIndex = 15
        '
        'OdometerGroupbox
        '
        Me.OdometerGroupbox.Controls.Add(Me.KilometersradioButton)
        Me.OdometerGroupbox.Controls.Add(Me.MilesradioButton)
        Me.OdometerGroupbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OdometerGroupbox.Location = New System.Drawing.Point(8, 244)
        Me.OdometerGroupbox.Name = "OdometerGroupbox"
        Me.OdometerGroupbox.Size = New System.Drawing.Size(312, 84)
        Me.OdometerGroupbox.TabIndex = 16
        Me.OdometerGroupbox.TabStop = False
        Me.OdometerGroupbox.Text = "Is Odometer In Miles Or Kilometers?"
        '
        'KilometersradioButton
        '
        Me.KilometersradioButton.AutoSize = True
        Me.KilometersradioButton.Location = New System.Drawing.Point(20, 52)
        Me.KilometersradioButton.Name = "KilometersradioButton"
        Me.KilometersradioButton.Size = New System.Drawing.Size(106, 20)
        Me.KilometersradioButton.TabIndex = 1
        Me.KilometersradioButton.Text = "Kilometers"
        Me.KilometersradioButton.UseVisualStyleBackColor = True
        '
        'MilesradioButton
        '
        Me.MilesradioButton.AutoSize = True
        Me.MilesradioButton.Checked = True
        Me.MilesradioButton.Location = New System.Drawing.Point(20, 24)
        Me.MilesradioButton.Name = "MilesradioButton"
        Me.MilesradioButton.Size = New System.Drawing.Size(66, 20)
        Me.MilesradioButton.TabIndex = 0
        Me.MilesradioButton.TabStop = True
        Me.MilesradioButton.Text = "Miles"
        Me.MilesradioButton.UseVisualStyleBackColor = True
        '
        'DiscountGroupbox
        '
        Me.DiscountGroupbox.Controls.Add(Me.Seniorcheckbox)
        Me.DiscountGroupbox.Controls.Add(Me.AAAcheckbox)
        Me.DiscountGroupbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountGroupbox.Location = New System.Drawing.Point(352, 244)
        Me.DiscountGroupbox.Name = "DiscountGroupbox"
        Me.DiscountGroupbox.Size = New System.Drawing.Size(240, 84)
        Me.DiscountGroupbox.TabIndex = 17
        Me.DiscountGroupbox.TabStop = False
        Me.DiscountGroupbox.Text = "Enter Any Discounts"
        '
        'Seniorcheckbox
        '
        Me.Seniorcheckbox.AutoSize = True
        Me.Seniorcheckbox.Location = New System.Drawing.Point(20, 56)
        Me.Seniorcheckbox.Name = "Seniorcheckbox"
        Me.Seniorcheckbox.Size = New System.Drawing.Size(211, 20)
        Me.Seniorcheckbox.TabIndex = 1
        Me.Seniorcheckbox.Text = "Senior Citizen Discount"
        Me.Seniorcheckbox.UseVisualStyleBackColor = True
        '
        'AAAcheckbox
        '
        Me.AAAcheckbox.AutoSize = True
        Me.AAAcheckbox.Location = New System.Drawing.Point(20, 28)
        Me.AAAcheckbox.Name = "AAAcheckbox"
        Me.AAAcheckbox.Size = New System.Drawing.Size(179, 20)
        Me.AAAcheckbox.TabIndex = 0
        Me.AAAcheckbox.Text = "AAA Member Discount"
        Me.AAAcheckbox.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(128, 380)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 18
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(220, 380)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 19
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(408, 380)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 20
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.AutoSize = True
        Me.MilesDrivenLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(292, 20)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(200, 16)
        Me.MilesDrivenLabel.TabIndex = 22
        Me.MilesDrivenLabel.Text = "Distance Driven In Miles"
        '
        'MilesDrivenOutputLabel
        '
        Me.MilesDrivenOutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MilesDrivenOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MilesDrivenOutputLabel.Location = New System.Drawing.Point(504, 16)
        Me.MilesDrivenOutputLabel.Name = "MilesDrivenOutputLabel"
        Me.MilesDrivenOutputLabel.Size = New System.Drawing.Size(128, 24)
        Me.MilesDrivenOutputLabel.TabIndex = 23
        Me.MilesDrivenOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MileChargeLabel
        '
        Me.MileChargeLabel.AutoSize = True
        Me.MileChargeLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MileChargeLabel.Location = New System.Drawing.Point(292, 52)
        Me.MileChargeLabel.Name = "MileChargeLabel"
        Me.MileChargeLabel.Size = New System.Drawing.Size(120, 16)
        Me.MileChargeLabel.TabIndex = 24
        Me.MileChargeLabel.Text = "Mileage Charge"
        '
        'MileChargeOutputLabel
        '
        Me.MileChargeOutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MileChargeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MileChargeOutputLabel.Location = New System.Drawing.Point(504, 48)
        Me.MileChargeOutputLabel.Name = "MileChargeOutputLabel"
        Me.MileChargeOutputLabel.Size = New System.Drawing.Size(128, 24)
        Me.MileChargeOutputLabel.TabIndex = 25
        Me.MileChargeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayChargeLabel.Location = New System.Drawing.Point(292, 84)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(88, 16)
        Me.DayChargeLabel.TabIndex = 26
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLabel.Location = New System.Drawing.Point(292, 116)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(120, 16)
        Me.DiscountLabel.TabIndex = 28
        Me.DiscountLabel.Text = "Minus Discount"
        '
        'YouOweLabel
        '
        Me.YouOweLabel.AutoSize = True
        Me.YouOweLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YouOweLabel.Location = New System.Drawing.Point(292, 148)
        Me.YouOweLabel.Name = "YouOweLabel"
        Me.YouOweLabel.Size = New System.Drawing.Size(64, 16)
        Me.YouOweLabel.TabIndex = 30
        Me.YouOweLabel.Text = "You Owe"
        '
        'DayChargeOutputLabel
        '
        Me.DayChargeOutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DayChargeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DayChargeOutputLabel.Location = New System.Drawing.Point(504, 80)
        Me.DayChargeOutputLabel.Name = "DayChargeOutputLabel"
        Me.DayChargeOutputLabel.Size = New System.Drawing.Size(128, 24)
        Me.DayChargeOutputLabel.TabIndex = 27
        Me.DayChargeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DiscountOutputLabel
        '
        Me.DiscountOutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DiscountOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiscountOutputLabel.Location = New System.Drawing.Point(504, 112)
        Me.DiscountOutputLabel.Name = "DiscountOutputLabel"
        Me.DiscountOutputLabel.Size = New System.Drawing.Size(128, 24)
        Me.DiscountOutputLabel.TabIndex = 29
        Me.DiscountOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YouOweOutputLabel
        '
        Me.YouOweOutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.YouOweOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YouOweOutputLabel.Location = New System.Drawing.Point(504, 144)
        Me.YouOweOutputLabel.Name = "YouOweOutputLabel"
        Me.YouOweOutputLabel.Size = New System.Drawing.Size(128, 24)
        Me.YouOweOutputLabel.TabIndex = 31
        Me.YouOweOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HDivLabel
        '
        Me.HDivLabel.BackColor = System.Drawing.SystemColors.ControlText
        Me.HDivLabel.Location = New System.Drawing.Point(272, 184)
        Me.HDivLabel.Name = "HDivLabel"
        Me.HDivLabel.Size = New System.Drawing.Size(372, 3)
        Me.HDivLabel.TabIndex = 32
        '
        'VDivLabel
        '
        Me.VDivLabel.BackColor = System.Drawing.SystemColors.ControlText
        Me.VDivLabel.Location = New System.Drawing.Point(272, 4)
        Me.VDivLabel.Name = "VDivLabel"
        Me.VDivLabel.Size = New System.Drawing.Size(3, 180)
        Me.VDivLabel.TabIndex = 21
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(316, 380)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 33
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'RentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 437)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.VDivLabel)
        Me.Controls.Add(Me.HDivLabel)
        Me.Controls.Add(Me.YouOweOutputLabel)
        Me.Controls.Add(Me.DiscountOutputLabel)
        Me.Controls.Add(Me.DayChargeOutputLabel)
        Me.Controls.Add(Me.YouOweLabel)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MileChargeOutputLabel)
        Me.Controls.Add(Me.MileChargeLabel)
        Me.Controls.Add(Me.MilesDrivenOutputLabel)
        Me.Controls.Add(Me.MilesDrivenLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DiscountGroupbox)
        Me.Controls.Add(Me.OdometerGroupbox)
        Me.Controls.Add(Me.DaysTextBox)
        Me.Controls.Add(Me.EndOdometerTextBox)
        Me.Controls.Add(Me.BeginOdometerTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DaysLabel)
        Me.Controls.Add(Me.EndOdometerLabel)
        Me.Controls.Add(Me.BeginOdometerLabel)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.State4)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "RentalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acme Car Rental Service"
        Me.OdometerGroupbox.ResumeLayout(False)
        Me.OdometerGroupbox.PerformLayout()
        Me.DiscountGroupbox.ResumeLayout(False)
        Me.DiscountGroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents State4 As System.Windows.Forms.Label
    Friend WithEvents ZipCodeLabel As System.Windows.Forms.Label
    Friend WithEvents BeginOdometerLabel As System.Windows.Forms.Label
    Friend WithEvents EndOdometerLabel As System.Windows.Forms.Label
    Friend WithEvents DaysLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeginOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OdometerGroupbox As System.Windows.Forms.GroupBox
    Friend WithEvents KilometersradioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MilesradioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DiscountGroupbox As System.Windows.Forms.GroupBox
    Friend WithEvents Seniorcheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents AAAcheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents MilesDrivenLabel As System.Windows.Forms.Label
    Friend WithEvents MilesDrivenOutputLabel As System.Windows.Forms.Label
    Friend WithEvents MileChargeLabel As System.Windows.Forms.Label
    Friend WithEvents MileChargeOutputLabel As System.Windows.Forms.Label
    Friend WithEvents DayChargeLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents YouOweLabel As System.Windows.Forms.Label
    Friend WithEvents DayChargeOutputLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountOutputLabel As System.Windows.Forms.Label
    Friend WithEvents YouOweOutputLabel As System.Windows.Forms.Label
    Friend WithEvents HDivLabel As System.Windows.Forms.Label
    Friend WithEvents VDivLabel As System.Windows.Forms.Label
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents RentalFormToolTip As ToolTip
    Private components As System.ComponentModel.IContainer
End Class
