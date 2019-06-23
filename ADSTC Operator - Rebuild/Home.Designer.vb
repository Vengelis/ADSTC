<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.TitleColorBox = New System.Windows.Forms.PictureBox()
        Me.LicenceColorBox = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RechercheClientTextbox = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.NOMPrenomSelect = New System.Windows.Forms.RadioButton()
        Me.PrenomNOMSelect = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActualiserButton = New System.Windows.Forms.Button()
        Me.Separateur1 = New System.Windows.Forms.PictureBox()
        Me.Separateur2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Séparateur4 = New System.Windows.Forms.PictureBox()
        Me.UserStatut = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TimeRestLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NomLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PrenomLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PseudoLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Separateur3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SetOpButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tvaType = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ParametresButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Add15MinutesButton = New System.Windows.Forms.Button()
        Me.Add30MinutesButton = New System.Windows.Forms.Button()
        Me.Add2HeuresButton = New System.Windows.Forms.Button()
        Me.Add1HeureButton = New System.Windows.Forms.Button()
        Me.Add10HeuresButton = New System.Windows.Forms.Button()
        Me.Add5HeuresButton = New System.Windows.Forms.Button()
        Me.Remise0Button = New System.Windows.Forms.Button()
        Me.RemoveUneHeureButton = New System.Windows.Forms.Button()
        Me.Remboursement30MinutesButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.InfiniteHeuresButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ViewLogButton = New System.Windows.Forms.Button()
        Me.ViewCaisseButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EncaisserButton = New System.Windows.Forms.Button()
        Me.CancelEncaisseButton = New System.Windows.Forms.Button()
        Me.GroupBoxSR = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ActualisationGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AlertEncaissementBox = New System.Windows.Forms.GroupBox()
        Me.AlertEncaissementLabel = New System.Windows.Forms.Label()
        Me.LicenceButton = New System.Windows.Forms.Button()
        Me.DebugX = New System.Windows.Forms.Label()
        Me.DebugY = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.WarningProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LDAPworker = New System.ComponentModel.BackgroundWorker()
        Me.Test = New System.Windows.Forms.Button()
        Me.HideMessageBox = New System.Windows.Forms.Timer(Me.components)
        Me.LabelVisibleEtatLicence = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel1 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.TitleColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicenceColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Separateur1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Separateur2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Séparateur4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Separateur3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSR.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActualisationGroupBox.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlertEncaissementBox.SuspendLayout()
        CType(Me.WarningProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleColorBox
        '
        Me.TitleColorBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TitleColorBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleColorBox.Location = New System.Drawing.Point(0, 0)
        Me.TitleColorBox.Name = "TitleColorBox"
        Me.TitleColorBox.Size = New System.Drawing.Size(992, 36)
        Me.TitleColorBox.TabIndex = 0
        Me.TitleColorBox.TabStop = False
        '
        'LicenceColorBox
        '
        Me.LicenceColorBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LicenceColorBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicenceColorBox.Location = New System.Drawing.Point(0, 602)
        Me.LicenceColorBox.Name = "LicenceColorBox"
        Me.LicenceColorBox.Size = New System.Drawing.Size(992, 26)
        Me.LicenceColorBox.TabIndex = 1
        Me.LicenceColorBox.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(16, 142)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(275, 418)
        Me.ListBox1.TabIndex = 22
        '
        'RechercheClientTextbox
        '
        Me.RechercheClientTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechercheClientTextbox.Location = New System.Drawing.Point(16, 71)
        Me.RechercheClientTextbox.Name = "RechercheClientTextbox"
        Me.RechercheClientTextbox.Size = New System.Drawing.Size(277, 31)
        Me.RechercheClientTextbox.TabIndex = 19
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(44, 299)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(53, 17)
        Me.ListBox2.TabIndex = 4
        Me.ListBox2.Visible = False
        '
        'NOMPrenomSelect
        '
        Me.NOMPrenomSelect.AutoSize = True
        Me.NOMPrenomSelect.Checked = True
        Me.NOMPrenomSelect.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NOMPrenomSelect.Location = New System.Drawing.Point(18, 108)
        Me.NOMPrenomSelect.Name = "NOMPrenomSelect"
        Me.NOMPrenomSelect.Size = New System.Drawing.Size(125, 25)
        Me.NOMPrenomSelect.TabIndex = 20
        Me.NOMPrenomSelect.TabStop = True
        Me.NOMPrenomSelect.Text = "NOM Prénom"
        Me.NOMPrenomSelect.UseVisualStyleBackColor = True
        '
        'PrenomNOMSelect
        '
        Me.PrenomNOMSelect.AutoSize = True
        Me.PrenomNOMSelect.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PrenomNOMSelect.Location = New System.Drawing.Point(168, 108)
        Me.PrenomNOMSelect.Name = "PrenomNOMSelect"
        Me.PrenomNOMSelect.Size = New System.Drawing.Size(125, 25)
        Me.PrenomNOMSelect.TabIndex = 21
        Me.PrenomNOMSelect.Text = "Prénom NOM"
        Me.PrenomNOMSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Rechercher un client:"
        '
        'ActualiserButton
        '
        Me.ActualiserButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ActualiserButton.BackColor = System.Drawing.Color.Gainsboro
        Me.ActualiserButton.FlatAppearance.BorderSize = 0
        Me.ActualiserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActualiserButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ActualiserButton.Location = New System.Drawing.Point(16, 566)
        Me.ActualiserButton.Name = "ActualiserButton"
        Me.ActualiserButton.Size = New System.Drawing.Size(275, 30)
        Me.ActualiserButton.TabIndex = 15
        Me.ActualiserButton.Text = "Actualiser la liste"
        Me.ActualiserButton.UseVisualStyleBackColor = False
        '
        'Separateur1
        '
        Me.Separateur1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Separateur1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Separateur1.Location = New System.Drawing.Point(602, 42)
        Me.Separateur1.Name = "Separateur1"
        Me.Separateur1.Size = New System.Drawing.Size(5, 554)
        Me.Separateur1.TabIndex = 9
        Me.Separateur1.TabStop = False
        '
        'Separateur2
        '
        Me.Separateur2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Separateur2.Location = New System.Drawing.Point(319, 306)
        Me.Separateur2.Name = "Separateur2"
        Me.Separateur2.Size = New System.Drawing.Size(270, 5)
        Me.Separateur2.TabIndex = 10
        Me.Separateur2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(310, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 36)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Infos Clients"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(613, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 36)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Gestion de temps"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Séparateur4
        '
        Me.Séparateur4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Séparateur4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Séparateur4.Location = New System.Drawing.Point(992, 41)
        Me.Séparateur4.Name = "Séparateur4"
        Me.Séparateur4.Size = New System.Drawing.Size(5, 554)
        Me.Séparateur4.TabIndex = 13
        Me.Séparateur4.TabStop = False
        '
        'UserStatut
        '
        Me.UserStatut.AutoSize = True
        Me.UserStatut.BackColor = System.Drawing.Color.Transparent
        Me.UserStatut.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserStatut.ForeColor = System.Drawing.Color.Teal
        Me.UserStatut.Location = New System.Drawing.Point(398, 259)
        Me.UserStatut.Name = "UserStatut"
        Me.UserStatut.Size = New System.Drawing.Size(83, 30)
        Me.UserStatut.TabIndex = 81
        Me.UserStatut.Text = "Indéfini"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(314, 259)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 30)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Statut :"
        '
        'TimeRestLabel
        '
        Me.TimeRestLabel.AutoSize = True
        Me.TimeRestLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeRestLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeRestLabel.ForeColor = System.Drawing.Color.Teal
        Me.TimeRestLabel.Location = New System.Drawing.Point(461, 214)
        Me.TimeRestLabel.Name = "TimeRestLabel"
        Me.TimeRestLabel.Size = New System.Drawing.Size(83, 30)
        Me.TimeRestLabel.TabIndex = 78
        Me.TimeRestLabel.Text = "Indéfini"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(314, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 30)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Temps restant :"
        '
        'NomLabel
        '
        Me.NomLabel.AutoSize = True
        Me.NomLabel.BackColor = System.Drawing.Color.Transparent
        Me.NomLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomLabel.ForeColor = System.Drawing.Color.Teal
        Me.NomLabel.Location = New System.Drawing.Point(399, 103)
        Me.NomLabel.Name = "NomLabel"
        Me.NomLabel.Size = New System.Drawing.Size(83, 30)
        Me.NomLabel.TabIndex = 76
        Me.NomLabel.Text = "Indéfini"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(314, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 30)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Nom:"
        '
        'PrenomLabel
        '
        Me.PrenomLabel.AutoSize = True
        Me.PrenomLabel.BackColor = System.Drawing.Color.Transparent
        Me.PrenomLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrenomLabel.ForeColor = System.Drawing.Color.Teal
        Me.PrenomLabel.Location = New System.Drawing.Point(399, 136)
        Me.PrenomLabel.Name = "PrenomLabel"
        Me.PrenomLabel.Size = New System.Drawing.Size(83, 30)
        Me.PrenomLabel.TabIndex = 74
        Me.PrenomLabel.Text = "Indéfini"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(314, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 30)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Prénom:"
        '
        'PseudoLabel
        '
        Me.PseudoLabel.AutoSize = True
        Me.PseudoLabel.BackColor = System.Drawing.Color.Transparent
        Me.PseudoLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PseudoLabel.ForeColor = System.Drawing.Color.Teal
        Me.PseudoLabel.Location = New System.Drawing.Point(399, 168)
        Me.PseudoLabel.Name = "PseudoLabel"
        Me.PseudoLabel.Size = New System.Drawing.Size(83, 30)
        Me.PseudoLabel.TabIndex = 72
        Me.PseudoLabel.Text = "Indéfini"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(314, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 30)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Pseudo :"
        '
        'Separateur3
        '
        Me.Separateur3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Separateur3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Separateur3.Location = New System.Drawing.Point(299, 41)
        Me.Separateur3.Name = "Separateur3"
        Me.Separateur3.Size = New System.Drawing.Size(5, 554)
        Me.Separateur3.TabIndex = 82
        Me.Separateur3.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(310, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 36)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Actions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SetOpButton
        '
        Me.SetOpButton.BackColor = System.Drawing.Color.Red
        Me.SetOpButton.FlatAppearance.BorderSize = 0
        Me.SetOpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetOpButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SetOpButton.ForeColor = System.Drawing.Color.White
        Me.SetOpButton.Location = New System.Drawing.Point(319, 359)
        Me.SetOpButton.Name = "SetOpButton"
        Me.SetOpButton.Size = New System.Drawing.Size(270, 30)
        Me.SetOpButton.TabIndex = 16
        Me.SetOpButton.Text = "Passer en Opérateur"
        Me.SetOpButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(319, 405)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 5)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(310, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 36)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Infos du temps"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tvaType
        '
        Me.tvaType.AutoSize = True
        Me.tvaType.BackColor = System.Drawing.Color.Transparent
        Me.tvaType.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvaType.ForeColor = System.Drawing.Color.Teal
        Me.tvaType.Location = New System.Drawing.Point(453, 460)
        Me.tvaType.Name = "tvaType"
        Me.tvaType.Size = New System.Drawing.Size(83, 30)
        Me.tvaType.TabIndex = 125
        Me.tvaType.Text = "Indéfini"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(314, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 30)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Type de TVA:"
        '
        'ParametresButton
        '
        Me.ParametresButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParametresButton.BackColor = System.Drawing.Color.Teal
        Me.ParametresButton.FlatAppearance.BorderSize = 0
        Me.ParametresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParametresButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParametresButton.ForeColor = System.Drawing.Color.White
        Me.ParametresButton.Location = New System.Drawing.Point(833, 9)
        Me.ParametresButton.Name = "ParametresButton"
        Me.ParametresButton.Size = New System.Drawing.Size(139, 21)
        Me.ParametresButton.TabIndex = 17
        Me.ParametresButton.Text = "Paramètres"
        Me.ParametresButton.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(620, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(352, 38)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "A Encaisser : 0 €"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(621, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(352, 24)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "En attente..."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add15MinutesButton
        '
        Me.Add15MinutesButton.BackColor = System.Drawing.Color.Gainsboro
        Me.Add15MinutesButton.FlatAppearance.BorderSize = 0
        Me.Add15MinutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add15MinutesButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Add15MinutesButton.Location = New System.Drawing.Point(620, 168)
        Me.Add15MinutesButton.Name = "Add15MinutesButton"
        Me.Add15MinutesButton.Size = New System.Drawing.Size(170, 30)
        Me.Add15MinutesButton.TabIndex = 1
        Me.Add15MinutesButton.Text = "15 minutes"
        Me.Add15MinutesButton.UseVisualStyleBackColor = False
        '
        'Add30MinutesButton
        '
        Me.Add30MinutesButton.BackColor = System.Drawing.Color.Gainsboro
        Me.Add30MinutesButton.FlatAppearance.BorderSize = 0
        Me.Add30MinutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add30MinutesButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Add30MinutesButton.Location = New System.Drawing.Point(810, 168)
        Me.Add30MinutesButton.Name = "Add30MinutesButton"
        Me.Add30MinutesButton.Size = New System.Drawing.Size(170, 30)
        Me.Add30MinutesButton.TabIndex = 2
        Me.Add30MinutesButton.Text = "30 minutes"
        Me.Add30MinutesButton.UseVisualStyleBackColor = False
        '
        'Add2HeuresButton
        '
        Me.Add2HeuresButton.BackColor = System.Drawing.Color.Gainsboro
        Me.Add2HeuresButton.FlatAppearance.BorderSize = 0
        Me.Add2HeuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add2HeuresButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Add2HeuresButton.Location = New System.Drawing.Point(810, 204)
        Me.Add2HeuresButton.Name = "Add2HeuresButton"
        Me.Add2HeuresButton.Size = New System.Drawing.Size(170, 30)
        Me.Add2HeuresButton.TabIndex = 4
        Me.Add2HeuresButton.Text = "2 heures"
        Me.Add2HeuresButton.UseVisualStyleBackColor = False
        '
        'Add1HeureButton
        '
        Me.Add1HeureButton.BackColor = System.Drawing.Color.Gainsboro
        Me.Add1HeureButton.FlatAppearance.BorderSize = 0
        Me.Add1HeureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add1HeureButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Add1HeureButton.Location = New System.Drawing.Point(620, 204)
        Me.Add1HeureButton.Name = "Add1HeureButton"
        Me.Add1HeureButton.Size = New System.Drawing.Size(170, 30)
        Me.Add1HeureButton.TabIndex = 3
        Me.Add1HeureButton.Text = "1 heure"
        Me.Add1HeureButton.UseVisualStyleBackColor = False
        '
        'Add10HeuresButton
        '
        Me.Add10HeuresButton.BackColor = System.Drawing.Color.Gainsboro
        Me.Add10HeuresButton.FlatAppearance.BorderSize = 0
        Me.Add10HeuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add10HeuresButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Add10HeuresButton.Location = New System.Drawing.Point(810, 240)
        Me.Add10HeuresButton.Name = "Add10HeuresButton"
        Me.Add10HeuresButton.Size = New System.Drawing.Size(170, 30)
        Me.Add10HeuresButton.TabIndex = 6
        Me.Add10HeuresButton.Text = "10 heures"
        Me.Add10HeuresButton.UseVisualStyleBackColor = False
        '
        'Add5HeuresButton
        '
        Me.Add5HeuresButton.BackColor = System.Drawing.Color.Gainsboro
        Me.Add5HeuresButton.FlatAppearance.BorderSize = 0
        Me.Add5HeuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add5HeuresButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Add5HeuresButton.Location = New System.Drawing.Point(620, 240)
        Me.Add5HeuresButton.Name = "Add5HeuresButton"
        Me.Add5HeuresButton.Size = New System.Drawing.Size(170, 30)
        Me.Add5HeuresButton.TabIndex = 5
        Me.Add5HeuresButton.Text = "5 heures"
        Me.Add5HeuresButton.UseVisualStyleBackColor = False
        '
        'Remise0Button
        '
        Me.Remise0Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Remise0Button.FlatAppearance.BorderSize = 0
        Me.Remise0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remise0Button.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Remise0Button.Location = New System.Drawing.Point(810, 276)
        Me.Remise0Button.Name = "Remise0Button"
        Me.Remise0Button.Size = New System.Drawing.Size(170, 30)
        Me.Remise0Button.TabIndex = 8
        Me.Remise0Button.Text = "Remise à 0"
        Me.Remise0Button.UseVisualStyleBackColor = False
        '
        'RemoveUneHeureButton
        '
        Me.RemoveUneHeureButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RemoveUneHeureButton.FlatAppearance.BorderSize = 0
        Me.RemoveUneHeureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveUneHeureButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RemoveUneHeureButton.Location = New System.Drawing.Point(620, 276)
        Me.RemoveUneHeureButton.Name = "RemoveUneHeureButton"
        Me.RemoveUneHeureButton.Size = New System.Drawing.Size(170, 30)
        Me.RemoveUneHeureButton.TabIndex = 7
        Me.RemoveUneHeureButton.Text = "- 1 heure"
        Me.RemoveUneHeureButton.UseVisualStyleBackColor = False
        '
        'Remboursement30MinutesButton
        '
        Me.Remboursement30MinutesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Remboursement30MinutesButton.FlatAppearance.BorderSize = 0
        Me.Remboursement30MinutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remboursement30MinutesButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Remboursement30MinutesButton.Location = New System.Drawing.Point(620, 320)
        Me.Remboursement30MinutesButton.Name = "Remboursement30MinutesButton"
        Me.Remboursement30MinutesButton.Size = New System.Drawing.Size(360, 30)
        Me.Remboursement30MinutesButton.TabIndex = 9
        Me.Remboursement30MinutesButton.Text = "Remboursement 30 minutes"
        Me.Remboursement30MinutesButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(620, 405)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(360, 5)
        Me.PictureBox2.TabIndex = 138
        Me.PictureBox2.TabStop = False
        '
        'InfiniteHeuresButton
        '
        Me.InfiniteHeuresButton.BackColor = System.Drawing.Color.Red
        Me.InfiniteHeuresButton.FlatAppearance.BorderSize = 0
        Me.InfiniteHeuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InfiniteHeuresButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InfiniteHeuresButton.ForeColor = System.Drawing.Color.White
        Me.InfiniteHeuresButton.Location = New System.Drawing.Point(620, 359)
        Me.InfiniteHeuresButton.Name = "InfiniteHeuresButton"
        Me.InfiniteHeuresButton.Size = New System.Drawing.Size(360, 30)
        Me.InfiniteHeuresButton.TabIndex = 10
        Me.InfiniteHeuresButton.Text = "Temps Infini"
        Me.InfiniteHeuresButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(621, 413)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(359, 36)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "Gestion de temps"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewLogButton
        '
        Me.ViewLogButton.BackColor = System.Drawing.Color.Gainsboro
        Me.ViewLogButton.FlatAppearance.BorderSize = 0
        Me.ViewLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewLogButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ViewLogButton.Location = New System.Drawing.Point(620, 462)
        Me.ViewLogButton.Name = "ViewLogButton"
        Me.ViewLogButton.Size = New System.Drawing.Size(360, 30)
        Me.ViewLogButton.TabIndex = 13
        Me.ViewLogButton.Text = "Logs"
        Me.ViewLogButton.UseVisualStyleBackColor = False
        '
        'ViewCaisseButton
        '
        Me.ViewCaisseButton.BackColor = System.Drawing.Color.Gainsboro
        Me.ViewCaisseButton.FlatAppearance.BorderSize = 0
        Me.ViewCaisseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewCaisseButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ViewCaisseButton.Location = New System.Drawing.Point(620, 498)
        Me.ViewCaisseButton.Name = "ViewCaisseButton"
        Me.ViewCaisseButton.Size = New System.Drawing.Size(360, 30)
        Me.ViewCaisseButton.TabIndex = 14
        Me.ViewCaisseButton.Text = "Caisse"
        Me.ViewCaisseButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(620, 543)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(360, 5)
        Me.PictureBox3.TabIndex = 143
        Me.PictureBox3.TabStop = False
        '
        'EncaisserButton
        '
        Me.EncaisserButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EncaisserButton.BackColor = System.Drawing.Color.Green
        Me.EncaisserButton.FlatAppearance.BorderSize = 0
        Me.EncaisserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EncaisserButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EncaisserButton.ForeColor = System.Drawing.Color.White
        Me.EncaisserButton.Location = New System.Drawing.Point(620, 562)
        Me.EncaisserButton.Name = "EncaisserButton"
        Me.EncaisserButton.Size = New System.Drawing.Size(170, 30)
        Me.EncaisserButton.TabIndex = 11
        Me.EncaisserButton.Text = "Encaisser"
        Me.EncaisserButton.UseVisualStyleBackColor = False
        '
        'CancelEncaisseButton
        '
        Me.CancelEncaisseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelEncaisseButton.BackColor = System.Drawing.Color.Red
        Me.CancelEncaisseButton.FlatAppearance.BorderSize = 0
        Me.CancelEncaisseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEncaisseButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CancelEncaisseButton.ForeColor = System.Drawing.Color.White
        Me.CancelEncaisseButton.Location = New System.Drawing.Point(810, 562)
        Me.CancelEncaisseButton.Name = "CancelEncaisseButton"
        Me.CancelEncaisseButton.Size = New System.Drawing.Size(170, 30)
        Me.CancelEncaisseButton.TabIndex = 12
        Me.CancelEncaisseButton.Text = "Annuler"
        Me.CancelEncaisseButton.UseVisualStyleBackColor = False
        '
        'GroupBoxSR
        '
        Me.GroupBoxSR.BackColor = System.Drawing.Color.White
        Me.GroupBoxSR.Controls.Add(Me.Label12)
        Me.GroupBoxSR.Controls.Add(Me.PictureBox4)
        Me.GroupBoxSR.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBoxSR.Location = New System.Drawing.Point(23, 153)
        Me.GroupBoxSR.Name = "GroupBoxSR"
        Me.GroupBoxSR.Size = New System.Drawing.Size(259, 117)
        Me.GroupBoxSR.TabIndex = 146
        Me.GroupBoxSR.TabStop = False
        Me.GroupBoxSR.Text = "Informations Paramètres"
        Me.GroupBoxSR.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 51)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Le logiciel n'est pas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bien paramétré !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vérifiez les protocoles !"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(6, 28)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(92, 84)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'ActualisationGroupBox
        '
        Me.ActualisationGroupBox.BackColor = System.Drawing.Color.White
        Me.ActualisationGroupBox.Controls.Add(Me.Label14)
        Me.ActualisationGroupBox.Controls.Add(Me.PictureBox5)
        Me.ActualisationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualisationGroupBox.ForeColor = System.Drawing.Color.Teal
        Me.ActualisationGroupBox.Location = New System.Drawing.Point(23, 486)
        Me.ActualisationGroupBox.Name = "ActualisationGroupBox"
        Me.ActualisationGroupBox.Size = New System.Drawing.Size(259, 62)
        Me.ActualisationGroupBox.TabIndex = 147
        Me.ActualisationGroupBox.TabStop = False
        Me.ActualisationGroupBox.Text = "Actualisation"
        Me.ActualisationGroupBox.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(56, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(175, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Actualisation des données..."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(14, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'AlertEncaissementBox
        '
        Me.AlertEncaissementBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AlertEncaissementBox.Controls.Add(Me.AlertEncaissementLabel)
        Me.AlertEncaissementBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertEncaissementBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.AlertEncaissementBox.Location = New System.Drawing.Point(310, 531)
        Me.AlertEncaissementBox.Name = "AlertEncaissementBox"
        Me.AlertEncaissementBox.Size = New System.Drawing.Size(286, 65)
        Me.AlertEncaissementBox.TabIndex = 148
        Me.AlertEncaissementBox.TabStop = False
        Me.AlertEncaissementBox.Text = "Messages"
        Me.AlertEncaissementBox.Visible = False
        '
        'AlertEncaissementLabel
        '
        Me.AlertEncaissementLabel.AutoSize = True
        Me.AlertEncaissementLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertEncaissementLabel.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.AlertEncaissementLabel.Location = New System.Drawing.Point(6, 32)
        Me.AlertEncaissementLabel.Name = "AlertEncaissementLabel"
        Me.AlertEncaissementLabel.Size = New System.Drawing.Size(175, 16)
        Me.AlertEncaissementLabel.TabIndex = 1
        Me.AlertEncaissementLabel.Text = "Actualisation des données..."
        Me.AlertEncaissementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LicenceButton
        '
        Me.LicenceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LicenceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LicenceButton.BackgroundImage = CType(resources.GetObject("LicenceButton.BackgroundImage"), System.Drawing.Image)
        Me.LicenceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LicenceButton.FlatAppearance.BorderSize = 0
        Me.LicenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LicenceButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenceButton.ForeColor = System.Drawing.Color.White
        Me.LicenceButton.Location = New System.Drawing.Point(805, 9)
        Me.LicenceButton.Name = "LicenceButton"
        Me.LicenceButton.Size = New System.Drawing.Size(22, 21)
        Me.LicenceButton.TabIndex = 18
        Me.LicenceButton.UseVisualStyleBackColor = False
        '
        'DebugX
        '
        Me.DebugX.AutoSize = True
        Me.DebugX.Location = New System.Drawing.Point(938, 49)
        Me.DebugX.Name = "DebugX"
        Me.DebugX.Size = New System.Drawing.Size(49, 13)
        Me.DebugX.TabIndex = 150
        Me.DebugX.Text = "Debug X"
        Me.DebugX.Visible = False
        '
        'DebugY
        '
        Me.DebugY.AutoSize = True
        Me.DebugY.Location = New System.Drawing.Point(938, 62)
        Me.DebugY.Name = "DebugY"
        Me.DebugY.Size = New System.Drawing.Size(49, 13)
        Me.DebugY.TabIndex = 151
        Me.DebugY.Text = "Debug Y"
        Me.DebugY.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(6, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 25)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "Organisation:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(130, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 25)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "ADSTC - BUILD"
        '
        'WarningProvider
        '
        Me.WarningProvider.ContainerControl = Me
        Me.WarningProvider.Icon = CType(resources.GetObject("WarningProvider.Icon"), System.Drawing.Icon)
        '
        'LDAPworker
        '
        '
        'Test
        '
        Me.Test.BackColor = System.Drawing.Color.Gainsboro
        Me.Test.FlatAppearance.BorderSize = 0
        Me.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Test.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test.Location = New System.Drawing.Point(688, 9)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(111, 21)
        Me.Test.TabIndex = 156
        Me.Test.Text = "Debug Dev"
        Me.Test.UseVisualStyleBackColor = False
        Me.Test.Visible = False
        '
        'HideMessageBox
        '
        Me.HideMessageBox.Interval = 1000
        '
        'LabelVisibleEtatLicence
        '
        Me.LabelVisibleEtatLicence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelVisibleEtatLicence.AutoSize = True
        Me.LabelVisibleEtatLicence.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelVisibleEtatLicence.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.LabelVisibleEtatLicence.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelVisibleEtatLicence.Location = New System.Drawing.Point(276, 608)
        Me.LabelVisibleEtatLicence.Name = "LabelVisibleEtatLicence"
        Me.LabelVisibleEtatLicence.Size = New System.Drawing.Size(46, 13)
        Me.LabelVisibleEtatLicence.TabIndex = 155
        Me.LabelVisibleEtatLicence.Text = "Aucune"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(3, 608)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(274, 13)
        Me.FlatLabel1.TabIndex = 154
        Me.FlatLabel1.Text = "Tous droits réservés à VLogis Development - Licence:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(571, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 21)
        Me.Button1.TabIndex = 157
        Me.Button1.Text = "Debug Dev"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(454, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 21)
        Me.Button2.TabIndex = 158
        Me.Button2.Text = "Debug Dev"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(992, 628)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.LabelVisibleEtatLicence)
        Me.Controls.Add(Me.FlatLabel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DebugY)
        Me.Controls.Add(Me.DebugX)
        Me.Controls.Add(Me.LicenceButton)
        Me.Controls.Add(Me.AlertEncaissementBox)
        Me.Controls.Add(Me.ActualisationGroupBox)
        Me.Controls.Add(Me.GroupBoxSR)
        Me.Controls.Add(Me.CancelEncaisseButton)
        Me.Controls.Add(Me.EncaisserButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ViewCaisseButton)
        Me.Controls.Add(Me.ViewLogButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.InfiniteHeuresButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Remboursement30MinutesButton)
        Me.Controls.Add(Me.Remise0Button)
        Me.Controls.Add(Me.RemoveUneHeureButton)
        Me.Controls.Add(Me.Add10HeuresButton)
        Me.Controls.Add(Me.Add5HeuresButton)
        Me.Controls.Add(Me.Add2HeuresButton)
        Me.Controls.Add(Me.Add1HeureButton)
        Me.Controls.Add(Me.Add30MinutesButton)
        Me.Controls.Add(Me.Add15MinutesButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ParametresButton)
        Me.Controls.Add(Me.tvaType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SetOpButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Separateur3)
        Me.Controls.Add(Me.UserStatut)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TimeRestLabel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.NomLabel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PrenomLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PseudoLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Séparateur4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Separateur2)
        Me.Controls.Add(Me.Separateur1)
        Me.Controls.Add(Me.ActualiserButton)
        Me.Controls.Add(Me.PrenomNOMSelect)
        Me.Controls.Add(Me.NOMPrenomSelect)
        Me.Controls.Add(Me.RechercheClientTextbox)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LicenceColorBox)
        Me.Controls.Add(Me.TitleColorBox)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADSTC Opérateur"
        CType(Me.TitleColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicenceColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Separateur1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Separateur2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Séparateur4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Separateur3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSR.ResumeLayout(False)
        Me.GroupBoxSR.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActualisationGroupBox.ResumeLayout(False)
        Me.ActualisationGroupBox.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlertEncaissementBox.ResumeLayout(False)
        Me.AlertEncaissementBox.PerformLayout()
        CType(Me.WarningProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleColorBox As PictureBox
    Friend WithEvents LicenceColorBox As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents RechercheClientTextbox As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents NOMPrenomSelect As Windows.Forms.RadioButton
    Friend WithEvents PrenomNOMSelect As Windows.Forms.RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ActualiserButton As Button
    Friend WithEvents Separateur1 As PictureBox
    Friend WithEvents Separateur2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Séparateur4 As PictureBox
    Friend WithEvents UserStatut As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TimeRestLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NomLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PrenomLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PseudoLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Separateur3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SetOpButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tvaType As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ParametresButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Add15MinutesButton As Button
    Friend WithEvents Add30MinutesButton As Button
    Friend WithEvents Add2HeuresButton As Button
    Friend WithEvents Add1HeureButton As Button
    Friend WithEvents Add10HeuresButton As Button
    Friend WithEvents Add5HeuresButton As Button
    Friend WithEvents Remise0Button As Button
    Friend WithEvents RemoveUneHeureButton As Button
    Friend WithEvents Remboursement30MinutesButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents InfiniteHeuresButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ViewLogButton As Button
    Friend WithEvents ViewCaisseButton As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents EncaisserButton As Button
    Friend WithEvents CancelEncaisseButton As Button
    Friend WithEvents GroupBoxSR As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ActualisationGroupBox As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents AlertEncaissementBox As GroupBox
    Friend WithEvents AlertEncaissementLabel As Label
    Friend WithEvents LicenceButton As Button
    Friend WithEvents DebugX As Label
    Friend WithEvents DebugY As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents LabelVisibleEtatLicence As FlatLabel
    Friend WithEvents WarningProvider As ErrorProvider
    Friend WithEvents LDAPworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Test As Button
    Friend WithEvents HideMessageBox As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
