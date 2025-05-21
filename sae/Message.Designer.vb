<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblMess = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblMess
        ' 
        lblMess.Font = New Font("Bodoni MT", 10.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMess.ForeColor = Color.FromArgb(CByte(72), CByte(57), CByte(62))
        lblMess.Location = New Point(24, 99)
        lblMess.Name = "lblMess"
        lblMess.Size = New Size(647, 148)
        lblMess.TabIndex = 0
        lblMess.Text = "Mess"
        lblMess.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.MouseOverBackColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(72), CByte(57), CByte(62))
        Button1.Location = New Point(263, 269)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 53)
        Button1.TabIndex = 1
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Message
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.fond3
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(695, 406)
        Controls.Add(Button1)
        Controls.Add(lblMess)
        FormBorderStyle = FormBorderStyle.None
        Name = "Message"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblMess As Label
    Friend WithEvents Button1 As Button
End Class
