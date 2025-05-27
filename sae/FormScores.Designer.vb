<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScores
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
        BtnTrier = New Button()
        LTempsT = New Label()
        LParties = New Label()
        LTempsM = New Label()
        LCarres = New Label()
        LJoueur = New Label()
        LstTempsT = New ListBox()
        LstParties = New ListBox()
        LstTempsM = New ListBox()
        LstCarres = New ListBox()
        LstJoueurs = New ListBox()
        LNom = New Label()
        BtnRechercher = New Button()
        ComboBoxJoueur = New ComboBox()
        BtnRetour = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        ComboBoxNiveau = New ComboBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnTrier
        ' 
        BtnTrier.BackColor = Color.Transparent
        BtnTrier.BackgroundImage = My.Resources.Resources.buttonS1
        BtnTrier.BackgroundImageLayout = ImageLayout.Center
        BtnTrier.CausesValidation = False
        BtnTrier.Cursor = Cursors.Hand
        BtnTrier.FlatAppearance.BorderSize = 0
        BtnTrier.FlatAppearance.MouseDownBackColor = Color.White
        BtnTrier.FlatAppearance.MouseOverBackColor = Color.White
        BtnTrier.FlatStyle = FlatStyle.Flat
        BtnTrier.ForeColor = Color.FromArgb(CByte(247), CByte(218), CByte(227))
        BtnTrier.Location = New Point(852, 394)
        BtnTrier.Margin = New Padding(3, 4, 3, 4)
        BtnTrier.Name = "BtnTrier"
        BtnTrier.Size = New Size(120, 68)
        BtnTrier.TabIndex = 10
        BtnTrier.Text = "TRIER"
        BtnTrier.UseVisualStyleBackColor = False
        ' 
        ' LTempsT
        ' 
        LTempsT.Location = New Point(788, 73)
        LTempsT.Name = "LTempsT"
        LTempsT.Size = New Size(221, 34)
        LTempsT.TabIndex = 9
        LTempsT.Text = "Temps de Jeu Total"
        LTempsT.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LParties
        ' 
        LParties.Location = New Point(613, 73)
        LParties.Name = "LParties"
        LParties.Size = New Size(169, 34)
        LParties.TabIndex = 8
        LParties.Text = "Parties Jouées"
        LParties.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LTempsM
        ' 
        LTempsM.Location = New Point(418, 73)
        LTempsM.Name = "LTempsM"
        LTempsM.Size = New Size(189, 34)
        LTempsM.TabIndex = 7
        LTempsM.Text = "Meilleurs Temps"
        LTempsM.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LCarres
        ' 
        LCarres.Location = New Point(223, 73)
        LCarres.Name = "LCarres"
        LCarres.Size = New Size(189, 34)
        LCarres.TabIndex = 6
        LCarres.Text = "Carrés Identifiés"
        LCarres.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LJoueur
        ' 
        LJoueur.Location = New Point(34, 73)
        LJoueur.Name = "LJoueur"
        LJoueur.Size = New Size(183, 34)
        LJoueur.TabIndex = 5
        LJoueur.Text = "Joueurs"
        LJoueur.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LstTempsT
        ' 
        LstTempsT.Font = New Font("Bookman Old Style", 9F)
        LstTempsT.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        LstTempsT.FormattingEnabled = True
        LstTempsT.ItemHeight = 27
        LstTempsT.Location = New Point(788, 130)
        LstTempsT.Margin = New Padding(3, 4, 3, 4)
        LstTempsT.Name = "LstTempsT"
        LstTempsT.Size = New Size(221, 220)
        LstTempsT.TabIndex = 4
        ' 
        ' LstParties
        ' 
        LstParties.Font = New Font("Bookman Old Style", 9F)
        LstParties.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        LstParties.FormattingEnabled = True
        LstParties.ItemHeight = 27
        LstParties.Location = New Point(613, 130)
        LstParties.Margin = New Padding(3, 4, 3, 4)
        LstParties.Name = "LstParties"
        LstParties.Size = New Size(169, 220)
        LstParties.TabIndex = 3
        ' 
        ' LstTempsM
        ' 
        LstTempsM.Font = New Font("Bookman Old Style", 9F)
        LstTempsM.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        LstTempsM.FormattingEnabled = True
        LstTempsM.ItemHeight = 27
        LstTempsM.Location = New Point(418, 130)
        LstTempsM.Margin = New Padding(3, 4, 3, 4)
        LstTempsM.Name = "LstTempsM"
        LstTempsM.Size = New Size(189, 220)
        LstTempsM.TabIndex = 2
        ' 
        ' LstCarres
        ' 
        LstCarres.Font = New Font("Bookman Old Style", 9F)
        LstCarres.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        LstCarres.FormattingEnabled = True
        LstCarres.ItemHeight = 27
        LstCarres.Location = New Point(223, 130)
        LstCarres.Margin = New Padding(3, 4, 3, 4)
        LstCarres.Name = "LstCarres"
        LstCarres.Size = New Size(189, 220)
        LstCarres.TabIndex = 1
        ' 
        ' LstJoueurs
        ' 
        LstJoueurs.Font = New Font("Bookman Old Style", 9F)
        LstJoueurs.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        LstJoueurs.FormattingEnabled = True
        LstJoueurs.ItemHeight = 27
        LstJoueurs.Location = New Point(34, 130)
        LstJoueurs.Margin = New Padding(3, 4, 3, 4)
        LstJoueurs.Name = "LstJoueurs"
        LstJoueurs.Size = New Size(183, 220)
        LstJoueurs.TabIndex = 0
        ' 
        ' LNom
        ' 
        LNom.AutoSize = True
        LNom.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        LNom.Location = New Point(80, 93)
        LNom.Name = "LNom"
        LNom.Size = New Size(164, 28)
        LNom.TabIndex = 2
        LNom.Text = "Nom du Joueur :"
        ' 
        ' BtnRechercher
        ' 
        BtnRechercher.BackColor = Color.Transparent
        BtnRechercher.BackgroundImage = My.Resources.Resources.buttonS3
        BtnRechercher.BackgroundImageLayout = ImageLayout.Center
        BtnRechercher.Cursor = Cursors.Hand
        BtnRechercher.FlatAppearance.BorderSize = 0
        BtnRechercher.FlatAppearance.MouseDownBackColor = Color.White
        BtnRechercher.FlatAppearance.MouseOverBackColor = Color.White
        BtnRechercher.FlatStyle = FlatStyle.Flat
        BtnRechercher.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        BtnRechercher.Location = New Point(154, 212)
        BtnRechercher.Margin = New Padding(3, 4, 3, 4)
        BtnRechercher.Name = "BtnRechercher"
        BtnRechercher.Size = New Size(221, 75)
        BtnRechercher.TabIndex = 1
        BtnRechercher.Text = "RECHERCHER"
        BtnRechercher.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxJoueur
        ' 
        ComboBoxJoueur.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBoxJoueur.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        ComboBoxJoueur.FormattingEnabled = True
        ComboBoxJoueur.Location = New Point(80, 145)
        ComboBoxJoueur.Margin = New Padding(3, 4, 3, 4)
        ComboBoxJoueur.Name = "ComboBoxJoueur"
        ComboBoxJoueur.Size = New Size(389, 35)
        ComboBoxJoueur.TabIndex = 0
        ' 
        ' BtnRetour
        ' 
        BtnRetour.BackColor = Color.Transparent
        BtnRetour.BackgroundImage = My.Resources.Resources.buttonS2
        BtnRetour.BackgroundImageLayout = ImageLayout.Center
        BtnRetour.Cursor = Cursors.Hand
        BtnRetour.FlatAppearance.BorderSize = 0
        BtnRetour.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnRetour.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnRetour.FlatStyle = FlatStyle.Flat
        BtnRetour.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnRetour.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        BtnRetour.Location = New Point(686, 695)
        BtnRetour.Margin = New Padding(3, 4, 3, 4)
        BtnRetour.Name = "BtnRetour"
        BtnRetour.Size = New Size(298, 92)
        BtnRetour.TabIndex = 3
        BtnRetour.Text = "RETOUR"
        BtnRetour.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.BackgroundImageLayout = ImageLayout.Center
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboBoxNiveau)
        GroupBox1.Controls.Add(BtnTrier)
        GroupBox1.Controls.Add(LstTempsT)
        GroupBox1.Controls.Add(LstTempsM)
        GroupBox1.Controls.Add(LTempsT)
        GroupBox1.Controls.Add(LstParties)
        GroupBox1.Controls.Add(LstCarres)
        GroupBox1.Controls.Add(LParties)
        GroupBox1.Controls.Add(LstJoueurs)
        GroupBox1.Controls.Add(LTempsM)
        GroupBox1.Controls.Add(LJoueur)
        GroupBox1.Controls.Add(LCarres)
        GroupBox1.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        GroupBox1.Location = New Point(25, 25)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1028, 490)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Statistiques"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 438)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 28)
        Label1.TabIndex = 12
        Label1.Text = "Niveau de difficulté :"
        ' 
        ' ComboBoxNiveau
        ' 
        ComboBoxNiveau.FormattingEnabled = True
        ComboBoxNiveau.Location = New Point(223, 435)
        ComboBoxNiveau.Name = "ComboBoxNiveau"
        ComboBoxNiveau.Size = New Size(178, 36)
        ComboBoxNiveau.TabIndex = 11
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.BackgroundImage = My.Resources.Resources.affichebulle
        GroupBox2.BackgroundImageLayout = ImageLayout.Center
        GroupBox2.Controls.Add(BtnRechercher)
        GroupBox2.Controls.Add(LNom)
        GroupBox2.Controls.Add(ComboBoxJoueur)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(107), CByte(75), CByte(88))
        GroupBox2.Location = New Point(96, 565)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(536, 364)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Rechercher un joueur"
        ' 
        ' FormScores
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1074, 981)
        Controls.Add(GroupBox2)
        Controls.Add(BtnRetour)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormScores"
        Text = "Scores"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents LTempsT As Label
    Friend WithEvents LParties As Label
    Friend WithEvents LTempsM As Label
    Friend WithEvents LCarres As Label
    Friend WithEvents LJoueur As Label
    Friend WithEvents LstTempsT As ListBox
    Friend WithEvents LstParties As ListBox
    Friend WithEvents LstTempsM As ListBox
    Friend WithEvents LstCarres As ListBox
    Friend WithEvents LstJoueurs As ListBox
    Friend WithEvents BtnTrier As Button
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents ComboBoxJoueur As ComboBox
    Friend WithEvents LNom As Label
    Friend WithEvents BtnRetour As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxNiveau As ComboBox
End Class
