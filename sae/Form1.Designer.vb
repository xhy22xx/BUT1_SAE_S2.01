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
        cbxNom = New ComboBox()
        btnLancer = New Button()
        btnQuitter = New Button()
        btnAfficher = New Button()
        SuspendLayout()
        ' 
        ' cbxNom
        ' 
        cbxNom.FormattingEnabled = True
        cbxNom.Location = New Point(168, 130)
        cbxNom.Name = "cbxNom"
        cbxNom.Size = New Size(242, 40)
        cbxNom.TabIndex = 0
        ' 
        ' btnLancer
        ' 
        btnLancer.Location = New Point(260, 464)
        btnLancer.Name = "btnLancer"
        btnLancer.Size = New Size(150, 46)
        btnLancer.TabIndex = 1
        btnLancer.Text = "Lancement"
        btnLancer.UseVisualStyleBackColor = True
        ' 
        ' btnQuitter
        ' 
        btnQuitter.Location = New Point(582, 464)
        btnQuitter.Name = "btnQuitter"
        btnQuitter.Size = New Size(150, 46)
        btnQuitter.TabIndex = 2
        btnQuitter.Text = "Quitter"
        btnQuitter.UseVisualStyleBackColor = True
        ' 
        ' btnAfficher
        ' 
        btnAfficher.Location = New Point(887, 464)
        btnAfficher.Name = "btnAfficher"
        btnAfficher.Size = New Size(150, 46)
        btnAfficher.TabIndex = 3
        btnAfficher.Text = "Affichage"
        btnAfficher.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1323, 730)
        Controls.Add(btnAfficher)
        Controls.Add(btnQuitter)
        Controls.Add(btnLancer)
        Controls.Add(cbxNom)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbxNom As ComboBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnAfficher As Button

End Class
