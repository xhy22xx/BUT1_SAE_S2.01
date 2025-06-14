﻿Public Class FormOptions

    Dim DefaultTextbtnLancer As String
    Dim DefaultTextbtnQuitter As String
    Dim DefaultTextbtnAfficherScore As String
    Dim DefaultTextbtnOptions As String
    Dim DefaultTextFormAccueil As String

    Dim DefaultTextlblD As String
    Dim DefaultTextlblL As String
    Dim DefaultTextlblC As String
    Dim DefaultTextlbtnValidation As String
    Dim DefaultTextRbtnFacile As String
    Dim DefaultTextRbtnMoyen As String
    Dim DefaultTextRbtnDifficile As String
    Dim DefaultTextRbtnL1 As String
    Dim DefaultTextRbtnL2 As String
    Dim DefaultTextRbtnL3 As String
    Dim DefaultTextRbtnT1 As String
    Dim DefaultTextRbtnT2 As String
    Dim DefaultTextRbtnT3 As String
    Dim DefaultTextRbtnT4 As String
    Dim DefaultTextRbtnT5 As String
    Dim DefaultTextFormOptions As String

    Dim DefaultTextlblJoueur As String
    Dim DefaultTextlblJoueur1 As String
    Dim DefaultTextlblJoueur2 As String
    Dim DefaultTextlblTempsR As String
    Dim DefaultTextlblTempsR1 As String
    Dim DefaultTextlblTempsR2 As String
    Dim DefaultTextbtnAbandon As String
    Dim DefaultTextbtnAbandon1 As String
    Dim DefaultTextbtnAbandon2 As String

    Dim DefaultTextConfirmation As String
    Dim DefaultTextbtnYes As String
    Dim DefaultTextbtnNo As String

    Dim DefaultTextGpB1 As String
    Dim DefaultTextGpB2 As String
    Dim DefaultTextLJoueur As String
    Dim DefaultTextLCarres As String
    Dim DefaultTextLTempsM As String
    Dim DefaultTextLParties As String
    Dim DefaultTextLTempsT As String
    Dim DefaultTextLNom As String
    Dim DefaultTextBtnTrier As String
    Dim DefaultTextBtnRetour As String
    Dim DefaultTextbtnRechercher As String
    Dim DefaultTextScores As String
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sauvegarde des textes initials (PAGE D'ACCUEIL)
        DefaultTextbtnLancer = FormAccueil.btnLancer.Text
        DefaultTextbtnQuitter = FormAccueil.btnQuitter.Text
        DefaultTextbtnAfficherScore = FormAccueil.btnAfficherScore.Text
        DefaultTextbtnOptions = FormAccueil.btnOptions.Text
        DefaultTextFormAccueil = FormAccueil.Text
        'Sauvegarde des textes initiales (Options)
        DefaultTextlblD = lblD.Text
        DefaultTextlblL = lblL.Text
        DefaultTextlblC = lblC.Text
        DefaultTextlbtnValidation = btnValidation.Text
        DefaultTextRbtnFacile = RbtnFacile.Text
        DefaultTextRbtnMoyen = RbtnMoyen.Text
        DefaultTextRbtnDifficile = RbtnDifficile.Text
        DefaultTextRbtnL1 = RbtnL1.Text
        DefaultTextRbtnL2 = RbtnL2.Text
        DefaultTextRbtnL3 = RbtnL3.Text
        DefaultTextRbtnT1 = RbtnT1.Text
        DefaultTextRbtnT2 = RbtnT2.Text
        DefaultTextRbtnT3 = RbtnT3.Text
        DefaultTextRbtnT4 = RbtnT4.Text
        DefaultTextRbtnT5 = RbtnT5.Text
        DefaultTextFormOptions = Me.Text

        'Sauvegarde des textes initiales (Memory)
        DefaultTextlblJoueur = MemoryNormal.lblJoueur.Text
        DefaultTextlblJoueur1 = MemoryEasy.lblJoueur1.Text
        DefaultTextlblJoueur2 = MemoryHard.lblJoueur2.Text
        DefaultTextlblTempsR = MemoryNormal.lblTempsR.Text
        DefaultTextlblTempsR1 = MemoryEasy.lblTempsR1.Text
        DefaultTextlblTempsR2 = MemoryHard.lblTempsR2.Text
        DefaultTextbtnAbandon = MemoryNormal.btnAbandon.Text
        DefaultTextbtnAbandon1 = MemoryEasy.btnAbandon1.Text
        DefaultTextbtnAbandon2 = MemoryHard.btnAbandon2.Text
        'Initialisation de la boîte de Confirmation
        DefaultTextConfirmation = formConfirmation.Text
        DefaultTextbtnYes = formConfirmation.btnYes.Text
        DefaultTextbtnNo = formConfirmation.btnNo.Text
        'Initialisation FormScores
        DefaultTextGpB1 = FormScores.GroupBox1.Text
        DefaultTextGpB2 = FormScores.GroupBox2.Text
        DefaultTextLJoueur = FormScores.LJoueur.Text
        DefaultTextLCarres = FormScores.LCarres.Text
        DefaultTextLTempsM = FormScores.LTempsM.Text
        DefaultTextLParties = FormScores.LParties.Text
        DefaultTextLTempsT = FormScores.LTempsT.Text
        DefaultTextLNom = FormScores.LNom.Text
        DefaultTextBtnTrier = FormScores.BtnTrier.Text
        DefaultTextBtnRetour = FormScores.BtnRetour.Text
        DefaultTextbtnRechercher = FormScores.BtnRechercher.Text
        DefaultTextScores = FormScores.Text
    End Sub

    Private Sub btnValidation_Click(sender As Object, e As EventArgs) Handles btnValidation.Click
        If RbtnL1.Checked = True Then
            FormAccueil.btnLancer.Text = DefaultTextbtnLancer
            FormAccueil.btnQuitter.Text = DefaultTextbtnQuitter
            FormAccueil.btnAfficherScore.Text = DefaultTextbtnAfficherScore
            FormAccueil.btnOptions.Text = DefaultTextbtnOptions
            FormAccueil.Text = DefaultTextFormAccueil

            lblD.Text = DefaultTextlblD
            lblL.Text = DefaultTextlblL
            lblC.Text = DefaultTextlblC
            btnValidation.Text = DefaultTextlbtnValidation
            RbtnFacile.Text = DefaultTextRbtnFacile
            RbtnMoyen.Text = DefaultTextRbtnMoyen
            RbtnDifficile.Text = DefaultTextRbtnDifficile
            RbtnL1.Text = DefaultTextRbtnL1
            RbtnL2.Text = DefaultTextRbtnL2
            RbtnL3.Text = DefaultTextRbtnL3
            RbtnT1.Text = DefaultTextRbtnT1
            RbtnT2.Text = DefaultTextRbtnT2
            RbtnT3.Text = DefaultTextRbtnT3
            RbtnT4.Text = DefaultTextRbtnT4
            RbtnT5.Text = DefaultTextRbtnT5
            Me.Text = DefaultTextFormOptions

            MemoryNormal.lblJoueur.Text = DefaultTextlblJoueur
            MemoryEasy.lblJoueur1.Text = DefaultTextlblJoueur1
            MemoryHard.lblJoueur2.Text = DefaultTextlblJoueur2
            MemoryNormal.lblTempsR.Text = DefaultTextlblTempsR
            MemoryEasy.lblTempsR1.Text = DefaultTextlblTempsR1
            MemoryHard.lblTempsR2.Text = DefaultTextlblTempsR2
            MemoryNormal.btnAbandon.Text = DefaultTextbtnAbandon
            MemoryEasy.btnAbandon1.Text = DefaultTextbtnAbandon1
            MemoryHard.btnAbandon2.Text = DefaultTextbtnAbandon2

            formConfirmation.Text = DefaultTextConfirmation
            formConfirmation.btnYes.Text = DefaultTextbtnYes
            formConfirmation.btnNo.Text = DefaultTextbtnNo

            FormScores.Text = DefaultTextScores
            FormScores.GroupBox1.Text = DefaultTextGpB1
            FormScores.GroupBox2.Text = DefaultTextGpB2
            FormScores.LJoueur.Text = DefaultTextLJoueur
            FormScores.LCarres.Text = DefaultTextLCarres
            FormScores.LTempsM.Text = DefaultTextLTempsM
            FormScores.LParties.Text = DefaultTextLParties
            FormScores.LTempsT.Text = DefaultTextLTempsT
            FormScores.LNom.Text = DefaultTextLNom
            FormScores.BtnTrier.Text = DefaultTextBtnTrier
            FormScores.BtnRetour.Text = DefaultTextBtnRetour
            FormScores.BtnRechercher.Text = DefaultTextbtnRechercher

        ElseIf RbtnL2.Checked = True Then
            FormAccueil.btnLancer.Text = "Start"
            FormAccueil.btnQuitter.Text = "Quit"
            FormAccueil.btnAfficherScore.Text = "Show Score"
            FormAccueil.btnOptions.Text = "Settings"
            FormAccueil.Text = "Main Menu"

            lblD.Text = "Difficulty selection: "
            lblL.Text = "Language choice: "
            lblC.Text = "Visual card style: "
            btnValidation.Text = "OK"
            RbtnFacile.Text = "Easy +"
            RbtnMoyen.Text = "Medium ++"
            RbtnDifficile.Text = "Hard +++"
            RbtnL1.Text = "French"
            RbtnL2.Text = "English"
            RbtnL3.Text = "Chinese"
            RbtnT1.Text = "Pokémon Card"
            RbtnT2.Text = "Link Click Card"
            RbtnT3.Text = "Uno Card"
            RbtnT4.Text = "Jojo Card"
            RbtnT5.Text = "JJK Card"
            Me.Text = "Options"

            MemoryNormal.lblJoueur.Text = "Player: "
            MemoryEasy.lblJoueur1.Text = "Player: "
            MemoryHard.lblJoueur2.Text = "Player: "
            MemoryNormal.lblTempsR.Text = "Time remaining: "
            MemoryEasy.lblTempsR1.Text = "Time remaining: "
            MemoryHard.lblTempsR2.Text = "Time remaining: "
            MemoryNormal.btnAbandon.Text = "Give Up"
            MemoryEasy.btnAbandon1.Text = "Give Up"
            MemoryHard.btnAbandon2.Text = "Give Up"
            MemoryNormal.Text = "Memory"

            formConfirmation.Text = "Confirmation"
            formConfirmation.btnYes.Text = "Yes"
            formConfirmation.btnNo.Text = "No"

            FormScores.Text = "Score"
            FormScores.GroupBox1.Text = "Stats"
            FormScores.GroupBox2.Text = "Search Players"
            FormScores.LJoueur.Text = "Players"
            FormScores.LCarres.Text = "Squares Found"
            FormScores.LTempsM.Text = "Record Time"
            FormScores.LParties.Text = "Games Played"
            FormScores.LTempsT.Text = "Total Play Time"
            FormScores.LNom.Text = "Player Name:"
            FormScores.BtnTrier.Text = "Sort"
            FormScores.BtnRetour.Text = "Back"
            FormScores.BtnRechercher.Text = "Search"

        ElseIf RbtnL3.Checked = True Then
            FormAccueil.btnLancer.Text = "开始"
            FormAccueil.btnQuitter.Text = "退出"
            FormAccueil.btnAfficherScore.Text = "显示分数"
            FormAccueil.btnOptions.Text = "设置"
            FormAccueil.Text = "主菜单"

            lblD.Text = "难度选择: "
            lblL.Text = "语言选择: "
            lblC.Text = "卡牌视觉风格: "
            btnValidation.Text = "确认"
            RbtnFacile.Text = "简单 +"
            RbtnMoyen.Text = "中等 ++"
            RbtnDifficile.Text = "困难 +++"
            RbtnL1.Text = "法文"
            RbtnL2.Text = "英文"
            RbtnL3.Text = "中文"
            RbtnT1.Text = "宝可梦卡牌"
            RbtnT2.Text = "时光代理人卡牌"
            RbtnT3.Text = "UNO卡牌"
            RbtnT4.Text = "JOJO卡牌"
            RbtnT5.Text = "咒术回战卡牌"
            Me.Text = "选项"

            MemoryNormal.lblJoueur.Text = "玩家: "
            MemoryNormal.lblJoueur.Text = "玩家: "
            MemoryEasy.lblJoueur1.Text = "玩家: "
            MemoryNormal.lblTempsR.Text = "剩余时间: "
            MemoryEasy.lblTempsR1.Text = "剩余时间: "
            MemoryHard.lblTempsR2.Text = "剩余时间: "
            MemoryNormal.btnAbandon.Text = "放弃"
            MemoryEasy.btnAbandon1.Text = "放弃"
            MemoryHard.btnAbandon2.Text = "放弃"
            MemoryNormal.Text = "配对游戏"

            formConfirmation.Text = "确认"
            formConfirmation.btnYes.Text = "确定"
            formConfirmation.btnNo.Text = "取消"

            FormScores.Text = "分数"
            FormScores.GroupBox1.Text = "数据统计"
            FormScores.GroupBox2.Text = "查找玩家"
            FormScores.LJoueur.Text = "玩家列表"
            FormScores.LCarres.Text = "解锁方块"
            FormScores.LTempsM.Text = "最快纪录"
            FormScores.LParties.Text = "总场次"
            FormScores.LTempsT.Text = "累计时长"
            FormScores.LNom.Text = "玩家ID："
            FormScores.BtnTrier.Text = "排行榜"
            FormScores.BtnRetour.Text = "返回菜单"
            FormScores.BtnRechercher.Text = "查找"
        End If

        Me.Hide()
        FormAccueil.Show()
    End Sub

End Class