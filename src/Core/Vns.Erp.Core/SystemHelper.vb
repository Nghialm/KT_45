Imports System.Reflection
Imports DevExpress.XtraBars
Imports System.Windows.Forms

''' <summary>
''' Store Assembly Name
''' Call form through Class Name
''' </summary>
''' <remarks></remarks>
Public Class SystemHelper

    ''' <summary>
    ''' Create form from Class Name
    ''' </summary>
    ''' <param name="formName"></param>
    ''' <param name="pane"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFormByName(ByVal formName As String, ByVal pane As Control, ByVal isChildForm As Boolean) As Form
        Try
            Dim noArgument() As Type = {}
            Dim constructInfo As Reflection.ConstructorInfo = Type.GetType(pane.GetType().Namespace & "." & formName, True, True).GetConstructor(noArgument)
            Dim theForm As Form = DirectCast(constructInfo.Invoke(Nothing), Form)
            If isChildForm = True Then
                theForm.MdiParent = pane
            End If
            Return theForm
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Create form from Assembly
    ''' </summary>
    ''' <param name="formName"></param>
    ''' <param name="pane"></param>
    ''' <param name="isChildForm"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFormAssembly(ByVal formName As String, ByVal pane As Control, ByVal isChildForm As Boolean, ByVal param As String) As Form
        Try
            'Tìm Namespace cho formName
            Dim n_space_of_class As String = String.Empty
            Dim assem_of_class As String = String.Empty
            n_space_of_class = GetNamespaceOfClass(formName)
            assem_of_class = CutString(n_space_of_class)
            'Khởi tạo Form
            Dim theForm As Form = DirectCast(Activator.CreateInstance(assem_of_class, n_space_of_class & "." & formName).Unwrap(), Form)
            'Thiết lập MdiParent cho Form
            If isChildForm = True Then
                theForm.MdiParent = pane
            End If
            If Not param.Equals(String.Empty) Then
                theForm.AccessibleDescription = param
            Else
                theForm.AccessibleDescription = ""
            End If
            Return theForm
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Create form from Assembly direct
    ''' </summary>
    ''' <param name="fullFormName"></param>
    ''' <param name="pane"></param>
    ''' <param name="isChildForm"></param>
    ''' <param name="param"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFormAssemblyDirect(ByVal fullFormName As String, ByVal pane As Control, ByVal isChildForm As Boolean, ByVal param As String) As Form
        Try
            'Tìm AssemblyName cho formName
            Dim assem_of_class As String = String.Empty
            assem_of_class = CutString(fullFormName)
            'Khởi tạo Form
            Dim theForm As Form = DirectCast(Activator.CreateInstance(assem_of_class, fullFormName).Unwrap(), Form)
            'Thiết lập MdiParent cho Form
            If isChildForm = True Then
                theForm.MdiParent = pane
            End If
            If Not param.Equals(String.Empty) Then
                theForm.AccessibleDescription = param
            Else
                theForm.AccessibleDescription = ""
            End If
            Return theForm
2:      Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Specify Class Name, that is existed in list class name
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <param name="pane"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsExistedForm(ByVal frm As Form, ByVal pane As Control)
        Try
            Dim isExisted As Boolean = False
            Dim parent As Form = DirectCast(pane, Form)
            For Each childForm As Form In parent.MdiChildren
                If childForm.Name.Equals(frm.Name) AndAlso childForm.AccessibleDescription.Equals(frm.AccessibleDescription) Then
                    isExisted = True
                End If
            Next
            Return isExisted
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Show Form
    ''' </summary>
    ''' <param name="formName"></param>
    ''' <param name="pane"></param>
    ''' <remarks></remarks>
    Public Shared Function ShowFormFull(ByVal formName As String, ByVal pane As Control, ByVal param As String, ByVal isShowDialog As Boolean) As Boolean
        Try
            Dim frm As Form = Nothing
            Dim dotCount As Integer = GetCountChar(formName, ".")
            If dotCount > 0 Then
                frm = GetFormAssemblyDirect(formName, pane, False, param)
            Else
                frm = GetFormAssembly(formName, pane, False, param)
            End If

            Dim isExisted As Boolean = IsExistedForm(frm, pane)
            Dim parent As Form = DirectCast(pane, Form)

            If isShowDialog = True Then
                frm.ShowDialog()
            Else
                If isExisted = True Then
                    For Each mdiForm As Form In parent.MdiChildren
                        If mdiForm.Name.Equals(frm.Name) Then
                            mdiForm.Activate()
                        End If
                    Next
                Else
                    frm.MdiParent = parent
                    frm.Show()
                End If
            End If

            Return True
        Catch
            Return False
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    ShowFormFullOther
    ' FullName:  KTY.UI.frmMenu.ShowFormFullOther
    ' Access:    private 
    ' Returns:   String, ByVal pane As Control, ByVal param As String, ByVal isShowDialog As Boolean)
    ' Parameter: ByVal formName As String
    ' Parameter: ByVal pane As Control
    ' Parameter: ByVal param As String
    ' Parameter: ByVal isShowDialog As Boolean
    '//////////////////////////////////////////////////
    Public Shared Sub ShowFormFullOther(ByVal formName As String, ByVal pane As Control, ByVal param As String, ByVal isShowDialog As Boolean)
        ShowFormFullOther("", formName, pane, param, isShowDialog)
    End Sub

    Public Shared Sub ShowFormFullOther(ByVal formDisplay As String, ByVal formName As String, ByVal pane As Control, ByVal param As String, ByVal isShowDialog As Boolean)
        Try
            Dim Name As String = formName
            If (Not formName.IndexOf(",") = -1) Then
                Dim formType As Type = Type.GetType(formName)
                Dim theForm As Windows.Forms.Form = DirectCast(Activator.CreateInstance(formType), Windows.Forms.Form)
                theForm.Name = formName + "?" + param
                Name = theForm.Name
            End If

            Name = formName + "?" + param
            Dim parent As Windows.Forms.Form = DirectCast(pane, Windows.Forms.Form)
            If isShowDialog = False Then
                For Each mdiForm As Windows.Forms.Form In parent.MdiChildren
                    If mdiForm.Name.Equals(Name) Then
                        mdiForm.Activate()
                        Return
                    End If
                Next
            End If


            Dim frm As Windows.Forms.Form = ObjectFactory.GetObject(formName)
            frm.Name = formName + "?" + param
            Name = frm.Name
            'Dim isExisted As Boolean = IsExistedFormOther(frm, pane)


            If Not param.Equals(String.Empty) Then
                frm.AccessibleDescription = param
            Else
                frm.AccessibleDescription = ""
            End If

            If (Not String.IsNullOrEmpty(formDisplay)) Then
                frm.Text = formDisplay
            End If

            If isShowDialog = True Then
                frm.ShowDialog()
            Else
                frm.MdiParent = parent
                frm.Show()
            End If
        Catch
        End Try
    End Sub

    Private Shared Function IsExistedFormOther(ByVal frm As Windows.Forms.Form, ByVal pane As Control) As Boolean
        Try
            Dim isExisted As Boolean = False
            Dim parent As Windows.Forms.Form = DirectCast(pane, Windows.Forms.Form)
            For Each childForm As Windows.Forms.Form In parent.MdiChildren
                If childForm.Name.Equals(frm.Name) AndAlso childForm.AccessibleDescription.Equals(frm.AccessibleDescription) Then
                    isExisted = True
                End If
            Next
            Return isExisted
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Show Form Direct
    ''' </summary>
    ''' <param name="fullFormName"></param>
    ''' <param name="pane"></param>
    ''' <param name="param"></param>
    ''' <param name="isShowDialog"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ShowFormFullDirect(ByVal fullFormName As String, ByVal pane As Control, ByVal param As String, ByVal isShowDialog As Boolean) As Boolean
        Try
            Dim frm As Form = GetFormAssemblyDirect(fullFormName, pane, False, param)
            Dim isExisted As Boolean = IsExistedForm(frm, pane)
            Dim parent As Form = DirectCast(pane, Form)

            If isShowDialog = True Then
                frm.ShowDialog()
            Else
                If isExisted = True Then
                    For Each mdiForm As Form In parent.MdiChildren
                        If mdiForm.Name.Equals(frm.Name) Then
                            mdiForm.Activate()
                        End If
                    Next
                Else
                    frm.MdiParent = parent
                    frm.Show()
                End If
            End If

            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' List Namespace of Solution
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ListNamespace() As List(Of String)
        Try
            Dim list As New List(Of String)
            list.Add("KTY.UI")
            list.Add("KTY.UI.Form")
            list.Add("KTY.UI.Form.DanhMuc")
            list.Add("KTY.UI.Form.GiaoDich")
            list.Add("KTY.Accounting")
            list.Add("KTY.Assets")
            list.Add("KTY.Report")
            list.Add("KTY.Security")
            list.Add("KTY.Store")
            list.Add("KTY.DataTransfer")
            list.Add("KTY.HR")
            list.Add("KTY.Taxi")
            list.Add("KTY.SaleService")
            Return list
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list Class Name of Namespace
    ''' </summary>
    ''' <param name="nSpace"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ListClasses(ByVal nSpace As String) As List(Of String)
        Dim strPath As String = Application.StartupPath
        Dim assemStr As String = CutString(nSpace)
        Dim classList As New List(Of String)
        Dim namespaceList As New List(Of String)
        Dim asm As Assembly
        Try
            asm = Assembly.LoadFrom(strPath + "\" + assemStr + ".dll")
            'Lấy về toàn bộ danh sách ClassName thuộc Namespace nSpace
            For Each type As Type In asm.GetTypes()
                If type.Namespace = nSpace Then
                    namespaceList.Add(type.Name)
                End If
            Next
            For Each strClass As String In namespaceList
                classList.Add(strClass)
            Next
        Catch
            asm = Assembly.LoadFrom(strPath + "\" + assemStr + ".exe")
            'Lấy về toàn bộ danh sách ClassName thuộc Namespace nSpace
            For Each type As Type In asm.GetTypes()
                If type.Namespace = nSpace Then
                    namespaceList.Add(type.Name)
                End If
            Next
            For Each strClass As String In namespaceList
                classList.Add(strClass)
            Next
        End Try
        Return classList
    End Function

    ''' <summary>
    ''' Get Namespace from Class Name
    ''' </summary>
    ''' <param name="className"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetNamespaceOfClass(ByVal className As String) As String
        Try
            Dim str As String = String.Empty
            For Each ns As String In ListNamespace()
                Dim list_Class As List(Of String) = ListClasses(ns)
                If list_Class IsNot Nothing Then
                    For Each cl As String In list_Class
                        If cl.Equals(className) Then
                            str = ns
                            Exit For
                        End If
                    Next
                End If
            Next
            Return str
        Catch
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Log off executed from Main Menu
    ''' </summary>
    ''' <param name="bar"></param>
    ''' <param name="parent"></param>
    ''' <remarks></remarks>
    Public Shared Sub LogOff(ByVal bar As BarManager, ByVal parent As Form)
        Try
            Globals.LoginUserID = Guid.Empty
            For Each mItem As BarItem In bar.Items
                If mItem.Name.Substring(0, 2) = "so" Then
                    mItem.Enabled = True
                Else
                    mItem.Enabled = False
                End If
            Next mItem
            'Close all child form before log off
            For Each frm_child As Windows.Forms.Form In parent.MdiChildren
                frm_child.Close()
            Next
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Get number count char in string
    ''' </summary>
    ''' <param name="str"></param>
    ''' <param name="ch"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCountChar(ByVal str As String, ByVal ch As String) As Integer
        Try
            Dim charArray As Char() = str.ToCharArray
            Dim count As Integer = 0
            For i As Integer = 0 To charArray.Length - 1
                If charArray(i).ToString().Equals(ch) Then
                    count = count + 1
                End If
            Next
            Return count
        Catch
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Cut string, only user for string that has two or more character "."
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CutString(ByVal str As String) As String
        Try
            Dim str_temp As String = String.Empty
            Dim ch_array As Char() = str.ToCharArray
            Dim ccccc As Integer = 0
            Dim coutDot As Integer = GetCountChar(str, ".")
            If coutDot > 1 Then
                For i As Integer = 0 To ch_array.Length - 1
                    'str_temp = str_temp + ch_array(i).ToString
                    If ch_array(i).ToString().Equals(".") Then
                        ccccc = ccccc + 1
                    End If
                    If ccccc = 2 Then
                        Exit For
                    End If
                    str_temp = str_temp + ch_array(i).ToString
                Next
                'str_temp = str_temp.Substring(0, str_temp.Length - 1)
            Else
                str_temp = str
            End If
            Return str_temp
        Catch
            Return str
        End Try
    End Function

    ''' <summary>
    ''' Show Help
    ''' </summary>
    ''' <param name="helpProvider"></param>
    ''' <remarks></remarks>
    Public Shared Sub ShowHelp(ByVal parent As Control, ByVal helpProvider As HelpProvider)
        Try
            Help.ShowHelp(parent, helpProvider.HelpNamespace, HelpNavigator.TableOfContents)
        Catch
            Message_Warning("Hướng dẫn sử dụng không tồn tại hoặc đường dẫn không đúng !")
        End Try
    End Sub

    ''' <summary>
    ''' Only use for KTY Project
    ''' </summary>
    ''' <param name="tableName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetObjectInfoFromTableName(ByVal tableName As String) As Object
        Dim objReturn As Object = Nothing
        Dim className As String = StrConv(tableName, VbStrConv.ProperCase) + "Info"
        Try
            objReturn = DirectCast(Activator.CreateInstance("KTY.ObjectInfo", _
                                                        "KTY.ObjectInfo" & "." & className, _
                                                        True, _
                                                        Nothing, _
                                                        Nothing, _
                                                        Nothing, _
                                                        Nothing, _
                                                        Nothing, _
                                                        Nothing).Unwrap(), _
                                                        Object)
        Catch
        End Try
        Return objReturn
    End Function
End Class
