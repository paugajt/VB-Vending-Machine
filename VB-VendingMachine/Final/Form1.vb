'Programmer:                  Justin Pauga
'Date:                        4/22/2017
'Program:                     Vending Machine Final
'Description:                 Allows a user to select from 16 vending items to add. They must insert money and complete
'                             a purchase. Program asks for more money if there is insufficient funds or refunds any
'                             money left over. Keeps track of order totals, money added, money refunded. Manager mode
'                             allows a manager to get a summary of the sales, re-stock items, re-stock cash reserves and
'                             pull out profits

Public Class VendingForm
    Structure purchase
        Dim totalDue As Decimal
        Dim amtPaid As Decimal
        Dim difference As Decimal
        Dim numItems As Integer
    End Structure
    Structure vendingItem
        Dim item As String
        Dim price As Decimal
        Dim amount As Integer
    End Structure
    'Declare constants
    Const SODA_PRICE As Decimal = 1.5
    Const CHIPS_PRICE As Decimal = 2
    Const CANDY_PRICE As Decimal = 0.75
    Const BREATH_PRICE As Decimal = 0.5

    'Declare variables
    'Pre load the vending machine with $20 in each denomination
    Friend nickels As Integer = 400
    Friend dimes As Integer = 200
    '$40 for quarters
    Friend quarters As Integer = 240
    '$60 for dollar bills
    Friend dollarBills As Integer = 60
    '$100 for five dollar bills
    Friend fiveDollarBills As Integer = 20
    'Keep track of the number of orders
    Friend count As Integer                   'keeps track of the number of orders
    Private itemCount As Integer               'keeps track of the number of items in an order
    Private capital As Decimal                 'keeps track of the amount of money put in for refunds
    Friend profit As Decimal                   'keeps track of the amount of money put into the machine
    Friend totalMoney As Decimal               'Keeps track of the total amount of money in the machine
    Private priceArray(4) As Decimal           'an array containing the prices for the items
    Friend inventoryArray(4, 4) As vendingItem 'an array containg the inventory of the vending machine
    Friend itemArray(5) As vendingItem         'an array that holds each item in an order (max 5)
    Friend orderArray(20) As purchase          'an array containing up to 20 orders

'test
    Private Sub VendingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the capital
        capital = (nickels * 0.05) + (dimes * 0.1) + (quarters * 0.25) + dollarBills + (fiveDollarBills * 5)
        totalMoney = capital
        'load the inventory with a base of 20 items each
        loadVendingMachine(20)
        'Only allow 5 items per order
    End Sub

    Private Sub loadVendingMachine(ByVal numItems As Integer)
        'loads the vendingArray with the items
        'initialize the items first
        Dim coke As New vendingItem
        coke.item = "Coke"
        coke.price = SODA_PRICE
        coke.amount = numItems
        Dim dietCoke As New vendingItem
        dietCoke.item = "Diet Coke"
        dietCoke.price = SODA_PRICE
        dietCoke.amount = numItems
        Dim drPepper As New vendingItem
        drPepper.item = "Dr. Pepper"
        drPepper.price = SODA_PRICE
        drPepper.amount = numItems
        Dim mountainDew As New vendingItem
        mountainDew.item = "Mountain Dew"
        mountainDew.price = SODA_PRICE
        mountainDew.amount = numItems
        Dim sunChips As New vendingItem
        sunChips.item = "Sun Chips"
        sunChips.price = CHIPS_PRICE
        sunChips.amount = numItems
        Dim nachoCheese As New vendingItem
        nachoCheese.item = "Nacho Cheese Doritos"
        nachoCheese.price = CHIPS_PRICE
        nachoCheese.amount = numItems
        Dim coolerRanch As New vendingItem
        coolerRanch.item = "Cooler Ranch Doritos"
        coolerRanch.price = CHIPS_PRICE
        coolerRanch.amount = numItems
        Dim popcorn As New vendingItem
        popcorn.item = "Popcorn"
        popcorn.price = CHIPS_PRICE
        popcorn.amount = numItems
        Dim snickers As New vendingItem
        snickers.item = "Snickers Bar"
        snickers.price = CANDY_PRICE
        snickers.amount = numItems
        Dim reeses As New vendingItem
        reeses.item = "Reeses Peanut Butter Cup"
        reeses.price = CANDY_PRICE
        reeses.amount = numItems
        Dim twix As New vendingItem
        twix.item = "Twix"
        twix.price = CANDY_PRICE
        twix.amount = numItems
        Dim milkyWay As New vendingItem
        milkyWay.item = "Milky Way"
        milkyWay.price = CANDY_PRICE
        milkyWay.amount = numItems
        Dim fiveGum As New vendingItem
        fiveGum.item = "Five Gum"
        fiveGum.price = BREATH_PRICE
        fiveGum.amount = numItems
        Dim orbit As New vendingItem
        orbit.item = "Orbit Gum"
        orbit.price = BREATH_PRICE
        orbit.amount = numItems
        Dim lifeSavers As New vendingItem
        lifeSavers.item = "LifeSavers"
        lifeSavers.price = BREATH_PRICE
        lifeSavers.amount = numItems
        Dim altoids As New vendingItem
        altoids.item = "Altoids"
        altoids.price = BREATH_PRICE
        altoids.amount = numItems

        'fill the vending machine array
        inventoryArray = {{coke, dietCoke, drPepper, mountainDew}, {sunChips, nachoCheese, coolerRanch, popcorn}, _
                          {snickers, reeses, twix, milkyWay}, {fiveGum, orbit, lifeSavers, altoids}}
    End Sub

    Private Sub AddItem(ByRef item As vendingItem)
        'add the item to the order array
        Dim itemString As String = item.item
        If itemCount < 5 Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 3
                    If inventoryArray(i, j).item = itemString Then
                        If inventoryArray(i, j).amount > 0 Then
                            orderArray(count).totalDue += item.price
                            orderArray(count).numItems += 1
                            itemArray(itemCount) = item
                            itemCount += 1
                        Else
                            MessageBox.Show(inventoryArray(i, j).item & " is Sold Out" & Environment.NewLine & _
                                            "Please select another item", "Item Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next j
            Next i
        Else
            MessageBox.Show("Orders are limited to 5 items per order", "Order Full", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'display the running total
        PurchaseAmountTextBox.Text = orderArray(count).totalDue.ToString("C")
    End Sub
    Private Sub CokeButton_Click(sender As Object, e As EventArgs) Handles CokeButton.Click
        'add a coke to the order
        AddItem(inventoryArray(0, 0))

    End Sub
    Private Sub DietCokebutton_Click(sender As Object, e As EventArgs) Handles DietCokebutton.Click
        'add a diet coke to the order
        AddItem(inventoryArray(0, 1))
    End Sub

    Private Sub DrPepperButton_Click(sender As Object, e As EventArgs) Handles DrPepperButton.Click
        'add a Dr Pepper to the order
        AddItem(inventoryArray(0, 2))
    End Sub

    Private Sub MtnDewbutton_Click(sender As Object, e As EventArgs) Handles MtnDewbutton.Click
        'add a Mountain Dew to the order
        AddItem(inventoryArray(0, 3))
    End Sub

    Private Sub SunChipsButton_Click(sender As Object, e As EventArgs) Handles SunChipsButton.Click
        'add sun chips to the order
        AddItem(inventoryArray(1, 0))
    End Sub

    Private Sub NachoCheeseButton_Click(sender As Object, e As EventArgs) Handles NachoCheeseButton.Click
        'add Nacho Cheese doritios to the order
        AddItem(inventoryArray(1, 1))
    End Sub

    Private Sub CoolerRanchButton_Click(sender As Object, e As EventArgs) Handles CoolerRanchButton.Click
        'add cooler ranch doritos to the order
        AddItem(inventoryArray(1, 2))
    End Sub

    Private Sub PopcornButton_Click(sender As Object, e As EventArgs) Handles PopcornButton.Click
        'add popcorn to the order
        AddItem(inventoryArray(1, 3))
    End Sub

    Private Sub SnickersButton_Click(sender As Object, e As EventArgs) Handles SnickersButton.Click
        'add a snickers bar to the order
        AddItem(inventoryArray(2, 0))
    End Sub

    Private Sub ReesesButton_Click(sender As Object, e As EventArgs) Handles ReesesButton.Click
        'add a reeses peanut butter cup to the order
        AddItem(inventoryArray(2, 1))
    End Sub

    Private Sub TwixButton_Click(sender As Object, e As EventArgs) Handles TwixButton.Click
        'add a twix to the order
        AddItem(inventoryArray(2, 2))
    End Sub

    Private Sub MilkyWayButton_Click(sender As Object, e As EventArgs) Handles MilkyWayButton.Click
        'add a milky way to the order
        AddItem(inventoryArray(2, 3))
    End Sub

    Private Sub ReactGumButton_Click(sender As Object, e As EventArgs) Handles ReactGumButton.Click
        'add 5 guym to the order
        AddItem(inventoryArray(3, 0))
    End Sub

    Private Sub OrbitGumButton_Click(sender As Object, e As EventArgs) Handles OrbitGumButton.Click
        'add orbit gum to the order
        AddItem(inventoryArray(3, 1))
    End Sub

    Private Sub LifeSaversButton_Click(sender As Object, e As EventArgs) Handles LifeSaversButton.Click
        'add life savers to the order
        AddItem(inventoryArray(3, 2))
    End Sub

    Private Sub AltoidsButton_Click(sender As Object, e As EventArgs) Handles AltoidsButton.Click
        'add altoids to the order
        AddItem(inventoryArray(3, 3))

    End Sub

    Private Sub AddMoneyButton_Click(sender As Object, e As EventArgs) Handles AddMoneyButton.Click, AddMoneyToolStripMenuItem.Click
        'Display the add money form
        AddMoneyForm.Show()
    End Sub

    Public Sub AddMoney(ByVal moneyToAdd As Decimal)
        'add the users money
        AmtEnteredTextBox.Text = moneyToAdd.ToString("C")
        orderArray(count).amtPaid += moneyToAdd
        CalcDifference()

    End Sub

    Private Sub CalcDifference()
        'calculate the difference and display it in the text box
        orderArray(count).difference = orderArray(count).totalDue - orderArray(count).amtPaid
        AmountDueTextBox.Text = orderArray(count).difference.ToString("C")
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click, CancelToolStripMenuItem.Click
        'cancels the order
        Dim message As String
        Dim result As DialogResult

        result = MessageBox.Show("Cancel the Order?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            message = orderArray(count).amtPaid.ToString("C") & " will be refunded"
            MessageBox.Show(message, "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With orderArray(count)
                calcChange(.amtPaid)
                .amtPaid = 0
                .totalDue = 0
                .difference = 0
            End With
           
            'clear the form
            ClearForm()


        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Show the about box
        AboutBox1.Show()
    End Sub

    Private Sub CompletePurchaseButton_Click(sender As Object, e As EventArgs) Handles CompletePurchaseButton.Click, CompletePurchaseToolStripMenuItem.Click
        'Complete the purchase, adjust inventory and issue a refund if there is any
        'Make sure there is at least one item in the order
        If orderArray(count).totalDue <> 0 Or orderArray(count).amtPaid <> 0 Then
            'Call calcDifference to account for if they didn't add any money
            CalcDifference()
            'Make sure the customer put in enough money to pay
            If orderArray(count).difference <= 0 Then
                calcChange(orderArray(count).difference * -1)
                'Remove the items from the inventory
                For i As Integer = 0 To 3
                    For j As Integer = 0 To 3
                        For k As Integer = 0 To itemCount - 1

                            If inventoryArray(i, j).item = itemArray(k).item Then

                                inventoryArray(i, j).amount -= 1

                            End If
                        Next k
                    Next j
                Next i

                'Vend the items
                VendItems()
                'Add the money to the total
                totalMoney += orderArray(count).amtPaid - (orderArray(count).difference * -1)
                profit = totalMoney - capital

                'Increase the count to start a new order and clear the form
                count += 1
                ClearForm()
                'clear the order's item array for the next order
                System.Array.Clear(itemArray, 0, 5)


            Else
                MessageBox.Show("Please insert " & orderArray(count).difference.ToString("C") & " to complete your purchase", _
                                "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Else
            MessageBox.Show("Please select an Item or enter money to continue", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub VendItems()
        'Show the user what items they bought
        Dim Message As String
        Message = "Items Vended" & Environment.NewLine
        For i As Integer = 0 To itemCount - 1
            If itemArray(i).item <> "" Then
                Message += itemArray(i).item & Environment.NewLine
            End If
        Next i

        MessageBox.Show(Message, "Vending Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClearForm()
        'clear the text boxes
        AmtEnteredTextBox.Clear()
        PurchaseAmountTextBox.Clear()
        AmountDueTextBox.Clear()
        'reset the item count
        itemCount = 0
    End Sub
    Public Sub calcChange(ByVal money As Decimal)
        'calculate the denominations for the change
        Dim refundNickels, refundDimes, refundQuarters, refundDollars, refundFiveDollars As Integer
        Dim moneyCalc As Integer
        Dim origMoney As Decimal = money
        'multiply money by 100 to make it easier to calculate
        moneyCalc = money * 100

        If moneyCalc \ 500 > 0 Then
            refundFiveDollars = moneyCalc \ 500
            fiveDollarBills -= refundFiveDollars
            moneyCalc -= 500 * refundFiveDollars
            money -= 5 * refundFiveDollars
        End If
        If moneyCalc \ 100 > 0 Then
            refundDollars = moneyCalc \ 100
            dollarBills -= refundDollars
            moneyCalc -= 100 * refundDollars
            money -= refundDollars
        End If

        If moneyCalc \ 25 > 0 Then
            refundQuarters = moneyCalc \ 25
            quarters -= refundQuarters
            moneyCalc -= 25 * refundQuarters
            money -= 0.25 * refundQuarters
        End If
        If moneyCalc \ 10 > 0 Then
            refundDimes = moneyCalc \ 10
            dimes -= refundDimes
            moneyCalc -= 10 * refundDimes
            money -= 0.1 * refundDimes
        End If
        If moneyCalc \ 5 > 0 Then
            refundNickels = moneyCalc \ 5
            nickels -= refundNickels
            moneyCalc -= 5 * refundNickels
            money -= 0.05 * refundNickels
        End If
        Dim message As String
        message = "You are getting back: " & origMoney.ToString("C") & Environment.NewLine _
                  & refundNickels.ToString & " Nickels" & Environment.NewLine & refundDimes.ToString & " Dimes" _
                  & Environment.NewLine & refundQuarters.ToString & " Quarters" & Environment.NewLine _
                  & refundDollars.ToString & " Dollar Bills" & Environment.NewLine & refundFiveDollars.ToString _
                  & " Five Dollar Bills"
        MessageBox.Show(message, "Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program
        Me.Close()
    End Sub

    Private Sub ManagerLogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerLogInToolStripMenuItem.Click
        'Display the password prompt
        LogInForm.Show()
    End Sub

End Class
