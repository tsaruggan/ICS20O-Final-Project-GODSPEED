Public Class FormStart

    Private Sub btnABOUT_Click(sender As Object, e As EventArgs) Handles btnABOUT.Click
        lblABOUT.Visible = True
        lblWONDERBOY.Visible = True 'MAKE CREDITS VISIBLE (ASSIGNMENT INFO)
        btnBACK.Visible = True 'SHOW BACK BUTTON TO EXIT CREDITS

        btnABOUT.Visible = False
        btnPLAY.Visible = False  'HIDE PLAY BUTTONS WHEN CREDITS ARE VISIBLE
        lbTITLE.Visible = False

    End Sub

    Private Sub btnBACK_Click(sender As Object, e As EventArgs) Handles btnBACK.Click
        lblABOUT.Visible = False
        lblWONDERBOY.Visible = False 'HIDE CREDITS
        btnBACK.Visible = False

        btnABOUT.Visible = True
        btnPLAY.Visible = True 'SHOW PLAY BUTTONS WHEN CREDITS BACK BUTTON IS PRESSED
        lbTITLE.Visible = True

    End Sub

    Private Sub btnPLAY_Click(sender As Object, e As EventArgs) Handles btnPLAY.Click
        FormSETTINGS.Show()
        Me.Hide()  'hide startup form, show settings form
    End Sub


End Class
