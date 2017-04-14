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
Imports DevExpress.XtraGrid
Imports DevExpress.XtraTreeList.Columns
Imports Vns.Erp.Core
Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service.Interface

Partial Public Class frmDanhMucGiuongDV_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"

    Private _DataSource As Object
    Public Property DataSource() As IList(Of SpaDmGuongdv)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of SpaDmGuongdv))
            _DataSource = value
        End Set
    End Property

    Private _SpaDmGuongdvService As ISpaDmGuongdvService
    Public Property SpaDmGuongdvService() As ISpaDmGuongdvService
        Get
            Return _SpaDmGuongdvService
        End Get
        Set(ByVal value As ISpaDmGuongdvService)
            _SpaDmGuongdvService = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục giường dịch vụ"

        'Ki?u hi?n th? là TreeList ho?c GridView
        KeyName = "Id"
        'ParentKeyName = "DonviIdCha"
        Viewer = _GridView

        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("Ma", "Mã giường DV", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Kyhieu", "Kí hiệu", 130, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Ten", "Tên giường DV", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Mota", "Mô tả", 200, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 100, True, ""))

        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("Ma", "Mã", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("Kyhieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("Ten", "Tên", 0, True, ""))

        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))


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
            DataSource = _SpaDmGuongdvService.GetAllByDonviID(Generals.DON_VI.Id)
            TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)
            '_GridView.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
            FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName

            'TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, true);
            'TNCommon.BindData_GridLookUp(SearchHelper, DataSource, ((ColumnInfo)SearchHelperColumnDefine[0]).FieldName, KeyName, SearchHelperColumnDefine, true,false);
            'TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, true,true);
            'FieldChooser.EditValue  = ((ColumnInfo)SearchHelperColumnDefine[0]).FieldName;

        Catch ex As Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Events"
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
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
            _SpaDmGuongdvService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region
End Class
