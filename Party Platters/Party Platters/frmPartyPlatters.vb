Public Class frmPartyPlatters
    Const FRUIT_PLATTER = 13.99D
    Const GREEK_INSPIRED = 10D
    Const CHEESE_BOARD = 9.78D
    Const ULTIMATE_VEGAN_BOARD = 5.68D
    Const DESSERT_CHARCUTERIE = 12.87D
    Const LOYALTY_DISCOUNT = 0.05


    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        Dim intLoyaltyPoints As Integer
        Dim decOrderEstimate As Decimal

        If radFruit.Checked Then
            decOrderEstimate = FRUIT_PLATTER
        ElseIf radGreek.Checked Then
            decOrderEstimate = GREEK_INSPIRED
        ElseIf radCheese.Checked Then
            decOrderEstimate = CHEESE_BOARD
        ElseIf radVegan.Checked Then
            decOrderEstimate = ULTIMATE_VEGAN_BOARD
        ElseIf radDessert.Checked Then
            decOrderEstimate = DESSERT_CHARCUTERIE
        End If

        If IsNumeric(txtLoyaltyPoints.Text) Then
            intLoyaltyPoints = Convert.ToInt32(txtLoyaltyPoints.Text)
            If intLoyaltyPoints >= 10 Then
                decOrderEstimate = decOrderEstimate - decOrderEstimate * LOYALTY_DISCOUNT
            End If
        Else
            MsgBox("Needs to be at least less 10 points.")
            txtLoyaltyPoints.Clear()
            txtLoyaltyPoints.Focus()
        End If

        If radPrePay.Checked Then
            lblOrder.Text = "Thank you for your order, please pre pay " & decOrderEstimate.ToString("C")
        Else
            lblOrder.Text = "Thank you for your order, please pay at pickup " & decOrderEstimate.ToString("C")
        End If
    End Sub
End Class
