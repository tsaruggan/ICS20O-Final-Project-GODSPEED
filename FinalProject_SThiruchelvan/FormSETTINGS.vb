Public Class FormSETTINGS

   
    Private Sub btnMENUback_Click(sender As Object, e As EventArgs) Handles btnMENUback.Click
        FormStart.Show()
        Me.Hide() 'go back to startup form, hide settings form
    End Sub

    Private Sub btnSTART_Click(sender As Object, e As EventArgs) Handles btnSTART.Click
        Me.Hide()
        FormGAME.Show() 'show actual game form, hide settings
        FormGAME.BackgroundImageLayout = ImageLayout.Stretch 'image stretches to cover form

        If radSTANDARD.Checked = True Then
            FormGAME.picBORDER.BackColor = Color.DarkSeaGreen 'BAR AT THE BOTTOM BEHIND TEXT BOX AND HEARTICONS
            FormGAME.BackColor = Color.LightBlue
            FormGAME.BackgroundImage = Nothing 'REMOVE BACKGROUND

            FormGAME.heart1.BackColor = Color.DarkSeaGreen
            FormGAME.heart2.BackColor = Color.DarkSeaGreen
            FormGAME.heart3.BackColor = Color.DarkSeaGreen 'change color of heart icons


            'STANDARD SETTINGS

        ElseIf radDUNGEON.Checked = True Then
            FormGAME.picBORDER.BackColor = Color.Firebrick 'BAR AT THE BOTTOM BEHIND TEXT BOX AND HEARTICONS
            FormGAME.BackgroundImage = My.Resources.DUNGEON

            FormGAME.heart1.BackColor = Color.Firebrick
            FormGAME.heart2.BackColor = Color.Firebrick
            FormGAME.heart3.BackColor = Color.Firebrick 'change color of heart icons


            'DUNGEON THEME

        ElseIf radUNDERWATER.Checked = True Then
            FormGAME.picBORDER.BackColor = Color.SteelBlue 'BAR AT THE BOTTOM BEHIND TEXT BOX AND HEARTICONS
            FormGAME.BackgroundImage = My.Resources.UNDERWATER

            FormGAME.heart1.BackColor = Color.SteelBlue
            FormGAME.heart2.BackColor = Color.SteelBlue
            FormGAME.heart3.BackColor = Color.SteelBlue 'change color of heart icons


            'UNDERWATER THEME

        ElseIf radGALAXY.Checked = True Then
            FormGAME.picBORDER.BackColor = Color.LightSlateGray 'BAR AT THE BOTTOM BEHIND TEXT BOX AND HEARTICONS
            FormGAME.BackgroundImage = My.Resources.GALAXY

            FormGAME.heart1.BackColor = Color.LightSlateGray
            FormGAME.heart2.BackColor = Color.LightSlateGray
            FormGAME.heart3.BackColor = Color.LightSlateGray 'change color of heart icons


            'GALAXY THEME

        ElseIf radURBAN.Checked = True Then
            FormGAME.picBORDER.BackColor = Color.CadetBlue 'BAR AT THE BOTTOM BEHIND TEXT BOX AND HEARTICONS
            FormGAME.BackgroundImage = My.Resources.URBAN

            FormGAME.heart1.BackColor = Color.CadetBlue
            FormGAME.heart2.BackColor = Color.CadetBlue
            FormGAME.heart3.BackColor = Color.CadetBlue  'change color of heart icons


            'URBAN THEME
        End If


        If radAVERAGE.Checked Then
            FormGAME.tmrWORDS.Interval = 400   'speed of timer to average mode
        ElseIf radEXTREME.Checked Then
            FormGAME.tmrWORDS.Interval = 275 'speed of timer more faster, more difficult
        End If


    End Sub

    Private Sub btnINSTRUCTIONS_Click(sender As Object, e As EventArgs) Handles btnINSTRUCTIONS.Click
        'show instructions of game upon instructions button click

        btnINSTRUCTIONS.Visible = False 'hide instructions button

        grpDIFFICULTY.Visible = False
        grpTHEME.Visible = False          'hide groupboxes of settings menu 
        grpINSTRUCTIONS.Visible = True

        btnSTART.Visible = False
        btnMENUback.Visible = False       'hide start and back buttons 

        btnBACKinstructions.Visible = True   'ONLY SHOW BACK BUTTON TO EXIT INSTRUCTIONS
    End Sub

    Private Sub btnBACKinstructions_Click(sender As Object, e As EventArgs) Handles btnBACKinstructions.Click
        'hide instructions of game upon back button click


        btnINSTRUCTIONS.Visible = True   'show instructions game

        grpDIFFICULTY.Visible = True
        grpTHEME.Visible = True             'show group boxes of settings menu
        grpINSTRUCTIONS.Visible = False

        btnSTART.Visible = True   'show start and back buttons
        btnMENUback.Visible = True

        btnBACKinstructions.Visible = False 'HIIDE INSTRUCTIONS BACK BUTTON
    End Sub

   
   
End Class