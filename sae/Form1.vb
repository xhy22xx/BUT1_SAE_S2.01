Public Class Form1
    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        If cbxNom.Text.Length >= 3 Then
            Form2.Show()
        End If
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim choix As MsgBoxResult = MsgBox("Êtes vous sûr de vouloir quitter l'application?", MsgBoxStyle.YesNo, "Confirmation")
        If choix = vbYes Then End
    End Sub


End Class
