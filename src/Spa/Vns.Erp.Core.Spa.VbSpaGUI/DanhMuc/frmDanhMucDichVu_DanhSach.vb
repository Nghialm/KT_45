Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Collections
Imports DevExpress.XtraTreeList
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service.Interface


Partial Public Class frmDanhMucDichVu_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"
    Dim _SpaDmDichVuService As ISpaDmDichVuService
    Public Property SpaDmDichVuService() As ISpaDmDichVuService
        Get
            Return _SpaDmDichVuService
        End Get
        Set(ByVal value As ISpaDmDichVuService)
            _SpaDmDichVuService = value
        End Set
    End Property

    Private _DataSource As Object
    Public Property DataSource() As IList(Of SpaDmDichVu)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of SpaDmDichVu))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        Title = "Danh mục dịch vụ"
        Viewer = _TreeList

        KeyName = "Id"
        ParentKeyName = "DichvuIdCha"

        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("Ma", "Mã dịch vụ", 130, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Kyhieu", "Ký hiệu", 130, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Ten", "Tên dịch vụ", 250, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DonGia", "Đơn giá", 120, True, "n0"))

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("Ten", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("Ma", "Mã dịch vụ", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("Kyhieu", "Ký hiệu", 0, True, ""))

        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper


    End Sub
#End Region

#Region "Modify here"
    Public Overrides Sub Loading()
        'Try
        DataSource = _SpaDmDichVuService.GetAllByDonviID(Generals.DON_VI.Id)
        TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)

        TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
        TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
        'Catch ex As Exception
        '    TNCommon.NotifyError(ex)
        'End Try

    End Sub
#End Region

#Region "Private Function"

#End Region

#Region "Events"
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
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
                DataSource.Remove(OldObj)
                DataSource.Add(NewObj)
            Case DataInputState.Delete
                DataSource.Remove(OldObj)
        End Select
        TNCommon.BindData4Refresh(Viewer, DataSource)
    End Sub
    Public Overloads Overrides Sub Deleting()
        Try
            _SpaDmDichVuService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region
End Class
