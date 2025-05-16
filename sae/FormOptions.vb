Public Class FormOptions

    Dim DefaultTextbtnLancer As String
    Dim DefaultTextbtnQuitter As String
    Dim DefaultTextbtnAfficherScore As String
    Dim DefaultTextbtnOptions As String

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

    Dim DefaultTextlblJoueur As String
    Dim DefaultTextlblTempsR As String
    Dim DefaultTextbtnAbandon As String

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
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sauvegarde des textes initials (PAGE D'ACCUEIL)
        DefaultTextbtnLancer = Form1.btnLancer.Text
        DefaultTextbtnQuitter = Form1.btnQuitter.Text
        DefaultTextbtnAfficherScore = Form1.btnAfficherScore.Text
        DefaultTextbtnOptions = Form1.btnOptions.Text
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
        'Sauvegarde des textes initiales (Memory)
        DefaultTextlblJoueur = Memory.lblJoueur.Text
        DefaultTextlblTempsR = Memory.lblTempsR.Text
        DefaultTextbtnAbandon = Memory.btnAbandon.Text
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

    End Sub

    'A mettre dans les autres FORMULAIREEEEEEEEEEEEEEEEEEEEEEEEEEEE
    'If RadioButton1.Checked = True Then
    'TextBox1.Text = RadioButton1.Text
    'End If

    Private Sub btnValidation_Click(sender As Object, e As EventArgs) Handles btnValidation.Click
        If RbtnL1.Checked = True Then
            Form1.btnLancer.Text = DefaultTextbtnLancer
            Form1.btnQuitter.Text = DefaultTextbtnQuitter
            Form1.btnAfficherScore.Text = DefaultTextbtnAfficherScore
            Form1.btnOptions.Text = DefaultTextbtnOptions

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

            Memory.lblJoueur.Text = DefaultTextlblJoueur
            Memory.lblTempsR.Text = DefaultTextlblTempsR
            Memory.btnAbandon.Text = DefaultTextbtnAbandon

            formConfirmation.Text = DefaultTextConfirmation
            formConfirmation.btnYes.Text = DefaultTextbtnYes
            formConfirmation.btnNo.Text = DefaultTextbtnNo

            'A mettre ici!!!!!!!!!!!!! ajout pour les langues du formscores!!

        ElseIf RbtnL2.Checked = True Then
            Form1.btnLancer.Text = "Start"
            Form1.btnQuitter.Text = "Quit"
            Form1.btnAfficherScore.Text = "Show Score"
            Form1.btnOptions.Text = "Settings"

            lblD.Text = "Difficulty selection: "
            lblL.Text = "Language choice: "
            lblC.Text = "Visual card style: "
            btnValidation.Text = "OK"
            RbtnFacile.Text = "Easy"
            RbtnMoyen.Text = "Medium"
            RbtnDifficile.Text = "Hard"
            RbtnL1.Text = "French"
            RbtnL2.Text = "English"
            RbtnL3.Text = "Chinese"
            RbtnT1.Text = "Pokémon Card"
            RbtnT2.Text = "type 2 en" 'A modifier
            RbtnT3.Text = "type 3 en" 'A modifier

            Memory.lblJoueur.Text = "Player: "
            Memory.lblTempsR.Text = "Time remaining: "
            Memory.btnAbandon.Text = "Give Up"

            formConfirmation.Text = "Confirmation"
            formConfirmation.btnYes.Text = "Yes"
            formConfirmation.btnNo.Text = "No"
        ElseIf RbtnL3.Checked = True Then
            Form1.btnLancer.Text = "开始"
            Form1.btnQuitter.Text = "退出"
            Form1.btnAfficherScore.Text = "显示分数"
            Form1.btnOptions.Text = "设置"

            lblD.Text = "难度选择: "
            lblL.Text = "语言选择: "
            lblC.Text = "卡牌视觉风格: "
            btnValidation.Text = "确认"
            RbtnFacile.Text = "简单"
            RbtnMoyen.Text = "中等"
            RbtnDifficile.Text = "困难"
            RbtnL1.Text = "法文"
            RbtnL2.Text = "英文"
            RbtnL3.Text = "中文"
            RbtnT1.Text = "宝可梦卡牌"
            RbtnT2.Text = "类型 2 " 'A modifier
            RbtnT3.Text = "类型 3 " 'A modifier

            Memory.lblJoueur.Text = "玩家: "
            Memory.lblTempsR.Text = "剩余时间: "
            Memory.btnAbandon.Text = "放弃"

            formConfirmation.Text = "确认"
            formConfirmation.btnYes.Text = "确定"
            formConfirmation.btnNo.Text = "取消"
        Else
            MsgBox("Erreur. Langue non choisie???")   'A enlever si ya plus de problèmes
        End If

        Me.Hide()
        Form1.Show()
    End Sub

End Class