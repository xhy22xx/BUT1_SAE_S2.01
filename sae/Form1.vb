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
        Dim nomValide As Boolean = False

        If cbxNoms.Text.Length < 3 Then
            Exit Sub
        End If

        For Each s As String In tnoms
            If s = cbxNoms.Text Then
                nomValide = True
                Exit For
            End If
        Next

        If nomValide = False Then
            cbxNoms.Focus()
            Exit Sub
        End If

        Dim nom As String = cbxNoms.Text
        Memory.Show()
        Memory.Label2.Text = nom

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim choix As MsgBoxResult = MsgBox("Êtes vous sûr de vouloir quitter l'application?", MsgBoxStyle.YesNo, "Confirmation")
        If choix = vbYes Then End
    End Sub

    Private Sub btnAfficherScore_Click(sender As Object, e As EventArgs) Handles btnAfficherScore.Click
        FormScores.Show()
    End Sub
End Class
