Public Class Options
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RbtnFacile.Checked = True
        RbtnFacile.PerformClick()

        RbtnL1.Checked = True
        RbtnL1.PerformClick()

        RbtnX1.Checked = True
        RbtnX1.PerformClick()

    End Sub

    'A mettre dans les autres FORMULAIREEEEEEEEEEEEEEEEEEEEEEEEEEEE
    'If RadioButton1.Checked = True Then
    'TextBox1.Text = RadioButton1.Text
    'End If

End Class