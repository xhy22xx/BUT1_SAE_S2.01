Imports System.Media
Imports System.Security.Cryptography

Public Class MemoryNormal
    Dim time As Integer
    Dim listeImages As New List(Of Image)
    Dim imageDos As Image
    Dim listeCartes As New List(Of PictureBox)
    Dim listeCartesFlipped As New List(Of PictureBox)
    Dim pointsJoueur As Integer
    Dim tempsJoueur As Integer
    Dim timeInitial As Integer
    Public niveau As String
    Public Joueur As String
    Private player As New System.Media.SoundPlayer()
    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        If FormOptions.RbtnL1.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Voulez-vous abandonner la partie en cours?"
        ElseIf FormOptions.RbtnL2.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Do you want to quit the current game?"
        ElseIf FormOptions.RbtnL3.Checked = True Then
            formConfirmation.lblConfirmation.Text = "你确定要放弃当前游戏吗？"
        End If
        Dim result As DialogResult = formConfirmation.ShowDialog()
        If result = DialogResult.Yes Then
            player.Stop()
            Me.Close()
            FormAccueil.Show()
        End If
    End Sub
    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormOptions.RbtnT1.Checked Or FormOptions.RbtnT2.Checked Or FormOptions.RbtnT3.Checked Then
            lblJoueur.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            lblTempsR.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Me.BackColor = Color.White

            If FormOptions.RbtnT1.Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\PokemonTGC.wav"
                imageDos = My.Resources.Carte_pokemon_dos

            ElseIf FormOptions.RbtnT2.Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\LinkClickOpening.wav"
                imageDos = My.Resources.LC

            ElseIf FormOptions.RbtnT3.Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\Chopin.wav"
                imageDos = My.Resources.Uno_Dos
            End If


        ElseIf FormOptions.RbtnT4.Checked Or FormOptions.RbtnT5.Checked Then
            lblJoueur.ForeColor = Color.White
            Label2.ForeColor = Color.White
            lblTempsR.ForeColor = Color.White
            Label4.ForeColor = Color.White
            Me.BackColor = Color.Black
            If FormOptions.RbtnT4.Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\naranciaMusic.wav"
                imageDos = My.Resources.Jojo_Dos
            ElseIf FormOptions.RbtnT5.Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\jujutsuOpening.wav"
                imageDos = My.Resources.jjk_Dos
            End If
        End If


        player.Play()
        timeInitial = 60
        time = timeInitial
        pointsJoueur = 0
        tempsJoueur = 0
        Dim minutes As Integer = time \ 60
        Dim secondes As Integer = (time Mod 60)
        Label4.Text = minutes.ToString("0") & ":" & secondes.ToString("00")
        'Ajout images dans une liste
        listeImages.Clear()
        If FormOptions.RbtnT1.Checked = True Then
            listeImages.AddRange({My.Resources.Celebi, My.Resources.Mew, My.Resources.Marill,
                              My.Resources.Dracaufeu, My.Resources.Evoli})
        ElseIf FormOptions.RbtnT2.Checked = True Then
            listeImages.AddRange({My.Resources.LC1, My.Resources.LC2, My.Resources.LC7,
                                 My.Resources.LC4, My.Resources.LC5})
        ElseIf FormOptions.RbtnT3.Checked = True Then
            listeImages.AddRange({My.Resources.Uno1, My.Resources.Uno2, My.Resources.Uno3,
                                 My.Resources.Uno4, My.Resources.Uno5})
        ElseIf FormOptions.RbtnT4.Checked = True Then
            listeImages.AddRange({My.Resources.Jojo1, My.Resources.Jojo2, My.Resources.Jojo3,
                                    My.Resources.Jojo4, My.Resources.Jojo5})
        ElseIf FormOptions.RbtnT5.Checked = True Then
            listeImages.AddRange({My.Resources.jjk11, My.Resources.jjk21, My.Resources.jjk3,
                                    My.Resources.jjk4, My.Resources.jjk5})
        End If
        listeImages.AddRange(listeImages)
        listeImages.AddRange(listeImages)
        listeCartes.Add(PictureBox1)
        listeCartes.Add(PictureBox2)
        listeCartes.Add(PictureBox3)
        listeCartes.Add(PictureBox4)
        listeCartes.Add(PictureBox5)
        listeCartes.Add(PictureBox6)
        listeCartes.Add(PictureBox7)
        listeCartes.Add(PictureBox8)
        listeCartes.Add(PictureBox9)
        listeCartes.Add(PictureBox10)
        listeCartes.Add(PictureBox11)
        listeCartes.Add(PictureBox12)
        listeCartes.Add(PictureBox13)
        listeCartes.Add(PictureBox14)
        listeCartes.Add(PictureBox15)
        listeCartes.Add(PictureBox16)
        listeCartes.Add(PictureBox17)
        listeCartes.Add(PictureBox18)
        listeCartes.Add(PictureBox19)
        listeCartes.Add(PictureBox20)

        Dim rand As New Random()
        listeImages = listeImages.OrderBy(Function() rand.Next()).ToList()

        For Each pb As PictureBox In listeCartes
            pb.Image = imageDos
        Next

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000
        time -= 1
        tempsJoueur += 1
        Dim minutes As Integer = time \ 60
        Dim secondes As Integer = (time Mod 60)
        If Label4.Text = "0:00" Then
            Timer1.Enabled = False
            If FormOptions.RbtnL1.Checked = True Then
                MsgBox("Temps écoulé!")
            ElseIf FormOptions.RbtnL2.Checked = True Then
                MsgBox("Time's up!")
            ElseIf FormOptions.RbtnL3.Checked = True Then
                MsgBox("时间限制已到!")
            End If
            Timer1.Stop()
            tempsJoueur = timeInitial

            Dim messages As New Dictionary(Of String, (Title As String, Message As String)) From {
    {"French", ("Résultat du joueur", "Temps écoulé !" & vbCrLf & "Carrés identifiés : " & pointsJoueur & vbCrLf & "Temps utilisé : " & tempsJoueur & " secondes")},
    {"English", ("Player Results", "Time's up!" & vbCrLf & "Correct matches: " & pointsJoueur & vbCrLf & "Time used: " & tempsJoueur & " seconds")},
    {"Chinese", ("玩家成绩", "时间到！" & vbCrLf & "正确配对: " & pointsJoueur & vbCrLf & "用时: " & tempsJoueur & " 秒")}
}

            Dim selectedLanguage As String = ""
            If FormOptions.RbtnL1.Checked Then
                selectedLanguage = "French"
            ElseIf FormOptions.RbtnL2.Checked Then
                selectedLanguage = "English"
            ElseIf FormOptions.RbtnL3.Checked Then
                selectedLanguage = "Chinese"
            End If

            If messages.ContainsKey(selectedLanguage) Then
                Dim msg = messages(selectedLanguage)
                MsgBox(msg.Message, MsgBoxStyle.Information, msg.Title)
            End If

            Module_Enregistrement.ChangerStats(Joueur, pointsJoueur, tempsJoueur, niveau)
            Me.Close()
            player.Stop()
            FormAccueil.Show()
        End If
        Label4.Text = minutes.ToString("0") & ":" & secondes.ToString("00")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click,
        PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click,
        PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click, PictureBox12.Click,
        PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click,
        PictureBox18.Click, PictureBox19.Click, PictureBox20.Click
        If Not Timer1.Enabled Then
            Timer1.Start()
        End If
        Timer2.Interval = 450

        Dim pbCliquee As PictureBox = CType(sender, PictureBox)
        If listeCartesFlipped.Contains(pbCliquee) Then Exit Sub
        If Timer2.Enabled OrElse Not pbCliquee.Enabled Then Exit Sub

        Dim indexCarte As Integer = listeCartes.IndexOf(pbCliquee)
        pbCliquee.Image = listeImages(indexCarte)
        listeCartesFlipped.Add(pbCliquee)

        If listeCartesFlipped.Count >= 1 Then
            Dim toutesIdentiques As Boolean = True
            Dim carteRetournee As Integer = 0

            carteRetournee = listeCartesFlipped.Count
            For i As Integer = 1 To carteRetournee - 1
                If Not listeCartesFlipped(i).Image.Equals(listeCartesFlipped(0).Image) Then
                    toutesIdentiques = False
                    Exit For
                End If
            Next
            If toutesIdentiques Then
                If carteRetournee = 4 Then
                    ' Bloque les cartes trouvées
                    For Each pbTrouve As PictureBox In listeCartesFlipped
                        pbTrouve.Enabled = False
                    Next
                    pointsJoueur += 1
                    listeCartesFlipped.Clear()
                End If
            Else
                If pbCliquee.Enabled Then
                    ' Sinon, déclenche Timer2 pour les retourner
                    Timer2.Start()
                End If
            End If
        End If

        If pointsJoueur = 5 Or Label4.Text.Equals("0:00") Then
            Timer1.Stop()
            If FormOptions.RbtnL1.Checked = True Then
                Message.lblMess.Text = "Bravoooo! Vous avez trouvé toutes les paires de cartes!"
            ElseIf FormOptions.RbtnL2.Checked = True Then
                Message.lblMess.Text = "You won! You found every pair of cards!"
            ElseIf FormOptions.RbtnL3.Checked = True Then
                Message.lblMess.Text = "你赢了！你找到了所有的卡片！"
            End If
            Me.Close()
            Message.ShowDialog()
            tempsJoueur = timeInitial - time
            Dim messages As New Dictionary(Of String, (Text As String, Title As String)) From {
    {"French", ($"Carrés identifiés : {pointsJoueur}{vbCrLf}Temps utilisé : {tempsJoueur} secondes", "Résultat du joueur")},
    {"English", ($"Time's up!{vbCrLf}Correct matches: {pointsJoueur}{vbCrLf}Time used: {tempsJoueur} seconds", "Player Results")},
    {"Chinese", ($"时间到！{vbCrLf}正确配对: {pointsJoueur}{vbCrLf}用时: {tempsJoueur} 秒", "玩家成绩")}
}
            Dim langue = If(FormOptions.RbtnL1.Checked, "French",
             If(FormOptions.RbtnL2.Checked, "English",
             If(FormOptions.RbtnL3.Checked, "Chinese", "")))

            If messages.ContainsKey(langue) Then
                MsgBox(messages(langue).Text, MsgBoxStyle.Information, messages(langue).Title)
            End If

            Module_Enregistrement.ChangerStats(Joueur, pointsJoueur, tempsJoueur, niveau)
            player.Stop()
            FormAccueil.Show()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        ' Réactive les cartes
        For Each pb As PictureBox In listeCartesFlipped
            pb.Enabled = True
            pb.Image = imageDos
        Next
        listeCartesFlipped.Clear()
    End Sub
End Class