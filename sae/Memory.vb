Imports System.Security.Cryptography

Public Class Memory
    Dim time As Integer = 60
    Dim listeImages As New List(Of Image)
    Dim listeCartes As New List(Of PictureBox)
    Dim listeCartesFlipped As New List(Of PictureBox)
    Dim compteurCarteRetournee As Integer
    Dim pointsJoueur As Integer
    Dim tempsJoueur As Integer
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
        pointsJoueur = 0
        tempsJoueur = 0
        Dim minutes As Integer = time \ 60
        Dim secondes As Integer = (time Mod 60)
        Label4.Text = minutes.ToString("0") & ":" & secondes.ToString("00")
        'j'ajoute nos images dans une liste
        listeImages.Clear()
        listeImages.AddRange({My.Resources.Celebi, My.Resources.Mew, My.Resources.Marill,
                              My.Resources.Dracaufeu, My.Resources.Evoli})
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


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000
        time -= 1
        tempsJoueur += 1
        Dim minutes As Integer = time \ 60
        Dim secondes As Integer = (time Mod 60)
        If Label4.Text = "0:01" Then
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
        If compteurCarteRetournee >= 1 Then
            For Each pb As PictureBox In listeCartesFlipped
                If Not pbCliquee.Image.Equals(pb.Image) Then
                    Timer2.Start()
                    For Each pbF As PictureBox In listeCartes
                        pbF.Enabled = False
                    Next
                    Exit For
                ElseIf pbCliquee.Image.Equals(pb.Image) Then
                    compteurCarteRetournee += 1
                End If
            Next
        Else compteurCarteRetournee += 1
        End If
        If compteurCarteRetournee = 4 Then 'And listeCartesFlipped(3).Image.Equals(listeCartesFlipped(2)) Then
            For Each pbTrouvé As PictureBox In listeCartesFlipped
                pbTrouvé.Enabled = False
            Next
            listeCartesFlipped.Clear()
            compteurCarteRetournee = 0
            pointsJoueur += 1
        End If

        If pointsJoueur = 5 Or Label4.Text.Equals("0:00") Then
            Timer1.Stop()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        ' Réactive les cartes
        For Each pbE As PictureBox In listeCartes
            pbE.Enabled = True
        Next
        For Each pbF As PictureBox In listeCartesFlipped
            pbF.Image = My.Resources.Carte_pokemon_dos
        Next
        compteurCarteRetournee = 0
        listeCartesFlipped.Clear()
    End Sub
End Class