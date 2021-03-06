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

Partial Public Class frmDanhMucPhuongThucQuanTri_DanhSach
    Inherits FrmBaseDmDanhSach
    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Dim _DmPtqtService As IDmPtqtService
    Public Property DmPtqtService() As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(value As IDmPtqtService)
            _DmPtqtService = value
        End Set
    End Property
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục phương thức quản trị"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _TreeList

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        ParentKeyName = "PtqtIdCha"

        'Đ?i tu?ng BO tuong ?ng v?i form
        'BO = DmPtqtService


        'Đ?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Ký hiệu", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenPtqt", "Tên phương thức quản trị", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MaTk", "Mã tài khoản liên quan", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 0, True, ""))

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        SearchHelperColumnDefine = New ArrayList()
        'SearchHelperColumnDefine.Add(new ColumnInfo("MA_PTQT", "Ma~ phuong thu´c qua?n tri?", 0, true, ""));
        SearchHelperColumnDefine.Add(New ColumnInfo("TenPtqt", "Tên phương thức quản trị", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Ký hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MaTk", "Mã tài khoản liên quan", 0, True, ""))



        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))

        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        'ButtonDelete = btnDelete

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

#Region "Modify here"
    Public Overrides Sub Loading()
        Try
            'Dim lstPTQT As List(Of DM_PtqtInfo) = DM_PtqtBO.Instance.GetObjectAllByDonviID(Generals.DON_VI.DONVI_ID.Replace("-", ""))
            DataSource = DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id)
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            Dim tree As TreeList = TryCast(Viewer, TreeList)
            tree.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Do not modify"
    Private _DataSource As Object
    Public Property DataSource() As IList(Of DmPtqt)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmPtqt))
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
            'Dim i_n As New frmInDanhMuc(data, "DM_PTQT")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    Private Sub frmDanhMucPhuongThucQuanTri_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InitComponent()
            InitProperty()
            CommonInit()
            'Me.InitSearchEvent()
            TNCommon.setIconControl(Me)
            'Dim view As DataView = CType(DataSource, DataTable).DefaultView
            'view.Sort = "LoaiLg"
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmPtqtService.GetById(obj)
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
            'Dim NewObj As Object = DmPtqtService.GetById(obj)
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
            DmPtqtService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Message_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?") Then
                Deleting()

                Loading()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
