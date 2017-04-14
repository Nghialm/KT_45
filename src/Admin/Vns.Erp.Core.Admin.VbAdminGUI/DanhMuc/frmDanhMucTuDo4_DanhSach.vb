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

Partial Public Class frmDanhMucTuDo4_DanhSach
    Inherits FrmBaseDmDanhSach


#Region "Variables and Messages"
    Dim _DmTudo4Service As IDmTudo4Service
    Public Property DmTudo4Service() As IDmTudo4Service
        Get
            Return _DmTudo4Service
        End Get
        Set(ByVal value As IDmTudo4Service)
            _DmTudo4Service = value
        End Set
    End Property

    'Private _FormChiTiet As BaseDmChiTiet(Of DmTudo4, Guid)
    'Public Overrides Property FormChiTiet() As BaseDmChiTiet(Of DmTudo4, Guid)
    '    Get
    '        If _FormChiTiet Is Nothing Then
    '            _FormChiTiet = New frmDanhMucTuDo4_ChiTiet()
    '        End If
    '        Return _FormChiTiet
    '    End Get
    '    Set(ByVal value As BaseDmChiTiet(Of DmTudo4, Guid))
    '        _FormChiTiet = value
    '    End Set
    'End Property

    Private _DataSource As IList(Of DmTudo4)
    Public Property DataSource() As IList(Of DmTudo4)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmTudo4))
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
        'Tiêu d? form
        Title = "Danh mục tự do 4"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _TreeList

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        ParentKeyName = "DmTudo4IdCha"

        'Ð?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenDmTudo4", "Tên", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng ", 80, True, ""))

        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m 
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenDmTudo4", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))

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
            DataSource = _DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id)
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

#Region "Events"
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Try
        '    Dim data As New DataTable
        '    data = CType(DataSource, DataTable)
        '    Dim i_n As New frmInDanhMuc(data, "DM_TUDO3")
        '    i_n.ShowDialog()
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub
#End Region
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmTudo4Service.GetById(obj)
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
            'Dim NewObj As Object = DmTudo4Service.GetById(obj)
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
            DmTudo4Service.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

End Class
