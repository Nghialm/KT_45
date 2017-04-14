'*************************************************************************
'	created:	2011/09/26
'	created:	26:9:2011   15:07
'	filename: 	D:\TRINAM\KeToan\v51\KTY.Common\XMLConfig.vb
'	file path:	D:\TRINAM\KeToan\v51\KTY.Common
'	file base:	XMLConfig
'	file ext:	vb
'	author:		Nguyen Quyet Tien
'	
'	purpose:	Read and Write XML info
'*************************************************************************

#Region "Imports"
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Xml
#End Region

''' <summary>
''' Read and Write info in XML File
''' </summary>
''' <remarks></remarks>
Public Class XMLConfig

    ''' <summary>
    ''' Get XML Document form string
    ''' </summary>
    ''' <param name="message"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateXMLDocument(ByVal message As String) As XmlDocument
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.LoadXml(message)
        Catch ex As Exception
            'MessageBox.Show("XML syntax invalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return doc
    End Function

    ''' <summary>
    ''' Get XML Document form XML file path
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function XmlReader(ByVal filename As String) As XmlDocument
        Dim doc As XmlDocument = New XmlDocument()
        Try
            doc.Load(filename)
        Catch ex As Exception
            'MessageBox.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        End Try
        Return doc
    End Function

    ''' <summary>
    ''' Write info to XML file
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <param name="donvi_id"></param>
    ''' <param name="ten_donvi"></param>
    ''' <param name="other1"></param>
    ''' <param name="other2"></param>
    ''' <param name="other3"></param>
    ''' <param name="other4"></param>
    ''' <param name="other5"></param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter(ByVal filename As String, ByVal username As String, ByVal password As String, ByVal donvi_id As String, ByVal ten_donvi As String, ByVal other1 As String, ByVal other2 As String, ByVal other3 As String, ByVal other4 As String, ByVal other5 As String)
        Try
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Nothing)
            writer.Formatting = Formatting.Indented

            writer.WriteStartDocument()
            writer.WriteComment("Do not change content of this file." _
                                + "\n Information basic :" _
                                + "\n\t servername : ten Server." _
                                + "\n\t username : ten dang nhap he thong." _
                                + "\n\t password : mat khau dang nhap he thong." _
                                + "\n\t database : ten co so du lieu.")
            writer.WriteStartElement("config")

            writer.WriteStartElement("username")
            writer.WriteString(username)
            writer.WriteEndElement()

            writer.WriteStartElement("password")
            writer.WriteString(password)
            writer.WriteEndElement()

            writer.WriteStartElement("donvi_id")
            writer.WriteString(donvi_id)
            writer.WriteEndElement()

            writer.WriteStartElement("ten_donvi")
            writer.WriteString(ten_donvi)
            writer.WriteEndElement()

            writer.WriteStartElement("other1")
            writer.WriteString(other1)
            writer.WriteEndElement()

            writer.WriteStartElement("other2")
            writer.WriteString(other2)
            writer.WriteEndElement()

            writer.WriteStartElement("other3")
            writer.WriteString(other3)
            writer.WriteEndElement()

            writer.WriteStartElement("other4")
            writer.WriteString(other4)
            writer.WriteEndElement()

            writer.WriteStartElement("other5")
            writer.WriteString(other5)
            writer.WriteEndElement()

            writer.WriteEndElement()
            writer.WriteEndDocument()

            writer.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class
