<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendingForm
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
        Me.AmtEnteredLabel = New System.Windows.Forms.Label()
        Me.AmtEnteredTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseAmountLabel = New System.Windows.Forms.Label()
        Me.PurchaseAmountTextBox = New System.Windows.Forms.TextBox()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.AddMoneyButton = New System.Windows.Forms.Button()
        Me.CompletePurchaseButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AcceptsLabel = New System.Windows.Forms.Label()
        Me.PaymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.CokeLabel = New System.Windows.Forms.Label()
        Me.DietCokeLabel = New System.Windows.Forms.Label()
        Me.DrPepperLabel = New System.Windows.Forms.Label()
        Me.MtnDewLabel = New System.Windows.Forms.Label()
        Me.SunChipsLabel = New System.Windows.Forms.Label()
        Me.NachoCheeseLabel = New System.Windows.Forms.Label()
        Me.CoolerRanchLabel = New System.Windows.Forms.Label()
        Me.PopcornLabel = New System.Windows.Forms.Label()
        Me.SnickersLabel = New System.Windows.Forms.Label()
        Me.ReesesLabel = New System.Windows.Forms.Label()
        Me.TwixLabel = New System.Windows.Forms.Label()
        Me.MilkyWayLabel = New System.Windows.Forms.Label()
        Me.ReactGumLabel = New System.Windows.Forms.Label()
        Me.SelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.AltoidsLabel = New System.Windows.Forms.Label()
        Me.LifeSaversLabel = New System.Windows.Forms.Label()
        Me.OrbitGumLabel = New System.Windows.Forms.Label()
        Me.DietCokebutton = New System.Windows.Forms.Button()
        Me.AltoidsButton = New System.Windows.Forms.Button()
        Me.CokeButton = New System.Windows.Forms.Button()
        Me.LifeSaversButton = New System.Windows.Forms.Button()
        Me.DrPepperButton = New System.Windows.Forms.Button()
        Me.OrbitGumButton = New System.Windows.Forms.Button()
        Me.MtnDewbutton = New System.Windows.Forms.Button()
        Me.ReactGumButton = New System.Windows.Forms.Button()
        Me.SunChipsButton = New System.Windows.Forms.Button()
        Me.MilkyWayButton = New System.Windows.Forms.Button()
        Me.NachoCheeseButton = New System.Windows.Forms.Button()
        Me.TwixButton = New System.Windows.Forms.Button()
        Me.CoolerRanchButton = New System.Windows.Forms.Button()
        Me.ReesesButton = New System.Windows.Forms.Button()
        Me.PopcornButton = New System.Windows.Forms.Button()
        Me.SnickersButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ManagerLogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletePurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PaymentGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectionGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AmtEnteredLabel
        '
        Me.AmtEnteredLabel.AutoSize = True
        Me.AmtEnteredLabel.Location = New System.Drawing.Point(23, 69)
        Me.AmtEnteredLabel.Name = "AmtEnteredLabel"
        Me.AmtEnteredLabel.Size = New System.Drawing.Size(178, 25)
        Me.AmtEnteredLabel.TabIndex = 0
        Me.AmtEnteredLabel.Text = "Amount Entered: "
        '
        'AmtEnteredTextBox
        '
        Me.AmtEnteredTextBox.Location = New System.Drawing.Point(225, 62)
        Me.AmtEnteredTextBox.Name = "AmtEnteredTextBox"
        Me.AmtEnteredTextBox.ReadOnly = True
        Me.AmtEnteredTextBox.Size = New System.Drawing.Size(117, 31)
        Me.AmtEnteredTextBox.TabIndex = 1
        Me.AmtEnteredTextBox.TabStop = False
        '
        'PurchaseAmountLabel
        '
        Me.PurchaseAmountLabel.AutoSize = True
        Me.PurchaseAmountLabel.Location = New System.Drawing.Point(23, 140)
        Me.PurchaseAmountLabel.Name = "PurchaseAmountLabel"
        Me.PurchaseAmountLabel.Size = New System.Drawing.Size(194, 25)
        Me.PurchaseAmountLabel.TabIndex = 2
        Me.PurchaseAmountLabel.Text = "Purchase Amount: "
        '
        'PurchaseAmountTextBox
        '
        Me.PurchaseAmountTextBox.Location = New System.Drawing.Point(225, 134)
        Me.PurchaseAmountTextBox.Name = "PurchaseAmountTextBox"
        Me.PurchaseAmountTextBox.ReadOnly = True
        Me.PurchaseAmountTextBox.Size = New System.Drawing.Size(117, 31)
        Me.PurchaseAmountTextBox.TabIndex = 3
        Me.PurchaseAmountTextBox.TabStop = False
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Location = New System.Drawing.Point(28, 212)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(142, 25)
        Me.AmountDueLabel.TabIndex = 4
        Me.AmountDueLabel.Text = "Amount Due: "
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.Location = New System.Drawing.Point(225, 205)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.ReadOnly = True
        Me.AmountDueTextBox.Size = New System.Drawing.Size(117, 31)
        Me.AmountDueTextBox.TabIndex = 5
        Me.AmountDueTextBox.TabStop = False
        '
        'AddMoneyButton
        '
        Me.AddMoneyButton.Location = New System.Drawing.Point(225, 282)
        Me.AddMoneyButton.Name = "AddMoneyButton"
        Me.AddMoneyButton.Size = New System.Drawing.Size(170, 58)
        Me.AddMoneyButton.TabIndex = 6
        Me.AddMoneyButton.Text = "&Add Money"
        Me.ToolTip1.SetToolTip(Me.AddMoneyButton, "Insert money into the machine")
        Me.AddMoneyButton.UseVisualStyleBackColor = True
        '
        'CompletePurchaseButton
        '
        Me.CompletePurchaseButton.Location = New System.Drawing.Point(225, 363)
        Me.CompletePurchaseButton.Name = "CompletePurchaseButton"
        Me.CompletePurchaseButton.Size = New System.Drawing.Size(170, 66)
        Me.CompletePurchaseButton.TabIndex = 7
        Me.CompletePurchaseButton.Text = "Complete &Purchase"
        Me.ToolTip1.SetToolTip(Me.CompletePurchaseButton, " Complete your purchase")
        Me.CompletePurchaseButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(225, 451)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(170, 58)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.CancelButton, "Cancel your order")
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AcceptsLabel
        '
        Me.AcceptsLabel.AutoSize = True
        Me.AcceptsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.AcceptsLabel.Location = New System.Drawing.Point(24, 291)
        Me.AcceptsLabel.Name = "AcceptsLabel"
        Me.AcceptsLabel.Size = New System.Drawing.Size(162, 20)
        Me.AcceptsLabel.TabIndex = 9
        Me.AcceptsLabel.Text = "This machine accepts"
        '
        'PaymentGroupBox
        '
        Me.PaymentGroupBox.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PaymentGroupBox.Controls.Add(Me.PictureBox1)
        Me.PaymentGroupBox.Controls.Add(Me.AcceptsLabel)
        Me.PaymentGroupBox.Controls.Add(Me.CancelButton)
        Me.PaymentGroupBox.Controls.Add(Me.CompletePurchaseButton)
        Me.PaymentGroupBox.Controls.Add(Me.AddMoneyButton)
        Me.PaymentGroupBox.Controls.Add(Me.AmountDueTextBox)
        Me.PaymentGroupBox.Controls.Add(Me.AmountDueLabel)
        Me.PaymentGroupBox.Controls.Add(Me.PurchaseAmountTextBox)
        Me.PaymentGroupBox.Controls.Add(Me.PurchaseAmountLabel)
        Me.PaymentGroupBox.Controls.Add(Me.AmtEnteredTextBox)
        Me.PaymentGroupBox.Controls.Add(Me.AmtEnteredLabel)
        Me.PaymentGroupBox.Location = New System.Drawing.Point(1428, 353)
        Me.PaymentGroupBox.Name = "PaymentGroupBox"
        Me.PaymentGroupBox.Size = New System.Drawing.Size(416, 543)
        Me.PaymentGroupBox.TabIndex = 17
        Me.PaymentGroupBox.TabStop = False
        Me.PaymentGroupBox.Text = "Payment"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Final.My.Resources.Resources.Untitled
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(33, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 167)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'HeadingLabel
        '
        Me.HeadingLabel.AutoSize = True
        Me.HeadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.HeadingLabel.Location = New System.Drawing.Point(679, 53)
        Me.HeadingLabel.Name = "HeadingLabel"
        Me.HeadingLabel.Size = New System.Drawing.Size(388, 73)
        Me.HeadingLabel.TabIndex = 18
        Me.HeadingLabel.Text = "Snack Time!"
        '
        'CokeLabel
        '
        Me.CokeLabel.AutoSize = True
        Me.CokeLabel.Location = New System.Drawing.Point(169, 292)
        Me.CokeLabel.Name = "CokeLabel"
        Me.CokeLabel.Size = New System.Drawing.Size(66, 25)
        Me.CokeLabel.TabIndex = 16
        Me.CokeLabel.Text = "$1.50"
        '
        'DietCokeLabel
        '
        Me.DietCokeLabel.AutoSize = True
        Me.DietCokeLabel.Location = New System.Drawing.Point(480, 292)
        Me.DietCokeLabel.Name = "DietCokeLabel"
        Me.DietCokeLabel.Size = New System.Drawing.Size(66, 25)
        Me.DietCokeLabel.TabIndex = 17
        Me.DietCokeLabel.Text = "$1.50"
        '
        'DrPepperLabel
        '
        Me.DrPepperLabel.AutoSize = True
        Me.DrPepperLabel.Location = New System.Drawing.Point(799, 292)
        Me.DrPepperLabel.Name = "DrPepperLabel"
        Me.DrPepperLabel.Size = New System.Drawing.Size(66, 25)
        Me.DrPepperLabel.TabIndex = 18
        Me.DrPepperLabel.Text = "$1.50"
        '
        'MtnDewLabel
        '
        Me.MtnDewLabel.AutoSize = True
        Me.MtnDewLabel.Location = New System.Drawing.Point(1080, 292)
        Me.MtnDewLabel.Name = "MtnDewLabel"
        Me.MtnDewLabel.Size = New System.Drawing.Size(66, 25)
        Me.MtnDewLabel.TabIndex = 19
        Me.MtnDewLabel.Text = "$1.50"
        '
        'SunChipsLabel
        '
        Me.SunChipsLabel.AutoSize = True
        Me.SunChipsLabel.Location = New System.Drawing.Point(169, 538)
        Me.SunChipsLabel.Name = "SunChipsLabel"
        Me.SunChipsLabel.Size = New System.Drawing.Size(66, 25)
        Me.SunChipsLabel.TabIndex = 20
        Me.SunChipsLabel.Text = "$2.00"
        '
        'NachoCheeseLabel
        '
        Me.NachoCheeseLabel.AutoSize = True
        Me.NachoCheeseLabel.Location = New System.Drawing.Point(480, 538)
        Me.NachoCheeseLabel.Name = "NachoCheeseLabel"
        Me.NachoCheeseLabel.Size = New System.Drawing.Size(66, 25)
        Me.NachoCheeseLabel.TabIndex = 21
        Me.NachoCheeseLabel.Text = "$2.00"
        '
        'CoolerRanchLabel
        '
        Me.CoolerRanchLabel.AutoSize = True
        Me.CoolerRanchLabel.Location = New System.Drawing.Point(799, 538)
        Me.CoolerRanchLabel.Name = "CoolerRanchLabel"
        Me.CoolerRanchLabel.Size = New System.Drawing.Size(66, 25)
        Me.CoolerRanchLabel.TabIndex = 22
        Me.CoolerRanchLabel.Text = "$2.00"
        '
        'PopcornLabel
        '
        Me.PopcornLabel.AutoSize = True
        Me.PopcornLabel.Location = New System.Drawing.Point(1080, 538)
        Me.PopcornLabel.Name = "PopcornLabel"
        Me.PopcornLabel.Size = New System.Drawing.Size(66, 25)
        Me.PopcornLabel.TabIndex = 23
        Me.PopcornLabel.Text = "$2.00"
        '
        'SnickersLabel
        '
        Me.SnickersLabel.AutoSize = True
        Me.SnickersLabel.Location = New System.Drawing.Point(169, 729)
        Me.SnickersLabel.Name = "SnickersLabel"
        Me.SnickersLabel.Size = New System.Drawing.Size(66, 25)
        Me.SnickersLabel.TabIndex = 24
        Me.SnickersLabel.Text = "$0.75"
        '
        'ReesesLabel
        '
        Me.ReesesLabel.AutoSize = True
        Me.ReesesLabel.Location = New System.Drawing.Point(480, 729)
        Me.ReesesLabel.Name = "ReesesLabel"
        Me.ReesesLabel.Size = New System.Drawing.Size(66, 25)
        Me.ReesesLabel.TabIndex = 25
        Me.ReesesLabel.Text = "$0.75"
        '
        'TwixLabel
        '
        Me.TwixLabel.AutoSize = True
        Me.TwixLabel.Location = New System.Drawing.Point(799, 729)
        Me.TwixLabel.Name = "TwixLabel"
        Me.TwixLabel.Size = New System.Drawing.Size(66, 25)
        Me.TwixLabel.TabIndex = 26
        Me.TwixLabel.Text = "$0.75"
        '
        'MilkyWayLabel
        '
        Me.MilkyWayLabel.AutoSize = True
        Me.MilkyWayLabel.Location = New System.Drawing.Point(1080, 729)
        Me.MilkyWayLabel.Name = "MilkyWayLabel"
        Me.MilkyWayLabel.Size = New System.Drawing.Size(66, 25)
        Me.MilkyWayLabel.TabIndex = 27
        Me.MilkyWayLabel.Text = "$0.75"
        '
        'ReactGumLabel
        '
        Me.ReactGumLabel.AutoSize = True
        Me.ReactGumLabel.Location = New System.Drawing.Point(169, 924)
        Me.ReactGumLabel.Name = "ReactGumLabel"
        Me.ReactGumLabel.Size = New System.Drawing.Size(66, 25)
        Me.ReactGumLabel.TabIndex = 28
        Me.ReactGumLabel.Text = "$0.50"
        '
        'SelectionGroupBox
        '
        Me.SelectionGroupBox.BackColor = System.Drawing.Color.RoyalBlue
        Me.SelectionGroupBox.Controls.Add(Me.AltoidsLabel)
        Me.SelectionGroupBox.Controls.Add(Me.LifeSaversLabel)
        Me.SelectionGroupBox.Controls.Add(Me.OrbitGumLabel)
        Me.SelectionGroupBox.Controls.Add(Me.ReactGumLabel)
        Me.SelectionGroupBox.Controls.Add(Me.MilkyWayLabel)
        Me.SelectionGroupBox.Controls.Add(Me.TwixLabel)
        Me.SelectionGroupBox.Controls.Add(Me.ReesesLabel)
        Me.SelectionGroupBox.Controls.Add(Me.SnickersLabel)
        Me.SelectionGroupBox.Controls.Add(Me.PopcornLabel)
        Me.SelectionGroupBox.Controls.Add(Me.CoolerRanchLabel)
        Me.SelectionGroupBox.Controls.Add(Me.NachoCheeseLabel)
        Me.SelectionGroupBox.Controls.Add(Me.SunChipsLabel)
        Me.SelectionGroupBox.Controls.Add(Me.MtnDewLabel)
        Me.SelectionGroupBox.Controls.Add(Me.DrPepperLabel)
        Me.SelectionGroupBox.Controls.Add(Me.DietCokeLabel)
        Me.SelectionGroupBox.Controls.Add(Me.CokeLabel)
        Me.SelectionGroupBox.Controls.Add(Me.DietCokebutton)
        Me.SelectionGroupBox.Controls.Add(Me.AltoidsButton)
        Me.SelectionGroupBox.Controls.Add(Me.CokeButton)
        Me.SelectionGroupBox.Controls.Add(Me.LifeSaversButton)
        Me.SelectionGroupBox.Controls.Add(Me.DrPepperButton)
        Me.SelectionGroupBox.Controls.Add(Me.OrbitGumButton)
        Me.SelectionGroupBox.Controls.Add(Me.MtnDewbutton)
        Me.SelectionGroupBox.Controls.Add(Me.ReactGumButton)
        Me.SelectionGroupBox.Controls.Add(Me.SunChipsButton)
        Me.SelectionGroupBox.Controls.Add(Me.MilkyWayButton)
        Me.SelectionGroupBox.Controls.Add(Me.NachoCheeseButton)
        Me.SelectionGroupBox.Controls.Add(Me.TwixButton)
        Me.SelectionGroupBox.Controls.Add(Me.CoolerRanchButton)
        Me.SelectionGroupBox.Controls.Add(Me.ReesesButton)
        Me.SelectionGroupBox.Controls.Add(Me.PopcornButton)
        Me.SelectionGroupBox.Controls.Add(Me.SnickersButton)
        Me.SelectionGroupBox.Location = New System.Drawing.Point(81, 129)
        Me.SelectionGroupBox.Name = "SelectionGroupBox"
        Me.SelectionGroupBox.Size = New System.Drawing.Size(1298, 975)
        Me.SelectionGroupBox.TabIndex = 16
        Me.SelectionGroupBox.TabStop = False
        Me.SelectionGroupBox.Text = "Selections"
        '
        'AltoidsLabel
        '
        Me.AltoidsLabel.AutoSize = True
        Me.AltoidsLabel.Location = New System.Drawing.Point(1080, 924)
        Me.AltoidsLabel.Name = "AltoidsLabel"
        Me.AltoidsLabel.Size = New System.Drawing.Size(66, 25)
        Me.AltoidsLabel.TabIndex = 31
        Me.AltoidsLabel.Text = "$0.50"
        '
        'LifeSaversLabel
        '
        Me.LifeSaversLabel.AutoSize = True
        Me.LifeSaversLabel.Location = New System.Drawing.Point(799, 924)
        Me.LifeSaversLabel.Name = "LifeSaversLabel"
        Me.LifeSaversLabel.Size = New System.Drawing.Size(66, 25)
        Me.LifeSaversLabel.TabIndex = 30
        Me.LifeSaversLabel.Text = "$0.50"
        '
        'OrbitGumLabel
        '
        Me.OrbitGumLabel.AutoSize = True
        Me.OrbitGumLabel.Location = New System.Drawing.Point(480, 924)
        Me.OrbitGumLabel.Name = "OrbitGumLabel"
        Me.OrbitGumLabel.Size = New System.Drawing.Size(66, 25)
        Me.OrbitGumLabel.TabIndex = 29
        Me.OrbitGumLabel.Text = "$0.50"
        '
        'DietCokebutton
        '
        Me.DietCokebutton.BackgroundImage = Global.Final.My.Resources.Resources.DietCoke_20oz
        Me.DietCokebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DietCokebutton.Location = New System.Drawing.Point(451, 43)
        Me.DietCokebutton.Name = "DietCokebutton"
        Me.DietCokebutton.Size = New System.Drawing.Size(129, 234)
        Me.DietCokebutton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DietCokebutton, "Add a Diet Coke to the order")
        Me.DietCokebutton.UseVisualStyleBackColor = True
        '
        'AltoidsButton
        '
        Me.AltoidsButton.BackgroundImage = Global.Final.My.Resources.Resources.download__8_
        Me.AltoidsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AltoidsButton.Location = New System.Drawing.Point(1015, 794)
        Me.AltoidsButton.Name = "AltoidsButton"
        Me.AltoidsButton.Size = New System.Drawing.Size(210, 117)
        Me.AltoidsButton.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.AltoidsButton, "Add Altoids to the order")
        Me.AltoidsButton.UseVisualStyleBackColor = True
        '
        'CokeButton
        '
        Me.CokeButton.BackgroundImage = Global.Final.My.Resources.Resources.PDP_Coca_Cola_HFCS_2L
        Me.CokeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CokeButton.Location = New System.Drawing.Point(140, 43)
        Me.CokeButton.Name = "CokeButton"
        Me.CokeButton.Size = New System.Drawing.Size(129, 234)
        Me.CokeButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CokeButton, "Add a Coke to the order")
        Me.CokeButton.UseVisualStyleBackColor = True
        '
        'LifeSaversButton
        '
        Me.LifeSaversButton.BackgroundImage = Global.Final.My.Resources.Resources.download__7_
        Me.LifeSaversButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LifeSaversButton.Location = New System.Drawing.Point(722, 794)
        Me.LifeSaversButton.Name = "LifeSaversButton"
        Me.LifeSaversButton.Size = New System.Drawing.Size(210, 117)
        Me.LifeSaversButton.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.LifeSaversButton, "Add LifeSavers to the order")
        Me.LifeSaversButton.UseVisualStyleBackColor = True
        '
        'DrPepperButton
        '
        Me.DrPepperButton.BackgroundImage = Global.Final.My.Resources.Resources.DR_PEPPER_20
        Me.DrPepperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DrPepperButton.Location = New System.Drawing.Point(763, 43)
        Me.DrPepperButton.Name = "DrPepperButton"
        Me.DrPepperButton.Size = New System.Drawing.Size(129, 234)
        Me.DrPepperButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DrPepperButton, "Add a Dr. Pepper to the order")
        Me.DrPepperButton.UseVisualStyleBackColor = True
        '
        'OrbitGumButton
        '
        Me.OrbitGumButton.BackgroundImage = Global.Final.My.Resources.Resources.download__6_
        Me.OrbitGumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OrbitGumButton.Location = New System.Drawing.Point(418, 794)
        Me.OrbitGumButton.Name = "OrbitGumButton"
        Me.OrbitGumButton.Size = New System.Drawing.Size(210, 117)
        Me.OrbitGumButton.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.OrbitGumButton, "Add Orbit Gum to the order")
        Me.OrbitGumButton.UseVisualStyleBackColor = True
        '
        'MtnDewbutton
        '
        Me.MtnDewbutton.BackgroundImage = Global.Final.My.Resources.Resources.download
        Me.MtnDewbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MtnDewbutton.Location = New System.Drawing.Point(1051, 43)
        Me.MtnDewbutton.Name = "MtnDewbutton"
        Me.MtnDewbutton.Size = New System.Drawing.Size(129, 234)
        Me.MtnDewbutton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.MtnDewbutton, "Add a Mountain Dew to the order")
        Me.MtnDewbutton.UseVisualStyleBackColor = True
        '
        'ReactGumButton
        '
        Me.ReactGumButton.BackgroundImage = Global.Final.My.Resources.Resources.images
        Me.ReactGumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReactGumButton.Location = New System.Drawing.Point(102, 794)
        Me.ReactGumButton.Name = "ReactGumButton"
        Me.ReactGumButton.Size = New System.Drawing.Size(210, 117)
        Me.ReactGumButton.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.ReactGumButton, "Add React 5 Gum to the order")
        Me.ReactGumButton.UseVisualStyleBackColor = True
        '
        'SunChipsButton
        '
        Me.SunChipsButton.BackgroundImage = Global.Final.My.Resources.Resources.SunChipsOriginal2
        Me.SunChipsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SunChipsButton.Location = New System.Drawing.Point(133, 363)
        Me.SunChipsButton.Name = "SunChipsButton"
        Me.SunChipsButton.Size = New System.Drawing.Size(152, 158)
        Me.SunChipsButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.SunChipsButton, "Add Sun Chips to the order")
        Me.SunChipsButton.UseVisualStyleBackColor = True
        '
        'MilkyWayButton
        '
        Me.MilkyWayButton.BackgroundImage = Global.Final.My.Resources.Resources.download__5_
        Me.MilkyWayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MilkyWayButton.Location = New System.Drawing.Point(1015, 594)
        Me.MilkyWayButton.Name = "MilkyWayButton"
        Me.MilkyWayButton.Size = New System.Drawing.Size(210, 117)
        Me.MilkyWayButton.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.MilkyWayButton, "Add a Milky Way to the order")
        Me.MilkyWayButton.UseVisualStyleBackColor = True
        '
        'NachoCheeseButton
        '
        Me.NachoCheeseButton.BackgroundImage = Global.Final.My.Resources.Resources.download__1_
        Me.NachoCheeseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NachoCheeseButton.Location = New System.Drawing.Point(436, 360)
        Me.NachoCheeseButton.Name = "NachoCheeseButton"
        Me.NachoCheeseButton.Size = New System.Drawing.Size(155, 161)
        Me.NachoCheeseButton.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.NachoCheeseButton, "Add Nacho Cheese Doritos to the order")
        Me.NachoCheeseButton.UseVisualStyleBackColor = True
        '
        'TwixButton
        '
        Me.TwixButton.BackgroundImage = Global.Final.My.Resources.Resources.download__4_
        Me.TwixButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TwixButton.Location = New System.Drawing.Point(722, 594)
        Me.TwixButton.Name = "TwixButton"
        Me.TwixButton.Size = New System.Drawing.Size(210, 117)
        Me.TwixButton.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.TwixButton, "Add a Twix to the order")
        Me.TwixButton.UseVisualStyleBackColor = True
        '
        'CoolerRanchButton
        '
        Me.CoolerRanchButton.BackgroundImage = Global.Final.My.Resources.Resources.doritos_cool_ranch
        Me.CoolerRanchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CoolerRanchButton.Location = New System.Drawing.Point(752, 363)
        Me.CoolerRanchButton.Name = "CoolerRanchButton"
        Me.CoolerRanchButton.Size = New System.Drawing.Size(153, 158)
        Me.CoolerRanchButton.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.CoolerRanchButton, "Add Cooler Ranch Doritos to the order")
        Me.CoolerRanchButton.UseVisualStyleBackColor = True
        '
        'ReesesButton
        '
        Me.ReesesButton.BackgroundImage = Global.Final.My.Resources.Resources.Reese_s_PB_Cups_Wrapper_Small
        Me.ReesesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReesesButton.Location = New System.Drawing.Point(418, 594)
        Me.ReesesButton.Name = "ReesesButton"
        Me.ReesesButton.Size = New System.Drawing.Size(210, 117)
        Me.ReesesButton.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ReesesButton, "Add a Reeses to the order")
        Me.ReesesButton.UseVisualStyleBackColor = True
        '
        'PopcornButton
        '
        Me.PopcornButton.BackgroundImage = Global.Final.My.Resources.Resources.download__2_
        Me.PopcornButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PopcornButton.Location = New System.Drawing.Point(1042, 360)
        Me.PopcornButton.Name = "PopcornButton"
        Me.PopcornButton.Size = New System.Drawing.Size(154, 158)
        Me.PopcornButton.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.PopcornButton, "Add Popcorn to the order")
        Me.PopcornButton.UseVisualStyleBackColor = True
        '
        'SnickersButton
        '
        Me.SnickersButton.BackgroundImage = Global.Final.My.Resources.Resources.download__3_
        Me.SnickersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SnickersButton.Location = New System.Drawing.Point(102, 594)
        Me.SnickersButton.Name = "SnickersButton"
        Me.SnickersButton.Size = New System.Drawing.Size(210, 117)
        Me.SnickersButton.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.SnickersButton, "Add a Snickers to the order")
        Me.SnickersButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1899, 40)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ManagerLogInToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(255, 6)
        '
        'ManagerLogInToolStripMenuItem
        '
        Me.ManagerLogInToolStripMenuItem.Name = "ManagerLogInToolStripMenuItem"
        Me.ManagerLogInToolStripMenuItem.Size = New System.Drawing.Size(258, 36)
        Me.ManagerLogInToolStripMenuItem.Text = "Manager Log In"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(258, 36)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMoneyToolStripMenuItem, Me.CompletePurchaseToolStripMenuItem, Me.CancelToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(67, 36)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddMoneyToolStripMenuItem
        '
        Me.AddMoneyToolStripMenuItem.Name = "AddMoneyToolStripMenuItem"
        Me.AddMoneyToolStripMenuItem.Size = New System.Drawing.Size(296, 36)
        Me.AddMoneyToolStripMenuItem.Text = "Add Money"
        '
        'CompletePurchaseToolStripMenuItem
        '
        Me.CompletePurchaseToolStripMenuItem.Name = "CompletePurchaseToolStripMenuItem"
        Me.CompletePurchaseToolStripMenuItem.Size = New System.Drawing.Size(296, 36)
        Me.CompletePurchaseToolStripMenuItem.Text = "Complete Purchase"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(296, 36)
        Me.CancelToolStripMenuItem.Text = "Cancel Order"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(155, 36)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VendingForm
        '
        Me.AcceptButton = Me.CompletePurchaseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1899, 1124)
        Me.Controls.Add(Me.HeadingLabel)
        Me.Controls.Add(Me.PaymentGroupBox)
        Me.Controls.Add(Me.SelectionGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VendingForm"
        Me.Text = "Pauga Vending LLC"
        Me.PaymentGroupBox.ResumeLayout(False)
        Me.PaymentGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectionGroupBox.ResumeLayout(False)
        Me.SelectionGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AmtEnteredLabel As System.Windows.Forms.Label
    Friend WithEvents AmtEnteredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurchaseAmountLabel As System.Windows.Forms.Label
    Friend WithEvents PurchaseAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountDueLabel As System.Windows.Forms.Label
    Friend WithEvents AmountDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddMoneyButton As System.Windows.Forms.Button
    Friend WithEvents CompletePurchaseButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents AcceptsLabel As System.Windows.Forms.Label
    Friend WithEvents PaymentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HeadingLabel As System.Windows.Forms.Label
    Friend WithEvents SnickersButton As System.Windows.Forms.Button
    Friend WithEvents PopcornButton As System.Windows.Forms.Button
    Friend WithEvents ReesesButton As System.Windows.Forms.Button
    Friend WithEvents CoolerRanchButton As System.Windows.Forms.Button
    Friend WithEvents TwixButton As System.Windows.Forms.Button
    Friend WithEvents NachoCheeseButton As System.Windows.Forms.Button
    Friend WithEvents MilkyWayButton As System.Windows.Forms.Button
    Friend WithEvents SunChipsButton As System.Windows.Forms.Button
    Friend WithEvents ReactGumButton As System.Windows.Forms.Button
    Friend WithEvents MtnDewbutton As System.Windows.Forms.Button
    Friend WithEvents OrbitGumButton As System.Windows.Forms.Button
    Friend WithEvents DrPepperButton As System.Windows.Forms.Button
    Friend WithEvents LifeSaversButton As System.Windows.Forms.Button
    Friend WithEvents CokeButton As System.Windows.Forms.Button
    Friend WithEvents AltoidsButton As System.Windows.Forms.Button
    Friend WithEvents DietCokebutton As System.Windows.Forms.Button
    Friend WithEvents CokeLabel As System.Windows.Forms.Label
    Friend WithEvents DietCokeLabel As System.Windows.Forms.Label
    Friend WithEvents DrPepperLabel As System.Windows.Forms.Label
    Friend WithEvents MtnDewLabel As System.Windows.Forms.Label
    Friend WithEvents SunChipsLabel As System.Windows.Forms.Label
    Friend WithEvents NachoCheeseLabel As System.Windows.Forms.Label
    Friend WithEvents CoolerRanchLabel As System.Windows.Forms.Label
    Friend WithEvents PopcornLabel As System.Windows.Forms.Label
    Friend WithEvents SnickersLabel As System.Windows.Forms.Label
    Friend WithEvents ReesesLabel As System.Windows.Forms.Label
    Friend WithEvents TwixLabel As System.Windows.Forms.Label
    Friend WithEvents MilkyWayLabel As System.Windows.Forms.Label
    Friend WithEvents ReactGumLabel As System.Windows.Forms.Label
    Friend WithEvents SelectionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AltoidsLabel As System.Windows.Forms.Label
    Friend WithEvents LifeSaversLabel As System.Windows.Forms.Label
    Friend WithEvents OrbitGumLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagerLogInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMoneyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompletePurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
