<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formErreur
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
        lblErreur = New Label()
        btnOK = New Button()
        SuspendLayout()
        ' 
        ' lblErreur
        ' 
        lblErreur.BackColor = Color.Transparent
        lblErreur.Location = New Point(59, 94)
        lblErreur.Name = "lblErreur"
        lblErreur.Size = New Size(609, 58)
        lblErreur.TabIndex = 0
        lblErreur.Text = "x"
        lblErreur.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnOK
        ' 
        btnOK.BackColor = Color.Transparent
        btnOK.BackgroundImage = My.Resources.Resources.button22
        btnOK.BackgroundImageLayout = ImageLayout.Center
        btnOK.FlatAppearance.BorderSize = 0
        btnOK.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnOK.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnOK.FlatStyle = FlatStyle.Flat
        btnOK.Location = New Point(277, 155)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(169, 131)
        btnOK.TabIndex = 1
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = False
        ' 
        ' formErreur
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.affiche
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(726, 298)
        Controls.Add(btnOK)
        Controls.Add(lblErreur)
        DoubleBuffered = True
        Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "formErreur"
        Text = "formErreur"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblErreur As Label
    Friend WithEvents btnOK As Button
End Class
