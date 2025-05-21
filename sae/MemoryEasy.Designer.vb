<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemoryEasy
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJoueur1 = New Label()
        lblname1 = New Label()
        lblTempsR1 = New Label()
        Label4 = New Label()
        btnAbandon = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox15 = New PictureBox()
        PictureBox16 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJoueur1
        ' 
        lblJoueur1.AutoSize = True
        lblJoueur1.Location = New Point(29, 26)
        lblJoueur1.Margin = New Padding(1, 0, 1, 0)
        lblJoueur1.Name = "lblJoueur1"
        lblJoueur1.Size = New Size(53, 15)
        lblJoueur1.TabIndex = 0
        lblJoueur1.Text = "- Joueur:"
        ' 
        ' lblname1
        ' 
        lblname1.AutoSize = True
        lblname1.Location = New Point(106, 26)
        lblname1.Margin = New Padding(1, 0, 1, 0)
        lblname1.Name = "lblname1"
        lblname1.Size = New Size(41, 15)
        lblname1.TabIndex = 1
        lblname1.Text = "Label2"
        ' 
        ' lblTempsR1
        ' 
        lblTempsR1.AutoSize = True
        lblTempsR1.Location = New Point(225, 26)
        lblTempsR1.Margin = New Padding(1, 0, 1, 0)
        lblTempsR1.Name = "lblTempsR1"
        lblTempsR1.Size = New Size(91, 15)
        lblTempsR1.TabIndex = 2
        lblTempsR1.Text = "- Temps restant:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(340, 26)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        ' 
        ' btnAbandon
        ' 
        btnAbandon.Location = New Point(452, 23)
        btnAbandon.Margin = New Padding(1, 1, 1, 1)
        btnAbandon.Name = "btnAbandon"
        btnAbandon.Size = New Size(80, 22)
        btnAbandon.TabIndex = 4
        btnAbandon.Text = "Abandon"
        btnAbandon.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox1.Location = New Point(1, 2)
        PictureBox1.Margin = New Padding(1, 2, 1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox2.Location = New Point(125, 2)
        PictureBox2.Margin = New Padding(1, 2, 1, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(122, 120)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox3.Location = New Point(249, 2)
        PictureBox3.Margin = New Padding(1, 2, 1, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(122, 120)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Dock = DockStyle.Fill
        PictureBox4.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox4.Location = New Point(373, 2)
        PictureBox4.Margin = New Padding(1, 2, 1, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(122, 120)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImageLayout = ImageLayout.None
        PictureBox5.Cursor = Cursors.Hand
        PictureBox5.Dock = DockStyle.Fill
        PictureBox5.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox5.Location = New Point(1, 126)
        PictureBox5.Margin = New Padding(1, 2, 1, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(122, 120)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.None
        PictureBox6.Cursor = Cursors.Hand
        PictureBox6.Dock = DockStyle.Fill
        PictureBox6.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox6.Location = New Point(125, 126)
        PictureBox6.Margin = New Padding(1, 2, 1, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(122, 120)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImageLayout = ImageLayout.None
        PictureBox7.Cursor = Cursors.Hand
        PictureBox7.Dock = DockStyle.Fill
        PictureBox7.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox7.Location = New Point(249, 126)
        PictureBox7.Margin = New Padding(1, 2, 1, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(122, 120)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.BackgroundImageLayout = ImageLayout.None
        PictureBox8.Cursor = Cursors.Hand
        PictureBox8.Dock = DockStyle.Fill
        PictureBox8.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox8.Location = New Point(373, 126)
        PictureBox8.Margin = New Padding(1, 2, 1, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(122, 120)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 7
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImageLayout = ImageLayout.None
        PictureBox9.Cursor = Cursors.Hand
        PictureBox9.Dock = DockStyle.Fill
        PictureBox9.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox9.Location = New Point(1, 250)
        PictureBox9.Margin = New Padding(1, 2, 1, 2)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(122, 120)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 8
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.Transparent
        PictureBox10.BackgroundImageLayout = ImageLayout.None
        PictureBox10.Cursor = Cursors.Hand
        PictureBox10.Dock = DockStyle.Fill
        PictureBox10.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox10.Location = New Point(125, 250)
        PictureBox10.Margin = New Padding(1, 2, 1, 2)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(122, 120)
        PictureBox10.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox10.TabIndex = 9
        PictureBox10.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.Transparent
        PictureBox11.BackgroundImageLayout = ImageLayout.None
        PictureBox11.Cursor = Cursors.Hand
        PictureBox11.Dock = DockStyle.Fill
        PictureBox11.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox11.Location = New Point(249, 250)
        PictureBox11.Margin = New Padding(1, 2, 1, 2)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(122, 120)
        PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox11.TabIndex = 10
        PictureBox11.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.Transparent
        PictureBox12.BackgroundImageLayout = ImageLayout.None
        PictureBox12.Cursor = Cursors.Hand
        PictureBox12.Dock = DockStyle.Fill
        PictureBox12.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox12.Location = New Point(373, 250)
        PictureBox12.Margin = New Padding(1, 2, 1, 2)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(122, 120)
        PictureBox12.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox12.TabIndex = 11
        PictureBox12.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Transparent
        PictureBox13.BackgroundImageLayout = ImageLayout.None
        PictureBox13.Cursor = Cursors.Hand
        PictureBox13.Dock = DockStyle.Fill
        PictureBox13.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox13.Location = New Point(1, 374)
        PictureBox13.Margin = New Padding(1, 2, 1, 2)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(122, 121)
        PictureBox13.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox13.TabIndex = 12
        PictureBox13.TabStop = False
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = Color.Transparent
        PictureBox14.BackgroundImageLayout = ImageLayout.None
        PictureBox14.Cursor = Cursors.Hand
        PictureBox14.Dock = DockStyle.Fill
        PictureBox14.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox14.Location = New Point(125, 374)
        PictureBox14.Margin = New Padding(1, 2, 1, 2)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(122, 121)
        PictureBox14.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox14.TabIndex = 13
        PictureBox14.TabStop = False
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BackColor = Color.Transparent
        PictureBox15.BackgroundImageLayout = ImageLayout.None
        PictureBox15.Cursor = Cursors.Hand
        PictureBox15.Dock = DockStyle.Fill
        PictureBox15.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox15.Location = New Point(249, 374)
        PictureBox15.Margin = New Padding(1, 2, 1, 2)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(122, 121)
        PictureBox15.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox15.TabIndex = 14
        PictureBox15.TabStop = False
        ' 
        ' PictureBox16
        ' 
        PictureBox16.BackColor = Color.Transparent
        PictureBox16.BackgroundImageLayout = ImageLayout.None
        PictureBox16.Cursor = Cursors.Hand
        PictureBox16.Dock = DockStyle.Fill
        PictureBox16.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox16.Location = New Point(373, 374)
        PictureBox16.Margin = New Padding(1, 2, 1, 2)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(122, 121)
        PictureBox16.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox16.TabIndex = 15
        PictureBox16.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(PictureBox16, 3, 3)
        TableLayoutPanel1.Controls.Add(PictureBox15, 2, 3)
        TableLayoutPanel1.Controls.Add(PictureBox14, 1, 3)
        TableLayoutPanel1.Controls.Add(PictureBox13, 0, 3)
        TableLayoutPanel1.Controls.Add(PictureBox12, 3, 2)
        TableLayoutPanel1.Controls.Add(PictureBox11, 2, 2)
        TableLayoutPanel1.Controls.Add(PictureBox10, 1, 2)
        TableLayoutPanel1.Controls.Add(PictureBox9, 0, 2)
        TableLayoutPanel1.Controls.Add(PictureBox8, 3, 1)
        TableLayoutPanel1.Controls.Add(PictureBox7, 2, 1)
        TableLayoutPanel1.Controls.Add(PictureBox6, 1, 1)
        TableLayoutPanel1.Controls.Add(PictureBox5, 0, 1)
        TableLayoutPanel1.Controls.Add(PictureBox4, 3, 0)
        TableLayoutPanel1.Controls.Add(PictureBox3, 2, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 1, 0)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Location = New Point(62, 59)
        TableLayoutPanel1.Margin = New Padding(1, 2, 1, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 12F))
        TableLayoutPanel1.Size = New Size(496, 497)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' MemoryEasy
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(614, 573)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnAbandon)
        Controls.Add(Label4)
        Controls.Add(lblTempsR1)
        Controls.Add(lblname1)
        Controls.Add(lblJoueur1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(1, 1, 1, 1)
        Name = "MemoryEasy"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJoueur1 As Label
    Friend WithEvents lblname1 As Label
    Friend WithEvents lblTempsR1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAbandon As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
