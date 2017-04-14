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


Partial Public Class frmDanhMucPhongBan_DanhSach
    Inherits FrmBaseDmDanhSach


#Region "Variables and Messages"
    Private _DmPhongbanService As IDmPhongbanService
    Public Property DmPhongbanService() As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
        End Set
    End Property

    'Private _FormChiTiet As BaseDmChiTiet(Of DmPhongban, Guid)
    'Public Overrides Property FormChiTiet() As BaseDmChiTiet(Of DmPhongban, Guid)
    '    Get

    '        Return _FormChiTiet
    '    End Get
    '    Set(ByVal value As BaseDmChiTiet(Of DmPhongban, Guid))
    '        _FormChiTiet = value
    '    End Set
    'End Property

    Private _DataSource As Object
    Public Property DataSource() As IList(Of DmPhongban)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmPhongban))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục phòng ban/bộ phận"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _TreeList

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        ParentKeyName = "PhongbanIdCha"

        'Đ?i tu?ng BO tuong ?ng v?i form
        'BO = DM_PhongbanBO.Instance()

        'Đ?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        'ViewerColumnDefine.Add(New ColumnInfo("MA_PHONGBAN", "Mă phòng ban", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Mã phòng ban", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenPhongban", "Tên phòng ban", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DiaChi", "Địa chỉ", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m 
        SearchHelperColumnDefine = New ArrayList()
        'SearchHelperColumnDefine.Add(New ColumnInfo("MA_PHONGBAN", "Mă phòng ban", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Mã phòng ban", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenPhongban", "Tên phòng ban", 0, True, ""))

        '
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 20, True, ""))

        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

    Public Overrides Sub Loading()
        Try
            DataSource = DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id)
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            Dim tree As TreeList = TryCast(Viewer, TreeList)
            tree.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, False, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Private Function"

#End Region

#Region "Events"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_PHONGBAN")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Do not modify"
    
   
#End Region

#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmPhongbanService.GetById(obj)
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
            'Dim NewObj As Object = DmPhongbanService.GetById(obj)
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
            DmPhongbanService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region
   
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
