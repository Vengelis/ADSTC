Public Class Exemple

    Public VerifClose As Boolean = True

    Private Sub Remise0Button_Click(sender As Object, e As EventArgs) Handles Remise0Button.Click
        Dim Response As String = GetResponse("http://vlogis-dev.ovh/fonctionnal/adstc.php?action=useLicence&user=" & UserLicenceTextbox.Text & "&key=" & LicenceTextbox.Text)
        Response = Response.Replace("ï»¿", "")
        Response = RC4(Response, "VLogisSecuKey")
        If Response = "OK:LICENCE_USED" Then
            My.Settings.LicenceUser = UserLicenceTextbox.Text
            My.Settings.LicenceKey = LicenceTextbox.Text
            My.Settings.Save()
            UserLicenceTextbox.Enabled = False
            LicenceTextbox.Enabled = False
            Paramètres.ActiveLicenceButton.Enabled = False
            Paramètres.ActiveLicenceButton.Text = "Produit activé"
            Paramètres.ActiveLicenceButton.BackColor = Color.Green
            Home.LabelVisibleEtatLicence.Text = "Produit activé"
            Home.LabelVisibleEtatLicence.ForeColor = Color.Green
            Home.LicenceButton.Visible = False
            WriteLogs("Paramètres", "Activation du produit")
            Loader.VProgressBar1.Valeur = 75
            Loader.Timer5.Start()
            Me.Hide()
        Else
            WriteLogs("Paramètres", "Echec de l'activation du produit")
            ErrorMsg("Cette licence n'est pas disponible")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://vlogis-development.selly.store/category/40ca01ce")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VerifClose = False
        Loader.VerifClose = False
        Loader.Close()
        Home.Close()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Loader.VProgressBar1.Valeur = 75
        Loader.Timer5.Start()
        Me.Hide()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = VerifClose
    End Sub
End Class