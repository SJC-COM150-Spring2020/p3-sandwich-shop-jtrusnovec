Public Class TheEggSandwichShop
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all checkbox and radio button selections, and listbox value
        lstOut.Items.Clear()
        chkBacon.Checked = False
        chkCheese.Checked = False
        chkCoffee.Checked = False
        chkHam.Checked = False
        chkHotChoc.Checked = False
        chkJuice.Checked = False
        chkMilk.Checked = False
        chkSausage.Checked = False
        chkTea.Checked = False
        chkVeggies.Checked = False
        radScrambled.Checked = False
        radSunny.Checked = False
        radOverEasy.Checked = False
        radPoached.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'exit the program
        Application.Exit()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        'show a message box to the user
        MessageBox.Show("Thank You For Your Order!")

        'declare variables
        Dim price As Double
        price = 0
        Const TAX As Double = 0.08645
        Dim finaltotal As Double
        Dim salestax As Double

        'add heading to the user's receipt
        lstOut.Items.Add("The Egg Sandwich Shop")
        lstOut.Items.Add("")

        'add drink category to list box
        lstOut.Items.Add("Drinks:")

        'check offs for drink category to be displayed
        If (chkCoffee.Checked = True) Then
            lstOut.Items.Add("Coffee - $2.25")
            price = price + 2.25
        End If

        If (chkJuice.Checked = True) Then
            lstOut.Items.Add("Juice - $2.25")
            price = price + 2.25
        End If

        If (chkTea.Checked = True) Then
            lstOut.Items.Add("Tea - $2.25")
            price = price + 2.25
        End If

        If (chkMilk.Checked = True) Then
            lstOut.Items.Add("Milk - $2.25")
            price = price + 2.25
        End If

        If (chkHotChoc.Checked = True) Then
            lstOut.Items.Add("Hot Chocolate - $2.25")
            price = price + 2.25
        End If

        lstOut.Items.Add("")

        'add egg style category to list box
        lstOut.Items.Add("Egg Style:")

        'displays user's selection of egg style
        If (radScrambled.Checked = True) Then
            lstOut.Items.Add("Scrambled - $6.95")
            price = price + 6.95
        ElseIf (radOverEasy.Checked = True) Then
            lstOut.Items.Add("Over Easy - $6.95")
            price = price + 6.95
        ElseIf (radSunny.Checked = True) Then
            lstOut.Items.Add("Sunny Side Up - $6.95")
            price = price + 6.95
        ElseIf (radPoached.Checked = True) Then
            lstOut.Items.Add("Poached - $6.95")
            price = price + 6.95
        End If

        lstOut.Items.Add("")

        'add extra category to listbox
        lstOut.Items.Add("Extras:")

        'displays user's selection of extras
        If (chkCheese.Checked = True) Then
            lstOut.Items.Add("Cheese - $1.50")
            price = price + 1.5
        End If
        If (chkBacon.Checked = True) Then
            lstOut.Items.Add("Bacon - $1.50")
            price = price + 1.5
        End If
        If (chkSausage.Checked = True) Then
            lstOut.Items.Add("Sausage - $1.50")
            price = price + 1.5
        End If
        If (chkHam.Checked = True) Then
            lstOut.Items.Add("Ham - $1.50")
            price = price + 1.5
        End If
        If (chkVeggies.Checked = True) Then
            lstOut.Items.Add("Vegetables - $1.50")
            price = price + 1.5
        End If

        lstOut.Items.Add("")

        'display subtotal to the user
        lstOut.Items.Add("Subtotal - " & FormatCurrency(price, 2))

        'calculate the tax value
        salestax = (price * TAX)

        'display tax value to the user
        lstOut.Items.Add("Tax - " & FormatCurrency(salestax, 2))
        lstOut.Items.Add("")

        'calculate the final total with new york sales tax
        finaltotal = ((price * TAX) + price)

        'display the final total to the user
        lstOut.Items.Add("Total - " & FormatCurrency(finaltotal, 2))

    End Sub
End Class
