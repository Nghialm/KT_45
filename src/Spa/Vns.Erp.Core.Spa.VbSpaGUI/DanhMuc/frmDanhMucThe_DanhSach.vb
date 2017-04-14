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
Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service.Interface
Imports DevExpress.Utils

Partial Public Class frmDanhMucThe_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"
    Private _DataSource As Object
    Public Property DataSource() As IList(Of SpaDmThe)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of SpaDmThe))
            _DataSource = value
        End Set
    End Property

    Private _SpaDmTheService As ISpaDmTheService
    Public Property SpaDmTheService() As ISpaDmTheService
        Get
            Return _SpaDmTheService
        End Get
        Set(ByVal value As ISpaDmTheService)
            _SpaDmTheService = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục thẻ dịch vụ"
        Viewer = _GridView
        'Ki?u hi?n th? là TreeList ho?c GridView
        KeyName = "Id"
        'ParentKeyName = "DonviIdCha"

        'ViewerColumnDefine = New ArrayList()
        'ViewerColumnDefine.Add(New ColumnInfo("Ma", "Mã thẻ", 150, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Kyhieu", "Kí hiệu", 130, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Ten", "Tên thẻ", 200, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Menhgia", "Mệnh giá", 100, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Giatien", "Giá tiền", 100, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Ngayphathanh", "Ngày phát hành", 100, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Tenkhachhang", "Tên khách hàng", 100, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Diachi", "Địa chỉ", 100, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("Sodienthoai", "Số điện thoại", 100, True, ""))
        'ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 200, True, ""))

        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("Ma", "Mã thẻ", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("Kyhieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("Ten", "Tên thẻ", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("Tenkhachhang", "Tên khách hàng", 0, True, ""))
        'FormatColumnGrid(ViewerColumnDefine)


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

    Private Sub FormatColumnGrid(ByVal arr As ArrayList)
        For i As Integer = 0 To arr.Count - 1
            If Viewer.Columns(i).FieldName = "Menhgia" Or Viewer.Columns(i).FieldName = "Giatien" Then
                Viewer.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
                Viewer.Columns(i).DisplayFormat.FormatString = "n0"
            End If

            If Viewer.Columns(i).FieldName = "Ngayphathanh" Then
                Viewer.Columns(i).DisplayFormat.FormatType = FormatType.DateTime
                Viewer.Columns(i).DisplayFormat.FormatString = "dd/MM/yyyy"
            End If
        Next
    End Sub

    Public Overrides Sub Loading()
        Try
            DataSource = _SpaDmTheService.GetAll()
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

    Private Sub btnLichSuThe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLichSu.Click
        Try
            Dim obj As SpaDmThe = CType(_GridView.GetRow(_GridView.FocusedRowHandle), SpaDmThe)
            If obj IsNot Nothing Then
                Dim frm As frmLSThe = CType(ObjectFactory.GetObject("frmLSThe", obj.Id), frmLSThe)
                frm.ShowInTaskbar = False
                'frm.TheId = obj.Id
                frm.StartPosition = FormStartPosition.CenterParent
                frm.ShowDialog()
            End If
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
            _SpaDmTheService.DeleteWithHis(VnsConvert.CGuid(KeyValue))
            '_SpaDmTheService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region
End Class
