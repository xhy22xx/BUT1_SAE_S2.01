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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        cbxNoms = New ComboBox()
        btnLancer = New Button()
        btnQuitter = New Button()
        btnAfficherScore = New Button()
        btnOptions = New Button()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        ButtonStopMusic = New Button()
        ButtonContinueMusic = New Button()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbxNoms
        ' 
        cbxNoms.FormattingEnabled = True
        cbxNoms.Location = New Point(103, 153)
        cbxNoms.Margin = New Padding(2, 3, 2, 3)
        cbxNoms.Name = "cbxNoms"
        cbxNoms.Size = New Size(150, 28)
        cbxNoms.TabIndex = 0
        ' 
        ' btnLancer
        ' 
        btnLancer.Location = New Point(91, 325)
        btnLancer.Margin = New Padding(2, 3, 2, 3)
        btnLancer.Name = "btnLancer"
        btnLancer.Size = New Size(114, 51)
        btnLancer.TabIndex = 1
        btnLancer.Text = "Lancer"
        btnLancer.UseVisualStyleBackColor = True
        ' 
        ' btnQuitter
        ' 
        btnQuitter.Location = New Point(259, 325)
        btnQuitter.Margin = New Padding(2, 3, 2, 3)
        btnQuitter.Name = "btnQuitter"
        btnQuitter.Size = New Size(114, 51)
        btnQuitter.TabIndex = 2
        btnQuitter.Text = "Quitter"
        btnQuitter.UseVisualStyleBackColor = True
        ' 
        ' btnAfficherScore
        ' 
        btnAfficherScore.Location = New Point(428, 325)
        btnAfficherScore.Margin = New Padding(2, 3, 2, 3)
        btnAfficherScore.Name = "btnAfficherScore"
        btnAfficherScore.Size = New Size(114, 51)
        btnAfficherScore.TabIndex = 3
        btnAfficherScore.Text = "Afficher Score"
        btnAfficherScore.UseVisualStyleBackColor = True
        ' 
        ' btnOptions
        ' 
        btnOptions.Location = New Point(558, 16)
        btnOptions.Margin = New Padding(3, 4, 3, 4)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(86, 31)
        btnOptions.TabIndex = 4
        btnOptions.Text = "Options"
        btnOptions.UseVisualStyleBackColor = True
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(12, 441)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(222, 34)
        AxWindowsMediaPlayer1.TabIndex = 5
        ' 
        ' ButtonStopMusic
        ' 
        ButtonStopMusic.Location = New Point(558, 141)
        ButtonStopMusic.Name = "ButtonStopMusic"
        ButtonStopMusic.Size = New Size(94, 29)
        ButtonStopMusic.TabIndex = 6
        ButtonStopMusic.Text = "Stop Music"
        ButtonStopMusic.UseVisualStyleBackColor = True
        ' 
        ' ButtonContinueMusic
        ' 
        ButtonContinueMusic.Location = New Point(551, 185)
        ButtonContinueMusic.Name = "ButtonContinueMusic"
        ButtonContinueMusic.Size = New Size(106, 29)
        ButtonContinueMusic.TabIndex = 7
        ButtonContinueMusic.Text = "Ecoute Music"
        ButtonContinueMusic.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(669, 487)
        Controls.Add(ButtonContinueMusic)
        Controls.Add(ButtonStopMusic)
        Controls.Add(AxWindowsMediaPlayer1)
        Controls.Add(btnOptions)
        Controls.Add(btnAfficherScore)
        Controls.Add(btnQuitter)
        Controls.Add(btnLancer)
        Controls.Add(cbxNoms)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form1"
        Text = "Accueil"
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbxNoms As ComboBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnAfficherScore As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ButtonStopMusic As Button
    Friend WithEvents ButtonContinueMusic As Button

End Class
