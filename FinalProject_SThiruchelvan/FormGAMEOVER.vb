Public Class FormGAMEOVER
 
   
    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Dim areyousure As MsgBoxResult
        areyousure = MsgBox("ARE YOU SURE YOU WANT TO EXIT?", MsgBoxStyle.YesNo, "Godspeed")
        If areyousure = MsgBoxResult.Yes Then
            Application.Exit()   'msg asking user if they want to exit 
        End If
    End Sub

    Private Sub btnMAINMENU_Click(sender As Object, e As EventArgs) Handles btnMAINMENU.Click
        'reset components on the game form so when user goes back to the main menu, they can play the game again


        FormStart.Show()
        Me.Hide()           'RETURN BACK TO MAIN MENU, hide gameover form

        My.Forms.FormGAME.btnGO.Visible = True 'show GO button
        'go button will reset x and y positions of words and all other variables on game form

        My.Forms.FormGAME.tmrWORDS.Stop() 'stop game timer
        My.Forms.FormGAME.mnuFILE.Enabled = True  'enable menu select on game form
        'was locked before when game was over

        My.Forms.FormGAME.lblWORD1.BackColor = SystemColors.InactiveCaptionText
        My.Forms.FormGAME.lblWORD1.ForeColor = Color.PaleGreen

        My.Forms.FormGAME.lblWORD2.BackColor = SystemColors.InactiveCaptionText
        My.Forms.FormGAME.lblWORD2.ForeColor = Color.PaleGreen

        My.Forms.FormGAME.lblWORD3.BackColor = SystemColors.InactiveCaptionText    'reset default colours of the words
        My.Forms.FormGAME.lblWORD3.ForeColor = Color.PaleGreen

        My.Forms.FormGAME.lblWORD4.BackColor = SystemColors.InactiveCaptionText
        My.Forms.FormGAME.lblWORD4.ForeColor = Color.PaleGreen

        My.Forms.FormGAME.lblWORD5.BackColor = SystemColors.InactiveCaptionText
        My.Forms.FormGAME.lblWORD5.ForeColor = Color.PaleGreen

        My.Forms.FormGAME.heart1.Visible = True
        My.Forms.FormGAME.heart2.Visible = True     'all heart icons on game form are visible
        My.Forms.FormGAME.heart3.Visible = True

        My.Forms.FormGAME.txtINPUT.Text = "" 'empties game text box
        My.Forms.FormGAME.txtINPUT.Enabled = True 'allows user ot type in textbox
        My.Forms.FormGAME.lblSCORE.Text = "0" 'resets score text, varaible will be resetted when user presses go button
        
        My.Forms.FormGAME.lblWORD1.Visible = False
        My.Forms.FormGAME.lblWORD2.Visible = False
        My.Forms.FormGAME.lblWORD3.Visible = False   'makes all words invisible on game form
        My.Forms.FormGAME.lblWORD4.Visible = False
        My.Forms.FormGAME.lblWORD5.Visible = False
        My.Forms.FormGAME.btnGAMEOVER.Visible = False  'hides the game over button




    End Sub
End Class