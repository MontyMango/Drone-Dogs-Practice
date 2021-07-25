Public Class DroneDogsOrder

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare constants
        Const dbl_Sales_Tax_Rate As Double = 0.07
        Const dbl_Hot_Dog_Price As Double = 1.99

        'Declare variables 
        Dim intNumBeefDogs As Integer
        Dim intNumPorkDogs As Integer
        Dim intNumTurkeyDogs As Integer
        Dim intNumHotDogs As Integer

        Dim dblSubTotal As Double
        Dim dblSalesTax As Double
        Dim dblTotalCost As Double

        'Extract user typed quantities from text boxes and convert to integers
        intNumBeefDogs = Convert.ToInt32(txtBeefDogs.Text)
        intNumPorkDogs = Convert.ToInt32(txtPorkDogs.Text)
        intNumTurkeyDogs = Convert.ToInt32(txtTurkeyDogs.Text)

        'Calculate total number of hot dogs ordered
        intNumHotDogs = intNumBeefDogs + intNumPorkDogs + intNumTurkeyDogs

        'Calculate subtotal, sales tax, and total amounts
        dblSubTotal = intNumHotDogs * dbl_Hot_Dog_Price
        dblSalesTax = dblSubTotal * dbl_Sales_Tax_Rate
        dblTotalCost = dblSubTotal + dblSalesTax

        'Convert numbers back to text and display in text boxes
        txtSubtotal.Text = dblSubTotal.ToString("c2")
        txtSalesTax.Text = dblSalesTax.ToString("c2")
        txtTotalCost.Text = dblTotalCost.ToString("c2")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close form
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Checks if all the text is filled in and the button is checked
        'If the checkbox isn't checked
        If chkboxLocationInfoAgreement.Checked = False Then
            MessageBox.Show("Error! You must check the location permission check box," & vbCrLf &
                            "So we can track you. 0_0")
            'If the total cost is nothing
        ElseIf txtTotalCost.Text = "" Then
            MessageBox.Show("Error! You must order at least one item," & vbCrLf &
                            "we don't like to give nothing away for free.")
        ElseIf txtEmailInput.Text = "" Then
            MessageBox.Show("Error! Please use the customer form button to get your customer info." & vbCrLf &
                            "We would like to know who you are. >:)")
        Else
            MessageBox.Show("Thank you for ordering from DroneDogs!" & vbCrLf &
                            "We will be at your location shortly... See you soon...")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clears form
        txtBeefDogs.Text = ""
        txtPorkDogs.Text = ""
        txtTurkeyDogs.Text = ""
        txtSubtotal.Text = ""
        txtSalesTax.Text = ""
        txtTotalCost.Text = ""
        txtFirstNameInput.Text = ""
        txtLastNameInput.Text = ""
        txtEmailInput.Text = ""

    End Sub

    Private Sub btnGetCustomerInfo_Click(sender As Object, e As EventArgs) Handles btnGetCustomerInfo.Click
        CustomerForm.Show()
    End Sub
End Class
