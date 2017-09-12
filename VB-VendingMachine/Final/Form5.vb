Public Class LogInForm

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        'Logs the user into manager mode
        'Check to see if there is a password
        If PasswordTextBox.Text <> "" Then
            VendingForm.Hide()
            Me.Close()
            ManagerForm.Show()

        Else
            MessageBox.Show("Please Enter You Password", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ManagerCancelButton_Click(sender As Object, e As EventArgs) Handles ManagerCancelButton.Click
        'Cancels the log in process
        Me.Close()
    End Sub
End Class