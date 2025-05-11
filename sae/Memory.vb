Public Class Memory
    Dim time As Integer
    Dim listeImages As New List(Of Image)

    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim choix As MsgBoxResult = MsgBox("Êtes vous sûr de vouloir abandonner la partie en cours?", MsgBoxStyle.YesNo, "Confirmation")
        If choix = vbYes Then End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
    Private Sub Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        time = 61
        listeImages.Clear()
        listeImages.AddRange({My.Resources.Celebi, My.Resources.Mew, My.Resources.Marill,
                              My.Resources.Dracaufeu, My.Resources.Evoli})
        listeImages.AddRange(listeImages)
        listeImages.AddRange(listeImages)
        listeImages.AddRange(listeImages)
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

    End Sub
End Class