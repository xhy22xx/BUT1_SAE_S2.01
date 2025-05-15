Imports System.Diagnostics.Eventing.Reader
Imports System.Media
Public Class Form1

    Dim form2 As New Form()
    'déclare le nouveau form'

    Dim player As SoundPlayer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim personne As PERS() = Module_Enregistrement.GetPersonnes()

        If personne IsNot Nothing AndAlso personne.Length > 0 Then
            For Each s As PERS In personne
                cbxNoms.Items.Add(s.Nom)
            Next
        End If

        'Initialisation des radiobuttons à mettre dans le Form1, les Rbtn ne seront pas initialisée si on ne va pas sur options puis on valide.
        FormOptions.RbtnFacile.Checked = True
        FormOptions.RbtnFacile.PerformClick()

        FormOptions.RbtnL1.Checked = True
        FormOptions.RbtnL1.PerformClick()

        FormOptions.RbtnT1.Checked = True
        FormOptions.RbtnT1.PerformClick()


        'player = New SoundPlayer("CallYouMine.wav")
        'player.Play() ' Utilise .PlayLooping() pour jouer en boucle
    End Sub

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        If cbxNoms.Text = "" Then
            If FormOptions.RbtnL1.Checked = True Then
                MsgBox("Nom obligatoire.")
            ElseIf FormOptions.RbtnL2.Checked = True Then
                MsgBox("Please enter a name.")
            ElseIf FormOptions.RbtnL3.Checked = True Then
                MsgBox("请输入玩家名称。")
            Else
                MsgBox("Erreur!!! (dans la boucle) Nom obligatoire.") ' A enlever si c bon
            End If
            cbxNoms.Focus()
            Exit Sub
        End If

        If cbxNoms.Text.Length < 3 Then
            If FormOptions.RbtnL1.Checked = True Then
                MsgBox("Veuillez entrez un nom d’au moins 3 caractères.", MsgBoxStyle.Information, "Nom invalide")
            ElseIf FormOptions.RbtnL2.Checked = True Then
                MsgBox("Please enter a name with at least 3 characters.", MsgBoxStyle.Information, "Invalid Name")
            ElseIf FormOptions.RbtnL3.Checked = True Then
                MsgBox("请输入至少3个字符的名称。", MsgBoxStyle.Information, "无效名称")
            End If
            cbxNoms.Focus()
        Else
            Dim name As String = cbxNoms.Text
            Module_Enregistrement.AJOUT(name)

            If FormOptions.RbtnFacile.Checked = True Then
                Memory.Show()
                Memory.Label2.Text = name    'Faudrait renommer ca!!
            ElseIf FormOptions.RbtnMoyen.Checked = True Then
                'Memory2.Show()
                'Memory........
                MsgBox("Memory niv moyen pas encore créer")
            ElseIf FormOptions.RbtnDifficile.Checked = True Then
                'Memory3.Show()
                'Memory........
                MsgBox("Memory niv difficile pas encore créer")
            Else
                'Normalement il n'affiche pas ca 
                MsgBox("Erreur. Niveau de difficulté non choisit. Aller sur options et choisir le niveau.")
            End If
        End If
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click   'A modifier le MsgBox à personnaliser!!
        If FormOptions.RbtnL1.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Êtes vous sûr de vouloir quitter l'application?"
        ElseIf FormOptions.RbtnL2.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Are you sure you want to quit the application?"
        ElseIf FormOptions.RbtnL3.Checked = True Then
            formConfirmation.lblConfirmation.Text = "确定要退出应用程序吗？"
        End If
        Dim result As DialogResult = formConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnAfficherScore_Click(sender As Object, e As EventArgs) Handles btnAfficherScore.Click
        FormScores.Show()
    End Sub


    Private Sub cbxNoms_alphabet(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbxNoms.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cbxNoms.Items.Clear()
        Dim personnes As PERS() = Module_Enregistrement.GetPersonnes()
        If personnes IsNot Nothing Then
            For Each s As PERS In personnes
                cbxNoms.Items.Add(s.Nom)
            Next
        End If
    End Sub



    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        FormOptions.Show()
    End Sub

End Class