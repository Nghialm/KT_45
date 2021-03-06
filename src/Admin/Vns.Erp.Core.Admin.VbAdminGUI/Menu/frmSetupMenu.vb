Imports System
Imports DevExpress.XtraTreeList
Imports System.Data
Imports System.Collections.Generic
Imports DevExpress.XtraTreeList.Nodes
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net
Imports DevExpress.XtraEditors
Imports System.IO
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Partial Public Class frmSetupMenu
    Inherits DevExpress.XtraEditors.XtraForm

#Region "Variables"
    Dim bo_app_forms As IAppFormsService
    Public Property AppFormsService
        Get
            Return bo_app_forms
        End Get
        Set(ByVal value)
            bo_app_forms = value
        End Set
    End Property

    Dim bo_dv_form As IAppDvFormService
    Public Property AppDvFormService
        Get
            Return bo_dv_form
        End Get
        Set(ByVal value)
            bo_dv_form = value
        End Set
    End Property

    Dim bo_app_ug_forms As IAppUgFormService
    Public Property AppUgFormService
        Get
            Return bo_app_ug_forms
        End Get
        Set(ByVal value)
            bo_app_ug_forms = value
        End Set
    End Property

    Dim bo_app_group_forms As IAppGroupFormsService
    Public Property AppGroupFormsService
        Get
            Return bo_app_group_forms
        End Get
        Set(ByVal value)
            bo_app_group_forms = value
        End Set
    End Property

    Dim bo_dv_group_from As IAppDvGroupFormService
    Public Property AppDvGroupFormService
        Get
            Return bo_dv_group_from
        End Get
        Set(ByVal value)
            bo_dv_group_from = value
        End Set
    End Property

    Dim bo_app_group_function As IAppGroupFunctionService
    Public Property AppGroupFunctionService
        Get
            Return bo_app_group_function
        End Get
        Set(ByVal value)
            bo_app_group_function = value
        End Set
    End Property

    Dim FormId As Integer
    Dim appForms As Vns.Erp.Core.Admin.Domain.AppForms
    Public Shared node_selected_index As String = String.Empty
    Public Shared flag_update_resource_name As String = "from_res"
    Public frmPopup As frmPopupOfSetup
    Public frmRes As frmResources
#End Region

#Region "Event Handles"
    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' List of App Group Function
    ''' </summary>
    ''' <remarks></remarks>
    Dim dt As IList(Of AppGroupFunction)
    Private Sub InitData()
        dt = bo_app_group_function.GetAll()
    End Sub


    '//////////////////////////////////////////////////
    ' Method:    frmSetupMenu_Load
    ' FullName:  KTY.UI.frmSetupMenu.frmSetupMenu_Load
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmSetupMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InitData()
            BindTreeGroup(listOriginal)
            SetSelectedNode(listOriginal, 0)
            ExpandNode(listOriginal, 0, True)
            InvisibleControl()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listOriginal_FocusedNodeChanged
    ' FullName:  KTY.UI.frmSetupMenu.listOriginal_FocusedNodeChanged
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listOriginal.FocusedNodeChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs
    '//////////////////////////////////////////////////
    Private Sub listOriginal_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listOriginal.FocusedNodeChanged
        Try
            Dim app_path As String = Application.StartupPath
            'app_path = app_path.Substring(0, app_path.LastIndexOf("bin"))

            Dim info As AppGroupFunction = CType(listOriginal.GetDataRecordByNode(e.Node), AppGroupFunction)
            txtGroupIndex.Text = e.Node.Id.ToString
            txtGroupId.Text = info.Id.ToString
            txtGroupName.Text = info.GroupTen
            BindTreeForm(info.Id, listForms)
            If listForms.Nodes.Count <= 0 Then
                AddNewForm()
            End If
            groupForms.Text = txtGroupName.Text
            'Hiển thị icon
            txtResourceName.Text = info.ResourceName
            Dim resource_path As String = app_path + txtResourceName.Text
            IconPreview(picPreview, resource_path)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listForms_FocusedNodeChanged
    ' FullName:  KTY.UI.frmSetupMenu.listForms_FocusedNodeChanged
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listForms.FocusedNodeChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs
    '//////////////////////////////////////////////////
    Private Sub listForms_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listForms.FocusedNodeChanged
        Try
            Dim info As AppGroupForms = CType(listForms.GetDataRecordByNode(e.Node), AppGroupForms)
            txtFormID.Text = info.Id.ToString
            If String.IsNullOrEmpty(info.AppForms.FormParam) Then
                txtFormName.Text = info.AppForms.FormName
            Else
                txtFormName.Text = info.AppForms.FormName + "?" + info.AppForms.FormParam
            End If
            FormId = info.AppForms.FormId
            appForms = info.AppForms
            txtFormText.Text = info.AppForms.FormText
            txtFormOrder.Text = info.FormsOrder.ToString
            If info.AppForms.MenuName.Equals("2") Then
                chkIsShowDialog.Checked = True
            Else
                chkIsShowDialog.Checked = False
            End If
            txtGroupFormsID.Text = info.Id.ToString
            groupDetail.Text = info.AppForms.FormText
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnAdd_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnAdd_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            AddNewForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnSave_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnSave_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If (Not txtFormName.Text.Equals("")) AndAlso (Not txtFormText.Text.Equals("")) Then
                frmProgress.Instance.Thread = AddressOf SaveForm
                frmProgress.Instance.Show_Progress()
            Else
                lblError.Text = "Tên Form và Tên hiển thị không được để trống."
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnDelete_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnDelete_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Not txtFormID.Text.Equals("") Then
                frmProgress.Instance.Thread = AddressOf DeleteForm
                frmProgress.Instance.Show_Progress()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listOriginal_MouseClick
    ' FullName:  KTY.UI.frmSetupMenu.listOriginal_MouseClick
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listOriginal.MouseClick
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.Windows.Forms.MouseEventArgs
    '//////////////////////////////////////////////////
    Private Sub listOriginal_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listOriginal.MouseClick
        Try
            If e.Button = MouseButtons.Left Then
                node_selected_index = txtGroupIndex.Text
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnClose_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnClose_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    txtFormOrder_EditValueChanged
    ' FullName:  KTY.UI.frmSetupMenu.txtFormOrder_EditValueChanged
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles txtFormOrder.EditValueChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub txtFormOrder_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFormOrder.EditValueChanged
        Try
            Dim f_order As Integer = Integer.Parse(txtFormOrder.Text)
        Catch
            txtFormOrder.Text = "0"
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listForms_MouseClick
    ' FullName:  KTY.UI.frmSetupMenu.listForms_MouseClick
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listForms.MouseClick
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.Windows.Forms.MouseEventArgs
    '//////////////////////////////////////////////////
    Private Sub listForms_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listForms.MouseClick
        Try
            If (e.Button = MouseButtons.Right) AndAlso (listForms.Nodes.Count > 0) Then
                popControl.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Common Functions"
    '//////////////////////////////////////////////////
    ' Method:    BindTreeGroup
    ' FullName:  KTY.UI.frmSetupMenu.BindTreeGroup
    ' Access:    public 
    ' Returns:   
    ' Parameter: ByVal tree As TreeList
    '//////////////////////////////////////////////////
    Private Sub BindTreeGroup(ByVal tree As TreeList)
        Try
            tree.DataSource = dt
            For Each pNode As TreeListNode In tree.Nodes
                pNode.ImageIndex = 0
                pNode.SelectImageIndex = 0
                For Each node As TreeListNode In pNode.Nodes
                    node.ImageIndex = 1
                    node.SelectImageIndex = 1
                    Dim info As AppGroupFunction = CType(listOriginal.GetDataRecordByNode(node), AppGroupFunction)
                    Dim group_id As Guid = info.Id
                    If GetCountFunctionOfGroup(group_id) > 0 Then
                        node.HasChildren = True
                    End If
                Next
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    BindTreeForm
    ' FullName:  KTY.UI.frmSetupMenu.BindTreeForm
    ' Access:    public 
    ' Returns:   Integer, ByVal listForm As TreeList)
    ' Parameter: ByVal gId As Integer
    ' Parameter: ByVal listForm As TreeList
    '//////////////////////////////////////////////////
    Private Sub BindTreeForm(ByVal gId As Guid, ByVal listForm As TreeList)
        Try
            Dim list As New List(Of AppGroupForms)
            list.AddRange(LoadFormTree(gId))
            listForm.DataSource = list
            For Each node As TreeListNode In listForm.Nodes
                node.ImageIndex = 2
                node.SelectImageIndex = 2
            Next
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadFormTree
    ' FullName:  KTY.UI.frmSetupMenu.LoadFormTree
    ' Access:    public 
    ' Returns:   List(Of APP_FormsInfo2)
    ' Parameter: ByVal group_id As Integer
    '//////////////////////////////////////////////////
    Private Function LoadFormTree(ByVal group_id As Guid) As IList(Of AppGroupForms)
        Try
            Dim dt As IList(Of AppGroupForms)
            dt = bo_app_group_forms.GetByGroupId(group_id)
            Return dt
        Catch
            Return Nothing
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    SetSelectedNode
    ' FullName:  KTY.UI.frmSetupMenu.SetSelectedNode
    ' Access:    public 
    ' Returns:   Integer
    ' Parameter: ByVal treeList As TreeList
    ' Parameter: ByVal nodeIndex As Integer
    '//////////////////////////////////////////////////
    Private Function SetSelectedNode(ByVal treeList As TreeList, ByVal nodeIndex As Integer) As Integer
        Dim node As TreeListNode = treeList.FindNodeByID(nodeIndex)
        node.Selected = True
        Return treeList.SetFocusedNode(node)
    End Function

    '//////////////////////////////////////////////////
    ' Method:    ExpandNode
    ' FullName:  KTY.UI.frmSetupMenu.ExpandNode
    ' Access:    public 
    ' Returns:   TreeList, ByVal nodeIndex As Integer, ByVal isExpanded As Boolean)
    ' Parameter: ByVal treeList As TreeList
    ' Parameter: ByVal nodeIndex As Integer
    ' Parameter: ByVal isExpanded As Boolean
    '//////////////////////////////////////////////////
    Private Sub ExpandNode(ByVal treeList As TreeList, ByVal nodeIndex As Integer, ByVal isExpanded As Boolean)
        Dim node As TreeListNode = treeList.Nodes(nodeIndex)
        node.Expanded = isExpanded
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    AddNewForm
    ' FullName:  KTY.UI.frmSetupMenu.AddNewForm
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub AddNewForm()
        groupDetail.Text = "Thông tin chi tiết"
        txtFormID.Text = String.Empty
        txtFormName.Text = String.Empty
        txtFormText.Text = String.Empty
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SaveForm
    ' FullName:  KTY.UI.frmSetupMenu.SaveForm
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SaveForm()
        Try
            'Tạo info để thao tác
            Dim formInfo As New AppForms
            If Not appForms Is Nothing Then
                formInfo = appForms
            End If


            formInfo.FormText = txtFormText.Text

            'Tách chuỗi để lấy ra FormName và FormParam
            Dim dataInfo As New FormDataInfo()
            dataInfo = DataMining.GetFormData(txtFormName.Text)
            formInfo.FormName = dataInfo.FORMNAME
            formInfo.FormParam = dataInfo.FORMDATA
            If chkIsShowDialog.Checked = True Then
                formInfo.MenuName = "2"
            Else
                formInfo.MenuName = "1"
            End If
            formInfo.MenuText = String.Empty
            formInfo.ParentName = String.Empty

            'Save form
            If Not txtFormID.Text.Equals("") Then
                'Update
                ' Khi Update thì lúc này trong bảng App_Group_Forms đã có ID rồi
                ' Lấy ID này để Update Form_Order
                formInfo.Id = New Guid(txtFormID.Text)
                Try
                    bo_app_forms.SaveOrUpdate(formInfo)
                    UpdateFormOrder(New Guid(txtGroupFormsID.Text), Integer.Parse(txtFormOrder.Text))
                    BindTreeGroup(listOriginal)
                Catch ex As Exception

                End Try
            Else
                'Add New
                ' Thêm một App_Forms_Info rồi bắt lấy ID của nó
                ' Đưa ID này vào trong App_Group_Form
                ' Tạo App_Group_Form_Info để nối giữa group và form
                ' Bắt lấy cái ID của App_Group_Form_Info
                ' Lấy ID này để Update Form_Order
                Try

                    Dim infoResult As AppForms = bo_app_forms.Save(formInfo)
                    If infoResult.Id <> Guid.Empty Then
                        Dim gfInfo As New AppGroupForms
                        gfInfo.Id = infoResult.Id
                        gfInfo.GroupId = New Guid(txtGroupId.Text)
                        gfInfo.FormsOrder = Integer.Parse(txtFormOrder.Text)
                        Dim gfResult As AppGroupForms = bo_app_group_forms.Save(gfInfo)
                        If gfResult.Id <> Guid.Empty Then
                            UpdateFormOrder(gfResult.Id, Integer.Parse(txtFormOrder.Text))
                            BindTreeGroup(listOriginal)
                        End If
                    End If
                Catch ex As Exception

                End Try
            End If

            'Focused
            SetSelectedNode(listOriginal, Integer.Parse(node_selected_index))
            lblError.Text = ""
        Catch
            lblError.Text = "Tên không được để trống, thứ tự là số nguyên."
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    DeleteForm
    ' FullName:  KTY.UI.frmSetupMenu.DeleteForm
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub DeleteForm()
        Try
            bo_app_group_forms.DeleteById(New Guid(txtGroupId.Text), New Guid(txtFormID.Text))
            bo_dv_group_from.DeleteByF(New Guid(txtFormID.Text))
            bo_dv_form.DeleteByForm(Decimal.Parse(txtFormID.Text))
            Dim tmpAppForms As AppForms = New AppForms()
            tmpAppForms.Id = New Guid(txtFormID.Text)
            bo_app_forms.Delete(tmpAppForms)
            BindTreeGroup(listOriginal)
            'Focused
            SetSelectedNode(listOriginal, Integer.Parse(node_selected_index))
            lblError.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    InvisibleControl
    ' FullName:  KTY.UI.frmSetupMenu.InvisibleControl
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub InvisibleControl()
        txtGroupId.Visible = False
        txtGroupName.Visible = False
        txtGroupIndex.Visible = False
        txtFormID.Visible = False
        txtGroupFormsID.Visible = False
        lblError.Text = ""
        'btnSaveResource.Visible = False
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    CopyWithParam
    ' FullName:  KTY.UI.frmSetupMenu.CopyWithParam
    ' Access:    public 
    ' Returns:   APP_FormsI
    ' Parameter: ByVal info As APP_FormsInfo
    ' Parameter: ByVal formOrder As Decimal
    ' Parameter: ByVal groupFormsId As Decimal
    '//////////////////////////////////////////////////

    'Private Function CopyWithParam(ByVal info As AppForms, ByVal formOrder As Decimal, ByVal groupFormsId As Decimal) As APP_FormsInfo2
    '    Dim info2 As New APP_FormsInfo2
    '    info2.FORMID = info.FormId
    '    info2.FORMNAME = info.FormName
    '    info2.FORMTEXT = info.FormText
    '    info2.PARENTNAME = info.ParentName
    '    info2.MENUNAME = info.MenuName
    '    info2.MENUTEXT = info.MenuText
    '    info2.FORMPARAM = info.FormParam
    '    info2.FORMORDER = formOrder
    '    info2.GROUPFORMSID = groupFormsId
    '    Return info2
    'End Function

    '//////////////////////////////////////////////////
    ' Method:    UpdateFormOrder
    ' FullName:  KTY.UI.frmSetupMenu.UpdateFormOrder
    ' Access:    public 
    ' Returns:   Boolean
    ' Parameter: ByVal group_form_id As Integer
    ' Parameter: ByVal form_order As Integer
    '//////////////////////////////////////////////////
    Private Function UpdateFormOrder(ByVal group_form_id As Guid, ByVal form_order As Integer) As Boolean
        Try
            Dim group_form_info As New AppGroupForms
            group_form_info = bo_app_group_forms.GetById(group_form_id)
            group_form_info.FormsOrder = form_order
            bo_app_group_forms.SaveOrUpdate(group_form_info)
            Return True
        Catch
            Return False
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    IconPreview
    ' FullName:  KTY.UI.frmSetupMenu.IconPreview
    ' Access:    public 
    ' Returns:   PictureEdit, ByVal path As String)
    ' Parameter: ByVal picEdit As PictureEdit
    ' Parameter: ByVal path As String
    '//////////////////////////////////////////////////
    Private Sub IconPreview(ByVal picEdit As PictureEdit, ByVal path As String)
        Dim bmp_icon As Bitmap
        Try
            Dim img As Image = Image.FromFile(path)
            bmp_icon = New Bitmap(img, 50, 50)
        Catch ex As Exception
            bmp_icon = Nothing
        End Try
        picEdit.Image = bmp_icon
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    UpdateResource
    ' FullName:  KTY.UI.frmSetupMenu.UpdateResource
    ' Access:    public 
    ' Returns:   Integer, ByVal resource_name As String)
    ' Parameter: ByVal group_id As Integer
    ' Parameter: ByVal resource_name As String
    '//////////////////////////////////////////////////
    Private Sub UpdateResource(ByVal group_id As Guid, ByVal resource_name As String)
        Try
            Dim info As AppGroupFunction = bo_app_group_function.GetById(group_id)
            info.ResourceName = resource_name
            bo_app_group_function.SaveOrUpdate(info)
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    RefreshResource
    ' FullName:  KTY.UI.frmSetupMenu.RefreshResource
    ' Access:    public 
    ' Returns:   Integer)
    ' Parameter: ByVal group_id As Integer
    '//////////////////////////////////////////////////
    Private Sub RefreshResource(ByVal group_id As Guid)
        Try
            Dim info As AppGroupFunction = bo_app_group_function.GetById(group_id)
            txtResourceName.Text = info.ResourceName
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SaveResources
    ' FullName:  KTY.UI.frmSetupMenu.SaveResources
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SaveResources()
        Try
            If flag_update_resource_name.Equals("from_computer") Then
                Dim app_path As String = Application.StartupPath
                app_path = app_path.Substring(0, app_path.LastIndexOf("bin"))
                app_path = app_path + "Resources\IconMenu\"
                '''''''''''''''
                Dim source_path As String = txtResourceName.Text
                Dim file_name As String = source_path.Substring(source_path.LastIndexOf("\") + 1)
                '''''''''''''''
                Dim path_update As String = "Resources\IconMenu\" + file_name
                Dim des_path As String = app_path + file_name
                '''''''''''''''
                File.Copy(source_path, des_path, True)
                '''''''''''''''
                If File.Exists(des_path) = True Then
                    UpdateResource(New Guid(txtGroupId.Text), path_update)
                End If
            ElseIf flag_update_resource_name.Equals("from_res") Then
                UpdateResource(New Guid(txtGroupId.Text), txtResourceName.Text)
            End If
            BindTreeGroup(listOriginal)
            SetSelectedNode(listOriginal, Integer.Parse(node_selected_index))
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    GetCountFunctionOfGroup
    ' FullName:  KTY.UI.frmSetupMenu.GetCountFunctionOfGroup
    ' Access:    public 
    ' Returns:   Integer
    ' Parameter: ByVal group_id As Integer
    '//////////////////////////////////////////////////
    Private Function GetCountFunctionOfGroup(ByVal group_id As Guid) As Decimal
        Try
            Dim count As Integer = 1
            'Dim dt As IList(Of AppGroupForms) = bo_app_group_forms.GetAll()
            'For Each row As AppGroupForms In dt
            '    If row.GroupId = group_id Then
            '        count = count + 1
            '    End If
            'Next
            Return count
        Catch
            Return 0
        End Try
    End Function

#End Region

#Region "Popup Menu"

    '//////////////////////////////////////////////////
    ' Method:    popDelete_ItemClick
    ' FullName:  KTY.UI.frmSetupMenu.popDelete_ItemClick
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popDelete.ItemClick
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraBars.ItemClickEventArgs
    '//////////////////////////////////////////////////
    Private Sub popDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popDelete.ItemClick
        Try
            Dim info As AppGroupForms = DirectCast(listForms.GetDataRecordByNode(listForms.FocusedNode), AppGroupForms)
            If MessageBox.Show("Bạn có chắc chắn xóa chức năng : " + info.AppForms.FormText + " ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                DeleteForm()
            End If
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    popCopy_ItemClick
    ' FullName:  KTY.UI.frmSetupMenu.popCopy_ItemClick
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popCopy.ItemClick
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraBars.ItemClickEventArgs
    '//////////////////////////////////////////////////
    Private Sub popCopy_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popCopy.ItemClick
        Try
            Dim info As AppGroupForms = DirectCast(listForms.GetDataRecordByNode(listForms.FocusedNode), AppGroupForms)
            frmPopup = ObjectFactory.GetObject("frmHPopupOfSetup")
            frmPopup.txtFlag.Text = "copy"
            frmPopup.txtFormID.Text = info.Id.ToString
            frmPopup.txtFormName.Text = info.AppForms.FormName
            frmPopup.txtFormParam.Text = info.AppForms.FormParam
            frmPopup.txtFormText.Text = info.AppForms.FormText
            frmPopup.txtFormOrder.Text = info.FormsOrder.ToString
            frmPopup.txtGroupFormId.Text = info.Id.ToString
            frmPopup.Text = "Sao chép " + info.AppForms.FormText + " tới ..."
            If frmPopup.ShowDialog() = DialogResult.Yes Then
                BindTreeGroup(listOriginal)
                SetSelectedNode(listOriginal, GetActiveClass.group_index_target)
            End If
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    popMove_ItemClick
    ' FullName:  KTY.UI.frmSetupMenu.popMove_ItemClick
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMove.ItemClick
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraBars.ItemClickEventArgs
    '//////////////////////////////////////////////////
    Private Sub popMove_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popMove.ItemClick
        Try
            Dim info As AppGroupForms = DirectCast(listForms.GetDataRecordByNode(listForms.FocusedNode), AppGroupForms)
            frmPopup = ObjectFactory.GetObject("frmHPopupOfSetup")
            frmPopup.txtFlag.Text = "move"
            frmPopup.txtFormID.Text = info.Id.ToString
            frmPopup.txtFormName.Text = info.AppForms.FormName
            frmPopup.txtFormParam.Text = info.AppForms.FormParam
            frmPopup.txtFormText.Text = info.AppForms.FormText
            frmPopup.txtFormOrder.Text = info.FormsOrder.ToString
            frmPopup.txtGroupFormId.Text = info.Id.ToString
            frmPopup.Text = "Di chuyển " + info.AppForms.FormText + " tới ..."
            If frmPopup.ShowDialog() = DialogResult.Yes Then
                BindTreeGroup(listOriginal)
                SetSelectedNode(listOriginal, GetActiveClass.group_index_target)
            End If
        Catch
        End Try
    End Sub

#End Region

#Region "Setting Resource"

    '//////////////////////////////////////////////////
    ' Method:    btnFromR_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnFromR_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnFromR.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnFromR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFromR.Click
        Try
            Dim app_path As String = Application.StartupPath
            app_path = app_path.Substring(0, app_path.LastIndexOf("bin"))
            'app_path = app_path + "Resources\IconMenu\"
            'Dim dirInfo As DirectoryInfo = Directory.CreateDirectory(app_path)
            'Dim listFile() As FileInfo = dirInfo.GetFiles()
            'Dim str As String = String.Empty
            'For i As Integer = 0 To listFile.Length - 1
            '    str = str + listFile(i).FullName + Environment.NewLine
            'Next
            'MessageBox.Show(str)
            flag_update_resource_name = "from_res"
            frmRes = New frmResources()
            If frmRes.ShowDialog() = DialogResult.OK Then
                txtResourceName.Text = GetActiveClass.resources_name
                IconPreview(picPreview, app_path + txtResourceName.Text)
            End If
            'btnSaveResource.Visible = True
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnFromC_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnFromC_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnFromC.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnFromC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFromC.Click
        Try
            flag_update_resource_name = "from_computer"
            Dim ofd As New OpenFileDialog()
            ofd.Filter = "PNG|*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtResourceName.Text = ofd.FileName
                IconPreview(picPreview, txtResourceName.Text)
            End If
            'btnSaveResource.Visible = True
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnSaveResource_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnSaveResource_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnSaveResource.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnSaveResource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveResource.Click
        frmProgress.Instance.Thread = AddressOf SaveResources
        frmProgress.Instance.Show_Progress()
        'btnSaveResource.Visible = False
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnNotChoise_Click
    ' FullName:  KTY.UI.frmSetupMenu.btnNotChoise_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnNotChoise.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnNotChoise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotChoise.Click
        flag_update_resource_name = "from_res"
        txtResourceName.Text = ""
        'btnSaveResource.Visible = True
    End Sub

#End Region
End Class

#Region "Global Class For Active"
Public Class GetActiveClass
    'Lưu Group Index được chọn trong Popup để thực hiện Selected
    Public Shared group_index_target As Integer = 0
    'Lưu Resource Name trong Popup để thực hiện cập nhật
    Public Shared resources_name As String = String.Empty
End Class
#End Region
