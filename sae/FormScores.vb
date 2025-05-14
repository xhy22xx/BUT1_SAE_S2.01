Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormScores
    'Faudrait enlever ca
    Dim tnoms() As String = {"le russe", "paracétamol", "amoxiciline", "doliprane", "smecta", "protagoniste", "sarah", "fitia", "eva", "celia"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxJoueur.Items.AddRange(tnoms) 'A enlever aussi
        LstJoueurs.Items.Add("sarah")
        LstJoueurs.Items.Add("celia")
        LstJoueurs.Items.Add("fitia")
        LstJoueurs.Items.Add("eva")

        LstCarres.Items.Add(2)
        LstCarres.Items.Add(2)
        LstCarres.Items.Add(3)
        LstCarres.Items.Add(3)

        LstTempsM.Items.Add(60)
        LstTempsM.Items.Add(50)
        LstTempsM.Items.Add(45)
        LstTempsM.Items.Add(60)

        LstParties.Items.Add(3)
        LstParties.Items.Add(6)
        LstParties.Items.Add(9)
        LstParties.Items.Add(5)

        LstTempsT.Items.Add(180)
        LstTempsT.Items.Add(200)
        LstTempsT.Items.Add(270)
        LstTempsT.Items.Add(300)



    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles LstJoueurs.SelectedIndexChanged,
            LstCarres.SelectedIndexChanged,
            LstTempsM.SelectedIndexChanged,
            LstParties.SelectedIndexChanged,
            LstTempsT.SelectedIndexChanged

        Dim source As ListBox = CType(sender, ListBox)
        Dim index As Integer = source.SelectedIndex

        If index >= 0 Then
            LstJoueurs.SelectedIndex = index
            LstCarres.SelectedIndex = index
            LstTempsM.SelectedIndex = index
            LstParties.SelectedIndex = index
            LstTempsT.SelectedIndex = index
        End If
    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        Dim nom As String = ComboBoxJoueur.Text.Trim()
        Dim index As Integer = LstJoueurs.Items.IndexOf(nom)

        If nom = "" Then
            MsgBox("Veuillez entrer un nom.")
            Exit Sub
        End If

        If index >= 0 Then
            Dim message As String = "Joueur : " & LstJoueurs.Items(index).ToString() & vbCrLf &
                                    "Carrés identifiés : " & LstCarres.Items(index).ToString() & vbCrLf &
                                    "Temps minimum : " & LstTempsM.Items(index).ToString() & " s" & vbCrLf &
                                    "Parties jouées : " & LstParties.Items(index).ToString() & vbCrLf &
                                    "Temps total de jeu: " & LstTempsT.Items(index).ToString() & " s"

            MsgBox(message, MsgBoxStyle.Information, "Statistiques")
        Else
            MsgBox("Joueur non trouvé.")
        End If
    End Sub



    Private ordreCroissant As Boolean = True

    Private Sub btnTrier_Click(sender As Object, e As EventArgs) Handles BtnTrier.Click
        Dim joueurs = New List(Of (Nom As String, Carres As Integer, TempsMin As String, Parties As String, TempsTotal As String))()

        For i = 0 To LstJoueurs.Items.Count - 1
            joueurs.Add((LstJoueurs.Items(i), CInt(LstCarres.Items(i)), LstTempsM.Items(i), LstParties.Items(i), LstTempsT.Items(i)))
        Next

        If ordreCroissant Then
            joueurs = joueurs.OrderBy(Function(j) j.Carres).ThenBy(Function(j) j.TempsMin).ToList()
        Else
            joueurs = joueurs.OrderByDescending(Function(j) j.Carres).ThenBy(Function(j) j.TempsMin).ToList()
        End If

        LstJoueurs.Items.Clear()
        LstCarres.Items.Clear()
        LstTempsM.Items.Clear()
        LstParties.Items.Clear()
        LstTempsT.Items.Clear()

        For Each j In joueurs
            LstJoueurs.Items.Add(j.Nom)
            LstCarres.Items.Add(j.Carres)
            LstTempsM.Items.Add(j.TempsMin)
            LstParties.Items.Add(j.Parties)
            LstTempsT.Items.Add(j.TempsTotal)
        Next

        ordreCroissant = Not ordreCroissant
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub LJoueur_Click(sender As Object, e As EventArgs) Handles LJoueur.Click

    End Sub
End Class
