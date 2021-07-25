Public Class CustomerForm
    'Form level member
    Private objCustomers As New ArrayList
    Private Sub btnAddNewCustomers_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomers.Click
        'Checks input boxes
        If txtFirstNameInput.Text = "" Then
            MessageBox.Show("Please put a first name.")
        ElseIf txtLastNameInput.Text = "" Then
            MessageBox.Show("Please put a last name.")
        ElseIf txtEmailInput.Text = "" Then
            MessageBox.Show("Please put in an email address")
        Else
            Dim strFirstName = txtFirstNameInput.Text
            Dim strLastName = txtLastNameInput.Text
            Dim strEmail = txtEmailInput.Text
            CreateCustomer(strFirstName, strLastName, strEmail)
        End If
    End Sub
    Public Sub CreateCustomer(firstName As String, lastName As String, email As String)
        'Declare a customer object
        Dim objNewCustomer As Customers.Customer

        'Create the new customer
        objNewCustomer.FirstName = firstName
        objNewCustomer.LastName = lastName
        objNewCustomer.Email = email

        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)

        'Add the new customer to the ListBox control
        lstCustomers.Items.Add(objNewCustomer)
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Preloading Customers
        CreateCustomer("Fred", "Garvin", "fgarvin@thiscompanysnl.com")
        CreateCustomer("Fran", "Pepper", "fpepper@notthesoftdrink.org")
        CreateCustomer("Will", "Robinson", "wrobinson@lostinspacetown.gov")
    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        'Get customer info and display it in the order form
        Dim objCustomerSelected As Customers.Customer = SelectedCustomer
        DroneDogsOrder.txtFirstNameInput.Text = objCustomerSelected.FirstName
        DroneDogsOrder.txtLastNameInput.Text = objCustomerSelected.LastName
        DroneDogsOrder.txtEmailInput.Text = objCustomerSelected.Email
    End Sub

    Public ReadOnly Property SelectedCustomer() As Customers.Customer
        Get
            If lstCustomers.SelectedIndex <> -1 Then
                'Return this customer
                Return CType(objCustomers(lstCustomers.SelectedIndex), Customers.Customer)
            End If
        End Get
    End Property
End Class