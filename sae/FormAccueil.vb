﻿Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Media
Public Class FormAccueil

    Dim positionMusique As Double = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Icon = New Icon("chemin\vers\votre\icone.ico")
        Module_Enregistrement.ChargerDepuisFichier()
        Dim personne As PERS() = Module_Enregistrement.GetPersonnes()
        If personne IsNot Nothing AndAlso personne.Length > 0 Then
            For Each s As PERS In personne
                If Not String.IsNullOrWhiteSpace(s.Nom) Then
                    cbxNoms.Items.Add(s.Nom)
                End If
            Next
        End If
        'Initialisation des options
        FormOptions.RbtnMoyen.Checked = True
        FormOptions.RbtnFacile.PerformClick()

        FormOptions.RbtnL1.Checked = True
        FormOptions.RbtnL1.PerformClick()

        FormOptions.RbtnT1.Checked = True
        FormOptions.RbtnT1.PerformClick()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cbxNoms.Items.Clear()
        Dim personnes As PERS() = Module_Enregistrement.GetPersonnes()
        If personnes IsNot Nothing Then
            For Each s As PERS In personnes
                cbxNoms.Items.Add(s.Nom)
            Next
        End If

        If AxWindowsMediaPlayer1.URL = "" Then
            AxWindowsMediaPlayer1.URL = "Resources\CallYouMine.wav"
            AxWindowsMediaPlayer1.settings.setMode("loop", True)
        End If

        If positionMusique > 0 Then
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = positionMusique
        End If
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStopMusic.Click
        positionMusique = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub ButtonResume_Click(sender As Object, e As EventArgs) Handles ButtonContinueMusic.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = positionMusique
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click

        If cbxNoms.Text = "" Then
            If FormOptions.RbtnL1.Checked = True Then
                MsgBox("Nom obligatoire.", MsgBoxStyle.Information, "Erreur d'entrée")
            ElseIf FormOptions.RbtnL2.Checked = True Then
                MsgBox("Please enter a name.", MsgBoxStyle.Information, "Input error")
            ElseIf FormOptions.RbtnL3.Checked = True Then
                MsgBox("请输入玩家名称。", MsgBoxStyle.Information, "输入错误")
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
            AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0
            AxWindowsMediaPlayer1.Ctlcontrols.pause()

            Dim name As String = cbxNoms.Text
            Dim niveau As String = ""
            If FormOptions.RbtnFacile.Checked Then
                niveau = "+"

            ElseIf FormOptions.RbtnMoyen.Checked Then
                niveau = "++"

            ElseIf FormOptions.RbtnDifficile.Checked Then
                niveau = "+++"
            End If


            Module_Enregistrement.InitialiserJoueur(name, niveau)

            If FormOptions.RbtnFacile.Checked = True Then
                niveau = "+"
                Me.Hide()
                MemoryEasy.niveau = niveau
                MemoryEasy.Show()
                MemoryEasy.Joueur = name
                MemoryEasy.Label2.Text = name
            ElseIf FormOptions.RbtnMoyen.Checked = True Then
                niveau = "++"
                Me.Hide()
                MemoryNormal.niveau = niveau
                MemoryNormal.Show()
                MemoryNormal.Joueur = name
                MemoryNormal.Label2.Text = name
            ElseIf FormOptions.RbtnDifficile.Checked = True Then
                niveau = "+++"
                Me.Hide()
                MemoryHard.niveau = niveau
                MemoryHard.Show()
                MemoryHard.Joueur = name
                MemoryHard.Label2.Text = name
            End If
        End If
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If FormOptions.RbtnL1.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Êtes vous sûr de vouloir quitter l'application?"
        ElseIf FormOptions.RbtnL2.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Are you sure you want to exit the application?"
        ElseIf FormOptions.RbtnL3.Checked = True Then
            formConfirmation.lblConfirmation.Text = "确定要退出应用程序吗？"
        End If
        Dim result As DialogResult = formConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            Module_Enregistrement.SauvegarderDansFichier()
            End
        End If
    End Sub

    Private Sub btnAfficherScore_Click(sender As Object, e As EventArgs) Handles btnAfficherScore.Click
        Me.Hide()
        FormScores.Show()
    End Sub

    Private Sub cbxNoms_alphabet(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbxNoms.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        FormOptions.Show()
    End Sub

End Class