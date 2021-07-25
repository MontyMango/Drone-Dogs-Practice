<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DroneDogsOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DroneDogsOrder))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBeefDogs = New System.Windows.Forms.Label()
        Me.lblPorkDogs = New System.Windows.Forms.Label()
        Me.lblTurkeyDogs = New System.Windows.Forms.Label()
        Me.txtBeefDogs = New System.Windows.Forms.TextBox()
        Me.txtPorkDogs = New System.Windows.Forms.TextBox()
        Me.txtTurkeyDogs = New System.Windows.Forms.TextBox()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkboxLocationInfoAgreement = New System.Windows.Forms.CheckBox()
        Me.btnGetCustomerInfo = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmailInput = New System.Windows.Forms.TextBox()
        Me.txtLastNameInput = New System.Windows.Forms.TextBox()
        Me.txtFirstNameInput = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(64, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(230, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DroneDogs Order Form"
        '
        'lblBeefDogs
        '
        Me.lblBeefDogs.AutoSize = True
        Me.lblBeefDogs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblBeefDogs.Location = New System.Drawing.Point(38, 60)
        Me.lblBeefDogs.Name = "lblBeefDogs"
        Me.lblBeefDogs.Size = New System.Drawing.Size(64, 13)
        Me.lblBeefDogs.TabIndex = 1
        Me.lblBeefDogs.Text = "# BeefDogs"
        '
        'lblPorkDogs
        '
        Me.lblPorkDogs.AutoSize = True
        Me.lblPorkDogs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblPorkDogs.Location = New System.Drawing.Point(38, 87)
        Me.lblPorkDogs.Name = "lblPorkDogs"
        Me.lblPorkDogs.Size = New System.Drawing.Size(67, 13)
        Me.lblPorkDogs.TabIndex = 2
        Me.lblPorkDogs.Text = "# PorkDogs:"
        '
        'lblTurkeyDogs
        '
        Me.lblTurkeyDogs.AutoSize = True
        Me.lblTurkeyDogs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTurkeyDogs.Location = New System.Drawing.Point(38, 113)
        Me.lblTurkeyDogs.Name = "lblTurkeyDogs"
        Me.lblTurkeyDogs.Size = New System.Drawing.Size(78, 13)
        Me.lblTurkeyDogs.TabIndex = 3
        Me.lblTurkeyDogs.Text = "# TurkeyDogs:"
        '
        'txtBeefDogs
        '
        Me.txtBeefDogs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtBeefDogs.Location = New System.Drawing.Point(122, 60)
        Me.txtBeefDogs.Name = "txtBeefDogs"
        Me.txtBeefDogs.Size = New System.Drawing.Size(40, 20)
        Me.txtBeefDogs.TabIndex = 1
        '
        'txtPorkDogs
        '
        Me.txtPorkDogs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPorkDogs.Location = New System.Drawing.Point(122, 87)
        Me.txtPorkDogs.Name = "txtPorkDogs"
        Me.txtPorkDogs.Size = New System.Drawing.Size(40, 20)
        Me.txtPorkDogs.TabIndex = 2
        '
        'txtTurkeyDogs
        '
        Me.txtTurkeyDogs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtTurkeyDogs.Location = New System.Drawing.Point(122, 113)
        Me.txtTurkeyDogs.Name = "txtTurkeyDogs"
        Me.txtTurkeyDogs.Size = New System.Drawing.Size(40, 20)
        Me.txtTurkeyDogs.TabIndex = 3
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblSalesTax.Location = New System.Drawing.Point(38, 222)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(57, 13)
        Me.lblSalesTax.TabIndex = 8
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTotalCost.Location = New System.Drawing.Point(38, 249)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Cursor = System.Windows.Forms.Cursors.No
        Me.txtSubtotal.Location = New System.Drawing.Point(119, 196)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 10
        Me.txtSubtotal.TabStop = False
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Cursor = System.Windows.Forms.Cursors.No
        Me.txtSalesTax.Location = New System.Drawing.Point(119, 222)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesTax.TabIndex = 11
        Me.txtSalesTax.TabStop = False
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotalCost.Location = New System.Drawing.Point(119, 249)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 12
        Me.txtTotalCost.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(294, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(88, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnCalculate.Location = New System.Drawing.Point(27, 148)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(89, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnExit.Location = New System.Drawing.Point(155, 446)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnSubmit.Location = New System.Drawing.Point(27, 446)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 23)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblSubTotal.Location = New System.Drawing.Point(38, 196)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblSubTotal.TabIndex = 17
        Me.lblSubTotal.Text = "Sub Total:"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button1.Location = New System.Drawing.Point(155, 286)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 19)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Clear Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkboxLocationInfoAgreement
        '
        Me.chkboxLocationInfoAgreement.AutoSize = True
        Me.chkboxLocationInfoAgreement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkboxLocationInfoAgreement.Location = New System.Drawing.Point(27, 423)
        Me.chkboxLocationInfoAgreement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkboxLocationInfoAgreement.Name = "chkboxLocationInfoAgreement"
        Me.chkboxLocationInfoAgreement.Size = New System.Drawing.Size(345, 17)
        Me.chkboxLocationInfoAgreement.TabIndex = 6
        Me.chkboxLocationInfoAgreement.Text = "I agree to give DroneDogs permission to use my location information"
        Me.chkboxLocationInfoAgreement.UseVisualStyleBackColor = True
        '
        'btnGetCustomerInfo
        '
        Me.btnGetCustomerInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnGetCustomerInfo.Location = New System.Drawing.Point(27, 286)
        Me.btnGetCustomerInfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGetCustomerInfo.Name = "btnGetCustomerInfo"
        Me.btnGetCustomerInfo.Size = New System.Drawing.Size(109, 19)
        Me.btnGetCustomerInfo.TabIndex = 5
        Me.btnGetCustomerInfo.Text = "Get Customer Info"
        Me.btnGetCustomerInfo.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFirstName.Location = New System.Drawing.Point(38, 331)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 38
        Me.lblFirstName.Text = "First Name:"
        '
        'txtEmailInput
        '
        Me.txtEmailInput.Cursor = System.Windows.Forms.Cursors.No
        Me.txtEmailInput.Location = New System.Drawing.Point(119, 384)
        Me.txtEmailInput.Name = "txtEmailInput"
        Me.txtEmailInput.ReadOnly = True
        Me.txtEmailInput.Size = New System.Drawing.Size(126, 20)
        Me.txtEmailInput.TabIndex = 37
        Me.txtEmailInput.TabStop = False
        '
        'txtLastNameInput
        '
        Me.txtLastNameInput.Cursor = System.Windows.Forms.Cursors.No
        Me.txtLastNameInput.Location = New System.Drawing.Point(119, 357)
        Me.txtLastNameInput.Name = "txtLastNameInput"
        Me.txtLastNameInput.ReadOnly = True
        Me.txtLastNameInput.Size = New System.Drawing.Size(126, 20)
        Me.txtLastNameInput.TabIndex = 36
        Me.txtLastNameInput.TabStop = False
        '
        'txtFirstNameInput
        '
        Me.txtFirstNameInput.Cursor = System.Windows.Forms.Cursors.No
        Me.txtFirstNameInput.Location = New System.Drawing.Point(119, 331)
        Me.txtFirstNameInput.Name = "txtFirstNameInput"
        Me.txtFirstNameInput.ReadOnly = True
        Me.txtFirstNameInput.Size = New System.Drawing.Size(126, 20)
        Me.txtFirstNameInput.TabIndex = 35
        Me.txtFirstNameInput.TabStop = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.Location = New System.Drawing.Point(38, 384)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 13)
        Me.lblEmail.TabIndex = 34
        Me.lblEmail.Text = "# Email:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLastName.Location = New System.Drawing.Point(38, 357)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 33
        Me.lblLastName.Text = "Last Name:"
        '
        'DroneDogsOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 488)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtEmailInput)
        Me.Controls.Add(Me.txtLastNameInput)
        Me.Controls.Add(Me.txtFirstNameInput)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.btnGetCustomerInfo)
        Me.Controls.Add(Me.chkboxLocationInfoAgreement)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.txtTurkeyDogs)
        Me.Controls.Add(Me.txtPorkDogs)
        Me.Controls.Add(Me.txtBeefDogs)
        Me.Controls.Add(Me.lblTurkeyDogs)
        Me.Controls.Add(Me.lblPorkDogs)
        Me.Controls.Add(Me.lblBeefDogs)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "DroneDogsOrder"
        Me.Text = "Cameron Harter"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblBeefDogs As System.Windows.Forms.Label
    Friend WithEvents lblPorkDogs As System.Windows.Forms.Label
    Friend WithEvents lblTurkeyDogs As System.Windows.Forms.Label
    Friend WithEvents txtBeefDogs As System.Windows.Forms.TextBox
    Friend WithEvents txtPorkDogs As System.Windows.Forms.TextBox
    Friend WithEvents txtTurkeyDogs As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkboxLocationInfoAgreement As CheckBox
    Friend WithEvents btnGetCustomerInfo As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtEmailInput As TextBox
    Friend WithEvents txtLastNameInput As TextBox
    Friend WithEvents txtFirstNameInput As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLastName As Label
End Class
