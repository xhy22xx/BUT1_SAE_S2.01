<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cbxNoms = New ComboBox()
        btnLancer = New Button()
        btnQuitter = New Button()
        btnAfficherScore = New Button()
        SuspendLayout()
        ' 
        ' cbxNoms
        ' 
        cbxNoms.FormattingEnabled = True
        cbxNoms.Location = New Point(155, 122)
        cbxNoms.Name = "cbxNoms"
        cbxNoms.Size = New Size(224, 38)
        cbxNoms.TabIndex = 0
        ' 
        ' btnLancer
        ' 
        btnLancer.Location = New Point(240, 435)
        btnLancer.Name = "btnLancer"
        btnLancer.Size = New Size(138, 43)
        btnLancer.TabIndex = 1
        btnLancer.Text = "Lancement"
        btnLancer.UseVisualStyleBackColor = True
        ' 
        ' btnQuitter
        ' 
        btnQuitter.Location = New Point(537, 435)
        btnQuitter.Name = "btnQuitter"
        btnQuitter.Size = New Size(138, 43)
        btnQuitter.TabIndex = 2
        btnQuitter.Text = "Quitter"
        btnQuitter.UseVisualStyleBackColor = True
        ' 
        ' btnAfficherScore
        ' 
        btnAfficherScore.Location = New Point(819, 435)
        btnAfficherScore.Name = "btnAfficherScore"
        btnAfficherScore.Size = New Size(138, 43)
        btnAfficherScore.TabIndex = 3
        btnAfficherScore.Text = "Affichage"
        btnAfficherScore.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1221, 684)
        Controls.Add(btnAfficherScore)
        Controls.Add(btnQuitter)
        Controls.Add(btnLancer)
        Controls.Add(cbxNoms)
        Name = "Form1"
        Text = "Accueil"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbxNoms As ComboBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnAfficherScore As Button

End Class
