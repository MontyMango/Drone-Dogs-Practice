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

        'Extract user typed quantities from text boxes and convert to integers

        'Calculate total number of hot dogs ordered

        'Calculate subtotal, sales tax, and total amounts

        'Convert numbers back to text and display in text boxes


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close form

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Display message box thanking the user

    End Sub

End Class
