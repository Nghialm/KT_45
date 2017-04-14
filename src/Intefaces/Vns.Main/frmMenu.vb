Imports DevExpress.XtraNavBar
Imports System.Data
Imports System
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraBars
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic

Imports System.Linq

Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmMenu
    Inherits DevExpress.XtraEditors.XtraForm

#Region "Variables"
    Dim bo_app_forms As IAppFormsService
    Dim bo_user_group As IAppUsergroupService
    Dim bo_usergroup_form As IAppUgFormService
    Dim bo_app_group_forms As IAppGroupFormsService
    Dim bo_app_group_function As IAppGroupFunctionService

    Private lstForms As List(Of AppGroupForms) = New List(Of AppGroupForms)
    Private queue As Queue 'Stored hover item in Menu
    Private default_color As Color 'Store color default
    Private default_font As Font 'Store font default
    Private form_name As String '
    Private form_param As String
    Private form_display As String
    Private is_show_dialog As Boolean
#End Region

#Region "Event Handles"
    Public Sub New()
        InitializeComponent()
        queue = New Queue(2)

        'Dim listKey As New List(Of ShortCutInfo)
        'listKey.Add(New ShortCutInfo("F1", "Trợ giúp"))
        'listKey.Add(New ShortCutInfo("F5", "Refresh"))
        'listKey.Add(New ShortCutInfo("Esc", "Thoát"))
        'DataMining.SetShortcutKey(Me, listKey)
        'Me.paneSearch.Width = 220
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InitService()
            ClearMenu()
            lstForms = New List(Of AppGroupForms)()
            lstForms.AddRange(bo_app_group_forms.GetAll)
            Globals.IS_ADMIN_TONG = False 'Tam
            If Globals.IS_ADMIN_TONG = True Then
                GetMainMenu()
            Else
                GetMainMenuPermission()
            End If
            InitDataForm()
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    Private Sub InitService()
        bo_app_forms = ObjectFactory.GetObject("AppFormsService")
        bo_user_group = ObjectFactory.GetObject("AppUsergroupService")
        bo_usergroup_form = ObjectFactory.GetObject("AppUgFormService")
        bo_app_group_forms = ObjectFactory.GetObject("AppGroupFormsService")
        bo_app_group_function = ObjectFactory.GetObject("AppGroupFunctionService")
    End Sub

    Private Sub barControlMain_LinkPressed(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barControlMain.LinkPressed
        Try
            If queue.Count > 1 Then
                queue.Dequeue()
            End If
            queue.Enqueue(e.Link.Item)
            SetFocusedItemImage(queue)
            'Tải danh sách Forms vào bên tay phải
            GetForms(New Guid(e.Link.Item.Name))
            groupForm.Caption = e.Link.Item.Caption
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub
    Private Sub barControlMain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles barControlMain.MouseDown

        Dim navBar As NavBarControl = TryCast(sender, NavBarControl)

        Dim hitInfo As NavBarHitInfo = navBar.CalcHitInfo(New Point(e.X, e.Y))

        If hitInfo.InGroupCaption AndAlso Not hitInfo.InGroupButton Then

            hitInfo.Group.Expanded = Not hitInfo.Group.Expanded
        End If
    End Sub
    Private Sub barControlMain_GroupExpanded(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles barControlMain.GroupExpanded
        Try
            'Đóng tất cả các Group khác lại
            For Each groupItem As NavBarGroup In barControlMain.Groups
                If Not groupItem Is e.Group Then
                    groupItem.Expanded = False
                End If
            Next
            'Load dữ liệu vào khung bên phải (Danh sách các Forms)
            If e.Group.ItemLinks.Count > 0 Then
                If queue.Count > 1 Then
                    queue.Dequeue()
                End If
                Dim group_function_id As Guid = Guid.Empty
                For Each link_item As NavBarItemLink In e.Group.ItemLinks
                    If link_item.Visible = True Then
                        queue.Enqueue(link_item.Item)
                        group_function_id = New Guid(link_item.Item.Name)
                        Exit For
                    End If
                Next
                SetFocusedItemImage(queue)
                GetForms(group_function_id)
            End If
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    Private Sub barForm_LinkPressed(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barForm.LinkPressed
        Try
            Dim name_dialog As String = e.Link.Item.Name
            Dim arr As String() = name_dialog.Split(Char.Parse(";"))
            Dim dialog_text As String = arr(1)

            Dim formName As String = arr(0)
            Dim formParam As String = e.Link.Item.Hint
            Dim isShowDialog As Boolean
            If dialog_text.Equals("2") Then
                isShowDialog = True
            Else
                isShowDialog = False
            End If


            form_name = formName
            form_param = formParam
            form_display = e.Link.Caption
            is_show_dialog = isShowDialog
            ShowFormAll()

            'frmProgress.Instance.Thread = AddressOf ShowFormAll
            'frmProgress.Instance.Show_Progress("Loading ...")
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    frmMenu_KeyDown
    ' FullName:  KTY.UI.frmMenu.frmMenu_KeyDown
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.Windows.Forms.KeyEventArgs
    '//////////////////////////////////////////////////
    Private Sub frmMenu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F5 Then
                Try
                    ClearMenu()
                    GetMainMenu()
                    InitDataForm()
                Catch Ex As Exception
                    Message_Error(Ex)
                End Try
            End If
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub
#End Region

#Region "Common Functions"
    '//////////////////////////////////////////////////
    ' Method:    ClearMenu
    ' FullName:  KTY.UI.frmMenu.ClearMenu
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub ClearMenu()
        barControlMain.Groups.Clear()
        groupForm.ItemLinks.Clear()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    InitDataForm
    ' FullName:  KTY.UI.frmMenu.InitDataForm
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub InitDataForm()
        Try
            Dim item_first As NavBarItem
            Dim group_id As Guid = Guid.Empty
            If barControlMain.Groups.Count > 0 Then
                For Each group_item As NavBarGroup In barControlMain.Groups
                    If group_item.Visible = True Then
                        group_item.Expanded = True
                        If group_item.ItemLinks.Count > 0 Then
                            For Each link_item As NavBarItemLink In group_item.ItemLinks
                                If link_item.Visible = True Then
                                    item_first = link_item.Item
                                    queue.Enqueue(item_first)
                                    default_color = item_first.Appearance.ForeColor
                                    default_font = item_first.Appearance.Font
                                    group_id = New Guid(item_first.Name)
                                    Exit For
                                End If
                            Next
                        End If
                        Exit For
                    End If
                Next
            End If
            SetFocusedItemImage(queue)
            GetForms(group_id)
            groupForm.SmallImage = listForm.Images(0)
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    GetMainMenu
    ' FullName:  KTY.UI.frmMenu.GetMainMenu
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub GetMainMenu()
        Try
            barControlMain.Groups.Clear()

            Dim group As NavBarGroup
            Dim item As NavBarItem
            Dim itemLink As NavBarItemLink
            Dim dtData As IList(Of AppGroupFunction)

            Dim app_path As String = Application.StartupPath
            dtData = bo_app_group_function.GetAll()

            'Thêm danh mục cấp 1
            Dim rlst_lv1 = From appgf
                        In dtData
                        Order By appgf.GroupOrder
                        Where appgf.ParentId = Null.NullGuid
                        Select appgf
            For Each r_level1 In rlst_lv1
                Dim group_id_cha As Guid = r_level1.Id
                Dim parent_id_cha As Guid = r_level1.ParentId
                Dim group_ten_cha As String = r_level1.GroupTen
                Dim resource_name_cha As String = r_level1.ResourceName
                Dim bitmap_resize_cha As Bitmap
                Try
                    Dim tmpfilecha As String = app_path + "\" + resource_name_cha
                    If Not (String.IsNullOrEmpty(resource_name_cha)) Then
                        Dim small_img_cha As Image = Image.FromFile(app_path + "\" + resource_name_cha)
                        bitmap_resize_cha = New Bitmap(small_img_cha, 32, 32)
                    Else
                        bitmap_resize_cha = Nothing
                    End If
                Catch Ex As Exception
                    bitmap_resize_cha = Nothing
                End Try
                group = New NavBarGroup
                group.SmallImage = bitmap_resize_cha
                group.Name = group_id_cha.ToString
                group.Caption = group_ten_cha

                'Thêm danh mục cấp 2
                Dim returnlist = From appgf
                    In dtData
                    Order By appgf.GroupOrder
                    Where appgf.ParentId = group_id_cha
                    Select appgf
                'dtChild = FillByParentId(dtData, r_level1.Id)
                For Each r_child In returnlist
                    Dim group_id_con As Guid = r_child.Id
                    Dim parent_id_con As Guid = r_child.ParentId
                    Dim group_ten_con As String = r_child.GroupTen
                    Dim resource_name_con As String = r_child.ResourceName
                    Dim bitmap_resize_con As Bitmap
                    Try
                        Dim tmpfilecon As String = app_path + "\" + resource_name_con
                        If Not (String.IsNullOrEmpty(resource_name_con)) Then
                            Dim small_img_con As Image = Image.FromFile(app_path + resource_name_con)
                            bitmap_resize_con = New Bitmap(small_img_con, 32, 32)
                        Else
                            bitmap_resize_con = Nothing
                        End If

                    Catch Ex As Exception
                        bitmap_resize_con = Nothing
                    End Try
                    item = New NavBarItem
                    If Not bitmap_resize_con Is Nothing Then
                        item.SmallImage = bitmap_resize_con
                    Else
                        item.SmallImage = listIcon.Images(9)
                    End If
                    item.Name = group_id_con.ToString
                    item.Caption = group_ten_con
                    itemLink = New NavBarItemLink(item)
                    group.ItemLinks.Add(itemLink)
                Next
                barControlMain.Groups.Add(group)
            Next

            'MessageBox.Show("z")
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    GetMainMenuPermission
    ' FullName:  KTY.UI.frmMenu.GetMainMenuPermission
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub GetMainMenuPermission()
        Try
            barControlMain.Groups.Clear()

            Dim group As NavBarGroup
            Dim item As NavBarItem
            Dim itemLink As NavBarItemLink
            Dim dtData As List(Of AppGroupFunction) = New List(Of AppGroupFunction)()
            Dim dtChild As List(Of AppGroupFunction) = New List(Of AppGroupFunction)()

            Dim app_path As String = Application.StartupPath
            dtData.AddRange(bo_app_group_function.GetByPId(New Guid()))

            'Thêm danh mục cấp 1
            For Each r_level1 As AppGroupFunction In dtData
                Dim group_id_cha As Guid = r_level1.Id
                'Nếu nằm trong phân quyền thì Add
                If Not IsExistedItemInList(LIST_LEVEL1, group_id_cha) = True Then
                    Continue For
                End If
                Dim parent_id_cha As Guid = r_level1.ParentId
                Dim group_ten_cha As String = r_level1.GroupTen
                Dim resource_name_cha As String = r_level1.ResourceName
                Dim bitmap_resize_cha As Bitmap
                Try
                    Dim small_img_cha As Image = Image.FromFile(app_path + "\" + resource_name_cha)
                    bitmap_resize_cha = New Bitmap(small_img_cha, 32, 32)
                Catch Ex As Exception
                    bitmap_resize_cha = Nothing
                End Try
                group = New NavBarGroup
                group.SmallImage = bitmap_resize_cha
                group.Name = group_id_cha.ToString
                group.Caption = group_ten_cha

                'Thêm danh mục cấp 2
                dtChild = New List(Of AppGroupFunction)()
                dtChild.AddRange(bo_app_group_function.GetByPId(group_id_cha))
                For Each r_child As AppGroupFunction In dtChild
                    Dim group_id_con As Guid = r_child.Id
                    'Nếu nằm trong phân quyền thì Add
                    If Not IsExistedItemInList(LIST_LEVEL2, group_id_con) = True Then
                        Continue For
                    End If
                    Dim parent_id_con As Guid = r_child.ParentId
                    Dim group_ten_con As String = r_child.GroupTen
                    Dim resource_name_con As String = r_child.ResourceName
                    Dim bitmap_resize_con As Bitmap
                    Try
                        Dim small_img_con As Image = Image.FromFile(app_path + resource_name_con)
                        bitmap_resize_con = New Bitmap(small_img_con, 32, 32)
                    Catch Ex As Exception
                        bitmap_resize_con = Nothing
                    End Try
                    item = New NavBarItem
                    If Not bitmap_resize_con Is Nothing Then
                        item.SmallImage = bitmap_resize_con
                    Else
                        item.SmallImage = listIcon.Images(9)
                    End If
                    item.Name = group_id_con.ToString
                    item.Caption = group_ten_con
                    itemLink = New NavBarItemLink(item)
                    group.ItemLinks.Add(itemLink)
                    'End If
                Next
                barControlMain.Groups.Add(group)
                'End If
            Next
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    GetForms
    ' FullName:  KTY.UI.frmMenu.GetForms
    ' Access:    private 
    ' Returns:   Integer)
    ' Parameter: ByVal group_id As Integer
    '//////////////////////////////////////////////////
    Private Sub GetForms(ByVal group_id As Guid)
        Try
            groupForm.ItemLinks.Clear()

            Dim item As NavBarItem
            Dim itemLink As NavBarItemLink
            'Dim dtData As IList(Of AppGroupForms)

            If (lstForms Is Nothing Or lstForms.Count = 0) Then
                lstForms = bo_app_group_forms.GetAll
            End If


            Dim dtData = From app
                    In lstForms
                    Order By app.FormsOrder
                    Where app.GroupId = group_id
                    Select app

            For i As Integer = 0 To dtData.Count - 1
                Dim form_id As Guid = dtData(i).Id
                If Not IsExistedItemInList(LIST_FORMS, form_id) Then Continue For

                item = New NavBarItem
                item.Name = dtData(i).AppForms.FormName & ";" & dtData(i).AppForms.MenuName
                item.Caption = dtData(i).AppForms.FormText
                item.Hint = dtData(i).AppForms.FormParam
                item.SmallImage = listIcon.Images(8)
                itemLink = New NavBarItemLink(item)
                groupForm.ItemLinks.Add(itemLink)
                'End If
            Next
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    RefreshMenu
    ' FullName:  KTY.UI.frmMenu.RefreshMenu
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub RefreshMenu()
        Try
            ClearMenu()
            GetMainMenu()
            InitDataForm()
            'BindSourceToTextBox(txtKeySearch)
            If Globals.IS_ADMIN_TONG = False Then
                GetPermission(barControlMain)
            End If
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub


    ''//////////////////////////////////////////////////
    '' Method:    IsExistedFormOther
    '' FullName:  KTY.UI.frmMenu.IsExistedFormOther
    '' Access:    private 
    '' Returns:   Boolean
    '' Parameter: ByVal frm As Windows.Forms.Form
    '' Parameter: ByVal pane As Control
    ''//////////////////////////////////////////////////
    'Private Function IsExistedFormOther(ByVal frm As Windows.Forms.Form, ByVal pane As Control) As Boolean
    '    Try
    '        Dim isExisted As Boolean = False
    '        Dim parent As Windows.Forms.Form = DirectCast(pane, Windows.Forms.Form)
    '        For Each childForm As Windows.Forms.Form In parent.MdiChildren
    '            If childForm.Name.Equals(frm.Name) AndAlso childForm.AccessibleDescription.Equals(frm.AccessibleDescription) Then
    '                isExisted = True
    '            End If
    '        Next
    '        Return isExisted
    '    Catch Ex As Exception
    '        Return False
    '    End Try
    'End Function
    Private Sub f_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)

    End Sub

    Private Sub ShowFormAll()
        Try
            SystemHelper.ShowFormFullOther(form_display, form_name, Me.ParentForm, form_param, is_show_dialog)
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetFocusedItemImage
    ' FullName:  KTY.UI.frmMenu.SetFocusedItemImage
    ' Access:    private 
    ' Returns:   Queue)
    ' Parameter: ByVal queue As Queue
    '//////////////////////////////////////////////////
    Private Sub SetFocusedItemImage(ByVal queue As Queue)
        Try
            Dim objs() As Object = queue.ToArray()
            If (objs Is Nothing Or objs.Length < 2) Then Return

            Dim item1 As NavBarItem = TryCast(objs(0), NavBarItem)
            Dim item2 As NavBarItem = TryCast(objs(1), NavBarItem)
            item1.SmallImage = listIcon.Images(9)
            item1.Appearance.ForeColor = default_color
            item2.SmallImage = listForm.Images(2)
            item2.Appearance.ForeColor = Color.Red
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    BindSourceToTextBox
    ' FullName:  KTY.UI.frmMenu.BindSourceToTextBox
    ' Access:    private 
    ' Returns:   TextBox)
    ' Parameter: ByVal txtKey As TextBox
    '//////////////////////////////////////////////////
    Private Sub BindSourceToTextBox(ByVal txtKey As TextBox)
        Try
            Dim dt As IList(Of AppForms) = bo_app_forms.GetAll()
            Dim collection As AutoCompleteStringCollection = txtKey.AutoCompleteCustomSource
            For Each row As AppForms In dt
                collection.Add(row.FormText)
            Next
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    Private Sub GetPermission(ByVal bar As NavBarControl)
        Try
            'Check Group Level 1
            For Each group_item As NavBarGroup In bar.Groups
                If IsExistedItemInList(LIST_LEVEL1, New Guid(group_item.Name)) = False Then
                    group_item.Visible = False
                ElseIf IsExistedItemInList(LIST_LEVEL1, New Guid(group_item.Name)) = True Then
                    'Check Group  Level 2
                    For Each link_item As NavBarItemLink In group_item.ItemLinks
                        If IsExistedItemInList(LIST_LEVEL2, New Guid(link_item.Item.Name)) = False Then
                            link_item.Visible = False
                        End If
                    Next
                End If
            Next
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Sub

    Private Function IsExistedItemInList(ByVal list As List(Of Guid), ByVal item As Guid) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As Guid In list
                If info = item Then
                    bReturn = True
                    Return bReturn
                End If
            Next
            Return bReturn
        Catch Ex As Exception
            Message_Error(Ex)
        End Try
    End Function
#End Region

End Class

