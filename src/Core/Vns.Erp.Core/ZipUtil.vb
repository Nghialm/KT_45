Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO.Compression
Imports System.IO

Public Class ZipUtil
    Public Delegate Sub ProgressDelegate(sMessage As String)
    Public Shared Sub ZipFile(sDir As String, sRelativePath As String, fileName As [String])
        Dim bytes As Byte() = File.ReadAllBytes(Path.Combine(sDir, sRelativePath))
        Using f2 As New FileStream(fileName, FileMode.Create)
            Using gz As New GZipStream(f2, CompressionMode.Compress, False)
                gz.Write(bytes, 0, bytes.Length)
                gz.Close()
                f2.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub CompressFile(sDir As String, sRelativePath As String, zipStream As GZipStream)
        'Compress file name
        Dim chars As Char() = sRelativePath.ToCharArray()
        zipStream.Write(BitConverter.GetBytes(chars.Length), 0, 4)
        For Each c As Char In chars
            zipStream.Write(BitConverter.GetBytes(c), 0, 2)
        Next

        'Compress file content
        Dim bytes As Byte() = File.ReadAllBytes(Path.Combine(sDir, sRelativePath))
        zipStream.Write(BitConverter.GetBytes(bytes.Length), 0, 4)
        zipStream.Write(bytes, 0, bytes.Length)
    End Sub
    Public Shared Function DecompressFile(sDir As String, zipStream As GZipStream) As Boolean
        'Decompress file name
        Dim bytes As Byte() = New Byte(4 - 1) {}
        Dim Readed As Integer = zipStream.Read(bytes, 0, 4)
        If Readed < 4 Then
            Return False
        End If

        Dim iNameLen As Integer = BitConverter.ToInt32(bytes, 0)
        bytes = New Byte(2 - 1) {}
        Dim sb As New StringBuilder()
        For i As Integer = 0 To iNameLen - 1
            zipStream.Read(bytes, 0, 2)
            Dim c As Char = BitConverter.ToChar(bytes, 0)
            sb.Append(c)
        Next
        Dim sFileName As String = sb.ToString()

        'Decompress file content
        bytes = New Byte(4 - 1) {}
        zipStream.Read(bytes, 0, 4)
        Dim iFileLen As Integer = BitConverter.ToInt32(bytes, 0)

        bytes = New Byte(iFileLen - 1) {}
        zipStream.Read(bytes, 0, bytes.Length)

        Dim sFilePath As String = Path.Combine(sDir, sFileName)
        Dim sFinalDir As String = Path.GetDirectoryName(sFilePath)
        If Not Directory.Exists(sFinalDir) Then
            Directory.CreateDirectory(sFinalDir)
        End If

        Using outFile As New FileStream(sFilePath, FileMode.Create, FileAccess.Write, FileShare.None)
            outFile.Write(bytes, 0, iFileLen)
        End Using

        Return True
    End Function
    Public Shared Sub CompressDirectory(sInDir As String, sOutFile As String)
        Dim sFiles As String() = Directory.GetFiles(sInDir, "*.*", SearchOption.AllDirectories)
        Dim iDirLen As Integer = If(sInDir(sInDir.Length - 1) = Path.DirectorySeparatorChar, sInDir.Length, sInDir.Length + 1)

        Using outFile As New FileStream(sOutFile, FileMode.Create, FileAccess.Write, FileShare.None)
            Using str As New GZipStream(outFile, CompressionMode.Compress)
                For Each sFilePath As String In sFiles
                    Dim sRelativePath As String = sFilePath.Substring(iDirLen)
                    CompressFile(sInDir, sRelativePath, str)
                Next
            End Using
        End Using
    End Sub

    Public Shared Sub DecompressToDirectory(sCompressedFile As String, sDir As String)
        Using inFile As New FileStream(sCompressedFile, FileMode.Open, FileAccess.Read, FileShare.None)
            Using zipStream As New GZipStream(inFile, CompressionMode.Decompress, True)
                While DecompressFile(sDir, zipStream)


                End While
            End Using
        End Using
    End Sub
End Class