Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Module ModuleJeu

    Friend Function GriserImage(source As Image) As Image
        Dim bmp As New Bitmap(source.Width, source.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim colorMatrix As New Imaging.ColorMatrix({
        New Single() {0.3, 0.3, 0.3, 0, 0},
        New Single() {0.59, 0.59, 0.59, 0, 0},
        New Single() {0.11, 0.11, 0.11, 0, 0},
        New Single() {0, 0, 0, 1, 0},
        New Single() {0, 0, 0, 0, 1}
    })

        Dim attributes As New Imaging.ImageAttributes()
        attributes.SetColorMatrix(colorMatrix)

        g.DrawImage(source,
                New Rectangle(0, 0, bmp.Width, bmp.Height),
                0, 0, source.Width, source.Height,
                GraphicsUnit.Pixel, attributes)

        g.Dispose()
        attributes.Dispose()

        Return bmp
    End Function

    Friend Sub GérerAbandonJeu(formAppelant As Form, lecteurSon As System.Media.SoundPlayer)
        If FormOptions.RbtnL1.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Voulez-vous abandonner la partie en cours?"
        ElseIf FormOptions.RbtnL2.Checked = True Then
            formConfirmation.lblConfirmation.Text = "Do you want to quit the current game?"
        ElseIf FormOptions.RbtnL3.Checked = True Then
            formConfirmation.lblConfirmation.Text = "你确定要放弃当前游戏吗？"
        End If

        Dim result As DialogResult = formConfirmation.ShowDialog()

        If result = DialogResult.Yes Then
            lecteurSon.Stop()
            formAppelant.Close()
            FormAccueil.Show()
        End If
    End Sub

    Friend Sub AppliquerStyleEtSon(RbtnT1Checked As Boolean, RbtnT2Checked As Boolean, RbtnT3Checked As Boolean, RbtnT4Checked As Boolean, RbtnT5Checked As Boolean, lblJoueur As Label, Label2 As Label, lblTempsR As Label, Label4 As Label, form As Form, ByRef player As System.Media.SoundPlayer, ByRef imageDos As Image)
        If RbtnT1Checked Or RbtnT2Checked Or RbtnT3Checked Then
            lblJoueur.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            lblTempsR.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            form.BackColor = Color.White

            If RbtnT1Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\PokemonTGC.wav"
                imageDos = My.Resources.Carte_pokemon_dos

            ElseIf RbtnT2Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\LinkClickOpening.wav"
                imageDos = My.Resources.LC

            ElseIf RbtnT3Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\Chopin.wav"
                imageDos = My.Resources.Uno_Dos
            End If


        ElseIf RbtnT4Checked Or RbtnT5Checked Then
            lblJoueur.ForeColor = Color.White
            Label2.ForeColor = Color.White
            lblTempsR.ForeColor = Color.White
            Label4.ForeColor = Color.White
            form.BackColor = Color.Black
            If RbtnT4Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\naranciaMusic.wav"
                imageDos = My.Resources.Jojo_Dos
            ElseIf RbtnT5Checked Then
                player.SoundLocation = Application.StartupPath & "\Resources\jujutsuOpening.wav"
                imageDos = My.Resources.jjk_Dos
            End If
        End If
        player.Play()
    End Sub

    Friend Sub InitialiserTempsJeu(timeInitial As Integer, ByRef time As Integer, ByRef pointsJoueur As Integer, ByRef tempsJoueur As Integer, labelTemps As Label)
        time = timeInitial
        pointsJoueur = 0
        tempsJoueur = 0

        Dim minutes As Integer = time \ 60
        Dim secondes As Integer = time Mod 60
        labelTemps.Text = minutes.ToString("0") & ":" & secondes.ToString("00")
    End Sub

    Public Sub PréparerImagesEtCartes(
    ByRef listeImages As List(Of Image),
    ByRef listeCartes As List(Of PictureBox),
    imageDos As Image
)
        Dim rand As New Random()
        listeImages = listeImages.OrderBy(Function() rand.Next()).ToList()

        For Each pb As PictureBox In listeCartes
            pb.Image = imageDos
        Next
    End Sub

    Friend Sub AfficherMessageTpsEcoule(pointsJoueur As Integer, tempsJoueur As Integer, formOptions As FormOptions)
        Dim messages As New Dictionary(Of String, (Title As String, Message As String)) From {
        {"French", ("Résultat du joueur", "Temps écoulé !" & vbCrLf & "Carrés identifiés : " & pointsJoueur & vbCrLf & "Temps utilisé : " & tempsJoueur & " secondes")},
        {"English", ("Player Results", "Time's up!" & vbCrLf & "Correct matches: " & pointsJoueur & vbCrLf & "Time used: " & tempsJoueur & " seconds")},
        {"Chinese", ("玩家成绩", "时间到！" & vbCrLf & "正确配对: " & pointsJoueur & vbCrLf & "用时: " & tempsJoueur & " 秒")}
        }

        Dim selectedLanguage As String = ""
        If formOptions.RbtnL1.Checked Then
            selectedLanguage = "French"
        ElseIf formOptions.RbtnL2.Checked Then
            selectedLanguage = "English"
        ElseIf formOptions.RbtnL3.Checked Then
            selectedLanguage = "Chinese"
        End If

        If messages.ContainsKey(selectedLanguage) Then
            Dim msg = messages(selectedLanguage)
            MsgBox(msg.Message, MsgBoxStyle.Information, msg.Title)
        End If
    End Sub
    Friend Sub VerifierCartesRetournees(ByRef listeCartesFlipped As List(Of PictureBox), pbCliquee As PictureBox, timerRetour As Timer, ByRef pointsJoueur As Integer, nombreCartesIdentiques As Integer)
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
                If carteRetournee = nombreCartesIdentiques Then
                    For Each pbTrouve As PictureBox In listeCartesFlipped
                        pbTrouve.Enabled = False
                        pbTrouve.Image = GriserImage(pbTrouve.Image)
                    Next
                    pointsJoueur += 1
                    listeCartesFlipped.Clear()
                End If
            Else
                If pbCliquee.Enabled Then
                    timerRetour.Start()
                End If
            End If
        End If

    End Sub

    Friend Sub AfficherResultatGagne(pointsJoueur As Integer, tempsJoueur As Integer)
        Message.ShowDialog()
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
    End Sub
    Friend Sub ReinitialiserCartes(listeCartesFlipped As List(Of PictureBox), imageDos As Image, timer As Timer)
        timer.Stop()
        For Each pb As PictureBox In listeCartesFlipped
            pb.Enabled = True
            pb.Image = imageDos
        Next
        listeCartesFlipped.Clear()
    End Sub
End Module
