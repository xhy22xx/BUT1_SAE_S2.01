<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        RbtnFacile = New RadioButton()
        pnlOp1 = New Panel()
        RbtnDifficile = New RadioButton()
        RbtnMoyen = New RadioButton()
        lblDifficulte = New Label()
        lblL = New Label()
        pnlOp2 = New Panel()
        RbtnL3 = New RadioButton()
        RbtnL2 = New RadioButton()
        RbtnL1 = New RadioButton()
        Label1 = New Label()
        pnlOp3 = New Panel()
        RbtnX3 = New RadioButton()
        RbtnX2 = New RadioButton()
        RbtnX1 = New RadioButton()
        pnlOp1.SuspendLayout()
        pnlOp2.SuspendLayout()
        pnlOp3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RbtnFacile
        ' 
        RbtnFacile.AutoSize = True
        RbtnFacile.Location = New Point(21, 18)
        RbtnFacile.Name = "RbtnFacile"
        RbtnFacile.Size = New Size(55, 19)
        RbtnFacile.TabIndex = 0
        RbtnFacile.TabStop = True
        RbtnFacile.Text = "Facile"
        RbtnFacile.UseVisualStyleBackColor = True
        ' 
        ' pnlOp1
        ' 
        pnlOp1.Controls.Add(RbtnDifficile)
        pnlOp1.Controls.Add(RbtnMoyen)
        pnlOp1.Controls.Add(RbtnFacile)
        pnlOp1.Location = New Point(34, 64)
        pnlOp1.Name = "pnlOp1"
        pnlOp1.Size = New Size(138, 135)
        pnlOp1.TabIndex = 1
        ' 
        ' RbtnDifficile
        ' 
        RbtnDifficile.AutoSize = True
        RbtnDifficile.Location = New Point(21, 97)
        RbtnDifficile.Name = "RbtnDifficile"
        RbtnDifficile.Size = New Size(65, 19)
        RbtnDifficile.TabIndex = 2
        RbtnDifficile.TabStop = True
        RbtnDifficile.Text = "Difficile"
        RbtnDifficile.UseVisualStyleBackColor = True
        ' 
        ' RbtnMoyen
        ' 
        RbtnMoyen.AutoSize = True
        RbtnMoyen.Location = New Point(21, 57)
        RbtnMoyen.Name = "RbtnMoyen"
        RbtnMoyen.Size = New Size(62, 19)
        RbtnMoyen.TabIndex = 3
        RbtnMoyen.TabStop = True
        RbtnMoyen.Text = "Moyen"
        RbtnMoyen.UseVisualStyleBackColor = True
        ' 
        ' lblDifficulte
        ' 
        lblDifficulte.AutoSize = True
        lblDifficulte.Location = New Point(34, 46)
        lblDifficulte.Name = "lblDifficulte"
        lblDifficulte.Size = New Size(136, 15)
        lblDifficulte.TabIndex = 2
        lblDifficulte.Text = "Sélection de la difficulté:"
        ' 
        ' lblL
        ' 
        lblL.AutoSize = True
        lblL.Location = New Point(34, 232)
        lblL.Name = "lblL"
        lblL.Size = New Size(113, 15)
        lblL.TabIndex = 4
        lblL.Text = "Sélection de langue:"
        ' 
        ' pnlOp2
        ' 
        pnlOp2.Controls.Add(RbtnL3)
        pnlOp2.Controls.Add(RbtnL2)
        pnlOp2.Controls.Add(RbtnL1)
        pnlOp2.Location = New Point(34, 250)
        pnlOp2.Name = "pnlOp2"
        pnlOp2.Size = New Size(113, 135)
        pnlOp2.TabIndex = 3
        ' 
        ' RbtnL3
        ' 
        RbtnL3.AutoSize = True
        RbtnL3.Location = New Point(21, 97)
        RbtnL3.Name = "RbtnL3"
        RbtnL3.Size = New Size(63, 19)
        RbtnL3.TabIndex = 2
        RbtnL3.TabStop = True
        RbtnL3.Text = "chinois"
        RbtnL3.UseVisualStyleBackColor = True
        ' 
        ' RbtnL2
        ' 
        RbtnL2.AutoSize = True
        RbtnL2.Location = New Point(21, 57)
        RbtnL2.Name = "RbtnL2"
        RbtnL2.Size = New Size(62, 19)
        RbtnL2.TabIndex = 3
        RbtnL2.TabStop = True
        RbtnL2.Text = "anglais"
        RbtnL2.UseVisualStyleBackColor = True
        ' 
        ' RbtnL1
        ' 
        RbtnL1.AutoSize = True
        RbtnL1.Location = New Point(21, 18)
        RbtnL1.Name = "RbtnL1"
        RbtnL1.Size = New Size(66, 19)
        RbtnL1.TabIndex = 0
        RbtnL1.TabStop = True
        RbtnL1.Text = "francais"
        RbtnL1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(227, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 15)
        Label1.TabIndex = 6
        Label1.Text = "Style visuel des cartes:"
        ' 
        ' pnlOp3
        ' 
        pnlOp3.Controls.Add(RbtnX3)
        pnlOp3.Controls.Add(RbtnX2)
        pnlOp3.Controls.Add(RbtnX1)
        pnlOp3.Location = New Point(227, 250)
        pnlOp3.Name = "pnlOp3"
        pnlOp3.Size = New Size(123, 135)
        pnlOp3.TabIndex = 5
        ' 
        ' RbtnX3
        ' 
        RbtnX3.AutoSize = True
        RbtnX3.Location = New Point(21, 97)
        RbtnX3.Name = "RbtnX3"
        RbtnX3.Size = New Size(57, 19)
        RbtnX3.TabIndex = 2
        RbtnX3.TabStop = True
        RbtnX3.Text = "type 3"
        RbtnX3.UseVisualStyleBackColor = True
        ' 
        ' RbtnX2
        ' 
        RbtnX2.AutoSize = True
        RbtnX2.Location = New Point(21, 57)
        RbtnX2.Name = "RbtnX2"
        RbtnX2.Size = New Size(57, 19)
        RbtnX2.TabIndex = 3
        RbtnX2.TabStop = True
        RbtnX2.Text = "type 2"
        RbtnX2.UseVisualStyleBackColor = True
        ' 
        ' RbtnX1
        ' 
        RbtnX1.AutoSize = True
        RbtnX1.Location = New Point(21, 18)
        RbtnX1.Name = "RbtnX1"
        RbtnX1.Size = New Size(57, 19)
        RbtnX1.TabIndex = 0
        RbtnX1.TabStop = True
        RbtnX1.Text = "type 1"
        RbtnX1.UseVisualStyleBackColor = True
        ' 
        ' Options
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(413, 454)
        Controls.Add(Label1)
        Controls.Add(pnlOp3)
        Controls.Add(lblL)
        Controls.Add(pnlOp2)
        Controls.Add(lblDifficulte)
        Controls.Add(pnlOp1)
        Name = "Options"
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
    Friend WithEvents lblDifficulte As Label
    Friend WithEvents lblL As Label
    Friend WithEvents pnlOp2 As Panel
    Friend WithEvents RbtnL3 As RadioButton
    Friend WithEvents RbtnL2 As RadioButton
    Friend WithEvents RbtnL1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlOp3 As Panel
    Friend WithEvents RbtnX3 As RadioButton
    Friend WithEvents RbtnX2 As RadioButton
    Friend WithEvents RbtnX1 As RadioButton
End Class
