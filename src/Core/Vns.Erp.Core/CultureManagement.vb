Imports System.Xml

Public Class CultureManagement

#Region "Way 1"
    'Get Function
    Public Function GetDocument() As XmlDocument
        Dim doc As New XmlDocument
        doc.Load("CultureManagement.xml")
        Return doc
    End Function

    Public Function GetDocument(ByVal filePath As String) As XmlDocument
        Dim doc As New XmlDocument
        doc.Load(filePath)
        Return doc
    End Function

    Public Function GetAll() As List(Of CulturesInfo)
        Dim list As New List(Of CulturesInfo)
        Dim info As CulturesInfo
        Dim doc As XmlDocument = GetDocument()
        Dim root As XmlElement = doc.DocumentElement
        Dim culsNode As XmlNode = root.SelectSingleNode("Cultures")
        For Each cNode As XmlNode In culsNode.ChildNodes
            info = New CulturesInfo()
            info.Name = cNode.SelectSingleNode("Name").InnerText
            info.Code = cNode.SelectSingleNode("Code").InnerText
            info.Example = cNode.SelectSingleNode("Example").InnerText
            info.IsUsed = Integer.Parse(cNode.SelectSingleNode("IsUsed").InnerText)
            info.IconIndex = Integer.Parse(cNode.SelectSingleNode("IconIndex").InnerText)
            info.Description = cNode.SelectSingleNode("Description").InnerText
            list.Add(info)
        Next
        Return list
    End Function

    Public Function GetByCode(ByVal codeName As String) As CulturesInfo
        Dim info As CulturesInfo = Nothing
        Dim list As List(Of CulturesInfo) = GetAll()
        If list.Count > 0 Then
            For Each cInfo As CulturesInfo In list
                If cInfo.Code.Equals(codeName) Then
                    info = cInfo
                    Exit For
                End If
            Next
        End If
        Return info
    End Function

    Public Function GetListUsed() As List(Of CulturesInfo)
        Dim listUsed As New List(Of CulturesInfo)
        Dim listAll As List(Of CulturesInfo) = GetAll()
        If listAll.Count > 0 Then
            For Each cInfo As CulturesInfo In listAll
                If cInfo.IsUsed = 1 Then
                    listUsed.Add(cInfo)
                End If
            Next
        End If
        Return listUsed
    End Function

    Public Function GetListStored() As List(Of CulturesInfo)
        Dim listStored As New List(Of CulturesInfo)
        Dim listAll As List(Of CulturesInfo) = GetAll()
        If listAll.Count > 0 Then
            For Each cInfo As CulturesInfo In listAll
                If cInfo.IsUsed = 0 Then
                    listStored.Add(cInfo)
                End If
            Next
        End If
        Return listStored
    End Function

    Public Function GetUsed() As CulturesInfo
        Dim listUsed As List(Of CulturesInfo) = GetListUsed()
        If listUsed.Count > 0 Then
            Return listUsed(0)
        Else
            Return Nothing
        End If
    End Function

    'Save Function
    Public Sub SaveDoc(ByVal doc As XmlDocument)
        SaveDocument(doc, "CultureManagement.xml")
    End Sub

    Public Sub SaveDocument(ByVal doc As XmlDocument, ByVal filePath As String)
        doc.Save(filePath)
    End Sub

    'Insert, Update, Delete Function
    Public Function Insert(ByVal info As CulturesInfo) As Boolean
        Dim bReturn As Boolean = True
        Try
            Dim doc As XmlDocument = GetDocument()
            Dim root As XmlElement = doc.DocumentElement
            Dim culs As XmlNode = root.SelectSingleNode("Cultures")
            Dim insertNode As XmlNode = doc.CreateNode(XmlNodeType.Element, "Culture", Nothing)
            Dim strXML As String = ""
            strXML = strXML + "<Name>" + info.Name + "</Name>"
            strXML = strXML + "<Code>" + info.Code + "</Code>"
            strXML = strXML + "<Example>" + info.Example + "</Example>"
            strXML = strXML + "<IsUsed>" + info.IsUsed.ToString + "</IsUsed>"
            strXML = strXML + "<IconIndex>" + info.IconIndex.ToString + "</IconIndex>"
            strXML = strXML + "<Description>" + info.Description + "</Description>"
            insertNode.InnerXml = strXML
            If CheckExist(info.Code) Then
                bReturn = False
            Else
                culs.AppendChild(insertNode)
                SaveDoc(doc)
            End If
        Catch
            bReturn = False
        End Try
        Return bReturn
    End Function

    Public Function Update(ByVal info As CulturesInfo) As Boolean
        Dim bReturn As Boolean = True
        Try
            Dim doc As XmlDocument = GetDocument()
            Dim root As XmlElement = doc.DocumentElement
            Dim culs As XmlNode = root.SelectSingleNode("Cultures")
            If CheckExist(info.Code) Then
                For Each cNode As XmlNode In culs.ChildNodes
                    If cNode.SelectSingleNode("Code").InnerText.Equals(info.Code) Then
                        cNode.SelectSingleNode("Name").InnerText = info.Name
                        cNode.SelectSingleNode("Example").InnerText = info.Example
                        cNode.SelectSingleNode("IsUsed").InnerText = info.IsUsed.ToString
                        cNode.SelectSingleNode("IconIndex").InnerText = info.IconIndex.ToString
                        cNode.SelectSingleNode("Description").InnerText = info.Description
                        Exit For
                    End If
                Next
                SaveDoc(doc)
            Else
                bReturn = False
            End If
        Catch
            bReturn = False
        End Try
        Return bReturn
    End Function

    Public Function SetNotUsed() As Boolean
        Dim bReturn As Boolean = True
        Try
            Dim doc As XmlDocument = GetDocument()
            Dim root As XmlElement = doc.DocumentElement
            Dim culs As XmlNode = root.SelectSingleNode("Cultures")
            For Each cNode As XmlNode In culs.ChildNodes
                cNode.SelectSingleNode("IsUsed").InnerText = "0"
            Next
            SaveDoc(doc)
        Catch
            bReturn = False
        End Try
        Return bReturn
    End Function

    Public Function SetUsed(ByVal codeName As String) As Boolean
        Dim bReturn As Boolean = True
        Try
            Dim doc As XmlDocument = GetDocument()
            Dim root As XmlElement = doc.DocumentElement
            Dim culs As XmlNode = root.SelectSingleNode("Cultures")
            For Each cNode As XmlNode In culs.ChildNodes
                If cNode.SelectSingleNode("Code").InnerText.Equals(codeName) Then
                    cNode.SelectSingleNode("IsUsed").InnerText = "1"
                    Exit For
                End If
            Next
            SaveDoc(doc)
        Catch
            bReturn = False
        End Try
        Return bReturn
    End Function

    Public Function Delete(ByVal codeName As String) As Boolean
        Dim bReturn As Boolean = False
        Try
            Dim doc As XmlDocument = GetDocument()
            Dim root As XmlElement = doc.DocumentElement
            Dim culs As XmlNode = root.SelectSingleNode("Cultures")
            If CheckExist(codeName) Then
                For Each cNode As XmlNode In culs.ChildNodes
                    If cNode.SelectSingleNode("Code").InnerText.Equals(codeName) Then
                        culs.RemoveChild(cNode)
                        bReturn = True
                        Exit For
                    End If
                Next
            End If
        Catch
        End Try
        Return bReturn
    End Function

    Public Function CheckExist(ByVal codeName As String) As Boolean
        Dim bReturn As Boolean = False
        Dim listAll As List(Of CulturesInfo) = GetAll()
        If listAll.Count > 0 Then
            For Each cInfo As CulturesInfo In listAll
                If cInfo.Code.Equals(codeName) Then
                    bReturn = True
                    Exit For
                End If
            Next
        End If
        Return bReturn
    End Function
#End Region

#Region "Way 2"
    'Get Function
    Public Function GetDocument_2() As XmlDocument
        Dim doc As New XmlDocument
        doc.Load("CultureSetting.xml")
        Return doc
    End Function

    Public Function GetDocument_2(ByVal filePath As String) As XmlDocument
        Dim doc As New XmlDocument
        doc.Load(filePath)
        Return doc
    End Function

    Public Function GetInfo_2() As CultureSettingInfo
        Dim info As CultureSettingInfo
        Dim doc As XmlDocument = GetDocument_2()
        Dim root As XmlElement = doc.DocumentElement
        Dim culInfo As XmlNode = root.SelectSingleNode("CultureInfo")

        info = New CultureSettingInfo()
        info.Name = culInfo.SelectSingleNode("Name").InnerText
        info.Code = culInfo.SelectSingleNode("Code").InnerText
        info.DateFormat = culInfo.SelectSingleNode("DateFormat").InnerText
        info.DateSeparator = culInfo.SelectSingleNode("DateSeparator").InnerText
        info.TimeFormat = culInfo.SelectSingleNode("TimeFormat").InnerText
        info.TimeSeparator = culInfo.SelectSingleNode("TimeSeparator").InnerText
        info.DecimalSeparator = culInfo.SelectSingleNode("DecimalSeparator").InnerText
        info.GroupSeparator = culInfo.SelectSingleNode("GroupSeparator").InnerText
        info.CalendarLanguage = culInfo.SelectSingleNode("CalendarLanguage").InnerText
        info.Extend1 = culInfo.SelectSingleNode("Extend1").InnerText
        info.Extend2 = culInfo.SelectSingleNode("Extend2").InnerText
        info.Extend3 = culInfo.SelectSingleNode("Extend3").InnerText
        info.Extend4 = culInfo.SelectSingleNode("Extend4").InnerText
        info.Extend5 = culInfo.SelectSingleNode("Extend5").InnerText
        info.Extend6 = culInfo.SelectSingleNode("Extend6").InnerText
        info.Extend7 = culInfo.SelectSingleNode("Extend7").InnerText
        info.Extend8 = culInfo.SelectSingleNode("Extend8").InnerText
        info.Extend9 = culInfo.SelectSingleNode("Extend9").InnerText
        info.Extend10 = culInfo.SelectSingleNode("Extend10").InnerText

        Return info
    End Function

    'Save Function
    Public Sub SaveDoc_2(ByVal doc As XmlDocument)
        SaveDocument_2(doc, "CultureSetting.xml")
    End Sub

    Public Sub SaveDocument_2(ByVal doc As XmlDocument, ByVal filePath As String)
        doc.Save(filePath)
    End Sub

    'Update Function
    Public Function Update_2(ByVal info As CultureSettingInfo) As Boolean
        Dim bReturn As Boolean = True
        Try
            Dim doc As XmlDocument = GetDocument_2()
            Dim root As XmlElement = doc.DocumentElement
            Dim culInfo As XmlNode = root.SelectSingleNode("CultureInfo")
            culInfo.SelectSingleNode("Name").InnerText = info.Name
            culInfo.SelectSingleNode("Code").InnerText = info.Code
            culInfo.SelectSingleNode("DateFormat").InnerText = info.DateFormat
            culInfo.SelectSingleNode("DateSeparator").InnerText = info.DateSeparator
            culInfo.SelectSingleNode("TimeFormat").InnerText = info.TimeFormat
            culInfo.SelectSingleNode("TimeSeparator").InnerText = info.TimeSeparator
            culInfo.SelectSingleNode("DecimalSeparator").InnerText = info.DecimalSeparator
            culInfo.SelectSingleNode("GroupSeparator").InnerText = info.GroupSeparator
            culInfo.SelectSingleNode("CalendarLanguage").InnerText = info.CalendarLanguage
            culInfo.SelectSingleNode("Extend1").InnerText = info.Extend1
            culInfo.SelectSingleNode("Extend2").InnerText = info.Extend2
            culInfo.SelectSingleNode("Extend3").InnerText = info.Extend3
            culInfo.SelectSingleNode("Extend4").InnerText = info.Extend4
            culInfo.SelectSingleNode("Extend5").InnerText = info.Extend5
            culInfo.SelectSingleNode("Extend6").InnerText = info.Extend6
            culInfo.SelectSingleNode("Extend7").InnerText = info.Extend7
            culInfo.SelectSingleNode("Extend8").InnerText = info.Extend8
            culInfo.SelectSingleNode("Extend9").InnerText = info.Extend9
            culInfo.SelectSingleNode("Extend10").InnerText = info.Extend10
            SaveDoc_2(doc)
        Catch
            bReturn = False
        End Try
        Return bReturn
    End Function
#End Region

End Class
