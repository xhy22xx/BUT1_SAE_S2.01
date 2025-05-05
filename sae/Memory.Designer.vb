<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Memory
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnAbandon = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 32)
        Label1.TabIndex = 0
        Label1.Text = "- Joueur:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(199, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 32)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(418, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 32)
        Label3.TabIndex = 2
        Label3.Text = "- Temps restant:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(631, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 32)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        ' 
        ' btnAbandon
        ' 
        btnAbandon.Location = New Point(840, 49)
        btnAbandon.Name = "btnAbandon"
        btnAbandon.Size = New Size(150, 46)
        btnAbandon.TabIndex = 4
        btnAbandon.Text = "Abandon"
        btnAbandon.UseVisualStyleBackColor = True
        ' 
        ' Memory
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1190, 859)
        Controls.Add(btnAbandon)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Memory"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAbandon As Button
End Class
