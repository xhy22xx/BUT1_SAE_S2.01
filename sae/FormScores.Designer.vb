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
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnTrier
        ' 
        BtnTrier.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnTrier.Location = New Point(945, 200)
        BtnTrier.Margin = New Padding(3, 4, 3, 4)
        BtnTrier.Name = "BtnTrier"
        BtnTrier.Size = New Size(111, 48)
        BtnTrier.TabIndex = 10
        BtnTrier.Text = "TRIER"
        BtnTrier.UseVisualStyleBackColor = False
        ' 
        ' LTempsT
        ' 
        LTempsT.AutoSize = True
        LTempsT.Location = New Point(693, 68)
        LTempsT.Name = "LTempsT"
        LTempsT.Size = New Size(185, 30)
        LTempsT.TabIndex = 9
        LTempsT.Text = "Temps Total de jeu"
        ' 
        ' LParties
        ' 
        LParties.AutoSize = True
        LParties.Location = New Point(531, 68)
        LParties.Name = "LParties"
        LParties.Size = New Size(143, 30)
        LParties.TabIndex = 8
        LParties.Text = "Parties Jouées"
        ' 
        ' LTempsM
        ' 
        LTempsM.AutoSize = True
        LTempsM.Location = New Point(393, 68)
        LTempsM.Name = "LTempsM"
        LTempsM.Size = New Size(114, 30)
        LTempsM.TabIndex = 7
        LTempsM.Text = "Temps Min"
        ' 
        ' LCarres
        ' 
        LCarres.AutoSize = True
        LCarres.Location = New Point(202, 68)
        LCarres.Name = "LCarres"
        LCarres.Size = New Size(162, 30)
        LCarres.TabIndex = 6
        LCarres.Text = "Carrés Identifiés"
        ' 
        ' LJoueur
        ' 
        LJoueur.AutoSize = True
        LJoueur.Location = New Point(82, 68)
        LJoueur.Name = "LJoueur"
        LJoueur.Size = New Size(75, 30)
        LJoueur.TabIndex = 5
        LJoueur.Text = "Joueur"
        ' 
        ' LstTempsT
        ' 
        LstTempsT.FormattingEnabled = True
        LstTempsT.ItemHeight = 30
        LstTempsT.Location = New Point(693, 122)
        LstTempsT.Margin = New Padding(3, 4, 3, 4)
        LstTempsT.Name = "LstTempsT"
        LstTempsT.Size = New Size(211, 244)
        LstTempsT.TabIndex = 4
        ' 
        ' LstParties
        ' 
        LstParties.FormattingEnabled = True
        LstParties.ItemHeight = 30
        LstParties.Location = New Point(535, 122)
        LstParties.Margin = New Padding(3, 4, 3, 4)
        LstParties.Name = "LstParties"
        LstParties.Size = New Size(148, 244)
        LstParties.TabIndex = 3
        ' 
        ' LstTempsM
        ' 
        LstTempsM.FormattingEnabled = True
        LstTempsM.ItemHeight = 30
        LstTempsM.Location = New Point(377, 122)
        LstTempsM.Margin = New Padding(3, 4, 3, 4)
        LstTempsM.Name = "LstTempsM"
        LstTempsM.Size = New Size(148, 244)
        LstTempsM.TabIndex = 2
        ' 
        ' LstCarres
        ' 
        LstCarres.FormattingEnabled = True
        LstCarres.ItemHeight = 30
        LstCarres.Location = New Point(207, 122)
        LstCarres.Margin = New Padding(3, 4, 3, 4)
        LstCarres.Name = "LstCarres"
        LstCarres.Size = New Size(160, 244)
        LstCarres.TabIndex = 1
        ' 
        ' LstJoueurs
        ' 
        LstJoueurs.FormattingEnabled = True
        LstJoueurs.ItemHeight = 30
        LstJoueurs.Location = New Point(31, 122)
        LstJoueurs.Margin = New Padding(3, 4, 3, 4)
        LstJoueurs.Name = "LstJoueurs"
        LstJoueurs.Size = New Size(169, 244)
        LstJoueurs.TabIndex = 0
        ' 
        ' LNom
        ' 
        LNom.AutoSize = True
        LNom.Location = New Point(57, 66)
        LNom.Name = "LNom"
        LNom.Size = New Size(168, 30)
        LNom.TabIndex = 2
        LNom.Text = "Nom du Joueur :"
        ' 
        ' BtnRechercher
        ' 
        BtnRechercher.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnRechercher.Location = New Point(144, 198)
        BtnRechercher.Margin = New Padding(3, 4, 3, 4)
        BtnRechercher.Name = "BtnRechercher"
        BtnRechercher.Size = New Size(190, 48)
        BtnRechercher.TabIndex = 1
        BtnRechercher.Text = "RECHERCHER"
        BtnRechercher.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxJoueur
        ' 
        ComboBoxJoueur.FormattingEnabled = True
        ComboBoxJoueur.Location = New Point(63, 120)
        ComboBoxJoueur.Margin = New Padding(3, 4, 3, 4)
        ComboBoxJoueur.Name = "ComboBoxJoueur"
        ComboBoxJoueur.Size = New Size(359, 38)
        ComboBoxJoueur.TabIndex = 0
        ' 
        ' BtnRetour
        ' 
        BtnRetour.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnRetour.Location = New Point(665, 574)
        BtnRetour.Margin = New Padding(3, 4, 3, 4)
        BtnRetour.Name = "BtnRetour"
        BtnRetour.Size = New Size(381, 66)
        BtnRetour.TabIndex = 3
        BtnRetour.Text = "RETOUR"
        BtnRetour.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
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
        GroupBox1.Location = New Point(31, 48)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1099, 404)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Statistiques"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox2.Controls.Add(BtnRechercher)
        GroupBox2.Controls.Add(LNom)
        GroupBox2.Controls.Add(ComboBoxJoueur)
        GroupBox2.Location = New Point(31, 478)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(495, 284)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Rechercher un joueur"
        ' 
        ' FormScores
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1178, 804)
        Controls.Add(GroupBox2)
        Controls.Add(BtnRetour)
        Controls.Add(GroupBox1)
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
End Class
