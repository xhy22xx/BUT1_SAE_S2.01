<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemoryHard
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
        lblJoueur2 = New Label()
        lblname2 = New Label()
        lblTempsR2 = New Label()
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
        PictureBox17 = New PictureBox()
        PictureBox18 = New PictureBox()
        PictureBox19 = New PictureBox()
        PictureBox20 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox21 = New PictureBox()
        PictureBox22 = New PictureBox()
        PictureBox23 = New PictureBox()
        PictureBox24 = New PictureBox()
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
        CType(PictureBox17, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox21, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox22, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox24, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJoueur2
        ' 
        lblJoueur2.AutoSize = True
        lblJoueur2.Location = New Point(41, 43)
        lblJoueur2.Margin = New Padding(1, 0, 1, 0)
        lblJoueur2.Name = "lblJoueur2"
        lblJoueur2.Size = New Size(80, 25)
        lblJoueur2.TabIndex = 0
        lblJoueur2.Text = "- Joueur:"
        ' 
        ' lblname2
        ' 
        lblname2.AutoSize = True
        lblname2.Location = New Point(151, 43)
        lblname2.Margin = New Padding(1, 0, 1, 0)
        lblname2.Name = "lblname2"
        lblname2.Size = New Size(63, 25)
        lblname2.TabIndex = 1
        lblname2.Text = "Label2"
        ' 
        ' lblTempsR2
        ' 
        lblTempsR2.AutoSize = True
        lblTempsR2.Location = New Point(321, 43)
        lblTempsR2.Margin = New Padding(1, 0, 1, 0)
        lblTempsR2.Name = "lblTempsR2"
        lblTempsR2.Size = New Size(138, 25)
        lblTempsR2.TabIndex = 2
        lblTempsR2.Text = "- Temps restant:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(486, 43)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 25)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        ' 
        ' btnAbandon
        ' 
        btnAbandon.Location = New Point(646, 38)
        btnAbandon.Margin = New Padding(1, 2, 1, 2)
        btnAbandon.Name = "btnAbandon"
        btnAbandon.Size = New Size(114, 37)
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
        PictureBox1.Location = New Point(1, 3)
        PictureBox1.Margin = New Padding(1, 3, 1, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 131)
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
        PictureBox2.Location = New Point(149, 3)
        PictureBox2.Margin = New Padding(1, 3, 1, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(146, 131)
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
        PictureBox3.Location = New Point(297, 3)
        PictureBox3.Margin = New Padding(1, 3, 1, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(146, 131)
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
        PictureBox4.Location = New Point(445, 3)
        PictureBox4.Margin = New Padding(1, 3, 1, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(147, 131)
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
        PictureBox5.Location = New Point(1, 140)
        PictureBox5.Margin = New Padding(1, 3, 1, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(146, 136)
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
        PictureBox6.Location = New Point(149, 140)
        PictureBox6.Margin = New Padding(1, 3, 1, 3)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(146, 136)
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
        PictureBox7.Location = New Point(297, 140)
        PictureBox7.Margin = New Padding(1, 3, 1, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(146, 136)
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
        PictureBox8.Location = New Point(445, 140)
        PictureBox8.Margin = New Padding(1, 3, 1, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(147, 136)
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
        PictureBox9.Location = New Point(1, 282)
        PictureBox9.Margin = New Padding(1, 3, 1, 3)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(146, 136)
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
        PictureBox10.Location = New Point(149, 282)
        PictureBox10.Margin = New Padding(1, 3, 1, 3)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(146, 136)
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
        PictureBox11.Location = New Point(297, 282)
        PictureBox11.Margin = New Padding(1, 3, 1, 3)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(146, 136)
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
        PictureBox12.Location = New Point(445, 282)
        PictureBox12.Margin = New Padding(1, 3, 1, 3)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(147, 136)
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
        PictureBox13.Location = New Point(1, 424)
        PictureBox13.Margin = New Padding(1, 3, 1, 3)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(146, 136)
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
        PictureBox14.Location = New Point(149, 424)
        PictureBox14.Margin = New Padding(1, 3, 1, 3)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(146, 136)
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
        PictureBox15.Location = New Point(297, 424)
        PictureBox15.Margin = New Padding(1, 3, 1, 3)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(146, 136)
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
        PictureBox16.Location = New Point(445, 424)
        PictureBox16.Margin = New Padding(1, 3, 1, 3)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(147, 136)
        PictureBox16.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox16.TabIndex = 15
        PictureBox16.TabStop = False
        ' 
        ' PictureBox17
        ' 
        PictureBox17.BackColor = Color.Transparent
        PictureBox17.BackgroundImageLayout = ImageLayout.None
        PictureBox17.Cursor = Cursors.Hand
        PictureBox17.Dock = DockStyle.Fill
        PictureBox17.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox17.Location = New Point(1, 566)
        PictureBox17.Margin = New Padding(1, 3, 1, 3)
        PictureBox17.Name = "PictureBox17"
        PictureBox17.Size = New Size(146, 136)
        PictureBox17.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox17.TabIndex = 16
        PictureBox17.TabStop = False
        ' 
        ' PictureBox18
        ' 
        PictureBox18.BackColor = Color.Transparent
        PictureBox18.BackgroundImageLayout = ImageLayout.None
        PictureBox18.Cursor = Cursors.Hand
        PictureBox18.Dock = DockStyle.Fill
        PictureBox18.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox18.Location = New Point(149, 566)
        PictureBox18.Margin = New Padding(1, 3, 1, 3)
        PictureBox18.Name = "PictureBox18"
        PictureBox18.Size = New Size(146, 136)
        PictureBox18.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox18.TabIndex = 17
        PictureBox18.TabStop = False
        ' 
        ' PictureBox19
        ' 
        PictureBox19.BackColor = Color.Transparent
        PictureBox19.BackgroundImageLayout = ImageLayout.None
        PictureBox19.Cursor = Cursors.Hand
        PictureBox19.Dock = DockStyle.Fill
        PictureBox19.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox19.Location = New Point(297, 566)
        PictureBox19.Margin = New Padding(1, 3, 1, 3)
        PictureBox19.Name = "PictureBox19"
        PictureBox19.Size = New Size(146, 136)
        PictureBox19.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox19.TabIndex = 18
        PictureBox19.TabStop = False
        ' 
        ' PictureBox20
        ' 
        PictureBox20.BackColor = Color.Transparent
        PictureBox20.BackgroundImageLayout = ImageLayout.None
        PictureBox20.Cursor = Cursors.Hand
        PictureBox20.Dock = DockStyle.Fill
        PictureBox20.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox20.Location = New Point(445, 566)
        PictureBox20.Margin = New Padding(1, 3, 1, 3)
        PictureBox20.Name = "PictureBox20"
        PictureBox20.Size = New Size(147, 136)
        PictureBox20.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox20.TabIndex = 19
        PictureBox20.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(PictureBox21, 0, 5)
        TableLayoutPanel1.Controls.Add(PictureBox22, 1, 5)
        TableLayoutPanel1.Controls.Add(PictureBox23, 2, 5)
        TableLayoutPanel1.Controls.Add(PictureBox24, 3, 5)
        TableLayoutPanel1.Controls.Add(PictureBox20, 3, 4)
        TableLayoutPanel1.Controls.Add(PictureBox19, 2, 4)
        TableLayoutPanel1.Controls.Add(PictureBox18, 1, 4)
        TableLayoutPanel1.Controls.Add(PictureBox17, 0, 4)
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
        TableLayoutPanel1.Location = New Point(134, 92)
        TableLayoutPanel1.Margin = New Padding(1, 3, 1, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.1073818F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.7785244F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.7785244F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.7785244F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.7785244F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.7785244F))
        TableLayoutPanel1.Size = New Size(593, 852)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' PictureBox21
        ' 
        PictureBox21.BackColor = Color.Transparent
        PictureBox21.BackgroundImageLayout = ImageLayout.None
        PictureBox21.Cursor = Cursors.Hand
        PictureBox21.Dock = DockStyle.Fill
        PictureBox21.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox21.Location = New Point(1, 708)
        PictureBox21.Margin = New Padding(1, 3, 1, 3)
        PictureBox21.Name = "PictureBox21"
        PictureBox21.Size = New Size(146, 141)
        PictureBox21.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox21.TabIndex = 23
        PictureBox21.TabStop = False
        ' 
        ' PictureBox22
        ' 
        PictureBox22.BackColor = Color.Transparent
        PictureBox22.BackgroundImageLayout = ImageLayout.None
        PictureBox22.Cursor = Cursors.Hand
        PictureBox22.Dock = DockStyle.Fill
        PictureBox22.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox22.Location = New Point(149, 708)
        PictureBox22.Margin = New Padding(1, 3, 1, 3)
        PictureBox22.Name = "PictureBox22"
        PictureBox22.Size = New Size(146, 141)
        PictureBox22.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox22.TabIndex = 22
        PictureBox22.TabStop = False
        ' 
        ' PictureBox23
        ' 
        PictureBox23.BackColor = Color.Transparent
        PictureBox23.BackgroundImageLayout = ImageLayout.None
        PictureBox23.Cursor = Cursors.Hand
        PictureBox23.Dock = DockStyle.Fill
        PictureBox23.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox23.Location = New Point(297, 708)
        PictureBox23.Margin = New Padding(1, 3, 1, 3)
        PictureBox23.Name = "PictureBox23"
        PictureBox23.Size = New Size(146, 141)
        PictureBox23.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox23.TabIndex = 21
        PictureBox23.TabStop = False
        ' 
        ' PictureBox24
        ' 
        PictureBox24.BackColor = Color.Transparent
        PictureBox24.BackgroundImageLayout = ImageLayout.None
        PictureBox24.Cursor = Cursors.Hand
        PictureBox24.Dock = DockStyle.Fill
        PictureBox24.Image = My.Resources.Resources.Carte_pokemon_dos
        PictureBox24.Location = New Point(445, 708)
        PictureBox24.Margin = New Padding(1, 3, 1, 3)
        PictureBox24.Name = "PictureBox24"
        PictureBox24.Size = New Size(147, 141)
        PictureBox24.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox24.TabIndex = 20
        PictureBox24.TabStop = False
        ' 
        ' MemoryHard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(877, 955)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnAbandon)
        Controls.Add(Label4)
        Controls.Add(lblTempsR2)
        Controls.Add(lblname2)
        Controls.Add(lblJoueur2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(1, 2, 1, 2)
        Name = "MemoryHard"
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
        CType(PictureBox17, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox21, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox22, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox24, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJoueur2 As Label
    Friend WithEvents lblname2 As Label
    Friend WithEvents lblTempsR2 As Label
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
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
End Class
