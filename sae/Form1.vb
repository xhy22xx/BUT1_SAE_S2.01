Imports System.Diagnostics.Eventing.Reader

Public Class Form1

    Dim tnoms() As String = {"le russe", "paracétamol", "amoxiciline", "doliprane", "smecta", "protagoniste", "sarah", "fitia", "eva", "celia"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        For Each s As String In tnoms
            cbxNoms.Items.Add(tnoms(i))
            i += 1
        Next
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
            Dim nom As String = cbxNoms.Text
            Memory.Show()
            Memory.Label2.Text = nom
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

End Class