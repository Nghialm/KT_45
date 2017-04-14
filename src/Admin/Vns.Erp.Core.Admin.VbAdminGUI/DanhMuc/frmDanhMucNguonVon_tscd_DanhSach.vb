'*************************************************************************
'	Created:	2011/09/01
'	Created:	1:9:2011   14:59
'	File base:	frmDanhMucNguonVon_tscd_DanhSach
'	File ext:	vb
'	Author:		Pham Xuan Duy
'	Email:		duypx@trinam.com.vn
'	Mobile:		01239 589 689
'	Company:	TRI NAM TDI., JSC 2009 | All rights reserved 
'	Purpose:	
'*************************************************************************
#Region "Imports"

Imports System.Collections.Generic
Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Data
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

#End Region


Public Class frmDanhMucNguonVon_tscd_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Varibales"
    Private _FormChiTiet As frmDanhMucNguonVon_tscd_ChiTiet

    'Public Property FormChiTiet() As frmDanhMucNguonVon_tscd_ChiTiet
    '    Get
    '        Return _FormChiTiet
    '    End Get
    '    Set(ByVal value As frmDanhMucNguonVon_tscd_ChiTiet)
    '        _FormChiTiet = value
    '    End Set
    'End Property

    Dim DMNVTSCD As Guid
    Dim _DmNguonTscdService As IDmNguonTscdService
    Public Property DmNguonTscdService() As IDmNguonTscdService
        Get
            Return _DmNguonTscdService
        End Get
        Set(ByVal value As IDmNguonTscdService)
            _DmNguonTscdService = value
        End Set
    End Property
#End Region

#Region "Overrides Functions and Property"
    'Private lstobj_nvtscd As List(Of DmNguonTscd) = New List(Of DmNguonTscd)
    Private _DataSource As IList(Of DmNguonTscd)

    Public Property DataSource() As IList(Of DmNguonTscd)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmNguonTscd))
            _DataSource = value
        End Set
    End Property

    Public Overrides Sub InitComponent()
    End Sub
    Public Overrides Sub InitProperty()
        Title = "Danh mục nguồn vốn TSCD"
        Viewer = _GridView
        KeyName = "Id"

        Dim SearchHelperColumnDefine As ArrayList = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaDmNguonTscd", "Mã nguồn", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenDmNguonTscd", "Tên nguồn", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Ký hiệu nguồn", 0, True, ""))

        Dim arr As ArrayList = New ArrayList()
        arr.Add(New ColumnInfo("Display", "Tìm kiếm theo", 0, True, ""))
        Dim tbl_TK As New DataTable
        tbl_TK.Columns.Add("Value")
        tbl_TK.Columns.Add("Display")

        tbl_TK.Rows.Add("TenDmNguonTscd", "Mã nguồn")
        tbl_TK.Rows.Add("TenDmNguonTscd", "Tên nguồn")
        tbl_TK.Rows.Add("KyHieu", "Ký hiệu")
        TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, True)


        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub
    Public Overrides Sub Loading()
        Dim dt_NHOM As IList(Of DmNguonTscd) = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id)
        TNCommon.BindData_GridLookUp(_SearchHelper, dt_NHOM, "MaDmNguonTscd", "MaDmNguonTscd", SearchHelperColumnDefine, True)
        LoadGrid()
    End Sub
#End Region

#Region "Functions"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub Grid_SetFocus(ByVal _Key As String)
        Dim lst As List(Of DmNguonTscd) = CType(_GridView.DataSource, List(Of DmNguonTscd))
        For i As Integer = 0 To lst.Count - 1
            If lst(i).Id.ToString.Equals(_Key) Then
                _GridView.FocusedRowHandle = i
            End If
        Next
    End Sub

    Private Sub BindataCBO()
        Dim dt_NHOM As IList(Of DmNguonTscd) = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id)
        ''Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        Dim SearchHelperColumnDefine As ArrayList = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaDmNguonTscd", "Mã nguồn", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenDmNguonTscd", "Tên nguồn", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Ký hiệu nguồn", 0, True, ""))
        TNCommon.BindData_GridLookUp(_SearchHelper, dt_NHOM, "MaDmNguonTscd", "MaDmNguonTscd", SearchHelperColumnDefine, True)

        Dim arr As ArrayList = New ArrayList()
        arr.Add(New ColumnInfo("Display", "Tìm kiếm theo", 0, True, ""))
        Dim tbl_TK As New DataTable
        tbl_TK.Columns.Add("Value")
        tbl_TK.Columns.Add("Display")

        tbl_TK.Rows.Add("TenDmNguonTscd", "Mã nguồn")
        tbl_TK.Rows.Add("TenDmNguonTscd", "Tên nguồn")
        tbl_TK.Rows.Add("KyHieu", "Ký hiệu")
        TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, True)

    End Sub

    Private Sub LoadGrid()
        'Dim lstNguonVonTSCD As List(Of DmNguonTscd) = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id)
        Me.DataSource = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id)
        _GridControl.DataSource = DataSource
        _GridView.Columns("ChoPhepSua").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
    End Sub

    Private Sub LoadGRV(ByVal DM_NGUON_TSCD_ID As String)
        'Dim lstobjdmnv_tscd As List(Of DmNguonTscd) = DmNguonTscdService.GetAllByDonviID(New Guid(DM_NGUON_TSCD_ID))
        Me.DataSource = DmNguonTscdService.GetAllByDonviID(New Guid(DM_NGUON_TSCD_ID))
        _GridControl.DataSource = DataSource
    End Sub

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (_GridView.GetSelectedRows().Length > 0) Then
            If (_GridView.RowCount <> 0) Then
                Dim griNV As DmNguonTscd = CType(_GridView.GetRow(_GridView.GetSelectedRows(0)), DmNguonTscd)
                DMNVTSCD = griNV.Id
                Return True
            End If
        End If
        Return False
    End Function
#End Region

#Region "Events"

    'Private Sub frmDanhMucNguonVon_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        InitComponent()
    '        InitProperty()
    '        CommonInit()
    '        'An nut in
    '        btnPri.Visible = False
    '    Catch ex As Exception
    '        Message_Error(ex)
    '    End Try
    'End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If (_GridView.RowCount <> 0) Then
                Dim gridcth As DmNguonTscd = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmNguonTscd)
                If Not (gridcth Is Nothing) Then
                    DMNVTSCD = gridcth.Id
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _FieldChooser_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _FieldChooser.EditValueChanged
        Try
            If DB_GetString(_FieldChooser.EditValue) <> "" Then
                _SearchHelper.Properties.DisplayMember = _FieldChooser.EditValue.ToString()
                _SearchHelper.Focus()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _SearchHelper_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SearchHelper.EditValueChanged
        Try
            If DB_GetString(_SearchHelper.EditValue) <> "" Then
                Grid_SetFocus(_SearchHelper.EditValue.ToString)
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
            'Dim NewObj As Object = DmNguonTscdService.GetById(obj)
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
            'Dim NewObj As Object = DmNguonTscdService.GetById(obj)
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
            DmNguonTscdService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

End Class
