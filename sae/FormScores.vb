Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormScores

    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim personnes As PERS() = Module_Enregistrement.GetPersonnes()

        ComboBoxNiveau.Items.Clear()
        ComboBoxNiveau.Items.AddRange({"Facile", "Moyen", "Difficile"})
        ComboBoxNiveau.SelectedIndex = 0

        ComboBoxNiveau_SelectedIndexChanged(Nothing, Nothing)


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
            If FormOptions.RbtnL1.Checked = True Then
                MsgBox("Veuillez entrer un nom.", MsgBoxStyle.Information, "Erreur d'entrée")
            ElseIf FormOptions.RbtnL2.Checked = True Then
                MsgBox("Please enter a name.", MsgBoxStyle.Information, "Input error")
            ElseIf FormOptions.RbtnL3.Checked = True Then
                MsgBox("请输入玩家名称。", MsgBoxStyle.Information, "输入错误")
            End If
            Exit Sub
        End If

        If index >= 0 Then
            If FormOptions.RbtnL1.Checked Then
                Dim message As String = "Joueur : " & LstJoueurs.Items(index).ToString() & vbCrLf &                         'Ajouter les autres langues aussi ici je crois
                                    "Carrés identifiés : " & LstCarres.Items(index).ToString() & vbCrLf &
                                    "Temps minimum : " & LstTempsM.Items(index).ToString() & " s" & vbCrLf &
                                    "Parties jouées : " & LstParties.Items(index).ToString() & vbCrLf &
                                    "Temps total de jeu: " & LstTempsT.Items(index).ToString() & " s"

                MsgBox(message, MsgBoxStyle.Information, "Statistiques")
            ElseIf FormOptions.RbtnL2.Checked Then
                Dim message As String = "Player: " & LstJoueurs.Items(index).ToString() & vbCrLf &
                                    "Squares identified: " & LstCarres.Items(index).ToString() & vbCrLf &
                                    "Minimum time: " & LstTempsM.Items(index).ToString() & " s" & vbCrLf &
                                    "Games played: " & LstParties.Items(index).ToString() & vbCrLf &
                                    "Total playtime: " & LstTempsT.Items(index).ToString() & " s"
                MsgBox(message, MsgBoxStyle.Information, "Statistics")
            ElseIf FormOptions.RbtnL3.Checked Then
                Dim message As String = "玩家：" & LstJoueurs.Items(index).ToString() & vbCrLf &
                                    "识别的方块：" & LstCarres.Items(index).ToString() & vbCrLf &
                                    "最短时间：" & LstTempsM.Items(index).ToString() & " 秒" & vbCrLf &
                                    "玩过的游戏：" & LstParties.Items(index).ToString() & vbCrLf &
                                    "总游戏时间：" & LstTempsT.Items(index).ToString() & " 秒"
                MsgBox(message, MsgBoxStyle.Information, "统计数据")
            End If
        Else
            If FormOptions.RbtnL1.Checked = True Then
                MsgBox("Joueur non trouvé.", MsgBoxStyle.Information, "Joueur inexistant")
            ElseIf FormOptions.RbtnL2.Checked = True Then
                MsgBox("Player not found.", MsgBoxStyle.Information, "Ghost player? They don’t exist!")
            ElseIf FormOptions.RbtnL3.Checked = True Then
                MsgBox("未找到玩家。", MsgBoxStyle.Information, "玩家不存在！")
            End If
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

    Private Sub ComboBoxNiveau_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNiveau.SelectedIndexChanged
        Dim niveauChoisi As String = ComboBoxNiveau.SelectedItem.ToString()

        LstJoueurs.Items.Clear()
        LstCarres.Items.Clear()
        LstTempsM.Items.Clear()
        LstParties.Items.Clear()
        LstTempsT.Items.Clear()

        Dim personnes = Module_Enregistrement.GetPersonnes()
        If personnes Is Nothing Then Exit Sub

        For Each p In personnes
            If p.Niveau IsNot Nothing AndAlso p.Niveau = niveauChoisi Then
                LstJoueurs.Items.Add(p.Nom)
                LstCarres.Items.Add(p.Carres)
                LstTempsM.Items.Add(p.TempsMin)
                LstParties.Items.Add(p.Parties)
                LstTempsT.Items.Add(p.TempsTotal)
            End If
        Next

        ComboBoxJoueur.Items.Clear()
        For Each p In personnes
            If p.Niveau = niveauChoisi AndAlso Not ComboBoxJoueur.Items.Contains(p.Nom) Then
                ComboBoxJoueur.Items.Add(p.Nom)
            End If
        Next
    End Sub
End Class
