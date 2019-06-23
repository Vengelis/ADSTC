Imports System.Net
Imports System.DirectoryServices
Imports System.Web.Script.Serialization
Imports System
Imports System.IO
Imports System.Text
Public Class Home

    Public Ldap As DirectoryEntry
    Public timeToAdd As Integer = 0
    Public AlreadyUserHaveTime As Integer = 0
    Public TvaApplication As Decimal

    Private Sub Home_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        DebugX.Text = Me.Size.Width
        DebugY.Text = Me.Size.Height
        If Me.Size.Width < 1005 Then
            Me.Size = New Size(1005, Me.Size.Height)
        End If
        If Me.Size.Height < 662 Then
            Me.Size = New Size(Me.Size.Width, 662)
        End If
    End Sub

    Private Sub ParametresButton_Click(sender As Object, e As EventArgs) Handles ParametresButton.Click

        If My.Settings.ResponsableName = Environment.UserName Then
            WriteLogs("Home", Environment.UserName & " Ouverture des paramètres (Responsable)")
            Me.Hide()
            Paramètres.TabControl1.SelectTab(0)
            Paramètres.Show()
        Else
            WarningMsg("Vous n'êtes pas autorisé à accéder aux paramètres du logiciel. Contactez votre responsable.")
            WriteLogs("Home", Environment.UserName & " Ouverture des paramètres (Responsable)")
            WriteLogs("Paramètres", Environment.UserName & " Ouverture des paramètres (Responsable)")
        End If
        ReadAllOperateur()

    End Sub

    Private Sub LDAPworker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LDAPworker.DoWork
        Try
            Ldap = New DirectoryEntry("LDAP://" & My.Settings.ReseauNameProtoc)
        Catch Ex As Exception
            ErrorMsg(Ex.Message & "Les protocles LDAP ne sont pas bien initialisés dans les paramètres")
        End Try
        UpdateList()
    End Sub

    Public Sub UpdateList()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim DirEntry As DirectoryEntry
        'searcher.Filter = "(&(memberOf=cn=Administrateurs MDL,ou=Administrateurs Pole Info,dc=mdl,dc=local)(objectClass=user))"
        Dim searcher As DirectorySearcher = New DirectorySearcher(Ldap) With {.Filter = "(&(objectCategory=person)(objectClass=user))"}
        Try
            For Each result As SearchResult In searcher.FindAll
                DirEntry = result.GetDirectoryEntry

                If NOMPrenomSelect.Checked = True Then
                    ListBox1.Items.Add(DirEntry.Properties("sn").Value + " " + DirEntry.Properties("givenName").Value)
                ElseIf PrenomNOMSelect.Checked = True Then
                    ListBox1.Items.Add(DirEntry.Properties("givenName").Value + " " + DirEntry.Properties("sn").Value)
                End If

                ListBox2.Items.Add(DirEntry.Properties("SAMAccountName").Value)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RefreshData()
        Try
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            Dim _pseudo = ListBox2.GetItemText(ListBox2.SelectedItem)
            Dim DirEntry As DirectoryEntry
            Dim searcher As DirectorySearcher = New DirectorySearcher(Ldap) With {
                .Filter = "SAMAccountName=" & _pseudo
            }

            If ReadSpecificOperateur(_pseudo) = "OK:USER_IS_OP" Then
                UserStatut.Text = "Opérateur ADSTC"
                SetOpButton.Enabled = False
                UserStatut.Text = "Opérateur ADSTC"
                If My.Settings.ResponsableName = Environment.UserName Then
                    SetOpButton.Enabled = True
                End If
            End If

            For Each result As SearchResult In searcher.FindAll
                DirEntry = result.GetDirectoryEntry
                NomLabel.Text = DirEntry.Properties("sn").Value
                PrenomLabel.Text = DirEntry.Properties("givenName").Value
                PseudoLabel.Text = _pseudo
                RecupUserInfo(_pseudo)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Test_Click(sender As Object, e As EventArgs) Handles Test.Click

        ApplyTheme("Light")

        'RecupAllLicences("edb000001")
        'RebuildBlacklistLicence("edb000001")
    End Sub

    Private Sub ViewLogButton_Click(sender As Object, e As EventArgs) Handles ViewLogButton.Click
        ReadLogs("Loader")
        LogsPage.Show()
    End Sub

    Private Sub LicenceButton_Click(sender As Object, e As EventArgs) Handles LicenceButton.Click

        If My.Settings.ResponsableName = Environment.UserName Then
            WriteLogs("Home", Environment.UserName & " Ouverture des paramètres (Responsable)")
            Me.Hide()
            Paramètres.TabControl1.SelectTab(7)
            Paramètres.Show()
        Else
            WarningMsg("Vous n'êtes pas autorisé à accéder aux paramètres du logiciel. Contactez votre responsable.")
            WriteLogs("Home", Environment.UserName & " Ouverture des paramètres (Responsable)")
            WriteLogs("Paramètres", Environment.UserName & " Ouverture des paramètres (Responsable)")
        End If
        ReadAllOperateur()
    End Sub
    Public Sub AfficheTimeToAdd(ByVal free As Boolean)
        If free = False Then
            Label9.Text = Int(timeToAdd / 60) & "h " & Int(timeToAdd Mod 60) & "min seront ajoutées"
            Label8.Text = "A Encaisser : " & (timeToAdd / (60 / My.Settings.PrixHeure)) / TvaApplication & " €"
        Else
            Label9.Text = Int(timeToAdd / 60) & "h " & Int(timeToAdd Mod 60) & "min seront ajoutées"
        End If
    End Sub

    Private Sub Add15MinutesButton_Click(sender As Object, e As EventArgs) Handles Add15MinutesButton.Click
        If My.Settings.LicenceKey = Nothing Then
            AlertEncaissementBox.ForeColor = Color.Red
            AlertEncaissementLabel.Text = "Licence invalide !"
            AlertEncaissementLabel.ForeColor = Color.Red
            AlertEncaissementBox.Visible = True
            HideMessageBox.Start()

        Else
            timeToAdd = timeToAdd + 15
            AfficheTimeToAdd(False)
        End If
    End Sub

    Private Sub Add30MinutesButton_Click(sender As Object, e As EventArgs) Handles Add30MinutesButton.Click
        If My.Settings.LicenceKey = Nothing Then
            AlertEncaissementBox.ForeColor = Color.Red
            AlertEncaissementLabel.Text = "Licence invalide !"
            AlertEncaissementLabel.ForeColor = Color.Red
            AlertEncaissementBox.Visible = True
            HideMessageBox.Start()

        Else
            timeToAdd = timeToAdd + 30
            AfficheTimeToAdd(False)
        End If
    End Sub

    Private Sub HideMessageBox_Tick(sender As Object, e As EventArgs) Handles HideMessageBox.Tick
        HideMessageBox.Stop()
        AlertEncaissementBox.Visible = False
    End Sub

    Private Sub EncaisserButton_Click(sender As Object, e As EventArgs) Handles EncaisserButton.Click
        Dim _pseudo = ListBox2.GetItemText(ListBox2.SelectedItem)
        ModifyTimeUser(_pseudo, AlreadyUserHaveTime + timeToAdd)
        RefreshData()
        RecupUserInfo(_pseudo)
        WriteLogs("Home", Environment.UserName & " - Encaissement de " & timeToAdd & " minutes à " & _pseudo)
        timeToAdd = 0
        Label9.Text = "En attente..."
        Label8.Text = "A Encaisser : 0 €"
    End Sub

    Private Sub CancelEncaisseButton_Click(sender As Object, e As EventArgs) Handles CancelEncaisseButton.Click
        Dim _pseudo = ListBox2.GetItemText(ListBox2.SelectedItem)
        WriteLogs("Home", Environment.UserName & " Annulation d'encaissement pour: " & _pseudo)
        timeToAdd = 0
        Label9.Text = "En attente..."
        Label8.Text = "A Encaisser : 0 €"
    End Sub

    Private Sub SetOpButton_Click(sender As Object, e As EventArgs) Handles SetOpButton.Click
        Dim _pseudo = ListBox2.GetItemText(ListBox2.SelectedItem)
        WriteOperateur(_pseudo)
        WriteLogs("Home", Environment.UserName & " a ajouté en opérateur '" & _pseudo & "'.")
    End Sub

    Private Sub Home_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Paramètres.Close()
        Loader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ApplyTheme("Dark")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ApplyTheme("Dédié")
    End Sub

    Private Sub Add1HeureButton_Click(sender As Object, e As EventArgs) Handles Add1HeureButton.Click
        timeToAdd = timeToAdd + 60
        AfficheTimeToAdd(False)
    End Sub

    Private Sub Add2HeuresButton_Click(sender As Object, e As EventArgs) Handles Add2HeuresButton.Click
        timeToAdd = timeToAdd + 120
        AfficheTimeToAdd(False)
    End Sub

    Private Sub Add5HeuresButton_Click(sender As Object, e As EventArgs) Handles Add5HeuresButton.Click
        timeToAdd = timeToAdd + 300
        AfficheTimeToAdd(False)
    End Sub

    Private Sub Add10HeuresButton_Click(sender As Object, e As EventArgs) Handles Add10HeuresButton.Click
        timeToAdd = timeToAdd + 600
        AfficheTimeToAdd(False)
    End Sub

    Private Sub RemoveUneHeureButton_Click(sender As Object, e As EventArgs) Handles RemoveUneHeureButton.Click
        timeToAdd = timeToAdd - 60
        AfficheTimeToAdd(False)
    End Sub

    Private Sub Remise0Button_Click(sender As Object, e As EventArgs) Handles Remise0Button.Click
        timeToAdd = 0
        AfficheTimeToAdd(False)
    End Sub

    Private Sub Remboursement30MinutesButton_Click(sender As Object, e As EventArgs) Handles Remboursement30MinutesButton.Click
        timeToAdd = timeToAdd + 30
        AfficheTimeToAdd(True)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        RefreshData()
    End Sub

    Private Sub ActualiserButton_Click(sender As Object, e As EventArgs) Handles ActualiserButton.Click
        UpdateList()
    End Sub

    Private Sub PrenomNOMSelect_CheckedChanged(sender As Object, e As EventArgs) Handles PrenomNOMSelect.CheckedChanged
        UpdateList()
    End Sub

    Private Sub NOMPrenomSelect_CheckedChanged(sender As Object, e As EventArgs) Handles NOMPrenomSelect.CheckedChanged
        UpdateList()
    End Sub

    Private Sub InfiniteHeuresButton_Click(sender As Object, e As EventArgs) Handles InfiniteHeuresButton.Click
        If My.Settings.LicenceKey = Nothing Then
            AlertEncaissementBox.ForeColor = Color.Red
            AlertEncaissementLabel.Text = "Licence invalide !"
            AlertEncaissementLabel.ForeColor = Color.Red
            AlertEncaissementBox.Visible = True
            HideMessageBox.Start()
        Else
            If My.Settings.ResponsableName = Environment.UserName Then
                Dim _pseudo = ListBox2.GetItemText(ListBox2.SelectedItem)
                If TimeRestLabel.Text = "Temps Infini" Then
                    InfiniteUserTime(_pseudo, False)
                    WriteLogs("Home", Environment.UserName & " Retrait du temps infini pour: " & _pseudo)
                    AlertEncaissementBox.ForeColor = Color.MediumSeaGreen
                    AlertEncaissementLabel.Text = "Retrait du temps infini"
                    AlertEncaissementLabel.ForeColor = Color.MediumSeaGreen
                    AlertEncaissementBox.Visible = True
                    HideMessageBox.Start()
                Else
                    InfiniteUserTime(_pseudo, True)
                    WriteLogs("Home", Environment.UserName & " Ajout du temps infini pour: " & _pseudo)
                    AlertEncaissementBox.ForeColor = Color.MediumSeaGreen
                    AlertEncaissementLabel.Text = "Ajout du temps infini"
                    AlertEncaissementLabel.ForeColor = Color.MediumSeaGreen
                    AlertEncaissementBox.Visible = True
                    HideMessageBox.Start()
                End If
            End If
        End If
    End Sub
End Class