#Region "Imports"
Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes
Imports System.Windows.Forms
Imports System
Imports System.Xml
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
#End Region

Public Class frmDonviBaocao

#Region "Varibales"
    Dim _DmDonviService As IDmDonviService

    Public Property DmDonviService() As IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property

    Dim _AppDvBcService As IAppDvBcService
    Public Property AppDvBcService() As IAppDvBcService
        Get
            Return _AppDvBcService
        End Get
        Set(value As IAppDvBcService)
            _AppDvBcService = value
        End Set
    End Property
    Dim _HtBaocaoService As IHtBaocaoService
    Public Property HtBaocaoService() As IHtBaocaoService
        Get
            Return _HtBaocaoService
        End Get
        Set(value As IHtBaocaoService)
            _HtBaocaoService = value
        End Set
    End Property
    Dim _AppDvGroupBcService As IAppDvGroupBcService
    Public Property AppDvGroupBcService() As IAppDvGroupBcService
        Get
            Return _AppDvGroupBcService
        End Get
        Set(value As IAppDvGroupBcService)
            _AppDvGroupBcService = value
        End Set
    End Property


    Private LIST_REPORT As List(Of String)
    Private LIST_ORIGINAL As List(Of String)
    Private MADONVI As String 'DONVI ID
    Private TENDONVI As String 'DONVI NAME
    Private ALL_REPORT As Boolean 'IS CHECK ALL
#End Region

#Region "Common Functions"

    '//////////////////////////////////////////////////
    ' Method:    LoadDV
    ' FullName:  frmDonviGroup.LoadDV
    ' Body:		 Load list DONVI to TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub LoadDV()
        Try
            Dim dt As IList(Of DmDonvi) = _DmDonviService.GetAll()
            listDonvi.DataSource = dt
            If (Not dt Is Nothing) And (dt.Count > 0) Then
                MADONVI = dt.Item(0).Id.ToString
            End If

            For Each node As TreeListNode In listDonvi.Nodes
                node.ImageIndex = 5
                node.SelectImageIndex = 5
            Next

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadListReportByDV
    ' FullName:  frmDonviBaocao.LoadListReportByDV
    ' Body:		 Load list report by DONVI, use for update permission
    ' Access:    private 
    ' Returns:   String)
    ' Parameter: ByVal DV_ID As String
    '//////////////////////////////////////////////////
    Private Sub LoadListReportByDV(ByVal DV_ID As String)
        Try
            LIST_REPORT = New List(Of String)
            LIST_ORIGINAL = New List(Of String)
            If (DV_ID <> Nothing) Then
                Dim dt As IList(Of AppDvBc) = _AppDvBcService.GetByDV(New Guid(DV_ID))
                For Each row As AppDvBc In dt
                    LIST_REPORT.Add(row.BcId.ToString)
                    LIST_ORIGINAL.Add(row.BcId.ToString)
                Next
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadReport
    ' FullName:  frmDonviBaocao.LoadReport
    ' Body:		 Load Report for TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub LoadReport()
        Try
            Dim dt As IList(Of HtBaocao) = _HtBaocaoService.GetAll()
            listBC.DataSource = dt
            For Each node0 As TreeListNode In listBC.Nodes
                node0.ImageIndex = 0
                node0.SelectImageIndex = 0
                For Each node1 As TreeListNode In node0.Nodes
                    node1.ImageIndex = 1
                    node1.SelectImageIndex = 1
                    For Each node2 As TreeListNode In node1.Nodes
                        node2.ImageIndex = 2
                        node2.SelectImageIndex = 2
                        For Each node3 As TreeListNode In node2.Nodes
                            node3.ImageIndex = 3
                            node3.SelectImageIndex = 3
                        Next
                    Next
                Next
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetStateChildNodeOf
    ' FullName:  frmDonviBaocao.SetStateChildNodeOf
    ' Body:		 Check or Uncheck all child nodes of Node
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetStateChildNodeOf(ByVal node As TreeListNode)
        Dim pInfo As HtBaocao
        Dim info As HtBaocao
        'Checked = True
        If node.Checked = True Then
            'pInfo = CType(listBC.GetDataRecordByNode(node), DataRowView)
            pInfo = listBC.GetDataRecordByNode(node)
            If IsExistedItemInList(LIST_REPORT, pInfo.Id.ToString) = False Then
                LIST_REPORT.Add(pInfo.Id.ToString)
            End If
            node.ExpandAll()
            For Each cNode As TreeListNode In node.Nodes
                cNode.Checked = True
                'info = CType(listBC.GetDataRecordByNode(cNode), DataRowView)
                info = listBC.GetDataRecordByNode(cNode)
                If IsExistedItemInList(LIST_REPORT, pInfo.Id.ToString) = False Then
                    LIST_REPORT.Add(info.Id.ToString)
                End If
                SetStateChildNodeOf(cNode)
            Next
        Else 'Checked = False
            pInfo = listBC.GetDataRecordByNode(node)
            If IsExistedItemInList(LIST_REPORT, pInfo.Id.ToString) = True Then
                LIST_REPORT.Remove(pInfo.Id.ToString)
            End If
            node.Expanded = False
            For Each cNode As TreeListNode In node.Nodes
                cNode.Checked = False
                info = listBC.GetDataRecordByNode(cNode)
                If IsExistedItemInList(LIST_REPORT, info.Id.ToString) = True Then
                    LIST_REPORT.Remove(info.Id.ToString)
                End If
                SetStateChildNodeOf(cNode)
            Next
        End If
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    ClearCheck
    ' FullName:  frmDonviBaocao.ClearCheck
    ' Body:		 Clear all node checked state in TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub ClearCheck()
        For Each node As TreeListNode In listBC.Nodes
            ResetSelected(node)
        Next
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetCheck
    ' FullName:  frmDonviBaocao.SetCheck
    ' Body:		 Set check for nodes of TreeList
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SetCheck()
        For Each node As TreeListNode In listBC.Nodes
            SetSelectedNode(node)
        Next
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    ResetSelected
    ' FullName:  frmDonviBaocao.ResetSelected
    ' Body:		 Clear check all child node of parent node
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub ResetSelected(ByVal node As TreeListNode)
        Try
            For Each cNode As TreeListNode In node.Nodes
                cNode.Checked = False
                ResetSelected(cNode)
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetSelectedNode
    ' FullName:  frmDonviBaocao.SetSelectedNode
    ' Body:		 Set checked for child node of parent node
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetSelectedNode(ByVal node As TreeListNode)
        Try
            'node : is node level 0
            'we have 2 case
            'case 1 : if node has ID existed in LIST_REPORT, certainly it checked
            'case 2 : if node has ID not existed in LIST_REPORT, but it has any child ID existed
            'in LIST_REPORT, it also checked. in other case, it unchecked.
            Dim pInfo As Vns.Erp.Core.Admin.Domain.HtBaocao = CType(listBC.GetDataRecordByNode(node), Vns.Erp.Core.Admin.Domain.HtBaocao)
            If IsExistedItemInList(LIST_REPORT, pInfo.Id.ToString) = True Then
                node.Checked = True
            Else
                node.Checked = False
            End If

            For Each cNode As TreeListNode In node.Nodes
                Dim info As HtBaocao = CType(listBC.GetDataRecordByNode(cNode), HtBaocao)
                If IsExistedItemInList(LIST_REPORT, info.Id.ToString) = True Then
                    cNode.Checked = True
                Else
                    cNode.Checked = False
                End If

                'If node has child, call again method
                If cNode.HasChildren = True Then
                    SetSelectedNode(cNode)
                End If

                'Set state of parent of node
                SetStateParentByChild2(cNode)
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    UncheckParentByChild
    ' FullName:  frmDonviBaocao.UncheckParentByChild
    ' Body:		 Set state parent node along child nodes
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetStateParentByChild(ByVal node As TreeListNode)
        Try
            'if node level = 0, it has no parent
            If node.Level > 0 Then
                Dim haveChildenChecked As Boolean = False
                Dim pNode As TreeListNode = node.ParentNode
                For Each cNode As TreeListNode In pNode.Nodes
                    If cNode.Checked = True Then
                        haveChildenChecked = True
                        Exit For
                    End If
                Next

                If haveChildenChecked = True Then
                    pNode.Checked = True
                Else
                    pNode.Checked = False
                End If
            End If
            'call again
            SetStateParentByChild(node.ParentNode)
        Catch 'ex As Exception
            'Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SetStateParentByChild2
    ' FullName:  frmDonviBaocao.SetStateParentByChild2
    ' Body:		 Set state parent node along child nodes and Only set first-parent
    ' Access:    private 
    ' Returns:   TreeListNode)
    ' Parameter: ByVal node As TreeListNode
    '//////////////////////////////////////////////////
    Private Sub SetStateParentByChild2(ByVal node As TreeListNode)
        Try
            If Not node.ParentNode Is Nothing Then
                Dim haveChildenChecked As Boolean = False
                Dim pNode As TreeListNode = node.ParentNode
                For Each cNode As TreeListNode In pNode.Nodes
                    If cNode.Checked = True Then
                        haveChildenChecked = True
                        Exit For
                    End If
                Next

                If haveChildenChecked = True Then
                    pNode.Checked = True
                Else
                    pNode.Checked = False
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    SavePermission
    ' FullName:  frmDonviBaocao.SavePermission
    ' Body:		 Save permission to database
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub SavePermission()
        Try
            'SELECT ALL
            If ALL_REPORT = True Then
                LIST_REPORT = New List(Of String)
                Dim dtAll As IList(Of HtBaocao) = _HtBaocaoService.GetAll()
                For Each rowAll As HtBaocao In dtAll
                    LIST_REPORT.Add(rowAll.Id.ToString)
                Next
            End If

            'DO ADDED
            For Each itemAdd As String In LIST_REPORT
                If IsExistedItemInList(LIST_ORIGINAL, itemAdd) = False Then
                    Dim infoAdd As New AppDvBc
                    infoAdd.DvId = New Guid(MADONVI)
                    infoAdd.BcId = VnsConvert.CGuid(itemAdd)
                    infoAdd.BcOrder = 0
                    _AppDvBcService.SaveOrUpdate(infoAdd)
                End If
            Next

            'DO DELETED
            For Each itemDelete As String In LIST_ORIGINAL
                If IsExistedItemInList(LIST_REPORT, itemDelete) = False Then
                    'Delete BC_ID in APP_DV_GROUP_BC before delete it in APP_DV_BC
                    _AppDvGroupBcService.DeleteByDVB(New Guid(MADONVI), VnsConvert.CGuid(itemDelete))
                    _AppDvBcService.DeleteByDVBC(New Guid(MADONVI), Decimal.Parse(itemDelete))
                End If
            Next

            'DO REFRESH
            ALL_REPORT = False
            btnSaveForm.Enabled = False
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    IsExistedItemInList
    ' FullName:  frmDonviGroup.IsExistedItemInList
    ' Body:		 Check item exsited in List(Of String)
    ' Access:    private 
    ' Returns:   String) As Boolean
    ' Parameter: ByVal list As List
    ' Parameter: Of String
    ' Parameter: ByVal item As String
    '//////////////////////////////////////////////////
    Private Function IsExistedItemInList(ByVal list As List(Of String), ByVal item As String) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As String In list
                If info.Equals(item) Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Event Handles"

    '//////////////////////////////////////////////////
    ' Method:    frmDonviBaocao_Load
    ' FullName:  frmDonviBaocao.frmDonviBaocao_Load
    ' Body:		 Form load and init control, data
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmDonviBaocao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadDV()
            LoadListReportByDV(MADONVI)
            LoadReport()
            SetCheck()
            listBC.CollapseAll()
            AddHandler listDonvi.FocusedNodeChanged, AddressOf listDonvi_FocusedNodeChanged
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listDonvi_FocusedNodeChanged
    ' FullName:  frmDonviBaocao.listDonvi_FocusedNodeChanged
    ' Body:		 Select DONVI and get data of DONVI
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles listDonvi.FocusedNodeChanged
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs
    '//////////////////////////////////////////////////
    Private Sub listDonvi_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
        Try
            Dim rowView As DmDonvi = CType(listDonvi.GetDataRecordByNode(e.Node), DmDonvi)
            MADONVI = rowView.Id.ToString
            TENDONVI = rowView.TenDonvi

            LoadListReportByDV(MADONVI)
            'ClearCheck()
            frmProgress.Instance.Thread = AddressOf SetCheck
            frmProgress.Instance.Show_Progress("Đang tải dữ liệu của " + TENDONVI)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnSaveForm_Click
    ' FullName:  frmDonviBaocao.btnSaveForm_Click
    ' Body:		 Save permission to database
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnSaveForm.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnSaveForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveForm.Click
        Try
            frmProgress.Instance.Thread = AddressOf SavePermission
            frmProgress.Instance.Show_Progress("Đang lưu thiết lập báo cáo ...")
            LoadListReportByDV(MADONVI)
            'SetCheck()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnAllForm_Click
    ' FullName:  frmDonviBaocao.btnAllForm_Click
    ' Body:		 Select all report
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles btnAllForm.Click
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub btnAllForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllForm.Click
        Try
            If MessageBox.Show("Bạn đồng ý phân toàn bộ Báo cáo cho " + Environment.NewLine + "Đơn vị: " + TENDONVI, "THIẾT LẬP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ALL_REPORT = True
                btnSaveForm.Enabled = True
                btnSaveForm.Focus()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    btnClose_Click
    ' FullName:  frmDonviBaocao.btnClose_Click
    ' Body:		 Close form
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
    ' Method:    listBC_AfterCheckNode
    ' FullName:  frmDonviBaocao.listBC_AfterCheckNode
    ' Body:		 Add/Remove item in list
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listBC.AfterCheckNode
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.NodeEventArgs
    '//////////////////////////////////////////////////
    Private Sub listBC_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles listBC.AfterCheckNode
        Try
            SetStateChildNodeOf(e.Node)
            SetStateParentByChild(e.Node)
            btnSaveForm.Enabled = True
            btnSaveForm.Focus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    listBC_GetSelectImage
    ' FullName:  frmDonviBaocao.listBC_GetSelectImage
    ' Body:		 Set Icon for TreeList
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles listBC.GetSelectImage
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs
    '//////////////////////////////////////////////////
    Private Sub listBC_GetSelectImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles listBC.GetSelectImage
        Try
            If e.Node.Level < 5 Then
                e.Node.ImageIndex = e.Node.Level
                e.Node.SelectImageIndex = e.Node.Level
            Else
                e.Node.ImageIndex = 4
                e.Node.SelectImageIndex = 4
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    Private Sub frmDonviBaocao_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class