<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Me.PasswordInfoLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LogInButton = New System.Windows.Forms.Button()
        Me.ManagerCancelButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'PasswordInfoLabel
        '
        Me.PasswordInfoLabel.AutoSize = True
        Me.PasswordInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PasswordInfoLabel.Location = New System.Drawing.Point(166, 34)
        Me.PasswordInfoLabel.Name = "PasswordInfoLabel"
        Me.PasswordInfoLabel.Size = New System.Drawing.Size(360, 31)
        Me.PasswordInfoLabel.TabIndex = 0
        Me.PasswordInfoLabel.Text = "Please Enter Your Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(246, 107)
        Me.PasswordTextBox.MaxLength = 24
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(229, 31)
        Me.PasswordTextBox.TabIndex = 1
        '
        'LogInButton
        '
        Me.LogInButton.Location = New System.Drawing.Point(246, 170)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(95, 48)
        Me.LogInButton.TabIndex = 2
        Me.LogInButton.Text = "&Log In"
        Me.ToolTip1.SetToolTip(Me.LogInButton, "Log in to manager mode")
        Me.LogInButton.UseVisualStyleBackColor = True
        '
        'ManagerCancelButton
        '
        Me.ManagerCancelButton.Location = New System.Drawing.Point(380, 170)
        Me.ManagerCancelButton.Name = "ManagerCancelButton"
        Me.ManagerCancelButton.Size = New System.Drawing.Size(95, 48)
        Me.ManagerCancelButton.TabIndex = 3
        Me.ManagerCancelButton.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.ManagerCancelButton, "Return to the vending machine")
        Me.ManagerCancelButton.UseVisualStyleBackColor = True
        '
        'LogInForm
        '
        Me.AcceptButton = Me.LogInButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 254)
        Me.Controls.Add(Me.ManagerCancelButton)
        Me.Controls.Add(Me.LogInButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordInfoLabel)
        Me.Name = "LogInForm"
        Me.Text = "Manager Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordInfoLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogInButton As System.Windows.Forms.Button
    Friend WithEvents ManagerCancelButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
