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

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Partial Public Class frmDanhMucLyDoTGTSCD_DanhSach
    Inherits FrmBaseDmDanhSach
    Private _DmLydoTgTscdService As IDmLydoTgTscdService

    Public Property DmLydoTgTscdService() As IDmLydoTgTscdService
        Get
            Return _DmLydoTgTscdService
        End Get
        Set(ByVal value As IDmLydoTgTscdService)
            _DmLydoTgTscdService = value
        End Set
    End Property
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục lý do tăng giảm tài sản cố định"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _GridView

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        'ParentKeyName = "DM_TUDO_2_ID_CHA";

        'Đ?i tu?ng BO tuong ?ng v?i form
        'BO = DmLydoTgTscdService

        'Đ?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("MaLydoTgTscd", "Mă lý do TG", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenLydoTgTscd", "Tên lý do TG", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("LoaiLg", "Loại", 0, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("GIA_TRI", "Giá trị", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))


        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaLydoTgTscd", "Mã", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("True", "Tên lý do", 0, True, ""))


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
    Public Overrides Sub Loading()
        'Try
        DataSource = DmLydoTgTscdService.GetAllByDonviID(Generals.DON_VI.Id)
        TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)

        Dim obj As GridView = TryCast(Viewer, GridView)
        obj.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

        Dim dr As DataRow
        Dim dtLoaiTG As DataTable = New DataTable()
        dtLoaiTG.Columns.Add("ID", GetType(String))
        dtLoaiTG.Columns.Add("Ten", GetType(String))
        dr = dtLoaiTG.NewRow()
        dr("ID") = 1
        dr("Ten") = "Tăng TSCD"
        dtLoaiTG.Rows.Add(dr)
        dr = dtLoaiTG.NewRow()
        dr("ID") = 2
        dr("Ten") = "Điều chỉnh tăng TSCD"
        dtLoaiTG.Rows.Add(dr)
        dr = dtLoaiTG.NewRow()
        dr("ID") = 3
        dr("Ten") = "Điều chỉnh giảm TSCD"
        dtLoaiTG.Rows.Add(dr)
        dr = dtLoaiTG.NewRow()
        dr("ID") = 4
        dr("Ten") = "Giảm TSCD"
        dtLoaiTG.Rows.Add(dr)

        dr = dtLoaiTG.NewRow()
        dr("ID") = 5
        dr("Ten") = "Thay đổi thông tin"
        dtLoaiTG.Rows.Add(dr)

        obj.Columns("LoaiLg").ColumnEdit = TNCommon.LookupEdit_ColumnEdit(dtLoaiTG, "Ten", "ID")

        TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
        TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, False, True)
        'Catch ex As Exception
        '    TNCommon.NotifyError(ex)
        'End Try
    End Sub

#Region "Do not modify"
    Private _DataSource As Object

    Public Property DataSource() As IList(Of DmLydoTgTscd)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmLydoTgTscd))
            _DataSource = value
        End Set
    End Property

    Public Overrides Sub InitComponent()
        InitializeComponent()
    End Sub
#End Region

    Private Sub btnPri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_LYDO_TG_TSCD")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucLyDoTGTSCD_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            'Dim NewObj As Object = DmLydoTgTscdService.GetById(obj)
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
            'Dim NewObj As Object = DmLydoTgTscdService.GetById(obj)
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
            DmLydoTgTscdService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region
End Class
