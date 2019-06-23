<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exemple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exemple))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleColorBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Remise0Button = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlatLabel9 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserLicenceTextbox = New System.Windows.Forms.TextBox()
        Me.LicenceTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.ADSTC_Operator___Rebuild.My.Resources.Resources.ADSTC_icone_Project_Licence
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(687, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 109)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TitleColorBox
        '
        Me.TitleColorBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.TitleColorBox.Location = New System.Drawing.Point(17, 137)
        Me.TitleColorBox.Name = "TitleColorBox"
        Me.TitleColorBox.Size = New System.Drawing.Size(792, 105)
        Me.TitleColorBox.TabIndex = 2
        Me.TitleColorBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(777, 36)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(22, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(780, 66)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Remise0Button
        '
        Me.Remise0Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Remise0Button.FlatAppearance.BorderSize = 0
        Me.Remise0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remise0Button.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Remise0Button.Location = New System.Drawing.Point(396, 524)
        Me.Remise0Button.Name = "Remise0Button"
        Me.Remise0Button.Size = New System.Drawing.Size(124, 29)
        Me.Remise0Button.TabIndex = 1
        Me.Remise0Button.Text = "Activer"
        Me.Remise0Button.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 309)
        Me.ProgressBar1.Maximum = 30
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(771, 11)
        Me.ProgressBar1.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "30 Jours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(755, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "0 Jours"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(675, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 29)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label78.Location = New System.Drawing.Point(12, 82)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(150, 25)
        Me.Label78.TabIndex = 102
        Me.Label78.Text = "Master Edition"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Red
        Me.Label79.Location = New System.Drawing.Point(228, 82)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(169, 25)
        Me.Label79.TabIndex = 101
        Me.Label79.Text = "Version 1.0.1.16"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(173, 57)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(224, 25)
        Me.Label74.TabIndex = 100
        Me.Label74.Text = "Session Time Counter"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label75.Location = New System.Drawing.Point(12, 57)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(163, 25)
        Me.Label75.TabIndex = 99
        Me.Label75.Text = "Active Directory"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label76.Location = New System.Drawing.Point(12, 9)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(91, 55)
        Me.Label76.TabIndex = 97
        Me.Label76.Text = "AD"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.White
        Me.Label77.Location = New System.Drawing.Point(94, 9)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(120, 55)
        Me.Label77.TabIndex = 98
        Me.Label77.Text = "STC"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label86.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label86.Location = New System.Drawing.Point(14, 107)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(325, 13)
        Me.Label86.TabIndex = 157
        Me.Label86.Text = "Copyright © 2019 - Tous droits réservés à VLogis Development"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(822, 131)
        Me.PictureBox2.TabIndex = 158
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(17, 248)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(792, 83)
        Me.PictureBox3.TabIndex = 159
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(777, 36)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Période d'essai:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(18, 337)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(792, 230)
        Me.PictureBox4.TabIndex = 161
        Me.PictureBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(536, 524)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 29)
        Me.Button2.TabIndex = 162
        Me.Button2.Text = "Acheter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.FlatLabel9.Location = New System.Drawing.Point(22, 376)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(784, 85)
        Me.FlatLabel9.TabIndex = 163
        Me.FlatLabel9.Text = resources.GetString("FlatLabel9.Text")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(19, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(777, 36)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Activation:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserLicenceTextbox
        '
        Me.UserLicenceTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.UserLicenceTextbox.Location = New System.Drawing.Point(119, 485)
        Me.UserLicenceTextbox.Name = "UserLicenceTextbox"
        Me.UserLicenceTextbox.Size = New System.Drawing.Size(271, 29)
        Me.UserLicenceTextbox.TabIndex = 165
        Me.UserLicenceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LicenceTextbox
        '
        Me.LicenceTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LicenceTextbox.Location = New System.Drawing.Point(119, 524)
        Me.LicenceTextbox.Mask = "aaaaa-aaaaa-aaaaa-aaaaa-aaaaa"
        Me.LicenceTextbox.Name = "LicenceTextbox"
        Me.LicenceTextbox.Size = New System.Drawing.Size(271, 29)
        Me.LicenceTextbox.TabIndex = 166
        Me.LicenceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label84.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label84.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label84.Location = New System.Drawing.Point(31, 488)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(84, 21)
        Me.Label84.TabIndex = 168
        Me.Label84.Text = "Utilisateur:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label83.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label83.Location = New System.Drawing.Point(31, 527)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(35, 21)
        Me.Label83.TabIndex = 167
        Me.Label83.Text = "Clé:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(675, 488)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 29)
        Me.Button3.TabIndex = 169
        Me.Button3.Text = "Ignorer"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Exemple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.UserLicenceTextbox)
        Me.Controls.Add(Me.LicenceTextbox)
        Me.Controls.Add(Me.Label84)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FlatLabel9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label86)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Remise0Button)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TitleColorBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Exemple"
        Me.Text = "Avertissement Licence"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TitleColorBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Remise0Button As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents UserLicenceTextbox As TextBox
    Friend WithEvents LicenceTextbox As MaskedTextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Button3 As Button
End Class
