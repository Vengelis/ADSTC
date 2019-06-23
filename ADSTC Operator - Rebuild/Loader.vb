Imports MySql.Data.MySqlClient
Imports System.Web.Script.Serialization
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.DirectoryServices

Public Class Loader

    Public VerifClose As Boolean = True

    Public NbEtapeTotal As Integer = 8

    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EtatEtapeLabel.Text = "Chargement du loadeur..."
        VProgressBar1.Valeur = 5
        NumberEtapes.Text = NbEtapeTotal
        ThisEtapeNumber.Text = 1

        Home.Hide()
        Paramètres.Hide()
        Me.Show()

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        VProgressBar1.Valeur = 10
        ThisEtapeNumber.Text = 2
        EtatEtapeLabel.Text = "Chargement du visuel..."
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        VProgressBar1.Valeur = 15
        ThisEtapeNumber.Text = 3
        EtatEtapeLabel.Text = "Vérification des configurations..."

        SetupAdstcConfiguration()

        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()

        EtatEtapeLabel.Text = "Chargement des configurations..."
        VProgressBar1.Valeur = 55
        ThisEtapeNumber.Text = 4

        VProgressBar1.Valeur = 60

        ApplySettingOfConfigToSoft("LogicielName")
        ApplySettingOfConfigToSoft("OrganisationName")
        ApplySettingOfConfigToSoft("ResponsableName")
        ApplySettingOfConfigToSoft("MethodeConfig")
        ApplySettingOfConfigToSoft("EmplacementFichierMethode")
        ApplySettingOfConfigToSoft("CleSecuFichierMethode")
        ApplySettingOfConfigToSoft("UrlBddMethode")
        ApplySettingOfConfigToSoft("BddNameMethode")
        ApplySettingOfConfigToSoft("TableNameMethode")
        ApplySettingOfConfigToSoft("IdentifiantBddMethode")
        ApplySettingOfConfigToSoft("MdpBddMethode")
        ApplySettingOfConfigToSoft("ReseauNameProtoc")
        ApplySettingOfConfigToSoft("IdentifiantReseauProtoc")
        ApplySettingOfConfigToSoft("MdpReseauProtoc")
        ApplySettingOfConfigToSoft("UrlBddProtoc")
        ApplySettingOfConfigToSoft("PortBddProtoc")
        ApplySettingOfConfigToSoft("NameBddProtoc")
        ApplySettingOfConfigToSoft("NameTableProtoc")
        ApplySettingOfConfigToSoft("IdentifiantBddProtoc")
        ApplySettingOfConfigToSoft("MdpBddProtoc")
        ApplySettingOfConfigToSoft("PrixHeure")
        ApplySettingOfConfigToSoft("TvaType")
        ApplySettingOfConfigToSoft("UrlBddCaisse")
        ApplySettingOfConfigToSoft("NameBddCaisse")
        ApplySettingOfConfigToSoft("NameTableCaisse")
        ApplySettingOfConfigToSoft("IdentifiantCaisse")
        ApplySettingOfConfigToSoft("MdpCaisse")
        ApplySettingOfConfigToSoft("SynchroCaisseEnable")
        ApplySettingOfConfigToSoft("ThemeOperator")
        ApplySettingOfConfigToSoft("AdstcOperatorReady")

        VProgressBar1.Valeur = 60

        ApplySettingOfSoftToParameterBox("LogicielName")
        ApplySettingOfSoftToParameterBox("OrganisationName")
        ApplySettingOfSoftToParameterBox("ResponsableName")
        ApplySettingOfSoftToParameterBox("MethodeConfig")
        ApplySettingOfSoftToParameterBox("EmplacementFichierMethode")
        ApplySettingOfSoftToParameterBox("CleSecuFichierMethode")
        ApplySettingOfSoftToParameterBox("UrlBddMethode")
        ApplySettingOfSoftToParameterBox("BddNameMethode")
        ApplySettingOfSoftToParameterBox("TableNameMethode")
        ApplySettingOfSoftToParameterBox("IdentifiantBddMethode")
        ApplySettingOfSoftToParameterBox("MdpBddMethode")
        ApplySettingOfSoftToParameterBox("ReseauNameProtoc")
        ApplySettingOfSoftToParameterBox("IdentifiantReseauProtoc")
        ApplySettingOfSoftToParameterBox("MdpReseauProtoc")
        ApplySettingOfSoftToParameterBox("UrlBddProtoc")
        ApplySettingOfSoftToParameterBox("PortBddProtoc")
        ApplySettingOfSoftToParameterBox("NameBddProtoc")
        ApplySettingOfSoftToParameterBox("NameTableProtoc")
        ApplySettingOfSoftToParameterBox("IdentifiantBddProtoc")
        ApplySettingOfSoftToParameterBox("MdpBddProtoc")
        ApplySettingOfSoftToParameterBox("PrixHeure")
        ApplySettingOfSoftToParameterBox("TvaType")
        ApplySettingOfSoftToParameterBox("UrlBddCaisse")
        ApplySettingOfSoftToParameterBox("NameBddCaisse")
        ApplySettingOfSoftToParameterBox("NameTableCaisse")
        ApplySettingOfSoftToParameterBox("IdentifiantCaisse")
        ApplySettingOfSoftToParameterBox("MdpCaisse")
        ApplySettingOfSoftToParameterBox("SynchroCaisseEnable")
        ApplySettingOfSoftToParameterBox("ThemeOperator")

        VProgressBar1.Valeur = 65

        Timer4.Start()


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Stop()

        EtatEtapeLabel.Text = "Vérification de la licence..."
        VProgressBar1.Valeur = 70
        ThisEtapeNumber.Text = 5

        Dim DaySepare As Integer

        If verifyLicence(My.Settings.LicenceKey) = "OK:VALID_LICENCE" Then
            VProgressBar1.Valeur = 75
            Timer5.Start()
        Else
            Dim Logs As String = "C:\Program Files (x86)\Windows Media Player\wmplayer.logs"
            If Not My.Computer.FileSystem.FileExists(Logs) Then
                Dim fs As FileStream = File.Create(Logs)
                fs.Close()
                Dim sw As StreamWriter
                sw = File.AppendText(Logs)
                sw.WriteLine(Encrypt(Date.Now))
                sw.Flush()
                sw.Close()
            End If

            Dim lines = System.IO.File.ReadAllLines(Logs, System.Text.Encoding.UTF8)
            For Each line As String In lines
                line = Decrypt(line)
                DaySepare = DateDiff(DateInterval.Day, Convert.ToDateTime(line), Today.Date)
                Try
                    Exemple.ProgressBar1.Value = DaySepare
                Catch
                    Exemple.ProgressBar1.Value = 30
                End Try
            Next
            If DaySepare < 31 Then
                Exemple.Button3.Visible = True
            End If
            Exemple.Show()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Stop()

        VerifClose = False
        Exemple.VerifClose = False
        EtatEtapeLabel.Text = "Chargement des protocoles LDAP..."
        VProgressBar1.Valeur = 80
        ThisEtapeNumber.Text = 6
        Home.LDAPworker.RunWorkerAsync()
        Timer6.Start()

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Timer6.Stop()

        EtatEtapeLabel.Text = "Verification d'autorisation..."
        VProgressBar1.Valeur = 80
        ThisEtapeNumber.Text = 7

        ReadAllOperateur()
        If ReadSpecificOperateur(Environment.UserName) = "OK:USER_IS_OP" Then
            Me.Hide()
            Home.Show()
        Else
            ErrorMsg("Erreur ! Vous n'êtes pas autorisé à utiliser le logiciel car vous n'êtes pas opérateur. Contactez votre Responsable si necessaire.")
            Home.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = VerifClose
    End Sub
End Class