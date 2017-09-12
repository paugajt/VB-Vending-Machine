Public Class AddMoneyForm
    Friend moneyAdded As Decimal
    Private moneyToAdd As Decimal

    Private Sub NickelButton_Click(sender As Object, e As EventArgs) Handles NickelButton.Click
        'Add a nickel to the total
        VendingForm.nickels += 1
        moneyToAdd += 0.05
        'Display the amount to add in the text box
        AddAmountTextBox.Text = moneyToAdd.ToString("C")
    End Sub

    Private Sub DimeButton_Click(sender As Object, e As EventArgs) Handles DimeButton.Click
        'Add a dime to the total
        VendingForm.dimes += 1
        moneyToAdd += 0.1
        'Display the amount to add in the text box
        AddAmountTextBox.Text = moneyToAdd.ToString("C")
    End Sub

    Private Sub QuarterButton_Click(sender As Object, e As EventArgs) Handles QuarterButton.Click
        'add a quarter to the total
        VendingForm.quarters += 1
        moneyToAdd += 0.25
        'Display the amount to add in the text box
        AddAmountTextBox.Text = moneyToAdd.ToString("C")
    End Sub

    Private Sub DollarButton_Click(sender As Object, e As EventArgs) Handles DollarButton.Click
        'add a dollar to the total
        VendingForm.dollarBills += 1
        moneyToAdd += 1.0
        'Display the amount to add in the text box
        AddAmountTextBox.Text = moneyToAdd.ToString("C")
    End Sub

    Private Sub FiveDollarButton_Click(sender As Object, e As EventArgs) Handles FiveDollarButton.Click
        'add a five dollar bill to the total
        VendingForm.fiveDollarBills += 1
        moneyToAdd += 5.0
        'Display the amount to add in the text box
        AddAmountTextBox.Text = moneyToAdd.ToString("C")
    End Sub

    Private Sub AddMoneyButton_Click(sender As Object, e As EventArgs) Handles AddMoneyButton.Click
        'add the money to the be used in the purchase
        Dim result As DialogResult
        If moneyToAdd <= 20.0 Then
            result = MessageBox.Show("Do you want to add " & moneyToAdd.ToString("C") & " to the vending Machine?", _
                                         "Add Money", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = Windows.Forms.DialogResult.Yes Then
                VendingForm.AddMoney(moneyToAdd)
                AddAmountTextBox.Clear()
                Me.Hide()
            End If
            'reset the money to add
            moneyToAdd = 0
        Else
            MessageBox.Show("This machine only accepts up to $20", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CancelButton.PerformClick()

        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'cancels the input of money
        Dim result As DialogResult

        result = MessageBox.Show(moneyToAdd.ToString("C") & " will be refunded" & Environment.NewLine & _
                                 "Do you want to cancel adding money?", "Cancel Add Money", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            VendingForm.calcChange(moneyToAdd)
            moneyToAdd = 0
            AddAmountTextBox.Clear()
            Me.Hide()
        End If

    End Sub

   
End Class