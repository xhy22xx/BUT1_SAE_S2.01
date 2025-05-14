Imports System.Diagnostics.Eventing.Reader

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim personne As PERS() = Module_Enregistrement.GetPersonnes()

        If personne IsNot Nothing AndAlso personne.Length > 0 Then
            For Each s As PERS In personne
                cbxNoms.Items.Add(s.Nom)
            Next
        End If
    End Sub

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        If cbxNoms.Text = "" Then
            MsgBox("Nom obligatoire.")
            cbxNoms.Focus()
            Exit Sub
        End If

        If cbxNoms.Text.Length < 3 Then
            MsgBox("Veuillez entrez un nom d’au moins 3 caractères.", MsgBoxStyle.Information, "Nom invalide")
            cbxNoms.Focus()

        Else
            Dim name As String = cbxNoms.Text
            Memory.Show()
            Module_Enregistrement.AJOUT(name)
            Memory.Label2.Text = name
        End If

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim choix As MsgBoxResult = MsgBox("Êtes vous sûr de vouloir quitter l'application?", MsgBoxStyle.YesNo, "Confirmation")
        If choix = vbYes Then End
    End Sub

    Private Sub btnAfficherScore_Click(sender As Object, e As EventArgs) Handles btnAfficherScore.Click
        FormScores.Show()
    End Sub


    Private Sub cbxNoms_alphabet(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbxNoms.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cbxNoms.Items.Clear()
        Dim personnes As PERS() = Module_Enregistrement.GetPersonnes()
        If personnes IsNot Nothing Then
            For Each s As PERS In personnes
                cbxNoms.Items.Add(s.Nom)
            Next
        End If
    End Sub



    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Options.Show()
    End Sub
End Class