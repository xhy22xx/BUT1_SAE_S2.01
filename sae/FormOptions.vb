Public Class FormOptions

    Dim DefaultTextbtnLancer As String
    Dim DefaultTextbtnQuitter As String
    Dim DefaultTextbtnAfficherScore As String

    Private Sub FormOptions_Initialisation()
        'Sauvegarde les texte initial (pour les changements de langues)
        DefaultTextbtnLancer = Form1.btnLancer.Text
        DefaultTextbtnQuitter = Form1.btnQuitter.Text
        DefaultTextbtnAfficherScore = Form1.btnAfficherScore.Text
    End Sub


    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'RbtnFacile.Checked = True
        'RbtnFacile.PerformClick()
        'RbtnL1.Checked = True
        'RbtnL1.PerformClick()
        'RbtnX1.Checked = True
        'RbtnX1.PerformClick()

    End Sub

    'A mettre dans les autres FORMULAIREEEEEEEEEEEEEEEEEEEEEEEEEEEE
    'If RadioButton1.Checked = True Then
    'TextBox1.Text = RadioButton1.Text
    'End If

    Private Sub btnValidation_Click(sender As Object, e As EventArgs) Handles btnValidation.Click
        If RbtnL1.Checked = True Then
            Form1.btnLancer.Text = DefaultTextbtnLancer 'Mettre en "" je pense
            Form1.btnQuitter.Text = DefaultTextbtnQuitter
            Form1.btnAfficherScore.Text = DefaultTextbtnAfficherScore
        ElseIf RbtnL2.Checked = True Then
            Form1.btnLancer.Text = "Launch"
            Form1.btnQuitter.Text = "Quit"
            Form1.btnAfficherScore.Text = "Display?"
        ElseIf RbtnL3.Checked = True Then
            MsgBox("pas encore fait pour L3")
        Else
            MsgBox("Erreur. Langue non choisit???")
        End If




        Me.Hide()
        Form1.Show()
    End Sub

End Class