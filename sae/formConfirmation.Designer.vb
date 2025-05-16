<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConfirmation
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
        btnNo = New Button()
        btnYes = New Button()
        lblConfirmation = New Label()
        SuspendLayout()
        ' 
        ' btnNo
        ' 
        btnNo.Location = New Point(295, 191)
        btnNo.Margin = New Padding(2, 2, 2, 2)
        btnNo.Name = "btnNo"
        btnNo.Size = New Size(145, 41)
        btnNo.TabIndex = 0
        btnNo.Text = "Non"
        btnNo.UseVisualStyleBackColor = True
        ' 
        ' btnYes
        ' 
        btnYes.Location = New Point(92, 191)
        btnYes.Margin = New Padding(2, 2, 2, 2)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(145, 41)
        btnYes.TabIndex = 1
        btnYes.Text = "Oui"
        btnYes.UseVisualStyleBackColor = True
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.AutoSize = True
        lblConfirmation.Location = New Point(92, 100)
        lblConfirmation.Margin = New Padding(2, 0, 2, 0)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(20, 25)
        lblConfirmation.TabIndex = 2
        lblConfirmation.Text = "x"
        lblConfirmation.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' formConfirmation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        ClientSize = New Size(540, 274)
        Controls.Add(lblConfirmation)
        Controls.Add(btnYes)
        Controls.Add(btnNo)
        Margin = New Padding(2, 2, 2, 2)
        Name = "formConfirmation"
        Text = "Confirmation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents lblConfirmation As Label
End Class
