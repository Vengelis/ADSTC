Imports Microsoft.Win32
Imports System.IO
Imports System.Text
Module LoadeurFunctions

    Public Function SetupAdstcConfiguration()
        Loader.VProgressBar1.Valeur = 16
        If My.Settings.MethodeConfig = 0 Then
            Paramètres.SelectRegeditMethode.Checked = True
            WriteLogs("Loader", Environment.UserName & " Setup des configurations Regedit")
            Loader.VProgressBar1.Valeur = 17
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "AdstcOperatorReady", Nothing) = Nothing Then
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("LogicielName", "ADSTC Opérateur")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("OrganisationName", "A définir")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("ResponsableName", Environment.UserName)
                WriteOperateur(Environment.UserName)
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("MethodeConfig", "0")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("EmplacementFichierMethode", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("CleSecuFichierMethode", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("UrlBddMethode", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("BddNameMethode", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("TableNameMethode", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("IdentifiantBddMethode", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("MdpBddMethode", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("ReseauNameProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("IdentifiantReseauProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("MdpReseauProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("UrlBddProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("PortBddProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("NameBddProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("NameTableProtoc", "AdstcTb")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("IdentifiantBddProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("MdpBddProtoc", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("PrixHeure", "0,5")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("TvaType", "20")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("UrlBddCaisse", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("NameBddCaisse", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("NameTableCaisse", "McInfoProds")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("IdentifiantCaisse", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("MdpCaisse", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("SynchroCaisseEnable", "False")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("ThemeOperator", "1")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("LicenceUser", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("LicenceKey", "")
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("AdstcOperatorReady", "False")
                'My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("", "")

                Loader.VProgressBar1.Valeur = 30

                My.Settings.LogicielName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "LogicielName", Nothing)
                My.Settings.OrganisationName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "OrganisationName", Nothing)
                My.Settings.ResponsableName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "ResponsableName", Nothing)
                My.Settings.MethodeConfig = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MethodeConfig", Nothing)
                My.Settings.EmplacementFichierMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "EmplacementFichierMethode", Nothing)
                My.Settings.CleSecuFichierMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "CleSecuFichierMethode", Nothing)
                My.Settings.UrlBddMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "UrlBddMethode", Nothing)
                My.Settings.BddNameMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "BddNameMethode", Nothing)
                My.Settings.TableNameMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "TableNameMethode", Nothing)
                My.Settings.IdentifiantBddMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantBddMethode", Nothing)
                My.Settings.MdpBddMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpBddMethode", Nothing)
                My.Settings.ReseauNameProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "ReseauNameProtoc", Nothing)
                My.Settings.IdentifiantReseauProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantReseauProtoc", Nothing)
                My.Settings.MdpReseauProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpReseauProtoc", Nothing)
                My.Settings.UrlBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "UrlBddProtoc", Nothing)
                My.Settings.PortBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "PortBddProtoc", Nothing)
                My.Settings.NameBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameBddProtoc", Nothing)
                My.Settings.NameTableProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameTableProtoc", Nothing)
                My.Settings.IdentifiantBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantBddProtoc", Nothing)
                My.Settings.MdpBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpBddProtoc", Nothing)
                My.Settings.PrixHeure = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "PrixHeure", Nothing)
                My.Settings.TvaType = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "TvaType", Nothing)
                My.Settings.UrlBddCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "UrlBddCaisse", Nothing)
                My.Settings.NameBddCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameBddCaisse", Nothing)
                My.Settings.NameTableCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameTableCaisse", Nothing)
                My.Settings.IdentifiantCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantCaisse", Nothing)
                My.Settings.MdpCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpCaisse", Nothing)
                My.Settings.SynchroCaisseEnable = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "SynchroCaisseEnable", Nothing)
                My.Settings.ThemeOperator = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "ThemeOperator", Nothing)
                My.Settings.AdstcOperatorReady = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "AdstcOperatorReady", Nothing)

                My.Settings.MethodeConfig = 0
                My.Settings.Save()

                Loader.VProgressBar1.Valeur = 50
                Return "OK:CONFIG_GENERATED"
            Else
                Loader.VProgressBar1.Valeur = 30

                My.Settings.LogicielName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "LogicielName", Nothing)
                My.Settings.OrganisationName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "OrganisationName", Nothing)
                My.Settings.ResponsableName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "ResponsableName", Nothing)
                My.Settings.MethodeConfig = Convert.ToInt64(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MethodeConfig", Nothing))
                My.Settings.EmplacementFichierMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "EmplacementFichierMethode", Nothing)
                My.Settings.CleSecuFichierMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "CleSecuFichierMethode", Nothing)
                My.Settings.UrlBddMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "UrlBddMethode", Nothing)
                My.Settings.BddNameMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "BddNameMethode", Nothing)
                My.Settings.TableNameMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "TableNameMethode", Nothing)
                My.Settings.IdentifiantBddMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantBddMethode", Nothing)
                My.Settings.MdpBddMethode = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpBddMethode", Nothing)
                My.Settings.ReseauNameProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "ReseauNameProtoc", Nothing)
                My.Settings.IdentifiantReseauProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantReseauProtoc", Nothing)
                My.Settings.MdpReseauProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpReseauProtoc", Nothing)
                My.Settings.UrlBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "UrlBddProtoc", Nothing)
                My.Settings.PortBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "PortBddProtoc", Nothing)
                My.Settings.NameBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameBddProtoc", Nothing)
                My.Settings.NameTableProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameTableProtoc", Nothing)
                My.Settings.IdentifiantBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantBddProtoc", Nothing)
                My.Settings.MdpBddProtoc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpBddProtoc", Nothing)
                My.Settings.PrixHeure = Convert.ToDecimal(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "PrixHeure", Nothing))
                My.Settings.TvaType = Convert.ToInt64(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "TvaType", Nothing))
                My.Settings.UrlBddCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "UrlBddCaisse", Nothing)
                My.Settings.NameBddCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameBddCaisse", Nothing)
                My.Settings.NameTableCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "NameTableCaisse", Nothing)
                My.Settings.IdentifiantCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "IdentifiantCaisse", Nothing)
                My.Settings.MdpCaisse = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "MdpCaisse", Nothing)
                My.Settings.SynchroCaisseEnable = Convert.ToBoolean(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "SynchroCaisseEnable", Nothing))
                My.Settings.ThemeOperator = Convert.ToInt64(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "ThemeOperator", Nothing))
                My.Settings.AdstcOperatorReady = Convert.ToBoolean(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", "AdstcOperatorReady", Nothing))

                My.Settings.MethodeConfig = 0
                My.Settings.Save()



                Loader.VProgressBar1.Valeur = 50
                Return "OK:CONFIG_ALREADY_GENERATED"
            End If
        ElseIf My.Settings.MethodeConfig = 1 Then
            Paramètres.SelectFileMethode.Checked = True
            WriteLogs("Loader", Environment.UserName & " Setup des configurations Files")
            Dim pathDirectory As String = Application.StartupPath & "\ADSTC"
            Paramètres.LocatedFileTextbox.Text = pathDirectory

            Loader.VProgressBar1.Valeur = 16
            If Not Directory.Exists(pathDirectory) Then
                Loader.VProgressBar1.Valeur = 20

                My.Computer.FileSystem.CreateDirectory(pathDirectory)
                Loader.VProgressBar1.Valeur = 21

                pathDirectory = pathDirectory & "\"
                'MsgBox(pathDirectory)

                WriteOperateur(Environment.UserName)

                Dim path As String = pathDirectory & "LogicielName.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("ADSTC Opérateur"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 22
                path = pathDirectory & "OrganisationName.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("A définir"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 23
                path = pathDirectory & "ResponsableName.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(Environment.UserName))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 24
                path = pathDirectory & "MethodeConfig.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("1"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 25
                path = pathDirectory & "EmplacementFichierMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(pathDirectory))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 26
                path = pathDirectory & "CleSecuFichierMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("adstc297"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 27
                path = pathDirectory & "UrlBddMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 28
                path = pathDirectory & "BddNameMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 29
                path = pathDirectory & "TableNameMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 30
                path = pathDirectory & "IdentifiantBddMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 31
                path = pathDirectory & "MdpBddMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 32
                path = pathDirectory & "ReseauNameProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 33
                path = pathDirectory & "IdentifiantReseauProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 34
                path = pathDirectory & "MdpReseauProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 35
                path = pathDirectory & "UrlBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 36
                path = pathDirectory & "PortBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 37
                path = pathDirectory & "NameBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 38
                path = pathDirectory & "NameTableProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 39
                path = pathDirectory & "IdentifiantBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 40
                path = pathDirectory & "MdpBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 41
                path = pathDirectory & "PrixHeure.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("0,5"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 42
                path = pathDirectory & "TvaType.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("20"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 43
                path = pathDirectory & "UrlBddCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 44
                path = pathDirectory & "NameBddCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 45
                path = pathDirectory & "NameTableCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 46
                path = pathDirectory & "IdentifiantCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 47
                path = pathDirectory & "MdpCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 48
                path = pathDirectory & "SynchroCaisseEnable.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("False"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 49
                path = pathDirectory & "ThemeOperator.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("1"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 50
                Return "OK:CONFIG_GENERATED"
            ElseIf Not My.Computer.FileSystem.FileExists(pathDirectory & "\LogicielName.adstc") Then
                Loader.VProgressBar1.Valeur = 20
                pathDirectory = pathDirectory & "\"
                'MsgBox(pathDirectory)
                Loader.VProgressBar1.Valeur = 21

                Dim path As String = pathDirectory & "LogicielName.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("ADSTC Opérateur"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 22
                path = pathDirectory & "OrganisationName.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("A définir"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 23
                path = pathDirectory & "ResponsableName.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(Environment.UserName))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                    WriteOperateur(Environment.UserName)
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 24
                path = pathDirectory & "MethodeConfig.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("1"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 25
                path = pathDirectory & "EmplacementFichierMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(pathDirectory))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 26
                path = pathDirectory & "CleSecuFichierMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("adstc297"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 27
                path = pathDirectory & "UrlBddMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 28
                path = pathDirectory & "BddNameMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 29
                path = pathDirectory & "TableNameMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 30
                path = pathDirectory & "IdentifiantBddMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 31
                path = pathDirectory & "MdpBddMethode.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 32
                path = pathDirectory & "ReseauNameProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 33
                path = pathDirectory & "IdentifiantReseauProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 34
                path = pathDirectory & "MdpReseauProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 35
                path = pathDirectory & "UrlBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 36
                path = pathDirectory & "PortBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 37
                path = pathDirectory & "NameBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 38
                path = pathDirectory & "NameTableProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 39
                path = pathDirectory & "IdentifiantBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 40
                path = pathDirectory & "MdpBddProtoc.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 41
                path = pathDirectory & "PrixHeure.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("0,5"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 42
                path = pathDirectory & "TvaType.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("20"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 43
                path = pathDirectory & "UrlBddCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 44
                path = pathDirectory & "NameBddCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 45
                path = pathDirectory & "NameTableCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 46
                path = pathDirectory & "IdentifiantCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 47
                path = pathDirectory & "MdpCaisse.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(""))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 48
                path = pathDirectory & "SynchroCaisseEnable.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("False"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 49
                path = pathDirectory & "ThemeOperator.adstc"
                Try
                    Dim fs As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(Encrypt("1"))
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                Catch ex As Exception
                    ErrorMsg("Une erreur c'est produite lors de la création des configurations ! Code erreur:" & path)
                End Try
                Loader.VProgressBar1.Valeur = 50
                Return "OK:CONFIG_GENERATED"
            End If
        ElseIf My.Settings.MethodeConfig = 2 Then
            My.Settings.MethodeConfig = 0
            My.Settings.Save()
            Return "ERROR:DENY_METHODE_SELECTED"
        End If
        Return "ERROR:NOTHING_METHODE_SELECTED"
    End Function

    Public Function DeleteAdstcConfiguration()
        WriteLogs("Loader", Environment.UserName & " Suppression des configurations")
        Return "ERROR:DISABLED"
    End Function

    '-----------------------------------------------------------------------------------------------------------------------------------
    ' Arg1: parameter1 - Nom du paramètre à modifier
    ' Arg2: parameter2 - Valeur du paramètre à modifier
    '-----------------------------------------------------------------------------------------------------------------------------------

    Public Function WriteSetting(ByVal parameter1 As String, ByVal parameter2 As String)
        WriteLogs("Paramètres", Environment.UserName & " Ecriture du paramètre suivant: " & parameter2 & " dans: " & parameter1)
        If Paramètres.SelectRegeditMethode.Checked = True Then
            Dim OpenKey As String = "Software\ADSTC\" & parameter1
            Try
                My.Computer.Registry.CurrentUser.OpenSubKey("Software\ADSTC", True).DeleteValue(parameter1)
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue(parameter1, parameter2)
                Return "OK:SETTING_MODIFY"
                Exit Function
            Catch Ex As Exception
                Return "ERROR:BAD_PARAMETER_" & parameter1 & "_" & parameter2
                Exit Function
            End Try
            Return "ERROR:BAD_PARAMETER_" & parameter1 & "_" & parameter2
        ElseIf Paramètres.SelectFileMethode.Checked = True Then
            Dim pathDirectory As String = Application.StartupPath & "\ADSTC\"
            pathDirectory = pathDirectory & parameter1 & ".adstc"
            If My.Computer.FileSystem.FileExists(pathDirectory) Then
                My.Computer.FileSystem.DeleteFile(pathDirectory)
                Dim fs As FileStream = File.Create(pathDirectory)
                Dim GPop001p As Byte() = New UTF8Encoding(True).GetBytes(Encrypt(parameter2))
                fs.Write(GPop001p, 0, GPop001p.Length)
                fs.Close()
                Return "OK:SETTING_MODIFY"
                Exit Function
            Else
                Return "OK:NOTHING_SETTING_MODIFY"
                Exit Function
            End If
            Return "ERROR:BAD_PARAMETER_" & parameter1 & "_" & parameter2
        ElseIf Paramètres.SelectBddMethode.Checked = True Then
            Return "ERROR:DENY_METHODE_SELECTED"
            Exit Function
        End If
        Return "ERROR:NOTHING_METHODE_SELECTED"
    End Function

    Public Function ReadSetting(ByVal parameter1 As String)
        WriteLogs("Paramètres", Environment.UserName & " Lecture du paramètre suivant: " & parameter1)
        If Paramètres.SelectRegeditMethode.Checked = True Then
            My.Computer.Registry.CurrentUser.CreateSubKey("Software\ADSTC").SetValue("AdstcOperatorReady", "False")
            Try
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", parameter1, Nothing) = Nothing Then
                    Return ""
                Else
                    Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\ADSTC", parameter1, Nothing)
                End If
            Catch Ex As Exception
                Return "ERROR:BAD_PARAMETER_" & parameter1
                Exit Function
            End Try
            Return "ERROR:BAD_PARAMETER_" & parameter1
        ElseIf Paramètres.SelectFileMethode.Checked = True Then
            Dim pathDirectory As String = Application.StartupPath & "\ADSTC\"
            pathDirectory = pathDirectory & parameter1 & ".adstc"
            If My.Computer.FileSystem.FileExists(pathDirectory) Then
                Dim lines() As String
                lines = System.IO.File.ReadAllLines(pathDirectory, System.Text.Encoding.UTF8)
                For Each line As String In lines
                    Return Decrypt(My.Computer.FileSystem.ReadAllText(pathDirectory, System.Text.Encoding.UTF8))
                Next
            Else
                Return "OK:NOTHING_SETTING_MODIFY"
                Exit Function
            End If
            Return "ERROR:BAD_PARAMETER_" & parameter1
        ElseIf Paramètres.SelectBddMethode.Checked = True Then
            Return "ERROR:DENY_METHODE_SELECTED"
            Exit Function
        End If
        Return "ERROR:NOTHING_METHODE_SELECTED"
    End Function

    Public Function ApplySettingOfSettingsToConfig(ByVal parameter1 As String)
        If parameter1 = "LogicielName" Then
            WriteSetting("LogicielName", My.Settings.LogicielName)
        End If
        If parameter1 = "OrganisationName" Then
            WriteSetting("OrganisationName", My.Settings.OrganisationName)
        End If
        If parameter1 = "ResponsableName" Then
            WriteSetting("ResponsableName", My.Settings.ResponsableName)
        End If
        If parameter1 = "MethodeConfig" Then
            WriteSetting("MethodeConfig", Convert.ToString(My.Settings.MethodeConfig))
        End If
        If parameter1 = "EmplacementFichierMethode" Then
            WriteSetting("EmplacementFichierMethode", My.Settings.EmplacementFichierMethode)
        End If
        If parameter1 = "CleSecuFichierMethode" Then
            WriteSetting("CleSecuFichierMethode", My.Settings.CleSecuFichierMethode)
        End If
        If parameter1 = "UrlBddMethode" Then
            WriteSetting("UrlBddMethode", My.Settings.UrlBddMethode)
        End If
        If parameter1 = "BddNameMethode" Then
            WriteSetting("BddNameMethode", My.Settings.BddNameMethode)
        End If
        If parameter1 = "TableNameMethode" Then
            WriteSetting("TableNameMethode", My.Settings.TableNameMethode)
        End If
        If parameter1 = "IdentifiantBddMethode" Then
            WriteSetting("IdentifiantBddMethode", My.Settings.IdentifiantBddMethode)
        End If
        If parameter1 = "MdpBddMethode" Then
            WriteSetting("MdpBddMethode", My.Settings.MdpBddMethode)
        End If
        If parameter1 = "ReseauNameProtoc" Then
            WriteSetting("ReseauNameProtoc", My.Settings.ReseauNameProtoc)
        End If
        If parameter1 = "IdentifiantReseauProtoc" Then
            WriteSetting("IdentifiantReseauProtoc", My.Settings.IdentifiantReseauProtoc)
        End If
        If parameter1 = "MdpReseauProtoc" Then
            WriteSetting("MdpReseauProtoc", My.Settings.MdpReseauProtoc)
        End If
        If parameter1 = "UrlBddProtoc" Then
            WriteSetting("UrlBddProtoc", My.Settings.UrlBddProtoc)
        End If
        If parameter1 = "PortBddProtoc" Then
            WriteSetting("PortBddProtoc", My.Settings.PortBddProtoc)
        End If
        If parameter1 = "NameBddProtoc" Then
            WriteSetting("NameBddProtoc", My.Settings.NameBddProtoc)
        End If
        If parameter1 = "IdentifiantBddProtoc" Then
            WriteSetting("IdentifiantBddProtoc", My.Settings.IdentifiantBddProtoc)
        End If
        If parameter1 = "MdpBddProtoc" Then
            WriteSetting("MdpBddProtoc", My.Settings.MdpBddProtoc)
        End If
        If parameter1 = "NameTableProtoc" Then
            WriteSetting("NameTableProtoc", My.Settings.NameTableProtoc)
        End If
        If parameter1 = "PrixHeure" Then
            WriteSetting("PrixHeure", Convert.ToString(My.Settings.PrixHeure))
        End If
        If parameter1 = "TvaType" Then
            WriteSetting("TvaType", Convert.ToString(My.Settings.TvaType))
        End If
        If parameter1 = "UrlBddCaisse" Then
            WriteSetting("UrlBddCaisse", My.Settings.UrlBddCaisse)
        End If
        If parameter1 = "NameBddCaisse" Then
            WriteSetting("NameBddCaisse", My.Settings.NameBddCaisse)
        End If
        If parameter1 = "NameTableCaisse" Then
            WriteSetting("NameTableCaisse", My.Settings.NameTableCaisse)
        End If
        If parameter1 = "IdentifiantCaisse" Then
            WriteSetting("IdentifiantCaisse", My.Settings.IdentifiantCaisse)
        End If
        If parameter1 = "MdpCaisse" Then
            WriteSetting("MdpCaisse", My.Settings.MdpCaisse)
        End If
        If parameter1 = "SynchroCaisseEnable" Then
            WriteSetting("SynchroCaisseEnable", Convert.ToString(My.Settings.SynchroCaisseEnable))
        End If
        If parameter1 = "ThemeOperator" Then
            WriteSetting("ThemeOperator", Convert.ToString(My.Settings.ThemeOperator))
        End If
        If parameter1 = "AdstcOperatorReady" Then
            WriteSetting("ThemeOperator", Convert.ToString(My.Settings.AdstcOperatorReady))
        End If
        Return "OK:SOFT_TO_CONFIG_FINISHED"
    End Function

    Public Function ApplySettingOfConfigToSoft(ByVal parameter1 As String)
        If parameter1 = "LogicielName" Then
            My.Settings.LogicielName = ReadSetting(parameter1)
        End If
        If parameter1 = "OrganisationName" Then
            My.Settings.OrganisationName = ReadSetting(parameter1)
        End If
        If parameter1 = "ResponsableName" Then
            My.Settings.ResponsableName = ReadSetting(parameter1)
        End If
        If parameter1 = "MethodeConfig" Then
            My.Settings.MethodeConfig = Convert.ToInt64(ReadSetting(parameter1))
        End If
        If parameter1 = "EmplacementFichierMethode" Then
            My.Settings.EmplacementFichierMethode = ReadSetting(parameter1)
        End If
        If parameter1 = "CleSecuFichierMethode" Then
            My.Settings.CleSecuFichierMethode = ReadSetting(parameter1)
        End If
        If parameter1 = "UrlBddMethode" Then
            My.Settings.UrlBddMethode = ReadSetting(parameter1)
        End If
        If parameter1 = "BddNameMethode" Then
            My.Settings.BddNameMethode = ReadSetting(parameter1)
        End If
        If parameter1 = "TableNameMethode" Then
            My.Settings.TableNameMethode = ReadSetting(parameter1)
        End If
        If parameter1 = "IdentifiantBddMethode" Then
            My.Settings.IdentifiantBddMethode = ReadSetting(parameter1)
        End If
        If parameter1 = "MdpBddMethode" Then
            My.Settings.MdpBddMethode = ReadSetting(parameter1)
        End If
        If parameter1 = "ReseauNameProtoc" Then
            My.Settings.ReseauNameProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "IdentifiantReseauProtoc" Then
            My.Settings.IdentifiantReseauProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "MdpReseauProtoc" Then
            My.Settings.MdpReseauProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "UrlBddProtoc" Then
            My.Settings.UrlBddProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "PortBddProtoc" Then
            My.Settings.PortBddProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "NameBddProtoc" Then
            My.Settings.NameBddProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "IdentifiantBddProtoc" Then
            My.Settings.IdentifiantBddProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "MdpBddProtoc" Then
            My.Settings.MdpBddProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "NameTableProtoc" Then
            My.Settings.NameTableProtoc = ReadSetting(parameter1)
        End If
        If parameter1 = "PrixHeure" Then
            My.Settings.PrixHeure = Convert.ToDecimal(ReadSetting(parameter1))
        End If
        If parameter1 = "TvaType" Then
            My.Settings.TvaType = Convert.ToInt64(ReadSetting(parameter1))
        End If
        If parameter1 = "UrlBddCaisse" Then
            My.Settings.UrlBddCaisse = ReadSetting(parameter1)
        End If
        If parameter1 = "NameBddCaisse" Then
            My.Settings.NameBddCaisse = ReadSetting(parameter1)
        End If
        If parameter1 = "NameTableCaisse" Then
            My.Settings.NameTableCaisse = ReadSetting(parameter1)
        End If
        If parameter1 = "IdentifiantCaisse" Then
            My.Settings.IdentifiantCaisse = ReadSetting(parameter1)
        End If
        If parameter1 = "MdpCaisse" Then
            My.Settings.MdpCaisse = ReadSetting(parameter1)
        End If
        If parameter1 = "SynchroCaisseEnable" Then
            My.Settings.SynchroCaisseEnable = Convert.ToBoolean(ReadSetting(parameter1))
        End If
        If parameter1 = "ThemeOperator" Then
            My.Settings.ThemeOperator = Convert.ToInt64(ReadSetting(parameter1))
        End If
        Return "OK:CONFIG_TO_SOFT_FINISHED"
    End Function

    Public Function ApplySettingOfSoftToParameterBox(ByVal parameter1 As String)
        If parameter1 = "LogicielName" Then
            Paramètres.textboxLogicielName.Text = My.Settings.LogicielName
            Home.Name = My.Settings.LogicielName
        End If
        If parameter1 = "OrganisationName" Then
            Paramètres.textboxOrganisationName.Text = My.Settings.OrganisationName
            Home.Label18.Text = My.Settings.OrganisationName
        End If
        If parameter1 = "ResponsableName" Then
            Paramètres.ResponsableTextbox.Text = My.Settings.ResponsableName
        End If
        If parameter1 = "MethodeConfig" Then
            If My.Settings.MethodeConfig = 0 Then
                Paramètres.SelectRegeditMethode.Checked = True
                Paramètres.SelectFileMethode.Checked = False
                Paramètres.SelectBddMethode.Checked = False
            ElseIf My.Settings.MethodeConfig = 1 Then
                Paramètres.SelectRegeditMethode.Checked = False
                Paramètres.SelectFileMethode.Checked = True
                Paramètres.SelectBddMethode.Checked = False
            ElseIf My.Settings.MethodeConfig = 2 Then
                Paramètres.SelectRegeditMethode.Checked = False
                Paramètres.SelectFileMethode.Checked = False
                Paramètres.SelectBddMethode.Checked = True
            End If
        End If
        If parameter1 = "EmplacementFichierMethode" Then
            Paramètres.LocatedFileTextbox.Text = My.Settings.EmplacementFichierMethode
        End If
        If parameter1 = "CleSecuFichierMethode" Then
            Paramètres.EncodeKeySecuFileTextbox.Text = My.Settings.CleSecuFichierMethode
        End If
        If parameter1 = "UrlBddMethode" Then
            Paramètres.UrlServerBddTextbox.Text = My.Settings.UrlBddMethode
        End If
        If parameter1 = "BddNameMethode" Then
            Paramètres.NameBddTextbox.Text = My.Settings.BddNameMethode
        End If
        If parameter1 = "TableNameMethode" Then
            Paramètres.NameTableBddTextbox.Text = My.Settings.TableNameMethode
        End If
        If parameter1 = "IdentifiantBddMethode" Then
            Paramètres.LoginBddTextbox.Text = My.Settings.IdentifiantBddMethode
        End If
        If parameter1 = "MdpBddMethode" Then
            Paramètres.MdpBddTextbox.Text = My.Settings.MdpBddMethode
        End If
        If parameter1 = "ReseauNameProtoc" Then
            Paramètres.ReseauNameTextbox.Text = My.Settings.ReseauNameProtoc
        End If
        If parameter1 = "IdentifiantReseauProtoc" Then
            Paramètres.LoginReseauTextbox.Text = My.Settings.IdentifiantReseauProtoc
        End If
        If parameter1 = "MdpReseauProtoc" Then
            Paramètres.MdpReaseauTextbox.Text = My.Settings.MdpReseauProtoc
        End If
        If parameter1 = "UrlBddProtoc" Then
            Paramètres.UrlBddTextbox.Text = My.Settings.UrlBddProtoc
        End If
        If parameter1 = "PortBddProtoc" Then
            Paramètres.PortBddTextbox.Text = My.Settings.PortBddProtoc
        End If
        If parameter1 = "NameBddProtoc" Then
            Paramètres.NamBddTextbox.Text = My.Settings.NameBddProtoc
        End If
        If parameter1 = "IdentifiantBddProtoc" Then
            Paramètres.LoginDbbTextbox.Text = My.Settings.IdentifiantBddProtoc
        End If
        If parameter1 = "MdpBddProtoc" Then
            Paramètres.PassBddTextbox.Text = My.Settings.MdpBddProtoc
        End If
        If parameter1 = "NameTableProtoc" Then
            Paramètres.NameTableTextbox.Text = My.Settings.NameTableProtoc
        End If
        If parameter1 = "PrixHeure" Then
            Paramètres.PriceHourTextbox.Text = My.Settings.PrixHeure
        End If
        If parameter1 = "TvaType" Then
            If My.Settings.TvaType = 20 Then
                Paramètres.TenTvaCheckbox.Checked = False
                Paramètres.TwelveTvaCheckbox.Checked = True
            ElseIf My.Settings.TvaType = 10 Then
                Paramètres.TenTvaCheckbox.Checked = True
                Paramètres.TwelveTvaCheckbox.Checked = False
            Else
                Paramètres.TenTvaCheckbox.Checked = False
                Paramètres.TwelveTvaCheckbox.Checked = False
            End If
        End If
        If parameter1 = "UrlBddCaisse" Then
            Paramètres.UrlBddCaisse.Text = My.Settings.UrlBddCaisse
        End If
        If parameter1 = "NameBddCaisse" Then
            Paramètres.NamBddCaisse.Text = My.Settings.NameBddCaisse
        End If
        If parameter1 = "NameTableCaisse" Then
            Paramètres.NameTableBddCaisse.Text = My.Settings.NameTableCaisse
        End If
        If parameter1 = "IdentifiantCaisse" Then
            Paramètres.LoginBddCaisse.Text = My.Settings.IdentifiantCaisse
        End If
        If parameter1 = "MdpCaisse" Then
            Paramètres.PassBddCaisse.Text = My.Settings.MdpCaisse
        End If
        If parameter1 = "SynchroCaisseEnable" Then
            If My.Settings.SynchroCaisseEnable = True Then
                Paramètres.EnableConnexionBddCaisseCheckeur.Checked = True
            Else
                Paramètres.EnableConnexionBddCaisseCheckeur.Checked = False
            End If
        End If
        If parameter1 = "ThemeOperator" Then
            If My.Settings.ThemeOperator = 0 Then
                Paramètres.LightThemeCheckeur.Checked = True
                Paramètres.DarkThemeCheckeur.Checked = False
                Paramètres.DedieThemeCheckeur.Checked = False
                ApplyTheme("Light")
            ElseIf My.Settings.ThemeOperator = 1 Then
                Paramètres.LightThemeCheckeur.Checked = False
                Paramètres.DarkThemeCheckeur.Checked = True
                Paramètres.DedieThemeCheckeur.Checked = False
                ApplyTheme("Dark")
            ElseIf My.Settings.ThemeOperator = 2 Then
                Paramètres.LightThemeCheckeur.Checked = False
                Paramètres.DarkThemeCheckeur.Checked = False
                Paramètres.DedieThemeCheckeur.Checked = True
                ApplyTheme("Dédié")
            End If
        End If
        Return "OK:SOFT_TO_TEXTBOX_FINISHED"
    End Function
    Public Function ApplySettingOfParameterBoxToSoft(ByVal parameter1 As String)
        If parameter1 = "LogicielName" Then
            My.Settings.LogicielName = Paramètres.textboxLogicielName.Text
        End If
        If parameter1 = "OrganisationName" Then
            My.Settings.OrganisationName = Paramètres.textboxOrganisationName.Text
        End If
        If parameter1 = "ResponsableName" Then
            My.Settings.ResponsableName = Paramètres.ResponsableTextbox.Text
        End If
        If parameter1 = "MethodeConfig" Then
            If Paramètres.SelectRegeditMethode.Checked = True Then
                My.Settings.MethodeConfig = 0
            ElseIf Paramètres.SelectFileMethode.Checked = True Then
                My.Settings.MethodeConfig = 1
            ElseIf Paramètres.SelectBddMethode.Checked = True Then
                My.Settings.MethodeConfig = 2
            End If
        End If
        If parameter1 = "EmplacementFichierMethode" Then
            My.Settings.EmplacementFichierMethode = Paramètres.LocatedFileTextbox.Text
        End If
        If parameter1 = "CleSecuFichierMethode" Then
            My.Settings.CleSecuFichierMethode = Paramètres.EncodeKeySecuFileTextbox.Text
        End If
        If parameter1 = "UrlBddMethode" Then
            My.Settings.UrlBddMethode = Paramètres.UrlServerBddTextbox.Text
        End If
        If parameter1 = "BddNameMethode" Then
            My.Settings.BddNameMethode = Paramètres.NameBddTextbox.Text
        End If
        If parameter1 = "TableNameMethode" Then
            My.Settings.TableNameMethode = Paramètres.NameTableBddTextbox.Text
        End If
        If parameter1 = "IdentifiantBddMethode" Then
            My.Settings.IdentifiantBddMethode = Paramètres.LoginBddTextbox.Text
        End If
        If parameter1 = "MdpBddMethode" Then
            My.Settings.MdpBddMethode = Paramètres.MdpBddTextbox.Text
        End If
        If parameter1 = "ReseauNameProtoc" Then
            My.Settings.ReseauNameProtoc = Paramètres.ReseauNameTextbox.Text
        End If
        If parameter1 = "IdentifiantReseauProtoc" Then
            My.Settings.IdentifiantReseauProtoc = Paramètres.LoginReseauTextbox.Text
        End If
        If parameter1 = "MdpReseauProtoc" Then
            My.Settings.MdpReseauProtoc = Paramètres.MdpReaseauTextbox.Text
        End If
        If parameter1 = "UrlBddProtoc" Then
            My.Settings.UrlBddProtoc = Paramètres.UrlBddTextbox.Text
        End If
        If parameter1 = "PortBddProtoc" Then
            My.Settings.PortBddProtoc = Paramètres.PortBddTextbox.Text
        End If
        If parameter1 = "NameBddProtoc" Then
            My.Settings.NameBddProtoc = Paramètres.NamBddTextbox.Text
        End If
        If parameter1 = "IdentifiantBddProtoc" Then
            My.Settings.IdentifiantBddProtoc = Paramètres.LoginDbbTextbox.Text
        End If
        If parameter1 = "MdpBddProtoc" Then
            My.Settings.MdpBddProtoc = Paramètres.PassBddTextbox.Text
        End If
        If parameter1 = "NameTableProtoc" Then
            My.Settings.NameTableProtoc = Paramètres.NameTableTextbox.Text
        End If
        If parameter1 = "PrixHeure" Then
            My.Settings.PrixHeure = Paramètres.PriceHourTextbox.Text
        End If
        If parameter1 = "TvaType" Then
            If Paramètres.TwelveTvaCheckbox.Checked = True Then

                My.Settings.TvaType = 20
            ElseIf Paramètres.TenTvaCheckbox.Checked = True Then
                My.Settings.TvaType = 10
            Else
                My.Settings.TvaType = 1
            End If
        End If
        If parameter1 = "UrlBddCaisse" Then
            My.Settings.UrlBddCaisse = Paramètres.UrlBddCaisse.Text
        End If
        If parameter1 = "NameBddCaisse" Then
            My.Settings.NameBddCaisse = Paramètres.NamBddCaisse.Text
        End If
        If parameter1 = "NameTableCaisse" Then
            My.Settings.NameTableCaisse = Paramètres.NameTableBddCaisse.Text
        End If
        If parameter1 = "IdentifiantCaisse" Then
            My.Settings.IdentifiantCaisse = Paramètres.LoginBddCaisse.Text
        End If
        If parameter1 = "MdpCaisse" Then
            My.Settings.MdpCaisse = Paramètres.PassBddCaisse.Text
        End If
        If parameter1 = "SynchroCaisseEnable" Then
            If Paramètres.EnableConnexionBddCaisseCheckeur.Checked = True Then
                My.Settings.MdpCaisse = True
            Else
                My.Settings.MdpCaisse = False
            End If
        End If
        If parameter1 = "ThemeOperator" Then
            If Paramètres.LightThemeCheckeur.Checked = True Then
                My.Settings.ThemeOperator = 0
            ElseIf Paramètres.DarkThemeCheckeur.Checked = True Then
                My.Settings.ThemeOperator = 1
            ElseIf Paramètres.DedieThemeCheckeur.Checked = True Then
                My.Settings.ThemeOperator = 2
            End If
        End If
        'If parameter1 = "AdstcOperatorReady" Then
        'Paramètres.textboxLogicielName.Text = My.Settings.AdstcOperatorReady
        'End If
        Return "OK:TEXTBOX_TO_SOFT_FINISHED"
    End Function

    Public Function ReadLogs(ByVal Parameter1 As String)
        WriteLogs("Paramètres", Environment.UserName & " Lecture des logs :" & Parameter1)
        Try
            Dim pathDirectory As String = Application.StartupPath & "\ADSTC\" & Parameter1 & ".adstc"
            If My.Computer.FileSystem.FileExists(pathDirectory) Then
                LogsPage.LogsListBox.Items.Clear()
                Dim lines() As String
                lines = System.IO.File.ReadAllLines(pathDirectory, System.Text.Encoding.UTF8)
                For Each line As String In lines
                    LogsPage.LogsListBox.Items.Add(line)
                    'Return My.Computer.FileSystem.ReadAllText(pathDirectory, System.Text.Encoding.UTF8)
                Next
                Return "OK:LOGS_READED"
                Exit Function
            Else
                Return "OK:NOTHING_LOGS_READED"
                Exit Function
            End If
            Return "ERROR:BAD_PARAMETER_" & Parameter1
        Catch ex As Exception
            Return "ERROR:BAD_PARAMETER_" & Parameter1 & " - " & ex.Message
        End Try
    End Function

    Public Function WriteLogs(ByVal Parameter1 As String, ByVal Parameter2 As String)

        Dim Logs As String = Application.StartupPath & "\ADSTC\" & Parameter1 & ".adstc"

        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\ADSTC") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\ADSTC")
        End If

        If Not My.Computer.FileSystem.FileExists(Logs) Then
            Dim fs As FileStream = File.Create(Logs)
            fs.Close()

            Dim sw2 As StreamWriter
            sw2 = File.AppendText(Logs)
            sw2.WriteLine("[Logiciel " & Date.Now & " - Loadeur] Création du fichier logs")
            sw2.Flush()
            sw2.Close()

        End If

        Dim sw As StreamWriter
        sw = File.AppendText(Logs)
        sw.WriteLine("[Date:" & Date.Now & "][Logs:" & Parameter2 & "]")
        sw.Flush()
        sw.Close()
    End Function

    Public Sub ErrorMsg(ByVal Text As String)
        MessageBox.Show(Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub WarningMsg(ByVal Text As String)
        MessageBox.Show(Text, "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

End Module
