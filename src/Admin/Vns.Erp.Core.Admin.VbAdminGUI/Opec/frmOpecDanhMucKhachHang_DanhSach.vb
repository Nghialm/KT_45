Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Common.Controls


Partial Public Class frmOpecDanhMucKhachHang_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"
    Dim _DmKhangService As IDmKhangService
    Public Property DmKhangService() As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Dim _FormChiTiet As FrmBaseDmChiTiet
    Public Overrides Property FormChiTiet() As FrmBaseDmChiTiet
        Get
            If _FormChiTiet Is Nothing Then
                _FormChiTiet = New frmOpecDanhMucKhachHang_ChiTiet()
            End If
            Return _FormChiTiet
        End Get
        Set(ByVal value As FrmBaseDmChiTiet)
            _FormChiTiet = value
        End Set
    End Property

    Private _DataSource As Object
    Public Property DataSource() As IList(Of DmKhang)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmKhang))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Tiêu d? form

        Title = "Danh mục khách hàng"

        'truyen para frm
        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)

        'Filter default by LoaiKhang, Nothing return All
        Dim LoaiKhang = -1
        If (lst_para.Count > 0) Then
            If (String.IsNullOrEmpty(lst_para(0).PARAMVALUE)) Then
                LoaiKhang = -1
            Else
                Decimal.TryParse(lst_para(0).PARAMVALUE, LoaiKhang)
            End If
        End If
        Select Case (LoaiKhang)
            Case 1
                Title = "Khách hàng"
            Case 2
                Title = "Nhà cung cấp"
        End Select
        Me.Title = Title

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _GridView

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        'ParentKeyName = "KhangIdCha"
        _GridView.Columns("KyHieu").Caption = String.Format("Mã {0}", Title)
        _GridView.Columns("TenKhang").Caption = String.Format("Tên {0}", Title)

        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaKhang", "Mã khách hàng", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", String.Format("Mã {0}", Title), 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenKhang", String.Format("Tên {0}", Title), 0, True, ""))
        'SearchHelperColumnDefine.Add(New ColumnInfo("MaSoThue", "Mã số thuế", 0, True, ""))
        'SearchHelperColumnDefine.Add(New ColumnInfo("SoTaikhoan", "Số tài khoản", 0, True, ""))
        'SearchHelperColumnDefine.Add(New ColumnInfo("TenLoaikhang", "Loại khách hàng", 0, True, ""))

        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))
        CtlPagerControl.display = New PagerControl.DisplayResult(AddressOf Loading)
        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
        btExport.GRID_VIEW = _GridView
    End Sub

    Public Overrides Sub Loading()
        'truyen para frm
        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)

        'Filter default by LoaiKhang, Nothing return All
        Dim LoaiKhang = -1
        If (lst_para.Count > 0) Then
            If (String.IsNullOrEmpty(lst_para(0).PARAMVALUE)) Then
                LoaiKhang = -1
            Else
                Decimal.TryParse(lst_para(0).PARAMVALUE, LoaiKhang)
            End If
        End If

        _FormChiTiet.Parameter = LoaiKhang
        DataSource = DmKhangService.GetAllByDonviId(Generals.DON_VI.Id, LoaiKhang)
        CtlPagerControl.RefreshPage()
        TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)
        'Dim tree As TreeList = TryCast(Viewer, TreeList)
        'tree.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        'TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
        'TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
    End Sub
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Private Function"

#End Region

#Region "Events"
    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPri.Click
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_KHACHHANG")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            Dim NewObj As Object = FormChiTiet.GetEditObject()
            DoRefressData(FormGlobals.DataInputState.AddMode, Nothing, NewObj)
            Me.KeyValue = obj
        End If
    End Sub

    Public Overrides Sub DoModify()
        If Me.KeyValue Is Nothing Then
            NotifyNoSelectRecord()
            Return
        End If
        Dim OldObj As Object = GetObjectValue()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.EditMode)
        If obj IsNot Nothing Then
            Dim NewObj As Object = FormChiTiet.GetEditObject()
            DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, NewObj)
            Me.KeyValue = obj
        End If
    End Sub

    Public Overrides Sub DoRefressData(ByVal _mode As FormGlobals.DataInputState, ByVal OldObj As Object, ByVal NewObj As Object)
        frmProgress.Instance().Thread = AddressOf Me.Loading
        frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE)
        Select Case _mode
            Case DataInputState.AddMode
                'DataSource.Add(NewObj)
            Case DataInputState.EditMode
                'Dim list As List(Of DmKhang) = New List(Of DmKhang)
                'list.AddRange(DataSource)
                'list.Remove(OldObj)
                'list.Add(NewObj)
                'DataSource = list
            Case DataInputState.Delete
                'Dim list As List(Of DmKhang) = New List(Of DmKhang)
                'list.AddRange(DataSource)
                'list.Remove(OldObj)
                'DataSource = list

        End Select
        TNCommon.BindData4Refresh(Viewer, DataSource)
    End Sub
    Public Overloads Overrides Sub Deleting()
        Try
            DmKhangService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

End Class
