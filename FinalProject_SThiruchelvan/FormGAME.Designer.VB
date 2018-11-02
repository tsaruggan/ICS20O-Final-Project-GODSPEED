<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGAME
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
        Me.components = New System.ComponentModel.Container()
        Me.mnuFILE = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPAUSE = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMAINMENU = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEXIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtINPUT = New System.Windows.Forms.TextBox()
        Me.picBORDER = New System.Windows.Forms.PictureBox()
        Me.heart1 = New System.Windows.Forms.PictureBox()
        Me.heart2 = New System.Windows.Forms.PictureBox()
        Me.heart3 = New System.Windows.Forms.PictureBox()
        Me.btnGO = New System.Windows.Forms.Button()
        Me.tmrWORDS = New System.Windows.Forms.Timer(Me.components)
        Me.lblWORD1 = New System.Windows.Forms.Label()
        Me.lblWORD2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSCORE = New System.Windows.Forms.Label()
        Me.lblWORD3 = New System.Windows.Forms.Label()
        Me.lblWORD4 = New System.Windows.Forms.Label()
        Me.lblWORD5 = New System.Windows.Forms.Label()
        Me.lblBONUS = New System.Windows.Forms.Label()
        Me.picLIFE = New System.Windows.Forms.PictureBox()
        Me.btnGAMEOVER = New System.Windows.Forms.Button()
        Me.mnuFILE.SuspendLayout()
        CType(Me.picBORDER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picLIFE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuFILE
        '
        Me.mnuFILE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.mnuFILE.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuFILE.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem})
        Me.mnuFILE.Location = New System.Drawing.Point(0, 0)
        Me.mnuFILE.Name = "mnuFILE"
        Me.mnuFILE.Size = New System.Drawing.Size(554, 28)
        Me.mnuFILE.TabIndex = 0
        Me.mnuFILE.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPAUSE, Me.mnuMAINMENU, Me.mnuEXIT})
        Me.FILEToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'mnuPAUSE
        '
        Me.mnuPAUSE.Name = "mnuPAUSE"
        Me.mnuPAUSE.Size = New System.Drawing.Size(160, 24)
        Me.mnuPAUSE.Text = "PAUSE"
        '
        'mnuMAINMENU
        '
        Me.mnuMAINMENU.Name = "mnuMAINMENU"
        Me.mnuMAINMENU.Size = New System.Drawing.Size(160, 24)
        Me.mnuMAINMENU.Text = "MAIN MENU"
        '
        'mnuEXIT
        '
        Me.mnuEXIT.Name = "mnuEXIT"
        Me.mnuEXIT.Size = New System.Drawing.Size(160, 24)
        Me.mnuEXIT.Text = "EXIT"
        '
        'txtINPUT
        '
        Me.txtINPUT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtINPUT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtINPUT.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtINPUT.Location = New System.Drawing.Point(173, 312)
        Me.txtINPUT.Name = "txtINPUT"
        Me.txtINPUT.Size = New System.Drawing.Size(216, 26)
        Me.txtINPUT.TabIndex = 2
        Me.txtINPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picBORDER
        '
        Me.picBORDER.BackColor = System.Drawing.Color.CadetBlue
        Me.picBORDER.Location = New System.Drawing.Point(0, 285)
        Me.picBORDER.Name = "picBORDER"
        Me.picBORDER.Size = New System.Drawing.Size(554, 74)
        Me.picBORDER.TabIndex = 1
        Me.picBORDER.TabStop = False
        '
        'heart1
        '
        Me.heart1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.heart1.BackgroundImage = Global.FinalProject_SThiruchelvan.My.Resources.Resources.heart
        Me.heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.heart1.Location = New System.Drawing.Point(422, 307)
        Me.heart1.Name = "heart1"
        Me.heart1.Size = New System.Drawing.Size(32, 31)
        Me.heart1.TabIndex = 3
        Me.heart1.TabStop = False
        '
        'heart2
        '
        Me.heart2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.heart2.BackgroundImage = Global.FinalProject_SThiruchelvan.My.Resources.Resources.heart
        Me.heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.heart2.Location = New System.Drawing.Point(460, 307)
        Me.heart2.Name = "heart2"
        Me.heart2.Size = New System.Drawing.Size(32, 31)
        Me.heart2.TabIndex = 4
        Me.heart2.TabStop = False
        '
        'heart3
        '
        Me.heart3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.heart3.BackgroundImage = Global.FinalProject_SThiruchelvan.My.Resources.Resources.heart
        Me.heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.heart3.Location = New System.Drawing.Point(498, 307)
        Me.heart3.Name = "heart3"
        Me.heart3.Size = New System.Drawing.Size(32, 31)
        Me.heart3.TabIndex = 5
        Me.heart3.TabStop = False
        '
        'btnGO
        '
        Me.btnGO.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGO.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGO.ForeColor = System.Drawing.Color.LightCoral
        Me.btnGO.Location = New System.Drawing.Point(227, 116)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(102, 72)
        Me.btnGO.TabIndex = 6
        Me.btnGO.Text = "GO"
        Me.btnGO.UseVisualStyleBackColor = False
        '
        'tmrWORDS
        '
        Me.tmrWORDS.Interval = 400
        '
        'lblWORD1
        '
        Me.lblWORD1.AutoSize = True
        Me.lblWORD1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblWORD1.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWORD1.ForeColor = System.Drawing.Color.White
        Me.lblWORD1.Location = New System.Drawing.Point(0, 50)
        Me.lblWORD1.Name = "lblWORD1"
        Me.lblWORD1.Size = New System.Drawing.Size(60, 20)
        Me.lblWORD1.TabIndex = 7
        Me.lblWORD1.Text = "WORD1"
        Me.lblWORD1.Visible = False
        '
        'lblWORD2
        '
        Me.lblWORD2.AutoSize = True
        Me.lblWORD2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblWORD2.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWORD2.ForeColor = System.Drawing.Color.White
        Me.lblWORD2.Location = New System.Drawing.Point(0, 100)
        Me.lblWORD2.Name = "lblWORD2"
        Me.lblWORD2.Size = New System.Drawing.Size(60, 20)
        Me.lblWORD2.TabIndex = 8
        Me.lblWORD2.Text = "WORD2"
        Me.lblWORD2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.lblSCORE)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightCoral
        Me.GroupBox1.Location = New System.Drawing.Point(12, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 46)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SCORE"
        '
        'lblSCORE
        '
        Me.lblSCORE.AutoSize = True
        Me.lblSCORE.Location = New System.Drawing.Point(6, 18)
        Me.lblSCORE.Name = "lblSCORE"
        Me.lblSCORE.Size = New System.Drawing.Size(16, 17)
        Me.lblSCORE.TabIndex = 0
        Me.lblSCORE.Text = "0"
        Me.lblSCORE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWORD3
        '
        Me.lblWORD3.AutoSize = True
        Me.lblWORD3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblWORD3.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWORD3.ForeColor = System.Drawing.Color.White
        Me.lblWORD3.Location = New System.Drawing.Point(0, 150)
        Me.lblWORD3.Name = "lblWORD3"
        Me.lblWORD3.Size = New System.Drawing.Size(60, 20)
        Me.lblWORD3.TabIndex = 10
        Me.lblWORD3.Text = "WORD3"
        Me.lblWORD3.Visible = False
        '
        'lblWORD4
        '
        Me.lblWORD4.AutoSize = True
        Me.lblWORD4.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblWORD4.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWORD4.ForeColor = System.Drawing.Color.White
        Me.lblWORD4.Location = New System.Drawing.Point(0, 200)
        Me.lblWORD4.Name = "lblWORD4"
        Me.lblWORD4.Size = New System.Drawing.Size(60, 20)
        Me.lblWORD4.TabIndex = 11
        Me.lblWORD4.Text = "WORD4"
        Me.lblWORD4.Visible = False
        '
        'lblWORD5
        '
        Me.lblWORD5.AutoSize = True
        Me.lblWORD5.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblWORD5.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWORD5.ForeColor = System.Drawing.Color.White
        Me.lblWORD5.Location = New System.Drawing.Point(0, 250)
        Me.lblWORD5.Name = "lblWORD5"
        Me.lblWORD5.Size = New System.Drawing.Size(60, 20)
        Me.lblWORD5.TabIndex = 12
        Me.lblWORD5.Text = "WORD5"
        Me.lblWORD5.Visible = False
        '
        'lblBONUS
        '
        Me.lblBONUS.AutoSize = True
        Me.lblBONUS.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblBONUS.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBONUS.Location = New System.Drawing.Point(500, 250)
        Me.lblBONUS.Name = "lblBONUS"
        Me.lblBONUS.Size = New System.Drawing.Size(69, 24)
        Me.lblBONUS.TabIndex = 13
        Me.lblBONUS.Text = "BONUS"
        Me.lblBONUS.Visible = False
        '
        'picLIFE
        '
        Me.picLIFE.BackColor = System.Drawing.Color.Transparent
        Me.picLIFE.BackgroundImage = Global.FinalProject_SThiruchelvan.My.Resources.Resources.FLYING_HEART
        Me.picLIFE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLIFE.Location = New System.Drawing.Point(0, 250)
        Me.picLIFE.Name = "picLIFE"
        Me.picLIFE.Size = New System.Drawing.Size(32, 31)
        Me.picLIFE.TabIndex = 14
        Me.picLIFE.TabStop = False
        Me.picLIFE.Visible = False
        '
        'btnGAMEOVER
        '
        Me.btnGAMEOVER.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnGAMEOVER.Font = New System.Drawing.Font("Franklin Gothic Demi", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGAMEOVER.ForeColor = System.Drawing.Color.LightCoral
        Me.btnGAMEOVER.Location = New System.Drawing.Point(180, 0)
        Me.btnGAMEOVER.Name = "btnGAMEOVER"
        Me.btnGAMEOVER.Size = New System.Drawing.Size(192, 51)
        Me.btnGAMEOVER.TabIndex = 16
        Me.btnGAMEOVER.Text = "GAME OVER"
        Me.btnGAMEOVER.UseVisualStyleBackColor = False
        Me.btnGAMEOVER.Visible = False
        '
        'FormGAME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.FinalProject_SThiruchelvan.My.Resources.Resources.URBAN
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 356)
        Me.Controls.Add(Me.btnGAMEOVER)
        Me.Controls.Add(Me.picLIFE)
        Me.Controls.Add(Me.lblBONUS)
        Me.Controls.Add(Me.lblWORD5)
        Me.Controls.Add(Me.lblWORD4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblWORD2)
        Me.Controls.Add(Me.lblWORD1)
        Me.Controls.Add(Me.btnGO)
        Me.Controls.Add(Me.heart3)
        Me.Controls.Add(Me.heart2)
        Me.Controls.Add(Me.heart1)
        Me.Controls.Add(Me.txtINPUT)
        Me.Controls.Add(Me.picBORDER)
        Me.Controls.Add(Me.mnuFILE)
        Me.Controls.Add(Me.lblWORD3)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.mnuFILE
        Me.Name = "FormGAME"
        Me.Text = "Godspeed"
        Me.mnuFILE.ResumeLayout(False)
        Me.mnuFILE.PerformLayout()
        CType(Me.picBORDER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picLIFE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuFILE As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picBORDER As System.Windows.Forms.PictureBox
    Friend WithEvents txtINPUT As System.Windows.Forms.TextBox
    Friend WithEvents heart1 As System.Windows.Forms.PictureBox
    Friend WithEvents heart2 As System.Windows.Forms.PictureBox
    Friend WithEvents heart3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents tmrWORDS As System.Windows.Forms.Timer
    Friend WithEvents lblWORD1 As System.Windows.Forms.Label
    Friend WithEvents lblWORD2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSCORE As System.Windows.Forms.Label
    Friend WithEvents lblWORD3 As System.Windows.Forms.Label
    Friend WithEvents lblWORD4 As System.Windows.Forms.Label
    Friend WithEvents lblWORD5 As System.Windows.Forms.Label
    Friend WithEvents lblBONUS As System.Windows.Forms.Label
    Friend WithEvents mnuEXIT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picLIFE As System.Windows.Forms.PictureBox
    Friend WithEvents mnuPAUSE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMAINMENU As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGAMEOVER As System.Windows.Forms.Button
End Class
