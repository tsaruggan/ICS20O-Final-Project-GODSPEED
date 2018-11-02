<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGAMEOVER
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
        Me.lblTITLEgameover = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFINALSCORE = New System.Windows.Forms.Label()
        Me.btnMAINMENU = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRATING = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTITLEgameover
        '
        Me.lblTITLEgameover.AutoSize = True
        Me.lblTITLEgameover.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblTITLEgameover.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTITLEgameover.ForeColor = System.Drawing.Color.LightCoral
        Me.lblTITLEgameover.Location = New System.Drawing.Point(109, 9)
        Me.lblTITLEgameover.Name = "lblTITLEgameover"
        Me.lblTITLEgameover.Size = New System.Drawing.Size(191, 41)
        Me.lblTITLEgameover.TabIndex = 1
        Me.lblTITLEgameover.Text = "GODSPEED"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(145, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Game Over!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(94, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Your score is:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFINALSCORE
        '
        Me.lblFINALSCORE.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblFINALSCORE.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFINALSCORE.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFINALSCORE.Location = New System.Drawing.Point(207, 104)
        Me.lblFINALSCORE.Name = "lblFINALSCORE"
        Me.lblFINALSCORE.Size = New System.Drawing.Size(103, 24)
        Me.lblFINALSCORE.TabIndex = 4
        Me.lblFINALSCORE.Text = "SCORE"
        Me.lblFINALSCORE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMAINMENU
        '
        Me.btnMAINMENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMAINMENU.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMAINMENU.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMAINMENU.Location = New System.Drawing.Point(98, 197)
        Me.btnMAINMENU.Name = "btnMAINMENU"
        Me.btnMAINMENU.Size = New System.Drawing.Size(103, 28)
        Me.btnMAINMENU.TabIndex = 5
        Me.btnMAINMENU.Text = "MAIN MENU"
        Me.btnMAINMENU.UseVisualStyleBackColor = True
        '
        'btnEXIT
        '
        Me.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEXIT.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEXIT.Location = New System.Drawing.Point(207, 197)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(103, 28)
        Me.btnEXIT.TabIndex = 6
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(150, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "RATING:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRATING
        '
        Me.lblRATING.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblRATING.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRATING.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRATING.Location = New System.Drawing.Point(101, 163)
        Me.lblRATING.Name = "lblRATING"
        Me.lblRATING.Size = New System.Drawing.Size(209, 24)
        Me.lblRATING.TabIndex = 8
        Me.lblRATING.Text = "lblRATING"
        Me.lblRATING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormGAMEOVER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(403, 237)
        Me.Controls.Add(Me.lblRATING)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.btnMAINMENU)
        Me.Controls.Add(Me.lblFINALSCORE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTITLEgameover)
        Me.Name = "FormGAMEOVER"
        Me.Text = "Godspeed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTITLEgameover As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFINALSCORE As System.Windows.Forms.Label
    Friend WithEvents btnMAINMENU As System.Windows.Forms.Button
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRATING As System.Windows.Forms.Label
End Class
