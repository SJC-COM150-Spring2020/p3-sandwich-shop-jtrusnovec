<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheEggSandwichShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheEggSandwichShop))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.grpDrink = New System.Windows.Forms.GroupBox()
        Me.chkJuice = New System.Windows.Forms.CheckBox()
        Me.chkMilk = New System.Windows.Forms.CheckBox()
        Me.chkHotChoc = New System.Windows.Forms.CheckBox()
        Me.chkTea = New System.Windows.Forms.CheckBox()
        Me.chkCoffee = New System.Windows.Forms.CheckBox()
        Me.grpEgg = New System.Windows.Forms.GroupBox()
        Me.radPoached = New System.Windows.Forms.RadioButton()
        Me.radSunny = New System.Windows.Forms.RadioButton()
        Me.radOverEasy = New System.Windows.Forms.RadioButton()
        Me.radScrambled = New System.Windows.Forms.RadioButton()
        Me.grpExtra = New System.Windows.Forms.GroupBox()
        Me.chkVeggies = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.picEgg = New System.Windows.Forms.PictureBox()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDrink.SuspendLayout()
        Me.grpEgg.SuspendLayout()
        Me.grpExtra.SuspendLayout()
        CType(Me.picEgg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Ink Free", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(153, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(366, 39)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "The Egg Sandwich Shop"
        '
        'grpDrink
        '
        Me.grpDrink.Controls.Add(Me.chkJuice)
        Me.grpDrink.Controls.Add(Me.chkMilk)
        Me.grpDrink.Controls.Add(Me.chkHotChoc)
        Me.grpDrink.Controls.Add(Me.chkTea)
        Me.grpDrink.Controls.Add(Me.chkCoffee)
        Me.grpDrink.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDrink.Location = New System.Drawing.Point(32, 110)
        Me.grpDrink.Name = "grpDrink"
        Me.grpDrink.Size = New System.Drawing.Size(166, 141)
        Me.grpDrink.TabIndex = 1
        Me.grpDrink.TabStop = False
        Me.grpDrink.Text = "Drinks - $2.25 Each"
        '
        'chkJuice
        '
        Me.chkJuice.AutoSize = True
        Me.chkJuice.Location = New System.Drawing.Point(6, 43)
        Me.chkJuice.Name = "chkJuice"
        Me.chkJuice.Size = New System.Drawing.Size(60, 20)
        Me.chkJuice.TabIndex = 4
        Me.chkJuice.Text = "Juice"
        Me.chkJuice.UseVisualStyleBackColor = True
        '
        'chkMilk
        '
        Me.chkMilk.AutoSize = True
        Me.chkMilk.Location = New System.Drawing.Point(6, 92)
        Me.chkMilk.Name = "chkMilk"
        Me.chkMilk.Size = New System.Drawing.Size(54, 20)
        Me.chkMilk.TabIndex = 3
        Me.chkMilk.Text = "Milk"
        Me.chkMilk.UseVisualStyleBackColor = True
        '
        'chkHotChoc
        '
        Me.chkHotChoc.AutoSize = True
        Me.chkHotChoc.Location = New System.Drawing.Point(6, 116)
        Me.chkHotChoc.Name = "chkHotChoc"
        Me.chkHotChoc.Size = New System.Drawing.Size(118, 20)
        Me.chkHotChoc.TabIndex = 2
        Me.chkHotChoc.Text = "Hot Chocolate"
        Me.chkHotChoc.UseVisualStyleBackColor = True
        '
        'chkTea
        '
        Me.chkTea.AutoSize = True
        Me.chkTea.Location = New System.Drawing.Point(6, 68)
        Me.chkTea.Name = "chkTea"
        Me.chkTea.Size = New System.Drawing.Size(52, 20)
        Me.chkTea.TabIndex = 1
        Me.chkTea.Text = "Tea"
        Me.chkTea.UseVisualStyleBackColor = True
        '
        'chkCoffee
        '
        Me.chkCoffee.AutoSize = True
        Me.chkCoffee.Location = New System.Drawing.Point(6, 19)
        Me.chkCoffee.Name = "chkCoffee"
        Me.chkCoffee.Size = New System.Drawing.Size(68, 20)
        Me.chkCoffee.TabIndex = 0
        Me.chkCoffee.Text = "Coffee"
        Me.chkCoffee.UseVisualStyleBackColor = True
        '
        'grpEgg
        '
        Me.grpEgg.Controls.Add(Me.radPoached)
        Me.grpEgg.Controls.Add(Me.radSunny)
        Me.grpEgg.Controls.Add(Me.radOverEasy)
        Me.grpEgg.Controls.Add(Me.radScrambled)
        Me.grpEgg.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEgg.Location = New System.Drawing.Point(249, 110)
        Me.grpEgg.Name = "grpEgg"
        Me.grpEgg.Size = New System.Drawing.Size(166, 141)
        Me.grpEgg.TabIndex = 2
        Me.grpEgg.TabStop = False
        Me.grpEgg.Text = "Eggs - $6.95"
        '
        'radPoached
        '
        Me.radPoached.AutoSize = True
        Me.radPoached.Location = New System.Drawing.Point(7, 115)
        Me.radPoached.Name = "radPoached"
        Me.radPoached.Size = New System.Drawing.Size(77, 20)
        Me.radPoached.TabIndex = 3
        Me.radPoached.TabStop = True
        Me.radPoached.Text = "Poached"
        Me.radPoached.UseVisualStyleBackColor = True
        '
        'radSunny
        '
        Me.radSunny.AutoSize = True
        Me.radSunny.Location = New System.Drawing.Point(7, 84)
        Me.radSunny.Name = "radSunny"
        Me.radSunny.Size = New System.Drawing.Size(115, 20)
        Me.radSunny.TabIndex = 2
        Me.radSunny.TabStop = True
        Me.radSunny.Text = "Sunny Side Up"
        Me.radSunny.UseVisualStyleBackColor = True
        '
        'radOverEasy
        '
        Me.radOverEasy.AutoSize = True
        Me.radOverEasy.Location = New System.Drawing.Point(7, 52)
        Me.radOverEasy.Name = "radOverEasy"
        Me.radOverEasy.Size = New System.Drawing.Size(93, 20)
        Me.radOverEasy.TabIndex = 1
        Me.radOverEasy.TabStop = True
        Me.radOverEasy.Text = "Over Easy"
        Me.radOverEasy.UseVisualStyleBackColor = True
        '
        'radScrambled
        '
        Me.radScrambled.AutoSize = True
        Me.radScrambled.Location = New System.Drawing.Point(7, 23)
        Me.radScrambled.Name = "radScrambled"
        Me.radScrambled.Size = New System.Drawing.Size(91, 20)
        Me.radScrambled.TabIndex = 0
        Me.radScrambled.TabStop = True
        Me.radScrambled.Text = "Scrambled"
        Me.radScrambled.UseVisualStyleBackColor = True
        '
        'grpExtra
        '
        Me.grpExtra.Controls.Add(Me.chkVeggies)
        Me.grpExtra.Controls.Add(Me.chkHam)
        Me.grpExtra.Controls.Add(Me.chkSausage)
        Me.grpExtra.Controls.Add(Me.chkBacon)
        Me.grpExtra.Controls.Add(Me.chkCheese)
        Me.grpExtra.Font = New System.Drawing.Font("Ink Free", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExtra.Location = New System.Drawing.Point(467, 110)
        Me.grpExtra.Name = "grpExtra"
        Me.grpExtra.Size = New System.Drawing.Size(166, 141)
        Me.grpExtra.TabIndex = 3
        Me.grpExtra.TabStop = False
        Me.grpExtra.Text = "Extras - $1.50 Each"
        '
        'chkVeggies
        '
        Me.chkVeggies.AutoSize = True
        Me.chkVeggies.Location = New System.Drawing.Point(7, 118)
        Me.chkVeggies.Name = "chkVeggies"
        Me.chkVeggies.Size = New System.Drawing.Size(98, 20)
        Me.chkVeggies.TabIndex = 4
        Me.chkVeggies.Text = "Vegetables"
        Me.chkVeggies.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(7, 92)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(56, 20)
        Me.chkHam.TabIndex = 3
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(7, 68)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(80, 20)
        Me.chkSausage.TabIndex = 2
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(7, 44)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(65, 20)
        Me.chkBacon.TabIndex = 1
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(7, 20)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(71, 20)
        Me.chkCheese.TabIndex = 0
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'lstOut
        '
        Me.lstOut.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 20
        Me.lstOut.Location = New System.Drawing.Point(415, 293)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(218, 264)
        Me.lstOut.TabIndex = 4
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Ink Free", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.ForeColor = System.Drawing.Color.White
        Me.lblOrder.Location = New System.Drawing.Point(27, 81)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(245, 26)
        Me.lblOrder.TabIndex = 5
        Me.lblOrder.Text = "Place Your Order Below:"
        '
        'picEgg
        '
        Me.picEgg.Image = CType(resources.GetObject("picEgg.Image"), System.Drawing.Image)
        Me.picEgg.Location = New System.Drawing.Point(14, 300)
        Me.picEgg.Name = "picEgg"
        Me.picEgg.Size = New System.Drawing.Size(356, 216)
        Me.picEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEgg.TabIndex = 6
        Me.picEgg.TabStop = False
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.ForeColor = System.Drawing.Color.White
        Me.lblReceipt.Location = New System.Drawing.Point(460, 270)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(105, 20)
        Me.lblReceipt.TabIndex = 7
        Me.lblReceipt.Text = "Your Receipt"
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Ink Free", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(32, 266)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(102, 28)
        Me.btnOrder.TabIndex = 8
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(32, 537)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 28)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(160, 537)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 28)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TheEggSandwichShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(664, 574)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblReceipt)
        Me.Controls.Add(Me.picEgg)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.grpExtra)
        Me.Controls.Add(Me.grpEgg)
        Me.Controls.Add(Me.grpDrink)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "TheEggSandwichShop"
        Me.Text = "The Egg Sandwich Shop"
        Me.grpDrink.ResumeLayout(False)
        Me.grpDrink.PerformLayout()
        Me.grpEgg.ResumeLayout(False)
        Me.grpEgg.PerformLayout()
        Me.grpExtra.ResumeLayout(False)
        Me.grpExtra.PerformLayout()
        CType(Me.picEgg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents grpDrink As GroupBox
    Friend WithEvents chkJuice As CheckBox
    Friend WithEvents chkMilk As CheckBox
    Friend WithEvents chkHotChoc As CheckBox
    Friend WithEvents chkTea As CheckBox
    Friend WithEvents chkCoffee As CheckBox
    Friend WithEvents grpEgg As GroupBox
    Friend WithEvents radPoached As RadioButton
    Friend WithEvents radSunny As RadioButton
    Friend WithEvents radOverEasy As RadioButton
    Friend WithEvents radScrambled As RadioButton
    Friend WithEvents grpExtra As GroupBox
    Friend WithEvents chkVeggies As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents lstOut As ListBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents picEgg As PictureBox
    Friend WithEvents lblReceipt As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
