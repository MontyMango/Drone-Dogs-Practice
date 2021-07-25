<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picboxDroneDogs = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.btnAddNewCustomers = New System.Windows.Forms.Button()
        Me.btnSelectCustomer = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmailInput = New System.Windows.Forms.TextBox()
        Me.txtLastNameInput = New System.Windows.Forms.TextBox()
        Me.txtFirstNameInput = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        CType(Me.picboxDroneDogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxDroneDogs
        '
        Me.picboxDroneDogs.Image = Global.DroneDogs.My.Resources.Resources.DroneDogs
        Me.picboxDroneDogs.Location = New System.Drawing.Point(516, 61)
        Me.picboxDroneDogs.Name = "picboxDroneDogs"
        Me.picboxDroneDogs.Size = New System.Drawing.Size(143, 173)
        Me.picboxDroneDogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxDroneDogs.TabIndex = 0
        Me.picboxDroneDogs.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(113, 28)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(274, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "DroneDogs Customer Form"
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 16
        Me.lstCustomers.Location = New System.Drawing.Point(66, 70)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(379, 164)
        Me.lstCustomers.TabIndex = 2
        '
        'btnAddNewCustomers
        '
        Me.btnAddNewCustomers.Location = New System.Drawing.Point(66, 382)
        Me.btnAddNewCustomers.Name = "btnAddNewCustomers"
        Me.btnAddNewCustomers.Size = New System.Drawing.Size(146, 31)
        Me.btnAddNewCustomers.TabIndex = 24
        Me.btnAddNewCustomers.Text = "Add New Customer"
        Me.btnAddNewCustomers.UseVisualStyleBackColor = True
        '
        'btnSelectCustomer
        '
        Me.btnSelectCustomer.Location = New System.Drawing.Point(242, 382)
        Me.btnSelectCustomer.Name = "btnSelectCustomer"
        Me.btnSelectCustomer.Size = New System.Drawing.Size(203, 31)
        Me.btnSelectCustomer.TabIndex = 25
        Me.btnSelectCustomer.Text = "Select Highlighted Customer"
        Me.btnSelectCustomer.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(134, 265)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 44
        Me.lblFirstName.Text = "First Name:"
        '
        'txtEmailInput
        '
        Me.txtEmailInput.Location = New System.Drawing.Point(242, 331)
        Me.txtEmailInput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailInput.Name = "txtEmailInput"
        Me.txtEmailInput.Size = New System.Drawing.Size(167, 22)
        Me.txtEmailInput.TabIndex = 43
        '
        'txtLastNameInput
        '
        Me.txtLastNameInput.Location = New System.Drawing.Point(242, 297)
        Me.txtLastNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastNameInput.Name = "txtLastNameInput"
        Me.txtLastNameInput.Size = New System.Drawing.Size(167, 22)
        Me.txtLastNameInput.TabIndex = 42
        '
        'txtFirstNameInput
        '
        Me.txtFirstNameInput.Location = New System.Drawing.Point(242, 265)
        Me.txtFirstNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstNameInput.Name = "txtFirstNameInput"
        Me.txtFirstNameInput.Size = New System.Drawing.Size(167, 22)
        Me.txtFirstNameInput.TabIndex = 41
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(134, 331)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(58, 17)
        Me.lblEmail.TabIndex = 40
        Me.lblEmail.Text = "# Email:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(134, 297)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 39
        Me.lblLastName.Text = "Last Name:"
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 450)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtEmailInput)
        Me.Controls.Add(Me.txtLastNameInput)
        Me.Controls.Add(Me.txtFirstNameInput)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.btnSelectCustomer)
        Me.Controls.Add(Me.btnAddNewCustomers)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picboxDroneDogs)
        Me.Name = "CustomerForm"
        Me.Text = "Cameron Harter"
        CType(Me.picboxDroneDogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picboxDroneDogs As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lstCustomers As ListBox
    Friend WithEvents btnAddNewCustomers As Button
    Friend WithEvents btnSelectCustomer As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtEmailInput As TextBox
    Friend WithEvents txtLastNameInput As TextBox
    Friend WithEvents txtFirstNameInput As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLastName As Label
End Class
