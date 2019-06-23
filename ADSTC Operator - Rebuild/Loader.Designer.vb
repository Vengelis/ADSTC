<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loader
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loader))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumberEtapes = New System.Windows.Forms.Label()
        Me.ThisEtapeNumber = New System.Windows.Forms.Label()
        Me.EtatEtapeLabel = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.VProgressBar1 = New ADSTC_Operator___Rebuild.VProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Russo One", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Russo One", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(103, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Russo One", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Active Directory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Russo One", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(205, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Session Time Counter"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ADSTC_Operator___Rebuild.My.Resources.Resources.ADSTCiconeProject
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(482, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 151)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Russo One", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(500, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Version Build"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Russo One", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Master Edition"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Chargement en cours:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Etapes:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Etats:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(74, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "/"
        '
        'NumberEtapes
        '
        Me.NumberEtapes.AutoSize = True
        Me.NumberEtapes.BackColor = System.Drawing.Color.Transparent
        Me.NumberEtapes.ForeColor = System.Drawing.Color.White
        Me.NumberEtapes.Location = New System.Drawing.Point(86, 283)
        Me.NumberEtapes.Name = "NumberEtapes"
        Me.NumberEtapes.Size = New System.Drawing.Size(14, 13)
        Me.NumberEtapes.TabIndex = 12
        Me.NumberEtapes.Text = "X"
        '
        'ThisEtapeNumber
        '
        Me.ThisEtapeNumber.AutoSize = True
        Me.ThisEtapeNumber.BackColor = System.Drawing.Color.Transparent
        Me.ThisEtapeNumber.ForeColor = System.Drawing.Color.White
        Me.ThisEtapeNumber.Location = New System.Drawing.Point(61, 283)
        Me.ThisEtapeNumber.Name = "ThisEtapeNumber"
        Me.ThisEtapeNumber.Size = New System.Drawing.Size(14, 13)
        Me.ThisEtapeNumber.TabIndex = 13
        Me.ThisEtapeNumber.Text = "X"
        '
        'EtatEtapeLabel
        '
        Me.EtatEtapeLabel.AutoSize = True
        Me.EtatEtapeLabel.BackColor = System.Drawing.Color.Transparent
        Me.EtatEtapeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatEtapeLabel.ForeColor = System.Drawing.Color.Green
        Me.EtatEtapeLabel.Location = New System.Drawing.Point(52, 298)
        Me.EtatEtapeLabel.Name = "EtatEtapeLabel"
        Me.EtatEtapeLabel.Size = New System.Drawing.Size(117, 13)
        Me.EtatEtapeLabel.TabIndex = 14
        Me.EtatEtapeLabel.Text = "Chargement en cours..."
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'VProgressBar1
        '
        Me.VProgressBar1.Couleur1 = System.Drawing.Color.DarkOrange
        Me.VProgressBar1.Couleur2 = System.Drawing.Color.Orange
        Me.VProgressBar1.CouleurFond = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VProgressBar1.Location = New System.Drawing.Point(8, 264)
        Me.VProgressBar1.Name = "VProgressBar1"
        Me.VProgressBar1.Size = New System.Drawing.Size(638, 16)
        Me.VProgressBar1.TabIndex = 8
        Me.VProgressBar1.Text = "VProgressBar1"
        Me.VProgressBar1.Valeur = 0
        '
        'Loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ADSTC_Operator___Rebuild.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(658, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.EtatEtapeLabel)
        Me.Controls.Add(Me.ThisEtapeNumber)
        Me.Controls.Add(Me.NumberEtapes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.VProgressBar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loader"
        Me.TransparencyKey = System.Drawing.Color.Ivory
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents VProgressBar1 As VProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NumberEtapes As Label
    Friend WithEvents ThisEtapeNumber As Label
    Friend WithEvents EtatEtapeLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
End Class
