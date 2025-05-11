Public Class Memory
    Dim time As Integer
    Dim listeImages As New List(Of Image)
    Dim listeCartes As New List(Of PictureBox)


    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim choix As MsgBoxResult = MsgBox("Êtes vous sûr de vouloir abandonner la partie en cours?", MsgBoxStyle.YesNo, "Confirmation")
        If choix = vbYes Then End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        time = 61
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
        time = time - 1
        Dim minutes As Integer = time \ 60
        Dim secondes As Integer = (time Mod 60)
        If Label4.Text = "0:01" Then
            Timer1.Enabled = False
            MsgBox("Temps écoulé!")
            Timer1.Stop()
        End If
        Label4.Text = minutes.ToString("0") & ":" & secondes.ToString("00")
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click,
        PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click,
        PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click, PictureBox12.Click,
        PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click,
        PictureBox18.Click, PictureBox19.Click, PictureBox20.Click

        Dim pbCliquee As PictureBox = CType(sender, PictureBox)
        Dim nom As String = pbCliquee.Name
        pbCliquee.Image = listeImages(listeCartes.IndexOf(pbCliquee))


    End Sub
End Class