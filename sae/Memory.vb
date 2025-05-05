Public Class Memory
    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim choix As MsgBoxResult = MsgBox("Êtes vous sûr de vouloir abandonner la partie en cours?", MsgBoxStyle.YesNo, "Confirmation")
        If choix = vbYes Then End
    End Sub



    lkjhgisqd
End Class