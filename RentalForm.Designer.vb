﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MileChargeLabel = New System.Windows.Forms.Label()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.YouOweLabel = New System.Windows.Forms.Label()
        Me.HDivLabel = New System.Windows.Forms.Label()
        Me.VDivLabel = New System.Windows.Forms.Label()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.RentalFormToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TotalMilesTextBox = New System.Windows.Forms.TextBox()
        Me.MileageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalChargeTextBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdometerGroupbox.SuspendLayout()
        Me.DiscountGroupbox.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(16, 88)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(166, 25)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(16, 141)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(91, 25)
        Me.AddressLabel.TabIndex = 2
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(16, 195)
        Me.CityLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(49, 25)
        Me.CityLabel.TabIndex = 4
        Me.CityLabel.Text = "City"
        '
        'State4
        '
        Me.State4.AutoSize = True
        Me.State4.Location = New System.Drawing.Point(16, 249)
        Me.State4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.State4.Name = "State4"
        Me.State4.Size = New System.Drawing.Size(62, 25)
        Me.State4.TabIndex = 6
        Me.State4.Text = "State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(16, 302)
        Me.ZipCodeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(99, 25)
        Me.ZipCodeLabel.TabIndex = 8
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'BeginOdometerLabel
        '
        Me.BeginOdometerLabel.AutoSize = True
        Me.BeginOdometerLabel.Location = New System.Drawing.Point(16, 356)
        Me.BeginOdometerLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BeginOdometerLabel.Name = "BeginOdometerLabel"
        Me.BeginOdometerLabel.Size = New System.Drawing.Size(294, 25)
        Me.BeginOdometerLabel.TabIndex = 10
        Me.BeginOdometerLabel.Text = "Beginning Odometer Reading"
        '
        'EndOdometerLabel
        '
        Me.EndOdometerLabel.AutoSize = True
        Me.EndOdometerLabel.Location = New System.Drawing.Point(16, 410)
        Me.EndOdometerLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.EndOdometerLabel.Name = "EndOdometerLabel"
        Me.EndOdometerLabel.Size = New System.Drawing.Size(265, 25)
        Me.EndOdometerLabel.TabIndex = 12
        Me.EndOdometerLabel.Text = "Ending Odometer Reading"
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(16, 464)
        Me.DaysLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(170, 25)
        Me.DaysLabel.TabIndex = 14
        Me.DaysLabel.Text = "Number Of Days"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(320, 80)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(196, 31)
        Me.NameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(320, 134)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(196, 31)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(320, 188)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(196, 31)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(320, 241)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(196, 31)
        Me.StateTextBox.TabIndex = 3
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(320, 295)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(196, 31)
        Me.ZipCodeTextBox.TabIndex = 4
        '
        'BeginOdometerTextBox
        '
        Me.BeginOdometerTextBox.Location = New System.Drawing.Point(320, 349)
        Me.BeginOdometerTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BeginOdometerTextBox.Name = "BeginOdometerTextBox"
        Me.BeginOdometerTextBox.Size = New System.Drawing.Size(196, 31)
        Me.BeginOdometerTextBox.TabIndex = 5
        '
        'EndOdometerTextBox
        '
        Me.EndOdometerTextBox.Location = New System.Drawing.Point(320, 402)
        Me.EndOdometerTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EndOdometerTextBox.Name = "EndOdometerTextBox"
        Me.EndOdometerTextBox.Size = New System.Drawing.Size(196, 31)
        Me.EndOdometerTextBox.TabIndex = 6
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Location = New System.Drawing.Point(320, 456)
        Me.DaysTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(196, 31)
        Me.DaysTextBox.TabIndex = 7
        '
        'OdometerGroupbox
        '
        Me.OdometerGroupbox.Controls.Add(Me.KilometersradioButton)
        Me.OdometerGroupbox.Controls.Add(Me.MilesradioButton)
        Me.OdometerGroupbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OdometerGroupbox.Location = New System.Drawing.Point(17, 522)
        Me.OdometerGroupbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.OdometerGroupbox.Name = "OdometerGroupbox"
        Me.OdometerGroupbox.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.OdometerGroupbox.Size = New System.Drawing.Size(624, 161)
        Me.OdometerGroupbox.TabIndex = 8
        Me.OdometerGroupbox.TabStop = False
        Me.OdometerGroupbox.Text = "Is Odometer In Miles Or Kilometers?"
        '
        'KilometersradioButton
        '
        Me.KilometersradioButton.AutoSize = True
        Me.KilometersradioButton.Location = New System.Drawing.Point(40, 100)
        Me.KilometersradioButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.KilometersradioButton.Name = "KilometersradioButton"
        Me.KilometersradioButton.Size = New System.Drawing.Size(204, 34)
        Me.KilometersradioButton.TabIndex = 1
        Me.KilometersradioButton.Text = "Kilometers"
        Me.KilometersradioButton.UseVisualStyleBackColor = True
        '
        'MilesradioButton
        '
        Me.MilesradioButton.AutoSize = True
        Me.MilesradioButton.Checked = True
        Me.MilesradioButton.Location = New System.Drawing.Point(40, 46)
        Me.MilesradioButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MilesradioButton.Name = "MilesradioButton"
        Me.MilesradioButton.Size = New System.Drawing.Size(124, 34)
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
        Me.DiscountGroupbox.Location = New System.Drawing.Point(705, 522)
        Me.DiscountGroupbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DiscountGroupbox.Name = "DiscountGroupbox"
        Me.DiscountGroupbox.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DiscountGroupbox.Size = New System.Drawing.Size(480, 161)
        Me.DiscountGroupbox.TabIndex = 9
        Me.DiscountGroupbox.TabStop = False
        Me.DiscountGroupbox.Text = "Enter Any Discounts"
        '
        'Seniorcheckbox
        '
        Me.Seniorcheckbox.AutoSize = True
        Me.Seniorcheckbox.Location = New System.Drawing.Point(40, 108)
        Me.Seniorcheckbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Seniorcheckbox.Name = "Seniorcheckbox"
        Me.Seniorcheckbox.Size = New System.Drawing.Size(413, 34)
        Me.Seniorcheckbox.TabIndex = 1
        Me.Seniorcheckbox.Text = "Senior Citizen Discount"
        Me.Seniorcheckbox.UseVisualStyleBackColor = True
        '
        'AAAcheckbox
        '
        Me.AAAcheckbox.AutoSize = True
        Me.AAAcheckbox.Location = New System.Drawing.Point(40, 54)
        Me.AAAcheckbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.AAAcheckbox.Name = "AAAcheckbox"
        Me.AAAcheckbox.Size = New System.Drawing.Size(349, 34)
        Me.AAAcheckbox.TabIndex = 0
        Me.AAAcheckbox.Text = "AAA Member Discount"
        Me.AAAcheckbox.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(256, 731)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(149, 44)
        Me.CalculateButton.TabIndex = 10
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(440, 731)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(149, 44)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Cl&ear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(816, 731)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(149, 44)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.AutoSize = True
        Me.MilesDrivenLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(584, 88)
        Me.MilesDrivenLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(397, 30)
        Me.MilesDrivenLabel.TabIndex = 22
        Me.MilesDrivenLabel.Text = "Distance Driven In Miles"
        '
        'MileChargeLabel
        '
        Me.MileChargeLabel.AutoSize = True
        Me.MileChargeLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MileChargeLabel.Location = New System.Drawing.Point(584, 149)
        Me.MileChargeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MileChargeLabel.Name = "MileChargeLabel"
        Me.MileChargeLabel.Size = New System.Drawing.Size(237, 30)
        Me.MileChargeLabel.TabIndex = 24
        Me.MileChargeLabel.Text = "Mileage Charge"
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayChargeLabel.Location = New System.Drawing.Point(584, 210)
        Me.DayChargeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(173, 30)
        Me.DayChargeLabel.TabIndex = 26
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLabel.Location = New System.Drawing.Point(584, 271)
        Me.DiscountLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(237, 30)
        Me.DiscountLabel.TabIndex = 28
        Me.DiscountLabel.Text = "Minus Discount"
        '
        'YouOweLabel
        '
        Me.YouOweLabel.AutoSize = True
        Me.YouOweLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YouOweLabel.Location = New System.Drawing.Point(584, 334)
        Me.YouOweLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.YouOweLabel.Name = "YouOweLabel"
        Me.YouOweLabel.Size = New System.Drawing.Size(125, 30)
        Me.YouOweLabel.TabIndex = 30
        Me.YouOweLabel.Text = "You Owe"
        '
        'HDivLabel
        '
        Me.HDivLabel.BackColor = System.Drawing.SystemColors.ControlText
        Me.HDivLabel.Location = New System.Drawing.Point(544, 402)
        Me.HDivLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.HDivLabel.Name = "HDivLabel"
        Me.HDivLabel.Size = New System.Drawing.Size(744, 6)
        Me.HDivLabel.TabIndex = 32
        '
        'VDivLabel
        '
        Me.VDivLabel.BackColor = System.Drawing.SystemColors.ControlText
        Me.VDivLabel.Location = New System.Drawing.Point(544, 56)
        Me.VDivLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.VDivLabel.Name = "VDivLabel"
        Me.VDivLabel.Size = New System.Drawing.Size(5, 346)
        Me.VDivLabel.TabIndex = 21
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(632, 731)
        Me.SummaryButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(149, 44)
        Me.SummaryButton.TabIndex = 12
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'TotalMilesTextBox
        '
        Me.TotalMilesTextBox.Location = New System.Drawing.Point(996, 74)
        Me.TotalMilesTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TotalMilesTextBox.Name = "TotalMilesTextBox"
        Me.TotalMilesTextBox.ReadOnly = True
        Me.TotalMilesTextBox.Size = New System.Drawing.Size(263, 31)
        Me.TotalMilesTextBox.TabIndex = 34
        Me.TotalMilesTextBox.TabStop = False
        Me.TotalMilesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MileageChargeTextBox
        '
        Me.MileageChargeTextBox.Location = New System.Drawing.Point(996, 141)
        Me.MileageChargeTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MileageChargeTextBox.Name = "MileageChargeTextBox"
        Me.MileageChargeTextBox.ReadOnly = True
        Me.MileageChargeTextBox.Size = New System.Drawing.Size(263, 31)
        Me.MileageChargeTextBox.TabIndex = 35
        Me.MileageChargeTextBox.TabStop = False
        Me.MileageChargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Location = New System.Drawing.Point(996, 202)
        Me.DayChargeTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.ReadOnly = True
        Me.DayChargeTextBox.Size = New System.Drawing.Size(263, 31)
        Me.DayChargeTextBox.TabIndex = 36
        Me.DayChargeTextBox.TabStop = False
        Me.DayChargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalDiscountTextBox
        '
        Me.TotalDiscountTextBox.Location = New System.Drawing.Point(996, 264)
        Me.TotalDiscountTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TotalDiscountTextBox.Name = "TotalDiscountTextBox"
        Me.TotalDiscountTextBox.ReadOnly = True
        Me.TotalDiscountTextBox.Size = New System.Drawing.Size(263, 31)
        Me.TotalDiscountTextBox.TabIndex = 37
        Me.TotalDiscountTextBox.TabStop = False
        Me.TotalDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalChargeTextBox
        '
        Me.TotalChargeTextBox.Location = New System.Drawing.Point(996, 326)
        Me.TotalChargeTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TotalChargeTextBox.Name = "TotalChargeTextBox"
        Me.TotalChargeTextBox.ReadOnly = True
        Me.TotalChargeTextBox.Size = New System.Drawing.Size(263, 31)
        Me.TotalChargeTextBox.TabIndex = 38
        Me.TotalChargeTextBox.TabStop = False
        Me.TotalChargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ClearToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(192, 156)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(191, 38)
        Me.FileToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(191, 38)
        Me.ClearToolStripMenuItem.Text = "Cl&ear"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(191, 38)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(191, 38)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.TopMenuStrip.Size = New System.Drawing.Size(1285, 48)
        Me.TopMenuStrip.TabIndex = 40
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem1, Me.SummaryToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(72, 44)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(250, 44)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(250, 44)
        Me.ClearToolStripMenuItem1.Text = "Cl&ear"
        '
        'SummaryToolStripMenuItem1
        '
        Me.SummaryToolStripMenuItem1.Name = "SummaryToolStripMenuItem1"
        Me.SummaryToolStripMenuItem1.Size = New System.Drawing.Size(250, 44)
        Me.SummaryToolStripMenuItem1.Text = "&Summary"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(250, 44)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'RentalForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1285, 840)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.TotalChargeTextBox)
        Me.Controls.Add(Me.TotalDiscountTextBox)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.MileageChargeTextBox)
        Me.Controls.Add(Me.TotalMilesTextBox)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.VDivLabel)
        Me.Controls.Add(Me.HDivLabel)
        Me.Controls.Add(Me.YouOweLabel)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MileChargeLabel)
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
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "RentalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acme Car Rental Service"
        Me.RentalFormToolTip.SetToolTip(Me, "ENTER YOUR INFO FOR THE BEST RATES THIS SIDE OF THE MISSISSIPPI!!!!")
        Me.OdometerGroupbox.ResumeLayout(False)
        Me.OdometerGroupbox.PerformLayout()
        Me.DiscountGroupbox.ResumeLayout(False)
        Me.DiscountGroupbox.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
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
    Friend WithEvents MileChargeLabel As System.Windows.Forms.Label
    Friend WithEvents DayChargeLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents YouOweLabel As System.Windows.Forms.Label
    Friend WithEvents HDivLabel As System.Windows.Forms.Label
    Friend WithEvents VDivLabel As System.Windows.Forms.Label
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents RentalFormToolTip As ToolTip
    Private components As System.ComponentModel.IContainer
    Friend WithEvents TotalMilesTextBox As TextBox
    Friend WithEvents MileageChargeTextBox As TextBox
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents TotalDiscountTextBox As TextBox
    Friend WithEvents TotalChargeTextBox As TextBox
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
