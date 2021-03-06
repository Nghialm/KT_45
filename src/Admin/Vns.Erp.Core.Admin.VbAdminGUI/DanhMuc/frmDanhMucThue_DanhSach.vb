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
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Partial Public Class frmDanhMucThue_DanhSach
    Inherits FrmBaseDmDanhSach
    Dim _DmThueService As IDmThueService

    Public Property DmThueService() As IDmThueService
        Get
            Return _DmThueService
        End Get
        Set(value As IDmThueService)
            _DmThueService = value
        End Set
    End Property
    'Kh?i t?o các thu?c tính
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục thuế"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _TreeList

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        ParentKeyName = "ThueIdCha"

        'Đ?i tu?ng BO tuong ?ng v?i form
        'BO = DM_ThueBO.Instance()

        'Đ?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("MaThue", "Mã thuế", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Ký hiệu", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenThue", "Tên thuế", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TyLe", "Tỷ lệ", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("XuatKhau", "Xuất khẩu", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaThue", "Mã thuế", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenThue", "Tên thuế", 0, True, ""))

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))

        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

    '
#Region "Modify here"
    Public Overrides Sub Loading()
        Try
            DataSource = DmThueService.GetAll()
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            Dim obj As TreeList = TryCast(Viewer, TreeList)
            obj.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
            _TreeList.Columns("XuatKhau").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
            FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Do not modify"
    Private _DataSource As Object

    Public Property DataSource() As IList(Of DmThue)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmThue))
            _DataSource = value
        End Set
    End Property

    Public Overrides Sub InitComponent()
        InitializeComponent()
    End Sub
#End Region

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_THUE")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    'Private Sub frmDanhMucThue_DanhSach_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Try
    '        InitProperty()
    '        CommonInit()
    '        TNCommon.setIconControl(Me)
    '    Catch ex As Exception
    '        Message_Error(ex)
    '    End Try
    'End Sub

    Public Sub New()
        InitComponent()
    End Sub
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmThueService.GetById(obj)
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
            'Dim NewObj As Object = DmThueService.GetById(obj)
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
            DmThueService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    '    Try
    '        If Message_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?") Then
    '            Deleting()

    '            Loading()
    '        End If
    '    Catch ex As Exception
    '        Message_Error(ex)
    '    End Try
    'End Sub
End Class
