<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInventoryForm
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
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.CurrentInventoryLabel = New System.Windows.Forms.Label()
        Me.CurrentInventoryTextBox = New System.Windows.Forms.TextBox()
        Me.AddItemsLabel = New System.Windows.Forms.Label()
        Me.AddItemsTextBox = New System.Windows.Forms.TextBox()
        Me.AddInventoryButton = New System.Windows.Forms.Button()
        Me.CancelAddButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'HeadingLabel
        '
        Me.HeadingLabel.AutoSize = True
        Me.HeadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HeadingLabel.Location = New System.Drawing.Point(234, 34)
        Me.HeadingLabel.Name = "HeadingLabel"
        Me.HeadingLabel.Size = New System.Drawing.Size(111, 37)
        Me.HeadingLabel.TabIndex = 0
        Me.HeadingLabel.Text = "Label1"
        '
        'CurrentInventoryLabel
        '
        Me.CurrentInventoryLabel.AutoSize = True
        Me.CurrentInventoryLabel.Location = New System.Drawing.Point(48, 153)
        Me.CurrentInventoryLabel.Name = "CurrentInventoryLabel"
        Me.CurrentInventoryLabel.Size = New System.Drawing.Size(297, 25)
        Me.CurrentInventoryLabel.TabIndex = 1
        Me.CurrentInventoryLabel.Text = "Number of Items in Inventory: "
        '
        'CurrentInventoryTextBox
        '
        Me.CurrentInventoryTextBox.Location = New System.Drawing.Point(351, 147)
        Me.CurrentInventoryTextBox.Name = "CurrentInventoryTextBox"
        Me.CurrentInventoryTextBox.ReadOnly = True
        Me.CurrentInventoryTextBox.Size = New System.Drawing.Size(100, 31)
        Me.CurrentInventoryTextBox.TabIndex = 2
        Me.CurrentInventoryTextBox.TabStop = False
        '
        'AddItemsLabel
        '
        Me.AddItemsLabel.AutoSize = True
        Me.AddItemsLabel.Location = New System.Drawing.Point(53, 237)
        Me.AddItemsLabel.Name = "AddItemsLabel"
        Me.AddItemsLabel.Size = New System.Drawing.Size(248, 25)
        Me.AddItemsLabel.TabIndex = 3
        Me.AddItemsLabel.Text = "Number of Items to Add: "
        '
        'AddItemsTextBox
        '
        Me.AddItemsTextBox.Location = New System.Drawing.Point(351, 230)
        Me.AddItemsTextBox.Name = "AddItemsTextBox"
        Me.AddItemsTextBox.Size = New System.Drawing.Size(100, 31)
        Me.AddItemsTextBox.TabIndex = 4
        '
        'AddInventoryButton
        '
        Me.AddInventoryButton.Location = New System.Drawing.Point(196, 298)
        Me.AddInventoryButton.Name = "AddInventoryButton"
        Me.AddInventoryButton.Size = New System.Drawing.Size(149, 68)
        Me.AddInventoryButton.TabIndex = 5
        Me.AddInventoryButton.Text = "&Add To Inventory"
        Me.ToolTip1.SetToolTip(Me.AddInventoryButton, "Add items to the selected inventory")
        Me.AddInventoryButton.UseVisualStyleBackColor = True
        '
        'CancelAddButton
        '
        Me.CancelAddButton.Location = New System.Drawing.Point(411, 298)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(149, 68)
        Me.CancelAddButton.TabIndex = 6
        Me.CancelAddButton.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.CancelAddButton, "Cancel adding items to inventory")
        Me.CancelAddButton.UseVisualStyleBackColor = True
        '
        'AddInventoryForm
        '
        Me.AcceptButton = Me.AddInventoryButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(838, 434)
        Me.Controls.Add(Me.CancelAddButton)
        Me.Controls.Add(Me.AddInventoryButton)
        Me.Controls.Add(Me.AddItemsTextBox)
        Me.Controls.Add(Me.AddItemsLabel)
        Me.Controls.Add(Me.CurrentInventoryTextBox)
        Me.Controls.Add(Me.CurrentInventoryLabel)
        Me.Controls.Add(Me.HeadingLabel)
        Me.Name = "AddInventoryForm"
        Me.Text = "Add Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadingLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentInventoryLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentInventoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddItemsLabel As System.Windows.Forms.Label
    Friend WithEvents AddItemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddInventoryButton As System.Windows.Forms.Button
    Friend WithEvents CancelAddButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
