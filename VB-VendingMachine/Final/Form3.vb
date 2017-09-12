Public Class ManagerForm
    Private dailyProfit As Decimal       'Keeps track of the daily profit regardless of whether it is withdrawn or not
    Friend itemToAdd As String                'Used to know what item you are adding

    Private Sub ManagerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Reverts the vending machine back to vending mode
        VendingForm.Show()
    End Sub

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display instructions for the manager
        Dim message As String
        message = "To add inventory, click on the product you want to add"
        MessageBox.Show(message, "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'load the dailyprofit
        dailyProfit = VendingForm.profit
        'Load the total money and profit text boxes
        LoadDailyTotals()
        
    End Sub

    Private Sub LoadDailyTotals()
        'Load the daily totals into the text box
        DailyTotalTextBox.Text = VendingForm.totalMoney.ToString("C")
        DailyProfitTextBox.Text = VendingForm.profit.ToString("C")
    End Sub

    Private Sub WithdrawProfitButton_Click(sender As Object, e As EventArgs) Handles WithdrawProfitButton.Click
        'WithDraw the profit from the machine
        VendingForm.calcChange(VendingForm.profit)
        'Subtract the profit from the total
        VendingForm.totalMoney = VendingForm.totalMoney - VendingForm.profit
        'Set the profit to 0
        VendingForm.profit = 0
        LoadDailyTotals()
    End Sub

    Private Sub AddToInventory()
        'Add the item to the inventory
        AddInventoryForm.Show()
    End Sub

    Private Sub CokeButton_Click(sender As Object, e As EventArgs) Handles CokeButton.Click
        'Select coke to add inventory
        itemToAdd = "Coke"
        AddToInventory()
    End Sub

    Private Sub DietCokebutton_Click(sender As Object, e As EventArgs) Handles DietCokebutton.Click
        'Select diet coke to add inventory
        itemToAdd = "Diet Coke"
        AddToInventory()
    End Sub

    Private Sub DrPepperButton_Click(sender As Object, e As EventArgs) Handles DrPepperButton.Click
        'Select Dr Pepper to add inventory
        itemToAdd = "Diet Coke"
        AddToInventory()
    End Sub

    Private Sub MtnDewbutton_Click(sender As Object, e As EventArgs) Handles MtnDewbutton.Click
        'Select mountain dew to add inventory
        itemToAdd = "Mountain Dew"
        AddToInventory()
    End Sub

    Private Sub SunChipsButton_Click(sender As Object, e As EventArgs) Handles SunChipsButton.Click
        'select sunchips to add to inventory
        itemToAdd = "Sun Chips"
        AddToInventory()
    End Sub

    Private Sub NachoCheeseButton_Click(sender As Object, e As EventArgs) Handles NachoCheeseButton.Click
        'select nacho cheese doritos to add to inventory
        itemToAdd = "Nacho Cheese Doritos"
        AddToInventory()
    End Sub

    Private Sub CoolerRanchButton_Click(sender As Object, e As EventArgs) Handles CoolerRanchButton.Click
        'select cooler ranch doritos to add to inventory
        itemToAdd = "Cooler Ranch Doritos"
        AddToInventory()
    End Sub

    Private Sub PopcornButton_Click(sender As Object, e As EventArgs) Handles PopcornButton.Click
        'select popcorn to add to inventory
        itemToAdd = "Popcorn"
        AddToInventory()
    End Sub

    Private Sub SnickersButton_Click(sender As Object, e As EventArgs) Handles SnickersButton.Click
        'select snickers to add to inventory
        itemToAdd = "Snickers Bar"
        AddToInventory()
    End Sub

    Private Sub ReesesButton_Click(sender As Object, e As EventArgs) Handles ReesesButton.Click
        'select reeses to add to inventory
        itemToAdd = "Reeses Peanut Butter Cup"
        AddToInventory()
    End Sub

    Private Sub TwixButton_Click(sender As Object, e As EventArgs) Handles TwixButton.Click
        'select twix to add to inventory
        itemToAdd = "Twix"
        AddToInventory()
    End Sub

    Private Sub MilkyWayButton_Click(sender As Object, e As EventArgs) Handles MilkyWayButton.Click
        'select Milky way to add to inventory
        itemToAdd = "Milky Way"
        AddToInventory()
    End Sub

    Private Sub ReactGumButton_Click(sender As Object, e As EventArgs) Handles ReactGumButton.Click
        'select react gum to add to inventory
        itemToAdd = "Five Gum"
        AddToInventory()
    End Sub

    Private Sub OrbitGumButton_Click(sender As Object, e As EventArgs) Handles OrbitGumButton.Click
        'select orbit gum to add to inventory
        itemToAdd = "Orbit Gum"
        AddToInventory()
    End Sub

    Private Sub LifeSaversButton_Click(sender As Object, e As EventArgs) Handles LifeSaversButton.Click
        'select lifesavers to add to inventory
        itemToAdd = "LifeSavers"
        AddToInventory()
    End Sub

    Private Sub AltoidsButton_Click(sender As Object, e As EventArgs) Handles AltoidsButton.Click
        'select altoids to add to inventory
        itemToAdd = "Altoids"
        AddToInventory()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Show the about box
        AboutBox1.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Prints the orders
        PrintPreviewDialog1.Document = PrintOrders
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintOrders_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintOrders.PrintPage
        'Prints a list of all the orders
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 16, FontStyle.Bold)
        Dim CategoryFont As New Font("Arial", 14, FontStyle.Underline)
        Dim LineHeight As Single = PrintFont.GetHeight + 2
        Dim VerticalPrintLocation As Single = e.MarginBounds.Top
        Dim Column1Location As Single = e.MarginBounds.Left
        Dim Column2Location As Single = 300
        Dim Column3Location As Single
        Dim FontSizeF As New SizeF
        Dim PrintString As String
        Dim orderNumber As Integer
        Dim profit As Decimal

        'Get the number of orders

        'Print the heading
        PrintString = "Orders"
        e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column2Location, VerticalPrintLocation)
        'add a space
        VerticalPrintLocation += LineHeight * 4

        'Print the total money
        PrintString = "Total Money in Machine: " & VendingForm.totalMoney.ToString("C")
        e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column1Location, VerticalPrintLocation)
        'add a line
        VerticalPrintLocation += LineHeight * 2

        'Print the profit
        PrintString = "Profit: " & VendingForm.profit.ToString("C")
        e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column1Location, VerticalPrintLocation)
        'add a line
        VerticalPrintLocation += LineHeight * 2

        'Print the orders
        'Print the categories headings
        'order number
        PrintString = "Order #"
        e.Graphics.DrawString(PrintString, CategoryFont, Brushes.Black, Column1Location, VerticalPrintLocation)

        'items in order
        PrintString = "Number of Items"
        e.Graphics.DrawString(PrintString, CategoryFont, Brushes.Black, Column2Location, VerticalPrintLocation)

        'Set up the 3rd Column
        FontSizeF = e.Graphics.MeasureString("Profit", CategoryFont)
        Column3Location = 650 - FontSizeF.Width

        'Profit
        PrintString = "Profit"
        e.Graphics.DrawString(PrintString, CategoryFont, Brushes.Black, Column3Location, VerticalPrintLocation)

        'add a line
        VerticalPrintLocation += LineHeight * 2

        'Print the orders
        For i As Integer = 0 To VendingForm.count - 1
            'Don't Print if empty
            If VendingForm.orderArray(i).numItems <> 0 Then
                'Print the order number
                orderNumber = i + 1
                PrintString = orderNumber.ToString
                e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column1Location, VerticalPrintLocation)

                'Print the items in the order
                PrintString = VendingForm.orderArray(i).numItems.ToString
                e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column2Location, VerticalPrintLocation)

                'Print the Profit
                profit = VendingForm.orderArray(i).amtPaid - (VendingForm.orderArray(i).difference * -1)
                PrintString = profit.ToString("C")
                FontSizeF = e.Graphics.MeasureString(PrintString, PrintFont)
                Column3Location = 650 - FontSizeF.Width
                e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column3Location, VerticalPrintLocation)
                'add a space for the next line
                VerticalPrintLocation += LineHeight * 2
            End If
        Next i


    End Sub

    Private Sub PrintToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem2.Click
        'Print out the inventory
        PrintPreviewDialog1.Document = PrintInventory
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintInventory_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintInventory.PrintPage
        'Prints the inventory
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 16, FontStyle.Bold)
        Dim CategoryFont As New Font("Arial", 14, FontStyle.Underline)
        Dim LineHeight As Single = PrintFont.GetHeight + 2
        Dim VerticalPrintLocation As Single = e.MarginBounds.Top
        Dim Column1Location As Single = e.MarginBounds.Left
        Dim Column2Location As Single = 350
        Dim Column3Location As Single
        Dim FontSizeF As New SizeF
        Dim PrintString As String

        'Set up and print the heading
        PrintString = "Inventory"
        e.Graphics.DrawString(PrintString, HeadingFont, Brushes.Black, Column2Location, VerticalPrintLocation)
        'add a space
        VerticalPrintLocation += LineHeight * 4

        'Set up the headings
        'Item
        PrintString = "Item"
        e.Graphics.DrawString(PrintString, CategoryFont, Brushes.Black, Column1Location, VerticalPrintLocation)
        'Price
        PrintString = "Price"
        e.Graphics.DrawString(PrintString, CategoryFont, Brushes.Black, Column2Location, VerticalPrintLocation)
        'set up the 3rd column
        FontSizeF = e.Graphics.MeasureString("Inventory Left", CategoryFont)
        Column3Location = 650 - FontSizeF.Width
        'Inventory Left
        PrintString = "Inventory Left"
        e.Graphics.DrawString(PrintString, CategoryFont, Brushes.Black, Column3Location, VerticalPrintLocation)

        'add a space
        VerticalPrintLocation += LineHeight * 2

        'Print the inventory
        For i As Integer = 0 To 3
            For j As Integer = 0 To 3
                'print the item
                PrintString = VendingForm.inventoryArray(i, j).item
                e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column1Location, VerticalPrintLocation)
                'Print the Price
                PrintString = VendingForm.inventoryArray(i, j).price.ToString("C")
                e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column2Location, VerticalPrintLocation)
                'set up the 3rd column
                FontSizeF = e.Graphics.MeasureString(VendingForm.inventoryArray(i, j).amount.ToString, PrintFont)
                Column3Location = 650 - FontSizeF.Width
                'Print the amount
                PrintString = VendingForm.inventoryArray(i, j).amount.ToString
                e.Graphics.DrawString(PrintString, PrintFont, Brushes.Black, Column3Location, VerticalPrintLocation)
                'add a space
                VerticalPrintLocation += LineHeight * 2
            Next j
        Next i
    End Sub

    Private Sub ExitManageModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitManageModeToolStripMenuItem.Click
        'Exits the manager mode and shows the vending form
        Me.Close()
        VendingForm.Show()

    End Sub
End Class