<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPartyPlatters
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
        grpPlatter = New GroupBox()
        radDessert = New RadioButton()
        radVegan = New RadioButton()
        radCheese = New RadioButton()
        radGreek = New RadioButton()
        radFruit = New RadioButton()
        grpPayment = New GroupBox()
        radPickup = New RadioButton()
        radPrePay = New RadioButton()
        lblPoints = New Label()
        btnOrder = New Button()
        txtLoyaltyPoints = New TextBox()
        lblOrder = New Label()
        grpPlatter.SuspendLayout()
        grpPayment.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpPlatter
        ' 
        grpPlatter.Controls.Add(radDessert)
        grpPlatter.Controls.Add(radVegan)
        grpPlatter.Controls.Add(radCheese)
        grpPlatter.Controls.Add(radGreek)
        grpPlatter.Controls.Add(radFruit)
        grpPlatter.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        grpPlatter.Location = New Point(74, 66)
        grpPlatter.Name = "grpPlatter"
        grpPlatter.Size = New Size(200, 147)
        grpPlatter.TabIndex = 0
        grpPlatter.TabStop = False
        grpPlatter.Text = "Platter Choices"
        ' 
        ' radDessert
        ' 
        radDessert.AutoSize = True
        radDessert.Location = New Point(6, 122)
        radDessert.Name = "radDessert"
        radDessert.Size = New Size(145, 20)
        radDessert.TabIndex = 5
        radDessert.TabStop = True
        radDessert.Text = "Dessert Charcuterie"
        radDessert.UseVisualStyleBackColor = True
        ' 
        ' radVegan
        ' 
        radVegan.AutoSize = True
        radVegan.Location = New Point(6, 97)
        radVegan.Name = "radVegan"
        radVegan.Size = New Size(159, 20)
        radVegan.TabIndex = 4
        radVegan.TabStop = True
        radVegan.Text = "Ultimate Vegan Board"
        radVegan.UseVisualStyleBackColor = True
        ' 
        ' radCheese
        ' 
        radCheese.AutoSize = True
        radCheese.Location = New Point(6, 72)
        radCheese.Name = "radCheese"
        radCheese.Size = New Size(105, 20)
        radCheese.TabIndex = 3
        radCheese.TabStop = True
        radCheese.Text = "Cheese Board"
        radCheese.UseVisualStyleBackColor = True
        ' 
        ' radGreek
        ' 
        radGreek.AutoSize = True
        radGreek.Location = New Point(6, 47)
        radGreek.Name = "radGreek"
        radGreek.Size = New Size(114, 20)
        radGreek.TabIndex = 2
        radGreek.TabStop = True
        radGreek.Text = "Greek-Inspired"
        radGreek.UseVisualStyleBackColor = True
        ' 
        ' radFruit
        ' 
        radFruit.AutoSize = True
        radFruit.Location = New Point(6, 22)
        radFruit.Name = "radFruit"
        radFruit.Size = New Size(103, 20)
        radFruit.TabIndex = 1
        radFruit.TabStop = True
        radFruit.Text = "Fruit Platter"
        radFruit.UseVisualStyleBackColor = True
        ' 
        ' grpPayment
        ' 
        grpPayment.Controls.Add(radPickup)
        grpPayment.Controls.Add(radPrePay)
        grpPayment.Font = New Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        grpPayment.Location = New Point(331, 83)
        grpPayment.Name = "grpPayment"
        grpPayment.Size = New Size(200, 100)
        grpPayment.TabIndex = 1
        grpPayment.TabStop = False
        grpPayment.Text = "Payment Type"
        ' 
        ' radPickup
        ' 
        radPickup.AutoSize = True
        radPickup.Location = New Point(6, 61)
        radPickup.Name = "radPickup"
        radPickup.Size = New Size(106, 20)
        radPickup.TabIndex = 1
        radPickup.TabStop = True
        radPickup.Text = "Order Pickup"
        radPickup.UseVisualStyleBackColor = True
        ' 
        ' radPrePay
        ' 
        radPrePay.AutoSize = True
        radPrePay.Location = New Point(6, 23)
        radPrePay.Name = "radPrePay"
        radPrePay.Size = New Size(73, 20)
        radPrePay.TabIndex = 0
        radPrePay.TabStop = True
        radPrePay.Text = "Pre-Pay"
        radPrePay.UseVisualStyleBackColor = True
        ' 
        ' lblPoints
        ' 
        lblPoints.AutoSize = True
        lblPoints.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPoints.Location = New Point(312, 201)
        lblPoints.Name = "lblPoints"
        lblPoints.Size = New Size(113, 19)
        lblPoints.TabIndex = 2
        lblPoints.Text = "Loyalty Points:"
        ' 
        ' btnOrder
        ' 
        btnOrder.BackgroundImageLayout = ImageLayout.Center
        btnOrder.FlatStyle = FlatStyle.Popup
        btnOrder.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnOrder.ForeColor = SystemColors.ControlText
        btnOrder.Location = New Point(264, 272)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(70, 28)
        btnOrder.TabIndex = 3
        btnOrder.Text = "Order"
        btnOrder.UseVisualStyleBackColor = True
        ' 
        ' txtLoyaltyPoints
        ' 
        txtLoyaltyPoints.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtLoyaltyPoints.Location = New Point(431, 198)
        txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        txtLoyaltyPoints.Size = New Size(100, 27)
        txtLoyaltyPoints.TabIndex = 4
        txtLoyaltyPoints.Text = "0"
        ' 
        ' lblOrder
        ' 
        lblOrder.AutoSize = True
        lblOrder.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblOrder.Location = New Point(80, 328)
        lblOrder.Name = "lblOrder"
        lblOrder.Size = New Size(0, 21)
        lblOrder.TabIndex = 5
        ' 
        ' frmPartyPlatters
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(598, 416)
        Controls.Add(btnOrder)
        Controls.Add(lblOrder)
        Controls.Add(txtLoyaltyPoints)
        Controls.Add(lblPoints)
        Controls.Add(grpPayment)
        Controls.Add(grpPlatter)
        Name = "frmPartyPlatters"
        Text = "Party Platters"
        grpPlatter.ResumeLayout(False)
        grpPlatter.PerformLayout()
        grpPayment.ResumeLayout(False)
        grpPayment.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpPlatter As GroupBox
    Friend WithEvents radDessert As RadioButton
    Friend WithEvents radVegan As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents radGreek As RadioButton
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents lblOrder As Label
End Class
