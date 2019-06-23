<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paramètres
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paramètres))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.GeneralParamPage = New System.Windows.Forms.TabPage()
        Me.EtatBDDConfigLabel = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.SaveGeneralParamPageButton = New System.Windows.Forms.Button()
        Me.EtatCaisseLabel = New System.Windows.Forms.Label()
        Me.EtatLDAPLabel = New System.Windows.Forms.Label()
        Me.EtatBDDLabel = New System.Windows.Forms.Label()
        Me.EtatConfLabel = New System.Windows.Forms.Label()
        Me.MalgachoCaisseSite = New System.Windows.Forms.Button()
        Me.DownloadMalgachoCaisse = New System.Windows.Forms.Button()
        Me.ADSTCWDSite = New System.Windows.Forms.Button()
        Me.DownloadADSTCWD = New System.Windows.Forms.Button()
        Me.ADSTCClientSite = New System.Windows.Forms.Button()
        Me.DownloadADSTCClient = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textboxOrganisationName = New System.Windows.Forms.TextBox()
        Me.textboxLogicielName = New System.Windows.Forms.TextBox()
        Me.Separateur3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AdminParamPage = New System.Windows.Forms.TabPage()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.MdpBddTextbox = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.LoginBddTextbox = New System.Windows.Forms.TextBox()
        Me.NameTableBddTextbox = New System.Windows.Forms.TextBox()
        Me.NameBddTextbox = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.UrlServerBddTextbox = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.EncodeKeySecuFileTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.SelectFileDirectoryButton = New System.Windows.Forms.Button()
        Me.LocatedFileTextbox = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.SelectBddMethode = New System.Windows.Forms.RadioButton()
        Me.SelectFileMethode = New System.Windows.Forms.RadioButton()
        Me.SelectRegeditMethode = New System.Windows.Forms.RadioButton()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.OpViewList = New System.Windows.Forms.ListView()
        Me.UtilisateurColonne = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RangColonne = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveAdminParamPageButton = New System.Windows.Forms.Button()
        Me.RemoveSelectop = New System.Windows.Forms.Button()
        Me.SelectionOpLabel = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ResponsableTextbox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Separateur2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProtocParamPage = New System.Windows.Forms.TabPage()
        Me.ApprouveTableCheck = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GenTableButton = New System.Windows.Forms.Button()
        Me.PassBddTextbox = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.LoginDbbTextbox = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.NameTableTextbox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PortBddTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.NamBddTextbox = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ForceRebootLdapButton = New System.Windows.Forms.Button()
        Me.SaveProtocParamPageButton = New System.Windows.Forms.Button()
        Me.MdpReaseauTextbox = New System.Windows.Forms.TextBox()
        Me.LoginReseauTextbox = New System.Windows.Forms.TextBox()
        Me.UrlBddTextbox = New System.Windows.Forms.TextBox()
        Me.ReseauNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PrixReducParamPage = New System.Windows.Forms.TabPage()
        Me.DeleteCouponButton = New System.Windows.Forms.Button()
        Me.ModifCouponButton = New System.Windows.Forms.Button()
        Me.CreateCouponButton = New System.Windows.Forms.Button()
        Me.IndispoCouponCheckButton = New System.Windows.Forms.RadioButton()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CouponDispoCheckButton = New System.Windows.Forms.RadioButton()
        Me.SavePriceReducParamPageButton = New System.Windows.Forms.Button()
        Me.AleaGenCoupon = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CouponReditTextbox = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CouponViewList = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Enable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TwelveTvaCheckbox = New System.Windows.Forms.CheckBox()
        Me.TenTvaCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PriceHourTextbox = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ClientsParamPage = New System.Windows.Forms.TabPage()
        Me.SaveSetClientParamPageButton = New System.Windows.Forms.Button()
        Me.PCPop006 = New System.Windows.Forms.CheckBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.ClientDedieThemeCheckeur = New System.Windows.Forms.CheckBox()
        Me.ClientDarkThemeCheckeur = New System.Windows.Forms.CheckBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.PCPop003 = New System.Windows.Forms.CheckBox()
        Me.PCPop005 = New System.Windows.Forms.CheckBox()
        Me.PCPop004 = New System.Windows.Forms.CheckBox()
        Me.ClientLightThemeCheckeur = New System.Windows.Forms.CheckBox()
        Me.PCPop002 = New System.Windows.Forms.CheckBox()
        Me.PCPop001 = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MalgachocaisseParamPage = New System.Windows.Forms.TabPage()
        Me.HelpCaisseButton = New System.Windows.Forms.Button()
        Me.EnableConnexionBddCaisseCheckeur = New System.Windows.Forms.CheckBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.SaveCaisseParamPageButton = New System.Windows.Forms.Button()
        Me.TestBddCaisseButton = New System.Windows.Forms.Button()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.PassBddCaisse = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.LoginBddCaisse = New System.Windows.Forms.TextBox()
        Me.NameTableBddCaisse = New System.Windows.Forms.TextBox()
        Me.NamBddCaisse = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.UrlBddCaisse = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ThemeParamPage = New System.Windows.Forms.TabPage()
        Me.SaveThemeParamPageButton = New System.Windows.Forms.Button()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.BuyThemeButton = New System.Windows.Forms.Button()
        Me.DedieThemeCheckeur = New System.Windows.Forms.CheckBox()
        Me.DarkThemeCheckeur = New System.Windows.Forms.CheckBox()
        Me.LightThemeCheckeur = New System.Windows.Forms.CheckBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.LicenceParamPage = New System.Windows.Forms.TabPage()
        Me.VisitSiteButton = New System.Windows.Forms.Button()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.BuyLicenceButton = New System.Windows.Forms.Button()
        Me.ActiveLicenceButton = New System.Windows.Forms.Button()
        Me.UserLicenceTextbox = New System.Windows.Forms.TextBox()
        Me.LicenceTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.VersionLogicielLabel = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.ReturnToHome = New System.Windows.Forms.Button()
        Me.ErrorIconProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.WarningIconProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ValidIconProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FlatLabel3 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel2 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel1 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel7 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel5 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel4 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.VProgressBar1 = New ADSTC_Operator___Rebuild.VProgressBar()
        Me.FlatLabel6 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel8 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.FlatLabel9 = New ADSTC_Operator___Rebuild.FlatLabel()
        Me.TabControl1.SuspendLayout()
        Me.GeneralParamPage.SuspendLayout()
        CType(Me.Separateur3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminParamPage.SuspendLayout()
        CType(Me.Separateur2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProtocParamPage.SuspendLayout()
        Me.PrixReducParamPage.SuspendLayout()
        Me.ClientsParamPage.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MalgachocaisseParamPage.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ThemeParamPage.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LicenceParamPage.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIconProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarningIconProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidIconProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.GeneralParamPage)
        Me.TabControl1.Controls.Add(Me.AdminParamPage)
        Me.TabControl1.Controls.Add(Me.ProtocParamPage)
        Me.TabControl1.Controls.Add(Me.PrixReducParamPage)
        Me.TabControl1.Controls.Add(Me.ClientsParamPage)
        Me.TabControl1.Controls.Add(Me.MalgachocaisseParamPage)
        Me.TabControl1.Controls.Add(Me.ThemeParamPage)
        Me.TabControl1.Controls.Add(Me.LicenceParamPage)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(985, 585)
        Me.TabControl1.TabIndex = 0
        '
        'GeneralParamPage
        '
        Me.GeneralParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GeneralParamPage.Controls.Add(Me.EtatBDDConfigLabel)
        Me.GeneralParamPage.Controls.Add(Me.Label51)
        Me.GeneralParamPage.Controls.Add(Me.SaveGeneralParamPageButton)
        Me.GeneralParamPage.Controls.Add(Me.EtatCaisseLabel)
        Me.GeneralParamPage.Controls.Add(Me.EtatLDAPLabel)
        Me.GeneralParamPage.Controls.Add(Me.EtatBDDLabel)
        Me.GeneralParamPage.Controls.Add(Me.EtatConfLabel)
        Me.GeneralParamPage.Controls.Add(Me.MalgachoCaisseSite)
        Me.GeneralParamPage.Controls.Add(Me.DownloadMalgachoCaisse)
        Me.GeneralParamPage.Controls.Add(Me.FlatLabel3)
        Me.GeneralParamPage.Controls.Add(Me.ADSTCWDSite)
        Me.GeneralParamPage.Controls.Add(Me.DownloadADSTCWD)
        Me.GeneralParamPage.Controls.Add(Me.FlatLabel2)
        Me.GeneralParamPage.Controls.Add(Me.ADSTCClientSite)
        Me.GeneralParamPage.Controls.Add(Me.DownloadADSTCClient)
        Me.GeneralParamPage.Controls.Add(Me.FlatLabel1)
        Me.GeneralParamPage.Controls.Add(Me.Label12)
        Me.GeneralParamPage.Controls.Add(Me.Label11)
        Me.GeneralParamPage.Controls.Add(Me.Label10)
        Me.GeneralParamPage.Controls.Add(Me.Label9)
        Me.GeneralParamPage.Controls.Add(Me.Label8)
        Me.GeneralParamPage.Controls.Add(Me.Label7)
        Me.GeneralParamPage.Controls.Add(Me.Label5)
        Me.GeneralParamPage.Controls.Add(Me.Label4)
        Me.GeneralParamPage.Controls.Add(Me.Label3)
        Me.GeneralParamPage.Controls.Add(Me.Label1)
        Me.GeneralParamPage.Controls.Add(Me.Label13)
        Me.GeneralParamPage.Controls.Add(Me.textboxOrganisationName)
        Me.GeneralParamPage.Controls.Add(Me.textboxLogicielName)
        Me.GeneralParamPage.Controls.Add(Me.Separateur3)
        Me.GeneralParamPage.Controls.Add(Me.Label2)
        Me.GeneralParamPage.Location = New System.Drawing.Point(4, 30)
        Me.GeneralParamPage.Name = "GeneralParamPage"
        Me.GeneralParamPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralParamPage.Size = New System.Drawing.Size(977, 551)
        Me.GeneralParamPage.TabIndex = 0
        Me.GeneralParamPage.Text = "Général"
        '
        'EtatBDDConfigLabel
        '
        Me.EtatBDDConfigLabel.AutoSize = True
        Me.EtatBDDConfigLabel.BackColor = System.Drawing.Color.Transparent
        Me.EtatBDDConfigLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatBDDConfigLabel.ForeColor = System.Drawing.Color.Teal
        Me.EtatBDDConfigLabel.Location = New System.Drawing.Point(237, 286)
        Me.EtatBDDConfigLabel.Name = "EtatBDDConfigLabel"
        Me.EtatBDDConfigLabel.Size = New System.Drawing.Size(38, 25)
        Me.EtatBDDConfigLabel.TabIndex = 142
        Me.EtatBDDConfigLabel.Text = "NA"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(5, 286)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(224, 25)
        Me.Label51.TabIndex = 141
        Me.Label51.Text = "Base de données logiciel:"
        '
        'SaveGeneralParamPageButton
        '
        Me.SaveGeneralParamPageButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveGeneralParamPageButton.BackColor = System.Drawing.Color.Gray
        Me.SaveGeneralParamPageButton.FlatAppearance.BorderSize = 0
        Me.SaveGeneralParamPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveGeneralParamPageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveGeneralParamPageButton.ForeColor = System.Drawing.Color.White
        Me.SaveGeneralParamPageButton.Location = New System.Drawing.Point(793, 513)
        Me.SaveGeneralParamPageButton.Name = "SaveGeneralParamPageButton"
        Me.SaveGeneralParamPageButton.Size = New System.Drawing.Size(178, 32)
        Me.SaveGeneralParamPageButton.TabIndex = 9
        Me.SaveGeneralParamPageButton.Text = "Enregistrer"
        Me.SaveGeneralParamPageButton.UseVisualStyleBackColor = False
        '
        'EtatCaisseLabel
        '
        Me.EtatCaisseLabel.AutoSize = True
        Me.EtatCaisseLabel.BackColor = System.Drawing.Color.Transparent
        Me.EtatCaisseLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatCaisseLabel.ForeColor = System.Drawing.Color.Teal
        Me.EtatCaisseLabel.Location = New System.Drawing.Point(77, 348)
        Me.EtatCaisseLabel.Name = "EtatCaisseLabel"
        Me.EtatCaisseLabel.Size = New System.Drawing.Size(38, 25)
        Me.EtatCaisseLabel.TabIndex = 139
        Me.EtatCaisseLabel.Text = "NA"
        '
        'EtatLDAPLabel
        '
        Me.EtatLDAPLabel.AutoSize = True
        Me.EtatLDAPLabel.BackColor = System.Drawing.Color.Transparent
        Me.EtatLDAPLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatLDAPLabel.ForeColor = System.Drawing.Color.Teal
        Me.EtatLDAPLabel.Location = New System.Drawing.Point(169, 318)
        Me.EtatLDAPLabel.Name = "EtatLDAPLabel"
        Me.EtatLDAPLabel.Size = New System.Drawing.Size(38, 25)
        Me.EtatLDAPLabel.TabIndex = 138
        Me.EtatLDAPLabel.Text = "NA"
        '
        'EtatBDDLabel
        '
        Me.EtatBDDLabel.AutoSize = True
        Me.EtatBDDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EtatBDDLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatBDDLabel.ForeColor = System.Drawing.Color.Teal
        Me.EtatBDDLabel.Location = New System.Drawing.Point(237, 254)
        Me.EtatBDDLabel.Name = "EtatBDDLabel"
        Me.EtatBDDLabel.Size = New System.Drawing.Size(38, 25)
        Me.EtatBDDLabel.TabIndex = 136
        Me.EtatBDDLabel.Text = "NA"
        '
        'EtatConfLabel
        '
        Me.EtatConfLabel.AutoSize = True
        Me.EtatConfLabel.BackColor = System.Drawing.Color.Transparent
        Me.EtatConfLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatConfLabel.ForeColor = System.Drawing.Color.Teal
        Me.EtatConfLabel.Location = New System.Drawing.Point(145, 224)
        Me.EtatConfLabel.Name = "EtatConfLabel"
        Me.EtatConfLabel.Size = New System.Drawing.Size(38, 25)
        Me.EtatConfLabel.TabIndex = 135
        Me.EtatConfLabel.Text = "NA"
        '
        'MalgachoCaisseSite
        '
        Me.MalgachoCaisseSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MalgachoCaisseSite.BackColor = System.Drawing.Color.Gray
        Me.MalgachoCaisseSite.FlatAppearance.BorderSize = 0
        Me.MalgachoCaisseSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MalgachoCaisseSite.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MalgachoCaisseSite.ForeColor = System.Drawing.Color.White
        Me.MalgachoCaisseSite.Location = New System.Drawing.Point(765, 455)
        Me.MalgachoCaisseSite.Name = "MalgachoCaisseSite"
        Me.MalgachoCaisseSite.Size = New System.Drawing.Size(178, 32)
        Me.MalgachoCaisseSite.TabIndex = 8
        Me.MalgachoCaisseSite.Text = "Site"
        Me.MalgachoCaisseSite.UseVisualStyleBackColor = False
        '
        'DownloadMalgachoCaisse
        '
        Me.DownloadMalgachoCaisse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadMalgachoCaisse.BackColor = System.Drawing.Color.Teal
        Me.DownloadMalgachoCaisse.FlatAppearance.BorderSize = 0
        Me.DownloadMalgachoCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownloadMalgachoCaisse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadMalgachoCaisse.ForeColor = System.Drawing.Color.White
        Me.DownloadMalgachoCaisse.Location = New System.Drawing.Point(524, 455)
        Me.DownloadMalgachoCaisse.Name = "DownloadMalgachoCaisse"
        Me.DownloadMalgachoCaisse.Size = New System.Drawing.Size(178, 32)
        Me.DownloadMalgachoCaisse.TabIndex = 5
        Me.DownloadMalgachoCaisse.Text = "Télécharger"
        Me.DownloadMalgachoCaisse.UseVisualStyleBackColor = False
        '
        'ADSTCWDSite
        '
        Me.ADSTCWDSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADSTCWDSite.BackColor = System.Drawing.Color.Gray
        Me.ADSTCWDSite.FlatAppearance.BorderSize = 0
        Me.ADSTCWDSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADSTCWDSite.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADSTCWDSite.ForeColor = System.Drawing.Color.White
        Me.ADSTCWDSite.Location = New System.Drawing.Point(765, 300)
        Me.ADSTCWDSite.Name = "ADSTCWDSite"
        Me.ADSTCWDSite.Size = New System.Drawing.Size(178, 32)
        Me.ADSTCWDSite.TabIndex = 7
        Me.ADSTCWDSite.Text = "Site"
        Me.ADSTCWDSite.UseVisualStyleBackColor = False
        '
        'DownloadADSTCWD
        '
        Me.DownloadADSTCWD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadADSTCWD.BackColor = System.Drawing.Color.Teal
        Me.DownloadADSTCWD.FlatAppearance.BorderSize = 0
        Me.DownloadADSTCWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownloadADSTCWD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadADSTCWD.ForeColor = System.Drawing.Color.White
        Me.DownloadADSTCWD.Location = New System.Drawing.Point(524, 300)
        Me.DownloadADSTCWD.Name = "DownloadADSTCWD"
        Me.DownloadADSTCWD.Size = New System.Drawing.Size(178, 32)
        Me.DownloadADSTCWD.TabIndex = 4
        Me.DownloadADSTCWD.Text = "Télécharger"
        Me.DownloadADSTCWD.UseVisualStyleBackColor = False
        '
        'ADSTCClientSite
        '
        Me.ADSTCClientSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADSTCClientSite.BackColor = System.Drawing.Color.Gray
        Me.ADSTCClientSite.FlatAppearance.BorderSize = 0
        Me.ADSTCClientSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADSTCClientSite.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADSTCClientSite.ForeColor = System.Drawing.Color.White
        Me.ADSTCClientSite.Location = New System.Drawing.Point(765, 144)
        Me.ADSTCClientSite.Name = "ADSTCClientSite"
        Me.ADSTCClientSite.Size = New System.Drawing.Size(178, 32)
        Me.ADSTCClientSite.TabIndex = 6
        Me.ADSTCClientSite.Text = "Site"
        Me.ADSTCClientSite.UseVisualStyleBackColor = False
        '
        'DownloadADSTCClient
        '
        Me.DownloadADSTCClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadADSTCClient.BackColor = System.Drawing.Color.Teal
        Me.DownloadADSTCClient.FlatAppearance.BorderSize = 0
        Me.DownloadADSTCClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownloadADSTCClient.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadADSTCClient.ForeColor = System.Drawing.Color.White
        Me.DownloadADSTCClient.Location = New System.Drawing.Point(524, 144)
        Me.DownloadADSTCClient.Name = "DownloadADSTCClient"
        Me.DownloadADSTCClient.Size = New System.Drawing.Size(178, 32)
        Me.DownloadADSTCClient.TabIndex = 3
        Me.DownloadADSTCClient.Text = "Télécharger"
        Me.DownloadADSTCClient.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(492, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 25)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "MalgachoCaisse 4000:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(494, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 25)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "ADSTC Watchdogs:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(494, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 25)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "ADSTC Client:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 25)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Caisse:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(494, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(477, 29)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Logiciels Annexes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 25)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Connexion LDAP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 25)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Base de données globale:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 25)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Configuration:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(6, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 29)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Etats des services:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Nom de l'organisation:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 25)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Nom du logiciel:"
        '
        'textboxOrganisationName
        '
        Me.textboxOrganisationName.Location = New System.Drawing.Point(215, 94)
        Me.textboxOrganisationName.Name = "textboxOrganisationName"
        Me.textboxOrganisationName.Size = New System.Drawing.Size(254, 29)
        Me.textboxOrganisationName.TabIndex = 2
        Me.textboxOrganisationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxLogicielName
        '
        Me.textboxLogicielName.Enabled = False
        Me.textboxLogicielName.Location = New System.Drawing.Point(162, 57)
        Me.textboxLogicielName.Name = "textboxLogicielName"
        Me.textboxLogicielName.Size = New System.Drawing.Size(307, 29)
        Me.textboxLogicielName.TabIndex = 1
        Me.textboxLogicielName.Text = "ADSTC Opérateur"
        Me.textboxLogicielName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Separateur3
        '
        Me.Separateur3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Separateur3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Separateur3.Location = New System.Drawing.Point(483, 6)
        Me.Separateur3.Name = "Separateur3"
        Me.Separateur3.Size = New System.Drawing.Size(5, 524)
        Me.Separateur3.TabIndex = 83
        Me.Separateur3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(471, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Informations logiciel"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminParamPage
        '
        Me.AdminParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AdminParamPage.Controls.Add(Me.FlatLabel7)
        Me.AdminParamPage.Controls.Add(Me.Label50)
        Me.AdminParamPage.Controls.Add(Me.Label49)
        Me.AdminParamPage.Controls.Add(Me.Label48)
        Me.AdminParamPage.Controls.Add(Me.MdpBddTextbox)
        Me.AdminParamPage.Controls.Add(Me.Label47)
        Me.AdminParamPage.Controls.Add(Me.LoginBddTextbox)
        Me.AdminParamPage.Controls.Add(Me.NameTableBddTextbox)
        Me.AdminParamPage.Controls.Add(Me.NameBddTextbox)
        Me.AdminParamPage.Controls.Add(Me.Label46)
        Me.AdminParamPage.Controls.Add(Me.UrlServerBddTextbox)
        Me.AdminParamPage.Controls.Add(Me.Label45)
        Me.AdminParamPage.Controls.Add(Me.Label44)
        Me.AdminParamPage.Controls.Add(Me.EncodeKeySecuFileTextbox)
        Me.AdminParamPage.Controls.Add(Me.Label43)
        Me.AdminParamPage.Controls.Add(Me.SelectFileDirectoryButton)
        Me.AdminParamPage.Controls.Add(Me.LocatedFileTextbox)
        Me.AdminParamPage.Controls.Add(Me.Label42)
        Me.AdminParamPage.Controls.Add(Me.Label41)
        Me.AdminParamPage.Controls.Add(Me.Label40)
        Me.AdminParamPage.Controls.Add(Me.SelectBddMethode)
        Me.AdminParamPage.Controls.Add(Me.SelectFileMethode)
        Me.AdminParamPage.Controls.Add(Me.SelectRegeditMethode)
        Me.AdminParamPage.Controls.Add(Me.Label39)
        Me.AdminParamPage.Controls.Add(Me.Label38)
        Me.AdminParamPage.Controls.Add(Me.OpViewList)
        Me.AdminParamPage.Controls.Add(Me.SaveAdminParamPageButton)
        Me.AdminParamPage.Controls.Add(Me.RemoveSelectop)
        Me.AdminParamPage.Controls.Add(Me.SelectionOpLabel)
        Me.AdminParamPage.Controls.Add(Me.Label19)
        Me.AdminParamPage.Controls.Add(Me.Label17)
        Me.AdminParamPage.Controls.Add(Me.Label16)
        Me.AdminParamPage.Controls.Add(Me.ResponsableTextbox)
        Me.AdminParamPage.Controls.Add(Me.Label15)
        Me.AdminParamPage.Controls.Add(Me.Label14)
        Me.AdminParamPage.Controls.Add(Me.Separateur2)
        Me.AdminParamPage.Controls.Add(Me.PictureBox1)
        Me.AdminParamPage.Controls.Add(Me.FlatLabel5)
        Me.AdminParamPage.Controls.Add(Me.FlatLabel4)
        Me.AdminParamPage.Location = New System.Drawing.Point(4, 30)
        Me.AdminParamPage.Name = "AdminParamPage"
        Me.AdminParamPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AdminParamPage.Size = New System.Drawing.Size(977, 551)
        Me.AdminParamPage.TabIndex = 1
        Me.AdminParamPage.Text = "Administration"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(639, 87)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(286, 21)
        Me.Label50.TabIndex = 168
        Me.Label50.Text = "(Pas de paramètres de méthode requits)"
        Me.Label50.Visible = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(499, 484)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(92, 17)
        Me.Label49.TabIndex = 167
        Me.Label49.Text = "Mot de passe:"
        Me.Label49.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(499, 453)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(68, 17)
        Me.Label48.TabIndex = 166
        Me.Label48.Text = "Identifiant:"
        Me.Label48.Visible = False
        '
        'MdpBddTextbox
        '
        Me.MdpBddTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MdpBddTextbox.Location = New System.Drawing.Point(609, 481)
        Me.MdpBddTextbox.Name = "MdpBddTextbox"
        Me.MdpBddTextbox.Size = New System.Drawing.Size(357, 25)
        Me.MdpBddTextbox.TabIndex = 14
        Me.MdpBddTextbox.UseSystemPasswordChar = True
        Me.MdpBddTextbox.Visible = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(499, 422)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(106, 17)
        Me.Label47.TabIndex = 164
        Me.Label47.Text = "Nom de la table:"
        Me.Label47.Visible = False
        '
        'LoginBddTextbox
        '
        Me.LoginBddTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBddTextbox.Location = New System.Drawing.Point(609, 450)
        Me.LoginBddTextbox.Name = "LoginBddTextbox"
        Me.LoginBddTextbox.Size = New System.Drawing.Size(357, 25)
        Me.LoginBddTextbox.TabIndex = 13
        Me.LoginBddTextbox.Visible = False
        '
        'NameTableBddTextbox
        '
        Me.NameTableBddTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTableBddTextbox.Location = New System.Drawing.Point(609, 419)
        Me.NameTableBddTextbox.Name = "NameTableBddTextbox"
        Me.NameTableBddTextbox.Size = New System.Drawing.Size(357, 25)
        Me.NameTableBddTextbox.TabIndex = 12
        Me.NameTableBddTextbox.Visible = False
        '
        'NameBddTextbox
        '
        Me.NameBddTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBddTextbox.Location = New System.Drawing.Point(683, 388)
        Me.NameBddTextbox.Name = "NameBddTextbox"
        Me.NameBddTextbox.Size = New System.Drawing.Size(283, 25)
        Me.NameBddTextbox.TabIndex = 11
        Me.NameBddTextbox.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(499, 392)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(178, 17)
        Me.Label46.TabIndex = 160
        Me.Label46.Text = "Nom de la base de données:"
        Me.Label46.Visible = False
        '
        'UrlServerBddTextbox
        '
        Me.UrlServerBddTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlServerBddTextbox.Location = New System.Drawing.Point(669, 359)
        Me.UrlServerBddTextbox.Name = "UrlServerBddTextbox"
        Me.UrlServerBddTextbox.Size = New System.Drawing.Size(297, 25)
        Me.UrlServerBddTextbox.TabIndex = 10
        Me.UrlServerBddTextbox.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(499, 364)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(166, 17)
        Me.Label45.TabIndex = 158
        Me.Label45.Text = "Url de la base de données:"
        Me.Label45.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Teal
        Me.Label44.Location = New System.Drawing.Point(497, 319)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(158, 25)
        Me.Label44.TabIndex = 157
        Me.Label44.Text = "Base de données:"
        Me.Label44.Visible = False
        '
        'EncodeKeySecuFileTextbox
        '
        Me.EncodeKeySecuFileTextbox.Enabled = False
        Me.EncodeKeySecuFileTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncodeKeySecuFileTextbox.Location = New System.Drawing.Point(609, 273)
        Me.EncodeKeySecuFileTextbox.Mask = "aaaaaaaa"
        Me.EncodeKeySecuFileTextbox.Name = "EncodeKeySecuFileTextbox"
        Me.EncodeKeySecuFileTextbox.Size = New System.Drawing.Size(82, 25)
        Me.EncodeKeySecuFileTextbox.TabIndex = 9
        Me.EncodeKeySecuFileTextbox.Text = "adstc297"
        Me.EncodeKeySecuFileTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EncodeKeySecuFileTextbox.UseSystemPasswordChar = True
        Me.EncodeKeySecuFileTextbox.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(499, 277)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(104, 17)
        Me.Label43.TabIndex = 155
        Me.Label43.Text = "Clé de sécuritée:"
        Me.Label43.Visible = False
        '
        'SelectFileDirectoryButton
        '
        Me.SelectFileDirectoryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectFileDirectoryButton.BackColor = System.Drawing.Color.Gray
        Me.SelectFileDirectoryButton.Enabled = False
        Me.SelectFileDirectoryButton.FlatAppearance.BorderSize = 0
        Me.SelectFileDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectFileDirectoryButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectFileDirectoryButton.ForeColor = System.Drawing.Color.White
        Me.SelectFileDirectoryButton.Location = New System.Drawing.Point(934, 263)
        Me.SelectFileDirectoryButton.Name = "SelectFileDirectoryButton"
        Me.SelectFileDirectoryButton.Size = New System.Drawing.Size(37, 25)
        Me.SelectFileDirectoryButton.TabIndex = 8
        Me.SelectFileDirectoryButton.Text = "..."
        Me.SelectFileDirectoryButton.UseVisualStyleBackColor = False
        Me.SelectFileDirectoryButton.Visible = False
        '
        'LocatedFileTextbox
        '
        Me.LocatedFileTextbox.Enabled = False
        Me.LocatedFileTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocatedFileTextbox.Location = New System.Drawing.Point(594, 241)
        Me.LocatedFileTextbox.Name = "LocatedFileTextbox"
        Me.LocatedFileTextbox.Size = New System.Drawing.Size(334, 25)
        Me.LocatedFileTextbox.TabIndex = 7
        Me.LocatedFileTextbox.Text = "C:\Program Files\ADSTC"
        Me.LocatedFileTextbox.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(499, 245)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(89, 17)
        Me.Label42.TabIndex = 152
        Me.Label42.Text = "Emplacement:"
        Me.Label42.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Teal
        Me.Label41.Location = New System.Drawing.Point(497, 220)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 25)
        Me.Label41.TabIndex = 151
        Me.Label41.Text = "Fichiers:"
        Me.Label41.Visible = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(497, 184)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(232, 25)
        Me.Label40.TabIndex = 150
        Me.Label40.Text = "Paramètres des méthodes:"
        Me.Label40.Visible = False
        '
        'SelectBddMethode
        '
        Me.SelectBddMethode.AutoSize = True
        Me.SelectBddMethode.Enabled = False
        Me.SelectBddMethode.Location = New System.Drawing.Point(502, 147)
        Me.SelectBddMethode.Name = "SelectBddMethode"
        Me.SelectBddMethode.Size = New System.Drawing.Size(195, 25)
        Me.SelectBddMethode.TabIndex = 6
        Me.SelectBddMethode.Text = "Base de données (W.I.P.)"
        Me.SelectBddMethode.UseVisualStyleBackColor = True
        '
        'SelectFileMethode
        '
        Me.SelectFileMethode.AutoSize = True
        Me.SelectFileMethode.Location = New System.Drawing.Point(502, 116)
        Me.SelectFileMethode.Name = "SelectFileMethode"
        Me.SelectFileMethode.Size = New System.Drawing.Size(81, 25)
        Me.SelectFileMethode.TabIndex = 5
        Me.SelectFileMethode.Text = "Fichiers"
        Me.SelectFileMethode.UseVisualStyleBackColor = True
        '
        'SelectRegeditMethode
        '
        Me.SelectRegeditMethode.AutoSize = True
        Me.SelectRegeditMethode.Checked = True
        Me.SelectRegeditMethode.Location = New System.Drawing.Point(502, 85)
        Me.SelectRegeditMethode.Name = "SelectRegeditMethode"
        Me.SelectRegeditMethode.Size = New System.Drawing.Size(141, 25)
        Me.SelectRegeditMethode.TabIndex = 4
        Me.SelectRegeditMethode.TabStop = True
        Me.SelectRegeditMethode.Text = "Regedit (Défaut)"
        Me.SelectRegeditMethode.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(497, 53)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(237, 25)
        Me.Label39.TabIndex = 146
        Me.Label39.Text = "Méthode de configuration:"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkRed
        Me.Label38.Location = New System.Drawing.Point(497, 14)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(471, 29)
        Me.Label38.TabIndex = 145
        Me.Label38.Text = "Fonctionnement logiciel"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpViewList
        '
        Me.OpViewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.UtilisateurColonne, Me.RangColonne})
        Me.OpViewList.Location = New System.Drawing.Point(6, 293)
        Me.OpViewList.Name = "OpViewList"
        Me.OpViewList.Size = New System.Drawing.Size(466, 215)
        Me.OpViewList.SmallImageList = Me.ImageList1
        Me.OpViewList.TabIndex = 2
        Me.OpViewList.UseCompatibleStateImageBehavior = False
        Me.OpViewList.View = System.Windows.Forms.View.Details
        '
        'UtilisateurColonne
        '
        Me.UtilisateurColonne.Text = "Utilisateur"
        Me.UtilisateurColonne.Width = 200
        '
        'RangColonne
        '
        Me.RangColonne.Text = "Rang"
        Me.RangColonne.Width = 300
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Admin.png")
        Me.ImageList1.Images.SetKeyName(1, "blue star.png")
        Me.ImageList1.Images.SetKeyName(2, "Compass.png")
        Me.ImageList1.Images.SetKeyName(3, "icon_2438661.png")
        Me.ImageList1.Images.SetKeyName(4, "icon_24386617.png")
        Me.ImageList1.Images.SetKeyName(5, "icon_163268880.png")
        Me.ImageList1.Images.SetKeyName(6, "icon_257215806.png")
        Me.ImageList1.Images.SetKeyName(7, "icon_323354384.png")
        Me.ImageList1.Images.SetKeyName(8, "icon_387623866.png")
        Me.ImageList1.Images.SetKeyName(9, "icon_500397205.png")
        Me.ImageList1.Images.SetKeyName(10, "icon_522229851.png")
        Me.ImageList1.Images.SetKeyName(11, "icon_534420434.png")
        Me.ImageList1.Images.SetKeyName(12, "icon_648751862.png")
        Me.ImageList1.Images.SetKeyName(13, "icon_652938585 - Copie.png")
        Me.ImageList1.Images.SetKeyName(14, "icon_652938585.png")
        Me.ImageList1.Images.SetKeyName(15, "icon_749890001.png")
        Me.ImageList1.Images.SetKeyName(16, "icon_753928882.png")
        Me.ImageList1.Images.SetKeyName(17, "icon_756368243.png")
        Me.ImageList1.Images.SetKeyName(18, "icon_834778152.png")
        Me.ImageList1.Images.SetKeyName(19, "icon_964883079.jpg")
        Me.ImageList1.Images.SetKeyName(20, "icon_965997750.png")
        Me.ImageList1.Images.SetKeyName(21, "icon_988677056.png")
        Me.ImageList1.Images.SetKeyName(22, "icon_1021567684.png")
        Me.ImageList1.Images.SetKeyName(23, "icon_1044441202.png")
        Me.ImageList1.Images.SetKeyName(24, "icon_1074886999.png")
        Me.ImageList1.Images.SetKeyName(25, "icon_1109941879.png")
        Me.ImageList1.Images.SetKeyName(26, "icon_1212463140.png")
        Me.ImageList1.Images.SetKeyName(27, "icon_1270368741.png")
        Me.ImageList1.Images.SetKeyName(28, "icon_1285508474.jpg")
        Me.ImageList1.Images.SetKeyName(29, "icon_1292886264.png")
        Me.ImageList1.Images.SetKeyName(30, "icon_1304285644.png")
        Me.ImageList1.Images.SetKeyName(31, "icon_1311386221.png")
        Me.ImageList1.Images.SetKeyName(32, "icon_1332692008.png")
        Me.ImageList1.Images.SetKeyName(33, "icon_1512013994.png")
        Me.ImageList1.Images.SetKeyName(34, "icon_1543006601.png")
        Me.ImageList1.Images.SetKeyName(35, "icon_1555435673.jpg")
        Me.ImageList1.Images.SetKeyName(36, "icon_1599076491.png")
        Me.ImageList1.Images.SetKeyName(37, "icon_1649942140.png")
        Me.ImageList1.Images.SetKeyName(38, "icon_1705857899.png")
        Me.ImageList1.Images.SetKeyName(39, "icon_1813792699.png")
        Me.ImageList1.Images.SetKeyName(40, "icon_1925638297.png")
        Me.ImageList1.Images.SetKeyName(41, "icon_1940519671.png")
        Me.ImageList1.Images.SetKeyName(42, "icon_2020371247.png")
        Me.ImageList1.Images.SetKeyName(43, "icon_2041428177.png")
        Me.ImageList1.Images.SetKeyName(44, "icon_2091970326.png")
        Me.ImageList1.Images.SetKeyName(45, "icon_2114432959.png")
        Me.ImageList1.Images.SetKeyName(46, "icon_2140363771.png")
        Me.ImageList1.Images.SetKeyName(47, "icon_2222628577.png")
        Me.ImageList1.Images.SetKeyName(48, "icon_2249562623.png")
        Me.ImageList1.Images.SetKeyName(49, "icon_2289640673.png")
        Me.ImageList1.Images.SetKeyName(50, "icon_2307454862.png")
        Me.ImageList1.Images.SetKeyName(51, "icon_2378588176.png")
        Me.ImageList1.Images.SetKeyName(52, "icon_2408954060.png")
        Me.ImageList1.Images.SetKeyName(53, "icon_2465779674.png")
        Me.ImageList1.Images.SetKeyName(54, "icon_2622270897.png")
        Me.ImageList1.Images.SetKeyName(55, "icon_2640683726.png")
        Me.ImageList1.Images.SetKeyName(56, "icon_2775517342.png")
        Me.ImageList1.Images.SetKeyName(57, "icon_2791809480.png")
        Me.ImageList1.Images.SetKeyName(58, "icon_2848828134.png")
        Me.ImageList1.Images.SetKeyName(59, "icon_2879126538.png")
        Me.ImageList1.Images.SetKeyName(60, "icon_2886253252.png")
        Me.ImageList1.Images.SetKeyName(61, "icon_2949348791.png")
        Me.ImageList1.Images.SetKeyName(62, "icon_2970727577.png")
        Me.ImageList1.Images.SetKeyName(63, "icon_2973400447.png")
        Me.ImageList1.Images.SetKeyName(64, "icon_3001569345.png")
        Me.ImageList1.Images.SetKeyName(65, "icon_3007889141.png")
        Me.ImageList1.Images.SetKeyName(66, "icon_3007889142.png")
        Me.ImageList1.Images.SetKeyName(67, "icon_3105040640.png")
        Me.ImageList1.Images.SetKeyName(68, "icon_3170822278.png")
        Me.ImageList1.Images.SetKeyName(69, "icon_3178069637.png")
        Me.ImageList1.Images.SetKeyName(70, "icon_3215132084.png")
        Me.ImageList1.Images.SetKeyName(71, "icon_3293873355.png")
        Me.ImageList1.Images.SetKeyName(72, "icon_3440973484.png")
        Me.ImageList1.Images.SetKeyName(73, "icon_3440983490.png")
        Me.ImageList1.Images.SetKeyName(74, "icon_3483212316.png")
        Me.ImageList1.Images.SetKeyName(75, "icon_3623298073.png")
        Me.ImageList1.Images.SetKeyName(76, "icon_3642606587.png")
        Me.ImageList1.Images.SetKeyName(77, "icon_3657059760.png")
        Me.ImageList1.Images.SetKeyName(78, "icon_3659952019.png")
        Me.ImageList1.Images.SetKeyName(79, "icon_3766282792.png")
        Me.ImageList1.Images.SetKeyName(80, "icon_3841604365.png")
        Me.ImageList1.Images.SetKeyName(81, "icon_4018455036.png")
        Me.ImageList1.Images.SetKeyName(82, "icon_4034955933.png")
        Me.ImageList1.Images.SetKeyName(83, "icon_4068049105.png")
        Me.ImageList1.Images.SetKeyName(84, "icon_4106725706.png")
        Me.ImageList1.Images.SetKeyName(85, "icon_4138420404.png")
        Me.ImageList1.Images.SetKeyName(86, "icon_4138420407.png")
        Me.ImageList1.Images.SetKeyName(87, "icon_4158303701.png")
        Me.ImageList1.Images.SetKeyName(88, "icon_4161966172.png")
        Me.ImageList1.Images.SetKeyName(89, "icon_4242176377.png")
        Me.ImageList1.Images.SetKeyName(90, "icon_4242176399.png")
        Me.ImageList1.Images.SetKeyName(91, "icon_4264844413.png")
        Me.ImageList1.Images.SetKeyName(92, "icon_aadm.png")
        Me.ImageList1.Images.SetKeyName(93, "icon_adm.png")
        Me.ImageList1.Images.SetKeyName(94, "icon_aop.png")
        Me.ImageList1.Images.SetKeyName(95, "icon_aquery.png")
        Me.ImageList1.Images.SetKeyName(96, "icon_op.png")
        Me.ImageList1.Images.SetKeyName(97, "icon_query.png")
        Me.ImageList1.Images.SetKeyName(98, "icon_querya.png")
        Me.ImageList1.Images.SetKeyName(99, "Operator.png")
        Me.ImageList1.Images.SetKeyName(100, "Query.PNG")
        '
        'SaveAdminParamPageButton
        '
        Me.SaveAdminParamPageButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveAdminParamPageButton.BackColor = System.Drawing.Color.Gray
        Me.SaveAdminParamPageButton.FlatAppearance.BorderSize = 0
        Me.SaveAdminParamPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveAdminParamPageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAdminParamPageButton.ForeColor = System.Drawing.Color.White
        Me.SaveAdminParamPageButton.Location = New System.Drawing.Point(793, 513)
        Me.SaveAdminParamPageButton.Name = "SaveAdminParamPageButton"
        Me.SaveAdminParamPageButton.Size = New System.Drawing.Size(178, 32)
        Me.SaveAdminParamPageButton.TabIndex = 15
        Me.SaveAdminParamPageButton.Text = "Enregistrer"
        Me.SaveAdminParamPageButton.UseVisualStyleBackColor = False
        '
        'RemoveSelectop
        '
        Me.RemoveSelectop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveSelectop.BackColor = System.Drawing.Color.Gray
        Me.RemoveSelectop.FlatAppearance.BorderSize = 0
        Me.RemoveSelectop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveSelectop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveSelectop.ForeColor = System.Drawing.Color.White
        Me.RemoveSelectop.Location = New System.Drawing.Point(6, 513)
        Me.RemoveSelectop.Name = "RemoveSelectop"
        Me.RemoveSelectop.Size = New System.Drawing.Size(470, 32)
        Me.RemoveSelectop.TabIndex = 3
        Me.RemoveSelectop.Text = "Retirer de la liste des opérateurs"
        Me.RemoveSelectop.UseVisualStyleBackColor = False
        '
        'SelectionOpLabel
        '
        Me.SelectionOpLabel.AutoSize = True
        Me.SelectionOpLabel.BackColor = System.Drawing.Color.Transparent
        Me.SelectionOpLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectionOpLabel.ForeColor = System.Drawing.Color.Teal
        Me.SelectionOpLabel.Location = New System.Drawing.Point(207, 265)
        Me.SelectionOpLabel.Name = "SelectionOpLabel"
        Me.SelectionOpLabel.Size = New System.Drawing.Size(38, 25)
        Me.SelectionOpLabel.TabIndex = 108
        Me.SelectionOpLabel.Text = "NA"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 265)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(203, 25)
        Me.Label19.TabIndex = 107
        Me.Label19.Text = "Opérateur selectionné:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(5, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(332, 25)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Liste des opérateurs ADSTC Opérateur"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(5, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(476, 29)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "Opérateurs"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResponsableTextbox
        '
        Me.ResponsableTextbox.Location = New System.Drawing.Point(6, 81)
        Me.ResponsableTextbox.Name = "ResponsableTextbox"
        Me.ResponsableTextbox.Size = New System.Drawing.Size(473, 29)
        Me.ResponsableTextbox.TabIndex = 1
        Me.ResponsableTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(9, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(235, 25)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Responsable Informatique:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(9, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(471, 29)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "Responsable"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Separateur2
        '
        Me.Separateur2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Separateur2.Location = New System.Drawing.Point(11, 149)
        Me.Separateur2.Name = "Separateur2"
        Me.Separateur2.Size = New System.Drawing.Size(465, 5)
        Me.Separateur2.TabIndex = 106
        Me.Separateur2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(486, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 554)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'ProtocParamPage
        '
        Me.ProtocParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProtocParamPage.Controls.Add(Me.VProgressBar1)
        Me.ProtocParamPage.Controls.Add(Me.FlatLabel6)
        Me.ProtocParamPage.Controls.Add(Me.ApprouveTableCheck)
        Me.ProtocParamPage.Controls.Add(Me.Label6)
        Me.ProtocParamPage.Controls.Add(Me.GenTableButton)
        Me.ProtocParamPage.Controls.Add(Me.PassBddTextbox)
        Me.ProtocParamPage.Controls.Add(Me.Label37)
        Me.ProtocParamPage.Controls.Add(Me.Label36)
        Me.ProtocParamPage.Controls.Add(Me.LoginDbbTextbox)
        Me.ProtocParamPage.Controls.Add(Me.Label27)
        Me.ProtocParamPage.Controls.Add(Me.NameTableTextbox)
        Me.ProtocParamPage.Controls.Add(Me.Label26)
        Me.ProtocParamPage.Controls.Add(Me.PortBddTextbox)
        Me.ProtocParamPage.Controls.Add(Me.NamBddTextbox)
        Me.ProtocParamPage.Controls.Add(Me.Label25)
        Me.ProtocParamPage.Controls.Add(Me.Label24)
        Me.ProtocParamPage.Controls.Add(Me.ForceRebootLdapButton)
        Me.ProtocParamPage.Controls.Add(Me.SaveProtocParamPageButton)
        Me.ProtocParamPage.Controls.Add(Me.MdpReaseauTextbox)
        Me.ProtocParamPage.Controls.Add(Me.LoginReseauTextbox)
        Me.ProtocParamPage.Controls.Add(Me.UrlBddTextbox)
        Me.ProtocParamPage.Controls.Add(Me.ReseauNameTextbox)
        Me.ProtocParamPage.Controls.Add(Me.Label23)
        Me.ProtocParamPage.Controls.Add(Me.Label22)
        Me.ProtocParamPage.Controls.Add(Me.Label21)
        Me.ProtocParamPage.Controls.Add(Me.Label20)
        Me.ProtocParamPage.Controls.Add(Me.Label18)
        Me.ProtocParamPage.Location = New System.Drawing.Point(4, 30)
        Me.ProtocParamPage.Name = "ProtocParamPage"
        Me.ProtocParamPage.Size = New System.Drawing.Size(977, 551)
        Me.ProtocParamPage.TabIndex = 2
        Me.ProtocParamPage.Text = "Protocoles"
        '
        'ApprouveTableCheck
        '
        Me.ApprouveTableCheck.AutoSize = True
        Me.ApprouveTableCheck.Location = New System.Drawing.Point(10, 483)
        Me.ApprouveTableCheck.Name = "ApprouveTableCheck"
        Me.ApprouveTableCheck.Size = New System.Drawing.Size(216, 25)
        Me.ApprouveTableCheck.TabIndex = 11
        Me.ApprouveTableCheck.Text = "Je valide que j'ai vérifié(e) !"
        Me.ApprouveTableCheck.UseVisualStyleBackColor = True
        Me.ApprouveTableCheck.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Générer les tables:"
        Me.Label6.Visible = False
        '
        'GenTableButton
        '
        Me.GenTableButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenTableButton.BackColor = System.Drawing.Color.Gray
        Me.GenTableButton.FlatAppearance.BorderSize = 0
        Me.GenTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenTableButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenTableButton.ForeColor = System.Drawing.Color.White
        Me.GenTableButton.Location = New System.Drawing.Point(302, 479)
        Me.GenTableButton.Name = "GenTableButton"
        Me.GenTableButton.Size = New System.Drawing.Size(178, 32)
        Me.GenTableButton.TabIndex = 12
        Me.GenTableButton.Text = "Générer"
        Me.GenTableButton.UseVisualStyleBackColor = False
        Me.GenTableButton.Visible = False
        '
        'PassBddTextbox
        '
        Me.PassBddTextbox.Location = New System.Drawing.Point(161, 370)
        Me.PassBddTextbox.Name = "PassBddTextbox"
        Me.PassBddTextbox.Size = New System.Drawing.Size(810, 29)
        Me.PassBddTextbox.TabIndex = 10
        Me.PassBddTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PassBddTextbox.UseSystemPasswordChar = True
        Me.PassBddTextbox.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(5, 374)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(128, 25)
        Me.Label37.TabIndex = 154
        Me.Label37.Text = "Mot de passe:"
        Me.Label37.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(5, 338)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 25)
        Me.Label36.TabIndex = 153
        Me.Label36.Text = "Identifiant:"
        Me.Label36.Visible = False
        '
        'LoginDbbTextbox
        '
        Me.LoginDbbTextbox.Location = New System.Drawing.Point(161, 335)
        Me.LoginDbbTextbox.Name = "LoginDbbTextbox"
        Me.LoginDbbTextbox.Size = New System.Drawing.Size(810, 29)
        Me.LoginDbbTextbox.TabIndex = 9
        Me.LoginDbbTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LoginDbbTextbox.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(5, 304)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(150, 25)
        Me.Label27.TabIndex = 151
        Me.Label27.Text = "Nom de la table:"
        Me.Label27.Visible = False
        '
        'NameTableTextbox
        '
        Me.NameTableTextbox.Location = New System.Drawing.Point(161, 300)
        Me.NameTableTextbox.Name = "NameTableTextbox"
        Me.NameTableTextbox.Size = New System.Drawing.Size(810, 29)
        Me.NameTableTextbox.TabIndex = 8
        Me.NameTableTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NameTableTextbox.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(810, 232)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 25)
        Me.Label26.TabIndex = 149
        Me.Label26.Text = "Port:"
        Me.Label26.Visible = False
        '
        'PortBddTextbox
        '
        Me.PortBddTextbox.Location = New System.Drawing.Point(871, 230)
        Me.PortBddTextbox.Mask = "00000"
        Me.PortBddTextbox.Name = "PortBddTextbox"
        Me.PortBddTextbox.Size = New System.Drawing.Size(100, 29)
        Me.PortBddTextbox.TabIndex = 6
        Me.PortBddTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PortBddTextbox.Visible = False
        '
        'NamBddTextbox
        '
        Me.NamBddTextbox.Location = New System.Drawing.Point(270, 265)
        Me.NamBddTextbox.Name = "NamBddTextbox"
        Me.NamBddTextbox.Size = New System.Drawing.Size(701, 29)
        Me.NamBddTextbox.TabIndex = 7
        Me.NamBddTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NamBddTextbox.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(5, 268)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(250, 25)
        Me.Label25.TabIndex = 146
        Me.Label25.Text = "Nom de la base de données:"
        Me.Label25.Visible = False
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DarkRed
        Me.Label24.Location = New System.Drawing.Point(5, 176)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(966, 29)
        Me.Label24.TabIndex = 145
        Me.Label24.Text = "Protocoles de connexion BDD"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ForceRebootLdapButton
        '
        Me.ForceRebootLdapButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForceRebootLdapButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ForceRebootLdapButton.FlatAppearance.BorderSize = 0
        Me.ForceRebootLdapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForceRebootLdapButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForceRebootLdapButton.ForeColor = System.Drawing.Color.White
        Me.ForceRebootLdapButton.Location = New System.Drawing.Point(731, 61)
        Me.ForceRebootLdapButton.Name = "ForceRebootLdapButton"
        Me.ForceRebootLdapButton.Size = New System.Drawing.Size(222, 29)
        Me.ForceRebootLdapButton.TabIndex = 4
        Me.ForceRebootLdapButton.Text = "Forcer le rechargement"
        Me.ForceRebootLdapButton.UseVisualStyleBackColor = False
        '
        'SaveProtocParamPageButton
        '
        Me.SaveProtocParamPageButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveProtocParamPageButton.BackColor = System.Drawing.Color.Gray
        Me.SaveProtocParamPageButton.FlatAppearance.BorderSize = 0
        Me.SaveProtocParamPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveProtocParamPageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveProtocParamPageButton.ForeColor = System.Drawing.Color.White
        Me.SaveProtocParamPageButton.Location = New System.Drawing.Point(793, 514)
        Me.SaveProtocParamPageButton.Name = "SaveProtocParamPageButton"
        Me.SaveProtocParamPageButton.Size = New System.Drawing.Size(178, 32)
        Me.SaveProtocParamPageButton.TabIndex = 13
        Me.SaveProtocParamPageButton.Text = "Enregistrer"
        Me.SaveProtocParamPageButton.UseVisualStyleBackColor = False
        '
        'MdpReaseauTextbox
        '
        Me.MdpReaseauTextbox.Location = New System.Drawing.Point(270, 131)
        Me.MdpReaseauTextbox.Name = "MdpReaseauTextbox"
        Me.MdpReaseauTextbox.Size = New System.Drawing.Size(701, 29)
        Me.MdpReaseauTextbox.TabIndex = 3
        Me.MdpReaseauTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MdpReaseauTextbox.UseSystemPasswordChar = True
        '
        'LoginReseauTextbox
        '
        Me.LoginReseauTextbox.Location = New System.Drawing.Point(270, 96)
        Me.LoginReseauTextbox.Name = "LoginReseauTextbox"
        Me.LoginReseauTextbox.Size = New System.Drawing.Size(701, 29)
        Me.LoginReseauTextbox.TabIndex = 2
        Me.LoginReseauTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UrlBddTextbox
        '
        Me.UrlBddTextbox.Location = New System.Drawing.Point(270, 230)
        Me.UrlBddTextbox.Name = "UrlBddTextbox"
        Me.UrlBddTextbox.Size = New System.Drawing.Size(534, 29)
        Me.UrlBddTextbox.TabIndex = 5
        Me.UrlBddTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReseauNameTextbox
        '
        Me.ReseauNameTextbox.Location = New System.Drawing.Point(270, 61)
        Me.ReseauNameTextbox.Name = "ReseauNameTextbox"
        Me.ReseauNameTextbox.Size = New System.Drawing.Size(455, 29)
        Me.ReseauNameTextbox.TabIndex = 1
        Me.ReseauNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(5, 133)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(256, 25)
        Me.Label23.TabIndex = 91
        Me.Label23.Text = "Mot de passe administrateur:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(5, 99)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(191, 25)
        Me.Label22.TabIndex = 90
        Me.Label22.Text = "Login administrateur:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(5, 234)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(242, 25)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "URL de la base de données:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(5, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(259, 25)
        Me.Label20.TabIndex = 88
        Me.Label20.Text = "Nom du réseau informatique:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkRed
        Me.Label18.Location = New System.Drawing.Point(5, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(966, 29)
        Me.Label18.TabIndex = 86
        Me.Label18.Text = "Protocoles de connexion LDAP"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrixReducParamPage
        '
        Me.PrixReducParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PrixReducParamPage.Controls.Add(Me.DeleteCouponButton)
        Me.PrixReducParamPage.Controls.Add(Me.ModifCouponButton)
        Me.PrixReducParamPage.Controls.Add(Me.CreateCouponButton)
        Me.PrixReducParamPage.Controls.Add(Me.IndispoCouponCheckButton)
        Me.PrixReducParamPage.Controls.Add(Me.Label35)
        Me.PrixReducParamPage.Controls.Add(Me.CouponDispoCheckButton)
        Me.PrixReducParamPage.Controls.Add(Me.SavePriceReducParamPageButton)
        Me.PrixReducParamPage.Controls.Add(Me.AleaGenCoupon)
        Me.PrixReducParamPage.Controls.Add(Me.Label34)
        Me.PrixReducParamPage.Controls.Add(Me.CouponReditTextbox)
        Me.PrixReducParamPage.Controls.Add(Me.Label30)
        Me.PrixReducParamPage.Controls.Add(Me.CouponViewList)
        Me.PrixReducParamPage.Controls.Add(Me.Label33)
        Me.PrixReducParamPage.Controls.Add(Me.TwelveTvaCheckbox)
        Me.PrixReducParamPage.Controls.Add(Me.TenTvaCheckbox)
        Me.PrixReducParamPage.Controls.Add(Me.Label32)
        Me.PrixReducParamPage.Controls.Add(Me.Label31)
        Me.PrixReducParamPage.Controls.Add(Me.PriceHourTextbox)
        Me.PrixReducParamPage.Controls.Add(Me.Label29)
        Me.PrixReducParamPage.Controls.Add(Me.Label28)
        Me.PrixReducParamPage.Location = New System.Drawing.Point(4, 30)
        Me.PrixReducParamPage.Name = "PrixReducParamPage"
        Me.PrixReducParamPage.Size = New System.Drawing.Size(977, 551)
        Me.PrixReducParamPage.TabIndex = 3
        Me.PrixReducParamPage.Text = "Prix et Réduction"
        '
        'DeleteCouponButton
        '
        Me.DeleteCouponButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteCouponButton.BackColor = System.Drawing.Color.Gray
        Me.DeleteCouponButton.FlatAppearance.BorderSize = 0
        Me.DeleteCouponButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCouponButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCouponButton.ForeColor = System.Drawing.Color.White
        Me.DeleteCouponButton.Location = New System.Drawing.Point(297, 386)
        Me.DeleteCouponButton.Name = "DeleteCouponButton"
        Me.DeleteCouponButton.Size = New System.Drawing.Size(126, 32)
        Me.DeleteCouponButton.TabIndex = 10
        Me.DeleteCouponButton.Text = "Supprimer"
        Me.DeleteCouponButton.UseVisualStyleBackColor = False
        '
        'ModifCouponButton
        '
        Me.ModifCouponButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModifCouponButton.BackColor = System.Drawing.Color.Gray
        Me.ModifCouponButton.FlatAppearance.BorderSize = 0
        Me.ModifCouponButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifCouponButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifCouponButton.ForeColor = System.Drawing.Color.White
        Me.ModifCouponButton.Location = New System.Drawing.Point(165, 386)
        Me.ModifCouponButton.Name = "ModifCouponButton"
        Me.ModifCouponButton.Size = New System.Drawing.Size(126, 32)
        Me.ModifCouponButton.TabIndex = 9
        Me.ModifCouponButton.Text = "Modifier"
        Me.ModifCouponButton.UseVisualStyleBackColor = False
        '
        'CreateCouponButton
        '
        Me.CreateCouponButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateCouponButton.BackColor = System.Drawing.Color.Gray
        Me.CreateCouponButton.FlatAppearance.BorderSize = 0
        Me.CreateCouponButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateCouponButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateCouponButton.ForeColor = System.Drawing.Color.White
        Me.CreateCouponButton.Location = New System.Drawing.Point(33, 386)
        Me.CreateCouponButton.Name = "CreateCouponButton"
        Me.CreateCouponButton.Size = New System.Drawing.Size(126, 32)
        Me.CreateCouponButton.TabIndex = 8
        Me.CreateCouponButton.Text = "Créer"
        Me.CreateCouponButton.UseVisualStyleBackColor = False
        '
        'IndispoCouponCheckButton
        '
        Me.IndispoCouponCheckButton.AutoSize = True
        Me.IndispoCouponCheckButton.Location = New System.Drawing.Point(221, 251)
        Me.IndispoCouponCheckButton.Name = "IndispoCouponCheckButton"
        Me.IndispoCouponCheckButton.Size = New System.Drawing.Size(113, 25)
        Me.IndispoCouponCheckButton.TabIndex = 7
        Me.IndispoCouponCheckButton.TabStop = True
        Me.IndispoCouponCheckButton.Text = "Indisponible"
        Me.IndispoCouponCheckButton.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(4, 253)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(100, 21)
        Me.Label35.TabIndex = 145
        Me.Label35.Text = "Disponibilité:"
        '
        'CouponDispoCheckButton
        '
        Me.CouponDispoCheckButton.AutoSize = True
        Me.CouponDispoCheckButton.Location = New System.Drawing.Point(113, 251)
        Me.CouponDispoCheckButton.Name = "CouponDispoCheckButton"
        Me.CouponDispoCheckButton.Size = New System.Drawing.Size(102, 25)
        Me.CouponDispoCheckButton.TabIndex = 6
        Me.CouponDispoCheckButton.TabStop = True
        Me.CouponDispoCheckButton.Text = "Disponible"
        Me.CouponDispoCheckButton.UseVisualStyleBackColor = True
        '
        'SavePriceReducParamPageButton
        '
        Me.SavePriceReducParamPageButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SavePriceReducParamPageButton.BackColor = System.Drawing.Color.Gray
        Me.SavePriceReducParamPageButton.FlatAppearance.BorderSize = 0
        Me.SavePriceReducParamPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SavePriceReducParamPageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavePriceReducParamPageButton.ForeColor = System.Drawing.Color.White
        Me.SavePriceReducParamPageButton.Location = New System.Drawing.Point(793, 516)
        Me.SavePriceReducParamPageButton.Name = "SavePriceReducParamPageButton"
        Me.SavePriceReducParamPageButton.Size = New System.Drawing.Size(178, 32)
        Me.SavePriceReducParamPageButton.TabIndex = 12
        Me.SavePriceReducParamPageButton.Text = "Enregistrer"
        Me.SavePriceReducParamPageButton.UseVisualStyleBackColor = False
        '
        'AleaGenCoupon
        '
        Me.AleaGenCoupon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AleaGenCoupon.BackColor = System.Drawing.Color.Gray
        Me.AleaGenCoupon.FlatAppearance.BorderSize = 0
        Me.AleaGenCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AleaGenCoupon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AleaGenCoupon.ForeColor = System.Drawing.Color.White
        Me.AleaGenCoupon.Location = New System.Drawing.Point(320, 205)
        Me.AleaGenCoupon.Name = "AleaGenCoupon"
        Me.AleaGenCoupon.Size = New System.Drawing.Size(131, 29)
        Me.AleaGenCoupon.TabIndex = 5
        Me.AleaGenCoupon.Text = "Générer"
        Me.AleaGenCoupon.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 209)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(49, 21)
        Me.Label34.TabIndex = 111
        Me.Label34.Text = "Code:"
        '
        'CouponReditTextbox
        '
        Me.CouponReditTextbox.Location = New System.Drawing.Point(61, 206)
        Me.CouponReditTextbox.Name = "CouponReditTextbox"
        Me.CouponReditTextbox.Size = New System.Drawing.Size(253, 29)
        Me.CouponReditTextbox.TabIndex = 4
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(5, 154)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(168, 25)
        Me.Label30.TabIndex = 109
        Me.Label30.Text = "Gérer les coupons:"
        '
        'CouponViewList
        '
        Me.CouponViewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Code, Me.Enable})
        Me.CouponViewList.LabelWrap = False
        Me.CouponViewList.Location = New System.Drawing.Point(457, 182)
        Me.CouponViewList.Name = "CouponViewList"
        Me.CouponViewList.Size = New System.Drawing.Size(511, 322)
        Me.CouponViewList.TabIndex = 11
        Me.CouponViewList.UseCompatibleStateImageBehavior = False
        Me.CouponViewList.View = System.Windows.Forms.View.Details
        Me.CouponViewList.VirtualMode = True
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Code
        '
        Me.Code.Text = "Code"
        Me.Code.Width = 390
        '
        'Enable
        '
        Me.Enable.Text = "Utilisé"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(452, 154)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(173, 25)
        Me.Label33.TabIndex = 107
        Me.Label33.Text = "Listes des coupons:"
        '
        'TwelveTvaCheckbox
        '
        Me.TwelveTvaCheckbox.AutoSize = True
        Me.TwelveTvaCheckbox.Location = New System.Drawing.Point(862, 57)
        Me.TwelveTvaCheckbox.Name = "TwelveTvaCheckbox"
        Me.TwelveTvaCheckbox.Size = New System.Drawing.Size(60, 25)
        Me.TwelveTvaCheckbox.TabIndex = 3
        Me.TwelveTvaCheckbox.Text = "20%"
        Me.TwelveTvaCheckbox.UseVisualStyleBackColor = True
        '
        'TenTvaCheckbox
        '
        Me.TenTvaCheckbox.AutoSize = True
        Me.TenTvaCheckbox.Location = New System.Drawing.Point(798, 58)
        Me.TenTvaCheckbox.Name = "TenTvaCheckbox"
        Me.TenTvaCheckbox.Size = New System.Drawing.Size(60, 25)
        Me.TenTvaCheckbox.TabIndex = 2
        Me.TenTvaCheckbox.Text = "10%"
        Me.TenTvaCheckbox.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(716, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 25)
        Me.Label32.TabIndex = 104
        Me.Label32.Text = "T.V.A. :"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DarkRed
        Me.Label31.Location = New System.Drawing.Point(3, 113)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(971, 29)
        Me.Label31.TabIndex = 103
        Me.Label31.Text = "Réductions"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceHourTextbox
        '
        Me.PriceHourTextbox.Location = New System.Drawing.Point(162, 56)
        Me.PriceHourTextbox.Name = "PriceHourTextbox"
        Me.PriceHourTextbox.Size = New System.Drawing.Size(72, 29)
        Me.PriceHourTextbox.TabIndex = 1
        Me.PriceHourTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(5, 57)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(154, 25)
        Me.Label29.TabIndex = 88
        Me.Label29.Text = "Prix d'une heure:"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DarkRed
        Me.Label28.Location = New System.Drawing.Point(9, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(962, 29)
        Me.Label28.TabIndex = 86
        Me.Label28.Text = "Prix et taxes"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientsParamPage
        '
        Me.ClientsParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientsParamPage.Controls.Add(Me.SaveSetClientParamPageButton)
        Me.ClientsParamPage.Controls.Add(Me.PCPop006)
        Me.ClientsParamPage.Controls.Add(Me.Label62)
        Me.ClientsParamPage.Controls.Add(Me.Label61)
        Me.ClientsParamPage.Controls.Add(Me.ClientDedieThemeCheckeur)
        Me.ClientsParamPage.Controls.Add(Me.ClientDarkThemeCheckeur)
        Me.ClientsParamPage.Controls.Add(Me.Label60)
        Me.ClientsParamPage.Controls.Add(Me.Label59)
        Me.ClientsParamPage.Controls.Add(Me.Label58)
        Me.ClientsParamPage.Controls.Add(Me.Label57)
        Me.ClientsParamPage.Controls.Add(Me.Label56)
        Me.ClientsParamPage.Controls.Add(Me.Label55)
        Me.ClientsParamPage.Controls.Add(Me.Label54)
        Me.ClientsParamPage.Controls.Add(Me.Label53)
        Me.ClientsParamPage.Controls.Add(Me.PCPop003)
        Me.ClientsParamPage.Controls.Add(Me.PCPop005)
        Me.ClientsParamPage.Controls.Add(Me.PCPop004)
        Me.ClientsParamPage.Controls.Add(Me.ClientLightThemeCheckeur)
        Me.ClientsParamPage.Controls.Add(Me.PCPop002)
        Me.ClientsParamPage.Controls.Add(Me.PCPop001)
        Me.ClientsParamPage.Controls.Add(Me.PictureBox2)
        Me.ClientsParamPage.Location = New System.Drawing.Point(4, 30)
        Me.ClientsParamPage.Name = "ClientsParamPage"
        Me.ClientsParamPage.Size = New System.Drawing.Size(977, 551)
        Me.ClientsParamPage.TabIndex = 4
        Me.ClientsParamPage.Text = "Paramètres Clients"
        '
        'SaveSetClientParamPageButton
        '
        Me.SaveSetClientParamPageButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveSetClientParamPageButton.BackColor = System.Drawing.Color.Gray
        Me.SaveSetClientParamPageButton.FlatAppearance.BorderSize = 0
        Me.SaveSetClientParamPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveSetClientParamPageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSetClientParamPageButton.ForeColor = System.Drawing.Color.White
        Me.SaveSetClientParamPageButton.Location = New System.Drawing.Point(793, 516)
        Me.SaveSetClientParamPageButton.Name = "SaveSetClientParamPageButton"
        Me.SaveSetClientParamPageButton.Size = New System.Drawing.Size(178, 32)
        Me.SaveSetClientParamPageButton.TabIndex = 10
        Me.SaveSetClientParamPageButton.Text = "Enregistrer"
        Me.SaveSetClientParamPageButton.UseVisualStyleBackColor = False
        '
        'PCPop006
        '
        Me.PCPop006.AutoSize = True
        Me.PCPop006.Location = New System.Drawing.Point(890, 386)
        Me.PCPop006.Name = "PCPop006"
        Me.PCPop006.Size = New System.Drawing.Size(71, 25)
        Me.PCPop006.TabIndex = 9
        Me.PCPop006.Text = "Activé"
        Me.PCPop006.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(503, 361)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(299, 50)
        Me.Label62.TabIndex = 99
        Me.Label62.Text = "Offrir 1 heure gratuite au premier " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "démarrage de session d'un client." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.DarkRed
        Me.Label61.Location = New System.Drawing.Point(496, 311)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(475, 29)
        Me.Label61.TabIndex = 98
        Me.Label61.Text = "Paramètres connexions"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientDedieThemeCheckeur
        '
        Me.ClientDedieThemeCheckeur.AutoSize = True
        Me.ClientDedieThemeCheckeur.Location = New System.Drawing.Point(702, 268)
        Me.ClientDedieThemeCheckeur.Name = "ClientDedieThemeCheckeur"
        Me.ClientDedieThemeCheckeur.Size = New System.Drawing.Size(69, 25)
        Me.ClientDedieThemeCheckeur.TabIndex = 8
        Me.ClientDedieThemeCheckeur.Text = "Dédié"
        Me.ClientDedieThemeCheckeur.UseVisualStyleBackColor = True
        '
        'ClientDarkThemeCheckeur
        '
        Me.ClientDarkThemeCheckeur.AutoSize = True
        Me.ClientDarkThemeCheckeur.Location = New System.Drawing.Point(890, 268)
        Me.ClientDarkThemeCheckeur.Name = "ClientDarkThemeCheckeur"
        Me.ClientDarkThemeCheckeur.Size = New System.Drawing.Size(62, 25)
        Me.ClientDarkThemeCheckeur.TabIndex = 6
        Me.ClientDarkThemeCheckeur.Text = "Dark"
        Me.ClientDarkThemeCheckeur.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(503, 239)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(166, 25)
        Me.Label60.TabIndex = 95
        Me.Label60.Text = "Thème des clients:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(503, 154)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(309, 50)
        Me.Label59.TabIndex = 94
        Me.Label59.Text = "Afficher le statut de la personne " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Responsable, Opérateur ou Client)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(503, 68)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(359, 50)
        Me.Label58.TabIndex = 93
        Me.Label58.Text = "Activer la barre d'utilisation d'un coupon " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de réduction."
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.DarkRed
        Me.Label57.Location = New System.Drawing.Point(497, 10)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(475, 29)
        Me.Label57.TabIndex = 92
        Me.Label57.Text = "Paramètres visuels"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(5, 266)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(374, 75)
        Me.Label56.TabIndex = 91
        Me.Label56.Text = "Attendre 1 minute avant l'arret de session " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lors de la connexion d'un client qua" &
    "nd son " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "temps est à 0." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(5, 154)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(325, 75)
        Me.Label55.TabIndex = 90
        Me.Label55.Text = "Envoyer un message d'avertissement " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quand il reste 5 minutes de temps " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "restant " &
    "au client." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(5, 72)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(360, 50)
        Me.Label54.TabIndex = 89
        Me.Label54.Text = "Forcer l'arret de la session de l'utilisateur " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quand le temps est à 0." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.DarkRed
        Me.Label53.Location = New System.Drawing.Point(5, 10)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(475, 29)
        Me.Label53.TabIndex = 87
        Me.Label53.Text = "Paramètres d'arret"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PCPop003
        '
        Me.PCPop003.AutoSize = True
        Me.PCPop003.Location = New System.Drawing.Point(384, 316)
        Me.PCPop003.Name = "PCPop003"
        Me.PCPop003.Size = New System.Drawing.Size(71, 25)
        Me.PCPop003.TabIndex = 3
        Me.PCPop003.Text = "Activé"
        Me.PCPop003.UseVisualStyleBackColor = True
        '
        'PCPop005
        '
        Me.PCPop005.AutoSize = True
        Me.PCPop005.Location = New System.Drawing.Point(890, 179)
        Me.PCPop005.Name = "PCPop005"
        Me.PCPop005.Size = New System.Drawing.Size(71, 25)
        Me.PCPop005.TabIndex = 5
        Me.PCPop005.Text = "Activé"
        Me.PCPop005.UseVisualStyleBackColor = True
        '
        'PCPop004
        '
        Me.PCPop004.AutoSize = True
        Me.PCPop004.Location = New System.Drawing.Point(890, 97)
        Me.PCPop004.Name = "PCPop004"
        Me.PCPop004.Size = New System.Drawing.Size(71, 25)
        Me.PCPop004.TabIndex = 4
        Me.PCPop004.Text = "Activé"
        Me.PCPop004.UseVisualStyleBackColor = True
        '
        'ClientLightThemeCheckeur
        '
        Me.ClientLightThemeCheckeur.AutoSize = True
        Me.ClientLightThemeCheckeur.Location = New System.Drawing.Point(798, 268)
        Me.ClientLightThemeCheckeur.Name = "ClientLightThemeCheckeur"
        Me.ClientLightThemeCheckeur.Size = New System.Drawing.Size(64, 25)
        Me.ClientLightThemeCheckeur.TabIndex = 7
        Me.ClientLightThemeCheckeur.Text = "Light"
        Me.ClientLightThemeCheckeur.UseVisualStyleBackColor = True
        '
        'PCPop002
        '
        Me.PCPop002.AutoSize = True
        Me.PCPop002.Location = New System.Drawing.Point(384, 204)
        Me.PCPop002.Name = "PCPop002"
        Me.PCPop002.Size = New System.Drawing.Size(71, 25)
        Me.PCPop002.TabIndex = 2
        Me.PCPop002.Text = "Activé"
        Me.PCPop002.UseVisualStyleBackColor = True
        '
        'PCPop001
        '
        Me.PCPop001.AutoSize = True
        Me.PCPop001.Location = New System.Drawing.Point(384, 97)
        Me.PCPop001.Name = "PCPop001"
        Me.PCPop001.Size = New System.Drawing.Size(71, 25)
        Me.PCPop001.TabIndex = 1
        Me.PCPop001.Text = "Activé"
        Me.PCPop001.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(486, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(5, 577)
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'MalgachocaisseParamPage
        '
        Me.MalgachocaisseParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MalgachocaisseParamPage.Controls.Add(Me.HelpCaisseButton)
        Me.MalgachocaisseParamPage.Controls.Add(Me.EnableConnexionBddCaisseCheckeur)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label70)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label69)
        Me.MalgachocaisseParamPage.Controls.Add(Me.SaveCaisseParamPageButton)
        Me.MalgachocaisseParamPage.Controls.Add(Me.TestBddCaisseButton)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label64)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label65)
        Me.MalgachocaisseParamPage.Controls.Add(Me.PassBddCaisse)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label66)
        Me.MalgachocaisseParamPage.Controls.Add(Me.LoginBddCaisse)
        Me.MalgachocaisseParamPage.Controls.Add(Me.NameTableBddCaisse)
        Me.MalgachocaisseParamPage.Controls.Add(Me.NamBddCaisse)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label67)
        Me.MalgachocaisseParamPage.Controls.Add(Me.UrlBddCaisse)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label68)
        Me.MalgachocaisseParamPage.Controls.Add(Me.Label63)
        Me.MalgachocaisseParamPage.Controls.Add(Me.PictureBox3)
        Me.MalgachocaisseParamPage.Location = New System.Drawing.Point(4, 30)
        Me.MalgachocaisseParamPage.Name = "MalgachocaisseParamPage"
        Me.MalgachocaisseParamPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MalgachocaisseParamPage.Size = New System.Drawing.Size(977, 551)
        Me.MalgachocaisseParamPage.TabIndex = 7
        Me.MalgachocaisseParamPage.Text = "MalgachoCaisse"
        '
        'HelpCaisseButton
        '
        Me.HelpCaisseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpCaisseButton.BackColor = System.Drawing.Color.Gray
        Me.HelpCaisseButton.FlatAppearance.BorderSize = 0
        Me.HelpCaisseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpCaisseButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpCaisseButton.ForeColor = System.Drawing.Color.White
        Me.HelpCaisseButton.Location = New System.Drawing.Point(116, 245)
        Me.HelpCaisseButton.Name = "HelpCaisseButton"
        Me.HelpCaisseButton.Size = New System.Drawing.Size(173, 32)
        Me.HelpCaisseButton.TabIndex = 7
        Me.HelpCaisseButton.Text = "Aide"
        Me.HelpCaisseButton.UseVisualStyleBackColor = False
        '
        'EnableConnexionBddCaisseCheckeur
        '
        Me.EnableConnexionBddCaisseCheckeur.AutoSize = True
        Me.EnableConnexionBddCaisseCheckeur.ForeColor = System.Drawing.Color.Red
        Me.EnableConnexionBddCaisseCheckeur.Location = New System.Drawing.Point(631, 76)
        Me.EnableConnexionBddCaisseCheckeur.Name = "EnableConnexionBddCaisseCheckeur"
        Me.EnableConnexionBddCaisseCheckeur.Size = New System.Drawing.Size(207, 25)
        Me.EnableConnexionBddCaisseCheckeur.TabIndex = 8
        Me.EnableConnexionBddCaisseCheckeur.Text = "Activer la synchronisation"
        Me.EnableConnexionBddCaisseCheckeur.UseVisualStyleBackColor = True
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Black
        Me.Label70.Location = New System.Drawing.Point(498, 48)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(471, 25)
        Me.Label70.TabIndex = 181
        Me.Label70.Text = "Activer l'outil de synchronisation avec MalgachoCaisse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.DarkRed
        Me.Label69.Location = New System.Drawing.Point(498, 10)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(475, 29)
        Me.Label69.TabIndex = 180
        Me.Label69.Text = "Activation"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveCaisseParamPageButton
        '
        Me.SaveCaisseParamPageButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveCaisseParamPageButton.BackColor = System.Drawing.Color.Gray
        Me.SaveCaisseParamPageButton.FlatAppearance.BorderSize = 0
        Me.SaveCaisseParamPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveCaisseParamPageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCaisseParamPageButton.ForeColor = System.Drawing.Color.White
        Me.SaveCaisseParamPageButton.Location = New System.Drawing.Point(793, 513)
        Me.SaveCaisseParamPageButton.Name = "SaveCaisseParamPageButton"
        Me.SaveCaisseParamPageButton.Size = New System.Drawing.Size(178, 32)
        Me.SaveCaisseParamPageButton.TabIndex = 9
        Me.SaveCaisseParamPageButton.Text = "Enregistrer"
        Me.SaveCaisseParamPageButton.UseVisualStyleBackColor = False
        '
        'TestBddCaisseButton
        '
        Me.TestBddCaisseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TestBddCaisseButton.BackColor = System.Drawing.Color.Gray
        Me.TestBddCaisseButton.FlatAppearance.BorderSize = 0
        Me.TestBddCaisseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestBddCaisseButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestBddCaisseButton.ForeColor = System.Drawing.Color.White
        Me.TestBddCaisseButton.Location = New System.Drawing.Point(295, 245)
        Me.TestBddCaisseButton.Name = "TestBddCaisseButton"
        Me.TestBddCaisseButton.Size = New System.Drawing.Size(178, 32)
        Me.TestBddCaisseButton.TabIndex = 6
        Me.TestBddCaisseButton.Text = "Tester"
        Me.TestBddCaisseButton.UseVisualStyleBackColor = False
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(6, 172)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(92, 17)
        Me.Label64.TabIndex = 177
        Me.Label64.Text = "Mot de passe:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(6, 141)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(68, 17)
        Me.Label65.TabIndex = 176
        Me.Label65.Text = "Identifiant:"
        '
        'PassBddCaisse
        '
        Me.PassBddCaisse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassBddCaisse.Location = New System.Drawing.Point(116, 169)
        Me.PassBddCaisse.Name = "PassBddCaisse"
        Me.PassBddCaisse.Size = New System.Drawing.Size(357, 25)
        Me.PassBddCaisse.TabIndex = 5
        Me.PassBddCaisse.UseSystemPasswordChar = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(6, 110)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(106, 17)
        Me.Label66.TabIndex = 174
        Me.Label66.Text = "Nom de la table:"
        '
        'LoginBddCaisse
        '
        Me.LoginBddCaisse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBddCaisse.Location = New System.Drawing.Point(116, 138)
        Me.LoginBddCaisse.Name = "LoginBddCaisse"
        Me.LoginBddCaisse.Size = New System.Drawing.Size(357, 25)
        Me.LoginBddCaisse.TabIndex = 4
        '
        'NameTableBddCaisse
        '
        Me.NameTableBddCaisse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTableBddCaisse.Location = New System.Drawing.Point(116, 107)
        Me.NameTableBddCaisse.Name = "NameTableBddCaisse"
        Me.NameTableBddCaisse.Size = New System.Drawing.Size(357, 25)
        Me.NameTableBddCaisse.TabIndex = 3
        '
        'NamBddCaisse
        '
        Me.NamBddCaisse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamBddCaisse.Location = New System.Drawing.Point(190, 76)
        Me.NamBddCaisse.Name = "NamBddCaisse"
        Me.NamBddCaisse.Size = New System.Drawing.Size(283, 25)
        Me.NamBddCaisse.TabIndex = 2
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(6, 80)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(178, 17)
        Me.Label67.TabIndex = 170
        Me.Label67.Text = "Nom de la base de données:"
        '
        'UrlBddCaisse
        '
        Me.UrlBddCaisse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlBddCaisse.Location = New System.Drawing.Point(176, 47)
        Me.UrlBddCaisse.Name = "UrlBddCaisse"
        Me.UrlBddCaisse.Size = New System.Drawing.Size(297, 25)
        Me.UrlBddCaisse.TabIndex = 1
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(6, 52)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(166, 17)
        Me.Label68.TabIndex = 168
        Me.Label68.Text = "Url de la base de données:"
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.DarkRed
        Me.Label63.Location = New System.Drawing.Point(3, 10)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(475, 29)
        Me.Label63.TabIndex = 88
        Me.Label63.Text = "Synchronisation des tables"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(486, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(5, 577)
        Me.PictureBox3.TabIndex = 89
        Me.PictureBox3.TabStop = False
        '
        'ThemeParamPage
        '
        Me.ThemeParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ThemeParamPage.Controls.Add(Me.SaveThemeParamPageButton)
        Me.ThemeParamPage.Controls.Add(Me.Label72)
        Me.ThemeParamPage.Controls.Add(Me.BuyThemeButton)
        Me.ThemeParamPage.Controls.Add(Me.DedieThemeCheckeur)
        Me.ThemeParamPage.Controls.Add(Me.DarkThemeCheckeur)
        Me.ThemeParamPage.Controls.Add(Me.LightThemeCheckeur)
        Me.ThemeParamPage.Controls.Add(Me.Label71)
        Me.ThemeParamPage.Controls.Add(Me.PictureBox7)
        Me.ThemeParamPage.Controls.Add(Me.PictureBox5)
        Me.ThemeParamPage.Controls.Add(Me.PictureBox4)
        Me.ThemeParamPage.Controls.Add(Me.PictureBox6)
        Me.ThemeParamPage.Controls.Add(Me.FlatLabel8)
        Me.ThemeParamPage.Location = New System.Drawing.Point(4, 30)
        Me.ThemeParamPage.Name = "ThemeParamPage"
        Me.ThemeParamPage.Size = New System.Drawing.Size(977, 551)
        Me.ThemeParamPage.TabIndex = 5
        Me.ThemeParamPage.Text = "Thème"
        '
        'SaveThemeParamPageButton
        '
        Me.SaveThemeParamPageButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveThemeParamPageButton.BackColor = System.Drawing.Color.Gray
        Me.SaveThemeParamPageButton.FlatAppearance.BorderSize = 0
        Me.SaveThemeParamPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveThemeParamPageButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveThemeParamPageButton.ForeColor = System.Drawing.Color.White
        Me.SaveThemeParamPageButton.Location = New System.Drawing.Point(795, 516)
        Me.SaveThemeParamPageButton.Name = "SaveThemeParamPageButton"
        Me.SaveThemeParamPageButton.Size = New System.Drawing.Size(178, 32)
        Me.SaveThemeParamPageButton.TabIndex = 5
        Me.SaveThemeParamPageButton.Text = "Enregistrer"
        Me.SaveThemeParamPageButton.UseVisualStyleBackColor = False
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.DarkRed
        Me.Label72.Location = New System.Drawing.Point(5, 390)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(962, 29)
        Me.Label72.TabIndex = 145
        Me.Label72.Text = "Thème dédié"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BuyThemeButton
        '
        Me.BuyThemeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuyThemeButton.BackColor = System.Drawing.Color.Gray
        Me.BuyThemeButton.FlatAppearance.BorderSize = 0
        Me.BuyThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuyThemeButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyThemeButton.ForeColor = System.Drawing.Color.White
        Me.BuyThemeButton.Location = New System.Drawing.Point(730, 429)
        Me.BuyThemeButton.Name = "BuyThemeButton"
        Me.BuyThemeButton.Size = New System.Drawing.Size(241, 32)
        Me.BuyThemeButton.TabIndex = 4
        Me.BuyThemeButton.Text = "Commandez un thème"
        Me.BuyThemeButton.UseVisualStyleBackColor = False
        '
        'DedieThemeCheckeur
        '
        Me.DedieThemeCheckeur.AutoSize = True
        Me.DedieThemeCheckeur.Enabled = False
        Me.DedieThemeCheckeur.Location = New System.Drawing.Point(803, 351)
        Me.DedieThemeCheckeur.Name = "DedieThemeCheckeur"
        Me.DedieThemeCheckeur.Size = New System.Drawing.Size(69, 25)
        Me.DedieThemeCheckeur.TabIndex = 3
        Me.DedieThemeCheckeur.Text = "Dédié"
        Me.DedieThemeCheckeur.UseVisualStyleBackColor = True
        '
        'DarkThemeCheckeur
        '
        Me.DarkThemeCheckeur.AutoSize = True
        Me.DarkThemeCheckeur.Location = New System.Drawing.Point(459, 351)
        Me.DarkThemeCheckeur.Name = "DarkThemeCheckeur"
        Me.DarkThemeCheckeur.Size = New System.Drawing.Size(62, 25)
        Me.DarkThemeCheckeur.TabIndex = 2
        Me.DarkThemeCheckeur.Text = "Dark"
        Me.DarkThemeCheckeur.UseVisualStyleBackColor = True
        '
        'LightThemeCheckeur
        '
        Me.LightThemeCheckeur.AutoSize = True
        Me.LightThemeCheckeur.Location = New System.Drawing.Point(116, 351)
        Me.LightThemeCheckeur.Name = "LightThemeCheckeur"
        Me.LightThemeCheckeur.Size = New System.Drawing.Size(64, 25)
        Me.LightThemeCheckeur.TabIndex = 1
        Me.LightThemeCheckeur.Text = "Light"
        Me.LightThemeCheckeur.UseVisualStyleBackColor = True
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.DarkRed
        Me.Label71.Location = New System.Drawing.Point(9, 13)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(962, 29)
        Me.Label71.TabIndex = 87
        Me.Label71.Text = "Thèmes"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(5, 382)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(966, 5)
        Me.PictureBox7.TabIndex = 144
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(340, 62)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(303, 283)
        Me.PictureBox5.TabIndex = 89
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(5, 62)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(303, 283)
        Me.PictureBox4.TabIndex = 88
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(671, 62)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(303, 283)
        Me.PictureBox6.TabIndex = 90
        Me.PictureBox6.TabStop = False
        '
        'LicenceParamPage
        '
        Me.LicenceParamPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LicenceParamPage.Controls.Add(Me.VisitSiteButton)
        Me.LicenceParamPage.Controls.Add(Me.Label88)
        Me.LicenceParamPage.Controls.Add(Me.Label87)
        Me.LicenceParamPage.Controls.Add(Me.Label85)
        Me.LicenceParamPage.Controls.Add(Me.Label86)
        Me.LicenceParamPage.Controls.Add(Me.BuyLicenceButton)
        Me.LicenceParamPage.Controls.Add(Me.ActiveLicenceButton)
        Me.LicenceParamPage.Controls.Add(Me.UserLicenceTextbox)
        Me.LicenceParamPage.Controls.Add(Me.LicenceTextbox)
        Me.LicenceParamPage.Controls.Add(Me.Label84)
        Me.LicenceParamPage.Controls.Add(Me.Label83)
        Me.LicenceParamPage.Controls.Add(Me.Label82)
        Me.LicenceParamPage.Controls.Add(Me.VersionLogicielLabel)
        Me.LicenceParamPage.Controls.Add(Me.Label80)
        Me.LicenceParamPage.Controls.Add(Me.Label78)
        Me.LicenceParamPage.Controls.Add(Me.Label79)
        Me.LicenceParamPage.Controls.Add(Me.Label74)
        Me.LicenceParamPage.Controls.Add(Me.Label75)
        Me.LicenceParamPage.Controls.Add(Me.Label76)
        Me.LicenceParamPage.Controls.Add(Me.Label77)
        Me.LicenceParamPage.Controls.Add(Me.Label73)
        Me.LicenceParamPage.Controls.Add(Me.PictureBox11)
        Me.LicenceParamPage.Controls.Add(Me.PictureBox10)
        Me.LicenceParamPage.Controls.Add(Me.PictureBox8)
        Me.LicenceParamPage.Controls.Add(Me.PictureBox9)
        Me.LicenceParamPage.Controls.Add(Me.FlatLabel9)
        Me.LicenceParamPage.Location = New System.Drawing.Point(4, 30)
        Me.LicenceParamPage.Name = "LicenceParamPage"
        Me.LicenceParamPage.Size = New System.Drawing.Size(977, 551)
        Me.LicenceParamPage.TabIndex = 6
        Me.LicenceParamPage.Text = "Licence"
        '
        'VisitSiteButton
        '
        Me.VisitSiteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisitSiteButton.BackColor = System.Drawing.Color.Gray
        Me.VisitSiteButton.FlatAppearance.BorderSize = 0
        Me.VisitSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VisitSiteButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitSiteButton.ForeColor = System.Drawing.Color.White
        Me.VisitSiteButton.Location = New System.Drawing.Point(789, 395)
        Me.VisitSiteButton.Name = "VisitSiteButton"
        Me.VisitSiteButton.Size = New System.Drawing.Size(178, 30)
        Me.VisitSiteButton.TabIndex = 5
        Me.VisitSiteButton.Text = "Visiter le site web"
        Me.VisitSiteButton.UseVisualStyleBackColor = False
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.ForeColor = System.Drawing.Color.Red
        Me.Label88.Location = New System.Drawing.Point(131, 498)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(54, 21)
        Me.Label88.TabIndex = 159
        Me.Label88.Text = "Aucun"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(22, 498)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(112, 21)
        Me.Label87.TabIndex = 158
        Me.Label87.Text = "Théme unique:"
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.DarkRed
        Me.Label85.Location = New System.Drawing.Point(5, 469)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(962, 29)
        Me.Label85.TabIndex = 157
        Me.Label85.Text = "Suppléments"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(7, 163)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(325, 13)
        Me.Label86.TabIndex = 156
        Me.Label86.Text = "Copyright © 2019 - Tous droits réservés à VLogis Development"
        '
        'BuyLicenceButton
        '
        Me.BuyLicenceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuyLicenceButton.BackColor = System.Drawing.Color.Gray
        Me.BuyLicenceButton.FlatAppearance.BorderSize = 0
        Me.BuyLicenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuyLicenceButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyLicenceButton.ForeColor = System.Drawing.Color.White
        Me.BuyLicenceButton.Location = New System.Drawing.Point(395, 374)
        Me.BuyLicenceButton.Name = "BuyLicenceButton"
        Me.BuyLicenceButton.Size = New System.Drawing.Size(204, 29)
        Me.BuyLicenceButton.TabIndex = 3
        Me.BuyLicenceButton.Text = "Se procurer une licence"
        Me.BuyLicenceButton.UseVisualStyleBackColor = False
        '
        'ActiveLicenceButton
        '
        Me.ActiveLicenceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActiveLicenceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ActiveLicenceButton.FlatAppearance.BorderSize = 0
        Me.ActiveLicenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActiveLicenceButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveLicenceButton.ForeColor = System.Drawing.Color.Black
        Me.ActiveLicenceButton.Location = New System.Drawing.Point(395, 409)
        Me.ActiveLicenceButton.Name = "ActiveLicenceButton"
        Me.ActiveLicenceButton.Size = New System.Drawing.Size(204, 29)
        Me.ActiveLicenceButton.TabIndex = 4
        Me.ActiveLicenceButton.Text = "Activer"
        Me.ActiveLicenceButton.UseVisualStyleBackColor = False
        '
        'UserLicenceTextbox
        '
        Me.UserLicenceTextbox.Location = New System.Drawing.Point(118, 374)
        Me.UserLicenceTextbox.Name = "UserLicenceTextbox"
        Me.UserLicenceTextbox.Size = New System.Drawing.Size(271, 29)
        Me.UserLicenceTextbox.TabIndex = 1
        Me.UserLicenceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LicenceTextbox
        '
        Me.LicenceTextbox.Location = New System.Drawing.Point(118, 408)
        Me.LicenceTextbox.Mask = "aaaaa-aaaaa-aaaaa-aaaaa-aaaaa"
        Me.LicenceTextbox.Name = "LicenceTextbox"
        Me.LicenceTextbox.Size = New System.Drawing.Size(271, 29)
        Me.LicenceTextbox.TabIndex = 2
        Me.LicenceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(22, 377)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(84, 21)
        Me.Label84.TabIndex = 149
        Me.Label84.Text = "Utilisateur:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(22, 411)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(35, 21)
        Me.Label83.TabIndex = 148
        Me.Label83.Text = "Clé:"
        '
        'Label82
        '
        Me.Label82.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.DarkRed
        Me.Label82.Location = New System.Drawing.Point(9, 208)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(962, 29)
        Me.Label82.TabIndex = 146
        Me.Label82.Text = "Activation"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VersionLogicielLabel
        '
        Me.VersionLogicielLabel.AutoSize = True
        Me.VersionLogicielLabel.BackColor = System.Drawing.Color.Transparent
        Me.VersionLogicielLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLogicielLabel.ForeColor = System.Drawing.Color.Red
        Me.VersionLogicielLabel.Location = New System.Drawing.Point(884, 163)
        Me.VersionLogicielLabel.Name = "VersionLogicielLabel"
        Me.VersionLogicielLabel.Size = New System.Drawing.Size(90, 25)
        Me.VersionLogicielLabel.TabIndex = 98
        Me.VersionLogicielLabel.Text = "1.0.1.16"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Black
        Me.Label80.Location = New System.Drawing.Point(705, 163)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(176, 25)
        Me.Label80.TabIndex = 97
        Me.Label80.Text = "Version officielle:"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label78.Location = New System.Drawing.Point(9, 132)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(150, 25)
        Me.Label78.TabIndex = 96
        Me.Label78.Text = "Master Edition"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Red
        Me.Label79.Location = New System.Drawing.Point(306, 132)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(139, 25)
        Me.Label79.TabIndex = 95
        Me.Label79.Text = "Version Build"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(175, 91)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(224, 25)
        Me.Label74.TabIndex = 93
        Me.Label74.Text = "Session Time Counter"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label75.Location = New System.Drawing.Point(14, 91)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(163, 25)
        Me.Label75.TabIndex = 92
        Me.Label75.Text = "Active Directory"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label76.Location = New System.Drawing.Point(14, 43)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(91, 55)
        Me.Label76.TabIndex = 90
        Me.Label76.Text = "AD"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.White
        Me.Label77.Location = New System.Drawing.Point(96, 43)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(120, 55)
        Me.Label77.TabIndex = 91
        Me.Label77.Text = "STC"
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.DarkRed
        Me.Label73.Location = New System.Drawing.Point(9, 6)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(962, 29)
        Me.Label73.TabIndex = 88
        Me.Label73.Text = "Licence"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox11.Location = New System.Drawing.Point(5, 461)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(966, 5)
        Me.PictureBox11.TabIndex = 152
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox10.Location = New System.Drawing.Point(5, 191)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(966, 5)
        Me.PictureBox10.TabIndex = 145
        Me.PictureBox10.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.ADSTC_Operator___Rebuild.My.Resources.Resources.Banner2
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(448, 43)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(523, 117)
        Me.PictureBox8.TabIndex = 89
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(5, 43)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(448, 117)
        Me.PictureBox9.TabIndex = 94
        Me.PictureBox9.TabStop = False
        '
        'ReturnToHome
        '
        Me.ReturnToHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReturnToHome.BackColor = System.Drawing.Color.Gray
        Me.ReturnToHome.FlatAppearance.BorderSize = 0
        Me.ReturnToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnToHome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToHome.ForeColor = System.Drawing.Color.White
        Me.ReturnToHome.Location = New System.Drawing.Point(810, 593)
        Me.ReturnToHome.Name = "ReturnToHome"
        Me.ReturnToHome.Size = New System.Drawing.Size(178, 32)
        Me.ReturnToHome.TabIndex = 141
        Me.ReturnToHome.Text = "Retour"
        Me.ReturnToHome.UseVisualStyleBackColor = False
        '
        'ErrorIconProvider
        '
        Me.ErrorIconProvider.ContainerControl = Me
        '
        'WarningIconProvider
        '
        Me.WarningIconProvider.ContainerControl = Me
        Me.WarningIconProvider.Icon = CType(resources.GetObject("WarningIconProvider.Icon"), System.Drawing.Icon)
        '
        'ValidIconProvider
        '
        Me.ValidIconProvider.ContainerControl = Me
        Me.ValidIconProvider.Icon = CType(resources.GetObject("ValidIconProvider.Icon"), System.Drawing.Icon)
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel3.Location = New System.Drawing.Point(494, 369)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(487, 78)
        Me.FlatLabel3.TabIndex = 132
        Me.FlatLabel3.Text = resources.GetString("FlatLabel3.Text")
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel2.Location = New System.Drawing.Point(494, 214)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(466, 78)
        Me.FlatLabel2.TabIndex = 129
        Me.FlatLabel2.Text = resources.GetString("FlatLabel2.Text")
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel1.Location = New System.Drawing.Point(494, 84)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(449, 52)
        Me.FlatLabel1.TabIndex = 98
        Me.FlatLabel1.Text = resources.GetString("FlatLabel1.Text")
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel7.Location = New System.Drawing.Point(499, 344)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(385, 13)
        Me.FlatLabel7.TabIndex = 169
        Me.FlatLabel7.Text = "Pour utiliser cette méthode, générez la table dans la rubrique 'Protocoles'"
        Me.FlatLabel7.Visible = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel5.Location = New System.Drawing.Point(7, 229)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(478, 26)
        Me.FlatLabel5.TabIndex = 103
        Me.FlatLabel5.Text = "Les opérateurs sont les personnes ayant la permission d'utiliser le logiciel ADST" &
    "C Opérateur," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "qui bénéficie de la permission d'ajouter des heures et de faire de" &
    "s encaissements."
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel4.Location = New System.Drawing.Point(11, 113)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(468, 26)
        Me.FlatLabel4.TabIndex = 99
        Me.FlatLabel4.Text = "Le responsable informatique sera le gérant du logiciel. Seul lui bénéficie de la " &
    "permission " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pour modifier les paraètres du logiciel."
        '
        'VProgressBar1
        '
        Me.VProgressBar1.Couleur1 = System.Drawing.Color.Black
        Me.VProgressBar1.Couleur2 = System.Drawing.Color.Orange
        Me.VProgressBar1.CouleurFond = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VProgressBar1.Location = New System.Drawing.Point(10, 514)
        Me.VProgressBar1.Name = "VProgressBar1"
        Me.VProgressBar1.Size = New System.Drawing.Size(470, 13)
        Me.VProgressBar1.TabIndex = 160
        Me.VProgressBar1.Text = "VProgressBar1"
        Me.VProgressBar1.Valeur = 0
        Me.VProgressBar1.Visible = False
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatLabel6.Location = New System.Drawing.Point(7, 437)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(473, 39)
        Me.FlatLabel6.TabIndex = 159
        Me.FlatLabel6.Text = resources.GetString("FlatLabel6.Text")
        Me.FlatLabel6.Visible = False
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel8.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel8.Location = New System.Drawing.Point(11, 429)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(689, 68)
        Me.FlatLabel8.TabIndex = 143
        Me.FlatLabel8.Text = resources.GetString("FlatLabel8.Text")
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel9.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel9.Location = New System.Drawing.Point(21, 247)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(844, 102)
        Me.FlatLabel9.TabIndex = 147
        Me.FlatLabel9.Text = resources.GetString("FlatLabel9.Text")
        '
        'Paramètres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReturnToHome)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1008, 667)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1008, 667)
        Me.Name = "Paramètres"
        Me.Text = "Parametres"
        Me.TabControl1.ResumeLayout(False)
        Me.GeneralParamPage.ResumeLayout(False)
        Me.GeneralParamPage.PerformLayout()
        CType(Me.Separateur3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminParamPage.ResumeLayout(False)
        Me.AdminParamPage.PerformLayout()
        CType(Me.Separateur2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProtocParamPage.ResumeLayout(False)
        Me.ProtocParamPage.PerformLayout()
        Me.PrixReducParamPage.ResumeLayout(False)
        Me.PrixReducParamPage.PerformLayout()
        Me.ClientsParamPage.ResumeLayout(False)
        Me.ClientsParamPage.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MalgachocaisseParamPage.ResumeLayout(False)
        Me.MalgachocaisseParamPage.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ThemeParamPage.ResumeLayout(False)
        Me.ThemeParamPage.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LicenceParamPage.ResumeLayout(False)
        Me.LicenceParamPage.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIconProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarningIconProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidIconProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GeneralParamPage As TabPage
    Friend WithEvents AdminParamPage As TabPage
    Friend WithEvents ProtocParamPage As TabPage
    Friend WithEvents PrixReducParamPage As TabPage
    Friend WithEvents ClientsParamPage As TabPage
    Friend WithEvents ThemeParamPage As TabPage
    Friend WithEvents LicenceParamPage As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents textboxOrganisationName As TextBox
    Friend WithEvents textboxLogicielName As TextBox
    Friend WithEvents Separateur3 As PictureBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents EtatCaisseLabel As Label
    Friend WithEvents EtatLDAPLabel As Label
    Friend WithEvents EtatBDDLabel As Label
    Friend WithEvents EtatConfLabel As Label
    Friend WithEvents MalgachoCaisseSite As Button
    Friend WithEvents DownloadMalgachoCaisse As Button
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents ADSTCWDSite As Button
    Friend WithEvents DownloadADSTCWD As Button
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents ADSTCClientSite As Button
    Friend WithEvents DownloadADSTCClient As Button
    Friend WithEvents MalgachocaisseParamPage As TabPage
    Friend WithEvents SaveGeneralParamPageButton As Button
    Friend WithEvents ReturnToHome As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents Label15 As Label
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ResponsableTextbox As TextBox
    Friend WithEvents RemoveSelectop As Button
    Friend WithEvents SelectionOpLabel As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Separateur2 As PictureBox
    Friend WithEvents MdpReaseauTextbox As TextBox
    Friend WithEvents LoginReseauTextbox As TextBox
    Friend WithEvents UrlBddTextbox As TextBox
    Friend WithEvents ReseauNameTextbox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents SaveAdminParamPageButton As Button
    Friend WithEvents SaveProtocParamPageButton As Button
    Friend WithEvents ForceRebootLdapButton As Button
    Friend WithEvents CouponViewList As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents Enable As ColumnHeader
    Friend WithEvents Label33 As Label
    Friend WithEvents TwelveTvaCheckbox As CheckBox
    Friend WithEvents TenTvaCheckbox As CheckBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents PriceHourTextbox As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents IndispoCouponCheckButton As Windows.Forms.RadioButton
    Friend WithEvents Label35 As Label
    Friend WithEvents CouponDispoCheckButton As Windows.Forms.RadioButton
    Friend WithEvents SavePriceReducParamPageButton As Button
    Friend WithEvents AleaGenCoupon As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents CouponReditTextbox As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents OpViewList As ListView
    Friend WithEvents UtilisateurColonne As ColumnHeader
    Friend WithEvents RangColonne As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DeleteCouponButton As Button
    Friend WithEvents ModifCouponButton As Button
    Friend WithEvents CreateCouponButton As Button
    Friend WithEvents ErrorIconProvider As ErrorProvider
    Friend WithEvents WarningIconProvider As ErrorProvider
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents PassBddTextbox As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents LoginDbbTextbox As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents NameTableTextbox As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents PortBddTextbox As MaskedTextBox
    Friend WithEvents NamBddTextbox As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents SelectBddMethode As Windows.Forms.RadioButton
    Friend WithEvents SelectFileMethode As Windows.Forms.RadioButton
    Friend WithEvents SelectRegeditMethode As Windows.Forms.RadioButton
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents MdpBddTextbox As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents LoginBddTextbox As TextBox
    Friend WithEvents NameTableBddTextbox As TextBox
    Friend WithEvents NameBddTextbox As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents UrlServerBddTextbox As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents EncodeKeySecuFileTextbox As MaskedTextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents SelectFileDirectoryButton As Button
    Friend WithEvents LocatedFileTextbox As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents EtatBDDConfigLabel As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents Label50 As Label
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents ApprouveTableCheck As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GenTableButton As Button
    Friend WithEvents VProgressBar1 As VProgressBar
    Friend WithEvents SaveSetClientParamPageButton As Button
    Friend WithEvents PCPop006 As CheckBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents ClientDedieThemeCheckeur As CheckBox
    Friend WithEvents ClientDarkThemeCheckeur As CheckBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label53 As Label
    Friend WithEvents PCPop003 As CheckBox
    Friend WithEvents PCPop005 As CheckBox
    Friend WithEvents PCPop004 As CheckBox
    Friend WithEvents ClientLightThemeCheckeur As CheckBox
    Friend WithEvents PCPop002 As CheckBox
    Friend WithEvents PCPop001 As CheckBox
    Friend WithEvents EnableConnexionBddCaisseCheckeur As CheckBox
    Friend WithEvents Label70 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents SaveCaisseParamPageButton As Button
    Friend WithEvents TestBddCaisseButton As Button
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents PassBddCaisse As TextBox
    Friend WithEvents Label66 As Label
    Friend WithEvents LoginBddCaisse As TextBox
    Friend WithEvents NameTableBddCaisse As TextBox
    Friend WithEvents NamBddCaisse As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents UrlBddCaisse As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label63 As Label
    Friend WithEvents DedieThemeCheckeur As CheckBox
    Friend WithEvents DarkThemeCheckeur As CheckBox
    Friend WithEvents LightThemeCheckeur As CheckBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label71 As Label
    Friend WithEvents ValidIconProvider As ErrorProvider
    Friend WithEvents SaveThemeParamPageButton As Button
    Friend WithEvents Label72 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents FlatLabel8 As FlatLabel
    Friend WithEvents BuyThemeButton As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents BuyLicenceButton As Button
    Friend WithEvents ActiveLicenceButton As Button
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents UserLicenceTextbox As TextBox
    Friend WithEvents LicenceTextbox As MaskedTextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents Label82 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents VersionLogicielLabel As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents VisitSiteButton As Button
    Friend WithEvents Label88 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents HelpCaisseButton As Button
End Class
