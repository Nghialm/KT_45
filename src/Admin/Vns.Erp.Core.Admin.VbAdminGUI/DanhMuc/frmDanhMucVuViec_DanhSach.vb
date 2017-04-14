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



Partial Public Class frmDanhMucVuViec_DanhSach
    Inherits FrmBaseDmDanhSach
    Dim _DmVuviecService As IDmVuviecService

    Public Property DmVuviecService() As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property

    Dim _DmTaikhoanService As IDmTaikhoanService

    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục vụ việc"

        Viewer = _GridView

        KeyName = "Id"
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("MaVuviec", "Mã vụ việc", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "kí hiệu", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenVuviec", "Tên vụ việc", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MaTkLienquan", "Mã tài khoản liên quan", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))


        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaVuviec", "Mã vụ việc", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenVuviec", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))

        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))

        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete
        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

    Public Overrides Sub Loading()
        Try
            DataSource = DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)

            TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)
            Dim obj As GridView = TryCast(Viewer, GridView)
            obj.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#Region "Do not modify"
    Private _DataSource As IList(Of DmVuviec)

    Public Property DataSource() As IList(Of DmVuviec)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmVuviec))
            _DataSource = value
        End Set
    End Property

    Public Overrides Sub InitComponent()
        InitializeComponent()
    End Sub
#End Region

    Public Sub New()
        InitComponent()
    End Sub

#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmVuviecService.GetById(obj)
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
            'Dim NewObj As Object = DmVuviecService.GetById(obj)
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
            DmVuviecService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class
