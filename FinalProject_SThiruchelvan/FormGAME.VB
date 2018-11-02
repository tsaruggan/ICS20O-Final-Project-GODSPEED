Public Class FormGAME
    Dim x1 As Integer
    Dim x2 As Integer
    Dim x3 As Integer     'X POSITIONS OF ALL 5 WORDS
    Dim x4 As Integer
    Dim x5 As Integer

    Dim xBONUS As Integer 'X POSITION OF BONUS
    Dim yBONUS As Integer 'Y POSITION OF BONUS
    Dim yGAMEOVER As Integer 'Y POSITION OF GAMEOVER BTN
    Dim xLIFE As Integer 'X POSITION OF BONUS LABEL
    Dim yLIFE As Integer 'Y POSITION OF BONUS LABEL
    Dim PAUSE As Boolean 'TRUE OR FALSE WHETHER TIMER STOPPED
    Dim SCORE As Integer 'SCORE VALUE
    Dim LIFE As Integer 'NUMBER OF LIVES LEFT
    Dim BONUS As Boolean 'TRUE OR FALSE IF USER CAN GET BONUS
    Dim EXTRALIFE As Boolean 'TRUE OR FALSE IF USER CAN COLLECT EXTRA LIFE

    Dim GAMEOVER As Boolean

    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        tmrWORDS.Start() 'ALLOW WORDS TO MOVE
        btnGO.Visible = False 'HIDE BUTTON
        txtINPUT.Focus() 'FOCUS ON TEXTBOX

        ' DEFAULT VARIABLES
        PAUSE = False
        LIFE = 3 'LIVES TO START W/

        SCORE = 0 'SCORE TO START W/
        lblSCORE.Text = SCORE

        x1 = 0
        x2 = 0
        x3 = 0         'X POSITIONS OFF AKLL WORDS
        x4 = 0
        x5 = 0

        xBONUS = 500     'WHERE BONUS WILL START FROM (INVISIBLE CURRENTLY)
        yBONUS = 250

        BONUS = False
        EXTRALIFE = False
        GAMEOVER = False

        xLIFE = 0     'WHERE EXTRA LIFE ICON WILL COME FROM (INVISIBLE CURRENTLY)
        yLIFE = 250
        yGAMEOVER = 0
        'DEFAULT VARIABLES


        lblWORD1.Visible = True
        lblWORD2.Visible = True
        lblWORD3.Visible = True       'MAKE ALL WORD LABELS VISIBLE
        lblWORD4.Visible = True
        lblWORD5.Visible = True
        btnGAMEOVER.Visible = False 'HIDE GAMEOVER BUTTON

        Dim WORDS1() As String = {"FLY", "BOTTLE", "ACID", "ANGEL", "SOFTWARE", "GENIUS", "COMPLEX", "ASTRONAUT", "FIRE", "DESIRE", "WEEKEND", "BABY", "WINDOW", "EIGHT", "STORE", "MANIA", "DIGITAL", "SHARK", "CHAIN", "SMOKE"} 'WORDS TO BE RANDOMIZED
        Dim word1 As Integer
        Randomize()
        word1 = Int(Rnd() * 19) 'RANDOMIZE NUMBER THAT WILL INDICATE WHICH WORD IN THE ARRAY
        lblWORD1.Text = WORDS1(word1) 'DISPLAY WORD IN RESPECTIVE LABEL

        Dim WORDS2() As String = {"WEIGHT", "ICY", "BOOST", "ANIMAL", "CHEMICAL", "ROMANCE", "OCEAN", "ELASTIC", "ENCHANT", "UMBRELLA", "RUIN", "FOREST", "FROG", "SWIM", "SECRET", "CAR", "TOOTHBRUSH", "IVY", "TWENTY", "PLENTY"} ' ""
        Dim word2 As Integer
        Randomize()
        word2 = Int(Rnd() * 19) 'RANDOMIZE NUMBER THAT WILL INDICATE WHICH WORD IN THE ARRAY
        lblWORD2.Text = WORDS2(word2) 'DISPLAY WORD IN RESPECTIVE LABEL

        Dim WORDS3() As String = {"FIGHT", "ZEBRA", "HOURS", "INFAMOUS", "AMAZING", "LOSER", "ADVENTURE", "RACE", "LOVE", "JAM", "LABYRINTH", "UNCLE", "ALCOHOL", "GAZE", "NOTHING", "MONSTER", "REACH", "IMMORTAL", "COPY", "DOUBT"} ' ""
        Dim word3 As Integer
        Randomize()
        word3 = Int(Rnd() * 19) 'RANDOMIZE NUMBER THAT WILL INDICATE WHICH WORD IN THE ARRAY
        lblWORD3.Text = WORDS3(word3) 'DISPLAY WORD IN RESPECTIVE LABEL

        Dim WORDS4() As String = {"BEE", "BAKE", "TENNIS", "UNIT", "LIVE", "EPIC", "CHILD", "SMILE", "AGENT", "QUICKSAND", "ENCRYPTION", "TOUR", "BLINK", "WORLD", "BOMB", "ULTRA", "ZIPPER", "EGG", "SEAL", "ENCYCLOPEDIA"} ' ""
        Dim word4 As Integer
        Randomize()
        word4 = Int(Rnd() * 19) 'RANDOMIZE NUMBER THAT WILL INDICATE WHICH WORD IN THE ARRAY
        lblWORD4.Text = WORDS4(word4) 'DISPLAY WORD IN RESPECTIVE LABEL

        Dim WORDS5() As String = {"MACHINE", "UP", "BLONDE", "CAT", "WASH", "NOSTALGIA", "WIRE", "COMPUTER", "EXPLODE", "TWIN", "ESCAPE", "VIOLET", "BEAUTY", "MADNESS", "VIEWS", "SIXTEEN", "PANCAKE", "ALARM", "VANILLA", "COIL"} ' ""
        Dim word5 As Integer
        Randomize()
        word5 = Int(Rnd() * 19) 'RANDOMIZE NUMBER THAT WILL INDICATE WHICH WORD IN THE ARRAY
        lblWORD5.Text = WORDS5(word5) 'DISPLAY WORD IN RESPECTIVE LABEL


        lblWORD1.BackColor = SystemColors.InactiveCaptionText
        lblWORD1.ForeColor = Color.PaleGreen     'DEFAULT LABEL COLOURS, GREEN TEXT, GREY BACKGROUND

        lblWORD2.BackColor = SystemColors.InactiveCaptionText
        lblWORD2.ForeColor = Color.PaleGreen 'DEFAULT LABEL COLOURS, GREEN TEXT, GREY BACKGROUND

        lblWORD3.BackColor = SystemColors.InactiveCaptionText
        lblWORD3.ForeColor = Color.PaleGreen 'DEFAULT LABEL COLOURS, GREEN TEXT, GREY BACKGROUND

        lblWORD4.BackColor = SystemColors.InactiveCaptionText
        lblWORD4.ForeColor = Color.PaleGreen 'DEFAULT LABEL COLOURS, GREEN TEXT, GREY BACKGROUND

        lblWORD5.BackColor = SystemColors.InactiveCaptionText
        lblWORD5.ForeColor = Color.PaleGreen 'DEFAULT LABEL COLOURS, GREEN TEXT, GREY BACKGROUND
        txtINPUT.BackColor = Color.WhiteSmoke 'INPUT BOX DEFAULT COLOUR
    End Sub


    Private Sub tmrWORDS_Tick(sender As Object, e As EventArgs) Handles tmrWORDS.Tick
        Dim updatepanel As ControlUpdateMode
        updatepanel = ControlUpdateMode.OnPropertyChanged 'allow user to type in textbox while timer ticks
        'PREVENT TIMER FROM CLEARING TEXTBOX WHILE USER WRITES

  


        If x1 > 0 Then
            If x1 > 0 And x1 < 250 Then
                lblWORD1.ForeColor = Color.PaleGreen   'lbl text stays green to start
            ElseIf x1 > 250 And x1 < 400 Then
                lblWORD1.ForeColor = Color.Yellow 'when lbl reaches middle of form, text turns yellow
            ElseIf x1 > 400 And x1 < 500 Then
                lblWORD1.ForeColor = Color.Black
                lblWORD1.BackColor = Color.Tomato 'when word approaches edge of form, word changes colour to red
            ElseIf x1 > 500 Then
                x1 = 0
                lblWORD1.BackColor = SystemColors.InactiveCaptionText
                lblWORD1.ForeColor = Color.PaleGreen 'word colours and x position of word resets when word reaches edge of form
                LIFE = LIFE - 1 'deduct life 
            End If
        End If

        If x2 > 0 Then
            If x2 > 0 And x2 < 250 Then
                lblWORD2.ForeColor = Color.PaleGreen  'lbl text stays green to start
            ElseIf x2 > 250 And x2 < 400 Then
                lblWORD2.ForeColor = Color.Yellow 'when lbl reaches middle of form, text turns yellow
            ElseIf x2 > 400 And x2 < 500 Then
                lblWORD2.ForeColor = Color.Black
                lblWORD2.BackColor = Color.Tomato 'when word approaches edge of form, word changes colour to red
            ElseIf x2 > 500 Then
                x2 = 0
                lblWORD2.BackColor = SystemColors.InactiveCaptionText
                lblWORD2.ForeColor = Color.PaleGreen 'word colours and x position of word resets when word reaches edge of form
                LIFE = LIFE - 1 'deduct life 
            End If
        End If

        If x3 > 0 Then
            If x3 > 0 And x3 < 250 Then
                lblWORD3.ForeColor = Color.PaleGreen  'lbl text stays green to start
            ElseIf x3 > 250 And x3 < 400 Then
                lblWORD3.ForeColor = Color.Yellow 'when lbl reaches middle of form, text turns yellow
            ElseIf x3 > 400 And x3 < 500 Then
                lblWORD3.ForeColor = Color.Black
                lblWORD3.BackColor = Color.Tomato 'when word approaches edge of form, word changes colour to red
            ElseIf x3 > 500 Then
                x3 = 0
                lblWORD3.BackColor = SystemColors.InactiveCaptionText
                lblWORD3.ForeColor = Color.PaleGreen 'word colours and x position of word resets when word reaches edge of form
                LIFE = LIFE - 1 'deduct life 
            End If
        End If

        If x4 > 0 Then
            If x4 > 0 And x4 < 250 Then
                lblWORD4.ForeColor = Color.PaleGreen  'lbl text stays green to start
            ElseIf x4 > 250 And x4 < 400 Then
                lblWORD4.ForeColor = Color.Yellow 'when lbl reaches middle of form, text turns yellow
            ElseIf x4 > 400 And x4 < 500 Then
                lblWORD4.ForeColor = Color.Black
                lblWORD4.BackColor = Color.Tomato 'when word approaches edge of form, word changes colour to red
            ElseIf x4 > 500 Then
                x4 = 0
                lblWORD4.BackColor = SystemColors.InactiveCaptionText
                lblWORD4.ForeColor = Color.PaleGreen 'word colours and x position of word resets when word reaches edge of form
                LIFE = LIFE - 1 'deduct life 
            End If
        End If

        If x5 > 0 Then
            If x5 > 0 And x5 < 250 Then
                lblWORD5.ForeColor = Color.PaleGreen  'lbl text stays green to start
            ElseIf x5 > 250 And x5 < 400 Then
                lblWORD5.ForeColor = Color.Yellow 'when lbl reaches middle of form, text turns yellow
            ElseIf x5 > 400 And x5 < 500 Then
                lblWORD5.ForeColor = Color.Black
                lblWORD5.BackColor = Color.Tomato 'when word approaches edge of form, word changes colour to red
            ElseIf x5 > 500 Then
                x5 = 0
                lblWORD5.BackColor = SystemColors.InactiveCaptionText
                lblWORD5.ForeColor = Color.PaleGreen 'word colours and x position of word resets when word reaches edge of form
                LIFE = LIFE - 1 'deduct life 
            End If
        End If

        If SCORE Mod 1100 = 0 And SCORE > 0 Then
            BONUS = True  'change boolean value of bonus when user score is multiple of 1100 (22 words)
        End If

        If BONUS = True Then
            lblBONUS.Visible = True 'make bonus label visible when  boolean is true
            xBONUS = xBONUS - 25 'bonus moves 25 x pixels per tick
            yBONUS = yBONUS - 12.5 'bonus moves 12.5 y pixels per tick (half as many x pixels as  form width is twice the length of height
            'word travels from bottom right to top left

            lblBONUS.Location = New Point(xBONUS, yBONUS) 'position of label location follows xbonus and ybonus variables

            If BONUS = True And xBONUS = 0 Then
                'if user misses bonus and position reaches top left corner
                'boolean bonus should reset and go back to default location, become invisible
                BONUS = False 'boolean becomes false
                lblBONUS.Visible = False 'hide label
                xBONUS = 500
                yBONUS = 250  'reset x and y position of  lbl
                lblBONUS.Location = New Point(xBONUS, yBONUS) 'position of label location follows xbonus and ybonus variables
            End If
        End If

        If SCORE Mod 750 = 0 And LIFE < 3 And SCORE > 0 Then
            EXTRALIFE = True 'when user is missing lives and score is a multiple of 750 (15 words)
        End If

        If EXTRALIFE = True Then
            picLIFE.Visible = True 'shows heart icon
            xLIFE = xLIFE + 15 'icon moves 15 x pixels per tick
            yLIFE = yLIFE - 7.5 'icon moves 7.5 y pixels per tick (half as many x pixels as form width is double form length
            picLIFE.Location = New Point(xLIFE, yLIFE) 'icon location follows x and y variables
            If EXTRALIFE = True And xLIFE = 500 Then
                'if user misses extra life, icon disappears and returns back to origianl position
                EXTRALIFE = False 'boolean becomes false
                picLIFE.Visible = False 'hide icon
                xLIFE = 0
                yLIFE = 250 'reset x and y positions
                picLIFE.Location = New Point(xLIFE, yLIFE) 'icon location follows x and y variables
            End If
        End If



        x1 = x1 + 10
        lblWORD1.Location = New Point(x1, 50)

        x2 = x2 + 10
        lblWORD2.Location = New Point(x2, 100)

        x3 = x3 + 10
        lblWORD3.Location = New Point(x3, 150)     'words move 10 pixels to the right as timer ticks

        x4 = x4 + 10
        lblWORD4.Location = New Point(x4, 200)

        x5 = x5 + 10
        lblWORD5.Location = New Point(x5, 250)

        If LIFE < 4 Then
            If LIFE = 3 Then
                heart1.Visible = True
                heart2.Visible = True  'if 3 lives left, 3 icons visible
                heart3.Visible = True
            ElseIf LIFE = 2 Then
                heart1.Visible = True
                heart2.Visible = True 'if 2 lives visible, 2 icons visible
                heart3.Visible = False
            ElseIf LIFE = 1 Then
                heart1.Visible = True
                heart2.Visible = False 'if 1 life visible , 1 icon visible
                heart3.Visible = False
            ElseIf LIFE <= 0 And GAMEOVER = False Then
                heart1.Visible = False
                heart2.Visible = False 'if all lives lost, all icons not visible
                heart3.Visible = False
                GAMEOVER = True 'gameover boolean that controls game over button and disables all other function
               
                End If
            End If


        If GAMEOVER = True And yGAMEOVER < 135 Then

            txtINPUT.Enabled = False
            mnuFILE.Enabled = False 'dont allow user to use textbox or access file menu
            btnGAMEOVER.Visible = True 'make game over button visible
            yGAMEOVER = yGAMEOVER + 13.5 'gameover button decends from top of the screen
            btnGAMEOVER.Location = New Point(180, yGAMEOVER)

            'button will stop moving when y pos reaches 135 (middle of screen)
            'hence the if then clause function to only proceed when yGAMEOVER is less than 135
            'WORDS CONTINUE TO MOVE FOR VISUAL EFFECT
            txtINPUT.Text = "CLICK THE BUTTON!" 'TELLS THE USER TO CLICK THE GAME OVER BUTTON
        End If

    End Sub


    Private Sub txtINPUT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtINPUT.KeyDown
        Dim input As String
        input = txtINPUT.Text


        Dim WORDS1() As String = {"FLY", "BOTTLE", "ACID", "ANGEL", "SOFTWARE", "GENIUS", "COMPLEX", "ASTRONAUT", "FIRE", "DESIRE", "WEEKEND", "BABY", "WINDOW", "EIGHT", "STORE", "MANIA", "DIGITAL", "SHARK", "CHAIN", "SMOKE"} 'possible words
        Dim word1 As Integer

        Dim WORDS2() As String = {"WEIGHT", "ICY", "BOOST", "ANIMAL", "CHEMICAL", "ROMANCE", "OCEAN", "ELASTIC", "ENCHANT", "UMBRELLA", "RUIN", "FOREST", "FROG", "SWIM", "SECRET", "CAR", "TOOTHBRUSH", "IVY", "TWENTY", "PLENTY"}
        Dim word2 As Integer

        Dim WORDS3() As String = {"FIGHT", "ZEBRA", "HOURS", "INFAMOUS", "AMAZING", "LOSER", "ADVENTURE", "RACE", "LOVE", "JAM", "LABYRINTH", "UNCLE", "ALCOHOL", "GAZE", "NOTHING", "MONSTER", "REACH", "IMMORTAL", "COPY", "DOUBT"}
        Dim word3 As Integer

        Dim WORDS4() As String = {"BEE", "BAKE", "TENNIS", "UNIT", "LIVE", "EPIC", "CHILD", "SMILE", "AGENT", "QUICKSAND", "ENCRYPTION", "TOUR", "BLINK", "WORLD", "BOMB", "ULTRA", "ZIPPER", "EGG", "SEAL", "ENCYCLOPEDIA"}
        Dim word4 As Integer

        Dim WORDS5() As String = {"MACHINE", "UP", "BLONDE", "CAT", "WASH", "NOSTALGIA", "WIRE", "COMPUTER", "EXPLODE", "TWIN", "ESCAPE", "VIOLET", "BEAUTY", "MADNESS", "VIEWS", "SIXTEEN", "PANCAKE", "ALARM", "VANILLA", "COIL"}
        Dim word5 As Integer

        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter And input = lblWORD1.Text Then
                'if user types correct word and hit enter
                x1 = 0 'RESET XPOS FOR WORD1
                lblWORD1.BackColor = SystemColors.InactiveCaptionText
                lblWORD1.ForeColor = Color.PaleGreen 'reset word colour scheme
                Randomize()
                word1 = Int(Rnd() * 19)
                lblWORD1.Text = WORDS1(word1) 'randomize word in lbl
                txtINPUT.SelectAll() 'HIGHLIGHT TEXT
                SCORE = SCORE + 50 'ADD POINTS TO SCORE
                txtINPUT.BackColor = Color.WhiteSmoke 'reset input box colour, (may have been red if user got word wrong)
            ElseIf e.KeyCode = Keys.Enter And input = lblWORD2.Text Then
                'if user types correct word and hit enter
                x2 = 0 'RESET XPOS
                lblWORD2.BackColor = SystemColors.InactiveCaptionText
                lblWORD2.ForeColor = Color.PaleGreen 'reset word colour scheme
                Randomize()
                word2 = Int(Rnd() * 19)
                lblWORD2.Text = WORDS2(word2) 'randomize word in lbl
                txtINPUT.SelectAll()
                SCORE = SCORE + 50 'ADD POINTS TO SCORE
                txtINPUT.BackColor = Color.WhiteSmoke 'reset input box colour, (may have been red if user got word wrong)
            ElseIf e.KeyCode = Keys.Enter And input = lblWORD3.Text Then
                'if user types correct word and hit enter
                x3 = 0 'RESET XPOS
                lblWORD3.BackColor = SystemColors.InactiveCaptionText
                lblWORD3.ForeColor = Color.PaleGreen 'reset word colour scheme
                Randomize()
                word3 = Int(Rnd() * 19)
                lblWORD3.Text = WORDS3(word3) 'randomize word in lbl
                txtINPUT.SelectAll()
                SCORE = SCORE + 50 'ADD POINTS TO SCORE
                txtINPUT.BackColor = Color.WhiteSmoke 'reset input box colour, (may have been red if user got word wrong)
            ElseIf e.KeyCode = Keys.Enter And input = lblWORD4.Text Then
                'if user types correct word and hit enter
                x4 = 0 'RESET XPOS
                lblWORD4.BackColor = SystemColors.InactiveCaptionText
                lblWORD4.ForeColor = Color.PaleGreen 'reset word colour scheme
                Randomize()
                word4 = Int(Rnd() * 19)
                lblWORD4.Text = WORDS4(word4) 'randomize word in lbl
                txtINPUT.SelectAll()
                SCORE = SCORE + 50 'ADD POINTS TO SCORE
                txtINPUT.BackColor = Color.WhiteSmoke 'reset input box colour, (may have been red if user got word wrong)
            ElseIf e.KeyCode = Keys.Enter And input = lblWORD5.Text Then
                'if user types correct word and hit enter
                x5 = 0 'RESET XPOS
                Randomize()
                word5 = Int(Rnd() * 19)
                lblWORD5.Text = WORDS5(word5) 'randomize word in lbl
                txtINPUT.SelectAll()
                SCORE = SCORE + 50 'ADD POINTS TO SCORE
                lblWORD5.BackColor = SystemColors.InactiveCaptionText
                lblWORD5.ForeColor = Color.PaleGreen 'reset word colour scheme
                txtINPUT.BackColor = Color.WhiteSmoke 'reset input box colour, (may have been red if user got word wrong)


            ElseIf e.KeyCode = Keys.Enter And input = "BONUS" And BONUS = True Then
                'user must type bonus and hit enter to claim bonus
                BONUS = False 'reset boolean to false
                SCORE = SCORE + 300 'add 300 to score
                xBONUS = 500
                yBONUS = 250 'reset x and y positions
                lblBONUS.Visible = False 'hide lbl
                txtINPUT.SelectAll() 'highlight text
                txtINPUT.BackColor = Color.WhiteSmoke 'reset input box colour, (may have been red if user got word wrong)
            ElseIf e.KeyCode = Keys.Enter And input = "<3" And EXTRALIFE = True Then
                ' user must type "<3" (heart shape) to collect extra life
                EXTRALIFE = False 'boolean to false
                picLIFE.Visible = False 'hide icon
                xLIFE = 0
                yLIFE = 250 'reset x and y positions
                txtINPUT.SelectAll() 'highlight text
                LIFE = LIFE + 1 'add to lives, icons will be replaced as well
                SCORE = SCORE + 100 'add 100 points to score
                'score is also added so extra lives don't continue to appear
                'when 100 points is added, score no longer is a multiple of 750 so boolean=true is not triggered
                txtINPUT.BackColor = Color.WhiteSmoke 'change colour of input box
            ElseIf e.KeyCode = Keys.Enter And Not (input = lblWORD1.Text) And Not (input = lblWORD2.Text) And Not (input = lblWORD3.Text) And Not (input = lblWORD4.Text) And Not (input = lblWORD5.Text) Then
                'if user does not type correct word, text box is cleared
                'user can press enter to clear textboxes always
                txtINPUT.SelectAll() 'highlights text
                txtINPUT.BackColor = Color.Tomato 'textbox colour changes to red, indicating spelling is wrong
            End If
        End If


        lblSCORE.Text = SCORE 'display score in lbl
        txtINPUT.Text = input 'refer to textbox for variable: input
    End Sub

    Private Sub mnuEXIT_Click(sender As Object, e As EventArgs) Handles mnuEXIT.Click
        Dim areyousure As MsgBoxResult
        tmrWORDS.Stop() 'pause timer when user clicks exit mnu

        areyousure = MsgBox("ARE YOU SURE YOU WANT TO EXIT?", MsgBoxStyle.YesNo, "Godspeed")
        If areyousure = MsgBoxResult.Yes Then
            Application.Exit() 'closes app when user agrees to exit
        ElseIf areyousure = MsgBoxResult.No Then
            tmrWORDS.Start() 'play timer when user says no to exiting
            mnuPAUSE.Text = "PAUSE" 'replace text of pause mnubtn to pause
        End If
    End Sub

    Private Sub mnuPAUSE_Click(sender As Object, e As EventArgs) Handles mnuPAUSE.Click
        If PAUSE = False Then
            tmrWORDS.Stop() 'pause timer
            PAUSE = True 'makes boolean true 
            mnuPAUSE.Text = "PLAY" 'change text of mnu to play so user can clcik it again
            txtINPUT.Enabled = False 'disbale input box so user cant collect points while game is paused
            txtINPUT.Text = ""
        ElseIf PAUSE = True Then
            tmrWORDS.Start() 'play timer 
            PAUSE = False 'boolean resets to false
            mnuPAUSE.Text = "PAUSE" 'text returns to pause 
            txtINPUT.Enabled = True
            txtINPUT.Focus() 'user can type in textbox again and txtbox is at focus
        End If
    End Sub

   
    Private Sub mnuMAINMENU_Click(sender As Object, e As EventArgs) Handles mnuMAINMENU.Click
        FormStart.Show()
        Me.Hide() 'hide game form, show main menu
        btnGO.Visible = True 'make go button on game form visible
        'when user clicks button, variables will reset
        tmrWORDS.Stop() 'pause timer
        mnuFILE.Enabled = True
        mnuPAUSE.Text = "PAUSE"

        lblWORD1.BackColor = SystemColors.InactiveCaptionText
        lblWORD1.ForeColor = Color.PaleGreen

        lblWORD2.BackColor = SystemColors.InactiveCaptionText
        lblWORD2.ForeColor = Color.PaleGreen

        lblWORD3.BackColor = SystemColors.InactiveCaptionText       'reset colours of words to default
        lblWORD3.ForeColor = Color.PaleGreen

        lblWORD4.BackColor = SystemColors.InactiveCaptionText
        lblWORD4.ForeColor = Color.PaleGreen

        lblWORD5.BackColor = SystemColors.InactiveCaptionText
        lblWORD5.ForeColor = Color.PaleGreen

        heart1.Visible = True
        heart2.Visible = True 'make life icons visible
        heart3.Visible = True

        txtINPUT.Text = ""
        txtINPUT.Enabled = True
        lblSCORE.Text = "0"

        lblWORD1.Visible = False
        lblWORD2.Visible = False
        lblWORD3.Visible = False 'hide word labels
        lblWORD4.Visible = False
        lblWORD5.Visible = False
        btnGAMEOVER.Visible = False 'hide gameoer button
    End Sub

    Private Sub btnGAMEOVER_Click(sender As Object, e As EventArgs) Handles btnGAMEOVER.Click
        Dim RATING As String
        FormGAMEOVER.Show()
        Me.Hide() 'user clicks game over button go to game over form
        SCORE = lblSCORE.Text

        If SCORE > 0 And SCORE < 250 Then
            RATING = "STUDENT"
        ElseIf SCORE > 250 And SCORE < 750 Then
            RATING = "PROFESSOR"
        ElseIf SCORE > 750 And SCORE < 1500 Then
            RATING = "CUSTOMER SERVICE"
        ElseIf SCORE > 1500 And SCORE < 3000 Then
            RATING = "LIBRARIAN"                     'determine user rating based on score
        ElseIf SCORE > 3000 And SCORE < 6000 Then
            RATING = "LAWYER"
        ElseIf SCORE > 6000 And SCORE < 12000 Then
            RATING = "ACCOUNTANT"
        ElseIf SCORE > 12000 And SCORE < 20000 Then
            RATING = "MAD SCIENTIST"
        ElseIf SCORE > 20000 Then
            RATING = "LEGEND"
        ElseIf SCORE = 0 Then
            RATING = "LOSER"
        End If

        My.Forms.FormGAMEOVER.lblFINALSCORE.Text = SCORE 'refer to score from game form
        My.Forms.FormGAMEOVER.lblRATING.Text = RATING
    End Sub
End Class