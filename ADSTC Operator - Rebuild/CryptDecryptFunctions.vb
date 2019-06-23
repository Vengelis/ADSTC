
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Module CryptDecryptFunctions
    Public Function Encrypt(ByVal Message As String)
        Dim TextBytes() As Byte = Encoding.UTF8.GetBytes(Message)
        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("adstc297")
        Dim EncrytEngine As New DESCryptoServiceProvider()
        EncrytEngine.Key = KeyBytes
        EncrytEngine.IV = KeyBytes
        Dim MEncrypt As ICryptoTransform = EncrytEngine.CreateEncryptor()
        Dim ResultBytes() As Byte = MEncrypt.TransformFinalBlock(TextBytes, 0, TextBytes.Length)
        Dim Result = Convert.ToBase64String(ResultBytes)
        Return Result
    End Function
    Public Function Decrypt(ByVal Message As String)
        Dim TextBytes() As Byte = Convert.FromBase64String(Message)
        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("adstc297")
        Dim EncrytEngine As New DESCryptoServiceProvider()
        EncrytEngine.Key = KeyBytes
        EncrytEngine.IV = KeyBytes
        Dim MEncrypt As ICryptoTransform = EncrytEngine.CreateDecryptor()
        Dim ResultBytes() As Byte = MEncrypt.TransformFinalBlock(TextBytes, 0, TextBytes.Length)
        Dim Result = Encoding.UTF8.GetString(ResultBytes)
        Return Result
    End Function
End Module
