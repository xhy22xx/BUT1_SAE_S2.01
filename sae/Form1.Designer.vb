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
        btnOptions = New Button()
        SuspendLayout()
        ' 
        ' cbxNoms
        ' 
        cbxNoms.FormattingEnabled = True
        cbxNoms.Location = New Point(90, 115)
        cbxNoms.Margin = New Padding(2)
        cbxNoms.Name = "cbxNoms"
        cbxNoms.Size = New Size(132, 23)
        cbxNoms.TabIndex = 0
        ' 
        ' btnLancer
        ' 
        btnLancer.Location = New Point(90, 244)
        btnLancer.Margin = New Padding(2)
        btnLancer.Name = "btnLancer"
        btnLancer.Size = New Size(89, 38)
        btnLancer.TabIndex = 1
        btnLancer.Text = "Lancement"
        btnLancer.UseVisualStyleBackColor = True
        ' 
        ' btnQuitter
        ' 
        btnQuitter.Location = New Point(237, 244)
        btnQuitter.Margin = New Padding(2)
        btnQuitter.Name = "btnQuitter"
        btnQuitter.Size = New Size(89, 38)
        btnQuitter.TabIndex = 2
        btnQuitter.Text = "Quitter"
        btnQuitter.UseVisualStyleBackColor = True
        ' 
        ' btnAfficherScore
        ' 
        btnAfficherScore.Location = New Point(385, 244)
        btnAfficherScore.Margin = New Padding(2)
        btnAfficherScore.Name = "btnAfficherScore"
        btnAfficherScore.Size = New Size(89, 38)
        btnAfficherScore.TabIndex = 3
        btnAfficherScore.Text = "Affichage"
        btnAfficherScore.UseVisualStyleBackColor = True
        ' 
        ' btnOptions
        ' 
        btnOptions.Location = New Point(488, 12)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(75, 23)
        btnOptions.TabIndex = 4
        btnOptions.Text = "Options"
        btnOptions.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 365)
        Controls.Add(btnOptions)
        Controls.Add(btnAfficherScore)
        Controls.Add(btnQuitter)
        Controls.Add(btnLancer)
        Controls.Add(cbxNoms)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Accueil"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbxNoms As ComboBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnAfficherScore As Button
    Friend WithEvents btnOptions As Button

End Class
