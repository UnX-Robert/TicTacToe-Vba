<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PlayExit = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.GameNew = New System.Windows.Forms.Button()
        Me.OScore = New System.Windows.Forms.Button()
        Me.XScore = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnTic9 = New System.Windows.Forms.Button()
        Me.BtnTic8 = New System.Windows.Forms.Button()
        Me.BtnTic7 = New System.Windows.Forms.Button()
        Me.BtnTic6 = New System.Windows.Forms.Button()
        Me.BtnTic5 = New System.Windows.Forms.Button()
        Me.BtnTic4 = New System.Windows.Forms.Button()
        Me.BtnTic3 = New System.Windows.Forms.Button()
        Me.BtnTic2 = New System.Windows.Forms.Button()
        Me.BtnTic1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Player = New System.Windows.Forms.Label()
        Me.About = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HomePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Play.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.About.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(175, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 118)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TicTacToe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HomePanel
        '
        Me.HomePanel.BackColor = System.Drawing.Color.Teal
        Me.HomePanel.Controls.Add(Me.PictureBox1)
        Me.HomePanel.Controls.Add(Me.ExitButton)
        Me.HomePanel.Controls.Add(Me.AboutButton)
        Me.HomePanel.Controls.Add(Me.PlayButton)
        Me.HomePanel.Controls.Add(Me.Label1)
        Me.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomePanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.HomePanel.Location = New System.Drawing.Point(0, 0)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(852, 512)
        Me.HomePanel.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Ink Free", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Turquoise
        Me.ExitButton.Location = New System.Drawing.Point(356, 329)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 35)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.Font = New System.Drawing.Font("Ink Free", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.ForeColor = System.Drawing.Color.Turquoise
        Me.AboutButton.Location = New System.Drawing.Point(356, 274)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(122, 35)
        Me.AboutButton.TabIndex = 2
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Font = New System.Drawing.Font("Ink Free", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.ForeColor = System.Drawing.Color.Turquoise
        Me.PlayButton.Location = New System.Drawing.Point(356, 222)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(122, 35)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Teal
        Me.Play.Controls.Add(Me.Panel4)
        Me.Play.Controls.Add(Me.Panel3)
        Me.Play.Controls.Add(Me.Panel2)
        Me.Play.Location = New System.Drawing.Point(0, 0)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(853, 512)
        Me.Play.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PlayExit)
        Me.Panel4.Controls.Add(Me.Reset)
        Me.Panel4.Controls.Add(Me.GameNew)
        Me.Panel4.Controls.Add(Me.OScore)
        Me.Panel4.Controls.Add(Me.XScore)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(428, 109)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(425, 403)
        Me.Panel4.TabIndex = 2
        '
        'PlayExit
        '
        Me.PlayExit.BackColor = System.Drawing.Color.Ivory
        Me.PlayExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayExit.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.PlayExit.Location = New System.Drawing.Point(232, 285)
        Me.PlayExit.Name = "PlayExit"
        Me.PlayExit.Size = New System.Drawing.Size(180, 79)
        Me.PlayExit.TabIndex = 8
        Me.PlayExit.Text = "Exit"
        Me.PlayExit.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.Ivory
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Reset.Location = New System.Drawing.Point(32, 285)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(180, 79)
        Me.Reset.TabIndex = 7
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'GameNew
        '
        Me.GameNew.BackColor = System.Drawing.Color.Ivory
        Me.GameNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameNew.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameNew.Location = New System.Drawing.Point(32, 184)
        Me.GameNew.Name = "GameNew"
        Me.GameNew.Size = New System.Drawing.Size(380, 79)
        Me.GameNew.TabIndex = 6
        Me.GameNew.Text = "New Game"
        Me.GameNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GameNew.UseVisualStyleBackColor = False
        '
        'OScore
        '
        Me.OScore.BackColor = System.Drawing.Color.Ivory
        Me.OScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OScore.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.OScore.Location = New System.Drawing.Point(278, 89)
        Me.OScore.Name = "OScore"
        Me.OScore.Size = New System.Drawing.Size(134, 48)
        Me.OScore.TabIndex = 3
        Me.OScore.Text = "0"
        Me.OScore.UseVisualStyleBackColor = False
        '
        'XScore
        '
        Me.XScore.BackColor = System.Drawing.Color.Ivory
        Me.XScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.XScore.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.XScore.Location = New System.Drawing.Point(278, 25)
        Me.XScore.Name = "XScore"
        Me.XScore.Size = New System.Drawing.Size(134, 48)
        Me.XScore.TabIndex = 2
        Me.XScore.Text = "0"
        Me.XScore.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ink Free", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 60)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Player O:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ink Free", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 60)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Player X:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BtnTic9)
        Me.Panel3.Controls.Add(Me.BtnTic8)
        Me.Panel3.Controls.Add(Me.BtnTic7)
        Me.Panel3.Controls.Add(Me.BtnTic6)
        Me.Panel3.Controls.Add(Me.BtnTic5)
        Me.Panel3.Controls.Add(Me.BtnTic4)
        Me.Panel3.Controls.Add(Me.BtnTic3)
        Me.Panel3.Controls.Add(Me.BtnTic2)
        Me.Panel3.Controls.Add(Me.BtnTic1)
        Me.Panel3.Location = New System.Drawing.Point(0, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(426, 391)
        Me.Panel3.TabIndex = 1
        '
        'BtnTic9
        '
        Me.BtnTic9.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic9.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic9.Location = New System.Drawing.Point(272, 265)
        Me.BtnTic9.Name = "BtnTic9"
        Me.BtnTic9.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic9.TabIndex = 8
        Me.BtnTic9.UseVisualStyleBackColor = False
        '
        'BtnTic8
        '
        Me.BtnTic8.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic8.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic8.Location = New System.Drawing.Point(146, 265)
        Me.BtnTic8.Name = "BtnTic8"
        Me.BtnTic8.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic8.TabIndex = 7
        Me.BtnTic8.UseVisualStyleBackColor = False
        '
        'BtnTic7
        '
        Me.BtnTic7.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic7.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic7.Location = New System.Drawing.Point(20, 265)
        Me.BtnTic7.Name = "BtnTic7"
        Me.BtnTic7.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic7.TabIndex = 6
        Me.BtnTic7.UseVisualStyleBackColor = False
        '
        'BtnTic6
        '
        Me.BtnTic6.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic6.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic6.Location = New System.Drawing.Point(272, 141)
        Me.BtnTic6.Name = "BtnTic6"
        Me.BtnTic6.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic6.TabIndex = 5
        Me.BtnTic6.UseVisualStyleBackColor = False
        '
        'BtnTic5
        '
        Me.BtnTic5.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic5.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic5.Location = New System.Drawing.Point(146, 141)
        Me.BtnTic5.Name = "BtnTic5"
        Me.BtnTic5.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic5.TabIndex = 4
        Me.BtnTic5.UseVisualStyleBackColor = False
        '
        'BtnTic4
        '
        Me.BtnTic4.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic4.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic4.Location = New System.Drawing.Point(20, 141)
        Me.BtnTic4.Name = "BtnTic4"
        Me.BtnTic4.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic4.TabIndex = 3
        Me.BtnTic4.UseVisualStyleBackColor = False
        '
        'BtnTic3
        '
        Me.BtnTic3.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic3.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic3.Location = New System.Drawing.Point(272, 15)
        Me.BtnTic3.Name = "BtnTic3"
        Me.BtnTic3.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic3.TabIndex = 2
        Me.BtnTic3.UseVisualStyleBackColor = False
        '
        'BtnTic2
        '
        Me.BtnTic2.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic2.Location = New System.Drawing.Point(146, 15)
        Me.BtnTic2.Name = "BtnTic2"
        Me.BtnTic2.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic2.TabIndex = 1
        Me.BtnTic2.UseVisualStyleBackColor = False
        '
        'BtnTic1
        '
        Me.BtnTic1.BackColor = System.Drawing.Color.Ivory
        Me.BtnTic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTic1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTic1.Location = New System.Drawing.Point(20, 15)
        Me.BtnTic1.Name = "BtnTic1"
        Me.BtnTic1.Size = New System.Drawing.Size(120, 120)
        Me.BtnTic1.TabIndex = 0
        Me.BtnTic1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Player)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(853, 109)
        Me.Panel2.TabIndex = 0
        '
        'Player
        '
        Me.Player.AutoSize = True
        Me.Player.Font = New System.Drawing.Font("Ink Free", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.ForeColor = System.Drawing.Color.LightGreen
        Me.Player.Location = New System.Drawing.Point(270, -9)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(321, 118)
        Me.Player.TabIndex = 1
        Me.Player.Text = "X Turn"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'About
        '
        Me.About.BackColor = System.Drawing.Color.Teal
        Me.About.Controls.Add(Me.BackButton)
        Me.About.Controls.Add(Me.Label11)
        Me.About.Controls.Add(Me.Label10)
        Me.About.Controls.Add(Me.Label9)
        Me.About.Controls.Add(Me.Label8)
        Me.About.Controls.Add(Me.Label7)
        Me.About.Controls.Add(Me.Label6)
        Me.About.Controls.Add(Me.Label2)
        Me.About.Controls.Add(Me.Label5)
        Me.About.Dock = System.Windows.Forms.DockStyle.Fill
        Me.About.Location = New System.Drawing.Point(0, 0)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(852, 512)
        Me.About.TabIndex = 5
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.MintCream
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(356, 394)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(109, 39)
        Me.BackButton.TabIndex = 9
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Ivory
        Me.Label11.Location = New System.Drawing.Point(172, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(460, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "If no player has 3 marks in a row, the game ends in a tie."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Ivory
        Me.Label10.Location = New System.Drawing.Point(172, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(387, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "4. When all 9 squares are full, the game is over. "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Ivory
        Me.Label9.Location = New System.Drawing.Point(185, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(360, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "(up, down, across, or diagonally) is the winner."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Ivory
        Me.Label8.Location = New System.Drawing.Point(171, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(410, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "3. The first player to get 3 of her marks in a row "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Ivory
        Me.Label7.Location = New System.Drawing.Point(185, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(455, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Players take turns putting their marks in empty squares."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Ivory
        Me.Label6.Location = New System.Drawing.Point(171, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(387, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "2. You are X, your friend (or the computer) is O. "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Ivory
        Me.Label2.Location = New System.Drawing.Point(172, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "1. The game is played on a grid that's 3 squares by 3 squares."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ink Free", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Ivory
        Me.Label5.Location = New System.Drawing.Point(288, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 118)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Rules"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 512)
        Me.Controls.Add(Me.HomePanel)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.About)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.HomePanel.ResumeLayout(False)
        Me.HomePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Play.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HomePanel As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Play As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnTic9 As Button
    Friend WithEvents BtnTic8 As Button
    Friend WithEvents BtnTic7 As Button
    Friend WithEvents BtnTic6 As Button
    Friend WithEvents BtnTic5 As Button
    Friend WithEvents BtnTic4 As Button
    Friend WithEvents BtnTic3 As Button
    Friend WithEvents BtnTic2 As Button
    Friend WithEvents BtnTic1 As Button
    Friend WithEvents Player As Label
    Friend WithEvents PlayExit As Button
    Friend WithEvents Reset As Button
    Friend WithEvents GameNew As Button
    Friend WithEvents OScore As Button
    Friend WithEvents XScore As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents About As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BackButton As Button
End Class
