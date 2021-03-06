'*************************************************************************
'	Modifile:	7:9:2011   14:35
'	File base:	frmDanhMucKhoanPhi_DanhSach
'	File ext:	vb
'	By:			Pham Xuan Duy
'	Email:		duypx@trinam.com.vn
'	Mobile:		01239 589 689
'	Company:	TRI NAM TDI., JSC 2009 | All rights reserved 
'	Purpose:	
'*************************************************************************
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections
Imports DevExpress.XtraEditors.Repository
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Partial Public Class frmDanhMucKhoanPhi_DanhSach
    Inherits FrmBaseDmDanhSach
    Private _BO As IDmKhoanphiService

    Public Property DmKhoanphiService() As IDmKhoanphiService
        Get
            Return _BO
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _BO = value
        End Set
    End Property
    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property


    'khởi tạo các thuộc tính
    Public Overrides Sub InitProperty()
        'Tiêu đề form
        Title = "Danh mục khoản phí"

        'Kiểu hiển thị là TreeList hoặc GridView
        Viewer = _TreeList

        'Áp dụng với  TreeList
        KeyName = "Id"
        ParentKeyName = "DmKhoanphiIdCha"
        'Ðối tượng BO tương ứng với form
        'BO = DmKhoanphiService()

        'Ðịnh nghĩa các cột cảu lưới hiển thị
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenDmKhoanphi", "Tên", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))

        'Ðịnh nghĩa danh sách các trường cho phép tìm kiếm
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenDmKhoanphi", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))

        '
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 20, True, ""))

        '----------------------------------------------
        'ButtonSearch = btnSearch
        'ButtonView = btnView
        'Pagger = _Pagger

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        'Button = btnClose

        'InitData()
    End Sub

    'Private _FormChiTiet As BaseDanhMucChiTiet(Of DmKhoanphi, Guid)
    'Public Overrides Property FormChiTiet() As BaseDanhMucChiTiet(Of DmKhoanphi, Guid)
    '    Get
    '        Return _FormChiTiet
    '    End Get
    '    Set(ByVal _FormChiTiet As BaseDanhMucChiTiet(Of DmKhoanphi, Guid))

    '    End Set
    'End Property
    Public Overrides Sub DoLoadData()
        DataSource = DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id)
        'Dim dt As DataTable = DM_PtqtBO.Instance.GetAllByDonviID(Generals.DON_VI.ID.Replace("-", "")).Tables(0)
        'DataSource = dt
        TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
        Dim tree As TreeList = TryCast(Viewer, TreeList)
        tree.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
        TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, False, True)
    End Sub
    Public Overrides Sub Loading()
        Try
            DataSource = DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id)
            'Dim dt As DataTable = DM_PtqtBO.Instance.GetAllByDonviID(Generals.DON_VI.ID.Replace("-", "")).Tables(0)
            'DataSource = dt
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            Dim tree As TreeList = TryCast(Viewer, TreeList)
            tree.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, False, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub
#Region "Do not modify"
    Private _DataSource As Object
    Public Property DataSource() As Object
        Get
            Return _DataSource
        End Get
        Set(ByVal value As Object)
            _DataSource = value
        End Set
    End Property

    Public Overrides Sub InitComponent()
        InitializeComponent()
    End Sub
    Public Sub New()
        InitComponent()
        InitProperty()
        'DoLoadData()
        'Me.InitSearchEvent()
        TNCommon.setIconControl(Me)
    End Sub
    'Public Sub New()
    '    InitComponent()
    '    'Generals.DON_VI.ID = System.Guid.Empty.ToString().Replace("-", "")
    '    'Generals.DON_VI.MA_DONVI = "0000"
    'End Sub
#End Region

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPri_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPri.Click
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_KHOANPHI")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmKhoanphiService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.AddMode, Nothing, obj)
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
            'Dim NewObj As Object = DmKhoanphiService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, obj)
            Me.KeyValue = obj
        End If
    End Sub

    Public Overrides Sub DoRefressData(ByVal _mode As FormGlobals.DataInputState, ByVal OldObj As Object, ByVal NewObj As Object)
        frmProgress.Instance().Thread = AddressOf Me.Loading
        frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE)
        'Select Case _mode
        '    Case DataInputState.AddMode
        '        'DataSource.Add(NewObj)
        '    Case DataInputState.EditMode
        '        DataSource.Remove(OldObj)
        '        DataSource.Add(NewObj)
        '    Case DataInputState.Delete
        '        DataSource.Remove(OldObj)
        'End Select
        TNCommon.BindData4Refresh(Viewer, DataSource)
    End Sub
    Public Overloads Overrides Sub Deleting()
        Try
            DmKhoanphiService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If _TreeList.Nodes.Count = 0 Then
                Message_Warning("Không có bản ghi nào được chọn")
                Return
            End If
            If Message_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?") Then
                Deleting()
                Loading()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
