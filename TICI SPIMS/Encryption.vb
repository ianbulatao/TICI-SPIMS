
Imports System.Security.Cryptography
Imports System.Text
Module Encryption
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        'ENCRYPTS THE STRING WITH AES
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function
    Function CONSUME(ByVal str As String)
        Return AES_Encrypt(str, "ETtEYzeqE4zBxfkJ4qu+3quAz2pQiLF4AbxlCcy8P6M=")
    End Function
    Function SPIT(ByVal str As String)
        Return AES_Decrypt(str, "ETtEYzeqE4zBxfkJ4qu+3quAz2pQiLF4AbxlCcy8P6M=")
    End Function

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        'DECRYPTS STRING WITH AES
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Module
