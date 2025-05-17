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
        btnNo.BackColor = Color.Transparent
        btnNo.BackgroundImage = My.Resources.Resources.button22
        btnNo.BackgroundImageLayout = ImageLayout.Center
        btnNo.Cursor = Cursors.Hand
        btnNo.FlatAppearance.BorderSize = 0
        btnNo.FlatAppearance.MouseDownBackColor = Color.White
        btnNo.FlatAppearance.MouseOverBackColor = Color.White
        btnNo.FlatStyle = FlatStyle.Flat
        btnNo.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNo.Location = New Point(383, 184)
        btnNo.Name = "btnNo"
        btnNo.Size = New Size(188, 86)
        btnNo.TabIndex = 0
        btnNo.Text = "Non"
        btnNo.UseVisualStyleBackColor = False
        ' 
        ' btnYes
        ' 
        btnYes.BackColor = Color.Transparent
        btnYes.BackgroundImage = My.Resources.Resources.button22
        btnYes.BackgroundImageLayout = ImageLayout.Center
        btnYes.Cursor = Cursors.Hand
        btnYes.FlatAppearance.BorderSize = 0
        btnYes.FlatAppearance.MouseDownBackColor = Color.White
        btnYes.FlatAppearance.MouseOverBackColor = Color.White
        btnYes.FlatStyle = FlatStyle.Flat
        btnYes.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnYes.Location = New Point(163, 184)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(188, 86)
        btnYes.TabIndex = 1
        btnYes.Text = "Oui"
        btnYes.UseVisualStyleBackColor = False
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.BackColor = Color.Transparent
        lblConfirmation.Font = New Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfirmation.Location = New Point(87, 123)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(564, 41)
        lblConfirmation.TabIndex = 2
        lblConfirmation.Text = "x"
        lblConfirmation.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' formConfirmation
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        BackgroundImage = My.Resources.Resources.affiche
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(738, 339)
        Controls.Add(lblConfirmation)
        Controls.Add(btnYes)
        Controls.Add(btnNo)
        DoubleBuffered = True
        Name = "formConfirmation"
        Text = "Confirmation"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents lblConfirmation As Label
End Class
