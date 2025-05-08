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
        listeImages.Add(My.Resources.Celebi)
        listeImages.Add(My.Resources.Celebi)
        listeImages.Add(My.Resources.Celebi)
        listeImages.Add(My.Resources.Celebi)
        listeImages.Add(My.Resources.Mew)
        listeImages.Add(My.Resources.Mew)
        listeImages.Add(My.Resources.Mew)
        listeImages.Add(My.Resources.Mew)
        listeImages.Add(My.Resources.Marill)
        listeImages.Add(My.Resources.Marill)
        listeImages.Add(My.Resources.Marill)
        listeImages.Add(My.Resources.Marill)
        listeImages.Add(My.Resources.Dracaufeu)
        listeImages.Add(My.Resources.Dracaufeu)
        listeImages.Add(My.Resources.Dracaufeu)
        listeImages.Add(My.Resources.Dracaufeu)
        listeImages.Add(My.Resources.Evoli)
        listeImages.Add(My.Resources.Evoli)
        listeImages.Add(My.Resources.Evoli)
        listeImages.Add(My.Resources.Evoli)


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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class