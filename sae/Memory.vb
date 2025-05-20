Imports System.Security.Cryptography

Public Class Memory
    Dim time As Integer
    Dim listeImages As New List(Of Image)
    Dim imageDos As Image
    Dim listeCartes As New List(Of PictureBox)
    Dim listeCartesFlipped As New List(Of PictureBox)
    Dim compteurCarteRetournee As Integer
    Dim pointsJoueur As Integer
    Dim tempsJoueur As Integer
    Dim timeInitial As Integer
    'Dim pictureBoxes As PictureBox() = {
    'PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5,
    'PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10,
    'PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15,
    'PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20}
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
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormOptions.RbtnT1.Checked Then
            imageDos = My.Resources.Carte_pokemon_dos
        ElseIf FormOptions.RbtnT2.Checked Then
            imageDos = My.Resources.LC
        End If
        timeInitial = 60
        time = timeInitial
        pointsJoueur = 0
        tempsJoueur = 0
        Dim minutes As Integer = time \ 60
        Dim secondes As Integer = (time Mod 60)
        Label4.Text = minutes.ToString("0") & ":" & secondes.ToString("00")
        'j'ajoute nos images dans une liste
        listeImages.Clear()
        If FormOptions.RbtnT1.Checked = True Then
            listeImages.AddRange({My.Resources.Celebi, My.Resources.Mew, My.Resources.Marill,
                              My.Resources.Dracaufeu, My.Resources.Evoli})
        ElseIf FormOptions.RbtnT2.Checked = True Then
            'Modifier le dos des cartes. Je n'y arrive pas TvT
            listeImages.AddRange({My.Resources.LC1, My.Resources.LC2, My.Resources.LC3,
                                 My.Resources.LC4, My.Resources.LC5})
        ElseIf FormOptions.RbtnT3.Checked = True Then

            'Les autres cartes
        Else
            MsgBox("Erreur qq part")
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
        tempsJoueur += 1                       'Faut stocker le temps du joueur qq part
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
        pbCliquee.Image = listeImages(listeCartes.IndexOf(pbCliquee))
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
                ' Sinon, déclenche Timer2 pour les retourner
                Timer2.Start()
                For Each pb As PictureBox In listeCartes
                    pb.Enabled = False
                Next
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
            Message.ShowDialog()
            tempsJoueur = timeInitial - time
            'Est ce que il faut que la personne sort le memory??
            'Memory.Close()
            'Il faudrait plutot montrer au joueur le score et le temps qu'il a pris pour réussir à retourner les cartes

            Dim resultat As String = "Carrés identifiés : " & pointsJoueur & vbCrLf &
                                "Temps utilisé : " & tempsJoueur & " secondes"

            MsgBox(resultat, MsgBoxStyle.Information, "Resultat du joueur")
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        ' Réactive les cartes
        For Each pbE As PictureBox In listeCartes
            pbE.Enabled = True
        Next
        For Each pbF As PictureBox In listeCartesFlipped
            pbF.Image = imageDos
        Next
        compteurCarteRetournee = 0
        listeCartesFlipped.Clear()
    End Sub
End Class