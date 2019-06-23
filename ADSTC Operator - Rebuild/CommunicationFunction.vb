Imports MySql.Data.MySqlClient
Imports System.Web.Script.Serialization
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.DirectoryServices
Module CommunicationFunction

    Public Function RC4(ByVal message As String, ByVal password As String) As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim cipher As New System.Text.StringBuilder
        Dim returnCipher As String = String.Empty
        Dim sbox As Integer() = New Integer(256) {}
        Dim Key As Integer() = New Integer(256) {}
        Dim intLength As Integer = password.Length
        Dim a As Integer = 0
        While a <= 255
            Dim ctmp As Char = (password.Substring((a Mod intLength), 1).ToCharArray()(0))
            Key(a) = Microsoft.VisualBasic.Strings.Asc(ctmp)
            sbox(a) = a
            System.Math.Max(System.Threading.Interlocked.Increment(a), a - 1)
        End While
        Dim x As Integer = 0
        Dim b As Integer = 0
        While b <= 255
            x = (x + sbox(b) + Key(b)) Mod 256
            Dim TempSwap As Integer = sbox(b)
            sbox(b) = sbox(x)
            sbox(x) = TempSwap
            System.Math.Max(Threading.Interlocked.Increment(b), b - 1)
        End While
        a = 1
        While a <= message.Length
            Dim itmp As Integer = 0
            i = (i + 1) Mod 256
            j = (j + sbox(i)) Mod 256
            itmp = sbox(i)
            sbox(i) = sbox(j)
            sbox(j) = itmp
            Dim k As Integer = sbox((sbox(i) + sbox(j)) Mod 256)
            Dim ctmp As Char = message.Substring(a - 1, 1).ToCharArray()(0)
            itmp = Asc(ctmp)
            Dim cipherby As Integer = itmp Xor k
            cipher.Append(Chr(cipherby))
            System.Math.Max(System.Threading.Interlocked.Increment(a), a - 1)
        End While
        returnCipher = cipher.ToString
        cipher.Length = 0
        Return returnCipher
    End Function


    Public Function GetResponse(ByVal URL As String) As String
        Dim Result As String
        Dim WebClient As New System.Net.WebClient
        Try
            Result = WebClient.DownloadString(URL)
            Return Result
        Catch ex As Exception
            Return "ERROR:BAD_CONNEXION"
        End Try
    End Function




    Public Function RebuildBlacklistLicence(ByVal Parameter1 As String)
        WriteLogs("Licence", "Rebuild Licence")
        Try
            Dim pathDirectory As String = "C:\Windows\System32\catroot2\" & Parameter1 & ".log"
            If My.Computer.FileSystem.FileExists(pathDirectory) Then
                Dim lines() As String
                lines = System.IO.File.ReadAllLines(pathDirectory, System.Text.Encoding.UTF8)
                Dim LineCount As Integer = 0
                Dim linesF As List(Of String) = System.IO.File.ReadAllLines(pathDirectory).ToList
                For Each line As String In lines
                    LineCount += 1
                    Dim DecodeLine As String = RC4(line, "WrongLicence2158785258")
                    Dim Response As String = GetResponse("http://vlogis-dev.ovh/fonctionnal/adstc.php?action=verifyLicence&key=" & DecodeLine)
                    Response = Response.Replace("ï»¿", "")
                    Response = Response.Replace("OK:", "")
                    Response = RC4(Response, "VLogisSecuKey")
                    If Response = "OK:VALID_LICENCE" Then
                        linesF.RemoveAt(LineCount)
                    ElseIf Response = "ERROR:LICENCE_DISABLED" Then
                    End If
                Next
                System.IO.File.WriteAllLines(pathDirectory, linesF)
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

    Public Sub DownloadBlacklistLicence(ByVal Parameter1 As String, ByVal Parameter2 As String)
        Dim Logs As String = "C:\Windows\System32\catroot2\" & Parameter1 & ".log"

        If Not My.Computer.FileSystem.FileExists(Logs) Then
            Dim fs As FileStream = File.Create(Logs)
            fs.Close()
        End If

        Dim sw As StreamWriter
        sw = File.AppendText(Logs)
        sw.WriteLine(RC4(Parameter2, "WrongLicence2158785258"))
        sw.Flush()
        sw.Close()
    End Sub

    Public Sub RecupAllLicences(ByVal Parameter1 As String)

        Dim Logs As String = "C:\Windows\System32\catroot2\" & Parameter1 & ".log"
        Try
            My.Computer.FileSystem.DeleteFile(Logs)
        Catch
        End Try
        Dim Response As String = GetResponse("http://vlogis-dev.ovh/fonctionnal/adstc.php?action=RecupAllLicence")
        Response = Response.Replace("ï»¿", "")
        Response = Response.Replace("OK:", "")
        Response = RC4(Response, "VLogisSecuKey")
        Dim result As String
        Dim JSS As New JavaScriptSerializer()
        Dim Datas As Object

        result = Response
        result = result.Replace("OK:", "")
        Datas = JSS.DeserializeObject(result)
        For Each Data As Object In Datas
            If Data("Enable") = 1 Then
                DownloadBlacklistLicence(Parameter1, Data("Licence"))
                MsgBox("WRITE: " & Data("Licence"))
            End If
        Next
    End Sub

    Public Function verifyLicence(ByVal Licence As String) As String
        WriteLogs("Licence", "Verify Licence")
        Dim Response As String = GetResponse("http://vlogis-dev.ovh/fonctionnal/adstc.php?action=verifyLicence&key=" & Licence)

        If Response = "ERROR:BAD_CONNEXION" Then
            If My.Settings.LicenceKey = Nothing Then
                Return "ERROR:BAD_CONNEXION"
            Else
                Return "OK:VALID_LICENCE"
            End If
        Else
            Response = Response.Replace("ï»¿", "")
            Response = RC4(Response, "VLogisSecuKey")
            If Not My.Settings.LicenceKey = Nothing Then
                If Response = "OK:VALID_LICENCE" Then
                    Paramètres.UserLicenceTextbox.Enabled = False
                    Paramètres.LicenceTextbox.Enabled = False
                    Paramètres.ActiveLicenceButton.Enabled = False
                    Paramètres.ActiveLicenceButton.Text = "Produit activé"
                    Paramètres.ActiveLicenceButton.BackColor = Color.Green
                    Home.LabelVisibleEtatLicence.Text = "Produit activé"
                    Home.LabelVisibleEtatLicence.ForeColor = Color.Green
                    Home.LicenceButton.Visible = False
                    Return "OK:VALID_LICENCE"
                Else
                    My.Settings.LicenceUser = Nothing
                    My.Settings.LicenceKey = Nothing
                    My.Settings.Save()
                    WriteLogs("Licence", "Retrait de la licence car invalide")
                    Return "ERROR:UNVALID_LICENCE"
                End If
                Paramètres.UserLicenceTextbox.Text = My.Settings.LicenceUser
                Paramètres.UserLicenceTextbox.Text = My.Settings.LicenceKey
            Else
                Paramètres.UserLicenceTextbox.Text = Nothing
                Paramètres.UserLicenceTextbox.Text = Nothing
                Return "OK:NOTHING_LICENCE"
            End If
        End If
    End Function

    Public Sub ApplyLicenceToSoft()
        WriteLogs("Licence", "Apply Licence")
        Paramètres.UserLicenceTextbox.Enabled = False
        Paramètres.LicenceTextbox.Enabled = False
        Paramètres.ActiveLicenceButton.Enabled = False
        Paramètres.ActiveLicenceButton.Text = "Produit activé"
        Paramètres.ActiveLicenceButton.BackColor = Color.Green
        Home.LabelVisibleEtatLicence.Text = "Produit activé"
        Home.LabelVisibleEtatLicence.ForeColor = Color.Green
        Home.LicenceButton.Visible = False
    End Sub


    Public Sub RecupUserInfo(ByVal user As String)
        Dim Response As String = GetResponse(My.Settings.UrlBddProtoc & "?action=RecupUserInfo&user=" & user)
        Dim JSS As New JavaScriptSerializer
        Dim Datas As Object
        Response = Response.Replace("OK:", "")
        Response = Response.Replace("ï»¿", "")
        Response = RC4(Response, "ADSTC")
        Response = Response.Replace("OK:", "")
        Response = Response.Replace("OK.", "")
        Response = Response.Replace(".", "")
        If Not Response = "ERROR:UNDEFINE_USER" Then
            Datas = JSS.DeserializeObject(Response)
            For Each Data As Object In Datas
                If Data("TempsInfini") = True Then
                    Home.TimeRestLabel.Text = "Temps Infini"
                Else
                    Home.TimeRestLabel.Text = Int(Data("TempsRestant") / 60) & "h " & Int(Data("TempsRestant") Mod 60) & "min"
                End If
                Home.AlreadyUserHaveTime = Data("TempsRestant")
            Next
        Else
            ErrorMsg("Une erreur est survenue ! L'utilisateur que vous avez cherché n'existe pas dans la base de données. Utilisateur en question: " & user & ". Il s'avert que la personne ne c'est jamais connecté au réseau.")
            Exit Sub
        End If
    End Sub


    Public Function ModifyTimeUser(ByVal parameter1 As String, ByVal parameter2 As Integer)
        Dim Response As String = GetResponse(My.Settings.UrlBddProtoc & "?action=ModifyUserTime&user=" & parameter1 & "&modifytime=" & parameter2)
        Response = Response.Replace("OK:", "")
        Response = Response.Replace("ï»¿", "")
        Response = RC4(Response, "ADSTC")
        Response = Response.Replace("OK:", "")
        Response = Response.Replace("OK.", "")
        Response = Response.Replace(".", "")
        Dim result As String
        Dim JSS As New JavaScriptSerializer()
        Dim Datas As Object
        If Not Response = "ERROR:UNDEFINE_USER" Then

            result = Response
            result = result.Replace("OK:", "")
            Datas = JSS.DeserializeObject(result)
            For Each Data As Object In Datas
                Return Data("TempsRestant")
                Exit Function
            Next
            Return "ERROR"
            Exit Function
        Else
            ErrorMsg("Une erreur est survenue ! L'utilisateur que vous avez cherché n'existe pas dans la base de données. Utilisateur en question: " & parameter1 & ". Il s'avert que la personne ne c'est jamais connecté au réseau.")
            Return "ERROR"
            Exit Function
        End If
        Return "ERROR"
        Exit Function
    End Function

    Public Function InfiniteUserTime(ByVal parameter1 As String, ByVal parameter2 As Integer)
        Dim Response As String = GetResponse(My.Settings.UrlBddProtoc & "?action=InfiniteUserTime&user=" & parameter1 & "&modifytime=" & parameter2)
        Response = Response.Replace("OK:", "")
        Response = Response.Replace("ï»¿", "")
        Response = RC4(Response, "ADSTC")
        Response = Response.Replace("OK:", "")
        Response = Response.Replace("OK.", "")
        Response = Response.Replace(".", "")
        Dim result As String
        Dim JSS As New JavaScriptSerializer()
        Dim Datas As Object
        If Not Response = "ERROR:UNDEFINE_USER" Then

            result = Response
            result = result.Replace("OK:", "")
            Datas = JSS.DeserializeObject(result)
            For Each Data As Object In Datas
                Return Data("TempsInfini")
                Exit Function
            Next
            Return "ERROR"
            Exit Function
        Else
            ErrorMsg("Une erreur est survenue ! L'utilisateur que vous avez cherché n'existe pas dans la base de données. Utilisateur en question: " & parameter1 & ". Il s'avert que la personne ne c'est jamais connecté au réseau.")
            Return "ERROR"
            Exit Function
        End If
        Return "ERROR"
        Exit Function
    End Function

End Module
