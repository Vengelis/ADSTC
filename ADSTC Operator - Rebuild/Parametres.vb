Imports System.Net
Imports System.DirectoryServices
Imports System.Web.Script.Serialization
Imports System
Imports System.IO
Imports System.Text

Public Class Paramètres
    Private Sub Parametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Parametres_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If Me.Size.Width < 1005 Then
            Me.Size = New Size(1005, Me.Size.Height)
        End If
        If Me.Size.Height < 662 Then
            Me.Size = New Size(Me.Size.Width, 662)
        End If
    End Sub

    Private Sub Parametres_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.MouseDoubleClick
        If Me.Size.Width < 1005 Then
            Me.Size = New Size(1005, Me.Size.Height)
        End If
        If Me.Size.Height < 662 Then
            Me.Size = New Size(Me.Size.Width, 662)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ReturnToHome.Click
        ApplySettingOfSettingsToConfig("LogicielName")
        ApplySettingOfSettingsToConfig("OrganisationName")
        ApplySettingOfSettingsToConfig("ResponsableName")
        ApplySettingOfSettingsToConfig("MethodeConfig")
        ApplySettingOfSettingsToConfig("EmplacementFichierMethode")
        ApplySettingOfSettingsToConfig("CleSecuFichierMethode")
        ApplySettingOfSettingsToConfig("UrlBddMethode")
        ApplySettingOfSettingsToConfig("BddNameMethode")
        ApplySettingOfSettingsToConfig("TableNameMethode")
        ApplySettingOfSettingsToConfig("IdentifiantBddMethode")
        ApplySettingOfSettingsToConfig("MdpBddMethode")
        ApplySettingOfSettingsToConfig("ReseauNameProtoc")
        ApplySettingOfSettingsToConfig("IdentifiantReseauProtoc")
        ApplySettingOfSettingsToConfig("MdpReseauProtoc")
        ApplySettingOfSettingsToConfig("UrlBddProtoc")
        ApplySettingOfSettingsToConfig("PortBddProtoc")
        ApplySettingOfSettingsToConfig("NameBddProtoc")
        ApplySettingOfSettingsToConfig("NameTableProtoc")
        ApplySettingOfSettingsToConfig("IdentifiantBddProtoc")
        ApplySettingOfSettingsToConfig("MdpBddProtoc")
        ApplySettingOfSettingsToConfig("PrixHeure")
        ApplySettingOfSettingsToConfig("TvaType")
        ApplySettingOfSettingsToConfig("UrlBddCaisse")
        ApplySettingOfSettingsToConfig("NameBddCaisse")
        ApplySettingOfSettingsToConfig("NameTableCaisse")
        ApplySettingOfSettingsToConfig("IdentifiantCaisse")
        ApplySettingOfSettingsToConfig("MdpCaisse")
        ApplySettingOfSettingsToConfig("SynchroCaisseEnable")
        ApplySettingOfSettingsToConfig("ThemeOperator")
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub SaveGeneralParamPageButton_Click(sender As Object, e As EventArgs) Handles SaveGeneralParamPageButton.Click
        ApplySettingOfParameterBoxToSoft("LogicielName")
        ApplySettingOfParameterBoxToSoft("OrganisationName")
        WriteLogs("Paramètres", Environment.UserName & " Sauvegarde des paramètres Général")
    End Sub

    Private Sub SaveAdminParamPageButton_Click(sender As Object, e As EventArgs) Handles SaveAdminParamPageButton.Click
        ApplySettingOfParameterBoxToSoft("ResponsableName")
        ApplySettingOfParameterBoxToSoft("MethodeConfig")
        ApplySettingOfParameterBoxToSoft("EmplacementFichierMethode")
        ApplySettingOfParameterBoxToSoft("CleSecuFichierMethode")
        ApplySettingOfParameterBoxToSoft("UrlBddMethode")
        ApplySettingOfParameterBoxToSoft("BddNameMethode")
        ApplySettingOfParameterBoxToSoft("TableNameMethode")
        ApplySettingOfParameterBoxToSoft("IdentifiantBddMethode")
        ApplySettingOfParameterBoxToSoft("MdpBddMethode")
        WriteLogs("Paramètres", Environment.UserName & " Sauvegarde des paramètres Administration")
    End Sub

    Private Sub SaveProtocParamPageButton_Click(sender As Object, e As EventArgs) Handles SaveProtocParamPageButton.Click
        ApplySettingOfParameterBoxToSoft("ReseauNameProtoc")
        ApplySettingOfParameterBoxToSoft("IdentifiantReseauProtoc")
        ApplySettingOfParameterBoxToSoft("MdpReseauProtoc")
        ApplySettingOfParameterBoxToSoft("UrlBddProtoc")
        ApplySettingOfParameterBoxToSoft("PortBddProtoc")
        ApplySettingOfParameterBoxToSoft("NameBddProtoc")
        ApplySettingOfParameterBoxToSoft("IdentifiantBddProtoc")
        ApplySettingOfParameterBoxToSoft("MdpBddProtoc")
        ApplySettingOfParameterBoxToSoft("NameTableProtoc")
        WriteLogs("Paramètres", Environment.UserName & " Sauvegarde des paramètres Protocoles")
    End Sub

    Private Sub SavePriceReducParamPageButton_Click(sender As Object, e As EventArgs) Handles SavePriceReducParamPageButton.Click
        ApplySettingOfParameterBoxToSoft("PrixHeure")
        ApplySettingOfParameterBoxToSoft("TvaType")

        If My.Settings.TvaType = 20 Then
            Home.TvaApplication = 0.8
            Home.tvaType.Text = "20%"
        ElseIf My.Settings.TvaType = 10 Then
            Home.TvaApplication = 0.9
            Home.tvaType.Text = "10%"
        Else
            Home.TvaApplication = 1
            Home.tvaType.Text = "Non appliquée"
        End If

        WriteLogs("Paramètres", Environment.UserName & " Sauvegarde des paramètres Prix et Réductions")
    End Sub

    Private Sub SaveCaisseParamPageButton_Click(sender As Object, e As EventArgs) Handles SaveCaisseParamPageButton.Click
        ApplySettingOfParameterBoxToSoft("UrlBddCaisse")
        ApplySettingOfParameterBoxToSoft("NameBddCaisse")
        ApplySettingOfParameterBoxToSoft("NameTableCaisse")
        ApplySettingOfParameterBoxToSoft("IdentifiantCaisse")
        ApplySettingOfParameterBoxToSoft("MdpCaisse")
        ApplySettingOfParameterBoxToSoft("SynchroCaisseEnable")
        WriteLogs("Paramètres", Environment.UserName & " Sauvegarde des paramètres MalgachoCaisse")
    End Sub

    Private Sub SaveThemeParamPageButton_Click(sender As Object, e As EventArgs) Handles SaveThemeParamPageButton.Click

        If LightThemeCheckeur.Checked = True Then
            ApplyTheme("Light")
        ElseIf DarkThemeCheckeur.Checked = True Then
            ApplyTheme("Dark")
        ElseIf DedieThemeCheckeur.Checked = True Then
            ApplyTheme("Dédié")
        End If

        ApplySettingOfParameterBoxToSoft("ThemeOperator")
        WriteLogs("Paramètres", Environment.UserName & " Sauvegarde des paramètres Thèmes")
    End Sub

    Private Sub ActiveLicenceButton_Click(sender As Object, e As EventArgs) Handles ActiveLicenceButton.Click
        Dim Response As String = GetResponse("http://vlogis-dev.ovh/fonctionnal/adstc.php?action=useLicence&user=" & UserLicenceTextbox.Text & "&key=" & LicenceTextbox.Text)
        Response = Response.Replace("ï»¿", "")
        Response = RC4(Response, "VLogisSecuKey")
        If Response = "OK:LICENCE_USED" Then
            My.Settings.LicenceUser = UserLicenceTextbox.Text
            My.Settings.LicenceKey = LicenceTextbox.Text
            My.Settings.Save()
            UserLicenceTextbox.Enabled = False
            LicenceTextbox.Enabled = False
            ActiveLicenceButton.Enabled = False
            ActiveLicenceButton.Text = "Produit activé"
            ActiveLicenceButton.BackColor = Color.Green
            Home.LabelVisibleEtatLicence.Text = "Produit activé"
            Home.LabelVisibleEtatLicence.ForeColor = Color.Green
            Home.LicenceButton.Visible = False
            WriteLogs("Paramètres", "Activation du produit")
        Else
            WriteLogs("Paramètres", "Echec de l'activation du produit")
            ErrorMsg("Cette licence n'est pas disponible")
        End If
    End Sub

    Private Sub BuyLicenceButton_Click(sender As Object, e As EventArgs) Handles BuyLicenceButton.Click
        Process.Start("https://vlogis-development.selly.store/category/40ca01ce")
    End Sub

    Private Sub VisitSiteButton_Click(sender As Object, e As EventArgs) Handles VisitSiteButton.Click
        Process.Start("http://vlogis-dev.ovh/ADSTC.html")
    End Sub

    Private Sub SaveSetClientParamPageButton_Click(sender As Object, e As EventArgs) Handles SaveSetClientParamPageButton.Click
        WriteLogs("Paramètres", Environment.UserName & " Sauvegarde des paramètres Clients")
    End Sub

    Private Sub GenTableButton_Click(sender As Object, e As EventArgs) Handles GenTableButton.Click
        WriteLogs("Paramètres", Environment.UserName & " Reconstruction des tables")
    End Sub

    Private Sub LightThemeCheckeur_CheckedChanged(sender As Object, e As EventArgs) Handles LightThemeCheckeur.MouseClick
        DarkThemeCheckeur.Checked = False
        DedieThemeCheckeur.Checked = False
        LightThemeCheckeur.Checked = True
        LightThemeCheckeur.Checked = True
        LightThemeCheckeur.Checked = True
    End Sub

    Private Sub DarkThemeCheckeur_CheckedChanged(sender As Object, e As EventArgs) Handles DarkThemeCheckeur.MouseClick
        LightThemeCheckeur.Checked = False
        DedieThemeCheckeur.Checked = False
        DarkThemeCheckeur.Checked = True
        DarkThemeCheckeur.Checked = True
        DarkThemeCheckeur.Checked = True
    End Sub

    Private Sub DedieThemeCheckeur_CheckedChanged(sender As Object, e As EventArgs) Handles DedieThemeCheckeur.MouseClick
        LightThemeCheckeur.Checked = False
        DarkThemeCheckeur.Checked = False
        DedieThemeCheckeur.Checked = True
        DedieThemeCheckeur.Checked = True
        DedieThemeCheckeur.Checked = True
    End Sub

    Private Sub ForceRebootLdapButton_Click(sender As Object, e As EventArgs) Handles ForceRebootLdapButton.Click
        Try
            If My.Settings.ReseauNameProtoc = Nothing Then
                Home.GroupBoxSR.Visible = True
            Else
                Home.GroupBoxSR.Visible = False
            End If
            Home.LDAPworker.RunWorkerAsync()
            WarningIconProvider.Clear()
        Catch ex As Exception
            WarningIconProvider.SetError(ForceRebootLdapButton, "Le protocole est déjà en train d'être forcé. Merci de patienter.")
        End Try
    End Sub

    Public Sub AddOpInList(ByVal Icon As Integer, ByVal Rank As String, ByVal User As String)
        OpViewList.Items.Add(New ListViewItem({User, Rank}, Icon))
    End Sub

    Private Sub RemoveSelectop_Click(sender As Object, e As EventArgs) Handles RemoveSelectop.Click
        WriteLogs("Home", Environment.UserName & " a retiré des opérateurs '" & OpSelect & "'.")
        Try
            Dim pathDirectory As String = Application.StartupPath & "\ADSTC\Operateurs.adstc"
            Dim pathDirectoryTemp As String = Application.StartupPath & "\ADSTC\OperateursTemp.adstc"

            Dim fs As FileStream = File.Create(pathDirectoryTemp)
            fs.Close()
            Dim lines2() As String

            Dim sw As StreamWriter

            lines2 = System.IO.File.ReadAllLines(pathDirectory, System.Text.Encoding.UTF8)
            For Each line As String In lines2
                MsgBox(line)
                line = Decrypt(line)
                MsgBox(line)
                If Not line.Contains(OpSelect) Then
                    MsgBox(OpSelect)
                    sw = File.AppendText(pathDirectoryTemp)
                    sw.WriteLine(Encrypt(line))
                    sw.Flush()
                    sw.Close()
                End If
            Next

            My.Computer.FileSystem.DeleteFile(pathDirectory)
            My.Computer.FileSystem.RenameFile(pathDirectoryTemp, "Operateurs.adstc")

            ReadAllOperateur()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpViewList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OpViewList.SelectedIndexChanged
        Dim element As ListViewItem = OpViewList.SelectedItems(0)
        OpSelect = element.Text
    End Sub

    Public OpSelect As String

End Class
