<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptions))
        RbtnFacile = New RadioButton()
        pnlOp1 = New Panel()
        RbtnDifficile = New RadioButton()
        RbtnMoyen = New RadioButton()
        lblD = New Label()
        lblL = New Label()
        pnlOp2 = New Panel()
        RbtnL3 = New RadioButton()
        RbtnL2 = New RadioButton()
        RbtnL1 = New RadioButton()
        lblC = New Label()
        pnlOp3 = New Panel()
        RbtnT5 = New RadioButton()
        RbtnT4 = New RadioButton()
        RbtnT3 = New RadioButton()
        RbtnT2 = New RadioButton()
        RbtnT1 = New RadioButton()
        btnValidation = New Button()
        pnlOp1.SuspendLayout()
        pnlOp2.SuspendLayout()
        pnlOp3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RbtnFacile
        ' 
        RbtnFacile.AutoSize = True
        RbtnFacile.Font = New Font("Baskerville Old Face", 9F)
        RbtnFacile.Location = New Point(23, 25)
        RbtnFacile.Margin = New Padding(5, 6, 5, 6)
        RbtnFacile.Name = "RbtnFacile"
        RbtnFacile.Size = New Size(90, 25)
        RbtnFacile.TabIndex = 0
        RbtnFacile.Text = "Facile +"
        RbtnFacile.UseVisualStyleBackColor = True
        ' 
        ' pnlOp1
        ' 
        pnlOp1.BackColor = Color.LightGray
        pnlOp1.BackgroundImageLayout = ImageLayout.Center
        pnlOp1.BorderStyle = BorderStyle.Fixed3D
        pnlOp1.Controls.Add(RbtnDifficile)
        pnlOp1.Controls.Add(RbtnMoyen)
        pnlOp1.Controls.Add(RbtnFacile)
        pnlOp1.Font = New Font("Baskerville Old Face", 9F, FontStyle.Bold)
        pnlOp1.Location = New Point(31, 75)
        pnlOp1.Margin = New Padding(5, 6, 5, 6)
        pnlOp1.Name = "pnlOp1"
        pnlOp1.Size = New Size(257, 209)
        pnlOp1.TabIndex = 1
        ' 
        ' RbtnDifficile
        ' 
        RbtnDifficile.AutoSize = True
        RbtnDifficile.Font = New Font("Baskerville Old Face", 9F)
        RbtnDifficile.Location = New Point(23, 156)
        RbtnDifficile.Margin = New Padding(5, 6, 5, 6)
        RbtnDifficile.Name = "RbtnDifficile"
        RbtnDifficile.Size = New Size(122, 25)
        RbtnDifficile.TabIndex = 2
        RbtnDifficile.Text = "Difficile +++"
        RbtnDifficile.UseVisualStyleBackColor = True
        ' 
        ' RbtnMoyen
        ' 
        RbtnMoyen.AutoSize = True
        RbtnMoyen.Font = New Font("Baskerville Old Face", 9F)
        RbtnMoyen.Location = New Point(23, 91)
        RbtnMoyen.Margin = New Padding(5, 6, 5, 6)
        RbtnMoyen.Name = "RbtnMoyen"
        RbtnMoyen.Size = New Size(108, 25)
        RbtnMoyen.TabIndex = 3
        RbtnMoyen.Text = "Moyen ++"
        RbtnMoyen.UseVisualStyleBackColor = True
        ' 
        ' lblD
        ' 
        lblD.AutoSize = True
        lblD.BackColor = Color.Transparent
        lblD.Font = New Font("Baskerville Old Face", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblD.Location = New Point(31, 33)
        lblD.Margin = New Padding(5, 0, 5, 0)
        lblD.Name = "lblD"
        lblD.Size = New Size(208, 21)
        lblD.TabIndex = 2
        lblD.Text = "Sélection de la difficulté:"
        ' 
        ' lblL
        ' 
        lblL.AutoSize = True
        lblL.BackColor = Color.Transparent
        lblL.Font = New Font("Baskerville Old Face", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblL.Location = New Point(31, 317)
        lblL.Margin = New Padding(5, 0, 5, 0)
        lblL.Name = "lblL"
        lblL.Size = New Size(169, 21)
        lblL.TabIndex = 4
        lblL.Text = "Sélection de langue:"
        ' 
        ' pnlOp2
        ' 
        pnlOp2.BackColor = Color.LightGray
        pnlOp2.BackgroundImageLayout = ImageLayout.Center
        pnlOp2.BorderStyle = BorderStyle.Fixed3D
        pnlOp2.Controls.Add(RbtnL3)
        pnlOp2.Controls.Add(RbtnL2)
        pnlOp2.Controls.Add(RbtnL1)
        pnlOp2.Font = New Font("Baskerville Old Face", 9F, FontStyle.Bold)
        pnlOp2.Location = New Point(31, 350)
        pnlOp2.Margin = New Padding(5, 6, 5, 6)
        pnlOp2.Name = "pnlOp2"
        pnlOp2.Size = New Size(257, 226)
        pnlOp2.TabIndex = 3
        ' 
        ' RbtnL3
        ' 
        RbtnL3.AutoSize = True
        RbtnL3.Font = New Font("Baskerville Old Face", 9F)
        RbtnL3.Location = New Point(23, 162)
        RbtnL3.Margin = New Padding(5, 6, 5, 6)
        RbtnL3.Name = "RbtnL3"
        RbtnL3.Size = New Size(83, 25)
        RbtnL3.TabIndex = 2
        RbtnL3.TabStop = True
        RbtnL3.Text = "chinois"
        RbtnL3.UseVisualStyleBackColor = True
        ' 
        ' RbtnL2
        ' 
        RbtnL2.AutoSize = True
        RbtnL2.Font = New Font("Baskerville Old Face", 9F)
        RbtnL2.Location = New Point(23, 98)
        RbtnL2.Margin = New Padding(5, 6, 5, 6)
        RbtnL2.Name = "RbtnL2"
        RbtnL2.Size = New Size(81, 25)
        RbtnL2.TabIndex = 3
        RbtnL2.TabStop = True
        RbtnL2.Text = "anglais"
        RbtnL2.UseVisualStyleBackColor = True
        ' 
        ' RbtnL1
        ' 
        RbtnL1.AutoSize = True
        RbtnL1.Font = New Font("Baskerville Old Face", 9F)
        RbtnL1.Location = New Point(23, 32)
        RbtnL1.Margin = New Padding(5, 6, 5, 6)
        RbtnL1.Name = "RbtnL1"
        RbtnL1.Size = New Size(88, 25)
        RbtnL1.TabIndex = 0
        RbtnL1.TabStop = True
        RbtnL1.Text = "francais"
        RbtnL1.UseVisualStyleBackColor = True
        ' 
        ' lblC
        ' 
        lblC.AutoSize = True
        lblC.BackColor = Color.Transparent
        lblC.Font = New Font("Baskerville Old Face", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblC.Location = New Point(335, 133)
        lblC.Margin = New Padding(5, 0, 5, 0)
        lblC.Name = "lblC"
        lblC.Size = New Size(188, 21)
        lblC.TabIndex = 6
        lblC.Text = "Style visuel des cartes:"
        ' 
        ' pnlOp3
        ' 
        pnlOp3.AutoSize = True
        pnlOp3.BackColor = Color.LightGray
        pnlOp3.BackgroundImageLayout = ImageLayout.Center
        pnlOp3.BorderStyle = BorderStyle.Fixed3D
        pnlOp3.Controls.Add(RbtnT5)
        pnlOp3.Controls.Add(RbtnT4)
        pnlOp3.Controls.Add(RbtnT3)
        pnlOp3.Controls.Add(RbtnT2)
        pnlOp3.Controls.Add(RbtnT1)
        pnlOp3.Font = New Font("Baskerville Old Face", 9F, FontStyle.Bold)
        pnlOp3.Location = New Point(335, 166)
        pnlOp3.Margin = New Padding(5, 6, 5, 6)
        pnlOp3.Name = "pnlOp3"
        pnlOp3.Size = New Size(310, 361)
        pnlOp3.TabIndex = 5
        ' 
        ' RbtnT5
        ' 
        RbtnT5.AutoSize = True
        RbtnT5.Font = New Font("Baskerville Old Face", 9F)
        RbtnT5.Location = New Point(24, 292)
        RbtnT5.Margin = New Padding(5, 6, 5, 6)
        RbtnT5.Name = "RbtnT5"
        RbtnT5.Size = New Size(136, 25)
        RbtnT5.TabIndex = 8
        RbtnT5.TabStop = True
        RbtnT5.Text = "Jujutsu Kaisen"
        RbtnT5.UseVisualStyleBackColor = True
        ' 
        ' RbtnT4
        ' 
        RbtnT4.AutoSize = True
        RbtnT4.Font = New Font("Baskerville Old Face", 9F)
        RbtnT4.Location = New Point(24, 232)
        RbtnT4.Margin = New Padding(5, 6, 5, 6)
        RbtnT4.Name = "RbtnT4"
        RbtnT4.Size = New Size(207, 25)
        RbtnT4.TabIndex = 9
        RbtnT4.TabStop = True
        RbtnT4.Text = "JoJo's Bizarre Adventure"
        RbtnT4.UseVisualStyleBackColor = True
        ' 
        ' RbtnT3
        ' 
        RbtnT3.AutoSize = True
        RbtnT3.Font = New Font("Baskerville Old Face", 9F)
        RbtnT3.Location = New Point(24, 171)
        RbtnT3.Margin = New Padding(5, 6, 5, 6)
        RbtnT3.Name = "RbtnT3"
        RbtnT3.Size = New Size(67, 25)
        RbtnT3.TabIndex = 2
        RbtnT3.TabStop = True
        RbtnT3.Text = "Uno"
        RbtnT3.UseVisualStyleBackColor = True
        ' 
        ' RbtnT2
        ' 
        RbtnT2.AutoSize = True
        RbtnT2.Font = New Font("Baskerville Old Face", 9F)
        RbtnT2.Location = New Point(24, 106)
        RbtnT2.Margin = New Padding(5, 6, 5, 6)
        RbtnT2.Name = "RbtnT2"
        RbtnT2.Size = New Size(109, 25)
        RbtnT2.TabIndex = 3
        RbtnT2.TabStop = True
        RbtnT2.Text = "Link Click"
        RbtnT2.UseVisualStyleBackColor = True
        ' 
        ' RbtnT1
        ' 
        RbtnT1.AutoSize = True
        RbtnT1.Font = New Font("Baskerville Old Face", 9F)
        RbtnT1.Location = New Point(24, 39)
        RbtnT1.Margin = New Padding(5, 6, 5, 6)
        RbtnT1.Name = "RbtnT1"
        RbtnT1.Size = New Size(153, 25)
        RbtnT1.TabIndex = 0
        RbtnT1.TabStop = True
        RbtnT1.Text = "Cartes Pokémon"
        RbtnT1.UseVisualStyleBackColor = True
        ' 
        ' btnValidation
        ' 
        btnValidation.BackColor = Color.LightGray
        btnValidation.BackgroundImageLayout = ImageLayout.Center
        btnValidation.Cursor = Cursors.Hand
        btnValidation.FlatAppearance.BorderColor = Color.Black
        btnValidation.FlatAppearance.BorderSize = 2
        btnValidation.FlatAppearance.MouseDownBackColor = Color.Black
        btnValidation.FlatAppearance.MouseOverBackColor = Color.White
        btnValidation.FlatStyle = FlatStyle.Flat
        btnValidation.Font = New Font("Felix Titling", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnValidation.Location = New Point(228, 607)
        btnValidation.Margin = New Padding(5, 6, 5, 6)
        btnValidation.Name = "btnValidation"
        btnValidation.Size = New Size(188, 62)
        btnValidation.TabIndex = 7
        btnValidation.Text = "Valider"
        btnValidation.UseVisualStyleBackColor = False
        ' 
        ' FormOptions
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.ControlLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(666, 700)
        Controls.Add(btnValidation)
        Controls.Add(lblC)
        Controls.Add(pnlOp3)
        Controls.Add(lblD)
        Controls.Add(lblL)
        Controls.Add(pnlOp2)
        Controls.Add(pnlOp1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 6, 5, 6)
        Name = "FormOptions"
        Text = "Options"
        pnlOp1.ResumeLayout(False)
        pnlOp1.PerformLayout()
        pnlOp2.ResumeLayout(False)
        pnlOp2.PerformLayout()
        pnlOp3.ResumeLayout(False)
        pnlOp3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RbtnFacile As RadioButton
    Friend WithEvents pnlOp1 As Panel
    Friend WithEvents RbtnDifficile As RadioButton
    Friend WithEvents RbtnMoyen As RadioButton
    Friend WithEvents lblD As Label
    Friend WithEvents lblL As Label
    Friend WithEvents pnlOp2 As Panel
    Friend WithEvents RbtnL3 As RadioButton
    Friend WithEvents RbtnL2 As RadioButton
    Friend WithEvents RbtnL1 As RadioButton
    Friend WithEvents lblC As Label
    Friend WithEvents pnlOp3 As Panel
    Friend WithEvents RbtnT3 As RadioButton
    Friend WithEvents RbtnT2 As RadioButton
    Friend WithEvents RbtnT1 As RadioButton
    Friend WithEvents btnValidation As Button
    Friend WithEvents RbtnT5 As RadioButton
    Friend WithEvents RbtnT4 As RadioButton
End Class
