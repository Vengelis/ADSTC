Imports System.Net
Imports System.DirectoryServices
Imports System.Web.Script.Serialization
Imports System
Imports System.IO
Imports System.Text

Module HomeFunctions
    Public Function ReadSpecificOperateur(ByVal user As String)
        Paramètres.OpViewList.Items.Clear()
        If user = My.Settings.ResponsableName Then
            Return "OK:USER_IS_OP"
            Exit Function
        End If
        Try
            Dim pathDirectory As String = Application.StartupPath & "\ADSTC\Operateurs.adstc"
            If My.Computer.FileSystem.FileExists(pathDirectory) Then
                LogsPage.LogsListBox.Items.Clear()
                Dim lines() As String
                lines = System.IO.File.ReadAllLines(pathDirectory, System.Text.Encoding.UTF8)
                For Each line As String In lines
                    line = Decrypt(line)
                    If line = user Then
                        Return "OK:USER_IS_OP"
                        Exit Function
                    End If
                Next
                Return "ERROR:USER_IS_NOT_OP"
                Exit Function
            Else
                Return "OK:NOTHING_OPERATOR_READED"
                Exit Function
            End If
            Return "ERROR:BAD_PARAMETER"
        Catch ex As Exception
            Return "ERROR:BAD_PARAMETER_" & ex.Message
        End Try
    End Function

    Public Function ReadAllOperateur()
        Paramètres.OpViewList.Items.Clear()

        Try
            Dim pathDirectory As String = Application.StartupPath & "\ADSTC\Operateurs.adstc"
            If My.Computer.FileSystem.FileExists(pathDirectory) Then
                LogsPage.LogsListBox.Items.Clear()
                Dim lines() As String
                lines = System.IO.File.ReadAllLines(pathDirectory, System.Text.Encoding.UTF8)
                For Each line As String In lines
                    line = Decrypt(line)
                    If line = "Vengelis" Then
                        Paramètres.AddOpInList(58, "Développeur", line)
                    ElseIf line = "gaby1" Then
                        Paramètres.AddOpInList(58, "Développeur", line)
                    ElseIf line = My.Settings.ResponsableName Then
                        Paramètres.AddOpInList(3, "Responsable", line)
                    Else
                        Paramètres.AddOpInList(30, "Opérateur", line)
                    End If

                Next
                Return "OK:LOGS_READED"
                Exit Function
            Else
                Return "OK:NOTHING_OPERATOR_READED"
                Exit Function
            End If
            Return "ERROR:BAD_PARAMETER"
        Catch ex As Exception
            Return "ERROR:BAD_PARAMETER_" & ex.Message
        End Try
    End Function

    Public Sub WriteOperateur(ByVal Parameter1 As String)

        Dim Logs As String = Application.StartupPath & "\ADSTC\Operateurs.adstc"

        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\ADSTC") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\ADSTC")
        End If

        If Not My.Computer.FileSystem.FileExists(Logs) Then
            Dim fs As FileStream = File.Create(Logs)
            fs.Close()
            Dim sw2 As StreamWriter
            sw2 = File.AppendText(Logs)
            sw2.WriteLine(Encrypt(Parameter1))
            sw2.Flush()
            sw2.Close()
        Else
            LogsPage.LogsListBox.Items.Clear()
            Dim lines() As String
            lines = System.IO.File.ReadAllLines(Logs, System.Text.Encoding.UTF8)
            For Each line As String In lines
                line = Decrypt(line)
                If line = Parameter1 Then
                    Exit Sub
                End If
            Next
            Dim sw2 As StreamWriter
            sw2 = File.AppendText(Logs)
            sw2.WriteLine(Encrypt(Parameter1))
            sw2.Flush()
            sw2.Close()
        End If
    End Sub
End Module
