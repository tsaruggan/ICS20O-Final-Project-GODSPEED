<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSETTINGS
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
        Me.lblDICT = New System.Windows.Forms.Label()
        Me.grpTHEME = New System.Windows.Forms.GroupBox()
        Me.radURBAN = New System.Windows.Forms.RadioButton()
        Me.radGALAXY = New System.Windows.Forms.RadioButton()
        Me.radUNDERWATER = New System.Windows.Forms.RadioButton()
        Me.radDUNGEON = New System.Windows.Forms.RadioButton()
        Me.radSTANDARD = New System.Windows.Forms.RadioButton()
        Me.grpDIFFICULTY = New System.Windows.Forms.GroupBox()
        Me.radEXTREME = New System.Windows.Forms.RadioButton()
        Me.radAVERAGE = New System.Windows.Forms.RadioButton()
        Me.btnSTART = New System.Windows.Forms.Button()
        Me.btnMENUback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpINSTRUCTIONS = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.iconLIFEinstructions = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.iconBONUSintrsuctions = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnINSTRUCTIONS = New System.Windows.Forms.Button()
        Me.btnBACKinstructions = New System.Windows.Forms.Button()
        Me.grpTHEME.SuspendLayout()
        Me.grpDIFFICULTY.SuspendLayout()
        Me.grpINSTRUCTIONS.SuspendLayout()
        CType(Me.iconLIFEinstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDICT
        '
        Me.lblDICT.AutoSize = True
        Me.lblDICT.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblDICT.Font = New System.Drawing.Font("Franklin Gothic Demi", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDICT.ForeColor = System.Drawing.Color.LightCoral
        Me.lblDICT.Location = New System.Drawing.Point(20, 34)
        Me.lblDICT.Name = "lblDICT"
        Me.lblDICT.Size = New System.Drawing.Size(200, 43)
        Me.lblDICT.TabIndex = 1
        Me.lblDICT.Text = "GODSPEED"
        '
        'grpTHEME
        '
        Me.grpTHEME.Controls.Add(Me.radURBAN)
        Me.grpTHEME.Controls.Add(Me.radGALAXY)
        Me.grpTHEME.Controls.Add(Me.radUNDERWATER)
        Me.grpTHEME.Controls.Add(Me.radDUNGEON)
        Me.grpTHEME.Controls.Add(Me.radSTANDARD)
        Me.grpTHEME.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTHEME.ForeColor = System.Drawing.Color.LightCoral
        Me.grpTHEME.Location = New System.Drawing.Point(32, 92)
        Me.grpTHEME.Name = "grpTHEME"
        Me.grpTHEME.Size = New System.Drawing.Size(182, 177)
        Me.grpTHEME.TabIndex = 3
        Me.grpTHEME.TabStop = False
        Me.grpTHEME.Text = "THEME"
        '
        'radURBAN
        '
        Me.radURBAN.AutoSize = True
        Me.radURBAN.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radURBAN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.radURBAN.Location = New System.Drawing.Point(13, 140)
        Me.radURBAN.Name = "radURBAN"
        Me.radURBAN.Size = New System.Drawing.Size(65, 24)
        Me.radURBAN.TabIndex = 4
        Me.radURBAN.TabStop = True
        Me.radURBAN.Text = "Urban"
        Me.radURBAN.UseVisualStyleBackColor = True
        '
        'radGALAXY
        '
        Me.radGALAXY.AutoSize = True
        Me.radGALAXY.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGALAXY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radGALAXY.Location = New System.Drawing.Point(13, 114)
        Me.radGALAXY.Name = "radGALAXY"
        Me.radGALAXY.Size = New System.Drawing.Size(69, 24)
        Me.radGALAXY.TabIndex = 3
        Me.radGALAXY.TabStop = True
        Me.radGALAXY.Text = "Galaxy"
        Me.radGALAXY.UseVisualStyleBackColor = True
        '
        'radUNDERWATER
        '
        Me.radUNDERWATER.AutoSize = True
        Me.radUNDERWATER.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUNDERWATER.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.radUNDERWATER.Location = New System.Drawing.Point(13, 84)
        Me.radUNDERWATER.Name = "radUNDERWATER"
        Me.radUNDERWATER.Size = New System.Drawing.Size(101, 24)
        Me.radUNDERWATER.TabIndex = 2
        Me.radUNDERWATER.TabStop = True
        Me.radUNDERWATER.Text = "Underwater"
        Me.radUNDERWATER.UseVisualStyleBackColor = True
        '
        'radDUNGEON
        '
        Me.radDUNGEON.AutoSize = True
        Me.radDUNGEON.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDUNGEON.ForeColor = System.Drawing.Color.Orange
        Me.radDUNGEON.Location = New System.Drawing.Point(13, 54)
        Me.radDUNGEON.Name = "radDUNGEON"
        Me.radDUNGEON.Size = New System.Drawing.Size(85, 24)
        Me.radDUNGEON.TabIndex = 1
        Me.radDUNGEON.TabStop = True
        Me.radDUNGEON.Text = "Dungeon"
        Me.radDUNGEON.UseVisualStyleBackColor = True
        '
        'radSTANDARD
        '
        Me.radSTANDARD.AutoSize = True
        Me.radSTANDARD.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSTANDARD.ForeColor = System.Drawing.Color.LawnGreen
        Me.radSTANDARD.Location = New System.Drawing.Point(13, 24)
        Me.radSTANDARD.Name = "radSTANDARD"
        Me.radSTANDARD.Size = New System.Drawing.Size(86, 24)
        Me.radSTANDARD.TabIndex = 0
        Me.radSTANDARD.TabStop = True
        Me.radSTANDARD.Text = "Standard"
        Me.radSTANDARD.UseVisualStyleBackColor = True
        '
        'grpDIFFICULTY
        '
        Me.grpDIFFICULTY.Controls.Add(Me.radEXTREME)
        Me.grpDIFFICULTY.Controls.Add(Me.radAVERAGE)
        Me.grpDIFFICULTY.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDIFFICULTY.ForeColor = System.Drawing.Color.LightCoral
        Me.grpDIFFICULTY.Location = New System.Drawing.Point(32, 286)
        Me.grpDIFFICULTY.Name = "grpDIFFICULTY"
        Me.grpDIFFICULTY.Size = New System.Drawing.Size(182, 97)
        Me.grpDIFFICULTY.TabIndex = 4
        Me.grpDIFFICULTY.TabStop = False
        Me.grpDIFFICULTY.Text = "DIFFICULTY"
        '
        'radEXTREME
        '
        Me.radEXTREME.AutoSize = True
        Me.radEXTREME.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEXTREME.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radEXTREME.Location = New System.Drawing.Point(13, 54)
        Me.radEXTREME.Name = "radEXTREME"
        Me.radEXTREME.Size = New System.Drawing.Size(88, 24)
        Me.radEXTREME.TabIndex = 1
        Me.radEXTREME.Text = "EXTREME"
        Me.radEXTREME.UseVisualStyleBackColor = True
        '
        'radAVERAGE
        '
        Me.radAVERAGE.AutoSize = True
        Me.radAVERAGE.Checked = True
        Me.radAVERAGE.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAVERAGE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radAVERAGE.Location = New System.Drawing.Point(13, 24)
        Me.radAVERAGE.Name = "radAVERAGE"
        Me.radAVERAGE.Size = New System.Drawing.Size(87, 24)
        Me.radAVERAGE.TabIndex = 0
        Me.radAVERAGE.TabStop = True
        Me.radAVERAGE.Text = "AVERAGE"
        Me.radAVERAGE.UseVisualStyleBackColor = True
        '
        'btnSTART
        '
        Me.btnSTART.BackColor = System.Drawing.Color.Gray
        Me.btnSTART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSTART.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSTART.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSTART.Location = New System.Drawing.Point(243, 449)
        Me.btnSTART.Name = "btnSTART"
        Me.btnSTART.Size = New System.Drawing.Size(208, 37)
        Me.btnSTART.TabIndex = 5
        Me.btnSTART.Text = "START"
        Me.btnSTART.UseVisualStyleBackColor = False
        '
        'btnMENUback
        '
        Me.btnMENUback.BackColor = System.Drawing.Color.Gray
        Me.btnMENUback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMENUback.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMENUback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMENUback.Location = New System.Drawing.Point(12, 449)
        Me.btnMENUback.Name = "btnMENUback"
        Me.btnMENUback.Size = New System.Drawing.Size(208, 37)
        Me.btnMENUback.TabIndex = 6
        Me.btnMENUback.Text = "BACK"
        Me.btnMENUback.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "INSTRUCTIONS"
        '
        'grpINSTRUCTIONS
        '
        Me.grpINSTRUCTIONS.Controls.Add(Me.Label6)
        Me.grpINSTRUCTIONS.Controls.Add(Me.Label5)
        Me.grpINSTRUCTIONS.Controls.Add(Me.iconLIFEinstructions)
        Me.grpINSTRUCTIONS.Controls.Add(Me.Label4)
        Me.grpINSTRUCTIONS.Controls.Add(Me.iconBONUSintrsuctions)
        Me.grpINSTRUCTIONS.Controls.Add(Me.Label3)
        Me.grpINSTRUCTIONS.Controls.Add(Me.Label2)
        Me.grpINSTRUCTIONS.Controls.Add(Me.Label1)
        Me.grpINSTRUCTIONS.Location = New System.Drawing.Point(12, 91)
        Me.grpINSTRUCTIONS.Name = "grpINSTRUCTIONS"
        Me.grpINSTRUCTIONS.Size = New System.Drawing.Size(439, 352)
        Me.grpINSTRUCTIONS.TabIndex = 8
        Me.grpINSTRUCTIONS.TabStop = False
        Me.grpINSTRUCTIONS.Text = " "
        Me.grpINSTRUCTIONS.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(392, 63)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "BEWARE, IF YOU MISS A WORD, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "YOU WILL LOSE A LIFE AND THE WORD WILL REAPPEAR." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & _
    "ET AS MANY POINTS AS YOU CAN."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 42)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "LOOK ALIVE." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GODSPEED"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'iconLIFEinstructions
        '
        Me.iconLIFEinstructions.BackColor = System.Drawing.Color.Transparent
        Me.iconLIFEinstructions.BackgroundImage = Global.FinalProject_SThiruchelvan.My.Resources.Resources.FLYING_HEART
        Me.iconLIFEinstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.iconLIFEinstructions.Location = New System.Drawing.Point(128, 168)
        Me.iconLIFEinstructions.Name = "iconLIFEinstructions"
        Me.iconLIFEinstructions.Size = New System.Drawing.Size(22, 21)
        Me.iconLIFEinstructions.TabIndex = 16
        Me.iconLIFEinstructions.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(286, 42)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "WHEN YOU SEE           TYPE ""<3"" TO GET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BACK A LOST LIFE AND GET 100 POINTS."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'iconBONUSintrsuctions
        '
        Me.iconBONUSintrsuctions.AutoSize = True
        Me.iconBONUSintrsuctions.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.iconBONUSintrsuctions.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconBONUSintrsuctions.Location = New System.Drawing.Point(124, 115)
        Me.iconBONUSintrsuctions.Name = "iconBONUSintrsuctions"
        Me.iconBONUSintrsuctions.Size = New System.Drawing.Size(59, 21)
        Me.iconBONUSintrsuctions.TabIndex = 14
        Me.iconBONUSintrsuctions.Text = "BONUS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 42)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "WHEN YOU SEE                  TYPE ""BONUS""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TO GET AN EXTRA 300 POINTS."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 63)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "TYPE THE WORDS THAT FLY ACROSS THE SCREEN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND HIT ENTER BEFORE THEY REACH THE ED" & _
    "GE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TO MAKE THEM DISAPPEAR AND GET 50 POINTS."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnINSTRUCTIONS
        '
        Me.btnINSTRUCTIONS.BackColor = System.Drawing.Color.DarkGray
        Me.btnINSTRUCTIONS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnINSTRUCTIONS.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINSTRUCTIONS.ForeColor = System.Drawing.Color.Black
        Me.btnINSTRUCTIONS.Location = New System.Drawing.Point(243, 34)
        Me.btnINSTRUCTIONS.Name = "btnINSTRUCTIONS"
        Me.btnINSTRUCTIONS.Size = New System.Drawing.Size(188, 43)
        Me.btnINSTRUCTIONS.TabIndex = 9
        Me.btnINSTRUCTIONS.Text = "INSTRUCTIONS"
        Me.btnINSTRUCTIONS.UseVisualStyleBackColor = False
        '
        'btnBACKinstructions
        '
        Me.btnBACKinstructions.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBACKinstructions.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACKinstructions.ForeColor = System.Drawing.Color.White
        Me.btnBACKinstructions.Location = New System.Drawing.Point(12, 454)
        Me.btnBACKinstructions.Name = "btnBACKinstructions"
        Me.btnBACKinstructions.Size = New System.Drawing.Size(58, 28)
        Me.btnBACKinstructions.TabIndex = 10
        Me.btnBACKinstructions.Text = "BACK"
        Me.btnBACKinstructions.UseVisualStyleBackColor = False
        Me.btnBACKinstructions.Visible = False
        '
        'FormSETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(463, 501)
        Me.Controls.Add(Me.btnBACKinstructions)
        Me.Controls.Add(Me.btnINSTRUCTIONS)
        Me.Controls.Add(Me.grpINSTRUCTIONS)
        Me.Controls.Add(Me.btnMENUback)
        Me.Controls.Add(Me.btnSTART)
        Me.Controls.Add(Me.grpDIFFICULTY)
        Me.Controls.Add(Me.grpTHEME)
        Me.Controls.Add(Me.lblDICT)
        Me.Name = "FormSETTINGS"
        Me.Text = "Godspeed"
        Me.grpTHEME.ResumeLayout(False)
        Me.grpTHEME.PerformLayout()
        Me.grpDIFFICULTY.ResumeLayout(False)
        Me.grpDIFFICULTY.PerformLayout()
        Me.grpINSTRUCTIONS.ResumeLayout(False)
        Me.grpINSTRUCTIONS.PerformLayout()
        CType(Me.iconLIFEinstructions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDICT As System.Windows.Forms.Label
    Friend WithEvents grpTHEME As System.Windows.Forms.GroupBox
    Friend WithEvents radUNDERWATER As System.Windows.Forms.RadioButton
    Friend WithEvents radDUNGEON As System.Windows.Forms.RadioButton
    Friend WithEvents radSTANDARD As System.Windows.Forms.RadioButton
    Friend WithEvents radGALAXY As System.Windows.Forms.RadioButton
    Friend WithEvents radURBAN As System.Windows.Forms.RadioButton
    Friend WithEvents grpDIFFICULTY As System.Windows.Forms.GroupBox
    Friend WithEvents radEXTREME As System.Windows.Forms.RadioButton
    Friend WithEvents radAVERAGE As System.Windows.Forms.RadioButton
    Friend WithEvents btnSTART As System.Windows.Forms.Button
    Friend WithEvents btnMENUback As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpINSTRUCTIONS As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents iconBONUSintrsuctions As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents iconLIFEinstructions As System.Windows.Forms.PictureBox
    Friend WithEvents btnINSTRUCTIONS As System.Windows.Forms.Button
    Friend WithEvents btnBACKinstructions As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
