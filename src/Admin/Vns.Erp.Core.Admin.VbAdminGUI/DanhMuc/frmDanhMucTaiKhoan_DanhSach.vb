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

Imports DevExpress.XtraGrid
Imports DevExpress.XtraTreeList.Columns
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
'Imports Vns.Erp.Core.Common.Controls


Partial Public Class frmDanhMucTaiKhoan_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"
    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Overridable Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Private _FormChiTiet As FrmBaseDmChiTiet
    Public Overrides Property FormChiTiet() As FrmBaseDmChiTiet
        Get
            If _FormChiTiet Is Nothing Then
                _FormChiTiet = New frmDanhMucTaiKhoan_ChiTiet()
            End If
            Return _FormChiTiet
        End Get
        Set(ByVal value As FrmBaseDmChiTiet)
            _FormChiTiet = value
        End Set
    End Property

    Private _DataSource As IList(Of DmTaikhoan)
    Public Property DataSource() As IList(Of DmTaikhoan)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmTaikhoan))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục tài khoản"

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _TreeList

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        ParentKeyName = "TaikhoanIdCha"

        'Ð?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TinhChat", "Tính chất", 30, True, ""))
        'ViewerColumnDefine.Add(new ColumnInfo("TK_NB", "Tài kho?n ngoài b?ng", 0, true, ""));
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 30, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Cap", "Level", 100, False, ""))

        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))

        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))
        'CtPagerControl.display = New PagerControl.DisplayResult(AddressOf Loading)

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete
    End Sub

    Public Overrides Sub Loading()
        Try
            DataSource = DmTaikhoanService().GetAllByDonviID(Generals.DON_VI.Id)
            'CtPagerControl.RefreshPage()
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            Dim obj As TreeList = TryCast(Viewer, TreeList)
            obj.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
            Dim dr As DataRow
            Dim dtTinhChat As DataTable = New DataTable()
            dtTinhChat.Columns.Add("Id", GetType(String)) '
            dtTinhChat.Columns.Add("Ten", GetType(String))
            dr = dtTinhChat.NewRow()
            dr("ID") = "N"
            dr("Ten") = "Nợ"
            dtTinhChat.Rows.Add(dr)
            dr = dtTinhChat.NewRow()
            dr("ID") = "C"
            dr("Ten") = "Có"
            dtTinhChat.Rows.Add(dr)
            dr = dtTinhChat.NewRow()
            dr("ID") = "L"
            dr("Ten") = "Lưỡng tính"
            dtTinhChat.Rows.Add(dr)

            obj.Columns("TinhChat").ColumnEdit = TNCommon.LookupEdit_ColumnEdit(dtTinhChat, "Ten", "ID")
            SearchHelper.Properties.ValueMember = KeyName

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
            SetFormat()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Private Function"
    Private Sub SetFormat()
        Dim cols As TreeListColumnCollection = _TreeList.Columns
        Dim colLevel As TreeListColumn = cols("Cap")
        colLevel.OptionsColumn.AllowEdit = True
        colLevel.OptionsColumn.ReadOnly = False
        colLevel.Visible = True

        Dim f1 As StyleFormatConditions.StyleFormatCondition = _TreeList.FormatConditions(0)
        f1.Condition = FormatConditionEnum.Equal
        f1.Value1 = "0"
        f1.ApplyToRow = True
        Dim f2 As StyleFormatConditions.StyleFormatCondition = _TreeList.FormatConditions(1)
        f2.Condition = FormatConditionEnum.Equal
        f2.Value1 = "1"
        f2.ApplyToRow = True
        f1.Column = colLevel
        f2.Column = colLevel
        colLevel.Visible = False
    End Sub
#End Region

#Region "Events"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Try
        '    Dim data As New DataTable
        '    data = CType(DataSource, DataTable)
        '    'Dim i_n As New frmInDanhMuc(data, "DM_TAIKHOAN")
        '    'i_n.ShowDialog()
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub
#End Region

#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            Dim objDmTk As DmTaikhoan = TryCast(obj, DmTaikhoan)
            'Dim NewObj As Object = DmTaikhoanService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.AddMode, Nothing, obj)
            Me.KeyValue = obj
            _TreeList.FocusedNode = _TreeList.FindNodeByKeyID(objDmTk.Id)
        End If
    End Sub

    Public Overrides Sub DoModify()
        Dim value As Object = KeyValue
        If Me.KeyValue Is Nothing Then
            NotifyNoSelectRecord()
            Return
        End If
        Dim OldObj As Object = GetObjectValue()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.EditMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmTaikhoanService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, obj)
            Me.KeyValue = obj
        End If
        _TreeList.FocusedNode = _TreeList.FindNodeByKeyID(value)
    End Sub

    Public Overrides Sub DoRefressData(ByVal _mode As FormGlobals.DataInputState, ByVal OldObj As Object, ByVal NewObj As Object)
        frmProgress.Instance().Thread = AddressOf Me.Loading
        frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE)
        'Select Case _mode
        '    Case DataInputState.AddMode
        '        'DataSource.Add(NewObj)
        '    Case DataInputState.EditMode
        '        'DataSource.Remove(OldObj)
        '        'DataSource.Add(NewObj)
        '    Case DataInputState.Delete
        '        DataSource.Remove(OldObj)
        'End Select
        TNCommon.BindData4Refresh(Viewer, DataSource)
    End Sub
    Public Overloads Overrides Sub Deleting()
        Try
            DmTaikhoanService.DeleteById(KeyValue)

            Dim parentId As Guid = DirectCast(GetObjectValue(), DmTaikhoan).TaikhoanIdCha
            Dim lstTK As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
            lstTK.AddRange(_DmTaikhoanService.GetAllByParentID(parentId))
            If lstTK.Count > 0 Then
                _DmTaikhoanService.SetChiTietTKCha(parentId, 0)
            Else
                _DmTaikhoanService.SetChiTietTKCha(parentId, 1)
            End If

            AfterDeleteSuccess()
        Catch ex As System.Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class
