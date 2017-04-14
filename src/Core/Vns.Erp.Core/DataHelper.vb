'*************************************************************************
'	created:	2011/09/29
'	created:	29:9:2011   21:33
'	filename: 	D:\TRINAM\KeToan\v51\KTY.Common\DataHelper.vb
'	file path:	D:\TRINAM\KeToan\v51\KTY.Common
'	file base:	DataHelper
'	file ext:	vb
'	author:		Nguyen Quyet Tien
'	support:    
'	update:     
'
'	purpose:	Convert, Manage Data
'*************************************************************************

#Region "Imports"
Imports System
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Xml
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms
Imports System.ComponentModel

#End Region

Public Class DataHelper

#Region "Converter"

    ''' <summary>
    ''' Get List Properties of Type
    ''' </summary>
    ''' <param name="objType">Type of object</param>
    ''' <returns>ArrayList</returns>
    ''' <remarks></remarks>
    Public Shared Function GetListProperties(ByVal objType As Type) As ArrayList
        Try
            'Declare array
            Dim arrProperties As ArrayList = New ArrayList
            'Declare propertyInfo
            Dim objProperty As PropertyInfo
            'Bind list properties of objType to array
            For Each objProperty In objType.GetProperties()
                arrProperties.Add(objProperty)
            Next
            'Return array of properties of objType
            Return arrProperties
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Convert DataRow to Object
    ''' </summary>
    ''' <param name="dr">DataRow need converted to object</param>
    ''' <param name="objType">Type of object</param>
    ''' <returns>Object</returns>
    ''' <remarks></remarks>
    Public Shared Function DataRowToObject(ByVal dr As DataRow, ByVal objType As Type) As Object
        Try
            'User for casting item in ArrayList Properties to PropertyInfo
            Dim objPropertyInfo As PropertyInfo
            'Stored value of Column that has name mapped with name of PropertyInfo
            Dim objValue As Object

            'This is instance of objType and value for return
            Dim objObject As Object = Activator.CreateInstance(objType)

            'Get list property of objType
            Dim arrProperties As ArrayList = GetListProperties(objType)

            'Get data from DataRow and set to objObject
            For i As Integer = 0 To arrProperties.Count - 1
                objPropertyInfo = CType(arrProperties(i), PropertyInfo)

                Try
                    objValue = dr.Item(objPropertyInfo.Name) 'Important
                Catch
                    objValue = Nothing
                End Try

                If IsDBNull(objValue) Then
                    'if value is Null, set Null Value to objPropertyInfo of objObject
                    objPropertyInfo.SetValue(objObject, Null.SetNull(objPropertyInfo), Nothing)
                Else
                    'set value to objPropertyInfo of objObject
                    objPropertyInfo.SetValue(objObject, objValue, Nothing)
                End If
            Next

            'Return object has data, this is instance of objType
            Return objObject
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Convert DataTable to List TypeInfo
    ''' </summary>
    ''' <param name="dt">DataTable need converted</param>
    ''' <param name="objType">Type of object</param>
    ''' <param name="objList">List of object</param>
    ''' <returns>List of object</returns>
    ''' <remarks></remarks>
    Public Shared Function DataTableToList(ByVal dt As DataTable, ByVal objType As Type, ByRef objList As IList) As IList
        'Get value converted from Converting dataRow
        Dim itemObject As Object
        For Each dr As DataRow In dt.Rows
            itemObject = DataRowToObject(dr, objType)
            objList.Add(itemObject)
        Next
        Return objList
    End Function

    ''' <summary>
    ''' Convert DataTable to ArrayList
    ''' </summary>
    ''' <param name="dt">DataTable need converted</param>
    ''' <param name="objType">Type of object</param>
    ''' <param name="objList">Array list</param>
    ''' <returns>ArrayList</returns>
    ''' <remarks></remarks>
    Public Shared Function DataTableToArray(ByVal dt As DataTable, ByVal objType As Type, ByRef objList As ArrayList) As ArrayList
        'Get value converted from Converting dataRow
        Dim itemObject As Object
        For Each dr As DataRow In dt.Rows
            itemObject = DataRowToObject(dr, objType)
            objList.Add(itemObject)
        Next
        Return objList
    End Function

    ''' <summary>
    ''' Convert DataTable to XmlDocument
    ''' </summary>
    ''' <param name="dt">DataTable need converted</param>
    ''' <param name="objType">Type of object</param>
    ''' <returns>XmlDocument</returns>
    ''' <remarks></remarks>
    Public Shared Function DataTableToXmlDocument(ByVal dt As DataTable, ByVal objType As Type) As XmlDocument
        'User for casting item in ArrayList Properties to PropertyInfo
        Dim objPropertyInfo As PropertyInfo
        'Get list properties
        Dim arrProperties As ArrayList = GetListProperties(objType)
        'Get object name
        Dim typeName As String = objType.Name
        'Get list properties name
        Dim listProperties As New List(Of String)
        For i As Integer = 0 To arrProperties.Count - 1
            objPropertyInfo = CType(arrProperties(i), PropertyInfo)
            listProperties.Add(objPropertyInfo.Name)
        Next

        'Declare XmlDocument
        Dim doc As New XmlDocument()
        doc.CreateXmlDeclaration("1.0", "UTF-8", "yes")
        '<?xml version="1.0" encoding="utf-8" standalone="yes"?>
        doc.CreateComment("Document created by TienNQ. Do not remove.")

        'Create root element
        Dim root As XmlElement = doc.CreateElement("", typeName + "s", "")
        'Write data to root element
        For Each dr As DataRow In dt.Rows
            Dim objNode As XmlNode = doc.CreateNode(XmlNodeType.Element, "", typeName, "")
            For Each proName As String In listProperties
                Dim childNode As XmlNode = doc.CreateNode(XmlNodeType.Element, "", proName, "")
                childNode.InnerText = dr.Item(proName).ToString
                objNode.AppendChild(childNode)
            Next
            root.AppendChild(objNode)
        Next
        doc.AppendChild(root)
        Return doc
    End Function

    ''' <summary>
    ''' Convert DataTable to List Object
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <param name="objType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DataTableToObject(ByVal dt As DataTable, ByVal objType As Type) As List(Of Object)
        Dim objList As New List(Of Object)
        For Each dr As DataRow In dt.Rows
            objList.Add(DataRowToObject(dr, objType))
        Next
        Return objList
    End Function

    Public Shared Function ToDataTable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim dt As New DataTable()
        For i As Integer = 0 To properties.Count - 1
            Dim [property] As PropertyDescriptor = properties(i)
            Try
                dt.Columns.Add([property].Name, [property].PropertyType)
            Catch ex As Exception
                dt.Columns.Add([property].Name, GetType(DateTime))
            End Try

        Next
        Dim values As Object() = New Object(properties.Count - 1) {}
        For Each item As T In data
            For i As Integer = 0 To values.Length - 1
                If properties(i).PropertyType Is GetType(DateTime) Then
                    Dim tmp As DateTime = DirectCast(properties(i).GetValue(item), DateTime)
                    values(i) = If(tmp <= DateTime.MinValue, Nothing, properties(i).GetValue(item))
                ElseIf properties(i).PropertyType Is GetType(Decimal) Then
                    Dim tmp As Decimal = DirectCast(properties(i).GetValue(item), Decimal)
                    values(i) = If(tmp <= Int32.MinValue, Nothing, properties(i).GetValue(item))
                Else
                    values(i) = properties(i).GetValue(item)
                End If
            Next
            dt.Rows.Add(values)
        Next
        Return dt
    End Function

    Public Shared Function ToDataTable(ByVal columns As List(Of String), ByVal results As IList, ByVal types As IList(Of String)) As DataTable
        Dim dataTable As New DataTable()
        Dim i = 0
        For Each column As String In columns
            dataTable.Columns.Add(column, Type.GetType(types(i)))
            i = i + 1
        Next
        If columns.Count > 1 Then
            For Each row As Object() In results
                dataTable.Rows.Add(row)
            Next
        End If
        Return dataTable
    End Function
#End Region

#Region "String Converter"
    Public Shared Function ConvertToNormalizeFormat(ByVal str As String, ByVal codeName As String) As String
        Dim strReturn As String = ""
        Dim strPHAY As String = ","
        Dim strCHAM As String = "."
        Dim strSPEC As String = "@"
        Dim arrTemp() As Char = Nothing
        Select Case codeName
            Case "vi-VN"
                '10.234,567
                arrTemp = str.ToCharArray()
                For i As Integer = arrTemp.Length - 1 To 0 Step -1
                    If arrTemp(i).ToString.Equals(",") Or arrTemp(i).ToString.Equals(".") Then
                        arrTemp(i) = Convert.ToChar(strSPEC)
                        Exit For
                    End If
                Next
                For k As Integer = 0 To arrTemp.Length - 1
                    strReturn = strReturn + arrTemp(k).ToString
                Next
                '
                strReturn = Regex.Replace(strReturn, "[^A-Za-z0-9@\-/]", "")
                strReturn = strReturn.Replace(strSPEC, strPHAY)
            Case "en-US"
                '10,234.567
                arrTemp = str.ToCharArray()
                For i As Integer = arrTemp.Length - 1 To 0 Step -1
                    If arrTemp(i).ToString.Equals(",") Or arrTemp(i).ToString.Equals(".") Then
                        arrTemp(i) = Convert.ToChar(strSPEC)
                        Exit For
                    End If
                Next
                For k As Integer = 0 To arrTemp.Length - 1
                    strReturn = strReturn + arrTemp(k).ToString
                Next
                strReturn = Regex.Replace(strReturn, "[^A-Za-z0-9@\-/]", "")
                strReturn = strReturn.Replace(strSPEC, strCHAM)
            Case "fr-FR"
                '10 234,567
                arrTemp = str.ToCharArray()
                For i As Integer = arrTemp.Length - 1 To 0 Step -1
                    If arrTemp(i).ToString.Equals(",") Or arrTemp(i).ToString.Equals(".") Then
                        arrTemp(i) = Convert.ToChar(strSPEC)
                        Exit For
                    End If
                Next
                For k As Integer = 0 To arrTemp.Length - 1
                    strReturn = strReturn + arrTemp(k).ToString
                Next
                strReturn = Regex.Replace(strReturn, "[^A-Za-z0-9@\-/]", "")
                strReturn = strReturn.Replace(strSPEC, strPHAY)
            Case Else
                strReturn = str
        End Select
        Return strReturn
    End Function
#End Region

#Region "Format Converter"
    Public Shared Sub ApplyFormat(ByVal parentControl As Control)
        Dim currentCodeName As String = System.Threading.Thread.CurrentThread.CurrentCulture.Name
        For Each formControl As Control In parentControl.Controls
            Select Case formControl.GetType().Name
                Case "TextEdit"
                    Dim objTextEdit As TextEdit = CType(formControl, TextEdit)
                    Dim strFormatted As String = ConvertToNormalizeFormat(objTextEdit.Text, currentCodeName)
                    objTextEdit.Text = Strings.Format(CDbl(strFormatted), "n")
                    'objTextEdit.Text = Strings.Format(CDbl(strFormatted), "n5")
                Case "GridControl"
                    Dim gridControl As DevExpress.XtraGrid.GridControl = CType(CType(formControl, Object), DevExpress.XtraGrid.GridControl)
                    Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(gridControl.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
                    For Each gCol As GridColumn In gridView.Columns
                        Dim data_type As String = gCol.ColumnType().Name
                        If data_type.Equals("Decimal") Or data_type.Equals("Double") Or data_type.Equals("Single") Then
                            gCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                            gCol.DisplayFormat.FormatString = "n"
                            'gCol.DisplayFormat.FormatString = "n5"
                            'gCol.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                            'gCol.GroupFormat.FormatString = "##0.000"
                            'gCol.GroupFormat.FormatString = "##0.000,00000"
                        End If
                    Next
                Case Else
                    ApplyFormat(formControl)
            End Select
        Next
    End Sub

    Public Shared Sub SetCulture(ByVal codeName As String)
        Thread.CurrentThread.CurrentCulture = New CultureInfo(codeName)
    End Sub

    Public Shared Sub SetCulture2()
        Dim objData As New CultureManagement
        Dim info As CultureSettingInfo = objData.GetInfo_2()
        Dim culInfo As New CultureInfo(info.Code)
        culInfo.DateTimeFormat.ShortDatePattern = info.DateFormat
        culInfo.DateTimeFormat.ShortTimePattern = info.TimeFormat
        culInfo.DateTimeFormat.DateSeparator = info.DateSeparator
        culInfo.DateTimeFormat.TimeSeparator = info.TimeSeparator
        culInfo.NumberFormat.NumberDecimalSeparator = info.DecimalSeparator
        If info.GroupSeparator.Equals("space") Then
            culInfo.NumberFormat.NumberGroupSeparator = Chr(160)
        Else
            culInfo.NumberFormat.NumberGroupSeparator = info.GroupSeparator
        End If
        Thread.CurrentThread.CurrentCulture = culInfo
    End Sub
#End Region

#Region "XML"

    ''' <summary>
    ''' Write data to XML file from DataSet
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="ds"></param>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter(ByVal filename As String, ByVal ds As DataSet, ByVal obj As Type)
        Try
            Dim dt As DataTable = ds.Tables(0)
            Dim objPropertyInfo As PropertyInfo = Nothing
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Encoding.UTF8)
            writer.Formatting = Formatting.Indented

            Dim typeName As String = obj.Name
            Dim rootName As String = typeName + "s"
            Dim arrProperties As ArrayList = GetListProperties(obj)

            writer.WriteStartDocument()
            writer.WriteComment("" _
                                + vbNewLine + vbTab + "Do not change content of this file." _
                                + vbNewLine + vbTab + "Created by TienNQ." _
                                + vbNewLine + vbTab)
            'Root element
            writer.WriteStartElement(rootName)

            'Write each element
            For Each rowData As DataRow In dt.Rows
                'Each typeName element
                writer.WriteStartElement(typeName)
                For i As Integer = 0 To arrProperties.Count - 1
                    'Each field of typeName element
                    objPropertyInfo = CType(arrProperties(i), PropertyInfo)
                    writer.WriteStartElement(objPropertyInfo.Name)
                    writer.WriteString(rowData.Item(i))
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next

            writer.WriteEndElement() 'End Root element
            writer.WriteEndDocument() 'End Document

            writer.Close() 'Close stream
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Write data to XML file from DataTable
    ''' </summary>
    ''' <param name="filename">Path of file</param>
    ''' <param name="dt">DataTable store data</param>
    ''' <param name="obj">Type of object</param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter(ByVal filename As String, ByVal dt As DataTable, ByVal obj As Type)
        Try
            Dim objPropertyInfo As PropertyInfo = Nothing
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Encoding.UTF8)
            writer.Formatting = Formatting.Indented

            Dim typeName As String = obj.Name
            Dim rootName As String = typeName + "s"
            Dim arrProperties As ArrayList = GetListProperties(obj)

            writer.WriteStartDocument()
            writer.WriteComment("" _
                                + vbNewLine + vbTab + "Do not change content of this file." _
                                + vbNewLine + vbTab + "Created by TienNQ." _
                                + vbNewLine + vbTab)
            'DataTable element
            writer.WriteStartElement("Roots")
            writer.WriteStartElement(rootName)

            'Write each element
            For Each rowData As DataRow In dt.Rows
                'Each typeName element
                writer.WriteStartElement(typeName)
                For i As Integer = 0 To arrProperties.Count - 1
                    'Each field of typeName element
                    objPropertyInfo = CType(arrProperties(i), PropertyInfo)
                    writer.WriteStartElement(objPropertyInfo.Name)
                    writer.WriteString(rowData.Item(i))
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next

            writer.WriteEndElement() 'End DataTable element



            'DonViInfo
            writer.WriteStartElement("DonViInfo")
            writer.WriteStartElement("DONVI_ID")
            writer.WriteString(Generals.DON_VI.Id.ToString())
            writer.WriteEndElement()

            writer.WriteStartElement("MA_DONVI")
            writer.WriteString(Generals.DON_VI.MaDonvi)
            writer.WriteEndElement()

            writer.WriteStartElement("TEN_DONVI")
            writer.WriteString(Generals.DON_VI.TenDonvi)
            writer.WriteEndElement()
            writer.WriteEndElement() 'End DonViInfo



            writer.WriteEndElement()
            writer.WriteEndDocument() 'End Document

            writer.Close() 'Close stream
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Write data to XML file from DataTable Not DonVI
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="dt"></param>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter2(ByVal filename As String, ByVal dt As DataTable, ByVal obj As Type)
        Try
            Dim objPropertyInfo As PropertyInfo = Nothing
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Encoding.UTF8)
            writer.Formatting = Formatting.Indented

            writer.WriteStartDocument()
            writer.WriteComment("" _
                                + vbNewLine + vbTab + "Do not change content of this file." _
                                + vbNewLine + vbTab + "Created by TienNQ." _
                                + vbNewLine + vbTab)

            If (Not dt Is Nothing) AndAlso (Not obj Is Nothing) Then
                Dim typeName As String = obj.Name
                Dim rootName As String = typeName + "s"
                Dim arrProperties As ArrayList = GetListProperties(obj)
                'Root element
                writer.WriteStartElement(rootName)
                'Write each element
                For Each rowData As DataRow In dt.Rows
                    'Each typeName element
                    writer.WriteStartElement(typeName)
                    For i As Integer = 0 To arrProperties.Count - 1
                        'Each field of typeName element
                        objPropertyInfo = CType(arrProperties(i), PropertyInfo)
                        writer.WriteStartElement(objPropertyInfo.Name)
                        Try
                            writer.WriteString(rowData.Item(objPropertyInfo.Name).ToString)
                        Catch
                            writer.WriteString("")
                        End Try
                        writer.WriteEndElement()
                    Next
                    writer.WriteEndElement()
                Next
            ElseIf (dt Is Nothing) AndAlso (Not obj Is Nothing) Then
                writer.WriteStartElement("root")
                writer.WriteString("Data Source Is NULL. Because Not Exist Stored Procedure GetAll() Or Not Exist Package !")
            ElseIf (obj Is Nothing) AndAlso (Not dt Is Nothing) Then
                writer.WriteStartElement("root")
                writer.WriteString("Object Info Is NULL. Because Not Exist Named TableName Plus Info !")
            Else
                writer.WriteStartElement("root")
                writer.WriteString("Object Info And Data Source Is NULL !")
            End If

            writer.WriteEndElement() 'End Root element
            writer.WriteEndDocument() 'End Document
            writer.Close() 'Close stream
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Write data to XML file from DataTable Only
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter3(ByVal filename As String, ByVal dt As DataTable)
        Try
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Encoding.UTF8)
            writer.Formatting = Formatting.Indented

            writer.WriteStartDocument()
            writer.WriteComment("" _
                                + vbNewLine + vbTab + "Do not change content of this file." _
                                + vbNewLine + vbTab + "Created by TienNQ." _
                                + vbNewLine + vbTab)

            If Not dt Is Nothing Then
                Dim listProperties As New List(Of String)
                For Each dtCol As DataColumn In dt.Columns
                    listProperties.Add(dtCol.ColumnName)
                Next
                Dim typeName As String = dt.TableName
                Dim rootName As String = typeName + "S"
                'Root element
                writer.WriteStartElement(rootName)
                'Write each element
                For Each rowData As DataRow In dt.Rows
                    'Each typeName element
                    writer.WriteStartElement(typeName)
                    For i As Integer = 0 To listProperties.Count - 1
                        'Each field of typeName element
                        writer.WriteStartElement(listProperties(i))
                        Try
                            writer.WriteString(rowData.Item(listProperties(i)).ToString)
                        Catch
                            writer.WriteString("")
                        End Try
                        writer.WriteEndElement()
                    Next
                    writer.WriteEndElement()
                Next
            ElseIf dt Is Nothing Then
                writer.WriteStartElement("root")
                writer.WriteString("Data Source Is NULL.")
            End If

            writer.WriteEndElement() 'End Root element
            writer.WriteEndDocument() 'End Document
            writer.Close() 'Close stream
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Write data to XML file from List(Of Object)
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="objList"></param>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter(ByVal filename As String, ByVal objList As IList, ByVal obj As Type)
        Try
            Dim objPropertyInfo As PropertyInfo = Nothing
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Encoding.UTF8)
            writer.Formatting = Formatting.Indented

            Dim typeName As String = obj.Name
            Dim rootName As String = typeName + "s"
            Dim arrProperties As ArrayList = GetListProperties(obj)

            writer.WriteStartDocument()
            writer.WriteComment("" _
                                + vbNewLine + vbTab + "Do not change content of this file." _
                                + vbNewLine + vbTab + "Created by TienNQ." _
                                + vbNewLine + vbTab)
            'Root element
            writer.WriteStartElement(rootName)

            'Write each element
            For i As Integer = 0 To objList.Count - 1
                'Each typeName element
                Dim objInfo As Object = objList.Item(i)
                writer.WriteStartElement(typeName)
                For j As Integer = 0 To arrProperties.Count - 1
                    'Each field of typeName element
                    objPropertyInfo = CType(arrProperties(j), PropertyInfo)
                    writer.WriteStartElement(objPropertyInfo.Name)
                    writer.WriteString(objPropertyInfo.GetValue(objInfo, Nothing))
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next

            writer.WriteEndElement() 'End Root element
            writer.WriteEndDocument() 'End Document

            writer.Close() 'Close stream
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Write data to XML file from List(Of DataSet)
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="listDS"></param>
    ''' <param name="listType"></param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter(ByVal filename As String, ByVal listDS As List(Of DataSet), ByVal listType As List(Of Type))
        Try
            Dim objPropertyInfo As PropertyInfo = Nothing
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Encoding.UTF8)
            writer.Formatting = Formatting.Indented

            writer.WriteStartDocument()
            writer.WriteComment("" _
                                + vbNewLine + vbTab + "Do not change content of this file." _
                                + vbNewLine + vbTab + "Multi report." _
                                + vbNewLine + vbTab + "Created by TienNQ." _
                                + vbNewLine + vbTab)

            'Start Root element
            writer.WriteStartElement("roots")

            For i As Integer = 0 To listDS.Count - 1
                Dim dt As DataTable = listDS.Item(i).Tables(0)
                Dim obj As Type = listType.Item(i)
                Dim typeName As String = obj.Name
                Dim rootName As String = typeName + "s"
                Dim arrProperties As ArrayList = GetListProperties(obj)

                writer.WriteStartElement(rootName)

                'Write each element
                For Each rowData As DataRow In dt.Rows
                    'Each typeName element
                    writer.WriteStartElement(typeName)
                    For j As Integer = 0 To arrProperties.Count - 1
                        'Each field of typeName element
                        objPropertyInfo = CType(arrProperties(j), PropertyInfo)
                        writer.WriteStartElement(objPropertyInfo.Name)
                        Try
                            writer.WriteString(rowData.Item(objPropertyInfo.Name))
                        Catch
                            writer.WriteString("")
                        End Try
                        writer.WriteEndElement()
                    Next
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next

            writer.WriteEndElement() 'End Root element
            writer.WriteEndDocument() 'End Document

            writer.Close() 'Close stream
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Write data to XML file from List(Of DataTable)
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="listDT"></param>
    ''' <param name="listType"></param>
    ''' <remarks></remarks>
    Public Shared Sub XMLWriter(ByVal filename As String, ByVal listDT As List(Of DataTable), ByVal listType As List(Of Type))
        Try
            Dim objPropertyInfo As PropertyInfo = Nothing
            Dim writer As XmlTextWriter = New XmlTextWriter(filename, Encoding.UTF8)
            writer.Formatting = Formatting.Indented

            writer.WriteStartDocument()
            writer.WriteComment("" _
                                + vbNewLine + vbTab + "Do not change content of this file." _
                                + vbNewLine + vbTab + "Multi report." _
                                + vbNewLine + vbTab + "Created by TienNQ." _
                                + vbNewLine + vbTab)

            'Start Root element
            writer.WriteStartElement("roots")

            For i As Integer = 0 To listDT.Count - 1
                Dim dt As DataTable = listDT.Item(i)
                Dim obj As Type = listType.Item(i)
                Dim typeName As String = obj.Name
                Dim rootName As String = typeName + "s"
                Dim arrProperties As ArrayList = GetListProperties(obj)

                writer.WriteStartElement(rootName)

                'Write each element
                For Each rowData As DataRow In dt.Rows
                    'Each typeName element
                    writer.WriteStartElement(typeName)
                    For j As Integer = 0 To arrProperties.Count - 1
                        'Each field of typeName element
                        objPropertyInfo = CType(arrProperties(j), PropertyInfo)
                        writer.WriteStartElement(objPropertyInfo.Name)
                        Try
                            writer.WriteString(rowData.Item(objPropertyInfo.Name))
                        Catch
                            writer.WriteString("")
                        End Try
                        writer.WriteEndElement()
                    Next
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next

            writer.WriteEndElement() 'End Root element
            writer.WriteEndDocument() 'End Document

            writer.Close() 'Close stream
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Common Functions"
    Public Shared Function GetDataRowByKey(ByVal dt As DataTable, ByVal key_name As String, ByVal key_value As String) As DataRow
        Dim row As DataRow = Nothing
        For Each r As DataRow In dt.Rows
            If r(key_name).ToString.Equals(key_value) Then
                row = r
                Exit For
            End If
        Next
        Return row
    End Function
#End Region

    Public Function FUNC_GET_VALUE_BC_CT(ByVal p_cach_tinh As String, ByVal _cot As String,
 ByVal dt As DataTable, ByVal ss_id As Guid)
        Dim dr As DataRow() = dt.Select(String.Format("MaSo = {0}", p_cach_tinh))
        Dim GiaTri As Decimal = 0
        If dr.Length > 0 Then
            If Not Decimal.TryParse(dr(0)(_cot).ToString(), GiaTri) Then
                GiaTri = 0
            End If
        End If

        Return GiaTri
    End Function

    Public Function FUNC_GET_DIV_VALUE_BC(ByVal p_cach_tinh As String, ByVal _cot As String,
 ByVal dt As DataTable, ByVal ss_id As Guid)
        Dim l_idx As String() = p_cach_tinh.Split("/")
        Dim GiaTri As Decimal = 0

        For i As Integer = 0 To l_idx.Length - 1

            If i = 0 Then
                GiaTri = FUNC_GET_VALUE_BC_CT(l_idx(0), _cot, dt, ss_id)
            Else
                Dim GiaTriTemp = FUNC_GET_VALUE_BC_CT(l_idx(0), _cot, dt, ss_id)
                If (GiaTriTemp = 0) Then
                    GiaTri = 0
                Else
                    GiaTri = GiaTri / GiaTriTemp
                End If
            End If
        Next

        Return GiaTri
    End Function

    Public Function FUNC_GET_MUL_VALUE_BC(ByVal p_cach_tinh As String, ByVal _cot As String,
 ByVal dt As DataTable, ByVal ss_id As Guid)
        Dim l_idx As String() = p_cach_tinh.Split("*")
        Dim GiaTri As Decimal = 1

        For i As Integer = 0 To l_idx.Length - 1
            GiaTri = GiaTri * FUNC_GET_DIV_VALUE_BC(l_idx(i), _cot, dt, ss_id)
        Next

        Return GiaTri
    End Function

    Public Function FUNC_GET_SUB_VALUE_BC(ByVal p_cach_tinh As String, ByVal _cot As String,
 ByVal dt As DataTable, ByVal ss_id As Guid)
        Dim l_idx As String() = p_cach_tinh.Split("-")
        Dim GiaTri As Decimal = 0
        '     LOOP
        '    if (ds_bieuthuc%rowcount = 1) then
        '        gia_tri:= Func_get_mul_value_bc(bieu_thuc_record.bieu_thuc, p_cot, p_table, SS_ID);
        '    Else
        '        gia_tri:= gia_tri - Func_get_mul_value_bc(bieu_thuc_record.bieu_thuc, p_cot, p_table, SS_ID);
        '    end if;
        'end loop;
        For i As Integer = 0 To l_idx.Length - 1
            If i = 0 Then
                GiaTri = FUNC_GET_MUL_VALUE_BC(l_idx(0), _cot, dt, ss_id)
            Else
                GiaTri = GiaTri - FUNC_GET_MUL_VALUE_BC(l_idx(i), _cot, dt, ss_id)
            End If
        Next

        Return GiaTri
    End Function

    Public Function FUNC_GET_ADD_VALUE_BC(ByVal p_cach_tinh As String, ByVal _cot As String,
 ByVal dt As DataTable, ByVal ss_id As Guid)
        Dim l_idx As String() = p_cach_tinh.Split("+")
        Dim GiaTri As Decimal = 0

        For i As Integer = 0 To l_idx.Length - 1
            GiaTri = GiaTri + FUNC_GET_SUB_VALUE_BC(l_idx(i), _cot, dt, ss_id)
        Next

        Return GiaTri
    End Function
End Class
