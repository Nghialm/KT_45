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



Partial Public Class frmDanhMucNgoaiTe_DanhSach
    Inherits FrmBaseDmDanhSach
    Dim _DmNgoaiteService As IDmNgoaiteService

    Public Property DmNgoaiteService() As IDmNgoaiteService
        Get
            Return _DmNgoaiteService
        End Get
        Set(value As IDmNgoaiteService)
            _DmNgoaiteService = value
        End Set
    End Property
    'Kh?i t?o các thu?c tính
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục ngoại tệ"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _GridView

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        'ParentKeyName = "DM_TUDO_2_ID_CHA";

        'Đ?i tu?ng BO tuong ?ng v?i form
        'BO = DmNgoaiteService()

        'Đ?nh nghia các c?t c?a lu?i hi?n th?
        'ViewerColumnDefine = New ArrayList()
        ''ViewerColumnDefine.Add(New ColumnInfo("MA_NTE", "Mã ngoại tệ", 0, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("TenNte", "Tên ngoại tệ", 0, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("TY_GIA", "Tỷ giá", 0, True, ""))
        ' ViewerColumnDefine.Add(new ColumnInfo("CO_SU_DUNG",             "Có sử dụng",   0, true, ""));

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))

        'Đ?nh nghia danh sách truờng cho phép t́m ki?m t́m ki?m
        SearchHelperColumnDefine = New ArrayList()
        'SearchHelperColumnDefine.Add(New ColumnInfo("MA_NTE", "Mã ngoại tệ", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenNte", "Tên ngoại tệ", 0, True, ""))

        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

    'Private _FormChiTiet As BaseDanhMucChiTiet

    'Public Overrides Property FormChiTiet() As BaseDanhMucChiTiet
    '    Get
    '        If _FormChiTiet Is Nothing Then
    '            _FormChiTiet = New frmDanhMucNgoaiTe_ChiTiet()
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
            DataSource = DmNgoaiteService().GetAll()
            TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)
            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
            FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName

        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

#Region "Do not modify"
    Private _DataSource As IList(Of DmNgoaite)

    Public Property DataSource() As IList(Of DmNgoaite)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmNgoaite))
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

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_NGOAITE")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    Private Sub frmDanhMucNgoaiTe_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitComponent()
        InitProperty()
        CommonInit()
    End Sub

#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmNgoaiteService.GetById(obj)
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
            'Dim NewObj As Object = DmNgoaiteService.GetById(obj)
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
            DmNgoaiteService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region
End Class
