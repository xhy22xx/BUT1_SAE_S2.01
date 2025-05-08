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
        Me.BtnTrier = New System.Windows.Forms.Button()
        Me.LTempsT = New System.Windows.Forms.Label()
        Me.LParties = New System.Windows.Forms.Label()
        Me.LTempsM = New System.Windows.Forms.Label()
        Me.LCarres = New System.Windows.Forms.Label()
        Me.LJoueur = New System.Windows.Forms.Label()
        Me.LstTempsT = New System.Windows.Forms.ListBox()
        Me.LstParties = New System.Windows.Forms.ListBox()
        Me.LstTempsM = New System.Windows.Forms.ListBox()
        Me.LstCarres = New System.Windows.Forms.ListBox()
        Me.LstJoueurs = New System.Windows.Forms.ListBox()
        Me.LNom = New System.Windows.Forms.Label()
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.ComboBoxJoueur = New System.Windows.Forms.ComboBox()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTrier
        '
        Me.BtnTrier.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTrier.Location = New System.Drawing.Point(709, 134)
        Me.BtnTrier.Name = "BtnTrier"
        Me.BtnTrier.Size = New System.Drawing.Size(84, 32)
        Me.BtnTrier.TabIndex = 10
        Me.BtnTrier.Text = "TRIER"
        Me.BtnTrier.UseVisualStyleBackColor = False
        '
        'LTempsT
        '
        Me.LTempsT.AutoSize = True
        Me.LTempsT.Location = New System.Drawing.Point(519, 46)
        Me.LTempsT.Name = "LTempsT"
        Me.LTempsT.Size = New System.Drawing.Size(143, 20)
        Me.LTempsT.TabIndex = 9
        Me.LTempsT.Text = "Temps Total de jeu"
        '
        'LParties
        '
        Me.LParties.AutoSize = True
        Me.LParties.Location = New System.Drawing.Point(399, 46)
        Me.LParties.Name = "LParties"
        Me.LParties.Size = New System.Drawing.Size(114, 20)
        Me.LParties.TabIndex = 8
        Me.LParties.Text = "Parties Jouées"
        '
        'LTempsM
        '
        Me.LTempsM.AutoSize = True
        Me.LTempsM.Location = New System.Drawing.Point(294, 46)
        Me.LTempsM.Name = "LTempsM"
        Me.LTempsM.Size = New System.Drawing.Size(86, 20)
        Me.LTempsM.TabIndex = 7
        Me.LTempsM.Text = "Temps Min"
        '
        'LCarres
        '
        Me.LCarres.AutoSize = True
        Me.LCarres.Location = New System.Drawing.Point(152, 46)
        Me.LCarres.Name = "LCarres"
        Me.LCarres.Size = New System.Drawing.Size(125, 20)
        Me.LCarres.TabIndex = 6
        Me.LCarres.Text = "Carrés Identifiés"
        '
        'LJoueur
        '
        Me.LJoueur.AutoSize = True
        Me.LJoueur.Location = New System.Drawing.Point(62, 46)
        Me.LJoueur.Name = "LJoueur"
        Me.LJoueur.Size = New System.Drawing.Size(58, 20)
        Me.LJoueur.TabIndex = 5
        Me.LJoueur.Text = "Joueur"
        '
        'LstTempsT
        '
        Me.LstTempsT.FormattingEnabled = True
        Me.LstTempsT.ItemHeight = 20
        Me.LstTempsT.Location = New System.Drawing.Point(519, 81)
        Me.LstTempsT.Name = "LstTempsT"
        Me.LstTempsT.Size = New System.Drawing.Size(160, 164)
        Me.LstTempsT.TabIndex = 4
        '
        'LstParties
        '
        Me.LstParties.FormattingEnabled = True
        Me.LstParties.ItemHeight = 20
        Me.LstParties.Location = New System.Drawing.Point(401, 81)
        Me.LstParties.Name = "LstParties"
        Me.LstParties.Size = New System.Drawing.Size(112, 164)
        Me.LstParties.TabIndex = 3
        '
        'LstTempsM
        '
        Me.LstTempsM.FormattingEnabled = True
        Me.LstTempsM.ItemHeight = 20
        Me.LstTempsM.Location = New System.Drawing.Point(283, 81)
        Me.LstTempsM.Name = "LstTempsM"
        Me.LstTempsM.Size = New System.Drawing.Size(112, 164)
        Me.LstTempsM.TabIndex = 2
        '
        'LstCarres
        '
        Me.LstCarres.FormattingEnabled = True
        Me.LstCarres.ItemHeight = 20
        Me.LstCarres.Location = New System.Drawing.Point(156, 81)
        Me.LstCarres.Name = "LstCarres"
        Me.LstCarres.Size = New System.Drawing.Size(121, 164)
        Me.LstCarres.TabIndex = 1
        '
        'LstJoueurs
        '
        Me.LstJoueurs.FormattingEnabled = True
        Me.LstJoueurs.ItemHeight = 20
        Me.LstJoueurs.Location = New System.Drawing.Point(23, 81)
        Me.LstJoueurs.Name = "LstJoueurs"
        Me.LstJoueurs.Size = New System.Drawing.Size(127, 164)
        Me.LstJoueurs.TabIndex = 0
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Location = New System.Drawing.Point(43, 44)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(125, 20)
        Me.LNom.TabIndex = 2
        Me.LNom.Text = "Nom du Joueur :"
        '
        'BtnRechercher
        '
        Me.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRechercher.Location = New System.Drawing.Point(108, 132)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(143, 32)
        Me.BtnRechercher.TabIndex = 1
        Me.BtnRechercher.Text = "RECHERCHER"
        Me.BtnRechercher.UseVisualStyleBackColor = False
        '
        'ComboBoxJoueur
        '
        Me.ComboBoxJoueur.FormattingEnabled = True
        Me.ComboBoxJoueur.Location = New System.Drawing.Point(47, 80)
        Me.ComboBoxJoueur.Name = "ComboBoxJoueur"
        Me.ComboBoxJoueur.Size = New System.Drawing.Size(270, 28)
        Me.ComboBoxJoueur.TabIndex = 0
        '
        'BtnRetour
        '
        Me.BtnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRetour.Location = New System.Drawing.Point(499, 383)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(286, 44)
        Me.BtnRetour.TabIndex = 3
        Me.BtnRetour.Text = "RETOUR"
        Me.BtnRetour.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnTrier)
        Me.GroupBox1.Controls.Add(Me.LstTempsT)
        Me.GroupBox1.Controls.Add(Me.LstTempsM)
        Me.GroupBox1.Controls.Add(Me.LTempsT)
        Me.GroupBox1.Controls.Add(Me.LstParties)
        Me.GroupBox1.Controls.Add(Me.LstCarres)
        Me.GroupBox1.Controls.Add(Me.LParties)
        Me.GroupBox1.Controls.Add(Me.LstJoueurs)
        Me.GroupBox1.Controls.Add(Me.LTempsM)
        Me.GroupBox1.Controls.Add(Me.LJoueur)
        Me.GroupBox1.Controls.Add(Me.LCarres)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 270)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statistiques"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnRechercher)
        Me.GroupBox2.Controls.Add(Me.LNom)
        Me.GroupBox2.Controls.Add(Me.ComboBoxJoueur)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 319)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 190)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher un joueur"
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(883, 536)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormScores"
        Me.Text = "Scores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

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
