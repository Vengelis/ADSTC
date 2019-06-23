'------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
'
'
'               Descendre pour avoir la zone du thème dédié
'
'
'------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



Module ParamFunctions

    Public Sub ApplyTheme(ByVal Theme As String)

        If Theme = "Light" Then

            Dim BackColor As Color = ColorTranslator.FromHtml("#EDF1FA")
            Dim HeaderColor As Color = ColorTranslator.FromHtml("#192440")
            Dim FooterColor As Color = ColorTranslator.FromHtml("#192440")
            Dim Button1 As Color = ColorTranslator.FromHtml("#CBCED6")
            Dim Button2 As Color = ColorTranslator.FromHtml("#22B6F0")
            Dim Button3 As Color = ColorTranslator.FromHtml("#D94141")
            Dim Label1 As Color = ColorTranslator.FromHtml("#192440")
            Dim Label2 As Color = Button2
            Dim Label3 As Color = Button3
            Dim Separator As Color = ColorTranslator.FromHtml("#0A0E1A")

            'Home------------------------------------------------------------

            '---Background

            Home.BackColor = BackColor
            Home.TitleColorBox.BackColor = HeaderColor
            Home.LicenceColorBox.BackColor = FooterColor

            '---Buttons

            Home.ActualiserButton.BackColor = Button1
            Home.Add15MinutesButton.BackColor = Button1
            Home.Add30MinutesButton.BackColor = Button1
            Home.Add1HeureButton.BackColor = Button1
            Home.Add2HeuresButton.BackColor = Button1
            Home.Add5HeuresButton.BackColor = Button1
            Home.Add10HeuresButton.BackColor = Button1
            Home.ViewLogButton.BackColor = Button1
            Home.ViewCaisseButton.BackColor = Button1

            Home.RemoveUneHeureButton.BackColor = Button2
            Home.Remise0Button.BackColor = Button2
            Home.Remboursement30MinutesButton.BackColor = Button2

            Home.InfiniteHeuresButton.BackColor = Button3
            Home.SetOpButton.BackColor = Button3

            '---Labels

            Home.Separateur3.BackColor = Separator
            Home.Separateur2.BackColor = Separator
            Home.Separateur1.BackColor = Separator
            Home.PictureBox1.BackColor = Separator
            Home.PictureBox2.BackColor = Separator
            Home.PictureBox3.BackColor = Separator
            Home.Séparateur4.BackColor = Separator

            Home.Label17.BackColor = HeaderColor
            Home.Label18.BackColor = HeaderColor
            Home.FlatLabel1.BackColor = FooterColor
            Home.LabelVisibleEtatLicence.BackColor = FooterColor
            Home.Label1.ForeColor = Label1
            Home.Label13.ForeColor = Label1
            Home.Label11.ForeColor = Label1
            Home.Label4.ForeColor = Label1
            Home.Label15.ForeColor = Label1
            Home.Label16.ForeColor = Label1
            Home.Label7.ForeColor = Label1
            Home.Label8.ForeColor = Label1
            Home.Label9.ForeColor = Label1
            Home.NOMPrenomSelect.ForeColor = Label1
            Home.PrenomNOMSelect.ForeColor = Label1

            Home.Label2.ForeColor = Label3
            Home.Label5.ForeColor = Label3
            Home.Label6.ForeColor = Label3
            Home.Label3.ForeColor = Label3
            Home.Label10.ForeColor = Label3

            Home.NomLabel.ForeColor = Label2
            Home.PrenomLabel.ForeColor = Label2
            Home.PseudoLabel.ForeColor = Label2
            Home.TimeRestLabel.ForeColor = Label2
            Home.UserStatut.ForeColor = Label2
            Home.tvaType.ForeColor = Label2


            'Parameters------------------------------------------------------

            '---Background

            Paramètres.BackColor = BackColor
            Paramètres.GeneralParamPage.BackColor = BackColor
            Paramètres.AdminParamPage.BackColor = BackColor
            Paramètres.ProtocParamPage.BackColor = BackColor
            Paramètres.PrixReducParamPage.BackColor = BackColor
            Paramètres.ClientsParamPage.BackColor = BackColor
            Paramètres.MalgachocaisseParamPage.BackColor = BackColor
            Paramètres.ThemeParamPage.BackColor = BackColor
            Paramètres.LicenceParamPage.BackColor = BackColor

            '---Buttons

            Paramètres.ReturnToHome.BackColor = Button3

            Paramètres.ADSTCClientSite.BackColor = Button1
            Paramètres.ADSTCWDSite.BackColor = Button1
            Paramètres.MalgachoCaisseSite.BackColor = Button1
            Paramètres.DownloadADSTCClient.BackColor = Button2
            Paramètres.DownloadADSTCWD.BackColor = Button2
            Paramètres.DownloadMalgachoCaisse.BackColor = Button2
            Paramètres.SaveGeneralParamPageButton.BackColor = Button2

            Paramètres.SelectFileDirectoryButton.BackColor = Button1
            Paramètres.RemoveSelectop.BackColor = Button1
            Paramètres.SaveAdminParamPageButton.BackColor = Button1


            Paramètres.ForceRebootLdapButton.BackColor = Button3
            Paramètres.GenTableButton.BackColor = Button1
            Paramètres.SaveProtocParamPageButton.BackColor = Button1

            Paramètres.AleaGenCoupon.BackColor = Button1
            Paramètres.CreateCouponButton.BackColor = Button1
            Paramètres.ModifCouponButton.BackColor = Button1
            Paramètres.DeleteCouponButton.BackColor = Button1
            Paramètres.SavePriceReducParamPageButton.BackColor = Button1

            Paramètres.SaveSetClientParamPageButton.BackColor = Button1

            Paramètres.HelpCaisseButton.BackColor = Button1
            Paramètres.TestBddCaisseButton.BackColor = Button1
            Paramètres.SaveCaisseParamPageButton.BackColor = Button1

            Paramètres.BuyThemeButton.BackColor = Button1
            Paramètres.SaveThemeParamPageButton.BackColor = Button1

            Paramètres.BuyLicenceButton.BackColor = Button1
            Paramètres.ActiveLicenceButton.BackColor = Button3
            Paramètres.VisitSiteButton.BackColor = Button1

            '---Labels

            Paramètres.Label2.ForeColor = Label3
            Paramètres.Label8.ForeColor = Label3
            Paramètres.Label3.ForeColor = Label3

            Paramètres.Label13.ForeColor = Label1
            Paramètres.Label1.ForeColor = Label1
            Paramètres.Label4.ForeColor = Label1
            Paramètres.Label5.ForeColor = Label1
            Paramètres.Label51.ForeColor = Label1
            Paramètres.Label7.ForeColor = Label1
            Paramètres.Label9.ForeColor = Label1

            Paramètres.Label10.ForeColor = Label2
            Paramètres.Label11.ForeColor = Label2
            Paramètres.Label12.ForeColor = Label2

            Paramètres.FlatLabel1.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.FlatLabel2.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.FlatLabel3.ForeColor = Color.FromArgb(64, 64, 64)



            Paramètres.Label15.ForeColor = Label1
            Paramètres.Label17.ForeColor = Label1
            Paramètres.Label19.ForeColor = Label1
            Paramètres.Label39.ForeColor = Label1
            Paramètres.Label40.ForeColor = Label1
            Paramètres.Label4.ForeColor = Label1
            Paramètres.Label5.ForeColor = Label1
            Paramètres.Label7.ForeColor = Label1
            Paramètres.Label50.ForeColor = Label1
            Paramètres.Label42.ForeColor = Label1
            Paramètres.Label43.ForeColor = Label1
            Paramètres.Label45.ForeColor = Label1
            Paramètres.Label46.ForeColor = Label1
            Paramètres.Label47.ForeColor = Label1
            Paramètres.Label48.ForeColor = Label1
            Paramètres.Label49.ForeColor = Label1
            Paramètres.SelectRegeditMethode.ForeColor = Label1
            Paramètres.SelectFileMethode.ForeColor = Label1
            Paramètres.SelectBddMethode.ForeColor = Label1

            Paramètres.Label14.ForeColor = Label3
            Paramètres.Label16.ForeColor = Label3
            Paramètres.Label38.ForeColor = Label3

            Paramètres.Label41.ForeColor = Label2
            Paramètres.Label43.ForeColor = Label2
            Paramètres.SelectionOpLabel.ForeColor = Label2



            Paramètres.Label18.ForeColor = Label3
            Paramètres.Label24.ForeColor = Label3

            Paramètres.Label20.ForeColor = Label1
            Paramètres.Label22.ForeColor = Label1
            Paramètres.Label23.ForeColor = Label1
            Paramètres.Label21.ForeColor = Label1
            Paramètres.Label25.ForeColor = Label1
            Paramètres.Label27.ForeColor = Label1
            Paramètres.Label36.ForeColor = Label1
            Paramètres.Label37.ForeColor = Label1
            Paramètres.Label26.ForeColor = Label1
            Paramètres.Label6.ForeColor = Label1
            Paramètres.FlatLabel6.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.ApprouveTableCheck.ForeColor = Label1



            Paramètres.Label28.ForeColor = Label3
            Paramètres.Label31.ForeColor = Label3

            Paramètres.Label29.ForeColor = Label1
            Paramètres.Label30.ForeColor = Label1
            Paramètres.Label32.ForeColor = Label1
            Paramètres.Label33.ForeColor = Label1
            Paramètres.Label34.ForeColor = Label1
            Paramètres.Label35.ForeColor = Label1
            Paramètres.CouponDispoCheckButton.ForeColor = Label1
            Paramètres.IndispoCouponCheckButton.ForeColor = Label1
            Paramètres.TenTvaCheckbox.ForeColor = Label1
            Paramètres.TwelveTvaCheckbox.ForeColor = Label1



            Paramètres.Label53.ForeColor = Label3
            Paramètres.Label57.ForeColor = Label3
            Paramètres.Label61.ForeColor = Label3

            Paramètres.Label54.ForeColor = Label1
            Paramètres.Label55.ForeColor = Label1
            Paramètres.Label56.ForeColor = Label1
            Paramètres.Label58.ForeColor = Label1
            Paramètres.Label59.ForeColor = Label1
            Paramètres.Label60.ForeColor = Label1
            Paramètres.Label62.ForeColor = Label1
            Paramètres.PCPop001.ForeColor = Label1
            Paramètres.PCPop002.ForeColor = Label1
            Paramètres.PCPop003.ForeColor = Label1
            Paramètres.PCPop004.ForeColor = Label1
            Paramètres.PCPop005.ForeColor = Label1
            Paramètres.ClientDedieThemeCheckeur.ForeColor = Label1
            Paramètres.ClientLightThemeCheckeur.ForeColor = Label1
            Paramètres.ClientDarkThemeCheckeur.ForeColor = Label1
            Paramètres.PCPop006.ForeColor = Label1



            Paramètres.Label63.ForeColor = Label3
            Paramètres.Label69.ForeColor = Label3
            Paramètres.EnableConnexionBddCaisseCheckeur.ForeColor = Label3

            Paramètres.Label64.ForeColor = Label1
            Paramètres.Label65.ForeColor = Label1
            Paramètres.Label66.ForeColor = Label1
            Paramètres.Label67.ForeColor = Label1
            Paramètres.Label68.ForeColor = Label1
            Paramètres.Label70.ForeColor = Label1



            Paramètres.Label71.ForeColor = Label3
            Paramètres.Label72.ForeColor = Label3

            Paramètres.FlatLabel8.ForeColor = Label1
            Paramètres.LightThemeCheckeur.ForeColor = Label1
            Paramètres.DarkThemeCheckeur.ForeColor = Label1
            Paramètres.DedieThemeCheckeur.ForeColor = Label1



            Paramètres.Label73.ForeColor = Label3
            Paramètres.Label82.ForeColor = Label3
            Paramètres.Label85.ForeColor = Label3
            Paramètres.Label86.ForeColor = Label3

            Paramètres.Label86.ForeColor = Label1
            Paramètres.Label80.ForeColor = Label1
            Paramètres.Label84.ForeColor = Label1
            Paramètres.Label83.ForeColor = Label1
            Paramètres.Label87.ForeColor = Label1
            Paramètres.FlatLabel9.ForeColor = Label1

            'Logs------------------------------------------------------------

        ElseIf Theme = "Dark" Then

            Dim BackColor As Color = ColorTranslator.FromHtml("#0F1626")
            Dim HeaderColor As Color = ColorTranslator.FromHtml("#0A0E1A")
            Dim FooterColor As Color = ColorTranslator.FromHtml("#0A0E1A")
            Dim Button1 As Color = ColorTranslator.FromHtml("#3C4A55")
            Dim Button2 As Color = ColorTranslator.FromHtml("#227EF0")
            Dim Button3 As Color = ColorTranslator.FromHtml("#B33535")
            Dim Label1 As Color = ColorTranslator.FromHtml("#CBCED6")
            Dim Label2 As Color = Button2
            Dim Label3 As Color = Button3
            Dim Separator As Color = ColorTranslator.FromHtml("#EDF1FA")

            'Home------------------------------------------------------------

            '---Background

            Home.BackColor = BackColor
            Home.TitleColorBox.BackColor = HeaderColor
            Home.LicenceColorBox.BackColor = FooterColor

            '---Buttons

            Home.ActualiserButton.BackColor = Button1
            Home.Add15MinutesButton.BackColor = Button1
            Home.Add30MinutesButton.BackColor = Button1
            Home.Add1HeureButton.BackColor = Button1
            Home.Add2HeuresButton.BackColor = Button1
            Home.Add5HeuresButton.BackColor = Button1
            Home.Add10HeuresButton.BackColor = Button1
            Home.ViewLogButton.BackColor = Button1
            Home.ViewCaisseButton.BackColor = Button1

            Home.RemoveUneHeureButton.BackColor = Button2
            Home.Remise0Button.BackColor = Button2
            Home.Remboursement30MinutesButton.BackColor = Button2

            Home.InfiniteHeuresButton.BackColor = Button3
            Home.SetOpButton.BackColor = Button3

            '---Labels

            Home.Separateur3.BackColor = Separator
            Home.Separateur2.BackColor = Separator
            Home.Separateur1.BackColor = Separator
            Home.PictureBox1.BackColor = Separator
            Home.PictureBox2.BackColor = Separator
            Home.PictureBox3.BackColor = Separator
            Home.Séparateur4.BackColor = Separator

            Home.Label17.BackColor = HeaderColor
            Home.Label18.BackColor = HeaderColor
            Home.FlatLabel1.BackColor = FooterColor
            Home.LabelVisibleEtatLicence.BackColor = FooterColor
            Home.Label1.ForeColor = Label1
            Home.Label13.ForeColor = Label1
            Home.Label11.ForeColor = Label1
            Home.Label4.ForeColor = Label1
            Home.Label15.ForeColor = Label1
            Home.Label16.ForeColor = Label1
            Home.Label7.ForeColor = Label1
            Home.Label8.ForeColor = Label1
            Home.Label9.ForeColor = Label1
            Home.NOMPrenomSelect.ForeColor = Label1
            Home.PrenomNOMSelect.ForeColor = Label1

            Home.Label2.ForeColor = Label3
            Home.Label5.ForeColor = Label3
            Home.Label6.ForeColor = Label3
            Home.Label3.ForeColor = Label3
            Home.Label10.ForeColor = Label3

            Home.NomLabel.ForeColor = Label2
            Home.PrenomLabel.ForeColor = Label2
            Home.PseudoLabel.ForeColor = Label2
            Home.TimeRestLabel.ForeColor = Label2
            Home.UserStatut.ForeColor = Label2
            Home.tvaType.ForeColor = Label2


            'Parameters------------------------------------------------------

            '---Background

            Paramètres.BackColor = BackColor
            Paramètres.GeneralParamPage.BackColor = BackColor
            Paramètres.AdminParamPage.BackColor = BackColor
            Paramètres.ProtocParamPage.BackColor = BackColor
            Paramètres.PrixReducParamPage.BackColor = BackColor
            Paramètres.ClientsParamPage.BackColor = BackColor
            Paramètres.MalgachocaisseParamPage.BackColor = BackColor
            Paramètres.ThemeParamPage.BackColor = BackColor
            Paramètres.LicenceParamPage.BackColor = BackColor

            '---Buttons

            Paramètres.ReturnToHome.BackColor = Button3

            Paramètres.ADSTCClientSite.BackColor = Button1
            Paramètres.ADSTCWDSite.BackColor = Button1
            Paramètres.MalgachoCaisseSite.BackColor = Button1
            Paramètres.DownloadADSTCClient.BackColor = Button2
            Paramètres.DownloadADSTCWD.BackColor = Button2
            Paramètres.DownloadMalgachoCaisse.BackColor = Button2
            Paramètres.SaveGeneralParamPageButton.BackColor = Button2

            Paramètres.SelectFileDirectoryButton.BackColor = Button1
            Paramètres.RemoveSelectop.BackColor = Button1
            Paramètres.SaveAdminParamPageButton.BackColor = Button1


            Paramètres.ForceRebootLdapButton.BackColor = Button3
            Paramètres.GenTableButton.BackColor = Button1
            Paramètres.SaveProtocParamPageButton.BackColor = Button1

            Paramètres.AleaGenCoupon.BackColor = Button1
            Paramètres.CreateCouponButton.BackColor = Button1
            Paramètres.ModifCouponButton.BackColor = Button1
            Paramètres.DeleteCouponButton.BackColor = Button1
            Paramètres.SavePriceReducParamPageButton.BackColor = Button1

            Paramètres.SaveSetClientParamPageButton.BackColor = Button1

            Paramètres.HelpCaisseButton.BackColor = Button1
            Paramètres.TestBddCaisseButton.BackColor = Button1
            Paramètres.SaveCaisseParamPageButton.BackColor = Button1

            Paramètres.BuyThemeButton.BackColor = Button1
            Paramètres.SaveThemeParamPageButton.BackColor = Button1

            Paramètres.BuyLicenceButton.BackColor = Button1
            Paramètres.ActiveLicenceButton.BackColor = Button3
            Paramètres.VisitSiteButton.BackColor = Button1

            '---Labels

            Paramètres.Label2.ForeColor = Label3
            Paramètres.Label8.ForeColor = Label3
            Paramètres.Label3.ForeColor = Label3

            Paramètres.Label13.ForeColor = Label1
            Paramètres.Label1.ForeColor = Label1
            Paramètres.Label4.ForeColor = Label1
            Paramètres.Label5.ForeColor = Label1
            Paramètres.Label51.ForeColor = Label1
            Paramètres.Label7.ForeColor = Label1
            Paramètres.Label9.ForeColor = Label1

            Paramètres.Label10.ForeColor = Label2
            Paramètres.Label11.ForeColor = Label2
            Paramètres.Label12.ForeColor = Label2

            Paramètres.FlatLabel1.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.FlatLabel2.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.FlatLabel3.ForeColor = Color.FromArgb(64, 64, 64)



            Paramètres.Label15.ForeColor = Label1
            Paramètres.Label17.ForeColor = Label1
            Paramètres.Label19.ForeColor = Label1
            Paramètres.Label39.ForeColor = Label1
            Paramètres.Label40.ForeColor = Label1
            Paramètres.Label4.ForeColor = Label1
            Paramètres.Label5.ForeColor = Label1
            Paramètres.Label7.ForeColor = Label1
            Paramètres.Label50.ForeColor = Label1
            Paramètres.Label42.ForeColor = Label1
            Paramètres.Label43.ForeColor = Label1
            Paramètres.Label45.ForeColor = Label1
            Paramètres.Label46.ForeColor = Label1
            Paramètres.Label47.ForeColor = Label1
            Paramètres.Label48.ForeColor = Label1
            Paramètres.Label49.ForeColor = Label1
            Paramètres.SelectRegeditMethode.ForeColor = Label1
            Paramètres.SelectFileMethode.ForeColor = Label1
            Paramètres.SelectBddMethode.ForeColor = Label1

            Paramètres.Label14.ForeColor = Label3
            Paramètres.Label16.ForeColor = Label3
            Paramètres.Label38.ForeColor = Label3

            Paramètres.Label41.ForeColor = Label2
            Paramètres.Label43.ForeColor = Label2
            Paramètres.SelectionOpLabel.ForeColor = Label2



            Paramètres.Label18.ForeColor = Label3
            Paramètres.Label24.ForeColor = Label3

            Paramètres.Label20.ForeColor = Label1
            Paramètres.Label22.ForeColor = Label1
            Paramètres.Label23.ForeColor = Label1
            Paramètres.Label21.ForeColor = Label1
            Paramètres.Label25.ForeColor = Label1
            Paramètres.Label27.ForeColor = Label1
            Paramètres.Label36.ForeColor = Label1
            Paramètres.Label37.ForeColor = Label1
            Paramètres.Label26.ForeColor = Label1
            Paramètres.Label6.ForeColor = Label1
            Paramètres.FlatLabel6.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.ApprouveTableCheck.ForeColor = Label1



            Paramètres.Label28.ForeColor = Label3
            Paramètres.Label31.ForeColor = Label3

            Paramètres.Label29.ForeColor = Label1
            Paramètres.Label30.ForeColor = Label1
            Paramètres.Label32.ForeColor = Label1
            Paramètres.Label33.ForeColor = Label1
            Paramètres.Label34.ForeColor = Label1
            Paramètres.Label35.ForeColor = Label1
            Paramètres.CouponDispoCheckButton.ForeColor = Label1
            Paramètres.IndispoCouponCheckButton.ForeColor = Label1
            Paramètres.TenTvaCheckbox.ForeColor = Label1
            Paramètres.TwelveTvaCheckbox.ForeColor = Label1



            Paramètres.Label53.ForeColor = Label3
            Paramètres.Label57.ForeColor = Label3
            Paramètres.Label61.ForeColor = Label3

            Paramètres.Label54.ForeColor = Label1
            Paramètres.Label55.ForeColor = Label1
            Paramètres.Label56.ForeColor = Label1
            Paramètres.Label58.ForeColor = Label1
            Paramètres.Label59.ForeColor = Label1
            Paramètres.Label60.ForeColor = Label1
            Paramètres.Label62.ForeColor = Label1
            Paramètres.PCPop001.ForeColor = Label1
            Paramètres.PCPop002.ForeColor = Label1
            Paramètres.PCPop003.ForeColor = Label1
            Paramètres.PCPop004.ForeColor = Label1
            Paramètres.PCPop005.ForeColor = Label1
            Paramètres.ClientDedieThemeCheckeur.ForeColor = Label1
            Paramètres.ClientLightThemeCheckeur.ForeColor = Label1
            Paramètres.ClientDarkThemeCheckeur.ForeColor = Label1
            Paramètres.PCPop006.ForeColor = Label1



            Paramètres.Label63.ForeColor = Label3
            Paramètres.Label69.ForeColor = Label3
            Paramètres.EnableConnexionBddCaisseCheckeur.ForeColor = Label3

            Paramètres.Label64.ForeColor = Label1
            Paramètres.Label65.ForeColor = Label1
            Paramètres.Label66.ForeColor = Label1
            Paramètres.Label67.ForeColor = Label1
            Paramètres.Label68.ForeColor = Label1
            Paramètres.Label70.ForeColor = Label1



            Paramètres.Label71.ForeColor = Label3
            Paramètres.Label72.ForeColor = Label3

            Paramètres.FlatLabel8.ForeColor = Label1
            Paramètres.LightThemeCheckeur.ForeColor = Label1
            Paramètres.DarkThemeCheckeur.ForeColor = Label1
            Paramètres.DedieThemeCheckeur.ForeColor = Label1



            Paramètres.Label73.ForeColor = Label3
            Paramètres.Label82.ForeColor = Label3
            Paramètres.Label85.ForeColor = Label3
            Paramètres.Label86.ForeColor = Label3

            Paramètres.Label86.ForeColor = Label1
            Paramètres.Label80.ForeColor = Label1
            Paramètres.Label84.ForeColor = Label1
            Paramètres.Label83.ForeColor = Label1
            Paramètres.Label87.ForeColor = Label1
            Paramètres.FlatLabel9.ForeColor = Label1

            'Logs------------------------------------------------------------


            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            '
            '           Zone du thème dédié
            '
            '           A compléter ici
            '
            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        ElseIf Theme = "Dédié" Then

            Dim BackColor As Color = Color.WhiteSmoke
            Dim HeaderColor As Color = Color.FromArgb(64, 64, 64)
            Dim FooterColor As Color = Color.FromArgb(64, 64, 64)
            Dim Button1 As Color = Color.Gainsboro
            Dim Button2 As Color = Color.FromArgb(255, 128, 0)
            Dim Button3 As Color = Color.Red
            Dim Label1 As Color = Color.Black
            Dim Label2 As Color = Color.Teal
            Dim Label3 As Color = Color.DarkRed
            Dim Separator As Color = Color.FromArgb(64, 64, 64)

            'Home------------------------------------------------------------

            '---Background

            Home.BackColor = BackColor
            Home.TitleColorBox.BackColor = HeaderColor
            Home.LicenceColorBox.BackColor = FooterColor

            '---Buttons

            Home.ActualiserButton.BackColor = Button1
            Home.Add15MinutesButton.BackColor = Button1
            Home.Add30MinutesButton.BackColor = Button1
            Home.Add1HeureButton.BackColor = Button1
            Home.Add2HeuresButton.BackColor = Button1
            Home.Add5HeuresButton.BackColor = Button1
            Home.Add10HeuresButton.BackColor = Button1
            Home.ViewLogButton.BackColor = Button1
            Home.ViewCaisseButton.BackColor = Button1

            Home.RemoveUneHeureButton.BackColor = Button2
            Home.Remise0Button.BackColor = Button2
            Home.Remboursement30MinutesButton.BackColor = Button2

            Home.InfiniteHeuresButton.BackColor = Button3
            Home.SetOpButton.BackColor = Button3

            '---Labels

            Home.Separateur3.BackColor = Separator
            Home.Separateur2.BackColor = Separator
            Home.Separateur1.BackColor = Separator
            Home.PictureBox1.BackColor = Separator
            Home.PictureBox2.BackColor = Separator
            Home.PictureBox3.BackColor = Separator
            Home.Séparateur4.BackColor = Separator

            Home.Label17.BackColor = HeaderColor
            Home.Label18.BackColor = HeaderColor
            Home.FlatLabel1.BackColor = FooterColor
            Home.LabelVisibleEtatLicence.BackColor = FooterColor
            Home.Label1.ForeColor = Label1
            Home.Label13.ForeColor = Label1
            Home.Label11.ForeColor = Label1
            Home.Label4.ForeColor = Label1
            Home.Label15.ForeColor = Label1
            Home.Label16.ForeColor = Label1
            Home.Label7.ForeColor = Label1
            Home.Label8.ForeColor = Label1
            Home.Label9.ForeColor = Label1
            Home.NOMPrenomSelect.ForeColor = Label1
            Home.PrenomNOMSelect.ForeColor = Label1

            Home.Label2.ForeColor = Label3
            Home.Label5.ForeColor = Label3
            Home.Label6.ForeColor = Label3
            Home.Label3.ForeColor = Label3
            Home.Label10.ForeColor = Label3

            Home.NomLabel.ForeColor = Label2
            Home.PrenomLabel.ForeColor = Label2
            Home.PseudoLabel.ForeColor = Label2
            Home.TimeRestLabel.ForeColor = Label2
            Home.UserStatut.ForeColor = Label2
            Home.tvaType.ForeColor = Label2


            'Parameters------------------------------------------------------

            '---Background

            Paramètres.BackColor = BackColor
            Paramètres.GeneralParamPage.BackColor = BackColor
            Paramètres.AdminParamPage.BackColor = BackColor
            Paramètres.ProtocParamPage.BackColor = BackColor
            Paramètres.PrixReducParamPage.BackColor = BackColor
            Paramètres.ClientsParamPage.BackColor = BackColor
            Paramètres.MalgachocaisseParamPage.BackColor = BackColor
            Paramètres.ThemeParamPage.BackColor = BackColor
            Paramètres.LicenceParamPage.BackColor = BackColor

            '---Buttons

            Paramètres.ReturnToHome.BackColor = Button3

            Paramètres.ADSTCClientSite.BackColor = Button1
            Paramètres.ADSTCWDSite.BackColor = Button1
            Paramètres.MalgachoCaisseSite.BackColor = Button1
            Paramètres.DownloadADSTCClient.BackColor = Button2
            Paramètres.DownloadADSTCWD.BackColor = Button2
            Paramètres.DownloadMalgachoCaisse.BackColor = Button2
            Paramètres.SaveGeneralParamPageButton.BackColor = Button2

            Paramètres.SelectFileDirectoryButton.BackColor = Button1
            Paramètres.RemoveSelectop.BackColor = Button1
            Paramètres.SaveAdminParamPageButton.BackColor = Button1


            Paramètres.ForceRebootLdapButton.BackColor = Button3
            Paramètres.GenTableButton.BackColor = Button1
            Paramètres.SaveProtocParamPageButton.BackColor = Button1

            Paramètres.AleaGenCoupon.BackColor = Button1
            Paramètres.CreateCouponButton.BackColor = Button1
            Paramètres.ModifCouponButton.BackColor = Button1
            Paramètres.DeleteCouponButton.BackColor = Button1
            Paramètres.SavePriceReducParamPageButton.BackColor = Button1

            Paramètres.SaveSetClientParamPageButton.BackColor = Button1

            Paramètres.HelpCaisseButton.BackColor = Button1
            Paramètres.TestBddCaisseButton.BackColor = Button1
            Paramètres.SaveCaisseParamPageButton.BackColor = Button1

            Paramètres.BuyThemeButton.BackColor = Button1
            Paramètres.SaveThemeParamPageButton.BackColor = Button1

            Paramètres.BuyLicenceButton.BackColor = Button1
            Paramètres.ActiveLicenceButton.BackColor = Button3
            Paramètres.VisitSiteButton.BackColor = Button1

            '---Labels

            Paramètres.Label2.ForeColor = Label3
            Paramètres.Label8.ForeColor = Label3
            Paramètres.Label3.ForeColor = Label3

            Paramètres.Label13.ForeColor = Label1
            Paramètres.Label1.ForeColor = Label1
            Paramètres.Label4.ForeColor = Label1
            Paramètres.Label5.ForeColor = Label1
            Paramètres.Label51.ForeColor = Label1
            Paramètres.Label7.ForeColor = Label1
            Paramètres.Label9.ForeColor = Label1

            Paramètres.Label10.ForeColor = Label2
            Paramètres.Label11.ForeColor = Label2
            Paramètres.Label12.ForeColor = Label2

            Paramètres.FlatLabel1.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.FlatLabel2.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.FlatLabel3.ForeColor = Color.FromArgb(64, 64, 64)



            Paramètres.Label15.ForeColor = Label1
            Paramètres.Label17.ForeColor = Label1
            Paramètres.Label19.ForeColor = Label1
            Paramètres.Label39.ForeColor = Label1
            Paramètres.Label40.ForeColor = Label1
            Paramètres.Label4.ForeColor = Label1
            Paramètres.Label5.ForeColor = Label1
            Paramètres.Label7.ForeColor = Label1
            Paramètres.Label50.ForeColor = Label1
            Paramètres.Label42.ForeColor = Label1
            Paramètres.Label43.ForeColor = Label1
            Paramètres.Label45.ForeColor = Label1
            Paramètres.Label46.ForeColor = Label1
            Paramètres.Label47.ForeColor = Label1
            Paramètres.Label48.ForeColor = Label1
            Paramètres.Label49.ForeColor = Label1
            Paramètres.SelectRegeditMethode.ForeColor = Label1
            Paramètres.SelectFileMethode.ForeColor = Label1
            Paramètres.SelectBddMethode.ForeColor = Label1

            Paramètres.Label14.ForeColor = Label3
            Paramètres.Label16.ForeColor = Label3
            Paramètres.Label38.ForeColor = Label3

            Paramètres.Label41.ForeColor = Label2
            Paramètres.Label43.ForeColor = Label2
            Paramètres.SelectionOpLabel.ForeColor = Label2



            Paramètres.Label18.ForeColor = Label3
            Paramètres.Label24.ForeColor = Label3

            Paramètres.Label20.ForeColor = Label1
            Paramètres.Label22.ForeColor = Label1
            Paramètres.Label23.ForeColor = Label1
            Paramètres.Label21.ForeColor = Label1
            Paramètres.Label25.ForeColor = Label1
            Paramètres.Label27.ForeColor = Label1
            Paramètres.Label36.ForeColor = Label1
            Paramètres.Label37.ForeColor = Label1
            Paramètres.Label26.ForeColor = Label1
            Paramètres.Label6.ForeColor = Label1
            Paramètres.FlatLabel6.ForeColor = Color.FromArgb(64, 64, 64)
            Paramètres.ApprouveTableCheck.ForeColor = Label1



            Paramètres.Label28.ForeColor = Label3
            Paramètres.Label31.ForeColor = Label3

            Paramètres.Label29.ForeColor = Label1
            Paramètres.Label30.ForeColor = Label1
            Paramètres.Label32.ForeColor = Label1
            Paramètres.Label33.ForeColor = Label1
            Paramètres.Label34.ForeColor = Label1
            Paramètres.Label35.ForeColor = Label1
            Paramètres.CouponDispoCheckButton.ForeColor = Label1
            Paramètres.IndispoCouponCheckButton.ForeColor = Label1
            Paramètres.TenTvaCheckbox.ForeColor = Label1
            Paramètres.TwelveTvaCheckbox.ForeColor = Label1



            Paramètres.Label53.ForeColor = Label3
            Paramètres.Label57.ForeColor = Label3
            Paramètres.Label61.ForeColor = Label3

            Paramètres.Label54.ForeColor = Label1
            Paramètres.Label55.ForeColor = Label1
            Paramètres.Label56.ForeColor = Label1
            Paramètres.Label58.ForeColor = Label1
            Paramètres.Label59.ForeColor = Label1
            Paramètres.Label60.ForeColor = Label1
            Paramètres.Label62.ForeColor = Label1
            Paramètres.PCPop001.ForeColor = Label1
            Paramètres.PCPop002.ForeColor = Label1
            Paramètres.PCPop003.ForeColor = Label1
            Paramètres.PCPop004.ForeColor = Label1
            Paramètres.PCPop005.ForeColor = Label1
            Paramètres.ClientDedieThemeCheckeur.ForeColor = Label1
            Paramètres.ClientLightThemeCheckeur.ForeColor = Label1
            Paramètres.ClientDarkThemeCheckeur.ForeColor = Label1
            Paramètres.PCPop006.ForeColor = Label1



            Paramètres.Label63.ForeColor = Label3
            Paramètres.Label69.ForeColor = Label3
            Paramètres.EnableConnexionBddCaisseCheckeur.ForeColor = Label3

            Paramètres.Label64.ForeColor = Label1
            Paramètres.Label65.ForeColor = Label1
            Paramètres.Label66.ForeColor = Label1
            Paramètres.Label67.ForeColor = Label1
            Paramètres.Label68.ForeColor = Label1
            Paramètres.Label70.ForeColor = Label1



            Paramètres.Label71.ForeColor = Label3
            Paramètres.Label72.ForeColor = Label3

            Paramètres.FlatLabel8.ForeColor = Label1
            Paramètres.LightThemeCheckeur.ForeColor = Label1
            Paramètres.DarkThemeCheckeur.ForeColor = Label1
            Paramètres.DedieThemeCheckeur.ForeColor = Label1



            Paramètres.Label73.ForeColor = Label3
            Paramètres.Label82.ForeColor = Label3
            Paramètres.Label85.ForeColor = Label3
            Paramètres.Label86.ForeColor = Label3

            Paramètres.Label86.ForeColor = Label1
            Paramètres.Label80.ForeColor = Label1
            Paramètres.Label84.ForeColor = Label1
            Paramètres.Label83.ForeColor = Label1
            Paramètres.Label87.ForeColor = Label1
            Paramètres.FlatLabel9.ForeColor = Label1

            'Logs------------------------------------------------------------

        End If
    End Sub

End Module
