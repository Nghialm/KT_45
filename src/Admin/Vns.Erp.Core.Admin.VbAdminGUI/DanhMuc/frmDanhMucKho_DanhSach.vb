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
Imports DevExpress.XtraGrid.Views.Grid
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Partial Public Class frmDanhMucKho_DanhSach
    Inherits FrmBaseDmDanhSach
    Private _DmKhoService As IDmKhoService

    Public Property DmKhoService() As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property

    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục kho"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _GridView

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        'ParentKeyName = "DM_TUDO_2_ID_CHA";

        'Đ?i tu?ng BO tuong ?ng v?i form
        'BO = DmKhoService

        'Đ?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ' ViewerColumnDefine.Add(New ColumnInfo("MA_KHO", "Mă kho", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Mã kho", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenKho", "Tên", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DiaChi", "Địa chỉ", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("XuatAm", "Xuất âm", 80, True, ""))


        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenKho", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("DiaChi", "Địa chỉ", 0, True, ""))


        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))

        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete
        'ButtonSearch = btnSearch
        'ButtonView = btnView
        'Pagger = _Pagger

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

    'Private _FormChiTiet As BaseDanhMucChiTiet(Of DmKho, Guid)

    'Public Overrides Property FormChiTiet() As BaseDanhMucChiTiet(Of DmKho, Guid)
    '    Get
    '        If _FormChiTiet Is Nothing Then
    '            _FormChiTiet = New frmDanhMucKho_ChiTiet()
    '        End If
    '        Return _FormChiTiet
    '    End Get
    '    Set(ByVal value As BaseDanhMucChiTiet)
    '        _FormChiTiet = value
    '    End Set
    'End Property
    '
    Public Overrides Sub Loading()
        Try
            DataSource = DmKhoService.GetAllByDonviID(Generals.DON_VI.Id)

            TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)
            Dim obj As GridView = TryCast(Viewer, GridView)
            obj.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
            obj.Columns("XuatAm").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, False, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

#Region "Do not modify"
    Private _DataSource As IList(Of DmKho)
    Public Property DataSource() As IList(Of DmKho)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmKho))
            _DataSource = value
        End Set
    End Property

    Public Overrides Sub InitComponent()
        InitializeComponent()
    End Sub
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
            'Dim i_n As New frmInDanhMuc(data, "DM_KHO")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    'Private Sub frmDanhMucKho_DanhSach_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Try
    '        CommonInit()
    '    Catch ex As Exception
    '        Message_Error(ex)
    '    End Try
    'End Sub

    Public Sub New()
        InitComponent()
        InitProperty()
        'DoLoadData()
        'Me.InitSearchEvent()
        TNCommon.setIconControl(Me)
    End Sub
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmKhoService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.AddMode, Nothing, obj)
            'Me.KeyValue = obj
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
            'Dim NewObj As Object = DmKhoService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, obj)
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
                'DataSource.Remove(OldObj)
                'DataSource.Add(NewObj)
            Case DataInputState.Delete
                'DataSource.Remove(OldObj)
        End Select
        TNCommon.BindData4Refresh(Viewer, DataSource)
    End Sub
    Public Overloads Overrides Sub Deleting()
        Try
            DmKhoService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dt As DataTable = NPOIExcelHelper.ReadDicFile("d:\kho.xls")
    End Sub
End Class
