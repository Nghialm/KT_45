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
Imports Vns.Erp.Core.Controls.Commons

Partial Public Class frmDanhMucHopDong_DanhSach
    Inherits FrmBaseDmDanhSach
    Dim _DmHopdongService As IDmHopdongService
    Public Property DmHopdongService() As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
        End Set
    End Property

    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục hợp đồng"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _TreeList

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        ParentKeyName = "HopdongIdCha"

        'Ð?i tu?ng BO tuong ?ng v?i form
        'BO = DmHopdongService

        'Ð?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenHopdong", "Tên hợp đồng", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenLoaiHopdong", "Tên loại hợp đồng", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("LoaiHopdong", "Loại hợp đồng", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))

        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenHopdong", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenLoaiHopdong", "Tên loại hợp đồng", 0, True, ""))


        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
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

    'Private _FormChiTiet As BaseDanhMucChiTiet

    'Public Overrides Property FormChiTiet() As BaseDanhMucChiTiet
    '    Get
    '        If _FormChiTiet Is Nothing Then
    '            _FormChiTiet = New frmDanhMucHopDong_ChiTiet()
    '        End If
    '        Return _FormChiTiet
    '    End Get
    '    Set(ByVal value As BaseDanhMucChiTiet)
    '        _FormChiTiet = value
    '    End Set
    'End Property
    '
#Region "Modify here"
    Public Overrides Sub Loading()
        Try
            DataSource = DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id)
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            Dim tree As TreeList = TryCast(Viewer, TreeList)
            tree.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
            FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Do not modify"
    Private _DataSource As IList(Of DmHopdong)
    Public Property DataSource() As IList(Of DmHopdong)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmHopdong))
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
            'Dim i_n As New frmInDanhMuc(data, "DmHopdong")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucHopDong_DanhSach_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'InitProperty()
            'CommonInit()
            'Me.InitSearchEvent()
            TNCommon.setIconControl(Me)

            'GridHelper.FormatGridView(_GridView:=)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Sub New()
        InitComponent()
    End Sub
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmHopdongService.GetById(obj)
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
            'Dim NewObj As Object = DmHopdongService.GetById(obj)
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
            DmHopdongService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region
End Class
