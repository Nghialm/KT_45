Imports DevExpress.XtraTreeList
Imports System.Data
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Diagnostics
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Public Class frmPopupOfSetup

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

    Dim bo_app_group_forms As IAppGroupFormsService
    Public Property AppGroupFormsService
        Get
            Return bo_app_group_forms
        End Get
        Set(ByVal value)
            bo_app_group_forms = value
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
#End Region

#Region "Event Handles"
    '//////////////////////////////////////////////////
    ' Method:    frmPopupOfSetup_Load
    ' FullName:  frmPopupOfSetup.frmPopupOfSetup_Load
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmPopupOfSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindTreeGroup(listMenu)
            SetSubmitText()
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    frmPopupOfSetup_KeyDown
    ' FullName:  frmPopupOfSetup.frmPopupOfSetup_KeyDown
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.Windows.Forms.KeyEventArgs
    '//////////////////////////////////////////////////
    Private Sub frmPopupOfSetup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnClose_Click
    ' FullName:  frmPopupOfSetup.btnClose_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listMenu_FocusedNodeChanged
    ' FullName:  frmPopupOfSetup.listMenu_FocusedNodeChanged
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listMenu.FocusedNodeChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs
    '//////////////////////////////////////////////////
    Private Sub listMenu_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listMenu.FocusedNodeChanged
        Try
            Dim info As DataRowView = CType(listMenu.GetDataRecordByNode(e.Node), DataRowView)
            txtGroupIdTarget.Text = info("GROUP_ID").ToString
            txtGroupIndexTarget.Text = e.Node.Id.ToString
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listMenu_MouseClick
    ' FullName:  frmPopupOfSetup.listMenu_MouseClick
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listMenu.MouseClick
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.Windows.Forms.MouseEventArgs
    '//////////////////////////////////////////////////
    Private Sub listMenu_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listMenu.MouseClick
        Try
            If e.Button = MouseButtons.Left Then
                GetActiveClass.group_index_target = Integer.Parse(txtGroupIndexTarget.Text)
            End If
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnSubmit_Click
    ' FullName:  frmPopupOfSetup.btnSubmit_Click
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Try
            Dim bResult As Boolean = DoAction(txtFlag.Text)
            If bResult = True Then
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
                Me.Close()
            Else
                lblNotice.Text = "Có lỗi xảy ra hoặc chức năng đã tồn tại trong nhóm đích."
            End If
        Catch
        End Try
    End Sub
#End Region

#Region "Common Function"

    '//////////////////////////////////////////////////
    ' Method:    BindTreeGroup
    ' FullName:  frmPopupOfSetup.BindTreeGroup
    ' Access:    public 
    ' Returns:   TreeList)
    ' Parameter: ByVal tree As TreeList
    '//////////////////////////////////////////////////
    Private Sub BindTreeGroup(ByVal tree As TreeList)
        Try
            Dim dt As IList(Of AppGroupFunction)
            Dim listInfo As New List(Of AppGroupFunction)
            dt = bo_app_group_function.GetAll()
            tree.DataSource = dt
        Catch
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetSubmitText
    ' FullName:  frmPopupOfSetup.SetSubmitText
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SetSubmitText()
        If txtFlag.Text.Equals("copy") Then
            btnSubmit.Text = "Sao chép"
        ElseIf txtFlag.Text.Equals("move") Then
            btnSubmit.Text = "Di chuyển"
        End If
        lblNotice.Text = ""
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    GetFormsInfo
    ' FullName:  frmPopupOfSetup.GetFormsInfo
    ' Access:    public 
    ' Returns:   APP_Forms
    '//////////////////////////////////////////////////
    Private Function GetFormsInfo() As AppForms
        Dim info As New AppForms
        info.FormName = txtFormName.Text
        info.FormText = txtFormText.Text
        info.FormParam = txtFormParam.Text
        info.MenuName = String.Empty
        info.MenuText = String.Empty
        info.ParentName = String.Empty
        Return info
    End Function

    '//////////////////////////////////////////////////
    ' Method:    GetGroupFormsInfo
    ' FullName:  frmPopupOfSetup.GetGroupFormsInfo
    ' Access:    public 
    ' Returns:   APP_Group_Forms
    '//////////////////////////////////////////////////
    Private Function GetGroupFormsInfo() As AppGroupForms
        Dim info As New AppGroupForms
        info.Id = New Guid(txtGroupFormId.Text)
        info.Id = New Guid(txtFormID.Text)
        info.GroupId = New Guid(txtGroupIdTarget.Text)
        info.FormsOrder = Decimal.Parse(txtFormOrder.Text)
        Return info
    End Function

    '//////////////////////////////////////////////////
    ' Method:    CheckExistedGroupFormsInfo
    ' FullName:  frmPopupOfSetup.CheckExistedGroupFormsInfo
    ' Access:    public 
    ' Returns:   Boolean
    ' Parameter: ByVal group_forms_info As APP_Group_FormsInfo
    '//////////////////////////////////////////////////
    Private Function CheckExistedGroupFormsInfo(ByVal group_forms_info As AppGroupForms) As Boolean
        Dim bReturn As Boolean = False
        Dim ds As IList(Of AppGroupForms)
        ds = bo_app_group_forms.GetByOption(group_forms_info.GroupId, group_forms_info.Id)
        If ds.Count > 0 Then
            bReturn = True
        End If
        Return bReturn
    End Function

    '//////////////////////////////////////////////////
    ' Method:    DoAction
    ' FullName:  frmPopupOfSetup.DoAction
    ' Access:    public 
    ' Returns:   Boolean
    ' Parameter: ByVal action As String
    '//////////////////////////////////////////////////
    Private Function DoAction(ByVal action As String) As Boolean
        Dim bReturn As Boolean
        If action.Equals("copy") Then
            bReturn = DoCopy()
        ElseIf action.Equals("move") Then
            bReturn = DoMove()
        End If
        Return bReturn
    End Function

    '//////////////////////////////////////////////////
    ' Method:    DoCopy
    ' FullName:  frmPopupOfSetup.DoCopy
    ' Access:    public 
    ' Returns:   Integer (0, -1 : Error, 1 : OK, 2 : Is Existed)
    '//////////////////////////////////////////////////
    Private Function DoCopy() As Boolean
        Try
            Dim bReturn As Boolean = False
            'Dim form_info As AppForms = GetFormsInfo()
            'Dim infoResult As AppForms = bo_app_forms.Save(form_info)
            'If infoResult.FORMID > 0 Then
            '    Dim gfInfo As New AppGroupForms
            '    gfInfo.Id = infoResult.FormId + 1
            '    gfInfo.GroupId = Decimal.Parse(txtGroupIdTarget.Text)
            '    gfInfo.FormsOrder = Decimal.Parse(txtFormOrder.Text)
            '    Dim gfResult As AppGroupForms = bo_app_group_forms.Save(gfInfo)
            '    If gfResult.Id <> Guid.Empty Then
            '        bReturn = True
            '    End If
            'End If
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    DoMove
    ' FullName:  frmPopupOfSetup.DoMove
    ' Access:    public 
    ' Returns:   Integer (0, -1 : Error, 1 : OK, 2 : Is Existed)
    '//////////////////////////////////////////////////
    Private Function DoMove() As Boolean
        Try
            Dim bReturn As Boolean = False
            Dim gfInfo As AppGroupForms = GetGroupFormsInfo()
            Dim isExisted As Boolean = CheckExistedGroupFormsInfo(gfInfo)
            If isExisted = False Then
                bo_app_group_forms.SaveOrUpdate(gfInfo)
                bReturn = True
            End If
            Return bReturn
        Catch
            Return False
        End Try
    End Function

#End Region

End Class