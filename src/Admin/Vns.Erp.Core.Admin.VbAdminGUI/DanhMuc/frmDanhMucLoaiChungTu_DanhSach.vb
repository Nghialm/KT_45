Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraGrid
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraTreeList
Imports Vns.Erp.Core.Common.Controls

Partial Public Class frmDanhMucLoaiChungTu_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Property"
    Dim _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService() As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property

    Dim _FormChiTiet As FrmBaseDmChiTiet
    Public Overrides Property FormChiTiet() As FrmBaseDmChiTiet
        Get
            Return _FormChiTiet
        End Get
        Set(ByVal value As FrmBaseDmChiTiet)
            _FormChiTiet = value
        End Set
    End Property

    Private _DataSource As IList(Of HtLoaichungtu)
    Public Property DataSource() As IList(Of HtLoaichungtu)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of HtLoaichungtu))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Load Form"
    'Kh?i t?o các thu?c tính
    Public Overrides Sub InitProperty()
        Title = "Danh mục loại chứng từ"
        Viewer = _TreeList
        KeyName = "Id"
        ParentKeyName = "LoaiCtIdCha"

        'Ð?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenLoaiCt", "Tên loại chứng từ", 250, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MaTkNoLq", "GH định khoản tài khoản nợ", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MaTkCoLq", "GH định khoản tài khoản có", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MauSoCt", "Mẫu số chứng từ", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("SdTkThueNgamdinh", "Sử dụng tài khoản thuế ngầm định", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TkThueNgamdinh", "Tài khoản thuế nhâm định", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmPtqt", "Danh mục PTQT", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmPhongban", "Danh mục phòng ban", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmTudo1", "Danh mục tu do 1", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmTudo2", "Danh mục tu do 2", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmTudo3", "Danh mục tu do 3", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmTudo4", "Danh mục tu do 4", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmTudo5", "Danh mục tu do 5", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmVuviec", "Danh mục vụ việc", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmKhoanphi", "Danh mục khoản phí", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmHopdong", "Danh mục hợp đồng", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmKhang", "Danh mục khách hàng", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DmCbnv", "Danh mục CBNV", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 250, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Cap", "Level", 100, False, ""))

        ''Them button
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        ''Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenLoaiCt", "Tên loại chứng từ", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MaLoaiCt", "Mã loại chứng từ", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MaSoCt", "Mẫu số chứng từ", 0, True, ""))

        ''Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))


        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

    Public Overrides Sub Loading()
        'Try
        DataSource = HtLoaichungtuService.GetByDonvi(Generals.DON_VI.Id)

        TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
        Dim tree As TreeList = TryCast(Viewer, TreeList)
        tree.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("SdTkThueNgamdinh").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmPtqt").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmPhongban").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmTudo1").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmTudo2").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmTudo3").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmTudo4").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmTudo5").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmVuviec").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmKhoanphi").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmHopdong").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmKhang").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        tree.Columns("DmCbnv").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
        TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
        FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName
        SetFormat()
        'Catch ex As Exception
        '    TNCommon.NotifyError(ex)
        'End Try
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
        f1.Value1 = "8"
        f1.ApplyToRow = True
        Dim f2 As StyleFormatConditions.StyleFormatCondition = _TreeList.FormatConditions(1)
        f2.Condition = FormatConditionEnum.Equal
        f2.Value1 = "9"
        f2.ApplyToRow = True

        _TreeList.BeginUnboundLoad()
        For Each gpNode As TreeListNode In _TreeList.Nodes
            gpNode.SetValue(0, 8)
            For Each pNode As TreeListNode In gpNode.Nodes
                pNode.SetValue(0, 9)
            Next
        Next
        _TreeList.EndUnboundLoad()

        f1.Column = colLevel
        f2.Column = colLevel
        colLevel.Visible = False
    End Sub
#End Region

#Region "Events"

#End Region

#Region "Override"
    Public Overrides Sub DoExport()
        Try
            frmProgress.Instance.Thread = AddressOf xuatxml
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub xuatxml()
        Dim ds As New DataSet
        ds.Tables.Add(Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_DataSource))

        Dim ofd As New SaveFileDialog()
        ofd.Filter = "XML file|*.xml"
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ds.WriteXml(ofd.FileName)
        End If
    End Sub

    Public Overrides Sub DoImport()
        Try
            frmProgress.Instance.Thread = AddressOf nhapxml
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub nhapxml()
        Dim lst_dm_loaichungtu As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
        Dim ds As New DataSet
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "XML file|*.xml"
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ds.ReadXml(ofd.FileName)
            Dim dt_Import As New DataTable
            dt_Import = ds.Tables(0)
            lst_dm_loaichungtu = New List(Of HtLoaichungtu)
            For Each dr As DataRow In dt_Import.Rows
                Dim obj As New HtLoaichungtu
                obj = CType(Object_GetDataRaw(obj, dr), HtLoaichungtu)
                lst_dm_loaichungtu.Add(obj)
            Next

            _HtLoaichungtuService.ImportList(lst_dm_loaichungtu, Generals.DonviID)
        End If
    End Sub

    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = HtLoaichungtuService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.AddMode, Nothing, obj)
            'Me.KeyValue = obj
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
            'Dim NewObj As Object = HtLoaichungtuService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, obj)
            Me.KeyValue = obj
        End If
    End Sub

    Public Overrides Sub DoRefressData(ByVal _mode As FormGlobals.DataInputState, ByVal OldObj As Object, ByVal NewObj As Object)
        'frmProgress.Instance().Thread = AddressOf Me.Loading
        'frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE)
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
            HtLoaichungtuService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
