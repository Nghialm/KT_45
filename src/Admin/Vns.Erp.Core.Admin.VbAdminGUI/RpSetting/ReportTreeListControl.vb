'*************************************************************************
'	Created:	2011/08/30
'	Created:	30:8:2011   16:58
'	File base:	ReportTreeListControl
'	File ext:	vb
'	Author:		Pham Xuan Duy
'	Email:		duypx@trinam.com.vn
'	Mobile:		01239 589 689
'	Company:	TRI NAM TDI., JSC 2009 | All rights reserved 
'	Purpose:	
'*************************************************************************

#Region "Import"

Imports DevExpress.XtraTreeList.Nodes
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

#End Region

Public Class ReportTreeListControl

#Region "Variable"
    'Object duoc truyen tu form cha
    Private _HtBaocaoService As IHtBaocaoService
    Public Property HtBaocaoService() As IHtBaocaoService
        Get
            Return _HtBaocaoService
        End Get
        Set(ByVal value As IHtBaocaoService)
            _HtBaocaoService = value
        End Set
    End Property
    Public input_obj_htbc As HtBaocao

    'Object luu ket qua
    Private result As HtBaocao

    Private lst_all_obj As List(Of HtBaocao)

    Private _ResultObject As HtBaocao

    Public Property ResultObject() As HtBaocao
        Get
            Return _ResultObject
        End Get
        Set(ByVal value As HtBaocao)
            _ResultObject = value
        End Set
    End Property
#End Region

#Region "Functions"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
        Me.lst_all_obj = New List(Of HtBaocao)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal obj As HtBaocao)
        InitializeComponent()

        Me.input_obj_htbc = New HtBaocao
        Me.input_obj_htbc = obj

        Me.lst_all_obj = New List(Of HtBaocao)
    End Sub

    ''' <summary>
    ''' Load treelist
    ''' </summary>
    ''' <param name="object_focusing">node can focus sau khi load</param>
    ''' <remarks></remarks>
    Private Sub LoadTreeMain(ByVal object_focusing As HtBaocao)
        'Lay datasource
        frmProgress.Instance().Thread = AddressOf GetData
        frmProgress.Instance().Show_Progress()

        TreeListMain.DataSource = Me.lst_all_obj

        'Focus vao node truyen vao
        Dim node As TreeListNode
        If Not VnsCheck.IsNullGuid(object_focusing.IdCha) Then
            node = TreeListMain.FindNodeByFieldValue("ID", object_focusing.IdCha)
        Else
            node = TreeListMain.FindNodeByFieldValue("ID", object_focusing.Id)
        End If

        'Group cac node lai va focus vao node dc truyen vao
        TreeListMain.CollapseAll()
        TreeListMain.SetFocusedNode(node)
    End Sub

    ''' <summary>
    ''' Lay du lieu tu db
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetData()
        Me.lst_all_obj = New List(Of HtBaocao)
        Me.lst_all_obj = HtBaocaoService.GetAll()
    End Sub

    ''' <summary>
    ''' Get node dang focus
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetNodeFocusing() As TreeListNode
        Return TreeListMain.FindNodeByID(TreeListMain.FocusedNode.Id)
    End Function

#End Region

#Region "Events"

    Private Sub ReportTreeListControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTreeMain(Me.input_obj_htbc)
        lblChoose.Text = Me.input_obj_htbc.TenBaocao
    End Sub

    Private Sub TreeListMain_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeListMain.FocusedNodeChanged
        If TreeListMain.Focused Then
            Dim obj_curent As HtBaocao = CType(TreeListMain.GetDataRecordByNode(GetNodeFocusing), HtBaocao)
            If obj_curent.ChiTiet = 1 Then
                lblChoose.Text = "Báo cáo: " + obj_curent.TenBaocao
            Else
                lblChoose.Text = "Thư mục: " + obj_curent.TenBaocao
            End If
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim obj_current As New HtBaocao
        obj_current = CType(TreeListMain.GetDataRecordByNode(GetNodeFocusing()), HtBaocao)
        'Neu node duoc chon trung voi node cha thi ko lam gi ca
        If obj_current.TenBaocao.Equals(Me.input_obj_htbc.TenBaocao) Then
            Message_Warning("'" + Me.input_obj_htbc.TenBaocao + "' không thể chứa chính nó!")
        ElseIf obj_current.Id = Me.input_obj_htbc.IdCha Then
            Message_Warning("'" + Me.input_obj_htbc.TenBaocao + "'" + " đã nằm trong " + "'" + obj_current.TenBaocao + "'")
        ElseIf obj_current.ChiTiet = 1 Then
            Message_Warning("'" + obj_current.TenBaocao + "' là một báo cáo không thể chứa '" + Me.input_obj_htbc.TenBaocao + "'")
        Else
            'Tra ve trang thai ok cua form
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me._ResultObject = obj_current
            Me.Hide()
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ReportTreeListControl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Else
        End Select
    End Sub

#End Region

End Class