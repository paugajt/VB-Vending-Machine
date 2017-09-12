Public Class AddInventoryForm
    Private item As String
    Private Sub AddInventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item = ManagerForm.itemToAdd
        HeadingLabel.Text = item
        For i As Integer = 0 To 3
            For j As Integer = 0 To 3
                If VendingForm.inventoryArray(i, j).item = item Then
                    HeadingLabel.Text = "Add to the " & item & " inventory"
                    CurrentInventoryTextBox.Text = VendingForm.inventoryArray(i, j).amount.ToString
                End If
            Next j
        Next i
    End Sub

    Private Sub CancelAddButton_Click(sender As Object, e As EventArgs) Handles CancelAddButton.Click
        'Cancels the form
        Dim result As DialogResult

        'if there is text in the add item, check if they want to cancel
        If AddItemsTextBox.Text <> "" Then
            result = MessageBox.Show("Cancel updating inventory?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                With AddItemsTextBox
                    .Focus()
                    .SelectAll()
                End With
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub AddInventoryButton_Click(sender As Object, e As EventArgs) Handles AddInventoryButton.Click
        'add the amount to the inventory of the selected item
        Dim numItems As Integer
        Try
            'make sure the entry isn't blank
            If AddItemsTextBox.Text <> "" Then
                numItems = Integer.Parse(AddItemsTextBox.Text)
                'make sure the value is greater than zero 
                If numItems > 0 Then
                    For i As Integer = 0 To 3
                        For j As Integer = 0 To 3
                            If VendingForm.inventoryArray(i, j).item = item Then
                                VendingForm.inventoryArray(i, j).amount += numItems
                                MessageBox.Show(numItems.ToString & " " & VendingForm.inventoryArray(i, j).item & _
                                                "'s were added to the inventory", "Inventory Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            End If
                        Next
                    Next
                End If
            End If
        Catch numItemsException As FormatException
            MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            With AddItemsTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub
End Class