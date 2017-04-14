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
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core

Partial Public Class frmDanhMucDonVi_DanhSach
    Inherits FrmBaseDmDanhSach
    Private _DmDonviService As IDmDonviService
    Public Property DmDonviService() As IDmDonviService

        Get
            Return _DmDonviService
        End Get
        Set(ByVal value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property


#Region "Variables and Messages"
    Private _DataSource As IList(Of DmDonvi)
    Public Property DataSource() As IList(Of DmDonvi)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmDonvi))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        Title = "Danh mục đơn vị"

        Viewer = _TreeList

        KeyName = "Id"
        ParentKeyName = "DonviIdCha"

        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("TenDonvi", "Tên", 250, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 130, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DiaChi", "Ðịa chỉ", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("QuanHuyen", "Quận huyện", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TinhTp", "Tỉnh TP", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DienThoai", "Điện thoại", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("FAX", "FAX", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("EMAIL", "EMAIL", 200, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("SoTaikhoanNh", "Số TK NN", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenNganhang", "Tên NN", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("DiaChiNh", "Ðịa chỉ NN", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MaSoThue", "Mã số thuế", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("NguoiLapBieu", "Người lập biểu", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("ThuQuy", "Thủ quỹ", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KtTruong", "Kế toán trưởng", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("GiamDoc", "Giám đốc", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Cap", "Level", 100, False, ""))

        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenDonvi", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("DiaChi", "Ðịa chỉ", 0, True, ""))

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
            Dim startDate As DateTime = DateTime.Now
            DataSource = DmDonviService.GetAll()
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
            Dim endDate As DateTime = DateTime.Now
            Console.WriteLine("Get ALL:" + (endDate.Subtract(startDate)).ToString())

            startDate = DateTime.Now

            FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName
            SetFormat()
            endDate = DateTime.Now

            Console.WriteLine("SetFormat:" + (endDate.Subtract(startDate)).ToString())

            btExport.GRID_VIEW = _TreeList
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

        _TreeList.BeginUnboundLoad()
        For Each gpNode As TreeListNode In _TreeList.Nodes
            gpNode.SetValue(0, gpNode.Level.ToString)
            For Each pNode As TreeListNode In gpNode.Nodes
                pNode.SetValue(0, pNode.Level.ToString)
            Next
        Next
        _TreeList.EndUnboundLoad()

        f1.Column = colLevel
        f2.Column = colLevel
        colLevel.Visible = False
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
#End Region
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmDonviService.GetById(obj)
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
            'Dim NewObj As Object = DmDonviService.GetById(obj)
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
            DmDonviService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

End Class
