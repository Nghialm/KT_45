'*************************************************************************
'	created:	2011/08/17
'	created:	17:8:2011   11:06
'	filename: 	D:\TRINAM\KeToan\v38\KTY.Common\DataMining.vb
'	file path:	D:\TRINAM\KeToan\v38\KTY.Common
'	file base:	DataMining
'	file ext:	vb
'	author:		Nguyễn Quyết Tiến
'	
'	purpose:	Separate array param to list param
'*************************************************************************
Imports System.Windows.Forms

''' <summary>
''' Separate array param to list param 
''' </summary>
''' <remarks></remarks>
Public Class DataMining

    ''' <summary>
    ''' Separate array param to FORM NAME and FORM PARAM
    ''' </summary>
    ''' <param name="inputText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFormData(ByVal inputText As String) As FormDataInfo
        Try
            Dim formInfo As New FormDataInfo
            Dim arr As String() = inputText.Split("?")
            If arr.Length = 1 Then
                formInfo.FORMNAME = arr(0)
                formInfo.FORMDATA = String.Empty
            ElseIf arr.Length >= 2 Then
                formInfo.FORMNAME = arr(0)
                formInfo.FORMDATA = arr(1)
            End If
            Return formInfo
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Create an object ParamInfo from string param
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateParam(ByVal data As String) As ParamInfo
        Try
            Dim info As New ParamInfo
            If data.Contains("=") Then
                Dim arr As String() = data.Split("=")
                If arr.Length = 2 Then
                    info.PARAMNAME = arr(0)
                    info.PARAMVALUE = arr(1)
                End If
            End If
            Return info
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get List ParamInfo from string param
    ''' </summary>
    ''' <param name="paramData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetParams(ByVal paramData As String) As List(Of ParamInfo)
        Try
            Dim list As New List(Of ParamInfo)
            Dim arr As String() = paramData.Split("&")
            If arr.Length > 0 Then
                For i As Integer = 0 To arr.Length - 1
                    list.Add(CreateParam(arr(i)))
                Next
            End If
            Return list
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Set ShortCut Description of Control to Main Form
    ''' </summary>
    ''' <param name="frm">Control have a ShortCut Description</param>
    ''' <param name="listKey">List ShortCut Key Description</param>
    ''' <remarks></remarks>
    Public Shared Sub SetShortcutKey(ByVal frm As Control, ByVal listKey As List(Of ShortCutInfo))
        Dim frmChild As Form = DirectCast(frm, Form)
        Dim keyDescription As String = String.Empty
        For Each keyInfo As ShortCutInfo In listKey
            keyDescription = keyDescription + keyInfo.KEY.ToUpper() + ": " + keyInfo.DESCRIPTION + ", "
        Next
        keyDescription = keyDescription.Substring(0, keyDescription.LastIndexOf(","))
        frmChild.Tag = keyDescription
    End Sub

End Class
