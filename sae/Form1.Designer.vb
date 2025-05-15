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
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbxNoms
        ' 
        cbxNoms.FormattingEnabled = True
        cbxNoms.Location = New Point(154, 230)
        cbxNoms.Margin = New Padding(3, 4, 3, 4)
        cbxNoms.Name = "cbxNoms"
        cbxNoms.Size = New Size(223, 38)
        cbxNoms.TabIndex = 0
        ' 
        ' btnLancer
        ' 
        btnLancer.Location = New Point(136, 488)
        btnLancer.Margin = New Padding(3, 4, 3, 4)
        btnLancer.Name = "btnLancer"
        btnLancer.Size = New Size(171, 76)
        btnLancer.TabIndex = 1
        btnLancer.Text = "Lancer"
        btnLancer.UseVisualStyleBackColor = True
        ' 
        ' btnQuitter
        ' 
        btnQuitter.Location = New Point(388, 488)
        btnQuitter.Margin = New Padding(3, 4, 3, 4)
        btnQuitter.Name = "btnQuitter"
        btnQuitter.Size = New Size(171, 76)
        btnQuitter.TabIndex = 2
        btnQuitter.Text = "Quitter"
        btnQuitter.UseVisualStyleBackColor = True
        ' 
        ' btnAfficherScore
        ' 
        btnAfficherScore.Location = New Point(642, 488)
        btnAfficherScore.Margin = New Padding(3, 4, 3, 4)
        btnAfficherScore.Name = "btnAfficherScore"
        btnAfficherScore.Size = New Size(171, 76)
        btnAfficherScore.TabIndex = 3
        btnAfficherScore.Text = "Afficher Score"
        btnAfficherScore.UseVisualStyleBackColor = True
        ' 
        ' btnOptions
        ' 
        btnOptions.Location = New Point(837, 24)
        btnOptions.Margin = New Padding(5, 6, 5, 6)
        btnOptions.Name = "btnOptions"
        btnOptions.Size = New Size(129, 46)
        btnOptions.TabIndex = 4
        btnOptions.Text = "Options"
        btnOptions.UseVisualStyleBackColor = True
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1003, 730)
        Controls.Add(btnOptions)
        Controls.Add(btnAfficherScore)
        Controls.Add(btnQuitter)
        Controls.Add(btnLancer)
        Controls.Add(cbxNoms)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Accueil"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbxNoms As ComboBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnAfficherScore As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher

End Class
