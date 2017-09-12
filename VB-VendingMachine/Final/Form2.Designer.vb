<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMoneyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NickelButton = New System.Windows.Forms.Button()
        Me.DimeButton = New System.Windows.Forms.Button()
        Me.QuarterButton = New System.Windows.Forms.Button()
        Me.DollarButton = New System.Windows.Forms.Button()
        Me.FiveDollarButton = New System.Windows.Forms.Button()
        Me.AddAmountLabel = New System.Windows.Forms.Label()
        Me.AddAmountTextBox = New System.Windows.Forms.TextBox()
        Me.AddMoneyButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'NickelButton
        '
        Me.NickelButton.Location = New System.Drawing.Point(27, 73)
        Me.NickelButton.Name = "NickelButton"
        Me.NickelButton.Size = New System.Drawing.Size(172, 79)
        Me.NickelButton.TabIndex = 0
        Me.NickelButton.Text = "Nickel"
        Me.ToolTip1.SetToolTip(Me.NickelButton, "Add a nickel to the machine")
        Me.NickelButton.UseVisualStyleBackColor = True
        '
        'DimeButton
        '
        Me.DimeButton.Location = New System.Drawing.Point(27, 201)
        Me.DimeButton.Name = "DimeButton"
        Me.DimeButton.Size = New System.Drawing.Size(172, 79)
        Me.DimeButton.TabIndex = 1
        Me.DimeButton.Text = "Dime"
        Me.ToolTip1.SetToolTip(Me.DimeButton, "Add a dime to the machine")
        Me.DimeButton.UseVisualStyleBackColor = True
        '
        'QuarterButton
        '
        Me.QuarterButton.Location = New System.Drawing.Point(27, 331)
        Me.QuarterButton.Name = "QuarterButton"
        Me.QuarterButton.Size = New System.Drawing.Size(172, 79)
        Me.QuarterButton.TabIndex = 2
        Me.QuarterButton.Text = "Quarter"
        Me.ToolTip1.SetToolTip(Me.QuarterButton, "Add a quarter to the machine")
        Me.QuarterButton.UseVisualStyleBackColor = True
        '
        'DollarButton
        '
        Me.DollarButton.Location = New System.Drawing.Point(27, 464)
        Me.DollarButton.Name = "DollarButton"
        Me.DollarButton.Size = New System.Drawing.Size(172, 79)
        Me.DollarButton.TabIndex = 3
        Me.DollarButton.Text = "Dollar"
        Me.ToolTip1.SetToolTip(Me.DollarButton, "Add a dollar bill to the machine")
        Me.DollarButton.UseVisualStyleBackColor = True
        '
        'FiveDollarButton
        '
        Me.FiveDollarButton.Location = New System.Drawing.Point(27, 598)
        Me.FiveDollarButton.Name = "FiveDollarButton"
        Me.FiveDollarButton.Size = New System.Drawing.Size(172, 79)
        Me.FiveDollarButton.TabIndex = 4
        Me.FiveDollarButton.Text = "Five Dollars"
        Me.ToolTip1.SetToolTip(Me.FiveDollarButton, "Add a five dollar bill to the machine")
        Me.FiveDollarButton.UseVisualStyleBackColor = True
        '
        'AddAmountLabel
        '
        Me.AddAmountLabel.AutoSize = True
        Me.AddAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddAmountLabel.Location = New System.Drawing.Point(382, 259)
        Me.AddAmountLabel.Name = "AddAmountLabel"
        Me.AddAmountLabel.Size = New System.Drawing.Size(192, 31)
        Me.AddAmountLabel.TabIndex = 5
        Me.AddAmountLabel.Text = "Amount to Add"
        '
        'AddAmountTextBox
        '
        Me.AddAmountTextBox.Location = New System.Drawing.Point(388, 336)
        Me.AddAmountTextBox.Name = "AddAmountTextBox"
        Me.AddAmountTextBox.ReadOnly = True
        Me.AddAmountTextBox.Size = New System.Drawing.Size(186, 31)
        Me.AddAmountTextBox.TabIndex = 6
        '
        'AddMoneyButton
        '
        Me.AddMoneyButton.Location = New System.Drawing.Point(405, 406)
        Me.AddMoneyButton.Name = "AddMoneyButton"
        Me.AddMoneyButton.Size = New System.Drawing.Size(156, 50)
        Me.AddMoneyButton.TabIndex = 7
        Me.AddMoneyButton.Text = "Add Money"
        Me.ToolTip1.SetToolTip(Me.AddMoneyButton, "Complete adding money")
        Me.AddMoneyButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(405, 489)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(156, 50)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.CancelButton, "Cancel adding money")
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddMoneyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(797, 816)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddMoneyButton)
        Me.Controls.Add(Me.AddAmountTextBox)
        Me.Controls.Add(Me.AddAmountLabel)
        Me.Controls.Add(Me.FiveDollarButton)
        Me.Controls.Add(Me.DollarButton)
        Me.Controls.Add(Me.QuarterButton)
        Me.Controls.Add(Me.DimeButton)
        Me.Controls.Add(Me.NickelButton)
        Me.Name = "AddMoneyForm"
        Me.Text = "Add Money"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NickelButton As System.Windows.Forms.Button
    Friend WithEvents DimeButton As System.Windows.Forms.Button
    Friend WithEvents QuarterButton As System.Windows.Forms.Button
    Friend WithEvents DollarButton As System.Windows.Forms.Button
    Friend WithEvents FiveDollarButton As System.Windows.Forms.Button
    Friend WithEvents AddAmountLabel As System.Windows.Forms.Label
    Friend WithEvents AddAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddMoneyButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
