Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Security.AccessControl
'*************************************************************************
'	created:	2011/09/26
'	created:	26:9:2011   11:12
'	filename: 	D:\TRINAM\KeToan\v51\KTY.Common\Crypto.vb
'	file path:	D:\TRINAM\KeToan\v51\KTY.Common
'	file base:	Crypto
'	file ext:	vb
'	author:		Nguyen Quyet Tien
'	
'	purpose:	Encrypt and Decrypt String, Grant Permission for file
'*************************************************************************

''' <summary>
''' Encrypt, Decrypt String
''' Gant Permission for File
''' </summary>
''' <remarks></remarks>
Public Class Crypto

    Public Shared key_encrypt As String = "hko98f8flKfOeiIlLjL"
    ''' <summary>
    ''' EncryptString128Bit
    ''' </summary>
    ''' <param name="vstrTextToBeEncrypted"></param>
    ''' <param name="vstrEncryptionKey"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function EncryptString128Bit(ByVal vstrTextToBeEncrypted As String, _
                                    ByVal vstrEncryptionKey As String) As String

        Dim bytValue() As Byte
        Dim bytKey() As Byte
        Dim bytEncoded() As Byte = {}
        Dim bytIV() As Byte = {121, 241, 10, 1, 132, 74, 11, 39, 255, 91, 45, 78, 14, 211, 22, 62}
        Dim intLength As Integer
        Dim intRemaining As Integer
        Dim objMemoryStream As New MemoryStream()
        Dim objCryptoStream As CryptoStream
        Dim objRijndaelManaged As RijndaelManaged

        '   **********************************************************************
        '   ******  Strip any null character from string to be encrypted    ******
        '   **********************************************************************

        vstrTextToBeEncrypted = StripNullCharacters(vstrTextToBeEncrypted)

        '   **********************************************************************
        '   ******  Value must be within ASCII range (i.e., no DBCS chars)  ******
        '   **********************************************************************

        bytValue = Encoding.ASCII.GetBytes(vstrTextToBeEncrypted.ToCharArray)

        intLength = Len(vstrEncryptionKey)

        '   ********************************************************************
        '   ******   Encryption Key must be 256 bits long (32 bytes)      ******
        '   ******   If it is longer than 32 bytes it will be truncated.  ******
        '   ******   If it is shorter than 32 bytes it will be padded     ******
        '   ******   with upper-case Xs.                                  ****** 
        '   ********************************************************************

        If intLength >= 32 Then
            vstrEncryptionKey = Strings.Left(vstrEncryptionKey, 32)
        Else
            intLength = Len(vstrEncryptionKey)
            intRemaining = 32 - intLength
            vstrEncryptionKey = vstrEncryptionKey & Strings.StrDup(intRemaining, "X")
        End If

        bytKey = Encoding.ASCII.GetBytes(vstrEncryptionKey.ToCharArray)

        objRijndaelManaged = New RijndaelManaged()

        '   ***********************************************************************
        '   ******  Create the encryptor and write value to it after it is   ******
        '   ******  converted into a byte array                              ******
        '   ***********************************************************************

        Try
            objCryptoStream = New CryptoStream(objMemoryStream, _
              objRijndaelManaged.CreateEncryptor(bytKey, bytIV), _
              CryptoStreamMode.Write)
            objCryptoStream.Write(bytValue, 0, bytValue.Length)

            objCryptoStream.FlushFinalBlock()

            bytEncoded = objMemoryStream.ToArray
            objMemoryStream.Close()
            objCryptoStream.Close()
        Catch
        End Try

        '   ***********************************************************************
        '   ******   Return encryptes value (converted from  byte Array to   ******
        '   ******   a base64 string).  Base64 is MIME encoding)             ******
        '   ***********************************************************************

        Return Convert.ToBase64String(bytEncoded)

    End Function

    ''' <summary>
    ''' DecryptString128Bit
    ''' </summary>
    ''' <param name="vstrStringToBeDecrypted"></param>
    ''' <param name="vstrDecryptionKey"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DecryptString128Bit(ByVal vstrStringToBeDecrypted As String, _
                                        ByVal vstrDecryptionKey As String) As String

        Dim bytDataToBeDecrypted() As Byte
        Dim bytTemp() As Byte
        Dim bytIV() As Byte = {121, 241, 10, 1, 132, 74, 11, 39, 255, 91, 45, 78, 14, 211, 22, 62}
        Dim objRijndaelManaged As New RijndaelManaged()
        Dim objMemoryStream As MemoryStream
        Dim objCryptoStream As CryptoStream
        Dim bytDecryptionKey() As Byte

        Dim intLength As Integer
        Dim intRemaining As Integer
        Dim strReturnString As String = String.Empty

        '   *****************************************************************
        '   ******   Convert base64 encrypted value to byte array      ******
        '   *****************************************************************

        bytDataToBeDecrypted = Convert.FromBase64String(vstrStringToBeDecrypted)

        '   ********************************************************************
        '   ******   Encryption Key must be 256 bits long (32 bytes)      ******
        '   ******   If it is longer than 32 bytes it will be truncated.  ******
        '   ******   If it is shorter than 32 bytes it will be padded     ******
        '   ******   with upper-case Xs.                                  ****** 
        '   ********************************************************************

        intLength = Len(vstrDecryptionKey)

        If intLength >= 32 Then
            vstrDecryptionKey = Strings.Left(vstrDecryptionKey, 32)
        Else
            intLength = Len(vstrDecryptionKey)
            intRemaining = 32 - intLength
            vstrDecryptionKey = vstrDecryptionKey & Strings.StrDup(intRemaining, "X")
        End If

        bytDecryptionKey = Encoding.ASCII.GetBytes(vstrDecryptionKey.ToCharArray)

        ReDim bytTemp(bytDataToBeDecrypted.Length)

        objMemoryStream = New MemoryStream(bytDataToBeDecrypted)

        '   ***********************************************************************
        '   ******  Create the decryptor and write value to it after it is   ******
        '   ******  converted into a byte array                              ******
        '   ***********************************************************************

        Try

            objCryptoStream = New CryptoStream(objMemoryStream, _
               objRijndaelManaged.CreateDecryptor(bytDecryptionKey, bytIV), _
               CryptoStreamMode.Read)

            objCryptoStream.Read(bytTemp, 0, bytTemp.Length)

            objCryptoStream.FlushFinalBlock()
            objMemoryStream.Close()
            objCryptoStream.Close()

        Catch
        End Try

        '   *****************************************
        '   ******   Return decypted value     ******
        '   *****************************************

        Return StripNullCharacters(Encoding.ASCII.GetString(bytTemp))

    End Function

    ''' <summary>
    ''' StripNullCharacters
    ''' </summary>
    ''' <param name="vstrStringWithNulls"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function StripNullCharacters(ByVal vstrStringWithNulls As String) As String

        Dim intPosition As Integer
        Dim strStringWithOutNulls As String

        intPosition = 1
        strStringWithOutNulls = vstrStringWithNulls

        Do While intPosition > 0
            intPosition = InStr(intPosition, vstrStringWithNulls, vbNullChar)

            If intPosition > 0 Then
                strStringWithOutNulls = Left$(strStringWithOutNulls, intPosition - 1) & _
                                  Right$(strStringWithOutNulls, Len(strStringWithOutNulls) - intPosition)
            End If

            If intPosition > strStringWithOutNulls.Length Then
                Exit Do
            End If
        Loop

        Return strStringWithOutNulls

    End Function

    ''' <summary>
    ''' Add File Security
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <param name="Account"></param>
    ''' <param name="Rights"></param>
    ''' <param name="ControlType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function AddFileSecurity(ByVal FileName As String, ByVal Account As String, ByVal Rights As FileSystemRights, ByVal ControlType As AccessControlType) As Boolean
        Try
            Dim fInfo As FileInfo = New FileInfo(FileName)
            Dim fSecurity As FileSecurity = fInfo.GetAccessControl()
            fSecurity.AddAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))
            fInfo.SetAccessControl(fSecurity)
            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Remove File Security
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <param name="Account"></param>
    ''' <param name="Rights"></param>
    ''' <param name="ControlType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function RemoveFileSecurity(ByVal FileName As String, ByVal Account As String, ByVal Rights As FileSystemRights, ByVal ControlType As AccessControlType)
        Try
            Dim fInfo As FileInfo = New FileInfo(FileName)
            Dim fSecurity As FileSecurity = fInfo.GetAccessControl()
            fSecurity.RemoveAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))
            fInfo.SetAccessControl(fSecurity)
            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Get Account Info
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAccountInfo() As String
        Return System.Environment.UserDomainName + "\\\\" + System.Environment.UserName
        'Return System.Environment.UserDomainName + "\\\\" + "EveryOne"
    End Function

    ''' <summary>
    ''' Check File Existed
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsExistedFile(ByVal FileName As String) As Boolean
        Try
            Dim fInfo As FileInfo = New FileInfo(FileName)
            If fInfo.Exists() = True Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Add Lock Permission to File
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <remarks></remarks>
    Public Shared Sub AddLockFile(ByVal FileName As String)
        If Crypto.IsExistedFile(FileName) = True Then
            Crypto.AddFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Read, AccessControlType.Deny)
            Crypto.AddFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Write, AccessControlType.Deny)
            Crypto.AddFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Delete, AccessControlType.Deny)
        End If
    End Sub

    ''' <summary>
    ''' Remove Lock Permission from File
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <remarks></remarks>
    Public Shared Sub RemoveLockFile(ByVal FileName As String)
        If Crypto.IsExistedFile(FileName) = True Then
            Crypto.RemoveFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Read, AccessControlType.Deny)
            Crypto.RemoveFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Write, AccessControlType.Deny)
            Crypto.RemoveFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Delete, AccessControlType.Deny)
            Crypto.AddFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Read, AccessControlType.Allow)
            Crypto.AddFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Write, AccessControlType.Allow)
            Crypto.AddFileSecurity(FileName, Crypto.GetAccountInfo, FileSystemRights.Delete, AccessControlType.Allow)
        End If
    End Sub

End Class
