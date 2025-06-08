<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccueil))
        cbxNoms = New ComboBox()
        btnLancer = New Button()
        btnOptions = New Button()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        ButtonStopMusic = New Button()
        ButtonContinueMusic = New Button()
        btnQuitter = New Button()
        btnAfficherScore = New Button()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbxNoms
        ' 
        cbxNoms.BackColor = SystemColors.InfoText
        cbxNoms.FlatStyle = FlatStyle.Flat
        cbxNoms.ForeColor = SystemColors.ButtonHighlight
        cbxNoms.FormattingEnabled = True
        cbxNoms.Location = New Point(339, 273)
        cbxNoms.Margin = New Padding(3, 5, 3, 5)
        cbxNoms.Name = "cbxNoms"
        cbxNoms.Size = New Size(241, 40)
        cbxNoms.TabIndex = 0
        ' 
        ' btnLancer
        ' 
        btnLancer.BackColor = Color.Transparent
        btnLancer.BackgroundImage = My.Resources.Resources.button
        btnLancer.BackgroundImageLayout = ImageLayout.None
        btnLancer.Cursor = Cursors.Hand
        btnLancer.FlatAppearance.BorderColor = Color.White
        btnLancer.FlatAppearance.BorderSize = 0
        btnLancer.FlatAppearance.MouseDownBackColor = Color.White
        btnLancer.FlatAppearance.MouseOverBackColor = Color.White
        btnLancer.FlatStyle = FlatStyle.Flat
        btnLancer.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLancer.Location = New Point(252, 389)
        btnLancer.Margin = New Padding(3, 5, 3, 5)
        btnLancer.Name = "btnLancer"
        btnLancer.Size = New Size(191, 82)
        btnLancer.TabIndex = 1
        btnLancer.Text = "Lancer"
        btnLancer.UseVisualStyleBackColor = False
        ' 
        ' btnOptions
        ' 
        btnOptions.BackColor = Color.Transparent
        btnOptions.BackgroundImage = My.Resources.Resources.button3
        btnOptions.BackgroundImageLayout = ImageLayout.Center
        btnOptions.Cursor = Cursors.Help
        btnOptions.FlatAppearance.BorderColor = Color.Black
        btnOptions.FlatAppearance.BorderSize = 0
        btnOptions.FlatAppearance.MouseOverBackColor = Color.White
        btnOptions.FlatStyle = FlatStyle.Flat
        btnOptions.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOptions.Location = New Point(866, 15)
        btnOptions.Margin = New Padding(5, 6, 5, 6)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(178, 83)
        btnOptions.TabIndex = 4
        btnOptions.Text = "Options"
        btnOptions.UseVisualStyleBackColor = False
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(634, 35)
        AxWindowsMediaPlayer1.Margin = New Padding(5)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(222, 34)
        AxWindowsMediaPlayer1.TabIndex = 5
        ' 
        ' ButtonStopMusic
        ' 
        ButtonStopMusic.BackColor = Color.Transparent
        ButtonStopMusic.BackgroundImage = My.Resources.Resources.btnStop
        ButtonStopMusic.BackgroundImageLayout = ImageLayout.Center
        ButtonStopMusic.Cursor = Cursors.Hand
        ButtonStopMusic.FlatAppearance.BorderColor = Color.White
        ButtonStopMusic.FlatAppearance.BorderSize = 0
        ButtonStopMusic.FlatAppearance.MouseDownBackColor = Color.White
        ButtonStopMusic.FlatAppearance.MouseOverBackColor = Color.White
        ButtonStopMusic.FlatStyle = FlatStyle.Flat
        ButtonStopMusic.Location = New Point(607, 244)
        ButtonStopMusic.Margin = New Padding(5)
        ButtonStopMusic.Name = "ButtonStopMusic"
        ButtonStopMusic.Size = New Size(95, 96)
        ButtonStopMusic.TabIndex = 6
        ButtonStopMusic.UseVisualStyleBackColor = False
        ' 
        ' ButtonContinueMusic
        ' 
        ButtonContinueMusic.BackColor = Color.Transparent
        ButtonContinueMusic.BackgroundImage = My.Resources.Resources.btnStart
        ButtonContinueMusic.BackgroundImageLayout = ImageLayout.Center
        ButtonContinueMusic.Cursor = Cursors.Hand
        ButtonContinueMusic.FlatAppearance.BorderColor = Color.White
        ButtonContinueMusic.FlatAppearance.BorderSize = 0
        ButtonContinueMusic.FlatAppearance.MouseDownBackColor = Color.White
        ButtonContinueMusic.FlatAppearance.MouseOverBackColor = Color.White
        ButtonContinueMusic.FlatStyle = FlatStyle.Flat
        ButtonContinueMusic.Location = New Point(702, 244)
        ButtonContinueMusic.Margin = New Padding(5)
        ButtonContinueMusic.Name = "ButtonContinueMusic"
        ButtonContinueMusic.Size = New Size(95, 96)
        ButtonContinueMusic.TabIndex = 7
        ButtonContinueMusic.UseVisualStyleBackColor = False
        ' 
        ' btnQuitter
        ' 
        btnQuitter.BackColor = Color.Transparent
        btnQuitter.BackgroundImage = My.Resources.Resources.button
        btnQuitter.BackgroundImageLayout = ImageLayout.None
        btnQuitter.Cursor = Cursors.Hand
        btnQuitter.FlatAppearance.BorderColor = Color.White
        btnQuitter.FlatAppearance.BorderSize = 0
        btnQuitter.FlatAppearance.MouseDownBackColor = Color.White
        btnQuitter.FlatAppearance.MouseOverBackColor = Color.White
        btnQuitter.FlatStyle = FlatStyle.Flat
        btnQuitter.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuitter.Location = New Point(471, 389)
        btnQuitter.Margin = New Padding(3, 5, 3, 5)
        btnQuitter.Name = "btnQuitter"
        btnQuitter.Size = New Size(191, 82)
        btnQuitter.TabIndex = 2
        btnQuitter.Text = "Quitter"
        btnQuitter.UseVisualStyleBackColor = False
        ' 
        ' btnAfficherScore
        ' 
        btnAfficherScore.BackColor = Color.Transparent
        btnAfficherScore.BackgroundImage = My.Resources.Resources.button
        btnAfficherScore.BackgroundImageLayout = ImageLayout.None
        btnAfficherScore.Cursor = Cursors.Hand
        btnAfficherScore.FlatAppearance.BorderColor = Color.White
        btnAfficherScore.FlatAppearance.BorderSize = 0
        btnAfficherScore.FlatAppearance.MouseDownBackColor = Color.White
        btnAfficherScore.FlatAppearance.MouseOverBackColor = Color.White
        btnAfficherScore.FlatStyle = FlatStyle.Flat
        btnAfficherScore.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAfficherScore.Location = New Point(690, 389)
        btnAfficherScore.Margin = New Padding(3, 5, 3, 5)
        btnAfficherScore.Name = "btnAfficherScore"
        btnAfficherScore.Size = New Size(191, 82)
        btnAfficherScore.TabIndex = 3
        btnAfficherScore.Text = "Afficher Score"
        btnAfficherScore.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = My.Resources.Resources.menu
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1071, 672)
        Controls.Add(btnAfficherScore)
        Controls.Add(btnQuitter)
        Controls.Add(ButtonContinueMusic)
        Controls.Add(ButtonStopMusic)
        Controls.Add(AxWindowsMediaPlayer1)
        Controls.Add(btnOptions)
        Controls.Add(btnLancer)
        Controls.Add(cbxNoms)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 5, 3, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterParent
        Text = "Accueil"
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbxNoms As ComboBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ButtonStopMusic As Button
    Friend WithEvents ButtonContinueMusic As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnAfficherScore As Button

End Class
