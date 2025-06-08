Imports System.Media
Imports System.Security.Cryptography

Public Class MemoryNormal
    Dim time As Integer
    Dim listeImages As New List(Of Image)
    Dim imageDos As Image
    Dim listeCartes As New List(Of PictureBox)
    Dim repetitionDesCartes As Integer = 4
    Dim listeCartesFlipped As New List(Of PictureBox)
    Dim pointsJoueur As Integer
    Dim tempsJoueur As Integer
    Dim timeInitial As Integer
    Public niveau As String
    Public Joueur As String
    Private player As New System.Media.SoundPlayer()
    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        GérerAbandonJeu(Me, player)
    End Sub
    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleJeu.AppliquerStyleEtSon(FormOptions.RbtnT1.Checked, FormOptions.RbtnT2.Checked, FormOptions.RbtnT3.Checked, FormOptions.RbtnT4.Checked, FormOptions.RbtnT5.Checked, lblJoueur, Label2, lblTempsR, Label4, Me, player, imageDos)
        timeInitial = 60
        ModuleJeu.InitialiserTempsJeu(timeInitial, time, pointsJoueur, tempsJoueur, Label4)

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
        listeImages = Enumerable.Repeat(listeImages, repetitionDesCartes).SelectMany(Function(x) x).ToList()
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


        PréparerImagesEtCartes(listeImages, listeCartes, imageDos)

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

            ModuleJeu.AfficherMessageTpsEcoule(pointsJoueur, tempsJoueur, FormOptions)

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
        ModuleJeu.VerifierCartesRetournees(listeCartesFlipped, pbCliquee, Timer2, pointsJoueur, repetitionDesCartes)


        If pointsJoueur = 5 Then
            Timer1.Stop()
            If FormOptions.RbtnL1.Checked = True Then
                Message.lblMess.Text = "Bravoooo! Vous avez trouvé toutes les paires de cartes!"
            ElseIf FormOptions.RbtnL2.Checked = True Then
                Message.lblMess.Text = "You won! You found every pair of cards!"
            ElseIf FormOptions.RbtnL3.Checked = True Then
                Message.lblMess.Text = "你赢了！你找到了所有的卡片！"
            End If
            Me.Close()
            tempsJoueur = timeInitial - time
            AfficherResultatGagne(pointsJoueur, tempsJoueur)

            Module_Enregistrement.ChangerStats(Joueur, pointsJoueur, tempsJoueur, niveau)
            player.Stop()
            FormAccueil.Show()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ModuleJeu.ReinitialiserCartes(listeCartesFlipped, imageDos, Timer2)
    End Sub
End Class